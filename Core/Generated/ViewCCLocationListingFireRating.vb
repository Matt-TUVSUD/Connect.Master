
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/30/2019 10:57:19 AM
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
	' Encapsulates the 'viewCCLocationListingFireRating' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationListingFireRating))> _
	<XmlType("ViewCCLocationListingFireRating")> _	
	Partial Public Class ViewCCLocationListingFireRating 
		Inherits esViewCCLocationListingFireRating
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationListingFireRating()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationListingFireRatingCollection")> _
	Partial Public Class ViewCCLocationListingFireRatingCollection
		Inherits esViewCCLocationListingFireRatingCollection
		Implements IEnumerable(Of ViewCCLocationListingFireRating)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationListingFireRating))> _
		Public Class ViewCCLocationListingFireRatingCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationListingFireRatingCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationListingFireRatingCollectionWCFPacket) As ViewCCLocationListingFireRatingCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationListingFireRatingCollection) As ViewCCLocationListingFireRatingCollectionWCFPacket
				Return New ViewCCLocationListingFireRatingCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationListingFireRatingQuery 
		Inherits esViewCCLocationListingFireRatingQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationListingFireRatingQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationListingFireRatingQuery) As String
			Return ViewCCLocationListingFireRatingQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationListingFireRatingQuery
			Return DirectCast(ViewCCLocationListingFireRatingQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationListingFireRatingQuery)), ViewCCLocationListingFireRatingQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingFireRating
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingFireRatingMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingFireRatingMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Report2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Report2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Report2, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Report2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Rpt2Revwr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Revwr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt2Revwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt2Revwr, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt2Revwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Rpt2Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt2Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt2Client, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt2Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Region
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Region As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Region)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Region, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Region)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ServicedBy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ServicedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ServicedBy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ServicedBy, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ServicedBy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.LocalTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocalTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocalTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocalTIV, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.LocalTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Field1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Field1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Field1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Field1, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Field1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Ownership
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ownership As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Ownership)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Ownership, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Ownership)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.IRINo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRINo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.IRINo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.IRINo, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.IRINo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.AccountablePerson
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AccountablePerson As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.AccountablePerson)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.AccountablePerson, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.AccountablePerson)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.PlantID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlantID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlantID, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.PlantID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.PlantName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlantName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlantName, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.PlantName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.GRCEngineerFire
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCEngineerFire As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCEngineerFire)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCEngineerFire, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.GRCEngineerFire)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.GRCEngineerBM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCEngineerBM As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCEngineerBM)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCEngineerBM, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.GRCEngineerBM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.GRCTitle
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCTitle As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCTitle)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCTitle, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.GRCTitle)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ClientLocation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocation As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.ClientLocation)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.ClientLocation, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ClientLocation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.LOCATIONNAME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Locationname As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Locationname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Locationname, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Locationname)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Status
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Status, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Status)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BusinessUnit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessUnit As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BusinessUnit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BusinessUnit, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BusinessUnit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldEntity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldEntity As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldEntity)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldEntity, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldEntity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.OCCUPANCY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occupancy As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Occupancy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Occupancy, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Occupancy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ZONE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zone As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Zone)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Zone, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Zone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldStructure
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldStructure As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldStructure)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldStructure, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldStructure)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.EQUIPMENT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Equipment As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Equipment)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Equipment, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Equipment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.INVENTORY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Inventory As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Inventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Inventory, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Inventory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Pd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Pd, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Pd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bi As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bi, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.TIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tiv As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Tiv)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.Tiv, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Tiv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireFreq
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireFreq As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireFreq)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireFreq, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireFreq)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Fire2000
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2000 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2000)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2000, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2000)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Fire2001
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2001 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2001)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2001, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2001)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Fire2002
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2002 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2002)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2002, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2002)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Fire2003
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2003 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2003)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2003, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2003)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Fire2004
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2004 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2004)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2004, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2004)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Fire2005
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2005 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2005)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2005, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2005)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireTargetMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireTargetMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireTargetMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireTargetMonth, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireTargetMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireLastInspectionReport, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireLastInspectionDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireScheduledDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireScheduledDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireScheduledDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireScheduledDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireScheduledDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireActualDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ToFireReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireReport, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ToFireReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ToFireReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireReport2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireReport2, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ToFireReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ToFireDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireDiagram, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ToFireDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ToBPVReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToBPVReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBPVReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBPVReport, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ToBPVReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireEmailedDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireInspectionCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireInspectionCount As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireInspectionCount)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireInspectionCount, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireInspectionCount)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.SpecialReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecialReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.SpecialReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.SpecialReport, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.SpecialReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.PlanReview
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlanReview As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlanReview)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlanReview, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.PlanReview)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireRecResponseRecevied
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireRecResponseRecevied As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireRecResponseRecevied)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireRecResponseRecevied, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireRecResponseRecevied)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireAQEDateRecevied
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireAQEDateRecevied As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireAQEDateRecevied)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireAQEDateRecevied, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireAQEDateRecevied)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireAQERating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireAQERating As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireAQERating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireAQERating, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireAQERating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMFreq
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMFreq As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMFreq)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMFreq, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMFreq)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BM2000
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2000 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2000)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2000, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2000)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BM2001
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2001 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2001)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2001, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2001)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BM2002
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2002 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2002)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2002, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2002)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BM2003
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2003 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2003)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2003, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2003)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BM2004
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2004 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2004)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2004, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2004)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BM2005
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2005 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2005)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2005, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2005)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMTarget
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMTarget As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMTarget)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMTarget, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMTarget)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.EngineerRequired
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngineerRequired As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.EngineerRequired)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.EngineerRequired, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.EngineerRequired)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMLastInspectionReport, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMLastInspectionDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ToBMDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToBMDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBMDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBMDiagram, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ToBMDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMScheduledDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMScheduledDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMScheduledDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMScheduledDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMScheduledDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMActualDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMEmailedDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ToBMReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToBMReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBMReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBMReport, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ToBMReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMRecResponseReceived
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMRecResponseReceived As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMRecResponseReceived)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMRecResponseReceived, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMRecResponseReceived)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMAQEDateRecevied
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMAQEDateRecevied As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMAQEDateRecevied)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMAQEDateRecevied, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMAQEDateRecevied)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMAQERating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMAQERating As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMAQERating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMAQERating, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMAQERating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMInspectionCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMInspectionCount As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMInspectionCount)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMInspectionCount, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMInspectionCount)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.LocationManager
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationManager As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationManager)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationManager, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationManager)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.LocationPhone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationPhone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationPhone, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationPhone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.LocationFax
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationFax As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationFax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationFax, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationFax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.LocationEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationEmail, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ARISELastInspection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARISELastInspection As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISELastInspection)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISELastInspection, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ARISELastInspection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ARISEInspectionLetter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARISEInspectionLetter As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISEInspectionLetter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISEInspectionLetter, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ARISEInspectionLetter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ARISELocationManager
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARISELocationManager As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISELocationManager)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISELocationManager, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ARISELocationManager)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireComments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireComments, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMComments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMComments, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BPVComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BPVComments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BPVComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.BPVComments, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BPVComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldAPLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldAPLPD As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLPD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLPD, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldAPLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldAPLBI As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLBI)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLBI, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldAPLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldAPLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLTotal, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldPMLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldPMLPD As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLPD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLPD, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldPMLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldPMLBI As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLBI)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLBI, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldPMLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldPMLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLTotal, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldMFLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldMFLPD As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLPD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLPD, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldMFLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldMFLBI As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLBI)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLBI, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.fldMFLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldMFLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLTotal, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FireUpdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireUpdate As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireUpdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireUpdate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireUpdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BMUpdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMUpdate As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMUpdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMUpdate, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMUpdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.SquareFootage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SquareFootage As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.SquareFootage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.SquareFootage, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.SquareFootage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Frequency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Frequency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Frequency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Frequency, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Frequency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Address1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Address2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Address2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Address2, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Address2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.PHONE1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Phone1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Phone1, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Phone1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.FAX
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.InspNotes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspNotes As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.InspNotes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.InspNotes, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.InspNotes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.BusinessContinuationPlan
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessContinuationPlan As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCLocationListingFireRatingMetadata.ColumnNames.BusinessContinuationPlan)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCLocationListingFireRatingMetadata.ColumnNames.BusinessContinuationPlan, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BusinessContinuationPlan)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.DateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.DateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.DateCompleted, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.DateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Rpt1Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt1Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt1Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt1Client, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt1Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.LocationStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.InspectionStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.InspectionStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.InspectionStatus, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.InspectionStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.SchedFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedFROM As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedFROM)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedFROM, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.SchedFROM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.SchedTO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedTO As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedTO)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedTO, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.SchedTO)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.NextInspYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NextInspYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCLocationListingFireRatingMetadata.ColumnNames.NextInspYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCLocationListingFireRatingMetadata.ColumnNames.NextInspYr, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.NextInspYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.TotalUS_TIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSTIV As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSTIV, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.TotalUSTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.TotalUS_PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSPD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSPD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSPD, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.TotalUSPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.TotalUS_BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSBI As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSBI)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSBI, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.TotalUSBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationListingFireRatingMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationListingFireRatingMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.SchedulingComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedulingComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedulingComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedulingComment, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.SchedulingComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.GSafeGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeGUID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.GSafeGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.GSafeGUID, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.GSafeGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.RecNum
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.RecNum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.RecNum, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.RecNum)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.RecCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.RecCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingFireRatingMetadata.ColumnNames.RecCount, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.RecCount)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingFireRating.AchievableScorePercentString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AchievableScorePercentString As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.AchievableScorePercentString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingFireRatingMetadata.ColumnNames.AchievableScorePercentString, value) Then
					OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.AchievableScorePercentString)
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
												
						Case "Field1"
							Me.str().Field1 = CType(value, string)
												
						Case "Ownership"
							Me.str().Ownership = CType(value, string)
												
						Case "IRINo"
							Me.str().IRINo = CType(value, string)
												
						Case "AccountablePerson"
							Me.str().AccountablePerson = CType(value, string)
												
						Case "PlantID"
							Me.str().PlantID = CType(value, string)
												
						Case "PlantName"
							Me.str().PlantName = CType(value, string)
												
						Case "GRCEngineerFire"
							Me.str().GRCEngineerFire = CType(value, string)
												
						Case "GRCEngineerBM"
							Me.str().GRCEngineerBM = CType(value, string)
												
						Case "GRCTitle"
							Me.str().GRCTitle = CType(value, string)
												
						Case "ClientLocation"
							Me.str().ClientLocation = CType(value, string)
												
						Case "Locationname"
							Me.str().Locationname = CType(value, string)
												
						Case "Status"
							Me.str().Status = CType(value, string)
												
						Case "BusinessUnit"
							Me.str().BusinessUnit = CType(value, string)
												
						Case "FldEntity"
							Me.str().FldEntity = CType(value, string)
												
						Case "Occupancy"
							Me.str().Occupancy = CType(value, string)
												
						Case "Zone"
							Me.str().Zone = CType(value, string)
												
						Case "FldStructure"
							Me.str().FldStructure = CType(value, string)
												
						Case "Equipment"
							Me.str().Equipment = CType(value, string)
												
						Case "Inventory"
							Me.str().Inventory = CType(value, string)
												
						Case "Pd"
							Me.str().Pd = CType(value, string)
												
						Case "Bi"
							Me.str().Bi = CType(value, string)
												
						Case "Tiv"
							Me.str().Tiv = CType(value, string)
												
						Case "FireFreq"
							Me.str().FireFreq = CType(value, string)
												
						Case "Fire2000"
							Me.str().Fire2000 = CType(value, string)
												
						Case "Fire2001"
							Me.str().Fire2001 = CType(value, string)
												
						Case "Fire2002"
							Me.str().Fire2002 = CType(value, string)
												
						Case "Fire2003"
							Me.str().Fire2003 = CType(value, string)
												
						Case "Fire2004"
							Me.str().Fire2004 = CType(value, string)
												
						Case "Fire2005"
							Me.str().Fire2005 = CType(value, string)
												
						Case "FireTargetMonth"
							Me.str().FireTargetMonth = CType(value, string)
												
						Case "FireLastInspectionReport"
							Me.str().FireLastInspectionReport = CType(value, string)
												
						Case "FireLastInspectionDate"
							Me.str().FireLastInspectionDate = CType(value, string)
												
						Case "FireScheduledDate"
							Me.str().FireScheduledDate = CType(value, string)
												
						Case "FireActualDate"
							Me.str().FireActualDate = CType(value, string)
												
						Case "ToFireReport"
							Me.str().ToFireReport = CType(value, string)
												
						Case "ToFireReport2"
							Me.str().ToFireReport2 = CType(value, string)
												
						Case "ToFireDiagram"
							Me.str().ToFireDiagram = CType(value, string)
												
						Case "ToBPVReport"
							Me.str().ToBPVReport = CType(value, string)
												
						Case "FireEmailedDate"
							Me.str().FireEmailedDate = CType(value, string)
												
						Case "FireInspectionCount"
							Me.str().FireInspectionCount = CType(value, string)
												
						Case "SpecialReport"
							Me.str().SpecialReport = CType(value, string)
												
						Case "PlanReview"
							Me.str().PlanReview = CType(value, string)
												
						Case "FireRecResponseRecevied"
							Me.str().FireRecResponseRecevied = CType(value, string)
												
						Case "FireAQEDateRecevied"
							Me.str().FireAQEDateRecevied = CType(value, string)
												
						Case "FireAQERating"
							Me.str().FireAQERating = CType(value, string)
												
						Case "BMFreq"
							Me.str().BMFreq = CType(value, string)
												
						Case "Bm2000"
							Me.str().Bm2000 = CType(value, string)
												
						Case "Bm2001"
							Me.str().Bm2001 = CType(value, string)
												
						Case "Bm2002"
							Me.str().Bm2002 = CType(value, string)
												
						Case "Bm2003"
							Me.str().Bm2003 = CType(value, string)
												
						Case "Bm2004"
							Me.str().Bm2004 = CType(value, string)
												
						Case "Bm2005"
							Me.str().Bm2005 = CType(value, string)
												
						Case "BMTarget"
							Me.str().BMTarget = CType(value, string)
												
						Case "EngineerRequired"
							Me.str().EngineerRequired = CType(value, string)
												
						Case "BMLastInspectionReport"
							Me.str().BMLastInspectionReport = CType(value, string)
												
						Case "BMLastInspectionDate"
							Me.str().BMLastInspectionDate = CType(value, string)
												
						Case "ToBMDiagram"
							Me.str().ToBMDiagram = CType(value, string)
												
						Case "BMScheduledDate"
							Me.str().BMScheduledDate = CType(value, string)
												
						Case "BMActualDate"
							Me.str().BMActualDate = CType(value, string)
												
						Case "BMEmailedDate"
							Me.str().BMEmailedDate = CType(value, string)
												
						Case "ToBMReport"
							Me.str().ToBMReport = CType(value, string)
												
						Case "BMRecResponseReceived"
							Me.str().BMRecResponseReceived = CType(value, string)
												
						Case "BMAQEDateRecevied"
							Me.str().BMAQEDateRecevied = CType(value, string)
												
						Case "BMAQERating"
							Me.str().BMAQERating = CType(value, string)
												
						Case "BMInspectionCount"
							Me.str().BMInspectionCount = CType(value, string)
												
						Case "LocationManager"
							Me.str().LocationManager = CType(value, string)
												
						Case "LocationPhone"
							Me.str().LocationPhone = CType(value, string)
												
						Case "LocationFax"
							Me.str().LocationFax = CType(value, string)
												
						Case "LocationEmail"
							Me.str().LocationEmail = CType(value, string)
												
						Case "ARISELastInspection"
							Me.str().ARISELastInspection = CType(value, string)
												
						Case "ARISEInspectionLetter"
							Me.str().ARISEInspectionLetter = CType(value, string)
												
						Case "ARISELocationManager"
							Me.str().ARISELocationManager = CType(value, string)
												
						Case "FireComments"
							Me.str().FireComments = CType(value, string)
												
						Case "BMComments"
							Me.str().BMComments = CType(value, string)
												
						Case "BPVComments"
							Me.str().BPVComments = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
												
						Case "ResponseDate"
							Me.str().ResponseDate = CType(value, string)
												
						Case "FldAPLPD"
							Me.str().FldAPLPD = CType(value, string)
												
						Case "FldAPLBI"
							Me.str().FldAPLBI = CType(value, string)
												
						Case "FldAPLTotal"
							Me.str().FldAPLTotal = CType(value, string)
												
						Case "FldPMLPD"
							Me.str().FldPMLPD = CType(value, string)
												
						Case "FldPMLBI"
							Me.str().FldPMLBI = CType(value, string)
												
						Case "FldPMLTotal"
							Me.str().FldPMLTotal = CType(value, string)
												
						Case "FldMFLPD"
							Me.str().FldMFLPD = CType(value, string)
												
						Case "FldMFLBI"
							Me.str().FldMFLBI = CType(value, string)
												
						Case "FldMFLTotal"
							Me.str().FldMFLTotal = CType(value, string)
												
						Case "FireUpdate"
							Me.str().FireUpdate = CType(value, string)
												
						Case "BMUpdate"
							Me.str().BMUpdate = CType(value, string)
												
						Case "SquareFootage"
							Me.str().SquareFootage = CType(value, string)
												
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
												
						Case "BusinessContinuationPlan"
							Me.str().BusinessContinuationPlan = CType(value, string)
												
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
												
						Case "AchievableScorePercentString"
							Me.str().AchievableScorePercentString = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "Rpt2Revwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Revwr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt2Revwr)
							End If
						
						Case "Rpt2Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt2Client)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Longitude)
							End If
						
						Case "ClientLocation"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ClientLocation = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ClientLocation)
							End If
						
						Case "Zone"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Zone = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Zone)
							End If
						
						Case "FldStructure"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldStructure = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldStructure)
							End If
						
						Case "Equipment"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Equipment = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Equipment)
							End If
						
						Case "Inventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Inventory = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Inventory)
							End If
						
						Case "Pd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Pd = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Pd)
							End If
						
						Case "Bi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bi = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bi)
							End If
						
						Case "Tiv"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Tiv = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Tiv)
							End If
						
						Case "Fire2000"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2000 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2000)
							End If
						
						Case "Fire2001"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2001 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2001)
							End If
						
						Case "Fire2002"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2002 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2002)
							End If
						
						Case "Fire2003"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2003 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2003)
							End If
						
						Case "Fire2004"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2004 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2004)
							End If
						
						Case "Fire2005"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2005 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2005)
							End If
						
						Case "FireTargetMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FireTargetMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireTargetMonth)
							End If
						
						Case "FireLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireLastInspectionDate)
							End If
						
						Case "FireScheduledDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireScheduledDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireScheduledDate)
							End If
						
						Case "FireActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireActualDate)
							End If
						
						Case "FireEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireEmailedDate)
							End If
						
						Case "Bm2000"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2000 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2000)
							End If
						
						Case "Bm2001"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2001 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2001)
							End If
						
						Case "Bm2002"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2002 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2002)
							End If
						
						Case "Bm2003"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2003 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2003)
							End If
						
						Case "Bm2004"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2004 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2004)
							End If
						
						Case "Bm2005"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2005 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2005)
							End If
						
						Case "BMTarget"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BMTarget = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMTarget)
							End If
						
						Case "BMLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BMLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMLastInspectionDate)
							End If
						
						Case "BMScheduledDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BMScheduledDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMScheduledDate)
							End If
						
						Case "BMActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BMActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMActualDate)
							End If
						
						Case "BMEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BMEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMEmailedDate)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "FldAPLPD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldAPLPD = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLPD)
							End If
						
						Case "FldAPLBI"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldAPLBI = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLBI)
							End If
						
						Case "FldAPLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldAPLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLTotal)
							End If
						
						Case "FldPMLPD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldPMLPD = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLPD)
							End If
						
						Case "FldPMLBI"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldPMLBI = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLBI)
							End If
						
						Case "FldPMLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldPMLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLTotal)
							End If
						
						Case "FldMFLPD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldMFLPD = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLPD)
							End If
						
						Case "FldMFLBI"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldMFLBI = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLBI)
							End If
						
						Case "FldMFLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldMFLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLTotal)
							End If
						
						Case "FireUpdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FireUpdate = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.FireUpdate)
							End If
						
						Case "BMUpdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.BMUpdate = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BMUpdate)
							End If
						
						Case "SquareFootage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SquareFootage = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.SquareFootage)
							End If
						
						Case "BusinessContinuationPlan"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.BusinessContinuationPlan = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.BusinessContinuationPlan)
							End If
						
						Case "DateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.DateCompleted)
							End If
						
						Case "Rpt1Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt1Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt1Client)
							End If
						
						Case "SchedFROM"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedFROM = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.SchedFROM)
							End If
						
						Case "SchedTO"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedTO = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.SchedTO)
							End If
						
						Case "NextInspYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NextInspYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.NextInspYr)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "RecNum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNum = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.RecNum)
							End If
						
						Case "RecCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingFireRatingMetadata.PropertyNames.RecCount)
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
		
			Public Sub New(ByVal entity As esViewCCLocationListingFireRating)
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
		  	
			Public Property Field1 As System.String 
				Get
					Dim data_ As System.String = entity.Field1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Field1 = Nothing
					Else
						entity.Field1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ownership As System.String 
				Get
					Dim data_ As System.String = entity.Ownership
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ownership = Nothing
					Else
						entity.Ownership = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRINo As System.String 
				Get
					Dim data_ As System.String = entity.IRINo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRINo = Nothing
					Else
						entity.IRINo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AccountablePerson As System.String 
				Get
					Dim data_ As System.String = entity.AccountablePerson
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AccountablePerson = Nothing
					Else
						entity.AccountablePerson = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlantID As System.String 
				Get
					Dim data_ As System.String = entity.PlantID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantID = Nothing
					Else
						entity.PlantID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlantName As System.String 
				Get
					Dim data_ As System.String = entity.PlantName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantName = Nothing
					Else
						entity.PlantName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GRCEngineerFire As System.String 
				Get
					Dim data_ As System.String = entity.GRCEngineerFire
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GRCEngineerFire = Nothing
					Else
						entity.GRCEngineerFire = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GRCEngineerBM As System.String 
				Get
					Dim data_ As System.String = entity.GRCEngineerBM
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GRCEngineerBM = Nothing
					Else
						entity.GRCEngineerBM = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GRCTitle As System.String 
				Get
					Dim data_ As System.String = entity.GRCTitle
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GRCTitle = Nothing
					Else
						entity.GRCTitle = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ClientLocation As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ClientLocation
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClientLocation = Nothing
					Else
						entity.ClientLocation = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Locationname As System.String 
				Get
					Dim data_ As System.String = entity.Locationname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Locationname = Nothing
					Else
						entity.Locationname = Convert.ToString(Value)
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
		  	
			Public Property BusinessUnit As System.String 
				Get
					Dim data_ As System.String = entity.BusinessUnit
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessUnit = Nothing
					Else
						entity.BusinessUnit = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldEntity As System.String 
				Get
					Dim data_ As System.String = entity.FldEntity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldEntity = Nothing
					Else
						entity.FldEntity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occupancy As System.String 
				Get
					Dim data_ As System.String = entity.Occupancy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occupancy = Nothing
					Else
						entity.Occupancy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Zone As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Zone
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Zone = Nothing
					Else
						entity.Zone = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldStructure As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldStructure
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldStructure = Nothing
					Else
						entity.FldStructure = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Equipment As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Equipment
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Equipment = Nothing
					Else
						entity.Equipment = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventory As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Inventory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventory = Nothing
					Else
						entity.Inventory = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Pd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pd = Nothing
					Else
						entity.Pd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bi As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Bi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bi = Nothing
					Else
						entity.Bi = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Tiv As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Tiv
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Tiv = Nothing
					Else
						entity.Tiv = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireFreq As System.String 
				Get
					Dim data_ As System.String = entity.FireFreq
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireFreq = Nothing
					Else
						entity.FireFreq = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire2000 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire2000
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire2000 = Nothing
					Else
						entity.Fire2000 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire2001 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire2001
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire2001 = Nothing
					Else
						entity.Fire2001 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire2002 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire2002
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire2002 = Nothing
					Else
						entity.Fire2002 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire2003 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire2003
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire2003 = Nothing
					Else
						entity.Fire2003 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire2004 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire2004
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire2004 = Nothing
					Else
						entity.Fire2004 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire2005 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire2005
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire2005 = Nothing
					Else
						entity.Fire2005 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireTargetMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FireTargetMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireTargetMonth = Nothing
					Else
						entity.FireTargetMonth = Convert.ToInt32(Value)
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
		  	
			Public Property FireScheduledDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.FireScheduledDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireScheduledDate = Nothing
					Else
						entity.FireScheduledDate = Convert.ToDateTime(Value)
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
		  	
			Public Property ToBPVReport As System.String 
				Get
					Dim data_ As System.String = entity.ToBPVReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToBPVReport = Nothing
					Else
						entity.ToBPVReport = Convert.ToString(Value)
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
		  	
			Public Property FireInspectionCount As System.String 
				Get
					Dim data_ As System.String = entity.FireInspectionCount
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireInspectionCount = Nothing
					Else
						entity.FireInspectionCount = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecialReport As System.String 
				Get
					Dim data_ As System.String = entity.SpecialReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecialReport = Nothing
					Else
						entity.SpecialReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlanReview As System.String 
				Get
					Dim data_ As System.String = entity.PlanReview
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlanReview = Nothing
					Else
						entity.PlanReview = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireRecResponseRecevied As System.String 
				Get
					Dim data_ As System.String = entity.FireRecResponseRecevied
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireRecResponseRecevied = Nothing
					Else
						entity.FireRecResponseRecevied = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireAQEDateRecevied As System.String 
				Get
					Dim data_ As System.String = entity.FireAQEDateRecevied
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireAQEDateRecevied = Nothing
					Else
						entity.FireAQEDateRecevied = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireAQERating As System.String 
				Get
					Dim data_ As System.String = entity.FireAQERating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireAQERating = Nothing
					Else
						entity.FireAQERating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMFreq As System.String 
				Get
					Dim data_ As System.String = entity.BMFreq
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMFreq = Nothing
					Else
						entity.BMFreq = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm2000 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bm2000
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm2000 = Nothing
					Else
						entity.Bm2000 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm2001 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bm2001
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm2001 = Nothing
					Else
						entity.Bm2001 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm2002 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bm2002
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm2002 = Nothing
					Else
						entity.Bm2002 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm2003 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bm2003
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm2003 = Nothing
					Else
						entity.Bm2003 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm2004 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bm2004
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm2004 = Nothing
					Else
						entity.Bm2004 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm2005 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bm2005
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm2005 = Nothing
					Else
						entity.Bm2005 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMTarget As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BMTarget
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMTarget = Nothing
					Else
						entity.BMTarget = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EngineerRequired As System.String 
				Get
					Dim data_ As System.String = entity.EngineerRequired
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EngineerRequired = Nothing
					Else
						entity.EngineerRequired = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.BMLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMLastInspectionReport = Nothing
					Else
						entity.BMLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.BMLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMLastInspectionDate = Nothing
					Else
						entity.BMLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToBMDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToBMDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToBMDiagram = Nothing
					Else
						entity.ToBMDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMScheduledDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.BMScheduledDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMScheduledDate = Nothing
					Else
						entity.BMScheduledDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.BMActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMActualDate = Nothing
					Else
						entity.BMActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.BMEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMEmailedDate = Nothing
					Else
						entity.BMEmailedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToBMReport As System.String 
				Get
					Dim data_ As System.String = entity.ToBMReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToBMReport = Nothing
					Else
						entity.ToBMReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMRecResponseReceived As System.String 
				Get
					Dim data_ As System.String = entity.BMRecResponseReceived
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMRecResponseReceived = Nothing
					Else
						entity.BMRecResponseReceived = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMAQEDateRecevied As System.String 
				Get
					Dim data_ As System.String = entity.BMAQEDateRecevied
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMAQEDateRecevied = Nothing
					Else
						entity.BMAQEDateRecevied = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMAQERating As System.String 
				Get
					Dim data_ As System.String = entity.BMAQERating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMAQERating = Nothing
					Else
						entity.BMAQERating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMInspectionCount As System.String 
				Get
					Dim data_ As System.String = entity.BMInspectionCount
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMInspectionCount = Nothing
					Else
						entity.BMInspectionCount = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationManager As System.String 
				Get
					Dim data_ As System.String = entity.LocationManager
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationManager = Nothing
					Else
						entity.LocationManager = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationPhone As System.String 
				Get
					Dim data_ As System.String = entity.LocationPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationPhone = Nothing
					Else
						entity.LocationPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationFax As System.String 
				Get
					Dim data_ As System.String = entity.LocationFax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationFax = Nothing
					Else
						entity.LocationFax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationEmail As System.String 
				Get
					Dim data_ As System.String = entity.LocationEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationEmail = Nothing
					Else
						entity.LocationEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ARISELastInspection As System.String 
				Get
					Dim data_ As System.String = entity.ARISELastInspection
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ARISELastInspection = Nothing
					Else
						entity.ARISELastInspection = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ARISEInspectionLetter As System.String 
				Get
					Dim data_ As System.String = entity.ARISEInspectionLetter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ARISEInspectionLetter = Nothing
					Else
						entity.ARISEInspectionLetter = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ARISELocationManager As System.String 
				Get
					Dim data_ As System.String = entity.ARISELocationManager
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ARISELocationManager = Nothing
					Else
						entity.ARISELocationManager = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireComments As System.String 
				Get
					Dim data_ As System.String = entity.FireComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireComments = Nothing
					Else
						entity.FireComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMComments As System.String 
				Get
					Dim data_ As System.String = entity.BMComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMComments = Nothing
					Else
						entity.BMComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BPVComments As System.String 
				Get
					Dim data_ As System.String = entity.BPVComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BPVComments = Nothing
					Else
						entity.BPVComments = Convert.ToString(Value)
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
		  	
			Public Property FldAPLPD As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldAPLPD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldAPLPD = Nothing
					Else
						entity.FldAPLPD = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldAPLBI As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldAPLBI
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldAPLBI = Nothing
					Else
						entity.FldAPLBI = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldAPLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldAPLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldAPLTotal = Nothing
					Else
						entity.FldAPLTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldPMLPD As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldPMLPD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldPMLPD = Nothing
					Else
						entity.FldPMLPD = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldPMLBI As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldPMLBI
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldPMLBI = Nothing
					Else
						entity.FldPMLBI = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldPMLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldPMLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldPMLTotal = Nothing
					Else
						entity.FldPMLTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldMFLPD As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldMFLPD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldMFLPD = Nothing
					Else
						entity.FldMFLPD = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldMFLBI As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldMFLBI
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldMFLBI = Nothing
					Else
						entity.FldMFLBI = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldMFLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldMFLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldMFLTotal = Nothing
					Else
						entity.FldMFLTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireUpdate As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FireUpdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireUpdate = Nothing
					Else
						entity.FireUpdate = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMUpdate As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.BMUpdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMUpdate = Nothing
					Else
						entity.BMUpdate = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SquareFootage As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SquareFootage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SquareFootage = Nothing
					Else
						entity.SquareFootage = Convert.ToInt32(Value)
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
		  	
			Public Property BusinessContinuationPlan As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.BusinessContinuationPlan
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessContinuationPlan = Nothing
					Else
						entity.BusinessContinuationPlan = Convert.ToBoolean(Value)
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
		  	
			Public Property AchievableScorePercentString As System.String 
				Get
					Dim data_ As System.String = entity.AchievableScorePercentString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AchievableScorePercentString = Nothing
					Else
						entity.AchievableScorePercentString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCLocationListingFireRating
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingFireRatingMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationListingFireRatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingFireRatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationListingFireRatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationListingFireRatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationListingFireRatingQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingFireRatingCollection
		Inherits esEntityCollection(Of ViewCCLocationListingFireRating)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingFireRatingMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationListingFireRatingCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationListingFireRatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingFireRatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationListingFireRatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationListingFireRatingQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationListingFireRatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationListingFireRatingQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationListingFireRatingQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationListingFireRatingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingFireRatingMetadata.Meta()
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
				Case "Field1" 
					Return Me.Field1
				Case "Ownership" 
					Return Me.Ownership
				Case "IRINo" 
					Return Me.IRINo
				Case "AccountablePerson" 
					Return Me.AccountablePerson
				Case "PlantID" 
					Return Me.PlantID
				Case "PlantName" 
					Return Me.PlantName
				Case "GRCEngineerFire" 
					Return Me.GRCEngineerFire
				Case "GRCEngineerBM" 
					Return Me.GRCEngineerBM
				Case "GRCTitle" 
					Return Me.GRCTitle
				Case "ClientLocation" 
					Return Me.ClientLocation
				Case "Locationname" 
					Return Me.Locationname
				Case "Status" 
					Return Me.Status
				Case "BusinessUnit" 
					Return Me.BusinessUnit
				Case "FldEntity" 
					Return Me.FldEntity
				Case "Occupancy" 
					Return Me.Occupancy
				Case "Zone" 
					Return Me.Zone
				Case "FldStructure" 
					Return Me.FldStructure
				Case "Equipment" 
					Return Me.Equipment
				Case "Inventory" 
					Return Me.Inventory
				Case "Pd" 
					Return Me.Pd
				Case "Bi" 
					Return Me.Bi
				Case "Tiv" 
					Return Me.Tiv
				Case "FireFreq" 
					Return Me.FireFreq
				Case "Fire2000" 
					Return Me.Fire2000
				Case "Fire2001" 
					Return Me.Fire2001
				Case "Fire2002" 
					Return Me.Fire2002
				Case "Fire2003" 
					Return Me.Fire2003
				Case "Fire2004" 
					Return Me.Fire2004
				Case "Fire2005" 
					Return Me.Fire2005
				Case "FireTargetMonth" 
					Return Me.FireTargetMonth
				Case "FireLastInspectionReport" 
					Return Me.FireLastInspectionReport
				Case "FireLastInspectionDate" 
					Return Me.FireLastInspectionDate
				Case "FireScheduledDate" 
					Return Me.FireScheduledDate
				Case "FireActualDate" 
					Return Me.FireActualDate
				Case "ToFireReport" 
					Return Me.ToFireReport
				Case "ToFireReport2" 
					Return Me.ToFireReport2
				Case "ToFireDiagram" 
					Return Me.ToFireDiagram
				Case "ToBPVReport" 
					Return Me.ToBPVReport
				Case "FireEmailedDate" 
					Return Me.FireEmailedDate
				Case "FireInspectionCount" 
					Return Me.FireInspectionCount
				Case "SpecialReport" 
					Return Me.SpecialReport
				Case "PlanReview" 
					Return Me.PlanReview
				Case "FireRecResponseRecevied" 
					Return Me.FireRecResponseRecevied
				Case "FireAQEDateRecevied" 
					Return Me.FireAQEDateRecevied
				Case "FireAQERating" 
					Return Me.FireAQERating
				Case "BMFreq" 
					Return Me.BMFreq
				Case "Bm2000" 
					Return Me.Bm2000
				Case "Bm2001" 
					Return Me.Bm2001
				Case "Bm2002" 
					Return Me.Bm2002
				Case "Bm2003" 
					Return Me.Bm2003
				Case "Bm2004" 
					Return Me.Bm2004
				Case "Bm2005" 
					Return Me.Bm2005
				Case "BMTarget" 
					Return Me.BMTarget
				Case "EngineerRequired" 
					Return Me.EngineerRequired
				Case "BMLastInspectionReport" 
					Return Me.BMLastInspectionReport
				Case "BMLastInspectionDate" 
					Return Me.BMLastInspectionDate
				Case "ToBMDiagram" 
					Return Me.ToBMDiagram
				Case "BMScheduledDate" 
					Return Me.BMScheduledDate
				Case "BMActualDate" 
					Return Me.BMActualDate
				Case "BMEmailedDate" 
					Return Me.BMEmailedDate
				Case "ToBMReport" 
					Return Me.ToBMReport
				Case "BMRecResponseReceived" 
					Return Me.BMRecResponseReceived
				Case "BMAQEDateRecevied" 
					Return Me.BMAQEDateRecevied
				Case "BMAQERating" 
					Return Me.BMAQERating
				Case "BMInspectionCount" 
					Return Me.BMInspectionCount
				Case "LocationManager" 
					Return Me.LocationManager
				Case "LocationPhone" 
					Return Me.LocationPhone
				Case "LocationFax" 
					Return Me.LocationFax
				Case "LocationEmail" 
					Return Me.LocationEmail
				Case "ARISELastInspection" 
					Return Me.ARISELastInspection
				Case "ARISEInspectionLetter" 
					Return Me.ARISEInspectionLetter
				Case "ARISELocationManager" 
					Return Me.ARISELocationManager
				Case "FireComments" 
					Return Me.FireComments
				Case "BMComments" 
					Return Me.BMComments
				Case "BPVComments" 
					Return Me.BPVComments
				Case "Comments" 
					Return Me.Comments
				Case "ResponseDate" 
					Return Me.ResponseDate
				Case "FldAPLPD" 
					Return Me.FldAPLPD
				Case "FldAPLBI" 
					Return Me.FldAPLBI
				Case "FldAPLTotal" 
					Return Me.FldAPLTotal
				Case "FldPMLPD" 
					Return Me.FldPMLPD
				Case "FldPMLBI" 
					Return Me.FldPMLBI
				Case "FldPMLTotal" 
					Return Me.FldPMLTotal
				Case "FldMFLPD" 
					Return Me.FldMFLPD
				Case "FldMFLBI" 
					Return Me.FldMFLBI
				Case "FldMFLTotal" 
					Return Me.FldMFLTotal
				Case "FireUpdate" 
					Return Me.FireUpdate
				Case "BMUpdate" 
					Return Me.BMUpdate
				Case "SquareFootage" 
					Return Me.SquareFootage
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
				Case "BusinessContinuationPlan" 
					Return Me.BusinessContinuationPlan
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
				Case "AchievableScorePercentString" 
					Return Me.AchievableScorePercentString
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Report2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Report2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Revwr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt2Revwr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt2Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Region As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Region, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ServicedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ServicedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocalTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.LocalTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Field1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Field1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ownership As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Ownership, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IRINo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.IRINo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AccountablePerson As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.AccountablePerson, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.PlantID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.PlantName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCEngineerFire As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCEngineerFire, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCEngineerBM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCEngineerBM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCTitle As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCTitle, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ClientLocation, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Locationname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Locationname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessUnit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BusinessUnit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FldEntity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldEntity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occupancy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Occupancy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Zone, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldStructure As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldStructure, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Equipment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Equipment, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Inventory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Inventory, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Pd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bi As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Bi, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Tiv As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Tiv, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FireFreq As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireFreq, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2000 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2000, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2001 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2001, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2002 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2002, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2003 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2003, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2004 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2004, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2005 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2005, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FireTargetMonth As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireTargetMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FireLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FireScheduledDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireScheduledDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FireActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToBPVReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBPVReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FireInspectionCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireInspectionCount, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecialReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.SpecialReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlanReview As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.PlanReview, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireRecResponseRecevied As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireRecResponseRecevied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireAQEDateRecevied As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireAQEDateRecevied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireAQERating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireAQERating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMFreq As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMFreq, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2000 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2000, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2001 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2001, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2002 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2002, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2003 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2003, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2004 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2004, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2005 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2005, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BMTarget As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMTarget, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EngineerRequired As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.EngineerRequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToBMDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBMDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMScheduledDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMScheduledDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property BMActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property BMEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToBMReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBMReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMRecResponseReceived As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMRecResponseReceived, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMAQEDateRecevied As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMAQEDateRecevied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMAQERating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMAQERating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMInspectionCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMInspectionCount, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationManager As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationManager, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationFax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationFax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ARISELastInspection As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISELastInspection, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ARISEInspectionLetter As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISEInspectionLetter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ARISELocationManager As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISELocationManager, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireComments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMComments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BPVComments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BPVComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FldAPLPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLPD, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldAPLBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLBI, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldAPLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldPMLPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLPD, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldPMLBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLBI, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldPMLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldMFLPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLPD, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldMFLBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLBI, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FldMFLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FireUpdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.FireUpdate, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property BMUpdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BMUpdate, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SquareFootage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.SquareFootage, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Frequency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Frequency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Address2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Phone1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.InspNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessContinuationPlan As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.BusinessContinuationPlan, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property DateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.DateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt1Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt1Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LocationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.InspectionStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedFROM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedFROM, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SchedTO As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedTO, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NextInspYr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.NextInspYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSPD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSBI, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property SchedulingComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedulingComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GSafeGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.GSafeGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.RecNum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.RecCount, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property AchievableScorePercentString As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingFireRatingMetadata.ColumnNames.AchievableScorePercentString, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationListingFireRatingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Client, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.PracticeCode, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Facility, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FileNo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Report2, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Report2
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt2Revwr, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt2Revwr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt2Client, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt2Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Region, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Region
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ServicedBy, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ServicedBy
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocalTIV, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.LocalTIV
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Division, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Latitude, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Longitude, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Field1, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Field1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Ownership, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Ownership
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.IRINo, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.IRINo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.AccountablePerson, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.AccountablePerson
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlantID, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.PlantID
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlantName, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.PlantName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCEngineerFire, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.GRCEngineerFire
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCEngineerBM, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.GRCEngineerBM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.GRCTitle, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.GRCTitle
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ClientLocation, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ClientLocation
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Locationname, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Locationname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Status, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Status
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BusinessUnit, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BusinessUnit
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldEntity, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldEntity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Occupancy, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Occupancy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Zone, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Zone
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldStructure, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldStructure
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Equipment, 31, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Equipment
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Inventory, 32, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Inventory
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Pd, 33, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Pd
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bi, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Bi
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Tiv, 35, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Tiv
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireFreq, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireFreq
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2000, 37, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2000
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2001, 38, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2001
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2002, 39, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2002
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2003, 40, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2003
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2004, 41, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2004
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fire2005, 42, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Fire2005
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireTargetMonth, 43, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireTargetMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireLastInspectionReport, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireLastInspectionDate, 45, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireScheduledDate, 46, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireScheduledDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireActualDate, 47, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireReport, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ToFireReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireReport2, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ToFireReport2
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToFireDiagram, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ToFireDiagram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBPVReport, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ToBPVReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireEmailedDate, 52, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireInspectionCount, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireInspectionCount
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.SpecialReport, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.SpecialReport
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.PlanReview, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.PlanReview
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireRecResponseRecevied, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireRecResponseRecevied
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireAQEDateRecevied, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireAQEDateRecevied
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireAQERating, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireAQERating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMFreq, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMFreq
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2000, 60, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2000
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2001, 61, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2001
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2002, 62, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2002
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2003, 63, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2003
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2004, 64, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2004
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Bm2005, 65, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Bm2005
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMTarget, 66, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMTarget
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.EngineerRequired, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.EngineerRequired
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMLastInspectionReport, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMLastInspectionDate, 69, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBMDiagram, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ToBMDiagram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMScheduledDate, 71, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMScheduledDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMActualDate, 72, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMEmailedDate, 73, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ToBMReport, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ToBMReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMRecResponseReceived, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMRecResponseReceived
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMAQEDateRecevied, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMAQEDateRecevied
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMAQERating, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMAQERating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMInspectionCount, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMInspectionCount
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationManager, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationManager
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationPhone, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationFax, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationFax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationEmail, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationEmail
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISELastInspection, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ARISELastInspection
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISEInspectionLetter, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ARISEInspectionLetter
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ARISELocationManager, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ARISELocationManager
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireComments, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMComments, 87, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMComments
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BPVComments, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BPVComments
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Comments, 89, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.ResponseDate, 90, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLPD, 91, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLPD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLBI, 92, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLBI
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldAPLTotal, 93, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldAPLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLPD, 94, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLPD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLBI, 95, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLBI
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldPMLTotal, 96, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldPMLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLPD, 97, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLPD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLBI, 98, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLBI
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FldMFLTotal, 99, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FldMFLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.FireUpdate, 100, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.FireUpdate
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BMUpdate, 101, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BMUpdate
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.SquareFootage, 102, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.SquareFootage
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Frequency, 103, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Frequency
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Address1, 104, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Address2, 105, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Address2
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.City, 106, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.StProv, 107, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Zip, 108, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Country, 109, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Phone1, 110, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Phone1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Fax, 111, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Fax
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.InspNotes, 112, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.InspNotes
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.BusinessContinuationPlan, 113, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.BusinessContinuationPlan
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.DateCompleted, 114, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.DateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Rpt1Client, 115, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Rpt1Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.LocationStatus, 116, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.LocationStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.InspectionStatus, 117, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.InspectionStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.Engineer, 118, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedFROM, 119, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.SchedFROM
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedTO, 120, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.SchedTO
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.NextInspYr, 121, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.NextInspYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSTIV, 122, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.TotalUSTIV
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSPD, 123, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.TotalUSPD
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.TotalUSBI, 124, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.TotalUSBI
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames._100PercentUSTot, 125, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.SchedulingComment, 126, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.SchedulingComment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.CustomAccess, 127, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.GSafeGUID, 128, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.GSafeGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.RecNum, 129, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.RecNum
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.RecCount, 130, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.RecCount
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingFireRatingMetadata.ColumnNames.AchievableScorePercentString, 131, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingFireRatingMetadata.PropertyNames.AchievableScorePercentString
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationListingFireRatingMetadata
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
			 Public Const Field1 As String = "Field1"
			 Public Const Ownership As String = "Ownership"
			 Public Const IRINo As String = "IRINo"
			 Public Const AccountablePerson As String = "AccountablePerson"
			 Public Const PlantID As String = "PlantID"
			 Public Const PlantName As String = "PlantName"
			 Public Const GRCEngineerFire As String = "GRCEngineerFire"
			 Public Const GRCEngineerBM As String = "GRCEngineerBM"
			 Public Const GRCTitle As String = "GRCTitle"
			 Public Const ClientLocation As String = "ClientLocation"
			 Public Const Locationname As String = "LOCATIONNAME"
			 Public Const Status As String = "Status"
			 Public Const BusinessUnit As String = "BusinessUnit"
			 Public Const FldEntity As String = "fldEntity"
			 Public Const Occupancy As String = "OCCUPANCY"
			 Public Const Zone As String = "ZONE"
			 Public Const FldStructure As String = "fldStructure"
			 Public Const Equipment As String = "EQUIPMENT"
			 Public Const Inventory As String = "INVENTORY"
			 Public Const Pd As String = "PD"
			 Public Const Bi As String = "BI"
			 Public Const Tiv As String = "TIV"
			 Public Const FireFreq As String = "FireFreq"
			 Public Const Fire2000 As String = "Fire2000"
			 Public Const Fire2001 As String = "Fire2001"
			 Public Const Fire2002 As String = "Fire2002"
			 Public Const Fire2003 As String = "Fire2003"
			 Public Const Fire2004 As String = "Fire2004"
			 Public Const Fire2005 As String = "Fire2005"
			 Public Const FireTargetMonth As String = "FireTargetMonth"
			 Public Const FireLastInspectionReport As String = "FireLastInspectionReport"
			 Public Const FireLastInspectionDate As String = "FireLastInspectionDate"
			 Public Const FireScheduledDate As String = "FireScheduledDate"
			 Public Const FireActualDate As String = "FireActualDate"
			 Public Const ToFireReport As String = "ToFireReport"
			 Public Const ToFireReport2 As String = "ToFireReport2"
			 Public Const ToFireDiagram As String = "ToFireDiagram"
			 Public Const ToBPVReport As String = "ToBPVReport"
			 Public Const FireEmailedDate As String = "FireEmailedDate"
			 Public Const FireInspectionCount As String = "FireInspectionCount"
			 Public Const SpecialReport As String = "SpecialReport"
			 Public Const PlanReview As String = "PlanReview"
			 Public Const FireRecResponseRecevied As String = "FireRecResponseRecevied"
			 Public Const FireAQEDateRecevied As String = "FireAQEDateRecevied"
			 Public Const FireAQERating As String = "FireAQERating"
			 Public Const BMFreq As String = "BMFreq"
			 Public Const Bm2000 As String = "BM2000"
			 Public Const Bm2001 As String = "BM2001"
			 Public Const Bm2002 As String = "BM2002"
			 Public Const Bm2003 As String = "BM2003"
			 Public Const Bm2004 As String = "BM2004"
			 Public Const Bm2005 As String = "BM2005"
			 Public Const BMTarget As String = "BMTarget"
			 Public Const EngineerRequired As String = "EngineerRequired"
			 Public Const BMLastInspectionReport As String = "BMLastInspectionReport"
			 Public Const BMLastInspectionDate As String = "BMLastInspectionDate"
			 Public Const ToBMDiagram As String = "ToBMDiagram"
			 Public Const BMScheduledDate As String = "BMScheduledDate"
			 Public Const BMActualDate As String = "BMActualDate"
			 Public Const BMEmailedDate As String = "BMEmailedDate"
			 Public Const ToBMReport As String = "ToBMReport"
			 Public Const BMRecResponseReceived As String = "BMRecResponseReceived"
			 Public Const BMAQEDateRecevied As String = "BMAQEDateRecevied"
			 Public Const BMAQERating As String = "BMAQERating"
			 Public Const BMInspectionCount As String = "BMInspectionCount"
			 Public Const LocationManager As String = "LocationManager"
			 Public Const LocationPhone As String = "LocationPhone"
			 Public Const LocationFax As String = "LocationFax"
			 Public Const LocationEmail As String = "LocationEmail"
			 Public Const ARISELastInspection As String = "ARISELastInspection"
			 Public Const ARISEInspectionLetter As String = "ARISEInspectionLetter"
			 Public Const ARISELocationManager As String = "ARISELocationManager"
			 Public Const FireComments As String = "FireComments"
			 Public Const BMComments As String = "BMComments"
			 Public Const BPVComments As String = "BPVComments"
			 Public Const Comments As String = "Comments"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const FldAPLPD As String = "fldAPLPD"
			 Public Const FldAPLBI As String = "fldAPLBI"
			 Public Const FldAPLTotal As String = "fldAPLTotal"
			 Public Const FldPMLPD As String = "fldPMLPD"
			 Public Const FldPMLBI As String = "fldPMLBI"
			 Public Const FldPMLTotal As String = "fldPMLTotal"
			 Public Const FldMFLPD As String = "fldMFLPD"
			 Public Const FldMFLBI As String = "fldMFLBI"
			 Public Const FldMFLTotal As String = "fldMFLTotal"
			 Public Const FireUpdate As String = "FireUpdate"
			 Public Const BMUpdate As String = "BMUpdate"
			 Public Const SquareFootage As String = "SquareFootage"
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
			 Public Const BusinessContinuationPlan As String = "BusinessContinuationPlan"
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
			 Public Const AchievableScorePercentString As String = "AchievableScorePercentString"
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
			 Public Const Field1 As String = "Field1"
			 Public Const Ownership As String = "Ownership"
			 Public Const IRINo As String = "IRINo"
			 Public Const AccountablePerson As String = "AccountablePerson"
			 Public Const PlantID As String = "PlantID"
			 Public Const PlantName As String = "PlantName"
			 Public Const GRCEngineerFire As String = "GRCEngineerFire"
			 Public Const GRCEngineerBM As String = "GRCEngineerBM"
			 Public Const GRCTitle As String = "GRCTitle"
			 Public Const ClientLocation As String = "ClientLocation"
			 Public Const Locationname As String = "Locationname"
			 Public Const Status As String = "Status"
			 Public Const BusinessUnit As String = "BusinessUnit"
			 Public Const FldEntity As String = "FldEntity"
			 Public Const Occupancy As String = "Occupancy"
			 Public Const Zone As String = "Zone"
			 Public Const FldStructure As String = "FldStructure"
			 Public Const Equipment As String = "Equipment"
			 Public Const Inventory As String = "Inventory"
			 Public Const Pd As String = "Pd"
			 Public Const Bi As String = "Bi"
			 Public Const Tiv As String = "Tiv"
			 Public Const FireFreq As String = "FireFreq"
			 Public Const Fire2000 As String = "Fire2000"
			 Public Const Fire2001 As String = "Fire2001"
			 Public Const Fire2002 As String = "Fire2002"
			 Public Const Fire2003 As String = "Fire2003"
			 Public Const Fire2004 As String = "Fire2004"
			 Public Const Fire2005 As String = "Fire2005"
			 Public Const FireTargetMonth As String = "FireTargetMonth"
			 Public Const FireLastInspectionReport As String = "FireLastInspectionReport"
			 Public Const FireLastInspectionDate As String = "FireLastInspectionDate"
			 Public Const FireScheduledDate As String = "FireScheduledDate"
			 Public Const FireActualDate As String = "FireActualDate"
			 Public Const ToFireReport As String = "ToFireReport"
			 Public Const ToFireReport2 As String = "ToFireReport2"
			 Public Const ToFireDiagram As String = "ToFireDiagram"
			 Public Const ToBPVReport As String = "ToBPVReport"
			 Public Const FireEmailedDate As String = "FireEmailedDate"
			 Public Const FireInspectionCount As String = "FireInspectionCount"
			 Public Const SpecialReport As String = "SpecialReport"
			 Public Const PlanReview As String = "PlanReview"
			 Public Const FireRecResponseRecevied As String = "FireRecResponseRecevied"
			 Public Const FireAQEDateRecevied As String = "FireAQEDateRecevied"
			 Public Const FireAQERating As String = "FireAQERating"
			 Public Const BMFreq As String = "BMFreq"
			 Public Const Bm2000 As String = "Bm2000"
			 Public Const Bm2001 As String = "Bm2001"
			 Public Const Bm2002 As String = "Bm2002"
			 Public Const Bm2003 As String = "Bm2003"
			 Public Const Bm2004 As String = "Bm2004"
			 Public Const Bm2005 As String = "Bm2005"
			 Public Const BMTarget As String = "BMTarget"
			 Public Const EngineerRequired As String = "EngineerRequired"
			 Public Const BMLastInspectionReport As String = "BMLastInspectionReport"
			 Public Const BMLastInspectionDate As String = "BMLastInspectionDate"
			 Public Const ToBMDiagram As String = "ToBMDiagram"
			 Public Const BMScheduledDate As String = "BMScheduledDate"
			 Public Const BMActualDate As String = "BMActualDate"
			 Public Const BMEmailedDate As String = "BMEmailedDate"
			 Public Const ToBMReport As String = "ToBMReport"
			 Public Const BMRecResponseReceived As String = "BMRecResponseReceived"
			 Public Const BMAQEDateRecevied As String = "BMAQEDateRecevied"
			 Public Const BMAQERating As String = "BMAQERating"
			 Public Const BMInspectionCount As String = "BMInspectionCount"
			 Public Const LocationManager As String = "LocationManager"
			 Public Const LocationPhone As String = "LocationPhone"
			 Public Const LocationFax As String = "LocationFax"
			 Public Const LocationEmail As String = "LocationEmail"
			 Public Const ARISELastInspection As String = "ARISELastInspection"
			 Public Const ARISEInspectionLetter As String = "ARISEInspectionLetter"
			 Public Const ARISELocationManager As String = "ARISELocationManager"
			 Public Const FireComments As String = "FireComments"
			 Public Const BMComments As String = "BMComments"
			 Public Const BPVComments As String = "BPVComments"
			 Public Const Comments As String = "Comments"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const FldAPLPD As String = "FldAPLPD"
			 Public Const FldAPLBI As String = "FldAPLBI"
			 Public Const FldAPLTotal As String = "FldAPLTotal"
			 Public Const FldPMLPD As String = "FldPMLPD"
			 Public Const FldPMLBI As String = "FldPMLBI"
			 Public Const FldPMLTotal As String = "FldPMLTotal"
			 Public Const FldMFLPD As String = "FldMFLPD"
			 Public Const FldMFLBI As String = "FldMFLBI"
			 Public Const FldMFLTotal As String = "FldMFLTotal"
			 Public Const FireUpdate As String = "FireUpdate"
			 Public Const BMUpdate As String = "BMUpdate"
			 Public Const SquareFootage As String = "SquareFootage"
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
			 Public Const BusinessContinuationPlan As String = "BusinessContinuationPlan"
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
			 Public Const AchievableScorePercentString As String = "AchievableScorePercentString"
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
			SyncLock GetType(ViewCCLocationListingFireRatingMetadata)
			
				If ViewCCLocationListingFireRatingMetadata.mapDelegates Is Nothing Then
					ViewCCLocationListingFireRatingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationListingFireRatingMetadata._meta Is Nothing Then
					ViewCCLocationListingFireRatingMetadata._meta = New ViewCCLocationListingFireRatingMetadata()
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
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Report2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Rpt2Revwr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt2Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Region", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ServicedBy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocalTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Field1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ownership", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("IRINo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("AccountablePerson", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantID", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GRCEngineerFire", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GRCEngineerBM", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GRCTitle", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ClientLocation", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Locationname", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Status", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BusinessUnit", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FldEntity", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Occupancy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zone", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldStructure", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Equipment", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Inventory", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Pd", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Bi", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Tiv", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FireFreq", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fire2000", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire2001", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire2002", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire2003", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire2004", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire2005", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FireTargetMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FireLastInspectionReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireLastInspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("FireScheduledDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("FireActualDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ToFireReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToFireReport2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToFireDiagram", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToBPVReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireEmailedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("FireInspectionCount", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecialReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlanReview", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireRecResponseRecevied", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireAQEDateRecevied", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireAQERating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMFreq", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Bm2000", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bm2001", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bm2002", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bm2003", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bm2004", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bm2005", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BMTarget", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EngineerRequired", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMLastInspectionReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMLastInspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ToBMDiagram", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMScheduledDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("BMActualDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("BMEmailedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ToBMReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMRecResponseReceived", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMAQEDateRecevied", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMAQERating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMInspectionCount", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationManager", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationPhone", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationFax", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationEmail", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ARISELastInspection", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ARISEInspectionLetter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ARISELocationManager", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FireComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BMComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BPVComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Comments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ResponseDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("FldAPLPD", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldAPLBI", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldAPLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldPMLPD", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldPMLBI", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldPMLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldMFLPD", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldMFLBI", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FldMFLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FireUpdate", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("BMUpdate", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SquareFootage", new esTypeMap("int", "System.Int32"))
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
				meta.AddTypeMap("BusinessContinuationPlan", new esTypeMap("bit", "System.Boolean"))
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
				meta.AddTypeMap("AchievableScorePercentString", new esTypeMap("nvarchar", "System.String"))			
				
				meta.Schema = "dbo"
				 
				meta.Source = "viewCCLocationListingFireRating"
				meta.Destination = "viewCCLocationListingFireRating"
				
				meta.spInsert = "proc_viewCCLocationListingFireRatingInsert"
				meta.spUpdate = "proc_viewCCLocationListingFireRatingUpdate"
				meta.spDelete = "proc_viewCCLocationListingFireRatingDelete"
				meta.spLoadAll = "proc_viewCCLocationListingFireRatingLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationListingFireRatingLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationListingFireRatingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
