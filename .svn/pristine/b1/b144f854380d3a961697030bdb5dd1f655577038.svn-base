
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2013 1:05:42 PM
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
	' Encapsulates the 'vwBMElectMaintenanceSummary' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwBMElectMaintenanceSummary))> _
	<XmlType("VwBMElectMaintenanceSummary")> _	
	Partial Public Class VwBMElectMaintenanceSummary 
		Inherits esVwBMElectMaintenanceSummary
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwBMElectMaintenanceSummary()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwBMElectMaintenanceSummaryCollection")> _
	Partial Public Class VwBMElectMaintenanceSummaryCollection
		Inherits esVwBMElectMaintenanceSummaryCollection
		Implements IEnumerable(Of VwBMElectMaintenanceSummary)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwBMElectMaintenanceSummary))> _
		Public Class VwBMElectMaintenanceSummaryCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwBMElectMaintenanceSummaryCollection)
			
			Public Shared Widening Operator CType(packet As VwBMElectMaintenanceSummaryCollectionWCFPacket) As VwBMElectMaintenanceSummaryCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwBMElectMaintenanceSummaryCollection) As VwBMElectMaintenanceSummaryCollectionWCFPacket
				Return New VwBMElectMaintenanceSummaryCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwBMElectMaintenanceSummaryQuery 
		Inherits esVwBMElectMaintenanceSummaryQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwBMElectMaintenanceSummaryQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwBMElectMaintenanceSummaryQuery) As String
			Return VwBMElectMaintenanceSummaryQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwBMElectMaintenanceSummaryQuery
			Return DirectCast(VwBMElectMaintenanceSummaryQuery.SerializeHelper.FromXml(query, GetType(VwBMElectMaintenanceSummaryQuery)), VwBMElectMaintenanceSummaryQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwBMElectMaintenanceSummary
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(VwBMElectMaintenanceSummaryMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(VwBMElectMaintenanceSummaryMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwBMElectMaintenanceSummaryMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwBMElectMaintenanceSummaryMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.MajorGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorGroup As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.MajorGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.MajorGroup, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.MajorGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.SpecificGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecificGroup As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.SpecificGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.SpecificGroup, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.SpecificGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecEquipC, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecPreMaintAdequate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecPreMaintAdequate As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecPreMaintAdequate)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecPreMaintAdequate, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecPreMaintAdequate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecPreMaintCMMS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecPreMaintCMMS As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecPreMaintCMMS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecPreMaintCMMS, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecPreMaintCMMS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElectIR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectIR As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElectIR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElectIR, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElectIR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecUltrasound
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecUltrasound As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecUltrasound)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecUltrasound, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecUltrasound)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecSwitch
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecSwitch As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecSwitch)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecSwitch, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecSwitch)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecTranOil
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecTranOil As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecTranOil)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecTranOil, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecTranOil)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecBattery
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecBattery As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecBattery)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecBattery, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecBattery)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecMotor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMotor As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecMotor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecMotor, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecMotor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecGrounding
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecGrounding As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecGrounding)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecGrounding, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecGrounding)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecRelay
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecRelay As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecRelay)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecRelay, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecRelay)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.ElecOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecOther As System.String
			Get
				Return MyBase.GetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecOther)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecOther, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.InspectionDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDateMonth, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMElectMaintenanceSummary.InspectionDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDateYear, value) Then
					OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDateYear)
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
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "Client"
							Me.str().Client = CType(value, string)
												
						Case "ClientLocNo"
							Me.str().ClientLocNo = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
												
						Case "Facility"
							Me.str().Facility = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "Address"
							Me.str().Address = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "StProv"
							Me.str().StProv = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "InspectionDate"
							Me.str().InspectionDate = CType(value, string)
												
						Case "_100PercentUSTot"
							Me.str()._100PercentUSTot = CType(value, string)
												
						Case "TIVAustralian"
							Me.str().TIVAustralian = CType(value, string)
												
						Case "TIVBritish"
							Me.str().TIVBritish = CType(value, string)
												
						Case "TIVCanadian"
							Me.str().TIVCanadian = CType(value, string)
												
						Case "TIVEuro"
							Me.str().TIVEuro = CType(value, string)
												
						Case "TIVJapanese"
							Me.str().TIVJapanese = CType(value, string)
												
						Case "TIVMexican"
							Me.str().TIVMexican = CType(value, string)
												
						Case "TIVNewZealand"
							Me.str().TIVNewZealand = CType(value, string)
												
						Case "Tivus"
							Me.str().Tivus = CType(value, string)
												
						Case "MajorGroup"
							Me.str().MajorGroup = CType(value, string)
												
						Case "SpecificGroup"
							Me.str().SpecificGroup = CType(value, string)
												
						Case "ElecEquipC"
							Me.str().ElecEquipC = CType(value, string)
												
						Case "ElecPreMaintAdequate"
							Me.str().ElecPreMaintAdequate = CType(value, string)
												
						Case "ElecPreMaintCMMS"
							Me.str().ElecPreMaintCMMS = CType(value, string)
												
						Case "ElectIR"
							Me.str().ElectIR = CType(value, string)
												
						Case "ElecUltrasound"
							Me.str().ElecUltrasound = CType(value, string)
												
						Case "ElecSwitch"
							Me.str().ElecSwitch = CType(value, string)
												
						Case "ElecTranOil"
							Me.str().ElecTranOil = CType(value, string)
												
						Case "ElecBattery"
							Me.str().ElecBattery = CType(value, string)
												
						Case "ElecMotor"
							Me.str().ElecMotor = CType(value, string)
												
						Case "ElecGrounding"
							Me.str().ElecGrounding = CType(value, string)
												
						Case "ElecRelay"
							Me.str().ElecRelay = CType(value, string)
												
						Case "ElecOther"
							Me.str().ElecOther = CType(value, string)
												
						Case "InspectionDateMonth"
							Me.str().InspectionDateMonth = CType(value, string)
												
						Case "InspectionDateYear"
							Me.str().InspectionDateYear = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.Tivus)
							End If
						
						Case "ElecEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecEquipC)
							End If
						
						Case "InspectionDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspectionDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDateMonth)
							End If
						
						Case "InspectionDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspectionDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDateYear)
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
		
			Public Sub New(ByVal entity As esVwBMElectMaintenanceSummary)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Client As System.String 
				Get
					Dim data_ As System.String = entity.Client
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Client = Nothing
					Else
						entity.Client = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ClientLocNo As System.String 
				Get
					Dim data_ As System.String = entity.ClientLocNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClientLocNo = Nothing
					Else
						entity.ClientLocNo = Convert.ToString(Value)
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
		  	
			Public Property CustomAccess As System.String 
				Get
					Dim data_ As System.String = entity.CustomAccess
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomAccess = Nothing
					Else
						entity.CustomAccess = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Address As System.String 
				Get
					Dim data_ As System.String = entity.Address
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address = Nothing
					Else
						entity.Address = Convert.ToString(Value)
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
		  	
			Public Property _100PercentUSTot As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity._100PercentUSTot
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._100PercentUSTot = Nothing
					Else
						entity._100PercentUSTot = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TIVAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TIVAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVAustralian = Nothing
					Else
						entity.TIVAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TIVBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TIVBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVBritish = Nothing
					Else
						entity.TIVBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TIVCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TIVCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVCanadian = Nothing
					Else
						entity.TIVCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TIVEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TIVEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVEuro = Nothing
					Else
						entity.TIVEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TIVJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TIVJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVJapanese = Nothing
					Else
						entity.TIVJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TIVMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TIVMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVMexican = Nothing
					Else
						entity.TIVMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TIVNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TIVNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVNewZealand = Nothing
					Else
						entity.TIVNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property Tivus As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.Tivus
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Tivus = Nothing
					Else
						entity.Tivus = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MajorGroup As System.String 
				Get
					Dim data_ As System.String = entity.MajorGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MajorGroup = Nothing
					Else
						entity.MajorGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecificGroup As System.String 
				Get
					Dim data_ As System.String = entity.SpecificGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecificGroup = Nothing
					Else
						entity.SpecificGroup = Convert.ToString(Value)
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
		  	
			Public Property ElecPreMaintAdequate As System.String 
				Get
					Dim data_ As System.String = entity.ElecPreMaintAdequate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecPreMaintAdequate = Nothing
					Else
						entity.ElecPreMaintAdequate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecPreMaintCMMS As System.String 
				Get
					Dim data_ As System.String = entity.ElecPreMaintCMMS
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecPreMaintCMMS = Nothing
					Else
						entity.ElecPreMaintCMMS = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectIR As System.String 
				Get
					Dim data_ As System.String = entity.ElectIR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectIR = Nothing
					Else
						entity.ElectIR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecUltrasound As System.String 
				Get
					Dim data_ As System.String = entity.ElecUltrasound
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecUltrasound = Nothing
					Else
						entity.ElecUltrasound = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecSwitch As System.String 
				Get
					Dim data_ As System.String = entity.ElecSwitch
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecSwitch = Nothing
					Else
						entity.ElecSwitch = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecTranOil As System.String 
				Get
					Dim data_ As System.String = entity.ElecTranOil
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecTranOil = Nothing
					Else
						entity.ElecTranOil = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecBattery As System.String 
				Get
					Dim data_ As System.String = entity.ElecBattery
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecBattery = Nothing
					Else
						entity.ElecBattery = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMotor As System.String 
				Get
					Dim data_ As System.String = entity.ElecMotor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMotor = Nothing
					Else
						entity.ElecMotor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecGrounding As System.String 
				Get
					Dim data_ As System.String = entity.ElecGrounding
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecGrounding = Nothing
					Else
						entity.ElecGrounding = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecRelay As System.String 
				Get
					Dim data_ As System.String = entity.ElecRelay
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecRelay = Nothing
					Else
						entity.ElecRelay = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecOther As System.String 
				Get
					Dim data_ As System.String = entity.ElecOther
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecOther = Nothing
					Else
						entity.ElecOther = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionDateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InspectionDateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionDateMonth = Nothing
					Else
						entity.InspectionDateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionDateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InspectionDateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionDateYear = Nothing
					Else
						entity.InspectionDateYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVwBMElectMaintenanceSummary
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwBMElectMaintenanceSummaryMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwBMElectMaintenanceSummaryQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwBMElectMaintenanceSummaryQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwBMElectMaintenanceSummaryQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwBMElectMaintenanceSummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwBMElectMaintenanceSummaryQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwBMElectMaintenanceSummaryCollection
		Inherits esEntityCollection(Of VwBMElectMaintenanceSummary)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwBMElectMaintenanceSummaryMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwBMElectMaintenanceSummaryCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwBMElectMaintenanceSummaryQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwBMElectMaintenanceSummaryQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwBMElectMaintenanceSummaryQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwBMElectMaintenanceSummaryQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwBMElectMaintenanceSummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwBMElectMaintenanceSummaryQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwBMElectMaintenanceSummaryQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwBMElectMaintenanceSummaryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwBMElectMaintenanceSummaryMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "FileNo" 
					Return Me.FileNo
				Case "Client" 
					Return Me.Client
				Case "ClientLocNo" 
					Return Me.ClientLocNo
				Case "Division" 
					Return Me.Division
				Case "Facility" 
					Return Me.Facility
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "Address" 
					Return Me.Address
				Case "City" 
					Return Me.City
				Case "StProv" 
					Return Me.StProv
				Case "Country" 
					Return Me.Country
				Case "InspectionDate" 
					Return Me.InspectionDate
				Case "_100PercentUSTot" 
					Return Me._100PercentUSTot
				Case "TIVAustralian" 
					Return Me.TIVAustralian
				Case "TIVBritish" 
					Return Me.TIVBritish
				Case "TIVCanadian" 
					Return Me.TIVCanadian
				Case "TIVEuro" 
					Return Me.TIVEuro
				Case "TIVJapanese" 
					Return Me.TIVJapanese
				Case "TIVMexican" 
					Return Me.TIVMexican
				Case "TIVNewZealand" 
					Return Me.TIVNewZealand
				Case "Tivus" 
					Return Me.Tivus
				Case "MajorGroup" 
					Return Me.MajorGroup
				Case "SpecificGroup" 
					Return Me.SpecificGroup
				Case "ElecEquipC" 
					Return Me.ElecEquipC
				Case "ElecPreMaintAdequate" 
					Return Me.ElecPreMaintAdequate
				Case "ElecPreMaintCMMS" 
					Return Me.ElecPreMaintCMMS
				Case "ElectIR" 
					Return Me.ElectIR
				Case "ElecUltrasound" 
					Return Me.ElecUltrasound
				Case "ElecSwitch" 
					Return Me.ElecSwitch
				Case "ElecTranOil" 
					Return Me.ElecTranOil
				Case "ElecBattery" 
					Return Me.ElecBattery
				Case "ElecMotor" 
					Return Me.ElecMotor
				Case "ElecGrounding" 
					Return Me.ElecGrounding
				Case "ElecRelay" 
					Return Me.ElecRelay
				Case "ElecOther" 
					Return Me.ElecOther
				Case "InspectionDateMonth" 
					Return Me.InspectionDateMonth
				Case "InspectionDateYear" 
					Return Me.InspectionDateYear
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MajorGroup As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.MajorGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecificGroup As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.SpecificGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecPreMaintAdequate As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecPreMaintAdequate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecPreMaintCMMS As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecPreMaintCMMS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectIR As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElectIR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecUltrasound As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecUltrasound, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecSwitch As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecSwitch, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecTranOil As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecTranOil, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecBattery As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecBattery, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMotor As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecMotor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecGrounding As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecGrounding, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecRelay As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecRelay, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecOther As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecOther, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDateYear, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwBMElectMaintenanceSummaryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.FilePrefix, 0, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Facility, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.CustomAccess, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Address, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.City, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.StProv, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Country, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames._100PercentUSTot, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVAustralian, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVBritish, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVCanadian, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVEuro, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVJapanese, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVMexican, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.TIVNewZealand, 19, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.Tivus, 20, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.MajorGroup, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.MajorGroup
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.SpecificGroup, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.SpecificGroup
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecEquipC, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecPreMaintAdequate, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecPreMaintAdequate
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecPreMaintCMMS, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecPreMaintCMMS
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElectIR, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElectIR
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecUltrasound, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecUltrasound
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecSwitch, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecSwitch
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecTranOil, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecTranOil
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecBattery, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecBattery
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecMotor, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecMotor
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecGrounding, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecGrounding
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecRelay, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecRelay
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.ElecOther, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.ElecOther
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDateMonth, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMElectMaintenanceSummaryMetadata.ColumnNames.InspectionDateYear, 36, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMElectMaintenanceSummaryMetadata.PropertyNames.InspectionDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwBMElectMaintenanceSummaryMetadata
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
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FileNo As String = "FileNo"
			 Public Const Client As String = "Client"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Address As String = "Address"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Country As String = "Country"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const _100PercentUSTot As String = "100PercentUSTot"
			 Public Const TIVAustralian As String = "TIVAustralian"
			 Public Const TIVBritish As String = "TIVBritish"
			 Public Const TIVCanadian As String = "TIVCanadian"
			 Public Const TIVEuro As String = "TIVEuro"
			 Public Const TIVJapanese As String = "TIVJapanese"
			 Public Const TIVMexican As String = "TIVMexican"
			 Public Const TIVNewZealand As String = "TIVNewZealand"
			 Public Const Tivus As String = "TIVUS"
			 Public Const MajorGroup As String = "MajorGroup"
			 Public Const SpecificGroup As String = "SpecificGroup"
			 Public Const ElecEquipC As String = "ElecEquipC"
			 Public Const ElecPreMaintAdequate As String = "ElecPreMaintAdequate"
			 Public Const ElecPreMaintCMMS As String = "ElecPreMaintCMMS"
			 Public Const ElectIR As String = "ElectIR"
			 Public Const ElecUltrasound As String = "ElecUltrasound"
			 Public Const ElecSwitch As String = "ElecSwitch"
			 Public Const ElecTranOil As String = "ElecTranOil"
			 Public Const ElecBattery As String = "ElecBattery"
			 Public Const ElecMotor As String = "ElecMotor"
			 Public Const ElecGrounding As String = "ElecGrounding"
			 Public Const ElecRelay As String = "ElecRelay"
			 Public Const ElecOther As String = "ElecOther"
			 Public Const InspectionDateMonth As String = "InspectionDateMonth"
			 Public Const InspectionDateYear As String = "InspectionDateYear"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FileNo As String = "FileNo"
			 Public Const Client As String = "Client"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Address As String = "Address"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Country As String = "Country"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const _100PercentUSTot As String = "_100PercentUSTot"
			 Public Const TIVAustralian As String = "TIVAustralian"
			 Public Const TIVBritish As String = "TIVBritish"
			 Public Const TIVCanadian As String = "TIVCanadian"
			 Public Const TIVEuro As String = "TIVEuro"
			 Public Const TIVJapanese As String = "TIVJapanese"
			 Public Const TIVMexican As String = "TIVMexican"
			 Public Const TIVNewZealand As String = "TIVNewZealand"
			 Public Const Tivus As String = "Tivus"
			 Public Const MajorGroup As String = "MajorGroup"
			 Public Const SpecificGroup As String = "SpecificGroup"
			 Public Const ElecEquipC As String = "ElecEquipC"
			 Public Const ElecPreMaintAdequate As String = "ElecPreMaintAdequate"
			 Public Const ElecPreMaintCMMS As String = "ElecPreMaintCMMS"
			 Public Const ElectIR As String = "ElectIR"
			 Public Const ElecUltrasound As String = "ElecUltrasound"
			 Public Const ElecSwitch As String = "ElecSwitch"
			 Public Const ElecTranOil As String = "ElecTranOil"
			 Public Const ElecBattery As String = "ElecBattery"
			 Public Const ElecMotor As String = "ElecMotor"
			 Public Const ElecGrounding As String = "ElecGrounding"
			 Public Const ElecRelay As String = "ElecRelay"
			 Public Const ElecOther As String = "ElecOther"
			 Public Const InspectionDateMonth As String = "InspectionDateMonth"
			 Public Const InspectionDateYear As String = "InspectionDateYear"
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
			SyncLock GetType(VwBMElectMaintenanceSummaryMetadata)
			
				If VwBMElectMaintenanceSummaryMetadata.mapDelegates Is Nothing Then
					VwBMElectMaintenanceSummaryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwBMElectMaintenanceSummaryMetadata._meta Is Nothing Then
					VwBMElectMaintenanceSummaryMetadata._meta = New VwBMElectMaintenanceSummaryMetadata()
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
				


				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Client", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ClientLocNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Facility", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("_100PercentUSTot", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TIVAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Tivus", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MajorGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecificGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecPreMaintAdequate", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecPreMaintCMMS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectIR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecUltrasound", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecSwitch", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecTranOil", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecBattery", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecMotor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecGrounding", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecRelay", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecOther", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectionDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InspectionDateYear", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "vwBMElectMaintenanceSummary"
				meta.Destination = "vwBMElectMaintenanceSummary"
				
				meta.spInsert = "proc_vwBMElectMaintenanceSummaryInsert"
				meta.spUpdate = "proc_vwBMElectMaintenanceSummaryUpdate"
				meta.spDelete = "proc_vwBMElectMaintenanceSummaryDelete"
				meta.spLoadAll = "proc_vwBMElectMaintenanceSummaryLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwBMElectMaintenanceSummaryLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwBMElectMaintenanceSummaryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
