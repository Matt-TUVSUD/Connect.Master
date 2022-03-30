
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
	' Encapsulates the 'Cope-FireProtection' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(CopeFireProtection))> _
	<XmlType("CopeFireProtection")> _	
	Partial Public Class CopeFireProtection 
		Inherits esCopeFireProtection
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New CopeFireProtection()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New CopeFireProtection()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New CopeFireProtection()
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
	<XmlType("CopeFireProtectionCollection")> _
	Partial Public Class CopeFireProtectionCollection
		Inherits esCopeFireProtectionCollection
		Implements IEnumerable(Of CopeFireProtection)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As CopeFireProtection
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(CopeFireProtection))> _
		Public Class CopeFireProtectionCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of CopeFireProtectionCollection)
			
			Public Shared Widening Operator CType(packet As CopeFireProtectionCollectionWCFPacket) As CopeFireProtectionCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As CopeFireProtectionCollection) As CopeFireProtectionCollectionWCFPacket
				Return New CopeFireProtectionCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class CopeFireProtectionQuery 
		Inherits esCopeFireProtectionQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "CopeFireProtectionQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As CopeFireProtectionQuery) As String
			Return CopeFireProtectionQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As CopeFireProtectionQuery
			Return DirectCast(CopeFireProtectionQuery.SerializeHelper.FromXml(query, GetType(CopeFireProtectionQuery)), CopeFireProtectionQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esCopeFireProtection
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
		
			Dim query As New CopeFireProtectionQuery()
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
		' Maps to Cope-FireProtection.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeFireProtectionMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeFireProtectionMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.AreaWithAdequateSprinklers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AreaWithAdequateSprinklers As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireProtectionMetadata.ColumnNames.AreaWithAdequateSprinklers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireProtectionMetadata.ColumnNames.AreaWithAdequateSprinklers, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AreaWithAdequateSprinklers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.AreaWithInadequateSprinkler
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AreaWithInadequateSprinkler As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireProtectionMetadata.ColumnNames.AreaWithInadequateSprinkler)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireProtectionMetadata.ColumnNames.AreaWithInadequateSprinkler, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AreaWithInadequateSprinkler)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.AreaWithoutSprinklersNeedingSprinklers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AreaWithoutSprinklersNeedingSprinklers As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireProtectionMetadata.ColumnNames.AreaWithoutSprinklersNeedingSprinklers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireProtectionMetadata.ColumnNames.AreaWithoutSprinklersNeedingSprinklers, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AreaWithoutSprinklersNeedingSprinklers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.AreaWithoutSprinklersNotNeedingSprinklers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AreaWithoutSprinklersNotNeedingSprinklers As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireProtectionMetadata.ColumnNames.AreaWithoutSprinklersNotNeedingSprinklers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireProtectionMetadata.ColumnNames.AreaWithoutSprinklersNotNeedingSprinklers, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AreaWithoutSprinklersNotNeedingSprinklers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SprinklerProtectionCapability
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SprinklerProtectionCapability As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SprinklerProtectionCapability)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SprinklerProtectionCapability, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerProtectionCapability)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SprinklerProtectionCapabilityDescriptionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SprinklerProtectionCapabilityDescriptionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SprinklerProtectionCapabilityDescriptionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SprinklerProtectionCapabilityDescriptionField, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerProtectionCapabilityDescriptionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.PublicWaterSupplyType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PublicWaterSupplyType As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.PublicWaterSupplyType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.PublicWaterSupplyType, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.PublicWaterSupplyType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.PrivateWaterSupplyType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrivateWaterSupplyType As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.PrivateWaterSupplyType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.PrivateWaterSupplyType, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.PrivateWaterSupplyType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.WaterSupplyDuration
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterSupplyDuration As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.WaterSupplyDuration)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.WaterSupplyDuration, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.WaterSupplyDuration)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.WaterSupplyRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterSupplyRating As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.WaterSupplyRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.WaterSupplyRating, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.WaterSupplyRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.WaterSupplyComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterSupplyComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.WaterSupplyComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.WaterSupplyComments, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.WaterSupplyComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SpecialHazardsRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecialHazardsRating As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SpecialHazardsRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SpecialHazardsRating, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SpecialHazardsRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SpecialHazardsComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecialHazardsComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SpecialHazardsComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SpecialHazardsComments, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SpecialHazardsComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.FireHydrantCoverage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireHydrantCoverage As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.FireHydrantCoverage)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.FireHydrantCoverage, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.FireHydrantCoverage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SpecialProtectionSystems
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecialProtectionSystems As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SpecialProtectionSystems)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SpecialProtectionSystems, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SpecialProtectionSystems)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SpecialProtectionSystemDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecialProtectionSystemDescription As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SpecialProtectionSystemDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SpecialProtectionSystemDescription, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SpecialProtectionSystemDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.FireExtinguishers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireExtinguishers As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.FireExtinguishers)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.FireExtinguishers, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.FireExtinguishers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SmallHoseStations
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SmallHoseStations As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SmallHoseStations)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SmallHoseStations, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SmallHoseStations)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SprinklerValvesLocked
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SprinklerValvesLocked As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.SprinklerValvesLocked)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.SprinklerValvesLocked, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerValvesLocked)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SprinklerValveTamperSwitches
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SprinklerValveTamperSwitches As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.SprinklerValveTamperSwitches)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.SprinklerValveTamperSwitches, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerValveTamperSwitches)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SprinklerWaterFlow
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SprinklerWaterFlow As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.SprinklerWaterFlow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.SprinklerWaterFlow, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerWaterFlow)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.FirePumpCondition
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FirePumpCondition As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.FirePumpCondition)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.FirePumpCondition, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.FirePumpCondition)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SmokeHeatDetection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SmokeHeatDetection As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.SmokeHeatDetection)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.SmokeHeatDetection, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SmokeHeatDetection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.IntrusionDetection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntrusionDetection As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.IntrusionDetection)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.IntrusionDetection, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.IntrusionDetection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.Other
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Other As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.Other)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(CopeFireProtectionMetadata.ColumnNames.Other, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.Other)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.AlarmsDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AlarmsDescription As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.AlarmsDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.AlarmsDescription, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AlarmsDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.AlarmMonitoring
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AlarmMonitoring As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.AlarmMonitoring)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.AlarmMonitoring, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AlarmMonitoring)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.WatchService
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WatchService As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.WatchService)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.WatchService, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.WatchService)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.PropertySurveillance
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PropertySurveillance As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.PropertySurveillance)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.PropertySurveillance, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.PropertySurveillance)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SprinklerValves
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SprinklerValves As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SprinklerValves)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SprinklerValves, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerValves)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.FirePumps
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FirePumps As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.FirePumps)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.FirePumps, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.FirePumps)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.InfraredScans
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InfraredScans As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.InfraredScans)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.InfraredScans, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.InfraredScans)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.SmokingControls
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SmokingControls As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.SmokingControls)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.SmokingControls, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SmokingControls)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.Alarms
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Alarms As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.Alarms)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.Alarms, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.Alarms)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.FireDoors
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireDoors As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.FireDoors)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.FireDoors, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.FireDoors)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.Extinguishers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Extinguishers As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.Extinguishers)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.Extinguishers, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.Extinguishers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.HotWorkMonitoring
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HotWorkMonitoring As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.HotWorkMonitoring)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.HotWorkMonitoring, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.HotWorkMonitoring)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.ImpairmentHandling
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpairmentHandling As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.ImpairmentHandling)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.ImpairmentHandling, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.ImpairmentHandling)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.CombustionSafetyControls
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CombustionSafetyControls As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.CombustionSafetyControls)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.CombustionSafetyControls, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.CombustionSafetyControls)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.GeneralMaintenance
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GeneralMaintenance As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.GeneralMaintenance)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.GeneralMaintenance, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.GeneralMaintenance)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.ContractorSupv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContractorSupv As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.ContractorSupv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.ContractorSupv, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.ContractorSupv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.ManagementOfChange
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ManagementOfChange As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.ManagementOfChange)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.ManagementOfChange, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.ManagementOfChange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.EOType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EOType As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.EOType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.EOType, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.EOType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.EOTraining
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EOTraining As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.EOTraining)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.EOTraining, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.EOTraining)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.EmergResponseBCP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmergResponseBCP As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.EmergResponseBCP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.EmergResponseBCP, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.EmergResponseBCP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.PublicFireDepartmentType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PublicFireDepartmentType As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.PublicFireDepartmentType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.PublicFireDepartmentType, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.PublicFireDepartmentType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.ISOCommunityRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ISOCommunityRating As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.ISOCommunityRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.ISOCommunityRating, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.ISOCommunityRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.DistanceToNearestStation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DistanceToNearestStation As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.DistanceToNearestStation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.DistanceToNearestStation, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.DistanceToNearestStation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.Housekeeping
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Housekeeping As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.Housekeeping)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.Housekeeping, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.Housekeeping)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.ProtectionUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProtectionUser1 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.ProtectionUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.ProtectionUser1, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.ProtectionUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.ProtectionUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProtectionUser2 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.ProtectionUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.ProtectionUser2, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.ProtectionUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.ProtectionUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProtectionUser3 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.ProtectionUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.ProtectionUser3, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.ProtectionUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.ProtectionUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProtectionUser4 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.ProtectionUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.ProtectionUser4, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.ProtectionUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastIRInspDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastIRInspDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastIRInspDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastIRInspDate, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastIRInspDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.IRInspOrg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRInspOrg As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.IRInspOrg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.IRInspOrg, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.IRInspOrg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.IRInspComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRInspComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.IRInspComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.IRInspComments, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.IRInspComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastArcFlashInspDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastArcFlashInspDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastArcFlashInspDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastArcFlashInspDate, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastArcFlashInspDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastArcFlashInspOrg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastArcFlashInspOrg As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastArcFlashInspOrg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastArcFlashInspOrg, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastArcFlashInspOrg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastArcFlashComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastArcFlashComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastArcFlashComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastArcFlashComments, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastArcFlashComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastPSMStudyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastPSMStudyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyDate, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastPSMStudyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastPSMStudyOrg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastPSMStudyOrg As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyOrg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyOrg, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastPSMStudyOrg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastPSMStudyComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastPSMStudyComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyComments, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastPSMStudyComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastDustHazInspDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastDustHazInspDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspDate, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastDustHazInspDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastDustHazInspOrg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastDustHazInspOrg As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspOrg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspOrg, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastDustHazInspOrg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastDustHazInspComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastDustHazInspComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspComments, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastDustHazInspComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastProcHazInspDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastProcHazInspDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspDate, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastProcHazInspDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastProcHazInspOrg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastProcHazInspOrg As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspOrg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspOrg, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastProcHazInspOrg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastProcHazInspComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastProcHazInspComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspComments, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastProcHazInspComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastIsoDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastIsoDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastIsoDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CopeFireProtectionMetadata.ColumnNames.LastIsoDate, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastIsoDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastIsoOrg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastIsoOrg As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastIsoOrg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastIsoOrg, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastIsoOrg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireProtection.LastIsoComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastIsoComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireProtectionMetadata.ColumnNames.LastIsoComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireProtectionMetadata.ColumnNames.LastIsoComments, value) Then
					OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastIsoComments)
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
												
						Case "AreaWithAdequateSprinklers"
							Me.str().AreaWithAdequateSprinklers = CType(value, string)
												
						Case "AreaWithInadequateSprinkler"
							Me.str().AreaWithInadequateSprinkler = CType(value, string)
												
						Case "AreaWithoutSprinklersNeedingSprinklers"
							Me.str().AreaWithoutSprinklersNeedingSprinklers = CType(value, string)
												
						Case "AreaWithoutSprinklersNotNeedingSprinklers"
							Me.str().AreaWithoutSprinklersNotNeedingSprinklers = CType(value, string)
												
						Case "SprinklerProtectionCapability"
							Me.str().SprinklerProtectionCapability = CType(value, string)
												
						Case "SprinklerProtectionCapabilityDescriptionField"
							Me.str().SprinklerProtectionCapabilityDescriptionField = CType(value, string)
												
						Case "PublicWaterSupplyType"
							Me.str().PublicWaterSupplyType = CType(value, string)
												
						Case "PrivateWaterSupplyType"
							Me.str().PrivateWaterSupplyType = CType(value, string)
												
						Case "WaterSupplyDuration"
							Me.str().WaterSupplyDuration = CType(value, string)
												
						Case "WaterSupplyRating"
							Me.str().WaterSupplyRating = CType(value, string)
												
						Case "WaterSupplyComments"
							Me.str().WaterSupplyComments = CType(value, string)
												
						Case "SpecialHazardsRating"
							Me.str().SpecialHazardsRating = CType(value, string)
												
						Case "SpecialHazardsComments"
							Me.str().SpecialHazardsComments = CType(value, string)
												
						Case "FireHydrantCoverage"
							Me.str().FireHydrantCoverage = CType(value, string)
												
						Case "SpecialProtectionSystems"
							Me.str().SpecialProtectionSystems = CType(value, string)
												
						Case "SpecialProtectionSystemDescription"
							Me.str().SpecialProtectionSystemDescription = CType(value, string)
												
						Case "FireExtinguishers"
							Me.str().FireExtinguishers = CType(value, string)
												
						Case "SmallHoseStations"
							Me.str().SmallHoseStations = CType(value, string)
												
						Case "SprinklerValvesLocked"
							Me.str().SprinklerValvesLocked = CType(value, string)
												
						Case "SprinklerValveTamperSwitches"
							Me.str().SprinklerValveTamperSwitches = CType(value, string)
												
						Case "SprinklerWaterFlow"
							Me.str().SprinklerWaterFlow = CType(value, string)
												
						Case "FirePumpCondition"
							Me.str().FirePumpCondition = CType(value, string)
												
						Case "SmokeHeatDetection"
							Me.str().SmokeHeatDetection = CType(value, string)
												
						Case "IntrusionDetection"
							Me.str().IntrusionDetection = CType(value, string)
												
						Case "Other"
							Me.str().Other = CType(value, string)
												
						Case "AlarmsDescription"
							Me.str().AlarmsDescription = CType(value, string)
												
						Case "AlarmMonitoring"
							Me.str().AlarmMonitoring = CType(value, string)
												
						Case "WatchService"
							Me.str().WatchService = CType(value, string)
												
						Case "PropertySurveillance"
							Me.str().PropertySurveillance = CType(value, string)
												
						Case "SprinklerValves"
							Me.str().SprinklerValves = CType(value, string)
												
						Case "FirePumps"
							Me.str().FirePumps = CType(value, string)
												
						Case "InfraredScans"
							Me.str().InfraredScans = CType(value, string)
												
						Case "SmokingControls"
							Me.str().SmokingControls = CType(value, string)
												
						Case "Alarms"
							Me.str().Alarms = CType(value, string)
												
						Case "FireDoors"
							Me.str().FireDoors = CType(value, string)
												
						Case "Extinguishers"
							Me.str().Extinguishers = CType(value, string)
												
						Case "HotWorkMonitoring"
							Me.str().HotWorkMonitoring = CType(value, string)
												
						Case "ImpairmentHandling"
							Me.str().ImpairmentHandling = CType(value, string)
												
						Case "CombustionSafetyControls"
							Me.str().CombustionSafetyControls = CType(value, string)
												
						Case "GeneralMaintenance"
							Me.str().GeneralMaintenance = CType(value, string)
												
						Case "ContractorSupv"
							Me.str().ContractorSupv = CType(value, string)
												
						Case "ManagementOfChange"
							Me.str().ManagementOfChange = CType(value, string)
												
						Case "EOType"
							Me.str().EOType = CType(value, string)
												
						Case "EOTraining"
							Me.str().EOTraining = CType(value, string)
												
						Case "EmergResponseBCP"
							Me.str().EmergResponseBCP = CType(value, string)
												
						Case "PublicFireDepartmentType"
							Me.str().PublicFireDepartmentType = CType(value, string)
												
						Case "ISOCommunityRating"
							Me.str().ISOCommunityRating = CType(value, string)
												
						Case "DistanceToNearestStation"
							Me.str().DistanceToNearestStation = CType(value, string)
												
						Case "Housekeeping"
							Me.str().Housekeeping = CType(value, string)
												
						Case "ProtectionUser1"
							Me.str().ProtectionUser1 = CType(value, string)
												
						Case "ProtectionUser2"
							Me.str().ProtectionUser2 = CType(value, string)
												
						Case "ProtectionUser3"
							Me.str().ProtectionUser3 = CType(value, string)
												
						Case "ProtectionUser4"
							Me.str().ProtectionUser4 = CType(value, string)
												
						Case "LastIRInspDate"
							Me.str().LastIRInspDate = CType(value, string)
												
						Case "IRInspOrg"
							Me.str().IRInspOrg = CType(value, string)
												
						Case "IRInspComments"
							Me.str().IRInspComments = CType(value, string)
												
						Case "LastArcFlashInspDate"
							Me.str().LastArcFlashInspDate = CType(value, string)
												
						Case "LastArcFlashInspOrg"
							Me.str().LastArcFlashInspOrg = CType(value, string)
												
						Case "LastArcFlashComments"
							Me.str().LastArcFlashComments = CType(value, string)
												
						Case "LastPSMStudyDate"
							Me.str().LastPSMStudyDate = CType(value, string)
												
						Case "LastPSMStudyOrg"
							Me.str().LastPSMStudyOrg = CType(value, string)
												
						Case "LastPSMStudyComments"
							Me.str().LastPSMStudyComments = CType(value, string)
												
						Case "LastDustHazInspDate"
							Me.str().LastDustHazInspDate = CType(value, string)
												
						Case "LastDustHazInspOrg"
							Me.str().LastDustHazInspOrg = CType(value, string)
												
						Case "LastDustHazInspComments"
							Me.str().LastDustHazInspComments = CType(value, string)
												
						Case "LastProcHazInspDate"
							Me.str().LastProcHazInspDate = CType(value, string)
												
						Case "LastProcHazInspOrg"
							Me.str().LastProcHazInspOrg = CType(value, string)
												
						Case "LastProcHazInspComments"
							Me.str().LastProcHazInspComments = CType(value, string)
												
						Case "LastIsoDate"
							Me.str().LastIsoDate = CType(value, string)
												
						Case "LastIsoOrg"
							Me.str().LastIsoOrg = CType(value, string)
												
						Case "LastIsoComments"
							Me.str().LastIsoComments = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.Id)
							End If
						
						Case "AreaWithAdequateSprinklers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.AreaWithAdequateSprinklers = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AreaWithAdequateSprinklers)
							End If
						
						Case "AreaWithInadequateSprinkler"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.AreaWithInadequateSprinkler = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AreaWithInadequateSprinkler)
							End If
						
						Case "AreaWithoutSprinklersNeedingSprinklers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.AreaWithoutSprinklersNeedingSprinklers = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AreaWithoutSprinklersNeedingSprinklers)
							End If
						
						Case "AreaWithoutSprinklersNotNeedingSprinklers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.AreaWithoutSprinklersNotNeedingSprinklers = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.AreaWithoutSprinklersNotNeedingSprinklers)
							End If
						
						Case "SprinklerValvesLocked"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SprinklerValvesLocked = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerValvesLocked)
							End If
						
						Case "SprinklerValveTamperSwitches"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SprinklerValveTamperSwitches = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerValveTamperSwitches)
							End If
						
						Case "SprinklerWaterFlow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SprinklerWaterFlow = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SprinklerWaterFlow)
							End If
						
						Case "FirePumpCondition"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FirePumpCondition = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.FirePumpCondition)
							End If
						
						Case "SmokeHeatDetection"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SmokeHeatDetection = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.SmokeHeatDetection)
							End If
						
						Case "IntrusionDetection"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IntrusionDetection = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.IntrusionDetection)
							End If
						
						Case "Other"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Other = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.Other)
							End If
						
						Case "LastIRInspDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastIRInspDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastIRInspDate)
							End If
						
						Case "LastArcFlashInspDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastArcFlashInspDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastArcFlashInspDate)
							End If
						
						Case "LastPSMStudyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastPSMStudyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastPSMStudyDate)
							End If
						
						Case "LastDustHazInspDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastDustHazInspDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastDustHazInspDate)
							End If
						
						Case "LastProcHazInspDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastProcHazInspDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastProcHazInspDate)
							End If
						
						Case "LastIsoDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastIsoDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CopeFireProtectionMetadata.PropertyNames.LastIsoDate)
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
		
			Public Sub New(ByVal entity As esCopeFireProtection)
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
		  	
			Public Property AreaWithAdequateSprinklers As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.AreaWithAdequateSprinklers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AreaWithAdequateSprinklers = Nothing
					Else
						entity.AreaWithAdequateSprinklers = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property AreaWithInadequateSprinkler As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.AreaWithInadequateSprinkler
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AreaWithInadequateSprinkler = Nothing
					Else
						entity.AreaWithInadequateSprinkler = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property AreaWithoutSprinklersNeedingSprinklers As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.AreaWithoutSprinklersNeedingSprinklers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AreaWithoutSprinklersNeedingSprinklers = Nothing
					Else
						entity.AreaWithoutSprinklersNeedingSprinklers = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property AreaWithoutSprinklersNotNeedingSprinklers As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.AreaWithoutSprinklersNotNeedingSprinklers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AreaWithoutSprinklersNotNeedingSprinklers = Nothing
					Else
						entity.AreaWithoutSprinklersNotNeedingSprinklers = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property SprinklerProtectionCapability As System.String 
				Get
					Dim data_ As System.String = entity.SprinklerProtectionCapability
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SprinklerProtectionCapability = Nothing
					Else
						entity.SprinklerProtectionCapability = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SprinklerProtectionCapabilityDescriptionField As System.String 
				Get
					Dim data_ As System.String = entity.SprinklerProtectionCapabilityDescriptionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SprinklerProtectionCapabilityDescriptionField = Nothing
					Else
						entity.SprinklerProtectionCapabilityDescriptionField = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PublicWaterSupplyType As System.String 
				Get
					Dim data_ As System.String = entity.PublicWaterSupplyType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PublicWaterSupplyType = Nothing
					Else
						entity.PublicWaterSupplyType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrivateWaterSupplyType As System.String 
				Get
					Dim data_ As System.String = entity.PrivateWaterSupplyType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrivateWaterSupplyType = Nothing
					Else
						entity.PrivateWaterSupplyType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterSupplyDuration As System.String 
				Get
					Dim data_ As System.String = entity.WaterSupplyDuration
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterSupplyDuration = Nothing
					Else
						entity.WaterSupplyDuration = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterSupplyRating As System.String 
				Get
					Dim data_ As System.String = entity.WaterSupplyRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterSupplyRating = Nothing
					Else
						entity.WaterSupplyRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterSupplyComments As System.String 
				Get
					Dim data_ As System.String = entity.WaterSupplyComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterSupplyComments = Nothing
					Else
						entity.WaterSupplyComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecialHazardsRating As System.String 
				Get
					Dim data_ As System.String = entity.SpecialHazardsRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecialHazardsRating = Nothing
					Else
						entity.SpecialHazardsRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecialHazardsComments As System.String 
				Get
					Dim data_ As System.String = entity.SpecialHazardsComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecialHazardsComments = Nothing
					Else
						entity.SpecialHazardsComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireHydrantCoverage As System.String 
				Get
					Dim data_ As System.String = entity.FireHydrantCoverage
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireHydrantCoverage = Nothing
					Else
						entity.FireHydrantCoverage = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecialProtectionSystems As System.String 
				Get
					Dim data_ As System.String = entity.SpecialProtectionSystems
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecialProtectionSystems = Nothing
					Else
						entity.SpecialProtectionSystems = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecialProtectionSystemDescription As System.String 
				Get
					Dim data_ As System.String = entity.SpecialProtectionSystemDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecialProtectionSystemDescription = Nothing
					Else
						entity.SpecialProtectionSystemDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireExtinguishers As System.String 
				Get
					Dim data_ As System.String = entity.FireExtinguishers
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireExtinguishers = Nothing
					Else
						entity.FireExtinguishers = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SmallHoseStations As System.String 
				Get
					Dim data_ As System.String = entity.SmallHoseStations
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SmallHoseStations = Nothing
					Else
						entity.SmallHoseStations = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SprinklerValvesLocked As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SprinklerValvesLocked
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SprinklerValvesLocked = Nothing
					Else
						entity.SprinklerValvesLocked = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SprinklerValveTamperSwitches As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SprinklerValveTamperSwitches
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SprinklerValveTamperSwitches = Nothing
					Else
						entity.SprinklerValveTamperSwitches = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SprinklerWaterFlow As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SprinklerWaterFlow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SprinklerWaterFlow = Nothing
					Else
						entity.SprinklerWaterFlow = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property FirePumpCondition As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FirePumpCondition
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FirePumpCondition = Nothing
					Else
						entity.FirePumpCondition = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SmokeHeatDetection As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SmokeHeatDetection
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SmokeHeatDetection = Nothing
					Else
						entity.SmokeHeatDetection = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property IntrusionDetection As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IntrusionDetection
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IntrusionDetection = Nothing
					Else
						entity.IntrusionDetection = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Other As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Other
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Other = Nothing
					Else
						entity.Other = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property AlarmsDescription As System.String 
				Get
					Dim data_ As System.String = entity.AlarmsDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AlarmsDescription = Nothing
					Else
						entity.AlarmsDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AlarmMonitoring As System.String 
				Get
					Dim data_ As System.String = entity.AlarmMonitoring
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AlarmMonitoring = Nothing
					Else
						entity.AlarmMonitoring = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WatchService As System.String 
				Get
					Dim data_ As System.String = entity.WatchService
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WatchService = Nothing
					Else
						entity.WatchService = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PropertySurveillance As System.String 
				Get
					Dim data_ As System.String = entity.PropertySurveillance
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PropertySurveillance = Nothing
					Else
						entity.PropertySurveillance = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SprinklerValves As System.String 
				Get
					Dim data_ As System.String = entity.SprinklerValves
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SprinklerValves = Nothing
					Else
						entity.SprinklerValves = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FirePumps As System.String 
				Get
					Dim data_ As System.String = entity.FirePumps
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FirePumps = Nothing
					Else
						entity.FirePumps = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InfraredScans As System.String 
				Get
					Dim data_ As System.String = entity.InfraredScans
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InfraredScans = Nothing
					Else
						entity.InfraredScans = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SmokingControls As System.String 
				Get
					Dim data_ As System.String = entity.SmokingControls
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SmokingControls = Nothing
					Else
						entity.SmokingControls = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Alarms As System.String 
				Get
					Dim data_ As System.String = entity.Alarms
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Alarms = Nothing
					Else
						entity.Alarms = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireDoors As System.String 
				Get
					Dim data_ As System.String = entity.FireDoors
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireDoors = Nothing
					Else
						entity.FireDoors = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Extinguishers As System.String 
				Get
					Dim data_ As System.String = entity.Extinguishers
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extinguishers = Nothing
					Else
						entity.Extinguishers = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HotWorkMonitoring As System.String 
				Get
					Dim data_ As System.String = entity.HotWorkMonitoring
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HotWorkMonitoring = Nothing
					Else
						entity.HotWorkMonitoring = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpairmentHandling As System.String 
				Get
					Dim data_ As System.String = entity.ImpairmentHandling
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpairmentHandling = Nothing
					Else
						entity.ImpairmentHandling = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CombustionSafetyControls As System.String 
				Get
					Dim data_ As System.String = entity.CombustionSafetyControls
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CombustionSafetyControls = Nothing
					Else
						entity.CombustionSafetyControls = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GeneralMaintenance As System.String 
				Get
					Dim data_ As System.String = entity.GeneralMaintenance
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GeneralMaintenance = Nothing
					Else
						entity.GeneralMaintenance = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContractorSupv As System.String 
				Get
					Dim data_ As System.String = entity.ContractorSupv
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContractorSupv = Nothing
					Else
						entity.ContractorSupv = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ManagementOfChange As System.String 
				Get
					Dim data_ As System.String = entity.ManagementOfChange
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ManagementOfChange = Nothing
					Else
						entity.ManagementOfChange = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EOType As System.String 
				Get
					Dim data_ As System.String = entity.EOType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EOType = Nothing
					Else
						entity.EOType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EOTraining As System.String 
				Get
					Dim data_ As System.String = entity.EOTraining
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EOTraining = Nothing
					Else
						entity.EOTraining = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmergResponseBCP As System.String 
				Get
					Dim data_ As System.String = entity.EmergResponseBCP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmergResponseBCP = Nothing
					Else
						entity.EmergResponseBCP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PublicFireDepartmentType As System.String 
				Get
					Dim data_ As System.String = entity.PublicFireDepartmentType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PublicFireDepartmentType = Nothing
					Else
						entity.PublicFireDepartmentType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ISOCommunityRating As System.String 
				Get
					Dim data_ As System.String = entity.ISOCommunityRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ISOCommunityRating = Nothing
					Else
						entity.ISOCommunityRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DistanceToNearestStation As System.String 
				Get
					Dim data_ As System.String = entity.DistanceToNearestStation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DistanceToNearestStation = Nothing
					Else
						entity.DistanceToNearestStation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Housekeeping As System.String 
				Get
					Dim data_ As System.String = entity.Housekeeping
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Housekeeping = Nothing
					Else
						entity.Housekeeping = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProtectionUser1 As System.String 
				Get
					Dim data_ As System.String = entity.ProtectionUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProtectionUser1 = Nothing
					Else
						entity.ProtectionUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProtectionUser2 As System.String 
				Get
					Dim data_ As System.String = entity.ProtectionUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProtectionUser2 = Nothing
					Else
						entity.ProtectionUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProtectionUser3 As System.String 
				Get
					Dim data_ As System.String = entity.ProtectionUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProtectionUser3 = Nothing
					Else
						entity.ProtectionUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProtectionUser4 As System.String 
				Get
					Dim data_ As System.String = entity.ProtectionUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProtectionUser4 = Nothing
					Else
						entity.ProtectionUser4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastIRInspDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastIRInspDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastIRInspDate = Nothing
					Else
						entity.LastIRInspDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRInspOrg As System.String 
				Get
					Dim data_ As System.String = entity.IRInspOrg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRInspOrg = Nothing
					Else
						entity.IRInspOrg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRInspComments As System.String 
				Get
					Dim data_ As System.String = entity.IRInspComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRInspComments = Nothing
					Else
						entity.IRInspComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastArcFlashInspDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastArcFlashInspDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastArcFlashInspDate = Nothing
					Else
						entity.LastArcFlashInspDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastArcFlashInspOrg As System.String 
				Get
					Dim data_ As System.String = entity.LastArcFlashInspOrg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastArcFlashInspOrg = Nothing
					Else
						entity.LastArcFlashInspOrg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastArcFlashComments As System.String 
				Get
					Dim data_ As System.String = entity.LastArcFlashComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastArcFlashComments = Nothing
					Else
						entity.LastArcFlashComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastPSMStudyDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastPSMStudyDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastPSMStudyDate = Nothing
					Else
						entity.LastPSMStudyDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastPSMStudyOrg As System.String 
				Get
					Dim data_ As System.String = entity.LastPSMStudyOrg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastPSMStudyOrg = Nothing
					Else
						entity.LastPSMStudyOrg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastPSMStudyComments As System.String 
				Get
					Dim data_ As System.String = entity.LastPSMStudyComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastPSMStudyComments = Nothing
					Else
						entity.LastPSMStudyComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastDustHazInspDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastDustHazInspDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastDustHazInspDate = Nothing
					Else
						entity.LastDustHazInspDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastDustHazInspOrg As System.String 
				Get
					Dim data_ As System.String = entity.LastDustHazInspOrg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastDustHazInspOrg = Nothing
					Else
						entity.LastDustHazInspOrg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastDustHazInspComments As System.String 
				Get
					Dim data_ As System.String = entity.LastDustHazInspComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastDustHazInspComments = Nothing
					Else
						entity.LastDustHazInspComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastProcHazInspDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastProcHazInspDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastProcHazInspDate = Nothing
					Else
						entity.LastProcHazInspDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastProcHazInspOrg As System.String 
				Get
					Dim data_ As System.String = entity.LastProcHazInspOrg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastProcHazInspOrg = Nothing
					Else
						entity.LastProcHazInspOrg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastProcHazInspComments As System.String 
				Get
					Dim data_ As System.String = entity.LastProcHazInspComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastProcHazInspComments = Nothing
					Else
						entity.LastProcHazInspComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastIsoDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastIsoDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastIsoDate = Nothing
					Else
						entity.LastIsoDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastIsoOrg As System.String 
				Get
					Dim data_ As System.String = entity.LastIsoOrg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastIsoOrg = Nothing
					Else
						entity.LastIsoOrg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastIsoComments As System.String 
				Get
					Dim data_ As System.String = entity.LastIsoComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastIsoComments = Nothing
					Else
						entity.LastIsoComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCopeFireProtection
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeFireProtectionMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As CopeFireProtectionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeFireProtectionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As CopeFireProtectionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As CopeFireProtectionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CopeFireProtectionQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esCopeFireProtectionCollection
		Inherits esEntityCollection(Of CopeFireProtection)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeFireProtectionMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "CopeFireProtectionCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As CopeFireProtectionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeFireProtectionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As CopeFireProtectionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New CopeFireProtectionQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As CopeFireProtectionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, CopeFireProtectionQuery))
		End Sub
		
		#End Region
						
		Private m_query As CopeFireProtectionQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esCopeFireProtectionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CopeFireProtectionMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "AreaWithAdequateSprinklers" 
					Return Me.AreaWithAdequateSprinklers
				Case "AreaWithInadequateSprinkler" 
					Return Me.AreaWithInadequateSprinkler
				Case "AreaWithoutSprinklersNeedingSprinklers" 
					Return Me.AreaWithoutSprinklersNeedingSprinklers
				Case "AreaWithoutSprinklersNotNeedingSprinklers" 
					Return Me.AreaWithoutSprinklersNotNeedingSprinklers
				Case "SprinklerProtectionCapability" 
					Return Me.SprinklerProtectionCapability
				Case "SprinklerProtectionCapabilityDescriptionField" 
					Return Me.SprinklerProtectionCapabilityDescriptionField
				Case "PublicWaterSupplyType" 
					Return Me.PublicWaterSupplyType
				Case "PrivateWaterSupplyType" 
					Return Me.PrivateWaterSupplyType
				Case "WaterSupplyDuration" 
					Return Me.WaterSupplyDuration
				Case "WaterSupplyRating" 
					Return Me.WaterSupplyRating
				Case "WaterSupplyComments" 
					Return Me.WaterSupplyComments
				Case "SpecialHazardsRating" 
					Return Me.SpecialHazardsRating
				Case "SpecialHazardsComments" 
					Return Me.SpecialHazardsComments
				Case "FireHydrantCoverage" 
					Return Me.FireHydrantCoverage
				Case "SpecialProtectionSystems" 
					Return Me.SpecialProtectionSystems
				Case "SpecialProtectionSystemDescription" 
					Return Me.SpecialProtectionSystemDescription
				Case "FireExtinguishers" 
					Return Me.FireExtinguishers
				Case "SmallHoseStations" 
					Return Me.SmallHoseStations
				Case "SprinklerValvesLocked" 
					Return Me.SprinklerValvesLocked
				Case "SprinklerValveTamperSwitches" 
					Return Me.SprinklerValveTamperSwitches
				Case "SprinklerWaterFlow" 
					Return Me.SprinklerWaterFlow
				Case "FirePumpCondition" 
					Return Me.FirePumpCondition
				Case "SmokeHeatDetection" 
					Return Me.SmokeHeatDetection
				Case "IntrusionDetection" 
					Return Me.IntrusionDetection
				Case "Other" 
					Return Me.Other
				Case "AlarmsDescription" 
					Return Me.AlarmsDescription
				Case "AlarmMonitoring" 
					Return Me.AlarmMonitoring
				Case "WatchService" 
					Return Me.WatchService
				Case "PropertySurveillance" 
					Return Me.PropertySurveillance
				Case "SprinklerValves" 
					Return Me.SprinklerValves
				Case "FirePumps" 
					Return Me.FirePumps
				Case "InfraredScans" 
					Return Me.InfraredScans
				Case "SmokingControls" 
					Return Me.SmokingControls
				Case "Alarms" 
					Return Me.Alarms
				Case "FireDoors" 
					Return Me.FireDoors
				Case "Extinguishers" 
					Return Me.Extinguishers
				Case "HotWorkMonitoring" 
					Return Me.HotWorkMonitoring
				Case "ImpairmentHandling" 
					Return Me.ImpairmentHandling
				Case "CombustionSafetyControls" 
					Return Me.CombustionSafetyControls
				Case "GeneralMaintenance" 
					Return Me.GeneralMaintenance
				Case "ContractorSupv" 
					Return Me.ContractorSupv
				Case "ManagementOfChange" 
					Return Me.ManagementOfChange
				Case "EOType" 
					Return Me.EOType
				Case "EOTraining" 
					Return Me.EOTraining
				Case "EmergResponseBCP" 
					Return Me.EmergResponseBCP
				Case "PublicFireDepartmentType" 
					Return Me.PublicFireDepartmentType
				Case "ISOCommunityRating" 
					Return Me.ISOCommunityRating
				Case "DistanceToNearestStation" 
					Return Me.DistanceToNearestStation
				Case "Housekeeping" 
					Return Me.Housekeeping
				Case "ProtectionUser1" 
					Return Me.ProtectionUser1
				Case "ProtectionUser2" 
					Return Me.ProtectionUser2
				Case "ProtectionUser3" 
					Return Me.ProtectionUser3
				Case "ProtectionUser4" 
					Return Me.ProtectionUser4
				Case "LastIRInspDate" 
					Return Me.LastIRInspDate
				Case "IRInspOrg" 
					Return Me.IRInspOrg
				Case "IRInspComments" 
					Return Me.IRInspComments
				Case "LastArcFlashInspDate" 
					Return Me.LastArcFlashInspDate
				Case "LastArcFlashInspOrg" 
					Return Me.LastArcFlashInspOrg
				Case "LastArcFlashComments" 
					Return Me.LastArcFlashComments
				Case "LastPSMStudyDate" 
					Return Me.LastPSMStudyDate
				Case "LastPSMStudyOrg" 
					Return Me.LastPSMStudyOrg
				Case "LastPSMStudyComments" 
					Return Me.LastPSMStudyComments
				Case "LastDustHazInspDate" 
					Return Me.LastDustHazInspDate
				Case "LastDustHazInspOrg" 
					Return Me.LastDustHazInspOrg
				Case "LastDustHazInspComments" 
					Return Me.LastDustHazInspComments
				Case "LastProcHazInspDate" 
					Return Me.LastProcHazInspDate
				Case "LastProcHazInspOrg" 
					Return Me.LastProcHazInspOrg
				Case "LastProcHazInspComments" 
					Return Me.LastProcHazInspComments
				Case "LastIsoDate" 
					Return Me.LastIsoDate
				Case "LastIsoOrg" 
					Return Me.LastIsoOrg
				Case "LastIsoComments" 
					Return Me.LastIsoComments
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AreaWithAdequateSprinklers As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.AreaWithAdequateSprinklers, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property AreaWithInadequateSprinkler As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.AreaWithInadequateSprinkler, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property AreaWithoutSprinklersNeedingSprinklers As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.AreaWithoutSprinklersNeedingSprinklers, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property AreaWithoutSprinklersNotNeedingSprinklers As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.AreaWithoutSprinklersNotNeedingSprinklers, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property SprinklerProtectionCapability As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SprinklerProtectionCapability, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SprinklerProtectionCapabilityDescriptionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SprinklerProtectionCapabilityDescriptionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PublicWaterSupplyType As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.PublicWaterSupplyType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrivateWaterSupplyType As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.PrivateWaterSupplyType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterSupplyDuration As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.WaterSupplyDuration, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterSupplyRating As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.WaterSupplyRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterSupplyComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.WaterSupplyComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecialHazardsRating As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SpecialHazardsRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecialHazardsComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SpecialHazardsComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireHydrantCoverage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.FireHydrantCoverage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecialProtectionSystems As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SpecialProtectionSystems, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecialProtectionSystemDescription As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SpecialProtectionSystemDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireExtinguishers As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.FireExtinguishers, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SmallHoseStations As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SmallHoseStations, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SprinklerValvesLocked As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SprinklerValvesLocked, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SprinklerValveTamperSwitches As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SprinklerValveTamperSwitches, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SprinklerWaterFlow As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SprinklerWaterFlow, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property FirePumpCondition As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.FirePumpCondition, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SmokeHeatDetection As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SmokeHeatDetection, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property IntrusionDetection As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.IntrusionDetection, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Other As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.Other, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property AlarmsDescription As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.AlarmsDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AlarmMonitoring As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.AlarmMonitoring, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WatchService As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.WatchService, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PropertySurveillance As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.PropertySurveillance, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SprinklerValves As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SprinklerValves, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FirePumps As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.FirePumps, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InfraredScans As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.InfraredScans, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SmokingControls As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.SmokingControls, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Alarms As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.Alarms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireDoors As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.FireDoors, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Extinguishers As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.Extinguishers, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HotWorkMonitoring As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.HotWorkMonitoring, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpairmentHandling As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.ImpairmentHandling, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CombustionSafetyControls As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.CombustionSafetyControls, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GeneralMaintenance As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.GeneralMaintenance, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContractorSupv As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.ContractorSupv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ManagementOfChange As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.ManagementOfChange, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EOType As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.EOType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EOTraining As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.EOTraining, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmergResponseBCP As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.EmergResponseBCP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PublicFireDepartmentType As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.PublicFireDepartmentType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ISOCommunityRating As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.ISOCommunityRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DistanceToNearestStation As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.DistanceToNearestStation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Housekeeping As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.Housekeeping, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProtectionUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.ProtectionUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProtectionUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.ProtectionUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProtectionUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.ProtectionUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProtectionUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.ProtectionUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastIRInspDate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastIRInspDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property IRInspOrg As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.IRInspOrg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IRInspComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.IRInspComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastArcFlashInspDate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastArcFlashInspDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastArcFlashInspOrg As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastArcFlashInspOrg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastArcFlashComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastArcFlashComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastPSMStudyDate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastPSMStudyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastPSMStudyOrg As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastPSMStudyOrg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastPSMStudyComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastPSMStudyComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastDustHazInspDate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastDustHazInspDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastDustHazInspOrg As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastDustHazInspOrg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastDustHazInspComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastDustHazInspComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastProcHazInspDate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastProcHazInspDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastProcHazInspOrg As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastProcHazInspOrg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastProcHazInspComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastProcHazInspComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastIsoDate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastIsoDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastIsoOrg As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastIsoOrg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastIsoComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireProtectionMetadata.ColumnNames.LastIsoComments, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class CopeFireProtection 
		Inherits esCopeFireProtection
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class CopeFireProtectionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.AreaWithAdequateSprinklers, 2, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.AreaWithAdequateSprinklers
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.AreaWithInadequateSprinkler, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.AreaWithInadequateSprinkler
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.AreaWithoutSprinklersNeedingSprinklers, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.AreaWithoutSprinklersNeedingSprinklers
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.AreaWithoutSprinklersNotNeedingSprinklers, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.AreaWithoutSprinklersNotNeedingSprinklers
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SprinklerProtectionCapability, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SprinklerProtectionCapability
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SprinklerProtectionCapabilityDescriptionField, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SprinklerProtectionCapabilityDescriptionField
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.PublicWaterSupplyType, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.PublicWaterSupplyType
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.PrivateWaterSupplyType, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.PrivateWaterSupplyType
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.WaterSupplyDuration, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.WaterSupplyDuration
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.WaterSupplyRating, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.WaterSupplyRating
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.WaterSupplyComments, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.WaterSupplyComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SpecialHazardsRating, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SpecialHazardsRating
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SpecialHazardsComments, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SpecialHazardsComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.FireHydrantCoverage, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.FireHydrantCoverage
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SpecialProtectionSystems, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SpecialProtectionSystems
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SpecialProtectionSystemDescription, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SpecialProtectionSystemDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.FireExtinguishers, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.FireExtinguishers
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SmallHoseStations, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SmallHoseStations
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SprinklerValvesLocked, 20, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SprinklerValvesLocked
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SprinklerValveTamperSwitches, 21, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SprinklerValveTamperSwitches
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SprinklerWaterFlow, 22, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SprinklerWaterFlow
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.FirePumpCondition, 23, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.FirePumpCondition
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SmokeHeatDetection, 24, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SmokeHeatDetection
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.IntrusionDetection, 25, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.IntrusionDetection
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.Other, 26, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.Other
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.AlarmsDescription, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.AlarmsDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.AlarmMonitoring, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.AlarmMonitoring
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.WatchService, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.WatchService
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.PropertySurveillance, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.PropertySurveillance
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SprinklerValves, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SprinklerValves
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.FirePumps, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.FirePumps
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.InfraredScans, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.InfraredScans
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.SmokingControls, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.SmokingControls
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.Alarms, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.Alarms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.FireDoors, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.FireDoors
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.Extinguishers, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.Extinguishers
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.HotWorkMonitoring, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.HotWorkMonitoring
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.ImpairmentHandling, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.ImpairmentHandling
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.CombustionSafetyControls, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.CombustionSafetyControls
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.GeneralMaintenance, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.GeneralMaintenance
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.ContractorSupv, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.ContractorSupv
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.ManagementOfChange, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.ManagementOfChange
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.EOType, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.EOType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.EOTraining, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.EOTraining
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.EmergResponseBCP, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.EmergResponseBCP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.PublicFireDepartmentType, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.PublicFireDepartmentType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.ISOCommunityRating, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.ISOCommunityRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.DistanceToNearestStation, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.DistanceToNearestStation
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.Housekeeping, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.Housekeeping
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.ProtectionUser1, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.ProtectionUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.ProtectionUser2, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.ProtectionUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.ProtectionUser3, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.ProtectionUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.ProtectionUser4, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.ProtectionUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastIRInspDate, 55, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastIRInspDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.IRInspOrg, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.IRInspOrg
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.IRInspComments, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.IRInspComments
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastArcFlashInspDate, 58, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastArcFlashInspDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastArcFlashInspOrg, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastArcFlashInspOrg
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastArcFlashComments, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastArcFlashComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyDate, 61, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastPSMStudyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyOrg, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastPSMStudyOrg
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastPSMStudyComments, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastPSMStudyComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspDate, 64, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastDustHazInspDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspOrg, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastDustHazInspOrg
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastDustHazInspComments, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastDustHazInspComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspDate, 67, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastProcHazInspDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspOrg, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastProcHazInspOrg
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastProcHazInspComments, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastProcHazInspComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastIsoDate, 70, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastIsoDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastIsoOrg, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastIsoOrg
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireProtectionMetadata.ColumnNames.LastIsoComments, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireProtectionMetadata.PropertyNames.LastIsoComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As CopeFireProtectionMetadata
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
			 Public Const AreaWithAdequateSprinklers As String = "AreaWithAdequateSprinklers"
			 Public Const AreaWithInadequateSprinkler As String = "AreaWithInadequateSprinkler"
			 Public Const AreaWithoutSprinklersNeedingSprinklers As String = "AreaWithoutSprinklersNeedingSprinklers"
			 Public Const AreaWithoutSprinklersNotNeedingSprinklers As String = "AreaWithoutSprinklersNotNeedingSprinklers"
			 Public Const SprinklerProtectionCapability As String = "SprinklerProtectionCapability"
			 Public Const SprinklerProtectionCapabilityDescriptionField As String = "SprinklerProtectionCapabilityDescriptionField"
			 Public Const PublicWaterSupplyType As String = "PublicWaterSupplyType"
			 Public Const PrivateWaterSupplyType As String = "PrivateWaterSupplyType"
			 Public Const WaterSupplyDuration As String = "WaterSupplyDuration"
			 Public Const WaterSupplyRating As String = "WaterSupplyRating"
			 Public Const WaterSupplyComments As String = "WaterSupplyComments"
			 Public Const SpecialHazardsRating As String = "SpecialHazardsRating"
			 Public Const SpecialHazardsComments As String = "SpecialHazardsComments"
			 Public Const FireHydrantCoverage As String = "FireHydrantCoverage"
			 Public Const SpecialProtectionSystems As String = "SpecialProtectionSystems"
			 Public Const SpecialProtectionSystemDescription As String = "SpecialProtectionSystemDescription"
			 Public Const FireExtinguishers As String = "FireExtinguishers"
			 Public Const SmallHoseStations As String = "SmallHoseStations"
			 Public Const SprinklerValvesLocked As String = "SprinklerValvesLocked"
			 Public Const SprinklerValveTamperSwitches As String = "SprinklerValveTamperSwitches"
			 Public Const SprinklerWaterFlow As String = "SprinklerWaterFlow"
			 Public Const FirePumpCondition As String = "FirePumpCondition"
			 Public Const SmokeHeatDetection As String = "SmokeHeatDetection"
			 Public Const IntrusionDetection As String = "IntrusionDetection"
			 Public Const Other As String = "Other"
			 Public Const AlarmsDescription As String = "AlarmsDescription"
			 Public Const AlarmMonitoring As String = "AlarmMonitoring"
			 Public Const WatchService As String = "WatchService"
			 Public Const PropertySurveillance As String = "PropertySurveillance"
			 Public Const SprinklerValves As String = "SprinklerValves"
			 Public Const FirePumps As String = "FirePumps"
			 Public Const InfraredScans As String = "InfraredScans"
			 Public Const SmokingControls As String = "SmokingControls"
			 Public Const Alarms As String = "Alarms"
			 Public Const FireDoors As String = "FireDoors"
			 Public Const Extinguishers As String = "Extinguishers"
			 Public Const HotWorkMonitoring As String = "HotWorkMonitoring"
			 Public Const ImpairmentHandling As String = "ImpairmentHandling"
			 Public Const CombustionSafetyControls As String = "CombustionSafetyControls"
			 Public Const GeneralMaintenance As String = "GeneralMaintenance"
			 Public Const ContractorSupv As String = "ContractorSupv"
			 Public Const ManagementOfChange As String = "ManagementOfChange"
			 Public Const EOType As String = "EOType"
			 Public Const EOTraining As String = "EOTraining"
			 Public Const EmergResponseBCP As String = "EmergResponseBCP"
			 Public Const PublicFireDepartmentType As String = "PublicFireDepartmentType"
			 Public Const ISOCommunityRating As String = "ISOCommunityRating"
			 Public Const DistanceToNearestStation As String = "DistanceToNearestStation"
			 Public Const Housekeeping As String = "Housekeeping"
			 Public Const ProtectionUser1 As String = "ProtectionUser1"
			 Public Const ProtectionUser2 As String = "ProtectionUser2"
			 Public Const ProtectionUser3 As String = "ProtectionUser3"
			 Public Const ProtectionUser4 As String = "ProtectionUser4"
			 Public Const LastIRInspDate As String = "LastIRInspDate"
			 Public Const IRInspOrg As String = "IRInspOrg"
			 Public Const IRInspComments As String = "IRInspComments"
			 Public Const LastArcFlashInspDate As String = "LastArcFlashInspDate"
			 Public Const LastArcFlashInspOrg As String = "LastArcFlashInspOrg"
			 Public Const LastArcFlashComments As String = "LastArcFlashComments"
			 Public Const LastPSMStudyDate As String = "LastPSMStudyDate"
			 Public Const LastPSMStudyOrg As String = "LastPSMStudyOrg"
			 Public Const LastPSMStudyComments As String = "LastPSMStudyComments"
			 Public Const LastDustHazInspDate As String = "LastDustHazInspDate"
			 Public Const LastDustHazInspOrg As String = "LastDustHazInspOrg"
			 Public Const LastDustHazInspComments As String = "LastDustHazInspComments"
			 Public Const LastProcHazInspDate As String = "LastProcHazInspDate"
			 Public Const LastProcHazInspOrg As String = "LastProcHazInspOrg"
			 Public Const LastProcHazInspComments As String = "LastProcHazInspComments"
			 Public Const LastIsoDate As String = "LastIsoDate"
			 Public Const LastIsoOrg As String = "LastIsoOrg"
			 Public Const LastIsoComments As String = "LastIsoComments"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const AreaWithAdequateSprinklers As String = "AreaWithAdequateSprinklers"
			 Public Const AreaWithInadequateSprinkler As String = "AreaWithInadequateSprinkler"
			 Public Const AreaWithoutSprinklersNeedingSprinklers As String = "AreaWithoutSprinklersNeedingSprinklers"
			 Public Const AreaWithoutSprinklersNotNeedingSprinklers As String = "AreaWithoutSprinklersNotNeedingSprinklers"
			 Public Const SprinklerProtectionCapability As String = "SprinklerProtectionCapability"
			 Public Const SprinklerProtectionCapabilityDescriptionField As String = "SprinklerProtectionCapabilityDescriptionField"
			 Public Const PublicWaterSupplyType As String = "PublicWaterSupplyType"
			 Public Const PrivateWaterSupplyType As String = "PrivateWaterSupplyType"
			 Public Const WaterSupplyDuration As String = "WaterSupplyDuration"
			 Public Const WaterSupplyRating As String = "WaterSupplyRating"
			 Public Const WaterSupplyComments As String = "WaterSupplyComments"
			 Public Const SpecialHazardsRating As String = "SpecialHazardsRating"
			 Public Const SpecialHazardsComments As String = "SpecialHazardsComments"
			 Public Const FireHydrantCoverage As String = "FireHydrantCoverage"
			 Public Const SpecialProtectionSystems As String = "SpecialProtectionSystems"
			 Public Const SpecialProtectionSystemDescription As String = "SpecialProtectionSystemDescription"
			 Public Const FireExtinguishers As String = "FireExtinguishers"
			 Public Const SmallHoseStations As String = "SmallHoseStations"
			 Public Const SprinklerValvesLocked As String = "SprinklerValvesLocked"
			 Public Const SprinklerValveTamperSwitches As String = "SprinklerValveTamperSwitches"
			 Public Const SprinklerWaterFlow As String = "SprinklerWaterFlow"
			 Public Const FirePumpCondition As String = "FirePumpCondition"
			 Public Const SmokeHeatDetection As String = "SmokeHeatDetection"
			 Public Const IntrusionDetection As String = "IntrusionDetection"
			 Public Const Other As String = "Other"
			 Public Const AlarmsDescription As String = "AlarmsDescription"
			 Public Const AlarmMonitoring As String = "AlarmMonitoring"
			 Public Const WatchService As String = "WatchService"
			 Public Const PropertySurveillance As String = "PropertySurveillance"
			 Public Const SprinklerValves As String = "SprinklerValves"
			 Public Const FirePumps As String = "FirePumps"
			 Public Const InfraredScans As String = "InfraredScans"
			 Public Const SmokingControls As String = "SmokingControls"
			 Public Const Alarms As String = "Alarms"
			 Public Const FireDoors As String = "FireDoors"
			 Public Const Extinguishers As String = "Extinguishers"
			 Public Const HotWorkMonitoring As String = "HotWorkMonitoring"
			 Public Const ImpairmentHandling As String = "ImpairmentHandling"
			 Public Const CombustionSafetyControls As String = "CombustionSafetyControls"
			 Public Const GeneralMaintenance As String = "GeneralMaintenance"
			 Public Const ContractorSupv As String = "ContractorSupv"
			 Public Const ManagementOfChange As String = "ManagementOfChange"
			 Public Const EOType As String = "EOType"
			 Public Const EOTraining As String = "EOTraining"
			 Public Const EmergResponseBCP As String = "EmergResponseBCP"
			 Public Const PublicFireDepartmentType As String = "PublicFireDepartmentType"
			 Public Const ISOCommunityRating As String = "ISOCommunityRating"
			 Public Const DistanceToNearestStation As String = "DistanceToNearestStation"
			 Public Const Housekeeping As String = "Housekeeping"
			 Public Const ProtectionUser1 As String = "ProtectionUser1"
			 Public Const ProtectionUser2 As String = "ProtectionUser2"
			 Public Const ProtectionUser3 As String = "ProtectionUser3"
			 Public Const ProtectionUser4 As String = "ProtectionUser4"
			 Public Const LastIRInspDate As String = "LastIRInspDate"
			 Public Const IRInspOrg As String = "IRInspOrg"
			 Public Const IRInspComments As String = "IRInspComments"
			 Public Const LastArcFlashInspDate As String = "LastArcFlashInspDate"
			 Public Const LastArcFlashInspOrg As String = "LastArcFlashInspOrg"
			 Public Const LastArcFlashComments As String = "LastArcFlashComments"
			 Public Const LastPSMStudyDate As String = "LastPSMStudyDate"
			 Public Const LastPSMStudyOrg As String = "LastPSMStudyOrg"
			 Public Const LastPSMStudyComments As String = "LastPSMStudyComments"
			 Public Const LastDustHazInspDate As String = "LastDustHazInspDate"
			 Public Const LastDustHazInspOrg As String = "LastDustHazInspOrg"
			 Public Const LastDustHazInspComments As String = "LastDustHazInspComments"
			 Public Const LastProcHazInspDate As String = "LastProcHazInspDate"
			 Public Const LastProcHazInspOrg As String = "LastProcHazInspOrg"
			 Public Const LastProcHazInspComments As String = "LastProcHazInspComments"
			 Public Const LastIsoDate As String = "LastIsoDate"
			 Public Const LastIsoOrg As String = "LastIsoOrg"
			 Public Const LastIsoComments As String = "LastIsoComments"
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
			SyncLock GetType(CopeFireProtectionMetadata)
			
				If CopeFireProtectionMetadata.mapDelegates Is Nothing Then
					CopeFireProtectionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If CopeFireProtectionMetadata._meta Is Nothing Then
					CopeFireProtectionMetadata._meta = New CopeFireProtectionMetadata()
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
				meta.AddTypeMap("AreaWithAdequateSprinklers", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("AreaWithInadequateSprinkler", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("AreaWithoutSprinklersNeedingSprinklers", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("AreaWithoutSprinklersNotNeedingSprinklers", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("SprinklerProtectionCapability", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SprinklerProtectionCapabilityDescriptionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PublicWaterSupplyType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PrivateWaterSupplyType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterSupplyDuration", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterSupplyRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterSupplyComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecialHazardsRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecialHazardsComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireHydrantCoverage", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecialProtectionSystems", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecialProtectionSystemDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireExtinguishers", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SmallHoseStations", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SprinklerValvesLocked", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SprinklerValveTamperSwitches", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SprinklerWaterFlow", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("FirePumpCondition", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SmokeHeatDetection", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("IntrusionDetection", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Other", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("AlarmsDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("AlarmMonitoring", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WatchService", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PropertySurveillance", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SprinklerValves", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FirePumps", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InfraredScans", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SmokingControls", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Alarms", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireDoors", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Extinguishers", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HotWorkMonitoring", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ImpairmentHandling", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CombustionSafetyControls", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GeneralMaintenance", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ContractorSupv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ManagementOfChange", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EOType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EOTraining", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EmergResponseBCP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PublicFireDepartmentType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ISOCommunityRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DistanceToNearestStation", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Housekeeping", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProtectionUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProtectionUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProtectionUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProtectionUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastIRInspDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("IRInspOrg", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("IRInspComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastArcFlashInspDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastArcFlashInspOrg", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastArcFlashComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastPSMStudyDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastPSMStudyOrg", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastPSMStudyComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastDustHazInspDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastDustHazInspOrg", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastDustHazInspComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastProcHazInspDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastProcHazInspOrg", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastProcHazInspComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastIsoDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastIsoOrg", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastIsoComments", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-FireProtection"
				meta.Destination = "Cope-FireProtection"
				
				meta.spInsert = "proc_Cope-FireProtectionInsert"
				meta.spUpdate = "proc_Cope-FireProtectionUpdate"
				meta.spDelete = "proc_Cope-FireProtectionDelete"
				meta.spLoadAll = "proc_Cope-FireProtectionLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-FireProtectionLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As CopeFireProtectionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
