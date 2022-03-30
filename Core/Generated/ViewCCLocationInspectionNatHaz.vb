
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2013 1:05:40 PM
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
	' Encapsulates the 'viewCCLocationInspectionNatHaz' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationInspectionNatHaz))> _
	<XmlType("ViewCCLocationInspectionNatHaz")> _	
	Partial Public Class ViewCCLocationInspectionNatHaz 
		Inherits esViewCCLocationInspectionNatHaz
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationInspectionNatHaz()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationInspectionNatHazCollection")> _
	Partial Public Class ViewCCLocationInspectionNatHazCollection
		Inherits esViewCCLocationInspectionNatHazCollection
		Implements IEnumerable(Of ViewCCLocationInspectionNatHaz)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationInspectionNatHaz))> _
		Public Class ViewCCLocationInspectionNatHazCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationInspectionNatHazCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationInspectionNatHazCollectionWCFPacket) As ViewCCLocationInspectionNatHazCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationInspectionNatHazCollection) As ViewCCLocationInspectionNatHazCollectionWCFPacket
				Return New ViewCCLocationInspectionNatHazCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationInspectionNatHazQuery 
		Inherits esViewCCLocationInspectionNatHazQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationInspectionNatHazQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationInspectionNatHazQuery) As String
			Return ViewCCLocationInspectionNatHazQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationInspectionNatHazQuery
			Return DirectCast(ViewCCLocationInspectionNatHazQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationInspectionNatHazQuery)), ViewCCLocationInspectionNatHazQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationInspectionNatHaz
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.LocationStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.LocationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.LocationStatus, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.LocationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.ContractYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContractYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationInspectionNatHazMetadata.ColumnNames.ContractYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationInspectionNatHazMetadata.ColumnNames.ContractYr, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.ContractYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.Frequency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Frequency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Frequency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Frequency, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.Frequency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.NextInspYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NextInspYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationInspectionNatHazMetadata.ColumnNames.NextInspYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationInspectionNatHazMetadata.ColumnNames.NextInspYr, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.NextInspYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PD_Building
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDBuilding As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDBuilding)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDBuilding, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDBuilding)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.TotalUS_TIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSTIV, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.TotalUSTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PD_Finished
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDFinished As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDFinished)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDFinished, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDFinished)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PD_RawStock
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDRawStock As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDRawStock)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDRawStock, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDRawStock)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PD_BuildersRisk
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDBuildersRisk As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDBuildersRisk)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDBuildersRisk, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDBuildersRisk)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PD_Misc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDMisc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDMisc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDMisc, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDMisc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PD_Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDTotal As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDTotal)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDTotal, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.BI_GrossProfit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIGrossProfit As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIGrossProfit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIGrossProfit, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.BIGrossProfit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.BI_WageExtraExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIWageExtraExp As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIWageExtraExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIWageExtraExp, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.BIWageExtraExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.BI_Misc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIMisc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIMisc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIMisc, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.BIMisc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.BI_Other
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIOther As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIOther)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIOther, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.BIOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.BI_Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BITotal As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BITotal)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BITotal, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.BITotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.GrossProfitIndemnity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GrossProfitIndemnity As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationInspectionNatHazMetadata.ColumnNames.GrossProfitIndemnity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationInspectionNatHazMetadata.ColumnNames.GrossProfitIndemnity, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.GrossProfitIndemnity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.WagesExtraExpIndem
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WagesExtraExpIndem As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationInspectionNatHazMetadata.ColumnNames.WagesExtraExpIndem)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationInspectionNatHazMetadata.ColumnNames.WagesExtraExpIndem, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.WagesExtraExpIndem)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.TotalUS_PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSPD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSPD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSPD, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.TotalUSPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.TotalUS_BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSBI As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSBI)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSBI, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.TotalUSBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.LocalTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocalTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.LocalTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.LocalTIV, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.LocalTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PERCENTUSTOT100
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Percentustot100 As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Percentustot100)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Percentustot100, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.Percentustot100)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.InspDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspDue, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.InspRemaining
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspRemaining As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspRemaining)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspRemaining, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspRemaining)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.EngTargetMo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngTargetMo As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.EngTargetMo)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.EngTargetMo, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.EngTargetMo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.InspPerFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspPerFROM As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspPerFROM)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspPerFROM, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspPerFROM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.InspPerTO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspPerTO As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspPerTO)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspPerTO, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspPerTO)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.CancelDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CancelDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.CancelDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.CancelDate, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.CancelDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.InspectionStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspectionStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspectionStatus, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspectionStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.EffectiveDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EffectiveDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.EffectiveDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.EffectiveDate, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.EffectiveDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.CurrencyCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrencyCode As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.CurrencyCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.CurrencyCode, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.CurrencyCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.PD_Equipment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDEquipment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDEquipment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDEquipment, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDEquipment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.DateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.DateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.DateCompleted, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.DateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.DateMailedToClient
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateMailedToClient As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.DateMailedToClient)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.DateMailedToClient, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.DateMailedToClient)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.ClientTargetMo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientTargetMo As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.ClientTargetMo)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionNatHazMetadata.ColumnNames.ClientTargetMo, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.ClientTargetMo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionNatHaz.Report1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Report1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Report1, value) Then
					OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.Report1)
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
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
						Case "Engineer"
							Me.str().Engineer = CType(value, string)
												
						Case "LocationStatus"
							Me.str().LocationStatus = CType(value, string)
												
						Case "ContractYr"
							Me.str().ContractYr = CType(value, string)
												
						Case "Frequency"
							Me.str().Frequency = CType(value, string)
												
						Case "NextInspYr"
							Me.str().NextInspYr = CType(value, string)
												
						Case "PDBuilding"
							Me.str().PDBuilding = CType(value, string)
												
						Case "TotalUSTIV"
							Me.str().TotalUSTIV = CType(value, string)
												
						Case "PDFinished"
							Me.str().PDFinished = CType(value, string)
												
						Case "PDRawStock"
							Me.str().PDRawStock = CType(value, string)
												
						Case "PDBuildersRisk"
							Me.str().PDBuildersRisk = CType(value, string)
												
						Case "PDMisc"
							Me.str().PDMisc = CType(value, string)
												
						Case "PDTotal"
							Me.str().PDTotal = CType(value, string)
												
						Case "BIGrossProfit"
							Me.str().BIGrossProfit = CType(value, string)
												
						Case "BIWageExtraExp"
							Me.str().BIWageExtraExp = CType(value, string)
												
						Case "BIMisc"
							Me.str().BIMisc = CType(value, string)
												
						Case "BIOther"
							Me.str().BIOther = CType(value, string)
												
						Case "BITotal"
							Me.str().BITotal = CType(value, string)
												
						Case "GrossProfitIndemnity"
							Me.str().GrossProfitIndemnity = CType(value, string)
												
						Case "WagesExtraExpIndem"
							Me.str().WagesExtraExpIndem = CType(value, string)
												
						Case "TotalUSPD"
							Me.str().TotalUSPD = CType(value, string)
												
						Case "TotalUSBI"
							Me.str().TotalUSBI = CType(value, string)
												
						Case "LocalTIV"
							Me.str().LocalTIV = CType(value, string)
												
						Case "Percentustot100"
							Me.str().Percentustot100 = CType(value, string)
												
						Case "InspDue"
							Me.str().InspDue = CType(value, string)
												
						Case "InspRemaining"
							Me.str().InspRemaining = CType(value, string)
												
						Case "EngTargetMo"
							Me.str().EngTargetMo = CType(value, string)
												
						Case "InspPerFROM"
							Me.str().InspPerFROM = CType(value, string)
												
						Case "InspPerTO"
							Me.str().InspPerTO = CType(value, string)
												
						Case "CancelDate"
							Me.str().CancelDate = CType(value, string)
												
						Case "InspectionStatus"
							Me.str().InspectionStatus = CType(value, string)
												
						Case "EffectiveDate"
							Me.str().EffectiveDate = CType(value, string)
												
						Case "CurrencyCode"
							Me.str().CurrencyCode = CType(value, string)
												
						Case "PDEquipment"
							Me.str().PDEquipment = CType(value, string)
												
						Case "DateCompleted"
							Me.str().DateCompleted = CType(value, string)
												
						Case "DateMailedToClient"
							Me.str().DateMailedToClient = CType(value, string)
												
						Case "ClientTargetMo"
							Me.str().ClientTargetMo = CType(value, string)
												
						Case "Report1"
							Me.str().Report1 = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "ContractYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.ContractYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.ContractYr)
							End If
						
						Case "NextInspYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NextInspYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.NextInspYr)
							End If
						
						Case "GrossProfitIndemnity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.GrossProfitIndemnity = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.GrossProfitIndemnity)
							End If
						
						Case "WagesExtraExpIndem"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.WagesExtraExpIndem = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.WagesExtraExpIndem)
							End If
						
						Case "Percentustot100"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Percentustot100 = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.Percentustot100)
							End If
						
						Case "InspDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspDue)
							End If
						
						Case "InspRemaining"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspRemaining = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspRemaining)
							End If
						
						Case "EngTargetMo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EngTargetMo = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.EngTargetMo)
							End If
						
						Case "InspPerFROM"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspPerFROM = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspPerFROM)
							End If
						
						Case "InspPerTO"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspPerTO = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspPerTO)
							End If
						
						Case "CancelDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CancelDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.CancelDate)
							End If
						
						Case "EffectiveDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EffectiveDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.EffectiveDate)
							End If
						
						Case "DateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.DateCompleted)
							End If
						
						Case "DateMailedToClient"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateMailedToClient = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.DateMailedToClient)
							End If
						
						Case "ClientTargetMo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ClientTargetMo = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionNatHazMetadata.PropertyNames.ClientTargetMo)
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
		
			Public Sub New(ByVal entity As esViewCCLocationInspectionNatHaz)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property PracticeCode As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.PracticeCode
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeCode = Nothing
					Else
						entity.PracticeCode = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Engineer As System.String 
				Get
					Dim data_ As System.String = entity.Engineer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Engineer = Nothing
					Else
						entity.Engineer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationStatus As System.String 
				Get
					Dim data_ As System.String = entity.LocationStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationStatus = Nothing
					Else
						entity.LocationStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContractYr As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.ContractYr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContractYr = Nothing
					Else
						entity.ContractYr = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Frequency As System.String 
				Get
					Dim data_ As System.String = entity.Frequency
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Frequency = Nothing
					Else
						entity.Frequency = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NextInspYr As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.NextInspYr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NextInspYr = Nothing
					Else
						entity.NextInspYr = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDBuilding As System.String 
				Get
					Dim data_ As System.String = entity.PDBuilding
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDBuilding = Nothing
					Else
						entity.PDBuilding = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalUSTIV As System.String 
				Get
					Dim data_ As System.String = entity.TotalUSTIV
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalUSTIV = Nothing
					Else
						entity.TotalUSTIV = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDFinished As System.String 
				Get
					Dim data_ As System.String = entity.PDFinished
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDFinished = Nothing
					Else
						entity.PDFinished = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDRawStock As System.String 
				Get
					Dim data_ As System.String = entity.PDRawStock
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDRawStock = Nothing
					Else
						entity.PDRawStock = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDBuildersRisk As System.String 
				Get
					Dim data_ As System.String = entity.PDBuildersRisk
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDBuildersRisk = Nothing
					Else
						entity.PDBuildersRisk = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDMisc As System.String 
				Get
					Dim data_ As System.String = entity.PDMisc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDMisc = Nothing
					Else
						entity.PDMisc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDTotal As System.String 
				Get
					Dim data_ As System.String = entity.PDTotal
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDTotal = Nothing
					Else
						entity.PDTotal = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIGrossProfit As System.String 
				Get
					Dim data_ As System.String = entity.BIGrossProfit
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIGrossProfit = Nothing
					Else
						entity.BIGrossProfit = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIWageExtraExp As System.String 
				Get
					Dim data_ As System.String = entity.BIWageExtraExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIWageExtraExp = Nothing
					Else
						entity.BIWageExtraExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIMisc As System.String 
				Get
					Dim data_ As System.String = entity.BIMisc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIMisc = Nothing
					Else
						entity.BIMisc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIOther As System.String 
				Get
					Dim data_ As System.String = entity.BIOther
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIOther = Nothing
					Else
						entity.BIOther = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BITotal As System.String 
				Get
					Dim data_ As System.String = entity.BITotal
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BITotal = Nothing
					Else
						entity.BITotal = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GrossProfitIndemnity As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.GrossProfitIndemnity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GrossProfitIndemnity = Nothing
					Else
						entity.GrossProfitIndemnity = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property WagesExtraExpIndem As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.WagesExtraExpIndem
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WagesExtraExpIndem = Nothing
					Else
						entity.WagesExtraExpIndem = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalUSPD As System.String 
				Get
					Dim data_ As System.String = entity.TotalUSPD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalUSPD = Nothing
					Else
						entity.TotalUSPD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalUSBI As System.String 
				Get
					Dim data_ As System.String = entity.TotalUSBI
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalUSBI = Nothing
					Else
						entity.TotalUSBI = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocalTIV As System.String 
				Get
					Dim data_ As System.String = entity.LocalTIV
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocalTIV = Nothing
					Else
						entity.LocalTIV = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Percentustot100 As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Percentustot100
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Percentustot100 = Nothing
					Else
						entity.Percentustot100 = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspDue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InspDue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspDue = Nothing
					Else
						entity.InspDue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspRemaining As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InspRemaining
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspRemaining = Nothing
					Else
						entity.InspRemaining = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EngTargetMo As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.EngTargetMo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EngTargetMo = Nothing
					Else
						entity.EngTargetMo = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspPerFROM As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspPerFROM
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspPerFROM = Nothing
					Else
						entity.InspPerFROM = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspPerTO As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspPerTO
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspPerTO = Nothing
					Else
						entity.InspPerTO = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CancelDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CancelDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CancelDate = Nothing
					Else
						entity.CancelDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionStatus As System.String 
				Get
					Dim data_ As System.String = entity.InspectionStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionStatus = Nothing
					Else
						entity.InspectionStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EffectiveDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.EffectiveDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EffectiveDate = Nothing
					Else
						entity.EffectiveDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CurrencyCode As System.String 
				Get
					Dim data_ As System.String = entity.CurrencyCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CurrencyCode = Nothing
					Else
						entity.CurrencyCode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDEquipment As System.String 
				Get
					Dim data_ As System.String = entity.PDEquipment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDEquipment = Nothing
					Else
						entity.PDEquipment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateCompleted As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateCompleted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateCompleted = Nothing
					Else
						entity.DateCompleted = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateMailedToClient As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateMailedToClient
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateMailedToClient = Nothing
					Else
						entity.DateMailedToClient = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ClientTargetMo As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ClientTargetMo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClientTargetMo = Nothing
					Else
						entity.ClientTargetMo = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Report1 As System.String 
				Get
					Dim data_ As System.String = entity.Report1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Report1 = Nothing
					Else
						entity.Report1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCLocationInspectionNatHaz
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationInspectionNatHazMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationInspectionNatHazQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationInspectionNatHazQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationInspectionNatHazQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationInspectionNatHazQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationInspectionNatHazQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationInspectionNatHazCollection
		Inherits esEntityCollection(Of ViewCCLocationInspectionNatHaz)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationInspectionNatHazMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationInspectionNatHazCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationInspectionNatHazQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationInspectionNatHazQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationInspectionNatHazQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationInspectionNatHazQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationInspectionNatHazQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationInspectionNatHazQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationInspectionNatHazQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationInspectionNatHazQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationInspectionNatHazMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "Engineer" 
					Return Me.Engineer
				Case "LocationStatus" 
					Return Me.LocationStatus
				Case "ContractYr" 
					Return Me.ContractYr
				Case "Frequency" 
					Return Me.Frequency
				Case "NextInspYr" 
					Return Me.NextInspYr
				Case "PDBuilding" 
					Return Me.PDBuilding
				Case "TotalUSTIV" 
					Return Me.TotalUSTIV
				Case "PDFinished" 
					Return Me.PDFinished
				Case "PDRawStock" 
					Return Me.PDRawStock
				Case "PDBuildersRisk" 
					Return Me.PDBuildersRisk
				Case "PDMisc" 
					Return Me.PDMisc
				Case "PDTotal" 
					Return Me.PDTotal
				Case "BIGrossProfit" 
					Return Me.BIGrossProfit
				Case "BIWageExtraExp" 
					Return Me.BIWageExtraExp
				Case "BIMisc" 
					Return Me.BIMisc
				Case "BIOther" 
					Return Me.BIOther
				Case "BITotal" 
					Return Me.BITotal
				Case "GrossProfitIndemnity" 
					Return Me.GrossProfitIndemnity
				Case "WagesExtraExpIndem" 
					Return Me.WagesExtraExpIndem
				Case "TotalUSPD" 
					Return Me.TotalUSPD
				Case "TotalUSBI" 
					Return Me.TotalUSBI
				Case "LocalTIV" 
					Return Me.LocalTIV
				Case "Percentustot100" 
					Return Me.Percentustot100
				Case "InspDue" 
					Return Me.InspDue
				Case "InspRemaining" 
					Return Me.InspRemaining
				Case "EngTargetMo" 
					Return Me.EngTargetMo
				Case "InspPerFROM" 
					Return Me.InspPerFROM
				Case "InspPerTO" 
					Return Me.InspPerTO
				Case "CancelDate" 
					Return Me.CancelDate
				Case "InspectionStatus" 
					Return Me.InspectionStatus
				Case "EffectiveDate" 
					Return Me.EffectiveDate
				Case "CurrencyCode" 
					Return Me.CurrencyCode
				Case "PDEquipment" 
					Return Me.PDEquipment
				Case "DateCompleted" 
					Return Me.DateCompleted
				Case "DateMailedToClient" 
					Return Me.DateMailedToClient
				Case "ClientTargetMo" 
					Return Me.ClientTargetMo
				Case "Report1" 
					Return Me.Report1
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.LocationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContractYr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.ContractYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Frequency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.Frequency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NextInspYr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.NextInspYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property PDBuilding As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDBuilding, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDFinished As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDFinished, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDRawStock As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDRawStock, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDBuildersRisk As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDBuildersRisk, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDMisc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDMisc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDTotal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIGrossProfit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIGrossProfit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIWageExtraExp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIWageExtraExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIMisc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIMisc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIOther As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIOther, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BITotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.BITotal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GrossProfitIndemnity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.GrossProfitIndemnity, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property WagesExtraExpIndem As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.WagesExtraExpIndem, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSPD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSBI, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocalTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.LocalTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Percentustot100 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.Percentustot100, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property InspDue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InspRemaining As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspRemaining, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EngTargetMo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.EngTargetMo, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InspPerFROM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspPerFROM, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InspPerTO As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspPerTO, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CancelDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.CancelDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspectionStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EffectiveDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.EffectiveDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CurrencyCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.CurrencyCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDEquipment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDEquipment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.DateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateMailedToClient As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.DateMailedToClient, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ClientTargetMo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.ClientTargetMo, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Report1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionNatHazMetadata.ColumnNames.Report1, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationInspectionNatHazMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PracticeCode, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Engineer, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.LocationStatus, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.LocationStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.ContractYr, 4, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.ContractYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Frequency, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.Frequency
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.NextInspYr, 6, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.NextInspYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDBuilding, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDBuilding
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSTIV, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.TotalUSTIV
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDFinished, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDFinished
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDRawStock, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDRawStock
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDBuildersRisk, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDBuildersRisk
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDMisc, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDMisc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDTotal, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDTotal
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIGrossProfit, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.BIGrossProfit
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIWageExtraExp, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.BIWageExtraExp
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIMisc, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.BIMisc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BIOther, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.BIOther
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.BITotal, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.BITotal
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.GrossProfitIndemnity, 19, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.GrossProfitIndemnity
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.WagesExtraExpIndem, 20, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.WagesExtraExpIndem
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSPD, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.TotalUSPD
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.TotalUSBI, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.TotalUSBI
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.LocalTIV, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.LocalTIV
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Percentustot100, 24, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.Percentustot100
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspDue, 25, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspRemaining, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspRemaining
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.EngTargetMo, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.EngTargetMo
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspPerFROM, 28, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspPerFROM
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspPerTO, 29, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspPerTO
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.CancelDate, 30, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.CancelDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.InspectionStatus, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.InspectionStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.EffectiveDate, 32, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.EffectiveDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.CurrencyCode, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.CurrencyCode
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.PDEquipment, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.PDEquipment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.DateCompleted, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.DateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.DateMailedToClient, 36, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.DateMailedToClient
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.ClientTargetMo, 37, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.ClientTargetMo
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionNatHazMetadata.ColumnNames.Report1, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionNatHazMetadata.PropertyNames.Report1
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationInspectionNatHazMetadata
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
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Engineer As String = "Engineer"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const ContractYr As String = "ContractYr"
			 Public Const Frequency As String = "Frequency"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const PDBuilding As String = "PD_Building"
			 Public Const TotalUSTIV As String = "TotalUS_TIV"
			 Public Const PDFinished As String = "PD_Finished"
			 Public Const PDRawStock As String = "PD_RawStock"
			 Public Const PDBuildersRisk As String = "PD_BuildersRisk"
			 Public Const PDMisc As String = "PD_Misc"
			 Public Const PDTotal As String = "PD_Total"
			 Public Const BIGrossProfit As String = "BI_GrossProfit"
			 Public Const BIWageExtraExp As String = "BI_WageExtraExp"
			 Public Const BIMisc As String = "BI_Misc"
			 Public Const BIOther As String = "BI_Other"
			 Public Const BITotal As String = "BI_Total"
			 Public Const GrossProfitIndemnity As String = "GrossProfitIndemnity"
			 Public Const WagesExtraExpIndem As String = "WagesExtraExpIndem"
			 Public Const TotalUSPD As String = "TotalUS_PD"
			 Public Const TotalUSBI As String = "TotalUS_BI"
			 Public Const LocalTIV As String = "LocalTIV"
			 Public Const Percentustot100 As String = "PERCENTUSTOT100"
			 Public Const InspDue As String = "InspDue"
			 Public Const InspRemaining As String = "InspRemaining"
			 Public Const EngTargetMo As String = "EngTargetMo"
			 Public Const InspPerFROM As String = "InspPerFROM"
			 Public Const InspPerTO As String = "InspPerTO"
			 Public Const CancelDate As String = "CancelDate"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const EffectiveDate As String = "EffectiveDate"
			 Public Const CurrencyCode As String = "CurrencyCode"
			 Public Const PDEquipment As String = "PD_Equipment"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const DateMailedToClient As String = "DateMailedToClient"
			 Public Const ClientTargetMo As String = "ClientTargetMo"
			 Public Const Report1 As String = "Report1"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Engineer As String = "Engineer"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const ContractYr As String = "ContractYr"
			 Public Const Frequency As String = "Frequency"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const PDBuilding As String = "PDBuilding"
			 Public Const TotalUSTIV As String = "TotalUSTIV"
			 Public Const PDFinished As String = "PDFinished"
			 Public Const PDRawStock As String = "PDRawStock"
			 Public Const PDBuildersRisk As String = "PDBuildersRisk"
			 Public Const PDMisc As String = "PDMisc"
			 Public Const PDTotal As String = "PDTotal"
			 Public Const BIGrossProfit As String = "BIGrossProfit"
			 Public Const BIWageExtraExp As String = "BIWageExtraExp"
			 Public Const BIMisc As String = "BIMisc"
			 Public Const BIOther As String = "BIOther"
			 Public Const BITotal As String = "BITotal"
			 Public Const GrossProfitIndemnity As String = "GrossProfitIndemnity"
			 Public Const WagesExtraExpIndem As String = "WagesExtraExpIndem"
			 Public Const TotalUSPD As String = "TotalUSPD"
			 Public Const TotalUSBI As String = "TotalUSBI"
			 Public Const LocalTIV As String = "LocalTIV"
			 Public Const Percentustot100 As String = "Percentustot100"
			 Public Const InspDue As String = "InspDue"
			 Public Const InspRemaining As String = "InspRemaining"
			 Public Const EngTargetMo As String = "EngTargetMo"
			 Public Const InspPerFROM As String = "InspPerFROM"
			 Public Const InspPerTO As String = "InspPerTO"
			 Public Const CancelDate As String = "CancelDate"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const EffectiveDate As String = "EffectiveDate"
			 Public Const CurrencyCode As String = "CurrencyCode"
			 Public Const PDEquipment As String = "PDEquipment"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const DateMailedToClient As String = "DateMailedToClient"
			 Public Const ClientTargetMo As String = "ClientTargetMo"
			 Public Const Report1 As String = "Report1"
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
			SyncLock GetType(ViewCCLocationInspectionNatHazMetadata)
			
				If ViewCCLocationInspectionNatHazMetadata.mapDelegates Is Nothing Then
					ViewCCLocationInspectionNatHazMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationInspectionNatHazMetadata._meta Is Nothing Then
					ViewCCLocationInspectionNatHazMetadata._meta = New ViewCCLocationInspectionNatHazMetadata()
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
				


				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Engineer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ContractYr", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Frequency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NextInspYr", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("PDBuilding", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalUSTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDFinished", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDRawStock", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDBuildersRisk", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDMisc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDTotal", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIGrossProfit", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIWageExtraExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIMisc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIOther", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BITotal", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GrossProfitIndemnity", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("WagesExtraExpIndem", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotalUSPD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalUSBI", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocalTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Percentustot100", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("InspDue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InspRemaining", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EngTargetMo", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("InspPerFROM", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("InspPerTO", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("CancelDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("InspectionStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EffectiveDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("CurrencyCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDEquipment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DateCompleted", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("DateMailedToClient", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ClientTargetMo", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Report1", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCLocationInspectionNatHaz"
				meta.Destination = "viewCCLocationInspectionNatHaz"
				
				meta.spInsert = "proc_viewCCLocationInspectionNatHazInsert"
				meta.spUpdate = "proc_viewCCLocationInspectionNatHazUpdate"
				meta.spDelete = "proc_viewCCLocationInspectionNatHazDelete"
				meta.spLoadAll = "proc_viewCCLocationInspectionNatHazLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationInspectionNatHazLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationInspectionNatHazMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
