
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/10/2013 11:50:44 PM
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
	' Encapsulates the 'viewCCBMFacilityRating' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCBMFacilityRating))> _
	<XmlType("ViewCCBMFacilityRating")> _	
	Partial Public Class ViewCCBMFacilityRating 
		Inherits esViewCCBMFacilityRating
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCBMFacilityRating()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCBMFacilityRatingCollection")> _
	Partial Public Class ViewCCBMFacilityRatingCollection
		Inherits esViewCCBMFacilityRatingCollection
		Implements IEnumerable(Of ViewCCBMFacilityRating)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCBMFacilityRating))> _
		Public Class ViewCCBMFacilityRatingCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCBMFacilityRatingCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCBMFacilityRatingCollectionWCFPacket) As ViewCCBMFacilityRatingCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCBMFacilityRatingCollection) As ViewCCBMFacilityRatingCollectionWCFPacket
				Return New ViewCCBMFacilityRatingCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCBMFacilityRatingQuery 
		Inherits esViewCCBMFacilityRatingQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCBMFacilityRatingQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCBMFacilityRatingQuery) As String
			Return ViewCCBMFacilityRatingQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCBMFacilityRatingQuery
			Return DirectCast(ViewCCBMFacilityRatingQuery.SerializeHelper.FromXml(query, GetType(ViewCCBMFacilityRatingQuery)), ViewCCBMFacilityRatingQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCBMFacilityRating
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCBMFacilityRatingMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCBMFacilityRatingMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BoilersC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ProcEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OccupancyC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.CompSysC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechMaintC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecMaintC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.SparesC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.HumanElementC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BCPC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bcpc As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.Bcpc)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.Bcpc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.Bcpc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechEquipWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecEquipWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BoilersWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ProcEquipWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OccupancyWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.CompSysWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechMaintWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecMaintWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.SparesWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.HumanElementWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWR, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BCPWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bcpwr As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.Bcpwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMFacilityRatingMetadata.ColumnNames.Bcpwr, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.Bcpwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechEquipWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecEquipWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BoilersWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ProcEquipWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OccupancyWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.CompSysWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechMaintWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecMaintWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.SparesWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.HumanElementWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BCPWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWeight, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BCPWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.PassiveC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PassiveC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.PassiveC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.PassiveC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.PassiveC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.PassiveWC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PassiveWC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.PassiveWC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.PassiveWC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.PassiveWC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ActiveC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ActiveC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ActiveC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ActiveC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ActiveWC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveWC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ActiveWC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.ActiveWC, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ActiveWC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.TotalScoreCurrent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalScoreCurrent As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalScoreCurrent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalScoreCurrent, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.TotalScoreCurrent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.TotalRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalRating As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalRating, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.TotalRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.TotalWRComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalWRComplete As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalWRComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalWRComplete, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.TotalWRComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechEquipDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecEquipDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BoilersDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ProcEquipDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OccupancyDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.CompSysDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechMaintDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecMaintDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.SparesDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.HumanElementDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BCPDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BCPDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechEquipWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecEquipWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BoilersWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ProcEquipWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OccupancyWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.CompSysWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechMaintWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecMaintWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.SparesWrDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesWrDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWrDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWrDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWrDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.HumanElementWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BCPWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPWRDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWRDesc, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BCPWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OverallPlantRatingRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallPlantRatingRating As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRating, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OverallPlantRatingRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.TotalWRCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalWRCompleteRating As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalWRCompleteRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalWRCompleteRating, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.TotalWRCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechEquipCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecEquipCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BoilersCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ProcEquipCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OccupancyCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.CompSysCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechEquipWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecEquipWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BoilersWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ProcEquipWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OccupancyWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.CompSysWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechMaintCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecMaintCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.SparesCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.HumanElementCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BCPCColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPCColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPCColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPCColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BCPCColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.MechMaintWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.ElecMaintWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.SparesWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.HumanElementWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.BCPWRColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPWRColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWRColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWRColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BCPWRColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OverallPlantRatingRatingColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallPlantRatingRatingColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRatingColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRatingColor, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OverallPlantRatingRatingColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.OverallPlantRatingRatingDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallPlantRatingRatingDescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRatingDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRatingDescription, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OverallPlantRatingRatingDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyDescription1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription1, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyDescription2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription2, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyDescription3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription3 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription3, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyDescription4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription4 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription4, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyDescription5
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription5 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription5)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription5, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription5)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyColor1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor1, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyColor2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor2, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyColor3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor3 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor3, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyColor4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor4 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor4, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMFacilityRating.RatingKeyColor5
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor5 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor5)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor5, value) Then
					OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor5)
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
												
						Case "InspectionDate"
							Me.str().InspectionDate = CType(value, string)
												
						Case "MechEquipC"
							Me.str().MechEquipC = CType(value, string)
												
						Case "ElecEquipC"
							Me.str().ElecEquipC = CType(value, string)
												
						Case "BoilersC"
							Me.str().BoilersC = CType(value, string)
												
						Case "ProcEquipC"
							Me.str().ProcEquipC = CType(value, string)
												
						Case "OccupancyC"
							Me.str().OccupancyC = CType(value, string)
												
						Case "CompSysC"
							Me.str().CompSysC = CType(value, string)
												
						Case "MechMaintC"
							Me.str().MechMaintC = CType(value, string)
												
						Case "ElecMaintC"
							Me.str().ElecMaintC = CType(value, string)
												
						Case "SparesC"
							Me.str().SparesC = CType(value, string)
												
						Case "HumanElementC"
							Me.str().HumanElementC = CType(value, string)
												
						Case "Bcpc"
							Me.str().Bcpc = CType(value, string)
												
						Case "MechEquipWR"
							Me.str().MechEquipWR = CType(value, string)
												
						Case "ElecEquipWR"
							Me.str().ElecEquipWR = CType(value, string)
												
						Case "BoilersWR"
							Me.str().BoilersWR = CType(value, string)
												
						Case "ProcEquipWR"
							Me.str().ProcEquipWR = CType(value, string)
												
						Case "OccupancyWR"
							Me.str().OccupancyWR = CType(value, string)
												
						Case "CompSysWR"
							Me.str().CompSysWR = CType(value, string)
												
						Case "MechMaintWR"
							Me.str().MechMaintWR = CType(value, string)
												
						Case "ElecMaintWR"
							Me.str().ElecMaintWR = CType(value, string)
												
						Case "SparesWR"
							Me.str().SparesWR = CType(value, string)
												
						Case "HumanElementWR"
							Me.str().HumanElementWR = CType(value, string)
												
						Case "Bcpwr"
							Me.str().Bcpwr = CType(value, string)
												
						Case "MechEquipWeight"
							Me.str().MechEquipWeight = CType(value, string)
												
						Case "ElecEquipWeight"
							Me.str().ElecEquipWeight = CType(value, string)
												
						Case "BoilersWeight"
							Me.str().BoilersWeight = CType(value, string)
												
						Case "ProcEquipWeight"
							Me.str().ProcEquipWeight = CType(value, string)
												
						Case "OccupancyWeight"
							Me.str().OccupancyWeight = CType(value, string)
												
						Case "CompSysWeight"
							Me.str().CompSysWeight = CType(value, string)
												
						Case "MechMaintWeight"
							Me.str().MechMaintWeight = CType(value, string)
												
						Case "ElecMaintWeight"
							Me.str().ElecMaintWeight = CType(value, string)
												
						Case "SparesWeight"
							Me.str().SparesWeight = CType(value, string)
												
						Case "HumanElementWeight"
							Me.str().HumanElementWeight = CType(value, string)
												
						Case "BCPWeight"
							Me.str().BCPWeight = CType(value, string)
												
						Case "PassiveC"
							Me.str().PassiveC = CType(value, string)
												
						Case "PassiveWC"
							Me.str().PassiveWC = CType(value, string)
												
						Case "ActiveC"
							Me.str().ActiveC = CType(value, string)
												
						Case "ActiveWC"
							Me.str().ActiveWC = CType(value, string)
												
						Case "TotalScoreCurrent"
							Me.str().TotalScoreCurrent = CType(value, string)
												
						Case "TotalRating"
							Me.str().TotalRating = CType(value, string)
												
						Case "TotalWRComplete"
							Me.str().TotalWRComplete = CType(value, string)
												
						Case "MechEquipDesc"
							Me.str().MechEquipDesc = CType(value, string)
												
						Case "ElecEquipDesc"
							Me.str().ElecEquipDesc = CType(value, string)
												
						Case "BoilersDesc"
							Me.str().BoilersDesc = CType(value, string)
												
						Case "ProcEquipDesc"
							Me.str().ProcEquipDesc = CType(value, string)
												
						Case "OccupancyDesc"
							Me.str().OccupancyDesc = CType(value, string)
												
						Case "CompSysDesc"
							Me.str().CompSysDesc = CType(value, string)
												
						Case "MechMaintDesc"
							Me.str().MechMaintDesc = CType(value, string)
												
						Case "ElecMaintDesc"
							Me.str().ElecMaintDesc = CType(value, string)
												
						Case "SparesDesc"
							Me.str().SparesDesc = CType(value, string)
												
						Case "HumanElementDesc"
							Me.str().HumanElementDesc = CType(value, string)
												
						Case "BCPDesc"
							Me.str().BCPDesc = CType(value, string)
												
						Case "MechEquipWRDesc"
							Me.str().MechEquipWRDesc = CType(value, string)
												
						Case "ElecEquipWRDesc"
							Me.str().ElecEquipWRDesc = CType(value, string)
												
						Case "BoilersWRDesc"
							Me.str().BoilersWRDesc = CType(value, string)
												
						Case "ProcEquipWRDesc"
							Me.str().ProcEquipWRDesc = CType(value, string)
												
						Case "OccupancyWRDesc"
							Me.str().OccupancyWRDesc = CType(value, string)
												
						Case "CompSysWRDesc"
							Me.str().CompSysWRDesc = CType(value, string)
												
						Case "MechMaintWRDesc"
							Me.str().MechMaintWRDesc = CType(value, string)
												
						Case "ElecMaintWRDesc"
							Me.str().ElecMaintWRDesc = CType(value, string)
												
						Case "SparesWrDesc"
							Me.str().SparesWrDesc = CType(value, string)
												
						Case "HumanElementWRDesc"
							Me.str().HumanElementWRDesc = CType(value, string)
												
						Case "BCPWRDesc"
							Me.str().BCPWRDesc = CType(value, string)
												
						Case "OverallPlantRatingRating"
							Me.str().OverallPlantRatingRating = CType(value, string)
												
						Case "TotalWRCompleteRating"
							Me.str().TotalWRCompleteRating = CType(value, string)
												
						Case "MechEquipCColor"
							Me.str().MechEquipCColor = CType(value, string)
												
						Case "ElecEquipCColor"
							Me.str().ElecEquipCColor = CType(value, string)
												
						Case "BoilersCColor"
							Me.str().BoilersCColor = CType(value, string)
												
						Case "ProcEquipCColor"
							Me.str().ProcEquipCColor = CType(value, string)
												
						Case "OccupancyCColor"
							Me.str().OccupancyCColor = CType(value, string)
												
						Case "CompSysCColor"
							Me.str().CompSysCColor = CType(value, string)
												
						Case "MechEquipWRColor"
							Me.str().MechEquipWRColor = CType(value, string)
												
						Case "ElecEquipWRColor"
							Me.str().ElecEquipWRColor = CType(value, string)
												
						Case "BoilersWRColor"
							Me.str().BoilersWRColor = CType(value, string)
												
						Case "ProcEquipWRColor"
							Me.str().ProcEquipWRColor = CType(value, string)
												
						Case "OccupancyWRColor"
							Me.str().OccupancyWRColor = CType(value, string)
												
						Case "CompSysWRColor"
							Me.str().CompSysWRColor = CType(value, string)
												
						Case "MechMaintCColor"
							Me.str().MechMaintCColor = CType(value, string)
												
						Case "ElecMaintCColor"
							Me.str().ElecMaintCColor = CType(value, string)
												
						Case "SparesCColor"
							Me.str().SparesCColor = CType(value, string)
												
						Case "HumanElementCColor"
							Me.str().HumanElementCColor = CType(value, string)
												
						Case "BCPCColor"
							Me.str().BCPCColor = CType(value, string)
												
						Case "MechMaintWRColor"
							Me.str().MechMaintWRColor = CType(value, string)
												
						Case "ElecMaintWRColor"
							Me.str().ElecMaintWRColor = CType(value, string)
												
						Case "SparesWRColor"
							Me.str().SparesWRColor = CType(value, string)
												
						Case "HumanElementWRColor"
							Me.str().HumanElementWRColor = CType(value, string)
												
						Case "BCPWRColor"
							Me.str().BCPWRColor = CType(value, string)
												
						Case "OverallPlantRatingRatingColor"
							Me.str().OverallPlantRatingRatingColor = CType(value, string)
												
						Case "OverallPlantRatingRatingDescription"
							Me.str().OverallPlantRatingRatingDescription = CType(value, string)
												
						Case "RatingKeyDescription1"
							Me.str().RatingKeyDescription1 = CType(value, string)
												
						Case "RatingKeyDescription2"
							Me.str().RatingKeyDescription2 = CType(value, string)
												
						Case "RatingKeyDescription3"
							Me.str().RatingKeyDescription3 = CType(value, string)
												
						Case "RatingKeyDescription4"
							Me.str().RatingKeyDescription4 = CType(value, string)
												
						Case "RatingKeyDescription5"
							Me.str().RatingKeyDescription5 = CType(value, string)
												
						Case "RatingKeyColor1"
							Me.str().RatingKeyColor1 = CType(value, string)
												
						Case "RatingKeyColor2"
							Me.str().RatingKeyColor2 = CType(value, string)
												
						Case "RatingKeyColor3"
							Me.str().RatingKeyColor3 = CType(value, string)
												
						Case "RatingKeyColor4"
							Me.str().RatingKeyColor4 = CType(value, string)
												
						Case "RatingKeyColor5"
							Me.str().RatingKeyColor5 = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.Id)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "MechEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MechEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipC)
							End If
						
						Case "ElecEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipC)
							End If
						
						Case "BoilersC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BoilersC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersC)
							End If
						
						Case "ProcEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProcEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipC)
							End If
						
						Case "OccupancyC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.OccupancyC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyC)
							End If
						
						Case "CompSysC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CompSysC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysC)
							End If
						
						Case "MechMaintC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MechMaintC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintC)
							End If
						
						Case "ElecMaintC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecMaintC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintC)
							End If
						
						Case "SparesC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SparesC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesC)
							End If
						
						Case "HumanElementC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.HumanElementC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementC)
							End If
						
						Case "Bcpc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bcpc = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.Bcpc)
							End If
						
						Case "MechEquipWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MechEquipWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWR)
							End If
						
						Case "ElecEquipWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecEquipWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWR)
							End If
						
						Case "BoilersWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BoilersWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWR)
							End If
						
						Case "ProcEquipWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProcEquipWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWR)
							End If
						
						Case "OccupancyWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.OccupancyWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWR)
							End If
						
						Case "CompSysWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CompSysWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWR)
							End If
						
						Case "MechMaintWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MechMaintWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWR)
							End If
						
						Case "ElecMaintWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecMaintWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWR)
							End If
						
						Case "SparesWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SparesWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWR)
							End If
						
						Case "HumanElementWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.HumanElementWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWR)
							End If
						
						Case "Bcpwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bcpwr = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.Bcpwr)
							End If
						
						Case "MechEquipWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MechEquipWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWeight)
							End If
						
						Case "ElecEquipWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ElecEquipWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWeight)
							End If
						
						Case "BoilersWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.BoilersWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWeight)
							End If
						
						Case "ProcEquipWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ProcEquipWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWeight)
							End If
						
						Case "OccupancyWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.OccupancyWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWeight)
							End If
						
						Case "CompSysWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CompSysWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWeight)
							End If
						
						Case "MechMaintWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MechMaintWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWeight)
							End If
						
						Case "ElecMaintWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ElecMaintWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWeight)
							End If
						
						Case "SparesWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.SparesWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWeight)
							End If
						
						Case "HumanElementWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.HumanElementWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWeight)
							End If
						
						Case "BCPWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.BCPWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.BCPWeight)
							End If
						
						Case "PassiveC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PassiveC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.PassiveC)
							End If
						
						Case "PassiveWC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PassiveWC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.PassiveWC)
							End If
						
						Case "ActiveC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ActiveC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ActiveC)
							End If
						
						Case "ActiveWC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ActiveWC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.ActiveWC)
							End If
						
						Case "TotalScoreCurrent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotalScoreCurrent = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.TotalScoreCurrent)
							End If
						
						Case "TotalWRComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotalWRComplete = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMFacilityRatingMetadata.PropertyNames.TotalWRComplete)
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
		
			Public Sub New(ByVal entity As esViewCCBMFacilityRating)
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
		  	
			Public Property InspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionDate = Nothing
					Else
						entity.InspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MechEquipC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipC = Nothing
					Else
						entity.MechEquipC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ElecEquipC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipC = Nothing
					Else
						entity.ElecEquipC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BoilersC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersC = Nothing
					Else
						entity.BoilersC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProcEquipC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipC = Nothing
					Else
						entity.ProcEquipC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.OccupancyC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyC = Nothing
					Else
						entity.OccupancyC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CompSysC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysC = Nothing
					Else
						entity.CompSysC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MechMaintC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintC = Nothing
					Else
						entity.MechMaintC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ElecMaintC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintC = Nothing
					Else
						entity.ElecMaintC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SparesC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesC = Nothing
					Else
						entity.SparesC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.HumanElementC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementC = Nothing
					Else
						entity.HumanElementC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bcpc As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bcpc
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bcpc = Nothing
					Else
						entity.Bcpc = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MechEquipWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipWR = Nothing
					Else
						entity.MechEquipWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ElecEquipWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipWR = Nothing
					Else
						entity.ElecEquipWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BoilersWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersWR = Nothing
					Else
						entity.BoilersWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProcEquipWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipWR = Nothing
					Else
						entity.ProcEquipWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.OccupancyWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWR = Nothing
					Else
						entity.OccupancyWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CompSysWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysWR = Nothing
					Else
						entity.CompSysWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MechMaintWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintWR = Nothing
					Else
						entity.MechMaintWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ElecMaintWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintWR = Nothing
					Else
						entity.ElecMaintWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SparesWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesWR = Nothing
					Else
						entity.SparesWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.HumanElementWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWR = Nothing
					Else
						entity.HumanElementWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bcpwr As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bcpwr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bcpwr = Nothing
					Else
						entity.Bcpwr = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MechEquipWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipWeight = Nothing
					Else
						entity.MechEquipWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ElecEquipWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipWeight = Nothing
					Else
						entity.ElecEquipWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.BoilersWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersWeight = Nothing
					Else
						entity.BoilersWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ProcEquipWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipWeight = Nothing
					Else
						entity.ProcEquipWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.OccupancyWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWeight = Nothing
					Else
						entity.OccupancyWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CompSysWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysWeight = Nothing
					Else
						entity.CompSysWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MechMaintWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintWeight = Nothing
					Else
						entity.MechMaintWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ElecMaintWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintWeight = Nothing
					Else
						entity.ElecMaintWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.SparesWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesWeight = Nothing
					Else
						entity.SparesWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.HumanElementWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWeight = Nothing
					Else
						entity.HumanElementWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.BCPWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPWeight = Nothing
					Else
						entity.BCPWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PassiveC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PassiveC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PassiveC = Nothing
					Else
						entity.PassiveC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PassiveWC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PassiveWC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PassiveWC = Nothing
					Else
						entity.PassiveWC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ActiveC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveC = Nothing
					Else
						entity.ActiveC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveWC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ActiveWC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveWC = Nothing
					Else
						entity.ActiveWC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalScoreCurrent As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TotalScoreCurrent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalScoreCurrent = Nothing
					Else
						entity.TotalScoreCurrent = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalRating As System.String 
				Get
					Dim data_ As System.String = entity.TotalRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalRating = Nothing
					Else
						entity.TotalRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalWRComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TotalWRComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalWRComplete = Nothing
					Else
						entity.TotalWRComplete = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipDesc As System.String 
				Get
					Dim data_ As System.String = entity.MechEquipDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipDesc = Nothing
					Else
						entity.MechEquipDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipDesc As System.String 
				Get
					Dim data_ As System.String = entity.ElecEquipDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipDesc = Nothing
					Else
						entity.ElecEquipDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersDesc As System.String 
				Get
					Dim data_ As System.String = entity.BoilersDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersDesc = Nothing
					Else
						entity.BoilersDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipDesc As System.String 
				Get
					Dim data_ As System.String = entity.ProcEquipDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipDesc = Nothing
					Else
						entity.ProcEquipDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyDesc As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyDesc = Nothing
					Else
						entity.OccupancyDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysDesc As System.String 
				Get
					Dim data_ As System.String = entity.CompSysDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysDesc = Nothing
					Else
						entity.CompSysDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintDesc As System.String 
				Get
					Dim data_ As System.String = entity.MechMaintDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintDesc = Nothing
					Else
						entity.MechMaintDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintDesc As System.String 
				Get
					Dim data_ As System.String = entity.ElecMaintDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintDesc = Nothing
					Else
						entity.ElecMaintDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesDesc As System.String 
				Get
					Dim data_ As System.String = entity.SparesDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesDesc = Nothing
					Else
						entity.SparesDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementDesc As System.String 
				Get
					Dim data_ As System.String = entity.HumanElementDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementDesc = Nothing
					Else
						entity.HumanElementDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPDesc As System.String 
				Get
					Dim data_ As System.String = entity.BCPDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPDesc = Nothing
					Else
						entity.BCPDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.MechEquipWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipWRDesc = Nothing
					Else
						entity.MechEquipWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.ElecEquipWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipWRDesc = Nothing
					Else
						entity.ElecEquipWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.BoilersWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersWRDesc = Nothing
					Else
						entity.BoilersWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.ProcEquipWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipWRDesc = Nothing
					Else
						entity.ProcEquipWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWRDesc = Nothing
					Else
						entity.OccupancyWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.CompSysWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysWRDesc = Nothing
					Else
						entity.CompSysWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.MechMaintWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintWRDesc = Nothing
					Else
						entity.MechMaintWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.ElecMaintWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintWRDesc = Nothing
					Else
						entity.ElecMaintWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesWrDesc As System.String 
				Get
					Dim data_ As System.String = entity.SparesWrDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesWrDesc = Nothing
					Else
						entity.SparesWrDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.HumanElementWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWRDesc = Nothing
					Else
						entity.HumanElementWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.BCPWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPWRDesc = Nothing
					Else
						entity.BCPWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallPlantRatingRating As System.String 
				Get
					Dim data_ As System.String = entity.OverallPlantRatingRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallPlantRatingRating = Nothing
					Else
						entity.OverallPlantRatingRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalWRCompleteRating As System.String 
				Get
					Dim data_ As System.String = entity.TotalWRCompleteRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalWRCompleteRating = Nothing
					Else
						entity.TotalWRCompleteRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipCColor As System.String 
				Get
					Dim data_ As System.String = entity.MechEquipCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipCColor = Nothing
					Else
						entity.MechEquipCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipCColor As System.String 
				Get
					Dim data_ As System.String = entity.ElecEquipCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipCColor = Nothing
					Else
						entity.ElecEquipCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersCColor As System.String 
				Get
					Dim data_ As System.String = entity.BoilersCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersCColor = Nothing
					Else
						entity.BoilersCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipCColor As System.String 
				Get
					Dim data_ As System.String = entity.ProcEquipCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipCColor = Nothing
					Else
						entity.ProcEquipCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyCColor As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyCColor = Nothing
					Else
						entity.OccupancyCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysCColor As System.String 
				Get
					Dim data_ As System.String = entity.CompSysCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysCColor = Nothing
					Else
						entity.CompSysCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipWRColor As System.String 
				Get
					Dim data_ As System.String = entity.MechEquipWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipWRColor = Nothing
					Else
						entity.MechEquipWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipWRColor As System.String 
				Get
					Dim data_ As System.String = entity.ElecEquipWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipWRColor = Nothing
					Else
						entity.ElecEquipWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersWRColor As System.String 
				Get
					Dim data_ As System.String = entity.BoilersWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersWRColor = Nothing
					Else
						entity.BoilersWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipWRColor As System.String 
				Get
					Dim data_ As System.String = entity.ProcEquipWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipWRColor = Nothing
					Else
						entity.ProcEquipWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWRColor As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWRColor = Nothing
					Else
						entity.OccupancyWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysWRColor As System.String 
				Get
					Dim data_ As System.String = entity.CompSysWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysWRColor = Nothing
					Else
						entity.CompSysWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintCColor As System.String 
				Get
					Dim data_ As System.String = entity.MechMaintCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintCColor = Nothing
					Else
						entity.MechMaintCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintCColor As System.String 
				Get
					Dim data_ As System.String = entity.ElecMaintCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintCColor = Nothing
					Else
						entity.ElecMaintCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesCColor As System.String 
				Get
					Dim data_ As System.String = entity.SparesCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesCColor = Nothing
					Else
						entity.SparesCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementCColor As System.String 
				Get
					Dim data_ As System.String = entity.HumanElementCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementCColor = Nothing
					Else
						entity.HumanElementCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPCColor As System.String 
				Get
					Dim data_ As System.String = entity.BCPCColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPCColor = Nothing
					Else
						entity.BCPCColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintWRColor As System.String 
				Get
					Dim data_ As System.String = entity.MechMaintWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintWRColor = Nothing
					Else
						entity.MechMaintWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintWRColor As System.String 
				Get
					Dim data_ As System.String = entity.ElecMaintWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintWRColor = Nothing
					Else
						entity.ElecMaintWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesWRColor As System.String 
				Get
					Dim data_ As System.String = entity.SparesWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesWRColor = Nothing
					Else
						entity.SparesWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWRColor As System.String 
				Get
					Dim data_ As System.String = entity.HumanElementWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWRColor = Nothing
					Else
						entity.HumanElementWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPWRColor As System.String 
				Get
					Dim data_ As System.String = entity.BCPWRColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPWRColor = Nothing
					Else
						entity.BCPWRColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallPlantRatingRatingColor As System.String 
				Get
					Dim data_ As System.String = entity.OverallPlantRatingRatingColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallPlantRatingRatingColor = Nothing
					Else
						entity.OverallPlantRatingRatingColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallPlantRatingRatingDescription As System.String 
				Get
					Dim data_ As System.String = entity.OverallPlantRatingRatingDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallPlantRatingRatingDescription = Nothing
					Else
						entity.OverallPlantRatingRatingDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription1 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription1 = Nothing
					Else
						entity.RatingKeyDescription1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription2 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription2 = Nothing
					Else
						entity.RatingKeyDescription2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription3 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription3 = Nothing
					Else
						entity.RatingKeyDescription3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription4 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription4 = Nothing
					Else
						entity.RatingKeyDescription4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription5 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription5 = Nothing
					Else
						entity.RatingKeyDescription5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor1 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor1 = Nothing
					Else
						entity.RatingKeyColor1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor2 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor2 = Nothing
					Else
						entity.RatingKeyColor2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor3 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor3 = Nothing
					Else
						entity.RatingKeyColor3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor4 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor4 = Nothing
					Else
						entity.RatingKeyColor4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor5 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor5 = Nothing
					Else
						entity.RatingKeyColor5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCBMFacilityRating
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCBMFacilityRatingMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCBMFacilityRatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCBMFacilityRatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCBMFacilityRatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCBMFacilityRatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCBMFacilityRatingQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCBMFacilityRatingCollection
		Inherits esEntityCollection(Of ViewCCBMFacilityRating)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCBMFacilityRatingMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCBMFacilityRatingCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCBMFacilityRatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCBMFacilityRatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCBMFacilityRatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCBMFacilityRatingQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCBMFacilityRatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCBMFacilityRatingQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCBMFacilityRatingQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCBMFacilityRatingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCBMFacilityRatingMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "InspectionDate" 
					Return Me.InspectionDate
				Case "MechEquipC" 
					Return Me.MechEquipC
				Case "ElecEquipC" 
					Return Me.ElecEquipC
				Case "BoilersC" 
					Return Me.BoilersC
				Case "ProcEquipC" 
					Return Me.ProcEquipC
				Case "OccupancyC" 
					Return Me.OccupancyC
				Case "CompSysC" 
					Return Me.CompSysC
				Case "MechMaintC" 
					Return Me.MechMaintC
				Case "ElecMaintC" 
					Return Me.ElecMaintC
				Case "SparesC" 
					Return Me.SparesC
				Case "HumanElementC" 
					Return Me.HumanElementC
				Case "Bcpc" 
					Return Me.Bcpc
				Case "MechEquipWR" 
					Return Me.MechEquipWR
				Case "ElecEquipWR" 
					Return Me.ElecEquipWR
				Case "BoilersWR" 
					Return Me.BoilersWR
				Case "ProcEquipWR" 
					Return Me.ProcEquipWR
				Case "OccupancyWR" 
					Return Me.OccupancyWR
				Case "CompSysWR" 
					Return Me.CompSysWR
				Case "MechMaintWR" 
					Return Me.MechMaintWR
				Case "ElecMaintWR" 
					Return Me.ElecMaintWR
				Case "SparesWR" 
					Return Me.SparesWR
				Case "HumanElementWR" 
					Return Me.HumanElementWR
				Case "Bcpwr" 
					Return Me.Bcpwr
				Case "MechEquipWeight" 
					Return Me.MechEquipWeight
				Case "ElecEquipWeight" 
					Return Me.ElecEquipWeight
				Case "BoilersWeight" 
					Return Me.BoilersWeight
				Case "ProcEquipWeight" 
					Return Me.ProcEquipWeight
				Case "OccupancyWeight" 
					Return Me.OccupancyWeight
				Case "CompSysWeight" 
					Return Me.CompSysWeight
				Case "MechMaintWeight" 
					Return Me.MechMaintWeight
				Case "ElecMaintWeight" 
					Return Me.ElecMaintWeight
				Case "SparesWeight" 
					Return Me.SparesWeight
				Case "HumanElementWeight" 
					Return Me.HumanElementWeight
				Case "BCPWeight" 
					Return Me.BCPWeight
				Case "PassiveC" 
					Return Me.PassiveC
				Case "PassiveWC" 
					Return Me.PassiveWC
				Case "ActiveC" 
					Return Me.ActiveC
				Case "ActiveWC" 
					Return Me.ActiveWC
				Case "TotalScoreCurrent" 
					Return Me.TotalScoreCurrent
				Case "TotalRating" 
					Return Me.TotalRating
				Case "TotalWRComplete" 
					Return Me.TotalWRComplete
				Case "MechEquipDesc" 
					Return Me.MechEquipDesc
				Case "ElecEquipDesc" 
					Return Me.ElecEquipDesc
				Case "BoilersDesc" 
					Return Me.BoilersDesc
				Case "ProcEquipDesc" 
					Return Me.ProcEquipDesc
				Case "OccupancyDesc" 
					Return Me.OccupancyDesc
				Case "CompSysDesc" 
					Return Me.CompSysDesc
				Case "MechMaintDesc" 
					Return Me.MechMaintDesc
				Case "ElecMaintDesc" 
					Return Me.ElecMaintDesc
				Case "SparesDesc" 
					Return Me.SparesDesc
				Case "HumanElementDesc" 
					Return Me.HumanElementDesc
				Case "BCPDesc" 
					Return Me.BCPDesc
				Case "MechEquipWRDesc" 
					Return Me.MechEquipWRDesc
				Case "ElecEquipWRDesc" 
					Return Me.ElecEquipWRDesc
				Case "BoilersWRDesc" 
					Return Me.BoilersWRDesc
				Case "ProcEquipWRDesc" 
					Return Me.ProcEquipWRDesc
				Case "OccupancyWRDesc" 
					Return Me.OccupancyWRDesc
				Case "CompSysWRDesc" 
					Return Me.CompSysWRDesc
				Case "MechMaintWRDesc" 
					Return Me.MechMaintWRDesc
				Case "ElecMaintWRDesc" 
					Return Me.ElecMaintWRDesc
				Case "SparesWrDesc" 
					Return Me.SparesWrDesc
				Case "HumanElementWRDesc" 
					Return Me.HumanElementWRDesc
				Case "BCPWRDesc" 
					Return Me.BCPWRDesc
				Case "OverallPlantRatingRating" 
					Return Me.OverallPlantRatingRating
				Case "TotalWRCompleteRating" 
					Return Me.TotalWRCompleteRating
				Case "MechEquipCColor" 
					Return Me.MechEquipCColor
				Case "ElecEquipCColor" 
					Return Me.ElecEquipCColor
				Case "BoilersCColor" 
					Return Me.BoilersCColor
				Case "ProcEquipCColor" 
					Return Me.ProcEquipCColor
				Case "OccupancyCColor" 
					Return Me.OccupancyCColor
				Case "CompSysCColor" 
					Return Me.CompSysCColor
				Case "MechEquipWRColor" 
					Return Me.MechEquipWRColor
				Case "ElecEquipWRColor" 
					Return Me.ElecEquipWRColor
				Case "BoilersWRColor" 
					Return Me.BoilersWRColor
				Case "ProcEquipWRColor" 
					Return Me.ProcEquipWRColor
				Case "OccupancyWRColor" 
					Return Me.OccupancyWRColor
				Case "CompSysWRColor" 
					Return Me.CompSysWRColor
				Case "MechMaintCColor" 
					Return Me.MechMaintCColor
				Case "ElecMaintCColor" 
					Return Me.ElecMaintCColor
				Case "SparesCColor" 
					Return Me.SparesCColor
				Case "HumanElementCColor" 
					Return Me.HumanElementCColor
				Case "BCPCColor" 
					Return Me.BCPCColor
				Case "MechMaintWRColor" 
					Return Me.MechMaintWRColor
				Case "ElecMaintWRColor" 
					Return Me.ElecMaintWRColor
				Case "SparesWRColor" 
					Return Me.SparesWRColor
				Case "HumanElementWRColor" 
					Return Me.HumanElementWRColor
				Case "BCPWRColor" 
					Return Me.BCPWRColor
				Case "OverallPlantRatingRatingColor" 
					Return Me.OverallPlantRatingRatingColor
				Case "OverallPlantRatingRatingDescription" 
					Return Me.OverallPlantRatingRatingDescription
				Case "RatingKeyDescription1" 
					Return Me.RatingKeyDescription1
				Case "RatingKeyDescription2" 
					Return Me.RatingKeyDescription2
				Case "RatingKeyDescription3" 
					Return Me.RatingKeyDescription3
				Case "RatingKeyDescription4" 
					Return Me.RatingKeyDescription4
				Case "RatingKeyDescription5" 
					Return Me.RatingKeyDescription5
				Case "RatingKeyColor1" 
					Return Me.RatingKeyColor1
				Case "RatingKeyColor2" 
					Return Me.RatingKeyColor2
				Case "RatingKeyColor3" 
					Return Me.RatingKeyColor3
				Case "RatingKeyColor4" 
					Return Me.RatingKeyColor4
				Case "RatingKeyColor5" 
					Return Me.RatingKeyColor5
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SparesC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.SparesC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bcpc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.Bcpc, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SparesWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bcpwr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.Bcpwr, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property SparesWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property BCPWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PassiveC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.PassiveC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PassiveWC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.PassiveWC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ActiveC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveWC As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ActiveWC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalScoreCurrent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.TotalScoreCurrent, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalRating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.TotalRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWRComplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.TotalWRComplete, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.SparesDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BCPDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BCPDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesWrDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWrDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BCPWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverallPlantRatingRating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWRCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.TotalWRCompleteRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.SparesCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BCPCColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BCPCColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BCPWRColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWRColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverallPlantRatingRatingColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRatingColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverallPlantRatingRatingDescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRatingDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription5 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription5, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor5 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor5, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCBMFacilityRatingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.InspectionDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipC, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipC, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersC, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipC, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyC, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysC, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintC, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintC, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesC, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.SparesC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementC, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.Bcpc, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.Bcpc
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWR, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWR, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWR, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWR, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWR, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWR, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWR, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWR, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWR, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWR, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.Bcpwr, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.Bcpwr
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWeight, 25, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWeight, 26, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWeight, 27, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWeight, 28, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWeight, 29, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWeight, 30, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWeight, 31, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWeight, 32, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWeight, 33, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWeight, 34, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWeight, 35, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BCPWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.PassiveC, 36, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.PassiveC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.PassiveWC, 37, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.PassiveWC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ActiveC, 38, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ActiveC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ActiveWC, 39, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ActiveWC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalScoreCurrent, 40, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.TotalScoreCurrent
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalRating, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.TotalRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalWRComplete, 42, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.TotalWRComplete
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipDesc, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipDesc, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersDesc, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipDesc, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyDesc, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysDesc, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintDesc, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintDesc, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesDesc, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.SparesDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementDesc, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPDesc, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BCPDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWRDesc, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWRDesc, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWRDesc, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWRDesc, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWRDesc, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWRDesc, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWRDesc, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWRDesc, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWrDesc, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWrDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWRDesc, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWRDesc, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BCPWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRating, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OverallPlantRatingRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.TotalWRCompleteRating, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.TotalWRCompleteRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipCColor, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipCColor, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersCColor, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipCColor, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyCColor, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysCColor, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechEquipWRColor, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechEquipWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecEquipWRColor, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecEquipWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BoilersWRColor, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BoilersWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ProcEquipWRColor, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ProcEquipWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OccupancyWRColor, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OccupancyWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.CompSysWRColor, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.CompSysWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintCColor, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintCColor, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesCColor, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.SparesCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementCColor, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPCColor, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BCPCColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.MechMaintWRColor, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.MechMaintWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.ElecMaintWRColor, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.ElecMaintWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.SparesWRColor, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.SparesWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.HumanElementWRColor, 87, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.HumanElementWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.BCPWRColor, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.BCPWRColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRatingColor, 89, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OverallPlantRatingRatingColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.OverallPlantRatingRatingDescription, 90, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.OverallPlantRatingRatingDescription
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription1, 91, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription2, 92, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription2
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription3, 93, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription3
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription4, 94, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription4
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyDescription5, 95, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyDescription5
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor1, 96, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor2, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor2
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor3, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor3
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor4, 99, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor4
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMFacilityRatingMetadata.ColumnNames.RatingKeyColor5, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMFacilityRatingMetadata.PropertyNames.RatingKeyColor5
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCBMFacilityRatingMetadata
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
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const MechEquipC As String = "MechEquipC"
			 Public Const ElecEquipC As String = "ElecEquipC"
			 Public Const BoilersC As String = "BoilersC"
			 Public Const ProcEquipC As String = "ProcEquipC"
			 Public Const OccupancyC As String = "OccupancyC"
			 Public Const CompSysC As String = "CompSysC"
			 Public Const MechMaintC As String = "MechMaintC"
			 Public Const ElecMaintC As String = "ElecMaintC"
			 Public Const SparesC As String = "SparesC"
			 Public Const HumanElementC As String = "HumanElementC"
			 Public Const Bcpc As String = "BCPC"
			 Public Const MechEquipWR As String = "MechEquipWR"
			 Public Const ElecEquipWR As String = "ElecEquipWR"
			 Public Const BoilersWR As String = "BoilersWR"
			 Public Const ProcEquipWR As String = "ProcEquipWR"
			 Public Const OccupancyWR As String = "OccupancyWR"
			 Public Const CompSysWR As String = "CompSysWR"
			 Public Const MechMaintWR As String = "MechMaintWR"
			 Public Const ElecMaintWR As String = "ElecMaintWR"
			 Public Const SparesWR As String = "SparesWR"
			 Public Const HumanElementWR As String = "HumanElementWR"
			 Public Const Bcpwr As String = "BCPWR"
			 Public Const MechEquipWeight As String = "MechEquipWeight"
			 Public Const ElecEquipWeight As String = "ElecEquipWeight"
			 Public Const BoilersWeight As String = "BoilersWeight"
			 Public Const ProcEquipWeight As String = "ProcEquipWeight"
			 Public Const OccupancyWeight As String = "OccupancyWeight"
			 Public Const CompSysWeight As String = "CompSysWeight"
			 Public Const MechMaintWeight As String = "MechMaintWeight"
			 Public Const ElecMaintWeight As String = "ElecMaintWeight"
			 Public Const SparesWeight As String = "SparesWeight"
			 Public Const HumanElementWeight As String = "HumanElementWeight"
			 Public Const BCPWeight As String = "BCPWeight"
			 Public Const PassiveC As String = "PassiveC"
			 Public Const PassiveWC As String = "PassiveWC"
			 Public Const ActiveC As String = "ActiveC"
			 Public Const ActiveWC As String = "ActiveWC"
			 Public Const TotalScoreCurrent As String = "TotalScoreCurrent"
			 Public Const TotalRating As String = "TotalRating"
			 Public Const TotalWRComplete As String = "TotalWRComplete"
			 Public Const MechEquipDesc As String = "MechEquipDesc"
			 Public Const ElecEquipDesc As String = "ElecEquipDesc"
			 Public Const BoilersDesc As String = "BoilersDesc"
			 Public Const ProcEquipDesc As String = "ProcEquipDesc"
			 Public Const OccupancyDesc As String = "OccupancyDesc"
			 Public Const CompSysDesc As String = "CompSysDesc"
			 Public Const MechMaintDesc As String = "MechMaintDesc"
			 Public Const ElecMaintDesc As String = "ElecMaintDesc"
			 Public Const SparesDesc As String = "SparesDesc"
			 Public Const HumanElementDesc As String = "HumanElementDesc"
			 Public Const BCPDesc As String = "BCPDesc"
			 Public Const MechEquipWRDesc As String = "MechEquipWRDesc"
			 Public Const ElecEquipWRDesc As String = "ElecEquipWRDesc"
			 Public Const BoilersWRDesc As String = "BoilersWRDesc"
			 Public Const ProcEquipWRDesc As String = "ProcEquipWRDesc"
			 Public Const OccupancyWRDesc As String = "OccupancyWRDesc"
			 Public Const CompSysWRDesc As String = "CompSysWRDesc"
			 Public Const MechMaintWRDesc As String = "MechMaintWRDesc"
			 Public Const ElecMaintWRDesc As String = "ElecMaintWRDesc"
			 Public Const SparesWrDesc As String = "SparesWrDesc"
			 Public Const HumanElementWRDesc As String = "HumanElementWRDesc"
			 Public Const BCPWRDesc As String = "BCPWRDesc"
			 Public Const OverallPlantRatingRating As String = "OverallPlantRatingRating"
			 Public Const TotalWRCompleteRating As String = "TotalWRCompleteRating"
			 Public Const MechEquipCColor As String = "MechEquipCColor"
			 Public Const ElecEquipCColor As String = "ElecEquipCColor"
			 Public Const BoilersCColor As String = "BoilersCColor"
			 Public Const ProcEquipCColor As String = "ProcEquipCColor"
			 Public Const OccupancyCColor As String = "OccupancyCColor"
			 Public Const CompSysCColor As String = "CompSysCColor"
			 Public Const MechEquipWRColor As String = "MechEquipWRColor"
			 Public Const ElecEquipWRColor As String = "ElecEquipWRColor"
			 Public Const BoilersWRColor As String = "BoilersWRColor"
			 Public Const ProcEquipWRColor As String = "ProcEquipWRColor"
			 Public Const OccupancyWRColor As String = "OccupancyWRColor"
			 Public Const CompSysWRColor As String = "CompSysWRColor"
			 Public Const MechMaintCColor As String = "MechMaintCColor"
			 Public Const ElecMaintCColor As String = "ElecMaintCColor"
			 Public Const SparesCColor As String = "SparesCColor"
			 Public Const HumanElementCColor As String = "HumanElementCColor"
			 Public Const BCPCColor As String = "BCPCColor"
			 Public Const MechMaintWRColor As String = "MechMaintWRColor"
			 Public Const ElecMaintWRColor As String = "ElecMaintWRColor"
			 Public Const SparesWRColor As String = "SparesWRColor"
			 Public Const HumanElementWRColor As String = "HumanElementWRColor"
			 Public Const BCPWRColor As String = "BCPWRColor"
			 Public Const OverallPlantRatingRatingColor As String = "OverallPlantRatingRatingColor"
			 Public Const OverallPlantRatingRatingDescription As String = "OverallPlantRatingRatingDescription"
			 Public Const RatingKeyDescription1 As String = "RatingKeyDescription1"
			 Public Const RatingKeyDescription2 As String = "RatingKeyDescription2"
			 Public Const RatingKeyDescription3 As String = "RatingKeyDescription3"
			 Public Const RatingKeyDescription4 As String = "RatingKeyDescription4"
			 Public Const RatingKeyDescription5 As String = "RatingKeyDescription5"
			 Public Const RatingKeyColor1 As String = "RatingKeyColor1"
			 Public Const RatingKeyColor2 As String = "RatingKeyColor2"
			 Public Const RatingKeyColor3 As String = "RatingKeyColor3"
			 Public Const RatingKeyColor4 As String = "RatingKeyColor4"
			 Public Const RatingKeyColor5 As String = "RatingKeyColor5"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const MechEquipC As String = "MechEquipC"
			 Public Const ElecEquipC As String = "ElecEquipC"
			 Public Const BoilersC As String = "BoilersC"
			 Public Const ProcEquipC As String = "ProcEquipC"
			 Public Const OccupancyC As String = "OccupancyC"
			 Public Const CompSysC As String = "CompSysC"
			 Public Const MechMaintC As String = "MechMaintC"
			 Public Const ElecMaintC As String = "ElecMaintC"
			 Public Const SparesC As String = "SparesC"
			 Public Const HumanElementC As String = "HumanElementC"
			 Public Const Bcpc As String = "Bcpc"
			 Public Const MechEquipWR As String = "MechEquipWR"
			 Public Const ElecEquipWR As String = "ElecEquipWR"
			 Public Const BoilersWR As String = "BoilersWR"
			 Public Const ProcEquipWR As String = "ProcEquipWR"
			 Public Const OccupancyWR As String = "OccupancyWR"
			 Public Const CompSysWR As String = "CompSysWR"
			 Public Const MechMaintWR As String = "MechMaintWR"
			 Public Const ElecMaintWR As String = "ElecMaintWR"
			 Public Const SparesWR As String = "SparesWR"
			 Public Const HumanElementWR As String = "HumanElementWR"
			 Public Const Bcpwr As String = "Bcpwr"
			 Public Const MechEquipWeight As String = "MechEquipWeight"
			 Public Const ElecEquipWeight As String = "ElecEquipWeight"
			 Public Const BoilersWeight As String = "BoilersWeight"
			 Public Const ProcEquipWeight As String = "ProcEquipWeight"
			 Public Const OccupancyWeight As String = "OccupancyWeight"
			 Public Const CompSysWeight As String = "CompSysWeight"
			 Public Const MechMaintWeight As String = "MechMaintWeight"
			 Public Const ElecMaintWeight As String = "ElecMaintWeight"
			 Public Const SparesWeight As String = "SparesWeight"
			 Public Const HumanElementWeight As String = "HumanElementWeight"
			 Public Const BCPWeight As String = "BCPWeight"
			 Public Const PassiveC As String = "PassiveC"
			 Public Const PassiveWC As String = "PassiveWC"
			 Public Const ActiveC As String = "ActiveC"
			 Public Const ActiveWC As String = "ActiveWC"
			 Public Const TotalScoreCurrent As String = "TotalScoreCurrent"
			 Public Const TotalRating As String = "TotalRating"
			 Public Const TotalWRComplete As String = "TotalWRComplete"
			 Public Const MechEquipDesc As String = "MechEquipDesc"
			 Public Const ElecEquipDesc As String = "ElecEquipDesc"
			 Public Const BoilersDesc As String = "BoilersDesc"
			 Public Const ProcEquipDesc As String = "ProcEquipDesc"
			 Public Const OccupancyDesc As String = "OccupancyDesc"
			 Public Const CompSysDesc As String = "CompSysDesc"
			 Public Const MechMaintDesc As String = "MechMaintDesc"
			 Public Const ElecMaintDesc As String = "ElecMaintDesc"
			 Public Const SparesDesc As String = "SparesDesc"
			 Public Const HumanElementDesc As String = "HumanElementDesc"
			 Public Const BCPDesc As String = "BCPDesc"
			 Public Const MechEquipWRDesc As String = "MechEquipWRDesc"
			 Public Const ElecEquipWRDesc As String = "ElecEquipWRDesc"
			 Public Const BoilersWRDesc As String = "BoilersWRDesc"
			 Public Const ProcEquipWRDesc As String = "ProcEquipWRDesc"
			 Public Const OccupancyWRDesc As String = "OccupancyWRDesc"
			 Public Const CompSysWRDesc As String = "CompSysWRDesc"
			 Public Const MechMaintWRDesc As String = "MechMaintWRDesc"
			 Public Const ElecMaintWRDesc As String = "ElecMaintWRDesc"
			 Public Const SparesWrDesc As String = "SparesWrDesc"
			 Public Const HumanElementWRDesc As String = "HumanElementWRDesc"
			 Public Const BCPWRDesc As String = "BCPWRDesc"
			 Public Const OverallPlantRatingRating As String = "OverallPlantRatingRating"
			 Public Const TotalWRCompleteRating As String = "TotalWRCompleteRating"
			 Public Const MechEquipCColor As String = "MechEquipCColor"
			 Public Const ElecEquipCColor As String = "ElecEquipCColor"
			 Public Const BoilersCColor As String = "BoilersCColor"
			 Public Const ProcEquipCColor As String = "ProcEquipCColor"
			 Public Const OccupancyCColor As String = "OccupancyCColor"
			 Public Const CompSysCColor As String = "CompSysCColor"
			 Public Const MechEquipWRColor As String = "MechEquipWRColor"
			 Public Const ElecEquipWRColor As String = "ElecEquipWRColor"
			 Public Const BoilersWRColor As String = "BoilersWRColor"
			 Public Const ProcEquipWRColor As String = "ProcEquipWRColor"
			 Public Const OccupancyWRColor As String = "OccupancyWRColor"
			 Public Const CompSysWRColor As String = "CompSysWRColor"
			 Public Const MechMaintCColor As String = "MechMaintCColor"
			 Public Const ElecMaintCColor As String = "ElecMaintCColor"
			 Public Const SparesCColor As String = "SparesCColor"
			 Public Const HumanElementCColor As String = "HumanElementCColor"
			 Public Const BCPCColor As String = "BCPCColor"
			 Public Const MechMaintWRColor As String = "MechMaintWRColor"
			 Public Const ElecMaintWRColor As String = "ElecMaintWRColor"
			 Public Const SparesWRColor As String = "SparesWRColor"
			 Public Const HumanElementWRColor As String = "HumanElementWRColor"
			 Public Const BCPWRColor As String = "BCPWRColor"
			 Public Const OverallPlantRatingRatingColor As String = "OverallPlantRatingRatingColor"
			 Public Const OverallPlantRatingRatingDescription As String = "OverallPlantRatingRatingDescription"
			 Public Const RatingKeyDescription1 As String = "RatingKeyDescription1"
			 Public Const RatingKeyDescription2 As String = "RatingKeyDescription2"
			 Public Const RatingKeyDescription3 As String = "RatingKeyDescription3"
			 Public Const RatingKeyDescription4 As String = "RatingKeyDescription4"
			 Public Const RatingKeyDescription5 As String = "RatingKeyDescription5"
			 Public Const RatingKeyColor1 As String = "RatingKeyColor1"
			 Public Const RatingKeyColor2 As String = "RatingKeyColor2"
			 Public Const RatingKeyColor3 As String = "RatingKeyColor3"
			 Public Const RatingKeyColor4 As String = "RatingKeyColor4"
			 Public Const RatingKeyColor5 As String = "RatingKeyColor5"
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
			SyncLock GetType(ViewCCBMFacilityRatingMetadata)
			
				If ViewCCBMFacilityRatingMetadata.mapDelegates Is Nothing Then
					ViewCCBMFacilityRatingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCBMFacilityRatingMetadata._meta Is Nothing Then
					ViewCCBMFacilityRatingMetadata._meta = New ViewCCBMFacilityRatingMetadata()
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
				meta.AddTypeMap("InspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("MechEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BoilersC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProcEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("OccupancyC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CompSysC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechMaintC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecMaintC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SparesC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("HumanElementC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bcpc", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechEquipWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecEquipWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BoilersWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProcEquipWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("OccupancyWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CompSysWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechMaintWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecMaintWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SparesWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("HumanElementWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bcpwr", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechEquipWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ElecEquipWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("BoilersWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ProcEquipWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("OccupancyWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CompSysWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MechMaintWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ElecMaintWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("SparesWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("HumanElementWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("BCPWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PassiveC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PassiveWC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ActiveC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ActiveWC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotalScoreCurrent", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotalRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalWRComplete", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MechEquipDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecEquipDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProcEquipDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OccupancyDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompSysDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechMaintDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecMaintDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SparesDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HumanElementDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BCPDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechEquipWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecEquipWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProcEquipWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OccupancyWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompSysWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechMaintWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecMaintWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SparesWrDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HumanElementWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BCPWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OverallPlantRatingRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalWRCompleteRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MechEquipCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ElecEquipCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BoilersCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProcEquipCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OccupancyCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompSysCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MechEquipWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ElecEquipWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BoilersWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProcEquipWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OccupancyWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompSysWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MechMaintCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ElecMaintCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SparesCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HumanElementCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BCPCColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MechMaintWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ElecMaintWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SparesWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HumanElementWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BCPWRColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OverallPlantRatingRatingColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OverallPlantRatingRatingDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription5", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor5", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCBMFacilityRating"
				meta.Destination = "viewCCBMFacilityRating"
				
				meta.spInsert = "proc_viewCCBMFacilityRatingInsert"
				meta.spUpdate = "proc_viewCCBMFacilityRatingUpdate"
				meta.spDelete = "proc_viewCCBMFacilityRatingDelete"
				meta.spLoadAll = "proc_viewCCBMFacilityRatingLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCBMFacilityRatingLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCBMFacilityRatingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
