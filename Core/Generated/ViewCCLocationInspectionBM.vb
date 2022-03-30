
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2013 1:05:39 PM
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
	' Encapsulates the 'viewCCLocationInspectionBM' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationInspectionBM))> _
	<XmlType("ViewCCLocationInspectionBM")> _	
	Partial Public Class ViewCCLocationInspectionBM 
		Inherits esViewCCLocationInspectionBM
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationInspectionBM()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationInspectionBMCollection")> _
	Partial Public Class ViewCCLocationInspectionBMCollection
		Inherits esViewCCLocationInspectionBMCollection
		Implements IEnumerable(Of ViewCCLocationInspectionBM)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationInspectionBM))> _
		Public Class ViewCCLocationInspectionBMCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationInspectionBMCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationInspectionBMCollectionWCFPacket) As ViewCCLocationInspectionBMCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationInspectionBMCollection) As ViewCCLocationInspectionBMCollectionWCFPacket
				Return New ViewCCLocationInspectionBMCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationInspectionBMQuery 
		Inherits esViewCCLocationInspectionBMQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationInspectionBMQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationInspectionBMQuery) As String
			Return ViewCCLocationInspectionBMQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationInspectionBMQuery
			Return DirectCast(ViewCCLocationInspectionBMQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationInspectionBMQuery)), ViewCCLocationInspectionBMQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationInspectionBM
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationInspectionBMMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationInspectionBMMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.NextInspYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NextInspYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationInspectionBMMetadata.ColumnNames.NextInspYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationInspectionBMMetadata.ColumnNames.NextInspYr, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.NextInspYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.InspRemaining
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspRemaining As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationInspectionBMMetadata.ColumnNames.InspRemaining)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationInspectionBMMetadata.ColumnNames.InspRemaining, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.InspRemaining)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.InspectionStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.InspectionStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.InspectionStatus, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.InspectionStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.LocationStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.LocationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.LocationStatus, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.LocationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.ContractYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContractYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationInspectionBMMetadata.ColumnNames.ContractYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationInspectionBMMetadata.ColumnNames.ContractYr, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.ContractYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.Frequency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Frequency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.Frequency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.Frequency, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.Frequency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.ClientTargetMo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientTargetMo As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.ClientTargetMo)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.ClientTargetMo, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.ClientTargetMo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.DateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.DateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.DateCompleted, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.DateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.DateMailedToClient
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateMailedToClient As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.DateMailedToClient)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.DateMailedToClient, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.DateMailedToClient)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.CancelDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CancelDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.CancelDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.CancelDate, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.CancelDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.EffectiveDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EffectiveDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.EffectiveDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.EffectiveDate, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.EffectiveDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.CurrencyCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrencyCode As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.CurrencyCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.CurrencyCode, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.CurrencyCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PD_Building
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDBuilding As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDBuilding)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDBuilding, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PDBuilding)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PD_Equipment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDEquipment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDEquipment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDEquipment, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PDEquipment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PD_Finished
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDFinished As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDFinished)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDFinished, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PDFinished)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PD_RawStock
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDRawStock As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDRawStock)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDRawStock, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PDRawStock)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PD_BuildersRisk
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDBuildersRisk As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDBuildersRisk)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDBuildersRisk, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PDBuildersRisk)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PD_Misc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDMisc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDMisc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDMisc, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PDMisc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PD_Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDTotal As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDTotal)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.PDTotal, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PDTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.BI_GrossProfit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIGrossProfit As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BIGrossProfit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BIGrossProfit, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.BIGrossProfit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.BI_WageExtraExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIWageExtraExp As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BIWageExtraExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BIWageExtraExp, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.BIWageExtraExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.BI_Misc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIMisc As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BIMisc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BIMisc, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.BIMisc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.BI_Other
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIOther As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BIOther)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BIOther, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.BIOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.BI_Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BITotal As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BITotal)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.BITotal, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.BITotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.GrossProfitIndemnity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GrossProfitIndemnity As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationInspectionBMMetadata.ColumnNames.GrossProfitIndemnity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationInspectionBMMetadata.ColumnNames.GrossProfitIndemnity, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.GrossProfitIndemnity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.WagesExtraExpIndem
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WagesExtraExpIndem As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationInspectionBMMetadata.ColumnNames.WagesExtraExpIndem)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationInspectionBMMetadata.ColumnNames.WagesExtraExpIndem, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.WagesExtraExpIndem)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.TotalUS_PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSPD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.TotalUSPD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.TotalUSPD, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.TotalUSPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.TotalUS_BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSBI As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.TotalUSBI)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.TotalUSBI, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.TotalUSBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.LocalTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocalTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.LocalTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.LocalTIV, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.LocalTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.PERCENTUSTOT100
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Percentustot100 As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationInspectionBMMetadata.ColumnNames.Percentustot100)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationInspectionBMMetadata.ColumnNames.Percentustot100, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.Percentustot100)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.InspDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationInspectionBMMetadata.ColumnNames.InspDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationInspectionBMMetadata.ColumnNames.InspDue, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.InspDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.EngTargetMo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngTargetMo As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.EngTargetMo)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationInspectionBMMetadata.ColumnNames.EngTargetMo, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.EngTargetMo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationInspectionBM.Inspection Type
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.InspectionType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationInspectionBMMetadata.ColumnNames.InspectionType, value) Then
					OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.InspectionType)
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
												
						Case "NextInspYr"
							Me.str().NextInspYr = CType(value, string)
												
						Case "InspRemaining"
							Me.str().InspRemaining = CType(value, string)
												
						Case "InspectionStatus"
							Me.str().InspectionStatus = CType(value, string)
												
						Case "LocationStatus"
							Me.str().LocationStatus = CType(value, string)
												
						Case "ContractYr"
							Me.str().ContractYr = CType(value, string)
												
						Case "Frequency"
							Me.str().Frequency = CType(value, string)
												
						Case "ClientTargetMo"
							Me.str().ClientTargetMo = CType(value, string)
												
						Case "DateCompleted"
							Me.str().DateCompleted = CType(value, string)
												
						Case "DateMailedToClient"
							Me.str().DateMailedToClient = CType(value, string)
												
						Case "CancelDate"
							Me.str().CancelDate = CType(value, string)
												
						Case "EffectiveDate"
							Me.str().EffectiveDate = CType(value, string)
												
						Case "CurrencyCode"
							Me.str().CurrencyCode = CType(value, string)
												
						Case "Engineer"
							Me.str().Engineer = CType(value, string)
												
						Case "PDBuilding"
							Me.str().PDBuilding = CType(value, string)
												
						Case "PDEquipment"
							Me.str().PDEquipment = CType(value, string)
												
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
												
						Case "EngTargetMo"
							Me.str().EngTargetMo = CType(value, string)
												
						Case "InspectionType"
							Me.str().InspectionType = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "NextInspYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NextInspYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.NextInspYr)
							End If
						
						Case "InspRemaining"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspRemaining = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.InspRemaining)
							End If
						
						Case "ContractYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.ContractYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.ContractYr)
							End If
						
						Case "ClientTargetMo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ClientTargetMo = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.ClientTargetMo)
							End If
						
						Case "DateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.DateCompleted)
							End If
						
						Case "DateMailedToClient"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateMailedToClient = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.DateMailedToClient)
							End If
						
						Case "CancelDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CancelDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.CancelDate)
							End If
						
						Case "EffectiveDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EffectiveDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.EffectiveDate)
							End If
						
						Case "GrossProfitIndemnity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.GrossProfitIndemnity = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.GrossProfitIndemnity)
							End If
						
						Case "WagesExtraExpIndem"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.WagesExtraExpIndem = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.WagesExtraExpIndem)
							End If
						
						Case "Percentustot100"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Percentustot100 = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.Percentustot100)
							End If
						
						Case "InspDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.InspDue)
							End If
						
						Case "EngTargetMo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EngTargetMo = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationInspectionBMMetadata.PropertyNames.EngTargetMo)
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
		
			Public Sub New(ByVal entity As esViewCCLocationInspectionBM)
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
		  	
			Public Property InspectionType As System.String 
				Get
					Dim data_ As System.String = entity.InspectionType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionType = Nothing
					Else
						entity.InspectionType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCLocationInspectionBM
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationInspectionBMMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationInspectionBMQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationInspectionBMQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationInspectionBMQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationInspectionBMQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationInspectionBMQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationInspectionBMCollection
		Inherits esEntityCollection(Of ViewCCLocationInspectionBM)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationInspectionBMMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationInspectionBMCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationInspectionBMQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationInspectionBMQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationInspectionBMQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationInspectionBMQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationInspectionBMQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationInspectionBMQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationInspectionBMQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationInspectionBMQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationInspectionBMMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "NextInspYr" 
					Return Me.NextInspYr
				Case "InspRemaining" 
					Return Me.InspRemaining
				Case "InspectionStatus" 
					Return Me.InspectionStatus
				Case "LocationStatus" 
					Return Me.LocationStatus
				Case "ContractYr" 
					Return Me.ContractYr
				Case "Frequency" 
					Return Me.Frequency
				Case "ClientTargetMo" 
					Return Me.ClientTargetMo
				Case "DateCompleted" 
					Return Me.DateCompleted
				Case "DateMailedToClient" 
					Return Me.DateMailedToClient
				Case "CancelDate" 
					Return Me.CancelDate
				Case "EffectiveDate" 
					Return Me.EffectiveDate
				Case "CurrencyCode" 
					Return Me.CurrencyCode
				Case "Engineer" 
					Return Me.Engineer
				Case "PDBuilding" 
					Return Me.PDBuilding
				Case "PDEquipment" 
					Return Me.PDEquipment
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
				Case "EngTargetMo" 
					Return Me.EngTargetMo
				Case "InspectionType" 
					Return Me.InspectionType
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property NextInspYr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.NextInspYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property InspRemaining As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.InspRemaining, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.InspectionStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.LocationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContractYr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.ContractYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Frequency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.Frequency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientTargetMo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.ClientTargetMo, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.DateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateMailedToClient As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.DateMailedToClient, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CancelDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.CancelDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property EffectiveDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.EffectiveDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CurrencyCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.CurrencyCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDBuilding As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.PDBuilding, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDEquipment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.PDEquipment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDFinished As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.PDFinished, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDRawStock As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.PDRawStock, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDBuildersRisk As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.PDBuildersRisk, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDMisc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.PDMisc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.PDTotal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIGrossProfit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.BIGrossProfit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIWageExtraExp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.BIWageExtraExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIMisc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.BIMisc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIOther As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.BIOther, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BITotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.BITotal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GrossProfitIndemnity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.GrossProfitIndemnity, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property WagesExtraExpIndem As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.WagesExtraExpIndem, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.TotalUSPD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.TotalUSBI, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocalTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.LocalTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Percentustot100 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.Percentustot100, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property InspDue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.InspDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EngTargetMo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.EngTargetMo, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationInspectionBMMetadata.ColumnNames.InspectionType, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationInspectionBMMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.PracticeCode, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.NextInspYr, 2, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.NextInspYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.InspRemaining, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.InspRemaining
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.InspectionStatus, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.InspectionStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.LocationStatus, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.LocationStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.ContractYr, 6, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.ContractYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.Frequency, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.Frequency
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.ClientTargetMo, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.ClientTargetMo
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.DateCompleted, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.DateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.DateMailedToClient, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.DateMailedToClient
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.CancelDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.CancelDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.EffectiveDate, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.EffectiveDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.CurrencyCode, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.CurrencyCode
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.Engineer, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.PDBuilding, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.PDBuilding
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.PDEquipment, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.PDEquipment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.PDFinished, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.PDFinished
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.PDRawStock, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.PDRawStock
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.PDBuildersRisk, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.PDBuildersRisk
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.PDMisc, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.PDMisc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.PDTotal, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.PDTotal
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.BIGrossProfit, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.BIGrossProfit
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.BIWageExtraExp, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.BIWageExtraExp
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.BIMisc, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.BIMisc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.BIOther, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.BIOther
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.BITotal, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.BITotal
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.GrossProfitIndemnity, 27, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.GrossProfitIndemnity
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.WagesExtraExpIndem, 28, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.WagesExtraExpIndem
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.TotalUSPD, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.TotalUSPD
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.TotalUSBI, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.TotalUSBI
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.LocalTIV, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.LocalTIV
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.Percentustot100, 32, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.Percentustot100
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.InspDue, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.InspDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.EngTargetMo, 34, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.EngTargetMo
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationInspectionBMMetadata.ColumnNames.InspectionType, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationInspectionBMMetadata.PropertyNames.InspectionType
			c.CharacterMaxLength = 18
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationInspectionBMMetadata
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
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const InspRemaining As String = "InspRemaining"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const ContractYr As String = "ContractYr"
			 Public Const Frequency As String = "Frequency"
			 Public Const ClientTargetMo As String = "ClientTargetMo"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const DateMailedToClient As String = "DateMailedToClient"
			 Public Const CancelDate As String = "CancelDate"
			 Public Const EffectiveDate As String = "EffectiveDate"
			 Public Const CurrencyCode As String = "CurrencyCode"
			 Public Const Engineer As String = "Engineer"
			 Public Const PDBuilding As String = "PD_Building"
			 Public Const PDEquipment As String = "PD_Equipment"
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
			 Public Const EngTargetMo As String = "EngTargetMo"
			 Public Const InspectionType As String = "Inspection Type"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const InspRemaining As String = "InspRemaining"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const ContractYr As String = "ContractYr"
			 Public Const Frequency As String = "Frequency"
			 Public Const ClientTargetMo As String = "ClientTargetMo"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const DateMailedToClient As String = "DateMailedToClient"
			 Public Const CancelDate As String = "CancelDate"
			 Public Const EffectiveDate As String = "EffectiveDate"
			 Public Const CurrencyCode As String = "CurrencyCode"
			 Public Const Engineer As String = "Engineer"
			 Public Const PDBuilding As String = "PDBuilding"
			 Public Const PDEquipment As String = "PDEquipment"
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
			 Public Const EngTargetMo As String = "EngTargetMo"
			 Public Const InspectionType As String = "InspectionType"
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
			SyncLock GetType(ViewCCLocationInspectionBMMetadata)
			
				If ViewCCLocationInspectionBMMetadata.mapDelegates Is Nothing Then
					ViewCCLocationInspectionBMMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationInspectionBMMetadata._meta Is Nothing Then
					ViewCCLocationInspectionBMMetadata._meta = New ViewCCLocationInspectionBMMetadata()
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
				meta.AddTypeMap("NextInspYr", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("InspRemaining", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InspectionStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ContractYr", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Frequency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ClientTargetMo", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("DateCompleted", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("DateMailedToClient", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("CancelDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("EffectiveDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("CurrencyCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Engineer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDBuilding", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDEquipment", new esTypeMap("nvarchar", "System.String"))
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
				meta.AddTypeMap("EngTargetMo", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("InspectionType", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCLocationInspectionBM"
				meta.Destination = "viewCCLocationInspectionBM"
				
				meta.spInsert = "proc_viewCCLocationInspectionBMInsert"
				meta.spUpdate = "proc_viewCCLocationInspectionBMUpdate"
				meta.spDelete = "proc_viewCCLocationInspectionBMDelete"
				meta.spLoadAll = "proc_viewCCLocationInspectionBMLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationInspectionBMLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationInspectionBMMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
