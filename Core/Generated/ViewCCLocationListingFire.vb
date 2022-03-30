
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/31/2019 10:44:05 AM
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
	' Encapsulates the 'viewCCLocationListingFire' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationListingFire))> _
	<XmlType("ViewCCLocationListingFire")> _	
	Partial Public Class ViewCCLocationListingFire 
		Inherits esViewCCLocationListingFire
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationListingFire()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationListingFireCollection")> _
	Partial Public Class ViewCCLocationListingFireCollection
		Inherits esViewCCLocationListingFireCollection
		Implements IEnumerable(Of ViewCCLocationListingFire)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationListingFire))> _
		Public Class ViewCCLocationListingFireCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationListingFireCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationListingFireCollectionWCFPacket) As ViewCCLocationListingFireCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationListingFireCollection) As ViewCCLocationListingFireCollectionWCFPacket
				Return New ViewCCLocationListingFireCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationListingFireQuery 
		Inherits esViewCCLocationListingFireQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationListingFireQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationListingFireQuery) As String
			Return ViewCCLocationListingFireQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationListingFireQuery
			Return DirectCast(ViewCCLocationListingFireQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationListingFireQuery)), ViewCCLocationListingFireQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingFire
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationListingFire.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingFireMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingFireMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Report2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Report2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Report2, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Report2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Rpt2Revwr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Revwr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.Rpt2Revwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.Rpt2Revwr, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Rpt2Revwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Rpt2Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.Rpt2Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.Rpt2Client, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Rpt2Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Region
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Region As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Region)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Region, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Region)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.ServicedBy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ServicedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ServicedBy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ServicedBy, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.ServicedBy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.LocalTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocalTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.LocalTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.LocalTIV, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.LocalTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.FireReportArchiveID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireReportArchiveID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireMetadata.ColumnNames.FireReportArchiveID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireMetadata.ColumnNames.FireReportArchiveID, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireReportArchiveID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.FireLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.FireLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.FireLastInspectionReport, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.FireLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.FireLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.FireLastInspectionDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.FireActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.FireActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.FireActualDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.ToFireReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ToFireReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ToFireReport, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.ToFireReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.ToFireReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireReport2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ToFireReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ToFireReport2, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.ToFireReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.ToFireDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ToFireDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.ToFireDiagram, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.ToFireDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.FireEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.FireEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.FireEmailedDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Frequency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Frequency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Frequency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Frequency, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Frequency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Address1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Address2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Address2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Address2, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Address2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.PHONE1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Phone1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Phone1, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Phone1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.FAX
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.InspNotes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspNotes As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.InspNotes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.InspNotes, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.InspNotes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.DateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.DateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.DateCompleted, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.DateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Rpt1Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt1Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.Rpt1Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.Rpt1Client, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Rpt1Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.LocationStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.LocationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.LocationStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.LocationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.InspectionStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.InspectionStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.InspectionStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.InspectionStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.SchedFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedFROM As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.SchedFROM)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.SchedFROM, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.SchedFROM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.SchedTO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedTO As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.SchedTO)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireMetadata.ColumnNames.SchedTO, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.SchedTO)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.NextInspYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NextInspYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingFireMetadata.ColumnNames.NextInspYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingFireMetadata.ColumnNames.NextInspYr, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.NextInspYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.TotalUS_TIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSTIV, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.TotalUSTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.TotalUS_PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSPD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSPD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSPD, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.TotalUSPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.TotalUS_BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSBI As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSBI)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSBI, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.TotalUSBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationListingFireMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationListingFireMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.SchedulingComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedulingComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.SchedulingComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.SchedulingComment, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.SchedulingComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.GSafeGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeGUID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.GSafeGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireMetadata.ColumnNames.GSafeGUID, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.GSafeGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.RecNum
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireMetadata.ColumnNames.RecNum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireMetadata.ColumnNames.RecNum, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.RecNum)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFire.RecCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireMetadata.ColumnNames.RecCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireMetadata.ColumnNames.RecCount, value) Then
					OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.RecCount)
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
												
						Case "FireReportArchiveID"
							Me.str().FireReportArchiveID = CType(value, string)
												
						Case "FireLastInspectionReport"
							Me.str().FireLastInspectionReport = CType(value, string)
												
						Case "FireLastInspectionDate"
							Me.str().FireLastInspectionDate = CType(value, string)
												
						Case "FireActualDate"
							Me.str().FireActualDate = CType(value, string)
												
						Case "ToFireReport"
							Me.str().ToFireReport = CType(value, string)
												
						Case "ToFireReport2"
							Me.str().ToFireReport2 = CType(value, string)
												
						Case "ToFireDiagram"
							Me.str().ToFireDiagram = CType(value, string)
												
						Case "FireEmailedDate"
							Me.str().FireEmailedDate = CType(value, string)
												
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
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "Rpt2Revwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Revwr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Rpt2Revwr)
							End If
						
						Case "Rpt2Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Rpt2Client)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Longitude)
							End If
						
						Case "FireReportArchiveID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FireReportArchiveID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireReportArchiveID)
							End If
						
						Case "FireLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireLastInspectionDate)
							End If
						
						Case "FireActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireActualDate)
							End If
						
						Case "FireEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.FireEmailedDate)
							End If
						
						Case "DateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.DateCompleted)
							End If
						
						Case "Rpt1Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt1Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.Rpt1Client)
							End If
						
						Case "SchedFROM"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedFROM = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.SchedFROM)
							End If
						
						Case "SchedTO"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedTO = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.SchedTO)
							End If
						
						Case "NextInspYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NextInspYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.NextInspYr)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "RecNum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNum = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.RecNum)
							End If
						
						Case "RecCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireMetadata.PropertyNames.RecCount)
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
		
			Public Sub New(ByVal entity As esViewCCLocationListingFire)
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
		  	
			Public Property FireReportArchiveID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FireReportArchiveID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireReportArchiveID = Nothing
					Else
						entity.FireReportArchiveID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.FireLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireLastInspectionReport = Nothing
					Else
						entity.FireLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.FireLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireLastInspectionDate = Nothing
					Else
						entity.FireLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.FireActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireActualDate = Nothing
					Else
						entity.FireActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToFireReport As System.String 
				Get
					Dim data_ As System.String = entity.ToFireReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToFireReport = Nothing
					Else
						entity.ToFireReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToFireReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToFireReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToFireReport2 = Nothing
					Else
						entity.ToFireReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToFireDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToFireDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToFireDiagram = Nothing
					Else
						entity.ToFireDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.FireEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireEmailedDate = Nothing
					Else
						entity.FireEmailedDate = Convert.ToDateTime(Value)
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
		  

			Private entity As esViewCCLocationListingFire
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingFireMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationListingFireQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingFireQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationListingFireQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationListingFireQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationListingFireQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingFireCollection
		Inherits esEntityCollection(Of ViewCCLocationListingFire)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingFireMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationListingFireCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationListingFireQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingFireQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationListingFireQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationListingFireQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationListingFireQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationListingFireQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationListingFireQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationListingFireQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingFireMetadata.Meta()
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
				Case "FireReportArchiveID" 
					Return Me.FireReportArchiveID
				Case "FireLastInspectionReport" 
					Return Me.FireLastInspectionReport
				Case "FireLastInspectionDate" 
					Return Me.FireLastInspectionDate
				Case "FireActualDate" 
					Return Me.FireActualDate
				Case "ToFireReport" 
					Return Me.ToFireReport
				Case "ToFireReport2" 
					Return Me.ToFireReport2
				Case "ToFireDiagram" 
					Return Me.ToFireDiagram
				Case "FireEmailedDate" 
					Return Me.FireEmailedDate
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
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Report2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Report2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Revwr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Rpt2Revwr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Rpt2Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Region As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Region, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ServicedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.ServicedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocalTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.LocalTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FireReportArchiveID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.FireReportArchiveID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FireLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.FireLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.FireLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FireActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.FireActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.ToFireReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.ToFireReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.ToFireDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.FireEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Frequency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Frequency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Address2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Phone1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.InspNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.DateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt1Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Rpt1Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LocationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.LocationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.InspectionStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedFROM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.SchedFROM, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SchedTO As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.SchedTO, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NextInspYr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.NextInspYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.TotalUSTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.TotalUSPD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.TotalUSBI, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property SchedulingComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.SchedulingComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GSafeGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.GSafeGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.RecNum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireMetadata.ColumnNames.RecCount, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationListingFireMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Client, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.PracticeCode, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Facility, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.FileNo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Report2, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Report2
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Rpt2Revwr, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Rpt2Revwr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Rpt2Client, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Rpt2Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Region, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Region
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.ServicedBy, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.ServicedBy
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.LocalTIV, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.LocalTIV
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Division, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Latitude, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Longitude, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.FireReportArchiveID, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.FireReportArchiveID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.FireLastInspectionReport, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.FireLastInspectionReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.FireLastInspectionDate, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.FireLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.FireActualDate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.FireActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.ToFireReport, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.ToFireReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.ToFireReport2, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.ToFireReport2
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.ToFireDiagram, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.ToFireDiagram
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.FireEmailedDate, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.FireEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Frequency, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Frequency
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Address1, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Address2, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Address2
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.City, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.StProv, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Zip, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Country, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Phone1, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Phone1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Fax, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Fax
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.InspNotes, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.InspNotes
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.DateCompleted, 32, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.DateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Rpt1Client, 33, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Rpt1Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.LocationStatus, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.LocationStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.InspectionStatus, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.InspectionStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.Engineer, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.SchedFROM, 37, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.SchedFROM
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.SchedTO, 38, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.SchedTO
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.NextInspYr, 39, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.NextInspYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSTIV, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.TotalUSTIV
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSPD, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.TotalUSPD
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.TotalUSBI, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.TotalUSBI
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames._100PercentUSTot, 43, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.SchedulingComment, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.SchedulingComment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.CustomAccess, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.GSafeGUID, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.GSafeGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.RecNum, 47, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.RecNum
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireMetadata.ColumnNames.RecCount, 48, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireMetadata.PropertyNames.RecCount
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationListingFireMetadata
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
			 Public Const FireReportArchiveID As String = "FireReportArchiveID"
			 Public Const FireLastInspectionReport As String = "FireLastInspectionReport"
			 Public Const FireLastInspectionDate As String = "FireLastInspectionDate"
			 Public Const FireActualDate As String = "FireActualDate"
			 Public Const ToFireReport As String = "ToFireReport"
			 Public Const ToFireReport2 As String = "ToFireReport2"
			 Public Const ToFireDiagram As String = "ToFireDiagram"
			 Public Const FireEmailedDate As String = "FireEmailedDate"
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
			 Public Const FireReportArchiveID As String = "FireReportArchiveID"
			 Public Const FireLastInspectionReport As String = "FireLastInspectionReport"
			 Public Const FireLastInspectionDate As String = "FireLastInspectionDate"
			 Public Const FireActualDate As String = "FireActualDate"
			 Public Const ToFireReport As String = "ToFireReport"
			 Public Const ToFireReport2 As String = "ToFireReport2"
			 Public Const ToFireDiagram As String = "ToFireDiagram"
			 Public Const FireEmailedDate As String = "FireEmailedDate"
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
			SyncLock GetType(ViewCCLocationListingFireMetadata)
			
				If ViewCCLocationListingFireMetadata.mapDelegates Is Nothing Then
					ViewCCLocationListingFireMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationListingFireMetadata._meta Is Nothing Then
					ViewCCLocationListingFireMetadata._meta = New ViewCCLocationListingFireMetadata()
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
				meta.AddTypeMap("FireReportArchiveID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FireLastInspectionReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireLastInspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("FireActualDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ToFireReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToFireReport2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ToFireDiagram", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireEmailedDate", new esTypeMap("datetime", "System.DateTime"))
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
				
				meta.Schema = "dbo"
				 
				meta.Source = "viewCCLocationListingFire"
				meta.Destination = "viewCCLocationListingFire"
				
				meta.spInsert = "proc_viewCCLocationListingFireInsert"
				meta.spUpdate = "proc_viewCCLocationListingFireUpdate"
				meta.spDelete = "proc_viewCCLocationListingFireDelete"
				meta.spLoadAll = "proc_viewCCLocationListingFireLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationListingFireLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationListingFireMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
