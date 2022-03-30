
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/18/2013 3:43:19 PM
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
	' Encapsulates the 'BMPlanReview' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMPlanReview))> _
	<XmlType("BMPlanReview")> _	
	Partial Public Class BMPlanReview 
		Inherits esBMPlanReview
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMPlanReview()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Decimal)
			Dim obj As New BMPlanReview()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Decimal, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMPlanReview()
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
	<XmlType("BMPlanReviewCollection")> _
	Partial Public Class BMPlanReviewCollection
		Inherits esBMPlanReviewCollection
		Implements IEnumerable(Of BMPlanReview)
	
		Public Function FindByPrimaryKey(ByVal id As System.Decimal) As BMPlanReview
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMPlanReview))> _
		Public Class BMPlanReviewCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMPlanReviewCollection)
			
			Public Shared Widening Operator CType(packet As BMPlanReviewCollectionWCFPacket) As BMPlanReviewCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMPlanReviewCollection) As BMPlanReviewCollectionWCFPacket
				Return New BMPlanReviewCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMPlanReviewQuery 
		Inherits esBMPlanReviewQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMPlanReviewQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMPlanReviewQuery) As String
			Return BMPlanReviewQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMPlanReviewQuery
			Return DirectCast(BMPlanReviewQuery.SerializeHelper.FromXml(query, GetType(BMPlanReviewQuery)), BMPlanReviewQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMPlanReview
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
		
			Dim query As New BMPlanReviewQuery()
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
		' Maps to BMPlanReview.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BMPlanReviewMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(BMPlanReviewMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMPlanReviewMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMPlanReviewMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.Contact
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Contact As System.String
			Get
				Return MyBase.GetSystemString(BMPlanReviewMetadata.ColumnNames.Contact)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMPlanReviewMetadata.ColumnNames.Contact, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Contact)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.Contact Phone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContactPhone As System.String
			Get
				Return MyBase.GetSystemString(BMPlanReviewMetadata.ColumnNames.ContactPhone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMPlanReviewMetadata.ColumnNames.ContactPhone, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.ContactPhone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.Subject
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Subject As System.String
			Get
				Return MyBase.GetSystemString(BMPlanReviewMetadata.ColumnNames.Subject)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMPlanReviewMetadata.ColumnNames.Subject, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Subject)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.Consultant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Consultant As System.String
			Get
				Return MyBase.GetSystemString(BMPlanReviewMetadata.ColumnNames.Consultant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMPlanReviewMetadata.ColumnNames.Consultant, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Consultant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.Received
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Received As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMPlanReviewMetadata.ColumnNames.Received)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMPlanReviewMetadata.ColumnNames.Received, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Received)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.Mailed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mailed As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMPlanReviewMetadata.ColumnNames.Mailed)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMPlanReviewMetadata.ColumnNames.Mailed, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Mailed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.To Review
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToReview As System.String
			Get
				Return MyBase.GetSystemString(BMPlanReviewMetadata.ColumnNames.ToReview)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMPlanReviewMetadata.ColumnNames.ToReview, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.ToReview)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.ProjectNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProjectNo As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BMPlanReviewMetadata.ColumnNames.ProjectNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BMPlanReviewMetadata.ColumnNames.ProjectNo, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.ProjectNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BMPlanReview.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(BMPlanReviewMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMPlanReviewMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Comments)
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
								OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Id)
							End If
						
						Case "Received"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Received = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Received)
							End If
						
						Case "Mailed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Mailed = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.Mailed)
							End If
						
						Case "ProjectNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.ProjectNo = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BMPlanReviewMetadata.PropertyNames.ProjectNo)
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
		
			Public Sub New(ByVal entity As esBMPlanReview)
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
		  

			Private entity As esBMPlanReview
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMPlanReviewMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMPlanReviewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMPlanReviewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMPlanReviewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMPlanReviewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMPlanReviewQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMPlanReviewCollection
		Inherits esEntityCollection(Of BMPlanReview)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMPlanReviewMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMPlanReviewCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMPlanReviewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMPlanReviewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMPlanReviewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMPlanReviewQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMPlanReviewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMPlanReviewQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMPlanReviewQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMPlanReviewQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMPlanReviewMetadata.Meta()
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
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.Id, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Contact As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.Contact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContactPhone As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.ContactPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Subject As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.Subject, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consultant As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.Consultant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Received As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.Received, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Mailed As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.Mailed, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToReview As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.ToReview, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProjectNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.ProjectNo, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, BMPlanReviewMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class BMPlanReviewMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.Id, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.Contact, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.Contact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.ContactPhone, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.ContactPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.Subject, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.Subject
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.Consultant, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.Consultant
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.Received, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.Received
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.Mailed, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.Mailed
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.ToReview, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.ToReview
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.ProjectNo, 9, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.ProjectNo
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMPlanReviewMetadata.ColumnNames.Comments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMPlanReviewMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMPlanReviewMetadata
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
			SyncLock GetType(BMPlanReviewMetadata)
			
				If BMPlanReviewMetadata.mapDelegates Is Nothing Then
					BMPlanReviewMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMPlanReviewMetadata._meta Is Nothing Then
					BMPlanReviewMetadata._meta = New BMPlanReviewMetadata()
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
				
				
				 
				meta.Source = "BMPlanReview"
				meta.Destination = "BMPlanReview"
				
				meta.spInsert = "proc_BMPlanReviewInsert"
				meta.spUpdate = "proc_BMPlanReviewUpdate"
				meta.spDelete = "proc_BMPlanReviewDelete"
				meta.spLoadAll = "proc_BMPlanReviewLoadAll"
				meta.spLoadByPrimaryKey = "proc_BMPlanReviewLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMPlanReviewMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
