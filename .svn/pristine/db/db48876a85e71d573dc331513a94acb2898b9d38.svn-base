
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
	' Encapsulates the 'vwBMFacilityDataSummary' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwBMFacilityDataSummary))> _
	<XmlType("VwBMFacilityDataSummary")> _	
	Partial Public Class VwBMFacilityDataSummary 
		Inherits esVwBMFacilityDataSummary
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwBMFacilityDataSummary()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwBMFacilityDataSummaryCollection")> _
	Partial Public Class VwBMFacilityDataSummaryCollection
		Inherits esVwBMFacilityDataSummaryCollection
		Implements IEnumerable(Of VwBMFacilityDataSummary)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwBMFacilityDataSummary))> _
		Public Class VwBMFacilityDataSummaryCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwBMFacilityDataSummaryCollection)
			
			Public Shared Widening Operator CType(packet As VwBMFacilityDataSummaryCollectionWCFPacket) As VwBMFacilityDataSummaryCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwBMFacilityDataSummaryCollection) As VwBMFacilityDataSummaryCollectionWCFPacket
				Return New VwBMFacilityDataSummaryCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwBMFacilityDataSummaryQuery 
		Inherits esVwBMFacilityDataSummaryQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwBMFacilityDataSummaryQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwBMFacilityDataSummaryQuery) As String
			Return VwBMFacilityDataSummaryQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwBMFacilityDataSummaryQuery
			Return DirectCast(VwBMFacilityDataSummaryQuery.SerializeHelper.FromXml(query, GetType(VwBMFacilityDataSummaryQuery)), VwBMFacilityDataSummaryQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwBMFacilityDataSummary
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(VwBMFacilityDataSummaryMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(VwBMFacilityDataSummaryMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwBMFacilityDataSummaryMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwBMFacilityDataSummaryMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMFacilityDataSummaryMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.MajorGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorGroup As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.MajorGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.MajorGroup, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.MajorGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.SpecificGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecificGroup As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.SpecificGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.SpecificGroup, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.SpecificGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.CompMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompMajorExp As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CompMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CompMajorExp, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.CompMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.CompAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CompAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CompAdeqCap, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.CompAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.RefrigMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigMajorExp As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.RefrigMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.RefrigMajorExp, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.RefrigMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.RefrigAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.RefrigAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.RefrigAdeqCap, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.RefrigAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.WaterMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterMajorExp As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.WaterMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.WaterMajorExp, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.WaterMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.WaterAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.WaterAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.WaterAdeqCap, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.WaterAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.CoolingMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingMajorExp As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CoolingMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CoolingMajorExp, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.CoolingMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.CoolingAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CoolingAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.CoolingAdeqCap, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.CoolingAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.FuelMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelMajorExp As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.FuelMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.FuelMajorExp, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.FuelMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.FuelAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.FuelAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.FuelAdeqCap, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.FuelAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.ElecEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.ElecEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.ElecEquipC, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.ElecEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.BoilersC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.BoilersC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.BoilersC, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.BoilersC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.ProcEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.ProcEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.ProcEquipC, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.ProcEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.CompSysC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.CompSysC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.CompSysC, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.CompSysC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.MechPreMaintAdequacy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintAdequacy As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.MechPreMaintAdequacy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.MechPreMaintAdequacy, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.MechPreMaintAdequacy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.ElecPreMaintAdequate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecPreMaintAdequate As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.ElecPreMaintAdequate)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.ElecPreMaintAdequate, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.ElecPreMaintAdequate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.SparesMaintained
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesMaintained As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.SparesMaintained)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.SparesMaintained, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.SparesMaintained)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.HEAdequate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEAdequate As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.HEAdequate)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.HEAdequate, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.HEAdequate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.BCP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bcp As System.String
			Get
				Return MyBase.GetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Bcp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMFacilityDataSummaryMetadata.ColumnNames.Bcp, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.Bcp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.InspectionDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDateMonth, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMFacilityDataSummary.InspectionDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDateYear, value) Then
					OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDateYear)
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
												
						Case "CompMajorExp"
							Me.str().CompMajorExp = CType(value, string)
												
						Case "CompAdeqCap"
							Me.str().CompAdeqCap = CType(value, string)
												
						Case "RefrigMajorExp"
							Me.str().RefrigMajorExp = CType(value, string)
												
						Case "RefrigAdeqCap"
							Me.str().RefrigAdeqCap = CType(value, string)
												
						Case "WaterMajorExp"
							Me.str().WaterMajorExp = CType(value, string)
												
						Case "WaterAdeqCap"
							Me.str().WaterAdeqCap = CType(value, string)
												
						Case "CoolingMajorExp"
							Me.str().CoolingMajorExp = CType(value, string)
												
						Case "CoolingAdeqCap"
							Me.str().CoolingAdeqCap = CType(value, string)
												
						Case "FuelMajorExp"
							Me.str().FuelMajorExp = CType(value, string)
												
						Case "FuelAdeqCap"
							Me.str().FuelAdeqCap = CType(value, string)
												
						Case "ElecEquipC"
							Me.str().ElecEquipC = CType(value, string)
												
						Case "BoilersC"
							Me.str().BoilersC = CType(value, string)
												
						Case "ProcEquipC"
							Me.str().ProcEquipC = CType(value, string)
												
						Case "CompSysC"
							Me.str().CompSysC = CType(value, string)
												
						Case "MechPreMaintAdequacy"
							Me.str().MechPreMaintAdequacy = CType(value, string)
												
						Case "ElecPreMaintAdequate"
							Me.str().ElecPreMaintAdequate = CType(value, string)
												
						Case "SparesMaintained"
							Me.str().SparesMaintained = CType(value, string)
												
						Case "HEAdequate"
							Me.str().HEAdequate = CType(value, string)
												
						Case "Bcp"
							Me.str().Bcp = CType(value, string)
												
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
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.Tivus)
							End If
						
						Case "ElecEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.ElecEquipC)
							End If
						
						Case "BoilersC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BoilersC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.BoilersC)
							End If
						
						Case "ProcEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProcEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.ProcEquipC)
							End If
						
						Case "CompSysC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CompSysC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.CompSysC)
							End If
						
						Case "InspectionDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspectionDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDateMonth)
							End If
						
						Case "InspectionDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspectionDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDateYear)
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
		
			Public Sub New(ByVal entity As esVwBMFacilityDataSummary)
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
		  	
			Public Property CompMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.CompMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompMajorExp = Nothing
					Else
						entity.CompMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.CompAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompAdeqCap = Nothing
					Else
						entity.CompAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.RefrigMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigMajorExp = Nothing
					Else
						entity.RefrigMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.RefrigAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigAdeqCap = Nothing
					Else
						entity.RefrigAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.WaterMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterMajorExp = Nothing
					Else
						entity.WaterMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.WaterAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterAdeqCap = Nothing
					Else
						entity.WaterAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.CoolingMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingMajorExp = Nothing
					Else
						entity.CoolingMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.CoolingAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingAdeqCap = Nothing
					Else
						entity.CoolingAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.FuelMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelMajorExp = Nothing
					Else
						entity.FuelMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.FuelAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelAdeqCap = Nothing
					Else
						entity.FuelAdeqCap = Convert.ToString(Value)
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
		  	
			Public Property MechPreMaintAdequacy As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintAdequacy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintAdequacy = Nothing
					Else
						entity.MechPreMaintAdequacy = Convert.ToString(Value)
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
		  	
			Public Property SparesMaintained As System.String 
				Get
					Dim data_ As System.String = entity.SparesMaintained
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesMaintained = Nothing
					Else
						entity.SparesMaintained = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEAdequate As System.String 
				Get
					Dim data_ As System.String = entity.HEAdequate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEAdequate = Nothing
					Else
						entity.HEAdequate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bcp As System.String 
				Get
					Dim data_ As System.String = entity.Bcp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bcp = Nothing
					Else
						entity.Bcp = Convert.ToString(Value)
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
		  

			Private entity As esVwBMFacilityDataSummary
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwBMFacilityDataSummaryMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwBMFacilityDataSummaryQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwBMFacilityDataSummaryQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwBMFacilityDataSummaryQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwBMFacilityDataSummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwBMFacilityDataSummaryQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwBMFacilityDataSummaryCollection
		Inherits esEntityCollection(Of VwBMFacilityDataSummary)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwBMFacilityDataSummaryMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwBMFacilityDataSummaryCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwBMFacilityDataSummaryQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwBMFacilityDataSummaryQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwBMFacilityDataSummaryQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwBMFacilityDataSummaryQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwBMFacilityDataSummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwBMFacilityDataSummaryQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwBMFacilityDataSummaryQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwBMFacilityDataSummaryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwBMFacilityDataSummaryMetadata.Meta()
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
				Case "CompMajorExp" 
					Return Me.CompMajorExp
				Case "CompAdeqCap" 
					Return Me.CompAdeqCap
				Case "RefrigMajorExp" 
					Return Me.RefrigMajorExp
				Case "RefrigAdeqCap" 
					Return Me.RefrigAdeqCap
				Case "WaterMajorExp" 
					Return Me.WaterMajorExp
				Case "WaterAdeqCap" 
					Return Me.WaterAdeqCap
				Case "CoolingMajorExp" 
					Return Me.CoolingMajorExp
				Case "CoolingAdeqCap" 
					Return Me.CoolingAdeqCap
				Case "FuelMajorExp" 
					Return Me.FuelMajorExp
				Case "FuelAdeqCap" 
					Return Me.FuelAdeqCap
				Case "ElecEquipC" 
					Return Me.ElecEquipC
				Case "BoilersC" 
					Return Me.BoilersC
				Case "ProcEquipC" 
					Return Me.ProcEquipC
				Case "CompSysC" 
					Return Me.CompSysC
				Case "MechPreMaintAdequacy" 
					Return Me.MechPreMaintAdequacy
				Case "ElecPreMaintAdequate" 
					Return Me.ElecPreMaintAdequate
				Case "SparesMaintained" 
					Return Me.SparesMaintained
				Case "HEAdequate" 
					Return Me.HEAdequate
				Case "Bcp" 
					Return Me.Bcp
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
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MajorGroup As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.MajorGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecificGroup As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.SpecificGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.CompMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.CompAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.RefrigMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.RefrigAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.WaterMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.WaterAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.CoolingMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.CoolingAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.FuelMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.FuelAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.ElecEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersC As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.BoilersC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.ProcEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysC As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.CompSysC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintAdequacy As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.MechPreMaintAdequacy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecPreMaintAdequate As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.ElecPreMaintAdequate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesMaintained As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.SparesMaintained, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEAdequate As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.HEAdequate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bcp As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.Bcp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDateYear, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwBMFacilityDataSummaryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.FilePrefix, 0, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.Facility, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.CustomAccess, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.Address, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.City, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.StProv, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.Country, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames._100PercentUSTot, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVAustralian, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVBritish, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVCanadian, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVEuro, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVJapanese, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVMexican, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.TIVNewZealand, 19, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.Tivus, 20, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.MajorGroup, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.MajorGroup
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.SpecificGroup, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.SpecificGroup
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.CompMajorExp, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.CompMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.CompAdeqCap, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.CompAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.RefrigMajorExp, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.RefrigMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.RefrigAdeqCap, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.RefrigAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.WaterMajorExp, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.WaterMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.WaterAdeqCap, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.WaterAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.CoolingMajorExp, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.CoolingMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.CoolingAdeqCap, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.CoolingAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.FuelMajorExp, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.FuelMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.FuelAdeqCap, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.FuelAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.ElecEquipC, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.ElecEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.BoilersC, 34, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.BoilersC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.ProcEquipC, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.ProcEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.CompSysC, 36, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.CompSysC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.MechPreMaintAdequacy, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.MechPreMaintAdequacy
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.ElecPreMaintAdequate, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.ElecPreMaintAdequate
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.SparesMaintained, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.SparesMaintained
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.HEAdequate, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.HEAdequate
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.Bcp, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.Bcp
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDateMonth, 42, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMFacilityDataSummaryMetadata.ColumnNames.InspectionDateYear, 43, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMFacilityDataSummaryMetadata.PropertyNames.InspectionDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwBMFacilityDataSummaryMetadata
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
			 Public Const CompMajorExp As String = "CompMajorExp"
			 Public Const CompAdeqCap As String = "CompAdeqCap"
			 Public Const RefrigMajorExp As String = "RefrigMajorExp"
			 Public Const RefrigAdeqCap As String = "RefrigAdeqCap"
			 Public Const WaterMajorExp As String = "WaterMajorExp"
			 Public Const WaterAdeqCap As String = "WaterAdeqCap"
			 Public Const CoolingMajorExp As String = "CoolingMajorExp"
			 Public Const CoolingAdeqCap As String = "CoolingAdeqCap"
			 Public Const FuelMajorExp As String = "FuelMajorExp"
			 Public Const FuelAdeqCap As String = "FuelAdeqCap"
			 Public Const ElecEquipC As String = "ElecEquipC"
			 Public Const BoilersC As String = "BoilersC"
			 Public Const ProcEquipC As String = "ProcEquipC"
			 Public Const CompSysC As String = "CompSysC"
			 Public Const MechPreMaintAdequacy As String = "MechPreMaintAdequacy"
			 Public Const ElecPreMaintAdequate As String = "ElecPreMaintAdequate"
			 Public Const SparesMaintained As String = "SparesMaintained"
			 Public Const HEAdequate As String = "HEAdequate"
			 Public Const Bcp As String = "BCP"
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
			 Public Const CompMajorExp As String = "CompMajorExp"
			 Public Const CompAdeqCap As String = "CompAdeqCap"
			 Public Const RefrigMajorExp As String = "RefrigMajorExp"
			 Public Const RefrigAdeqCap As String = "RefrigAdeqCap"
			 Public Const WaterMajorExp As String = "WaterMajorExp"
			 Public Const WaterAdeqCap As String = "WaterAdeqCap"
			 Public Const CoolingMajorExp As String = "CoolingMajorExp"
			 Public Const CoolingAdeqCap As String = "CoolingAdeqCap"
			 Public Const FuelMajorExp As String = "FuelMajorExp"
			 Public Const FuelAdeqCap As String = "FuelAdeqCap"
			 Public Const ElecEquipC As String = "ElecEquipC"
			 Public Const BoilersC As String = "BoilersC"
			 Public Const ProcEquipC As String = "ProcEquipC"
			 Public Const CompSysC As String = "CompSysC"
			 Public Const MechPreMaintAdequacy As String = "MechPreMaintAdequacy"
			 Public Const ElecPreMaintAdequate As String = "ElecPreMaintAdequate"
			 Public Const SparesMaintained As String = "SparesMaintained"
			 Public Const HEAdequate As String = "HEAdequate"
			 Public Const Bcp As String = "Bcp"
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
			SyncLock GetType(VwBMFacilityDataSummaryMetadata)
			
				If VwBMFacilityDataSummaryMetadata.mapDelegates Is Nothing Then
					VwBMFacilityDataSummaryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwBMFacilityDataSummaryMetadata._meta Is Nothing Then
					VwBMFacilityDataSummaryMetadata._meta = New VwBMFacilityDataSummaryMetadata()
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
				meta.AddTypeMap("CompMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CoolingMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CoolingAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FuelMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FuelAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BoilersC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProcEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CompSysC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechPreMaintAdequacy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecPreMaintAdequate", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SparesMaintained", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEAdequate", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Bcp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectionDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InspectionDateYear", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "vwBMFacilityDataSummary"
				meta.Destination = "vwBMFacilityDataSummary"
				
				meta.spInsert = "proc_vwBMFacilityDataSummaryInsert"
				meta.spUpdate = "proc_vwBMFacilityDataSummaryUpdate"
				meta.spDelete = "proc_vwBMFacilityDataSummaryDelete"
				meta.spLoadAll = "proc_vwBMFacilityDataSummaryLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwBMFacilityDataSummaryLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwBMFacilityDataSummaryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
