
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/16/2021 4:22:07 PM
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
	' Encapsulates the 'tblMetaRecType' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaRecType))> _
	<XmlType("TblMetaRecType")> _	
	Partial Public Class TblMetaRecType 
		Inherits esTblMetaRecType
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaRecType()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldId As System.Int32)
			Dim obj As New TblMetaRecType()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaRecType()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("TblMetaRecTypeCollection")> _
	Partial Public Class TblMetaRecTypeCollection
		Inherits esTblMetaRecTypeCollection
		Implements IEnumerable(Of TblMetaRecType)
	
		Public Function FindByPrimaryKey(ByVal fldId As System.Int32) As TblMetaRecType
			Return MyBase.SingleOrDefault(Function(e) e.FldId.HasValue AndAlso e.FldId.Value = fldId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaRecType))> _
		Public Class TblMetaRecTypeCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaRecTypeCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaRecTypeCollectionWCFPacket) As TblMetaRecTypeCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaRecTypeCollection) As TblMetaRecTypeCollectionWCFPacket
				Return New TblMetaRecTypeCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaRecTypeQuery 
		Inherits esTblMetaRecTypeQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaRecTypeQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaRecTypeQuery) As String
			Return TblMetaRecTypeQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaRecTypeQuery
			Return DirectCast(TblMetaRecTypeQuery.SerializeHelper.FromXml(query, GetType(TblMetaRecTypeQuery)), TblMetaRecTypeQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecType
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fldId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fldId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fldId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fldId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fldId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fldId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fldId As System.Int32) As Boolean

			Dim query As New TblMetaRecTypeQuery("a")
			query.Where(query.FldId = fldId)
			Return Me.Load(query)

		End Function

		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fldId As System.Int32) As Boolean

			Dim parms As esParameters = New esParameters()
			parms.Add("FldId", fldId)

			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)

		End Function
#End Region

#Region "Properties"



		' <summary>
		' Maps to tblMetaRecType.fldId
		' </summary>
		<DataMember(EmitDefaultValue:=False)>
		Public Overridable Property FldId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecTypeMetadata.ColumnNames.FldId)
			End Get

			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecTypeMetadata.ColumnNames.FldId, value) Then
					OnPropertyChanged(TblMetaRecTypeMetadata.PropertyNames.FldId)
				End If
			End Set
		End Property

		' <summary>
		' Maps to tblMetaRecType.fldType
		' </summary>
		<DataMember(EmitDefaultValue:=False)>
		Public Overridable Property FldType As System.String
			Get
				Return MyBase.GetSystemString(TblMetaRecTypeMetadata.ColumnNames.FldType)
			End Get

			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaRecTypeMetadata.ColumnNames.FldType, value) Then
					OnPropertyChanged(TblMetaRecTypeMetadata.PropertyNames.FldType)
				End If
			End Set
		End Property

#End Region

#Region ".str() Properties"

		Public Overrides Sub SetProperties(values As IDictionary)

			Dim propertyName As String
			For Each propertyName In values.Keys
				Me.SetProperty(propertyName, values(propertyName))
			Next

		End Sub

		Public Overrides Sub SetProperty(name As String, value As Object)

			Dim col As esColumnMetadata = Me.Meta.Columns.FindByPropertyName(name)
			If Not col Is Nothing Then

				If value Is Nothing OrElse value.GetType().ToString() = "System.String" Then

					' Use the strongly typed property
					Select Case name

						Case "FldId"
							Me.str().FldId = CType(value, String)

						Case "FldType"
							Me.str().FldType = CType(value, String)

					End Select

				Else

					Select Case name

						Case "FldId"

							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecTypeMetadata.PropertyNames.FldId)
							End If


						Case Else

					End Select
				End If

			ElseIf Me.ContainsColumn(name) Then
				Me.SetColumn(name, value)
			Else
				Throw New Exception("SetProperty Error: '" + name + "' not found")
			End If

		End Sub

		Public Function str() As esStrings

			If _esstrings Is Nothing Then
				_esstrings = New esStrings(Me)
			End If
			Return _esstrings

		End Function

		Public NotInheritable Class esStrings

			Public Sub New(ByVal entity As esTblMetaRecType)
				Me.entity = entity
			End Sub


			Public Property FldId As System.String
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldId

					If Not data_.HasValue Then

						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value As System.String)
					If String.IsNullOrEmpty(Value) Then
						entity.FldId = Nothing
					Else
						entity.FldId = Convert.ToInt32(Value)
					End If
				End Set
			End Property

			Public Property FldType As System.String
				Get
					Dim data_ As System.String = entity.FldType

					If data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value As System.String)
					If String.IsNullOrEmpty(Value) Then
						entity.FldType = Nothing
					Else
						entity.FldType = Convert.ToString(Value)
					End If
				End Set
			End Property


			Private entity As esTblMetaRecType
		End Class


		<NonSerialized>
		<IgnoreDataMember>
		Private _esstrings As esStrings

#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecTypeMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaRecTypeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecTypeQuery("a")
					InitQuery(Me.m_query)
				End If

				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecTypeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaRecTypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded

			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

		<IgnoreDataMember>
		Private m_query As TblMetaRecTypeQuery

	End Class



	<Serializable()>
	Partial Public MustInherit Class esTblMetaRecTypeCollection
		Inherits esEntityCollection(Of TblMetaRecType)

#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecTypeMetadata.Meta()
			End Get
		End Property

		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaRecTypeCollection"
		End Function

#End Region

#Region "Query Logic"


		<BrowsableAttribute(False)>
		Public ReadOnly Property Query() As TblMetaRecTypeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecTypeQuery("a")
					InitQuery(Me.m_query)
				End If

				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecTypeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return query.Load()
		End Function

		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaRecTypeQuery("a")
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaRecTypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaRecTypeQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaRecTypeQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaRecTypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaRecTypeMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldId" 
					Return Me.FldId
				Case "FldType" 
					Return Me.FldType
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FldId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecTypeMetadata.ColumnNames.FldId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldType As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecTypeMetadata.ColumnNames.FldType, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaRecType 
		Inherits esTblMetaRecType
		
	
		#Region "TblMetaRecTypePairCollectionByFldPrimaryRecTypeId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_TblMetaRecTypePairCollectionByFldPrimaryRecTypeId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecType.TblMetaRecTypePairCollectionByFldPrimaryRecTypeId_Delegate)
				map.PropertyName = "TblMetaRecTypePairCollectionByFldPrimaryRecTypeId"
				map.MyColumnName = "fldPrimaryRecTypeId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub TblMetaRecTypePairCollectionByFldPrimaryRecTypeId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecTypeQuery(data.NextAlias())
			
			Dim mee As TblMetaRecTypePairQuery = If(data.You IsNot Nothing, TryCast(data.You, TblMetaRecTypePairQuery), New TblMetaRecTypePairQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.FldPrimaryRecTypeId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_tblMetaRecTypePair_fldPrimaryRecTypeId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property TblMetaRecTypePairCollectionByFldPrimaryRecTypeId As TblMetaRecTypePairCollection 
		
			Get
				If Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId Is Nothing Then
					Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId = New TblMetaRecTypePairCollection()
					Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("TblMetaRecTypePairCollectionByFldPrimaryRecTypeId", Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId.Query.Where(Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId.Query.FldPrimaryRecTypeId = Me.FldId)
							Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId.fks.Add(TblMetaRecTypePairMetadata.ColumnNames.FldPrimaryRecTypeId, Me.FldId)
					End If
				End If

				Return Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId
			End Get
			
			Set(ByVal value As TblMetaRecTypePairCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId Is Nothing Then

					Me.RemovePostSave("TblMetaRecTypePairCollectionByFldPrimaryRecTypeId")
					Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _TblMetaRecTypePairCollectionByFldPrimaryRecTypeId As TblMetaRecTypePairCollection
		#End Region

		#Region "TblMetaRecTypePairCollectionByFldSecondaryRecTypeId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_TblMetaRecTypePairCollectionByFldSecondaryRecTypeId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecType.TblMetaRecTypePairCollectionByFldSecondaryRecTypeId_Delegate)
				map.PropertyName = "TblMetaRecTypePairCollectionByFldSecondaryRecTypeId"
				map.MyColumnName = "fldSecondaryRecTypeId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub TblMetaRecTypePairCollectionByFldSecondaryRecTypeId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecTypeQuery(data.NextAlias())
			
			Dim mee As TblMetaRecTypePairQuery = If(data.You IsNot Nothing, TryCast(data.You, TblMetaRecTypePairQuery), New TblMetaRecTypePairQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.FldSecondaryRecTypeId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_tblMetaRecTypePair_fldSecondaryRecTypeId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property TblMetaRecTypePairCollectionByFldSecondaryRecTypeId As TblMetaRecTypePairCollection 
		
			Get
				If Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId Is Nothing Then
					Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId = New TblMetaRecTypePairCollection()
					Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("TblMetaRecTypePairCollectionByFldSecondaryRecTypeId", Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId.Query.Where(Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId.Query.FldSecondaryRecTypeId = Me.FldId)
							Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId.fks.Add(TblMetaRecTypePairMetadata.ColumnNames.FldSecondaryRecTypeId, Me.FldId)
					End If
				End If

				Return Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId
			End Get
			
			Set(ByVal value As TblMetaRecTypePairCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId Is Nothing Then

					Me.RemovePostSave("TblMetaRecTypePairCollectionByFldSecondaryRecTypeId")
					Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _TblMetaRecTypePairCollectionByFldSecondaryRecTypeId As TblMetaRecTypePairCollection
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "TblMetaRecTypePairCollectionByFldPrimaryRecTypeId"
					coll = Me.TblMetaRecTypePairCollectionByFldPrimaryRecTypeId
					Exit Select
				Case "TblMetaRecTypePairCollectionByFldSecondaryRecTypeId"
					coll = Me.TblMetaRecTypePairCollectionByFldSecondaryRecTypeId
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "TblMetaRecTypePairCollectionByFldPrimaryRecTypeId", GetType(TblMetaRecTypePairCollection), New TblMetaRecTypePair()))
			props.Add(new esPropertyDescriptor(Me, "TblMetaRecTypePairCollectionByFldSecondaryRecTypeId", GetType(TblMetaRecTypePairCollection), New TblMetaRecTypePair()))
			Return props
			
		End Function
		
		''' <summary>
		''' Called by ApplyPostSaveKeys 
		''' </summary>
		''' <param name="coll">The collection to enumerate over</param>
		''' <param name="key">"The column name</param>
		''' <param name="value">The column value</param>
		Private Sub Apply(coll As esEntityCollectionBase, key As String, value As Object)
			For Each obj As esEntity In coll
				If obj.es.IsAdded Then
					obj.SetProperty(key, value)
				End If
			Next
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
			If Not Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId Is Nothing Then
				Apply(Me._TblMetaRecTypePairCollectionByFldPrimaryRecTypeId, "FldPrimaryRecTypeId", Me.FldId)
			End If
			
			If Not Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId Is Nothing Then
				Apply(Me._TblMetaRecTypePairCollectionByFldSecondaryRecTypeId, "FldSecondaryRecTypeId", Me.FldId)
			End If
			
		End Sub
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaRecTypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaRecTypeMetadata.ColumnNames.FldId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecTypeMetadata.PropertyNames.FldId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecTypeMetadata.ColumnNames.FldType, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaRecTypeMetadata.PropertyNames.FldType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaRecTypeMetadata
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
			 Public Const FldId As String = "fldId"
			 Public Const FldType As String = "fldType"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldId As String = "FldId"
			 Public Const FldType As String = "FldType"
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
			SyncLock GetType(TblMetaRecTypeMetadata)
			
				If TblMetaRecTypeMetadata.mapDelegates Is Nothing Then
					TblMetaRecTypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaRecTypeMetadata._meta Is Nothing Then
					TblMetaRecTypeMetadata._meta = New TblMetaRecTypeMetadata()
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
				


				meta.AddTypeMap("FldId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldType", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "tblMetaRecType"
				meta.Destination = "tblMetaRecType"
				
				meta.spInsert = "proc_tblMetaRecTypeInsert"
				meta.spUpdate = "proc_tblMetaRecTypeUpdate"
				meta.spDelete = "proc_tblMetaRecTypeDelete"
				meta.spLoadAll = "proc_tblMetaRecTypeLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaRecTypeLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaRecTypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
