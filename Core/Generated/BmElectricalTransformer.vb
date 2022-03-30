
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
	' Encapsulates the 'Cope-Boiler04a-ElectricalTransformers' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BmElectricalTransformer))> _
	<XmlType("BmElectricalTransformer")> _	
	Partial Public Class BmElectricalTransformer 
		Inherits esBmElectricalTransformer
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BmElectricalTransformer()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New BmElectricalTransformer()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BmElectricalTransformer()
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
	<XmlType("BmElectricalTransformerCollection")> _
	Partial Public Class BmElectricalTransformerCollection
		Inherits esBmElectricalTransformerCollection
		Implements IEnumerable(Of BmElectricalTransformer)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As BmElectricalTransformer
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BmElectricalTransformer))> _
		Public Class BmElectricalTransformerCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BmElectricalTransformerCollection)
			
			Public Shared Widening Operator CType(packet As BmElectricalTransformerCollectionWCFPacket) As BmElectricalTransformerCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BmElectricalTransformerCollection) As BmElectricalTransformerCollectionWCFPacket
				Return New BmElectricalTransformerCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BmElectricalTransformerQuery 
		Inherits esBmElectricalTransformerQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BmElectricalTransformerQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BmElectricalTransformerQuery) As String
			Return BmElectricalTransformerQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BmElectricalTransformerQuery
			Return DirectCast(BmElectricalTransformerQuery.SerializeHelper.FromXml(query, GetType(BmElectricalTransformerQuery)), BmElectricalTransformerQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBmElectricalTransformer
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
		
			Dim query As New BmElectricalTransformerQuery()
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
		' Maps to Cope-Boiler04a-ElectricalTransformers.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmElectricalTransformerMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmElectricalTransformerMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.ItemNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ItemNo As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(BmElectricalTransformerMetadata.ColumnNames.ItemNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(BmElectricalTransformerMetadata.ColumnNames.ItemNo, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.ItemNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.Manufacturer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Manufacturer As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.Manufacturer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.Manufacturer, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Manufacturer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.Year
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Year As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.Year)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.Year, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Year)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.Prim-Sec Voltage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimSecVoltage As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.PrimSecVoltage)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.PrimSecVoltage, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.PrimSecVoltage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.KVA
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Kva As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.Kva)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.Kva, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Kva)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.Type
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.Type, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Type)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BmElectricalTransformerMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BmElectricalTransformerMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.Solution
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Solution As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.Solution)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.Solution, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Solution)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler04a-ElectricalTransformers.Status
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(BmElectricalTransformerMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmElectricalTransformerMetadata.ColumnNames.Status, value) Then
					OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Status)
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
												
						Case "Year"
							Me.str().Year = CType(value, string)
												
						Case "PrimSecVoltage"
							Me.str().PrimSecVoltage = CType(value, string)
												
						Case "Kva"
							Me.str().Kva = CType(value, string)
												
						Case "Type"
							Me.str().Type = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "Solution"
							Me.str().Solution = CType(value, string)
												
						Case "Status"
							Me.str().Status = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.Id)
							End If
						
						Case "ItemNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.ItemNo = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.ItemNo)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BmElectricalTransformerMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBmElectricalTransformer)
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
		  	
			Public Property PrimSecVoltage As System.String 
				Get
					Dim data_ As System.String = entity.PrimSecVoltage
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimSecVoltage = Nothing
					Else
						entity.PrimSecVoltage = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Kva As System.String 
				Get
					Dim data_ As System.String = entity.Kva
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kva = Nothing
					Else
						entity.Kva = Convert.ToString(Value)
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
		  	
			Public Property Solution As System.String 
				Get
					Dim data_ As System.String = entity.Solution
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Solution = Nothing
					Else
						entity.Solution = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Status As System.String 
				Get
					Dim data_ As System.String = entity.Status
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Status = Nothing
					Else
						entity.Status = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBmElectricalTransformer
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmElectricalTransformerMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BmElectricalTransformerQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmElectricalTransformerQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BmElectricalTransformerQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BmElectricalTransformerQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BmElectricalTransformerQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBmElectricalTransformerCollection
		Inherits esEntityCollection(Of BmElectricalTransformer)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmElectricalTransformerMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BmElectricalTransformerCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BmElectricalTransformerQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmElectricalTransformerQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BmElectricalTransformerQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BmElectricalTransformerQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BmElectricalTransformerQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BmElectricalTransformerQuery))
		End Sub
		
		#End Region
						
		Private m_query As BmElectricalTransformerQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBmElectricalTransformerQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BmElectricalTransformerMetadata.Meta()
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
				Case "Year" 
					Return Me.Year
				Case "PrimSecVoltage" 
					Return Me.PrimSecVoltage
				Case "Kva" 
					Return Me.Kva
				Case "Type" 
					Return Me.Type
				Case "Comments" 
					Return Me.Comments
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "Solution" 
					Return Me.Solution
				Case "Status" 
					Return Me.Status
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.ItemNo, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Manufacturer As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.Manufacturer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Year As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.Year, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimSecVoltage As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.PrimSecVoltage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Kva As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.Kva, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Solution As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.Solution, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, BmElectricalTransformerMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class BmElectricalTransformerMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.ItemNo, 2, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.ItemNo
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.Manufacturer, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.Manufacturer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.Year, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.Year
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.PrimSecVoltage, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.PrimSecVoltage
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.Kva, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.Kva
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.Type, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.Type
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.Comments, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.FilePrefix, 9, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.Solution, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.Solution
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmElectricalTransformerMetadata.ColumnNames.Status, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmElectricalTransformerMetadata.PropertyNames.Status
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BmElectricalTransformerMetadata
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
			 Public Const Year As String = "Year"
			 Public Const PrimSecVoltage As String = "Prim-Sec Voltage"
			 Public Const Kva As String = "KVA"
			 Public Const Type As String = "Type"
			 Public Const Comments As String = "Comments"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Solution As String = "Solution"
			 Public Const Status As String = "Status"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const Manufacturer As String = "Manufacturer"
			 Public Const Year As String = "Year"
			 Public Const PrimSecVoltage As String = "PrimSecVoltage"
			 Public Const Kva As String = "Kva"
			 Public Const Type As String = "Type"
			 Public Const Comments As String = "Comments"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Solution As String = "Solution"
			 Public Const Status As String = "Status"
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
			SyncLock GetType(BmElectricalTransformerMetadata)
			
				If BmElectricalTransformerMetadata.mapDelegates Is Nothing Then
					BmElectricalTransformerMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BmElectricalTransformerMetadata._meta Is Nothing Then
					BmElectricalTransformerMetadata._meta = New BmElectricalTransformerMetadata()
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
				meta.AddTypeMap("Year", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PrimSecVoltage", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Kva", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Solution", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Status", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
                meta.Source = "Cope-BMElectricalTransformer"
                meta.Destination = "Cope-BMElectricalTransformer"
				
				meta.spInsert = "proc_Cope-Boiler04a-ElectricalTransformersInsert"
				meta.spUpdate = "proc_Cope-Boiler04a-ElectricalTransformersUpdate"
				meta.spDelete = "proc_Cope-Boiler04a-ElectricalTransformersDelete"
				meta.spLoadAll = "proc_Cope-Boiler04a-ElectricalTransformersLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-Boiler04a-ElectricalTransformersLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BmElectricalTransformerMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
