
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/30/2019 10:09:34 AM
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
	' Encapsulates the 'vwFireRatingBaseView' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwFireRatingBaseView))> _
	<XmlType("VwFireRatingBaseView")> _	
	Partial Public Class VwFireRatingBaseView 
		Inherits esVwFireRatingBaseView
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwFireRatingBaseView()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwFireRatingBaseViewCollection")> _
	Partial Public Class VwFireRatingBaseViewCollection
		Inherits esVwFireRatingBaseViewCollection
		Implements IEnumerable(Of VwFireRatingBaseView)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwFireRatingBaseView))> _
		Public Class VwFireRatingBaseViewCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwFireRatingBaseViewCollection)
			
			Public Shared Widening Operator CType(packet As VwFireRatingBaseViewCollectionWCFPacket) As VwFireRatingBaseViewCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwFireRatingBaseViewCollection) As VwFireRatingBaseViewCollectionWCFPacket
				Return New VwFireRatingBaseViewCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwFireRatingBaseViewQuery 
		Inherits esVwFireRatingBaseViewQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwFireRatingBaseViewQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwFireRatingBaseViewQuery) As String
			Return VwFireRatingBaseViewQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwFireRatingBaseViewQuery
			Return DirectCast(VwFireRatingBaseViewQuery.SerializeHelper.FromXml(query, GetType(VwFireRatingBaseViewQuery)), VwFireRatingBaseViewQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwFireRatingBaseView
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwFireRatingBaseView.RowNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RowNo As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireRatingBaseViewMetadata.ColumnNames.RowNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireRatingBaseViewMetadata.ColumnNames.RowNo, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.RowNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Address1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.GripssTIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GripssTIVUS As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireRatingBaseViewMetadata.ColumnNames.GripssTIVUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireRatingBaseViewMetadata.ColumnNames.GripssTIVUS, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.GripssTIVUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.StProvName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProvName As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.StProvName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.StProvName, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.StProvName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Client1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client1 As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Client1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.Client1, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Client1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.RatingID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingID As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.RatingID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.RatingID, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.RatingID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.Grade
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Grade As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.Grade)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.Grade, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Grade)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRatingBaseViewMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRatingBaseViewMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.ConstructionRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ConstructionRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OccupancyRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OccupancyRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.FloodRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.FloodRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.FloodRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FloodRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.EarthquakeRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EarthquakeRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.EarthquakeRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.WindstormRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindstormRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.WindstormRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.WindstormRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.WindstormRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OtherRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OtherRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OtherRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OtherRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.PhysicalProtectionRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PhysicalProtectionRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.PhysicalProtectionRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.PhysicalProtectionRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.PhysicalProtectionRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.HumanElementRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.HumanElementRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.NaturalHazardsProtectionRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NaturalHazardsProtectionRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.NaturalHazardsProtectionRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.NaturalHazardsProtectionRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.NaturalHazardsProtectionRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.BusinessContinuityRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessContinuityRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.BusinessContinuityRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.BusinessContinuityRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.BusinessContinuityRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.APL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Apl As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.Apl)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.Apl, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Apl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.APLFactor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLFactor As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.APLFactor)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.APLFactor, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.APLFactor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OverallPlantRatingRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallPlantRatingRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.OverallPlantRatingRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.OverallPlantRatingRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OverallPlantRatingRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.PassiveScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PassiveScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.PassiveScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.PassiveScore, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.PassiveScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.ActiveScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ActiveScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ActiveScore, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ActiveScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.TotalScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.TotalScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.TotalScore, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.TotalScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OtherWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OtherWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OtherWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OtherWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.ConstructionWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ConstructionWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OccupancyWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OccupancyWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.PhysicalProtectionWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PhysicalProtectionWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.PhysicalProtectionWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.PhysicalProtectionWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.PhysicalProtectionWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.HumanElementWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.HumanElementWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.NaturalHazardsProtectionWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NaturalHazardsProtectionWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.NaturalHazardsProtectionWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.NaturalHazardsProtectionWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.NaturalHazardsProtectionWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.BusinessContinuityWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessContinuityWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.BusinessContinuityWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.BusinessContinuityWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.BusinessContinuityWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.FireProtectionAllRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireProtectionAllRecsCompleteRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.FireProtectionAllRecsCompleteRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.FireProtectionAllRecsCompleteRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FireProtectionAllRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.HumanElementAllRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementAllRecsCompleteRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementAllRecsCompleteRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementAllRecsCompleteRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.HumanElementAllRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.NatHazProtAllRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazProtAllRecsCompleteRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.NatHazProtAllRecsCompleteRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.NatHazProtAllRecsCompleteRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.NatHazProtAllRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.BCPAllRecsCompletRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPAllRecsCompletRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.BCPAllRecsCompletRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.BCPAllRecsCompletRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.BCPAllRecsCompletRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.ActiveScoreWithRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveScoreWithRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ActiveScoreWithRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ActiveScoreWithRecsComplete, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ActiveScoreWithRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.APLWithAllRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.APLWithAllRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.APLWithAllRecsComplete, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.APLWithAllRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.FloodWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.FloodWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.FloodWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FloodWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.EarthquakeWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EarthquakeWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.EarthquakeWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.WindstormWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindstormWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.WindstormWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.WindstormWeight, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.WindstormWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OverallScoreWithRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallScoreWithRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OverallScoreWithRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.OverallScoreWithRecsComplete, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OverallScoreWithRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.AchievableScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AchievableScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScore, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.AchievableScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OverallScoreWithRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallScoreWithRecsCompleteRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.OverallScoreWithRecsCompleteRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OverallScoreWithRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.MaxPossibleScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MaxPossibleScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.MaxPossibleScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.MaxPossibleScore, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.MaxPossibleScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.APLFactorWithAllRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLFactorWithAllRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.APLFactorWithAllRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.APLFactorWithAllRecsComplete, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.APLFactorWithAllRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.FloodDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FloodDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FloodDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FloodDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.EarthquakeDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EarthquakeDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.EarthquakeDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.WindstormDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindstormDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.WindstormDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.WindstormDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.WindstormDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.ConstructionDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ConstructionDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OccupancyDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OccupancyDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.OtherDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.OtherDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.OtherDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OtherDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.FireDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FireDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FireDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FireDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.HumanDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.HumanDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.HumanDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.HumanDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.NaturalDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NaturalDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.NaturalDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.NaturalDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.NaturalDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.BusinessDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.BusinessDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.BusinessDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.BusinessDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.FireRecDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireRecDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FireRecDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.FireRecDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FireRecDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.HumanRecDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanRecDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.HumanRecDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.HumanRecDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.HumanRecDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.NaturalRecDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NaturalRecDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.NaturalRecDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.NaturalRecDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.NaturalRecDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.BusinessRecDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessRecDescription As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.BusinessRecDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.BusinessRecDescription, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.BusinessRecDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.ExchangeRate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRate As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ExchangeRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.ExchangeRate, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ExchangeRate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.AdminMemo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminMemo As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.AdminMemo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.AdminMemo, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.AdminMemo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.MaxPossibleRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MaxPossibleRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.MaxPossibleRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.MaxPossibleRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.MaxPossibleRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.IsLatestRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IsLatestRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.IsLatestRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.IsLatestRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.IsLatestRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.TotalScoreHexColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalScoreHexColor As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.TotalScoreHexColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.TotalScoreHexColor, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.TotalScoreHexColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.TotalScoreRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalScoreRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.TotalScoreRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.TotalScoreRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.TotalScoreRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.AchievableScoreHexColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AchievableScoreHexColor As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScoreHexColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScoreHexColor, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.AchievableScoreHexColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.AchievableScoreRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AchievableScoreRating As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScoreRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScoreRating, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.AchievableScoreRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.AchievableScorePercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AchievableScorePercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScorePercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScorePercent, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.AchievableScorePercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.IndustryGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IndustryGroup As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.IndustryGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.IndustryGroup, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.IndustryGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.InspPeriodPosition
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspPeriodPosition As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(VwFireRatingBaseViewMetadata.ColumnNames.InspPeriodPosition)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(VwFireRatingBaseViewMetadata.ColumnNames.InspPeriodPosition, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.InspPeriodPosition)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.InspPeriodDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspPeriodDesc As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.InspPeriodDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.InspPeriodDesc, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.InspPeriodDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.AchievableScorePercentString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AchievableScorePercentString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScorePercentString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScorePercentString, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.AchievableScorePercentString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRatingBaseView.TIVWeightedPotentialScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVWeightedPotentialScore As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireRatingBaseViewMetadata.ColumnNames.TIVWeightedPotentialScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireRatingBaseViewMetadata.ColumnNames.TIVWeightedPotentialScore, value) Then
					OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.TIVWeightedPotentialScore)
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
												
						Case "RowNo"
							Me.str().RowNo = CType(value, string)
												
						Case "Client"
							Me.str().Client = CType(value, string)
												
						Case "ClientLocNo"
							Me.str().ClientLocNo = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
												
						Case "Facility"
							Me.str().Facility = CType(value, string)
												
						Case "Address1"
							Me.str().Address1 = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "StProv"
							Me.str().StProv = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "GripssTIVUS"
							Me.str().GripssTIVUS = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "Zip"
							Me.str().Zip = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "StProvName"
							Me.str().StProvName = CType(value, string)
												
						Case "Client1"
							Me.str().Client1 = CType(value, string)
												
						Case "RatingID"
							Me.str().RatingID = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "Grade"
							Me.str().Grade = CType(value, string)
												
						Case "InspectionDate"
							Me.str().InspectionDate = CType(value, string)
												
						Case "ConstructionRating"
							Me.str().ConstructionRating = CType(value, string)
												
						Case "OccupancyRating"
							Me.str().OccupancyRating = CType(value, string)
												
						Case "FloodRating"
							Me.str().FloodRating = CType(value, string)
												
						Case "EarthquakeRating"
							Me.str().EarthquakeRating = CType(value, string)
												
						Case "WindstormRating"
							Me.str().WindstormRating = CType(value, string)
												
						Case "OtherRating"
							Me.str().OtherRating = CType(value, string)
												
						Case "PhysicalProtectionRating"
							Me.str().PhysicalProtectionRating = CType(value, string)
												
						Case "HumanElementRating"
							Me.str().HumanElementRating = CType(value, string)
												
						Case "NaturalHazardsProtectionRating"
							Me.str().NaturalHazardsProtectionRating = CType(value, string)
												
						Case "BusinessContinuityRating"
							Me.str().BusinessContinuityRating = CType(value, string)
												
						Case "Apl"
							Me.str().Apl = CType(value, string)
												
						Case "APLFactor"
							Me.str().APLFactor = CType(value, string)
												
						Case "OverallPlantRatingRating"
							Me.str().OverallPlantRatingRating = CType(value, string)
												
						Case "PassiveScore"
							Me.str().PassiveScore = CType(value, string)
												
						Case "ActiveScore"
							Me.str().ActiveScore = CType(value, string)
												
						Case "TotalScore"
							Me.str().TotalScore = CType(value, string)
												
						Case "OtherWeight"
							Me.str().OtherWeight = CType(value, string)
												
						Case "ConstructionWeight"
							Me.str().ConstructionWeight = CType(value, string)
												
						Case "OccupancyWeight"
							Me.str().OccupancyWeight = CType(value, string)
												
						Case "PhysicalProtectionWeight"
							Me.str().PhysicalProtectionWeight = CType(value, string)
												
						Case "HumanElementWeight"
							Me.str().HumanElementWeight = CType(value, string)
												
						Case "NaturalHazardsProtectionWeight"
							Me.str().NaturalHazardsProtectionWeight = CType(value, string)
												
						Case "BusinessContinuityWeight"
							Me.str().BusinessContinuityWeight = CType(value, string)
												
						Case "FireProtectionAllRecsCompleteRating"
							Me.str().FireProtectionAllRecsCompleteRating = CType(value, string)
												
						Case "HumanElementAllRecsCompleteRating"
							Me.str().HumanElementAllRecsCompleteRating = CType(value, string)
												
						Case "NatHazProtAllRecsCompleteRating"
							Me.str().NatHazProtAllRecsCompleteRating = CType(value, string)
												
						Case "BCPAllRecsCompletRating"
							Me.str().BCPAllRecsCompletRating = CType(value, string)
												
						Case "ActiveScoreWithRecsComplete"
							Me.str().ActiveScoreWithRecsComplete = CType(value, string)
												
						Case "APLWithAllRecsComplete"
							Me.str().APLWithAllRecsComplete = CType(value, string)
												
						Case "FloodWeight"
							Me.str().FloodWeight = CType(value, string)
												
						Case "EarthquakeWeight"
							Me.str().EarthquakeWeight = CType(value, string)
												
						Case "WindstormWeight"
							Me.str().WindstormWeight = CType(value, string)
												
						Case "OverallScoreWithRecsComplete"
							Me.str().OverallScoreWithRecsComplete = CType(value, string)
												
						Case "AchievableScore"
							Me.str().AchievableScore = CType(value, string)
												
						Case "OverallScoreWithRecsCompleteRating"
							Me.str().OverallScoreWithRecsCompleteRating = CType(value, string)
												
						Case "MaxPossibleScore"
							Me.str().MaxPossibleScore = CType(value, string)
												
						Case "APLFactorWithAllRecsComplete"
							Me.str().APLFactorWithAllRecsComplete = CType(value, string)
												
						Case "FloodDescription"
							Me.str().FloodDescription = CType(value, string)
												
						Case "EarthquakeDescription"
							Me.str().EarthquakeDescription = CType(value, string)
												
						Case "WindstormDescription"
							Me.str().WindstormDescription = CType(value, string)
												
						Case "ConstructionDescription"
							Me.str().ConstructionDescription = CType(value, string)
												
						Case "OccupancyDescription"
							Me.str().OccupancyDescription = CType(value, string)
												
						Case "OtherDescription"
							Me.str().OtherDescription = CType(value, string)
												
						Case "FireDescription"
							Me.str().FireDescription = CType(value, string)
												
						Case "HumanDescription"
							Me.str().HumanDescription = CType(value, string)
												
						Case "NaturalDescription"
							Me.str().NaturalDescription = CType(value, string)
												
						Case "BusinessDescription"
							Me.str().BusinessDescription = CType(value, string)
												
						Case "FireRecDescription"
							Me.str().FireRecDescription = CType(value, string)
												
						Case "HumanRecDescription"
							Me.str().HumanRecDescription = CType(value, string)
												
						Case "NaturalRecDescription"
							Me.str().NaturalRecDescription = CType(value, string)
												
						Case "BusinessRecDescription"
							Me.str().BusinessRecDescription = CType(value, string)
												
						Case "ExchangeRate"
							Me.str().ExchangeRate = CType(value, string)
												
						Case "AdminMemo"
							Me.str().AdminMemo = CType(value, string)
												
						Case "MaxPossibleRating"
							Me.str().MaxPossibleRating = CType(value, string)
												
						Case "IsLatestRating"
							Me.str().IsLatestRating = CType(value, string)
												
						Case "TotalScoreHexColor"
							Me.str().TotalScoreHexColor = CType(value, string)
												
						Case "TotalScoreRating"
							Me.str().TotalScoreRating = CType(value, string)
												
						Case "AchievableScoreHexColor"
							Me.str().AchievableScoreHexColor = CType(value, string)
												
						Case "AchievableScoreRating"
							Me.str().AchievableScoreRating = CType(value, string)
												
						Case "AchievableScorePercent"
							Me.str().AchievableScorePercent = CType(value, string)
												
						Case "IndustryGroup"
							Me.str().IndustryGroup = CType(value, string)
												
						Case "InspPeriodPosition"
							Me.str().InspPeriodPosition = CType(value, string)
												
						Case "InspPeriodDesc"
							Me.str().InspPeriodDesc = CType(value, string)
												
						Case "AchievableScorePercentString"
							Me.str().AchievableScorePercentString = CType(value, string)
												
						Case "TIVWeightedPotentialScore"
							Me.str().TIVWeightedPotentialScore = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RowNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.RowNo = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.RowNo)
							End If
						
						Case "GripssTIVUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.GripssTIVUS = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.GripssTIVUS)
							End If
						
						Case "RatingID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingID = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.RatingID)
							End If
						
						Case "Grade"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Grade = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Grade)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "ConstructionRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ConstructionRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ConstructionRating)
							End If
						
						Case "OccupancyRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OccupancyRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OccupancyRating)
							End If
						
						Case "FloodRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FloodRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FloodRating)
							End If
						
						Case "EarthquakeRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.EarthquakeRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.EarthquakeRating)
							End If
						
						Case "WindstormRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WindstormRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.WindstormRating)
							End If
						
						Case "OtherRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OtherRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OtherRating)
							End If
						
						Case "PhysicalProtectionRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PhysicalProtectionRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.PhysicalProtectionRating)
							End If
						
						Case "HumanElementRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.HumanElementRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.HumanElementRating)
							End If
						
						Case "NaturalHazardsProtectionRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.NaturalHazardsProtectionRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.NaturalHazardsProtectionRating)
							End If
						
						Case "BusinessContinuityRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BusinessContinuityRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.BusinessContinuityRating)
							End If
						
						Case "Apl"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Apl = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.Apl)
							End If
						
						Case "APLFactor"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLFactor = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.APLFactor)
							End If
						
						Case "PassiveScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PassiveScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.PassiveScore)
							End If
						
						Case "ActiveScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ActiveScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ActiveScore)
							End If
						
						Case "TotalScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.TotalScore)
							End If
						
						Case "OtherWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OtherWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OtherWeight)
							End If
						
						Case "ConstructionWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ConstructionWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ConstructionWeight)
							End If
						
						Case "OccupancyWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OccupancyWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OccupancyWeight)
							End If
						
						Case "PhysicalProtectionWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PhysicalProtectionWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.PhysicalProtectionWeight)
							End If
						
						Case "HumanElementWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.HumanElementWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.HumanElementWeight)
							End If
						
						Case "NaturalHazardsProtectionWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.NaturalHazardsProtectionWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.NaturalHazardsProtectionWeight)
							End If
						
						Case "BusinessContinuityWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BusinessContinuityWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.BusinessContinuityWeight)
							End If
						
						Case "FireProtectionAllRecsCompleteRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FireProtectionAllRecsCompleteRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FireProtectionAllRecsCompleteRating)
							End If
						
						Case "HumanElementAllRecsCompleteRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.HumanElementAllRecsCompleteRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.HumanElementAllRecsCompleteRating)
							End If
						
						Case "NatHazProtAllRecsCompleteRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.NatHazProtAllRecsCompleteRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.NatHazProtAllRecsCompleteRating)
							End If
						
						Case "BCPAllRecsCompletRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BCPAllRecsCompletRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.BCPAllRecsCompletRating)
							End If
						
						Case "ActiveScoreWithRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ActiveScoreWithRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ActiveScoreWithRecsComplete)
							End If
						
						Case "APLWithAllRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLWithAllRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.APLWithAllRecsComplete)
							End If
						
						Case "FloodWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FloodWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.FloodWeight)
							End If
						
						Case "EarthquakeWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.EarthquakeWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.EarthquakeWeight)
							End If
						
						Case "WindstormWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WindstormWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.WindstormWeight)
							End If
						
						Case "OverallScoreWithRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OverallScoreWithRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.OverallScoreWithRecsComplete)
							End If
						
						Case "AchievableScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.AchievableScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.AchievableScore)
							End If
						
						Case "MaxPossibleScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MaxPossibleScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.MaxPossibleScore)
							End If
						
						Case "APLFactorWithAllRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLFactorWithAllRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.APLFactorWithAllRecsComplete)
							End If
						
						Case "ExchangeRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ExchangeRate = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.ExchangeRate)
							End If
						
						Case "AchievableScorePercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.AchievableScorePercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.AchievableScorePercent)
							End If
						
						Case "InspPeriodPosition"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.InspPeriodPosition = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.InspPeriodPosition)
							End If
						
						Case "TIVWeightedPotentialScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TIVWeightedPotentialScore = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireRatingBaseViewMetadata.PropertyNames.TIVWeightedPotentialScore)
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
		
			Public Sub New(ByVal entity As esVwFireRatingBaseView)
				Me.entity = entity
			End Sub				
		
	
			Public Property RowNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.RowNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RowNo = Nothing
					Else
						entity.RowNo = Convert.ToInt64(Value)
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
		  	
			Public Property GripssTIVUS As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.GripssTIVUS
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GripssTIVUS = Nothing
					Else
						entity.GripssTIVUS = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Client1 As System.String 
				Get
					Dim data_ As System.String = entity.Client1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Client1 = Nothing
					Else
						entity.Client1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingID As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingID = Nothing
					Else
						entity.RatingID = Convert.ToDecimal(Value)
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
		  	
			Public Property Grade As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Grade
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Grade = Nothing
					Else
						entity.Grade = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionDate = Nothing
					Else
						entity.InspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ConstructionRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionRating = Nothing
					Else
						entity.ConstructionRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OccupancyRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyRating = Nothing
					Else
						entity.OccupancyRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FloodRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodRating = Nothing
					Else
						entity.FloodRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property EarthquakeRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.EarthquakeRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EarthquakeRating = Nothing
					Else
						entity.EarthquakeRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindstormRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WindstormRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindstormRating = Nothing
					Else
						entity.WindstormRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OtherRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherRating = Nothing
					Else
						entity.OtherRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PhysicalProtectionRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PhysicalProtectionRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PhysicalProtectionRating = Nothing
					Else
						entity.PhysicalProtectionRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.HumanElementRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementRating = Nothing
					Else
						entity.HumanElementRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property NaturalHazardsProtectionRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.NaturalHazardsProtectionRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NaturalHazardsProtectionRating = Nothing
					Else
						entity.NaturalHazardsProtectionRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BusinessContinuityRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BusinessContinuityRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessContinuityRating = Nothing
					Else
						entity.BusinessContinuityRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apl As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Apl
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apl = Nothing
					Else
						entity.Apl = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLFactor As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLFactor
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLFactor = Nothing
					Else
						entity.APLFactor = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallPlantRatingRating As System.String 
				Get
					Dim data_ As System.String = entity.OverallPlantRatingRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallPlantRatingRating = Nothing
					Else
						entity.OverallPlantRatingRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PassiveScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PassiveScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PassiveScore = Nothing
					Else
						entity.PassiveScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ActiveScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveScore = Nothing
					Else
						entity.ActiveScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalScore = Nothing
					Else
						entity.TotalScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OtherWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherWeight = Nothing
					Else
						entity.OtherWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ConstructionWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionWeight = Nothing
					Else
						entity.ConstructionWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OccupancyWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWeight = Nothing
					Else
						entity.OccupancyWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PhysicalProtectionWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PhysicalProtectionWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PhysicalProtectionWeight = Nothing
					Else
						entity.PhysicalProtectionWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.HumanElementWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWeight = Nothing
					Else
						entity.HumanElementWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property NaturalHazardsProtectionWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.NaturalHazardsProtectionWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NaturalHazardsProtectionWeight = Nothing
					Else
						entity.NaturalHazardsProtectionWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BusinessContinuityWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BusinessContinuityWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessContinuityWeight = Nothing
					Else
						entity.BusinessContinuityWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireProtectionAllRecsCompleteRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FireProtectionAllRecsCompleteRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireProtectionAllRecsCompleteRating = Nothing
					Else
						entity.FireProtectionAllRecsCompleteRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementAllRecsCompleteRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.HumanElementAllRecsCompleteRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementAllRecsCompleteRating = Nothing
					Else
						entity.HumanElementAllRecsCompleteRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazProtAllRecsCompleteRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.NatHazProtAllRecsCompleteRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazProtAllRecsCompleteRating = Nothing
					Else
						entity.NatHazProtAllRecsCompleteRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPAllRecsCompletRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BCPAllRecsCompletRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPAllRecsCompletRating = Nothing
					Else
						entity.BCPAllRecsCompletRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveScoreWithRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ActiveScoreWithRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveScoreWithRecsComplete = Nothing
					Else
						entity.ActiveScoreWithRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLWithAllRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsComplete = Nothing
					Else
						entity.APLWithAllRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FloodWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodWeight = Nothing
					Else
						entity.FloodWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property EarthquakeWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.EarthquakeWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EarthquakeWeight = Nothing
					Else
						entity.EarthquakeWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindstormWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WindstormWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindstormWeight = Nothing
					Else
						entity.WindstormWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallScoreWithRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OverallScoreWithRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallScoreWithRecsComplete = Nothing
					Else
						entity.OverallScoreWithRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property AchievableScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.AchievableScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AchievableScore = Nothing
					Else
						entity.AchievableScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallScoreWithRecsCompleteRating As System.String 
				Get
					Dim data_ As System.String = entity.OverallScoreWithRecsCompleteRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallScoreWithRecsCompleteRating = Nothing
					Else
						entity.OverallScoreWithRecsCompleteRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxPossibleScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MaxPossibleScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxPossibleScore = Nothing
					Else
						entity.MaxPossibleScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLFactorWithAllRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLFactorWithAllRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLFactorWithAllRecsComplete = Nothing
					Else
						entity.APLFactorWithAllRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodDescription As System.String 
				Get
					Dim data_ As System.String = entity.FloodDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodDescription = Nothing
					Else
						entity.FloodDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EarthquakeDescription As System.String 
				Get
					Dim data_ As System.String = entity.EarthquakeDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EarthquakeDescription = Nothing
					Else
						entity.EarthquakeDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindstormDescription As System.String 
				Get
					Dim data_ As System.String = entity.WindstormDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindstormDescription = Nothing
					Else
						entity.WindstormDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionDescription As System.String 
				Get
					Dim data_ As System.String = entity.ConstructionDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionDescription = Nothing
					Else
						entity.ConstructionDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyDescription As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyDescription = Nothing
					Else
						entity.OccupancyDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherDescription As System.String 
				Get
					Dim data_ As System.String = entity.OtherDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherDescription = Nothing
					Else
						entity.OtherDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireDescription As System.String 
				Get
					Dim data_ As System.String = entity.FireDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireDescription = Nothing
					Else
						entity.FireDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanDescription As System.String 
				Get
					Dim data_ As System.String = entity.HumanDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanDescription = Nothing
					Else
						entity.HumanDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NaturalDescription As System.String 
				Get
					Dim data_ As System.String = entity.NaturalDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NaturalDescription = Nothing
					Else
						entity.NaturalDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BusinessDescription As System.String 
				Get
					Dim data_ As System.String = entity.BusinessDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessDescription = Nothing
					Else
						entity.BusinessDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireRecDescription As System.String 
				Get
					Dim data_ As System.String = entity.FireRecDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireRecDescription = Nothing
					Else
						entity.FireRecDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanRecDescription As System.String 
				Get
					Dim data_ As System.String = entity.HumanRecDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanRecDescription = Nothing
					Else
						entity.HumanRecDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NaturalRecDescription As System.String 
				Get
					Dim data_ As System.String = entity.NaturalRecDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NaturalRecDescription = Nothing
					Else
						entity.NaturalRecDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BusinessRecDescription As System.String 
				Get
					Dim data_ As System.String = entity.BusinessRecDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessRecDescription = Nothing
					Else
						entity.BusinessRecDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExchangeRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ExchangeRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExchangeRate = Nothing
					Else
						entity.ExchangeRate = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property AdminMemo As System.String 
				Get
					Dim data_ As System.String = entity.AdminMemo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AdminMemo = Nothing
					Else
						entity.AdminMemo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxPossibleRating As System.String 
				Get
					Dim data_ As System.String = entity.MaxPossibleRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxPossibleRating = Nothing
					Else
						entity.MaxPossibleRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsLatestRating As System.String 
				Get
					Dim data_ As System.String = entity.IsLatestRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsLatestRating = Nothing
					Else
						entity.IsLatestRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalScoreHexColor As System.String 
				Get
					Dim data_ As System.String = entity.TotalScoreHexColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalScoreHexColor = Nothing
					Else
						entity.TotalScoreHexColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalScoreRating As System.String 
				Get
					Dim data_ As System.String = entity.TotalScoreRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalScoreRating = Nothing
					Else
						entity.TotalScoreRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AchievableScoreHexColor As System.String 
				Get
					Dim data_ As System.String = entity.AchievableScoreHexColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AchievableScoreHexColor = Nothing
					Else
						entity.AchievableScoreHexColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AchievableScoreRating As System.String 
				Get
					Dim data_ As System.String = entity.AchievableScoreRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AchievableScoreRating = Nothing
					Else
						entity.AchievableScoreRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AchievableScorePercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.AchievableScorePercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AchievableScorePercent = Nothing
					Else
						entity.AchievableScorePercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property IndustryGroup As System.String 
				Get
					Dim data_ As System.String = entity.IndustryGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IndustryGroup = Nothing
					Else
						entity.IndustryGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspPeriodPosition As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.InspPeriodPosition
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspPeriodPosition = Nothing
					Else
						entity.InspPeriodPosition = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspPeriodDesc As System.String 
				Get
					Dim data_ As System.String = entity.InspPeriodDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspPeriodDesc = Nothing
					Else
						entity.InspPeriodDesc = Convert.ToString(Value)
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
		  	
			Public Property TIVWeightedPotentialScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TIVWeightedPotentialScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVWeightedPotentialScore = Nothing
					Else
						entity.TIVWeightedPotentialScore = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVwFireRatingBaseView
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireRatingBaseViewMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwFireRatingBaseViewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireRatingBaseViewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwFireRatingBaseViewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwFireRatingBaseViewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwFireRatingBaseViewQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwFireRatingBaseViewCollection
		Inherits esEntityCollection(Of VwFireRatingBaseView)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireRatingBaseViewMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwFireRatingBaseViewCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwFireRatingBaseViewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireRatingBaseViewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwFireRatingBaseViewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwFireRatingBaseViewQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwFireRatingBaseViewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwFireRatingBaseViewQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwFireRatingBaseViewQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwFireRatingBaseViewQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwFireRatingBaseViewMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "RowNo" 
					Return Me.RowNo
				Case "Client" 
					Return Me.Client
				Case "ClientLocNo" 
					Return Me.ClientLocNo
				Case "Division" 
					Return Me.Division
				Case "Facility" 
					Return Me.Facility
				Case "Address1" 
					Return Me.Address1
				Case "City" 
					Return Me.City
				Case "StProv" 
					Return Me.StProv
				Case "Country" 
					Return Me.Country
				Case "GripssTIVUS" 
					Return Me.GripssTIVUS
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "Zip" 
					Return Me.Zip
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "Longitude" 
					Return Me.Longitude
				Case "Latitude" 
					Return Me.Latitude
				Case "StProvName" 
					Return Me.StProvName
				Case "Client1" 
					Return Me.Client1
				Case "RatingID" 
					Return Me.RatingID
				Case "FileNo" 
					Return Me.FileNo
				Case "Grade" 
					Return Me.Grade
				Case "InspectionDate" 
					Return Me.InspectionDate
				Case "ConstructionRating" 
					Return Me.ConstructionRating
				Case "OccupancyRating" 
					Return Me.OccupancyRating
				Case "FloodRating" 
					Return Me.FloodRating
				Case "EarthquakeRating" 
					Return Me.EarthquakeRating
				Case "WindstormRating" 
					Return Me.WindstormRating
				Case "OtherRating" 
					Return Me.OtherRating
				Case "PhysicalProtectionRating" 
					Return Me.PhysicalProtectionRating
				Case "HumanElementRating" 
					Return Me.HumanElementRating
				Case "NaturalHazardsProtectionRating" 
					Return Me.NaturalHazardsProtectionRating
				Case "BusinessContinuityRating" 
					Return Me.BusinessContinuityRating
				Case "Apl" 
					Return Me.Apl
				Case "APLFactor" 
					Return Me.APLFactor
				Case "OverallPlantRatingRating" 
					Return Me.OverallPlantRatingRating
				Case "PassiveScore" 
					Return Me.PassiveScore
				Case "ActiveScore" 
					Return Me.ActiveScore
				Case "TotalScore" 
					Return Me.TotalScore
				Case "OtherWeight" 
					Return Me.OtherWeight
				Case "ConstructionWeight" 
					Return Me.ConstructionWeight
				Case "OccupancyWeight" 
					Return Me.OccupancyWeight
				Case "PhysicalProtectionWeight" 
					Return Me.PhysicalProtectionWeight
				Case "HumanElementWeight" 
					Return Me.HumanElementWeight
				Case "NaturalHazardsProtectionWeight" 
					Return Me.NaturalHazardsProtectionWeight
				Case "BusinessContinuityWeight" 
					Return Me.BusinessContinuityWeight
				Case "FireProtectionAllRecsCompleteRating" 
					Return Me.FireProtectionAllRecsCompleteRating
				Case "HumanElementAllRecsCompleteRating" 
					Return Me.HumanElementAllRecsCompleteRating
				Case "NatHazProtAllRecsCompleteRating" 
					Return Me.NatHazProtAllRecsCompleteRating
				Case "BCPAllRecsCompletRating" 
					Return Me.BCPAllRecsCompletRating
				Case "ActiveScoreWithRecsComplete" 
					Return Me.ActiveScoreWithRecsComplete
				Case "APLWithAllRecsComplete" 
					Return Me.APLWithAllRecsComplete
				Case "FloodWeight" 
					Return Me.FloodWeight
				Case "EarthquakeWeight" 
					Return Me.EarthquakeWeight
				Case "WindstormWeight" 
					Return Me.WindstormWeight
				Case "OverallScoreWithRecsComplete" 
					Return Me.OverallScoreWithRecsComplete
				Case "AchievableScore" 
					Return Me.AchievableScore
				Case "OverallScoreWithRecsCompleteRating" 
					Return Me.OverallScoreWithRecsCompleteRating
				Case "MaxPossibleScore" 
					Return Me.MaxPossibleScore
				Case "APLFactorWithAllRecsComplete" 
					Return Me.APLFactorWithAllRecsComplete
				Case "FloodDescription" 
					Return Me.FloodDescription
				Case "EarthquakeDescription" 
					Return Me.EarthquakeDescription
				Case "WindstormDescription" 
					Return Me.WindstormDescription
				Case "ConstructionDescription" 
					Return Me.ConstructionDescription
				Case "OccupancyDescription" 
					Return Me.OccupancyDescription
				Case "OtherDescription" 
					Return Me.OtherDescription
				Case "FireDescription" 
					Return Me.FireDescription
				Case "HumanDescription" 
					Return Me.HumanDescription
				Case "NaturalDescription" 
					Return Me.NaturalDescription
				Case "BusinessDescription" 
					Return Me.BusinessDescription
				Case "FireRecDescription" 
					Return Me.FireRecDescription
				Case "HumanRecDescription" 
					Return Me.HumanRecDescription
				Case "NaturalRecDescription" 
					Return Me.NaturalRecDescription
				Case "BusinessRecDescription" 
					Return Me.BusinessRecDescription
				Case "ExchangeRate" 
					Return Me.ExchangeRate
				Case "AdminMemo" 
					Return Me.AdminMemo
				Case "MaxPossibleRating" 
					Return Me.MaxPossibleRating
				Case "IsLatestRating" 
					Return Me.IsLatestRating
				Case "TotalScoreHexColor" 
					Return Me.TotalScoreHexColor
				Case "TotalScoreRating" 
					Return Me.TotalScoreRating
				Case "AchievableScoreHexColor" 
					Return Me.AchievableScoreHexColor
				Case "AchievableScoreRating" 
					Return Me.AchievableScoreRating
				Case "AchievableScorePercent" 
					Return Me.AchievableScorePercent
				Case "IndustryGroup" 
					Return Me.IndustryGroup
				Case "InspPeriodPosition" 
					Return Me.InspPeriodPosition
				Case "InspPeriodDesc" 
					Return Me.InspPeriodDesc
				Case "AchievableScorePercentString" 
					Return Me.AchievableScorePercentString
				Case "TIVWeightedPotentialScore" 
					Return Me.TIVWeightedPotentialScore
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property RowNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.RowNo, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GripssTIVUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.GripssTIVUS, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Longitude, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Latitude, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProvName As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.StProvName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client1 As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Client1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingID As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.RatingID, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Grade As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Grade, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.ConstructionRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OccupancyRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FloodRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.FloodRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property EarthquakeRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WindstormRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.WindstormRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OtherRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OtherRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PhysicalProtectionRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.PhysicalProtectionRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.HumanElementRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property NaturalHazardsProtectionRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.NaturalHazardsProtectionRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessContinuityRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.BusinessContinuityRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Apl As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.Apl, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLFactor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.APLFactor, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OverallPlantRatingRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OverallPlantRatingRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PassiveScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.PassiveScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.ActiveScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.TotalScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OtherWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OtherWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.ConstructionWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OccupancyWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PhysicalProtectionWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.PhysicalProtectionWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.HumanElementWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property NaturalHazardsProtectionWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.NaturalHazardsProtectionWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessContinuityWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.BusinessContinuityWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FireProtectionAllRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.FireProtectionAllRecsCompleteRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementAllRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.HumanElementAllRecsCompleteRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazProtAllRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.NatHazProtAllRecsCompleteRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BCPAllRecsCompletRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.BCPAllRecsCompletRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveScoreWithRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.ActiveScoreWithRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.APLWithAllRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FloodWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.FloodWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property EarthquakeWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WindstormWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.WindstormWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OverallScoreWithRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OverallScoreWithRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property AchievableScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.AchievableScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OverallScoreWithRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MaxPossibleScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.MaxPossibleScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLFactorWithAllRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.APLFactorWithAllRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FloodDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.FloodDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EarthquakeDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WindstormDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.WindstormDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.ConstructionDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OccupancyDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.OtherDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.FireDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.HumanDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NaturalDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.NaturalDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.BusinessDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireRecDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.FireRecDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanRecDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.HumanRecDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NaturalRecDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.NaturalRecDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessRecDescription As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.BusinessRecDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.ExchangeRate, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property AdminMemo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.AdminMemo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MaxPossibleRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.MaxPossibleRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IsLatestRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.IsLatestRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalScoreHexColor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.TotalScoreHexColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalScoreRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.TotalScoreRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AchievableScoreHexColor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.AchievableScoreHexColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AchievableScoreRating As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.AchievableScoreRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AchievableScorePercent As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.AchievableScorePercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property IndustryGroup As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.IndustryGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspPeriodPosition As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.InspPeriodPosition, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property InspPeriodDesc As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.InspPeriodDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AchievableScorePercentString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.AchievableScorePercentString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TIVWeightedPotentialScore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRatingBaseViewMetadata.ColumnNames.TIVWeightedPotentialScore, esSystemType.Double)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwFireRatingBaseViewMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.RowNo, 0, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.RowNo
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Client, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.ClientLocNo, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Division, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Facility, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Address1, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.City, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.StProv, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Country, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.GripssTIVUS, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.GripssTIVUS
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.FilePrefix, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Zip, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.CustomAccess, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Longitude, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Longitude
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Latitude, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Latitude
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.StProvName, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.StProvName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Client1, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Client1
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.RatingID, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.RatingID
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.FileNo, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Grade, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Grade
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.InspectionDate, 20, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionRating, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.ConstructionRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyRating, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OccupancyRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.FloodRating, 23, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.FloodRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeRating, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.EarthquakeRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.WindstormRating, 25, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.WindstormRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OtherRating, 26, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OtherRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.PhysicalProtectionRating, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.PhysicalProtectionRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementRating, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.HumanElementRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.NaturalHazardsProtectionRating, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.NaturalHazardsProtectionRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.BusinessContinuityRating, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.BusinessContinuityRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.Apl, 31, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.Apl
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.APLFactor, 32, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.APLFactor
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OverallPlantRatingRating, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OverallPlantRatingRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.PassiveScore, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.PassiveScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.ActiveScore, 35, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.ActiveScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.TotalScore, 36, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.TotalScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OtherWeight, 37, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OtherWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionWeight, 38, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.ConstructionWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyWeight, 39, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OccupancyWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.PhysicalProtectionWeight, 40, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.PhysicalProtectionWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementWeight, 41, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.HumanElementWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.NaturalHazardsProtectionWeight, 42, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.NaturalHazardsProtectionWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.BusinessContinuityWeight, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.BusinessContinuityWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.FireProtectionAllRecsCompleteRating, 44, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.FireProtectionAllRecsCompleteRating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.HumanElementAllRecsCompleteRating, 45, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.HumanElementAllRecsCompleteRating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.NatHazProtAllRecsCompleteRating, 46, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.NatHazProtAllRecsCompleteRating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.BCPAllRecsCompletRating, 47, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.BCPAllRecsCompletRating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.ActiveScoreWithRecsComplete, 48, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.ActiveScoreWithRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.APLWithAllRecsComplete, 49, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.APLWithAllRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.FloodWeight, 50, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.FloodWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeWeight, 51, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.EarthquakeWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.WindstormWeight, 52, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.WindstormWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OverallScoreWithRecsComplete, 53, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OverallScoreWithRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScore, 54, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.AchievableScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OverallScoreWithRecsCompleteRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.MaxPossibleScore, 56, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.MaxPossibleScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.APLFactorWithAllRecsComplete, 57, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.APLFactorWithAllRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.FloodDescription, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.FloodDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.EarthquakeDescription, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.EarthquakeDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.WindstormDescription, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.WindstormDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.ConstructionDescription, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.ConstructionDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OccupancyDescription, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OccupancyDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.OtherDescription, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.OtherDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.FireDescription, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.FireDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.HumanDescription, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.HumanDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.NaturalDescription, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.NaturalDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.BusinessDescription, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.BusinessDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.FireRecDescription, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.FireRecDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.HumanRecDescription, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.HumanRecDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.NaturalRecDescription, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.NaturalRecDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.BusinessRecDescription, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.BusinessRecDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.ExchangeRate, 72, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.ExchangeRate
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.AdminMemo, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.AdminMemo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.MaxPossibleRating, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.MaxPossibleRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.IsLatestRating, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.IsLatestRating
			c.CharacterMaxLength = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.TotalScoreHexColor, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.TotalScoreHexColor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.TotalScoreRating, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.TotalScoreRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScoreHexColor, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.AchievableScoreHexColor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScoreRating, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.AchievableScoreRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScorePercent, 80, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.AchievableScorePercent
			c.NumericPrecision = 38
			c.NumericScale = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.IndustryGroup, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.IndustryGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.InspPeriodPosition, 82, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.InspPeriodPosition
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.InspPeriodDesc, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.InspPeriodDesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.AchievableScorePercentString, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.AchievableScorePercentString
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRatingBaseViewMetadata.ColumnNames.TIVWeightedPotentialScore, 85, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireRatingBaseViewMetadata.PropertyNames.TIVWeightedPotentialScore
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwFireRatingBaseViewMetadata
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
			 Public Const RowNo As String = "RowNo"
			 Public Const Client As String = "Client"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const Address1 As String = "Address1"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Country As String = "Country"
			 Public Const GripssTIVUS As String = "GripssTIVUS"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Zip As String = "Zip"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Longitude As String = "Longitude"
			 Public Const Latitude As String = "Latitude"
			 Public Const StProvName As String = "StProvName"
			 Public Const Client1 As String = "Client1"
			 Public Const RatingID As String = "RatingID"
			 Public Const FileNo As String = "FileNo"
			 Public Const Grade As String = "Grade"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const ConstructionRating As String = "ConstructionRating"
			 Public Const OccupancyRating As String = "OccupancyRating"
			 Public Const FloodRating As String = "FloodRating"
			 Public Const EarthquakeRating As String = "EarthquakeRating"
			 Public Const WindstormRating As String = "WindstormRating"
			 Public Const OtherRating As String = "OtherRating"
			 Public Const PhysicalProtectionRating As String = "PhysicalProtectionRating"
			 Public Const HumanElementRating As String = "HumanElementRating"
			 Public Const NaturalHazardsProtectionRating As String = "NaturalHazardsProtectionRating"
			 Public Const BusinessContinuityRating As String = "BusinessContinuityRating"
			 Public Const Apl As String = "APL"
			 Public Const APLFactor As String = "APLFactor"
			 Public Const OverallPlantRatingRating As String = "OverallPlantRatingRating"
			 Public Const PassiveScore As String = "PassiveScore"
			 Public Const ActiveScore As String = "ActiveScore"
			 Public Const TotalScore As String = "TotalScore"
			 Public Const OtherWeight As String = "OtherWeight"
			 Public Const ConstructionWeight As String = "ConstructionWeight"
			 Public Const OccupancyWeight As String = "OccupancyWeight"
			 Public Const PhysicalProtectionWeight As String = "PhysicalProtectionWeight"
			 Public Const HumanElementWeight As String = "HumanElementWeight"
			 Public Const NaturalHazardsProtectionWeight As String = "NaturalHazardsProtectionWeight"
			 Public Const BusinessContinuityWeight As String = "BusinessContinuityWeight"
			 Public Const FireProtectionAllRecsCompleteRating As String = "FireProtectionAllRecsCompleteRating"
			 Public Const HumanElementAllRecsCompleteRating As String = "HumanElementAllRecsCompleteRating"
			 Public Const NatHazProtAllRecsCompleteRating As String = "NatHazProtAllRecsCompleteRating"
			 Public Const BCPAllRecsCompletRating As String = "BCPAllRecsCompletRating"
			 Public Const ActiveScoreWithRecsComplete As String = "ActiveScoreWithRecsComplete"
			 Public Const APLWithAllRecsComplete As String = "APLWithAllRecsComplete"
			 Public Const FloodWeight As String = "FloodWeight"
			 Public Const EarthquakeWeight As String = "EarthquakeWeight"
			 Public Const WindstormWeight As String = "WindstormWeight"
			 Public Const OverallScoreWithRecsComplete As String = "OverallScoreWithRecsComplete"
			 Public Const AchievableScore As String = "AchievableScore"
			 Public Const OverallScoreWithRecsCompleteRating As String = "OverallScoreWithRecsCompleteRating"
			 Public Const MaxPossibleScore As String = "MaxPossibleScore"
			 Public Const APLFactorWithAllRecsComplete As String = "APLFactorWithAllRecsComplete"
			 Public Const FloodDescription As String = "FloodDescription"
			 Public Const EarthquakeDescription As String = "EarthquakeDescription"
			 Public Const WindstormDescription As String = "WindstormDescription"
			 Public Const ConstructionDescription As String = "ConstructionDescription"
			 Public Const OccupancyDescription As String = "OccupancyDescription"
			 Public Const OtherDescription As String = "OtherDescription"
			 Public Const FireDescription As String = "FireDescription"
			 Public Const HumanDescription As String = "HumanDescription"
			 Public Const NaturalDescription As String = "NaturalDescription"
			 Public Const BusinessDescription As String = "BusinessDescription"
			 Public Const FireRecDescription As String = "FireRecDescription"
			 Public Const HumanRecDescription As String = "HumanRecDescription"
			 Public Const NaturalRecDescription As String = "NaturalRecDescription"
			 Public Const BusinessRecDescription As String = "BusinessRecDescription"
			 Public Const ExchangeRate As String = "ExchangeRate"
			 Public Const AdminMemo As String = "AdminMemo"
			 Public Const MaxPossibleRating As String = "MaxPossibleRating"
			 Public Const IsLatestRating As String = "IsLatestRating"
			 Public Const TotalScoreHexColor As String = "TotalScoreHexColor"
			 Public Const TotalScoreRating As String = "TotalScoreRating"
			 Public Const AchievableScoreHexColor As String = "AchievableScoreHexColor"
			 Public Const AchievableScoreRating As String = "AchievableScoreRating"
			 Public Const AchievableScorePercent As String = "AchievableScorePercent"
			 Public Const IndustryGroup As String = "IndustryGroup"
			 Public Const InspPeriodPosition As String = "InspPeriodPosition"
			 Public Const InspPeriodDesc As String = "InspPeriodDesc"
			 Public Const AchievableScorePercentString As String = "AchievableScorePercentString"
			 Public Const TIVWeightedPotentialScore As String = "TIVWeightedPotentialScore"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const RowNo As String = "RowNo"
			 Public Const Client As String = "Client"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const Address1 As String = "Address1"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const Country As String = "Country"
			 Public Const GripssTIVUS As String = "GripssTIVUS"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Zip As String = "Zip"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const Longitude As String = "Longitude"
			 Public Const Latitude As String = "Latitude"
			 Public Const StProvName As String = "StProvName"
			 Public Const Client1 As String = "Client1"
			 Public Const RatingID As String = "RatingID"
			 Public Const FileNo As String = "FileNo"
			 Public Const Grade As String = "Grade"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const ConstructionRating As String = "ConstructionRating"
			 Public Const OccupancyRating As String = "OccupancyRating"
			 Public Const FloodRating As String = "FloodRating"
			 Public Const EarthquakeRating As String = "EarthquakeRating"
			 Public Const WindstormRating As String = "WindstormRating"
			 Public Const OtherRating As String = "OtherRating"
			 Public Const PhysicalProtectionRating As String = "PhysicalProtectionRating"
			 Public Const HumanElementRating As String = "HumanElementRating"
			 Public Const NaturalHazardsProtectionRating As String = "NaturalHazardsProtectionRating"
			 Public Const BusinessContinuityRating As String = "BusinessContinuityRating"
			 Public Const Apl As String = "Apl"
			 Public Const APLFactor As String = "APLFactor"
			 Public Const OverallPlantRatingRating As String = "OverallPlantRatingRating"
			 Public Const PassiveScore As String = "PassiveScore"
			 Public Const ActiveScore As String = "ActiveScore"
			 Public Const TotalScore As String = "TotalScore"
			 Public Const OtherWeight As String = "OtherWeight"
			 Public Const ConstructionWeight As String = "ConstructionWeight"
			 Public Const OccupancyWeight As String = "OccupancyWeight"
			 Public Const PhysicalProtectionWeight As String = "PhysicalProtectionWeight"
			 Public Const HumanElementWeight As String = "HumanElementWeight"
			 Public Const NaturalHazardsProtectionWeight As String = "NaturalHazardsProtectionWeight"
			 Public Const BusinessContinuityWeight As String = "BusinessContinuityWeight"
			 Public Const FireProtectionAllRecsCompleteRating As String = "FireProtectionAllRecsCompleteRating"
			 Public Const HumanElementAllRecsCompleteRating As String = "HumanElementAllRecsCompleteRating"
			 Public Const NatHazProtAllRecsCompleteRating As String = "NatHazProtAllRecsCompleteRating"
			 Public Const BCPAllRecsCompletRating As String = "BCPAllRecsCompletRating"
			 Public Const ActiveScoreWithRecsComplete As String = "ActiveScoreWithRecsComplete"
			 Public Const APLWithAllRecsComplete As String = "APLWithAllRecsComplete"
			 Public Const FloodWeight As String = "FloodWeight"
			 Public Const EarthquakeWeight As String = "EarthquakeWeight"
			 Public Const WindstormWeight As String = "WindstormWeight"
			 Public Const OverallScoreWithRecsComplete As String = "OverallScoreWithRecsComplete"
			 Public Const AchievableScore As String = "AchievableScore"
			 Public Const OverallScoreWithRecsCompleteRating As String = "OverallScoreWithRecsCompleteRating"
			 Public Const MaxPossibleScore As String = "MaxPossibleScore"
			 Public Const APLFactorWithAllRecsComplete As String = "APLFactorWithAllRecsComplete"
			 Public Const FloodDescription As String = "FloodDescription"
			 Public Const EarthquakeDescription As String = "EarthquakeDescription"
			 Public Const WindstormDescription As String = "WindstormDescription"
			 Public Const ConstructionDescription As String = "ConstructionDescription"
			 Public Const OccupancyDescription As String = "OccupancyDescription"
			 Public Const OtherDescription As String = "OtherDescription"
			 Public Const FireDescription As String = "FireDescription"
			 Public Const HumanDescription As String = "HumanDescription"
			 Public Const NaturalDescription As String = "NaturalDescription"
			 Public Const BusinessDescription As String = "BusinessDescription"
			 Public Const FireRecDescription As String = "FireRecDescription"
			 Public Const HumanRecDescription As String = "HumanRecDescription"
			 Public Const NaturalRecDescription As String = "NaturalRecDescription"
			 Public Const BusinessRecDescription As String = "BusinessRecDescription"
			 Public Const ExchangeRate As String = "ExchangeRate"
			 Public Const AdminMemo As String = "AdminMemo"
			 Public Const MaxPossibleRating As String = "MaxPossibleRating"
			 Public Const IsLatestRating As String = "IsLatestRating"
			 Public Const TotalScoreHexColor As String = "TotalScoreHexColor"
			 Public Const TotalScoreRating As String = "TotalScoreRating"
			 Public Const AchievableScoreHexColor As String = "AchievableScoreHexColor"
			 Public Const AchievableScoreRating As String = "AchievableScoreRating"
			 Public Const AchievableScorePercent As String = "AchievableScorePercent"
			 Public Const IndustryGroup As String = "IndustryGroup"
			 Public Const InspPeriodPosition As String = "InspPeriodPosition"
			 Public Const InspPeriodDesc As String = "InspPeriodDesc"
			 Public Const AchievableScorePercentString As String = "AchievableScorePercentString"
			 Public Const TIVWeightedPotentialScore As String = "TIVWeightedPotentialScore"
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
			SyncLock GetType(VwFireRatingBaseViewMetadata)
			
				If VwFireRatingBaseViewMetadata.mapDelegates Is Nothing Then
					VwFireRatingBaseViewMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwFireRatingBaseViewMetadata._meta Is Nothing Then
					VwFireRatingBaseViewMetadata._meta = New VwFireRatingBaseViewMetadata()
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
				


				meta.AddTypeMap("RowNo", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Client", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ClientLocNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Facility", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GripssTIVUS", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Zip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Longitude", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProvName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Client1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RatingID", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Grade", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("InspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ConstructionRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OccupancyRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FloodRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("EarthquakeRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("WindstormRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OtherRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("PhysicalProtectionRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("HumanElementRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("NaturalHazardsProtectionRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("BusinessContinuityRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Apl", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLFactor", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OverallPlantRatingRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PassiveScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ActiveScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("TotalScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OtherWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ConstructionWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OccupancyWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("PhysicalProtectionWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("HumanElementWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("NaturalHazardsProtectionWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("BusinessContinuityWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FireProtectionAllRecsCompleteRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("HumanElementAllRecsCompleteRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("NatHazProtAllRecsCompleteRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("BCPAllRecsCompletRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ActiveScoreWithRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLWithAllRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FloodWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("EarthquakeWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("WindstormWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OverallScoreWithRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("AchievableScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OverallScoreWithRecsCompleteRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MaxPossibleScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLFactorWithAllRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FloodDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EarthquakeDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WindstormDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ConstructionDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OccupancyDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OtherDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HumanDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NaturalDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BusinessDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireRecDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HumanRecDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NaturalRecDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BusinessRecDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExchangeRate", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("AdminMemo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MaxPossibleRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("IsLatestRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalScoreHexColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalScoreRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AchievableScoreHexColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AchievableScoreRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AchievableScorePercent", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("IndustryGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspPeriodPosition", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("InspPeriodDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("AchievableScorePercentString", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TIVWeightedPotentialScore", new esTypeMap("float", "System.Double"))			
				
				meta.Schema = "bv"
				 
				meta.Source = "vwFireRatingBaseView"
				meta.Destination = "vwFireRatingBaseView"
				
				meta.spInsert = "proc_vwFireRatingBaseViewInsert"
				meta.spUpdate = "proc_vwFireRatingBaseViewUpdate"
				meta.spDelete = "proc_vwFireRatingBaseViewDelete"
				meta.spLoadAll = "proc_vwFireRatingBaseViewLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwFireRatingBaseViewLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwFireRatingBaseViewMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
