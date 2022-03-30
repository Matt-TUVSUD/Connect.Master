
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
	' Encapsulates the 'vwFireFacilityRatingSummary' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwFireFacilityRatingSummary))> _
	<XmlType("VwFireFacilityRatingSummary")> _	
	Partial Public Class VwFireFacilityRatingSummary 
		Inherits esVwFireFacilityRatingSummary
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwFireFacilityRatingSummary()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwFireFacilityRatingSummaryCollection")> _
	Partial Public Class VwFireFacilityRatingSummaryCollection
		Inherits esVwFireFacilityRatingSummaryCollection
		Implements IEnumerable(Of VwFireFacilityRatingSummary)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwFireFacilityRatingSummary))> _
		Public Class VwFireFacilityRatingSummaryCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwFireFacilityRatingSummaryCollection)
			
			Public Shared Widening Operator CType(packet As VwFireFacilityRatingSummaryCollectionWCFPacket) As VwFireFacilityRatingSummaryCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwFireFacilityRatingSummaryCollection) As VwFireFacilityRatingSummaryCollectionWCFPacket
				Return New VwFireFacilityRatingSummaryCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwFireFacilityRatingSummaryQuery 
		Inherits esVwFireFacilityRatingSummaryQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwFireFacilityRatingSummaryQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwFireFacilityRatingSummaryQuery) As String
			Return VwFireFacilityRatingSummaryQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwFireFacilityRatingSummaryQuery
			Return DirectCast(VwFireFacilityRatingSummaryQuery.SerializeHelper.FromXml(query, GetType(VwFireFacilityRatingSummaryQuery)), VwFireFacilityRatingSummaryQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwFireFacilityRatingSummary
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(VwFireFacilityRatingSummaryMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(VwFireFacilityRatingSummaryMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireFacilityRatingSummaryMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireFacilityRatingSummaryMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Apl As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.Apl)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.Apl, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Apl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLAustralian, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLBritish, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLCanadian, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLEuro, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLJapanese, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLMexican, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLNewZealand, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.Aplus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.Aplus, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Aplus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLFactor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLFactor As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLFactor)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLFactor, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLFactor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsComplete, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsCompleteAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsCompleteAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteAustralian, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsCompleteBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsCompleteBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteBritish, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsCompleteCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsCompleteCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteCanadian, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsCompleteEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsCompleteEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteEuro, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsCompleteJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsCompleteJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteJapanese, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsCompleteMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsCompleteMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteMexican, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsCompleteNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsCompleteNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteNewZealand, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLWithAllRecsCompleteUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsCompleteUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteUS, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.APLFactorWithAllRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLFactorWithAllRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLFactorWithAllRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLFactorWithAllRecsComplete, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLFactorWithAllRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.PassiveScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PassiveScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.PassiveScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.PassiveScore, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.PassiveScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.ActiveScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.ActiveScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.ActiveScore, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.ActiveScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.ActiveScoreWithRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveScoreWithRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.ActiveScoreWithRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.ActiveScoreWithRecsComplete, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.ActiveScoreWithRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.TotalScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.TotalScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.TotalScore, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TotalScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.OverallPlantRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallPlantRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallPlantRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallPlantRating, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.OverallPlantRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.OverallScoreWithRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallScoreWithRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallScoreWithRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallScoreWithRecsComplete, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.OverallScoreWithRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.OverallPlantRatingWithRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallPlantRatingWithRecsComplete As System.String
			Get
				Return MyBase.GetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallPlantRatingWithRecsComplete)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallPlantRatingWithRecsComplete, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.OverallPlantRatingWithRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.InspectionDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDateMonth, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireFacilityRatingSummary.InspectionDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDateYear, value) Then
					OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDateYear)
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
												
						Case "APLFactor"
							Me.str().APLFactor = CType(value, string)
												
						Case "APLWithAllRecsComplete"
							Me.str().APLWithAllRecsComplete = CType(value, string)
												
						Case "APLWithAllRecsCompleteAustralian"
							Me.str().APLWithAllRecsCompleteAustralian = CType(value, string)
												
						Case "APLWithAllRecsCompleteBritish"
							Me.str().APLWithAllRecsCompleteBritish = CType(value, string)
												
						Case "APLWithAllRecsCompleteCanadian"
							Me.str().APLWithAllRecsCompleteCanadian = CType(value, string)
												
						Case "APLWithAllRecsCompleteEuro"
							Me.str().APLWithAllRecsCompleteEuro = CType(value, string)
												
						Case "APLWithAllRecsCompleteJapanese"
							Me.str().APLWithAllRecsCompleteJapanese = CType(value, string)
												
						Case "APLWithAllRecsCompleteMexican"
							Me.str().APLWithAllRecsCompleteMexican = CType(value, string)
												
						Case "APLWithAllRecsCompleteNewZealand"
							Me.str().APLWithAllRecsCompleteNewZealand = CType(value, string)
												
						Case "APLWithAllRecsCompleteUS"
							Me.str().APLWithAllRecsCompleteUS = CType(value, string)
												
						Case "APLFactorWithAllRecsComplete"
							Me.str().APLFactorWithAllRecsComplete = CType(value, string)
												
						Case "PassiveScore"
							Me.str().PassiveScore = CType(value, string)
												
						Case "ActiveScore"
							Me.str().ActiveScore = CType(value, string)
												
						Case "ActiveScoreWithRecsComplete"
							Me.str().ActiveScoreWithRecsComplete = CType(value, string)
												
						Case "TotalScore"
							Me.str().TotalScore = CType(value, string)
												
						Case "OverallPlantRating"
							Me.str().OverallPlantRating = CType(value, string)
												
						Case "OverallScoreWithRecsComplete"
							Me.str().OverallScoreWithRecsComplete = CType(value, string)
												
						Case "OverallPlantRatingWithRecsComplete"
							Me.str().OverallPlantRatingWithRecsComplete = CType(value, string)
												
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
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Tivus)
							End If
						
						Case "Apl"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Apl = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Apl)
							End If
						
						Case "APLAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLAustralian)
							End If
						
						Case "APLBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLBritish)
							End If
						
						Case "APLCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLCanadian)
							End If
						
						Case "APLEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLEuro)
							End If
						
						Case "APLJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLJapanese)
							End If
						
						Case "APLMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLMexican)
							End If
						
						Case "APLNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLNewZealand)
							End If
						
						Case "Aplus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Aplus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.Aplus)
							End If
						
						Case "APLFactor"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLFactor = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLFactor)
							End If
						
						Case "APLWithAllRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLWithAllRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsComplete)
							End If
						
						Case "APLWithAllRecsCompleteAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLWithAllRecsCompleteAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteAustralian)
							End If
						
						Case "APLWithAllRecsCompleteBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLWithAllRecsCompleteBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteBritish)
							End If
						
						Case "APLWithAllRecsCompleteCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLWithAllRecsCompleteCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteCanadian)
							End If
						
						Case "APLWithAllRecsCompleteEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLWithAllRecsCompleteEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteEuro)
							End If
						
						Case "APLWithAllRecsCompleteJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLWithAllRecsCompleteJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteJapanese)
							End If
						
						Case "APLWithAllRecsCompleteMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLWithAllRecsCompleteMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteMexican)
							End If
						
						Case "APLWithAllRecsCompleteNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLWithAllRecsCompleteNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteNewZealand)
							End If
						
						Case "APLWithAllRecsCompleteUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.APLWithAllRecsCompleteUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteUS)
							End If
						
						Case "APLFactorWithAllRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLFactorWithAllRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.APLFactorWithAllRecsComplete)
							End If
						
						Case "PassiveScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PassiveScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.PassiveScore)
							End If
						
						Case "ActiveScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ActiveScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.ActiveScore)
							End If
						
						Case "ActiveScoreWithRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ActiveScoreWithRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.ActiveScoreWithRecsComplete)
							End If
						
						Case "TotalScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.TotalScore)
							End If
						
						Case "OverallScoreWithRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OverallScoreWithRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.OverallScoreWithRecsComplete)
							End If
						
						Case "InspectionDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspectionDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDateMonth)
							End If
						
						Case "InspectionDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspectionDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDateYear)
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
		
			Public Sub New(ByVal entity As esVwFireFacilityRatingSummary)
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
		  	
			Public Property Apl As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Apl
					
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
						entity.Apl = Convert.ToDecimal(Value)
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
		  	
			Public Property APLFactor As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLFactor
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLFactor = Nothing
					Else
						entity.APLFactor = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLWithAllRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsComplete = Nothing
					Else
						entity.APLWithAllRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsCompleteAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLWithAllRecsCompleteAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsCompleteAustralian = Nothing
					Else
						entity.APLWithAllRecsCompleteAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsCompleteBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLWithAllRecsCompleteBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsCompleteBritish = Nothing
					Else
						entity.APLWithAllRecsCompleteBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsCompleteCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLWithAllRecsCompleteCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsCompleteCanadian = Nothing
					Else
						entity.APLWithAllRecsCompleteCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsCompleteEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLWithAllRecsCompleteEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsCompleteEuro = Nothing
					Else
						entity.APLWithAllRecsCompleteEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsCompleteJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLWithAllRecsCompleteJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsCompleteJapanese = Nothing
					Else
						entity.APLWithAllRecsCompleteJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsCompleteMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLWithAllRecsCompleteMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsCompleteMexican = Nothing
					Else
						entity.APLWithAllRecsCompleteMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsCompleteNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLWithAllRecsCompleteNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsCompleteNewZealand = Nothing
					Else
						entity.APLWithAllRecsCompleteNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsCompleteUS As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.APLWithAllRecsCompleteUS
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsCompleteUS = Nothing
					Else
						entity.APLWithAllRecsCompleteUS = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLFactorWithAllRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLFactorWithAllRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLFactorWithAllRecsComplete = Nothing
					Else
						entity.APLFactorWithAllRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PassiveScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PassiveScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PassiveScore = Nothing
					Else
						entity.PassiveScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ActiveScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveScore = Nothing
					Else
						entity.ActiveScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveScoreWithRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ActiveScoreWithRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveScoreWithRecsComplete = Nothing
					Else
						entity.ActiveScoreWithRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalScore = Nothing
					Else
						entity.TotalScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallPlantRating As System.String 
				Get
					Dim data_ As System.String = entity.OverallPlantRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallPlantRating = Nothing
					Else
						entity.OverallPlantRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallScoreWithRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OverallScoreWithRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallScoreWithRecsComplete = Nothing
					Else
						entity.OverallScoreWithRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallPlantRatingWithRecsComplete As System.String 
				Get
					Dim data_ As System.String = entity.OverallPlantRatingWithRecsComplete
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallPlantRatingWithRecsComplete = Nothing
					Else
						entity.OverallPlantRatingWithRecsComplete = Convert.ToString(Value)
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
		  

			Private entity As esVwFireFacilityRatingSummary
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireFacilityRatingSummaryMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwFireFacilityRatingSummaryQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireFacilityRatingSummaryQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwFireFacilityRatingSummaryQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwFireFacilityRatingSummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwFireFacilityRatingSummaryQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwFireFacilityRatingSummaryCollection
		Inherits esEntityCollection(Of VwFireFacilityRatingSummary)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireFacilityRatingSummaryMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwFireFacilityRatingSummaryCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwFireFacilityRatingSummaryQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireFacilityRatingSummaryQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwFireFacilityRatingSummaryQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwFireFacilityRatingSummaryQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwFireFacilityRatingSummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwFireFacilityRatingSummaryQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwFireFacilityRatingSummaryQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwFireFacilityRatingSummaryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwFireFacilityRatingSummaryMetadata.Meta()
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
				Case "APLFactor" 
					Return Me.APLFactor
				Case "APLWithAllRecsComplete" 
					Return Me.APLWithAllRecsComplete
				Case "APLWithAllRecsCompleteAustralian" 
					Return Me.APLWithAllRecsCompleteAustralian
				Case "APLWithAllRecsCompleteBritish" 
					Return Me.APLWithAllRecsCompleteBritish
				Case "APLWithAllRecsCompleteCanadian" 
					Return Me.APLWithAllRecsCompleteCanadian
				Case "APLWithAllRecsCompleteEuro" 
					Return Me.APLWithAllRecsCompleteEuro
				Case "APLWithAllRecsCompleteJapanese" 
					Return Me.APLWithAllRecsCompleteJapanese
				Case "APLWithAllRecsCompleteMexican" 
					Return Me.APLWithAllRecsCompleteMexican
				Case "APLWithAllRecsCompleteNewZealand" 
					Return Me.APLWithAllRecsCompleteNewZealand
				Case "APLWithAllRecsCompleteUS" 
					Return Me.APLWithAllRecsCompleteUS
				Case "APLFactorWithAllRecsComplete" 
					Return Me.APLFactorWithAllRecsComplete
				Case "PassiveScore" 
					Return Me.PassiveScore
				Case "ActiveScore" 
					Return Me.ActiveScore
				Case "ActiveScoreWithRecsComplete" 
					Return Me.ActiveScoreWithRecsComplete
				Case "TotalScore" 
					Return Me.TotalScore
				Case "OverallPlantRating" 
					Return Me.OverallPlantRating
				Case "OverallScoreWithRecsComplete" 
					Return Me.OverallScoreWithRecsComplete
				Case "OverallPlantRatingWithRecsComplete" 
					Return Me.OverallPlantRatingWithRecsComplete
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
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Apl As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.Apl, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Aplus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.Aplus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLFactor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLFactor, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsCompleteAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsCompleteBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsCompleteCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsCompleteEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsCompleteJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsCompleteMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsCompleteNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsCompleteUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property APLFactorWithAllRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.APLFactorWithAllRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PassiveScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.PassiveScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.ActiveScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveScoreWithRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.ActiveScoreWithRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.TotalScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OverallPlantRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallPlantRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverallScoreWithRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallScoreWithRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OverallPlantRatingWithRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallPlantRatingWithRecsComplete, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDateYear, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwFireFacilityRatingSummaryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.FilePrefix, 0, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.CustomAccess, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.Facility, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.Address, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.City, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.StProv, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.Country, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames._100PercentUSTot, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVAustralian, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVBritish, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVCanadian, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVEuro, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVJapanese, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVMexican, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.TIVNewZealand, 19, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.Tivus, 20, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.Apl, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.Apl
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLAustralian, 22, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLBritish, 23, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLCanadian, 24, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLEuro, 25, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLJapanese, 26, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLMexican, 27, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLNewZealand, 28, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.Aplus, 29, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.Aplus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLFactor, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLFactor
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsComplete, 31, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteAustralian, 32, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteBritish, 33, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteCanadian, 34, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteEuro, 35, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteJapanese, 36, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteMexican, 37, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteNewZealand, 38, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLWithAllRecsCompleteUS, 39, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLWithAllRecsCompleteUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.APLFactorWithAllRecsComplete, 40, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.APLFactorWithAllRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.PassiveScore, 41, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.PassiveScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.ActiveScore, 42, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.ActiveScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.ActiveScoreWithRecsComplete, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.ActiveScoreWithRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.TotalScore, 44, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.TotalScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallPlantRating, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.OverallPlantRating
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallScoreWithRecsComplete, 46, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.OverallScoreWithRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.OverallPlantRatingWithRecsComplete, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.OverallPlantRatingWithRecsComplete
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDateMonth, 48, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireFacilityRatingSummaryMetadata.ColumnNames.InspectionDateYear, 49, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireFacilityRatingSummaryMetadata.PropertyNames.InspectionDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwFireFacilityRatingSummaryMetadata
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
			 Public Const Apl As String = "APL"
			 Public Const APLAustralian As String = "APLAustralian"
			 Public Const APLBritish As String = "APLBritish"
			 Public Const APLCanadian As String = "APLCanadian"
			 Public Const APLEuro As String = "APLEuro"
			 Public Const APLJapanese As String = "APLJapanese"
			 Public Const APLMexican As String = "APLMexican"
			 Public Const APLNewZealand As String = "APLNewZealand"
			 Public Const Aplus As String = "APLUS"
			 Public Const APLFactor As String = "APLFactor"
			 Public Const APLWithAllRecsComplete As String = "APLWithAllRecsComplete"
			 Public Const APLWithAllRecsCompleteAustralian As String = "APLWithAllRecsCompleteAustralian"
			 Public Const APLWithAllRecsCompleteBritish As String = "APLWithAllRecsCompleteBritish"
			 Public Const APLWithAllRecsCompleteCanadian As String = "APLWithAllRecsCompleteCanadian"
			 Public Const APLWithAllRecsCompleteEuro As String = "APLWithAllRecsCompleteEuro"
			 Public Const APLWithAllRecsCompleteJapanese As String = "APLWithAllRecsCompleteJapanese"
			 Public Const APLWithAllRecsCompleteMexican As String = "APLWithAllRecsCompleteMexican"
			 Public Const APLWithAllRecsCompleteNewZealand As String = "APLWithAllRecsCompleteNewZealand"
			 Public Const APLWithAllRecsCompleteUS As String = "APLWithAllRecsCompleteUS"
			 Public Const APLFactorWithAllRecsComplete As String = "APLFactorWithAllRecsComplete"
			 Public Const PassiveScore As String = "PassiveScore"
			 Public Const ActiveScore As String = "ActiveScore"
			 Public Const ActiveScoreWithRecsComplete As String = "ActiveScoreWithRecsComplete"
			 Public Const TotalScore As String = "TotalScore"
			 Public Const OverallPlantRating As String = "OverallPlantRating"
			 Public Const OverallScoreWithRecsComplete As String = "OverallScoreWithRecsComplete"
			 Public Const OverallPlantRatingWithRecsComplete As String = "OverallPlantRatingWithRecsComplete"
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
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Facility As String = "Facility"
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
			 Public Const Apl As String = "Apl"
			 Public Const APLAustralian As String = "APLAustralian"
			 Public Const APLBritish As String = "APLBritish"
			 Public Const APLCanadian As String = "APLCanadian"
			 Public Const APLEuro As String = "APLEuro"
			 Public Const APLJapanese As String = "APLJapanese"
			 Public Const APLMexican As String = "APLMexican"
			 Public Const APLNewZealand As String = "APLNewZealand"
			 Public Const Aplus As String = "Aplus"
			 Public Const APLFactor As String = "APLFactor"
			 Public Const APLWithAllRecsComplete As String = "APLWithAllRecsComplete"
			 Public Const APLWithAllRecsCompleteAustralian As String = "APLWithAllRecsCompleteAustralian"
			 Public Const APLWithAllRecsCompleteBritish As String = "APLWithAllRecsCompleteBritish"
			 Public Const APLWithAllRecsCompleteCanadian As String = "APLWithAllRecsCompleteCanadian"
			 Public Const APLWithAllRecsCompleteEuro As String = "APLWithAllRecsCompleteEuro"
			 Public Const APLWithAllRecsCompleteJapanese As String = "APLWithAllRecsCompleteJapanese"
			 Public Const APLWithAllRecsCompleteMexican As String = "APLWithAllRecsCompleteMexican"
			 Public Const APLWithAllRecsCompleteNewZealand As String = "APLWithAllRecsCompleteNewZealand"
			 Public Const APLWithAllRecsCompleteUS As String = "APLWithAllRecsCompleteUS"
			 Public Const APLFactorWithAllRecsComplete As String = "APLFactorWithAllRecsComplete"
			 Public Const PassiveScore As String = "PassiveScore"
			 Public Const ActiveScore As String = "ActiveScore"
			 Public Const ActiveScoreWithRecsComplete As String = "ActiveScoreWithRecsComplete"
			 Public Const TotalScore As String = "TotalScore"
			 Public Const OverallPlantRating As String = "OverallPlantRating"
			 Public Const OverallScoreWithRecsComplete As String = "OverallScoreWithRecsComplete"
			 Public Const OverallPlantRatingWithRecsComplete As String = "OverallPlantRatingWithRecsComplete"
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
			SyncLock GetType(VwFireFacilityRatingSummaryMetadata)
			
				If VwFireFacilityRatingSummaryMetadata.mapDelegates Is Nothing Then
					VwFireFacilityRatingSummaryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwFireFacilityRatingSummaryMetadata._meta Is Nothing Then
					VwFireFacilityRatingSummaryMetadata._meta = New VwFireFacilityRatingSummaryMetadata()
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
				meta.AddTypeMap("Apl", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Aplus", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLFactor", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLWithAllRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLWithAllRecsCompleteAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLWithAllRecsCompleteBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLWithAllRecsCompleteCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLWithAllRecsCompleteEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLWithAllRecsCompleteJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLWithAllRecsCompleteMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLWithAllRecsCompleteNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLWithAllRecsCompleteUS", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("APLFactorWithAllRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("PassiveScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ActiveScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ActiveScoreWithRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("TotalScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OverallPlantRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OverallScoreWithRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OverallPlantRatingWithRecsComplete", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("InspectionDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InspectionDateYear", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "vwFireFacilityRatingSummary"
				meta.Destination = "vwFireFacilityRatingSummary"
				
				meta.spInsert = "proc_vwFireFacilityRatingSummaryInsert"
				meta.spUpdate = "proc_vwFireFacilityRatingSummaryUpdate"
				meta.spDelete = "proc_vwFireFacilityRatingSummaryDelete"
				meta.spLoadAll = "proc_vwFireFacilityRatingSummaryLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwFireFacilityRatingSummaryLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwFireFacilityRatingSummaryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
