
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
	' Encapsulates the 'vwBMRecommendations' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwBMRecommendations))> _
	<XmlType("VwBMRecommendations")> _	
	Partial Public Class VwBMRecommendations 
		Inherits esVwBMRecommendations
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwBMRecommendations()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwBMRecommendationsCollection")> _
	Partial Public Class VwBMRecommendationsCollection
		Inherits esVwBMRecommendationsCollection
		Implements IEnumerable(Of VwBMRecommendations)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwBMRecommendations))> _
		Public Class VwBMRecommendationsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwBMRecommendationsCollection)
			
			Public Shared Widening Operator CType(packet As VwBMRecommendationsCollectionWCFPacket) As VwBMRecommendationsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwBMRecommendationsCollection) As VwBMRecommendationsCollectionWCFPacket
				Return New VwBMRecommendationsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwBMRecommendationsQuery 
		Inherits esVwBMRecommendationsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwBMRecommendationsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwBMRecommendationsQuery) As String
			Return VwBMRecommendationsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwBMRecommendationsQuery
			Return DirectCast(VwBMRecommendationsQuery.SerializeHelper.FromXml(query, GetType(VwBMRecommendationsQuery)), VwBMRecommendationsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwBMRecommendations
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwBMRecommendations.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(VwBMRecommendationsMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(VwBMRecommendationsMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwBMRecommendationsMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwBMRecommendationsMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.TIVAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVAustralian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.TIVBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVBritish, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.TIVCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVCanadian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.TIVEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVEuro, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.TIVJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVJapanese, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.TIVMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVMexican, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.TIVNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.TIVNewZealand, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecPrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPrefix As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecPrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecPrefix, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecPrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMonth As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecMonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecMonth, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecSubletter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecSubletter As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecSubletter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecSubletter, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecSubletter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwBMRecommendationsMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwBMRecommendationsMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecCategory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategory As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecCategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecCategory, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecCategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecAction As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecAction, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.RecKeyWords
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecKeyWords As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecKeyWords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.RecKeyWords, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecKeyWords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LossExpectancyBeforeActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LossExpectancyBefore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBefore As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyBefore)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyBefore, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LossExpectancyBefore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LossExpectancyAfterActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LossExpectancyAfter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfter As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyAfter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyAfter, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LossExpectancyAfter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.CostToCompleteActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.CostToCompleteActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.CostToCompleteActual, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.CostToCompleteActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.CostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToComplete As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.CostToComplete)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.CostToComplete, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.CostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEBeforeAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeAustralian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEBeforeAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeAustralian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEBeforeAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEAfterAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterAustralian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEAfterAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterAustralian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEAfterAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLECostAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostAustralian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LECostAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostAustralian As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostAustralian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostAustralian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LECostAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEBeforeBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeBritish, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEBeforeBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeBritish As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeBritish, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEBeforeBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEAfterBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterBritish, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEAfterBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterBritish As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterBritish, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEAfterBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLECostBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostBritish, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LECostBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostBritish As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostBritish)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostBritish, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LECostBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEBeforeCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeCanadian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEBeforeCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeCanadian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEBeforeCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEAfterCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterCanadian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEAfterCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterCanadian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEAfterCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLECostCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostCanadian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LECostCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostCanadian As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostCanadian)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostCanadian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LECostCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEBeforeEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeEuro, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEBeforeEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeEuro As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeEuro, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEBeforeEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEAfterEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterEuro, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEAfterEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterEuro As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterEuro, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEAfterEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLECostEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostEuro, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LECostEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostEuro As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostEuro)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostEuro, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LECostEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEBeforeJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeJapanese, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEBeforeJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeJapanese, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEBeforeJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEAfterJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterJapanese, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEAfterJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterJapanese, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEAfterJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLECostJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostJapanese, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LECostJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostJapanese As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostJapanese)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostJapanese, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LECostJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEBeforeMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeMexican, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEBeforeMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeMexican As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeMexican, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEBeforeMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEAfterMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterMexican, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEAfterMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterMexican As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterMexican, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEAfterMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLECostMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostMexican, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LECostMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostMexican As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostMexican)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostMexican, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LECostMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEBeforeNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeNewZealand, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEBeforeNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeNewZealand, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEBeforeNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEAfterNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterNewZealand, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEAfterNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterNewZealand, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEAfterNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLECostNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostNewZealand, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LECostNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostNewZealand As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostNewZealand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostNewZealand, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LECostNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEBeforeUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEBeforeUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeUS, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEBeforeUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEBeforeUS As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEBeforeUS, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEBeforeUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLEAfterUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLEAfterUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterUS, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LEAfterUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEAfterUS As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LEAfterUS, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LEAfterUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualLECostUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualLECostUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualLECostUS, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.LECostUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LECostUS As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostUS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.LECostUS, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LECostUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ActualCostToComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ActualCostToComplete, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToCompleteAustralian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteAustralian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteAustralian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteAustralian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteAustralian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToCompleteBritish
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteBritish As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteBritish)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteBritish, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteBritish)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToCompleteCanadian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteCanadian As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteCanadian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteCanadian, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteCanadian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToCompleteEuro
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteEuro As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteEuro)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteEuro, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteEuro)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToCompleteJapanese
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteJapanese As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteJapanese)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteJapanese, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteJapanese)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToCompleteMexican
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteMexican As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteMexican)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteMexican, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteMexican)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToCompleteNewZealand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteNewZealand As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteNewZealand)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteNewZealand, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteNewZealand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ActualCostToCompleteUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToCompleteUS As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteUS)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteUS, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteUS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.SavingsRatio
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SavingsRatio As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.SavingsRatio)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.SavingsRatio, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.SavingsRatio)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwBMRecommendationsMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwBMRecommendationsMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ResponseFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseFrom As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.ResponseFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.ResponseFrom, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ResponseFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.PlantComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantComment As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.PlantComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.PlantComment, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.PlantComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ExpectedCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.PlantFeedback
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantFeedback As System.String
			Get
				Return MyBase.GetSystemString(VwBMRecommendationsMetadata.ColumnNames.PlantFeedback)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwBMRecommendationsMetadata.ColumnNames.PlantFeedback, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.PlantFeedback)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.StatusDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.StatusDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.StatusDateMonth, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.StatusDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.StatusDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.StatusDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.StatusDateYear, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.StatusDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ResponseDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ResponseDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ResponseDateMonth, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ResponseDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ResponseDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ResponseDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ResponseDateYear, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ResponseDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ExpectedCompletionDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDateMonth, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwBMRecommendations.ExpectedCompletionDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDateYear, value) Then
					OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDateYear)
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
												
						Case "RecCategory"
							Me.str().RecCategory = CType(value, string)
												
						Case "PrimaryRecType"
							Me.str().PrimaryRecType = CType(value, string)
												
						Case "SecondaryRecType"
							Me.str().SecondaryRecType = CType(value, string)
												
						Case "RecAction"
							Me.str().RecAction = CType(value, string)
												
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
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "TIVAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVAustralian)
							End If
						
						Case "TIVBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVBritish)
							End If
						
						Case "TIVCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVCanadian)
							End If
						
						Case "TIVEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVEuro)
							End If
						
						Case "TIVJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVJapanese)
							End If
						
						Case "TIVMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVMexican)
							End If
						
						Case "TIVNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TIVNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.TIVNewZealand)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.Tivus = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.Tivus)
							End If
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecYear)
							End If
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.RecNumber)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.StatusDate)
							End If
						
						Case "LossExpectancyBeforeActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyBeforeActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
							End If
						
						Case "LossExpectancyAfterActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyAfterActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
							End If
						
						Case "CostToCompleteActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.CostToCompleteActual)
							End If
						
						Case "ActualLEBeforeAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeAustralian)
							End If
						
						Case "ActualLEAfterAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterAustralian)
							End If
						
						Case "ActualLECostAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostAustralian)
							End If
						
						Case "ActualLEBeforeBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeBritish)
							End If
						
						Case "ActualLEAfterBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterBritish)
							End If
						
						Case "ActualLECostBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostBritish)
							End If
						
						Case "ActualLEBeforeCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeCanadian)
							End If
						
						Case "ActualLEAfterCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterCanadian)
							End If
						
						Case "ActualLECostCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostCanadian)
							End If
						
						Case "ActualLEBeforeEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeEuro)
							End If
						
						Case "ActualLEAfterEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterEuro)
							End If
						
						Case "ActualLECostEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostEuro)
							End If
						
						Case "ActualLEBeforeJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeJapanese)
							End If
						
						Case "ActualLEAfterJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterJapanese)
							End If
						
						Case "ActualLECostJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostJapanese)
							End If
						
						Case "ActualLEBeforeMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeMexican)
							End If
						
						Case "ActualLEAfterMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterMexican)
							End If
						
						Case "ActualLECostMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostMexican)
							End If
						
						Case "ActualLEBeforeNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeNewZealand)
							End If
						
						Case "ActualLEAfterNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterNewZealand)
							End If
						
						Case "ActualLECostNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostNewZealand)
							End If
						
						Case "ActualLEBeforeUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEBeforeUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeUS)
							End If
						
						Case "ActualLEAfterUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLEAfterUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterUS)
							End If
						
						Case "ActualLECostUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualLECostUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualLECostUS)
							End If
						
						Case "ActualCostToComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ActualCostToComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToComplete)
							End If
						
						Case "ActualCostToCompleteAustralian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteAustralian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteAustralian)
							End If
						
						Case "ActualCostToCompleteBritish"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteBritish = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteBritish)
							End If
						
						Case "ActualCostToCompleteCanadian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteCanadian = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteCanadian)
							End If
						
						Case "ActualCostToCompleteEuro"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteEuro = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteEuro)
							End If
						
						Case "ActualCostToCompleteJapanese"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteJapanese = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteJapanese)
							End If
						
						Case "ActualCostToCompleteMexican"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteMexican = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteMexican)
							End If
						
						Case "ActualCostToCompleteNewZealand"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteNewZealand = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteNewZealand)
							End If
						
						Case "ActualCostToCompleteUS"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.ActualCostToCompleteUS = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteUS)
							End If
						
						Case "SavingsRatio"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SavingsRatio = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.SavingsRatio)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "ExpectedCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDate)
							End If
						
						Case "StatusDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.StatusDateMonth)
							End If
						
						Case "StatusDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.StatusDateYear)
							End If
						
						Case "ResponseDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ResponseDateMonth)
							End If
						
						Case "ResponseDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ResponseDateYear)
							End If
						
						Case "ExpectedCompletionDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDateMonth)
							End If
						
						Case "ExpectedCompletionDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDateYear)
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
		
			Public Sub New(ByVal entity As esVwBMRecommendations)
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
		  	
			Public Property RecAction As System.String 
				Get
					Dim data_ As System.String = entity.RecAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecAction = Nothing
					Else
						entity.RecAction = Convert.ToString(Value)
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
		  

			Private entity As esVwBMRecommendations
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwBMRecommendationsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwBMRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwBMRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwBMRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwBMRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwBMRecommendationsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwBMRecommendationsCollection
		Inherits esEntityCollection(Of VwBMRecommendations)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwBMRecommendationsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwBMRecommendationsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwBMRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwBMRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwBMRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwBMRecommendationsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwBMRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwBMRecommendationsQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwBMRecommendationsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwBMRecommendationsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwBMRecommendationsMetadata.Meta()
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
				Case "RecCategory" 
					Return Me.RecCategory
				Case "PrimaryRecType" 
					Return Me.PrimaryRecType
				Case "SecondaryRecType" 
					Return Me.SecondaryRecType
				Case "RecAction" 
					Return Me.RecAction
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
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.TIVAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.TIVBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.TIVCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.TIVEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.TIVJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.TIVMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TIVNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.TIVNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.Tivus, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property RecPrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecPrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecMonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecSubletter As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecSubletter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategory As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecCategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecAction As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecKeyWords As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.RecKeyWords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBefore As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LossExpectancyBefore, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfter As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LossExpectancyAfter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.CostToCompleteActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.CostToComplete, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEBeforeAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEAfterAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLECostAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LECostAustralian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEBeforeBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEAfterBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLECostBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LECostBritish, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEBeforeCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEAfterCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLECostCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LECostCanadian, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEBeforeEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEAfterEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLECostEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LECostEuro, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEBeforeJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEAfterJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLECostJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LECostJapanese, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEBeforeMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEAfterMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLECostMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LECostMexican, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEBeforeNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEAfterNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLECostNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LECostNewZealand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEBeforeUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEBeforeUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEBeforeUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLEAfterUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LEAfterUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LEAfterUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualLECostUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualLECostUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LECostUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.LECostUS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteAustralian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteAustralian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteBritish As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteBritish, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteCanadian As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteCanadian, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteEuro As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteEuro, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteJapanese As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteJapanese, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteMexican As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteMexican, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteNewZealand As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteNewZealand, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToCompleteUS As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteUS, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property SavingsRatio As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.SavingsRatio, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseFrom As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ResponseFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantComment As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.PlantComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantFeedback As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.PlantFeedback, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.StatusDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.StatusDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ResponseDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ResponseDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDateYear, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwBMRecommendationsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.FilePrefix, 0, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.Facility, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.Address, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.City, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.StProv, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.Country, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames._100PercentUSTot, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.TIVAustralian, 11, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.TIVAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.TIVBritish, 12, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.TIVBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.TIVCanadian, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.TIVCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.TIVEuro, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.TIVEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.TIVJapanese, 15, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.TIVJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.TIVMexican, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.TIVMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.TIVNewZealand, 17, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.TIVNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.Tivus, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.Tivus
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecPrefix, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecPrefix
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecYear, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecMonth, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecMonth
			c.CharacterMaxLength = 255
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecNumber, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecSubletter, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecSubletter
			c.CharacterMaxLength = 255
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecStatus, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.StatusDate, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecCategory, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecCategory
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.PrimaryRecType, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.SecondaryRecType, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecAction, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecAction
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.RecKeyWords, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.RecKeyWords
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyBefore, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LossExpectancyBefore
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LossExpectancyAfter, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LossExpectancyAfter
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.CostToCompleteActual, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.CostToCompleteActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.CostToComplete, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.CostToComplete
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeAustralian, 37, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEBeforeAustralian, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEBeforeAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterAustralian, 39, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEAfterAustralian, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEAfterAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLECostAustralian, 41, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLECostAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LECostAustralian, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LECostAustralian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeBritish, 43, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEBeforeBritish, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEBeforeBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterBritish, 45, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEAfterBritish, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEAfterBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLECostBritish, 47, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLECostBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LECostBritish, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LECostBritish
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeCanadian, 49, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEBeforeCanadian, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEBeforeCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterCanadian, 51, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEAfterCanadian, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEAfterCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLECostCanadian, 53, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLECostCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LECostCanadian, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LECostCanadian
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeEuro, 55, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEBeforeEuro, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEBeforeEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterEuro, 57, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEAfterEuro, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEAfterEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLECostEuro, 59, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLECostEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LECostEuro, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LECostEuro
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeJapanese, 61, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEBeforeJapanese, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEBeforeJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterJapanese, 63, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEAfterJapanese, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEAfterJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLECostJapanese, 65, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLECostJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LECostJapanese, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LECostJapanese
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeMexican, 67, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEBeforeMexican, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEBeforeMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterMexican, 69, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEAfterMexican, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEAfterMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLECostMexican, 71, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLECostMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LECostMexican, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LECostMexican
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeNewZealand, 73, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEBeforeNewZealand, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEBeforeNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterNewZealand, 75, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEAfterNewZealand, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEAfterNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLECostNewZealand, 77, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLECostNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LECostNewZealand, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LECostNewZealand
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEBeforeUS, 79, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEBeforeUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEBeforeUS, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEBeforeUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLEAfterUS, 81, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLEAfterUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LEAfterUS, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LEAfterUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualLECostUS, 83, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualLECostUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.LECostUS, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.LECostUS
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToComplete, 85, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteAustralian, 86, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteAustralian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteBritish, 87, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteBritish
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteCanadian, 88, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteCanadian
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteEuro, 89, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteEuro
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteJapanese, 90, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteJapanese
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteMexican, 91, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteMexican
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteNewZealand, 92, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteNewZealand
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ActualCostToCompleteUS, 93, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ActualCostToCompleteUS
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.SavingsRatio, 94, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.SavingsRatio
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.IntendedAction, 95, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ResponseDate, 96, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ResponseFrom, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ResponseFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.PlantComment, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.PlantComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, 99, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.CustomAccess, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.PlantFeedback, 101, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.PlantFeedback
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.StatusDateMonth, 102, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.StatusDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.StatusDateYear, 103, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.StatusDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ResponseDateMonth, 104, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ResponseDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ResponseDateYear, 105, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ResponseDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDateMonth, 106, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwBMRecommendationsMetadata.ColumnNames.ExpectedCompletionDateYear, 107, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwBMRecommendationsMetadata.PropertyNames.ExpectedCompletionDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwBMRecommendationsMetadata
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
			 Public Const RecCategory As String = "RecCategory"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecAction As String = "RecAction"
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
			 Public Const RecCategory As String = "RecCategory"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecAction As String = "RecAction"
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
			SyncLock GetType(VwBMRecommendationsMetadata)
			
				If VwBMRecommendationsMetadata.mapDelegates Is Nothing Then
					VwBMRecommendationsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwBMRecommendationsMetadata._meta Is Nothing Then
					VwBMRecommendationsMetadata._meta = New VwBMRecommendationsMetadata()
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
				meta.AddTypeMap("RecCategory", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PrimaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SecondaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecAction", new esTypeMap("nvarchar", "System.String"))
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
				
				
				 
				meta.Source = "vwBMRecommendations"
				meta.Destination = "vwBMRecommendations"
				
				meta.spInsert = "proc_vwBMRecommendationsInsert"
				meta.spUpdate = "proc_vwBMRecommendationsUpdate"
				meta.spDelete = "proc_vwBMRecommendationsDelete"
				meta.spLoadAll = "proc_vwBMRecommendationsLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwBMRecommendationsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwBMRecommendationsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
