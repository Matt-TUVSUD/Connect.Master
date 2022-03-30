
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2013 1:05:42 PM
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
	' Encapsulates the 'vwFireAllRecommendations' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwFireAllRecommendations))> _
	<XmlType("VwFireAllRecommendations")> _	
	Partial Public Class VwFireAllRecommendations 
		Inherits esVwFireAllRecommendations
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwFireAllRecommendations()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwFireAllRecommendationsCollection")> _
	Partial Public Class VwFireAllRecommendationsCollection
		Inherits esVwFireAllRecommendationsCollection
		Implements IEnumerable(Of VwFireAllRecommendations)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwFireAllRecommendations))> _
		Public Class VwFireAllRecommendationsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwFireAllRecommendationsCollection)
			
			Public Shared Widening Operator CType(packet As VwFireAllRecommendationsCollectionWCFPacket) As VwFireAllRecommendationsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwFireAllRecommendationsCollection) As VwFireAllRecommendationsCollectionWCFPacket
				Return New VwFireAllRecommendationsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwFireAllRecommendationsQuery 
		Inherits esVwFireAllRecommendationsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwFireAllRecommendationsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwFireAllRecommendationsQuery) As String
			Return VwFireAllRecommendationsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwFireAllRecommendationsQuery
			Return DirectCast(VwFireAllRecommendationsQuery.SerializeHelper.FromXml(query, GetType(VwFireAllRecommendationsQuery)), VwFireAllRecommendationsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwFireAllRecommendations
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwFireAllRecommendations.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(VwFireAllRecommendationsMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(VwFireAllRecommendationsMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireAllRecommendationsMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireAllRecommendationsMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecPrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPrefix As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecPrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecPrefix, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecPrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMonth As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecMonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecMonth, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecSubletter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecSubletter As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecSubletter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecSubletter, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecSubletter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireAllRecommendationsMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireAllRecommendationsMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCode As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecCode, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecCategory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategory As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecCategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecCategory, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecCategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.HazardPrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HazardPrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.HazardPrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.HazardPrimaryRecType, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.HazardPrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.RecKeyWords
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecKeyWords As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecKeyWords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.RecKeyWords, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecKeyWords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LossExpectancyBeforeActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LossExpectancyBefore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBefore As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyBefore)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyBefore, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyBefore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LossExpectancyAfterActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LossExpectancyAfter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfter As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyAfter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyAfter, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyAfter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.CostToCompleteActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.CostToCompleteActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.CostToCompleteActual, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.CostToCompleteActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.CostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToComplete As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.CostToComplete)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.CostToComplete, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.CostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEBeforeAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeAustralian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEBeforeAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeAustralian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEAfterAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterAustralian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEAfterAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEAfterAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterAustralian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LECostAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostAustralian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LECostAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLECostAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostAustralian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEBeforeBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeBritish As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeBritish, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEBeforeBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeBritish, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEAfterBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterBritish As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterBritish, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEAfterBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEAfterBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterBritish, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LECostBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostBritish As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostBritish, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LECostBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLECostBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostBritish, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEBeforeCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeCanadian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEBeforeCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeCanadian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEAfterCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterCanadian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEAfterCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEAfterCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterCanadian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LECostCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostCanadian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LECostCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLECostCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostCanadian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEBeforeEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeEuro As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeEuro, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEBeforeEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeEuro, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEAfterEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterEuro As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterEuro, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEAfterEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEAfterEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterEuro, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LECostEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostEuro As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostEuro, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LECostEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLECostEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostEuro, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEBeforeJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeJapanese, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEBeforeJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeJapanese, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEAfterJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterJapanese, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEAfterJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEAfterJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterJapanese, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LECostJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostJapanese, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LECostJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLECostJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostJapanese, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEBeforeMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeMexican As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeMexican, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEBeforeMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeMexican, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEAfterMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterMexican As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterMexican, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEAfterMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEAfterMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterMexican, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LECostMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostMexican As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostMexican, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LECostMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLECostMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostMexican, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEBeforeNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeNewZealand, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEBeforeNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeNewZealand, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEAfterNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterNewZealand, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEAfterNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEAfterNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterNewZealand, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LECostNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostNewZealand, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LECostNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLECostNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostNewZealand, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEBeforeUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeUS As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeUS, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEBeforeUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeUS, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LEAfterUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterUS As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterUS, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LEAfterUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLEAfterUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterUS, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.LECostUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostUS As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.LECostUS, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LECostUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualLECostUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostUS, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToComplete, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToCompleteAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteAustralian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToCompleteBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteBritish, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToCompleteCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteCanadian, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToCompleteEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteEuro, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToCompleteJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteJapanese, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToCompleteMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteMexican, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToCompleteNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteNewZealand, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ActualCostToCompleteUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteUS, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.SavingsRatio
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SavingsRatio As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.SavingsRatio)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.SavingsRatio, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.SavingsRatio)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ResponseFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseFrom As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.ResponseFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.ResponseFrom, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ResponseFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.PlantComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantComment As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.PlantComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.PlantComment, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.PlantComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ExpectedCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.PlantFeedback
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantFeedback As System.String
			Get
				Return MyBase.GetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.PlantFeedback)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireAllRecommendationsMetadata.ColumnNames.PlantFeedback, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.PlantFeedback)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.StatusDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.StatusDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.StatusDateMonth, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.StatusDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.StatusDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.StatusDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.StatusDateYear, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.StatusDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ResponseDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDateMonth, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ResponseDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ResponseDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDateYear, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ResponseDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ExpectedCompletionDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDateMonth, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireAllRecommendations.ExpectedCompletionDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDateYear, value) Then
					OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDateYear)
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
												
						Case "LEBeforeAustralian"
							Me.str().LEBeforeAustralian = CType(value, string)
												
						Case "ActualLEBeforeAustralian"
							Me.str().ActualLEBeforeAustralian = CType(value, string)
												
						Case "LEAfterAustralian"
							Me.str().LEAfterAustralian = CType(value, string)
												
						Case "ActualLEAfterAustralian"
							Me.str().ActualLEAfterAustralian = CType(value, string)
												
						Case "LECostAustralian"
							Me.str().LECostAustralian = CType(value, string)
												
						Case "ActualLECostAustralian"
							Me.str().ActualLECostAustralian = CType(value, string)
												
						Case "LEBeforeBritish"
							Me.str().LEBeforeBritish = CType(value, string)
												
						Case "ActualLEBeforeBritish"
							Me.str().ActualLEBeforeBritish = CType(value, string)
												
						Case "LEAfterBritish"
							Me.str().LEAfterBritish = CType(value, string)
												
						Case "ActualLEAfterBritish"
							Me.str().ActualLEAfterBritish = CType(value, string)
												
						Case "LECostBritish"
							Me.str().LECostBritish = CType(value, string)
												
						Case "ActualLECostBritish"
							Me.str().ActualLECostBritish = CType(value, string)
												
						Case "LEBeforeCanadian"
							Me.str().LEBeforeCanadian = CType(value, string)
												
						Case "ActualLEBeforeCanadian"
							Me.str().ActualLEBeforeCanadian = CType(value, string)
												
						Case "LEAfterCanadian"
							Me.str().LEAfterCanadian = CType(value, string)
												
						Case "ActualLEAfterCanadian"
							Me.str().ActualLEAfterCanadian = CType(value, string)
												
						Case "LECostCanadian"
							Me.str().LECostCanadian = CType(value, string)
												
						Case "ActualLECostCanadian"
							Me.str().ActualLECostCanadian = CType(value, string)
												
						Case "LEBeforeEuro"
							Me.str().LEBeforeEuro = CType(value, string)
												
						Case "ActualLEBeforeEuro"
							Me.str().ActualLEBeforeEuro = CType(value, string)
												
						Case "LEAfterEuro"
							Me.str().LEAfterEuro = CType(value, string)
												
						Case "ActualLEAfterEuro"
							Me.str().ActualLEAfterEuro = CType(value, string)
												
						Case "LECostEuro"
							Me.str().LECostEuro = CType(value, string)
												
						Case "ActualLECostEuro"
							Me.str().ActualLECostEuro = CType(value, string)
												
						Case "LEBeforeJapanese"
							Me.str().LEBeforeJapanese = CType(value, string)
												
						Case "ActualLEBeforeJapanese"
							Me.str().ActualLEBeforeJapanese = CType(value, string)
												
						Case "LEAfterJapanese"
							Me.str().LEAfterJapanese = CType(value, string)
												
						Case "ActualLEAfterJapanese"
							Me.str().ActualLEAfterJapanese = CType(value, string)
												
						Case "LECostJapanese"
							Me.str().LECostJapanese = CType(value, string)
												
						Case "ActualLECostJapanese"
							Me.str().ActualLECostJapanese = CType(value, string)
												
						Case "LEBeforeMexican"
							Me.str().LEBeforeMexican = CType(value, string)
												
						Case "ActualLEBeforeMexican"
							Me.str().ActualLEBeforeMexican = CType(value, string)
												
						Case "LEAfterMexican"
							Me.str().LEAfterMexican = CType(value, string)
												
						Case "ActualLEAfterMexican"
							Me.str().ActualLEAfterMexican = CType(value, string)
												
						Case "LECostMexican"
							Me.str().LECostMexican = CType(value, string)
												
						Case "ActualLECostMexican"
							Me.str().ActualLECostMexican = CType(value, string)
												
						Case "LEBeforeNewZealand"
							Me.str().LEBeforeNewZealand = CType(value, string)
												
						Case "ActualLEBeforeNewZealand"
							Me.str().ActualLEBeforeNewZealand = CType(value, string)
												
						Case "LEAfterNewZealand"
							Me.str().LEAfterNewZealand = CType(value, string)
												
						Case "ActualLEAfterNewZealand"
							Me.str().ActualLEAfterNewZealand = CType(value, string)
												
						Case "LECostNewZealand"
							Me.str().LECostNewZealand = CType(value, string)
												
						Case "ActualLECostNewZealand"
							Me.str().ActualLECostNewZealand = CType(value, string)
												
						Case "LEBeforeUS"
							Me.str().LEBeforeUS = CType(value, string)
												
						Case "ActualLEBeforeUS"
							Me.str().ActualLEBeforeUS = CType(value, string)
												
						Case "LEAfterUS"
							Me.str().LEAfterUS = CType(value, string)
												
						Case "ActualLEAfterUS"
							Me.str().ActualLEAfterUS = CType(value, string)
												
						Case "LECostUS"
							Me.str().LECostUS = CType(value, string)
												
						Case "ActualLECostUS"
							Me.str().ActualLECostUS = CType(value, string)
												
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
												
						Case "IntendedAction"
							Me.str().IntendedAction = CType(value, string)
												
						Case "ResponseDate"
							Me.str().ResponseDate = CType(value, string)
												
						Case "ResponseFrom"
							Me.str().ResponseFrom = CType(value, string)
												
						Case "PlantComment"
							Me.str().PlantComment = CType(value, string)
												
						Case "ExpectedCompletionDate"
							Me.str().ExpectedCompletionDate = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "PlantFeedback"
							Me.str().PlantFeedback = CType(value, string)
												
						Case "StatusDateMonth"
							Me.str().StatusDateMonth = CType(value, string)
												
						Case "StatusDateYear"
							Me.str().StatusDateYear = CType(value, string)
												
						Case "ResponseDateMonth"
							Me.str().ResponseDateMonth = CType(value, string)
												
						Case "ResponseDateYear"
							Me.str().ResponseDateYear = CType(value, string)
												
						Case "ExpectedCompletionDateMonth"
							Me.str().ExpectedCompletionDateMonth = CType(value, string)
												
						Case "ExpectedCompletionDateYear"
							Me.str().ExpectedCompletionDateYear = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.Tivus)
							End If
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecYear)
							End If
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.RecNumber)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.StatusDate)
							End If
						
						Case "LossExpectancyBeforeActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyBeforeActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
							End If
						
						Case "LossExpectancyAfterActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyAfterActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
							End If
						
						Case "CostToCompleteActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.CostToCompleteActual)
							End If
						
						Case "ActualLEBeforeAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeAustralian)
							End If
						
						Case "ActualLEAfterAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterAustralian)
							End If
						
						Case "ActualLECostAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostAustralian)
							End If
						
						Case "ActualLEBeforeBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeBritish)
							End If
						
						Case "ActualLEAfterBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterBritish)
							End If
						
						Case "ActualLECostBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostBritish)
							End If
						
						Case "ActualLEBeforeCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeCanadian)
							End If
						
						Case "ActualLEAfterCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterCanadian)
							End If
						
						Case "ActualLECostCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostCanadian)
							End If
						
						Case "ActualLEBeforeEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeEuro)
							End If
						
						Case "ActualLEAfterEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterEuro)
							End If
						
						Case "ActualLECostEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostEuro)
							End If
						
						Case "ActualLEBeforeJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeJapanese)
							End If
						
						Case "ActualLEAfterJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterJapanese)
							End If
						
						Case "ActualLECostJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostJapanese)
							End If
						
						Case "ActualLEBeforeMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeMexican)
							End If
						
						Case "ActualLEAfterMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterMexican)
							End If
						
						Case "ActualLECostMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostMexican)
							End If
						
						Case "ActualLEBeforeNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeNewZealand)
							End If
						
						Case "ActualLEAfterNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterNewZealand)
							End If
						
						Case "ActualLECostNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostNewZealand)
							End If
						
						Case "ActualLEBeforeUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeUS)
							End If
						
						Case "ActualLEAfterUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterUS)
							End If
						
						Case "ActualLECostUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostUS)
							End If
						
						Case "ActualCostToComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ActualCostToComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToComplete)
							End If
						
						Case "ActualCostToCompleteAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteAustralian)
							End If
						
						Case "ActualCostToCompleteBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteBritish)
							End If
						
						Case "ActualCostToCompleteCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteCanadian)
							End If
						
						Case "ActualCostToCompleteEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteEuro)
							End If
						
						Case "ActualCostToCompleteJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteJapanese)
							End If
						
						Case "ActualCostToCompleteMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteMexican)
							End If
						
						Case "ActualCostToCompleteNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteNewZealand)
							End If
						
						Case "ActualCostToCompleteUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteUS)
							End If
						
						Case "SavingsRatio"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SavingsRatio = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.SavingsRatio)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "ExpectedCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDate)
							End If
						
						Case "StatusDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.StatusDateMonth)
							End If
						
						Case "StatusDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.StatusDateYear)
							End If
						
						Case "ResponseDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ResponseDateMonth)
							End If
						
						Case "ResponseDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ResponseDateYear)
							End If
						
						Case "ExpectedCompletionDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDateMonth)
							End If
						
						Case "ExpectedCompletionDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDateYear)
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
		
			Public Sub New(ByVal entity As esVwFireAllRecommendations)
				Me.entity = entity
			End Sub				
		
	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.FilePrefix
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToInt16(Value)
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
		  

			Private entity As esVwFireAllRecommendations
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireAllRecommendationsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwFireAllRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireAllRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwFireAllRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwFireAllRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwFireAllRecommendationsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwFireAllRecommendationsCollection
		Inherits esEntityCollection(Of VwFireAllRecommendations)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireAllRecommendationsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwFireAllRecommendationsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwFireAllRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireAllRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwFireAllRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwFireAllRecommendationsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwFireAllRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwFireAllRecommendationsQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwFireAllRecommendationsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwFireAllRecommendationsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwFireAllRecommendationsMetadata.Meta()
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
				Case "LEBeforeAustralian" 
					Return Me.LEBeforeAustralian
				Case "ActualLEBeforeAustralian" 
					Return Me.ActualLEBeforeAustralian
				Case "LEAfterAustralian" 
					Return Me.LEAfterAustralian
				Case "ActualLEAfterAustralian" 
					Return Me.ActualLEAfterAustralian
				Case "LECostAustralian" 
					Return Me.LECostAustralian
				Case "ActualLECostAustralian" 
					Return Me.ActualLECostAustralian
				Case "LEBeforeBritish" 
					Return Me.LEBeforeBritish
				Case "ActualLEBeforeBritish" 
					Return Me.ActualLEBeforeBritish
				Case "LEAfterBritish" 
					Return Me.LEAfterBritish
				Case "ActualLEAfterBritish" 
					Return Me.ActualLEAfterBritish
				Case "LECostBritish" 
					Return Me.LECostBritish
				Case "ActualLECostBritish" 
					Return Me.ActualLECostBritish
				Case "LEBeforeCanadian" 
					Return Me.LEBeforeCanadian
				Case "ActualLEBeforeCanadian" 
					Return Me.ActualLEBeforeCanadian
				Case "LEAfterCanadian" 
					Return Me.LEAfterCanadian
				Case "ActualLEAfterCanadian" 
					Return Me.ActualLEAfterCanadian
				Case "LECostCanadian" 
					Return Me.LECostCanadian
				Case "ActualLECostCanadian" 
					Return Me.ActualLECostCanadian
				Case "LEBeforeEuro" 
					Return Me.LEBeforeEuro
				Case "ActualLEBeforeEuro" 
					Return Me.ActualLEBeforeEuro
				Case "LEAfterEuro" 
					Return Me.LEAfterEuro
				Case "ActualLEAfterEuro" 
					Return Me.ActualLEAfterEuro
				Case "LECostEuro" 
					Return Me.LECostEuro
				Case "ActualLECostEuro" 
					Return Me.ActualLECostEuro
				Case "LEBeforeJapanese" 
					Return Me.LEBeforeJapanese
				Case "ActualLEBeforeJapanese" 
					Return Me.ActualLEBeforeJapanese
				Case "LEAfterJapanese" 
					Return Me.LEAfterJapanese
				Case "ActualLEAfterJapanese" 
					Return Me.ActualLEAfterJapanese
				Case "LECostJapanese" 
					Return Me.LECostJapanese
				Case "ActualLECostJapanese" 
					Return Me.ActualLECostJapanese
				Case "LEBeforeMexican" 
					Return Me.LEBeforeMexican
				Case "ActualLEBeforeMexican" 
					Return Me.ActualLEBeforeMexican
				Case "LEAfterMexican" 
					Return Me.LEAfterMexican
				Case "ActualLEAfterMexican" 
					Return Me.ActualLEAfterMexican
				Case "LECostMexican" 
					Return Me.LECostMexican
				Case "ActualLECostMexican" 
					Return Me.ActualLECostMexican
				Case "LEBeforeNewZealand" 
					Return Me.LEBeforeNewZealand
				Case "ActualLEBeforeNewZealand" 
					Return Me.ActualLEBeforeNewZealand
				Case "LEAfterNewZealand" 
					Return Me.LEAfterNewZealand
				Case "ActualLEAfterNewZealand" 
					Return Me.ActualLEAfterNewZealand
				Case "LECostNewZealand" 
					Return Me.LECostNewZealand
				Case "ActualLECostNewZealand" 
					Return Me.ActualLECostNewZealand
				Case "LEBeforeUS" 
					Return Me.LEBeforeUS
				Case "ActualLEBeforeUS" 
					Return Me.ActualLEBeforeUS
				Case "LEAfterUS" 
					Return Me.LEAfterUS
				Case "ActualLEAfterUS" 
					Return Me.ActualLEAfterUS
				Case "LECostUS" 
					Return Me.LECostUS
				Case "ActualLECostUS" 
					Return Me.ActualLECostUS
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
				Case "IntendedAction" 
					Return Me.IntendedAction
				Case "ResponseDate" 
					Return Me.ResponseDate
				Case "ResponseFrom" 
					Return Me.ResponseFrom
				Case "PlantComment" 
					Return Me.PlantComment
				Case "ExpectedCompletionDate" 
					Return Me.ExpectedCompletionDate
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "PlantFeedback" 
					Return Me.PlantFeedback
				Case "StatusDateMonth" 
					Return Me.StatusDateMonth
				Case "StatusDateYear" 
					Return Me.StatusDateYear
				Case "ResponseDateMonth" 
					Return Me.ResponseDateMonth
				Case "ResponseDateYear" 
					Return Me.ResponseDateYear
				Case "ExpectedCompletionDateMonth" 
					Return Me.ExpectedCompletionDateMonth
				Case "ExpectedCompletionDateYear" 
					Return Me.ExpectedCompletionDateYear
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property RecPrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecPrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecMonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecSubletter As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecSubletter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecCode As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategory As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecCategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazardPrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.HazardPrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecKeyWords As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.RecKeyWords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBefore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyBefore, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfter As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyAfter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.CostToCompleteActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.CostToComplete, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEAfterAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LECostAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEAfterBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LECostBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEAfterCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LECostCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEAfterEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LECostEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEAfterJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LECostJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEAfterMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LECostMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEAfterNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LECostNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LEAfterUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.LECostUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property SavingsRatio As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.SavingsRatio, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseFrom As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ResponseFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantComment As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.PlantComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantFeedback As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.PlantFeedback, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.StatusDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.StatusDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ResponseDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ResponseDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDateYear, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwFireAllRecommendationsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.FilePrefix, 0, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.Facility, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.Address, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.City, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.StProv, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.Country, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames._100PercentUSTot, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.TIVAustralian, 11, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.TIVBritish, 12, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.TIVCanadian, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.TIVEuro, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.TIVJapanese, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.TIVMexican, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.TIVNewZealand, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.Tivus, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecPrefix, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecPrefix
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecYear, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecMonth, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecMonth
			c.CharacterMaxLength = 255
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecNumber, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecSubletter, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecSubletter
			c.CharacterMaxLength = 255
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecStatus, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.StatusDate, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecCode, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecCode
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecCategory, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecCategory
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.HazardPrimaryRecType, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.HazardPrimaryRecType
			c.CharacterMaxLength = 265
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.Hazard, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 7
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.PrimaryRecType, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.SecondaryRecType, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.RecKeyWords, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.RecKeyWords
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyBefore, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyBefore
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LossExpectancyAfter, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LossExpectancyAfter
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.CostToCompleteActual, 37, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.CostToCompleteActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.CostToComplete, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.CostToComplete
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeAustralian, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeAustralian, 40, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterAustralian, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEAfterAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterAustralian, 42, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LECostAustralian, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LECostAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostAustralian, 44, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeBritish, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeBritish, 46, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterBritish, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEAfterBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterBritish, 48, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LECostBritish, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LECostBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostBritish, 50, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeCanadian, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeCanadian, 52, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterCanadian, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEAfterCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterCanadian, 54, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LECostCanadian, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LECostCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostCanadian, 56, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeEuro, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeEuro, 58, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterEuro, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEAfterEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterEuro, 60, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LECostEuro, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LECostEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostEuro, 62, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeJapanese, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeJapanese, 64, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterJapanese, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEAfterJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterJapanese, 66, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LECostJapanese, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LECostJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostJapanese, 68, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeMexican, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeMexican, 70, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterMexican, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEAfterMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterMexican, 72, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LECostMexican, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LECostMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostMexican, 74, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeNewZealand, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeNewZealand, 76, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterNewZealand, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEAfterNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterNewZealand, 78, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LECostNewZealand, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LECostNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostNewZealand, 80, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEBeforeUS, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEBeforeUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEBeforeUS, 82, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEBeforeUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LEAfterUS, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LEAfterUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLEAfterUS, 84, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLEAfterUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.LECostUS, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.LECostUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualLECostUS, 86, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualLECostUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToComplete, 87, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteAustralian, 88, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteBritish, 89, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteCanadian, 90, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteEuro, 91, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteJapanese, 92, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteMexican, 93, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteNewZealand, 94, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ActualCostToCompleteUS, 95, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ActualCostToCompleteUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.SavingsRatio, 96, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.SavingsRatio
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.IntendedAction, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDate, 98, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ResponseFrom, 99, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ResponseFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.PlantComment, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.PlantComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, 101, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.CustomAccess, 102, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.PlantFeedback, 103, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.PlantFeedback
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.StatusDateMonth, 104, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.StatusDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.StatusDateYear, 105, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.StatusDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDateMonth, 106, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ResponseDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ResponseDateYear, 107, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ResponseDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDateMonth, 108, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireAllRecommendationsMetadata.ColumnNames.ExpectedCompletionDateYear, 109, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireAllRecommendationsMetadata.PropertyNames.ExpectedCompletionDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwFireAllRecommendationsMetadata
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
			 Public Const LEBeforeAustralian As String = "LEBeforeAustralian"
			 Public Const ActualLEBeforeAustralian As String = "ActualLEBeforeAustralian"
			 Public Const LEAfterAustralian As String = "LEAfterAustralian"
			 Public Const ActualLEAfterAustralian As String = "ActualLEAfterAustralian"
			 Public Const LECostAustralian As String = "LECostAustralian"
			 Public Const ActualLECostAustralian As String = "ActualLECostAustralian"
			 Public Const LEBeforeBritish As String = "LEBeforeBritish"
			 Public Const ActualLEBeforeBritish As String = "ActualLEBeforeBritish"
			 Public Const LEAfterBritish As String = "LEAfterBritish"
			 Public Const ActualLEAfterBritish As String = "ActualLEAfterBritish"
			 Public Const LECostBritish As String = "LECostBritish"
			 Public Const ActualLECostBritish As String = "ActualLECostBritish"
			 Public Const LEBeforeCanadian As String = "LEBeforeCanadian"
			 Public Const ActualLEBeforeCanadian As String = "ActualLEBeforeCanadian"
			 Public Const LEAfterCanadian As String = "LEAfterCanadian"
			 Public Const ActualLEAfterCanadian As String = "ActualLEAfterCanadian"
			 Public Const LECostCanadian As String = "LECostCanadian"
			 Public Const ActualLECostCanadian As String = "ActualLECostCanadian"
			 Public Const LEBeforeEuro As String = "LEBeforeEuro"
			 Public Const ActualLEBeforeEuro As String = "ActualLEBeforeEuro"
			 Public Const LEAfterEuro As String = "LEAfterEuro"
			 Public Const ActualLEAfterEuro As String = "ActualLEAfterEuro"
			 Public Const LECostEuro As String = "LECostEuro"
			 Public Const ActualLECostEuro As String = "ActualLECostEuro"
			 Public Const LEBeforeJapanese As String = "LEBeforeJapanese"
			 Public Const ActualLEBeforeJapanese As String = "ActualLEBeforeJapanese"
			 Public Const LEAfterJapanese As String = "LEAfterJapanese"
			 Public Const ActualLEAfterJapanese As String = "ActualLEAfterJapanese"
			 Public Const LECostJapanese As String = "LECostJapanese"
			 Public Const ActualLECostJapanese As String = "ActualLECostJapanese"
			 Public Const LEBeforeMexican As String = "LEBeforeMexican"
			 Public Const ActualLEBeforeMexican As String = "ActualLEBeforeMexican"
			 Public Const LEAfterMexican As String = "LEAfterMexican"
			 Public Const ActualLEAfterMexican As String = "ActualLEAfterMexican"
			 Public Const LECostMexican As String = "LECostMexican"
			 Public Const ActualLECostMexican As String = "ActualLECostMexican"
			 Public Const LEBeforeNewZealand As String = "LEBeforeNewZealand"
			 Public Const ActualLEBeforeNewZealand As String = "ActualLEBeforeNewZealand"
			 Public Const LEAfterNewZealand As String = "LEAfterNewZealand"
			 Public Const ActualLEAfterNewZealand As String = "ActualLEAfterNewZealand"
			 Public Const LECostNewZealand As String = "LECostNewZealand"
			 Public Const ActualLECostNewZealand As String = "ActualLECostNewZealand"
			 Public Const LEBeforeUS As String = "LEBeforeUS"
			 Public Const ActualLEBeforeUS As String = "ActualLEBeforeUS"
			 Public Const LEAfterUS As String = "LEAfterUS"
			 Public Const ActualLEAfterUS As String = "ActualLEAfterUS"
			 Public Const LECostUS As String = "LECostUS"
			 Public Const ActualLECostUS As String = "ActualLECostUS"
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
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const PlantFeedback As String = "PlantFeedback"
			 Public Const StatusDateMonth As String = "StatusDateMonth"
			 Public Const StatusDateYear As String = "StatusDateYear"
			 Public Const ResponseDateMonth As String = "ResponseDateMonth"
			 Public Const ResponseDateYear As String = "ResponseDateYear"
			 Public Const ExpectedCompletionDateMonth As String = "ExpectedCompletionDateMonth"
			 Public Const ExpectedCompletionDateYear As String = "ExpectedCompletionDateYear"
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
			 Public Const LEBeforeAustralian As String = "LEBeforeAustralian"
			 Public Const ActualLEBeforeAustralian As String = "ActualLEBeforeAustralian"
			 Public Const LEAfterAustralian As String = "LEAfterAustralian"
			 Public Const ActualLEAfterAustralian As String = "ActualLEAfterAustralian"
			 Public Const LECostAustralian As String = "LECostAustralian"
			 Public Const ActualLECostAustralian As String = "ActualLECostAustralian"
			 Public Const LEBeforeBritish As String = "LEBeforeBritish"
			 Public Const ActualLEBeforeBritish As String = "ActualLEBeforeBritish"
			 Public Const LEAfterBritish As String = "LEAfterBritish"
			 Public Const ActualLEAfterBritish As String = "ActualLEAfterBritish"
			 Public Const LECostBritish As String = "LECostBritish"
			 Public Const ActualLECostBritish As String = "ActualLECostBritish"
			 Public Const LEBeforeCanadian As String = "LEBeforeCanadian"
			 Public Const ActualLEBeforeCanadian As String = "ActualLEBeforeCanadian"
			 Public Const LEAfterCanadian As String = "LEAfterCanadian"
			 Public Const ActualLEAfterCanadian As String = "ActualLEAfterCanadian"
			 Public Const LECostCanadian As String = "LECostCanadian"
			 Public Const ActualLECostCanadian As String = "ActualLECostCanadian"
			 Public Const LEBeforeEuro As String = "LEBeforeEuro"
			 Public Const ActualLEBeforeEuro As String = "ActualLEBeforeEuro"
			 Public Const LEAfterEuro As String = "LEAfterEuro"
			 Public Const ActualLEAfterEuro As String = "ActualLEAfterEuro"
			 Public Const LECostEuro As String = "LECostEuro"
			 Public Const ActualLECostEuro As String = "ActualLECostEuro"
			 Public Const LEBeforeJapanese As String = "LEBeforeJapanese"
			 Public Const ActualLEBeforeJapanese As String = "ActualLEBeforeJapanese"
			 Public Const LEAfterJapanese As String = "LEAfterJapanese"
			 Public Const ActualLEAfterJapanese As String = "ActualLEAfterJapanese"
			 Public Const LECostJapanese As String = "LECostJapanese"
			 Public Const ActualLECostJapanese As String = "ActualLECostJapanese"
			 Public Const LEBeforeMexican As String = "LEBeforeMexican"
			 Public Const ActualLEBeforeMexican As String = "ActualLEBeforeMexican"
			 Public Const LEAfterMexican As String = "LEAfterMexican"
			 Public Const ActualLEAfterMexican As String = "ActualLEAfterMexican"
			 Public Const LECostMexican As String = "LECostMexican"
			 Public Const ActualLECostMexican As String = "ActualLECostMexican"
			 Public Const LEBeforeNewZealand As String = "LEBeforeNewZealand"
			 Public Const ActualLEBeforeNewZealand As String = "ActualLEBeforeNewZealand"
			 Public Const LEAfterNewZealand As String = "LEAfterNewZealand"
			 Public Const ActualLEAfterNewZealand As String = "ActualLEAfterNewZealand"
			 Public Const LECostNewZealand As String = "LECostNewZealand"
			 Public Const ActualLECostNewZealand As String = "ActualLECostNewZealand"
			 Public Const LEBeforeUS As String = "LEBeforeUS"
			 Public Const ActualLEBeforeUS As String = "ActualLEBeforeUS"
			 Public Const LEAfterUS As String = "LEAfterUS"
			 Public Const ActualLEAfterUS As String = "ActualLEAfterUS"
			 Public Const LECostUS As String = "LECostUS"
			 Public Const ActualLECostUS As String = "ActualLECostUS"
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
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const PlantFeedback As String = "PlantFeedback"
			 Public Const StatusDateMonth As String = "StatusDateMonth"
			 Public Const StatusDateYear As String = "StatusDateYear"
			 Public Const ResponseDateMonth As String = "ResponseDateMonth"
			 Public Const ResponseDateYear As String = "ResponseDateYear"
			 Public Const ExpectedCompletionDateMonth As String = "ExpectedCompletionDateMonth"
			 Public Const ExpectedCompletionDateYear As String = "ExpectedCompletionDateYear"
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
			SyncLock GetType(VwFireAllRecommendationsMetadata)
			
				If VwFireAllRecommendationsMetadata.mapDelegates Is Nothing Then
					VwFireAllRecommendationsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwFireAllRecommendationsMetadata._meta Is Nothing Then
					VwFireAllRecommendationsMetadata._meta = New VwFireAllRecommendationsMetadata()
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
				


				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
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
				meta.AddTypeMap("LEBeforeAustralian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterAustralian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostAustralian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostAustralian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeBritish", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterBritish", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostBritish", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostBritish", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeCanadian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterCanadian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostCanadian", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostCanadian", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeEuro", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterEuro", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostEuro", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostEuro", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeJapanese", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterJapanese", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostJapanese", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostJapanese", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeMexican", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterMexican", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostMexican", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostMexican", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeNewZealand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterNewZealand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostNewZealand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostNewZealand", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEBeforeUS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEBeforeUS", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LEAfterUS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLEAfterUS", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LECostUS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualLECostUS", new esTypeMap("bigint", "System.Int64"))
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
				meta.AddTypeMap("IntendedAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ResponseDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ResponseFrom", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantFeedback", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StatusDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StatusDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ResponseDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ResponseDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExpectedCompletionDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExpectedCompletionDateYear", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "vwFireAllRecommendations"
				meta.Destination = "vwFireAllRecommendations"
				
				meta.spInsert = "proc_vwFireAllRecommendationsInsert"
				meta.spUpdate = "proc_vwFireAllRecommendationsUpdate"
				meta.spDelete = "proc_vwFireAllRecommendationsDelete"
				meta.spLoadAll = "proc_vwFireAllRecommendationsLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwFireAllRecommendationsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwFireAllRecommendationsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
