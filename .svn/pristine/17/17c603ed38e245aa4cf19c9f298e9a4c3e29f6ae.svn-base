
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/10/2021 12:42:44 PM
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
	' Encapsulates the 'vwMetaRecTypePair' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwMetaRecTypePair))> _
	<XmlType("VwMetaRecTypePair")> _	
	Partial Public Class VwMetaRecTypePair 
		Inherits esVwMetaRecTypePair
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwMetaRecTypePair()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwMetaRecTypePairCollection")> _
	Partial Public Class VwMetaRecTypePairCollection
		Inherits esVwMetaRecTypePairCollection
		Implements IEnumerable(Of VwMetaRecTypePair)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwMetaRecTypePair))> _
		Public Class VwMetaRecTypePairCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwMetaRecTypePairCollection)
			
			Public Shared Widening Operator CType(packet As VwMetaRecTypePairCollectionWCFPacket) As VwMetaRecTypePairCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwMetaRecTypePairCollection) As VwMetaRecTypePairCollectionWCFPacket
				Return New VwMetaRecTypePairCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwMetaRecTypePairQuery 
		Inherits esVwMetaRecTypePairQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwMetaRecTypePairQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwMetaRecTypePairQuery) As String
			Return VwMetaRecTypePairQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwMetaRecTypePairQuery
			Return DirectCast(VwMetaRecTypePairQuery.SerializeHelper.FromXml(query, GetType(VwMetaRecTypePairQuery)), VwMetaRecTypePairQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwMetaRecTypePair
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwMetaRecTypePair.LanguageId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LanguageId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwMetaRecTypePairMetadata.ColumnNames.LanguageId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwMetaRecTypePairMetadata.ColumnNames.LanguageId, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.LanguageId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.PracticeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwMetaRecTypePairMetadata.ColumnNames.PracticeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwMetaRecTypePairMetadata.ColumnNames.PracticeId, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.PracticeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.PracticeName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeName As System.String
			Get
				Return MyBase.GetSystemString(VwMetaRecTypePairMetadata.ColumnNames.PracticeName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwMetaRecTypePairMetadata.ColumnNames.PracticeName, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.PracticeName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.IsImportable
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IsImportable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(VwMetaRecTypePairMetadata.ColumnNames.IsImportable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(VwMetaRecTypePairMetadata.ColumnNames.IsImportable, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.IsImportable)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.PrimaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecTypeId, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.PrimaryRecTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.PrimaryRecTypeDisplayText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecTypeDisplayText As System.String
			Get
				Return MyBase.GetSystemString(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecTypeDisplayText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecTypeDisplayText, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.PrimaryRecTypeDisplayText)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.SecondaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecTypeId, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.SecondaryRecTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwMetaRecTypePair.SecondaryRecTypeDisplayText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecTypeDisplayText As System.String
			Get
				Return MyBase.GetSystemString(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecTypeDisplayText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecTypeDisplayText, value) Then
					OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.SecondaryRecTypeDisplayText)
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
												
						Case "LanguageId"
							Me.str().LanguageId = CType(value, string)
												
						Case "PracticeId"
							Me.str().PracticeId = CType(value, string)
												
						Case "PracticeName"
							Me.str().PracticeName = CType(value, string)
												
						Case "IsImportable"
							Me.str().IsImportable = CType(value, string)
												
						Case "PrimaryRecTypeId"
							Me.str().PrimaryRecTypeId = CType(value, string)
												
						Case "PrimaryRecType"
							Me.str().PrimaryRecType = CType(value, string)
												
						Case "PrimaryRecTypeDisplayText"
							Me.str().PrimaryRecTypeDisplayText = CType(value, string)
												
						Case "SecondaryRecTypeId"
							Me.str().SecondaryRecTypeId = CType(value, string)
												
						Case "SecondaryRecType"
							Me.str().SecondaryRecType = CType(value, string)
												
						Case "SecondaryRecTypeDisplayText"
							Me.str().SecondaryRecTypeDisplayText = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LanguageId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LanguageId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.LanguageId)
							End If
						
						Case "PracticeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PracticeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.PracticeId)
							End If
						
						Case "IsImportable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsImportable = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.IsImportable)
							End If
						
						Case "PrimaryRecTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PrimaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.PrimaryRecTypeId)
							End If
						
						Case "SecondaryRecTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecondaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwMetaRecTypePairMetadata.PropertyNames.SecondaryRecTypeId)
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
		
			Public Sub New(ByVal entity As esVwMetaRecTypePair)
				Me.entity = entity
			End Sub				
		
	
			Public Property LanguageId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LanguageId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LanguageId = Nothing
					Else
						entity.LanguageId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PracticeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PracticeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeId = Nothing
					Else
						entity.PracticeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PracticeName As System.String 
				Get
					Dim data_ As System.String = entity.PracticeName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeName = Nothing
					Else
						entity.PracticeName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsImportable As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IsImportable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsImportable = Nothing
					Else
						entity.IsImportable = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrimaryRecTypeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PrimaryRecTypeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimaryRecTypeId = Nothing
					Else
						entity.PrimaryRecTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrimaryRecType As System.String 
				Get
					Dim data_ As System.String = entity.PrimaryRecType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimaryRecType = Nothing
					Else
						entity.PrimaryRecType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrimaryRecTypeDisplayText As System.String 
				Get
					Dim data_ As System.String = entity.PrimaryRecTypeDisplayText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimaryRecTypeDisplayText = Nothing
					Else
						entity.PrimaryRecTypeDisplayText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecondaryRecTypeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SecondaryRecTypeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecondaryRecTypeId = Nothing
					Else
						entity.SecondaryRecTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecondaryRecType As System.String 
				Get
					Dim data_ As System.String = entity.SecondaryRecType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecondaryRecType = Nothing
					Else
						entity.SecondaryRecType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecondaryRecTypeDisplayText As System.String 
				Get
					Dim data_ As System.String = entity.SecondaryRecTypeDisplayText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecondaryRecTypeDisplayText = Nothing
					Else
						entity.SecondaryRecTypeDisplayText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVwMetaRecTypePair
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwMetaRecTypePairMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwMetaRecTypePairQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwMetaRecTypePairQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwMetaRecTypePairQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwMetaRecTypePairQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwMetaRecTypePairQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwMetaRecTypePairCollection
		Inherits esEntityCollection(Of VwMetaRecTypePair)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwMetaRecTypePairMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwMetaRecTypePairCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwMetaRecTypePairQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwMetaRecTypePairQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwMetaRecTypePairQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwMetaRecTypePairQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwMetaRecTypePairQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwMetaRecTypePairQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwMetaRecTypePairQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwMetaRecTypePairQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwMetaRecTypePairMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "LanguageId" 
					Return Me.LanguageId
				Case "PracticeId" 
					Return Me.PracticeId
				Case "PracticeName" 
					Return Me.PracticeName
				Case "IsImportable" 
					Return Me.IsImportable
				Case "PrimaryRecTypeId" 
					Return Me.PrimaryRecTypeId
				Case "PrimaryRecType" 
					Return Me.PrimaryRecType
				Case "PrimaryRecTypeDisplayText" 
					Return Me.PrimaryRecTypeDisplayText
				Case "SecondaryRecTypeId" 
					Return Me.SecondaryRecTypeId
				Case "SecondaryRecType" 
					Return Me.SecondaryRecType
				Case "SecondaryRecTypeDisplayText" 
					Return Me.SecondaryRecTypeDisplayText
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property LanguageId As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.LanguageId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeId As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.PracticeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeName As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.PracticeName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IsImportable As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.IsImportable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecTypeDisplayText As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecTypeDisplayText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecTypeDisplayText As esQueryItem
			Get
				Return New esQueryItem(Me, VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecTypeDisplayText, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwMetaRecTypePairMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.LanguageId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.LanguageId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.PracticeId, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.PracticeId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.PracticeName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.PracticeName
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.IsImportable, 3, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.IsImportable
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecTypeId, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.PrimaryRecTypeId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecType, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.PrimaryRecTypeDisplayText, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.PrimaryRecTypeDisplayText
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecTypeId, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.SecondaryRecTypeId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecType, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwMetaRecTypePairMetadata.ColumnNames.SecondaryRecTypeDisplayText, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwMetaRecTypePairMetadata.PropertyNames.SecondaryRecTypeDisplayText
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwMetaRecTypePairMetadata
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
			 Public Const LanguageId As String = "LanguageId"
			 Public Const PracticeId As String = "PracticeId"
			 Public Const PracticeName As String = "PracticeName"
			 Public Const IsImportable As String = "IsImportable"
			 Public Const PrimaryRecTypeId As String = "PrimaryRecTypeId"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const PrimaryRecTypeDisplayText As String = "PrimaryRecTypeDisplayText"
			 Public Const SecondaryRecTypeId As String = "SecondaryRecTypeId"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const SecondaryRecTypeDisplayText As String = "SecondaryRecTypeDisplayText"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LanguageId As String = "LanguageId"
			 Public Const PracticeId As String = "PracticeId"
			 Public Const PracticeName As String = "PracticeName"
			 Public Const IsImportable As String = "IsImportable"
			 Public Const PrimaryRecTypeId As String = "PrimaryRecTypeId"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const PrimaryRecTypeDisplayText As String = "PrimaryRecTypeDisplayText"
			 Public Const SecondaryRecTypeId As String = "SecondaryRecTypeId"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const SecondaryRecTypeDisplayText As String = "SecondaryRecTypeDisplayText"
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
			SyncLock GetType(VwMetaRecTypePairMetadata)
			
				If VwMetaRecTypePairMetadata.mapDelegates Is Nothing Then
					VwMetaRecTypePairMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwMetaRecTypePairMetadata._meta Is Nothing Then
					VwMetaRecTypePairMetadata._meta = New VwMetaRecTypePairMetadata()
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
				


				meta.AddTypeMap("LanguageId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PracticeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PracticeName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("IsImportable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("PrimaryRecTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PrimaryRecType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PrimaryRecTypeDisplayText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SecondaryRecTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SecondaryRecType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SecondaryRecTypeDisplayText", new esTypeMap("varchar", "System.String"))			
				meta.Catalog = "cldbConnect"
				meta.Schema = "api"
				 
				meta.Source = "vwMetaRecTypePair"
				meta.Destination = "vwMetaRecTypePair"
				
				meta.spInsert = "proc_vwMetaRecTypePairInsert"
				meta.spUpdate = "proc_vwMetaRecTypePairUpdate"
				meta.spDelete = "proc_vwMetaRecTypePairDelete"
				meta.spLoadAll = "proc_vwMetaRecTypePairLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwMetaRecTypePairLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwMetaRecTypePairMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
