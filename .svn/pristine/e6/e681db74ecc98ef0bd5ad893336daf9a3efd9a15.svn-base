
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/16/2021 2:32:42 PM
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
	' Encapsulates the 'tblMetaRecIntendedAction' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaRecIntendedAction))> _
	<XmlType("TblMetaRecIntendedAction")> _	
	Partial Public Class TblMetaRecIntendedAction 
		Inherits esTblMetaRecIntendedAction
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaRecIntendedAction()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldId As System.Int32)
			Dim obj As New TblMetaRecIntendedAction()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaRecIntendedAction()
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
	<XmlType("TblMetaRecIntendedActionCollection")> _
	Partial Public Class TblMetaRecIntendedActionCollection
		Inherits esTblMetaRecIntendedActionCollection
		Implements IEnumerable(Of TblMetaRecIntendedAction)
	
		Public Function FindByPrimaryKey(ByVal fldId As System.Int32) As TblMetaRecIntendedAction
			Return MyBase.SingleOrDefault(Function(e) e.FldId.HasValue AndAlso e.FldId.Value = fldId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaRecIntendedAction))> _
		Public Class TblMetaRecIntendedActionCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaRecIntendedActionCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaRecIntendedActionCollectionWCFPacket) As TblMetaRecIntendedActionCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaRecIntendedActionCollection) As TblMetaRecIntendedActionCollectionWCFPacket
				Return New TblMetaRecIntendedActionCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaRecIntendedActionQuery 
		Inherits esTblMetaRecIntendedActionQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaRecIntendedActionQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaRecIntendedActionQuery) As String
			Return TblMetaRecIntendedActionQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaRecIntendedActionQuery
			Return DirectCast(TblMetaRecIntendedActionQuery.SerializeHelper.FromXml(query, GetType(TblMetaRecIntendedActionQuery)), TblMetaRecIntendedActionQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecIntendedAction
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

			Dim query As New TblMetaRecIntendedActionQuery("a")
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
		' Maps to tblMetaRecIntendedAction.fldId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecIntendedActionMetadata.ColumnNames.FldId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecIntendedActionMetadata.ColumnNames.FldId, value) Then
					OnPropertyChanged(TblMetaRecIntendedActionMetadata.PropertyNames.FldId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRecIntendedAction.fldAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldAction As System.String
			Get
				Return MyBase.GetSystemString(TblMetaRecIntendedActionMetadata.ColumnNames.FldAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaRecIntendedActionMetadata.ColumnNames.FldAction, value) Then
					OnPropertyChanged(TblMetaRecIntendedActionMetadata.PropertyNames.FldAction)
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
												
						Case "FldId"
							Me.str().FldId = CType(value, string)
												
						Case "FldAction"
							Me.str().FldAction = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FldId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecIntendedActionMetadata.PropertyNames.FldId)
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
		
			Public Sub New(ByVal entity As esTblMetaRecIntendedAction)
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

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldId = Nothing
					Else
						entity.FldId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldAction As System.String 
				Get
					Dim data_ As System.String = entity.FldAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldAction = Nothing
					Else
						entity.FldAction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esTblMetaRecIntendedAction
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecIntendedActionMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaRecIntendedActionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecIntendedActionQuery("a")
					InitQuery(Me.m_query)
				End If

				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecIntendedActionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaRecIntendedActionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblMetaRecIntendedActionQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecIntendedActionCollection
		Inherits esEntityCollection(Of TblMetaRecIntendedAction)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecIntendedActionMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaRecIntendedActionCollection"
		End Function

#End Region

#Region "Query Logic"


		<BrowsableAttribute(False)>
		Public ReadOnly Property Query() As TblMetaRecIntendedActionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecIntendedActionQuery("a")
					InitQuery(Me.m_query)
				End If

				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecIntendedActionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaRecIntendedActionQuery("a")
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaRecIntendedActionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaRecIntendedActionQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaRecIntendedActionQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaRecIntendedActionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaRecIntendedActionMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldId" 
					Return Me.FldId
				Case "FldAction" 
					Return Me.FldAction
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FldId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecIntendedActionMetadata.ColumnNames.FldId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldAction As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecIntendedActionMetadata.ColumnNames.FldAction, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaRecIntendedAction 
		Inherits esTblMetaRecIntendedAction
		
	
		#Region "BMRecommendationsCollectionByIntendedActionId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_BMRecommendationsCollectionByIntendedActionId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecIntendedAction.BMRecommendationsCollectionByIntendedActionId_Delegate)
				map.PropertyName = "BMRecommendationsCollectionByIntendedActionId"
				map.MyColumnName = "IntendedActionId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub BMRecommendationsCollectionByIntendedActionId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecIntendedActionQuery(data.NextAlias())
			
			Dim mee As BMRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, BMRecommendationsQuery), New BMRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.IntendedActionId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_BmRec_IntendedActionId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property BMRecommendationsCollectionByIntendedActionId As BMRecommendationsCollection 
		
			Get
				If Me._BMRecommendationsCollectionByIntendedActionId Is Nothing Then
					Me._BMRecommendationsCollectionByIntendedActionId = New BMRecommendationsCollection()
					Me._BMRecommendationsCollectionByIntendedActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("BMRecommendationsCollectionByIntendedActionId", Me._BMRecommendationsCollectionByIntendedActionId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._BMRecommendationsCollectionByIntendedActionId.Query.Where(Me._BMRecommendationsCollectionByIntendedActionId.Query.IntendedActionId = Me.FldId)
							Me._BMRecommendationsCollectionByIntendedActionId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._BMRecommendationsCollectionByIntendedActionId.fks.Add(BMRecommendationsMetadata.ColumnNames.IntendedActionId, Me.FldId)
					End If
				End If

				Return Me._BMRecommendationsCollectionByIntendedActionId
			End Get
			
			Set(ByVal value As BMRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._BMRecommendationsCollectionByIntendedActionId Is Nothing Then

					Me.RemovePostSave("BMRecommendationsCollectionByIntendedActionId")
					Me._BMRecommendationsCollectionByIntendedActionId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _BMRecommendationsCollectionByIntendedActionId As BMRecommendationsCollection
		#End Region

		#Region "FireRecommendationsCollectionByIntendedActionId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_FireRecommendationsCollectionByIntendedActionId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecIntendedAction.FireRecommendationsCollectionByIntendedActionId_Delegate)
				map.PropertyName = "FireRecommendationsCollectionByIntendedActionId"
				map.MyColumnName = "IntendedActionId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub FireRecommendationsCollectionByIntendedActionId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecIntendedActionQuery(data.NextAlias())
			
			Dim mee As FireRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, FireRecommendationsQuery), New FireRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.IntendedActionId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_FireRec_IntendedActionId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property FireRecommendationsCollectionByIntendedActionId As FireRecommendationsCollection 
		
			Get
				If Me._FireRecommendationsCollectionByIntendedActionId Is Nothing Then
					Me._FireRecommendationsCollectionByIntendedActionId = New FireRecommendationsCollection()
					Me._FireRecommendationsCollectionByIntendedActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("FireRecommendationsCollectionByIntendedActionId", Me._FireRecommendationsCollectionByIntendedActionId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._FireRecommendationsCollectionByIntendedActionId.Query.Where(Me._FireRecommendationsCollectionByIntendedActionId.Query.IntendedActionId = Me.FldId)
							Me._FireRecommendationsCollectionByIntendedActionId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._FireRecommendationsCollectionByIntendedActionId.fks.Add(FireRecommendationsMetadata.ColumnNames.IntendedActionId, Me.FldId)
					End If
				End If

				Return Me._FireRecommendationsCollectionByIntendedActionId
			End Get
			
			Set(ByVal value As FireRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._FireRecommendationsCollectionByIntendedActionId Is Nothing Then

					Me.RemovePostSave("FireRecommendationsCollectionByIntendedActionId")
					Me._FireRecommendationsCollectionByIntendedActionId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _FireRecommendationsCollectionByIntendedActionId As FireRecommendationsCollection
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "BMRecommendationsCollectionByIntendedActionId"
					coll = Me.BMRecommendationsCollectionByIntendedActionId
					Exit Select
				Case "FireRecommendationsCollectionByIntendedActionId"
					coll = Me.FireRecommendationsCollectionByIntendedActionId
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "BMRecommendationsCollectionByIntendedActionId", GetType(BMRecommendationsCollection), New BMRecommendations()))
			props.Add(new esPropertyDescriptor(Me, "FireRecommendationsCollectionByIntendedActionId", GetType(FireRecommendationsCollection), New FireRecommendations()))
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
		
			If Not Me._BMRecommendationsCollectionByIntendedActionId Is Nothing Then
				Apply(Me._BMRecommendationsCollectionByIntendedActionId, "IntendedActionId", Me.FldId)
			End If
			
			If Not Me._FireRecommendationsCollectionByIntendedActionId Is Nothing Then
				Apply(Me._FireRecommendationsCollectionByIntendedActionId, "IntendedActionId", Me.FldId)
			End If
			
		End Sub
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaRecIntendedActionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaRecIntendedActionMetadata.ColumnNames.FldId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecIntendedActionMetadata.PropertyNames.FldId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecIntendedActionMetadata.ColumnNames.FldAction, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaRecIntendedActionMetadata.PropertyNames.FldAction
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaRecIntendedActionMetadata
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
			 Public Const FldAction As String = "fldAction"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldId As String = "FldId"
			 Public Const FldAction As String = "FldAction"
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
			SyncLock GetType(TblMetaRecIntendedActionMetadata)
			
				If TblMetaRecIntendedActionMetadata.mapDelegates Is Nothing Then
					TblMetaRecIntendedActionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaRecIntendedActionMetadata._meta Is Nothing Then
					TblMetaRecIntendedActionMetadata._meta = New TblMetaRecIntendedActionMetadata()
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
				meta.AddTypeMap("FldAction", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "tblMetaRecIntendedAction"
				meta.Destination = "tblMetaRecIntendedAction"
				
				meta.spInsert = "proc_tblMetaRecIntendedActionInsert"
				meta.spUpdate = "proc_tblMetaRecIntendedActionUpdate"
				meta.spDelete = "proc_tblMetaRecIntendedActionDelete"
				meta.spLoadAll = "proc_tblMetaRecIntendedActionLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaRecIntendedActionLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaRecIntendedActionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
