
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:40 AM
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
	' Encapsulates the 'Cope-FireConstruction' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(CopeFireConstruction))> _
	<XmlType("CopeFireConstruction")> _	
	Partial Public Class CopeFireConstruction 
		Inherits esCopeFireConstruction
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New CopeFireConstruction()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New CopeFireConstruction()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New CopeFireConstruction()
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
	<XmlType("CopeFireConstructionCollection")> _
	Partial Public Class CopeFireConstructionCollection
		Inherits esCopeFireConstructionCollection
		Implements IEnumerable(Of CopeFireConstruction)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As CopeFireConstruction
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(CopeFireConstruction))> _
		Public Class CopeFireConstructionCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of CopeFireConstructionCollection)
			
			Public Shared Widening Operator CType(packet As CopeFireConstructionCollectionWCFPacket) As CopeFireConstructionCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As CopeFireConstructionCollection) As CopeFireConstructionCollectionWCFPacket
				Return New CopeFireConstructionCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class CopeFireConstructionQuery 
		Inherits esCopeFireConstructionQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "CopeFireConstructionQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As CopeFireConstructionQuery) As String
			Return CopeFireConstructionQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As CopeFireConstructionQuery
			Return DirectCast(CopeFireConstructionQuery.SerializeHelper.FromXml(query, GetType(CopeFireConstructionQuery)), CopeFireConstructionQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esCopeFireConstruction
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
		
			Dim query As New CopeFireConstructionQuery()
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
		' Maps to Cope-FireConstruction.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeFireConstructionMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeFireConstructionMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.NoofStories
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoofStories As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.NoofStories)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.NoofStories, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.NoofStories)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.TotalFloorArea
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalFloorArea As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireConstructionMetadata.ColumnNames.TotalFloorArea)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireConstructionMetadata.ColumnNames.TotalFloorArea, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.TotalFloorArea)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.InititalMajorConstructionYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InititalMajorConstructionYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeFireConstructionMetadata.ColumnNames.InititalMajorConstructionYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeFireConstructionMetadata.ColumnNames.InititalMajorConstructionYear, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.InititalMajorConstructionYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.LastAdditionYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastAdditionYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeFireConstructionMetadata.ColumnNames.LastAdditionYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeFireConstructionMetadata.ColumnNames.LastAdditionYear, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.LastAdditionYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.BuildingHeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BuildingHeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeFireConstructionMetadata.ColumnNames.BuildingHeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeFireConstructionMetadata.ColumnNames.BuildingHeight, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.BuildingHeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.RoofConstructionFireResistive
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionFireResistive As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireConstructionMetadata.ColumnNames.RoofConstructionFireResistive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireConstructionMetadata.ColumnNames.RoofConstructionFireResistive, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionFireResistive)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.RoofConstructionNoncombustible
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionNoncombustible As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireConstructionMetadata.ColumnNames.RoofConstructionNoncombustible)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireConstructionMetadata.ColumnNames.RoofConstructionNoncombustible, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionNoncombustible)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.RoofConstructionCombustible
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionCombustible As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireConstructionMetadata.ColumnNames.RoofConstructionCombustible)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireConstructionMetadata.ColumnNames.RoofConstructionCombustible, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionCombustible)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.RoofConstructionClass
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionClass As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireConstructionMetadata.ColumnNames.RoofConstructionClass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireConstructionMetadata.ColumnNames.RoofConstructionClass, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionClass)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.RoofConstructionDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionDescription As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.RoofConstructionDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.RoofConstructionDescription, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.NoofFireAreas
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoofFireAreas As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireConstructionMetadata.ColumnNames.NoofFireAreas)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireConstructionMetadata.ColumnNames.NoofFireAreas, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.NoofFireAreas)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.SeparationDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeparationDescription As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.SeparationDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.SeparationDescription, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.SeparationDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.NoBasementLevels
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoBasementLevels As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeFireConstructionMetadata.ColumnNames.NoBasementLevels)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeFireConstructionMetadata.ColumnNames.NoBasementLevels, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.NoBasementLevels)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.ConstructionUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionUser1 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.ConstructionUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.ConstructionUser1, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.ConstructionUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.ConstructionUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionUser2 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.ConstructionUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.ConstructionUser2, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.ConstructionUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.ConstructionUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionUser3 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.ConstructionUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.ConstructionUser3, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.ConstructionUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.ConstructionUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionUser4 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.ConstructionUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.ConstructionUser4, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.ConstructionUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.MajorProjectsPlanned
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorProjectsPlanned As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.MajorProjectsPlanned)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.MajorProjectsPlanned, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.MajorProjectsPlanned)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireConstruction.MajorProjectsValueRange
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorProjectsValueRange As System.String
			Get
				Return MyBase.GetSystemString(CopeFireConstructionMetadata.ColumnNames.MajorProjectsValueRange)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireConstructionMetadata.ColumnNames.MajorProjectsValueRange, value) Then
					OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.MajorProjectsValueRange)
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
												
						Case "NoofStories"
							Me.str().NoofStories = CType(value, string)
												
						Case "TotalFloorArea"
							Me.str().TotalFloorArea = CType(value, string)
												
						Case "InititalMajorConstructionYear"
							Me.str().InititalMajorConstructionYear = CType(value, string)
												
						Case "LastAdditionYear"
							Me.str().LastAdditionYear = CType(value, string)
												
						Case "BuildingHeight"
							Me.str().BuildingHeight = CType(value, string)
												
						Case "RoofConstructionFireResistive"
							Me.str().RoofConstructionFireResistive = CType(value, string)
												
						Case "RoofConstructionNoncombustible"
							Me.str().RoofConstructionNoncombustible = CType(value, string)
												
						Case "RoofConstructionCombustible"
							Me.str().RoofConstructionCombustible = CType(value, string)
												
						Case "RoofConstructionClass"
							Me.str().RoofConstructionClass = CType(value, string)
												
						Case "RoofConstructionDescription"
							Me.str().RoofConstructionDescription = CType(value, string)
												
						Case "NoofFireAreas"
							Me.str().NoofFireAreas = CType(value, string)
												
						Case "SeparationDescription"
							Me.str().SeparationDescription = CType(value, string)
												
						Case "NoBasementLevels"
							Me.str().NoBasementLevels = CType(value, string)
												
						Case "ConstructionUser1"
							Me.str().ConstructionUser1 = CType(value, string)
												
						Case "ConstructionUser2"
							Me.str().ConstructionUser2 = CType(value, string)
												
						Case "ConstructionUser3"
							Me.str().ConstructionUser3 = CType(value, string)
												
						Case "ConstructionUser4"
							Me.str().ConstructionUser4 = CType(value, string)
												
						Case "MajorProjectsPlanned"
							Me.str().MajorProjectsPlanned = CType(value, string)
												
						Case "MajorProjectsValueRange"
							Me.str().MajorProjectsValueRange = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.Id)
							End If
						
						Case "TotalFloorArea"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotalFloorArea = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.TotalFloorArea)
							End If
						
						Case "InititalMajorConstructionYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InititalMajorConstructionYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.InititalMajorConstructionYear)
							End If
						
						Case "LastAdditionYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LastAdditionYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.LastAdditionYear)
							End If
						
						Case "BuildingHeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BuildingHeight = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.BuildingHeight)
							End If
						
						Case "RoofConstructionFireResistive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RoofConstructionFireResistive = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionFireResistive)
							End If
						
						Case "RoofConstructionNoncombustible"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RoofConstructionNoncombustible = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionNoncombustible)
							End If
						
						Case "RoofConstructionCombustible"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RoofConstructionCombustible = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionCombustible)
							End If
						
						Case "RoofConstructionClass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RoofConstructionClass = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.RoofConstructionClass)
							End If
						
						Case "NoofFireAreas"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.NoofFireAreas = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.NoofFireAreas)
							End If
						
						Case "NoBasementLevels"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NoBasementLevels = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeFireConstructionMetadata.PropertyNames.NoBasementLevels)
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
		
			Public Sub New(ByVal entity As esCopeFireConstruction)
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
		  	
			Public Property NoofStories As System.String 
				Get
					Dim data_ As System.String = entity.NoofStories
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoofStories = Nothing
					Else
						entity.NoofStories = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalFloorArea As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TotalFloorArea
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalFloorArea = Nothing
					Else
						entity.TotalFloorArea = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property InititalMajorConstructionYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InititalMajorConstructionYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InititalMajorConstructionYear = Nothing
					Else
						entity.InititalMajorConstructionYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastAdditionYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LastAdditionYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastAdditionYear = Nothing
					Else
						entity.LastAdditionYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BuildingHeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BuildingHeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BuildingHeight = Nothing
					Else
						entity.BuildingHeight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RoofConstructionFireResistive As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RoofConstructionFireResistive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RoofConstructionFireResistive = Nothing
					Else
						entity.RoofConstructionFireResistive = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RoofConstructionNoncombustible As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RoofConstructionNoncombustible
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RoofConstructionNoncombustible = Nothing
					Else
						entity.RoofConstructionNoncombustible = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RoofConstructionCombustible As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RoofConstructionCombustible
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RoofConstructionCombustible = Nothing
					Else
						entity.RoofConstructionCombustible = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RoofConstructionClass As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RoofConstructionClass
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RoofConstructionClass = Nothing
					Else
						entity.RoofConstructionClass = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RoofConstructionDescription As System.String 
				Get
					Dim data_ As System.String = entity.RoofConstructionDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RoofConstructionDescription = Nothing
					Else
						entity.RoofConstructionDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoofFireAreas As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.NoofFireAreas
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoofFireAreas = Nothing
					Else
						entity.NoofFireAreas = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeparationDescription As System.String 
				Get
					Dim data_ As System.String = entity.SeparationDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeparationDescription = Nothing
					Else
						entity.SeparationDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoBasementLevels As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.NoBasementLevels
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoBasementLevels = Nothing
					Else
						entity.NoBasementLevels = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionUser1 As System.String 
				Get
					Dim data_ As System.String = entity.ConstructionUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionUser1 = Nothing
					Else
						entity.ConstructionUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionUser2 As System.String 
				Get
					Dim data_ As System.String = entity.ConstructionUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionUser2 = Nothing
					Else
						entity.ConstructionUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionUser3 As System.String 
				Get
					Dim data_ As System.String = entity.ConstructionUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionUser3 = Nothing
					Else
						entity.ConstructionUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionUser4 As System.String 
				Get
					Dim data_ As System.String = entity.ConstructionUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionUser4 = Nothing
					Else
						entity.ConstructionUser4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MajorProjectsPlanned As System.String 
				Get
					Dim data_ As System.String = entity.MajorProjectsPlanned
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MajorProjectsPlanned = Nothing
					Else
						entity.MajorProjectsPlanned = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MajorProjectsValueRange As System.String 
				Get
					Dim data_ As System.String = entity.MajorProjectsValueRange
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MajorProjectsValueRange = Nothing
					Else
						entity.MajorProjectsValueRange = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCopeFireConstruction
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeFireConstructionMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As CopeFireConstructionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeFireConstructionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As CopeFireConstructionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As CopeFireConstructionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CopeFireConstructionQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esCopeFireConstructionCollection
		Inherits esEntityCollection(Of CopeFireConstruction)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeFireConstructionMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "CopeFireConstructionCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As CopeFireConstructionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeFireConstructionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As CopeFireConstructionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New CopeFireConstructionQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As CopeFireConstructionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, CopeFireConstructionQuery))
		End Sub
		
		#End Region
						
		Private m_query As CopeFireConstructionQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esCopeFireConstructionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CopeFireConstructionMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "NoofStories" 
					Return Me.NoofStories
				Case "TotalFloorArea" 
					Return Me.TotalFloorArea
				Case "InititalMajorConstructionYear" 
					Return Me.InititalMajorConstructionYear
				Case "LastAdditionYear" 
					Return Me.LastAdditionYear
				Case "BuildingHeight" 
					Return Me.BuildingHeight
				Case "RoofConstructionFireResistive" 
					Return Me.RoofConstructionFireResistive
				Case "RoofConstructionNoncombustible" 
					Return Me.RoofConstructionNoncombustible
				Case "RoofConstructionCombustible" 
					Return Me.RoofConstructionCombustible
				Case "RoofConstructionClass" 
					Return Me.RoofConstructionClass
				Case "RoofConstructionDescription" 
					Return Me.RoofConstructionDescription
				Case "NoofFireAreas" 
					Return Me.NoofFireAreas
				Case "SeparationDescription" 
					Return Me.SeparationDescription
				Case "NoBasementLevels" 
					Return Me.NoBasementLevels
				Case "ConstructionUser1" 
					Return Me.ConstructionUser1
				Case "ConstructionUser2" 
					Return Me.ConstructionUser2
				Case "ConstructionUser3" 
					Return Me.ConstructionUser3
				Case "ConstructionUser4" 
					Return Me.ConstructionUser4
				Case "MajorProjectsPlanned" 
					Return Me.MajorProjectsPlanned
				Case "MajorProjectsValueRange" 
					Return Me.MajorProjectsValueRange
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoofStories As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.NoofStories, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalFloorArea As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.TotalFloorArea, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property InititalMajorConstructionYear As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.InititalMajorConstructionYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LastAdditionYear As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.LastAdditionYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BuildingHeight As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.BuildingHeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionFireResistive As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.RoofConstructionFireResistive, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionNoncombustible As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.RoofConstructionNoncombustible, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionCombustible As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.RoofConstructionCombustible, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionClass As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.RoofConstructionClass, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionDescription As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.RoofConstructionDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoofFireAreas As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.NoofFireAreas, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property SeparationDescription As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.SeparationDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoBasementLevels As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.NoBasementLevels, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.ConstructionUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.ConstructionUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.ConstructionUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.ConstructionUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MajorProjectsPlanned As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.MajorProjectsPlanned, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MajorProjectsValueRange As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireConstructionMetadata.ColumnNames.MajorProjectsValueRange, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class CopeFireConstruction 
		Inherits esCopeFireConstruction
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class CopeFireConstructionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.NoofStories, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.NoofStories
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.TotalFloorArea, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.TotalFloorArea
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.InititalMajorConstructionYear, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.InititalMajorConstructionYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.LastAdditionYear, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.LastAdditionYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.BuildingHeight, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.BuildingHeight
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.RoofConstructionFireResistive, 7, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.RoofConstructionFireResistive
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.RoofConstructionNoncombustible, 8, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.RoofConstructionNoncombustible
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.RoofConstructionCombustible, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.RoofConstructionCombustible
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.RoofConstructionClass, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.RoofConstructionClass
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.RoofConstructionDescription, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.RoofConstructionDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.NoofFireAreas, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.NoofFireAreas
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.SeparationDescription, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.SeparationDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.NoBasementLevels, 14, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.NoBasementLevels
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.ConstructionUser1, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.ConstructionUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.ConstructionUser2, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.ConstructionUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.ConstructionUser3, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.ConstructionUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.ConstructionUser4, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.ConstructionUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.MajorProjectsPlanned, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.MajorProjectsPlanned
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireConstructionMetadata.ColumnNames.MajorProjectsValueRange, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireConstructionMetadata.PropertyNames.MajorProjectsValueRange
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As CopeFireConstructionMetadata
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
			 Public Const NoofStories As String = "NoofStories"
			 Public Const TotalFloorArea As String = "TotalFloorArea"
			 Public Const InititalMajorConstructionYear As String = "InititalMajorConstructionYear"
			 Public Const LastAdditionYear As String = "LastAdditionYear"
			 Public Const BuildingHeight As String = "BuildingHeight"
			 Public Const RoofConstructionFireResistive As String = "RoofConstructionFireResistive"
			 Public Const RoofConstructionNoncombustible As String = "RoofConstructionNoncombustible"
			 Public Const RoofConstructionCombustible As String = "RoofConstructionCombustible"
			 Public Const RoofConstructionClass As String = "RoofConstructionClass"
			 Public Const RoofConstructionDescription As String = "RoofConstructionDescription"
			 Public Const NoofFireAreas As String = "NoofFireAreas"
			 Public Const SeparationDescription As String = "SeparationDescription"
			 Public Const NoBasementLevels As String = "NoBasementLevels"
			 Public Const ConstructionUser1 As String = "ConstructionUser1"
			 Public Const ConstructionUser2 As String = "ConstructionUser2"
			 Public Const ConstructionUser3 As String = "ConstructionUser3"
			 Public Const ConstructionUser4 As String = "ConstructionUser4"
			 Public Const MajorProjectsPlanned As String = "MajorProjectsPlanned"
			 Public Const MajorProjectsValueRange As String = "MajorProjectsValueRange"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const NoofStories As String = "NoofStories"
			 Public Const TotalFloorArea As String = "TotalFloorArea"
			 Public Const InititalMajorConstructionYear As String = "InititalMajorConstructionYear"
			 Public Const LastAdditionYear As String = "LastAdditionYear"
			 Public Const BuildingHeight As String = "BuildingHeight"
			 Public Const RoofConstructionFireResistive As String = "RoofConstructionFireResistive"
			 Public Const RoofConstructionNoncombustible As String = "RoofConstructionNoncombustible"
			 Public Const RoofConstructionCombustible As String = "RoofConstructionCombustible"
			 Public Const RoofConstructionClass As String = "RoofConstructionClass"
			 Public Const RoofConstructionDescription As String = "RoofConstructionDescription"
			 Public Const NoofFireAreas As String = "NoofFireAreas"
			 Public Const SeparationDescription As String = "SeparationDescription"
			 Public Const NoBasementLevels As String = "NoBasementLevels"
			 Public Const ConstructionUser1 As String = "ConstructionUser1"
			 Public Const ConstructionUser2 As String = "ConstructionUser2"
			 Public Const ConstructionUser3 As String = "ConstructionUser3"
			 Public Const ConstructionUser4 As String = "ConstructionUser4"
			 Public Const MajorProjectsPlanned As String = "MajorProjectsPlanned"
			 Public Const MajorProjectsValueRange As String = "MajorProjectsValueRange"
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
			SyncLock GetType(CopeFireConstructionMetadata)
			
				If CopeFireConstructionMetadata.mapDelegates Is Nothing Then
					CopeFireConstructionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If CopeFireConstructionMetadata._meta Is Nothing Then
					CopeFireConstructionMetadata._meta = New CopeFireConstructionMetadata()
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
				meta.AddTypeMap("NoofStories", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalFloorArea", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("InititalMajorConstructionYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LastAdditionYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BuildingHeight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RoofConstructionFireResistive", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RoofConstructionNoncombustible", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RoofConstructionCombustible", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RoofConstructionClass", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RoofConstructionDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NoofFireAreas", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("SeparationDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NoBasementLevels", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("ConstructionUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ConstructionUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ConstructionUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ConstructionUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MajorProjectsPlanned", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MajorProjectsValueRange", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-FireConstruction"
				meta.Destination = "Cope-FireConstruction"
				
				meta.spInsert = "proc_Cope-FireConstructionInsert"
				meta.spUpdate = "proc_Cope-FireConstructionUpdate"
				meta.spDelete = "proc_Cope-FireConstructionDelete"
				meta.spLoadAll = "proc_Cope-FireConstructionLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-FireConstructionLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As CopeFireConstructionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
