
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/14/2021 12:54:09 PM
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
	' Encapsulates the 'tblMetaRecThirdLevelIntendedAction' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaRecThirdLevelIntendedAction))> _
	<XmlType("TblMetaRecThirdLevelIntendedAction")> _	
	Partial Public Class TblMetaRecThirdLevelIntendedAction 
		Inherits esTblMetaRecThirdLevelIntendedAction
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaRecThirdLevelIntendedAction()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldId As System.Int32)
			Dim obj As New TblMetaRecThirdLevelIntendedAction()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaRecThirdLevelIntendedAction()
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
	<XmlType("TblMetaRecThirdLevelIntendedActionCollection")> _
	Partial Public Class TblMetaRecThirdLevelIntendedActionCollection
		Inherits esTblMetaRecThirdLevelIntendedActionCollection
		Implements IEnumerable(Of TblMetaRecThirdLevelIntendedAction)
	
		Public Function FindByPrimaryKey(ByVal fldId As System.Int32) As TblMetaRecThirdLevelIntendedAction
			Return MyBase.SingleOrDefault(Function(e) e.FldId.HasValue AndAlso e.FldId.Value = fldId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaRecThirdLevelIntendedAction))> _
		Public Class TblMetaRecThirdLevelIntendedActionCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaRecThirdLevelIntendedActionCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaRecThirdLevelIntendedActionCollectionWCFPacket) As TblMetaRecThirdLevelIntendedActionCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaRecThirdLevelIntendedActionCollection) As TblMetaRecThirdLevelIntendedActionCollectionWCFPacket
				Return New TblMetaRecThirdLevelIntendedActionCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaRecThirdLevelIntendedActionQuery 
		Inherits esTblMetaRecThirdLevelIntendedActionQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaRecThirdLevelIntendedActionQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaRecThirdLevelIntendedActionQuery) As String
			Return TblMetaRecThirdLevelIntendedActionQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaRecThirdLevelIntendedActionQuery
			Return DirectCast(TblMetaRecThirdLevelIntendedActionQuery.SerializeHelper.FromXml(query, GetType(TblMetaRecThirdLevelIntendedActionQuery)), TblMetaRecThirdLevelIntendedActionQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecThirdLevelIntendedAction
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
		
			Dim query As New TblMetaRecThirdLevelIntendedActionQuery()
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
		' Maps to tblMetaRecThirdLevelIntendedAction.fldId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldId, value) Then
					OnPropertyChanged(TblMetaRecThirdLevelIntendedActionMetadata.PropertyNames.FldId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRecThirdLevelIntendedAction.fldPrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldPrefix As System.String
			Get
				Return MyBase.GetSystemString(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldPrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldPrefix, value) Then
					OnPropertyChanged(TblMetaRecThirdLevelIntendedActionMetadata.PropertyNames.FldPrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRecThirdLevelIntendedAction.fldAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldAction As System.String
			Get
				Return MyBase.GetSystemString(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldAction, value) Then
					OnPropertyChanged(TblMetaRecThirdLevelIntendedActionMetadata.PropertyNames.FldAction)
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
												
						Case "FldPrefix"
							Me.str().FldPrefix = CType(value, string)
												
						Case "FldAction"
							Me.str().FldAction = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FldId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecThirdLevelIntendedActionMetadata.PropertyNames.FldId)
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
		
			Public Sub New(ByVal entity As esTblMetaRecThirdLevelIntendedAction)
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
		  	
			Public Property FldPrefix As System.String 
				Get
					Dim data_ As System.String = entity.FldPrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldPrefix = Nothing
					Else
						entity.FldPrefix = Convert.ToString(Value)
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
		  

			Private entity As esTblMetaRecThirdLevelIntendedAction
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecThirdLevelIntendedActionMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaRecThirdLevelIntendedActionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecThirdLevelIntendedActionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecThirdLevelIntendedActionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaRecThirdLevelIntendedActionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblMetaRecThirdLevelIntendedActionQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecThirdLevelIntendedActionCollection
		Inherits esEntityCollection(Of TblMetaRecThirdLevelIntendedAction)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecThirdLevelIntendedActionMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaRecThirdLevelIntendedActionCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TblMetaRecThirdLevelIntendedActionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecThirdLevelIntendedActionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TblMetaRecThirdLevelIntendedActionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaRecThirdLevelIntendedActionQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaRecThirdLevelIntendedActionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaRecThirdLevelIntendedActionQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaRecThirdLevelIntendedActionQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaRecThirdLevelIntendedActionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaRecThirdLevelIntendedActionMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldId" 
					Return Me.FldId
				Case "FldPrefix" 
					Return Me.FldPrefix
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
				Return New esQueryItem(Me, TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldPrefix As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldPrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FldAction As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldAction, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaRecThirdLevelIntendedAction 
		Inherits esTblMetaRecThirdLevelIntendedAction
		
	
		#Region "BMRecommendationsCollectionByThirdLevelRespActionId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_BMRecommendationsCollectionByThirdLevelRespActionId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecThirdLevelIntendedAction.BMRecommendationsCollectionByThirdLevelRespActionId_Delegate)
				map.PropertyName = "BMRecommendationsCollectionByThirdLevelRespActionId"
				map.MyColumnName = "ThirdLevelRespActionId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub BMRecommendationsCollectionByThirdLevelRespActionId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecThirdLevelIntendedActionQuery(data.NextAlias())
			
			Dim mee As BMRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, BMRecommendationsQuery), New BMRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.ThirdLevelRespActionId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_BmRec_ThirdLabelRespActionId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property BMRecommendationsCollectionByThirdLevelRespActionId As BMRecommendationsCollection 
		
			Get
				If Me._BMRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then
					Me._BMRecommendationsCollectionByThirdLevelRespActionId = New BMRecommendationsCollection()
					Me._BMRecommendationsCollectionByThirdLevelRespActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("BMRecommendationsCollectionByThirdLevelRespActionId", Me._BMRecommendationsCollectionByThirdLevelRespActionId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._BMRecommendationsCollectionByThirdLevelRespActionId.Query.Where(Me._BMRecommendationsCollectionByThirdLevelRespActionId.Query.ThirdLevelRespActionId = Me.FldId)
							Me._BMRecommendationsCollectionByThirdLevelRespActionId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._BMRecommendationsCollectionByThirdLevelRespActionId.fks.Add(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, Me.FldId)
					End If
				End If

				Return Me._BMRecommendationsCollectionByThirdLevelRespActionId
			End Get
			
			Set(ByVal value As BMRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._BMRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then

					Me.RemovePostSave("BMRecommendationsCollectionByThirdLevelRespActionId")
					Me._BMRecommendationsCollectionByThirdLevelRespActionId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _BMRecommendationsCollectionByThirdLevelRespActionId As BMRecommendationsCollection
		#End Region

		#Region "FireRecommendationsCollectionByThirdLevelRespActionId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_FireRecommendationsCollectionByThirdLevelRespActionId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecThirdLevelIntendedAction.FireRecommendationsCollectionByThirdLevelRespActionId_Delegate)
				map.PropertyName = "FireRecommendationsCollectionByThirdLevelRespActionId"
				map.MyColumnName = "ThirdLevelRespActionId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub FireRecommendationsCollectionByThirdLevelRespActionId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecThirdLevelIntendedActionQuery(data.NextAlias())
			
			Dim mee As FireRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, FireRecommendationsQuery), New FireRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.ThirdLevelRespActionId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_FireRec_ThirdLabelRespActionId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property FireRecommendationsCollectionByThirdLevelRespActionId As FireRecommendationsCollection 
		
			Get
				If Me._FireRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then
					Me._FireRecommendationsCollectionByThirdLevelRespActionId = New FireRecommendationsCollection()
					Me._FireRecommendationsCollectionByThirdLevelRespActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("FireRecommendationsCollectionByThirdLevelRespActionId", Me._FireRecommendationsCollectionByThirdLevelRespActionId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._FireRecommendationsCollectionByThirdLevelRespActionId.Query.Where(Me._FireRecommendationsCollectionByThirdLevelRespActionId.Query.ThirdLevelRespActionId = Me.FldId)
							Me._FireRecommendationsCollectionByThirdLevelRespActionId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._FireRecommendationsCollectionByThirdLevelRespActionId.fks.Add(FireRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, Me.FldId)
					End If
				End If

				Return Me._FireRecommendationsCollectionByThirdLevelRespActionId
			End Get
			
			Set(ByVal value As FireRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._FireRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then

					Me.RemovePostSave("FireRecommendationsCollectionByThirdLevelRespActionId")
					Me._FireRecommendationsCollectionByThirdLevelRespActionId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _FireRecommendationsCollectionByThirdLevelRespActionId As FireRecommendationsCollection
		#End Region

		#Region "PSRecommendationsCollectionByThirdLevelRespActionId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_PSRecommendationsCollectionByThirdLevelRespActionId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecThirdLevelIntendedAction.PSRecommendationsCollectionByThirdLevelRespActionId_Delegate)
				map.PropertyName = "PSRecommendationsCollectionByThirdLevelRespActionId"
				map.MyColumnName = "ThirdLevelRespActionId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub PSRecommendationsCollectionByThirdLevelRespActionId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecThirdLevelIntendedActionQuery(data.NextAlias())
			
			Dim mee As PSRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, PSRecommendationsQuery), New PSRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.ThirdLevelRespActionId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_PsRec_ThirdLabelRespActionId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property PSRecommendationsCollectionByThirdLevelRespActionId As PSRecommendationsCollection 
		
			Get
				If Me._PSRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then
					Me._PSRecommendationsCollectionByThirdLevelRespActionId = New PSRecommendationsCollection()
					Me._PSRecommendationsCollectionByThirdLevelRespActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("PSRecommendationsCollectionByThirdLevelRespActionId", Me._PSRecommendationsCollectionByThirdLevelRespActionId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._PSRecommendationsCollectionByThirdLevelRespActionId.Query.Where(Me._PSRecommendationsCollectionByThirdLevelRespActionId.Query.ThirdLevelRespActionId = Me.FldId)
							Me._PSRecommendationsCollectionByThirdLevelRespActionId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._PSRecommendationsCollectionByThirdLevelRespActionId.fks.Add(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, Me.FldId)
					End If
				End If

				Return Me._PSRecommendationsCollectionByThirdLevelRespActionId
			End Get
			
			Set(ByVal value As PSRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._PSRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then

					Me.RemovePostSave("PSRecommendationsCollectionByThirdLevelRespActionId")
					Me._PSRecommendationsCollectionByThirdLevelRespActionId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _PSRecommendationsCollectionByThirdLevelRespActionId As PSRecommendationsCollection
		#End Region

		#Region "SelfAuditRecommendationsCollectionByThirdLevelRespActionId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_SelfAuditRecommendationsCollectionByThirdLevelRespActionId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecThirdLevelIntendedAction.SelfAuditRecommendationsCollectionByThirdLevelRespActionId_Delegate)
				map.PropertyName = "SelfAuditRecommendationsCollectionByThirdLevelRespActionId"
				map.MyColumnName = "ThirdLevelRespActionId"
				map.ParentColumnName = "fldId"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub SelfAuditRecommendationsCollectionByThirdLevelRespActionId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecThirdLevelIntendedActionQuery(data.NextAlias())
			
			Dim mee As SelfAuditRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, SelfAuditRecommendationsQuery), New SelfAuditRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldId = mee.ThirdLevelRespActionId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_SelfAuditRec_ThirdLabelRespActionId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property SelfAuditRecommendationsCollectionByThirdLevelRespActionId As SelfAuditRecommendationsCollection 
		
			Get
				If Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then
					Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId = New SelfAuditRecommendationsCollection()
					Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("SelfAuditRecommendationsCollectionByThirdLevelRespActionId", Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId)
				
					If Not Me.FldId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId.Query.Where(Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId.Query.ThirdLevelRespActionId = Me.FldId)
							Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId.fks.Add(SelfAuditRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, Me.FldId)
					End If
				End If

				Return Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId
			End Get
			
			Set(ByVal value As SelfAuditRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then

					Me.RemovePostSave("SelfAuditRecommendationsCollectionByThirdLevelRespActionId")
					Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _SelfAuditRecommendationsCollectionByThirdLevelRespActionId As SelfAuditRecommendationsCollection
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "BMRecommendationsCollectionByThirdLevelRespActionId"
					coll = Me.BMRecommendationsCollectionByThirdLevelRespActionId
					Exit Select
				Case "FireRecommendationsCollectionByThirdLevelRespActionId"
					coll = Me.FireRecommendationsCollectionByThirdLevelRespActionId
					Exit Select
				Case "PSRecommendationsCollectionByThirdLevelRespActionId"
					coll = Me.PSRecommendationsCollectionByThirdLevelRespActionId
					Exit Select
				Case "SelfAuditRecommendationsCollectionByThirdLevelRespActionId"
					coll = Me.SelfAuditRecommendationsCollectionByThirdLevelRespActionId
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "BMRecommendationsCollectionByThirdLevelRespActionId", GetType(BMRecommendationsCollection), New BMRecommendations()))
			props.Add(new esPropertyDescriptor(Me, "FireRecommendationsCollectionByThirdLevelRespActionId", GetType(FireRecommendationsCollection), New FireRecommendations()))
			props.Add(new esPropertyDescriptor(Me, "PSRecommendationsCollectionByThirdLevelRespActionId", GetType(PSRecommendationsCollection), New PSRecommendations()))
			props.Add(new esPropertyDescriptor(Me, "SelfAuditRecommendationsCollectionByThirdLevelRespActionId", GetType(SelfAuditRecommendationsCollection), New SelfAuditRecommendations()))
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
		
			If Not Me._BMRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then
				Apply(Me._BMRecommendationsCollectionByThirdLevelRespActionId, "ThirdLevelRespActionId", Me.FldId)
			End If
			
			If Not Me._FireRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then
				Apply(Me._FireRecommendationsCollectionByThirdLevelRespActionId, "ThirdLevelRespActionId", Me.FldId)
			End If
			
			If Not Me._PSRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then
				Apply(Me._PSRecommendationsCollectionByThirdLevelRespActionId, "ThirdLevelRespActionId", Me.FldId)
			End If
			
			If Not Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId Is Nothing Then
				Apply(Me._SelfAuditRecommendationsCollectionByThirdLevelRespActionId, "ThirdLevelRespActionId", Me.FldId)
			End If
			
		End Sub
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaRecThirdLevelIntendedActionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecThirdLevelIntendedActionMetadata.PropertyNames.FldId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldPrefix, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaRecThirdLevelIntendedActionMetadata.PropertyNames.FldPrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecThirdLevelIntendedActionMetadata.ColumnNames.FldAction, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaRecThirdLevelIntendedActionMetadata.PropertyNames.FldAction
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaRecThirdLevelIntendedActionMetadata
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
			 Public Const FldPrefix As String = "fldPrefix"
			 Public Const FldAction As String = "fldAction"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldId As String = "FldId"
			 Public Const FldPrefix As String = "FldPrefix"
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
			SyncLock GetType(TblMetaRecThirdLevelIntendedActionMetadata)
			
				If TblMetaRecThirdLevelIntendedActionMetadata.mapDelegates Is Nothing Then
					TblMetaRecThirdLevelIntendedActionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaRecThirdLevelIntendedActionMetadata._meta Is Nothing Then
					TblMetaRecThirdLevelIntendedActionMetadata._meta = New TblMetaRecThirdLevelIntendedActionMetadata()
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
				meta.AddTypeMap("FldPrefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FldAction", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "tblMetaRecThirdLevelIntendedAction"
				meta.Destination = "tblMetaRecThirdLevelIntendedAction"
				
				meta.spInsert = "proc_tblMetaRecThirdLevelIntendedActionInsert"
				meta.spUpdate = "proc_tblMetaRecThirdLevelIntendedActionUpdate"
				meta.spDelete = "proc_tblMetaRecThirdLevelIntendedActionDelete"
				meta.spLoadAll = "proc_tblMetaRecThirdLevelIntendedActionLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaRecThirdLevelIntendedActionLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaRecThirdLevelIntendedActionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
