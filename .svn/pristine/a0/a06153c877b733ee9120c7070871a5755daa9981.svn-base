
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:19 PM
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
	' Encapsulates the 'Color' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Color))> _
	<XmlType("Color")> _	
	Partial Public Class Color 
		Inherits esColor
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Color()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal colorID As System.Int32)
			Dim obj As New Color()
			obj.ColorID = colorID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal colorID As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Color()
			obj.ColorID = colorID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ColorCollection")> _
	Partial Public Class ColorCollection
		Inherits esColorCollection
		Implements IEnumerable(Of Color)
	
		Public Function FindByPrimaryKey(ByVal colorID As System.Int32) As Color
			Return MyBase.SingleOrDefault(Function(e) e.ColorID.HasValue AndAlso e.ColorID.Value = colorID)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Color))> _
		Public Class ColorCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ColorCollection)
			
			Public Shared Widening Operator CType(packet As ColorCollectionWCFPacket) As ColorCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ColorCollection) As ColorCollectionWCFPacket
				Return New ColorCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ColorQuery 
		Inherits esColorQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ColorQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ColorQuery) As String
			Return ColorQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ColorQuery
			Return DirectCast(ColorQuery.SerializeHelper.FromXml(query, GetType(ColorQuery)), ColorQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esColor
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal colorID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(colorID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(colorID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal colorID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(colorID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(colorID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal colorID As System.Int32) As Boolean
		
			Dim query As New ColorQuery()
			query.Where(query.ColorID = colorID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal colorID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("ColorID", colorID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Color.ColorID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ColorID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ColorMetadata.ColumnNames.ColorID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ColorMetadata.ColumnNames.ColorID, value) Then
					OnPropertyChanged(ColorMetadata.PropertyNames.ColorID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Color.Color
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Color As System.String
			Get
				Return MyBase.GetSystemString(ColorMetadata.ColumnNames.Color)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ColorMetadata.ColumnNames.Color, value) Then
					OnPropertyChanged(ColorMetadata.PropertyNames.Color)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Color.Hex
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hex As System.String
			Get
				Return MyBase.GetSystemString(ColorMetadata.ColumnNames.Hex)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ColorMetadata.ColumnNames.Hex, value) Then
					OnPropertyChanged(ColorMetadata.PropertyNames.Hex)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Color.R
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property R As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ColorMetadata.ColumnNames.R)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ColorMetadata.ColumnNames.R, value) Then
					OnPropertyChanged(ColorMetadata.PropertyNames.R)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Color.G
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property G As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ColorMetadata.ColumnNames.G)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ColorMetadata.ColumnNames.G, value) Then
					OnPropertyChanged(ColorMetadata.PropertyNames.G)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Color.B
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property B As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ColorMetadata.ColumnNames.B)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ColorMetadata.ColumnNames.B, value) Then
					OnPropertyChanged(ColorMetadata.PropertyNames.B)
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
												
						Case "ColorID"
							Me.str().ColorID = CType(value, string)
												
						Case "Color"
							Me.str().Color = CType(value, string)
												
						Case "Hex"
							Me.str().Hex = CType(value, string)
												
						Case "R"
							Me.str().R = CType(value, string)
												
						Case "G"
							Me.str().G = CType(value, string)
												
						Case "B"
							Me.str().B = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "ColorID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ColorID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ColorMetadata.PropertyNames.ColorID)
							End If
						
						Case "R"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.R = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ColorMetadata.PropertyNames.R)
							End If
						
						Case "G"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.G = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ColorMetadata.PropertyNames.G)
							End If
						
						Case "B"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.B = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ColorMetadata.PropertyNames.B)
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
		
			Public Sub New(ByVal entity As esColor)
				Me.entity = entity
			End Sub				
		
	
			Public Property ColorID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ColorID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ColorID = Nothing
					Else
						entity.ColorID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Color As System.String 
				Get
					Dim data_ As System.String = entity.Color
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Color = Nothing
					Else
						entity.Color = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hex As System.String 
				Get
					Dim data_ As System.String = entity.Hex
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hex = Nothing
					Else
						entity.Hex = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property R As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.R
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.R = Nothing
					Else
						entity.R = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property G As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.G
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.G = Nothing
					Else
						entity.G = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property B As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.B
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.B = Nothing
					Else
						entity.B = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esColor
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ColorMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ColorQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ColorQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ColorQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ColorQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ColorQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esColorCollection
		Inherits esEntityCollection(Of Color)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ColorMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ColorCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ColorQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ColorQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ColorQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ColorQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ColorQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ColorQuery))
		End Sub
		
		#End Region
						
		Private m_query As ColorQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esColorQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ColorMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "ColorID" 
					Return Me.ColorID
				Case "Color" 
					Return Me.Color
				Case "Hex" 
					Return Me.Hex
				Case "R" 
					Return Me.R
				Case "G" 
					Return Me.G
				Case "B" 
					Return Me.B
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property ColorID As esQueryItem
			Get
				Return New esQueryItem(Me, ColorMetadata.ColumnNames.ColorID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Color As esQueryItem
			Get
				Return New esQueryItem(Me, ColorMetadata.ColumnNames.Color, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hex As esQueryItem
			Get
				Return New esQueryItem(Me, ColorMetadata.ColumnNames.Hex, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property R As esQueryItem
			Get
				Return New esQueryItem(Me, ColorMetadata.ColumnNames.R, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property G As esQueryItem
			Get
				Return New esQueryItem(Me, ColorMetadata.ColumnNames.G, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property B As esQueryItem
			Get
				Return New esQueryItem(Me, ColorMetadata.ColumnNames.B, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ColorMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ColorMetadata.ColumnNames.ColorID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ColorMetadata.PropertyNames.ColorID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ColorMetadata.ColumnNames.Color, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ColorMetadata.PropertyNames.Color
			c.CharacterMaxLength = 15
			m_columns.Add(c)
				
			c = New esColumnMetadata(ColorMetadata.ColumnNames.Hex, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ColorMetadata.PropertyNames.Hex
			c.CharacterMaxLength = 7
			m_columns.Add(c)
				
			c = New esColumnMetadata(ColorMetadata.ColumnNames.R, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ColorMetadata.PropertyNames.R
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ColorMetadata.ColumnNames.G, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ColorMetadata.PropertyNames.G
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ColorMetadata.ColumnNames.B, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ColorMetadata.PropertyNames.B
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ColorMetadata
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
			 Public Const ColorID As String = "ColorID"
			 Public Const Color As String = "Color"
			 Public Const Hex As String = "Hex"
			 Public Const R As String = "R"
			 Public Const G As String = "G"
			 Public Const B As String = "B"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const ColorID As String = "ColorID"
			 Public Const Color As String = "Color"
			 Public Const Hex As String = "Hex"
			 Public Const R As String = "R"
			 Public Const G As String = "G"
			 Public Const B As String = "B"
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
			SyncLock GetType(ColorMetadata)
			
				If ColorMetadata.mapDelegates Is Nothing Then
					ColorMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ColorMetadata._meta Is Nothing Then
					ColorMetadata._meta = New ColorMetadata()
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
				


				meta.AddTypeMap("ColorID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Color", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hex", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("R", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("G", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("B", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "Color"
				meta.Destination = "Color"
				
				meta.spInsert = "proc_ColorInsert"
				meta.spUpdate = "proc_ColorUpdate"
				meta.spDelete = "proc_ColorDelete"
				meta.spLoadAll = "proc_ColorLoadAll"
				meta.spLoadByPrimaryKey = "proc_ColorLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ColorMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
