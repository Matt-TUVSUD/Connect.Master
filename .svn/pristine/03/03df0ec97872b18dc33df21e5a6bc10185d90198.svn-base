
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
	' Encapsulates the 'viewCCLocationAllViolationsJuris' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationAllViolationsJuris))> _
	<XmlType("ViewCCLocationAllViolationsJuris")> _	
	Partial Public Class ViewCCLocationAllViolationsJuris 
		Inherits esViewCCLocationAllViolationsJuris
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationAllViolationsJuris()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationAllViolationsJurisCollection")> _
	Partial Public Class ViewCCLocationAllViolationsJurisCollection
		Inherits esViewCCLocationAllViolationsJurisCollection
		Implements IEnumerable(Of ViewCCLocationAllViolationsJuris)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationAllViolationsJuris))> _
		Public Class ViewCCLocationAllViolationsJurisCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationAllViolationsJurisCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationAllViolationsJurisCollectionWCFPacket) As ViewCCLocationAllViolationsJurisCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationAllViolationsJurisCollection) As ViewCCLocationAllViolationsJurisCollectionWCFPacket
				Return New ViewCCLocationAllViolationsJurisCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationAllViolationsJurisQuery 
		Inherits esViewCCLocationAllViolationsJurisQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationAllViolationsJurisQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationAllViolationsJurisQuery) As String
			Return ViewCCLocationAllViolationsJurisQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationAllViolationsJurisQuery
			Return DirectCast(ViewCCLocationAllViolationsJurisQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationAllViolationsJurisQuery)), ViewCCLocationAllViolationsJurisQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationAllViolationsJuris
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Client__Loc_ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ClientLocID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ClientLocID, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ClientLocID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.St_Prov
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Juris_No
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property JurisNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.JurisNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.JurisNo, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.JurisNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Nat_Bd_No
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatBdNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.NatBdNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.NatBdNo, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.NatBdNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Vessel_Type
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property VesselType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.VesselType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.VesselType, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.VesselType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Manufacturer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Manufacturer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Manufacturer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Manufacturer, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Manufacturer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Year_Built
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property YearBuilt As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.YearBuilt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.YearBuilt, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.YearBuilt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Object_Location
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ObjectLocation As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ObjectLocation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ObjectLocation, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ObjectLocation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Status
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Status, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Status)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Cert_Exp_Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CertExpDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.CertExpDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.CertExpDate, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.CertExpDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Violation__ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ViolationID As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationID, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Violation__Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ViolationDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationDate, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Violation__Type
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ViolationType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationType, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Violation__Category
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ViolationCategory As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationCategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationCategory, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationCategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Violation__Status
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ViolationStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationStatus, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Resolution__Reqd_Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResolutionReqdDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ResolutionReqdDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ResolutionReqdDate, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ResolutionReqdDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Comment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Comment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Comment, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Comment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Requirement
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Requirement As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Requirement)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Requirement, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Requirement)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Condition
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Condition As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Condition)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Condition, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Condition)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationAllViolationsJuris.Closed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Closed As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Closed)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Closed, value) Then
					OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Closed)
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
												
						Case "ClientLocID"
							Me.str().ClientLocID = CType(value, string)
												
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
												
						Case "JurisNo"
							Me.str().JurisNo = CType(value, string)
												
						Case "NatBdNo"
							Me.str().NatBdNo = CType(value, string)
												
						Case "VesselType"
							Me.str().VesselType = CType(value, string)
												
						Case "Manufacturer"
							Me.str().Manufacturer = CType(value, string)
												
						Case "YearBuilt"
							Me.str().YearBuilt = CType(value, string)
												
						Case "ObjectLocation"
							Me.str().ObjectLocation = CType(value, string)
												
						Case "Status"
							Me.str().Status = CType(value, string)
												
						Case "CertExpDate"
							Me.str().CertExpDate = CType(value, string)
												
						Case "ViolationID"
							Me.str().ViolationID = CType(value, string)
												
						Case "ViolationDate"
							Me.str().ViolationDate = CType(value, string)
												
						Case "ViolationType"
							Me.str().ViolationType = CType(value, string)
												
						Case "ViolationCategory"
							Me.str().ViolationCategory = CType(value, string)
												
						Case "ViolationStatus"
							Me.str().ViolationStatus = CType(value, string)
												
						Case "ResolutionReqdDate"
							Me.str().ResolutionReqdDate = CType(value, string)
												
						Case "Comment"
							Me.str().Comment = CType(value, string)
												
						Case "Requirement"
							Me.str().Requirement = CType(value, string)
												
						Case "Condition"
							Me.str().Condition = CType(value, string)
												
						Case "Closed"
							Me.str().Closed = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "YearBuilt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.YearBuilt = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.YearBuilt)
							End If
						
						Case "CertExpDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CertExpDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.CertExpDate)
							End If
						
						Case "ViolationID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ViolationID = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationID)
							End If
						
						Case "ViolationDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ViolationDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationDate)
							End If
						
						Case "ResolutionReqdDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResolutionReqdDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ResolutionReqdDate)
							End If
						
						Case "Closed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Closed = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Closed)
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
		
			Public Sub New(ByVal entity As esViewCCLocationAllViolationsJuris)
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
		  	
			Public Property ClientLocID As System.String 
				Get
					Dim data_ As System.String = entity.ClientLocID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClientLocID = Nothing
					Else
						entity.ClientLocID = Convert.ToString(Value)
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
		  	
			Public Property JurisNo As System.String 
				Get
					Dim data_ As System.String = entity.JurisNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.JurisNo = Nothing
					Else
						entity.JurisNo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatBdNo As System.String 
				Get
					Dim data_ As System.String = entity.NatBdNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatBdNo = Nothing
					Else
						entity.NatBdNo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property VesselType As System.String 
				Get
					Dim data_ As System.String = entity.VesselType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VesselType = Nothing
					Else
						entity.VesselType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Manufacturer As System.String 
				Get
					Dim data_ As System.String = entity.Manufacturer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Manufacturer = Nothing
					Else
						entity.Manufacturer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property YearBuilt As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.YearBuilt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.YearBuilt = Nothing
					Else
						entity.YearBuilt = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ObjectLocation As System.String 
				Get
					Dim data_ As System.String = entity.ObjectLocation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ObjectLocation = Nothing
					Else
						entity.ObjectLocation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Status As System.String 
				Get
					Dim data_ As System.String = entity.Status
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Status = Nothing
					Else
						entity.Status = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CertExpDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CertExpDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CertExpDate = Nothing
					Else
						entity.CertExpDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ViolationID As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ViolationID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ViolationID = Nothing
					Else
						entity.ViolationID = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ViolationDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ViolationDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ViolationDate = Nothing
					Else
						entity.ViolationDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ViolationType As System.String 
				Get
					Dim data_ As System.String = entity.ViolationType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ViolationType = Nothing
					Else
						entity.ViolationType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ViolationCategory As System.String 
				Get
					Dim data_ As System.String = entity.ViolationCategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ViolationCategory = Nothing
					Else
						entity.ViolationCategory = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ViolationStatus As System.String 
				Get
					Dim data_ As System.String = entity.ViolationStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ViolationStatus = Nothing
					Else
						entity.ViolationStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResolutionReqdDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ResolutionReqdDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResolutionReqdDate = Nothing
					Else
						entity.ResolutionReqdDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Comment As System.String 
				Get
					Dim data_ As System.String = entity.Comment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Comment = Nothing
					Else
						entity.Comment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Requirement As System.String 
				Get
					Dim data_ As System.String = entity.Requirement
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Requirement = Nothing
					Else
						entity.Requirement = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Condition As System.String 
				Get
					Dim data_ As System.String = entity.Condition
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Condition = Nothing
					Else
						entity.Condition = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Closed As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Closed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Closed = Nothing
					Else
						entity.Closed = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCLocationAllViolationsJuris
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationAllViolationsJurisMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationAllViolationsJurisQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationAllViolationsJurisQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationAllViolationsJurisQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationAllViolationsJurisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationAllViolationsJurisQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationAllViolationsJurisCollection
		Inherits esEntityCollection(Of ViewCCLocationAllViolationsJuris)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationAllViolationsJurisMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationAllViolationsJurisCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationAllViolationsJurisQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationAllViolationsJurisQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationAllViolationsJurisQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationAllViolationsJurisQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationAllViolationsJurisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationAllViolationsJurisQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationAllViolationsJurisQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationAllViolationsJurisQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationAllViolationsJurisMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "ClientLocID" 
					Return Me.ClientLocID
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
				Case "JurisNo" 
					Return Me.JurisNo
				Case "NatBdNo" 
					Return Me.NatBdNo
				Case "VesselType" 
					Return Me.VesselType
				Case "Manufacturer" 
					Return Me.Manufacturer
				Case "YearBuilt" 
					Return Me.YearBuilt
				Case "ObjectLocation" 
					Return Me.ObjectLocation
				Case "Status" 
					Return Me.Status
				Case "CertExpDate" 
					Return Me.CertExpDate
				Case "ViolationID" 
					Return Me.ViolationID
				Case "ViolationDate" 
					Return Me.ViolationDate
				Case "ViolationType" 
					Return Me.ViolationType
				Case "ViolationCategory" 
					Return Me.ViolationCategory
				Case "ViolationStatus" 
					Return Me.ViolationStatus
				Case "ResolutionReqdDate" 
					Return Me.ResolutionReqdDate
				Case "Comment" 
					Return Me.Comment
				Case "Requirement" 
					Return Me.Requirement
				Case "Condition" 
					Return Me.Condition
				Case "Closed" 
					Return Me.Closed
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ClientLocID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property JurisNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.JurisNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatBdNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.NatBdNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property VesselType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.VesselType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Manufacturer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Manufacturer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property YearBuilt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.YearBuilt, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ObjectLocation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ObjectLocation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CertExpDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.CertExpDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ViolationID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationID, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ViolationDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ViolationType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ViolationCategory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationCategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ViolationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResolutionReqdDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ResolutionReqdDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Comment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Comment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Requirement As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Requirement, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Condition As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Condition, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Closed As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Closed, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationAllViolationsJurisMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ClientLocID, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ClientLocID
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Division, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Division
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Facility, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Address, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Address
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.City, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.City
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.StProv, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Country, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Country
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.JurisNo, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.JurisNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.NatBdNo, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.NatBdNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.VesselType, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.VesselType
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Manufacturer, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Manufacturer
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.YearBuilt, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.YearBuilt
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ObjectLocation, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ObjectLocation
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Status, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Status
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.CertExpDate, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.CertExpDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationID, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationDate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationType, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationCategory, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationCategory
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ViolationStatus, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ViolationStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.ResolutionReqdDate, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.ResolutionReqdDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Comment, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Comment
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Requirement, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Requirement
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Condition, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Condition
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationAllViolationsJurisMetadata.ColumnNames.Closed, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationAllViolationsJurisMetadata.PropertyNames.Closed
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationAllViolationsJurisMetadata
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
			 Public Const ClientLocID As String = "Client__Loc_ID"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const Address As String = "Address"
			 Public Const City As String = "City"
			 Public Const StProv As String = "St_Prov"
			 Public Const Country As String = "Country"
			 Public Const JurisNo As String = "Juris_No"
			 Public Const NatBdNo As String = "Nat_Bd_No"
			 Public Const VesselType As String = "Vessel_Type"
			 Public Const Manufacturer As String = "Manufacturer"
			 Public Const YearBuilt As String = "Year_Built"
			 Public Const ObjectLocation As String = "Object_Location"
			 Public Const Status As String = "Status"
			 Public Const CertExpDate As String = "Cert_Exp_Date"
			 Public Const ViolationID As String = "Violation__ID"
			 Public Const ViolationDate As String = "Violation__Date"
			 Public Const ViolationType As String = "Violation__Type"
			 Public Const ViolationCategory As String = "Violation__Category"
			 Public Const ViolationStatus As String = "Violation__Status"
			 Public Const ResolutionReqdDate As String = "Resolution__Reqd_Date"
			 Public Const Comment As String = "Comment"
			 Public Const Requirement As String = "Requirement"
			 Public Const Condition As String = "Condition"
			 Public Const Closed As String = "Closed"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const ClientLocID As String = "ClientLocID"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const Address As String = "Address"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Country As String = "Country"
			 Public Const JurisNo As String = "JurisNo"
			 Public Const NatBdNo As String = "NatBdNo"
			 Public Const VesselType As String = "VesselType"
			 Public Const Manufacturer As String = "Manufacturer"
			 Public Const YearBuilt As String = "YearBuilt"
			 Public Const ObjectLocation As String = "ObjectLocation"
			 Public Const Status As String = "Status"
			 Public Const CertExpDate As String = "CertExpDate"
			 Public Const ViolationID As String = "ViolationID"
			 Public Const ViolationDate As String = "ViolationDate"
			 Public Const ViolationType As String = "ViolationType"
			 Public Const ViolationCategory As String = "ViolationCategory"
			 Public Const ViolationStatus As String = "ViolationStatus"
			 Public Const ResolutionReqdDate As String = "ResolutionReqdDate"
			 Public Const Comment As String = "Comment"
			 Public Const Requirement As String = "Requirement"
			 Public Const Condition As String = "Condition"
			 Public Const Closed As String = "Closed"
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
			SyncLock GetType(ViewCCLocationAllViolationsJurisMetadata)
			
				If ViewCCLocationAllViolationsJurisMetadata.mapDelegates Is Nothing Then
					ViewCCLocationAllViolationsJurisMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationAllViolationsJurisMetadata._meta Is Nothing Then
					ViewCCLocationAllViolationsJurisMetadata._meta = New ViewCCLocationAllViolationsJurisMetadata()
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
				


				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ClientLocID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Facility", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Address", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("JurisNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NatBdNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("VesselType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Manufacturer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("YearBuilt", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ObjectLocation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Status", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CertExpDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ViolationID", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ViolationDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ViolationType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ViolationCategory", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ViolationStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ResolutionReqdDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Comment", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Requirement", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Condition", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Closed", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewCCLocationAllViolationsJuris"
				meta.Destination = "viewCCLocationAllViolationsJuris"
				
				meta.spInsert = "proc_viewCCLocationAllViolationsJurisInsert"
				meta.spUpdate = "proc_viewCCLocationAllViolationsJurisUpdate"
				meta.spDelete = "proc_viewCCLocationAllViolationsJurisDelete"
				meta.spLoadAll = "proc_viewCCLocationAllViolationsJurisLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationAllViolationsJurisLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationAllViolationsJurisMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
