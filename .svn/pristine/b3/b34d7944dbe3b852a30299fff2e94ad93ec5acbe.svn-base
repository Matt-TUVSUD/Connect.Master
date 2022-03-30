
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/16/2016 12:10:16 PM
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
	' Encapsulates the 'tblMetaRatingKey' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaRatingKey))> _
	<XmlType("TblMetaRatingKey")> _	
	Partial Public Class TblMetaRatingKey 
		Inherits esTblMetaRatingKey
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaRatingKey()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldId As System.Int32)
			Dim obj As New TblMetaRatingKey()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaRatingKey()
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
	<XmlType("TblMetaRatingKeyCollection")> _
	Partial Public Class TblMetaRatingKeyCollection
		Inherits esTblMetaRatingKeyCollection
		Implements IEnumerable(Of TblMetaRatingKey)
	
		Public Function FindByPrimaryKey(ByVal fldId As System.Int32) As TblMetaRatingKey
			Return MyBase.SingleOrDefault(Function(e) e.FldId.HasValue AndAlso e.FldId.Value = fldId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaRatingKey))> _
		Public Class TblMetaRatingKeyCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaRatingKeyCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaRatingKeyCollectionWCFPacket) As TblMetaRatingKeyCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaRatingKeyCollection) As TblMetaRatingKeyCollectionWCFPacket
				Return New TblMetaRatingKeyCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaRatingKeyQuery 
		Inherits esTblMetaRatingKeyQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaRatingKeyQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaRatingKeyQuery) As String
			Return TblMetaRatingKeyQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaRatingKeyQuery
			Return DirectCast(TblMetaRatingKeyQuery.SerializeHelper.FromXml(query, GetType(TblMetaRatingKeyQuery)), TblMetaRatingKeyQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRatingKey
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
		
			Dim query As New TblMetaRatingKeyQuery()
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
		' Maps to tblMetaRatingKey.fldId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRatingKeyMetadata.ColumnNames.FldId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRatingKeyMetadata.ColumnNames.FldId, value) Then
					OnPropertyChanged(TblMetaRatingKeyMetadata.PropertyNames.FldId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRatingKey.fldAPLFactor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldAPLFactor As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(TblMetaRatingKeyMetadata.ColumnNames.FldAPLFactor)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(TblMetaRatingKeyMetadata.ColumnNames.FldAPLFactor, value) Then
					OnPropertyChanged(TblMetaRatingKeyMetadata.PropertyNames.FldAPLFactor)
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
												
						Case "FldAPLFactor"
							Me.str().FldAPLFactor = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FldId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRatingKeyMetadata.PropertyNames.FldId)
							End If
						
						Case "FldAPLFactor"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.FldAPLFactor = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(TblMetaRatingKeyMetadata.PropertyNames.FldAPLFactor)
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
		
			Public Sub New(ByVal entity As esTblMetaRatingKey)
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
		  	
			Public Property FldAPLFactor As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.FldAPLFactor
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldAPLFactor = Nothing
					Else
						entity.FldAPLFactor = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esTblMetaRatingKey
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRatingKeyMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaRatingKeyQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRatingKeyQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRatingKeyQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaRatingKeyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblMetaRatingKeyQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRatingKeyCollection
		Inherits esEntityCollection(Of TblMetaRatingKey)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRatingKeyMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaRatingKeyCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TblMetaRatingKeyQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRatingKeyQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TblMetaRatingKeyQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaRatingKeyQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaRatingKeyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaRatingKeyQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaRatingKeyQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaRatingKeyQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaRatingKeyMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldId" 
					Return Me.FldId
				Case "FldAPLFactor" 
					Return Me.FldAPLFactor
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FldId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyMetadata.ColumnNames.FldId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldAPLFactor As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyMetadata.ColumnNames.FldAPLFactor, esSystemType.Double)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaRatingKey 
		Inherits esTblMetaRatingKey
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaRatingKeyMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaRatingKeyMetadata.ColumnNames.FldId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRatingKeyMetadata.PropertyNames.FldId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRatingKeyMetadata.ColumnNames.FldAPLFactor, 1, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = TblMetaRatingKeyMetadata.PropertyNames.FldAPLFactor
			c.NumericPrecision = 15
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaRatingKeyMetadata
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
			 Public Const FldAPLFactor As String = "fldAPLFactor"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldId As String = "FldId"
			 Public Const FldAPLFactor As String = "FldAPLFactor"
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
			SyncLock GetType(TblMetaRatingKeyMetadata)
			
				If TblMetaRatingKeyMetadata.mapDelegates Is Nothing Then
					TblMetaRatingKeyMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaRatingKeyMetadata._meta Is Nothing Then
					TblMetaRatingKeyMetadata._meta = New TblMetaRatingKeyMetadata()
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
				meta.AddTypeMap("FldAPLFactor", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "tblMetaRatingKey"
				meta.Destination = "tblMetaRatingKey"
				
				meta.spInsert = "proc_tblMetaRatingKeyInsert"
				meta.spUpdate = "proc_tblMetaRatingKeyUpdate"
				meta.spDelete = "proc_tblMetaRatingKeyDelete"
				meta.spLoadAll = "proc_tblMetaRatingKeyLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaRatingKeyLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaRatingKeyMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
