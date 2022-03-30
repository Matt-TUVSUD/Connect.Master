
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
	' Encapsulates the 'tblMetaRecStatus' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaRecStatus))> _
	<XmlType("TblMetaRecStatus")> _	
	Partial Public Class TblMetaRecStatus 
		Inherits esTblMetaRecStatus
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaRecStatus()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldId As System.Int32)
			Dim obj As New TblMetaRecStatus()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaRecStatus()
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
	<XmlType("TblMetaRecStatusCollection")> _
	Partial Public Class TblMetaRecStatusCollection
		Inherits esTblMetaRecStatusCollection
		Implements IEnumerable(Of TblMetaRecStatus)
	
		Public Function FindByPrimaryKey(ByVal fldId As System.Int32) As TblMetaRecStatus
			Return MyBase.SingleOrDefault(Function(e) e.FldId.HasValue AndAlso e.FldId.Value = fldId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaRecStatus))> _
		Public Class TblMetaRecStatusCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaRecStatusCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaRecStatusCollectionWCFPacket) As TblMetaRecStatusCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaRecStatusCollection) As TblMetaRecStatusCollectionWCFPacket
				Return New TblMetaRecStatusCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaRecStatusQuery 
		Inherits esTblMetaRecStatusQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaRecStatusQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaRecStatusQuery) As String
			Return TblMetaRecStatusQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaRecStatusQuery
			Return DirectCast(TblMetaRecStatusQuery.SerializeHelper.FromXml(query, GetType(TblMetaRecStatusQuery)), TblMetaRecStatusQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecStatus
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
		
			Dim query As New TblMetaRecStatusQuery()
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
		' Maps to tblMetaRecStatus.fldId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecStatusMetadata.ColumnNames.FldId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecStatusMetadata.ColumnNames.FldId, value) Then
					OnPropertyChanged(TblMetaRecStatusMetadata.PropertyNames.FldId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRecStatus.fldStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldStatus As System.String
			Get
				Return MyBase.GetSystemString(TblMetaRecStatusMetadata.ColumnNames.FldStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaRecStatusMetadata.ColumnNames.FldStatus, value) Then
					OnPropertyChanged(TblMetaRecStatusMetadata.PropertyNames.FldStatus)
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
												
						Case "FldStatus"
							Me.str().FldStatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FldId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecStatusMetadata.PropertyNames.FldId)
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
		
			Public Sub New(ByVal entity As esTblMetaRecStatus)
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
		  	
			Public Property FldStatus As System.String 
				Get
					Dim data_ As System.String = entity.FldStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldStatus = Nothing
					Else
						entity.FldStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esTblMetaRecStatus
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecStatusMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaRecStatusQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecStatusQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecStatusQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaRecStatusQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblMetaRecStatusQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecStatusCollection
		Inherits esEntityCollection(Of TblMetaRecStatus)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecStatusMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaRecStatusCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TblMetaRecStatusQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecStatusQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TblMetaRecStatusQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaRecStatusQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaRecStatusQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaRecStatusQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaRecStatusQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaRecStatusQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaRecStatusMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldId" 
					Return Me.FldId
				Case "FldStatus" 
					Return Me.FldStatus
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FldId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecStatusMetadata.ColumnNames.FldId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldStatus As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecStatusMetadata.ColumnNames.FldStatus, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaRecStatus 
		Inherits esTblMetaRecStatus
		
	
		#Region "BMRecommendationsCollectionByRecStatusId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_BMRecommendationsCollectionByRecStatusId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecStatus.BMRecommendationsCollectionByRecStatusId_Delegate)
				map.PropertyName = "BMRecommendationsCollectionByRecStatusId"
				map.MyColumnName = "RecStatusId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub BMRecommendationsCollectionByRecStatusId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecStatusQuery(data.NextAlias())
			
			Dim mee As BMRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, BMRecommendationsQuery), New BMRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.RecStatusId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_BmRec_RecStatusId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property BMRecommendationsCollectionByRecStatusId As BMRecommendationsCollection 
		
			Get
				If Me._BMRecommendationsCollectionByRecStatusId Is Nothing Then
					Me._BMRecommendationsCollectionByRecStatusId = New BMRecommendationsCollection()
					Me._BMRecommendationsCollectionByRecStatusId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("BMRecommendationsCollectionByRecStatusId", Me._BMRecommendationsCollectionByRecStatusId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._BMRecommendationsCollectionByRecStatusId.Query.Where(Me._BMRecommendationsCollectionByRecStatusId.Query.RecStatusId = Me.FldId)
							Me._BMRecommendationsCollectionByRecStatusId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._BMRecommendationsCollectionByRecStatusId.fks.Add(BMRecommendationsMetadata.ColumnNames.RecStatusId, Me.FldId)
					End If
				End If

				Return Me._BMRecommendationsCollectionByRecStatusId
			End Get
			
			Set(ByVal value As BMRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._BMRecommendationsCollectionByRecStatusId Is Nothing Then

					Me.RemovePostSave("BMRecommendationsCollectionByRecStatusId")
					Me._BMRecommendationsCollectionByRecStatusId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _BMRecommendationsCollectionByRecStatusId As BMRecommendationsCollection
		#End Region

		#Region "FireRecommendationsCollectionByRecStatusId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_FireRecommendationsCollectionByRecStatusId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecStatus.FireRecommendationsCollectionByRecStatusId_Delegate)
				map.PropertyName = "FireRecommendationsCollectionByRecStatusId"
				map.MyColumnName = "RecStatusId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub FireRecommendationsCollectionByRecStatusId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecStatusQuery(data.NextAlias())
			
			Dim mee As FireRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, FireRecommendationsQuery), New FireRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.RecStatusId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_FireRec_RecStatusId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property FireRecommendationsCollectionByRecStatusId As FireRecommendationsCollection 
		
			Get
				If Me._FireRecommendationsCollectionByRecStatusId Is Nothing Then
					Me._FireRecommendationsCollectionByRecStatusId = New FireRecommendationsCollection()
					Me._FireRecommendationsCollectionByRecStatusId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("FireRecommendationsCollectionByRecStatusId", Me._FireRecommendationsCollectionByRecStatusId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._FireRecommendationsCollectionByRecStatusId.Query.Where(Me._FireRecommendationsCollectionByRecStatusId.Query.RecStatusId = Me.FldId)
							Me._FireRecommendationsCollectionByRecStatusId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._FireRecommendationsCollectionByRecStatusId.fks.Add(FireRecommendationsMetadata.ColumnNames.RecStatusId, Me.FldId)
					End If
				End If

				Return Me._FireRecommendationsCollectionByRecStatusId
			End Get
			
			Set(ByVal value As FireRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._FireRecommendationsCollectionByRecStatusId Is Nothing Then

					Me.RemovePostSave("FireRecommendationsCollectionByRecStatusId")
					Me._FireRecommendationsCollectionByRecStatusId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _FireRecommendationsCollectionByRecStatusId As FireRecommendationsCollection
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "BMRecommendationsCollectionByRecStatusId"
					coll = Me.BMRecommendationsCollectionByRecStatusId
					Exit Select
				Case "FireRecommendationsCollectionByRecStatusId"
					coll = Me.FireRecommendationsCollectionByRecStatusId
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "BMRecommendationsCollectionByRecStatusId", GetType(BMRecommendationsCollection), New BMRecommendations()))
			props.Add(new esPropertyDescriptor(Me, "FireRecommendationsCollectionByRecStatusId", GetType(FireRecommendationsCollection), New FireRecommendations()))
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
		
			If Not Me._BMRecommendationsCollectionByRecStatusId Is Nothing Then
				Apply(Me._BMRecommendationsCollectionByRecStatusId, "RecStatusId", Me.FldId)
			End If
			
			If Not Me._FireRecommendationsCollectionByRecStatusId Is Nothing Then
				Apply(Me._FireRecommendationsCollectionByRecStatusId, "RecStatusId", Me.FldId)
			End If
			
		End Sub
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaRecStatusMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaRecStatusMetadata.ColumnNames.FldId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecStatusMetadata.PropertyNames.FldId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecStatusMetadata.ColumnNames.FldStatus, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaRecStatusMetadata.PropertyNames.FldStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaRecStatusMetadata
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
			 Public Const FldStatus As String = "fldStatus"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldId As String = "FldId"
			 Public Const FldStatus As String = "FldStatus"
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
			SyncLock GetType(TblMetaRecStatusMetadata)
			
				If TblMetaRecStatusMetadata.mapDelegates Is Nothing Then
					TblMetaRecStatusMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaRecStatusMetadata._meta Is Nothing Then
					TblMetaRecStatusMetadata._meta = New TblMetaRecStatusMetadata()
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
				meta.AddTypeMap("FldStatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "tblMetaRecStatus"
				meta.Destination = "tblMetaRecStatus"
				
				meta.spInsert = "proc_tblMetaRecStatusInsert"
				meta.spUpdate = "proc_tblMetaRecStatusUpdate"
				meta.spDelete = "proc_tblMetaRecStatusDelete"
				meta.spLoadAll = "proc_tblMetaRecStatusLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaRecStatusLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaRecStatusMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
