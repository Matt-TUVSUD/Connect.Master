
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/8/2019 2:51:45 PM
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
	' Encapsulates the 'vwFireRecommendationsBaseView' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(VwFireRecommendationsBaseView))> _
	<XmlType("VwFireRecommendationsBaseView")> _	
	Partial Public Class VwFireRecommendationsBaseView 
		Inherits esVwFireRecommendationsBaseView
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New VwFireRecommendationsBaseView()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("VwFireRecommendationsBaseViewCollection")> _
	Partial Public Class VwFireRecommendationsBaseViewCollection
		Inherits esVwFireRecommendationsBaseViewCollection
		Implements IEnumerable(Of VwFireRecommendationsBaseView)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(VwFireRecommendationsBaseView))> _
		Public Class VwFireRecommendationsBaseViewCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of VwFireRecommendationsBaseViewCollection)
			
			Public Shared Widening Operator CType(packet As VwFireRecommendationsBaseViewCollectionWCFPacket) As VwFireRecommendationsBaseViewCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As VwFireRecommendationsBaseViewCollection) As VwFireRecommendationsBaseViewCollectionWCFPacket
				Return New VwFireRecommendationsBaseViewCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class VwFireRecommendationsBaseViewQuery 
		Inherits esVwFireRecommendationsBaseViewQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "VwFireRecommendationsBaseViewQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As VwFireRecommendationsBaseViewQuery) As String
			Return VwFireRecommendationsBaseViewQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As VwFireRecommendationsBaseViewQuery
			Return DirectCast(VwFireRecommendationsBaseViewQuery.SerializeHelper.FromXml(query, GetType(VwFireRecommendationsBaseViewQuery)), VwFireRecommendationsBaseViewQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esVwFireRecommendationsBaseView
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.TIVUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivus As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireRecommendationsBaseViewMetadata.ColumnNames.Tivus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireRecommendationsBaseViewMetadata.ColumnNames.Tivus, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Tivus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.StProvName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProvName As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.StProvName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.StProvName, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StProvName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.AddressStamp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AddressStamp As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.AddressStamp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.AddressStamp, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.AddressStamp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecUniqueID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecUniqueID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecUniqueID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecUniqueID, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecUniqueID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMonth As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecMonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecSubletter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecSubletter As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecSubletter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecSubletter, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecSubletter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNo As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecNo, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecCategory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategory As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCategory, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecCategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCode As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCode, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecKeyWords
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecKeyWords As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecKeyWords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecKeyWords, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecKeyWords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.BriefExplanationOfRec
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BriefExplanationOfRec As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.BriefExplanationOfRec)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.BriefExplanationOfRec, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.BriefExplanationOfRec)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.LossExpectancyBefore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBefore As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBefore)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBefore, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyBefore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.LossExpectancyAfter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfter As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfter, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyAfter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.CostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToComplete As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToComplete)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToComplete, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.CostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.SavingsRatio
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SavingsRatio As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(VwFireRecommendationsBaseViewMetadata.ColumnNames.SavingsRatio)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(VwFireRecommendationsBaseViewMetadata.ColumnNames.SavingsRatio, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.SavingsRatio)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ResponseFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseFrom As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseFrom, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.PlantComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantComment As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.PlantComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.PlantComment, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.PlantComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ExpectedCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDate, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.LossExpectancyBeforeActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBeforeActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBeforeActual, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyBeforeActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.LossExpectancyAfterActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfterActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfterActual, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyAfterActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.CostToCompleteActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToCompleteActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToCompleteActual, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.CostToCompleteActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ActualCostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ActualCostToComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ActualCostToComplete, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ActualCostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.MgmtRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespDate, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.MgmtRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespFrom As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespFrom, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.MgmtRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespAction As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespAction, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.MgmtRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespComment As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespComment, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecPriority
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPriority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecPriority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecPriority, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecPriority)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RatingCatWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCatWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCatWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCatWeight, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingCatWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RatingCat
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCat As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCat)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCat, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingCat)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RatingPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingPts, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ResponseStatusFlag
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatusFlag As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatusFlag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatusFlag, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseStatusFlag)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RespRequestDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDate, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RespDueDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDate, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.DaysOverdue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DaysOverdue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.DaysOverdue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.DaysOverdue, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.DaysOverdue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU1Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1Date, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU2Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2Date, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU3Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3Date, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientName As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecipientName, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecipientEmail, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.AutoRequest
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AutoRequest As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.AutoRequest)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.AutoRequest, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.AutoRequest)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RespRequestDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RespRequestDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RespDueDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RespDueDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ResponseDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ResponseDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU1DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU1DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU2DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU2DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU3DateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3DateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU3DateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3DateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ExpectedCompletionDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ExpectedCompletionDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.StatusDateMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateMonth, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDateMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.StatusDateYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateYear, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDateYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RespRequestDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespRequestDateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateString, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RespDueDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDueDateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateString, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ResponseDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateString, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU1DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1DateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateString, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU2DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2DateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateString, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RFU3DateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3DateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateString, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3DateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ExpectedCompletionDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateString, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.StatusDateString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateString As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateString, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDateString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ExchangeRateGroupID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRateGroupID As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExchangeRateGroupID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExchangeRateGroupID, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExchangeRateGroupID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ResponseStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatus As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatus, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RatingScoreChange
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingScoreChange As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingScoreChange)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingScoreChange, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingScoreChange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RatingCatPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCatPts As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCatPts)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCatPts, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingCatPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.RecCategoryColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategoryColor As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCategoryColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCategoryColor, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecCategoryColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ExpectedCompletionDateColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDateColor As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateColor, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ResponseStatusColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatusColor As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatusColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatusColor, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseStatusColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.LossExpectancyBeforeMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBeforeMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBeforeMedian, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyBeforeMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.LossExpectancyAfterMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfterMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfterMedian, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyAfterMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.CostToCompleteMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToCompleteMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToCompleteMedian, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.CostToCompleteMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ThirdLevelRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespAction As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespAction, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ThirdLevelRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespComment As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespComment, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ThirdLevelRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespDate, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to vwFireRecommendationsBaseView.ThirdLevelRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespFrom As System.String
			Get
				Return MyBase.GetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespFrom, value) Then
					OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespFrom)
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
												
						Case "AddressStamp"
							Me.str().AddressStamp = CType(value, string)
												
						Case "RecUniqueID"
							Me.str().RecUniqueID = CType(value, string)
												
						Case "RecYear"
							Me.str().RecYear = CType(value, string)
												
						Case "RecMonth"
							Me.str().RecMonth = CType(value, string)
												
						Case "RecNumber"
							Me.str().RecNumber = CType(value, string)
												
						Case "RecSubletter"
							Me.str().RecSubletter = CType(value, string)
												
						Case "RecNo"
							Me.str().RecNo = CType(value, string)
												
						Case "RecCategory"
							Me.str().RecCategory = CType(value, string)
												
						Case "RecStatus"
							Me.str().RecStatus = CType(value, string)
												
						Case "StatusDate"
							Me.str().StatusDate = CType(value, string)
												
						Case "RecCode"
							Me.str().RecCode = CType(value, string)
												
						Case "PrimaryRecType"
							Me.str().PrimaryRecType = CType(value, string)
												
						Case "SecondaryRecType"
							Me.str().SecondaryRecType = CType(value, string)
												
						Case "RecKeyWords"
							Me.str().RecKeyWords = CType(value, string)
												
						Case "BriefExplanationOfRec"
							Me.str().BriefExplanationOfRec = CType(value, string)
												
						Case "LossExpectancyBefore"
							Me.str().LossExpectancyBefore = CType(value, string)
												
						Case "LossExpectancyAfter"
							Me.str().LossExpectancyAfter = CType(value, string)
												
						Case "CostToComplete"
							Me.str().CostToComplete = CType(value, string)
												
						Case "SavingsRatio"
							Me.str().SavingsRatio = CType(value, string)
												
						Case "ResponseDate"
							Me.str().ResponseDate = CType(value, string)
												
						Case "ResponseFrom"
							Me.str().ResponseFrom = CType(value, string)
												
						Case "PlantComment"
							Me.str().PlantComment = CType(value, string)
												
						Case "ExpectedCompletionDate"
							Me.str().ExpectedCompletionDate = CType(value, string)
												
						Case "IntendedAction"
							Me.str().IntendedAction = CType(value, string)
												
						Case "LossExpectancyBeforeActual"
							Me.str().LossExpectancyBeforeActual = CType(value, string)
												
						Case "LossExpectancyAfterActual"
							Me.str().LossExpectancyAfterActual = CType(value, string)
												
						Case "CostToCompleteActual"
							Me.str().CostToCompleteActual = CType(value, string)
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "ActualCostToComplete"
							Me.str().ActualCostToComplete = CType(value, string)
												
						Case "MgmtRespDate"
							Me.str().MgmtRespDate = CType(value, string)
												
						Case "MgmtRespFrom"
							Me.str().MgmtRespFrom = CType(value, string)
												
						Case "MgmtRespAction"
							Me.str().MgmtRespAction = CType(value, string)
												
						Case "MgmtRespComment"
							Me.str().MgmtRespComment = CType(value, string)
												
						Case "RecPriority"
							Me.str().RecPriority = CType(value, string)
												
						Case "RatingCatWeight"
							Me.str().RatingCatWeight = CType(value, string)
												
						Case "RatingCat"
							Me.str().RatingCat = CType(value, string)
												
						Case "RatingPts"
							Me.str().RatingPts = CType(value, string)
												
						Case "ResponseStatusFlag"
							Me.str().ResponseStatusFlag = CType(value, string)
												
						Case "RespRequestDate"
							Me.str().RespRequestDate = CType(value, string)
												
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
												
						Case "RecipientName"
							Me.str().RecipientName = CType(value, string)
												
						Case "RecipientEmail"
							Me.str().RecipientEmail = CType(value, string)
												
						Case "AutoRequest"
							Me.str().AutoRequest = CType(value, string)
												
						Case "RespRequestDateMonth"
							Me.str().RespRequestDateMonth = CType(value, string)
												
						Case "RespRequestDateYear"
							Me.str().RespRequestDateYear = CType(value, string)
												
						Case "RespDueDateMonth"
							Me.str().RespDueDateMonth = CType(value, string)
												
						Case "RespDueDateYear"
							Me.str().RespDueDateYear = CType(value, string)
												
						Case "ResponseDateMonth"
							Me.str().ResponseDateMonth = CType(value, string)
												
						Case "ResponseDateYear"
							Me.str().ResponseDateYear = CType(value, string)
												
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
												
						Case "ExpectedCompletionDateMonth"
							Me.str().ExpectedCompletionDateMonth = CType(value, string)
												
						Case "ExpectedCompletionDateYear"
							Me.str().ExpectedCompletionDateYear = CType(value, string)
												
						Case "StatusDateMonth"
							Me.str().StatusDateMonth = CType(value, string)
												
						Case "StatusDateYear"
							Me.str().StatusDateYear = CType(value, string)
												
						Case "RespRequestDateString"
							Me.str().RespRequestDateString = CType(value, string)
												
						Case "RespDueDateString"
							Me.str().RespDueDateString = CType(value, string)
												
						Case "ResponseDateString"
							Me.str().ResponseDateString = CType(value, string)
												
						Case "RFU1DateString"
							Me.str().RFU1DateString = CType(value, string)
												
						Case "RFU2DateString"
							Me.str().RFU2DateString = CType(value, string)
												
						Case "RFU3DateString"
							Me.str().RFU3DateString = CType(value, string)
												
						Case "ExpectedCompletionDateString"
							Me.str().ExpectedCompletionDateString = CType(value, string)
												
						Case "StatusDateString"
							Me.str().StatusDateString = CType(value, string)
												
						Case "ExchangeRateGroupID"
							Me.str().ExchangeRateGroupID = CType(value, string)
												
						Case "ResponseStatus"
							Me.str().ResponseStatus = CType(value, string)
												
						Case "RatingScoreChange"
							Me.str().RatingScoreChange = CType(value, string)
												
						Case "RatingCatPts"
							Me.str().RatingCatPts = CType(value, string)
												
						Case "RecCategoryColor"
							Me.str().RecCategoryColor = CType(value, string)
												
						Case "ExpectedCompletionDateColor"
							Me.str().ExpectedCompletionDateColor = CType(value, string)
												
						Case "ResponseStatusColor"
							Me.str().ResponseStatusColor = CType(value, string)
												
						Case "LossExpectancyBeforeMedian"
							Me.str().LossExpectancyBeforeMedian = CType(value, string)
												
						Case "LossExpectancyAfterMedian"
							Me.str().LossExpectancyAfterMedian = CType(value, string)
												
						Case "CostToCompleteMedian"
							Me.str().CostToCompleteMedian = CType(value, string)
												
						Case "ThirdLevelRespAction"
							Me.str().ThirdLevelRespAction = CType(value, string)
												
						Case "ThirdLevelRespComment"
							Me.str().ThirdLevelRespComment = CType(value, string)
												
						Case "ThirdLevelRespDate"
							Me.str().ThirdLevelRespDate = CType(value, string)
												
						Case "ThirdLevelRespFrom"
							Me.str().ThirdLevelRespFrom = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Longitude)
							End If
						
						Case "Tivus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Tivus = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.Tivus)
							End If
						
						Case "RecUniqueID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecUniqueID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecUniqueID)
							End If
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecYear)
							End If
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecNumber)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDate)
							End If
						
						Case "SavingsRatio"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.SavingsRatio = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.SavingsRatio)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "ExpectedCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDate)
							End If
						
						Case "LossExpectancyBeforeActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyBeforeActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyBeforeActual)
							End If
						
						Case "LossExpectancyAfterActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyAfterActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyAfterActual)
							End If
						
						Case "CostToCompleteActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.CostToCompleteActual)
							End If
						
						Case "ActualCostToComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ActualCostToComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ActualCostToComplete)
							End If
						
						Case "MgmtRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.MgmtRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespDate)
							End If
						
						Case "RecPriority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecPriority = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RecPriority)
							End If
						
						Case "RatingCatWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingCatWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingCatWeight)
							End If
						
						Case "RatingPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingPts)
							End If
						
						Case "ResponseStatusFlag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseStatusFlag = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseStatusFlag)
							End If
						
						Case "RespRequestDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespRequestDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDate)
							End If
						
						Case "RespDueDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespDueDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDate)
							End If
						
						Case "DaysOverdue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DaysOverdue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.DaysOverdue)
							End If
						
						Case "RFU1Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU1Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1Date)
							End If
						
						Case "RFU2Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU2Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2Date)
							End If
						
						Case "RFU3Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU3Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3Date)
							End If
						
						Case "RespRequestDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDateMonth)
							End If
						
						Case "RespRequestDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespRequestDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDateYear)
							End If
						
						Case "RespDueDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDateMonth)
							End If
						
						Case "RespDueDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RespDueDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDateYear)
							End If
						
						Case "ResponseDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDateMonth)
							End If
						
						Case "ResponseDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ResponseDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDateYear)
							End If
						
						Case "RFU1DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1DateMonth)
							End If
						
						Case "RFU1DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU1DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1DateYear)
							End If
						
						Case "RFU2DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2DateMonth)
							End If
						
						Case "RFU2DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU2DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2DateYear)
							End If
						
						Case "RFU3DateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3DateMonth)
							End If
						
						Case "RFU3DateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RFU3DateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3DateYear)
							End If
						
						Case "ExpectedCompletionDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateMonth)
							End If
						
						Case "ExpectedCompletionDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ExpectedCompletionDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateYear)
							End If
						
						Case "StatusDateMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDateMonth)
							End If
						
						Case "StatusDateYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDateYear)
							End If
						
						Case "ExchangeRateGroupID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.ExchangeRateGroupID = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ExchangeRateGroupID)
							End If
						
						Case "RatingScoreChange"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingScoreChange = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingScoreChange)
							End If
						
						Case "LossExpectancyBeforeMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyBeforeMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyBeforeMedian)
							End If
						
						Case "LossExpectancyAfterMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyAfterMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyAfterMedian)
							End If
						
						Case "CostToCompleteMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.CostToCompleteMedian)
							End If
						
						Case "ThirdLevelRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ThirdLevelRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespDate)
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
		
			Public Sub New(ByVal entity As esVwFireRecommendationsBaseView)
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
		  	
			Public Property AddressStamp As System.String 
				Get
					Dim data_ As System.String = entity.AddressStamp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AddressStamp = Nothing
					Else
						entity.AddressStamp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecUniqueID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecUniqueID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecUniqueID = Nothing
					Else
						entity.RecUniqueID = Convert.ToInt32(Value)
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
		  	
			Public Property RecNo As System.String 
				Get
					Dim data_ As System.String = entity.RecNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecNo = Nothing
					Else
						entity.RecNo = Convert.ToString(Value)
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
		  	
			Public Property BriefExplanationOfRec As System.String 
				Get
					Dim data_ As System.String = entity.BriefExplanationOfRec
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BriefExplanationOfRec = Nothing
					Else
						entity.BriefExplanationOfRec = Convert.ToString(Value)
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
		  	
			Public Property SavingsRatio As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.SavingsRatio
					
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
						entity.SavingsRatio = Convert.ToDouble(Value)
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
		  	
			Public Property MgmtRespDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.MgmtRespDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespDate = Nothing
					Else
						entity.MgmtRespDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtRespFrom As System.String 
				Get
					Dim data_ As System.String = entity.MgmtRespFrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespFrom = Nothing
					Else
						entity.MgmtRespFrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtRespAction As System.String 
				Get
					Dim data_ As System.String = entity.MgmtRespAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespAction = Nothing
					Else
						entity.MgmtRespAction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtRespComment As System.String 
				Get
					Dim data_ As System.String = entity.MgmtRespComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespComment = Nothing
					Else
						entity.MgmtRespComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecPriority As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecPriority
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecPriority = Nothing
					Else
						entity.RecPriority = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingCatWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingCatWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingCatWeight = Nothing
					Else
						entity.RatingCatWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingCat As System.String 
				Get
					Dim data_ As System.String = entity.RatingCat
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingCat = Nothing
					Else
						entity.RatingCat = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingPts As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingPts
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingPts = Nothing
					Else
						entity.RatingPts = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponseStatusFlag As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ResponseStatusFlag
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseStatusFlag = Nothing
					Else
						entity.ResponseStatusFlag = Convert.ToInt32(Value)
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
		  	
			Public Property ResponseDateString As System.String 
				Get
					Dim data_ As System.String = entity.ResponseDateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseDateString = Nothing
					Else
						entity.ResponseDateString = Convert.ToString(Value)
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
		  	
			Public Property ExpectedCompletionDateString As System.String 
				Get
					Dim data_ As System.String = entity.ExpectedCompletionDateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpectedCompletionDateString = Nothing
					Else
						entity.ExpectedCompletionDateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StatusDateString As System.String 
				Get
					Dim data_ As System.String = entity.StatusDateString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StatusDateString = Nothing
					Else
						entity.StatusDateString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExchangeRateGroupID As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.ExchangeRateGroupID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExchangeRateGroupID = Nothing
					Else
						entity.ExchangeRateGroupID = Convert.ToByte(Value)
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
		  	
			Public Property RatingScoreChange As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingScoreChange
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingScoreChange = Nothing
					Else
						entity.RatingScoreChange = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingCatPts As System.String 
				Get
					Dim data_ As System.String = entity.RatingCatPts
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingCatPts = Nothing
					Else
						entity.RatingCatPts = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecCategoryColor As System.String 
				Get
					Dim data_ As System.String = entity.RecCategoryColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCategoryColor = Nothing
					Else
						entity.RecCategoryColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExpectedCompletionDateColor As System.String 
				Get
					Dim data_ As System.String = entity.ExpectedCompletionDateColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpectedCompletionDateColor = Nothing
					Else
						entity.ExpectedCompletionDateColor = Convert.ToString(Value)
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
		  	
			Public Property LossExpectancyBeforeMedian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LossExpectancyBeforeMedian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyBeforeMedian = Nothing
					Else
						entity.LossExpectancyBeforeMedian = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyAfterMedian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LossExpectancyAfterMedian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyAfterMedian = Nothing
					Else
						entity.LossExpectancyAfterMedian = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CostToCompleteMedian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CostToCompleteMedian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CostToCompleteMedian = Nothing
					Else
						entity.CostToCompleteMedian = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespAction As System.String 
				Get
					Dim data_ As System.String = entity.ThirdLevelRespAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespAction = Nothing
					Else
						entity.ThirdLevelRespAction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespComment As System.String 
				Get
					Dim data_ As System.String = entity.ThirdLevelRespComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespComment = Nothing
					Else
						entity.ThirdLevelRespComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ThirdLevelRespDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespDate = Nothing
					Else
						entity.ThirdLevelRespDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespFrom As System.String 
				Get
					Dim data_ As System.String = entity.ThirdLevelRespFrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespFrom = Nothing
					Else
						entity.ThirdLevelRespFrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esVwFireRecommendationsBaseView
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireRecommendationsBaseViewMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As VwFireRecommendationsBaseViewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireRecommendationsBaseViewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As VwFireRecommendationsBaseViewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As VwFireRecommendationsBaseViewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As VwFireRecommendationsBaseViewQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esVwFireRecommendationsBaseViewCollection
		Inherits esEntityCollection(Of VwFireRecommendationsBaseView)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return VwFireRecommendationsBaseViewMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "VwFireRecommendationsBaseViewCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As VwFireRecommendationsBaseViewQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New VwFireRecommendationsBaseViewQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As VwFireRecommendationsBaseViewQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New VwFireRecommendationsBaseViewQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As VwFireRecommendationsBaseViewQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, VwFireRecommendationsBaseViewQuery))
		End Sub
		
		#End Region
						
		Private m_query As VwFireRecommendationsBaseViewQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esVwFireRecommendationsBaseViewQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return VwFireRecommendationsBaseViewMetadata.Meta()
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
				Case "AddressStamp" 
					Return Me.AddressStamp
				Case "RecUniqueID" 
					Return Me.RecUniqueID
				Case "RecYear" 
					Return Me.RecYear
				Case "RecMonth" 
					Return Me.RecMonth
				Case "RecNumber" 
					Return Me.RecNumber
				Case "RecSubletter" 
					Return Me.RecSubletter
				Case "RecNo" 
					Return Me.RecNo
				Case "RecCategory" 
					Return Me.RecCategory
				Case "RecStatus" 
					Return Me.RecStatus
				Case "StatusDate" 
					Return Me.StatusDate
				Case "RecCode" 
					Return Me.RecCode
				Case "PrimaryRecType" 
					Return Me.PrimaryRecType
				Case "SecondaryRecType" 
					Return Me.SecondaryRecType
				Case "RecKeyWords" 
					Return Me.RecKeyWords
				Case "BriefExplanationOfRec" 
					Return Me.BriefExplanationOfRec
				Case "LossExpectancyBefore" 
					Return Me.LossExpectancyBefore
				Case "LossExpectancyAfter" 
					Return Me.LossExpectancyAfter
				Case "CostToComplete" 
					Return Me.CostToComplete
				Case "SavingsRatio" 
					Return Me.SavingsRatio
				Case "ResponseDate" 
					Return Me.ResponseDate
				Case "ResponseFrom" 
					Return Me.ResponseFrom
				Case "PlantComment" 
					Return Me.PlantComment
				Case "ExpectedCompletionDate" 
					Return Me.ExpectedCompletionDate
				Case "IntendedAction" 
					Return Me.IntendedAction
				Case "LossExpectancyBeforeActual" 
					Return Me.LossExpectancyBeforeActual
				Case "LossExpectancyAfterActual" 
					Return Me.LossExpectancyAfterActual
				Case "CostToCompleteActual" 
					Return Me.CostToCompleteActual
				Case "Hazard" 
					Return Me.Hazard
				Case "ActualCostToComplete" 
					Return Me.ActualCostToComplete
				Case "MgmtRespDate" 
					Return Me.MgmtRespDate
				Case "MgmtRespFrom" 
					Return Me.MgmtRespFrom
				Case "MgmtRespAction" 
					Return Me.MgmtRespAction
				Case "MgmtRespComment" 
					Return Me.MgmtRespComment
				Case "RecPriority" 
					Return Me.RecPriority
				Case "RatingCatWeight" 
					Return Me.RatingCatWeight
				Case "RatingCat" 
					Return Me.RatingCat
				Case "RatingPts" 
					Return Me.RatingPts
				Case "ResponseStatusFlag" 
					Return Me.ResponseStatusFlag
				Case "RespRequestDate" 
					Return Me.RespRequestDate
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
				Case "RecipientName" 
					Return Me.RecipientName
				Case "RecipientEmail" 
					Return Me.RecipientEmail
				Case "AutoRequest" 
					Return Me.AutoRequest
				Case "RespRequestDateMonth" 
					Return Me.RespRequestDateMonth
				Case "RespRequestDateYear" 
					Return Me.RespRequestDateYear
				Case "RespDueDateMonth" 
					Return Me.RespDueDateMonth
				Case "RespDueDateYear" 
					Return Me.RespDueDateYear
				Case "ResponseDateMonth" 
					Return Me.ResponseDateMonth
				Case "ResponseDateYear" 
					Return Me.ResponseDateYear
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
				Case "ExpectedCompletionDateMonth" 
					Return Me.ExpectedCompletionDateMonth
				Case "ExpectedCompletionDateYear" 
					Return Me.ExpectedCompletionDateYear
				Case "StatusDateMonth" 
					Return Me.StatusDateMonth
				Case "StatusDateYear" 
					Return Me.StatusDateYear
				Case "RespRequestDateString" 
					Return Me.RespRequestDateString
				Case "RespDueDateString" 
					Return Me.RespDueDateString
				Case "ResponseDateString" 
					Return Me.ResponseDateString
				Case "RFU1DateString" 
					Return Me.RFU1DateString
				Case "RFU2DateString" 
					Return Me.RFU2DateString
				Case "RFU3DateString" 
					Return Me.RFU3DateString
				Case "ExpectedCompletionDateString" 
					Return Me.ExpectedCompletionDateString
				Case "StatusDateString" 
					Return Me.StatusDateString
				Case "ExchangeRateGroupID" 
					Return Me.ExchangeRateGroupID
				Case "ResponseStatus" 
					Return Me.ResponseStatus
				Case "RatingScoreChange" 
					Return Me.RatingScoreChange
				Case "RatingCatPts" 
					Return Me.RatingCatPts
				Case "RecCategoryColor" 
					Return Me.RecCategoryColor
				Case "ExpectedCompletionDateColor" 
					Return Me.ExpectedCompletionDateColor
				Case "ResponseStatusColor" 
					Return Me.ResponseStatusColor
				Case "LossExpectancyBeforeMedian" 
					Return Me.LossExpectancyBeforeMedian
				Case "LossExpectancyAfterMedian" 
					Return Me.LossExpectancyAfterMedian
				Case "CostToCompleteMedian" 
					Return Me.CostToCompleteMedian
				Case "ThirdLevelRespAction" 
					Return Me.ThirdLevelRespAction
				Case "ThirdLevelRespComment" 
					Return Me.ThirdLevelRespComment
				Case "ThirdLevelRespDate" 
					Return Me.ThirdLevelRespDate
				Case "ThirdLevelRespFrom" 
					Return Me.ThirdLevelRespFrom
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Tivus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Tivus, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property StProvName As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.StProvName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AddressStamp As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.AddressStamp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecUniqueID As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecUniqueID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecMonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecSubletter As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecSubletter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNo As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategory As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecCode As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecKeyWords As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecKeyWords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BriefExplanationOfRec As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.BriefExplanationOfRec, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBefore As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBefore, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfter As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToComplete, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SavingsRatio As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.SavingsRatio, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseFrom As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantComment As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.PlantComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBeforeActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfterActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteActual As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToCompleteActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ActualCostToComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecPriority As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecPriority, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCatWeight As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCatWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCat As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCat, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingPts As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatusFlag As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatusFlag, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DaysOverdue As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.DaysOverdue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3Date As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AutoRequest As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.AutoRequest, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateMonth As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateYear As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RespRequestDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespDueDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3DateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateString As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRateGroupID As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ExchangeRateGroupID, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatus As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingScoreChange As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingScoreChange, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCatPts As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCatPts, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategoryColor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCategoryColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDateColor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatusColor As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatusColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeMedian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBeforeMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterMedian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfterMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteMedian As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToCompleteMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespFrom, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class VwFireRecommendationsBaseViewMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.FilePrefix, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ClientLocNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Division, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.CustomAccess, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Facility, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Address, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Address
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.City, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.StProv, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Zip, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Country, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Latitude, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Longitude, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Tivus, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Tivus
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.StProvName, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.StProvName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.AddressStamp, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.AddressStamp
			c.CharacterMaxLength = 1000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecUniqueID, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecUniqueID
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecYear, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecMonth, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecMonth
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecNumber, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecSubletter, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecSubletter
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecNo, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecNo
			c.CharacterMaxLength = 533
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCategory, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecCategory
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecStatus, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDate, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCode, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecCode
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.PrimaryRecType, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.SecondaryRecType, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecKeyWords, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecKeyWords
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.BriefExplanationOfRec, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.BriefExplanationOfRec
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBefore, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyBefore
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfter, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyAfter
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToComplete, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.CostToComplete
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.SavingsRatio, 34, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.SavingsRatio
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDate, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseFrom, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.PlantComment, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.PlantComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDate, 38, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.IntendedAction, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBeforeActual, 40, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyBeforeActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfterActual, 41, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyAfterActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToCompleteActual, 42, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.CostToCompleteActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.Hazard, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 6
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ActualCostToComplete, 44, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ActualCostToComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespDate, 45, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespFrom, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespAction, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.MgmtRespComment, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.MgmtRespComment
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecPriority, 49, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecPriority
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCatWeight, 50, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingCatWeight
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCat, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingCat
			c.CharacterMaxLength = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingPts, 52, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingPts
			c.NumericPrecision = 21
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatusFlag, 53, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseStatusFlag
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDate, 54, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDate, 55, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.DaysOverdue, 56, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.DaysOverdue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1Date, 57, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2Date, 58, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3Date, 59, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecipientName, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecipientName
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecipientEmail, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecipientEmail
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.AutoRequest, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.AutoRequest
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateMonth, 63, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateYear, 64, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateMonth, 65, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateYear, 66, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateMonth, 67, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateYear, 68, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateMonth, 69, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateYear, 70, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateMonth, 71, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateYear, 72, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateMonth, 73, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3DateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateYear, 74, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3DateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateMonth, 75, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateYear, 76, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateMonth, 77, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDateMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateYear, 78, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDateYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespRequestDateString, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RespRequestDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RespDueDateString, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RespDueDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseDateString, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU1DateString, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU1DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU2DateString, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU2DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RFU3DateString, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RFU3DateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateString, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.StatusDateString, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.StatusDateString
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExchangeRateGroupID, 87, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ExchangeRateGroupID
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatus, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingScoreChange, 89, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingScoreChange
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RatingCatPts, 90, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RatingCatPts
			c.CharacterMaxLength = 54
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.RecCategoryColor, 91, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.RecCategoryColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ExpectedCompletionDateColor, 92, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ExpectedCompletionDateColor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ResponseStatusColor, 93, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ResponseStatusColor
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyBeforeMedian, 94, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyBeforeMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.LossExpectancyAfterMedian, 95, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.LossExpectancyAfterMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.CostToCompleteMedian, 96, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.CostToCompleteMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespAction, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespComment, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespComment
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespDate, 99, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(VwFireRecommendationsBaseViewMetadata.ColumnNames.ThirdLevelRespFrom, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = VwFireRecommendationsBaseViewMetadata.PropertyNames.ThirdLevelRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As VwFireRecommendationsBaseViewMetadata
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
			 Public Const AddressStamp As String = "AddressStamp"
			 Public Const RecUniqueID As String = "RecUniqueID"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecSubletter As String = "RecSubletter"
			 Public Const RecNo As String = "RecNo"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecKeyWords As String = "RecKeyWords"
			 Public Const BriefExplanationOfRec As String = "BriefExplanationOfRec"
			 Public Const LossExpectancyBefore As String = "LossExpectancyBefore"
			 Public Const LossExpectancyAfter As String = "LossExpectancyAfter"
			 Public Const CostToComplete As String = "CostToComplete"
			 Public Const SavingsRatio As String = "SavingsRatio"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const LossExpectancyBeforeActual As String = "LossExpectancyBeforeActual"
			 Public Const LossExpectancyAfterActual As String = "LossExpectancyAfterActual"
			 Public Const CostToCompleteActual As String = "CostToCompleteActual"
			 Public Const Hazard As String = "Hazard"
			 Public Const ActualCostToComplete As String = "ActualCostToComplete"
			 Public Const MgmtRespDate As String = "MgmtRespDate"
			 Public Const MgmtRespFrom As String = "MgmtRespFrom"
			 Public Const MgmtRespAction As String = "MgmtRespAction"
			 Public Const MgmtRespComment As String = "MgmtRespComment"
			 Public Const RecPriority As String = "RecPriority"
			 Public Const RatingCatWeight As String = "RatingCatWeight"
			 Public Const RatingCat As String = "RatingCat"
			 Public Const RatingPts As String = "RatingPts"
			 Public Const ResponseStatusFlag As String = "ResponseStatusFlag"
			 Public Const RespRequestDate As String = "RespRequestDate"
			 Public Const RespDueDate As String = "RespDueDate"
			 Public Const DaysOverdue As String = "DaysOverdue"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const AutoRequest As String = "AutoRequest"
			 Public Const RespRequestDateMonth As String = "RespRequestDateMonth"
			 Public Const RespRequestDateYear As String = "RespRequestDateYear"
			 Public Const RespDueDateMonth As String = "RespDueDateMonth"
			 Public Const RespDueDateYear As String = "RespDueDateYear"
			 Public Const ResponseDateMonth As String = "ResponseDateMonth"
			 Public Const ResponseDateYear As String = "ResponseDateYear"
			 Public Const RFU1DateMonth As String = "RFU1DateMonth"
			 Public Const RFU1DateYear As String = "RFU1DateYear"
			 Public Const RFU2DateMonth As String = "RFU2DateMonth"
			 Public Const RFU2DateYear As String = "RFU2DateYear"
			 Public Const RFU3DateMonth As String = "RFU3DateMonth"
			 Public Const RFU3DateYear As String = "RFU3DateYear"
			 Public Const ExpectedCompletionDateMonth As String = "ExpectedCompletionDateMonth"
			 Public Const ExpectedCompletionDateYear As String = "ExpectedCompletionDateYear"
			 Public Const StatusDateMonth As String = "StatusDateMonth"
			 Public Const StatusDateYear As String = "StatusDateYear"
			 Public Const RespRequestDateString As String = "RespRequestDateString"
			 Public Const RespDueDateString As String = "RespDueDateString"
			 Public Const ResponseDateString As String = "ResponseDateString"
			 Public Const RFU1DateString As String = "RFU1DateString"
			 Public Const RFU2DateString As String = "RFU2DateString"
			 Public Const RFU3DateString As String = "RFU3DateString"
			 Public Const ExpectedCompletionDateString As String = "ExpectedCompletionDateString"
			 Public Const StatusDateString As String = "StatusDateString"
			 Public Const ExchangeRateGroupID As String = "ExchangeRateGroupID"
			 Public Const ResponseStatus As String = "ResponseStatus"
			 Public Const RatingScoreChange As String = "RatingScoreChange"
			 Public Const RatingCatPts As String = "RatingCatPts"
			 Public Const RecCategoryColor As String = "RecCategoryColor"
			 Public Const ExpectedCompletionDateColor As String = "ExpectedCompletionDateColor"
			 Public Const ResponseStatusColor As String = "ResponseStatusColor"
			 Public Const LossExpectancyBeforeMedian As String = "LossExpectancyBeforeMedian"
			 Public Const LossExpectancyAfterMedian As String = "LossExpectancyAfterMedian"
			 Public Const CostToCompleteMedian As String = "CostToCompleteMedian"
			 Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
			 Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
			 Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
			 Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
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
			 Public Const AddressStamp As String = "AddressStamp"
			 Public Const RecUniqueID As String = "RecUniqueID"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecSubletter As String = "RecSubletter"
			 Public Const RecNo As String = "RecNo"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecKeyWords As String = "RecKeyWords"
			 Public Const BriefExplanationOfRec As String = "BriefExplanationOfRec"
			 Public Const LossExpectancyBefore As String = "LossExpectancyBefore"
			 Public Const LossExpectancyAfter As String = "LossExpectancyAfter"
			 Public Const CostToComplete As String = "CostToComplete"
			 Public Const SavingsRatio As String = "SavingsRatio"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const LossExpectancyBeforeActual As String = "LossExpectancyBeforeActual"
			 Public Const LossExpectancyAfterActual As String = "LossExpectancyAfterActual"
			 Public Const CostToCompleteActual As String = "CostToCompleteActual"
			 Public Const Hazard As String = "Hazard"
			 Public Const ActualCostToComplete As String = "ActualCostToComplete"
			 Public Const MgmtRespDate As String = "MgmtRespDate"
			 Public Const MgmtRespFrom As String = "MgmtRespFrom"
			 Public Const MgmtRespAction As String = "MgmtRespAction"
			 Public Const MgmtRespComment As String = "MgmtRespComment"
			 Public Const RecPriority As String = "RecPriority"
			 Public Const RatingCatWeight As String = "RatingCatWeight"
			 Public Const RatingCat As String = "RatingCat"
			 Public Const RatingPts As String = "RatingPts"
			 Public Const ResponseStatusFlag As String = "ResponseStatusFlag"
			 Public Const RespRequestDate As String = "RespRequestDate"
			 Public Const RespDueDate As String = "RespDueDate"
			 Public Const DaysOverdue As String = "DaysOverdue"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const AutoRequest As String = "AutoRequest"
			 Public Const RespRequestDateMonth As String = "RespRequestDateMonth"
			 Public Const RespRequestDateYear As String = "RespRequestDateYear"
			 Public Const RespDueDateMonth As String = "RespDueDateMonth"
			 Public Const RespDueDateYear As String = "RespDueDateYear"
			 Public Const ResponseDateMonth As String = "ResponseDateMonth"
			 Public Const ResponseDateYear As String = "ResponseDateYear"
			 Public Const RFU1DateMonth As String = "RFU1DateMonth"
			 Public Const RFU1DateYear As String = "RFU1DateYear"
			 Public Const RFU2DateMonth As String = "RFU2DateMonth"
			 Public Const RFU2DateYear As String = "RFU2DateYear"
			 Public Const RFU3DateMonth As String = "RFU3DateMonth"
			 Public Const RFU3DateYear As String = "RFU3DateYear"
			 Public Const ExpectedCompletionDateMonth As String = "ExpectedCompletionDateMonth"
			 Public Const ExpectedCompletionDateYear As String = "ExpectedCompletionDateYear"
			 Public Const StatusDateMonth As String = "StatusDateMonth"
			 Public Const StatusDateYear As String = "StatusDateYear"
			 Public Const RespRequestDateString As String = "RespRequestDateString"
			 Public Const RespDueDateString As String = "RespDueDateString"
			 Public Const ResponseDateString As String = "ResponseDateString"
			 Public Const RFU1DateString As String = "RFU1DateString"
			 Public Const RFU2DateString As String = "RFU2DateString"
			 Public Const RFU3DateString As String = "RFU3DateString"
			 Public Const ExpectedCompletionDateString As String = "ExpectedCompletionDateString"
			 Public Const StatusDateString As String = "StatusDateString"
			 Public Const ExchangeRateGroupID As String = "ExchangeRateGroupID"
			 Public Const ResponseStatus As String = "ResponseStatus"
			 Public Const RatingScoreChange As String = "RatingScoreChange"
			 Public Const RatingCatPts As String = "RatingCatPts"
			 Public Const RecCategoryColor As String = "RecCategoryColor"
			 Public Const ExpectedCompletionDateColor As String = "ExpectedCompletionDateColor"
			 Public Const ResponseStatusColor As String = "ResponseStatusColor"
			 Public Const LossExpectancyBeforeMedian As String = "LossExpectancyBeforeMedian"
			 Public Const LossExpectancyAfterMedian As String = "LossExpectancyAfterMedian"
			 Public Const CostToCompleteMedian As String = "CostToCompleteMedian"
			 Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
			 Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
			 Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
			 Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
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
			SyncLock GetType(VwFireRecommendationsBaseViewMetadata)
			
				If VwFireRecommendationsBaseViewMetadata.mapDelegates Is Nothing Then
					VwFireRecommendationsBaseViewMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If VwFireRecommendationsBaseViewMetadata._meta Is Nothing Then
					VwFireRecommendationsBaseViewMetadata._meta = New VwFireRecommendationsBaseViewMetadata()
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
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Tivus", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("StProvName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("AddressStamp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecUniqueID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecMonth", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecSubletter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecCategory", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StatusDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("RecCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PrimaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SecondaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecKeyWords", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BriefExplanationOfRec", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LossExpectancyBefore", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LossExpectancyAfter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CostToComplete", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SavingsRatio", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ResponseDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ResponseFrom", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("IntendedAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LossExpectancyBeforeActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LossExpectancyAfterActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CostToCompleteActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ActualCostToComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MgmtRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("MgmtRespFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecPriority", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RatingCatWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("RatingCat", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingPts", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ResponseStatusFlag", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespRequestDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RespDueDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DaysOverdue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU2Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU3Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RecipientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecipientEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AutoRequest", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RespRequestDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespRequestDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespDueDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespDueDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ResponseDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ResponseDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU1DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU2DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU2DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU3DateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RFU3DateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExpectedCompletionDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExpectedCompletionDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StatusDateMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StatusDateYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RespRequestDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RespDueDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ResponseDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU1DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU2DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RFU3DateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StatusDateString", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExchangeRateGroupID", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("ResponseStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RatingScoreChange", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("RatingCatPts", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecCategoryColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDateColor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ResponseStatusColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LossExpectancyBeforeMedian", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LossExpectancyAfterMedian", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CostToCompleteMedian", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ThirdLevelRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ThirdLevelRespFrom", new esTypeMap("varchar", "System.String"))			
				
				meta.Schema = "bv"
				 
				meta.Source = "vwFireRecommendationsBaseView"
				meta.Destination = "vwFireRecommendationsBaseView"
				
				meta.spInsert = "proc_vwFireRecommendationsBaseViewInsert"
				meta.spUpdate = "proc_vwFireRecommendationsBaseViewUpdate"
				meta.spDelete = "proc_vwFireRecommendationsBaseViewDelete"
				meta.spLoadAll = "proc_vwFireRecommendationsBaseViewLoadAll"
				meta.spLoadByPrimaryKey = "proc_vwFireRecommendationsBaseViewLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As VwFireRecommendationsBaseViewMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
