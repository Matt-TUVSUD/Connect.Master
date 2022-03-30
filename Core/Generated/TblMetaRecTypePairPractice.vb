
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/10/2021 11:37:28 AM
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
	' Encapsulates the 'tblMetaRecTypePairPractice' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaRecTypePairPractice))> _
	<XmlType("TblMetaRecTypePairPractice")> _	
	Partial Public Class TblMetaRecTypePairPractice 
		Inherits esTblMetaRecTypePairPractice
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaRecTypePairPractice()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldPracticeId As System.Int32, ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32)
			Dim obj As New TblMetaRecTypePairPractice()
			obj.FldPracticeId = fldPracticeId
			obj.FldPrimaryRecTypeId = fldPrimaryRecTypeId
			obj.FldSecondaryRecTypeId = fldSecondaryRecTypeId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldPracticeId As System.Int32, ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaRecTypePairPractice()
			obj.FldPracticeId = fldPracticeId
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
	<XmlType("TblMetaRecTypePairPracticeCollection")> _
	Partial Public Class TblMetaRecTypePairPracticeCollection
		Inherits esTblMetaRecTypePairPracticeCollection
		Implements IEnumerable(Of TblMetaRecTypePairPractice)
	
		Public Function FindByPrimaryKey(ByVal fldPracticeId As System.Int32, ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As TblMetaRecTypePairPractice
			Return MyBase.SingleOrDefault(Function(e) e.FldPracticeId.HasValue AndAlso e.FldPracticeId.Value = fldPracticeId And e.FldPrimaryRecTypeId.HasValue AndAlso e.FldPrimaryRecTypeId.Value = fldPrimaryRecTypeId And e.FldSecondaryRecTypeId.HasValue AndAlso e.FldSecondaryRecTypeId.Value = fldSecondaryRecTypeId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaRecTypePairPractice))> _
		Public Class TblMetaRecTypePairPracticeCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaRecTypePairPracticeCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaRecTypePairPracticeCollectionWCFPacket) As TblMetaRecTypePairPracticeCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaRecTypePairPracticeCollection) As TblMetaRecTypePairPracticeCollectionWCFPacket
				Return New TblMetaRecTypePairPracticeCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaRecTypePairPracticeQuery 
		Inherits esTblMetaRecTypePairPracticeQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaRecTypePairPracticeQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaRecTypePairPracticeQuery) As String
			Return TblMetaRecTypePairPracticeQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaRecTypePairPracticeQuery
			Return DirectCast(TblMetaRecTypePairPracticeQuery.SerializeHelper.FromXml(query, GetType(TblMetaRecTypePairPracticeQuery)), TblMetaRecTypePairPracticeQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecTypePairPractice
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fldPracticeId As System.Int32, ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fldPracticeId, fldPrimaryRecTypeId, fldSecondaryRecTypeId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fldPracticeId, fldPrimaryRecTypeId, fldSecondaryRecTypeId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fldPracticeId As System.Int32, ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fldPracticeId, fldPrimaryRecTypeId, fldSecondaryRecTypeId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fldPracticeId, fldPrimaryRecTypeId, fldSecondaryRecTypeId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fldPracticeId As System.Int32, ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As Boolean
		
			Dim query As New TblMetaRecTypePairPracticeQuery()
			query.Where(query.FldPracticeId = fldPracticeId And query.FldPrimaryRecTypeId = fldPrimaryRecTypeId And query.FldSecondaryRecTypeId = fldSecondaryRecTypeId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fldPracticeId As System.Int32, ByVal fldPrimaryRecTypeId As System.Int32, ByVal fldSecondaryRecTypeId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FldPracticeId", fldPracticeId)
						parms.Add("FldPrimaryRecTypeId", fldPrimaryRecTypeId)
						parms.Add("FldSecondaryRecTypeId", fldSecondaryRecTypeId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to tblMetaRecTypePairPractice.fldPrimaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldPrimaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPrimaryRecTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPrimaryRecTypeId, value) Then
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecTypePairByFldPrimaryRecTypeId")
					OnPropertyChanged(TblMetaRecTypePairPracticeMetadata.PropertyNames.FldPrimaryRecTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRecTypePairPractice.fldSecondaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldSecondaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldSecondaryRecTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldSecondaryRecTypeId, value) Then
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecTypePairByFldPrimaryRecTypeId")
					OnPropertyChanged(TblMetaRecTypePairPracticeMetadata.PropertyNames.FldSecondaryRecTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRecTypePairPractice.fldPracticeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldPracticeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPracticeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPracticeId, value) Then
					OnPropertyChanged(TblMetaRecTypePairPracticeMetadata.PropertyNames.FldPracticeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRecTypePairPractice.fldIsImportable
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldIsImportable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldIsImportable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldIsImportable, value) Then
					OnPropertyChanged(TblMetaRecTypePairPracticeMetadata.PropertyNames.FldIsImportable)
				End If
			End Set
		End Property	
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToTblMetaRecTypePairByFldPrimaryRecTypeId As TblMetaRecTypePair
		
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
												
						Case "FldPrimaryRecTypeId"
							Me.str().FldPrimaryRecTypeId = CType(value, string)
												
						Case "FldSecondaryRecTypeId"
							Me.str().FldSecondaryRecTypeId = CType(value, string)
												
						Case "FldPracticeId"
							Me.str().FldPracticeId = CType(value, string)
												
						Case "FldIsImportable"
							Me.str().FldIsImportable = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FldPrimaryRecTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldPrimaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecTypePairPracticeMetadata.PropertyNames.FldPrimaryRecTypeId)
							End If
						
						Case "FldSecondaryRecTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldSecondaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecTypePairPracticeMetadata.PropertyNames.FldSecondaryRecTypeId)
							End If
						
						Case "FldPracticeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldPracticeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRecTypePairPracticeMetadata.PropertyNames.FldPracticeId)
							End If
						
						Case "FldIsImportable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FldIsImportable = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(TblMetaRecTypePairPracticeMetadata.PropertyNames.FldIsImportable)
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
		
			Public Sub New(ByVal entity As esTblMetaRecTypePairPractice)
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

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
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

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldSecondaryRecTypeId = Nothing
					Else
						entity.FldSecondaryRecTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldPracticeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldPracticeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldPracticeId = Nothing
					Else
						entity.FldPracticeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldIsImportable As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FldIsImportable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldIsImportable = Nothing
					Else
						entity.FldIsImportable = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esTblMetaRecTypePairPractice
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecTypePairPracticeMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaRecTypePairPracticeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecTypePairPracticeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRecTypePairPracticeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaRecTypePairPracticeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblMetaRecTypePairPracticeQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRecTypePairPracticeCollection
		Inherits esEntityCollection(Of TblMetaRecTypePairPractice)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRecTypePairPracticeMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaRecTypePairPracticeCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TblMetaRecTypePairPracticeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRecTypePairPracticeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TblMetaRecTypePairPracticeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaRecTypePairPracticeQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaRecTypePairPracticeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaRecTypePairPracticeQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaRecTypePairPracticeQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaRecTypePairPracticeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaRecTypePairPracticeMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldPrimaryRecTypeId" 
					Return Me.FldPrimaryRecTypeId
				Case "FldSecondaryRecTypeId" 
					Return Me.FldSecondaryRecTypeId
				Case "FldPracticeId" 
					Return Me.FldPracticeId
				Case "FldIsImportable" 
					Return Me.FldIsImportable
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FldPrimaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPrimaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldSecondaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecTypePairPracticeMetadata.ColumnNames.FldSecondaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldPracticeId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPracticeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldIsImportable As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRecTypePairPracticeMetadata.ColumnNames.FldIsImportable, esSystemType.Boolean)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaRecTypePairPractice 
		Inherits esTblMetaRecTypePairPractice
		
	
		#Region "UpToTblMetaRecTypePairByFldPrimaryRecTypeId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_tblMetaRecTypePairPractice
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecTypePairByFldPrimaryRecTypeId As TblMetaRecTypePair
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId Is Nothing _
						 AndAlso Not FldPrimaryRecTypeId.Equals(Nothing)  AndAlso Not FldSecondaryRecTypeId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId = New TblMetaRecTypePair()
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecTypePairByFldPrimaryRecTypeId", Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId)
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId.Query.Where(Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId.Query.FldPrimaryRecTypeId = Me.FldPrimaryRecTypeId)
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId.Query.Where(Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId.Query.FldSecondaryRecTypeId = Me.FldSecondaryRecTypeId)
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId.Query.Load()
				End If

				Return Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId
			End Get
			
            Set(ByVal value As TblMetaRecTypePair)
				Me.RemovePreSave("UpToTblMetaRecTypePairByFldPrimaryRecTypeId")
				

				If value Is Nothing Then
				
					Me.FldPrimaryRecTypeId = Nothing
				
					Me.FldSecondaryRecTypeId = Nothing
				
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId = Nothing
				Else
				
					Me.FldPrimaryRecTypeId = value.FldPrimaryRecTypeId
					
					Me.FldSecondaryRecTypeId = value.FldSecondaryRecTypeId
					
					Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId = value
					Me.SetPreSave("UpToTblMetaRecTypePairByFldPrimaryRecTypeId", Me._UpToTblMetaRecTypePairByFldPrimaryRecTypeId)
				End If
				
			End Set	

		End Property
		#End Region

		
		
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaRecTypePairPracticeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPrimaryRecTypeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecTypePairPracticeMetadata.PropertyNames.FldPrimaryRecTypeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldSecondaryRecTypeId, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecTypePairPracticeMetadata.PropertyNames.FldSecondaryRecTypeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldPracticeId, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRecTypePairPracticeMetadata.PropertyNames.FldPracticeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRecTypePairPracticeMetadata.ColumnNames.FldIsImportable, 3, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = TblMetaRecTypePairPracticeMetadata.PropertyNames.FldIsImportable
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaRecTypePairPracticeMetadata
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
			 Public Const FldPracticeId As String = "fldPracticeId"
			 Public Const FldIsImportable As String = "fldIsImportable"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldPrimaryRecTypeId As String = "FldPrimaryRecTypeId"
			 Public Const FldSecondaryRecTypeId As String = "FldSecondaryRecTypeId"
			 Public Const FldPracticeId As String = "FldPracticeId"
			 Public Const FldIsImportable As String = "FldIsImportable"
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
			SyncLock GetType(TblMetaRecTypePairPracticeMetadata)
			
				If TblMetaRecTypePairPracticeMetadata.mapDelegates Is Nothing Then
					TblMetaRecTypePairPracticeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaRecTypePairPracticeMetadata._meta Is Nothing Then
					TblMetaRecTypePairPracticeMetadata._meta = New TblMetaRecTypePairPracticeMetadata()
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
				meta.AddTypeMap("FldPracticeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldIsImportable", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "tblMetaRecTypePairPractice"
				meta.Destination = "tblMetaRecTypePairPractice"
				
				meta.spInsert = "proc_tblMetaRecTypePairPracticeInsert"
				meta.spUpdate = "proc_tblMetaRecTypePairPracticeUpdate"
				meta.spDelete = "proc_tblMetaRecTypePairPracticeDelete"
				meta.spLoadAll = "proc_tblMetaRecTypePairPracticeLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaRecTypePairPracticeLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaRecTypePairPracticeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
