
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/1/2013 11:42:21 AM
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
	' Encapsulates the 'viewCCTranslationPrimaryRec' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCTranslationPrimaryRec))> _
	<XmlType("ViewCCTranslationPrimaryRec")> _	
	Partial Public Class ViewCCTranslationPrimaryRec 
		Inherits esViewCCTranslationPrimaryRec
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCTranslationPrimaryRec()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCTranslationPrimaryRecCollection")> _
	Partial Public Class ViewCCTranslationPrimaryRecCollection
		Inherits esViewCCTranslationPrimaryRecCollection
		Implements IEnumerable(Of ViewCCTranslationPrimaryRec)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCTranslationPrimaryRec))> _
		Public Class ViewCCTranslationPrimaryRecCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCTranslationPrimaryRecCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCTranslationPrimaryRecCollectionWCFPacket) As ViewCCTranslationPrimaryRecCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCTranslationPrimaryRecCollection) As ViewCCTranslationPrimaryRecCollectionWCFPacket
				Return New ViewCCTranslationPrimaryRecCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCTranslationPrimaryRecQuery 
		Inherits esViewCCTranslationPrimaryRecQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCTranslationPrimaryRecQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCTranslationPrimaryRecQuery) As String
			Return ViewCCTranslationPrimaryRecQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCTranslationPrimaryRecQuery
			Return DirectCast(ViewCCTranslationPrimaryRecQuery.SerializeHelper.FromXml(query, GetType(ViewCCTranslationPrimaryRecQuery)), ViewCCTranslationPrimaryRecQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCTranslationPrimaryRec
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCTranslationPrimaryRec.Id
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCTranslationPrimaryRecMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCTranslationPrimaryRecMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCTranslationPrimaryRec.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCTranslationPrimaryRec.EnglishTranslation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EnglishTranslation As System.String
			Get
				Return MyBase.GetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.EnglishTranslation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.EnglishTranslation, value) Then
					OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.EnglishTranslation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCTranslationPrimaryRec.GermanTranslation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GermanTranslation As System.String
			Get
				Return MyBase.GetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.GermanTranslation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.GermanTranslation, value) Then
					OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.GermanTranslation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCTranslationPrimaryRec.SpanishTranslation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpanishTranslation As System.String
			Get
				Return MyBase.GetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.SpanishTranslation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.SpanishTranslation, value) Then
					OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.SpanishTranslation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCTranslationPrimaryRec.FrenchTranslation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FrenchTranslation As System.String
			Get
				Return MyBase.GetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.FrenchTranslation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.FrenchTranslation, value) Then
					OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.FrenchTranslation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCTranslationPrimaryRec.ItalianTranslation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ItalianTranslation As System.String
			Get
				Return MyBase.GetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.ItalianTranslation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.ItalianTranslation, value) Then
					OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.ItalianTranslation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCTranslationPrimaryRec.PortugueseTranslation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PortugueseTranslation As System.String
			Get
				Return MyBase.GetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.PortugueseTranslation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCTranslationPrimaryRecMetadata.ColumnNames.PortugueseTranslation, value) Then
					OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.PortugueseTranslation)
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
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "EnglishTranslation"
							Me.str().EnglishTranslation = CType(value, string)
												
						Case "GermanTranslation"
							Me.str().GermanTranslation = CType(value, string)
												
						Case "SpanishTranslation"
							Me.str().SpanishTranslation = CType(value, string)
												
						Case "FrenchTranslation"
							Me.str().FrenchTranslation = CType(value, string)
												
						Case "ItalianTranslation"
							Me.str().ItalianTranslation = CType(value, string)
												
						Case "PortugueseTranslation"
							Me.str().PortugueseTranslation = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCTranslationPrimaryRecMetadata.PropertyNames.Id)
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
		
			Public Sub New(ByVal entity As esViewCCTranslationPrimaryRec)
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
		  	
			Public Property Hazard As System.String 
				Get
					Dim data_ As System.String = entity.Hazard
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazard = Nothing
					Else
						entity.Hazard = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EnglishTranslation As System.String 
				Get
					Dim data_ As System.String = entity.EnglishTranslation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EnglishTranslation = Nothing
					Else
						entity.EnglishTranslation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GermanTranslation As System.String 
				Get
					Dim data_ As System.String = entity.GermanTranslation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GermanTranslation = Nothing
					Else
						entity.GermanTranslation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpanishTranslation As System.String 
				Get
					Dim data_ As System.String = entity.SpanishTranslation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpanishTranslation = Nothing
					Else
						entity.SpanishTranslation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FrenchTranslation As System.String 
				Get
					Dim data_ As System.String = entity.FrenchTranslation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FrenchTranslation = Nothing
					Else
						entity.FrenchTranslation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ItalianTranslation As System.String 
				Get
					Dim data_ As System.String = entity.ItalianTranslation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItalianTranslation = Nothing
					Else
						entity.ItalianTranslation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PortugueseTranslation As System.String 
				Get
					Dim data_ As System.String = entity.PortugueseTranslation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PortugueseTranslation = Nothing
					Else
						entity.PortugueseTranslation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCTranslationPrimaryRec
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCTranslationPrimaryRecMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCTranslationPrimaryRecQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCTranslationPrimaryRecQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCTranslationPrimaryRecQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCTranslationPrimaryRecQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCTranslationPrimaryRecQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCTranslationPrimaryRecCollection
		Inherits esEntityCollection(Of ViewCCTranslationPrimaryRec)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCTranslationPrimaryRecMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCTranslationPrimaryRecCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCTranslationPrimaryRecQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCTranslationPrimaryRecQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCTranslationPrimaryRecQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCTranslationPrimaryRecQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCTranslationPrimaryRecQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCTranslationPrimaryRecQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCTranslationPrimaryRecQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCTranslationPrimaryRecQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCTranslationPrimaryRecMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "Hazard" 
					Return Me.Hazard
				Case "EnglishTranslation" 
					Return Me.EnglishTranslation
				Case "GermanTranslation" 
					Return Me.GermanTranslation
				Case "SpanishTranslation" 
					Return Me.SpanishTranslation
				Case "FrenchTranslation" 
					Return Me.FrenchTranslation
				Case "ItalianTranslation" 
					Return Me.ItalianTranslation
				Case "PortugueseTranslation" 
					Return Me.PortugueseTranslation
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCTranslationPrimaryRecMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCTranslationPrimaryRecMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EnglishTranslation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCTranslationPrimaryRecMetadata.ColumnNames.EnglishTranslation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GermanTranslation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCTranslationPrimaryRecMetadata.ColumnNames.GermanTranslation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpanishTranslation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCTranslationPrimaryRecMetadata.ColumnNames.SpanishTranslation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FrenchTranslation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCTranslationPrimaryRecMetadata.ColumnNames.FrenchTranslation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItalianTranslation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCTranslationPrimaryRecMetadata.ColumnNames.ItalianTranslation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PortugueseTranslation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCTranslationPrimaryRecMetadata.ColumnNames.PortugueseTranslation, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCTranslationPrimaryRecMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCTranslationPrimaryRecMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCTranslationPrimaryRecMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCTranslationPrimaryRecMetadata.ColumnNames.Hazard, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCTranslationPrimaryRecMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCTranslationPrimaryRecMetadata.ColumnNames.EnglishTranslation, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCTranslationPrimaryRecMetadata.PropertyNames.EnglishTranslation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCTranslationPrimaryRecMetadata.ColumnNames.GermanTranslation, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCTranslationPrimaryRecMetadata.PropertyNames.GermanTranslation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCTranslationPrimaryRecMetadata.ColumnNames.SpanishTranslation, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCTranslationPrimaryRecMetadata.PropertyNames.SpanishTranslation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCTranslationPrimaryRecMetadata.ColumnNames.FrenchTranslation, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCTranslationPrimaryRecMetadata.PropertyNames.FrenchTranslation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCTranslationPrimaryRecMetadata.ColumnNames.ItalianTranslation, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCTranslationPrimaryRecMetadata.PropertyNames.ItalianTranslation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCTranslationPrimaryRecMetadata.ColumnNames.PortugueseTranslation, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCTranslationPrimaryRecMetadata.PropertyNames.PortugueseTranslation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCTranslationPrimaryRecMetadata
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
			 Public Const Id As String = "Id"
			 Public Const Hazard As String = "Hazard"
			 Public Const EnglishTranslation As String = "EnglishTranslation"
			 Public Const GermanTranslation As String = "GermanTranslation"
			 Public Const SpanishTranslation As String = "SpanishTranslation"
			 Public Const FrenchTranslation As String = "FrenchTranslation"
			 Public Const ItalianTranslation As String = "ItalianTranslation"
			 Public Const PortugueseTranslation As String = "PortugueseTranslation"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const Hazard As String = "Hazard"
			 Public Const EnglishTranslation As String = "EnglishTranslation"
			 Public Const GermanTranslation As String = "GermanTranslation"
			 Public Const SpanishTranslation As String = "SpanishTranslation"
			 Public Const FrenchTranslation As String = "FrenchTranslation"
			 Public Const ItalianTranslation As String = "ItalianTranslation"
			 Public Const PortugueseTranslation As String = "PortugueseTranslation"
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
			SyncLock GetType(ViewCCTranslationPrimaryRecMetadata)
			
				If ViewCCTranslationPrimaryRecMetadata.mapDelegates Is Nothing Then
					ViewCCTranslationPrimaryRecMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCTranslationPrimaryRecMetadata._meta Is Nothing Then
					ViewCCTranslationPrimaryRecMetadata._meta = New ViewCCTranslationPrimaryRecMetadata()
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
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EnglishTranslation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("GermanTranslation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SpanishTranslation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FrenchTranslation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ItalianTranslation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PortugueseTranslation", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCTranslationPrimaryRec"
				meta.Destination = "viewCCTranslationPrimaryRec"
				
				meta.spInsert = "proc_viewCCTranslationPrimaryRecInsert"
				meta.spUpdate = "proc_viewCCTranslationPrimaryRecUpdate"
				meta.spDelete = "proc_viewCCTranslationPrimaryRecDelete"
				meta.spLoadAll = "proc_viewCCTranslationPrimaryRecLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCTranslationPrimaryRecLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCTranslationPrimaryRecMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
