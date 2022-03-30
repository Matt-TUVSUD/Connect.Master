
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/30/2019 10:09:36 AM
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
	' Encapsulates the 'vwFireRecommendationsFollowUpBaseView' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwFireRecommendationsFollowUpBaseView))> _
	<XmlType("VwFireRecommendationsFollowUpBaseView")> _	
	Partial Public Class VwFireRecommendationsFollowUpBaseView 
		Inherits esVwFireRecommendationsFollowUpBaseView
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwFireRecommendationsFollowUpBaseView()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwFireRecommendationsFollowUpBaseViewCollection")> _
	Partial Public Class VwFireRecommendationsFollowUpBaseViewCollection
		Inherits esVwFireRecommendationsFollowUpBaseViewCollection
		Implements IEnumerable(Of VwFireRecommendationsFollowUpBaseView)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwFireRecommendationsFollowUpBaseView))> _
		Public Class VwFireRecommendationsFollowUpBaseViewCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwFireRecommendationsFollowUpBaseViewCollection)
			
			Public Shared Widening Operator CType(packet As VwFireRecommendationsFollowUpBaseViewCollectionWCFPacket) As VwFireRecommendationsFollowUpBaseViewCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwFireRecommendationsFollowUpBaseViewCollection) As VwFireRecommendationsFollowUpBaseViewCollectionWCFPacket
				Return New VwFireRecommendationsFollowUpBaseViewCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwFireRecommendationsFollowUpBaseViewQuery 
		Inherits esVwFireRecommendationsFollowUpBaseViewQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwFireRecommendationsFollowUpBaseViewQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwFireRecommendationsFollowUpBaseViewQuery) As String
			Return VwFireRecommendationsFollowUpBaseViewQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwFireRecommendationsFollowUpBaseViewQuery
			Return DirectCast(VwFireRecommendationsFollowUpBaseViewQuery.SerializeHelper.FromXml(query, GetType(VwFireRecommendationsFollowUpBaseViewQuery)), VwFireRecommendationsFollowUpBaseViewQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwFireRecommendationsFollowUpBaseView
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.StProvName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProvName As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.StProvName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.StProvName, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.StProvName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.LastInspDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastInspDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.LastInspDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.LastInspDate, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.LastInspDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RespRequestDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDate, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.AutoRequest
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AutoRequest As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.AutoRequest)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.AutoRequest, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.AutoRequest)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.TotalNoRecs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalNoRecs As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.TotalNoRecs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.TotalNoRecs, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.TotalNoRecs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.NoActiveRecs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoActiveRecs As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoActiveRecs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoActiveRecs, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.NoActiveRecs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.NoRecsNeedingResp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoRecsNeedingResp As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoRecsNeedingResp)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoRecsNeedingResp, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.NoRecsNeedingResp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RespDueDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDate, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.DaysOverdue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DaysOverdue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.DaysOverdue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.DaysOverdue, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.DaysOverdue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU1Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1Date, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU2Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2Date, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU3Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3Date, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RespRequestDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateString, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RespDueDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateString, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU1DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateString, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU2DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateString, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU3DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateString, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RespRequestDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RespRequestDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RespDueDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RespDueDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU1DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU1DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU2DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU2DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU3DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RFU3DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.ResponseStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatus As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ResponseStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ResponseStatus, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.ResponseStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RecipientEmail, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.RecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientName As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RecipientName, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.ResponseStatusColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatusColor As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ResponseStatusColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ResponseStatusColor, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.ResponseStatusColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsFollowUpBaseView.NoRecsNeedingRespColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoRecsNeedingRespColor As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoRecsNeedingRespColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoRecsNeedingRespColor, value) Then
					OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.NoRecsNeedingRespColor)
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
												
						Case "Zip"
							Me.str().Zip = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "Tivus"
							Me.str().Tivus = CType(value, string)
												
						Case "StProvName"
							Me.str().StProvName = CType(value, string)
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "LastInspDate"
							Me.str().LastInspDate = CType(value, string)
												
						Case "RespRequestDate"
							Me.str().RespRequestDate = CType(value, string)
												
						Case "AutoRequest"
							Me.str().AutoRequest = CType(value, string)
												
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
												
						Case "ResponseStatus"
							Me.str().ResponseStatus = CType(value, string)
												
						Case "RecipientEmail"
							Me.str().RecipientEmail = CType(value, string)
												
						Case "RecipientName"
							Me.str().RecipientName = CType(value, string)
												
						Case "ResponseStatusColor"
							Me.str().ResponseStatusColor = CType(value, string)
												
						Case "NoRecsNeedingRespColor"
							Me.str().NoRecsNeedingRespColor = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Tivus = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Tivus)
							End If
						
						Case "LastInspDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastInspDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.LastInspDate)
							End If
						
						Case "RespRequestDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespRequestDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDate)
							End If
						
						Case "TotalNoRecs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalNoRecs = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.TotalNoRecs)
							End If
						
						Case "NoActiveRecs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NoActiveRecs = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.NoActiveRecs)
							End If
						
						Case "NoRecsNeedingResp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NoRecsNeedingResp = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.NoRecsNeedingResp)
							End If
						
						Case "RespDueDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespDueDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDate)
							End If
						
						Case "DaysOverdue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DaysOverdue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.DaysOverdue)
							End If
						
						Case "RFU1Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU1Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1Date)
							End If
						
						Case "RFU2Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU2Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2Date)
							End If
						
						Case "RFU3Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU3Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3Date)
							End If
						
						Case "RespRequestDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDateMonth)
							End If
						
						Case "RespRequestDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDateYear)
							End If
						
						Case "RespDueDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDateMonth)
							End If
						
						Case "RespDueDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDateYear)
							End If
						
						Case "RFU1DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1DateMonth)
							End If
						
						Case "RFU1DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1DateYear)
							End If
						
						Case "RFU2DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2DateMonth)
							End If
						
						Case "RFU2DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2DateYear)
							End If
						
						Case "RFU3DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3DateMonth)
							End If
						
						Case "RFU3DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3DateYear)
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
		
			Public Sub New(ByVal entity As esVwFireRecommendationsFollowUpBaseView)
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
		  	
			Public Property Zip As System.String 
				Get
					Dim data_ As System.String = entity.Zip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Zip = Nothing
					Else
						entity.Zip = Convert.ToString(Value)
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
		  	
			Public Property Latitude As System.String 
				Get
					Dim data_ As System.String = entity.Latitude
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Latitude = Nothing
					Else
						entity.Latitude = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Longitude As System.String 
				Get
					Dim data_ As System.String = entity.Longitude
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Longitude = Nothing
					Else
						entity.Longitude = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Tivus As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Tivus
					
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
						entity.Tivus = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property StProvName As System.String 
				Get
					Dim data_ As System.String = entity.StProvName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StProvName = Nothing
					Else
						entity.StProvName = Convert.ToString(Value)
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
		  	
			Public Property ResponseStatusColor As System.String 
				Get
					Dim data_ As System.String = entity.ResponseStatusColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseStatusColor = Nothing
					Else
						entity.ResponseStatusColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoRecsNeedingRespColor As System.String 
				Get
					Dim data_ As System.String = entity.NoRecsNeedingRespColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoRecsNeedingRespColor = Nothing
					Else
						entity.NoRecsNeedingRespColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVwFireRecommendationsFollowUpBaseView
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireRecommendationsFollowUpBaseViewMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwFireRecommendationsFollowUpBaseViewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireRecommendationsFollowUpBaseViewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwFireRecommendationsFollowUpBaseViewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwFireRecommendationsFollowUpBaseViewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwFireRecommendationsFollowUpBaseViewQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwFireRecommendationsFollowUpBaseViewCollection
		Inherits esEntityCollection(Of VwFireRecommendationsFollowUpBaseView)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireRecommendationsFollowUpBaseViewMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwFireRecommendationsFollowUpBaseViewCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwFireRecommendationsFollowUpBaseViewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireRecommendationsFollowUpBaseViewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwFireRecommendationsFollowUpBaseViewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwFireRecommendationsFollowUpBaseViewQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwFireRecommendationsFollowUpBaseViewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwFireRecommendationsFollowUpBaseViewQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwFireRecommendationsFollowUpBaseViewQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwFireRecommendationsFollowUpBaseViewQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwFireRecommendationsFollowUpBaseViewMetadata.Meta()
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
				Case "Zip" 
					Return Me.Zip
				Case "Country" 
					Return Me.Country
				Case "Latitude" 
					Return Me.Latitude
				Case "Longitude" 
					Return Me.Longitude
				Case "Tivus" 
					Return Me.Tivus
				Case "StProvName" 
					Return Me.StProvName
				Case "Hazard" 
					Return Me.Hazard
				Case "LastInspDate" 
					Return Me.LastInspDate
				Case "RespRequestDate" 
					Return Me.RespRequestDate
				Case "AutoRequest" 
					Return Me.AutoRequest
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
				Case "ResponseStatus" 
					Return Me.ResponseStatus
				Case "RecipientEmail" 
					Return Me.RecipientEmail
				Case "RecipientName" 
					Return Me.RecipientName
				Case "ResponseStatusColor" 
					Return Me.ResponseStatusColor
				Case "NoRecsNeedingRespColor" 
					Return Me.NoRecsNeedingRespColor
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Latitude, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Longitude, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Tivus, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property StProvName As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.StProvName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastInspDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.LastInspDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AutoRequest As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.AutoRequest, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalNoRecs As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.TotalNoRecs, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NoActiveRecs As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoActiveRecs, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NoRecsNeedingResp As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoRecsNeedingResp, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DaysOverdue As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.DaysOverdue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ResponseStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatusColor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ResponseStatusColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoRecsNeedingRespColor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoRecsNeedingRespColor, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwFireRecommendationsFollowUpBaseViewMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.FilePrefix, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.CustomAccess, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Facility, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Address, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.City, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.StProv, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Zip, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Country, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Latitude, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Latitude
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Longitude, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Longitude
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Tivus, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Tivus
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.StProvName, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.StProvName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.Hazard, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.LastInspDate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.LastInspDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDate, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.AutoRequest, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.AutoRequest
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.TotalNoRecs, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.TotalNoRecs
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoActiveRecs, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.NoActiveRecs
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoRecsNeedingResp, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.NoRecsNeedingResp
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.DaysOverdue, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.DaysOverdue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1Date, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2Date, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3Date, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateString, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateString, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateString, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateString, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateString, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateMonth, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespRequestDateYear, 34, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespRequestDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateMonth, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RespDueDateYear, 36, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RespDueDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateMonth, 37, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU1DateYear, 38, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU1DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateMonth, 39, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU2DateYear, 40, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU2DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateMonth, 41, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RFU3DateYear, 42, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RFU3DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ResponseStatus, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.ResponseStatus
			c.CharacterMaxLength = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RecipientEmail, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RecipientEmail
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.RecipientName, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.RecipientName
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.ResponseStatusColor, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.ResponseStatusColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsFollowUpBaseViewMetadata.ColumnNames.NoRecsNeedingRespColor, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsFollowUpBaseViewMetadata.PropertyNames.NoRecsNeedingRespColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwFireRecommendationsFollowUpBaseViewMetadata
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
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Latitude As String = "latitude"
			 Public Const Longitude As String = "longitude"
			 Public Const Tivus As String = "TIVUS"
			 Public Const StProvName As String = "StProvName"
			 Public Const Hazard As String = "Hazard"
			 Public Const LastInspDate As String = "LastInspDate"
			 Public Const RespRequestDate As String = "RespRequestDate"
			 Public Const AutoRequest As String = "AutoRequest"
			 Public Const TotalNoRecs As String = "TotalNoRecs"
			 Public Const NoActiveRecs As String = "NoActiveRecs"
			 Public Const NoRecsNeedingResp As String = "NoRecsNeedingResp"
			 Public Const RespDueDate As String = "RespDueDate"
			 Public Const DaysOverdue As String = "DaysOverdue"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RespRequestDateString As String = "RespRequestDateString"
			 Public Const RespDueDateString As String = "RespDueDateString"
			 Public Const RFU1DateString As String = "RFU1DateString"
			 Public Const RFU2DateString As String = "RFU2DateString"
			 Public Const RFU3DateString As String = "RFU3DateString"
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
			 Public Const ResponseStatus As String = "ResponseStatus"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const ResponseStatusColor As String = "ResponseStatusColor"
			 Public Const NoRecsNeedingRespColor As String = "NoRecsNeedingRespColor"
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
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const Tivus As String = "Tivus"
			 Public Const StProvName As String = "StProvName"
			 Public Const Hazard As String = "Hazard"
			 Public Const LastInspDate As String = "LastInspDate"
			 Public Const RespRequestDate As String = "RespRequestDate"
			 Public Const AutoRequest As String = "AutoRequest"
			 Public Const TotalNoRecs As String = "TotalNoRecs"
			 Public Const NoActiveRecs As String = "NoActiveRecs"
			 Public Const NoRecsNeedingResp As String = "NoRecsNeedingResp"
			 Public Const RespDueDate As String = "RespDueDate"
			 Public Const DaysOverdue As String = "DaysOverdue"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RespRequestDateString As String = "RespRequestDateString"
			 Public Const RespDueDateString As String = "RespDueDateString"
			 Public Const RFU1DateString As String = "RFU1DateString"
			 Public Const RFU2DateString As String = "RFU2DateString"
			 Public Const RFU3DateString As String = "RFU3DateString"
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
			 Public Const ResponseStatus As String = "ResponseStatus"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const ResponseStatusColor As String = "ResponseStatusColor"
			 Public Const NoRecsNeedingRespColor As String = "NoRecsNeedingRespColor"
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
			SyncLock GetType(VwFireRecommendationsFollowUpBaseViewMetadata)
			
				If VwFireRecommendationsFollowUpBaseViewMetadata.mapDelegates Is Nothing Then
					VwFireRecommendationsFollowUpBaseViewMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwFireRecommendationsFollowUpBaseViewMetadata._meta Is Nothing Then
					VwFireRecommendationsFollowUpBaseViewMetadata._meta = New VwFireRecommendationsFollowUpBaseViewMetadata()
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
				meta.AddTypeMap("Zip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Longitude", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Tivus", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("StProvName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LastInspDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("RespRequestDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("AutoRequest", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalNoRecs", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NoActiveRecs", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NoRecsNeedingResp", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespDueDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DaysOverdue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU2Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU3Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RespRequestDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RespDueDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU1DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU2DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU3DateString", new esTypeMap("varchar", "System.String"))
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
				meta.AddTypeMap("ResponseStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecipientEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecipientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ResponseStatusColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NoRecsNeedingRespColor", new esTypeMap("varchar", "System.String"))			
				
				meta.Schema = "bv"
				 
				meta.Source = "vwFireRecommendationsFollowUpBaseView"
				meta.Destination = "vwFireRecommendationsFollowUpBaseView"
				
				meta.spInsert = "proc_vwFireRecommendationsFollowUpBaseViewInsert"
				meta.spUpdate = "proc_vwFireRecommendationsFollowUpBaseViewUpdate"
				meta.spDelete = "proc_vwFireRecommendationsFollowUpBaseViewDelete"
				meta.spLoadAll = "proc_vwFireRecommendationsFollowUpBaseViewLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwFireRecommendationsFollowUpBaseViewLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwFireRecommendationsFollowUpBaseViewMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
