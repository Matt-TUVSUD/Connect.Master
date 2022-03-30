
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
	' Encapsulates the 'Cope-Boiler04b-ElectricalRotatingEquipment' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BmElectricalRotatingEquipment))> _
	<XmlType("BmElectricalRotatingEquipment")> _	
	Partial Public Class BmElectricalRotatingEquipment 
		Inherits esBmElectricalRotatingEquipment
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BmElectricalRotatingEquipment()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New BmElectricalRotatingEquipment()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BmElectricalRotatingEquipment()
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
	<XmlType("BmElectricalRotatingEquipmentCollection")> _
	Partial Public Class BmElectricalRotatingEquipmentCollection
		Inherits esBmElectricalRotatingEquipmentCollection
		Implements IEnumerable(Of BmElectricalRotatingEquipment)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As BmElectricalRotatingEquipment
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BmElectricalRotatingEquipment))> _
		Public Class BmElectricalRotatingEquipmentCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BmElectricalRotatingEquipmentCollection)
			
			Public Shared Widening Operator CType(packet As BmElectricalRotatingEquipmentCollectionWCFPacket) As BmElectricalRotatingEquipmentCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BmElectricalRotatingEquipmentCollection) As BmElectricalRotatingEquipmentCollectionWCFPacket
				Return New BmElectricalRotatingEquipmentCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BmElectricalRotatingEquipmentQuery 
		Inherits esBmElectricalRotatingEquipmentQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BmElectricalRotatingEquipmentQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BmElectricalRotatingEquipmentQuery) As String
			Return BmElectricalRotatingEquipmentQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BmElectricalRotatingEquipmentQuery
			Return DirectCast(BmElectricalRotatingEquipmentQuery.SerializeHelper.FromXml(query, GetType(BmElectricalRotatingEquipmentQuery)), BmElectricalRotatingEquipmentQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBmElectricalRotatingEquipment
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
		
			Dim query As New BmElectricalRotatingEquipmentQuery()
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
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmElectricalRotatingEquipmentMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmElectricalRotatingEquipmentMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.ItemNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ItemNo As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(BmElectricalRotatingEquipmentMetadata.ColumnNames.ItemNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(BmElectricalRotatingEquipmentMetadata.ColumnNames.ItemNo, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.ItemNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.Item
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Item As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Item)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Item, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.Item)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.Type
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Type, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.Type)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.GenDriver
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GenDriver As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.GenDriver)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.GenDriver, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.GenDriver)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.Manfacturer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Manfacturer As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Manfacturer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Manfacturer, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.Manfacturer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.KVAHP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Kvahp As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Kvahp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Kvahp, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.Kvahp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.Voltage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Voltage As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Voltage)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Voltage, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.Voltage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalRotatingEquipmentMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04b-ElectricalRotatingEquipment.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BmElectricalRotatingEquipmentMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BmElectricalRotatingEquipmentMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.FilePrefix)
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
												
						Case "Item"
							Me.str().Item = CType(value, string)
												
						Case "Type"
							Me.str().Type = CType(value, string)
												
						Case "GenDriver"
							Me.str().GenDriver = CType(value, string)
												
						Case "Manfacturer"
							Me.str().Manfacturer = CType(value, string)
												
						Case "Kvahp"
							Me.str().Kvahp = CType(value, string)
												
						Case "Voltage"
							Me.str().Voltage = CType(value, string)
												
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
								OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.Id)
							End If
						
						Case "ItemNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.ItemNo = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.ItemNo)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BmElectricalRotatingEquipmentMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBmElectricalRotatingEquipment)
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
		  	
			Public Property Item As System.String 
				Get
					Dim data_ As System.String = entity.Item
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Item = Nothing
					Else
						entity.Item = Convert.ToString(Value)
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
		  	
			Public Property GenDriver As System.String 
				Get
					Dim data_ As System.String = entity.GenDriver
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GenDriver = Nothing
					Else
						entity.GenDriver = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Manfacturer As System.String 
				Get
					Dim data_ As System.String = entity.Manfacturer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Manfacturer = Nothing
					Else
						entity.Manfacturer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Kvahp As System.String 
				Get
					Dim data_ As System.String = entity.Kvahp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kvahp = Nothing
					Else
						entity.Kvahp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Voltage As System.String 
				Get
					Dim data_ As System.String = entity.Voltage
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Voltage = Nothing
					Else
						entity.Voltage = Convert.ToString(Value)
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
		  

			Private entity As esBmElectricalRotatingEquipment
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmElectricalRotatingEquipmentMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BmElectricalRotatingEquipmentQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmElectricalRotatingEquipmentQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BmElectricalRotatingEquipmentQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BmElectricalRotatingEquipmentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BmElectricalRotatingEquipmentQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBmElectricalRotatingEquipmentCollection
		Inherits esEntityCollection(Of BmElectricalRotatingEquipment)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmElectricalRotatingEquipmentMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BmElectricalRotatingEquipmentCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BmElectricalRotatingEquipmentQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmElectricalRotatingEquipmentQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BmElectricalRotatingEquipmentQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BmElectricalRotatingEquipmentQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BmElectricalRotatingEquipmentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BmElectricalRotatingEquipmentQuery))
		End Sub
		
		#End Region
						
		Private m_query As BmElectricalRotatingEquipmentQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBmElectricalRotatingEquipmentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BmElectricalRotatingEquipmentMetadata.Meta()
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
				Case "Item" 
					Return Me.Item
				Case "Type" 
					Return Me.Type
				Case "GenDriver" 
					Return Me.GenDriver
				Case "Manfacturer" 
					Return Me.Manfacturer
				Case "Kvahp" 
					Return Me.Kvahp
				Case "Voltage" 
					Return Me.Voltage
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
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.ItemNo, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Item As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.Item, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GenDriver As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.GenDriver, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Manfacturer As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.Manfacturer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Kvahp As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.Kvahp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Voltage As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.Voltage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalRotatingEquipmentMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BmElectricalRotatingEquipment 
		Inherits esBmElectricalRotatingEquipment
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BmElectricalRotatingEquipmentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.ItemNo, 2, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.ItemNo
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.Item, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.Item
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.Type, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.Type
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.GenDriver, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.GenDriver
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.Manfacturer, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.Manfacturer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.Kvahp, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.Kvahp
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.Voltage, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.Voltage
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.Comments, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalRotatingEquipmentMetadata.ColumnNames.FilePrefix, 10, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BmElectricalRotatingEquipmentMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BmElectricalRotatingEquipmentMetadata
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
			 Public Const Item As String = "Item"
			 Public Const Type As String = "Type"
			 Public Const GenDriver As String = "GenDriver"
			 Public Const Manfacturer As String = "Manfacturer"
			 Public Const Kvahp As String = "KVAHP"
			 Public Const Voltage As String = "Voltage"
			 Public Const Comments As String = "Comments"
			 Public Const FilePrefix As String = "FilePrefix"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const Item As String = "Item"
			 Public Const Type As String = "Type"
			 Public Const GenDriver As String = "GenDriver"
			 Public Const Manfacturer As String = "Manfacturer"
			 Public Const Kvahp As String = "Kvahp"
			 Public Const Voltage As String = "Voltage"
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
			SyncLock GetType(BmElectricalRotatingEquipmentMetadata)
			
				If BmElectricalRotatingEquipmentMetadata.mapDelegates Is Nothing Then
					BmElectricalRotatingEquipmentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BmElectricalRotatingEquipmentMetadata._meta Is Nothing Then
					BmElectricalRotatingEquipmentMetadata._meta = New BmElectricalRotatingEquipmentMetadata()
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
				meta.AddTypeMap("Item", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GenDriver", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Manfacturer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Kvahp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Voltage", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))			
				
				
				 
                meta.Source = "Cope-BMElectricalRotatingEquipment"
                meta.Destination = "Cope-BMElectricalRotatingEquipment"
				
				meta.spInsert = "proc_Cope-Boiler04b-ElectricalRotatingEquipmentInsert"
				meta.spUpdate = "proc_Cope-Boiler04b-ElectricalRotatingEquipmentUpdate"
				meta.spDelete = "proc_Cope-Boiler04b-ElectricalRotatingEquipmentDelete"
				meta.spLoadAll = "proc_Cope-Boiler04b-ElectricalRotatingEquipmentLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-Boiler04b-ElectricalRotatingEquipmentLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BmElectricalRotatingEquipmentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
