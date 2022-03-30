
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2013 1:05:38 PM
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
	' Encapsulates the 'viewCCDocumentLibraryForm' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCDocumentLibraryForm))> _
	<XmlType("ViewCCDocumentLibraryForm")> _	
	Partial Public Class ViewCCDocumentLibraryForm 
		Inherits esViewCCDocumentLibraryForm
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCDocumentLibraryForm()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCDocumentLibraryFormCollection")> _
	Partial Public Class ViewCCDocumentLibraryFormCollection
		Inherits esViewCCDocumentLibraryFormCollection
		Implements IEnumerable(Of ViewCCDocumentLibraryForm)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCDocumentLibraryForm))> _
		Public Class ViewCCDocumentLibraryFormCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCDocumentLibraryFormCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCDocumentLibraryFormCollectionWCFPacket) As ViewCCDocumentLibraryFormCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCDocumentLibraryFormCollection) As ViewCCDocumentLibraryFormCollectionWCFPacket
				Return New ViewCCDocumentLibraryFormCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCDocumentLibraryFormQuery 
		Inherits esViewCCDocumentLibraryFormQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCDocumentLibraryFormQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCDocumentLibraryFormQuery) As String
			Return ViewCCDocumentLibraryFormQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCDocumentLibraryFormQuery
			Return DirectCast(ViewCCDocumentLibraryFormQuery.SerializeHelper.FromXml(query, GetType(ViewCCDocumentLibraryFormQuery)), ViewCCDocumentLibraryFormQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCDocumentLibraryForm
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCDocumentLibraryFormMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCDocumentLibraryFormMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.ClientLocID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.ClientLocID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.ClientLocID, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.ClientLocID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.DocumentDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DocumentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCDocumentLibraryFormMetadata.ColumnNames.DocumentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCDocumentLibraryFormMetadata.ColumnNames.DocumentDate, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.DocumentDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.LinkToER
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToER As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToER)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToER, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.LinkToER)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.LinkToUROrLEReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToUROrLEReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToUROrLEReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToUROrLEReport, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.LinkToUROrLEReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.LinkToDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToDiagram, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.LinkToDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.Practice
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Practice As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Practice)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Practice, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.Practice)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.Address1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.St_Prov
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCDocumentLibraryForm.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCDocumentLibraryFormMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.Country)
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
												
						Case "ClientLocID"
							Me.str().ClientLocID = CType(value, string)
												
						Case "DocumentDate"
							Me.str().DocumentDate = CType(value, string)
												
						Case "LinkToER"
							Me.str().LinkToER = CType(value, string)
												
						Case "LinkToUROrLEReport"
							Me.str().LinkToUROrLEReport = CType(value, string)
												
						Case "LinkToDiagram"
							Me.str().LinkToDiagram = CType(value, string)
												
						Case "Practice"
							Me.str().Practice = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
												
						Case "Facility"
							Me.str().Facility = CType(value, string)
												
						Case "Address1"
							Me.str().Address1 = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "StProv"
							Me.str().StProv = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.Id)
							End If
						
						Case "DocumentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DocumentDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCDocumentLibraryFormMetadata.PropertyNames.DocumentDate)
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
		
			Public Sub New(ByVal entity As esViewCCDocumentLibraryForm)
				Me.entity = entity
			End Sub				
		
	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Id
					
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
						entity.Id = Convert.ToInt32(Value)
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
		  	
			Public Property ClientLocID As System.String 
				Get
					Dim data_ As System.String = entity.ClientLocID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClientLocID = Nothing
					Else
						entity.ClientLocID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DocumentDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DocumentDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DocumentDate = Nothing
					Else
						entity.DocumentDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToER As System.String 
				Get
					Dim data_ As System.String = entity.LinkToER
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkToER = Nothing
					Else
						entity.LinkToER = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToUROrLEReport As System.String 
				Get
					Dim data_ As System.String = entity.LinkToUROrLEReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkToUROrLEReport = Nothing
					Else
						entity.LinkToUROrLEReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToDiagram As System.String 
				Get
					Dim data_ As System.String = entity.LinkToDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkToDiagram = Nothing
					Else
						entity.LinkToDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Practice As System.String 
				Get
					Dim data_ As System.String = entity.Practice
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Practice = Nothing
					Else
						entity.Practice = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Division As System.String 
				Get
					Dim data_ As System.String = entity.Division
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Division = Nothing
					Else
						entity.Division = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Facility As System.String 
				Get
					Dim data_ As System.String = entity.Facility
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Facility = Nothing
					Else
						entity.Facility = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Address1 As System.String 
				Get
					Dim data_ As System.String = entity.Address1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address1 = Nothing
					Else
						entity.Address1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property City As System.String 
				Get
					Dim data_ As System.String = entity.City
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.City = Nothing
					Else
						entity.City = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StProv As System.String 
				Get
					Dim data_ As System.String = entity.StProv
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StProv = Nothing
					Else
						entity.StProv = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Country As System.String 
				Get
					Dim data_ As System.String = entity.Country
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Country = Nothing
					Else
						entity.Country = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCDocumentLibraryForm
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCDocumentLibraryFormMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCDocumentLibraryFormQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCDocumentLibraryFormQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCDocumentLibraryFormQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCDocumentLibraryFormQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCDocumentLibraryFormQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCDocumentLibraryFormCollection
		Inherits esEntityCollection(Of ViewCCDocumentLibraryForm)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCDocumentLibraryFormMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCDocumentLibraryFormCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCDocumentLibraryFormQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCDocumentLibraryFormQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCDocumentLibraryFormQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCDocumentLibraryFormQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCDocumentLibraryFormQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCDocumentLibraryFormQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCDocumentLibraryFormQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCDocumentLibraryFormQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCDocumentLibraryFormMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "ClientLocID" 
					Return Me.ClientLocID
				Case "DocumentDate" 
					Return Me.DocumentDate
				Case "LinkToER" 
					Return Me.LinkToER
				Case "LinkToUROrLEReport" 
					Return Me.LinkToUROrLEReport
				Case "LinkToDiagram" 
					Return Me.LinkToDiagram
				Case "Practice" 
					Return Me.Practice
				Case "Division" 
					Return Me.Division
				Case "Facility" 
					Return Me.Facility
				Case "Address1" 
					Return Me.Address1
				Case "City" 
					Return Me.City
				Case "StProv" 
					Return Me.StProv
				Case "Country" 
					Return Me.Country
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.ClientLocID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DocumentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.DocumentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToER As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToER, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToUROrLEReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToUROrLEReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Practice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.Practice, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCDocumentLibraryFormMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCDocumentLibraryFormMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.ClientLocID, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.ClientLocID
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.DocumentDate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.DocumentDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToER, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.LinkToER
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToUROrLEReport, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.LinkToUROrLEReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.LinkToDiagram, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.LinkToDiagram
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.Practice, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.Practice
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.Division, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.Facility, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.Address1, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.City, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.StProv, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCDocumentLibraryFormMetadata.ColumnNames.Country, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCDocumentLibraryFormMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCDocumentLibraryFormMetadata
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
			 Public Const ClientLocID As String = "ClientLocID"
			 Public Const DocumentDate As String = "DocumentDate"
			 Public Const LinkToER As String = "LinkToER"
			 Public Const LinkToUROrLEReport As String = "LinkToUROrLEReport"
			 Public Const LinkToDiagram As String = "LinkToDiagram"
			 Public Const Practice As String = "Practice"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const Address1 As String = "Address1"
			 Public Const City As String = "City"
			 Public Const StProv As String = "St_Prov"
			 Public Const Country As String = "Country"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const ClientLocID As String = "ClientLocID"
			 Public Const DocumentDate As String = "DocumentDate"
			 Public Const LinkToER As String = "LinkToER"
			 Public Const LinkToUROrLEReport As String = "LinkToUROrLEReport"
			 Public Const LinkToDiagram As String = "LinkToDiagram"
			 Public Const Practice As String = "Practice"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const Address1 As String = "Address1"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Country As String = "Country"
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
			SyncLock GetType(ViewCCDocumentLibraryFormMetadata)
			
				If ViewCCDocumentLibraryFormMetadata.mapDelegates Is Nothing Then
					ViewCCDocumentLibraryFormMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCDocumentLibraryFormMetadata._meta Is Nothing Then
					ViewCCDocumentLibraryFormMetadata._meta = New ViewCCDocumentLibraryFormMetadata()
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
				


				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ClientLocID", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DocumentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LinkToER", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkToUROrLEReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkToDiagram", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Practice", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Facility", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCDocumentLibraryForm"
				meta.Destination = "viewCCDocumentLibraryForm"
				
				meta.spInsert = "proc_viewCCDocumentLibraryFormInsert"
				meta.spUpdate = "proc_viewCCDocumentLibraryFormUpdate"
				meta.spDelete = "proc_viewCCDocumentLibraryFormDelete"
				meta.spLoadAll = "proc_viewCCDocumentLibraryFormLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCDocumentLibraryFormLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCDocumentLibraryFormMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
