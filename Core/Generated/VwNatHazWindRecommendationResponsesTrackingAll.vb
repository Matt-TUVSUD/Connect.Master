
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
	' Encapsulates the 'vwNatHazWindRecommendationResponsesTrackingAll' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwNatHazWindRecommendationResponsesTrackingAll))> _
	<XmlType("VwNatHazWindRecommendationResponsesTrackingAll")> _	
	Partial Public Class VwNatHazWindRecommendationResponsesTrackingAll 
		Inherits esVwNatHazWindRecommendationResponsesTrackingAll
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwNatHazWindRecommendationResponsesTrackingAll()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwNatHazWindRecommendationResponsesTrackingAllCollection")> _
	Partial Public Class VwNatHazWindRecommendationResponsesTrackingAllCollection
		Inherits esVwNatHazWindRecommendationResponsesTrackingAllCollection
		Implements IEnumerable(Of VwNatHazWindRecommendationResponsesTrackingAll)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwNatHazWindRecommendationResponsesTrackingAll))> _
		Public Class VwNatHazWindRecommendationResponsesTrackingAllCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwNatHazWindRecommendationResponsesTrackingAllCollection)
			
			Public Shared Widening Operator CType(packet As VwNatHazWindRecommendationResponsesTrackingAllCollectionWCFPacket) As VwNatHazWindRecommendationResponsesTrackingAllCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwNatHazWindRecommendationResponsesTrackingAllCollection) As VwNatHazWindRecommendationResponsesTrackingAllCollectionWCFPacket
				Return New VwNatHazWindRecommendationResponsesTrackingAllCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwNatHazWindRecommendationResponsesTrackingAllQuery 
		Inherits esVwNatHazWindRecommendationResponsesTrackingAllQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwNatHazWindRecommendationResponsesTrackingAllQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwNatHazWindRecommendationResponsesTrackingAllQuery) As String
			Return VwNatHazWindRecommendationResponsesTrackingAllQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwNatHazWindRecommendationResponsesTrackingAllQuery
			Return DirectCast(VwNatHazWindRecommendationResponsesTrackingAllQuery.SerializeHelper.FromXml(query, GetType(VwNatHazWindRecommendationResponsesTrackingAllQuery)), VwNatHazWindRecommendationResponsesTrackingAllQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwNatHazWindRecommendationResponsesTrackingAll
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ResponseStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatus As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseStatus, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RespRequestDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDate, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RespDueDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDate, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.DaysOverdue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DaysOverdue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.DaysOverdue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.DaysOverdue, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.DaysOverdue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU1Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1Date, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU2Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2Date, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU3Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3Date, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientName As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientName, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientEmail, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ResponseFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseFrom As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseFrom, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.PlantComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantComment As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantComment, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.PlantComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ExpectedCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDate, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecPrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPrefix As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecPrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecPrefix, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecPrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMonth As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecMonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecSubletter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecSubletter As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecSubletter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecSubletter, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecSubletter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCode As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCode, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecCategory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategory As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCategory, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecCategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.HazardPrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HazardPrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.HazardPrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.HazardPrimaryRecType, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.HazardPrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RecKeyWords
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecKeyWords As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecKeyWords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecKeyWords, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecKeyWords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LossExpectancyBeforeActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyBeforeActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyBeforeActual, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyBeforeActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LossExpectancyBefore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBefore As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyBefore)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyBefore, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyBefore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LossExpectancyAfterActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyAfterActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyAfterActual, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyAfterActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LossExpectancyAfter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfter As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyAfter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyAfter, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyAfter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.CostToCompleteActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CostToCompleteActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CostToCompleteActual, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.CostToCompleteActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.CostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToComplete As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CostToComplete)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CostToComplete, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.CostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEBeforeAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeAustralian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEBeforeAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeAustralian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEAfterAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterAustralian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEAfterAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterAustralian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLECostAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostAustralian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LECostAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostAustralian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEBeforeBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeBritish, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEBeforeBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeBritish As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeBritish, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEAfterBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterBritish, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEAfterBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterBritish As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterBritish, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLECostBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostBritish, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LECostBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostBritish As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostBritish, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEBeforeCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeCanadian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEBeforeCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeCanadian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEAfterCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterCanadian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEAfterCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterCanadian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLECostCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostCanadian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LECostCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostCanadian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEBeforeEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeEuro, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEBeforeEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeEuro As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeEuro, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEAfterEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterEuro, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEAfterEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterEuro As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterEuro, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLECostEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostEuro, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LECostEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostEuro As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostEuro, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEBeforeJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeJapanese, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEBeforeJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeJapanese, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEAfterJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterJapanese, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEAfterJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterJapanese, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLECostJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostJapanese, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LECostJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostJapanese, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEBeforeMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeMexican, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEBeforeMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeMexican As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeMexican, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEAfterMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterMexican, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEAfterMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterMexican As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterMexican, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLECostMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostMexican, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LECostMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostMexican As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostMexican, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEBeforeNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeNewZealand, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEBeforeNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeNewZealand, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEAfterNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterNewZealand, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEAfterNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterNewZealand, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLECostNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostNewZealand, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LECostNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostNewZealand, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEBeforeUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeUS, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEBeforeUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeUS As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeUS, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLEAfterUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterUS, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LEAfterUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterUS As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterUS, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualLECostUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostUS, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.LECostUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostUS As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostUS, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToComplete, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToCompleteAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteAustralian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToCompleteBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteBritish, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToCompleteCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteCanadian, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToCompleteEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteEuro, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToCompleteJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteJapanese, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToCompleteMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteMexican, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToCompleteNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteNewZealand, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ActualCostToCompleteUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteUS, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.SavingsRatio
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SavingsRatio As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.SavingsRatio)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.SavingsRatio, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.SavingsRatio)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.PlantFeedback
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantFeedback As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantFeedback)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantFeedback, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.PlantFeedback)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RespRequestDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RespRequestDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RespDueDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RespDueDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ResponseDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ResponseDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU1DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU1DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU2DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU2DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU3DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU3DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ExpectedCompletionDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ExpectedCompletionDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.StatusDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateMonth, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.StatusDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateYear, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RespRequestDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateString, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RespDueDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateString, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ResponseDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateString, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU1DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateString, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU2DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateString, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.RFU3DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateString, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.ExpectedCompletionDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateString, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwNatHazWindRecommendationResponsesTrackingAll.StatusDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateString As System.String
			Get
				Return MyBase.GetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateString, value) Then
					OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateString)
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
												
						Case "ResponseFrom"
							Me.str().ResponseFrom = CType(value, string)
												
						Case "PlantComment"
							Me.str().PlantComment = CType(value, string)
												
						Case "ExpectedCompletionDate"
							Me.str().ExpectedCompletionDate = CType(value, string)
												
						Case "IntendedAction"
							Me.str().IntendedAction = CType(value, string)
												
						Case "RecPrefix"
							Me.str().RecPrefix = CType(value, string)
												
						Case "RecYear"
							Me.str().RecYear = CType(value, string)
												
						Case "RecMonth"
							Me.str().RecMonth = CType(value, string)
												
						Case "RecNumber"
							Me.str().RecNumber = CType(value, string)
												
						Case "RecSubletter"
							Me.str().RecSubletter = CType(value, string)
												
						Case "RecStatus"
							Me.str().RecStatus = CType(value, string)
												
						Case "StatusDate"
							Me.str().StatusDate = CType(value, string)
												
						Case "RecCode"
							Me.str().RecCode = CType(value, string)
												
						Case "RecCategory"
							Me.str().RecCategory = CType(value, string)
												
						Case "HazardPrimaryRecType"
							Me.str().HazardPrimaryRecType = CType(value, string)
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "PrimaryRecType"
							Me.str().PrimaryRecType = CType(value, string)
												
						Case "SecondaryRecType"
							Me.str().SecondaryRecType = CType(value, string)
												
						Case "RecKeyWords"
							Me.str().RecKeyWords = CType(value, string)
												
						Case "LossExpectancyBeforeActual"
							Me.str().LossExpectancyBeforeActual = CType(value, string)
												
						Case "LossExpectancyBefore"
							Me.str().LossExpectancyBefore = CType(value, string)
												
						Case "LossExpectancyAfterActual"
							Me.str().LossExpectancyAfterActual = CType(value, string)
												
						Case "LossExpectancyAfter"
							Me.str().LossExpectancyAfter = CType(value, string)
												
						Case "CostToCompleteActual"
							Me.str().CostToCompleteActual = CType(value, string)
												
						Case "CostToComplete"
							Me.str().CostToComplete = CType(value, string)
												
						Case "ActualLEBeforeAustralian"
							Me.str().ActualLEBeforeAustralian = CType(value, string)
												
						Case "LEBeforeAustralian"
							Me.str().LEBeforeAustralian = CType(value, string)
												
						Case "ActualLEAfterAustralian"
							Me.str().ActualLEAfterAustralian = CType(value, string)
												
						Case "LEAfterAustralian"
							Me.str().LEAfterAustralian = CType(value, string)
												
						Case "ActualLECostAustralian"
							Me.str().ActualLECostAustralian = CType(value, string)
												
						Case "LECostAustralian"
							Me.str().LECostAustralian = CType(value, string)
												
						Case "ActualLEBeforeBritish"
							Me.str().ActualLEBeforeBritish = CType(value, string)
												
						Case "LEBeforeBritish"
							Me.str().LEBeforeBritish = CType(value, string)
												
						Case "ActualLEAfterBritish"
							Me.str().ActualLEAfterBritish = CType(value, string)
												
						Case "LEAfterBritish"
							Me.str().LEAfterBritish = CType(value, string)
												
						Case "ActualLECostBritish"
							Me.str().ActualLECostBritish = CType(value, string)
												
						Case "LECostBritish"
							Me.str().LECostBritish = CType(value, string)
												
						Case "ActualLEBeforeCanadian"
							Me.str().ActualLEBeforeCanadian = CType(value, string)
												
						Case "LEBeforeCanadian"
							Me.str().LEBeforeCanadian = CType(value, string)
												
						Case "ActualLEAfterCanadian"
							Me.str().ActualLEAfterCanadian = CType(value, string)
												
						Case "LEAfterCanadian"
							Me.str().LEAfterCanadian = CType(value, string)
												
						Case "ActualLECostCanadian"
							Me.str().ActualLECostCanadian = CType(value, string)
												
						Case "LECostCanadian"
							Me.str().LECostCanadian = CType(value, string)
												
						Case "ActualLEBeforeEuro"
							Me.str().ActualLEBeforeEuro = CType(value, string)
												
						Case "LEBeforeEuro"
							Me.str().LEBeforeEuro = CType(value, string)
												
						Case "ActualLEAfterEuro"
							Me.str().ActualLEAfterEuro = CType(value, string)
												
						Case "LEAfterEuro"
							Me.str().LEAfterEuro = CType(value, string)
												
						Case "ActualLECostEuro"
							Me.str().ActualLECostEuro = CType(value, string)
												
						Case "LECostEuro"
							Me.str().LECostEuro = CType(value, string)
												
						Case "ActualLEBeforeJapanese"
							Me.str().ActualLEBeforeJapanese = CType(value, string)
												
						Case "LEBeforeJapanese"
							Me.str().LEBeforeJapanese = CType(value, string)
												
						Case "ActualLEAfterJapanese"
							Me.str().ActualLEAfterJapanese = CType(value, string)
												
						Case "LEAfterJapanese"
							Me.str().LEAfterJapanese = CType(value, string)
												
						Case "ActualLECostJapanese"
							Me.str().ActualLECostJapanese = CType(value, string)
												
						Case "LECostJapanese"
							Me.str().LECostJapanese = CType(value, string)
												
						Case "ActualLEBeforeMexican"
							Me.str().ActualLEBeforeMexican = CType(value, string)
												
						Case "LEBeforeMexican"
							Me.str().LEBeforeMexican = CType(value, string)
												
						Case "ActualLEAfterMexican"
							Me.str().ActualLEAfterMexican = CType(value, string)
												
						Case "LEAfterMexican"
							Me.str().LEAfterMexican = CType(value, string)
												
						Case "ActualLECostMexican"
							Me.str().ActualLECostMexican = CType(value, string)
												
						Case "LECostMexican"
							Me.str().LECostMexican = CType(value, string)
												
						Case "ActualLEBeforeNewZealand"
							Me.str().ActualLEBeforeNewZealand = CType(value, string)
												
						Case "LEBeforeNewZealand"
							Me.str().LEBeforeNewZealand = CType(value, string)
												
						Case "ActualLEAfterNewZealand"
							Me.str().ActualLEAfterNewZealand = CType(value, string)
												
						Case "LEAfterNewZealand"
							Me.str().LEAfterNewZealand = CType(value, string)
												
						Case "ActualLECostNewZealand"
							Me.str().ActualLECostNewZealand = CType(value, string)
												
						Case "LECostNewZealand"
							Me.str().LECostNewZealand = CType(value, string)
												
						Case "ActualLEBeforeUS"
							Me.str().ActualLEBeforeUS = CType(value, string)
												
						Case "LEBeforeUS"
							Me.str().LEBeforeUS = CType(value, string)
												
						Case "ActualLEAfterUS"
							Me.str().ActualLEAfterUS = CType(value, string)
												
						Case "LEAfterUS"
							Me.str().LEAfterUS = CType(value, string)
												
						Case "ActualLECostUS"
							Me.str().ActualLECostUS = CType(value, string)
												
						Case "LECostUS"
							Me.str().LECostUS = CType(value, string)
												
						Case "ActualCostToComplete"
							Me.str().ActualCostToComplete = CType(value, string)
												
						Case "ActualCostToCompleteAustralian"
							Me.str().ActualCostToCompleteAustralian = CType(value, string)
												
						Case "ActualCostToCompleteBritish"
							Me.str().ActualCostToCompleteBritish = CType(value, string)
												
						Case "ActualCostToCompleteCanadian"
							Me.str().ActualCostToCompleteCanadian = CType(value, string)
												
						Case "ActualCostToCompleteEuro"
							Me.str().ActualCostToCompleteEuro = CType(value, string)
												
						Case "ActualCostToCompleteJapanese"
							Me.str().ActualCostToCompleteJapanese = CType(value, string)
												
						Case "ActualCostToCompleteMexican"
							Me.str().ActualCostToCompleteMexican = CType(value, string)
												
						Case "ActualCostToCompleteNewZealand"
							Me.str().ActualCostToCompleteNewZealand = CType(value, string)
												
						Case "ActualCostToCompleteUS"
							Me.str().ActualCostToCompleteUS = CType(value, string)
												
						Case "SavingsRatio"
							Me.str().SavingsRatio = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "PlantFeedback"
							Me.str().PlantFeedback = CType(value, string)
												
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
												
						Case "ExpectedCompletionDateMonth"
							Me.str().ExpectedCompletionDateMonth = CType(value, string)
												
						Case "ExpectedCompletionDateYear"
							Me.str().ExpectedCompletionDateYear = CType(value, string)
												
						Case "StatusDateMonth"
							Me.str().StatusDateMonth = CType(value, string)
												
						Case "StatusDateYear"
							Me.str().StatusDateYear = CType(value, string)
												
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
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Tivus)
							End If
						
						Case "RespRequestDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespRequestDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDate)
							End If
						
						Case "RespDueDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespDueDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDate)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "DaysOverdue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DaysOverdue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.DaysOverdue)
							End If
						
						Case "RFU1Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU1Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1Date)
							End If
						
						Case "RFU2Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU2Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2Date)
							End If
						
						Case "RFU3Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU3Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3Date)
							End If
						
						Case "ExpectedCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDate)
							End If
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecYear)
							End If
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecNumber)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDate)
							End If
						
						Case "LossExpectancyBeforeActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyBeforeActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyBeforeActual)
							End If
						
						Case "LossExpectancyAfterActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyAfterActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyAfterActual)
							End If
						
						Case "CostToCompleteActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.CostToCompleteActual)
							End If
						
						Case "ActualLEBeforeAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeAustralian)
							End If
						
						Case "ActualLEAfterAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterAustralian)
							End If
						
						Case "ActualLECostAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostAustralian)
							End If
						
						Case "ActualLEBeforeBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeBritish)
							End If
						
						Case "ActualLEAfterBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterBritish)
							End If
						
						Case "ActualLECostBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostBritish)
							End If
						
						Case "ActualLEBeforeCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeCanadian)
							End If
						
						Case "ActualLEAfterCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterCanadian)
							End If
						
						Case "ActualLECostCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostCanadian)
							End If
						
						Case "ActualLEBeforeEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeEuro)
							End If
						
						Case "ActualLEAfterEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterEuro)
							End If
						
						Case "ActualLECostEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostEuro)
							End If
						
						Case "ActualLEBeforeJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeJapanese)
							End If
						
						Case "ActualLEAfterJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterJapanese)
							End If
						
						Case "ActualLECostJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostJapanese)
							End If
						
						Case "ActualLEBeforeMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeMexican)
							End If
						
						Case "ActualLEAfterMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterMexican)
							End If
						
						Case "ActualLECostMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostMexican)
							End If
						
						Case "ActualLEBeforeNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeNewZealand)
							End If
						
						Case "ActualLEAfterNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterNewZealand)
							End If
						
						Case "ActualLECostNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostNewZealand)
							End If
						
						Case "ActualLEBeforeUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeUS)
							End If
						
						Case "ActualLEAfterUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterUS)
							End If
						
						Case "ActualLECostUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostUS)
							End If
						
						Case "ActualCostToComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ActualCostToComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToComplete)
							End If
						
						Case "ActualCostToCompleteAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteAustralian)
							End If
						
						Case "ActualCostToCompleteBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteBritish)
							End If
						
						Case "ActualCostToCompleteCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteCanadian)
							End If
						
						Case "ActualCostToCompleteEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteEuro)
							End If
						
						Case "ActualCostToCompleteJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteJapanese)
							End If
						
						Case "ActualCostToCompleteMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteMexican)
							End If
						
						Case "ActualCostToCompleteNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteNewZealand)
							End If
						
						Case "ActualCostToCompleteUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteUS)
							End If
						
						Case "SavingsRatio"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SavingsRatio = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.SavingsRatio)
							End If
						
						Case "RespRequestDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateMonth)
							End If
						
						Case "RespRequestDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateYear)
							End If
						
						Case "RespDueDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateMonth)
							End If
						
						Case "RespDueDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateYear)
							End If
						
						Case "ResponseDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateMonth)
							End If
						
						Case "ResponseDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateYear)
							End If
						
						Case "RFU1DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateMonth)
							End If
						
						Case "RFU1DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateYear)
							End If
						
						Case "RFU2DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateMonth)
							End If
						
						Case "RFU2DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateYear)
							End If
						
						Case "RFU3DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateMonth)
							End If
						
						Case "RFU3DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateYear)
							End If
						
						Case "ExpectedCompletionDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateMonth)
							End If
						
						Case "ExpectedCompletionDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateYear)
							End If
						
						Case "StatusDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateMonth)
							End If
						
						Case "StatusDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateYear)
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
		
			Public Sub New(ByVal entity As esVwNatHazWindRecommendationResponsesTrackingAll)
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
		  	
			Public Property RecPrefix As System.String 
				Get
					Dim data_ As System.String = entity.RecPrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecPrefix = Nothing
					Else
						entity.RecPrefix = Convert.ToString(Value)
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
		  	
			Public Property RecSubletter As System.String 
				Get
					Dim data_ As System.String = entity.RecSubletter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecSubletter = Nothing
					Else
						entity.RecSubletter = Convert.ToString(Value)
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
		  	
			Public Property RecCode As System.String 
				Get
					Dim data_ As System.String = entity.RecCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCode = Nothing
					Else
						entity.RecCode = Convert.ToString(Value)
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
		  	
			Public Property HazardPrimaryRecType As System.String 
				Get
					Dim data_ As System.String = entity.HazardPrimaryRecType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazardPrimaryRecType = Nothing
					Else
						entity.HazardPrimaryRecType = Convert.ToString(Value)
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
		  	
			Public Property RecKeyWords As System.String 
				Get
					Dim data_ As System.String = entity.RecKeyWords
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecKeyWords = Nothing
					Else
						entity.RecKeyWords = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyBeforeActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LossExpectancyBeforeActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyBeforeActual = Nothing
					Else
						entity.LossExpectancyBeforeActual = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyBefore As System.String 
				Get
					Dim data_ As System.String = entity.LossExpectancyBefore
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyBefore = Nothing
					Else
						entity.LossExpectancyBefore = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyAfterActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LossExpectancyAfterActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyAfterActual = Nothing
					Else
						entity.LossExpectancyAfterActual = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyAfter As System.String 
				Get
					Dim data_ As System.String = entity.LossExpectancyAfter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyAfter = Nothing
					Else
						entity.LossExpectancyAfter = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CostToCompleteActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CostToCompleteActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CostToCompleteActual = Nothing
					Else
						entity.CostToCompleteActual = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CostToComplete As System.String 
				Get
					Dim data_ As System.String = entity.CostToComplete
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CostToComplete = Nothing
					Else
						entity.CostToComplete = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEBeforeAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEBeforeAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEBeforeAustralian = Nothing
					Else
						entity.ActualLEBeforeAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEBeforeAustralian As System.String 
				Get
					Dim data_ As System.String = entity.LEBeforeAustralian
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEBeforeAustralian = Nothing
					Else
						entity.LEBeforeAustralian = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEAfterAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEAfterAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEAfterAustralian = Nothing
					Else
						entity.ActualLEAfterAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEAfterAustralian As System.String 
				Get
					Dim data_ As System.String = entity.LEAfterAustralian
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEAfterAustralian = Nothing
					Else
						entity.LEAfterAustralian = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLECostAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLECostAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLECostAustralian = Nothing
					Else
						entity.ActualLECostAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LECostAustralian As System.String 
				Get
					Dim data_ As System.String = entity.LECostAustralian
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LECostAustralian = Nothing
					Else
						entity.LECostAustralian = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEBeforeBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEBeforeBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEBeforeBritish = Nothing
					Else
						entity.ActualLEBeforeBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEBeforeBritish As System.String 
				Get
					Dim data_ As System.String = entity.LEBeforeBritish
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEBeforeBritish = Nothing
					Else
						entity.LEBeforeBritish = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEAfterBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEAfterBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEAfterBritish = Nothing
					Else
						entity.ActualLEAfterBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEAfterBritish As System.String 
				Get
					Dim data_ As System.String = entity.LEAfterBritish
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEAfterBritish = Nothing
					Else
						entity.LEAfterBritish = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLECostBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLECostBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLECostBritish = Nothing
					Else
						entity.ActualLECostBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LECostBritish As System.String 
				Get
					Dim data_ As System.String = entity.LECostBritish
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LECostBritish = Nothing
					Else
						entity.LECostBritish = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEBeforeCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEBeforeCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEBeforeCanadian = Nothing
					Else
						entity.ActualLEBeforeCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEBeforeCanadian As System.String 
				Get
					Dim data_ As System.String = entity.LEBeforeCanadian
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEBeforeCanadian = Nothing
					Else
						entity.LEBeforeCanadian = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEAfterCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEAfterCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEAfterCanadian = Nothing
					Else
						entity.ActualLEAfterCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEAfterCanadian As System.String 
				Get
					Dim data_ As System.String = entity.LEAfterCanadian
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEAfterCanadian = Nothing
					Else
						entity.LEAfterCanadian = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLECostCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLECostCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLECostCanadian = Nothing
					Else
						entity.ActualLECostCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LECostCanadian As System.String 
				Get
					Dim data_ As System.String = entity.LECostCanadian
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LECostCanadian = Nothing
					Else
						entity.LECostCanadian = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEBeforeEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEBeforeEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEBeforeEuro = Nothing
					Else
						entity.ActualLEBeforeEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEBeforeEuro As System.String 
				Get
					Dim data_ As System.String = entity.LEBeforeEuro
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEBeforeEuro = Nothing
					Else
						entity.LEBeforeEuro = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEAfterEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEAfterEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEAfterEuro = Nothing
					Else
						entity.ActualLEAfterEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEAfterEuro As System.String 
				Get
					Dim data_ As System.String = entity.LEAfterEuro
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEAfterEuro = Nothing
					Else
						entity.LEAfterEuro = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLECostEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLECostEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLECostEuro = Nothing
					Else
						entity.ActualLECostEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LECostEuro As System.String 
				Get
					Dim data_ As System.String = entity.LECostEuro
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LECostEuro = Nothing
					Else
						entity.LECostEuro = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEBeforeJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEBeforeJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEBeforeJapanese = Nothing
					Else
						entity.ActualLEBeforeJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEBeforeJapanese As System.String 
				Get
					Dim data_ As System.String = entity.LEBeforeJapanese
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEBeforeJapanese = Nothing
					Else
						entity.LEBeforeJapanese = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEAfterJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEAfterJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEAfterJapanese = Nothing
					Else
						entity.ActualLEAfterJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEAfterJapanese As System.String 
				Get
					Dim data_ As System.String = entity.LEAfterJapanese
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEAfterJapanese = Nothing
					Else
						entity.LEAfterJapanese = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLECostJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLECostJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLECostJapanese = Nothing
					Else
						entity.ActualLECostJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LECostJapanese As System.String 
				Get
					Dim data_ As System.String = entity.LECostJapanese
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LECostJapanese = Nothing
					Else
						entity.LECostJapanese = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEBeforeMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEBeforeMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEBeforeMexican = Nothing
					Else
						entity.ActualLEBeforeMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEBeforeMexican As System.String 
				Get
					Dim data_ As System.String = entity.LEBeforeMexican
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEBeforeMexican = Nothing
					Else
						entity.LEBeforeMexican = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEAfterMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEAfterMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEAfterMexican = Nothing
					Else
						entity.ActualLEAfterMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEAfterMexican As System.String 
				Get
					Dim data_ As System.String = entity.LEAfterMexican
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEAfterMexican = Nothing
					Else
						entity.LEAfterMexican = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLECostMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLECostMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLECostMexican = Nothing
					Else
						entity.ActualLECostMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LECostMexican As System.String 
				Get
					Dim data_ As System.String = entity.LECostMexican
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LECostMexican = Nothing
					Else
						entity.LECostMexican = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEBeforeNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEBeforeNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEBeforeNewZealand = Nothing
					Else
						entity.ActualLEBeforeNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEBeforeNewZealand As System.String 
				Get
					Dim data_ As System.String = entity.LEBeforeNewZealand
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEBeforeNewZealand = Nothing
					Else
						entity.LEBeforeNewZealand = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEAfterNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEAfterNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEAfterNewZealand = Nothing
					Else
						entity.ActualLEAfterNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEAfterNewZealand As System.String 
				Get
					Dim data_ As System.String = entity.LEAfterNewZealand
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEAfterNewZealand = Nothing
					Else
						entity.LEAfterNewZealand = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLECostNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLECostNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLECostNewZealand = Nothing
					Else
						entity.ActualLECostNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LECostNewZealand As System.String 
				Get
					Dim data_ As System.String = entity.LECostNewZealand
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LECostNewZealand = Nothing
					Else
						entity.LECostNewZealand = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEBeforeUS As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEBeforeUS
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEBeforeUS = Nothing
					Else
						entity.ActualLEBeforeUS = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEBeforeUS As System.String 
				Get
					Dim data_ As System.String = entity.LEBeforeUS
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEBeforeUS = Nothing
					Else
						entity.LEBeforeUS = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLEAfterUS As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLEAfterUS
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLEAfterUS = Nothing
					Else
						entity.ActualLEAfterUS = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEAfterUS As System.String 
				Get
					Dim data_ As System.String = entity.LEAfterUS
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEAfterUS = Nothing
					Else
						entity.LEAfterUS = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualLECostUS As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualLECostUS
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualLECostUS = Nothing
					Else
						entity.ActualLECostUS = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LECostUS As System.String 
				Get
					Dim data_ As System.String = entity.LECostUS
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LECostUS = Nothing
					Else
						entity.LECostUS = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ActualCostToComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToComplete = Nothing
					Else
						entity.ActualCostToComplete = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToCompleteAustralian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualCostToCompleteAustralian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToCompleteAustralian = Nothing
					Else
						entity.ActualCostToCompleteAustralian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToCompleteBritish As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualCostToCompleteBritish
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToCompleteBritish = Nothing
					Else
						entity.ActualCostToCompleteBritish = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToCompleteCanadian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualCostToCompleteCanadian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToCompleteCanadian = Nothing
					Else
						entity.ActualCostToCompleteCanadian = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToCompleteEuro As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualCostToCompleteEuro
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToCompleteEuro = Nothing
					Else
						entity.ActualCostToCompleteEuro = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToCompleteJapanese As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualCostToCompleteJapanese
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToCompleteJapanese = Nothing
					Else
						entity.ActualCostToCompleteJapanese = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToCompleteMexican As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualCostToCompleteMexican
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToCompleteMexican = Nothing
					Else
						entity.ActualCostToCompleteMexican = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToCompleteNewZealand As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualCostToCompleteNewZealand
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToCompleteNewZealand = Nothing
					Else
						entity.ActualCostToCompleteNewZealand = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToCompleteUS As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.ActualCostToCompleteUS
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToCompleteUS = Nothing
					Else
						entity.ActualCostToCompleteUS = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property SavingsRatio As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SavingsRatio
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SavingsRatio = Nothing
					Else
						entity.SavingsRatio = Convert.ToInt32(Value)
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
		  	
			Public Property PlantFeedback As System.String 
				Get
					Dim data_ As System.String = entity.PlantFeedback
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantFeedback = Nothing
					Else
						entity.PlantFeedback = Convert.ToString(Value)
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
		  

			Private entity As esVwNatHazWindRecommendationResponsesTrackingAll
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwNatHazWindRecommendationResponsesTrackingAllMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwNatHazWindRecommendationResponsesTrackingAllQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwNatHazWindRecommendationResponsesTrackingAllQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwNatHazWindRecommendationResponsesTrackingAllQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwNatHazWindRecommendationResponsesTrackingAllQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwNatHazWindRecommendationResponsesTrackingAllQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwNatHazWindRecommendationResponsesTrackingAllCollection
		Inherits esEntityCollection(Of VwNatHazWindRecommendationResponsesTrackingAll)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwNatHazWindRecommendationResponsesTrackingAllMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwNatHazWindRecommendationResponsesTrackingAllCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwNatHazWindRecommendationResponsesTrackingAllQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwNatHazWindRecommendationResponsesTrackingAllQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwNatHazWindRecommendationResponsesTrackingAllQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwNatHazWindRecommendationResponsesTrackingAllQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwNatHazWindRecommendationResponsesTrackingAllQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwNatHazWindRecommendationResponsesTrackingAllQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwNatHazWindRecommendationResponsesTrackingAllQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwNatHazWindRecommendationResponsesTrackingAllQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwNatHazWindRecommendationResponsesTrackingAllMetadata.Meta()
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
				Case "ResponseFrom" 
					Return Me.ResponseFrom
				Case "PlantComment" 
					Return Me.PlantComment
				Case "ExpectedCompletionDate" 
					Return Me.ExpectedCompletionDate
				Case "IntendedAction" 
					Return Me.IntendedAction
				Case "RecPrefix" 
					Return Me.RecPrefix
				Case "RecYear" 
					Return Me.RecYear
				Case "RecMonth" 
					Return Me.RecMonth
				Case "RecNumber" 
					Return Me.RecNumber
				Case "RecSubletter" 
					Return Me.RecSubletter
				Case "RecStatus" 
					Return Me.RecStatus
				Case "StatusDate" 
					Return Me.StatusDate
				Case "RecCode" 
					Return Me.RecCode
				Case "RecCategory" 
					Return Me.RecCategory
				Case "HazardPrimaryRecType" 
					Return Me.HazardPrimaryRecType
				Case "Hazard" 
					Return Me.Hazard
				Case "PrimaryRecType" 
					Return Me.PrimaryRecType
				Case "SecondaryRecType" 
					Return Me.SecondaryRecType
				Case "RecKeyWords" 
					Return Me.RecKeyWords
				Case "LossExpectancyBeforeActual" 
					Return Me.LossExpectancyBeforeActual
				Case "LossExpectancyBefore" 
					Return Me.LossExpectancyBefore
				Case "LossExpectancyAfterActual" 
					Return Me.LossExpectancyAfterActual
				Case "LossExpectancyAfter" 
					Return Me.LossExpectancyAfter
				Case "CostToCompleteActual" 
					Return Me.CostToCompleteActual
				Case "CostToComplete" 
					Return Me.CostToComplete
				Case "ActualLEBeforeAustralian" 
					Return Me.ActualLEBeforeAustralian
				Case "LEBeforeAustralian" 
					Return Me.LEBeforeAustralian
				Case "ActualLEAfterAustralian" 
					Return Me.ActualLEAfterAustralian
				Case "LEAfterAustralian" 
					Return Me.LEAfterAustralian
				Case "ActualLECostAustralian" 
					Return Me.ActualLECostAustralian
				Case "LECostAustralian" 
					Return Me.LECostAustralian
				Case "ActualLEBeforeBritish" 
					Return Me.ActualLEBeforeBritish
				Case "LEBeforeBritish" 
					Return Me.LEBeforeBritish
				Case "ActualLEAfterBritish" 
					Return Me.ActualLEAfterBritish
				Case "LEAfterBritish" 
					Return Me.LEAfterBritish
				Case "ActualLECostBritish" 
					Return Me.ActualLECostBritish
				Case "LECostBritish" 
					Return Me.LECostBritish
				Case "ActualLEBeforeCanadian" 
					Return Me.ActualLEBeforeCanadian
				Case "LEBeforeCanadian" 
					Return Me.LEBeforeCanadian
				Case "ActualLEAfterCanadian" 
					Return Me.ActualLEAfterCanadian
				Case "LEAfterCanadian" 
					Return Me.LEAfterCanadian
				Case "ActualLECostCanadian" 
					Return Me.ActualLECostCanadian
				Case "LECostCanadian" 
					Return Me.LECostCanadian
				Case "ActualLEBeforeEuro" 
					Return Me.ActualLEBeforeEuro
				Case "LEBeforeEuro" 
					Return Me.LEBeforeEuro
				Case "ActualLEAfterEuro" 
					Return Me.ActualLEAfterEuro
				Case "LEAfterEuro" 
					Return Me.LEAfterEuro
				Case "ActualLECostEuro" 
					Return Me.ActualLECostEuro
				Case "LECostEuro" 
					Return Me.LECostEuro
				Case "ActualLEBeforeJapanese" 
					Return Me.ActualLEBeforeJapanese
				Case "LEBeforeJapanese" 
					Return Me.LEBeforeJapanese
				Case "ActualLEAfterJapanese" 
					Return Me.ActualLEAfterJapanese
				Case "LEAfterJapanese" 
					Return Me.LEAfterJapanese
				Case "ActualLECostJapanese" 
					Return Me.ActualLECostJapanese
				Case "LECostJapanese" 
					Return Me.LECostJapanese
				Case "ActualLEBeforeMexican" 
					Return Me.ActualLEBeforeMexican
				Case "LEBeforeMexican" 
					Return Me.LEBeforeMexican
				Case "ActualLEAfterMexican" 
					Return Me.ActualLEAfterMexican
				Case "LEAfterMexican" 
					Return Me.LEAfterMexican
				Case "ActualLECostMexican" 
					Return Me.ActualLECostMexican
				Case "LECostMexican" 
					Return Me.LECostMexican
				Case "ActualLEBeforeNewZealand" 
					Return Me.ActualLEBeforeNewZealand
				Case "LEBeforeNewZealand" 
					Return Me.LEBeforeNewZealand
				Case "ActualLEAfterNewZealand" 
					Return Me.ActualLEAfterNewZealand
				Case "LEAfterNewZealand" 
					Return Me.LEAfterNewZealand
				Case "ActualLECostNewZealand" 
					Return Me.ActualLECostNewZealand
				Case "LECostNewZealand" 
					Return Me.LECostNewZealand
				Case "ActualLEBeforeUS" 
					Return Me.ActualLEBeforeUS
				Case "LEBeforeUS" 
					Return Me.LEBeforeUS
				Case "ActualLEAfterUS" 
					Return Me.ActualLEAfterUS
				Case "LEAfterUS" 
					Return Me.LEAfterUS
				Case "ActualLECostUS" 
					Return Me.ActualLECostUS
				Case "LECostUS" 
					Return Me.LECostUS
				Case "ActualCostToComplete" 
					Return Me.ActualCostToComplete
				Case "ActualCostToCompleteAustralian" 
					Return Me.ActualCostToCompleteAustralian
				Case "ActualCostToCompleteBritish" 
					Return Me.ActualCostToCompleteBritish
				Case "ActualCostToCompleteCanadian" 
					Return Me.ActualCostToCompleteCanadian
				Case "ActualCostToCompleteEuro" 
					Return Me.ActualCostToCompleteEuro
				Case "ActualCostToCompleteJapanese" 
					Return Me.ActualCostToCompleteJapanese
				Case "ActualCostToCompleteMexican" 
					Return Me.ActualCostToCompleteMexican
				Case "ActualCostToCompleteNewZealand" 
					Return Me.ActualCostToCompleteNewZealand
				Case "ActualCostToCompleteUS" 
					Return Me.ActualCostToCompleteUS
				Case "SavingsRatio" 
					Return Me.SavingsRatio
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "PlantFeedback" 
					Return Me.PlantFeedback
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
				Case "ExpectedCompletionDateMonth" 
					Return Me.ExpectedCompletionDateMonth
				Case "ExpectedCompletionDateYear" 
					Return Me.ExpectedCompletionDateYear
				Case "StatusDateMonth" 
					Return Me.StatusDateMonth
				Case "StatusDateYear" 
					Return Me.StatusDateYear
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
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DaysOverdue As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.DaysOverdue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseFrom As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantComment As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecPrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecPrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecMonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecSubletter As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecSubletter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecCode As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategory As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazardPrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.HazardPrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecKeyWords As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecKeyWords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyBeforeActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBefore As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyBefore, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyAfterActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfter As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyAfter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CostToCompleteActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CostToComplete, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property SavingsRatio As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.SavingsRatio, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantFeedback As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantFeedback, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateString, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwNatHazWindRecommendationResponsesTrackingAllMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.FilePrefix, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Facility, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Address, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.City, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StProv, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Country, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames._100PercentUSTot, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVAustralian, 11, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVBritish, 12, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVCanadian, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVEuro, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVJapanese, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVMexican, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.TIVNewZealand, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Tivus, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseStatus, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseStatus
			c.CharacterMaxLength = 12
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDate, 20, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDate, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.DaysOverdue, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.DaysOverdue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1Date, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2Date, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3Date, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientName, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecipientName
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecipientEmail, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecipientEmail
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseFrom, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantComment, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.PlantComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDate, 31, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.IntendedAction, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecPrefix, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecPrefix
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecYear, 34, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecMonth, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecMonth
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecNumber, 36, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecSubletter, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecSubletter
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecStatus, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDate, 39, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCode, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecCode
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecCategory, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecCategory
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.HazardPrimaryRecType, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.HazardPrimaryRecType
			c.CharacterMaxLength = 265
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.Hazard, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 7
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PrimaryRecType, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.SecondaryRecType, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RecKeyWords, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RecKeyWords
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyBeforeActual, 47, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyBeforeActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyBefore, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyBefore
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyAfterActual, 49, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyAfterActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LossExpectancyAfter, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LossExpectancyAfter
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CostToCompleteActual, 51, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.CostToCompleteActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CostToComplete, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.CostToComplete
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeAustralian, 53, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeAustralian, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterAustralian, 55, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterAustralian, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostAustralian, 57, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostAustralian, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeBritish, 59, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeBritish, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterBritish, 61, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterBritish, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostBritish, 63, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostBritish, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeCanadian, 65, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeCanadian, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterCanadian, 67, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterCanadian, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostCanadian, 69, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostCanadian, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeEuro, 71, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeEuro, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterEuro, 73, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterEuro, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostEuro, 75, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostEuro, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeJapanese, 77, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeJapanese, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterJapanese, 79, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterJapanese, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostJapanese, 81, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostJapanese, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeMexican, 83, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeMexican, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterMexican, 85, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterMexican, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostMexican, 87, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostMexican, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeNewZealand, 89, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeNewZealand, 90, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterNewZealand, 91, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterNewZealand, 92, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostNewZealand, 93, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostNewZealand, 94, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEBeforeUS, 95, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEBeforeUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEBeforeUS, 96, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEBeforeUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLEAfterUS, 97, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLEAfterUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LEAfterUS, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LEAfterUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualLECostUS, 99, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualLECostUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.LECostUS, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.LECostUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToComplete, 101, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteAustralian, 102, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteBritish, 103, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteCanadian, 104, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteEuro, 105, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteJapanese, 106, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteMexican, 107, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteNewZealand, 108, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ActualCostToCompleteUS, 109, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ActualCostToCompleteUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.SavingsRatio, 110, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.SavingsRatio
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.CustomAccess, 111, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.PlantFeedback, 112, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.PlantFeedback
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateMonth, 113, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateYear, 114, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateMonth, 115, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateYear, 116, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateMonth, 117, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateYear, 118, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateMonth, 119, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateYear, 120, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateMonth, 121, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateYear, 122, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateMonth, 123, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateYear, 124, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateMonth, 125, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateYear, 126, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateMonth, 127, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateYear, 128, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespRequestDateString, 129, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespRequestDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RespDueDateString, 130, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RespDueDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ResponseDateString, 131, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ResponseDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU1DateString, 132, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU1DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU2DateString, 133, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU2DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.RFU3DateString, 134, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.RFU3DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.ExpectedCompletionDateString, 135, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.ExpectedCompletionDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwNatHazWindRecommendationResponsesTrackingAllMetadata.ColumnNames.StatusDateString, 136, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwNatHazWindRecommendationResponsesTrackingAllMetadata.PropertyNames.StatusDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwNatHazWindRecommendationResponsesTrackingAllMetadata
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
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const RecPrefix As String = "RecPrefix"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecSubletter As String = "RecSubletter"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const HazardPrimaryRecType As String = "HazardPrimaryRecType"
			 Public Const Hazard As String = "Hazard"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecKeyWords As String = "RecKeyWords"
			 Public Const LossExpectancyBeforeActual As String = "LossExpectancyBeforeActual"
			 Public Const LossExpectancyBefore As String = "LossExpectancyBefore"
			 Public Const LossExpectancyAfterActual As String = "LossExpectancyAfterActual"
			 Public Const LossExpectancyAfter As String = "LossExpectancyAfter"
			 Public Const CostToCompleteActual As String = "CostToCompleteActual"
			 Public Const CostToComplete As String = "CostToComplete"
			 Public Const ActualLEBeforeAustralian As String = "ActualLEBeforeAustralian"
			 Public Const LEBeforeAustralian As String = "LEBeforeAustralian"
			 Public Const ActualLEAfterAustralian As String = "ActualLEAfterAustralian"
			 Public Const LEAfterAustralian As String = "LEAfterAustralian"
			 Public Const ActualLECostAustralian As String = "ActualLECostAustralian"
			 Public Const LECostAustralian As String = "LECostAustralian"
			 Public Const ActualLEBeforeBritish As String = "ActualLEBeforeBritish"
			 Public Const LEBeforeBritish As String = "LEBeforeBritish"
			 Public Const ActualLEAfterBritish As String = "ActualLEAfterBritish"
			 Public Const LEAfterBritish As String = "LEAfterBritish"
			 Public Const ActualLECostBritish As String = "ActualLECostBritish"
			 Public Const LECostBritish As String = "LECostBritish"
			 Public Const ActualLEBeforeCanadian As String = "ActualLEBeforeCanadian"
			 Public Const LEBeforeCanadian As String = "LEBeforeCanadian"
			 Public Const ActualLEAfterCanadian As String = "ActualLEAfterCanadian"
			 Public Const LEAfterCanadian As String = "LEAfterCanadian"
			 Public Const ActualLECostCanadian As String = "ActualLECostCanadian"
			 Public Const LECostCanadian As String = "LECostCanadian"
			 Public Const ActualLEBeforeEuro As String = "ActualLEBeforeEuro"
			 Public Const LEBeforeEuro As String = "LEBeforeEuro"
			 Public Const ActualLEAfterEuro As String = "ActualLEAfterEuro"
			 Public Const LEAfterEuro As String = "LEAfterEuro"
			 Public Const ActualLECostEuro As String = "ActualLECostEuro"
			 Public Const LECostEuro As String = "LECostEuro"
			 Public Const ActualLEBeforeJapanese As String = "ActualLEBeforeJapanese"
			 Public Const LEBeforeJapanese As String = "LEBeforeJapanese"
			 Public Const ActualLEAfterJapanese As String = "ActualLEAfterJapanese"
			 Public Const LEAfterJapanese As String = "LEAfterJapanese"
			 Public Const ActualLECostJapanese As String = "ActualLECostJapanese"
			 Public Const LECostJapanese As String = "LECostJapanese"
			 Public Const ActualLEBeforeMexican As String = "ActualLEBeforeMexican"
			 Public Const LEBeforeMexican As String = "LEBeforeMexican"
			 Public Const ActualLEAfterMexican As String = "ActualLEAfterMexican"
			 Public Const LEAfterMexican As String = "LEAfterMexican"
			 Public Const ActualLECostMexican As String = "ActualLECostMexican"
			 Public Const LECostMexican As String = "LECostMexican"
			 Public Const ActualLEBeforeNewZealand As String = "ActualLEBeforeNewZealand"
			 Public Const LEBeforeNewZealand As String = "LEBeforeNewZealand"
			 Public Const ActualLEAfterNewZealand As String = "ActualLEAfterNewZealand"
			 Public Const LEAfterNewZealand As String = "LEAfterNewZealand"
			 Public Const ActualLECostNewZealand As String = "ActualLECostNewZealand"
			 Public Const LECostNewZealand As String = "LECostNewZealand"
			 Public Const ActualLEBeforeUS As String = "ActualLEBeforeUS"
			 Public Const LEBeforeUS As String = "LEBeforeUS"
			 Public Const ActualLEAfterUS As String = "ActualLEAfterUS"
			 Public Const LEAfterUS As String = "LEAfterUS"
			 Public Const ActualLECostUS As String = "ActualLECostUS"
			 Public Const LECostUS As String = "LECostUS"
			 Public Const ActualCostToComplete As String = "ActualCostToComplete"
			 Public Const ActualCostToCompleteAustralian As String = "ActualCostToCompleteAustralian"
			 Public Const ActualCostToCompleteBritish As String = "ActualCostToCompleteBritish"
			 Public Const ActualCostToCompleteCanadian As String = "ActualCostToCompleteCanadian"
			 Public Const ActualCostToCompleteEuro As String = "ActualCostToCompleteEuro"
			 Public Const ActualCostToCompleteJapanese As String = "ActualCostToCompleteJapanese"
			 Public Const ActualCostToCompleteMexican As String = "ActualCostToCompleteMexican"
			 Public Const ActualCostToCompleteNewZealand As String = "ActualCostToCompleteNewZealand"
			 Public Const ActualCostToCompleteUS As String = "ActualCostToCompleteUS"
			 Public Const SavingsRatio As String = "SavingsRatio"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const PlantFeedback As String = "PlantFeedback"
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
			 Public Const ExpectedCompletionDateMonth As String = "ExpectedCompletionDateMonth"
			 Public Const ExpectedCompletionDateYear As String = "ExpectedCompletionDateYear"
			 Public Const StatusDateMonth As String = "StatusDateMonth"
			 Public Const StatusDateYear As String = "StatusDateYear"
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
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const RecPrefix As String = "RecPrefix"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecSubletter As String = "RecSubletter"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const HazardPrimaryRecType As String = "HazardPrimaryRecType"
			 Public Const Hazard As String = "Hazard"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecKeyWords As String = "RecKeyWords"
			 Public Const LossExpectancyBeforeActual As String = "LossExpectancyBeforeActual"
			 Public Const LossExpectancyBefore As String = "LossExpectancyBefore"
			 Public Const LossExpectancyAfterActual As String = "LossExpectancyAfterActual"
			 Public Const LossExpectancyAfter As String = "LossExpectancyAfter"
			 Public Const CostToCompleteActual As String = "CostToCompleteActual"
			 Public Const CostToComplete As String = "CostToComplete"
			 Public Const ActualLEBeforeAustralian As String = "ActualLEBeforeAustralian"
			 Public Const LEBeforeAustralian As String = "LEBeforeAustralian"
			 Public Const ActualLEAfterAustralian As String = "ActualLEAfterAustralian"
			 Public Const LEAfterAustralian As String = "LEAfterAustralian"
			 Public Const ActualLECostAustralian As String = "ActualLECostAustralian"
			 Public Const LECostAustralian As String = "LECostAustralian"
			 Public Const ActualLEBeforeBritish As String = "ActualLEBeforeBritish"
			 Public Const LEBeforeBritish As String = "LEBeforeBritish"
			 Public Const ActualLEAfterBritish As String = "ActualLEAfterBritish"
			 Public Const LEAfterBritish As String = "LEAfterBritish"
			 Public Const ActualLECostBritish As String = "ActualLECostBritish"
			 Public Const LECostBritish As String = "LECostBritish"
			 Public Const ActualLEBeforeCanadian As String = "ActualLEBeforeCanadian"
			 Public Const LEBeforeCanadian As String = "LEBeforeCanadian"
			 Public Const ActualLEAfterCanadian As String = "ActualLEAfterCanadian"
			 Public Const LEAfterCanadian As String = "LEAfterCanadian"
			 Public Const ActualLECostCanadian As String = "ActualLECostCanadian"
			 Public Const LECostCanadian As String = "LECostCanadian"
			 Public Const ActualLEBeforeEuro As String = "ActualLEBeforeEuro"
			 Public Const LEBeforeEuro As String = "LEBeforeEuro"
			 Public Const ActualLEAfterEuro As String = "ActualLEAfterEuro"
			 Public Const LEAfterEuro As String = "LEAfterEuro"
			 Public Const ActualLECostEuro As String = "ActualLECostEuro"
			 Public Const LECostEuro As String = "LECostEuro"
			 Public Const ActualLEBeforeJapanese As String = "ActualLEBeforeJapanese"
			 Public Const LEBeforeJapanese As String = "LEBeforeJapanese"
			 Public Const ActualLEAfterJapanese As String = "ActualLEAfterJapanese"
			 Public Const LEAfterJapanese As String = "LEAfterJapanese"
			 Public Const ActualLECostJapanese As String = "ActualLECostJapanese"
			 Public Const LECostJapanese As String = "LECostJapanese"
			 Public Const ActualLEBeforeMexican As String = "ActualLEBeforeMexican"
			 Public Const LEBeforeMexican As String = "LEBeforeMexican"
			 Public Const ActualLEAfterMexican As String = "ActualLEAfterMexican"
			 Public Const LEAfterMexican As String = "LEAfterMexican"
			 Public Const ActualLECostMexican As String = "ActualLECostMexican"
			 Public Const LECostMexican As String = "LECostMexican"
			 Public Const ActualLEBeforeNewZealand As String = "ActualLEBeforeNewZealand"
			 Public Const LEBeforeNewZealand As String = "LEBeforeNewZealand"
			 Public Const ActualLEAfterNewZealand As String = "ActualLEAfterNewZealand"
			 Public Const LEAfterNewZealand As String = "LEAfterNewZealand"
			 Public Const ActualLECostNewZealand As String = "ActualLECostNewZealand"
			 Public Const LECostNewZealand As String = "LECostNewZealand"
			 Public Const ActualLEBeforeUS As String = "ActualLEBeforeUS"
			 Public Const LEBeforeUS As String = "LEBeforeUS"
			 Public Const ActualLEAfterUS As String = "ActualLEAfterUS"
			 Public Const LEAfterUS As String = "LEAfterUS"
			 Public Const ActualLECostUS As String = "ActualLECostUS"
			 Public Const LECostUS As String = "LECostUS"
			 Public Const ActualCostToComplete As String = "ActualCostToComplete"
			 Public Const ActualCostToCompleteAustralian As String = "ActualCostToCompleteAustralian"
			 Public Const ActualCostToCompleteBritish As String = "ActualCostToCompleteBritish"
			 Public Const ActualCostToCompleteCanadian As String = "ActualCostToCompleteCanadian"
			 Public Const ActualCostToCompleteEuro As String = "ActualCostToCompleteEuro"
			 Public Const ActualCostToCompleteJapanese As String = "ActualCostToCompleteJapanese"
			 Public Const ActualCostToCompleteMexican As String = "ActualCostToCompleteMexican"
			 Public Const ActualCostToCompleteNewZealand As String = "ActualCostToCompleteNewZealand"
			 Public Const ActualCostToCompleteUS As String = "ActualCostToCompleteUS"
			 Public Const SavingsRatio As String = "SavingsRatio"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const PlantFeedback As String = "PlantFeedback"
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
			 Public Const ExpectedCompletionDateMonth As String = "ExpectedCompletionDateMonth"
			 Public Const ExpectedCompletionDateYear As String = "ExpectedCompletionDateYear"
			 Public Const StatusDateMonth As String = "StatusDateMonth"
			 Public Const StatusDateYear As String = "StatusDateYear"
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
			SyncLock GetType(VwNatHazWindRecommendationResponsesTrackingAllMetadata)
			
				If VwNatHazWindRecommendationResponsesTrackingAllMetadata.mapDelegates Is Nothing Then
					VwNatHazWindRecommendationResponsesTrackingAllMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwNatHazWindRecommendationResponsesTrackingAllMetadata._meta Is Nothing Then
					VwNatHazWindRecommendationResponsesTrackingAllMetadata._meta = New VwNatHazWindRecommendationResponsesTrackingAllMetadata()
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
				meta.AddTypeMap("ResponseFrom", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("IntendedAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecPrefix", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecMonth", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecSubletter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StatusDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("RecCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecCategory", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HazardPrimaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PrimaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SecondaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecKeyWords", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LossExpectancyBeforeActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LossExpectancyBefore", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LossExpectancyAfterActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LossExpectancyAfter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CostToCompleteActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CostToComplete", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeAustralian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterAustralian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostAustralian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeBritish", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterBritish", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostBritish", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeCanadian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterCanadian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostCanadian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeEuro", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterEuro", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostEuro", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeJapanese", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterJapanese", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostJapanese", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeMexican", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterMexican", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostMexican", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeNewZealand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterNewZealand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostNewZealand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeUS", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeUS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterUS", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterUS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostUS", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostUS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualCostToComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ActualCostToCompleteAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("ActualCostToCompleteBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("ActualCostToCompleteCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("ActualCostToCompleteEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("ActualCostToCompleteJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("ActualCostToCompleteMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("ActualCostToCompleteNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("ActualCostToCompleteUS", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("SavingsRatio", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantFeedback", new esTypeMap("nvarchar", "System.String"))
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
				meta.AddTypeMap("ExpectedCompletionDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExpectedCompletionDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StatusDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StatusDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespRequestDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RespDueDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ResponseDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU1DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU2DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU3DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StatusDateString", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "vwNatHazWindRecommendationResponsesTrackingAll"
				meta.Destination = "vwNatHazWindRecommendationResponsesTrackingAll"
				
				meta.spInsert = "proc_vwNatHazWindRecommendationResponsesTrackingAllInsert"
				meta.spUpdate = "proc_vwNatHazWindRecommendationResponsesTrackingAllUpdate"
				meta.spDelete = "proc_vwNatHazWindRecommendationResponsesTrackingAllDelete"
				meta.spLoadAll = "proc_vwNatHazWindRecommendationResponsesTrackingAllLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwNatHazWindRecommendationResponsesTrackingAllLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwNatHazWindRecommendationResponsesTrackingAllMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
