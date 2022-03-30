
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/19/2013 1:35:42 PM
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
	' Encapsulates the 'FirePlanReview' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(FirePlanReview))> _
	<XmlType("FirePlanReview")> _	
	Partial Public Class FirePlanReview 
		Inherits esFirePlanReview
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New FirePlanReview()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Decimal)
			Dim obj As New FirePlanReview()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Decimal, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New FirePlanReview()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("FirePlanReviewCollection")> _
	Partial Public Class FirePlanReviewCollection
		Inherits esFirePlanReviewCollection
		Implements IEnumerable(Of FirePlanReview)
	
		Public Function FindByPrimaryKey(ByVal id As System.Decimal) As FirePlanReview
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(FirePlanReview))> _
		Public Class FirePlanReviewCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of FirePlanReviewCollection)
			
			Public Shared Widening Operator CType(packet As FirePlanReviewCollectionWCFPacket) As FirePlanReviewCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As FirePlanReviewCollection) As FirePlanReviewCollectionWCFPacket
				Return New FirePlanReviewCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class FirePlanReviewQuery 
		Inherits esFirePlanReviewQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "FirePlanReviewQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As FirePlanReviewQuery) As String
			Return FirePlanReviewQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As FirePlanReviewQuery
			Return DirectCast(FirePlanReviewQuery.SerializeHelper.FromXml(query, GetType(FirePlanReviewQuery)), FirePlanReviewQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esFirePlanReview
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Decimal) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Decimal) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Decimal) As Boolean
		
			Dim query As New FirePlanReviewQuery()
			query.Where(query.Id = id)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Decimal) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to FirePlanReview.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(FirePlanReviewMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(FirePlanReviewMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(FirePlanReviewMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FirePlanReviewMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.Contact
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Contact As System.String
			Get
				Return MyBase.GetSystemString(FirePlanReviewMetadata.ColumnNames.Contact)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FirePlanReviewMetadata.ColumnNames.Contact, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Contact)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.Contact Phone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContactPhone As System.String
			Get
				Return MyBase.GetSystemString(FirePlanReviewMetadata.ColumnNames.ContactPhone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FirePlanReviewMetadata.ColumnNames.ContactPhone, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.ContactPhone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.Subject
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Subject As System.String
			Get
				Return MyBase.GetSystemString(FirePlanReviewMetadata.ColumnNames.Subject)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FirePlanReviewMetadata.ColumnNames.Subject, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Subject)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.Consultant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Consultant As System.String
			Get
				Return MyBase.GetSystemString(FirePlanReviewMetadata.ColumnNames.Consultant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FirePlanReviewMetadata.ColumnNames.Consultant, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Consultant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.Received
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Received As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(FirePlanReviewMetadata.ColumnNames.Received)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(FirePlanReviewMetadata.ColumnNames.Received, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Received)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.Mailed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mailed As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(FirePlanReviewMetadata.ColumnNames.Mailed)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(FirePlanReviewMetadata.ColumnNames.Mailed, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Mailed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.To Review
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToReview As System.String
			Get
				Return MyBase.GetSystemString(FirePlanReviewMetadata.ColumnNames.ToReview)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FirePlanReviewMetadata.ColumnNames.ToReview, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.ToReview)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.ProjectNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProjectNo As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(FirePlanReviewMetadata.ColumnNames.ProjectNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(FirePlanReviewMetadata.ColumnNames.ProjectNo, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.ProjectNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to FirePlanReview.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(FirePlanReviewMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FirePlanReviewMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Comments)
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
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "Contact"
							Me.str().Contact = CType(value, string)
												
						Case "ContactPhone"
							Me.str().ContactPhone = CType(value, string)
												
						Case "Subject"
							Me.str().Subject = CType(value, string)
												
						Case "Consultant"
							Me.str().Consultant = CType(value, string)
												
						Case "Received"
							Me.str().Received = CType(value, string)
												
						Case "Mailed"
							Me.str().Mailed = CType(value, string)
												
						Case "ToReview"
							Me.str().ToReview = CType(value, string)
												
						Case "ProjectNo"
							Me.str().ProjectNo = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Id = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Id)
							End If
						
						Case "Received"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Received = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Received)
							End If
						
						Case "Mailed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Mailed = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.Mailed)
							End If
						
						Case "ProjectNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.ProjectNo = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(FirePlanReviewMetadata.PropertyNames.ProjectNo)
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
		
			Public Sub New(ByVal entity As esFirePlanReview)
				Me.entity = entity
			End Sub				
		
	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Id
					
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
						entity.Id = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FileNo As System.String 
				Get
					Dim data_ As System.String = entity.FileNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FileNo = Nothing
					Else
						entity.FileNo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Contact As System.String 
				Get
					Dim data_ As System.String = entity.Contact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Contact = Nothing
					Else
						entity.Contact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContactPhone As System.String 
				Get
					Dim data_ As System.String = entity.ContactPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContactPhone = Nothing
					Else
						entity.ContactPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Subject As System.String 
				Get
					Dim data_ As System.String = entity.Subject
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Subject = Nothing
					Else
						entity.Subject = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consultant As System.String 
				Get
					Dim data_ As System.String = entity.Consultant
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consultant = Nothing
					Else
						entity.Consultant = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Received As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Received
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Received = Nothing
					Else
						entity.Received = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mailed As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Mailed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mailed = Nothing
					Else
						entity.Mailed = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToReview As System.String 
				Get
					Dim data_ As System.String = entity.ToReview
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToReview = Nothing
					Else
						entity.ToReview = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProjectNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.ProjectNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProjectNo = Nothing
					Else
						entity.ProjectNo = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Comments As System.String 
				Get
					Dim data_ As System.String = entity.Comments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Comments = Nothing
					Else
						entity.Comments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esFirePlanReview
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return FirePlanReviewMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As FirePlanReviewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New FirePlanReviewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As FirePlanReviewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As FirePlanReviewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As FirePlanReviewQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esFirePlanReviewCollection
		Inherits esEntityCollection(Of FirePlanReview)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return FirePlanReviewMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "FirePlanReviewCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As FirePlanReviewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New FirePlanReviewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As FirePlanReviewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New FirePlanReviewQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As FirePlanReviewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, FirePlanReviewQuery))
		End Sub
		
		#End Region
						
		Private m_query As FirePlanReviewQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esFirePlanReviewQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FirePlanReviewMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "Contact" 
					Return Me.Contact
				Case "ContactPhone" 
					Return Me.ContactPhone
				Case "Subject" 
					Return Me.Subject
				Case "Consultant" 
					Return Me.Consultant
				Case "Received" 
					Return Me.Received
				Case "Mailed" 
					Return Me.Mailed
				Case "ToReview" 
					Return Me.ToReview
				Case "ProjectNo" 
					Return Me.ProjectNo
				Case "Comments" 
					Return Me.Comments
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.Id, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Contact As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.Contact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContactPhone As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.ContactPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Subject As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.Subject, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consultant As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.Consultant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Received As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.Received, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Mailed As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.Mailed, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToReview As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.ToReview, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProjectNo As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.ProjectNo, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, FirePlanReviewMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class FirePlanReviewMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.Id, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.Contact, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.Contact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.ContactPhone, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.ContactPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.Subject, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.Subject
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.Consultant, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.Consultant
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.Received, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.Received
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.Mailed, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.Mailed
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.ToReview, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.ToReview
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.ProjectNo, 9, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.ProjectNo
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FirePlanReviewMetadata.ColumnNames.Comments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = FirePlanReviewMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As FirePlanReviewMetadata
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
			 Public Const Id As String = "ID"
			 Public Const FileNo As String = "FileNo"
			 Public Const Contact As String = "Contact"
			 Public Const ContactPhone As String = "Contact Phone"
			 Public Const Subject As String = "Subject"
			 Public Const Consultant As String = "Consultant"
			 Public Const Received As String = "Received"
			 Public Const Mailed As String = "Mailed"
			 Public Const ToReview As String = "To Review"
			 Public Const ProjectNo As String = "ProjectNo"
			 Public Const Comments As String = "Comments"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const Contact As String = "Contact"
			 Public Const ContactPhone As String = "ContactPhone"
			 Public Const Subject As String = "Subject"
			 Public Const Consultant As String = "Consultant"
			 Public Const Received As String = "Received"
			 Public Const Mailed As String = "Mailed"
			 Public Const ToReview As String = "ToReview"
			 Public Const ProjectNo As String = "ProjectNo"
			 Public Const Comments As String = "Comments"
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
			SyncLock GetType(FirePlanReviewMetadata)
			
				If FirePlanReviewMetadata.mapDelegates Is Nothing Then
					FirePlanReviewMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If FirePlanReviewMetadata._meta Is Nothing Then
					FirePlanReviewMetadata._meta = New FirePlanReviewMetadata()
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
				


				meta.AddTypeMap("Id", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Contact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ContactPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Subject", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consultant", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Received", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Mailed", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ToReview", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProjectNo", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "FirePlanReview"
				meta.Destination = "FirePlanReview"
				
				meta.spInsert = "proc_FirePlanReviewInsert"
				meta.spUpdate = "proc_FirePlanReviewUpdate"
				meta.spDelete = "proc_FirePlanReviewDelete"
				meta.spLoadAll = "proc_FirePlanReviewLoadAll"
				meta.spLoadByPrimaryKey = "proc_FirePlanReviewLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As FirePlanReviewMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
