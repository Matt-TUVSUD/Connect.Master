
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/26/2012 12:14:12 PM
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
	' Encapsulates the 'viewCCLocationListingBMGroupBy' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationListingBMGroupBy))> _
	<XmlType("ViewCCLocationListingBMGroupBy")> _	
	Partial Public Class ViewCCLocationListingBMGroupBy 
		Inherits esViewCCLocationListingBMGroupBy
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationListingBMGroupBy()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationListingBMGroupByCollection")> _
	Partial Public Class ViewCCLocationListingBMGroupByCollection
		Inherits esViewCCLocationListingBMGroupByCollection
		Implements IEnumerable(Of ViewCCLocationListingBMGroupBy)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationListingBMGroupBy))> _
		Public Class ViewCCLocationListingBMGroupByCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationListingBMGroupByCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationListingBMGroupByCollectionWCFPacket) As ViewCCLocationListingBMGroupByCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationListingBMGroupByCollection) As ViewCCLocationListingBMGroupByCollectionWCFPacket
				Return New ViewCCLocationListingBMGroupByCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationListingBMGroupByQuery 
		Inherits esViewCCLocationListingBMGroupByQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationListingBMGroupByQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationListingBMGroupByQuery) As String
			Return ViewCCLocationListingBMGroupByQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationListingBMGroupByQuery
			Return DirectCast(ViewCCLocationListingBMGroupByQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationListingBMGroupByQuery)), ViewCCLocationListingBMGroupByQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingBMGroupBy
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.LocalTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocalTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.LocalTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.LocalTIV, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.LocalTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingBMGroupByMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingBMGroupByMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Frequency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Frequency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Frequency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Frequency, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Frequency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Address1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.PHONE1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Phone1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Phone1, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Phone1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.FAX
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.DateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingBMGroupByMetadata.ColumnNames.DateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingBMGroupByMetadata.ColumnNames.DateCompleted, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.DateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Rpt1Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt1Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Rpt1Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Rpt1Client, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Rpt1Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.LocationStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.LocationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.LocationStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.LocationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.InspectionStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.InspectionStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.InspectionStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.InspectionStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.SchedFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedFROM As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedFROM)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedFROM, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.SchedFROM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.SchedTO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedTO As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedTO)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedTO, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.SchedTO)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.InspNotes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspNotes As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.InspNotes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.InspNotes, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.InspNotes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.NextInspYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NextInspYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingBMGroupByMetadata.ColumnNames.NextInspYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingBMGroupByMetadata.ColumnNames.NextInspYr, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.NextInspYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationListingBMGroupByMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationListingBMGroupByMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.TotalUS_TIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.TotalUSTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.TotalUSTIV, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.TotalUSTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.SchedulingComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedulingComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedulingComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedulingComment, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.SchedulingComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingBMGroupBy.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingBMGroupByMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.CustomAccess)
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
												
						Case "LocalTIV"
							Me.str().LocalTIV = CType(value, string)
												
						Case "Client"
							Me.str().Client = CType(value, string)
												
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
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
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
												
						Case "DateCompleted"
							Me.str().DateCompleted = CType(value, string)
												
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
												
						Case "InspNotes"
							Me.str().InspNotes = CType(value, string)
												
						Case "NextInspYr"
							Me.str().NextInspYr = CType(value, string)
												
						Case "_100PercentUSTot"
							Me.str()._100PercentUSTot = CType(value, string)
												
						Case "TotalUSTIV"
							Me.str().TotalUSTIV = CType(value, string)
												
						Case "Engineer"
							Me.str().Engineer = CType(value, string)
												
						Case "SchedulingComment"
							Me.str().SchedulingComment = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Longitude)
							End If
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "DateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.DateCompleted)
							End If
						
						Case "Rpt1Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt1Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.Rpt1Client)
							End If
						
						Case "SchedFROM"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedFROM = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.SchedFROM)
							End If
						
						Case "SchedTO"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedTO = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.SchedTO)
							End If
						
						Case "NextInspYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NextInspYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames.NextInspYr)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationListingBMGroupByMetadata.PropertyNames._100PercentUSTot)
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
		
			Public Sub New(ByVal entity As esViewCCLocationListingBMGroupBy)
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
		  

			Private entity As esViewCCLocationListingBMGroupBy
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingBMGroupByMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationListingBMGroupByQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingBMGroupByQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationListingBMGroupByQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationListingBMGroupByQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationListingBMGroupByQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingBMGroupByCollection
		Inherits esEntityCollection(Of ViewCCLocationListingBMGroupBy)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingBMGroupByMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationListingBMGroupByCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationListingBMGroupByQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingBMGroupByQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationListingBMGroupByQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationListingBMGroupByQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationListingBMGroupByQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationListingBMGroupByQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationListingBMGroupByQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationListingBMGroupByQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingBMGroupByMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "LocalTIV" 
					Return Me.LocalTIV
				Case "Client" 
					Return Me.Client
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
				Case "PracticeCode" 
					Return Me.PracticeCode
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
				Case "DateCompleted" 
					Return Me.DateCompleted
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
				Case "InspNotes" 
					Return Me.InspNotes
				Case "NextInspYr" 
					Return Me.NextInspYr
				Case "_100PercentUSTot" 
					Return Me._100PercentUSTot
				Case "TotalUSTIV" 
					Return Me.TotalUSTIV
				Case "Engineer" 
					Return Me.Engineer
				Case "SchedulingComment" 
					Return Me.SchedulingComment
				Case "CustomAccess" 
					Return Me.CustomAccess
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocalTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.LocalTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Frequency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Frequency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Phone1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.DateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt1Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Rpt1Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LocationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.LocationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.InspectionStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedFROM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedFROM, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SchedTO As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedTO, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InspNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.InspNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NextInspYr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.NextInspYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.TotalUSTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedulingComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedulingComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingBMGroupByMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationListingBMGroupByMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.LocalTIV, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.LocalTIV
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Latitude, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Longitude, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Facility, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.PracticeCode, 8, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Frequency, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Frequency
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Address1, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.City, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.StProv, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Zip, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Country, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Phone1, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Phone1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Fax, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Fax
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.DateCompleted, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.DateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Rpt1Client, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Rpt1Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.LocationStatus, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.LocationStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.InspectionStatus, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.InspectionStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedFROM, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.SchedFROM
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedTO, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.SchedTO
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.InspNotes, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.InspNotes
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.NextInspYr, 24, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.NextInspYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames._100PercentUSTot, 25, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.TotalUSTIV, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.TotalUSTIV
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.Engineer, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.SchedulingComment, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.SchedulingComment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingBMGroupByMetadata.ColumnNames.CustomAccess, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingBMGroupByMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationListingBMGroupByMetadata
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
			 Public Const LocalTIV As String = "LocalTIV"
			 Public Const Client As String = "Client"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const Facility As String = "Facility"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Frequency As String = "Frequency"
			 Public Const Address1 As String = "Address1"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Phone1 As String = "PHONE1"
			 Public Const Fax As String = "FAX"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const Rpt1Client As String = "Rpt1Client"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const SchedFROM As String = "SchedFROM"
			 Public Const SchedTO As String = "SchedTO"
			 Public Const InspNotes As String = "InspNotes"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const _100PercentUSTot As String = "100PercentUSTot"
			 Public Const TotalUSTIV As String = "TotalUS_TIV"
			 Public Const Engineer As String = "Engineer"
			 Public Const SchedulingComment As String = "SchedulingComment"
			 Public Const CustomAccess As String = "CustomAccess"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const LocalTIV As String = "LocalTIV"
			 Public Const Client As String = "Client"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const Facility As String = "Facility"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Frequency As String = "Frequency"
			 Public Const Address1 As String = "Address1"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Phone1 As String = "Phone1"
			 Public Const Fax As String = "Fax"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const Rpt1Client As String = "Rpt1Client"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const SchedFROM As String = "SchedFROM"
			 Public Const SchedTO As String = "SchedTO"
			 Public Const InspNotes As String = "InspNotes"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const _100PercentUSTot As String = "_100PercentUSTot"
			 Public Const TotalUSTIV As String = "TotalUSTIV"
			 Public Const Engineer As String = "Engineer"
			 Public Const SchedulingComment As String = "SchedulingComment"
			 Public Const CustomAccess As String = "CustomAccess"
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
			SyncLock GetType(ViewCCLocationListingBMGroupByMetadata)
			
				If ViewCCLocationListingBMGroupByMetadata.mapDelegates Is Nothing Then
					ViewCCLocationListingBMGroupByMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationListingBMGroupByMetadata._meta Is Nothing Then
					ViewCCLocationListingBMGroupByMetadata._meta = New ViewCCLocationListingBMGroupByMetadata()
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
				meta.AddTypeMap("LocalTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Client", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ClientLocNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Facility", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Frequency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Phone1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DateCompleted", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt1Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("LocationStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectionStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SchedFROM", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("SchedTO", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("InspNotes", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NextInspYr", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("_100PercentUSTot", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotalUSTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Engineer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SchedulingComment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCLocationListingBMGroupBy"
				meta.Destination = "viewCCLocationListingBMGroupBy"
				
				meta.spInsert = "proc_viewCCLocationListingBMGroupByInsert"
				meta.spUpdate = "proc_viewCCLocationListingBMGroupByUpdate"
				meta.spDelete = "proc_viewCCLocationListingBMGroupByDelete"
				meta.spLoadAll = "proc_viewCCLocationListingBMGroupByLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationListingBMGroupByLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationListingBMGroupByMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
