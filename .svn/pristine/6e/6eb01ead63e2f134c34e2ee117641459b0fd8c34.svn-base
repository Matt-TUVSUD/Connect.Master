
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
	' Encapsulates the 'vwFireCOPESummary' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwFireCOPESummary))> _
	<XmlType("VwFireCOPESummary")> _	
	Partial Public Class VwFireCOPESummary 
		Inherits esVwFireCOPESummary
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwFireCOPESummary()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwFireCOPESummaryCollection")> _
	Partial Public Class VwFireCOPESummaryCollection
		Inherits esVwFireCOPESummaryCollection
		Implements IEnumerable(Of VwFireCOPESummary)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwFireCOPESummary))> _
		Public Class VwFireCOPESummaryCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwFireCOPESummaryCollection)
			
			Public Shared Widening Operator CType(packet As VwFireCOPESummaryCollectionWCFPacket) As VwFireCOPESummaryCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwFireCOPESummaryCollection) As VwFireCOPESummaryCollectionWCFPacket
				Return New VwFireCOPESummaryCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwFireCOPESummaryQuery 
		Inherits esVwFireCOPESummaryQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwFireCOPESummaryQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwFireCOPESummaryQuery) As String
			Return VwFireCOPESummaryQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwFireCOPESummaryQuery
			Return DirectCast(VwFireCOPESummaryQuery.SerializeHelper.FromXml(query, GetType(VwFireCOPESummaryQuery)), VwFireCOPESummaryQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwFireCOPESummary
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwFireCOPESummary.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(VwFireCOPESummaryMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(VwFireCOPESummaryMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireCOPESummaryMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireCOPESummaryMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.InititalMajorConstructionYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InititalMajorConstructionYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireCOPESummaryMetadata.ColumnNames.InititalMajorConstructionYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireCOPESummaryMetadata.ColumnNames.InititalMajorConstructionYear, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.InititalMajorConstructionYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TotalFloorArea
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalFloorArea As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.TotalFloorArea)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.TotalFloorArea, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TotalFloorArea)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.TotalFloorAreaMetric
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalFloorAreaMetric As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TotalFloorAreaMetric)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.TotalFloorAreaMetric, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TotalFloorAreaMetric)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.NoofStories
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoofStories As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.NoofStories)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.NoofStories, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.NoofStories)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.RoofConstructionFireResistive
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionFireResistive As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionFireResistive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionFireResistive, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionFireResistive)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.RoofConstructionNoncombustible
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionNoncombustible As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionNoncombustible)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionNoncombustible, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionNoncombustible)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.RoofConstructionCombustible
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionCombustible As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionCombustible)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionCombustible, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionCombustible)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.RoofConstructionClass
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RoofConstructionClass As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionClass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionClass, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionClass)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MajorGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorGroup As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.MajorGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.MajorGroup, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MajorGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.SpecificGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecificGroup As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.SpecificGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.SpecificGroup, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.SpecificGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.AreaWithSprinklers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AreaWithSprinklers As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.AreaWithSprinklers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.AreaWithSprinklers, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.AreaWithSprinklers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.AreaWithoutSprinklersNeedingSprinklers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AreaWithoutSprinklersNeedingSprinklers As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.AreaWithoutSprinklersNeedingSprinklers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.AreaWithoutSprinklersNeedingSprinklers, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.AreaWithoutSprinklersNeedingSprinklers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.WaterSupplyRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterSupplyRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.WaterSupplyRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.WaterSupplyRating, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.WaterSupplyRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PropertySurveillance
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PropertySurveillance As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.PropertySurveillance)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.PropertySurveillance, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PropertySurveillance)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.SpecialHazardsRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecialHazardsRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.SpecialHazardsRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.SpecialHazardsRating, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.SpecialHazardsRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.HumanElementRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireCOPESummaryMetadata.ColumnNames.HumanElementRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireCOPESummaryMetadata.ColumnNames.HumanElementRating, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.HumanElementRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.ExternalFire
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExternalFire As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.ExternalFire)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.ExternalFire, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.ExternalFire)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.FMSeismicZone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FMSeismicZone As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.FMSeismicZone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.FMSeismicZone, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.FMSeismicZone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.Flood
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Flood As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Flood)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Flood, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Flood)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.Zone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zone As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Zone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Zone, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Zone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.Windstorm
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Windstorm As System.String
			Get
				Return MyBase.GetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Windstorm)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireCOPESummaryMetadata.ColumnNames.Windstorm, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Windstorm)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MaxSustainedWindSpeed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MaxSustainedWindSpeed As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.MaxSustainedWindSpeed)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireCOPESummaryMetadata.ColumnNames.MaxSustainedWindSpeed, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MaxSustainedWindSpeed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MaxSustainedWindSpeedMetric
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MaxSustainedWindSpeedMetric As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireCOPESummaryMetadata.ColumnNames.MaxSustainedWindSpeedMetric)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireCOPESummaryMetadata.ColumnNames.MaxSustainedWindSpeedMetric, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MaxSustainedWindSpeedMetric)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Apl As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Apl)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Apl, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Apl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APLAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLAustralian, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APLBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLBritish, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APLCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLCanadian, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APLEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLEuro, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APLJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLJapanese, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APLMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLMexican, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APLNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.APLNewZealand, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.APLUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Aplus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Aplus, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Aplus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PML
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pml As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Pml)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Pml, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Pml)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PMLAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLAustralian, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PMLBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLBritish, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PMLCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLCanadian, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PMLEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLEuro, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PMLJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLJapanese, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PMLMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLMexican, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PMLNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.PMLNewZealand, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.PMLUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Pmlus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Pmlus, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Pmlus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mfl As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Mfl)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Mfl, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Mfl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFLAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLAustralian, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFLBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLBritish, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFLCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLCanadian, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFLEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLEuro, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFLJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLJapanese, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFLMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLMexican, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFLNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.MFLNewZealand, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.MFLUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Mflus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireCOPESummaryMetadata.ColumnNames.Mflus, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Mflus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.SurveyDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireCOPESummaryMetadata.ColumnNames.SurveyDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireCOPESummaryMetadata.ColumnNames.SurveyDateMonth, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.SurveyDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireCOPESummary.SurveyDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireCOPESummaryMetadata.ColumnNames.SurveyDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireCOPESummaryMetadata.ColumnNames.SurveyDateYear, value) Then
					OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.SurveyDateYear)
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
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "Facility"
							Me.str().Facility = CType(value, string)
												
						Case "Address"
							Me.str().Address = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "StProv"
							Me.str().StProv = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "SurveyDate"
							Me.str().SurveyDate = CType(value, string)
												
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
												
						Case "InititalMajorConstructionYear"
							Me.str().InititalMajorConstructionYear = CType(value, string)
												
						Case "TotalFloorArea"
							Me.str().TotalFloorArea = CType(value, string)
												
						Case "TotalFloorAreaMetric"
							Me.str().TotalFloorAreaMetric = CType(value, string)
												
						Case "NoofStories"
							Me.str().NoofStories = CType(value, string)
												
						Case "RoofConstructionFireResistive"
							Me.str().RoofConstructionFireResistive = CType(value, string)
												
						Case "RoofConstructionNoncombustible"
							Me.str().RoofConstructionNoncombustible = CType(value, string)
												
						Case "RoofConstructionCombustible"
							Me.str().RoofConstructionCombustible = CType(value, string)
												
						Case "RoofConstructionClass"
							Me.str().RoofConstructionClass = CType(value, string)
												
						Case "MajorGroup"
							Me.str().MajorGroup = CType(value, string)
												
						Case "SpecificGroup"
							Me.str().SpecificGroup = CType(value, string)
												
						Case "AreaWithSprinklers"
							Me.str().AreaWithSprinklers = CType(value, string)
												
						Case "AreaWithoutSprinklersNeedingSprinklers"
							Me.str().AreaWithoutSprinklersNeedingSprinklers = CType(value, string)
												
						Case "WaterSupplyRating"
							Me.str().WaterSupplyRating = CType(value, string)
												
						Case "PropertySurveillance"
							Me.str().PropertySurveillance = CType(value, string)
												
						Case "SpecialHazardsRating"
							Me.str().SpecialHazardsRating = CType(value, string)
												
						Case "HumanElementRating"
							Me.str().HumanElementRating = CType(value, string)
												
						Case "ExternalFire"
							Me.str().ExternalFire = CType(value, string)
												
						Case "FMSeismicZone"
							Me.str().FMSeismicZone = CType(value, string)
												
						Case "Flood"
							Me.str().Flood = CType(value, string)
												
						Case "Zone"
							Me.str().Zone = CType(value, string)
												
						Case "Windstorm"
							Me.str().Windstorm = CType(value, string)
												
						Case "MaxSustainedWindSpeed"
							Me.str().MaxSustainedWindSpeed = CType(value, string)
												
						Case "MaxSustainedWindSpeedMetric"
							Me.str().MaxSustainedWindSpeedMetric = CType(value, string)
												
						Case "Apl"
							Me.str().Apl = CType(value, string)
												
						Case "APLAustralian"
							Me.str().APLAustralian = CType(value, string)
												
						Case "APLBritish"
							Me.str().APLBritish = CType(value, string)
												
						Case "APLCanadian"
							Me.str().APLCanadian = CType(value, string)
												
						Case "APLEuro"
							Me.str().APLEuro = CType(value, string)
												
						Case "APLJapanese"
							Me.str().APLJapanese = CType(value, string)
												
						Case "APLMexican"
							Me.str().APLMexican = CType(value, string)
												
						Case "APLNewZealand"
							Me.str().APLNewZealand = CType(value, string)
												
						Case "Aplus"
							Me.str().Aplus = CType(value, string)
												
						Case "Pml"
							Me.str().Pml = CType(value, string)
												
						Case "PMLAustralian"
							Me.str().PMLAustralian = CType(value, string)
												
						Case "PMLBritish"
							Me.str().PMLBritish = CType(value, string)
												
						Case "PMLCanadian"
							Me.str().PMLCanadian = CType(value, string)
												
						Case "PMLEuro"
							Me.str().PMLEuro = CType(value, string)
												
						Case "PMLJapanese"
							Me.str().PMLJapanese = CType(value, string)
												
						Case "PMLMexican"
							Me.str().PMLMexican = CType(value, string)
												
						Case "PMLNewZealand"
							Me.str().PMLNewZealand = CType(value, string)
												
						Case "Pmlus"
							Me.str().Pmlus = CType(value, string)
												
						Case "Mfl"
							Me.str().Mfl = CType(value, string)
												
						Case "MFLAustralian"
							Me.str().MFLAustralian = CType(value, string)
												
						Case "MFLBritish"
							Me.str().MFLBritish = CType(value, string)
												
						Case "MFLCanadian"
							Me.str().MFLCanadian = CType(value, string)
												
						Case "MFLEuro"
							Me.str().MFLEuro = CType(value, string)
												
						Case "MFLJapanese"
							Me.str().MFLJapanese = CType(value, string)
												
						Case "MFLMexican"
							Me.str().MFLMexican = CType(value, string)
												
						Case "MFLNewZealand"
							Me.str().MFLNewZealand = CType(value, string)
												
						Case "Mflus"
							Me.str().Mflus = CType(value, string)
												
						Case "SurveyDateMonth"
							Me.str().SurveyDateMonth = CType(value, string)
												
						Case "SurveyDateYear"
							Me.str().SurveyDateYear = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Tivus)
							End If
						
						Case "InititalMajorConstructionYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InititalMajorConstructionYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.InititalMajorConstructionYear)
							End If
						
						Case "TotalFloorArea"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotalFloorArea = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TotalFloorArea)
							End If
						
						Case "TotalFloorAreaMetric"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TotalFloorAreaMetric = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.TotalFloorAreaMetric)
							End If
						
						Case "RoofConstructionFireResistive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RoofConstructionFireResistive = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionFireResistive)
							End If
						
						Case "RoofConstructionNoncombustible"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RoofConstructionNoncombustible = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionNoncombustible)
							End If
						
						Case "RoofConstructionCombustible"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RoofConstructionCombustible = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionCombustible)
							End If
						
						Case "RoofConstructionClass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RoofConstructionClass = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionClass)
							End If
						
						Case "AreaWithSprinklers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.AreaWithSprinklers = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.AreaWithSprinklers)
							End If
						
						Case "AreaWithoutSprinklersNeedingSprinklers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.AreaWithoutSprinklersNeedingSprinklers = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.AreaWithoutSprinklersNeedingSprinklers)
							End If
						
						Case "HumanElementRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.HumanElementRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.HumanElementRating)
							End If
						
						Case "MaxSustainedWindSpeed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MaxSustainedWindSpeed = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MaxSustainedWindSpeed)
							End If
						
						Case "MaxSustainedWindSpeedMetric"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MaxSustainedWindSpeedMetric = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MaxSustainedWindSpeedMetric)
							End If
						
						Case "Apl"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Apl = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Apl)
							End If
						
						Case "APLAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLAustralian)
							End If
						
						Case "APLBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLBritish)
							End If
						
						Case "APLCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLCanadian)
							End If
						
						Case "APLEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLEuro)
							End If
						
						Case "APLJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLJapanese)
							End If
						
						Case "APLMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLMexican)
							End If
						
						Case "APLNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.APLNewZealand)
							End If
						
						Case "Aplus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Aplus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Aplus)
							End If
						
						Case "Pml"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Pml = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Pml)
							End If
						
						Case "PMLAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PMLAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLAustralian)
							End If
						
						Case "PMLBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PMLBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLBritish)
							End If
						
						Case "PMLCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PMLCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLCanadian)
							End If
						
						Case "PMLEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PMLEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLEuro)
							End If
						
						Case "PMLJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PMLJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLJapanese)
							End If
						
						Case "PMLMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PMLMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLMexican)
							End If
						
						Case "PMLNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PMLNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.PMLNewZealand)
							End If
						
						Case "Pmlus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Pmlus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Pmlus)
							End If
						
						Case "Mfl"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Mfl = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Mfl)
							End If
						
						Case "MFLAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MFLAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLAustralian)
							End If
						
						Case "MFLBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MFLBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLBritish)
							End If
						
						Case "MFLCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MFLCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLCanadian)
							End If
						
						Case "MFLEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MFLEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLEuro)
							End If
						
						Case "MFLJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MFLJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLJapanese)
							End If
						
						Case "MFLMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MFLMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLMexican)
							End If
						
						Case "MFLNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MFLNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.MFLNewZealand)
							End If
						
						Case "Mflus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Mflus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.Mflus)
							End If
						
						Case "SurveyDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SurveyDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.SurveyDateMonth)
							End If
						
						Case "SurveyDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SurveyDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireCOPESummaryMetadata.PropertyNames.SurveyDateYear)
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
		
			Public Sub New(ByVal entity As esVwFireCOPESummary)
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
		  	
			Public Property TotalFloorAreaMetric As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TotalFloorAreaMetric
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalFloorAreaMetric = Nothing
					Else
						entity.TotalFloorAreaMetric = Convert.ToInt64(Value)
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
		  	
			Public Property AreaWithSprinklers As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.AreaWithSprinklers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AreaWithSprinklers = Nothing
					Else
						entity.AreaWithSprinklers = Convert.ToDouble(Value)
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
		  	
			Public Property HumanElementRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.HumanElementRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementRating = Nothing
					Else
						entity.HumanElementRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExternalFire As System.String 
				Get
					Dim data_ As System.String = entity.ExternalFire
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExternalFire = Nothing
					Else
						entity.ExternalFire = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FMSeismicZone As System.String 
				Get
					Dim data_ As System.String = entity.FMSeismicZone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FMSeismicZone = Nothing
					Else
						entity.FMSeismicZone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Flood As System.String 
				Get
					Dim data_ As System.String = entity.Flood
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Flood = Nothing
					Else
						entity.Flood = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Zone As System.String 
				Get
					Dim data_ As System.String = entity.Zone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Zone = Nothing
					Else
						entity.Zone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Windstorm As System.String 
				Get
					Dim data_ As System.String = entity.Windstorm
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Windstorm = Nothing
					Else
						entity.Windstorm = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxSustainedWindSpeed As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MaxSustainedWindSpeed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxSustainedWindSpeed = Nothing
					Else
						entity.MaxSustainedWindSpeed = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxSustainedWindSpeedMetric As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MaxSustainedWindSpeedMetric
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxSustainedWindSpeedMetric = Nothing
					Else
						entity.MaxSustainedWindSpeedMetric = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apl As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.Apl
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apl = Nothing
					Else
						entity.Apl = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLAustralian = Nothing
					Else
						entity.APLAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLBritish = Nothing
					Else
						entity.APLBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLCanadian = Nothing
					Else
						entity.APLCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLEuro = Nothing
					Else
						entity.APLEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLJapanese = Nothing
					Else
						entity.APLJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLMexican = Nothing
					Else
						entity.APLMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLNewZealand = Nothing
					Else
						entity.APLNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property Aplus As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.Aplus
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aplus = Nothing
					Else
						entity.Aplus = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pml As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.Pml
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pml = Nothing
					Else
						entity.Pml = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PMLAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLAustralian = Nothing
					Else
						entity.PMLAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PMLBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLBritish = Nothing
					Else
						entity.PMLBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PMLCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLCanadian = Nothing
					Else
						entity.PMLCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PMLEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLEuro = Nothing
					Else
						entity.PMLEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PMLJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLJapanese = Nothing
					Else
						entity.PMLJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PMLMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLMexican = Nothing
					Else
						entity.PMLMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PMLNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLNewZealand = Nothing
					Else
						entity.PMLNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pmlus As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.Pmlus
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pmlus = Nothing
					Else
						entity.Pmlus = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mfl As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.Mfl
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mfl = Nothing
					Else
						entity.Mfl = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MFLAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLAustralian = Nothing
					Else
						entity.MFLAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MFLBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLBritish = Nothing
					Else
						entity.MFLBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MFLCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLCanadian = Nothing
					Else
						entity.MFLCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MFLEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLEuro = Nothing
					Else
						entity.MFLEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MFLJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLJapanese = Nothing
					Else
						entity.MFLJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MFLMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLMexican = Nothing
					Else
						entity.MFLMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MFLNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLNewZealand = Nothing
					Else
						entity.MFLNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mflus As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.Mflus
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mflus = Nothing
					Else
						entity.Mflus = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property SurveyDateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SurveyDateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurveyDateMonth = Nothing
					Else
						entity.SurveyDateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SurveyDateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SurveyDateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurveyDateYear = Nothing
					Else
						entity.SurveyDateYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVwFireCOPESummary
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireCOPESummaryMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwFireCOPESummaryQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireCOPESummaryQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwFireCOPESummaryQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwFireCOPESummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwFireCOPESummaryQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwFireCOPESummaryCollection
		Inherits esEntityCollection(Of VwFireCOPESummary)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireCOPESummaryMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwFireCOPESummaryCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwFireCOPESummaryQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireCOPESummaryQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwFireCOPESummaryQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwFireCOPESummaryQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwFireCOPESummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwFireCOPESummaryQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwFireCOPESummaryQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwFireCOPESummaryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwFireCOPESummaryMetadata.Meta()
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
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "Facility" 
					Return Me.Facility
				Case "Address" 
					Return Me.Address
				Case "City" 
					Return Me.City
				Case "StProv" 
					Return Me.StProv
				Case "Country" 
					Return Me.Country
				Case "SurveyDate" 
					Return Me.SurveyDate
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
				Case "InititalMajorConstructionYear" 
					Return Me.InititalMajorConstructionYear
				Case "TotalFloorArea" 
					Return Me.TotalFloorArea
				Case "TotalFloorAreaMetric" 
					Return Me.TotalFloorAreaMetric
				Case "NoofStories" 
					Return Me.NoofStories
				Case "RoofConstructionFireResistive" 
					Return Me.RoofConstructionFireResistive
				Case "RoofConstructionNoncombustible" 
					Return Me.RoofConstructionNoncombustible
				Case "RoofConstructionCombustible" 
					Return Me.RoofConstructionCombustible
				Case "RoofConstructionClass" 
					Return Me.RoofConstructionClass
				Case "MajorGroup" 
					Return Me.MajorGroup
				Case "SpecificGroup" 
					Return Me.SpecificGroup
				Case "AreaWithSprinklers" 
					Return Me.AreaWithSprinklers
				Case "AreaWithoutSprinklersNeedingSprinklers" 
					Return Me.AreaWithoutSprinklersNeedingSprinklers
				Case "WaterSupplyRating" 
					Return Me.WaterSupplyRating
				Case "PropertySurveillance" 
					Return Me.PropertySurveillance
				Case "SpecialHazardsRating" 
					Return Me.SpecialHazardsRating
				Case "HumanElementRating" 
					Return Me.HumanElementRating
				Case "ExternalFire" 
					Return Me.ExternalFire
				Case "FMSeismicZone" 
					Return Me.FMSeismicZone
				Case "Flood" 
					Return Me.Flood
				Case "Zone" 
					Return Me.Zone
				Case "Windstorm" 
					Return Me.Windstorm
				Case "MaxSustainedWindSpeed" 
					Return Me.MaxSustainedWindSpeed
				Case "MaxSustainedWindSpeedMetric" 
					Return Me.MaxSustainedWindSpeedMetric
				Case "Apl" 
					Return Me.Apl
				Case "APLAustralian" 
					Return Me.APLAustralian
				Case "APLBritish" 
					Return Me.APLBritish
				Case "APLCanadian" 
					Return Me.APLCanadian
				Case "APLEuro" 
					Return Me.APLEuro
				Case "APLJapanese" 
					Return Me.APLJapanese
				Case "APLMexican" 
					Return Me.APLMexican
				Case "APLNewZealand" 
					Return Me.APLNewZealand
				Case "Aplus" 
					Return Me.Aplus
				Case "Pml" 
					Return Me.Pml
				Case "PMLAustralian" 
					Return Me.PMLAustralian
				Case "PMLBritish" 
					Return Me.PMLBritish
				Case "PMLCanadian" 
					Return Me.PMLCanadian
				Case "PMLEuro" 
					Return Me.PMLEuro
				Case "PMLJapanese" 
					Return Me.PMLJapanese
				Case "PMLMexican" 
					Return Me.PMLMexican
				Case "PMLNewZealand" 
					Return Me.PMLNewZealand
				Case "Pmlus" 
					Return Me.Pmlus
				Case "Mfl" 
					Return Me.Mfl
				Case "MFLAustralian" 
					Return Me.MFLAustralian
				Case "MFLBritish" 
					Return Me.MFLBritish
				Case "MFLCanadian" 
					Return Me.MFLCanadian
				Case "MFLEuro" 
					Return Me.MFLEuro
				Case "MFLJapanese" 
					Return Me.MFLJapanese
				Case "MFLMexican" 
					Return Me.MFLMexican
				Case "MFLNewZealand" 
					Return Me.MFLNewZealand
				Case "Mflus" 
					Return Me.Mflus
				Case "SurveyDateMonth" 
					Return Me.SurveyDateMonth
				Case "SurveyDateYear" 
					Return Me.SurveyDateYear
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property InititalMajorConstructionYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.InititalMajorConstructionYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TotalFloorArea As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TotalFloorArea, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalFloorAreaMetric As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.TotalFloorAreaMetric, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property NoofStories As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.NoofStories, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionFireResistive As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionFireResistive, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionNoncombustible As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionNoncombustible, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionCombustible As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionCombustible, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RoofConstructionClass As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionClass, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MajorGroup As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MajorGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecificGroup As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.SpecificGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AreaWithSprinklers As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.AreaWithSprinklers, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property AreaWithoutSprinklersNeedingSprinklers As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.AreaWithoutSprinklersNeedingSprinklers, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property WaterSupplyRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.WaterSupplyRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PropertySurveillance As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.PropertySurveillance, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecialHazardsRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.SpecialHazardsRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.HumanElementRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ExternalFire As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.ExternalFire, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FMSeismicZone As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.FMSeismicZone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Flood As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Flood, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zone As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Zone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Windstorm As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Windstorm, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MaxSustainedWindSpeed As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MaxSustainedWindSpeed, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MaxSustainedWindSpeedMetric As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MaxSustainedWindSpeedMetric, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apl As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Apl, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.APLAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.APLBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.APLCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.APLEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.APLJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.APLMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.APLNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Aplus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Aplus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Pml As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Pml, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PMLAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.PMLAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PMLBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.PMLBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PMLCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.PMLCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PMLEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.PMLEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PMLJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.PMLJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PMLMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.PMLMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PMLNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.PMLNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Pmlus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Mfl As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Mfl, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MFLAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MFLAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MFLBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MFLBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MFLCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MFLCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MFLEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MFLEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MFLJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MFLJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MFLMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MFLMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MFLNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.MFLNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Mflus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.Mflus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.SurveyDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireCOPESummaryMetadata.ColumnNames.SurveyDateYear, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwFireCOPESummaryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.FilePrefix, 0, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.CustomAccess, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Facility, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Address, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.City, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.StProv, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Country, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.SurveyDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames._100PercentUSTot, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TIVAustralian, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TIVBritish, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TIVCanadian, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TIVEuro, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TIVJapanese, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TIVMexican, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TIVNewZealand, 19, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Tivus, 20, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.InititalMajorConstructionYear, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.InititalMajorConstructionYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TotalFloorArea, 22, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TotalFloorArea
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.TotalFloorAreaMetric, 23, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.TotalFloorAreaMetric
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.NoofStories, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.NoofStories
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionFireResistive, 25, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionFireResistive
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionNoncombustible, 26, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionNoncombustible
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionCombustible, 27, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionCombustible
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.RoofConstructionClass, 28, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.RoofConstructionClass
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MajorGroup, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MajorGroup
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.SpecificGroup, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.SpecificGroup
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.AreaWithSprinklers, 31, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.AreaWithSprinklers
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.AreaWithoutSprinklersNeedingSprinklers, 32, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.AreaWithoutSprinklersNeedingSprinklers
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.WaterSupplyRating, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.WaterSupplyRating
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.PropertySurveillance, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.PropertySurveillance
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.SpecialHazardsRating, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.SpecialHazardsRating
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.HumanElementRating, 36, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.HumanElementRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.ExternalFire, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.ExternalFire
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.FMSeismicZone, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.FMSeismicZone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Flood, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Flood
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Zone, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Zone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Windstorm, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Windstorm
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MaxSustainedWindSpeed, 42, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MaxSustainedWindSpeed
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MaxSustainedWindSpeedMetric, 43, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MaxSustainedWindSpeedMetric
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Apl, 44, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Apl
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.APLAustralian, 45, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.APLAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.APLBritish, 46, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.APLBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.APLCanadian, 47, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.APLCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.APLEuro, 48, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.APLEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.APLJapanese, 49, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.APLJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.APLMexican, 50, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.APLMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.APLNewZealand, 51, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.APLNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Aplus, 52, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Aplus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Pml, 53, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Pml
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.PMLAustralian, 54, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.PMLAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.PMLBritish, 55, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.PMLBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.PMLCanadian, 56, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.PMLCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.PMLEuro, 57, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.PMLEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.PMLJapanese, 58, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.PMLJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.PMLMexican, 59, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.PMLMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.PMLNewZealand, 60, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.PMLNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Pmlus, 61, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Pmlus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Mfl, 62, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Mfl
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MFLAustralian, 63, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MFLAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MFLBritish, 64, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MFLBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MFLCanadian, 65, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MFLCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MFLEuro, 66, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MFLEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MFLJapanese, 67, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MFLJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MFLMexican, 68, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MFLMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.MFLNewZealand, 69, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.MFLNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.Mflus, 70, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.Mflus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.SurveyDateMonth, 71, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.SurveyDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireCOPESummaryMetadata.ColumnNames.SurveyDateYear, 72, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireCOPESummaryMetadata.PropertyNames.SurveyDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwFireCOPESummaryMetadata
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
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Facility As String = "Facility"
			 Public Const Address As String = "Address"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Country As String = "Country"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const _100PercentUSTot As String = "100PercentUSTot"
			 Public Const TIVAustralian As String = "TIVAustralian"
			 Public Const TIVBritish As String = "TIVBritish"
			 Public Const TIVCanadian As String = "TIVCanadian"
			 Public Const TIVEuro As String = "TIVEuro"
			 Public Const TIVJapanese As String = "TIVJapanese"
			 Public Const TIVMexican As String = "TIVMexican"
			 Public Const TIVNewZealand As String = "TIVNewZealand"
			 Public Const Tivus As String = "TIVUS"
			 Public Const InititalMajorConstructionYear As String = "InititalMajorConstructionYear"
			 Public Const TotalFloorArea As String = "TotalFloorArea"
			 Public Const TotalFloorAreaMetric As String = "TotalFloorAreaMetric"
			 Public Const NoofStories As String = "NoofStories"
			 Public Const RoofConstructionFireResistive As String = "RoofConstructionFireResistive"
			 Public Const RoofConstructionNoncombustible As String = "RoofConstructionNoncombustible"
			 Public Const RoofConstructionCombustible As String = "RoofConstructionCombustible"
			 Public Const RoofConstructionClass As String = "RoofConstructionClass"
			 Public Const MajorGroup As String = "MajorGroup"
			 Public Const SpecificGroup As String = "SpecificGroup"
			 Public Const AreaWithSprinklers As String = "AreaWithSprinklers"
			 Public Const AreaWithoutSprinklersNeedingSprinklers As String = "AreaWithoutSprinklersNeedingSprinklers"
			 Public Const WaterSupplyRating As String = "WaterSupplyRating"
			 Public Const PropertySurveillance As String = "PropertySurveillance"
			 Public Const SpecialHazardsRating As String = "SpecialHazardsRating"
			 Public Const HumanElementRating As String = "HumanElementRating"
			 Public Const ExternalFire As String = "ExternalFire"
			 Public Const FMSeismicZone As String = "FMSeismicZone"
			 Public Const Flood As String = "Flood"
			 Public Const Zone As String = "Zone"
			 Public Const Windstorm As String = "Windstorm"
			 Public Const MaxSustainedWindSpeed As String = "MaxSustainedWindSpeed"
			 Public Const MaxSustainedWindSpeedMetric As String = "MaxSustainedWindSpeedMetric"
			 Public Const Apl As String = "APL"
			 Public Const APLAustralian As String = "APLAustralian"
			 Public Const APLBritish As String = "APLBritish"
			 Public Const APLCanadian As String = "APLCanadian"
			 Public Const APLEuro As String = "APLEuro"
			 Public Const APLJapanese As String = "APLJapanese"
			 Public Const APLMexican As String = "APLMexican"
			 Public Const APLNewZealand As String = "APLNewZealand"
			 Public Const Aplus As String = "APLUS"
			 Public Const Pml As String = "PML"
			 Public Const PMLAustralian As String = "PMLAustralian"
			 Public Const PMLBritish As String = "PMLBritish"
			 Public Const PMLCanadian As String = "PMLCanadian"
			 Public Const PMLEuro As String = "PMLEuro"
			 Public Const PMLJapanese As String = "PMLJapanese"
			 Public Const PMLMexican As String = "PMLMexican"
			 Public Const PMLNewZealand As String = "PMLNewZealand"
			 Public Const Pmlus As String = "PMLUS"
			 Public Const Mfl As String = "MFL"
			 Public Const MFLAustralian As String = "MFLAustralian"
			 Public Const MFLBritish As String = "MFLBritish"
			 Public Const MFLCanadian As String = "MFLCanadian"
			 Public Const MFLEuro As String = "MFLEuro"
			 Public Const MFLJapanese As String = "MFLJapanese"
			 Public Const MFLMexican As String = "MFLMexican"
			 Public Const MFLNewZealand As String = "MFLNewZealand"
			 Public Const Mflus As String = "MFLUS"
			 Public Const SurveyDateMonth As String = "SurveyDateMonth"
			 Public Const SurveyDateYear As String = "SurveyDateYear"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FileNo As String = "FileNo"
			 Public Const Client As String = "Client"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Facility As String = "Facility"
			 Public Const Address As String = "Address"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Country As String = "Country"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const _100PercentUSTot As String = "_100PercentUSTot"
			 Public Const TIVAustralian As String = "TIVAustralian"
			 Public Const TIVBritish As String = "TIVBritish"
			 Public Const TIVCanadian As String = "TIVCanadian"
			 Public Const TIVEuro As String = "TIVEuro"
			 Public Const TIVJapanese As String = "TIVJapanese"
			 Public Const TIVMexican As String = "TIVMexican"
			 Public Const TIVNewZealand As String = "TIVNewZealand"
			 Public Const Tivus As String = "Tivus"
			 Public Const InititalMajorConstructionYear As String = "InititalMajorConstructionYear"
			 Public Const TotalFloorArea As String = "TotalFloorArea"
			 Public Const TotalFloorAreaMetric As String = "TotalFloorAreaMetric"
			 Public Const NoofStories As String = "NoofStories"
			 Public Const RoofConstructionFireResistive As String = "RoofConstructionFireResistive"
			 Public Const RoofConstructionNoncombustible As String = "RoofConstructionNoncombustible"
			 Public Const RoofConstructionCombustible As String = "RoofConstructionCombustible"
			 Public Const RoofConstructionClass As String = "RoofConstructionClass"
			 Public Const MajorGroup As String = "MajorGroup"
			 Public Const SpecificGroup As String = "SpecificGroup"
			 Public Const AreaWithSprinklers As String = "AreaWithSprinklers"
			 Public Const AreaWithoutSprinklersNeedingSprinklers As String = "AreaWithoutSprinklersNeedingSprinklers"
			 Public Const WaterSupplyRating As String = "WaterSupplyRating"
			 Public Const PropertySurveillance As String = "PropertySurveillance"
			 Public Const SpecialHazardsRating As String = "SpecialHazardsRating"
			 Public Const HumanElementRating As String = "HumanElementRating"
			 Public Const ExternalFire As String = "ExternalFire"
			 Public Const FMSeismicZone As String = "FMSeismicZone"
			 Public Const Flood As String = "Flood"
			 Public Const Zone As String = "Zone"
			 Public Const Windstorm As String = "Windstorm"
			 Public Const MaxSustainedWindSpeed As String = "MaxSustainedWindSpeed"
			 Public Const MaxSustainedWindSpeedMetric As String = "MaxSustainedWindSpeedMetric"
			 Public Const Apl As String = "Apl"
			 Public Const APLAustralian As String = "APLAustralian"
			 Public Const APLBritish As String = "APLBritish"
			 Public Const APLCanadian As String = "APLCanadian"
			 Public Const APLEuro As String = "APLEuro"
			 Public Const APLJapanese As String = "APLJapanese"
			 Public Const APLMexican As String = "APLMexican"
			 Public Const APLNewZealand As String = "APLNewZealand"
			 Public Const Aplus As String = "Aplus"
			 Public Const Pml As String = "Pml"
			 Public Const PMLAustralian As String = "PMLAustralian"
			 Public Const PMLBritish As String = "PMLBritish"
			 Public Const PMLCanadian As String = "PMLCanadian"
			 Public Const PMLEuro As String = "PMLEuro"
			 Public Const PMLJapanese As String = "PMLJapanese"
			 Public Const PMLMexican As String = "PMLMexican"
			 Public Const PMLNewZealand As String = "PMLNewZealand"
			 Public Const Pmlus As String = "Pmlus"
			 Public Const Mfl As String = "Mfl"
			 Public Const MFLAustralian As String = "MFLAustralian"
			 Public Const MFLBritish As String = "MFLBritish"
			 Public Const MFLCanadian As String = "MFLCanadian"
			 Public Const MFLEuro As String = "MFLEuro"
			 Public Const MFLJapanese As String = "MFLJapanese"
			 Public Const MFLMexican As String = "MFLMexican"
			 Public Const MFLNewZealand As String = "MFLNewZealand"
			 Public Const Mflus As String = "Mflus"
			 Public Const SurveyDateMonth As String = "SurveyDateMonth"
			 Public Const SurveyDateYear As String = "SurveyDateYear"
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
			SyncLock GetType(VwFireCOPESummaryMetadata)
			
				If VwFireCOPESummaryMetadata.mapDelegates Is Nothing Then
					VwFireCOPESummaryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwFireCOPESummaryMetadata._meta Is Nothing Then
					VwFireCOPESummaryMetadata._meta = New VwFireCOPESummaryMetadata()
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
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Facility", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SurveyDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("_100PercentUSTot", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TIVAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Tivus", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("InititalMajorConstructionYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TotalFloorArea", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotalFloorAreaMetric", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("NoofStories", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RoofConstructionFireResistive", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RoofConstructionNoncombustible", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RoofConstructionCombustible", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RoofConstructionClass", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MajorGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecificGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("AreaWithSprinklers", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("AreaWithoutSprinklersNeedingSprinklers", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("WaterSupplyRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PropertySurveillance", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecialHazardsRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HumanElementRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ExternalFire", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FMSeismicZone", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Flood", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zone", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Windstorm", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MaxSustainedWindSpeed", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MaxSustainedWindSpeedMetric", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apl", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Aplus", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Pml", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PMLAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PMLBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PMLCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PMLEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PMLJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PMLMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PMLNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Pmlus", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Mfl", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MFLAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MFLBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MFLCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MFLEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MFLJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MFLMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MFLNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Mflus", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("SurveyDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SurveyDateYear", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "vwFireCOPESummary"
				meta.Destination = "vwFireCOPESummary"
				
				meta.spInsert = "proc_vwFireCOPESummaryInsert"
				meta.spUpdate = "proc_vwFireCOPESummaryUpdate"
				meta.spDelete = "proc_vwFireCOPESummaryDelete"
				meta.spLoadAll = "proc_vwFireCOPESummaryLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwFireCOPESummaryLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwFireCOPESummaryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
