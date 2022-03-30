
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/11/2013 2:45:24 PM
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
	' Encapsulates the 'viewCCLocationListingNatHaz' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationListingNatHaz))> _
	<XmlType("ViewCCLocationListingNatHaz")> _	
	Partial Public Class ViewCCLocationListingNatHaz 
		Inherits esViewCCLocationListingNatHaz
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationListingNatHaz()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationListingNatHazCollection")> _
	Partial Public Class ViewCCLocationListingNatHazCollection
		Inherits esViewCCLocationListingNatHazCollection
		Implements IEnumerable(Of ViewCCLocationListingNatHaz)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationListingNatHaz))> _
		Public Class ViewCCLocationListingNatHazCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationListingNatHazCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationListingNatHazCollectionWCFPacket) As ViewCCLocationListingNatHazCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationListingNatHazCollection) As ViewCCLocationListingNatHazCollectionWCFPacket
				Return New ViewCCLocationListingNatHazCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationListingNatHazQuery 
		Inherits esViewCCLocationListingNatHazQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationListingNatHazQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationListingNatHazQuery) As String
			Return ViewCCLocationListingNatHazQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationListingNatHazQuery
			Return DirectCast(ViewCCLocationListingNatHazQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationListingNatHazQuery)), ViewCCLocationListingNatHazQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingNatHaz
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingNatHazMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingNatHazMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Report1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Report1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Report1, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Report1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingNatHazMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingNatHazMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingNatHazMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingNatHazMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Frequency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Frequency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Frequency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Frequency, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Frequency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Address1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.PHONE1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Phone1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Phone1, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Phone1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.FAX
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.InspNotes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspNotes As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.InspNotes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.InspNotes, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.InspNotes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.Rpt1Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt1Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.Rpt1Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.Rpt1Client, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Rpt1Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.LocationStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.LocationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.LocationStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.LocationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.InspectionStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.InspectionStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.InspectionStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.InspectionStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.SchedFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedFROM As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedFROM)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedFROM, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.SchedFROM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.SchedTO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedTO As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedTO)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedTO, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.SchedTO)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.DateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.DateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.DateCompleted, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.DateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.SchedulingComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedulingComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedulingComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedulingComment, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.SchedulingComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazWindReportArchiveID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindReportArchiveID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindReportArchiveID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindReportArchiveID, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindReportArchiveID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazWindLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindLastInspectionDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazWindLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindLastInspectionReport, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazWindActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindActualDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazWindReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazWindReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindReport, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazWindReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazWindReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazWindReport2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindReport2, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazWindReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazWindDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazWindDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindDiagram, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazWindDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazWindEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindEmailedDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazSeismicReportArchiveID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicReportArchiveID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicReportArchiveID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicReportArchiveID, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicReportArchiveID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazSeismicLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicLastInspectionDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazSeismicLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicLastInspectionReport, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazSeismicActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicActualDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazSeismicReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazSeismicReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicReport, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazSeismicReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazSeismicReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazSeismicReport2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicReport2, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazSeismicReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazSeismicDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazSeismicDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicDiagram, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazSeismicDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazSeismicEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicEmailedDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazFloodReportArchiveID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodReportArchiveID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodReportArchiveID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodReportArchiveID, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodReportArchiveID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazFloodLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodLastInspectionDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazFloodLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodLastInspectionReport, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazFloodActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodActualDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazFloodReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazFloodReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodReport, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazFloodReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazFloodReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazFloodReport2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodReport2, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazFloodReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.ToNatHazFloodDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazFloodDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodDiagram, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazFloodDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.NatHazFloodEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodEmailedDate, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationListingNatHazMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationListingNatHazMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.GSafeGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeGUID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.GSafeGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingNatHazMetadata.ColumnNames.GSafeGUID, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.GSafeGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.RecNum
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.RecNum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.RecNum, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.RecNum)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingNatHaz.RecCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.RecCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingNatHazMetadata.ColumnNames.RecCount, value) Then
					OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.RecCount)
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
												
						Case "Client"
							Me.str().Client = CType(value, string)
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
						Case "Report1"
							Me.str().Report1 = CType(value, string)
												
						Case "ClientLocNo"
							Me.str().ClientLocNo = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "Facility"
							Me.str().Facility = CType(value, string)
												
						Case "Frequency"
							Me.str().Frequency = CType(value, string)
												
						Case "Address1"
							Me.str().Address1 = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "StProv"
							Me.str().StProv = CType(value, string)
												
						Case "Zip"
							Me.str().Zip = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "Phone1"
							Me.str().Phone1 = CType(value, string)
												
						Case "Fax"
							Me.str().Fax = CType(value, string)
												
						Case "InspNotes"
							Me.str().InspNotes = CType(value, string)
												
						Case "Rpt1Client"
							Me.str().Rpt1Client = CType(value, string)
												
						Case "LocationStatus"
							Me.str().LocationStatus = CType(value, string)
												
						Case "InspectionStatus"
							Me.str().InspectionStatus = CType(value, string)
												
						Case "SchedFROM"
							Me.str().SchedFROM = CType(value, string)
												
						Case "SchedTO"
							Me.str().SchedTO = CType(value, string)
												
						Case "DateCompleted"
							Me.str().DateCompleted = CType(value, string)
												
						Case "SchedulingComment"
							Me.str().SchedulingComment = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "NatHazWindReportArchiveID"
							Me.str().NatHazWindReportArchiveID = CType(value, string)
												
						Case "NatHazWindLastInspectionDate"
							Me.str().NatHazWindLastInspectionDate = CType(value, string)
												
						Case "NatHazWindLastInspectionReport"
							Me.str().NatHazWindLastInspectionReport = CType(value, string)
												
						Case "NatHazWindActualDate"
							Me.str().NatHazWindActualDate = CType(value, string)
												
						Case "ToNatHazWindReport"
							Me.str().ToNatHazWindReport = CType(value, string)
												
						Case "ToNatHazWindReport2"
							Me.str().ToNatHazWindReport2 = CType(value, string)
												
						Case "ToNatHazWindDiagram"
							Me.str().ToNatHazWindDiagram = CType(value, string)
												
						Case "NatHazWindEmailedDate"
							Me.str().NatHazWindEmailedDate = CType(value, string)
												
						Case "NatHazSeismicReportArchiveID"
							Me.str().NatHazSeismicReportArchiveID = CType(value, string)
												
						Case "NatHazSeismicLastInspectionDate"
							Me.str().NatHazSeismicLastInspectionDate = CType(value, string)
												
						Case "NatHazSeismicLastInspectionReport"
							Me.str().NatHazSeismicLastInspectionReport = CType(value, string)
												
						Case "NatHazSeismicActualDate"
							Me.str().NatHazSeismicActualDate = CType(value, string)
												
						Case "ToNatHazSeismicReport"
							Me.str().ToNatHazSeismicReport = CType(value, string)
												
						Case "ToNatHazSeismicReport2"
							Me.str().ToNatHazSeismicReport2 = CType(value, string)
												
						Case "ToNatHazSeismicDiagram"
							Me.str().ToNatHazSeismicDiagram = CType(value, string)
												
						Case "NatHazSeismicEmailedDate"
							Me.str().NatHazSeismicEmailedDate = CType(value, string)
												
						Case "NatHazFloodReportArchiveID"
							Me.str().NatHazFloodReportArchiveID = CType(value, string)
												
						Case "NatHazFloodLastInspectionDate"
							Me.str().NatHazFloodLastInspectionDate = CType(value, string)
												
						Case "NatHazFloodLastInspectionReport"
							Me.str().NatHazFloodLastInspectionReport = CType(value, string)
												
						Case "NatHazFloodActualDate"
							Me.str().NatHazFloodActualDate = CType(value, string)
												
						Case "ToNatHazFloodReport"
							Me.str().ToNatHazFloodReport = CType(value, string)
												
						Case "ToNatHazFloodReport2"
							Me.str().ToNatHazFloodReport2 = CType(value, string)
												
						Case "ToNatHazFloodDiagram"
							Me.str().ToNatHazFloodDiagram = CType(value, string)
												
						Case "NatHazFloodEmailedDate"
							Me.str().NatHazFloodEmailedDate = CType(value, string)
												
						Case "_100PercentUSTot"
							Me.str()._100PercentUSTot = CType(value, string)
												
						Case "GSafeGUID"
							Me.str().GSafeGUID = CType(value, string)
												
						Case "RecNum"
							Me.str().RecNum = CType(value, string)
												
						Case "RecCount"
							Me.str().RecCount = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Longitude)
							End If
						
						Case "Rpt1Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt1Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.Rpt1Client)
							End If
						
						Case "SchedFROM"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedFROM = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.SchedFROM)
							End If
						
						Case "SchedTO"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedTO = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.SchedTO)
							End If
						
						Case "DateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.DateCompleted)
							End If
						
						Case "NatHazWindReportArchiveID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NatHazWindReportArchiveID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindReportArchiveID)
							End If
						
						Case "NatHazWindLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazWindLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindLastInspectionDate)
							End If
						
						Case "NatHazWindActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazWindActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindActualDate)
							End If
						
						Case "NatHazWindEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazWindEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindEmailedDate)
							End If
						
						Case "NatHazSeismicReportArchiveID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NatHazSeismicReportArchiveID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicReportArchiveID)
							End If
						
						Case "NatHazSeismicLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazSeismicLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicLastInspectionDate)
							End If
						
						Case "NatHazSeismicActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazSeismicActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicActualDate)
							End If
						
						Case "NatHazSeismicEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazSeismicEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicEmailedDate)
							End If
						
						Case "NatHazFloodReportArchiveID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NatHazFloodReportArchiveID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodReportArchiveID)
							End If
						
						Case "NatHazFloodLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazFloodLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodLastInspectionDate)
							End If
						
						Case "NatHazFloodActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazFloodActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodActualDate)
							End If
						
						Case "NatHazFloodEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazFloodEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodEmailedDate)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "RecNum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNum = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.RecNum)
							End If
						
						Case "RecCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingNatHazMetadata.PropertyNames.RecCount)
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
		
			Public Sub New(ByVal entity As esViewCCLocationListingNatHaz)
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
		  	
			Public Property Latitude As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Latitude
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Latitude = Nothing
					Else
						entity.Latitude = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Longitude As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Longitude
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Longitude = Nothing
					Else
						entity.Longitude = Convert.ToDecimal(Value)
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
		  	
			Public Property Address1 As System.String 
				Get
					Dim data_ As System.String = entity.Address1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address1 = Nothing
					Else
						entity.Address1 = Convert.ToString(Value)
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
		  	
			Public Property Phone1 As System.String 
				Get
					Dim data_ As System.String = entity.Phone1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phone1 = Nothing
					Else
						entity.Phone1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fax As System.String 
				Get
					Dim data_ As System.String = entity.Fax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fax = Nothing
					Else
						entity.Fax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspNotes As System.String 
				Get
					Dim data_ As System.String = entity.InspNotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspNotes = Nothing
					Else
						entity.InspNotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt1Client As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt1Client
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt1Client = Nothing
					Else
						entity.Rpt1Client = Convert.ToDateTime(Value)
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
		  	
			Public Property SchedFROM As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SchedFROM
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedFROM = Nothing
					Else
						entity.SchedFROM = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedTO As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SchedTO
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedTO = Nothing
					Else
						entity.SchedTO = Convert.ToDateTime(Value)
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
		  	
			Public Property SchedulingComment As System.String 
				Get
					Dim data_ As System.String = entity.SchedulingComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedulingComment = Nothing
					Else
						entity.SchedulingComment = Convert.ToString(Value)
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
		  	
			Public Property NatHazWindReportArchiveID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NatHazWindReportArchiveID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindReportArchiveID = Nothing
					Else
						entity.NatHazWindReportArchiveID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazWindLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazWindLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindLastInspectionDate = Nothing
					Else
						entity.NatHazWindLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazWindLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.NatHazWindLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindLastInspectionReport = Nothing
					Else
						entity.NatHazWindLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazWindActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazWindActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindActualDate = Nothing
					Else
						entity.NatHazWindActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazWindReport As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazWindReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazWindReport = Nothing
					Else
						entity.ToNatHazWindReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazWindReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazWindReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazWindReport2 = Nothing
					Else
						entity.ToNatHazWindReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazWindDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazWindDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazWindDiagram = Nothing
					Else
						entity.ToNatHazWindDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazWindEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazWindEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindEmailedDate = Nothing
					Else
						entity.NatHazWindEmailedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicReportArchiveID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NatHazSeismicReportArchiveID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicReportArchiveID = Nothing
					Else
						entity.NatHazSeismicReportArchiveID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazSeismicLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicLastInspectionDate = Nothing
					Else
						entity.NatHazSeismicLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.NatHazSeismicLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicLastInspectionReport = Nothing
					Else
						entity.NatHazSeismicLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazSeismicActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicActualDate = Nothing
					Else
						entity.NatHazSeismicActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazSeismicReport As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazSeismicReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazSeismicReport = Nothing
					Else
						entity.ToNatHazSeismicReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazSeismicReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazSeismicReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazSeismicReport2 = Nothing
					Else
						entity.ToNatHazSeismicReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazSeismicDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazSeismicDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazSeismicDiagram = Nothing
					Else
						entity.ToNatHazSeismicDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazSeismicEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicEmailedDate = Nothing
					Else
						entity.NatHazSeismicEmailedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodReportArchiveID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NatHazFloodReportArchiveID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodReportArchiveID = Nothing
					Else
						entity.NatHazFloodReportArchiveID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazFloodLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodLastInspectionDate = Nothing
					Else
						entity.NatHazFloodLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.NatHazFloodLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodLastInspectionReport = Nothing
					Else
						entity.NatHazFloodLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazFloodActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodActualDate = Nothing
					Else
						entity.NatHazFloodActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazFloodReport As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazFloodReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazFloodReport = Nothing
					Else
						entity.ToNatHazFloodReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazFloodReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazFloodReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazFloodReport2 = Nothing
					Else
						entity.ToNatHazFloodReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazFloodDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazFloodDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazFloodDiagram = Nothing
					Else
						entity.ToNatHazFloodDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazFloodEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodEmailedDate = Nothing
					Else
						entity.NatHazFloodEmailedDate = Convert.ToDateTime(Value)
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
		  	
			Public Property GSafeGUID As System.String 
				Get
					Dim data_ As System.String = entity.GSafeGUID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GSafeGUID = Nothing
					Else
						entity.GSafeGUID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecNum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecNum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecNum = Nothing
					Else
						entity.RecNum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecCount As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecCount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCount = Nothing
					Else
						entity.RecCount = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCLocationListingNatHaz
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingNatHazMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationListingNatHazQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingNatHazQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationListingNatHazQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationListingNatHazQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationListingNatHazQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingNatHazCollection
		Inherits esEntityCollection(Of ViewCCLocationListingNatHaz)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingNatHazMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationListingNatHazCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationListingNatHazQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingNatHazQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationListingNatHazQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationListingNatHazQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationListingNatHazQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationListingNatHazQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationListingNatHazQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationListingNatHazQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingNatHazMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "Client" 
					Return Me.Client
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "Report1" 
					Return Me.Report1
				Case "ClientLocNo" 
					Return Me.ClientLocNo
				Case "Division" 
					Return Me.Division
				Case "Latitude" 
					Return Me.Latitude
				Case "Longitude" 
					Return Me.Longitude
				Case "Facility" 
					Return Me.Facility
				Case "Frequency" 
					Return Me.Frequency
				Case "Address1" 
					Return Me.Address1
				Case "City" 
					Return Me.City
				Case "StProv" 
					Return Me.StProv
				Case "Zip" 
					Return Me.Zip
				Case "Country" 
					Return Me.Country
				Case "Phone1" 
					Return Me.Phone1
				Case "Fax" 
					Return Me.Fax
				Case "InspNotes" 
					Return Me.InspNotes
				Case "Rpt1Client" 
					Return Me.Rpt1Client
				Case "LocationStatus" 
					Return Me.LocationStatus
				Case "InspectionStatus" 
					Return Me.InspectionStatus
				Case "SchedFROM" 
					Return Me.SchedFROM
				Case "SchedTO" 
					Return Me.SchedTO
				Case "DateCompleted" 
					Return Me.DateCompleted
				Case "SchedulingComment" 
					Return Me.SchedulingComment
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "NatHazWindReportArchiveID" 
					Return Me.NatHazWindReportArchiveID
				Case "NatHazWindLastInspectionDate" 
					Return Me.NatHazWindLastInspectionDate
				Case "NatHazWindLastInspectionReport" 
					Return Me.NatHazWindLastInspectionReport
				Case "NatHazWindActualDate" 
					Return Me.NatHazWindActualDate
				Case "ToNatHazWindReport" 
					Return Me.ToNatHazWindReport
				Case "ToNatHazWindReport2" 
					Return Me.ToNatHazWindReport2
				Case "ToNatHazWindDiagram" 
					Return Me.ToNatHazWindDiagram
				Case "NatHazWindEmailedDate" 
					Return Me.NatHazWindEmailedDate
				Case "NatHazSeismicReportArchiveID" 
					Return Me.NatHazSeismicReportArchiveID
				Case "NatHazSeismicLastInspectionDate" 
					Return Me.NatHazSeismicLastInspectionDate
				Case "NatHazSeismicLastInspectionReport" 
					Return Me.NatHazSeismicLastInspectionReport
				Case "NatHazSeismicActualDate" 
					Return Me.NatHazSeismicActualDate
				Case "ToNatHazSeismicReport" 
					Return Me.ToNatHazSeismicReport
				Case "ToNatHazSeismicReport2" 
					Return Me.ToNatHazSeismicReport2
				Case "ToNatHazSeismicDiagram" 
					Return Me.ToNatHazSeismicDiagram
				Case "NatHazSeismicEmailedDate" 
					Return Me.NatHazSeismicEmailedDate
				Case "NatHazFloodReportArchiveID" 
					Return Me.NatHazFloodReportArchiveID
				Case "NatHazFloodLastInspectionDate" 
					Return Me.NatHazFloodLastInspectionDate
				Case "NatHazFloodLastInspectionReport" 
					Return Me.NatHazFloodLastInspectionReport
				Case "NatHazFloodActualDate" 
					Return Me.NatHazFloodActualDate
				Case "ToNatHazFloodReport" 
					Return Me.ToNatHazFloodReport
				Case "ToNatHazFloodReport2" 
					Return Me.ToNatHazFloodReport2
				Case "ToNatHazFloodDiagram" 
					Return Me.ToNatHazFloodDiagram
				Case "NatHazFloodEmailedDate" 
					Return Me.NatHazFloodEmailedDate
				Case "_100PercentUSTot" 
					Return Me._100PercentUSTot
				Case "GSafeGUID" 
					Return Me.GSafeGUID
				Case "RecNum" 
					Return Me.RecNum
				Case "RecCount" 
					Return Me.RecCount
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Report1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Report1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Frequency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Frequency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Phone1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.InspNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt1Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.Rpt1Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LocationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.LocationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.InspectionStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedFROM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.SchedFROM, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SchedTO As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.SchedTO, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.DateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SchedulingComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.SchedulingComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindReportArchiveID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindReportArchiveID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazWindReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazWindReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazWindDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicReportArchiveID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicReportArchiveID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazSeismicReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazSeismicReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazSeismicDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodReportArchiveID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodReportArchiveID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazFloodReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazFloodReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazFloodDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property GSafeGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.GSafeGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.RecNum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingNatHazMetadata.ColumnNames.RecCount, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationListingNatHazMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Client, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.PracticeCode, 2, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Report1, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Report1
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ClientLocNo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Division, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Latitude, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Longitude, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Facility, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Frequency, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Frequency
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Address1, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.City, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.StProv, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Zip, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Country, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Phone1, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Phone1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Fax, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Fax
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.InspNotes, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.InspNotes
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.Rpt1Client, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.Rpt1Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.LocationStatus, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.LocationStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.InspectionStatus, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.InspectionStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedFROM, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.SchedFROM
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedTO, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.SchedTO
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.DateCompleted, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.DateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.SchedulingComment, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.SchedulingComment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.CustomAccess, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindReportArchiveID, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindReportArchiveID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindLastInspectionDate, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindLastInspectionReport, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindActualDate, 29, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindReport, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazWindReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindReport2, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazWindReport2
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazWindDiagram, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazWindDiagram
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazWindEmailedDate, 33, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazWindEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicReportArchiveID, 34, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicReportArchiveID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicLastInspectionDate, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicLastInspectionReport, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicActualDate, 37, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicReport, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazSeismicReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicReport2, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazSeismicReport2
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazSeismicDiagram, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazSeismicDiagram
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazSeismicEmailedDate, 41, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazSeismicEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodReportArchiveID, 42, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodReportArchiveID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodLastInspectionDate, 43, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodLastInspectionReport, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodActualDate, 45, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodReport, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazFloodReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodReport2, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazFloodReport2
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.ToNatHazFloodDiagram, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.ToNatHazFloodDiagram
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.NatHazFloodEmailedDate, 49, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.NatHazFloodEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames._100PercentUSTot, 50, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.GSafeGUID, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.GSafeGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.RecNum, 52, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.RecNum
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingNatHazMetadata.ColumnNames.RecCount, 53, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingNatHazMetadata.PropertyNames.RecCount
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationListingNatHazMetadata
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
			 Public Const Client As String = "Client"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Report1 As String = "Report1"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const Facility As String = "Facility"
			 Public Const Frequency As String = "Frequency"
			 Public Const Address1 As String = "Address1"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Phone1 As String = "PHONE1"
			 Public Const Fax As String = "FAX"
			 Public Const InspNotes As String = "InspNotes"
			 Public Const Rpt1Client As String = "Rpt1Client"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const SchedFROM As String = "SchedFROM"
			 Public Const SchedTO As String = "SchedTO"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const SchedulingComment As String = "SchedulingComment"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const NatHazWindReportArchiveID As String = "NatHazWindReportArchiveID"
			 Public Const NatHazWindLastInspectionDate As String = "NatHazWindLastInspectionDate"
			 Public Const NatHazWindLastInspectionReport As String = "NatHazWindLastInspectionReport"
			 Public Const NatHazWindActualDate As String = "NatHazWindActualDate"
			 Public Const ToNatHazWindReport As String = "ToNatHazWindReport"
			 Public Const ToNatHazWindReport2 As String = "ToNatHazWindReport2"
			 Public Const ToNatHazWindDiagram As String = "ToNatHazWindDiagram"
			 Public Const NatHazWindEmailedDate As String = "NatHazWindEmailedDate"
			 Public Const NatHazSeismicReportArchiveID As String = "NatHazSeismicReportArchiveID"
			 Public Const NatHazSeismicLastInspectionDate As String = "NatHazSeismicLastInspectionDate"
			 Public Const NatHazSeismicLastInspectionReport As String = "NatHazSeismicLastInspectionReport"
			 Public Const NatHazSeismicActualDate As String = "NatHazSeismicActualDate"
			 Public Const ToNatHazSeismicReport As String = "ToNatHazSeismicReport"
			 Public Const ToNatHazSeismicReport2 As String = "ToNatHazSeismicReport2"
			 Public Const ToNatHazSeismicDiagram As String = "ToNatHazSeismicDiagram"
			 Public Const NatHazSeismicEmailedDate As String = "NatHazSeismicEmailedDate"
			 Public Const NatHazFloodReportArchiveID As String = "NatHazFloodReportArchiveID"
			 Public Const NatHazFloodLastInspectionDate As String = "NatHazFloodLastInspectionDate"
			 Public Const NatHazFloodLastInspectionReport As String = "NatHazFloodLastInspectionReport"
			 Public Const NatHazFloodActualDate As String = "NatHazFloodActualDate"
			 Public Const ToNatHazFloodReport As String = "ToNatHazFloodReport"
			 Public Const ToNatHazFloodReport2 As String = "ToNatHazFloodReport2"
			 Public Const ToNatHazFloodDiagram As String = "ToNatHazFloodDiagram"
			 Public Const NatHazFloodEmailedDate As String = "NatHazFloodEmailedDate"
			 Public Const _100PercentUSTot As String = "100PercentUSTot"
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const RecNum As String = "RecNum"
			 Public Const RecCount As String = "RecCount"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const Client As String = "Client"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Report1 As String = "Report1"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const Facility As String = "Facility"
			 Public Const Frequency As String = "Frequency"
			 Public Const Address1 As String = "Address1"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Phone1 As String = "Phone1"
			 Public Const Fax As String = "Fax"
			 Public Const InspNotes As String = "InspNotes"
			 Public Const Rpt1Client As String = "Rpt1Client"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const SchedFROM As String = "SchedFROM"
			 Public Const SchedTO As String = "SchedTO"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const SchedulingComment As String = "SchedulingComment"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const NatHazWindReportArchiveID As String = "NatHazWindReportArchiveID"
			 Public Const NatHazWindLastInspectionDate As String = "NatHazWindLastInspectionDate"
			 Public Const NatHazWindLastInspectionReport As String = "NatHazWindLastInspectionReport"
			 Public Const NatHazWindActualDate As String = "NatHazWindActualDate"
			 Public Const ToNatHazWindReport As String = "ToNatHazWindReport"
			 Public Const ToNatHazWindReport2 As String = "ToNatHazWindReport2"
			 Public Const ToNatHazWindDiagram As String = "ToNatHazWindDiagram"
			 Public Const NatHazWindEmailedDate As String = "NatHazWindEmailedDate"
			 Public Const NatHazSeismicReportArchiveID As String = "NatHazSeismicReportArchiveID"
			 Public Const NatHazSeismicLastInspectionDate As String = "NatHazSeismicLastInspectionDate"
			 Public Const NatHazSeismicLastInspectionReport As String = "NatHazSeismicLastInspectionReport"
			 Public Const NatHazSeismicActualDate As String = "NatHazSeismicActualDate"
			 Public Const ToNatHazSeismicReport As String = "ToNatHazSeismicReport"
			 Public Const ToNatHazSeismicReport2 As String = "ToNatHazSeismicReport2"
			 Public Const ToNatHazSeismicDiagram As String = "ToNatHazSeismicDiagram"
			 Public Const NatHazSeismicEmailedDate As String = "NatHazSeismicEmailedDate"
			 Public Const NatHazFloodReportArchiveID As String = "NatHazFloodReportArchiveID"
			 Public Const NatHazFloodLastInspectionDate As String = "NatHazFloodLastInspectionDate"
			 Public Const NatHazFloodLastInspectionReport As String = "NatHazFloodLastInspectionReport"
			 Public Const NatHazFloodActualDate As String = "NatHazFloodActualDate"
			 Public Const ToNatHazFloodReport As String = "ToNatHazFloodReport"
			 Public Const ToNatHazFloodReport2 As String = "ToNatHazFloodReport2"
			 Public Const ToNatHazFloodDiagram As String = "ToNatHazFloodDiagram"
			 Public Const NatHazFloodEmailedDate As String = "NatHazFloodEmailedDate"
			 Public Const _100PercentUSTot As String = "_100PercentUSTot"
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const RecNum As String = "RecNum"
			 Public Const RecCount As String = "RecCount"
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
			SyncLock GetType(ViewCCLocationListingNatHazMetadata)
			
				If ViewCCLocationListingNatHazMetadata.mapDelegates Is Nothing Then
					ViewCCLocationListingNatHazMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationListingNatHazMetadata._meta Is Nothing Then
					ViewCCLocationListingNatHazMetadata._meta = New ViewCCLocationListingNatHazMetadata()
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
				meta.AddTypeMap("Client", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Report1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ClientLocNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Facility", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Frequency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Phone1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspNotes", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Rpt1Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("LocationStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectionStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SchedFROM", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("SchedTO", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("DateCompleted", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("SchedulingComment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NatHazWindReportArchiveID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NatHazWindLastInspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("NatHazWindLastInspectionReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NatHazWindActualDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ToNatHazWindReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToNatHazWindReport2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToNatHazWindDiagram", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NatHazWindEmailedDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("NatHazSeismicReportArchiveID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NatHazSeismicLastInspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("NatHazSeismicLastInspectionReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NatHazSeismicActualDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ToNatHazSeismicReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToNatHazSeismicReport2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToNatHazSeismicDiagram", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NatHazSeismicEmailedDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("NatHazFloodReportArchiveID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NatHazFloodLastInspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("NatHazFloodLastInspectionReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NatHazFloodActualDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ToNatHazFloodReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToNatHazFloodReport2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToNatHazFloodDiagram", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NatHazFloodEmailedDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("_100PercentUSTot", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("GSafeGUID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecNum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecCount", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCLocationListingNatHaz"
				meta.Destination = "viewCCLocationListingNatHaz"
				
				meta.spInsert = "proc_viewCCLocationListingNatHazInsert"
				meta.spUpdate = "proc_viewCCLocationListingNatHazUpdate"
				meta.spDelete = "proc_viewCCLocationListingNatHazDelete"
				meta.spLoadAll = "proc_viewCCLocationListingNatHazLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationListingNatHazLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationListingNatHazMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
