
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/15/2013 3:38:38 PM
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
	' Encapsulates the 'ViewCCBMPlanReview' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCBMPlanReview))> _
	<XmlType("ViewCCBMPlanReview")> _	
	Partial Public Class ViewCCBMPlanReview 
		Inherits esViewCCBMPlanReview
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCBMPlanReview()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCBMPlanReviewCollection")> _
	Partial Public Class ViewCCBMPlanReviewCollection
		Inherits esViewCCBMPlanReviewCollection
		Implements IEnumerable(Of ViewCCBMPlanReview)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCBMPlanReview))> _
		Public Class ViewCCBMPlanReviewCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCBMPlanReviewCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCBMPlanReviewCollectionWCFPacket) As ViewCCBMPlanReviewCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCBMPlanReviewCollection) As ViewCCBMPlanReviewCollectionWCFPacket
				Return New ViewCCBMPlanReviewCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCBMPlanReviewQuery 
		Inherits esViewCCBMPlanReviewQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCBMPlanReviewQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCBMPlanReviewQuery) As String
			Return ViewCCBMPlanReviewQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCBMPlanReviewQuery
			Return DirectCast(ViewCCBMPlanReviewQuery.SerializeHelper.FromXml(query, GetType(ViewCCBMPlanReviewQuery)), ViewCCBMPlanReviewQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCBMPlanReview
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to ViewCCBMPlanReview.Id
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCBMPlanReviewMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCBMPlanReviewMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.Contact
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Contact As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.Contact)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.Contact, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Contact)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.ContactPhone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContactPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.ContactPhone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.ContactPhone, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.ContactPhone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.Subject
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Subject As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.Subject)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.Subject, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Subject)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.Consultant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Consultant As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.Consultant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.Consultant, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Consultant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.Received
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Received As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCBMPlanReviewMetadata.ColumnNames.Received)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCBMPlanReviewMetadata.ColumnNames.Received, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Received)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.Mailed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mailed As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCBMPlanReviewMetadata.ColumnNames.Mailed)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCBMPlanReviewMetadata.ColumnNames.Mailed, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Mailed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.ToReview
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToReview As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.ToReview)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.ToReview, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.ToReview)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.ProjectNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProjectNo As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCBMPlanReviewMetadata.ColumnNames.ProjectNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCBMPlanReviewMetadata.ColumnNames.ProjectNo, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.ProjectNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ViewCCBMPlanReview.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMPlanReviewMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Comments)
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
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
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
								OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Id)
							End If
						
						Case "Received"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Received = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Received)
							End If
						
						Case "Mailed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Mailed = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.Mailed)
							End If
						
						Case "ProjectNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.ProjectNo = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCBMPlanReviewMetadata.PropertyNames.ProjectNo)
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
		
			Public Sub New(ByVal entity As esViewCCBMPlanReview)
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
		  	
			Public Property PracticeCode As System.String 
				Get
					Dim data_ As System.String = entity.PracticeCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeCode = Nothing
					Else
						entity.PracticeCode = Convert.ToString(Value)
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
		  

			Private entity As esViewCCBMPlanReview
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCBMPlanReviewMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCBMPlanReviewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCBMPlanReviewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCBMPlanReviewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCBMPlanReviewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCBMPlanReviewQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCBMPlanReviewCollection
		Inherits esEntityCollection(Of ViewCCBMPlanReview)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCBMPlanReviewMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCBMPlanReviewCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCBMPlanReviewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCBMPlanReviewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCBMPlanReviewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCBMPlanReviewQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCBMPlanReviewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCBMPlanReviewQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCBMPlanReviewQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCBMPlanReviewQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCBMPlanReviewMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "PracticeCode" 
					Return Me.PracticeCode
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
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.Id, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.PracticeCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Contact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.Contact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContactPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.ContactPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Subject As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.Subject, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consultant As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.Consultant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Received As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.Received, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Mailed As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.Mailed, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToReview As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.ToReview, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProjectNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.ProjectNo, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMPlanReviewMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCBMPlanReviewMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.Id, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.PracticeCode, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.PracticeCode
			c.CharacterMaxLength = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.Contact, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.Contact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.ContactPhone, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.ContactPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.Subject, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.Subject
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.Consultant, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.Consultant
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.Received, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.Received
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.Mailed, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.Mailed
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.ToReview, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.ToReview
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.ProjectNo, 10, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.ProjectNo
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMPlanReviewMetadata.ColumnNames.Comments, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMPlanReviewMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCBMPlanReviewMetadata
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
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
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
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
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
			SyncLock GetType(ViewCCBMPlanReviewMetadata)
			
				If ViewCCBMPlanReviewMetadata.mapDelegates Is Nothing Then
					ViewCCBMPlanReviewMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCBMPlanReviewMetadata._meta Is Nothing Then
					ViewCCBMPlanReviewMetadata._meta = New ViewCCBMPlanReviewMetadata()
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
				meta.AddTypeMap("PracticeCode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Contact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ContactPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Subject", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consultant", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Received", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Mailed", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ToReview", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProjectNo", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "ViewCCBMPlanReview"
				meta.Destination = "ViewCCBMPlanReview"
				
				meta.spInsert = "proc_ViewCCBMPlanReviewInsert"
				meta.spUpdate = "proc_ViewCCBMPlanReviewUpdate"
				meta.spDelete = "proc_ViewCCBMPlanReviewDelete"
				meta.spLoadAll = "proc_ViewCCBMPlanReviewLoadAll"
				meta.spLoadByPrimaryKey = "proc_ViewCCBMPlanReviewLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCBMPlanReviewMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
