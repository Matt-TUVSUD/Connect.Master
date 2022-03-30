
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/16/2014 8:45:03 PM
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
	' Encapsulates the 'viewCCCopeMainFire' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCCopeMainFire))> _
	<XmlType("ViewCCCopeMainFire")> _	
	Partial Public Class ViewCCCopeMainFire 
		Inherits esViewCCCopeMainFire
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCCopeMainFire()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCCopeMainFireCollection")> _
	Partial Public Class ViewCCCopeMainFireCollection
		Inherits esViewCCCopeMainFireCollection
		Implements IEnumerable(Of ViewCCCopeMainFire)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCCopeMainFire))> _
		Public Class ViewCCCopeMainFireCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCCopeMainFireCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCCopeMainFireCollectionWCFPacket) As ViewCCCopeMainFireCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCCopeMainFireCollection) As ViewCCCopeMainFireCollectionWCFPacket
				Return New ViewCCCopeMainFireCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCCopeMainFireQuery 
		Inherits esViewCCCopeMainFireQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCCopeMainFireQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCCopeMainFireQuery) As String
			Return ViewCCCopeMainFireQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCCopeMainFireQuery
			Return DirectCast(ViewCCCopeMainFireQuery.SerializeHelper.FromXml(query, GetType(ViewCCCopeMainFireQuery)), ViewCCCopeMainFireQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCCopeMainFire
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCCopeMainFire.RowNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RowNumber As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.RowNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.RowNumber, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.RowNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCCopeMainFireMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCCopeMainFireMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCCopeMainFireMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCCopeMainFireMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.Consultant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Consultant As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.Consultant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.Consultant, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Consultant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.Units
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Units As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.Units, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Units)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.Currency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Currency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.Currency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.Currency, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Currency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.BIReporting
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIReporting As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.BIReporting)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.BIReporting, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.BIReporting)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.ExchangeRate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.ExchangeRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.ExchangeRate, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.ExchangeRate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TIVPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Tivpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Tivpd, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Tivpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TIVBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Tivbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Tivbi, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Tivbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TIVTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.TIVTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.TIVTotal, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TIVTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.APLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Aplpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Aplpd, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Aplpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.APLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Aplbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Aplbi, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Aplbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.APLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.APLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.APLTotal, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.APLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.APLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.APLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.APLPDPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.APLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.APLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.APLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.APLBIPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.APLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.APLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.APLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.APLTotalPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.APLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PMLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Pmlpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Pmlpd, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Pmlpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PMLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Pmlbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Pmlbi, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Pmlbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PMLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.PMLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.PMLTotal, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PMLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PMLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.PMLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.PMLPDPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PMLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PMLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.PMLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.PMLBIPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PMLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PMLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.PMLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.PMLTotalPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PMLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MFLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Mflpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Mflpd, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Mflpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MFLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Mflbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.Mflbi, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Mflbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MFLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.MFLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.MFLTotal, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MFLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MFLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.MFLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.MFLPDPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MFLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MFLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.MFLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.MFLBIPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MFLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MFLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.MFLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainFireMetadata.ColumnNames.MFLTotalPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MFLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.Interdependencies
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Interdependencies As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.Interdependencies)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.Interdependencies, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Interdependencies)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.LEandInterdependecyComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEandInterdependecyComments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.LEandInterdependecyComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.LEandInterdependecyComments, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.LEandInterdependecyComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.SignificantPropertyDamageLossesInPast3Years
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SignificantPropertyDamageLossesInPast3Years As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.SignificantPropertyDamageLossesInPast3Years)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.SignificantPropertyDamageLossesInPast3Years, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.SignificantPropertyDamageLossesInPast3Years)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.SignificantPropertyDescriptionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SignificantPropertyDescriptionField As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.SignificantPropertyDescriptionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.SignificantPropertyDescriptionField, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.SignificantPropertyDescriptionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AdminMemo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminMemo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.AdminMemo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainFireMetadata.ColumnNames.AdminMemo, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AdminMemo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivPdUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivPdAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivPdJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivPdNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivPdEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivPdMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivPdCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivPdGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivPdGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivBiUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivBiAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivBiJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivBiNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivBiEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivBiMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivBiCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivBiGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivBiGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplPdGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplBiGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflPdGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflBiGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlPdPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlBiPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplPdPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPdPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.AplPdPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.AplPdPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplBiPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBiPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.AplBiPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.AplBiPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflPdPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.MflPdPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.MflPdPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflBiPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.MflBiPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.MflBiPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivTotalUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivTotalAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivTotalJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivTotalNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivTotalEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivTotalMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivTotalCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.TivTotalGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.AplTotalGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplTotalGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.PmlTotalGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalUSD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalUSD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalAUD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalAUD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalJPY As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalJPY)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalNZD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalNZD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalEUR As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalEUR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalMXP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalMXP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalCAD As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalCAD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainFire.MflTotalGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalGBP As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalGBP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalGBP)
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
												
						Case "RowNumber"
							Me.str().RowNumber = CType(value, string)
												
						Case "Id"
							Me.str().Id = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "SurveyDate"
							Me.str().SurveyDate = CType(value, string)
												
						Case "Consultant"
							Me.str().Consultant = CType(value, string)
												
						Case "Units"
							Me.str().Units = CType(value, string)
												
						Case "Currency"
							Me.str().Currency = CType(value, string)
												
						Case "BIReporting"
							Me.str().BIReporting = CType(value, string)
												
						Case "ExchangeRate"
							Me.str().ExchangeRate = CType(value, string)
												
						Case "Tivpd"
							Me.str().Tivpd = CType(value, string)
												
						Case "Tivbi"
							Me.str().Tivbi = CType(value, string)
												
						Case "TIVTotal"
							Me.str().TIVTotal = CType(value, string)
												
						Case "Aplpd"
							Me.str().Aplpd = CType(value, string)
												
						Case "Aplbi"
							Me.str().Aplbi = CType(value, string)
												
						Case "APLTotal"
							Me.str().APLTotal = CType(value, string)
												
						Case "APLPDPercentage"
							Me.str().APLPDPercentage = CType(value, string)
												
						Case "APLBIPercentage"
							Me.str().APLBIPercentage = CType(value, string)
												
						Case "APLTotalPercentage"
							Me.str().APLTotalPercentage = CType(value, string)
												
						Case "Pmlpd"
							Me.str().Pmlpd = CType(value, string)
												
						Case "Pmlbi"
							Me.str().Pmlbi = CType(value, string)
												
						Case "PMLTotal"
							Me.str().PMLTotal = CType(value, string)
												
						Case "PMLPDPercentage"
							Me.str().PMLPDPercentage = CType(value, string)
												
						Case "PMLBIPercentage"
							Me.str().PMLBIPercentage = CType(value, string)
												
						Case "PMLTotalPercentage"
							Me.str().PMLTotalPercentage = CType(value, string)
												
						Case "Mflpd"
							Me.str().Mflpd = CType(value, string)
												
						Case "Mflbi"
							Me.str().Mflbi = CType(value, string)
												
						Case "MFLTotal"
							Me.str().MFLTotal = CType(value, string)
												
						Case "MFLPDPercentage"
							Me.str().MFLPDPercentage = CType(value, string)
												
						Case "MFLBIPercentage"
							Me.str().MFLBIPercentage = CType(value, string)
												
						Case "MFLTotalPercentage"
							Me.str().MFLTotalPercentage = CType(value, string)
												
						Case "Interdependencies"
							Me.str().Interdependencies = CType(value, string)
												
						Case "LEandInterdependecyComments"
							Me.str().LEandInterdependecyComments = CType(value, string)
												
						Case "SignificantPropertyDamageLossesInPast3Years"
							Me.str().SignificantPropertyDamageLossesInPast3Years = CType(value, string)
												
						Case "SignificantPropertyDescriptionField"
							Me.str().SignificantPropertyDescriptionField = CType(value, string)
												
						Case "AdminMemo"
							Me.str().AdminMemo = CType(value, string)
												
						Case "TivPdUSD"
							Me.str().TivPdUSD = CType(value, string)
												
						Case "TivPdAUD"
							Me.str().TivPdAUD = CType(value, string)
												
						Case "TivPdJPY"
							Me.str().TivPdJPY = CType(value, string)
												
						Case "TivPdNZD"
							Me.str().TivPdNZD = CType(value, string)
												
						Case "TivPdEUR"
							Me.str().TivPdEUR = CType(value, string)
												
						Case "TivPdMXP"
							Me.str().TivPdMXP = CType(value, string)
												
						Case "TivPdCAD"
							Me.str().TivPdCAD = CType(value, string)
												
						Case "TivPdGBP"
							Me.str().TivPdGBP = CType(value, string)
												
						Case "TivBiUSD"
							Me.str().TivBiUSD = CType(value, string)
												
						Case "TivBiAUD"
							Me.str().TivBiAUD = CType(value, string)
												
						Case "TivBiJPY"
							Me.str().TivBiJPY = CType(value, string)
												
						Case "TivBiNZD"
							Me.str().TivBiNZD = CType(value, string)
												
						Case "TivBiEUR"
							Me.str().TivBiEUR = CType(value, string)
												
						Case "TivBiMXP"
							Me.str().TivBiMXP = CType(value, string)
												
						Case "TivBiCAD"
							Me.str().TivBiCAD = CType(value, string)
												
						Case "TivBiGBP"
							Me.str().TivBiGBP = CType(value, string)
												
						Case "AplPdUSD"
							Me.str().AplPdUSD = CType(value, string)
												
						Case "AplPdAUD"
							Me.str().AplPdAUD = CType(value, string)
												
						Case "AplPdJPY"
							Me.str().AplPdJPY = CType(value, string)
												
						Case "AplPdNZD"
							Me.str().AplPdNZD = CType(value, string)
												
						Case "AplPdEUR"
							Me.str().AplPdEUR = CType(value, string)
												
						Case "AplPdMXP"
							Me.str().AplPdMXP = CType(value, string)
												
						Case "AplPdCAD"
							Me.str().AplPdCAD = CType(value, string)
												
						Case "AplPdGBP"
							Me.str().AplPdGBP = CType(value, string)
												
						Case "AplBiUSD"
							Me.str().AplBiUSD = CType(value, string)
												
						Case "AplBiAUD"
							Me.str().AplBiAUD = CType(value, string)
												
						Case "AplBiJPY"
							Me.str().AplBiJPY = CType(value, string)
												
						Case "AplBiNZD"
							Me.str().AplBiNZD = CType(value, string)
												
						Case "AplBiEUR"
							Me.str().AplBiEUR = CType(value, string)
												
						Case "AplBiMXP"
							Me.str().AplBiMXP = CType(value, string)
												
						Case "AplBiCAD"
							Me.str().AplBiCAD = CType(value, string)
												
						Case "AplBiGBP"
							Me.str().AplBiGBP = CType(value, string)
												
						Case "PmlPdUSD"
							Me.str().PmlPdUSD = CType(value, string)
												
						Case "PmlPdAUD"
							Me.str().PmlPdAUD = CType(value, string)
												
						Case "PmlPdJPY"
							Me.str().PmlPdJPY = CType(value, string)
												
						Case "PmlPdNZD"
							Me.str().PmlPdNZD = CType(value, string)
												
						Case "PmlPdEUR"
							Me.str().PmlPdEUR = CType(value, string)
												
						Case "PmlPdMXP"
							Me.str().PmlPdMXP = CType(value, string)
												
						Case "PmlPdCAD"
							Me.str().PmlPdCAD = CType(value, string)
												
						Case "PmlPdGBP"
							Me.str().PmlPdGBP = CType(value, string)
												
						Case "PmlBiUSD"
							Me.str().PmlBiUSD = CType(value, string)
												
						Case "PmlBiAUD"
							Me.str().PmlBiAUD = CType(value, string)
												
						Case "PmlBiJPY"
							Me.str().PmlBiJPY = CType(value, string)
												
						Case "PmlBiNZD"
							Me.str().PmlBiNZD = CType(value, string)
												
						Case "PmlBiEUR"
							Me.str().PmlBiEUR = CType(value, string)
												
						Case "PmlBiMXP"
							Me.str().PmlBiMXP = CType(value, string)
												
						Case "PmlBiCAD"
							Me.str().PmlBiCAD = CType(value, string)
												
						Case "PmlBiGBP"
							Me.str().PmlBiGBP = CType(value, string)
												
						Case "MflPdUSD"
							Me.str().MflPdUSD = CType(value, string)
												
						Case "MflPdAUD"
							Me.str().MflPdAUD = CType(value, string)
												
						Case "MflPdJPY"
							Me.str().MflPdJPY = CType(value, string)
												
						Case "MflPdNZD"
							Me.str().MflPdNZD = CType(value, string)
												
						Case "MflPdEUR"
							Me.str().MflPdEUR = CType(value, string)
												
						Case "MflPdMXP"
							Me.str().MflPdMXP = CType(value, string)
												
						Case "MflPdCAD"
							Me.str().MflPdCAD = CType(value, string)
												
						Case "MflPdGBP"
							Me.str().MflPdGBP = CType(value, string)
												
						Case "MflBiUSD"
							Me.str().MflBiUSD = CType(value, string)
												
						Case "MflBiAUD"
							Me.str().MflBiAUD = CType(value, string)
												
						Case "MflBiJPY"
							Me.str().MflBiJPY = CType(value, string)
												
						Case "MflBiNZD"
							Me.str().MflBiNZD = CType(value, string)
												
						Case "MflBiEUR"
							Me.str().MflBiEUR = CType(value, string)
												
						Case "MflBiMXP"
							Me.str().MflBiMXP = CType(value, string)
												
						Case "MflBiCAD"
							Me.str().MflBiCAD = CType(value, string)
												
						Case "MflBiGBP"
							Me.str().MflBiGBP = CType(value, string)
												
						Case "PmlPdPercent"
							Me.str().PmlPdPercent = CType(value, string)
												
						Case "PmlBiPercent"
							Me.str().PmlBiPercent = CType(value, string)
												
						Case "PmlTotalPercent"
							Me.str().PmlTotalPercent = CType(value, string)
												
						Case "AplPdPercent"
							Me.str().AplPdPercent = CType(value, string)
												
						Case "AplBiPercent"
							Me.str().AplBiPercent = CType(value, string)
												
						Case "AplTotalPercent"
							Me.str().AplTotalPercent = CType(value, string)
												
						Case "MflPdPercent"
							Me.str().MflPdPercent = CType(value, string)
												
						Case "MflBiPercent"
							Me.str().MflBiPercent = CType(value, string)
												
						Case "MflTotalPercent"
							Me.str().MflTotalPercent = CType(value, string)
												
						Case "TivTotalUSD"
							Me.str().TivTotalUSD = CType(value, string)
												
						Case "TivTotalAUD"
							Me.str().TivTotalAUD = CType(value, string)
												
						Case "TivTotalJPY"
							Me.str().TivTotalJPY = CType(value, string)
												
						Case "TivTotalNZD"
							Me.str().TivTotalNZD = CType(value, string)
												
						Case "TivTotalEUR"
							Me.str().TivTotalEUR = CType(value, string)
												
						Case "TivTotalMXP"
							Me.str().TivTotalMXP = CType(value, string)
												
						Case "TivTotalCAD"
							Me.str().TivTotalCAD = CType(value, string)
												
						Case "TivTotalGBP"
							Me.str().TivTotalGBP = CType(value, string)
												
						Case "AplTotalUSD"
							Me.str().AplTotalUSD = CType(value, string)
												
						Case "AplTotalAUD"
							Me.str().AplTotalAUD = CType(value, string)
												
						Case "AplTotalJPY"
							Me.str().AplTotalJPY = CType(value, string)
												
						Case "AplTotalNZD"
							Me.str().AplTotalNZD = CType(value, string)
												
						Case "AplTotalEUR"
							Me.str().AplTotalEUR = CType(value, string)
												
						Case "AplTotalMXP"
							Me.str().AplTotalMXP = CType(value, string)
												
						Case "AplTotalCAD"
							Me.str().AplTotalCAD = CType(value, string)
												
						Case "AplTotalGBP"
							Me.str().AplTotalGBP = CType(value, string)
												
						Case "PmlTotalUSD"
							Me.str().PmlTotalUSD = CType(value, string)
												
						Case "PmlTotalAUD"
							Me.str().PmlTotalAUD = CType(value, string)
												
						Case "PmlTotalJPY"
							Me.str().PmlTotalJPY = CType(value, string)
												
						Case "PmlTotalNZD"
							Me.str().PmlTotalNZD = CType(value, string)
												
						Case "PmlTotalEUR"
							Me.str().PmlTotalEUR = CType(value, string)
												
						Case "PmlTotalMXP"
							Me.str().PmlTotalMXP = CType(value, string)
												
						Case "PmlTotalCAD"
							Me.str().PmlTotalCAD = CType(value, string)
												
						Case "PmlTotalGBP"
							Me.str().PmlTotalGBP = CType(value, string)
												
						Case "MflTotalUSD"
							Me.str().MflTotalUSD = CType(value, string)
												
						Case "MflTotalAUD"
							Me.str().MflTotalAUD = CType(value, string)
												
						Case "MflTotalJPY"
							Me.str().MflTotalJPY = CType(value, string)
												
						Case "MflTotalNZD"
							Me.str().MflTotalNZD = CType(value, string)
												
						Case "MflTotalEUR"
							Me.str().MflTotalEUR = CType(value, string)
												
						Case "MflTotalMXP"
							Me.str().MflTotalMXP = CType(value, string)
												
						Case "MflTotalCAD"
							Me.str().MflTotalCAD = CType(value, string)
												
						Case "MflTotalGBP"
							Me.str().MflTotalGBP = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RowNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.RowNumber = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.RowNumber)
							End If
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Id)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Longitude)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "ExchangeRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ExchangeRate = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.ExchangeRate)
							End If
						
						Case "Tivpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Tivpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Tivpd)
							End If
						
						Case "Tivbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Tivbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Tivbi)
							End If
						
						Case "TIVTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TIVTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TIVTotal)
							End If
						
						Case "Aplpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Aplpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Aplpd)
							End If
						
						Case "Aplbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Aplbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Aplbi)
							End If
						
						Case "APLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.APLTotal)
							End If
						
						Case "APLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.APLPDPercentage)
							End If
						
						Case "APLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.APLBIPercentage)
							End If
						
						Case "APLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.APLTotalPercentage)
							End If
						
						Case "Pmlpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pmlpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Pmlpd)
							End If
						
						Case "Pmlbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pmlbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Pmlbi)
							End If
						
						Case "PMLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PMLTotal)
							End If
						
						Case "PMLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PMLPDPercentage)
							End If
						
						Case "PMLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PMLBIPercentage)
							End If
						
						Case "PMLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PMLTotalPercentage)
							End If
						
						Case "Mflpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Mflpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Mflpd)
							End If
						
						Case "Mflbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Mflbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.Mflbi)
							End If
						
						Case "MFLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MFLTotal)
							End If
						
						Case "MFLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MFLPDPercentage)
							End If
						
						Case "MFLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MFLBIPercentage)
							End If
						
						Case "MFLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MFLTotalPercentage)
							End If
						
						Case "TivPdUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivPdUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdUSD)
							End If
						
						Case "TivPdAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivPdAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdAUD)
							End If
						
						Case "TivPdJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivPdJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdJPY)
							End If
						
						Case "TivPdNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivPdNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdNZD)
							End If
						
						Case "TivPdEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivPdEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdEUR)
							End If
						
						Case "TivPdMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivPdMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdMXP)
							End If
						
						Case "TivPdCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivPdCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdCAD)
							End If
						
						Case "TivPdGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivPdGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivPdGBP)
							End If
						
						Case "TivBiUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivBiUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiUSD)
							End If
						
						Case "TivBiAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivBiAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiAUD)
							End If
						
						Case "TivBiJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivBiJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiJPY)
							End If
						
						Case "TivBiNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivBiNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiNZD)
							End If
						
						Case "TivBiEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivBiEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiEUR)
							End If
						
						Case "TivBiMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivBiMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiMXP)
							End If
						
						Case "TivBiCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivBiCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiCAD)
							End If
						
						Case "TivBiGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivBiGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivBiGBP)
							End If
						
						Case "AplPdUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplPdUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdUSD)
							End If
						
						Case "AplPdAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplPdAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdAUD)
							End If
						
						Case "AplPdJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplPdJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdJPY)
							End If
						
						Case "AplPdNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplPdNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdNZD)
							End If
						
						Case "AplPdEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplPdEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdEUR)
							End If
						
						Case "AplPdMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplPdMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdMXP)
							End If
						
						Case "AplPdCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplPdCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdCAD)
							End If
						
						Case "AplPdGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplPdGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdGBP)
							End If
						
						Case "AplBiUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplBiUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiUSD)
							End If
						
						Case "AplBiAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplBiAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiAUD)
							End If
						
						Case "AplBiJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplBiJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiJPY)
							End If
						
						Case "AplBiNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplBiNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiNZD)
							End If
						
						Case "AplBiEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplBiEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiEUR)
							End If
						
						Case "AplBiMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplBiMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiMXP)
							End If
						
						Case "AplBiCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplBiCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiCAD)
							End If
						
						Case "AplBiGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplBiGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiGBP)
							End If
						
						Case "PmlPdUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlPdUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdUSD)
							End If
						
						Case "PmlPdAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlPdAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdAUD)
							End If
						
						Case "PmlPdJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlPdJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdJPY)
							End If
						
						Case "PmlPdNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlPdNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdNZD)
							End If
						
						Case "PmlPdEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlPdEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdEUR)
							End If
						
						Case "PmlPdMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlPdMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdMXP)
							End If
						
						Case "PmlPdCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlPdCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdCAD)
							End If
						
						Case "PmlPdGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlPdGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdGBP)
							End If
						
						Case "PmlBiUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlBiUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiUSD)
							End If
						
						Case "PmlBiAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlBiAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiAUD)
							End If
						
						Case "PmlBiJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlBiJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiJPY)
							End If
						
						Case "PmlBiNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlBiNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiNZD)
							End If
						
						Case "PmlBiEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlBiEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiEUR)
							End If
						
						Case "PmlBiMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlBiMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiMXP)
							End If
						
						Case "PmlBiCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlBiCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiCAD)
							End If
						
						Case "PmlBiGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlBiGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiGBP)
							End If
						
						Case "MflPdUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflPdUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdUSD)
							End If
						
						Case "MflPdAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflPdAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdAUD)
							End If
						
						Case "MflPdJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflPdJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdJPY)
							End If
						
						Case "MflPdNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflPdNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdNZD)
							End If
						
						Case "MflPdEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflPdEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdEUR)
							End If
						
						Case "MflPdMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflPdMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdMXP)
							End If
						
						Case "MflPdCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflPdCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdCAD)
							End If
						
						Case "MflPdGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflPdGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdGBP)
							End If
						
						Case "MflBiUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflBiUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiUSD)
							End If
						
						Case "MflBiAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflBiAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiAUD)
							End If
						
						Case "MflBiJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflBiJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiJPY)
							End If
						
						Case "MflBiNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflBiNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiNZD)
							End If
						
						Case "MflBiEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflBiEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiEUR)
							End If
						
						Case "MflBiMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflBiMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiMXP)
							End If
						
						Case "MflBiCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflBiCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiCAD)
							End If
						
						Case "MflBiGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflBiGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiGBP)
							End If
						
						Case "PmlPdPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PmlPdPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlPdPercent)
							End If
						
						Case "PmlBiPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PmlBiPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlBiPercent)
							End If
						
						Case "PmlTotalPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PmlTotalPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalPercent)
							End If
						
						Case "AplPdPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.AplPdPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplPdPercent)
							End If
						
						Case "AplBiPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.AplBiPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplBiPercent)
							End If
						
						Case "AplTotalPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.AplTotalPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalPercent)
							End If
						
						Case "MflPdPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MflPdPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflPdPercent)
							End If
						
						Case "MflBiPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MflBiPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflBiPercent)
							End If
						
						Case "MflTotalPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MflTotalPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalPercent)
							End If
						
						Case "TivTotalUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivTotalUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalUSD)
							End If
						
						Case "TivTotalAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivTotalAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalAUD)
							End If
						
						Case "TivTotalJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivTotalJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalJPY)
							End If
						
						Case "TivTotalNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivTotalNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalNZD)
							End If
						
						Case "TivTotalEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivTotalEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalEUR)
							End If
						
						Case "TivTotalMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivTotalMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalMXP)
							End If
						
						Case "TivTotalCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivTotalCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalCAD)
							End If
						
						Case "TivTotalGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.TivTotalGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.TivTotalGBP)
							End If
						
						Case "AplTotalUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplTotalUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalUSD)
							End If
						
						Case "AplTotalAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplTotalAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalAUD)
							End If
						
						Case "AplTotalJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplTotalJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalJPY)
							End If
						
						Case "AplTotalNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplTotalNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalNZD)
							End If
						
						Case "AplTotalEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplTotalEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalEUR)
							End If
						
						Case "AplTotalMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplTotalMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalMXP)
							End If
						
						Case "AplTotalCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplTotalCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalCAD)
							End If
						
						Case "AplTotalGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.AplTotalGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.AplTotalGBP)
							End If
						
						Case "PmlTotalUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlTotalUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalUSD)
							End If
						
						Case "PmlTotalAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlTotalAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalAUD)
							End If
						
						Case "PmlTotalJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlTotalJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalJPY)
							End If
						
						Case "PmlTotalNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlTotalNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalNZD)
							End If
						
						Case "PmlTotalEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlTotalEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalEUR)
							End If
						
						Case "PmlTotalMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlTotalMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalMXP)
							End If
						
						Case "PmlTotalCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlTotalCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalCAD)
							End If
						
						Case "PmlTotalGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.PmlTotalGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalGBP)
							End If
						
						Case "MflTotalUSD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflTotalUSD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalUSD)
							End If
						
						Case "MflTotalAUD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflTotalAUD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalAUD)
							End If
						
						Case "MflTotalJPY"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflTotalJPY = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalJPY)
							End If
						
						Case "MflTotalNZD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflTotalNZD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalNZD)
							End If
						
						Case "MflTotalEUR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflTotalEUR = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalEUR)
							End If
						
						Case "MflTotalMXP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflTotalMXP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalMXP)
							End If
						
						Case "MflTotalCAD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflTotalCAD = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalCAD)
							End If
						
						Case "MflTotalGBP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.MflTotalGBP = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCCopeMainFireMetadata.PropertyNames.MflTotalGBP)
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
		
			Public Sub New(ByVal entity As esViewCCCopeMainFire)
				Me.entity = entity
			End Sub				
		
	
			Public Property RowNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.RowNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RowNumber = Nothing
					Else
						entity.RowNumber = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Id
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Id = Nothing
					Else
						entity.Id = Convert.ToInt32(Value)
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
		  	
			Public Property SurveyDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SurveyDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurveyDate = Nothing
					Else
						entity.SurveyDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consultant As System.String 
				Get
					Dim data_ As System.String = entity.Consultant
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consultant = Nothing
					Else
						entity.Consultant = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As System.String = entity.Units
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Units = Nothing
					Else
						entity.Units = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Currency As System.String 
				Get
					Dim data_ As System.String = entity.Currency
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Currency = Nothing
					Else
						entity.Currency = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIReporting As System.String 
				Get
					Dim data_ As System.String = entity.BIReporting
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIReporting = Nothing
					Else
						entity.BIReporting = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExchangeRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ExchangeRate
					
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
						entity.ExchangeRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Tivpd As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Tivpd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Tivpd = Nothing
					Else
						entity.Tivpd = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Tivbi As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Tivbi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Tivbi = Nothing
					Else
						entity.Tivbi = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TIVTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TIVTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TIVTotal = Nothing
					Else
						entity.TIVTotal = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Aplpd As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Aplpd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aplpd = Nothing
					Else
						entity.Aplpd = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Aplbi As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Aplbi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aplbi = Nothing
					Else
						entity.Aplbi = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.APLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLTotal = Nothing
					Else
						entity.APLTotal = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLPDPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.APLPDPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLPDPercentage = Nothing
					Else
						entity.APLPDPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLBIPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.APLBIPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLBIPercentage = Nothing
					Else
						entity.APLBIPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLTotalPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.APLTotalPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLTotalPercentage = Nothing
					Else
						entity.APLTotalPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pmlpd As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Pmlpd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pmlpd = Nothing
					Else
						entity.Pmlpd = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pmlbi As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Pmlbi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pmlbi = Nothing
					Else
						entity.Pmlbi = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PMLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLTotal = Nothing
					Else
						entity.PMLTotal = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLPDPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PMLPDPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLPDPercentage = Nothing
					Else
						entity.PMLPDPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLBIPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PMLBIPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLBIPercentage = Nothing
					Else
						entity.PMLBIPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLTotalPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PMLTotalPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PMLTotalPercentage = Nothing
					Else
						entity.PMLTotalPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mflpd As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Mflpd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mflpd = Nothing
					Else
						entity.Mflpd = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mflbi As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Mflbi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mflbi = Nothing
					Else
						entity.Mflbi = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MFLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLTotal = Nothing
					Else
						entity.MFLTotal = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLPDPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MFLPDPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLPDPercentage = Nothing
					Else
						entity.MFLPDPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLBIPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MFLBIPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLBIPercentage = Nothing
					Else
						entity.MFLBIPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLTotalPercentage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MFLTotalPercentage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MFLTotalPercentage = Nothing
					Else
						entity.MFLTotalPercentage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Interdependencies As System.String 
				Get
					Dim data_ As System.String = entity.Interdependencies
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Interdependencies = Nothing
					Else
						entity.Interdependencies = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LEandInterdependecyComments As System.String 
				Get
					Dim data_ As System.String = entity.LEandInterdependecyComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LEandInterdependecyComments = Nothing
					Else
						entity.LEandInterdependecyComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SignificantPropertyDamageLossesInPast3Years As System.String 
				Get
					Dim data_ As System.String = entity.SignificantPropertyDamageLossesInPast3Years
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SignificantPropertyDamageLossesInPast3Years = Nothing
					Else
						entity.SignificantPropertyDamageLossesInPast3Years = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SignificantPropertyDescriptionField As System.String 
				Get
					Dim data_ As System.String = entity.SignificantPropertyDescriptionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SignificantPropertyDescriptionField = Nothing
					Else
						entity.SignificantPropertyDescriptionField = Convert.ToString(Value)
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
		  	
			Public Property TivPdUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivPdUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdUSD = Nothing
					Else
						entity.TivPdUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivPdAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdAUD = Nothing
					Else
						entity.TivPdAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivPdJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdJPY = Nothing
					Else
						entity.TivPdJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivPdNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdNZD = Nothing
					Else
						entity.TivPdNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivPdEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdEUR = Nothing
					Else
						entity.TivPdEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivPdMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdMXP = Nothing
					Else
						entity.TivPdMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivPdCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdCAD = Nothing
					Else
						entity.TivPdCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivPdGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdGBP = Nothing
					Else
						entity.TivPdGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivBiUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiUSD = Nothing
					Else
						entity.TivBiUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivBiAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiAUD = Nothing
					Else
						entity.TivBiAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivBiJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiJPY = Nothing
					Else
						entity.TivBiJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivBiNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiNZD = Nothing
					Else
						entity.TivBiNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivBiEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiEUR = Nothing
					Else
						entity.TivBiEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivBiMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiMXP = Nothing
					Else
						entity.TivBiMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivBiCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiCAD = Nothing
					Else
						entity.TivBiCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivBiGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiGBP = Nothing
					Else
						entity.TivBiGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplPdUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdUSD = Nothing
					Else
						entity.AplPdUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplPdAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdAUD = Nothing
					Else
						entity.AplPdAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplPdJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdJPY = Nothing
					Else
						entity.AplPdJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplPdNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdNZD = Nothing
					Else
						entity.AplPdNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplPdEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdEUR = Nothing
					Else
						entity.AplPdEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplPdMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdMXP = Nothing
					Else
						entity.AplPdMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplPdCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdCAD = Nothing
					Else
						entity.AplPdCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplPdGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdGBP = Nothing
					Else
						entity.AplPdGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplBiUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiUSD = Nothing
					Else
						entity.AplBiUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplBiAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiAUD = Nothing
					Else
						entity.AplBiAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplBiJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiJPY = Nothing
					Else
						entity.AplBiJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplBiNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiNZD = Nothing
					Else
						entity.AplBiNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplBiEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiEUR = Nothing
					Else
						entity.AplBiEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplBiMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiMXP = Nothing
					Else
						entity.AplBiMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplBiCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiCAD = Nothing
					Else
						entity.AplBiCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplBiGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiGBP = Nothing
					Else
						entity.AplBiGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlPdUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdUSD = Nothing
					Else
						entity.PmlPdUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlPdAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdAUD = Nothing
					Else
						entity.PmlPdAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlPdJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdJPY = Nothing
					Else
						entity.PmlPdJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlPdNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdNZD = Nothing
					Else
						entity.PmlPdNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlPdEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdEUR = Nothing
					Else
						entity.PmlPdEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlPdMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdMXP = Nothing
					Else
						entity.PmlPdMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlPdCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdCAD = Nothing
					Else
						entity.PmlPdCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlPdGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdGBP = Nothing
					Else
						entity.PmlPdGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlBiUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiUSD = Nothing
					Else
						entity.PmlBiUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlBiAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiAUD = Nothing
					Else
						entity.PmlBiAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlBiJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiJPY = Nothing
					Else
						entity.PmlBiJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlBiNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiNZD = Nothing
					Else
						entity.PmlBiNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlBiEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiEUR = Nothing
					Else
						entity.PmlBiEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlBiMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiMXP = Nothing
					Else
						entity.PmlBiMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlBiCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiCAD = Nothing
					Else
						entity.PmlBiCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlBiGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiGBP = Nothing
					Else
						entity.PmlBiGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflPdUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdUSD = Nothing
					Else
						entity.MflPdUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflPdAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdAUD = Nothing
					Else
						entity.MflPdAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflPdJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdJPY = Nothing
					Else
						entity.MflPdJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflPdNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdNZD = Nothing
					Else
						entity.MflPdNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflPdEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdEUR = Nothing
					Else
						entity.MflPdEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflPdMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdMXP = Nothing
					Else
						entity.MflPdMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflPdCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdCAD = Nothing
					Else
						entity.MflPdCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflPdGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdGBP = Nothing
					Else
						entity.MflPdGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflBiUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiUSD = Nothing
					Else
						entity.MflBiUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflBiAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiAUD = Nothing
					Else
						entity.MflBiAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflBiJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiJPY = Nothing
					Else
						entity.MflBiJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflBiNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiNZD = Nothing
					Else
						entity.MflBiNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflBiEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiEUR = Nothing
					Else
						entity.MflBiEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflBiMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiMXP = Nothing
					Else
						entity.MflBiMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflBiCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiCAD = Nothing
					Else
						entity.MflBiCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflBiGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiGBP = Nothing
					Else
						entity.MflBiGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PmlPdPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdPercent = Nothing
					Else
						entity.PmlPdPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PmlBiPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiPercent = Nothing
					Else
						entity.PmlBiPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PmlTotalPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalPercent = Nothing
					Else
						entity.PmlTotalPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplPdPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.AplPdPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPdPercent = Nothing
					Else
						entity.AplPdPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBiPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.AplBiPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBiPercent = Nothing
					Else
						entity.AplBiPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.AplTotalPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalPercent = Nothing
					Else
						entity.AplTotalPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MflPdPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdPercent = Nothing
					Else
						entity.MflPdPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MflBiPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiPercent = Nothing
					Else
						entity.MflBiPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalPercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MflTotalPercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalPercent = Nothing
					Else
						entity.MflTotalPercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivTotalUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalUSD = Nothing
					Else
						entity.TivTotalUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivTotalAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalAUD = Nothing
					Else
						entity.TivTotalAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivTotalJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalJPY = Nothing
					Else
						entity.TivTotalJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivTotalNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalNZD = Nothing
					Else
						entity.TivTotalNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivTotalEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalEUR = Nothing
					Else
						entity.TivTotalEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivTotalMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalMXP = Nothing
					Else
						entity.TivTotalMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivTotalCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalCAD = Nothing
					Else
						entity.TivTotalCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.TivTotalGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalGBP = Nothing
					Else
						entity.TivTotalGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplTotalUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalUSD = Nothing
					Else
						entity.AplTotalUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplTotalAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalAUD = Nothing
					Else
						entity.AplTotalAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplTotalJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalJPY = Nothing
					Else
						entity.AplTotalJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplTotalNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalNZD = Nothing
					Else
						entity.AplTotalNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplTotalEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalEUR = Nothing
					Else
						entity.AplTotalEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplTotalMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalMXP = Nothing
					Else
						entity.AplTotalMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplTotalCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalCAD = Nothing
					Else
						entity.AplTotalCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplTotalGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.AplTotalGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplTotalGBP = Nothing
					Else
						entity.AplTotalGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlTotalUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalUSD = Nothing
					Else
						entity.PmlTotalUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlTotalAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalAUD = Nothing
					Else
						entity.PmlTotalAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlTotalJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalJPY = Nothing
					Else
						entity.PmlTotalJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlTotalNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalNZD = Nothing
					Else
						entity.PmlTotalNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlTotalEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalEUR = Nothing
					Else
						entity.PmlTotalEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlTotalMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalMXP = Nothing
					Else
						entity.PmlTotalMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlTotalCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalCAD = Nothing
					Else
						entity.PmlTotalCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.PmlTotalGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalGBP = Nothing
					Else
						entity.PmlTotalGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalUSD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflTotalUSD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalUSD = Nothing
					Else
						entity.MflTotalUSD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalAUD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflTotalAUD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalAUD = Nothing
					Else
						entity.MflTotalAUD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalJPY As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflTotalJPY
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalJPY = Nothing
					Else
						entity.MflTotalJPY = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalNZD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflTotalNZD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalNZD = Nothing
					Else
						entity.MflTotalNZD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalEUR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflTotalEUR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalEUR = Nothing
					Else
						entity.MflTotalEUR = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalMXP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflTotalMXP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalMXP = Nothing
					Else
						entity.MflTotalMXP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalCAD As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflTotalCAD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalCAD = Nothing
					Else
						entity.MflTotalCAD = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalGBP As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.MflTotalGBP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalGBP = Nothing
					Else
						entity.MflTotalGBP = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCCopeMainFire
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCCopeMainFireMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCCopeMainFireQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCCopeMainFireQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCCopeMainFireQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCCopeMainFireQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCCopeMainFireQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCCopeMainFireCollection
		Inherits esEntityCollection(Of ViewCCCopeMainFire)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCCopeMainFireMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCCopeMainFireCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCCopeMainFireQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCCopeMainFireQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCCopeMainFireQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCCopeMainFireQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCCopeMainFireQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCCopeMainFireQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCCopeMainFireQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCCopeMainFireQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCCopeMainFireMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "RowNumber" 
					Return Me.RowNumber
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "Latitude" 
					Return Me.Latitude
				Case "Longitude" 
					Return Me.Longitude
				Case "SurveyDate" 
					Return Me.SurveyDate
				Case "Consultant" 
					Return Me.Consultant
				Case "Units" 
					Return Me.Units
				Case "Currency" 
					Return Me.Currency
				Case "BIReporting" 
					Return Me.BIReporting
				Case "ExchangeRate" 
					Return Me.ExchangeRate
				Case "Tivpd" 
					Return Me.Tivpd
				Case "Tivbi" 
					Return Me.Tivbi
				Case "TIVTotal" 
					Return Me.TIVTotal
				Case "Aplpd" 
					Return Me.Aplpd
				Case "Aplbi" 
					Return Me.Aplbi
				Case "APLTotal" 
					Return Me.APLTotal
				Case "APLPDPercentage" 
					Return Me.APLPDPercentage
				Case "APLBIPercentage" 
					Return Me.APLBIPercentage
				Case "APLTotalPercentage" 
					Return Me.APLTotalPercentage
				Case "Pmlpd" 
					Return Me.Pmlpd
				Case "Pmlbi" 
					Return Me.Pmlbi
				Case "PMLTotal" 
					Return Me.PMLTotal
				Case "PMLPDPercentage" 
					Return Me.PMLPDPercentage
				Case "PMLBIPercentage" 
					Return Me.PMLBIPercentage
				Case "PMLTotalPercentage" 
					Return Me.PMLTotalPercentage
				Case "Mflpd" 
					Return Me.Mflpd
				Case "Mflbi" 
					Return Me.Mflbi
				Case "MFLTotal" 
					Return Me.MFLTotal
				Case "MFLPDPercentage" 
					Return Me.MFLPDPercentage
				Case "MFLBIPercentage" 
					Return Me.MFLBIPercentage
				Case "MFLTotalPercentage" 
					Return Me.MFLTotalPercentage
				Case "Interdependencies" 
					Return Me.Interdependencies
				Case "LEandInterdependecyComments" 
					Return Me.LEandInterdependecyComments
				Case "SignificantPropertyDamageLossesInPast3Years" 
					Return Me.SignificantPropertyDamageLossesInPast3Years
				Case "SignificantPropertyDescriptionField" 
					Return Me.SignificantPropertyDescriptionField
				Case "AdminMemo" 
					Return Me.AdminMemo
				Case "TivPdUSD" 
					Return Me.TivPdUSD
				Case "TivPdAUD" 
					Return Me.TivPdAUD
				Case "TivPdJPY" 
					Return Me.TivPdJPY
				Case "TivPdNZD" 
					Return Me.TivPdNZD
				Case "TivPdEUR" 
					Return Me.TivPdEUR
				Case "TivPdMXP" 
					Return Me.TivPdMXP
				Case "TivPdCAD" 
					Return Me.TivPdCAD
				Case "TivPdGBP" 
					Return Me.TivPdGBP
				Case "TivBiUSD" 
					Return Me.TivBiUSD
				Case "TivBiAUD" 
					Return Me.TivBiAUD
				Case "TivBiJPY" 
					Return Me.TivBiJPY
				Case "TivBiNZD" 
					Return Me.TivBiNZD
				Case "TivBiEUR" 
					Return Me.TivBiEUR
				Case "TivBiMXP" 
					Return Me.TivBiMXP
				Case "TivBiCAD" 
					Return Me.TivBiCAD
				Case "TivBiGBP" 
					Return Me.TivBiGBP
				Case "AplPdUSD" 
					Return Me.AplPdUSD
				Case "AplPdAUD" 
					Return Me.AplPdAUD
				Case "AplPdJPY" 
					Return Me.AplPdJPY
				Case "AplPdNZD" 
					Return Me.AplPdNZD
				Case "AplPdEUR" 
					Return Me.AplPdEUR
				Case "AplPdMXP" 
					Return Me.AplPdMXP
				Case "AplPdCAD" 
					Return Me.AplPdCAD
				Case "AplPdGBP" 
					Return Me.AplPdGBP
				Case "AplBiUSD" 
					Return Me.AplBiUSD
				Case "AplBiAUD" 
					Return Me.AplBiAUD
				Case "AplBiJPY" 
					Return Me.AplBiJPY
				Case "AplBiNZD" 
					Return Me.AplBiNZD
				Case "AplBiEUR" 
					Return Me.AplBiEUR
				Case "AplBiMXP" 
					Return Me.AplBiMXP
				Case "AplBiCAD" 
					Return Me.AplBiCAD
				Case "AplBiGBP" 
					Return Me.AplBiGBP
				Case "PmlPdUSD" 
					Return Me.PmlPdUSD
				Case "PmlPdAUD" 
					Return Me.PmlPdAUD
				Case "PmlPdJPY" 
					Return Me.PmlPdJPY
				Case "PmlPdNZD" 
					Return Me.PmlPdNZD
				Case "PmlPdEUR" 
					Return Me.PmlPdEUR
				Case "PmlPdMXP" 
					Return Me.PmlPdMXP
				Case "PmlPdCAD" 
					Return Me.PmlPdCAD
				Case "PmlPdGBP" 
					Return Me.PmlPdGBP
				Case "PmlBiUSD" 
					Return Me.PmlBiUSD
				Case "PmlBiAUD" 
					Return Me.PmlBiAUD
				Case "PmlBiJPY" 
					Return Me.PmlBiJPY
				Case "PmlBiNZD" 
					Return Me.PmlBiNZD
				Case "PmlBiEUR" 
					Return Me.PmlBiEUR
				Case "PmlBiMXP" 
					Return Me.PmlBiMXP
				Case "PmlBiCAD" 
					Return Me.PmlBiCAD
				Case "PmlBiGBP" 
					Return Me.PmlBiGBP
				Case "MflPdUSD" 
					Return Me.MflPdUSD
				Case "MflPdAUD" 
					Return Me.MflPdAUD
				Case "MflPdJPY" 
					Return Me.MflPdJPY
				Case "MflPdNZD" 
					Return Me.MflPdNZD
				Case "MflPdEUR" 
					Return Me.MflPdEUR
				Case "MflPdMXP" 
					Return Me.MflPdMXP
				Case "MflPdCAD" 
					Return Me.MflPdCAD
				Case "MflPdGBP" 
					Return Me.MflPdGBP
				Case "MflBiUSD" 
					Return Me.MflBiUSD
				Case "MflBiAUD" 
					Return Me.MflBiAUD
				Case "MflBiJPY" 
					Return Me.MflBiJPY
				Case "MflBiNZD" 
					Return Me.MflBiNZD
				Case "MflBiEUR" 
					Return Me.MflBiEUR
				Case "MflBiMXP" 
					Return Me.MflBiMXP
				Case "MflBiCAD" 
					Return Me.MflBiCAD
				Case "MflBiGBP" 
					Return Me.MflBiGBP
				Case "PmlPdPercent" 
					Return Me.PmlPdPercent
				Case "PmlBiPercent" 
					Return Me.PmlBiPercent
				Case "PmlTotalPercent" 
					Return Me.PmlTotalPercent
				Case "AplPdPercent" 
					Return Me.AplPdPercent
				Case "AplBiPercent" 
					Return Me.AplBiPercent
				Case "AplTotalPercent" 
					Return Me.AplTotalPercent
				Case "MflPdPercent" 
					Return Me.MflPdPercent
				Case "MflBiPercent" 
					Return Me.MflBiPercent
				Case "MflTotalPercent" 
					Return Me.MflTotalPercent
				Case "TivTotalUSD" 
					Return Me.TivTotalUSD
				Case "TivTotalAUD" 
					Return Me.TivTotalAUD
				Case "TivTotalJPY" 
					Return Me.TivTotalJPY
				Case "TivTotalNZD" 
					Return Me.TivTotalNZD
				Case "TivTotalEUR" 
					Return Me.TivTotalEUR
				Case "TivTotalMXP" 
					Return Me.TivTotalMXP
				Case "TivTotalCAD" 
					Return Me.TivTotalCAD
				Case "TivTotalGBP" 
					Return Me.TivTotalGBP
				Case "AplTotalUSD" 
					Return Me.AplTotalUSD
				Case "AplTotalAUD" 
					Return Me.AplTotalAUD
				Case "AplTotalJPY" 
					Return Me.AplTotalJPY
				Case "AplTotalNZD" 
					Return Me.AplTotalNZD
				Case "AplTotalEUR" 
					Return Me.AplTotalEUR
				Case "AplTotalMXP" 
					Return Me.AplTotalMXP
				Case "AplTotalCAD" 
					Return Me.AplTotalCAD
				Case "AplTotalGBP" 
					Return Me.AplTotalGBP
				Case "PmlTotalUSD" 
					Return Me.PmlTotalUSD
				Case "PmlTotalAUD" 
					Return Me.PmlTotalAUD
				Case "PmlTotalJPY" 
					Return Me.PmlTotalJPY
				Case "PmlTotalNZD" 
					Return Me.PmlTotalNZD
				Case "PmlTotalEUR" 
					Return Me.PmlTotalEUR
				Case "PmlTotalMXP" 
					Return Me.PmlTotalMXP
				Case "PmlTotalCAD" 
					Return Me.PmlTotalCAD
				Case "PmlTotalGBP" 
					Return Me.PmlTotalGBP
				Case "MflTotalUSD" 
					Return Me.MflTotalUSD
				Case "MflTotalAUD" 
					Return Me.MflTotalAUD
				Case "MflTotalJPY" 
					Return Me.MflTotalJPY
				Case "MflTotalNZD" 
					Return Me.MflTotalNZD
				Case "MflTotalEUR" 
					Return Me.MflTotalEUR
				Case "MflTotalMXP" 
					Return Me.MflTotalMXP
				Case "MflTotalCAD" 
					Return Me.MflTotalCAD
				Case "MflTotalGBP" 
					Return Me.MflTotalGBP
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property RowNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.RowNumber, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Consultant As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Consultant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Units, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Currency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Currency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIReporting As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.BIReporting, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.ExchangeRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Tivpd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Tivpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Tivbi As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Tivbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TIVTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Aplpd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Aplpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Aplbi As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Aplbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property APLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.APLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property APLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.APLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property APLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.APLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property APLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.APLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlpd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Pmlpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlbi As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Pmlbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PMLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PMLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PMLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PMLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Mflpd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Mflpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Mflbi As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Mflbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MFLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MFLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MFLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MFLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Interdependencies As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.Interdependencies, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LEandInterdependecyComments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.LEandInterdependecyComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SignificantPropertyDamageLossesInPast3Years As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.SignificantPropertyDamageLossesInPast3Years, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SignificantPropertyDescriptionField As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.SignificantPropertyDescriptionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AdminMemo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AdminMemo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivPdUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivPdAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivPdJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivPdNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivPdEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivPdMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivPdCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivPdGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivBiUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivBiAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivBiJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivBiNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivBiEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivBiMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivBiCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivBiGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlPdPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlBiPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property AplPdPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplPdPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property AplBiPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplBiPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflPdPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflBiPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivTotalUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivTotalAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivTotalJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivTotalNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivTotalEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivTotalMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivTotalCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.TivTotalGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property AplTotalGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.AplTotalGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalGBP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalUSD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalAUD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalJPY, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalNZD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalEUR, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalMXP, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalCAD, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainFireMetadata.ColumnNames.MflTotalGBP, esSystemType.Int64)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCCopeMainFireMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.RowNumber, 0, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.RowNumber
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Id, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.FileNo, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Latitude, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Longitude, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.SurveyDate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Consultant, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Consultant
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Units, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Units
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Currency, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Currency
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.BIReporting, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.BIReporting
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.ExchangeRate, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.ExchangeRate
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Tivpd, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Tivpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Tivbi, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Tivbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TIVTotal, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TIVTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Aplpd, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Aplpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Aplbi, 15, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Aplbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.APLTotal, 16, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.APLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.APLPDPercentage, 17, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.APLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.APLBIPercentage, 18, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.APLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.APLTotalPercentage, 19, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.APLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Pmlpd, 20, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Pmlpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Pmlbi, 21, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Pmlbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PMLTotal, 22, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PMLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PMLPDPercentage, 23, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PMLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PMLBIPercentage, 24, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PMLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PMLTotalPercentage, 25, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PMLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Mflpd, 26, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Mflpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Mflbi, 27, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Mflbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MFLTotal, 28, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MFLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MFLPDPercentage, 29, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MFLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MFLBIPercentage, 30, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MFLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MFLTotalPercentage, 31, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MFLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.Interdependencies, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.Interdependencies
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.LEandInterdependecyComments, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.LEandInterdependecyComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.SignificantPropertyDamageLossesInPast3Years, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.SignificantPropertyDamageLossesInPast3Years
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.SignificantPropertyDescriptionField, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.SignificantPropertyDescriptionField
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AdminMemo, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AdminMemo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivPdUSD, 37, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivPdUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivPdAUD, 38, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivPdAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivPdJPY, 39, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivPdJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivPdNZD, 40, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivPdNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivPdEUR, 41, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivPdEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivPdMXP, 42, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivPdMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivPdCAD, 43, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivPdCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivPdGBP, 44, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivPdGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivBiUSD, 45, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivBiUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivBiAUD, 46, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivBiAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivBiJPY, 47, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivBiJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivBiNZD, 48, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivBiNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivBiEUR, 49, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivBiEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivBiMXP, 50, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivBiMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivBiCAD, 51, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivBiCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivBiGBP, 52, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivBiGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdUSD, 53, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdAUD, 54, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdJPY, 55, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdNZD, 56, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdEUR, 57, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdMXP, 58, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdCAD, 59, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdGBP, 60, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiUSD, 61, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiAUD, 62, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiJPY, 63, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiNZD, 64, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiEUR, 65, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiMXP, 66, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiCAD, 67, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiGBP, 68, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdUSD, 69, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdAUD, 70, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdJPY, 71, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdNZD, 72, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdEUR, 73, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdMXP, 74, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdCAD, 75, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdGBP, 76, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiUSD, 77, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiAUD, 78, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiJPY, 79, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiNZD, 80, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiEUR, 81, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiMXP, 82, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiCAD, 83, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiGBP, 84, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdUSD, 85, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdAUD, 86, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdJPY, 87, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdNZD, 88, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdEUR, 89, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdMXP, 90, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdCAD, 91, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdGBP, 92, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiUSD, 93, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiAUD, 94, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiJPY, 95, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiNZD, 96, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiEUR, 97, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiMXP, 98, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiCAD, 99, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiGBP, 100, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlPdPercent, 101, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlPdPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlBiPercent, 102, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlBiPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalPercent, 103, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplPdPercent, 104, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplPdPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplBiPercent, 105, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplBiPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalPercent, 106, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflPdPercent, 107, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflPdPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflBiPercent, 108, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflBiPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalPercent, 109, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalUSD, 110, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivTotalUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalAUD, 111, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivTotalAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalJPY, 112, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivTotalJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalNZD, 113, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivTotalNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalEUR, 114, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivTotalEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalMXP, 115, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivTotalMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalCAD, 116, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivTotalCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.TivTotalGBP, 117, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.TivTotalGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalUSD, 118, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalAUD, 119, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalJPY, 120, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalNZD, 121, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalEUR, 122, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalMXP, 123, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalCAD, 124, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.AplTotalGBP, 125, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.AplTotalGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalUSD, 126, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalAUD, 127, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalJPY, 128, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalNZD, 129, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalEUR, 130, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalMXP, 131, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalCAD, 132, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.PmlTotalGBP, 133, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.PmlTotalGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalUSD, 134, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalUSD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalAUD, 135, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalAUD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalJPY, 136, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalJPY
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalNZD, 137, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalNZD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalEUR, 138, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalEUR
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalMXP, 139, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalMXP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalCAD, 140, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalCAD
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainFireMetadata.ColumnNames.MflTotalGBP, 141, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainFireMetadata.PropertyNames.MflTotalGBP
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCCopeMainFireMetadata
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
			 Public Const RowNumber As String = "RowNumber"
			 Public Const Id As String = "ID"
			 Public Const FileNo As String = "FileNo"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Consultant As String = "Consultant"
			 Public Const Units As String = "Units"
			 Public Const Currency As String = "Currency"
			 Public Const BIReporting As String = "BIReporting"
			 Public Const ExchangeRate As String = "ExchangeRate"
			 Public Const Tivpd As String = "TIVPD"
			 Public Const Tivbi As String = "TIVBI"
			 Public Const TIVTotal As String = "TIVTotal"
			 Public Const Aplpd As String = "APLPD"
			 Public Const Aplbi As String = "APLBI"
			 Public Const APLTotal As String = "APLTotal"
			 Public Const APLPDPercentage As String = "APLPDPercentage"
			 Public Const APLBIPercentage As String = "APLBIPercentage"
			 Public Const APLTotalPercentage As String = "APLTotalPercentage"
			 Public Const Pmlpd As String = "PMLPD"
			 Public Const Pmlbi As String = "PMLBI"
			 Public Const PMLTotal As String = "PMLTotal"
			 Public Const PMLPDPercentage As String = "PMLPDPercentage"
			 Public Const PMLBIPercentage As String = "PMLBIPercentage"
			 Public Const PMLTotalPercentage As String = "PMLTotalPercentage"
			 Public Const Mflpd As String = "MFLPD"
			 Public Const Mflbi As String = "MFLBI"
			 Public Const MFLTotal As String = "MFLTotal"
			 Public Const MFLPDPercentage As String = "MFLPDPercentage"
			 Public Const MFLBIPercentage As String = "MFLBIPercentage"
			 Public Const MFLTotalPercentage As String = "MFLTotalPercentage"
			 Public Const Interdependencies As String = "Interdependencies"
			 Public Const LEandInterdependecyComments As String = "LEandInterdependecyComments"
			 Public Const SignificantPropertyDamageLossesInPast3Years As String = "SignificantPropertyDamageLossesInPast3Years"
			 Public Const SignificantPropertyDescriptionField As String = "SignificantPropertyDescriptionField"
			 Public Const AdminMemo As String = "AdminMemo"
			 Public Const TivPdUSD As String = "TivPdUSD"
			 Public Const TivPdAUD As String = "TivPdAUD"
			 Public Const TivPdJPY As String = "TivPdJPY"
			 Public Const TivPdNZD As String = "TivPdNZD"
			 Public Const TivPdEUR As String = "TivPdEUR"
			 Public Const TivPdMXP As String = "TivPdMXP"
			 Public Const TivPdCAD As String = "TivPdCAD"
			 Public Const TivPdGBP As String = "TivPdGBP"
			 Public Const TivBiUSD As String = "TivBiUSD"
			 Public Const TivBiAUD As String = "TivBiAUD"
			 Public Const TivBiJPY As String = "TivBiJPY"
			 Public Const TivBiNZD As String = "TivBiNZD"
			 Public Const TivBiEUR As String = "TivBiEUR"
			 Public Const TivBiMXP As String = "TivBiMXP"
			 Public Const TivBiCAD As String = "TivBiCAD"
			 Public Const TivBiGBP As String = "TivBiGBP"
			 Public Const AplPdUSD As String = "AplPdUSD"
			 Public Const AplPdAUD As String = "AplPdAUD"
			 Public Const AplPdJPY As String = "AplPdJPY"
			 Public Const AplPdNZD As String = "AplPdNZD"
			 Public Const AplPdEUR As String = "AplPdEUR"
			 Public Const AplPdMXP As String = "AplPdMXP"
			 Public Const AplPdCAD As String = "AplPdCAD"
			 Public Const AplPdGBP As String = "AplPdGBP"
			 Public Const AplBiUSD As String = "AplBiUSD"
			 Public Const AplBiAUD As String = "AplBiAUD"
			 Public Const AplBiJPY As String = "AplBiJPY"
			 Public Const AplBiNZD As String = "AplBiNZD"
			 Public Const AplBiEUR As String = "AplBiEUR"
			 Public Const AplBiMXP As String = "AplBiMXP"
			 Public Const AplBiCAD As String = "AplBiCAD"
			 Public Const AplBiGBP As String = "AplBiGBP"
			 Public Const PmlPdUSD As String = "PmlPdUSD"
			 Public Const PmlPdAUD As String = "PmlPdAUD"
			 Public Const PmlPdJPY As String = "PmlPdJPY"
			 Public Const PmlPdNZD As String = "PmlPdNZD"
			 Public Const PmlPdEUR As String = "PmlPdEUR"
			 Public Const PmlPdMXP As String = "PmlPdMXP"
			 Public Const PmlPdCAD As String = "PmlPdCAD"
			 Public Const PmlPdGBP As String = "PmlPdGBP"
			 Public Const PmlBiUSD As String = "PmlBiUSD"
			 Public Const PmlBiAUD As String = "PmlBiAUD"
			 Public Const PmlBiJPY As String = "PmlBiJPY"
			 Public Const PmlBiNZD As String = "PmlBiNZD"
			 Public Const PmlBiEUR As String = "PmlBiEUR"
			 Public Const PmlBiMXP As String = "PmlBiMXP"
			 Public Const PmlBiCAD As String = "PmlBiCAD"
			 Public Const PmlBiGBP As String = "PmlBiGBP"
			 Public Const MflPdUSD As String = "MflPdUSD"
			 Public Const MflPdAUD As String = "MflPdAUD"
			 Public Const MflPdJPY As String = "MflPdJPY"
			 Public Const MflPdNZD As String = "MflPdNZD"
			 Public Const MflPdEUR As String = "MflPdEUR"
			 Public Const MflPdMXP As String = "MflPdMXP"
			 Public Const MflPdCAD As String = "MflPdCAD"
			 Public Const MflPdGBP As String = "MflPdGBP"
			 Public Const MflBiUSD As String = "MflBiUSD"
			 Public Const MflBiAUD As String = "MflBiAUD"
			 Public Const MflBiJPY As String = "MflBiJPY"
			 Public Const MflBiNZD As String = "MflBiNZD"
			 Public Const MflBiEUR As String = "MflBiEUR"
			 Public Const MflBiMXP As String = "MflBiMXP"
			 Public Const MflBiCAD As String = "MflBiCAD"
			 Public Const MflBiGBP As String = "MflBiGBP"
			 Public Const PmlPdPercent As String = "PmlPdPercent"
			 Public Const PmlBiPercent As String = "PmlBiPercent"
			 Public Const PmlTotalPercent As String = "PmlTotalPercent"
			 Public Const AplPdPercent As String = "AplPdPercent"
			 Public Const AplBiPercent As String = "AplBiPercent"
			 Public Const AplTotalPercent As String = "AplTotalPercent"
			 Public Const MflPdPercent As String = "MflPdPercent"
			 Public Const MflBiPercent As String = "MflBiPercent"
			 Public Const MflTotalPercent As String = "MflTotalPercent"
			 Public Const TivTotalUSD As String = "TivTotalUSD"
			 Public Const TivTotalAUD As String = "TivTotalAUD"
			 Public Const TivTotalJPY As String = "TivTotalJPY"
			 Public Const TivTotalNZD As String = "TivTotalNZD"
			 Public Const TivTotalEUR As String = "TivTotalEUR"
			 Public Const TivTotalMXP As String = "TivTotalMXP"
			 Public Const TivTotalCAD As String = "TivTotalCAD"
			 Public Const TivTotalGBP As String = "TivTotalGBP"
			 Public Const AplTotalUSD As String = "AplTotalUSD"
			 Public Const AplTotalAUD As String = "AplTotalAUD"
			 Public Const AplTotalJPY As String = "AplTotalJPY"
			 Public Const AplTotalNZD As String = "AplTotalNZD"
			 Public Const AplTotalEUR As String = "AplTotalEUR"
			 Public Const AplTotalMXP As String = "AplTotalMXP"
			 Public Const AplTotalCAD As String = "AplTotalCAD"
			 Public Const AplTotalGBP As String = "AplTotalGBP"
			 Public Const PmlTotalUSD As String = "PmlTotalUSD"
			 Public Const PmlTotalAUD As String = "PmlTotalAUD"
			 Public Const PmlTotalJPY As String = "PmlTotalJPY"
			 Public Const PmlTotalNZD As String = "PmlTotalNZD"
			 Public Const PmlTotalEUR As String = "PmlTotalEUR"
			 Public Const PmlTotalMXP As String = "PmlTotalMXP"
			 Public Const PmlTotalCAD As String = "PmlTotalCAD"
			 Public Const PmlTotalGBP As String = "PmlTotalGBP"
			 Public Const MflTotalUSD As String = "MflTotalUSD"
			 Public Const MflTotalAUD As String = "MflTotalAUD"
			 Public Const MflTotalJPY As String = "MflTotalJPY"
			 Public Const MflTotalNZD As String = "MflTotalNZD"
			 Public Const MflTotalEUR As String = "MflTotalEUR"
			 Public Const MflTotalMXP As String = "MflTotalMXP"
			 Public Const MflTotalCAD As String = "MflTotalCAD"
			 Public Const MflTotalGBP As String = "MflTotalGBP"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const RowNumber As String = "RowNumber"
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Consultant As String = "Consultant"
			 Public Const Units As String = "Units"
			 Public Const Currency As String = "Currency"
			 Public Const BIReporting As String = "BIReporting"
			 Public Const ExchangeRate As String = "ExchangeRate"
			 Public Const Tivpd As String = "Tivpd"
			 Public Const Tivbi As String = "Tivbi"
			 Public Const TIVTotal As String = "TIVTotal"
			 Public Const Aplpd As String = "Aplpd"
			 Public Const Aplbi As String = "Aplbi"
			 Public Const APLTotal As String = "APLTotal"
			 Public Const APLPDPercentage As String = "APLPDPercentage"
			 Public Const APLBIPercentage As String = "APLBIPercentage"
			 Public Const APLTotalPercentage As String = "APLTotalPercentage"
			 Public Const Pmlpd As String = "Pmlpd"
			 Public Const Pmlbi As String = "Pmlbi"
			 Public Const PMLTotal As String = "PMLTotal"
			 Public Const PMLPDPercentage As String = "PMLPDPercentage"
			 Public Const PMLBIPercentage As String = "PMLBIPercentage"
			 Public Const PMLTotalPercentage As String = "PMLTotalPercentage"
			 Public Const Mflpd As String = "Mflpd"
			 Public Const Mflbi As String = "Mflbi"
			 Public Const MFLTotal As String = "MFLTotal"
			 Public Const MFLPDPercentage As String = "MFLPDPercentage"
			 Public Const MFLBIPercentage As String = "MFLBIPercentage"
			 Public Const MFLTotalPercentage As String = "MFLTotalPercentage"
			 Public Const Interdependencies As String = "Interdependencies"
			 Public Const LEandInterdependecyComments As String = "LEandInterdependecyComments"
			 Public Const SignificantPropertyDamageLossesInPast3Years As String = "SignificantPropertyDamageLossesInPast3Years"
			 Public Const SignificantPropertyDescriptionField As String = "SignificantPropertyDescriptionField"
			 Public Const AdminMemo As String = "AdminMemo"
			 Public Const TivPdUSD As String = "TivPdUSD"
			 Public Const TivPdAUD As String = "TivPdAUD"
			 Public Const TivPdJPY As String = "TivPdJPY"
			 Public Const TivPdNZD As String = "TivPdNZD"
			 Public Const TivPdEUR As String = "TivPdEUR"
			 Public Const TivPdMXP As String = "TivPdMXP"
			 Public Const TivPdCAD As String = "TivPdCAD"
			 Public Const TivPdGBP As String = "TivPdGBP"
			 Public Const TivBiUSD As String = "TivBiUSD"
			 Public Const TivBiAUD As String = "TivBiAUD"
			 Public Const TivBiJPY As String = "TivBiJPY"
			 Public Const TivBiNZD As String = "TivBiNZD"
			 Public Const TivBiEUR As String = "TivBiEUR"
			 Public Const TivBiMXP As String = "TivBiMXP"
			 Public Const TivBiCAD As String = "TivBiCAD"
			 Public Const TivBiGBP As String = "TivBiGBP"
			 Public Const AplPdUSD As String = "AplPdUSD"
			 Public Const AplPdAUD As String = "AplPdAUD"
			 Public Const AplPdJPY As String = "AplPdJPY"
			 Public Const AplPdNZD As String = "AplPdNZD"
			 Public Const AplPdEUR As String = "AplPdEUR"
			 Public Const AplPdMXP As String = "AplPdMXP"
			 Public Const AplPdCAD As String = "AplPdCAD"
			 Public Const AplPdGBP As String = "AplPdGBP"
			 Public Const AplBiUSD As String = "AplBiUSD"
			 Public Const AplBiAUD As String = "AplBiAUD"
			 Public Const AplBiJPY As String = "AplBiJPY"
			 Public Const AplBiNZD As String = "AplBiNZD"
			 Public Const AplBiEUR As String = "AplBiEUR"
			 Public Const AplBiMXP As String = "AplBiMXP"
			 Public Const AplBiCAD As String = "AplBiCAD"
			 Public Const AplBiGBP As String = "AplBiGBP"
			 Public Const PmlPdUSD As String = "PmlPdUSD"
			 Public Const PmlPdAUD As String = "PmlPdAUD"
			 Public Const PmlPdJPY As String = "PmlPdJPY"
			 Public Const PmlPdNZD As String = "PmlPdNZD"
			 Public Const PmlPdEUR As String = "PmlPdEUR"
			 Public Const PmlPdMXP As String = "PmlPdMXP"
			 Public Const PmlPdCAD As String = "PmlPdCAD"
			 Public Const PmlPdGBP As String = "PmlPdGBP"
			 Public Const PmlBiUSD As String = "PmlBiUSD"
			 Public Const PmlBiAUD As String = "PmlBiAUD"
			 Public Const PmlBiJPY As String = "PmlBiJPY"
			 Public Const PmlBiNZD As String = "PmlBiNZD"
			 Public Const PmlBiEUR As String = "PmlBiEUR"
			 Public Const PmlBiMXP As String = "PmlBiMXP"
			 Public Const PmlBiCAD As String = "PmlBiCAD"
			 Public Const PmlBiGBP As String = "PmlBiGBP"
			 Public Const MflPdUSD As String = "MflPdUSD"
			 Public Const MflPdAUD As String = "MflPdAUD"
			 Public Const MflPdJPY As String = "MflPdJPY"
			 Public Const MflPdNZD As String = "MflPdNZD"
			 Public Const MflPdEUR As String = "MflPdEUR"
			 Public Const MflPdMXP As String = "MflPdMXP"
			 Public Const MflPdCAD As String = "MflPdCAD"
			 Public Const MflPdGBP As String = "MflPdGBP"
			 Public Const MflBiUSD As String = "MflBiUSD"
			 Public Const MflBiAUD As String = "MflBiAUD"
			 Public Const MflBiJPY As String = "MflBiJPY"
			 Public Const MflBiNZD As String = "MflBiNZD"
			 Public Const MflBiEUR As String = "MflBiEUR"
			 Public Const MflBiMXP As String = "MflBiMXP"
			 Public Const MflBiCAD As String = "MflBiCAD"
			 Public Const MflBiGBP As String = "MflBiGBP"
			 Public Const PmlPdPercent As String = "PmlPdPercent"
			 Public Const PmlBiPercent As String = "PmlBiPercent"
			 Public Const PmlTotalPercent As String = "PmlTotalPercent"
			 Public Const AplPdPercent As String = "AplPdPercent"
			 Public Const AplBiPercent As String = "AplBiPercent"
			 Public Const AplTotalPercent As String = "AplTotalPercent"
			 Public Const MflPdPercent As String = "MflPdPercent"
			 Public Const MflBiPercent As String = "MflBiPercent"
			 Public Const MflTotalPercent As String = "MflTotalPercent"
			 Public Const TivTotalUSD As String = "TivTotalUSD"
			 Public Const TivTotalAUD As String = "TivTotalAUD"
			 Public Const TivTotalJPY As String = "TivTotalJPY"
			 Public Const TivTotalNZD As String = "TivTotalNZD"
			 Public Const TivTotalEUR As String = "TivTotalEUR"
			 Public Const TivTotalMXP As String = "TivTotalMXP"
			 Public Const TivTotalCAD As String = "TivTotalCAD"
			 Public Const TivTotalGBP As String = "TivTotalGBP"
			 Public Const AplTotalUSD As String = "AplTotalUSD"
			 Public Const AplTotalAUD As String = "AplTotalAUD"
			 Public Const AplTotalJPY As String = "AplTotalJPY"
			 Public Const AplTotalNZD As String = "AplTotalNZD"
			 Public Const AplTotalEUR As String = "AplTotalEUR"
			 Public Const AplTotalMXP As String = "AplTotalMXP"
			 Public Const AplTotalCAD As String = "AplTotalCAD"
			 Public Const AplTotalGBP As String = "AplTotalGBP"
			 Public Const PmlTotalUSD As String = "PmlTotalUSD"
			 Public Const PmlTotalAUD As String = "PmlTotalAUD"
			 Public Const PmlTotalJPY As String = "PmlTotalJPY"
			 Public Const PmlTotalNZD As String = "PmlTotalNZD"
			 Public Const PmlTotalEUR As String = "PmlTotalEUR"
			 Public Const PmlTotalMXP As String = "PmlTotalMXP"
			 Public Const PmlTotalCAD As String = "PmlTotalCAD"
			 Public Const PmlTotalGBP As String = "PmlTotalGBP"
			 Public Const MflTotalUSD As String = "MflTotalUSD"
			 Public Const MflTotalAUD As String = "MflTotalAUD"
			 Public Const MflTotalJPY As String = "MflTotalJPY"
			 Public Const MflTotalNZD As String = "MflTotalNZD"
			 Public Const MflTotalEUR As String = "MflTotalEUR"
			 Public Const MflTotalMXP As String = "MflTotalMXP"
			 Public Const MflTotalCAD As String = "MflTotalCAD"
			 Public Const MflTotalGBP As String = "MflTotalGBP"
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
			SyncLock GetType(ViewCCCopeMainFireMetadata)
			
				If ViewCCCopeMainFireMetadata.mapDelegates Is Nothing Then
					ViewCCCopeMainFireMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCCopeMainFireMetadata._meta Is Nothing Then
					ViewCCCopeMainFireMetadata._meta = New ViewCCCopeMainFireMetadata()
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
				


				meta.AddTypeMap("RowNumber", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("SurveyDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Consultant", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Currency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIReporting", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExchangeRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Tivpd", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Tivbi", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TIVTotal", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Aplpd", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Aplbi", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("APLTotal", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("APLPDPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("APLBIPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("APLTotalPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Pmlpd", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Pmlbi", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PMLTotal", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PMLPDPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PMLBIPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PMLTotalPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Mflpd", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Mflbi", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MFLTotal", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MFLPDPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MFLBIPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MFLTotalPercentage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Interdependencies", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LEandInterdependecyComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SignificantPropertyDamageLossesInPast3Years", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SignificantPropertyDescriptionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("AdminMemo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivPdUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivPdAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivPdJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivPdNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivPdEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivPdMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivPdCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivPdGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivBiUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivBiAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivBiJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivBiNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivBiEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivBiMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivBiCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivBiGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplPdUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplPdAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplPdJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplPdNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplPdEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplPdMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplPdCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplPdGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplBiUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplBiAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplBiJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplBiNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplBiEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplBiMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplBiCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplBiGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlBiUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlBiAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlBiJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlBiNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlBiEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlBiMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlBiCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlBiGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflPdUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflPdAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflPdJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflPdNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflPdEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflPdMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflPdCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflPdGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflBiUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflBiAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflBiJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflBiNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflBiEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflBiMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflBiCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflBiGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlPdPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PmlBiPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PmlTotalPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("AplPdPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("AplBiPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("AplTotalPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("MflPdPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("MflBiPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("MflTotalPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("TivTotalUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivTotalAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivTotalJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivTotalNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivTotalEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivTotalMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivTotalCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("TivTotalGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplTotalUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplTotalAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplTotalJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplTotalNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplTotalEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplTotalMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplTotalCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("AplTotalGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlTotalUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlTotalAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlTotalJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlTotalNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlTotalEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlTotalMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlTotalCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("PmlTotalGBP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflTotalUSD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflTotalAUD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflTotalJPY", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflTotalNZD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflTotalEUR", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflTotalMXP", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflTotalCAD", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("MflTotalGBP", new esTypeMap("bigint", "System.Int64"))			
				
				
				 
				meta.Source = "viewCCCopeMainFire"
				meta.Destination = "viewCCCopeMainFire"
				
				meta.spInsert = "proc_viewCCCopeMainFireInsert"
				meta.spUpdate = "proc_viewCCCopeMainFireUpdate"
				meta.spDelete = "proc_viewCCCopeMainFireDelete"
				meta.spLoadAll = "proc_viewCCCopeMainFireLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCCopeMainFireLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCCopeMainFireMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
