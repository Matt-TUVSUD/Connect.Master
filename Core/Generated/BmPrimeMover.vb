
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/11/2014 3:28:22 PM
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
	' Encapsulates the 'Cope-Boiler05c-PrimeMovers' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BmPrimeMover))> _
	<XmlType("BmPrimeMover")> _	
	Partial Public Class BmPrimeMover 
		Inherits esBmPrimeMover
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BmPrimeMover()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New BmPrimeMover()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BmPrimeMover()
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
	<XmlType("BmPrimeMoverCollection")> _
	Partial Public Class BmPrimeMoverCollection
		Inherits esBmPrimeMoverCollection
		Implements IEnumerable(Of BmPrimeMover)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As BmPrimeMover
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BmPrimeMover))> _
		Public Class BmPrimeMoverCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BmPrimeMoverCollection)
			
			Public Shared Widening Operator CType(packet As BmPrimeMoverCollectionWCFPacket) As BmPrimeMoverCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BmPrimeMoverCollection) As BmPrimeMoverCollectionWCFPacket
				Return New BmPrimeMoverCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BmPrimeMoverQuery 
		Inherits esBmPrimeMoverQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BmPrimeMoverQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BmPrimeMoverQuery) As String
			Return BmPrimeMoverQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BmPrimeMoverQuery
			Return DirectCast(BmPrimeMoverQuery.SerializeHelper.FromXml(query, GetType(BmPrimeMoverQuery)), BmPrimeMoverQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBmPrimeMover
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Int32) As Boolean
		
			Dim query As New BmPrimeMoverQuery()
			query.Where(query.Id = id)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmPrimeMoverMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmPrimeMoverMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BmPrimeMoverMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPrimeMoverMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.ItemNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ItemNo As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(BmPrimeMoverMetadata.ColumnNames.ItemNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(BmPrimeMoverMetadata.ColumnNames.ItemNo, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.ItemNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.Type
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(BmPrimeMoverMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPrimeMoverMetadata.ColumnNames.Type, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.Type)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.Model
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Model As System.String
			Get
				Return MyBase.GetSystemString(BmPrimeMoverMetadata.ColumnNames.Model)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPrimeMoverMetadata.ColumnNames.Model, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.Model)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.SerialNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SerialNumber As System.String
			Get
				Return MyBase.GetSystemString(BmPrimeMoverMetadata.ColumnNames.SerialNumber)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPrimeMoverMetadata.ColumnNames.SerialNumber, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.SerialNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.Manufacturer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Manufacturer As System.String
			Get
				Return MyBase.GetSystemString(BmPrimeMoverMetadata.ColumnNames.Manufacturer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPrimeMoverMetadata.ColumnNames.Manufacturer, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.Manufacturer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.KWHPCP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Kwhpcp As System.String
			Get
				Return MyBase.GetSystemString(BmPrimeMoverMetadata.ColumnNames.Kwhpcp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPrimeMoverMetadata.ColumnNames.Kwhpcp, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.Kwhpcp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.Year
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Year As System.String
			Get
				Return MyBase.GetSystemString(BmPrimeMoverMetadata.ColumnNames.Year)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPrimeMoverMetadata.ColumnNames.Year, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.Year)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.OverhaulDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverhaulDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BmPrimeMoverMetadata.ColumnNames.OverhaulDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BmPrimeMoverMetadata.ColumnNames.OverhaulDate, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.OverhaulDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.AssessmentDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AssessmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BmPrimeMoverMetadata.ColumnNames.AssessmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BmPrimeMoverMetadata.ColumnNames.AssessmentDate, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.AssessmentDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.NextMajorDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NextMajorDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BmPrimeMoverMetadata.ColumnNames.NextMajorDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BmPrimeMoverMetadata.ColumnNames.NextMajorDate, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.NextMajorDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(BmPrimeMoverMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPrimeMoverMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05c-PrimeMovers.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BmPrimeMoverMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BmPrimeMoverMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.FilePrefix)
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
												
						Case "ItemNo"
							Me.str().ItemNo = CType(value, string)
												
						Case "Type"
							Me.str().Type = CType(value, string)
												
						Case "Model"
							Me.str().Model = CType(value, string)
												
						Case "SerialNumber"
							Me.str().SerialNumber = CType(value, string)
												
						Case "Manufacturer"
							Me.str().Manufacturer = CType(value, string)
												
						Case "Kwhpcp"
							Me.str().Kwhpcp = CType(value, string)
												
						Case "Year"
							Me.str().Year = CType(value, string)
												
						Case "OverhaulDate"
							Me.str().OverhaulDate = CType(value, string)
												
						Case "AssessmentDate"
							Me.str().AssessmentDate = CType(value, string)
												
						Case "NextMajorDate"
							Me.str().NextMajorDate = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.Id)
							End If
						
						Case "ItemNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.ItemNo = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.ItemNo)
							End If
						
						Case "OverhaulDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.OverhaulDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.OverhaulDate)
							End If
						
						Case "AssessmentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.AssessmentDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.AssessmentDate)
							End If
						
						Case "NextMajorDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NextMajorDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.NextMajorDate)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BmPrimeMoverMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBmPrimeMover)
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
		  	
			Public Property ItemNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.ItemNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemNo = Nothing
					Else
						entity.ItemNo = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property Type As System.String 
				Get
					Dim data_ As System.String = entity.Type
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Type = Nothing
					Else
						entity.Type = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Model As System.String 
				Get
					Dim data_ As System.String = entity.Model
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Model = Nothing
					Else
						entity.Model = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SerialNumber As System.String 
				Get
					Dim data_ As System.String = entity.SerialNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SerialNumber = Nothing
					Else
						entity.SerialNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Manufacturer As System.String 
				Get
					Dim data_ As System.String = entity.Manufacturer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Manufacturer = Nothing
					Else
						entity.Manufacturer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Kwhpcp As System.String 
				Get
					Dim data_ As System.String = entity.Kwhpcp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kwhpcp = Nothing
					Else
						entity.Kwhpcp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Year As System.String 
				Get
					Dim data_ As System.String = entity.Year
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Year = Nothing
					Else
						entity.Year = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverhaulDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.OverhaulDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverhaulDate = Nothing
					Else
						entity.OverhaulDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property AssessmentDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.AssessmentDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AssessmentDate = Nothing
					Else
						entity.AssessmentDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NextMajorDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NextMajorDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NextMajorDate = Nothing
					Else
						entity.NextMajorDate = Convert.ToDateTime(Value)
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
		  	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.FilePrefix
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBmPrimeMover
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmPrimeMoverMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BmPrimeMoverQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmPrimeMoverQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BmPrimeMoverQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BmPrimeMoverQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BmPrimeMoverQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBmPrimeMoverCollection
		Inherits esEntityCollection(Of BmPrimeMover)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmPrimeMoverMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BmPrimeMoverCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BmPrimeMoverQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmPrimeMoverQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BmPrimeMoverQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BmPrimeMoverQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BmPrimeMoverQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BmPrimeMoverQuery))
		End Sub
		
		#End Region
						
		Private m_query As BmPrimeMoverQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBmPrimeMoverQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BmPrimeMoverMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "ItemNo" 
					Return Me.ItemNo
				Case "Type" 
					Return Me.Type
				Case "Model" 
					Return Me.Model
				Case "SerialNumber" 
					Return Me.SerialNumber
				Case "Manufacturer" 
					Return Me.Manufacturer
				Case "Kwhpcp" 
					Return Me.Kwhpcp
				Case "Year" 
					Return Me.Year
				Case "OverhaulDate" 
					Return Me.OverhaulDate
				Case "AssessmentDate" 
					Return Me.AssessmentDate
				Case "NextMajorDate" 
					Return Me.NextMajorDate
				Case "Comments" 
					Return Me.Comments
				Case "FilePrefix" 
					Return Me.FilePrefix
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.ItemNo, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Model As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.Model, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SerialNumber As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.SerialNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Manufacturer As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.Manufacturer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Kwhpcp As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.Kwhpcp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Year As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.Year, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverhaulDate As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.OverhaulDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AssessmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.AssessmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NextMajorDate As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.NextMajorDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BmPrimeMoverMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class BmPrimeMoverMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.ItemNo, 2, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.ItemNo
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.Type, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.Type
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.Model, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.Model
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.SerialNumber, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.SerialNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.Manufacturer, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.Manufacturer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.Kwhpcp, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.Kwhpcp
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.Year, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.Year
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.OverhaulDate, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.OverhaulDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.AssessmentDate, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.AssessmentDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.NextMajorDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.NextMajorDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.Comments, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPrimeMoverMetadata.ColumnNames.FilePrefix, 13, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BmPrimeMoverMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BmPrimeMoverMetadata
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
			 Public Const ItemNo As String = "ItemNo"
			 Public Const Type As String = "Type"
			 Public Const Model As String = "Model"
			 Public Const SerialNumber As String = "SerialNumber"
			 Public Const Manufacturer As String = "Manufacturer"
			 Public Const Kwhpcp As String = "KWHPCP"
			 Public Const Year As String = "Year"
			 Public Const OverhaulDate As String = "OverhaulDate"
			 Public Const AssessmentDate As String = "AssessmentDate"
			 Public Const NextMajorDate As String = "NextMajorDate"
			 Public Const Comments As String = "Comments"
			 Public Const FilePrefix As String = "FilePrefix"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const Type As String = "Type"
			 Public Const Model As String = "Model"
			 Public Const SerialNumber As String = "SerialNumber"
			 Public Const Manufacturer As String = "Manufacturer"
			 Public Const Kwhpcp As String = "Kwhpcp"
			 Public Const Year As String = "Year"
			 Public Const OverhaulDate As String = "OverhaulDate"
			 Public Const AssessmentDate As String = "AssessmentDate"
			 Public Const NextMajorDate As String = "NextMajorDate"
			 Public Const Comments As String = "Comments"
			 Public Const FilePrefix As String = "FilePrefix"
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
			SyncLock GetType(BmPrimeMoverMetadata)
			
				If BmPrimeMoverMetadata.mapDelegates Is Nothing Then
					BmPrimeMoverMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BmPrimeMoverMetadata._meta Is Nothing Then
					BmPrimeMoverMetadata._meta = New BmPrimeMoverMetadata()
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
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ItemNo", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Model", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SerialNumber", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Manufacturer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Kwhpcp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Year", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OverhaulDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("AssessmentDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("NextMajorDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))			
				
				
				 
                meta.Source = "Cope-BMPrimeMovers"
                meta.Destination = "Cope-BMPrimeMovers"
				
				meta.spInsert = "proc_Cope-Boiler05c-PrimeMoversInsert"
				meta.spUpdate = "proc_Cope-Boiler05c-PrimeMoversUpdate"
				meta.spDelete = "proc_Cope-Boiler05c-PrimeMoversDelete"
				meta.spLoadAll = "proc_Cope-Boiler05c-PrimeMoversLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-Boiler05c-PrimeMoversLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BmPrimeMoverMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
