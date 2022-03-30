
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
	' Encapsulates the 'tblMetaRecTypePair' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaRecTypePair))> _
	<XmlType("TblMetaRecTypePair")> _	
	Partial Public Class TblMetaRecTypePair 
		Inherits esTblMetaRecTypePair
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaRecTypePair()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32)
			Dim obj As New TblMetaRecTypePair()
			obj.FldPrimaryRecTypeId = fldPrimaryRecTypeId
			obj.FldSecondaryRecTypeId = fldSecondaryRecTypeId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaRecTypePair()
			obj.FldPrimaryRecTypeId = fldPrimaryRecTypeId
			obj.FldSecondaryRecTypeId = fldSecondaryRecTypeId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("TblMetaRecTypePairCollection")> _
	Partial Public Class TblMetaRecTypePairCollection
		Inherits esTblMetaRecTypePairCollection
		Implements IEnumerable(Of TblMetaRecTypePair)
	
		Public Function FindByPrimaryKey(ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As TblMetaRecTypePair
			Return MyBase.SingleOrDefault(Function(e) e.FldPrimaryRecTypeId.HasValue AndAlso e.FldPrimaryRecTypeId.Value = fldPrimaryRecTypeId And e.FldSecondaryRecTypeId.HasValue AndAlso e.FldSecondaryRecTypeId.Value = fldSecondaryRecTypeId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaRecTypePair))> _
		Public Class TblMetaRecTypePairCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaRecTypePairCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaRecTypePairCollectionWCFPacket) As TblMetaRecTypePairCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaRecTypePairCollection) As TblMetaRecTypePairCollectionWCFPacket
				Return New TblMetaRecTypePairCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaRecTypePairQuery 
		Inherits esTblMetaRecTypePairQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaRecTypePairQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaRecTypePairQuery) As String
			Return TblMetaRecTypePairQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaRecTypePairQuery
			Return DirectCast(TblMetaRecTypePairQuery.SerializeHelper.FromXml(query, GetType(TblMetaRecTypePairQuery)), TblMetaRecTypePairQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecTypePair
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fldPrimaryRecTypeId, fldSecondaryRecTypeId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fldPrimaryRecTypeId, fldSecondaryRecTypeId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fldPrimaryRecTypeId, fldSecondaryRecTypeId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fldPrimaryRecTypeId, fldSecondaryRecTypeId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As Boolean

			Dim query As New TblMetaRecTypePairQuery("a")
			query.Where(query.FldPrimaryRecTypeId = fldPrimaryRecTypeId And query.FldSecondaryRecTypeId = fldSecondaryRecTypeId)
			Return Me.Load(query)

		End Function

		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As Boolean

			Dim parms As esParameters = New esParameters()
			parms.Add("FldPrimaryRecTypeId", fldPrimaryRecTypeId)
			parms.Add("FldSecondaryRecTypeId", fldSecondaryRecTypeId)

			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)

		End Function
#End Region

#Region "Properties"



		' <summary>
		' Maps to tblMetaRecTypePair.fldPrimaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)>
		Public Overridable Property FldPrimaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecTypePairMetadata.ColumnNames.FldPrimaryRecTypeId)
			End Get

			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecTypePairMetadata.ColumnNames.FldPrimaryRecTypeId, value) Then
					OnPropertyChanged(TblMetaRecTypePairMetadata.PropertyNames.FldPrimaryRecTypeId)
				End If
			End Set
		End Property

		' <summary>
		' Maps to tblMetaRecTypePair.fldSecondaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)>
		Public Overridable Property FldSecondaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecTypePairMetadata.ColumnNames.FldSecondaryRecTypeId)
			End Get

			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecTypePairMetadata.ColumnNames.FldSecondaryRecTypeId, value) Then
					OnPropertyChanged(TblMetaRecTypePairMetadata.PropertyNames.FldSecondaryRecTypeId)
				End If
			End Set
		End Property

		<CLSCompliant(False)>
		Protected Friend _UpToTblMetaRecTypeByFldPrimaryRecTypeId As TblMetaRecType

		<CLSCompliant(False)>
		Protected Friend _UpToTblMetaRecTypeByFldSecondaryRecTypeId As TblMetaRecType

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

						Case "FldPrimaryRecTypeId"
							Me.str().FldPrimaryRecTypeId = CType(value, String)

						Case "FldSecondaryRecTypeId"
							Me.str().FldSecondaryRecTypeId = CType(value, String)

					End Select

				Else

					Select Case name

						Case "FldPrimaryRecTypeId"

							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldPrimaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecTypePairMetadata.PropertyNames.FldPrimaryRecTypeId)
							End If

						Case "FldSecondaryRecTypeId"

							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldSecondaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecTypePairMetadata.PropertyNames.FldSecondaryRecTypeId)
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

			Public Sub New(ByVal entity As esTblMetaRecTypePair)
				Me.entity = entity
			End Sub


			Public Property FldPrimaryRecTypeId As System.String
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldPrimaryRecTypeId

					If Not data_.HasValue Then

						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value As System.String)
					If String.IsNullOrEmpty(Value) Then
						entity.FldPrimaryRecTypeId = Nothing
					Else
						entity.FldPrimaryRecTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property

			Public Property FldSecondaryRecTypeId As System.String
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldSecondaryRecTypeId

					If Not data_.HasValue Then

						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value As System.String)
					If String.IsNullOrEmpty(Value) Then
						entity.FldSecondaryRecTypeId = Nothing
					Else
						entity.FldSecondaryRecTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property


			Private entity As esTblMetaRecTypePair
		End Class


		<NonSerialized>
		<IgnoreDataMember>
		Private _esstrings As esStrings

#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecTypePairMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaRecTypePairQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecTypePairQuery("a")
					InitQuery(Me.m_query)
				End If

				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecTypePairQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaRecTypePairQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded

			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

		<IgnoreDataMember>
		Private m_query As TblMetaRecTypePairQuery

	End Class



	<Serializable()>
	Partial Public MustInherit Class esTblMetaRecTypePairCollection
		Inherits esEntityCollection(Of TblMetaRecTypePair)

#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecTypePairMetadata.Meta()
			End Get
		End Property

		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaRecTypePairCollection"
		End Function

#End Region

#Region "Query Logic"


		<BrowsableAttribute(False)>
		Public ReadOnly Property Query() As TblMetaRecTypePairQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecTypePairQuery("a")
					InitQuery(Me.m_query)
				End If

				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecTypePairQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return query.Load()
		End Function

		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaRecTypePairQuery("a")
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaRecTypePairQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaRecTypePairQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaRecTypePairQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaRecTypePairQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaRecTypePairMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldPrimaryRecTypeId" 
					Return Me.FldPrimaryRecTypeId
				Case "FldSecondaryRecTypeId" 
					Return Me.FldSecondaryRecTypeId
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FldPrimaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecTypePairMetadata.ColumnNames.FldPrimaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldSecondaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecTypePairMetadata.ColumnNames.FldSecondaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaRecTypePair 
		Inherits esTblMetaRecTypePair
		
	
		#Region "BMRecommendationsCollectionByPrimaryRecTypeId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_BMRecommendationsCollectionByPrimaryRecTypeId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecTypePair.BMRecommendationsCollectionByPrimaryRecTypeId_Delegate)
				map.PropertyName = "BMRecommendationsCollectionByPrimaryRecTypeId"
				map.MyColumnName = "PrimaryRecTypeId,SecondaryRecTypeId"
				map.ParentColumnName = "fldPrimaryRecTypeId,fldSecondaryRecTypeId"
				map.IsMultiPartKey = true
				Return map
			End Get
		End Property

		Private Shared Sub BMRecommendationsCollectionByPrimaryRecTypeId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecTypePairQuery(data.NextAlias())
			
			Dim mee As BMRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, BMRecommendationsQuery), New BMRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldPrimaryRecTypeId = mee.PrimaryRecTypeId And parent.FldSecondaryRecTypeId = mee.SecondaryRecTypeId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_BmRec_PrimaryRecTypeId_SecondaryRecTypeId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property BMRecommendationsCollectionByPrimaryRecTypeId As BMRecommendationsCollection 
		
			Get
				If Me._BMRecommendationsCollectionByPrimaryRecTypeId Is Nothing Then
					Me._BMRecommendationsCollectionByPrimaryRecTypeId = New BMRecommendationsCollection()
					Me._BMRecommendationsCollectionByPrimaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("BMRecommendationsCollectionByPrimaryRecTypeId", Me._BMRecommendationsCollectionByPrimaryRecTypeId)
				
					If Not Me.FldPrimaryRecTypeId.Equals(Nothing) AndAlso Not Me.FldSecondaryRecTypeId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._BMRecommendationsCollectionByPrimaryRecTypeId.Query.Where(Me._BMRecommendationsCollectionByPrimaryRecTypeId.Query.PrimaryRecTypeId = Me.FldPrimaryRecTypeId)
							Me._BMRecommendationsCollectionByPrimaryRecTypeId.Query.Where(Me._BMRecommendationsCollectionByPrimaryRecTypeId.Query.SecondaryRecTypeId = Me.FldSecondaryRecTypeId)
							Me._BMRecommendationsCollectionByPrimaryRecTypeId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._BMRecommendationsCollectionByPrimaryRecTypeId.fks.Add(BMRecommendationsMetadata.ColumnNames.PrimaryRecTypeId, Me.FldPrimaryRecTypeId)
						Me._BMRecommendationsCollectionByPrimaryRecTypeId.fks.Add(BMRecommendationsMetadata.ColumnNames.SecondaryRecTypeId, Me.FldSecondaryRecTypeId)
					End If
				End If

				Return Me._BMRecommendationsCollectionByPrimaryRecTypeId
			End Get
			
			Set(ByVal value As BMRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._BMRecommendationsCollectionByPrimaryRecTypeId Is Nothing Then

					Me.RemovePostSave("BMRecommendationsCollectionByPrimaryRecTypeId")
					Me._BMRecommendationsCollectionByPrimaryRecTypeId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _BMRecommendationsCollectionByPrimaryRecTypeId As BMRecommendationsCollection
		#End Region

		#Region "FireRecommendationsCollectionByPrimaryRecTypeId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_FireRecommendationsCollectionByPrimaryRecTypeId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecTypePair.FireRecommendationsCollectionByPrimaryRecTypeId_Delegate)
				map.PropertyName = "FireRecommendationsCollectionByPrimaryRecTypeId"
				map.MyColumnName = "PrimaryRecTypeId,SecondaryRecTypeId"
				map.ParentColumnName = "fldPrimaryRecTypeId,fldSecondaryRecTypeId"
				map.IsMultiPartKey = true
				Return map
			End Get
		End Property

		Private Shared Sub FireRecommendationsCollectionByPrimaryRecTypeId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecTypePairQuery(data.NextAlias())
			
			Dim mee As FireRecommendationsQuery = If(data.You IsNot Nothing, TryCast(data.You, FireRecommendationsQuery), New FireRecommendationsQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldPrimaryRecTypeId = mee.PrimaryRecTypeId And parent.FldSecondaryRecTypeId = mee.SecondaryRecTypeId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_FireRec_PrimaryRecTypeId_SecondaryRecTypeId
		''' </summary>

		<XmlIgnore()> _ 
		Public Property FireRecommendationsCollectionByPrimaryRecTypeId As FireRecommendationsCollection 
		
			Get
				If Me._FireRecommendationsCollectionByPrimaryRecTypeId Is Nothing Then
					Me._FireRecommendationsCollectionByPrimaryRecTypeId = New FireRecommendationsCollection()
					Me._FireRecommendationsCollectionByPrimaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("FireRecommendationsCollectionByPrimaryRecTypeId", Me._FireRecommendationsCollectionByPrimaryRecTypeId)
				
					If Not Me.FldPrimaryRecTypeId.Equals(Nothing) AndAlso Not Me.FldSecondaryRecTypeId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._FireRecommendationsCollectionByPrimaryRecTypeId.Query.Where(Me._FireRecommendationsCollectionByPrimaryRecTypeId.Query.PrimaryRecTypeId = Me.FldPrimaryRecTypeId)
							Me._FireRecommendationsCollectionByPrimaryRecTypeId.Query.Where(Me._FireRecommendationsCollectionByPrimaryRecTypeId.Query.SecondaryRecTypeId = Me.FldSecondaryRecTypeId)
							Me._FireRecommendationsCollectionByPrimaryRecTypeId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._FireRecommendationsCollectionByPrimaryRecTypeId.fks.Add(FireRecommendationsMetadata.ColumnNames.PrimaryRecTypeId, Me.FldPrimaryRecTypeId)
						Me._FireRecommendationsCollectionByPrimaryRecTypeId.fks.Add(FireRecommendationsMetadata.ColumnNames.SecondaryRecTypeId, Me.FldSecondaryRecTypeId)
					End If
				End If

				Return Me._FireRecommendationsCollectionByPrimaryRecTypeId
			End Get
			
			Set(ByVal value As FireRecommendationsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._FireRecommendationsCollectionByPrimaryRecTypeId Is Nothing Then

					Me.RemovePostSave("FireRecommendationsCollectionByPrimaryRecTypeId")
					Me._FireRecommendationsCollectionByPrimaryRecTypeId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _FireRecommendationsCollectionByPrimaryRecTypeId As FireRecommendationsCollection
		#End Region

		#Region "TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.TblMetaRecTypePair.TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId_Delegate)
				map.PropertyName = "TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId"
				map.MyColumnName = "fldPrimaryRecTypeId,fldSecondaryRecTypeId"
				map.ParentColumnName = "fldPrimaryRecTypeId,fldSecondaryRecTypeId"
				map.IsMultiPartKey = true
				Return map
			End Get
		End Property

		Private Shared Sub TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TblMetaRecTypePairQuery(data.NextAlias())
			
			Dim mee As TblMetaRecTypePairPracticeQuery = If(data.You IsNot Nothing, TryCast(data.You, TblMetaRecTypePairPracticeQuery), New TblMetaRecTypePairPracticeQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.FldPrimaryRecTypeId = mee.FldPrimaryRecTypeId And parent.FldSecondaryRecTypeId = mee.FldSecondaryRecTypeId)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_tblMetaRecTypePairPractice
		''' </summary>

		<XmlIgnore()> _ 
		Public Property TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId As TblMetaRecTypePairPracticeCollection 
		
			Get
				If Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId Is Nothing Then
					Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId = New TblMetaRecTypePairPracticeCollection()
					Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId", Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId)
				
					If Not Me.FldPrimaryRecTypeId.Equals(Nothing) AndAlso Not Me.FldSecondaryRecTypeId.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId.Query.Where(Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId.Query.FldPrimaryRecTypeId = Me.FldPrimaryRecTypeId)
							Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId.Query.Where(Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId.Query.FldSecondaryRecTypeId = Me.FldSecondaryRecTypeId)
							Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId.fks.Add(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPrimaryRecTypeId, Me.FldPrimaryRecTypeId)
						Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId.fks.Add(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldSecondaryRecTypeId, Me.FldSecondaryRecTypeId)
					End If
				End If

				Return Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId
			End Get
			
			Set(ByVal value As TblMetaRecTypePairPracticeCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId Is Nothing Then

					Me.RemovePostSave("TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId")
					Me._TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId = Nothing
					

				End If
			End Set				
			
		End Property
		

		private _TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId As TblMetaRecTypePairPracticeCollection
		#End Region

		#Region "UpToTblMetaRecTypeByFldPrimaryRecTypeId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_tblMetaRecTypePair_fldPrimaryRecTypeId
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecTypeByFldPrimaryRecTypeId As TblMetaRecType
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId Is Nothing _
						 AndAlso Not FldPrimaryRecTypeId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId = New TblMetaRecType()
					Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecTypeByFldPrimaryRecTypeId", Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId)
					Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId.Query.Where(Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId.Query.FldId = Me.FldPrimaryRecTypeId)
					Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId.Query.Load()
				End If

				Return Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId
			End Get
			
            Set(ByVal value As TblMetaRecType)
				Me.RemovePreSave("UpToTblMetaRecTypeByFldPrimaryRecTypeId")
				

				If value Is Nothing Then
				
					Me.FldPrimaryRecTypeId = Nothing
				
					Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId = Nothing
				Else
				
					Me.FldPrimaryRecTypeId = value.FldId
					
					Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId = value
					Me.SetPreSave("UpToTblMetaRecTypeByFldPrimaryRecTypeId", Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId)
				End If
				
			End Set	

		End Property
		#End Region

		#Region "UpToTblMetaRecTypeByFldSecondaryRecTypeId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_tblMetaRecTypePair_fldSecondaryRecTypeId
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecTypeByFldSecondaryRecTypeId As TblMetaRecType
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId Is Nothing _
						 AndAlso Not FldSecondaryRecTypeId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId = New TblMetaRecType()
					Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecTypeByFldSecondaryRecTypeId", Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId)
					Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId.Query.Where(Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId.Query.FldId = Me.FldSecondaryRecTypeId)
					Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId.Query.Load()
				End If

				Return Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId
			End Get
			
            Set(ByVal value As TblMetaRecType)
				Me.RemovePreSave("UpToTblMetaRecTypeByFldSecondaryRecTypeId")
				

				If value Is Nothing Then
				
					Me.FldSecondaryRecTypeId = Nothing
				
					Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId = Nothing
				Else
				
					Me.FldSecondaryRecTypeId = value.FldId
					
					Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId = value
					Me.SetPreSave("UpToTblMetaRecTypeByFldSecondaryRecTypeId", Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId)
				End If
				
			End Set	

		End Property
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "BMRecommendationsCollectionByPrimaryRecTypeId"
					coll = Me.BMRecommendationsCollectionByPrimaryRecTypeId
					Exit Select
				Case "FireRecommendationsCollectionByPrimaryRecTypeId"
					coll = Me.FireRecommendationsCollectionByPrimaryRecTypeId
					Exit Select
				Case "TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId"
					coll = Me.TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "BMRecommendationsCollectionByPrimaryRecTypeId", GetType(BMRecommendationsCollection), New BMRecommendations()))
			props.Add(new esPropertyDescriptor(Me, "FireRecommendationsCollectionByPrimaryRecTypeId", GetType(FireRecommendationsCollection), New FireRecommendations()))
			props.Add(new esPropertyDescriptor(Me, "TblMetaRecTypePairPracticeCollectionByFldPrimaryRecTypeId", GetType(TblMetaRecTypePairPracticeCollection), New TblMetaRecTypePairPractice()))
			Return props
			
		End Function	
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
			If Not Me.es.IsDeleted And Not Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId Is Nothing Then
				Me.FldPrimaryRecTypeId = Me._UpToTblMetaRecTypeByFldPrimaryRecTypeId.FldId
			End If
			
			If Not Me.es.IsDeleted And Not Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId Is Nothing Then
				Me.FldSecondaryRecTypeId = Me._UpToTblMetaRecTypeByFldSecondaryRecTypeId.FldId
			End If
			
		End Sub
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaRecTypePairMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaRecTypePairMetadata.ColumnNames.FldPrimaryRecTypeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecTypePairMetadata.PropertyNames.FldPrimaryRecTypeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecTypePairMetadata.ColumnNames.FldSecondaryRecTypeId, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecTypePairMetadata.PropertyNames.FldSecondaryRecTypeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaRecTypePairMetadata
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
			 Public Const FldPrimaryRecTypeId As String = "fldPrimaryRecTypeId"
			 Public Const FldSecondaryRecTypeId As String = "fldSecondaryRecTypeId"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldPrimaryRecTypeId As String = "FldPrimaryRecTypeId"
			 Public Const FldSecondaryRecTypeId As String = "FldSecondaryRecTypeId"
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
			SyncLock GetType(TblMetaRecTypePairMetadata)
			
				If TblMetaRecTypePairMetadata.mapDelegates Is Nothing Then
					TblMetaRecTypePairMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaRecTypePairMetadata._meta Is Nothing Then
					TblMetaRecTypePairMetadata._meta = New TblMetaRecTypePairMetadata()
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
				


				meta.AddTypeMap("FldPrimaryRecTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldSecondaryRecTypeId", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "tblMetaRecTypePair"
				meta.Destination = "tblMetaRecTypePair"
				
				meta.spInsert = "proc_tblMetaRecTypePairInsert"
				meta.spUpdate = "proc_tblMetaRecTypePairUpdate"
				meta.spDelete = "proc_tblMetaRecTypePairDelete"
				meta.spLoadAll = "proc_tblMetaRecTypePairLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaRecTypePairLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaRecTypePairMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
