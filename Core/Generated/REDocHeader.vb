
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/10/2013 3:55:29 PM
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
	' Encapsulates the 'REDocHeader' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(REDocHeader))> _
	<XmlType("REDocHeader")> _	
	Partial Public Class REDocHeader 
		Inherits esREDocHeader
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New REDocHeader()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal rEDocId As System.Int32)
			Dim obj As New REDocHeader()
			obj.REDocId = rEDocId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal rEDocId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New REDocHeader()
			obj.REDocId = rEDocId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("REDocHeaderCollection")> _
	Partial Public Class REDocHeaderCollection
		Inherits esREDocHeaderCollection
		Implements IEnumerable(Of REDocHeader)
	
		Public Function FindByPrimaryKey(ByVal rEDocId As System.Int32) As REDocHeader
			Return MyBase.SingleOrDefault(Function(e) e.REDocId.HasValue AndAlso e.REDocId.Value = rEDocId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(REDocHeader))> _
		Public Class REDocHeaderCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of REDocHeaderCollection)
			
			Public Shared Widening Operator CType(packet As REDocHeaderCollectionWCFPacket) As REDocHeaderCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As REDocHeaderCollection) As REDocHeaderCollectionWCFPacket
				Return New REDocHeaderCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class REDocHeaderQuery 
		Inherits esREDocHeaderQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "REDocHeaderQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As REDocHeaderQuery) As String
			Return REDocHeaderQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As REDocHeaderQuery
			Return DirectCast(REDocHeaderQuery.SerializeHelper.FromXml(query, GetType(REDocHeaderQuery)), REDocHeaderQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esREDocHeader
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal rEDocId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(rEDocId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(rEDocId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal rEDocId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(rEDocId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(rEDocId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal rEDocId As System.Int32) As Boolean
		
			Dim query As New REDocHeaderQuery()
			query.Where(query.REDocId = rEDocId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal rEDocId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("REDocId", rEDocId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to REDocHeader.REDocId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property REDocId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(REDocHeaderMetadata.ColumnNames.REDocId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(REDocHeaderMetadata.ColumnNames.REDocId, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.REDocId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocHeader.REDocGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property REDocGUID As System.String
			Get
				Return MyBase.GetSystemString(REDocHeaderMetadata.ColumnNames.REDocGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(REDocHeaderMetadata.ColumnNames.REDocGUID, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.REDocGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocHeader.SafeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SafeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(REDocHeaderMetadata.ColumnNames.SafeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(REDocHeaderMetadata.ColumnNames.SafeId, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.SafeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocHeader.OwnerId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OwnerId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(REDocHeaderMetadata.ColumnNames.OwnerId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(REDocHeaderMetadata.ColumnNames.OwnerId, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.OwnerId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocHeader.RptSetId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RptSetId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(REDocHeaderMetadata.ColumnNames.RptSetId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(REDocHeaderMetadata.ColumnNames.RptSetId, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.RptSetId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocHeader.JobDefId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property JobDefId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(REDocHeaderMetadata.ColumnNames.JobDefId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(REDocHeaderMetadata.ColumnNames.JobDefId, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.JobDefId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocHeader.CreateDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CreateDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(REDocHeaderMetadata.ColumnNames.CreateDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(REDocHeaderMetadata.ColumnNames.CreateDate, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.CreateDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocHeader.AccessDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AccessDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(REDocHeaderMetadata.ColumnNames.AccessDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(REDocHeaderMetadata.ColumnNames.AccessDate, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.AccessDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to REDocHeader.FileSizeBytes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileSizeBytes As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(REDocHeaderMetadata.ColumnNames.FileSizeBytes)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(REDocHeaderMetadata.ColumnNames.FileSizeBytes, value) Then
					OnPropertyChanged(REDocHeaderMetadata.PropertyNames.FileSizeBytes)
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
												
						Case "REDocId"
							Me.str().REDocId = CType(value, string)
												
						Case "REDocGUID"
							Me.str().REDocGUID = CType(value, string)
												
						Case "SafeId"
							Me.str().SafeId = CType(value, string)
												
						Case "OwnerId"
							Me.str().OwnerId = CType(value, string)
												
						Case "RptSetId"
							Me.str().RptSetId = CType(value, string)
												
						Case "JobDefId"
							Me.str().JobDefId = CType(value, string)
												
						Case "CreateDate"
							Me.str().CreateDate = CType(value, string)
												
						Case "AccessDate"
							Me.str().AccessDate = CType(value, string)
												
						Case "FileSizeBytes"
							Me.str().FileSizeBytes = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "REDocId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.REDocId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(REDocHeaderMetadata.PropertyNames.REDocId)
							End If
						
						Case "SafeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SafeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(REDocHeaderMetadata.PropertyNames.SafeId)
							End If
						
						Case "OwnerId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.OwnerId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(REDocHeaderMetadata.PropertyNames.OwnerId)
							End If
						
						Case "RptSetId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RptSetId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(REDocHeaderMetadata.PropertyNames.RptSetId)
							End If
						
						Case "JobDefId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.JobDefId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(REDocHeaderMetadata.PropertyNames.JobDefId)
							End If
						
						Case "CreateDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CreateDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(REDocHeaderMetadata.PropertyNames.CreateDate)
							End If
						
						Case "AccessDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.AccessDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(REDocHeaderMetadata.PropertyNames.AccessDate)
							End If
						
						Case "FileSizeBytes"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FileSizeBytes = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(REDocHeaderMetadata.PropertyNames.FileSizeBytes)
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
		
			Public Sub New(ByVal entity As esREDocHeader)
				Me.entity = entity
			End Sub				
		
	
			Public Property REDocId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.REDocId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.REDocId = Nothing
					Else
						entity.REDocId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property REDocGUID As System.String 
				Get
					Dim data_ As System.String = entity.REDocGUID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.REDocGUID = Nothing
					Else
						entity.REDocGUID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SafeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SafeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SafeId = Nothing
					Else
						entity.SafeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property OwnerId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.OwnerId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OwnerId = Nothing
					Else
						entity.OwnerId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RptSetId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RptSetId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RptSetId = Nothing
					Else
						entity.RptSetId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property JobDefId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.JobDefId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.JobDefId = Nothing
					Else
						entity.JobDefId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreateDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CreateDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreateDate = Nothing
					Else
						entity.CreateDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property AccessDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.AccessDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AccessDate = Nothing
					Else
						entity.AccessDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property FileSizeBytes As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FileSizeBytes
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FileSizeBytes = Nothing
					Else
						entity.FileSizeBytes = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esREDocHeader
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return REDocHeaderMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As REDocHeaderQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New REDocHeaderQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As REDocHeaderQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As REDocHeaderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As REDocHeaderQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esREDocHeaderCollection
		Inherits esEntityCollection(Of REDocHeader)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return REDocHeaderMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "REDocHeaderCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As REDocHeaderQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New REDocHeaderQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As REDocHeaderQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New REDocHeaderQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As REDocHeaderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, REDocHeaderQuery))
		End Sub
		
		#End Region
						
		Private m_query As REDocHeaderQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esREDocHeaderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return REDocHeaderMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "REDocId" 
					Return Me.REDocId
				Case "REDocGUID" 
					Return Me.REDocGUID
				Case "SafeId" 
					Return Me.SafeId
				Case "OwnerId" 
					Return Me.OwnerId
				Case "RptSetId" 
					Return Me.RptSetId
				Case "JobDefId" 
					Return Me.JobDefId
				Case "CreateDate" 
					Return Me.CreateDate
				Case "AccessDate" 
					Return Me.AccessDate
				Case "FileSizeBytes" 
					Return Me.FileSizeBytes
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property REDocId As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.REDocId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property REDocGUID As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.REDocGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SafeId As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.SafeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OwnerId As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.OwnerId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RptSetId As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.RptSetId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property JobDefId As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.JobDefId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CreateDate As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.CreateDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AccessDate As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.AccessDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FileSizeBytes As esQueryItem
			Get
				Return New esQueryItem(Me, REDocHeaderMetadata.ColumnNames.FileSizeBytes, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class REDocHeaderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.REDocId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.REDocId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.REDocGUID, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.REDocGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.SafeId, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.SafeId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.OwnerId, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.OwnerId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.RptSetId, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.RptSetId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.JobDefId, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.JobDefId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.CreateDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.CreateDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.AccessDate, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.AccessDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(REDocHeaderMetadata.ColumnNames.FileSizeBytes, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = REDocHeaderMetadata.PropertyNames.FileSizeBytes
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As REDocHeaderMetadata
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
			 Public Const REDocId As String = "REDocId"
			 Public Const REDocGUID As String = "REDocGUID"
			 Public Const SafeId As String = "SafeId"
			 Public Const OwnerId As String = "OwnerId"
			 Public Const RptSetId As String = "RptSetId"
			 Public Const JobDefId As String = "JobDefId"
			 Public Const CreateDate As String = "CreateDate"
			 Public Const AccessDate As String = "AccessDate"
			 Public Const FileSizeBytes As String = "FileSizeBytes"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const REDocId As String = "REDocId"
			 Public Const REDocGUID As String = "REDocGUID"
			 Public Const SafeId As String = "SafeId"
			 Public Const OwnerId As String = "OwnerId"
			 Public Const RptSetId As String = "RptSetId"
			 Public Const JobDefId As String = "JobDefId"
			 Public Const CreateDate As String = "CreateDate"
			 Public Const AccessDate As String = "AccessDate"
			 Public Const FileSizeBytes As String = "FileSizeBytes"
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
			SyncLock GetType(REDocHeaderMetadata)
			
				If REDocHeaderMetadata.mapDelegates Is Nothing Then
					REDocHeaderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If REDocHeaderMetadata._meta Is Nothing Then
					REDocHeaderMetadata._meta = New REDocHeaderMetadata()
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
				


				meta.AddTypeMap("REDocId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("REDocGUID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SafeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("OwnerId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RptSetId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("JobDefId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("AccessDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("FileSizeBytes", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "REDocHeader"
				meta.Destination = "REDocHeader"
				
				meta.spInsert = "proc_REDocHeaderInsert"
				meta.spUpdate = "proc_REDocHeaderUpdate"
				meta.spDelete = "proc_REDocHeaderDelete"
				meta.spLoadAll = "proc_REDocHeaderLoadAll"
				meta.spLoadByPrimaryKey = "proc_REDocHeaderLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As REDocHeaderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
