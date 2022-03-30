
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:24 PM
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
	' Encapsulates the 'NatHaz-Seismic-StructuralData' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazSeismicStructuralData))> _
	<XmlType("NatHazSeismicStructuralData")> _	
	Partial Public Class NatHazSeismicStructuralData 
		Inherits esNatHazSeismicStructuralData
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazSeismicStructuralData()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazSeismicStructuralData()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazSeismicStructuralData()
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
	<XmlType("NatHazSeismicStructuralDataCollection")> _
	Partial Public Class NatHazSeismicStructuralDataCollection
		Inherits esNatHazSeismicStructuralDataCollection
		Implements IEnumerable(Of NatHazSeismicStructuralData)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazSeismicStructuralData
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazSeismicStructuralData))> _
		Public Class NatHazSeismicStructuralDataCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazSeismicStructuralDataCollection)
			
			Public Shared Widening Operator CType(packet As NatHazSeismicStructuralDataCollectionWCFPacket) As NatHazSeismicStructuralDataCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazSeismicStructuralDataCollection) As NatHazSeismicStructuralDataCollectionWCFPacket
				Return New NatHazSeismicStructuralDataCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazSeismicStructuralDataQuery 
		Inherits esNatHazSeismicStructuralDataQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazSeismicStructuralDataQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazSeismicStructuralDataQuery) As String
			Return NatHazSeismicStructuralDataQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazSeismicStructuralDataQuery
			Return DirectCast(NatHazSeismicStructuralDataQuery.SerializeHelper.FromXml(query, GetType(NatHazSeismicStructuralDataQuery)), NatHazSeismicStructuralDataQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazSeismicStructuralData
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
		
			Dim query As New NatHazSeismicStructuralDataQuery()
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
		' Maps to NatHaz-Seismic-StructuralData.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazSeismicStructuralDataMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazSeismicStructuralDataMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralDataMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralDataMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicStructuralDataMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicStructuralDataMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.Code
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Code As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralDataMetadata.ColumnNames.Code)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralDataMetadata.ColumnNames.Code, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Code)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.Year
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Year As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralDataMetadata.ColumnNames.Year)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralDataMetadata.ColumnNames.Year, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Year)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.Benchmark
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Benchmark As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazSeismicStructuralDataMetadata.ColumnNames.Benchmark)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazSeismicStructuralDataMetadata.ColumnNames.Benchmark, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Benchmark)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.PercentofFloorArea
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PercentofFloorArea As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralDataMetadata.ColumnNames.PercentofFloorArea)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralDataMetadata.ColumnNames.PercentofFloorArea, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.PercentofFloorArea)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.Reoccupancy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Reoccupancy As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralDataMetadata.ColumnNames.Reoccupancy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralDataMetadata.ColumnNames.Reoccupancy, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Reoccupancy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.OtherCodeDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherCodeDescription As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralDataMetadata.ColumnNames.OtherCodeDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralDataMetadata.ColumnNames.OtherCodeDescription, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.OtherCodeDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicStructuralDataMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicStructuralDataMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-StructuralData.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicStructuralDataMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicStructuralDataMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Importorigdate)
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
												
						Case "SurveyDate"
							Me.str().SurveyDate = CType(value, string)
												
						Case "Code"
							Me.str().Code = CType(value, string)
												
						Case "Year"
							Me.str().Year = CType(value, string)
												
						Case "Benchmark"
							Me.str().Benchmark = CType(value, string)
												
						Case "PercentofFloorArea"
							Me.str().PercentofFloorArea = CType(value, string)
												
						Case "Reoccupancy"
							Me.str().Reoccupancy = CType(value, string)
												
						Case "OtherCodeDescription"
							Me.str().OtherCodeDescription = CType(value, string)
												
						Case "Importdate"
							Me.str().Importdate = CType(value, string)
												
						Case "Importorigdate"
							Me.str().Importorigdate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Year"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Year = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Year)
							End If
						
						Case "Benchmark"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Benchmark = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Benchmark)
							End If
						
						Case "PercentofFloorArea"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PercentofFloorArea = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.PercentofFloorArea)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicStructuralDataMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazSeismicStructuralData)
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
		  	
			Public Property SurveyDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SurveyDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurveyDate = Nothing
					Else
						entity.SurveyDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Code As System.String 
				Get
					Dim data_ As System.String = entity.Code
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Code = Nothing
					Else
						entity.Code = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Year As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Year
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Year = Nothing
					Else
						entity.Year = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Benchmark As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Benchmark
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Benchmark = Nothing
					Else
						entity.Benchmark = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property PercentofFloorArea As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PercentofFloorArea
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PercentofFloorArea = Nothing
					Else
						entity.PercentofFloorArea = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reoccupancy As System.String 
				Get
					Dim data_ As System.String = entity.Reoccupancy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reoccupancy = Nothing
					Else
						entity.Reoccupancy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherCodeDescription As System.String 
				Get
					Dim data_ As System.String = entity.OtherCodeDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherCodeDescription = Nothing
					Else
						entity.OtherCodeDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Importdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Importdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Importdate = Nothing
					Else
						entity.Importdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Importorigdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Importorigdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Importorigdate = Nothing
					Else
						entity.Importorigdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esNatHazSeismicStructuralData
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazSeismicStructuralDataMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazSeismicStructuralDataQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazSeismicStructuralDataQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazSeismicStructuralDataQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazSeismicStructuralDataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazSeismicStructuralDataQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazSeismicStructuralDataCollection
		Inherits esEntityCollection(Of NatHazSeismicStructuralData)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazSeismicStructuralDataMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazSeismicStructuralDataCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazSeismicStructuralDataQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazSeismicStructuralDataQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazSeismicStructuralDataQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazSeismicStructuralDataQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazSeismicStructuralDataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazSeismicStructuralDataQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazSeismicStructuralDataQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazSeismicStructuralDataQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazSeismicStructuralDataMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "SurveyDate" 
					Return Me.SurveyDate
				Case "Code" 
					Return Me.Code
				Case "Year" 
					Return Me.Year
				Case "Benchmark" 
					Return Me.Benchmark
				Case "PercentofFloorArea" 
					Return Me.PercentofFloorArea
				Case "Reoccupancy" 
					Return Me.Reoccupancy
				Case "OtherCodeDescription" 
					Return Me.OtherCodeDescription
				Case "Importdate" 
					Return Me.Importdate
				Case "Importorigdate" 
					Return Me.Importorigdate
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Code As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.Code, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Year As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.Year, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Benchmark As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.Benchmark, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property PercentofFloorArea As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.PercentofFloorArea, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Reoccupancy As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.Reoccupancy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherCodeDescription As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.OtherCodeDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralDataMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazSeismicStructuralDataMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.Code, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.Code
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.Year, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.Year
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.Benchmark, 5, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.Benchmark
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.PercentofFloorArea, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.PercentofFloorArea
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.Reoccupancy, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.Reoccupancy
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.OtherCodeDescription, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.OtherCodeDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.Importdate, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralDataMetadata.ColumnNames.Importorigdate, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicStructuralDataMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazSeismicStructuralDataMetadata
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
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Code As String = "Code"
			 Public Const Year As String = "Year"
			 Public Const Benchmark As String = "Benchmark"
			 Public Const PercentofFloorArea As String = "PercentofFloorArea"
			 Public Const Reoccupancy As String = "Reoccupancy"
			 Public Const OtherCodeDescription As String = "OtherCodeDescription"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Code As String = "Code"
			 Public Const Year As String = "Year"
			 Public Const Benchmark As String = "Benchmark"
			 Public Const PercentofFloorArea As String = "PercentofFloorArea"
			 Public Const Reoccupancy As String = "Reoccupancy"
			 Public Const OtherCodeDescription As String = "OtherCodeDescription"
			 Public Const Importdate As String = "Importdate"
			 Public Const Importorigdate As String = "Importorigdate"
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
			SyncLock GetType(NatHazSeismicStructuralDataMetadata)
			
				If NatHazSeismicStructuralDataMetadata.mapDelegates Is Nothing Then
					NatHazSeismicStructuralDataMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazSeismicStructuralDataMetadata._meta Is Nothing Then
					NatHazSeismicStructuralDataMetadata._meta = New NatHazSeismicStructuralDataMetadata()
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
				meta.AddTypeMap("SurveyDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Code", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Year", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Benchmark", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("PercentofFloorArea", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Reoccupancy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OtherCodeDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Seismic-StructuralData"
				meta.Destination = "NatHaz-Seismic-StructuralData"
				
				meta.spInsert = "proc_NatHaz-Seismic-StructuralDataInsert"
				meta.spUpdate = "proc_NatHaz-Seismic-StructuralDataUpdate"
				meta.spDelete = "proc_NatHaz-Seismic-StructuralDataDelete"
				meta.spLoadAll = "proc_NatHaz-Seismic-StructuralDataLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Seismic-StructuralDataLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazSeismicStructuralDataMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
