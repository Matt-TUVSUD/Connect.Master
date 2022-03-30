
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/24/2013 11:35:58 AM
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
	' Encapsulates the 'vwIRRecommendationResponsesTrackingAll' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwIRRecommendationResponsesTrackingAll))> _
	<XmlType("VwIRRecommendationResponsesTrackingAll")> _	
	Partial Public Class VwIRRecommendationResponsesTrackingAll 
		Inherits esVwIRRecommendationResponsesTrackingAll
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwIRRecommendationResponsesTrackingAll()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwIRRecommendationResponsesTrackingAllCollection")> _
	Partial Public Class VwIRRecommendationResponsesTrackingAllCollection
		Inherits esVwIRRecommendationResponsesTrackingAllCollection
		Implements IEnumerable(Of VwIRRecommendationResponsesTrackingAll)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwIRRecommendationResponsesTrackingAll))> _
		Public Class VwIRRecommendationResponsesTrackingAllCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwIRRecommendationResponsesTrackingAllCollection)
			
			Public Shared Widening Operator CType(packet As VwIRRecommendationResponsesTrackingAllCollectionWCFPacket) As VwIRRecommendationResponsesTrackingAllCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwIRRecommendationResponsesTrackingAllCollection) As VwIRRecommendationResponsesTrackingAllCollectionWCFPacket
				Return New VwIRRecommendationResponsesTrackingAllCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwIRRecommendationResponsesTrackingAllQuery 
		Inherits esVwIRRecommendationResponsesTrackingAllQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwIRRecommendationResponsesTrackingAllQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwIRRecommendationResponsesTrackingAllQuery) As String
			Return VwIRRecommendationResponsesTrackingAllQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwIRRecommendationResponsesTrackingAllQuery
			Return DirectCast(VwIRRecommendationResponsesTrackingAllQuery.SerializeHelper.FromXml(query, GetType(VwIRRecommendationResponsesTrackingAllQuery)), VwIRRecommendationResponsesTrackingAllQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwIRRecommendationResponsesTrackingAll
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ResponseStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatus As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseStatus, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RespRequestDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDate, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RespDueDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDate, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.DaysOverdue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DaysOverdue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.DaysOverdue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.DaysOverdue, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.DaysOverdue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU1Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1Date, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU2Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2Date, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU3Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3Date, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientName As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientName, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientEmail, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.findingno
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Findingno As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Findingno)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Findingno, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Findingno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RecMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMonth As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecMonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.History
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property History As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.History)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.History, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.History)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RecCategory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategory As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCategory, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecCategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ProbableEquipmentDamageCost
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProbableEquipmentDamageCost As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ProbableEquipmentDamageCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ProbableEquipmentDamageCost, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ProbableEquipmentDamageCost)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.LengthOfBusinessInterruption
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LengthOfBusinessInterruption As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.LengthOfBusinessInterruption)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.LengthOfBusinessInterruption, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.LengthOfBusinessInterruption)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.severityrating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Severityrating As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Severityrating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Severityrating, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Severityrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Criticalit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Criticalit As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Criticalit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Criticalit, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Criticalit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Location
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Location As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Location)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Location, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Location)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.equipment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Equipment As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Equipment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Equipment, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Equipment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.DetectedWith
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DetectedWith As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.DetectedWith)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.DetectedWith, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.DetectedWith)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.FaultType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FaultType As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FaultType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FaultType, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.FaultType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.PlantAreaAffected
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantAreaAffected As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantAreaAffected)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantAreaAffected, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.PlantAreaAffected)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RedundancySpare
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RedundancySpare As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RedundancySpare)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RedundancySpare, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RedundancySpare)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ProbableCause
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProbableCause As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ProbableCause)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ProbableCause, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ProbableCause)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Recommendation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recommendation As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Recommendation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Recommendation, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Recommendation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.SpecItemDetail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecItemDetail As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.SpecItemDetail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.SpecItemDetail, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.SpecItemDetail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.FindEquip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FindEquip As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FindEquip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FindEquip, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.FindEquip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.Load
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Load1 As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Load1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Load1, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Load1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ResponseFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseFrom As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseFrom, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.PlantComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantComment As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantComment, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.PlantComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ExpectedCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDate, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.EquipmentLocation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EquipmentLocation As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.EquipmentLocation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.EquipmentLocation, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.EquipmentLocation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RespRequestDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RespRequestDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RespDueDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RespDueDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ResponseDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ResponseDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU1DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU1DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU2DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU2DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU3DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU3DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.StatusDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.StatusDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ExpectedCompletionDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateMonth, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ExpectedCompletionDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateYear, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RespRequestDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateString As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateString, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RespDueDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateString As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateString, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ResponseDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateString As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateString, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU1DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateString As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateString, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU2DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateString As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateString, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.RFU3DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateString As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateString, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.ExpectedCompletionDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateString As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateString, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwIRRecommendationResponsesTrackingAll.StatusDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateString As System.String
			Get
				Return MyBase.GetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateString, value) Then
					OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateString)
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
												
						Case "RespRequestDate"
							Me.str().RespRequestDate = CType(value, string)
												
						Case "RespDueDate"
							Me.str().RespDueDate = CType(value, string)
												
						Case "ResponseDate"
							Me.str().ResponseDate = CType(value, string)
												
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
												
						Case "Findingno"
							Me.str().Findingno = CType(value, string)
												
						Case "RecYear"
							Me.str().RecYear = CType(value, string)
												
						Case "RecMonth"
							Me.str().RecMonth = CType(value, string)
												
						Case "RecNumber"
							Me.str().RecNumber = CType(value, string)
												
						Case "History"
							Me.str().History = CType(value, string)
												
						Case "RecStatus"
							Me.str().RecStatus = CType(value, string)
												
						Case "StatusDate"
							Me.str().StatusDate = CType(value, string)
												
						Case "RecCategory"
							Me.str().RecCategory = CType(value, string)
												
						Case "ProbableEquipmentDamageCost"
							Me.str().ProbableEquipmentDamageCost = CType(value, string)
												
						Case "LengthOfBusinessInterruption"
							Me.str().LengthOfBusinessInterruption = CType(value, string)
												
						Case "Severityrating"
							Me.str().Severityrating = CType(value, string)
												
						Case "Criticalit"
							Me.str().Criticalit = CType(value, string)
												
						Case "Location"
							Me.str().Location = CType(value, string)
												
						Case "Equipment"
							Me.str().Equipment = CType(value, string)
												
						Case "PrimaryRecType"
							Me.str().PrimaryRecType = CType(value, string)
												
						Case "SecondaryRecType"
							Me.str().SecondaryRecType = CType(value, string)
												
						Case "DetectedWith"
							Me.str().DetectedWith = CType(value, string)
												
						Case "FaultType"
							Me.str().FaultType = CType(value, string)
												
						Case "PlantAreaAffected"
							Me.str().PlantAreaAffected = CType(value, string)
												
						Case "RedundancySpare"
							Me.str().RedundancySpare = CType(value, string)
												
						Case "ProbableCause"
							Me.str().ProbableCause = CType(value, string)
												
						Case "Recommendation"
							Me.str().Recommendation = CType(value, string)
												
						Case "SpecItemDetail"
							Me.str().SpecItemDetail = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
												
						Case "FindEquip"
							Me.str().FindEquip = CType(value, string)
												
						Case "Load1"
							Me.str().Load1 = CType(value, string)
												
						Case "ResponseFrom"
							Me.str().ResponseFrom = CType(value, string)
												
						Case "PlantComment"
							Me.str().PlantComment = CType(value, string)
												
						Case "IntendedAction"
							Me.str().IntendedAction = CType(value, string)
												
						Case "ExpectedCompletionDate"
							Me.str().ExpectedCompletionDate = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "EquipmentLocation"
							Me.str().EquipmentLocation = CType(value, string)
												
						Case "RespRequestDateMonth"
							Me.str().RespRequestDateMonth = CType(value, string)
												
						Case "RespRequestDateYear"
							Me.str().RespRequestDateYear = CType(value, string)
												
						Case "RespDueDateMonth"
							Me.str().RespDueDateMonth = CType(value, string)
												
						Case "RespDueDateYear"
							Me.str().RespDueDateYear = CType(value, string)
												
						Case "ResponseDateMonth"
							Me.str().ResponseDateMonth = CType(value, string)
												
						Case "ResponseDateYear"
							Me.str().ResponseDateYear = CType(value, string)
												
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
												
						Case "StatusDateMonth"
							Me.str().StatusDateMonth = CType(value, string)
												
						Case "StatusDateYear"
							Me.str().StatusDateYear = CType(value, string)
												
						Case "ExpectedCompletionDateMonth"
							Me.str().ExpectedCompletionDateMonth = CType(value, string)
												
						Case "ExpectedCompletionDateYear"
							Me.str().ExpectedCompletionDateYear = CType(value, string)
												
						Case "RespRequestDateString"
							Me.str().RespRequestDateString = CType(value, string)
												
						Case "RespDueDateString"
							Me.str().RespDueDateString = CType(value, string)
												
						Case "ResponseDateString"
							Me.str().ResponseDateString = CType(value, string)
												
						Case "RFU1DateString"
							Me.str().RFU1DateString = CType(value, string)
												
						Case "RFU2DateString"
							Me.str().RFU2DateString = CType(value, string)
												
						Case "RFU3DateString"
							Me.str().RFU3DateString = CType(value, string)
												
						Case "ExpectedCompletionDateString"
							Me.str().ExpectedCompletionDateString = CType(value, string)
												
						Case "StatusDateString"
							Me.str().StatusDateString = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Tivus)
							End If
						
						Case "RespRequestDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespRequestDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDate)
							End If
						
						Case "RespDueDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespDueDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDate)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "DaysOverdue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DaysOverdue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.DaysOverdue)
							End If
						
						Case "RFU1Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU1Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1Date)
							End If
						
						Case "RFU2Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU2Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2Date)
							End If
						
						Case "RFU3Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU3Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3Date)
							End If
						
						Case "Findingno"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Findingno = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Findingno)
							End If
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecYear)
							End If
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecNumber)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDate)
							End If
						
						Case "ProbableEquipmentDamageCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProbableEquipmentDamageCost = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ProbableEquipmentDamageCost)
							End If
						
						Case "ExpectedCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDate)
							End If
						
						Case "RespRequestDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateMonth)
							End If
						
						Case "RespRequestDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateYear)
							End If
						
						Case "RespDueDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateMonth)
							End If
						
						Case "RespDueDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateYear)
							End If
						
						Case "ResponseDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateMonth)
							End If
						
						Case "ResponseDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateYear)
							End If
						
						Case "RFU1DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateMonth)
							End If
						
						Case "RFU1DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateYear)
							End If
						
						Case "RFU2DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateMonth)
							End If
						
						Case "RFU2DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateYear)
							End If
						
						Case "RFU3DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateMonth)
							End If
						
						Case "RFU3DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateYear)
							End If
						
						Case "StatusDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateMonth)
							End If
						
						Case "StatusDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateYear)
							End If
						
						Case "ExpectedCompletionDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateMonth)
							End If
						
						Case "ExpectedCompletionDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateYear)
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
		
			Public Sub New(ByVal entity As esVwIRRecommendationResponsesTrackingAll)
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
		  	
			Public Property ResponseDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ResponseDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseDate = Nothing
					Else
						entity.ResponseDate = Convert.ToDateTime(Value)
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
		  	
			Public Property Findingno As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Findingno
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Findingno = Nothing
					Else
						entity.Findingno = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecYear = Nothing
					Else
						entity.RecYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecMonth As System.String 
				Get
					Dim data_ As System.String = entity.RecMonth
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecMonth = Nothing
					Else
						entity.RecMonth = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecNumber = Nothing
					Else
						entity.RecNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property History As System.String 
				Get
					Dim data_ As System.String = entity.History
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.History = Nothing
					Else
						entity.History = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecStatus As System.String 
				Get
					Dim data_ As System.String = entity.RecStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecStatus = Nothing
					Else
						entity.RecStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StatusDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.StatusDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StatusDate = Nothing
					Else
						entity.StatusDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecCategory As System.String 
				Get
					Dim data_ As System.String = entity.RecCategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCategory = Nothing
					Else
						entity.RecCategory = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProbableEquipmentDamageCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProbableEquipmentDamageCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProbableEquipmentDamageCost = Nothing
					Else
						entity.ProbableEquipmentDamageCost = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LengthOfBusinessInterruption As System.String 
				Get
					Dim data_ As System.String = entity.LengthOfBusinessInterruption
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LengthOfBusinessInterruption = Nothing
					Else
						entity.LengthOfBusinessInterruption = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Severityrating As System.String 
				Get
					Dim data_ As System.String = entity.Severityrating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Severityrating = Nothing
					Else
						entity.Severityrating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Criticalit As System.String 
				Get
					Dim data_ As System.String = entity.Criticalit
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Criticalit = Nothing
					Else
						entity.Criticalit = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Location As System.String 
				Get
					Dim data_ As System.String = entity.Location
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Location = Nothing
					Else
						entity.Location = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Equipment As System.String 
				Get
					Dim data_ As System.String = entity.Equipment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Equipment = Nothing
					Else
						entity.Equipment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrimaryRecType As System.String 
				Get
					Dim data_ As System.String = entity.PrimaryRecType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimaryRecType = Nothing
					Else
						entity.PrimaryRecType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecondaryRecType As System.String 
				Get
					Dim data_ As System.String = entity.SecondaryRecType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecondaryRecType = Nothing
					Else
						entity.SecondaryRecType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DetectedWith As System.String 
				Get
					Dim data_ As System.String = entity.DetectedWith
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DetectedWith = Nothing
					Else
						entity.DetectedWith = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FaultType As System.String 
				Get
					Dim data_ As System.String = entity.FaultType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FaultType = Nothing
					Else
						entity.FaultType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlantAreaAffected As System.String 
				Get
					Dim data_ As System.String = entity.PlantAreaAffected
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantAreaAffected = Nothing
					Else
						entity.PlantAreaAffected = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RedundancySpare As System.String 
				Get
					Dim data_ As System.String = entity.RedundancySpare
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RedundancySpare = Nothing
					Else
						entity.RedundancySpare = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProbableCause As System.String 
				Get
					Dim data_ As System.String = entity.ProbableCause
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProbableCause = Nothing
					Else
						entity.ProbableCause = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recommendation As System.String 
				Get
					Dim data_ As System.String = entity.Recommendation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recommendation = Nothing
					Else
						entity.Recommendation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecItemDetail As System.String 
				Get
					Dim data_ As System.String = entity.SpecItemDetail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecItemDetail = Nothing
					Else
						entity.SpecItemDetail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Comments As System.String 
				Get
					Dim data_ As System.String = entity.Comments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Comments = Nothing
					Else
						entity.Comments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FindEquip As System.String 
				Get
					Dim data_ As System.String = entity.FindEquip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FindEquip = Nothing
					Else
						entity.FindEquip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Load1 As System.String 
				Get
					Dim data_ As System.String = entity.Load1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Load1 = Nothing
					Else
						entity.Load1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponseFrom As System.String 
				Get
					Dim data_ As System.String = entity.ResponseFrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseFrom = Nothing
					Else
						entity.ResponseFrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlantComment As System.String 
				Get
					Dim data_ As System.String = entity.PlantComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantComment = Nothing
					Else
						entity.PlantComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IntendedAction As System.String 
				Get
					Dim data_ As System.String = entity.IntendedAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IntendedAction = Nothing
					Else
						entity.IntendedAction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExpectedCompletionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ExpectedCompletionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpectedCompletionDate = Nothing
					Else
						entity.ExpectedCompletionDate = Convert.ToDateTime(Value)
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
		  	
			Public Property EquipmentLocation As System.String 
				Get
					Dim data_ As System.String = entity.EquipmentLocation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EquipmentLocation = Nothing
					Else
						entity.EquipmentLocation = Convert.ToString(Value)
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
		  	
			Public Property ResponseDateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ResponseDateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseDateMonth = Nothing
					Else
						entity.ResponseDateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponseDateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ResponseDateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseDateYear = Nothing
					Else
						entity.ResponseDateYear = Convert.ToInt32(Value)
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
		  	
			Public Property StatusDateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.StatusDateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StatusDateMonth = Nothing
					Else
						entity.StatusDateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property StatusDateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.StatusDateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StatusDateYear = Nothing
					Else
						entity.StatusDateYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExpectedCompletionDateMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ExpectedCompletionDateMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpectedCompletionDateMonth = Nothing
					Else
						entity.ExpectedCompletionDateMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExpectedCompletionDateYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ExpectedCompletionDateYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpectedCompletionDateYear = Nothing
					Else
						entity.ExpectedCompletionDateYear = Convert.ToInt32(Value)
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
		  	
			Public Property ResponseDateString As System.String 
				Get
					Dim data_ As System.String = entity.ResponseDateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseDateString = Nothing
					Else
						entity.ResponseDateString = Convert.ToString(Value)
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
		  	
			Public Property ExpectedCompletionDateString As System.String 
				Get
					Dim data_ As System.String = entity.ExpectedCompletionDateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpectedCompletionDateString = Nothing
					Else
						entity.ExpectedCompletionDateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StatusDateString As System.String 
				Get
					Dim data_ As System.String = entity.StatusDateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StatusDateString = Nothing
					Else
						entity.StatusDateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVwIRRecommendationResponsesTrackingAll
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwIRRecommendationResponsesTrackingAllMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwIRRecommendationResponsesTrackingAllQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwIRRecommendationResponsesTrackingAllQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwIRRecommendationResponsesTrackingAllQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwIRRecommendationResponsesTrackingAllQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwIRRecommendationResponsesTrackingAllQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwIRRecommendationResponsesTrackingAllCollection
		Inherits esEntityCollection(Of VwIRRecommendationResponsesTrackingAll)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwIRRecommendationResponsesTrackingAllMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwIRRecommendationResponsesTrackingAllCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwIRRecommendationResponsesTrackingAllQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwIRRecommendationResponsesTrackingAllQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwIRRecommendationResponsesTrackingAllQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwIRRecommendationResponsesTrackingAllQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwIRRecommendationResponsesTrackingAllQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwIRRecommendationResponsesTrackingAllQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwIRRecommendationResponsesTrackingAllQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwIRRecommendationResponsesTrackingAllQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwIRRecommendationResponsesTrackingAllMetadata.Meta()
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
				Case "RespRequestDate" 
					Return Me.RespRequestDate
				Case "RespDueDate" 
					Return Me.RespDueDate
				Case "ResponseDate" 
					Return Me.ResponseDate
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
				Case "Findingno" 
					Return Me.Findingno
				Case "RecYear" 
					Return Me.RecYear
				Case "RecMonth" 
					Return Me.RecMonth
				Case "RecNumber" 
					Return Me.RecNumber
				Case "History" 
					Return Me.History
				Case "RecStatus" 
					Return Me.RecStatus
				Case "StatusDate" 
					Return Me.StatusDate
				Case "RecCategory" 
					Return Me.RecCategory
				Case "ProbableEquipmentDamageCost" 
					Return Me.ProbableEquipmentDamageCost
				Case "LengthOfBusinessInterruption" 
					Return Me.LengthOfBusinessInterruption
				Case "Severityrating" 
					Return Me.Severityrating
				Case "Criticalit" 
					Return Me.Criticalit
				Case "Location" 
					Return Me.Location
				Case "Equipment" 
					Return Me.Equipment
				Case "PrimaryRecType" 
					Return Me.PrimaryRecType
				Case "SecondaryRecType" 
					Return Me.SecondaryRecType
				Case "DetectedWith" 
					Return Me.DetectedWith
				Case "FaultType" 
					Return Me.FaultType
				Case "PlantAreaAffected" 
					Return Me.PlantAreaAffected
				Case "RedundancySpare" 
					Return Me.RedundancySpare
				Case "ProbableCause" 
					Return Me.ProbableCause
				Case "Recommendation" 
					Return Me.Recommendation
				Case "SpecItemDetail" 
					Return Me.SpecItemDetail
				Case "Comments" 
					Return Me.Comments
				Case "FindEquip" 
					Return Me.FindEquip
				Case "Load1" 
					Return Me.Load1
				Case "ResponseFrom" 
					Return Me.ResponseFrom
				Case "PlantComment" 
					Return Me.PlantComment
				Case "IntendedAction" 
					Return Me.IntendedAction
				Case "ExpectedCompletionDate" 
					Return Me.ExpectedCompletionDate
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "EquipmentLocation" 
					Return Me.EquipmentLocation
				Case "RespRequestDateMonth" 
					Return Me.RespRequestDateMonth
				Case "RespRequestDateYear" 
					Return Me.RespRequestDateYear
				Case "RespDueDateMonth" 
					Return Me.RespDueDateMonth
				Case "RespDueDateYear" 
					Return Me.RespDueDateYear
				Case "ResponseDateMonth" 
					Return Me.ResponseDateMonth
				Case "ResponseDateYear" 
					Return Me.ResponseDateYear
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
				Case "StatusDateMonth" 
					Return Me.StatusDateMonth
				Case "StatusDateYear" 
					Return Me.StatusDateYear
				Case "ExpectedCompletionDateMonth" 
					Return Me.ExpectedCompletionDateMonth
				Case "ExpectedCompletionDateYear" 
					Return Me.ExpectedCompletionDateYear
				Case "RespRequestDateString" 
					Return Me.RespRequestDateString
				Case "RespDueDateString" 
					Return Me.RespDueDateString
				Case "ResponseDateString" 
					Return Me.ResponseDateString
				Case "RFU1DateString" 
					Return Me.RFU1DateString
				Case "RFU2DateString" 
					Return Me.RFU2DateString
				Case "RFU3DateString" 
					Return Me.RFU3DateString
				Case "ExpectedCompletionDateString" 
					Return Me.ExpectedCompletionDateString
				Case "StatusDateString" 
					Return Me.StatusDateString
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DaysOverdue As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.DaysOverdue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Findingno As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Findingno, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecMonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property History As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.History, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategory As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProbableEquipmentDamageCost As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ProbableEquipmentDamageCost, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LengthOfBusinessInterruption As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.LengthOfBusinessInterruption, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Severityrating As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Severityrating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Criticalit As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Criticalit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Location As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Location, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Equipment As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Equipment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DetectedWith As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.DetectedWith, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FaultType As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FaultType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantAreaAffected As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantAreaAffected, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RedundancySpare As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RedundancySpare, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProbableCause As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ProbableCause, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recommendation As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Recommendation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecItemDetail As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.SpecItemDetail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FindEquip As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FindEquip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Load1 As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Load1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseFrom As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantComment As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EquipmentLocation As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.EquipmentLocation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateString, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwIRRecommendationResponsesTrackingAllMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FilePrefix, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Facility, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Address, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.City, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StProv, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Country, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames._100PercentUSTot, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVAustralian, 11, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVBritish, 12, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVCanadian, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVEuro, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVJapanese, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVMexican, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVNewZealand, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Tivus, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseStatus, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseStatus
			c.CharacterMaxLength = 12
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDate, 20, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDate, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.DaysOverdue, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.DaysOverdue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1Date, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2Date, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3Date, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientName, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecipientName
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientEmail, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecipientEmail
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Findingno, 29, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Findingno
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecYear, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecMonth, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecMonth
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecNumber, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.History, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.History
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecStatus, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDate, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCategory, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RecCategory
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ProbableEquipmentDamageCost, 37, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ProbableEquipmentDamageCost
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.LengthOfBusinessInterruption, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.LengthOfBusinessInterruption
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Severityrating, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Severityrating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Criticalit, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Criticalit
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Location, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Location
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Equipment, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Equipment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PrimaryRecType, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.SecondaryRecType, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.DetectedWith, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.DetectedWith
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FaultType, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.FaultType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantAreaAffected, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.PlantAreaAffected
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RedundancySpare, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RedundancySpare
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ProbableCause, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ProbableCause
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Recommendation, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Recommendation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.SpecItemDetail, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.SpecItemDetail
			c.CharacterMaxLength = 186
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Comments, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.FindEquip, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.FindEquip
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.Load1, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.Load1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			c.Alias = "Load1"
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseFrom, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseFrom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantComment, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.PlantComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.IntendedAction, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDate, 58, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.CustomAccess, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.EquipmentLocation, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.EquipmentLocation
			c.CharacterMaxLength = 513
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateMonth, 61, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateYear, 62, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateMonth, 63, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateYear, 64, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateMonth, 65, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateYear, 66, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateMonth, 67, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateYear, 68, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateMonth, 69, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateYear, 70, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateMonth, 71, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateYear, 72, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateMonth, 73, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateYear, 74, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateMonth, 75, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateYear, 76, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateString, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateString, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateString, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateString, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateString, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateString, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateString, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwIRRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateString, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwIRRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwIRRecommendationResponsesTrackingAllMetadata
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
			 Public Const RespRequestDate As String = "RespRequestDate"
			 Public Const RespDueDate As String = "RespDueDate"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const DaysOverdue As String = "DaysOverdue"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const Findingno As String = "findingno"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const History As String = "History"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const ProbableEquipmentDamageCost As String = "ProbableEquipmentDamageCost"
			 Public Const LengthOfBusinessInterruption As String = "LengthOfBusinessInterruption"
			 Public Const Severityrating As String = "severityrating"
			 Public Const Criticalit As String = "Criticalit"
			 Public Const Location As String = "Location"
			 Public Const Equipment As String = "equipment"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const DetectedWith As String = "DetectedWith"
			 Public Const FaultType As String = "FaultType"
			 Public Const PlantAreaAffected As String = "PlantAreaAffected"
			 Public Const RedundancySpare As String = "RedundancySpare"
			 Public Const ProbableCause As String = "ProbableCause"
			 Public Const Recommendation As String = "Recommendation"
			 Public Const SpecItemDetail As String = "SpecItemDetail"
			 Public Const Comments As String = "Comments"
			 Public Const FindEquip As String = "FindEquip"
			 Public Const Load1 As String = "Load"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const EquipmentLocation As String = "EquipmentLocation"
			 Public Const RespRequestDateMonth As String = "RespRequestDateMonth"
			 Public Const RespRequestDateYear As String = "RespRequestDateYear"
			 Public Const RespDueDateMonth As String = "RespDueDateMonth"
			 Public Const RespDueDateYear As String = "RespDueDateYear"
			 Public Const ResponseDateMonth As String = "ResponseDateMonth"
			 Public Const ResponseDateYear As String = "ResponseDateYear"
			 Public Const RFU1DateMonth As String = "RFU1DateMonth"
			 Public Const RFU1DateYear As String = "RFU1DateYear"
			 Public Const RFU2DateMonth As String = "RFU2DateMonth"
			 Public Const RFU2DateYear As String = "RFU2DateYear"
			 Public Const RFU3DateMonth As String = "RFU3DateMonth"
			 Public Const RFU3DateYear As String = "RFU3DateYear"
			 Public Const StatusDateMonth As String = "StatusDateMonth"
			 Public Const StatusDateYear As String = "StatusDateYear"
			 Public Const ExpectedCompletionDateMonth As String = "ExpectedCompletionDateMonth"
			 Public Const ExpectedCompletionDateYear As String = "ExpectedCompletionDateYear"
			 Public Const RespRequestDateString As String = "RespRequestDateString"
			 Public Const RespDueDateString As String = "RespDueDateString"
			 Public Const ResponseDateString As String = "ResponseDateString"
			 Public Const RFU1DateString As String = "RFU1DateString"
			 Public Const RFU2DateString As String = "RFU2DateString"
			 Public Const RFU3DateString As String = "RFU3DateString"
			 Public Const ExpectedCompletionDateString As String = "ExpectedCompletionDateString"
			 Public Const StatusDateString As String = "StatusDateString"
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
			 Public Const RespRequestDate As String = "RespRequestDate"
			 Public Const RespDueDate As String = "RespDueDate"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const DaysOverdue As String = "DaysOverdue"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const Findingno As String = "Findingno"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const History As String = "History"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const ProbableEquipmentDamageCost As String = "ProbableEquipmentDamageCost"
			 Public Const LengthOfBusinessInterruption As String = "LengthOfBusinessInterruption"
			 Public Const Severityrating As String = "Severityrating"
			 Public Const Criticalit As String = "Criticalit"
			 Public Const Location As String = "Location"
			 Public Const Equipment As String = "Equipment"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const DetectedWith As String = "DetectedWith"
			 Public Const FaultType As String = "FaultType"
			 Public Const PlantAreaAffected As String = "PlantAreaAffected"
			 Public Const RedundancySpare As String = "RedundancySpare"
			 Public Const ProbableCause As String = "ProbableCause"
			 Public Const Recommendation As String = "Recommendation"
			 Public Const SpecItemDetail As String = "SpecItemDetail"
			 Public Const Comments As String = "Comments"
			 Public Const FindEquip As String = "FindEquip"
			 Public Const Load1 As String = "Load1"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const EquipmentLocation As String = "EquipmentLocation"
			 Public Const RespRequestDateMonth As String = "RespRequestDateMonth"
			 Public Const RespRequestDateYear As String = "RespRequestDateYear"
			 Public Const RespDueDateMonth As String = "RespDueDateMonth"
			 Public Const RespDueDateYear As String = "RespDueDateYear"
			 Public Const ResponseDateMonth As String = "ResponseDateMonth"
			 Public Const ResponseDateYear As String = "ResponseDateYear"
			 Public Const RFU1DateMonth As String = "RFU1DateMonth"
			 Public Const RFU1DateYear As String = "RFU1DateYear"
			 Public Const RFU2DateMonth As String = "RFU2DateMonth"
			 Public Const RFU2DateYear As String = "RFU2DateYear"
			 Public Const RFU3DateMonth As String = "RFU3DateMonth"
			 Public Const RFU3DateYear As String = "RFU3DateYear"
			 Public Const StatusDateMonth As String = "StatusDateMonth"
			 Public Const StatusDateYear As String = "StatusDateYear"
			 Public Const ExpectedCompletionDateMonth As String = "ExpectedCompletionDateMonth"
			 Public Const ExpectedCompletionDateYear As String = "ExpectedCompletionDateYear"
			 Public Const RespRequestDateString As String = "RespRequestDateString"
			 Public Const RespDueDateString As String = "RespDueDateString"
			 Public Const ResponseDateString As String = "ResponseDateString"
			 Public Const RFU1DateString As String = "RFU1DateString"
			 Public Const RFU2DateString As String = "RFU2DateString"
			 Public Const RFU3DateString As String = "RFU3DateString"
			 Public Const ExpectedCompletionDateString As String = "ExpectedCompletionDateString"
			 Public Const StatusDateString As String = "StatusDateString"
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
			SyncLock GetType(VwIRRecommendationResponsesTrackingAllMetadata)
			
				If VwIRRecommendationResponsesTrackingAllMetadata.mapDelegates Is Nothing Then
					VwIRRecommendationResponsesTrackingAllMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwIRRecommendationResponsesTrackingAllMetadata._meta Is Nothing Then
					VwIRRecommendationResponsesTrackingAllMetadata._meta = New VwIRRecommendationResponsesTrackingAllMetadata()
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
				meta.AddTypeMap("RespRequestDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RespDueDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ResponseDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DaysOverdue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU2Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU3Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RecipientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecipientEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Findingno", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RecYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecMonth", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("History", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StatusDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RecCategory", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProbableEquipmentDamageCost", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LengthOfBusinessInterruption", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Severityrating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Criticalit", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Location", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Equipment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PrimaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SecondaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DetectedWith", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FaultType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantAreaAffected", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RedundancySpare", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProbableCause", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Recommendation", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecItemDetail", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Comments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FindEquip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Load1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ResponseFrom", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("IntendedAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EquipmentLocation", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RespRequestDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespRequestDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespDueDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespDueDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ResponseDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ResponseDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU2DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU2DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU3DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU3DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StatusDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StatusDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExpectedCompletionDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExpectedCompletionDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespRequestDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RespDueDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ResponseDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU1DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU2DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU3DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StatusDateString", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "vwIRRecommendationResponsesTrackingAll"
				meta.Destination = "vwIRRecommendationResponsesTrackingAll"
				
				meta.spInsert = "proc_vwIRRecommendationResponsesTrackingAllInsert"
				meta.spUpdate = "proc_vwIRRecommendationResponsesTrackingAllUpdate"
				meta.spDelete = "proc_vwIRRecommendationResponsesTrackingAllDelete"
				meta.spLoadAll = "proc_vwIRRecommendationResponsesTrackingAllLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwIRRecommendationResponsesTrackingAllLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwIRRecommendationResponsesTrackingAllMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
