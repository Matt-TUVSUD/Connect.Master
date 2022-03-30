
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/9/2013 10:35:18 PM
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
	' Encapsulates the 'vwNatHazFloodRecommendationResponsesFollowUp' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwNatHazFloodRecommendationResponsesFollowUp))> _
	<XmlType("VwNatHazFloodRecommendationResponsesFollowUp")> _	
	Partial Public Class VwNatHazFloodRecommendationResponsesFollowUp 
		Inherits esVwNatHazFloodRecommendationResponsesFollowUp
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwNatHazFloodRecommendationResponsesFollowUp()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwNatHazFloodRecommendationResponsesFollowUpCollection")> _
	Partial Public Class VwNatHazFloodRecommendationResponsesFollowUpCollection
		Inherits esVwNatHazFloodRecommendationResponsesFollowUpCollection
		Implements IEnumerable(Of VwNatHazFloodRecommendationResponsesFollowUp)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwNatHazFloodRecommendationResponsesFollowUp))> _
		Public Class VwNatHazFloodRecommendationResponsesFollowUpCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwNatHazFloodRecommendationResponsesFollowUpCollection)
			
			Public Shared Widening Operator CType(packet As VwNatHazFloodRecommendationResponsesFollowUpCollectionWCFPacket) As VwNatHazFloodRecommendationResponsesFollowUpCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwNatHazFloodRecommendationResponsesFollowUpCollection) As VwNatHazFloodRecommendationResponsesFollowUpCollectionWCFPacket
				Return New VwNatHazFloodRecommendationResponsesFollowUpCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwNatHazFloodRecommendationResponsesFollowUpQuery 
		Inherits esVwNatHazFloodRecommendationResponsesFollowUpQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwNatHazFloodRecommendationResponsesFollowUpQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwNatHazFloodRecommendationResponsesFollowUpQuery) As String
			Return VwNatHazFloodRecommendationResponsesFollowUpQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwNatHazFloodRecommendationResponsesFollowUpQuery
			Return DirectCast(VwNatHazFloodRecommendationResponsesFollowUpQuery.SerializeHelper.FromXml(query, GetType(VwNatHazFloodRecommendationResponsesFollowUpQuery)), VwNatHazFloodRecommendationResponsesFollowUpQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwNatHazFloodRecommendationResponsesFollowUp
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.ResponseStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatus As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.ResponseStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.ResponseStatus, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.ResponseStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.AutoRequest
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AutoRequest As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.AutoRequest)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.AutoRequest, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.AutoRequest)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.LastInspDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastInspDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.LastInspDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.LastInspDate, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.LastInspDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RespRequestDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDate, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.TotalNoRecs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalNoRecs As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TotalNoRecs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TotalNoRecs, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TotalNoRecs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.NoActiveRecs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoActiveRecs As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.NoActiveRecs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.NoActiveRecs, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.NoActiveRecs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.NoRecsNeedingResp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoRecsNeedingResp As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.NoRecsNeedingResp)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.NoRecsNeedingResp, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.NoRecsNeedingResp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RespDueDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDate, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.DaysOverdue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DaysOverdue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.DaysOverdue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.DaysOverdue, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.DaysOverdue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU1Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1Date, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU2Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2Date, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU3Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3Date, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientName As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RecipientName, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RecipientEmail, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RespRequestDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateMonth, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RespRequestDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateYear, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RespDueDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateMonth, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RespDueDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateYear, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU1DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateMonth, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU1DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateYear, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU2DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateMonth, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU2DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateYear, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU3DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateMonth, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU3DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateYear, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RespRequestDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateString, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RespDueDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateString, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU1DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateString, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU2DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateString, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazFloodRecommendationResponsesFollowUp.RFU3DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateString, value) Then
					OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3DateString)
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
												
						Case "ResponseStatus"
							Me.str().ResponseStatus = CType(value, string)
												
						Case "AutoRequest"
							Me.str().AutoRequest = CType(value, string)
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "LastInspDate"
							Me.str().LastInspDate = CType(value, string)
												
						Case "RespRequestDate"
							Me.str().RespRequestDate = CType(value, string)
												
						Case "TotalNoRecs"
							Me.str().TotalNoRecs = CType(value, string)
												
						Case "NoActiveRecs"
							Me.str().NoActiveRecs = CType(value, string)
												
						Case "NoRecsNeedingResp"
							Me.str().NoRecsNeedingResp = CType(value, string)
												
						Case "RespDueDate"
							Me.str().RespDueDate = CType(value, string)
												
						Case "DaysOverdue"
							Me.str().DaysOverdue = CType(value, string)
												
						Case "RFU1Date"
							Me.str().RFU1Date = CType(value, string)
												
						Case "RFU2Date"
							Me.str().RFU2Date = CType(value, string)
												
						Case "RFU3Date"
							Me.str().RFU3Date = CType(value, string)
												
						Case "RecipientName"
							Me.str().RecipientName = CType(value, string)
												
						Case "RecipientEmail"
							Me.str().RecipientEmail = CType(value, string)
												
						Case "RespRequestDateMonth"
							Me.str().RespRequestDateMonth = CType(value, string)
												
						Case "RespRequestDateYear"
							Me.str().RespRequestDateYear = CType(value, string)
												
						Case "RespDueDateMonth"
							Me.str().RespDueDateMonth = CType(value, string)
												
						Case "RespDueDateYear"
							Me.str().RespDueDateYear = CType(value, string)
												
						Case "RFU1DateMonth"
							Me.str().RFU1DateMonth = CType(value, string)
												
						Case "RFU1DateYear"
							Me.str().RFU1DateYear = CType(value, string)
												
						Case "RFU2DateMonth"
							Me.str().RFU2DateMonth = CType(value, string)
												
						Case "RFU2DateYear"
							Me.str().RFU2DateYear = CType(value, string)
												
						Case "RFU3DateMonth"
							Me.str().RFU3DateMonth = CType(value, string)
												
						Case "RFU3DateYear"
							Me.str().RFU3DateYear = CType(value, string)
												
						Case "RespRequestDateString"
							Me.str().RespRequestDateString = CType(value, string)
												
						Case "RespDueDateString"
							Me.str().RespDueDateString = CType(value, string)
												
						Case "RFU1DateString"
							Me.str().RFU1DateString = CType(value, string)
												
						Case "RFU2DateString"
							Me.str().RFU2DateString = CType(value, string)
												
						Case "RFU3DateString"
							Me.str().RFU3DateString = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Tivus)
							End If
						
						Case "LastInspDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastInspDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.LastInspDate)
							End If
						
						Case "RespRequestDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespRequestDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDate)
							End If
						
						Case "TotalNoRecs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalNoRecs = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TotalNoRecs)
							End If
						
						Case "NoActiveRecs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NoActiveRecs = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.NoActiveRecs)
							End If
						
						Case "NoRecsNeedingResp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NoRecsNeedingResp = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.NoRecsNeedingResp)
							End If
						
						Case "RespDueDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespDueDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDate)
							End If
						
						Case "DaysOverdue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DaysOverdue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.DaysOverdue)
							End If
						
						Case "RFU1Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU1Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1Date)
							End If
						
						Case "RFU2Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU2Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2Date)
							End If
						
						Case "RFU3Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU3Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3Date)
							End If
						
						Case "RespRequestDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDateMonth)
							End If
						
						Case "RespRequestDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDateYear)
							End If
						
						Case "RespDueDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDateMonth)
							End If
						
						Case "RespDueDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDateYear)
							End If
						
						Case "RFU1DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1DateMonth)
							End If
						
						Case "RFU1DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1DateYear)
							End If
						
						Case "RFU2DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2DateMonth)
							End If
						
						Case "RFU2DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2DateYear)
							End If
						
						Case "RFU3DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3DateMonth)
							End If
						
						Case "RFU3DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3DateYear)
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
		
			Public Sub New(ByVal entity As esVwNatHazFloodRecommendationResponsesFollowUp)
				Me.entity = entity
			End Sub				
		
	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As System.String = entity.FilePrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToString(Value)
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
		  	
			Public Property ResponseStatus As System.String 
				Get
					Dim data_ As System.String = entity.ResponseStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseStatus = Nothing
					Else
						entity.ResponseStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AutoRequest As System.String 
				Get
					Dim data_ As System.String = entity.AutoRequest
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AutoRequest = Nothing
					Else
						entity.AutoRequest = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazard As System.String 
				Get
					Dim data_ As System.String = entity.Hazard
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazard = Nothing
					Else
						entity.Hazard = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastInspDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastInspDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastInspDate = Nothing
					Else
						entity.LastInspDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespRequestDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RespRequestDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespRequestDate = Nothing
					Else
						entity.RespRequestDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalNoRecs As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TotalNoRecs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalNoRecs = Nothing
					Else
						entity.TotalNoRecs = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoActiveRecs As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NoActiveRecs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoActiveRecs = Nothing
					Else
						entity.NoActiveRecs = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoRecsNeedingResp As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NoRecsNeedingResp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoRecsNeedingResp = Nothing
					Else
						entity.NoRecsNeedingResp = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespDueDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RespDueDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespDueDate = Nothing
					Else
						entity.RespDueDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DaysOverdue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.DaysOverdue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DaysOverdue = Nothing
					Else
						entity.DaysOverdue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU1Date As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RFU1Date
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU1Date = Nothing
					Else
						entity.RFU1Date = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU2Date As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RFU2Date
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU2Date = Nothing
					Else
						entity.RFU2Date = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU3Date As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RFU3Date
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU3Date = Nothing
					Else
						entity.RFU3Date = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecipientName As System.String 
				Get
					Dim data_ As System.String = entity.RecipientName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecipientName = Nothing
					Else
						entity.RecipientName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecipientEmail As System.String 
				Get
					Dim data_ As System.String = entity.RecipientEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecipientEmail = Nothing
					Else
						entity.RecipientEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespRequestDateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RespRequestDateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespRequestDateMonth = Nothing
					Else
						entity.RespRequestDateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespRequestDateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RespRequestDateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespRequestDateYear = Nothing
					Else
						entity.RespRequestDateYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespDueDateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RespDueDateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespDueDateMonth = Nothing
					Else
						entity.RespDueDateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespDueDateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RespDueDateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespDueDateYear = Nothing
					Else
						entity.RespDueDateYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU1DateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RFU1DateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU1DateMonth = Nothing
					Else
						entity.RFU1DateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU1DateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RFU1DateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU1DateYear = Nothing
					Else
						entity.RFU1DateYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU2DateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RFU2DateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU2DateMonth = Nothing
					Else
						entity.RFU2DateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU2DateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RFU2DateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU2DateYear = Nothing
					Else
						entity.RFU2DateYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU3DateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RFU3DateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU3DateMonth = Nothing
					Else
						entity.RFU3DateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU3DateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RFU3DateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU3DateYear = Nothing
					Else
						entity.RFU3DateYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespRequestDateString As System.String 
				Get
					Dim data_ As System.String = entity.RespRequestDateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespRequestDateString = Nothing
					Else
						entity.RespRequestDateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespDueDateString As System.String 
				Get
					Dim data_ As System.String = entity.RespDueDateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespDueDateString = Nothing
					Else
						entity.RespDueDateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU1DateString As System.String 
				Get
					Dim data_ As System.String = entity.RFU1DateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU1DateString = Nothing
					Else
						entity.RFU1DateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU2DateString As System.String 
				Get
					Dim data_ As System.String = entity.RFU2DateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU2DateString = Nothing
					Else
						entity.RFU2DateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU3DateString As System.String 
				Get
					Dim data_ As System.String = entity.RFU3DateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU3DateString = Nothing
					Else
						entity.RFU3DateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVwNatHazFloodRecommendationResponsesFollowUp
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwNatHazFloodRecommendationResponsesFollowUpMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwNatHazFloodRecommendationResponsesFollowUpQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwNatHazFloodRecommendationResponsesFollowUpQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwNatHazFloodRecommendationResponsesFollowUpQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwNatHazFloodRecommendationResponsesFollowUpQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwNatHazFloodRecommendationResponsesFollowUpQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwNatHazFloodRecommendationResponsesFollowUpCollection
		Inherits esEntityCollection(Of VwNatHazFloodRecommendationResponsesFollowUp)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwNatHazFloodRecommendationResponsesFollowUpMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwNatHazFloodRecommendationResponsesFollowUpCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwNatHazFloodRecommendationResponsesFollowUpQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwNatHazFloodRecommendationResponsesFollowUpQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwNatHazFloodRecommendationResponsesFollowUpQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwNatHazFloodRecommendationResponsesFollowUpQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwNatHazFloodRecommendationResponsesFollowUpQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwNatHazFloodRecommendationResponsesFollowUpQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwNatHazFloodRecommendationResponsesFollowUpQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwNatHazFloodRecommendationResponsesFollowUpQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwNatHazFloodRecommendationResponsesFollowUpMetadata.Meta()
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
				Case "ResponseStatus" 
					Return Me.ResponseStatus
				Case "AutoRequest" 
					Return Me.AutoRequest
				Case "Hazard" 
					Return Me.Hazard
				Case "LastInspDate" 
					Return Me.LastInspDate
				Case "RespRequestDate" 
					Return Me.RespRequestDate
				Case "TotalNoRecs" 
					Return Me.TotalNoRecs
				Case "NoActiveRecs" 
					Return Me.NoActiveRecs
				Case "NoRecsNeedingResp" 
					Return Me.NoRecsNeedingResp
				Case "RespDueDate" 
					Return Me.RespDueDate
				Case "DaysOverdue" 
					Return Me.DaysOverdue
				Case "RFU1Date" 
					Return Me.RFU1Date
				Case "RFU2Date" 
					Return Me.RFU2Date
				Case "RFU3Date" 
					Return Me.RFU3Date
				Case "RecipientName" 
					Return Me.RecipientName
				Case "RecipientEmail" 
					Return Me.RecipientEmail
				Case "RespRequestDateMonth" 
					Return Me.RespRequestDateMonth
				Case "RespRequestDateYear" 
					Return Me.RespRequestDateYear
				Case "RespDueDateMonth" 
					Return Me.RespDueDateMonth
				Case "RespDueDateYear" 
					Return Me.RespDueDateYear
				Case "RFU1DateMonth" 
					Return Me.RFU1DateMonth
				Case "RFU1DateYear" 
					Return Me.RFU1DateYear
				Case "RFU2DateMonth" 
					Return Me.RFU2DateMonth
				Case "RFU2DateYear" 
					Return Me.RFU2DateYear
				Case "RFU3DateMonth" 
					Return Me.RFU3DateMonth
				Case "RFU3DateYear" 
					Return Me.RFU3DateYear
				Case "RespRequestDateString" 
					Return Me.RespRequestDateString
				Case "RespDueDateString" 
					Return Me.RespDueDateString
				Case "RFU1DateString" 
					Return Me.RFU1DateString
				Case "RFU2DateString" 
					Return Me.RFU2DateString
				Case "RFU3DateString" 
					Return Me.RFU3DateString
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.ResponseStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AutoRequest As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.AutoRequest, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastInspDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.LastInspDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property TotalNoRecs As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TotalNoRecs, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NoActiveRecs As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.NoActiveRecs, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NoRecsNeedingResp As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.NoRecsNeedingResp, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DaysOverdue As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.DaysOverdue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateString, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwNatHazFloodRecommendationResponsesFollowUpMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.FilePrefix, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.CustomAccess, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Facility, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Address, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.City, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.StProv, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Country, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames._100PercentUSTot, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVAustralian, 12, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVBritish, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVCanadian, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVEuro, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVJapanese, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVMexican, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TIVNewZealand, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Tivus, 19, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.ResponseStatus, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.ResponseStatus
			c.CharacterMaxLength = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.AutoRequest, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.AutoRequest
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.Hazard, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.LastInspDate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.LastInspDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDate, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.TotalNoRecs, 25, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.TotalNoRecs
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.NoActiveRecs, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.NoActiveRecs
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.NoRecsNeedingResp, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.NoRecsNeedingResp
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDate, 28, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.DaysOverdue, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.DaysOverdue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1Date, 30, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2Date, 31, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3Date, 32, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RecipientName, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RecipientName
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RecipientEmail, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RecipientEmail
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateMonth, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateYear, 36, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateMonth, 37, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateYear, 38, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateMonth, 39, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateYear, 40, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateMonth, 41, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateYear, 42, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateMonth, 43, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateYear, 44, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespRequestDateString, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespRequestDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RespDueDateString, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RespDueDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU1DateString, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU1DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU2DateString, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU2DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazFloodRecommendationResponsesFollowUpMetadata.ColumnNames.RFU3DateString, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazFloodRecommendationResponsesFollowUpMetadata.PropertyNames.RFU3DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwNatHazFloodRecommendationResponsesFollowUpMetadata
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
			 Public Const _100PercentUSTot As String = "100PercentUSTot"
			 Public Const TIVAustralian As String = "TIVAustralian"
			 Public Const TIVBritish As String = "TIVBritish"
			 Public Const TIVCanadian As String = "TIVCanadian"
			 Public Const TIVEuro As String = "TIVEuro"
			 Public Const TIVJapanese As String = "TIVJapanese"
			 Public Const TIVMexican As String = "TIVMexican"
			 Public Const TIVNewZealand As String = "TIVNewZealand"
			 Public Const Tivus As String = "TIVUS"
			 Public Const ResponseStatus As String = "ResponseStatus"
			 Public Const AutoRequest As String = "AutoRequest"
			 Public Const Hazard As String = "Hazard"
			 Public Const LastInspDate As String = "LastInspDate"
			 Public Const RespRequestDate As String = "RespRequestDate"
			 Public Const TotalNoRecs As String = "TotalNoRecs"
			 Public Const NoActiveRecs As String = "NoActiveRecs"
			 Public Const NoRecsNeedingResp As String = "NoRecsNeedingResp"
			 Public Const RespDueDate As String = "RespDueDate"
			 Public Const DaysOverdue As String = "DaysOverdue"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const RespRequestDateMonth As String = "RespRequestDateMonth"
			 Public Const RespRequestDateYear As String = "RespRequestDateYear"
			 Public Const RespDueDateMonth As String = "RespDueDateMonth"
			 Public Const RespDueDateYear As String = "RespDueDateYear"
			 Public Const RFU1DateMonth As String = "RFU1DateMonth"
			 Public Const RFU1DateYear As String = "RFU1DateYear"
			 Public Const RFU2DateMonth As String = "RFU2DateMonth"
			 Public Const RFU2DateYear As String = "RFU2DateYear"
			 Public Const RFU3DateMonth As String = "RFU3DateMonth"
			 Public Const RFU3DateYear As String = "RFU3DateYear"
			 Public Const RespRequestDateString As String = "RespRequestDateString"
			 Public Const RespDueDateString As String = "RespDueDateString"
			 Public Const RFU1DateString As String = "RFU1DateString"
			 Public Const RFU2DateString As String = "RFU2DateString"
			 Public Const RFU3DateString As String = "RFU3DateString"
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
			 Public Const _100PercentUSTot As String = "_100PercentUSTot"
			 Public Const TIVAustralian As String = "TIVAustralian"
			 Public Const TIVBritish As String = "TIVBritish"
			 Public Const TIVCanadian As String = "TIVCanadian"
			 Public Const TIVEuro As String = "TIVEuro"
			 Public Const TIVJapanese As String = "TIVJapanese"
			 Public Const TIVMexican As String = "TIVMexican"
			 Public Const TIVNewZealand As String = "TIVNewZealand"
			 Public Const Tivus As String = "Tivus"
			 Public Const ResponseStatus As String = "ResponseStatus"
			 Public Const AutoRequest As String = "AutoRequest"
			 Public Const Hazard As String = "Hazard"
			 Public Const LastInspDate As String = "LastInspDate"
			 Public Const RespRequestDate As String = "RespRequestDate"
			 Public Const TotalNoRecs As String = "TotalNoRecs"
			 Public Const NoActiveRecs As String = "NoActiveRecs"
			 Public Const NoRecsNeedingResp As String = "NoRecsNeedingResp"
			 Public Const RespDueDate As String = "RespDueDate"
			 Public Const DaysOverdue As String = "DaysOverdue"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const RespRequestDateMonth As String = "RespRequestDateMonth"
			 Public Const RespRequestDateYear As String = "RespRequestDateYear"
			 Public Const RespDueDateMonth As String = "RespDueDateMonth"
			 Public Const RespDueDateYear As String = "RespDueDateYear"
			 Public Const RFU1DateMonth As String = "RFU1DateMonth"
			 Public Const RFU1DateYear As String = "RFU1DateYear"
			 Public Const RFU2DateMonth As String = "RFU2DateMonth"
			 Public Const RFU2DateYear As String = "RFU2DateYear"
			 Public Const RFU3DateMonth As String = "RFU3DateMonth"
			 Public Const RFU3DateYear As String = "RFU3DateYear"
			 Public Const RespRequestDateString As String = "RespRequestDateString"
			 Public Const RespDueDateString As String = "RespDueDateString"
			 Public Const RFU1DateString As String = "RFU1DateString"
			 Public Const RFU2DateString As String = "RFU2DateString"
			 Public Const RFU3DateString As String = "RFU3DateString"
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
			SyncLock GetType(VwNatHazFloodRecommendationResponsesFollowUpMetadata)
			
				If VwNatHazFloodRecommendationResponsesFollowUpMetadata.mapDelegates Is Nothing Then
					VwNatHazFloodRecommendationResponsesFollowUpMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwNatHazFloodRecommendationResponsesFollowUpMetadata._meta Is Nothing Then
					VwNatHazFloodRecommendationResponsesFollowUpMetadata._meta = New VwNatHazFloodRecommendationResponsesFollowUpMetadata()
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
				


				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))
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
				meta.AddTypeMap("_100PercentUSTot", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TIVAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TIVNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Tivus", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("ResponseStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AutoRequest", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LastInspDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("RespRequestDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("TotalNoRecs", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NoActiveRecs", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NoRecsNeedingResp", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespDueDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DaysOverdue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU2Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU3Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RecipientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecipientEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RespRequestDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespRequestDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespDueDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespDueDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU2DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU2DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU3DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU3DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespRequestDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RespDueDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU1DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU2DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU3DateString", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "vwNatHazFloodRecommendationResponsesFollowUp"
				meta.Destination = "vwNatHazFloodRecommendationResponsesFollowUp"
				
				meta.spInsert = "proc_vwNatHazFloodRecommendationResponsesFollowUpInsert"
				meta.spUpdate = "proc_vwNatHazFloodRecommendationResponsesFollowUpUpdate"
				meta.spDelete = "proc_vwNatHazFloodRecommendationResponsesFollowUpDelete"
				meta.spLoadAll = "proc_vwNatHazFloodRecommendationResponsesFollowUpLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwNatHazFloodRecommendationResponsesFollowUpLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwNatHazFloodRecommendationResponsesFollowUpMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
