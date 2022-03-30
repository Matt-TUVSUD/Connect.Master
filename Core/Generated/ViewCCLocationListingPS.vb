
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/27/2018 10:45:08 AM
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
	' Encapsulates the 'viewCCLocationListingPS' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationListingPS))> _
	<XmlType("ViewCCLocationListingPS")> _	
	Partial Public Class ViewCCLocationListingPS 
		Inherits esViewCCLocationListingPS
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationListingPS()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationListingPSCollection")> _
	Partial Public Class ViewCCLocationListingPSCollection
		Inherits esViewCCLocationListingPSCollection
		Implements IEnumerable(Of ViewCCLocationListingPS)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationListingPS))> _
		Public Class ViewCCLocationListingPSCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationListingPSCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationListingPSCollectionWCFPacket) As ViewCCLocationListingPSCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationListingPSCollection) As ViewCCLocationListingPSCollectionWCFPacket
				Return New ViewCCLocationListingPSCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationListingPSQuery 
		Inherits esViewCCLocationListingPSQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationListingPSQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationListingPSQuery) As String
			Return ViewCCLocationListingPSQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationListingPSQuery
			Return DirectCast(ViewCCLocationListingPSQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationListingPSQuery)), ViewCCLocationListingPSQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingPS
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationListingPS.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingPSMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingPSMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Report2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Report2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Report2, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Report2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Rpt2Revwr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Revwr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.Rpt2Revwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.Rpt2Revwr, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Rpt2Revwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Rpt2Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.Rpt2Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.Rpt2Client, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Rpt2Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Region
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Region As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Region)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Region, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Region)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.ServicedBy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ServicedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ServicedBy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ServicedBy, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.ServicedBy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.LocalTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocalTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.LocalTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.LocalTIV, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.LocalTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingPSMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingPSMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingPSMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingPSMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.PSReportArchiveID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PSReportArchiveID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingPSMetadata.ColumnNames.PSReportArchiveID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingPSMetadata.ColumnNames.PSReportArchiveID, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSReportArchiveID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.PSLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PSLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.PSLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.PSLastInspectionReport, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.PSLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PSLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.PSLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.PSLastInspectionDate, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.PSActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PSActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.PSActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.PSActualDate, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.ToPSReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToPSReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ToPSReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ToPSReport, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.ToPSReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.ToPSReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToPSReport2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ToPSReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ToPSReport2, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.ToPSReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.ToPSDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToPSDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ToPSDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.ToPSDiagram, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.ToPSDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.PSEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PSEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.PSEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.PSEmailedDate, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Frequency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Frequency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Frequency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Frequency, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Frequency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Address1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Address2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Address2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Address2, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Address2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.PHONE1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Phone1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Phone1, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Phone1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.FAX
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.InspNotes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspNotes As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.InspNotes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.InspNotes, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.InspNotes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.DateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.DateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.DateCompleted, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.DateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Rpt1Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt1Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.Rpt1Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.Rpt1Client, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Rpt1Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.LocationStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.LocationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.LocationStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.LocationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.InspectionStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.InspectionStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.InspectionStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.InspectionStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.SchedFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedFROM As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.SchedFROM)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.SchedFROM, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.SchedFROM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.SchedTO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedTO As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.SchedTO)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingPSMetadata.ColumnNames.SchedTO, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.SchedTO)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.NextInspYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NextInspYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingPSMetadata.ColumnNames.NextInspYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingPSMetadata.ColumnNames.NextInspYr, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.NextInspYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.TotalUS_TIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSTIV, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.TotalUSTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.TotalUS_PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSPD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSPD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSPD, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.TotalUSPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.TotalUS_BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSBI As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSBI)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSBI, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.TotalUSBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationListingPSMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationListingPSMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.SchedulingComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedulingComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.SchedulingComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.SchedulingComment, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.SchedulingComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.GSafeGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeGUID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.GSafeGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingPSMetadata.ColumnNames.GSafeGUID, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.GSafeGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.RecNum
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingPSMetadata.ColumnNames.RecNum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingPSMetadata.ColumnNames.RecNum, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.RecNum)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingPS.RecCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingPSMetadata.ColumnNames.RecCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingPSMetadata.ColumnNames.RecCount, value) Then
					OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.RecCount)
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
												
						Case "Client"
							Me.str().Client = CType(value, string)
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
						Case "Facility"
							Me.str().Facility = CType(value, string)
												
						Case "ClientLocNo"
							Me.str().ClientLocNo = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "Report2"
							Me.str().Report2 = CType(value, string)
												
						Case "Rpt2Revwr"
							Me.str().Rpt2Revwr = CType(value, string)
												
						Case "Rpt2Client"
							Me.str().Rpt2Client = CType(value, string)
												
						Case "Region"
							Me.str().Region = CType(value, string)
												
						Case "ServicedBy"
							Me.str().ServicedBy = CType(value, string)
												
						Case "LocalTIV"
							Me.str().LocalTIV = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "PSReportArchiveID"
							Me.str().PSReportArchiveID = CType(value, string)
												
						Case "PSLastInspectionReport"
							Me.str().PSLastInspectionReport = CType(value, string)
												
						Case "PSLastInspectionDate"
							Me.str().PSLastInspectionDate = CType(value, string)
												
						Case "PSActualDate"
							Me.str().PSActualDate = CType(value, string)
												
						Case "ToPSReport"
							Me.str().ToPSReport = CType(value, string)
												
						Case "ToPSReport2"
							Me.str().ToPSReport2 = CType(value, string)
												
						Case "ToPSDiagram"
							Me.str().ToPSDiagram = CType(value, string)
												
						Case "PSEmailedDate"
							Me.str().PSEmailedDate = CType(value, string)
												
						Case "Frequency"
							Me.str().Frequency = CType(value, string)
												
						Case "Address1"
							Me.str().Address1 = CType(value, string)
												
						Case "Address2"
							Me.str().Address2 = CType(value, string)
												
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
												
						Case "DateCompleted"
							Me.str().DateCompleted = CType(value, string)
												
						Case "Rpt1Client"
							Me.str().Rpt1Client = CType(value, string)
												
						Case "LocationStatus"
							Me.str().LocationStatus = CType(value, string)
												
						Case "InspectionStatus"
							Me.str().InspectionStatus = CType(value, string)
												
						Case "Engineer"
							Me.str().Engineer = CType(value, string)
												
						Case "SchedFROM"
							Me.str().SchedFROM = CType(value, string)
												
						Case "SchedTO"
							Me.str().SchedTO = CType(value, string)
												
						Case "NextInspYr"
							Me.str().NextInspYr = CType(value, string)
												
						Case "TotalUSTIV"
							Me.str().TotalUSTIV = CType(value, string)
												
						Case "TotalUSPD"
							Me.str().TotalUSPD = CType(value, string)
												
						Case "TotalUSBI"
							Me.str().TotalUSBI = CType(value, string)
												
						Case "_100PercentUSTot"
							Me.str()._100PercentUSTot = CType(value, string)
												
						Case "SchedulingComment"
							Me.str().SchedulingComment = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
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
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "Rpt2Revwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Revwr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Rpt2Revwr)
							End If
						
						Case "Rpt2Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Rpt2Client)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Longitude)
							End If
						
						Case "PSReportArchiveID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PSReportArchiveID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSReportArchiveID)
							End If
						
						Case "PSLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PSLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSLastInspectionDate)
							End If
						
						Case "PSActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PSActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSActualDate)
							End If
						
						Case "PSEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PSEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.PSEmailedDate)
							End If
						
						Case "DateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.DateCompleted)
							End If
						
						Case "Rpt1Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt1Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.Rpt1Client)
							End If
						
						Case "SchedFROM"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedFROM = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.SchedFROM)
							End If
						
						Case "SchedTO"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedTO = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.SchedTO)
							End If
						
						Case "NextInspYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NextInspYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.NextInspYr)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "RecNum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNum = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.RecNum)
							End If
						
						Case "RecCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingPSMetadata.PropertyNames.RecCount)
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
		
			Public Sub New(ByVal entity As esViewCCLocationListingPS)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Report2 As System.String 
				Get
					Dim data_ As System.String = entity.Report2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Report2 = Nothing
					Else
						entity.Report2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt2Revwr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt2Revwr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt2Revwr = Nothing
					Else
						entity.Rpt2Revwr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt2Client As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt2Client
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt2Client = Nothing
					Else
						entity.Rpt2Client = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Region As System.String 
				Get
					Dim data_ As System.String = entity.Region
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Region = Nothing
					Else
						entity.Region = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ServicedBy As System.String 
				Get
					Dim data_ As System.String = entity.ServicedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ServicedBy = Nothing
					Else
						entity.ServicedBy = Convert.ToString(Value)
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
		  	
			Public Property PSReportArchiveID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PSReportArchiveID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PSReportArchiveID = Nothing
					Else
						entity.PSReportArchiveID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PSLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.PSLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PSLastInspectionReport = Nothing
					Else
						entity.PSLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PSLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PSLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PSLastInspectionDate = Nothing
					Else
						entity.PSLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property PSActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PSActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PSActualDate = Nothing
					Else
						entity.PSActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToPSReport As System.String 
				Get
					Dim data_ As System.String = entity.ToPSReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToPSReport = Nothing
					Else
						entity.ToPSReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToPSReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToPSReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToPSReport2 = Nothing
					Else
						entity.ToPSReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToPSDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToPSDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToPSDiagram = Nothing
					Else
						entity.ToPSDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PSEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PSEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PSEmailedDate = Nothing
					Else
						entity.PSEmailedDate = Convert.ToDateTime(Value)
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
		  	
			Public Property Address2 As System.String 
				Get
					Dim data_ As System.String = entity.Address2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address2 = Nothing
					Else
						entity.Address2 = Convert.ToString(Value)
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
		  

			Private entity As esViewCCLocationListingPS
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingPSMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationListingPSQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingPSQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationListingPSQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationListingPSQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationListingPSQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingPSCollection
		Inherits esEntityCollection(Of ViewCCLocationListingPS)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingPSMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationListingPSCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationListingPSQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingPSQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationListingPSQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationListingPSQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationListingPSQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationListingPSQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationListingPSQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationListingPSQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingPSMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Client" 
					Return Me.Client
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "Facility" 
					Return Me.Facility
				Case "ClientLocNo" 
					Return Me.ClientLocNo
				Case "FileNo" 
					Return Me.FileNo
				Case "Report2" 
					Return Me.Report2
				Case "Rpt2Revwr" 
					Return Me.Rpt2Revwr
				Case "Rpt2Client" 
					Return Me.Rpt2Client
				Case "Region" 
					Return Me.Region
				Case "ServicedBy" 
					Return Me.ServicedBy
				Case "LocalTIV" 
					Return Me.LocalTIV
				Case "Division" 
					Return Me.Division
				Case "Latitude" 
					Return Me.Latitude
				Case "Longitude" 
					Return Me.Longitude
				Case "PSReportArchiveID" 
					Return Me.PSReportArchiveID
				Case "PSLastInspectionReport" 
					Return Me.PSLastInspectionReport
				Case "PSLastInspectionDate" 
					Return Me.PSLastInspectionDate
				Case "PSActualDate" 
					Return Me.PSActualDate
				Case "ToPSReport" 
					Return Me.ToPSReport
				Case "ToPSReport2" 
					Return Me.ToPSReport2
				Case "ToPSDiagram" 
					Return Me.ToPSDiagram
				Case "PSEmailedDate" 
					Return Me.PSEmailedDate
				Case "Frequency" 
					Return Me.Frequency
				Case "Address1" 
					Return Me.Address1
				Case "Address2" 
					Return Me.Address2
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
				Case "DateCompleted" 
					Return Me.DateCompleted
				Case "Rpt1Client" 
					Return Me.Rpt1Client
				Case "LocationStatus" 
					Return Me.LocationStatus
				Case "InspectionStatus" 
					Return Me.InspectionStatus
				Case "Engineer" 
					Return Me.Engineer
				Case "SchedFROM" 
					Return Me.SchedFROM
				Case "SchedTO" 
					Return Me.SchedTO
				Case "NextInspYr" 
					Return Me.NextInspYr
				Case "TotalUSTIV" 
					Return Me.TotalUSTIV
				Case "TotalUSPD" 
					Return Me.TotalUSPD
				Case "TotalUSBI" 
					Return Me.TotalUSBI
				Case "_100PercentUSTot" 
					Return Me._100PercentUSTot
				Case "SchedulingComment" 
					Return Me.SchedulingComment
				Case "CustomAccess" 
					Return Me.CustomAccess
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


		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Report2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Report2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Revwr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Rpt2Revwr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Rpt2Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Region As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Region, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ServicedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.ServicedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocalTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.LocalTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PSReportArchiveID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.PSReportArchiveID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PSLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.PSLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PSLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.PSLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PSActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.PSActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToPSReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.ToPSReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToPSReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.ToPSReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToPSDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.ToPSDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PSEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.PSEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Frequency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Frequency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Address2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Phone1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.InspNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.DateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt1Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Rpt1Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LocationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.LocationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.InspectionStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedFROM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.SchedFROM, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SchedTO As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.SchedTO, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NextInspYr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.NextInspYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.TotalUSTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.TotalUSPD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.TotalUSBI, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property SchedulingComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.SchedulingComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GSafeGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.GSafeGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.RecNum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingPSMetadata.ColumnNames.RecCount, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationListingPSMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Client, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.PracticeCode, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Facility, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.FileNo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Report2, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Report2
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Rpt2Revwr, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Rpt2Revwr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Rpt2Client, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Rpt2Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Region, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Region
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.ServicedBy, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.ServicedBy
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.LocalTIV, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.LocalTIV
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Division, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Latitude, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Longitude, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.PSReportArchiveID, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.PSReportArchiveID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.PSLastInspectionReport, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.PSLastInspectionReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.PSLastInspectionDate, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.PSLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.PSActualDate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.PSActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.ToPSReport, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.ToPSReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.ToPSReport2, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.ToPSReport2
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.ToPSDiagram, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.ToPSDiagram
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.PSEmailedDate, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.PSEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Frequency, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Frequency
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Address1, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Address2, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Address2
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.City, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.StProv, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Zip, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Country, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Phone1, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Phone1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Fax, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Fax
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.InspNotes, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.InspNotes
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.DateCompleted, 32, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.DateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Rpt1Client, 33, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Rpt1Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.LocationStatus, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.LocationStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.InspectionStatus, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.InspectionStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.Engineer, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.SchedFROM, 37, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.SchedFROM
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.SchedTO, 38, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.SchedTO
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.NextInspYr, 39, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.NextInspYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSTIV, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.TotalUSTIV
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSPD, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.TotalUSPD
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.TotalUSBI, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.TotalUSBI
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames._100PercentUSTot, 43, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.SchedulingComment, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.SchedulingComment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.CustomAccess, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.GSafeGUID, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.GSafeGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.RecNum, 47, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.RecNum
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingPSMetadata.ColumnNames.RecCount, 48, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingPSMetadata.PropertyNames.RecCount
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationListingPSMetadata
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
			 Public Const Client As String = "Client"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Facility As String = "Facility"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const FileNo As String = "FileNo"
			 Public Const Report2 As String = "Report2"
			 Public Const Rpt2Revwr As String = "Rpt2Revwr"
			 Public Const Rpt2Client As String = "Rpt2Client"
			 Public Const Region As String = "Region"
			 Public Const ServicedBy As String = "ServicedBy"
			 Public Const LocalTIV As String = "LocalTIV"
			 Public Const Division As String = "Division"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const PSReportArchiveID As String = "PSReportArchiveID"
			 Public Const PSLastInspectionReport As String = "PSLastInspectionReport"
			 Public Const PSLastInspectionDate As String = "PSLastInspectionDate"
			 Public Const PSActualDate As String = "PSActualDate"
			 Public Const ToPSReport As String = "ToPSReport"
			 Public Const ToPSReport2 As String = "ToPSReport2"
			 Public Const ToPSDiagram As String = "ToPSDiagram"
			 Public Const PSEmailedDate As String = "PSEmailedDate"
			 Public Const Frequency As String = "Frequency"
			 Public Const Address1 As String = "Address1"
			 Public Const Address2 As String = "Address2"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Phone1 As String = "PHONE1"
			 Public Const Fax As String = "FAX"
			 Public Const InspNotes As String = "InspNotes"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const Rpt1Client As String = "Rpt1Client"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const Engineer As String = "Engineer"
			 Public Const SchedFROM As String = "SchedFROM"
			 Public Const SchedTO As String = "SchedTO"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const TotalUSTIV As String = "TotalUS_TIV"
			 Public Const TotalUSPD As String = "TotalUS_PD"
			 Public Const TotalUSBI As String = "TotalUS_BI"
			 Public Const _100PercentUSTot As String = "100PercentUSTot"
			 Public Const SchedulingComment As String = "SchedulingComment"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const RecNum As String = "RecNum"
			 Public Const RecCount As String = "RecCount"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Client As String = "Client"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Facility As String = "Facility"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const FileNo As String = "FileNo"
			 Public Const Report2 As String = "Report2"
			 Public Const Rpt2Revwr As String = "Rpt2Revwr"
			 Public Const Rpt2Client As String = "Rpt2Client"
			 Public Const Region As String = "Region"
			 Public Const ServicedBy As String = "ServicedBy"
			 Public Const LocalTIV As String = "LocalTIV"
			 Public Const Division As String = "Division"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const PSReportArchiveID As String = "PSReportArchiveID"
			 Public Const PSLastInspectionReport As String = "PSLastInspectionReport"
			 Public Const PSLastInspectionDate As String = "PSLastInspectionDate"
			 Public Const PSActualDate As String = "PSActualDate"
			 Public Const ToPSReport As String = "ToPSReport"
			 Public Const ToPSReport2 As String = "ToPSReport2"
			 Public Const ToPSDiagram As String = "ToPSDiagram"
			 Public Const PSEmailedDate As String = "PSEmailedDate"
			 Public Const Frequency As String = "Frequency"
			 Public Const Address1 As String = "Address1"
			 Public Const Address2 As String = "Address2"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Phone1 As String = "Phone1"
			 Public Const Fax As String = "Fax"
			 Public Const InspNotes As String = "InspNotes"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const Rpt1Client As String = "Rpt1Client"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const Engineer As String = "Engineer"
			 Public Const SchedFROM As String = "SchedFROM"
			 Public Const SchedTO As String = "SchedTO"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const TotalUSTIV As String = "TotalUSTIV"
			 Public Const TotalUSPD As String = "TotalUSPD"
			 Public Const TotalUSBI As String = "TotalUSBI"
			 Public Const _100PercentUSTot As String = "_100PercentUSTot"
			 Public Const SchedulingComment As String = "SchedulingComment"
			 Public Const CustomAccess As String = "CustomAccess"
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
			SyncLock GetType(ViewCCLocationListingPSMetadata)
			
				If ViewCCLocationListingPSMetadata.mapDelegates Is Nothing Then
					ViewCCLocationListingPSMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationListingPSMetadata._meta Is Nothing Then
					ViewCCLocationListingPSMetadata._meta = New ViewCCLocationListingPSMetadata()
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
				


				meta.AddTypeMap("Client", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Facility", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ClientLocNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Report2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Rpt2Revwr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt2Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Region", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ServicedBy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocalTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PSReportArchiveID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PSLastInspectionReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PSLastInspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PSActualDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ToPSReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToPSReport2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToPSDiagram", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PSEmailedDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Frequency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Phone1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspNotes", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DateCompleted", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt1Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("LocationStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectionStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Engineer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SchedFROM", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("SchedTO", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("NextInspYr", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("TotalUSTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalUSPD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalUSBI", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("_100PercentUSTot", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("SchedulingComment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GSafeGUID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecNum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecCount", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCLocationListingPS"
				meta.Destination = "viewCCLocationListingPS"
				
				meta.spInsert = "proc_viewCCLocationListingPSInsert"
				meta.spUpdate = "proc_viewCCLocationListingPSUpdate"
				meta.spDelete = "proc_viewCCLocationListingPSDelete"
				meta.spLoadAll = "proc_viewCCLocationListingPSLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationListingPSLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationListingPSMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
