
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/17/2013 1:57:00 PM
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
	' Encapsulates the 'Cope-Boiler05a-BPV' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BmBpvA))> _
	<XmlType("BmBpvA")> _	
	Partial Public Class BmBpvA 
		Inherits esBmBpvA
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BmBpvA()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New BmBpvA()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BmBpvA()
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
	<XmlType("BmBpvACollection")> _
	Partial Public Class BmBpvACollection
		Inherits esBmBpvACollection
		Implements IEnumerable(Of BmBpvA)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As BmBpvA
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BmBpvA))> _
		Public Class BmBpvACollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BmBpvACollection)
			
			Public Shared Widening Operator CType(packet As BmBpvACollectionWCFPacket) As BmBpvACollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BmBpvACollection) As BmBpvACollectionWCFPacket
				Return New BmBpvACollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BmBpvAQuery 
		Inherits esBmBpvAQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BmBpvAQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BmBpvAQuery) As String
			Return BmBpvAQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BmBpvAQuery
			Return DirectCast(BmBpvAQuery.SerializeHelper.FromXml(query, GetType(BmBpvAQuery)), BmBpvAQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBmBpvA
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
		
			Dim query As New BmBpvAQuery()
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
		' Maps to Cope-Boiler05a-BPV.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmBpvAMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmBpvAMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.ItemNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ItemNo As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(BmBpvAMetadata.ColumnNames.ItemNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(BmBpvAMetadata.ColumnNames.ItemNo, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.ItemNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.Manufacturer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Manufacturer As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.Manufacturer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.Manufacturer, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.Manufacturer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.Type
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.Type, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.Type)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.Service
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Service As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.Service)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.Service, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.Service)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.Capacity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Capacity As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.Capacity)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.Capacity, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.Capacity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.Pressure
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pressure As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.Pressure)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.Pressure, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.Pressure)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.Fuel
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fuel As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.Fuel)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.Fuel, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.Fuel)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.RentalAvailable
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RentalAvailable As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.RentalAvailable)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.RentalAvailable, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.RentalAvailable)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(BmBpvAMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmBpvAMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler05a-BPV.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BmBpvAMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BmBpvAMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BmBpvAMetadata.PropertyNames.FilePrefix)
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
												
						Case "Manufacturer"
							Me.str().Manufacturer = CType(value, string)
												
						Case "Type"
							Me.str().Type = CType(value, string)
												
						Case "Service"
							Me.str().Service = CType(value, string)
												
						Case "Capacity"
							Me.str().Capacity = CType(value, string)
												
						Case "Pressure"
							Me.str().Pressure = CType(value, string)
												
						Case "Fuel"
							Me.str().Fuel = CType(value, string)
												
						Case "RentalAvailable"
							Me.str().RentalAvailable = CType(value, string)
												
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
								OnPropertyChanged(BmBpvAMetadata.PropertyNames.Id)
							End If
						
						Case "ItemNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.ItemNo = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(BmBpvAMetadata.PropertyNames.ItemNo)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BmBpvAMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBmBpvA)
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
		  	
			Public Property Service As System.String 
				Get
					Dim data_ As System.String = entity.Service
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Service = Nothing
					Else
						entity.Service = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Capacity As System.String 
				Get
					Dim data_ As System.String = entity.Capacity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Capacity = Nothing
					Else
						entity.Capacity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pressure As System.String 
				Get
					Dim data_ As System.String = entity.Pressure
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pressure = Nothing
					Else
						entity.Pressure = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fuel As System.String 
				Get
					Dim data_ As System.String = entity.Fuel
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fuel = Nothing
					Else
						entity.Fuel = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RentalAvailable As System.String 
				Get
					Dim data_ As System.String = entity.RentalAvailable
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RentalAvailable = Nothing
					Else
						entity.RentalAvailable = Convert.ToString(Value)
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
		  

			Private entity As esBmBpvA
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmBpvAMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BmBpvAQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmBpvAQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BmBpvAQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BmBpvAQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BmBpvAQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBmBpvACollection
		Inherits esEntityCollection(Of BmBpvA)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmBpvAMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BmBpvACollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BmBpvAQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmBpvAQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BmBpvAQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BmBpvAQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BmBpvAQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BmBpvAQuery))
		End Sub
		
		#End Region
						
		Private m_query As BmBpvAQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBmBpvAQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BmBpvAMetadata.Meta()
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
				Case "Manufacturer" 
					Return Me.Manufacturer
				Case "Type" 
					Return Me.Type
				Case "Service" 
					Return Me.Service
				Case "Capacity" 
					Return Me.Capacity
				Case "Pressure" 
					Return Me.Pressure
				Case "Fuel" 
					Return Me.Fuel
				Case "RentalAvailable" 
					Return Me.RentalAvailable
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
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.ItemNo, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Manufacturer As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.Manufacturer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Service As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.Service, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Capacity As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.Capacity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Pressure As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.Pressure, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fuel As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.Fuel, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RentalAvailable As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.RentalAvailable, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BmBpvAMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BmBpvA 
		Inherits esBmBpvA
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BmBpvAMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.ItemNo, 2, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.ItemNo
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.Manufacturer, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.Manufacturer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.Type, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.Type
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.Service, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.Service
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.Capacity, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.Capacity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.Pressure, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.Pressure
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.Fuel, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.Fuel
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.RentalAvailable, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.RentalAvailable
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.Comments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmBpvAMetadata.ColumnNames.FilePrefix, 11, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BmBpvAMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BmBpvAMetadata
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
			 Public Const Manufacturer As String = "Manufacturer"
			 Public Const Type As String = "Type"
			 Public Const Service As String = "Service"
			 Public Const Capacity As String = "Capacity"
			 Public Const Pressure As String = "Pressure"
			 Public Const Fuel As String = "Fuel"
			 Public Const RentalAvailable As String = "RentalAvailable"
			 Public Const Comments As String = "Comments"
			 Public Const FilePrefix As String = "FilePrefix"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const Manufacturer As String = "Manufacturer"
			 Public Const Type As String = "Type"
			 Public Const Service As String = "Service"
			 Public Const Capacity As String = "Capacity"
			 Public Const Pressure As String = "Pressure"
			 Public Const Fuel As String = "Fuel"
			 Public Const RentalAvailable As String = "RentalAvailable"
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
			SyncLock GetType(BmBpvAMetadata)
			
				If BmBpvAMetadata.mapDelegates Is Nothing Then
					BmBpvAMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BmBpvAMetadata._meta Is Nothing Then
					BmBpvAMetadata._meta = New BmBpvAMetadata()
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
				meta.AddTypeMap("Manufacturer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Service", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Capacity", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Pressure", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fuel", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RentalAvailable", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))			
				
				
				 
                meta.Source = "Cope-BMBPV"
                meta.Destination = "Cope-BMBPV"
				
				meta.spInsert = "proc_Cope-Boiler05a-BPVInsert"
				meta.spUpdate = "proc_Cope-Boiler05a-BPVUpdate"
				meta.spDelete = "proc_Cope-Boiler05a-BPVDelete"
				meta.spLoadAll = "proc_Cope-Boiler05a-BPVLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-Boiler05a-BPVLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BmBpvAMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
