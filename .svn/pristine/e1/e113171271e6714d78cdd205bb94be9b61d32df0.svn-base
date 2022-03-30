
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
	' Encapsulates the 'viewCCCopeMainBM' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCCopeMainBM))> _
	<XmlType("ViewCCCopeMainBM")> _	
	Partial Public Class ViewCCCopeMainBM 
		Inherits esViewCCCopeMainBM
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCCopeMainBM()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCCopeMainBMCollection")> _
	Partial Public Class ViewCCCopeMainBMCollection
		Inherits esViewCCCopeMainBMCollection
		Implements IEnumerable(Of ViewCCCopeMainBM)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCCopeMainBM))> _
		Public Class ViewCCCopeMainBMCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCCopeMainBMCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCCopeMainBMCollectionWCFPacket) As ViewCCCopeMainBMCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCCopeMainBMCollection) As ViewCCCopeMainBMCollectionWCFPacket
				Return New ViewCCCopeMainBMCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCCopeMainBMQuery 
		Inherits esViewCCCopeMainBMQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCCopeMainBMQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCCopeMainBMQuery) As String
			Return ViewCCCopeMainBMQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCCopeMainBMQuery
			Return DirectCast(ViewCCCopeMainBMQuery.SerializeHelper.FromXml(query, GetType(ViewCCCopeMainBMQuery)), ViewCCCopeMainBMQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCCopeMainBM
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCCopeMainBM.RowNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RowNumber As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCCopeMainBMMetadata.ColumnNames.RowNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCCopeMainBMMetadata.ColumnNames.RowNumber, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.RowNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCCopeMainBMMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCCopeMainBMMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.Currency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Currency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.Currency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.Currency, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Currency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.BIReporting
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIReporting As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.BIReporting)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.BIReporting, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.BIReporting)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.ExchangeRate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.ExchangeRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.ExchangeRate, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.ExchangeRate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.ReptPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReptPD As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.ReptPD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.ReptPD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.ReptPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.ReptBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReptBI As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.ReptBI)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.ReptBI, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.ReptBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.ReptTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReptTIV As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.ReptTIV)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.ReptTIV, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.ReptTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PMLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.Pmlpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.Pmlpd, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Pmlpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PMLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.Pmlbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.Pmlbi, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Pmlbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PMLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.PMLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.PMLTotal, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PMLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PMLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.PMLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.PMLPDPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PMLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PMLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.PMLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.PMLBIPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PMLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PMLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.PMLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.PMLTotalPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PMLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MFLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.Mflpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.Mflpd, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Mflpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MFLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.Mflbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.Mflbi, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Mflbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MFLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.MFLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.MFLTotal, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MFLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MFLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.MFLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.MFLPDPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MFLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MFLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.MFLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.MFLBIPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MFLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MFLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.MFLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCCopeMainBMMetadata.ColumnNames.MFLTotalPercentage, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MFLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.Interdependencies
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Interdependencies As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.Interdependencies)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.Interdependencies, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Interdependencies)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.LEandInterdependecyComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEandInterdependecyComments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.LEandInterdependecyComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.LEandInterdependecyComments, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.LEandInterdependecyComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.SignificantB&MDamageLossesInPast3Years
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SignificantBMDamageLossesInPast3Years As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.SignificantBMDamageLossesInPast3Years)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.SignificantBMDamageLossesInPast3Years, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.SignificantBMDamageLossesInPast3Years)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.SignificantB&MDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SignificantBMDescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.SignificantBMDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.SignificantBMDescription, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.SignificantBMDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCCopeMainBMMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCCopeMainBMMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivPdUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivPdUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivPdAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivPdAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivPdJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivPdJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivPdNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivPdNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivPdEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivPdEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivPdMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivPdMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivPdCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivPdCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivPdGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivPdGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivPdGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivPdGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivBiUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivBiUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivBiAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivBiAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivBiJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivBiJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivBiNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivBiNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivBiEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivBiEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivBiMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivBiMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivBiCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivBiCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivBiGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivBiGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivBiGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivBiGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflPdGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflBiGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlPdPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPdPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlBiPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBiPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflPdPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPdPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.MflPdPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.MflPdPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflBiPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBiPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.MflBiPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.MflBiPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalPercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalPercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalPercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalPercent, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalPercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivTotalUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivTotalUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivTotalAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivTotalAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivTotalJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivTotalJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivTotalNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivTotalNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivTotalEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivTotalEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivTotalMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivTotalMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivTotalCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivTotalCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.TivTotalGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TivTotalGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.TivTotalGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.PmlTotalGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlTotalGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalGBP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalUSD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalUSD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalUSD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalUSD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalUSD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalAUD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalAUD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalAUD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalAUD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalAUD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalJPY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalJPY As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalJPY)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalJPY, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalJPY)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalNZD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalNZD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalNZD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalNZD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalNZD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalEUR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalEUR As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalEUR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalEUR, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalEUR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalMXP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalMXP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalMXP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalMXP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalMXP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalCAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalCAD As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalCAD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalCAD, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalCAD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCCopeMainBM.MflTotalGBP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflTotalGBP As System.String
			Get
				Return MyBase.GetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalGBP)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalGBP, value) Then
					OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalGBP)
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
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "SurveyDate"
							Me.str().SurveyDate = CType(value, string)
												
						Case "Engineer"
							Me.str().Engineer = CType(value, string)
												
						Case "Currency"
							Me.str().Currency = CType(value, string)
												
						Case "BIReporting"
							Me.str().BIReporting = CType(value, string)
												
						Case "ExchangeRate"
							Me.str().ExchangeRate = CType(value, string)
												
						Case "ReptPD"
							Me.str().ReptPD = CType(value, string)
												
						Case "ReptBI"
							Me.str().ReptBI = CType(value, string)
												
						Case "ReptTIV"
							Me.str().ReptTIV = CType(value, string)
												
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
												
						Case "SignificantBMDamageLossesInPast3Years"
							Me.str().SignificantBMDamageLossesInPast3Years = CType(value, string)
												
						Case "SignificantBMDescription"
							Me.str().SignificantBMDescription = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
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
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.RowNumber)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "ExchangeRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ExchangeRate = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.ExchangeRate)
							End If
						
						Case "ReptPD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ReptPD = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.ReptPD)
							End If
						
						Case "ReptBI"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ReptBI = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.ReptBI)
							End If
						
						Case "ReptTIV"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ReptTIV = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.ReptTIV)
							End If
						
						Case "Pmlpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pmlpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Pmlpd)
							End If
						
						Case "Pmlbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pmlbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Pmlbi)
							End If
						
						Case "PMLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PMLTotal)
							End If
						
						Case "PMLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PMLPDPercentage)
							End If
						
						Case "PMLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PMLBIPercentage)
							End If
						
						Case "PMLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PMLTotalPercentage)
							End If
						
						Case "Mflpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Mflpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Mflpd)
							End If
						
						Case "Mflbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Mflbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.Mflbi)
							End If
						
						Case "MFLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MFLTotal)
							End If
						
						Case "MFLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MFLPDPercentage)
							End If
						
						Case "MFLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MFLBIPercentage)
							End If
						
						Case "MFLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MFLTotalPercentage)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "PmlPdPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PmlPdPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlPdPercent)
							End If
						
						Case "PmlBiPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PmlBiPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlBiPercent)
							End If
						
						Case "PmlTotalPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PmlTotalPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalPercent)
							End If
						
						Case "MflPdPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MflPdPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflPdPercent)
							End If
						
						Case "MflBiPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MflBiPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflBiPercent)
							End If
						
						Case "MflTotalPercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MflTotalPercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCCopeMainBMMetadata.PropertyNames.MflTotalPercent)
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
		
			Public Sub New(ByVal entity As esViewCCCopeMainBM)
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
		  	
			Public Property ReptPD As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ReptPD
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReptPD = Nothing
					Else
						entity.ReptPD = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReptBI As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ReptBI
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReptBI = Nothing
					Else
						entity.ReptBI = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReptTIV As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ReptTIV
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReptTIV = Nothing
					Else
						entity.ReptTIV = Convert.ToDouble(Value)
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
		  	
			Public Property SignificantBMDamageLossesInPast3Years As System.String 
				Get
					Dim data_ As System.String = entity.SignificantBMDamageLossesInPast3Years
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SignificantBMDamageLossesInPast3Years = Nothing
					Else
						entity.SignificantBMDamageLossesInPast3Years = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SignificantBMDescription As System.String 
				Get
					Dim data_ As System.String = entity.SignificantBMDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SignificantBMDescription = Nothing
					Else
						entity.SignificantBMDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property TivPdUSD As System.String 
				Get
					Dim data_ As System.String = entity.TivPdUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdUSD = Nothing
					Else
						entity.TivPdUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdAUD As System.String 
				Get
					Dim data_ As System.String = entity.TivPdAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdAUD = Nothing
					Else
						entity.TivPdAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdJPY As System.String 
				Get
					Dim data_ As System.String = entity.TivPdJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdJPY = Nothing
					Else
						entity.TivPdJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdNZD As System.String 
				Get
					Dim data_ As System.String = entity.TivPdNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdNZD = Nothing
					Else
						entity.TivPdNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdEUR As System.String 
				Get
					Dim data_ As System.String = entity.TivPdEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdEUR = Nothing
					Else
						entity.TivPdEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdMXP As System.String 
				Get
					Dim data_ As System.String = entity.TivPdMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdMXP = Nothing
					Else
						entity.TivPdMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdCAD As System.String 
				Get
					Dim data_ As System.String = entity.TivPdCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdCAD = Nothing
					Else
						entity.TivPdCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivPdGBP As System.String 
				Get
					Dim data_ As System.String = entity.TivPdGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivPdGBP = Nothing
					Else
						entity.TivPdGBP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiUSD As System.String 
				Get
					Dim data_ As System.String = entity.TivBiUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiUSD = Nothing
					Else
						entity.TivBiUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiAUD As System.String 
				Get
					Dim data_ As System.String = entity.TivBiAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiAUD = Nothing
					Else
						entity.TivBiAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiJPY As System.String 
				Get
					Dim data_ As System.String = entity.TivBiJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiJPY = Nothing
					Else
						entity.TivBiJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiNZD As System.String 
				Get
					Dim data_ As System.String = entity.TivBiNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiNZD = Nothing
					Else
						entity.TivBiNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiEUR As System.String 
				Get
					Dim data_ As System.String = entity.TivBiEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiEUR = Nothing
					Else
						entity.TivBiEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiMXP As System.String 
				Get
					Dim data_ As System.String = entity.TivBiMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiMXP = Nothing
					Else
						entity.TivBiMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiCAD As System.String 
				Get
					Dim data_ As System.String = entity.TivBiCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiCAD = Nothing
					Else
						entity.TivBiCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivBiGBP As System.String 
				Get
					Dim data_ As System.String = entity.TivBiGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivBiGBP = Nothing
					Else
						entity.TivBiGBP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdUSD As System.String 
				Get
					Dim data_ As System.String = entity.PmlPdUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdUSD = Nothing
					Else
						entity.PmlPdUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdAUD As System.String 
				Get
					Dim data_ As System.String = entity.PmlPdAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdAUD = Nothing
					Else
						entity.PmlPdAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdJPY As System.String 
				Get
					Dim data_ As System.String = entity.PmlPdJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdJPY = Nothing
					Else
						entity.PmlPdJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdNZD As System.String 
				Get
					Dim data_ As System.String = entity.PmlPdNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdNZD = Nothing
					Else
						entity.PmlPdNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdEUR As System.String 
				Get
					Dim data_ As System.String = entity.PmlPdEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdEUR = Nothing
					Else
						entity.PmlPdEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdMXP As System.String 
				Get
					Dim data_ As System.String = entity.PmlPdMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdMXP = Nothing
					Else
						entity.PmlPdMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdCAD As System.String 
				Get
					Dim data_ As System.String = entity.PmlPdCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdCAD = Nothing
					Else
						entity.PmlPdCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPdGBP As System.String 
				Get
					Dim data_ As System.String = entity.PmlPdGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPdGBP = Nothing
					Else
						entity.PmlPdGBP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiUSD As System.String 
				Get
					Dim data_ As System.String = entity.PmlBiUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiUSD = Nothing
					Else
						entity.PmlBiUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiAUD As System.String 
				Get
					Dim data_ As System.String = entity.PmlBiAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiAUD = Nothing
					Else
						entity.PmlBiAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiJPY As System.String 
				Get
					Dim data_ As System.String = entity.PmlBiJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiJPY = Nothing
					Else
						entity.PmlBiJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiNZD As System.String 
				Get
					Dim data_ As System.String = entity.PmlBiNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiNZD = Nothing
					Else
						entity.PmlBiNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiEUR As System.String 
				Get
					Dim data_ As System.String = entity.PmlBiEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiEUR = Nothing
					Else
						entity.PmlBiEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiMXP As System.String 
				Get
					Dim data_ As System.String = entity.PmlBiMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiMXP = Nothing
					Else
						entity.PmlBiMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiCAD As System.String 
				Get
					Dim data_ As System.String = entity.PmlBiCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiCAD = Nothing
					Else
						entity.PmlBiCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBiGBP As System.String 
				Get
					Dim data_ As System.String = entity.PmlBiGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBiGBP = Nothing
					Else
						entity.PmlBiGBP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdUSD As System.String 
				Get
					Dim data_ As System.String = entity.MflPdUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdUSD = Nothing
					Else
						entity.MflPdUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdAUD As System.String 
				Get
					Dim data_ As System.String = entity.MflPdAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdAUD = Nothing
					Else
						entity.MflPdAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdJPY As System.String 
				Get
					Dim data_ As System.String = entity.MflPdJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdJPY = Nothing
					Else
						entity.MflPdJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdNZD As System.String 
				Get
					Dim data_ As System.String = entity.MflPdNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdNZD = Nothing
					Else
						entity.MflPdNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdEUR As System.String 
				Get
					Dim data_ As System.String = entity.MflPdEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdEUR = Nothing
					Else
						entity.MflPdEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdMXP As System.String 
				Get
					Dim data_ As System.String = entity.MflPdMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdMXP = Nothing
					Else
						entity.MflPdMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdCAD As System.String 
				Get
					Dim data_ As System.String = entity.MflPdCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdCAD = Nothing
					Else
						entity.MflPdCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPdGBP As System.String 
				Get
					Dim data_ As System.String = entity.MflPdGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPdGBP = Nothing
					Else
						entity.MflPdGBP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiUSD As System.String 
				Get
					Dim data_ As System.String = entity.MflBiUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiUSD = Nothing
					Else
						entity.MflBiUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiAUD As System.String 
				Get
					Dim data_ As System.String = entity.MflBiAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiAUD = Nothing
					Else
						entity.MflBiAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiJPY As System.String 
				Get
					Dim data_ As System.String = entity.MflBiJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiJPY = Nothing
					Else
						entity.MflBiJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiNZD As System.String 
				Get
					Dim data_ As System.String = entity.MflBiNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiNZD = Nothing
					Else
						entity.MflBiNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiEUR As System.String 
				Get
					Dim data_ As System.String = entity.MflBiEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiEUR = Nothing
					Else
						entity.MflBiEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiMXP As System.String 
				Get
					Dim data_ As System.String = entity.MflBiMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiMXP = Nothing
					Else
						entity.MflBiMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiCAD As System.String 
				Get
					Dim data_ As System.String = entity.MflBiCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiCAD = Nothing
					Else
						entity.MflBiCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBiGBP As System.String 
				Get
					Dim data_ As System.String = entity.MflBiGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBiGBP = Nothing
					Else
						entity.MflBiGBP = Convert.ToString(Value)
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
					Dim data_ As System.String = entity.TivTotalUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalUSD = Nothing
					Else
						entity.TivTotalUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalAUD As System.String 
				Get
					Dim data_ As System.String = entity.TivTotalAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalAUD = Nothing
					Else
						entity.TivTotalAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalJPY As System.String 
				Get
					Dim data_ As System.String = entity.TivTotalJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalJPY = Nothing
					Else
						entity.TivTotalJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalNZD As System.String 
				Get
					Dim data_ As System.String = entity.TivTotalNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalNZD = Nothing
					Else
						entity.TivTotalNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalEUR As System.String 
				Get
					Dim data_ As System.String = entity.TivTotalEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalEUR = Nothing
					Else
						entity.TivTotalEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalMXP As System.String 
				Get
					Dim data_ As System.String = entity.TivTotalMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalMXP = Nothing
					Else
						entity.TivTotalMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalCAD As System.String 
				Get
					Dim data_ As System.String = entity.TivTotalCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalCAD = Nothing
					Else
						entity.TivTotalCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TivTotalGBP As System.String 
				Get
					Dim data_ As System.String = entity.TivTotalGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TivTotalGBP = Nothing
					Else
						entity.TivTotalGBP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalUSD As System.String 
				Get
					Dim data_ As System.String = entity.PmlTotalUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalUSD = Nothing
					Else
						entity.PmlTotalUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalAUD As System.String 
				Get
					Dim data_ As System.String = entity.PmlTotalAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalAUD = Nothing
					Else
						entity.PmlTotalAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalJPY As System.String 
				Get
					Dim data_ As System.String = entity.PmlTotalJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalJPY = Nothing
					Else
						entity.PmlTotalJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalNZD As System.String 
				Get
					Dim data_ As System.String = entity.PmlTotalNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalNZD = Nothing
					Else
						entity.PmlTotalNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalEUR As System.String 
				Get
					Dim data_ As System.String = entity.PmlTotalEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalEUR = Nothing
					Else
						entity.PmlTotalEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalMXP As System.String 
				Get
					Dim data_ As System.String = entity.PmlTotalMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalMXP = Nothing
					Else
						entity.PmlTotalMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalCAD As System.String 
				Get
					Dim data_ As System.String = entity.PmlTotalCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalCAD = Nothing
					Else
						entity.PmlTotalCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlTotalGBP As System.String 
				Get
					Dim data_ As System.String = entity.PmlTotalGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlTotalGBP = Nothing
					Else
						entity.PmlTotalGBP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalUSD As System.String 
				Get
					Dim data_ As System.String = entity.MflTotalUSD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalUSD = Nothing
					Else
						entity.MflTotalUSD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalAUD As System.String 
				Get
					Dim data_ As System.String = entity.MflTotalAUD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalAUD = Nothing
					Else
						entity.MflTotalAUD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalJPY As System.String 
				Get
					Dim data_ As System.String = entity.MflTotalJPY
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalJPY = Nothing
					Else
						entity.MflTotalJPY = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalNZD As System.String 
				Get
					Dim data_ As System.String = entity.MflTotalNZD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalNZD = Nothing
					Else
						entity.MflTotalNZD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalEUR As System.String 
				Get
					Dim data_ As System.String = entity.MflTotalEUR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalEUR = Nothing
					Else
						entity.MflTotalEUR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalMXP As System.String 
				Get
					Dim data_ As System.String = entity.MflTotalMXP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalMXP = Nothing
					Else
						entity.MflTotalMXP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalCAD As System.String 
				Get
					Dim data_ As System.String = entity.MflTotalCAD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalCAD = Nothing
					Else
						entity.MflTotalCAD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflTotalGBP As System.String 
				Get
					Dim data_ As System.String = entity.MflTotalGBP
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflTotalGBP = Nothing
					Else
						entity.MflTotalGBP = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCCopeMainBM
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCCopeMainBMMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCCopeMainBMQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCCopeMainBMQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCCopeMainBMQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCCopeMainBMQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCCopeMainBMQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCCopeMainBMCollection
		Inherits esEntityCollection(Of ViewCCCopeMainBM)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCCopeMainBMMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCCopeMainBMCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCCopeMainBMQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCCopeMainBMQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCCopeMainBMQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCCopeMainBMQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCCopeMainBMQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCCopeMainBMQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCCopeMainBMQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCCopeMainBMQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCCopeMainBMMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "RowNumber" 
					Return Me.RowNumber
				Case "FileNo" 
					Return Me.FileNo
				Case "SurveyDate" 
					Return Me.SurveyDate
				Case "Engineer" 
					Return Me.Engineer
				Case "Currency" 
					Return Me.Currency
				Case "BIReporting" 
					Return Me.BIReporting
				Case "ExchangeRate" 
					Return Me.ExchangeRate
				Case "ReptPD" 
					Return Me.ReptPD
				Case "ReptBI" 
					Return Me.ReptBI
				Case "ReptTIV" 
					Return Me.ReptTIV
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
				Case "SignificantBMDamageLossesInPast3Years" 
					Return Me.SignificantBMDamageLossesInPast3Years
				Case "SignificantBMDescription" 
					Return Me.SignificantBMDescription
				Case "FilePrefix" 
					Return Me.FilePrefix
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
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.RowNumber, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Currency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.Currency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIReporting As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.BIReporting, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.ExchangeRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ReptPD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.ReptPD, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ReptBI As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.ReptBI, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ReptTIV As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.ReptTIV, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlpd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.Pmlpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlbi As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.Pmlbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PMLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PMLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PMLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PMLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Mflpd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.Mflpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Mflbi As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.Mflbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MFLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MFLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MFLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MFLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Interdependencies As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.Interdependencies, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LEandInterdependecyComments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.LEandInterdependecyComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SignificantBMDamageLossesInPast3Years As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.SignificantBMDamageLossesInPast3Years, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SignificantBMDescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.SignificantBMDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivPdUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivPdAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivPdJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivPdNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivPdEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivPdMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivPdCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivPdGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivPdGBP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivBiUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivBiAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivBiJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivBiNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivBiEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivBiMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivBiCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivBiGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivBiGBP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdGBP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiGBP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdGBP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiGBP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPdPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlPdPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBiPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlBiPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MflPdPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflPdPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MflBiPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflBiPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalPercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalPercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivTotalUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivTotalAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivTotalJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivTotalNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivTotalEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivTotalMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivTotalCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TivTotalGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.TivTotalGBP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PmlTotalGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalGBP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalUSD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalUSD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalAUD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalAUD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalJPY As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalJPY, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalNZD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalNZD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalEUR As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalEUR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalMXP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalMXP, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalCAD As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalCAD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MflTotalGBP As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCCopeMainBMMetadata.ColumnNames.MflTotalGBP, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCCopeMainBMMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.RowNumber, 0, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.RowNumber
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.Engineer, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.Currency, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.Currency
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.BIReporting, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.BIReporting
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.ExchangeRate, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.ExchangeRate
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.ReptPD, 7, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.ReptPD
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.ReptBI, 8, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.ReptBI
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.ReptTIV, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.ReptTIV
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.Pmlpd, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.Pmlpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.Pmlbi, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.Pmlbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PMLTotal, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PMLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PMLPDPercentage, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PMLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PMLBIPercentage, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PMLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PMLTotalPercentage, 15, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PMLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.Mflpd, 16, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.Mflpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.Mflbi, 17, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.Mflbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MFLTotal, 18, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MFLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MFLPDPercentage, 19, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MFLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MFLBIPercentage, 20, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MFLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MFLTotalPercentage, 21, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MFLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.Interdependencies, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.Interdependencies
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.LEandInterdependecyComments, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.LEandInterdependecyComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.SignificantBMDamageLossesInPast3Years, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.SignificantBMDamageLossesInPast3Years
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.SignificantBMDescription, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.SignificantBMDescription
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.FilePrefix, 26, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivPdUSD, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivPdUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivPdAUD, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivPdAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivPdJPY, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivPdJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivPdNZD, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivPdNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivPdEUR, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivPdEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivPdMXP, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivPdMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivPdCAD, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivPdCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivPdGBP, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivPdGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivBiUSD, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivBiUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivBiAUD, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivBiAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivBiJPY, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivBiJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivBiNZD, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivBiNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivBiEUR, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivBiEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivBiMXP, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivBiMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivBiCAD, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivBiCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivBiGBP, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivBiGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdUSD, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdAUD, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdJPY, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdNZD, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdEUR, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdMXP, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdCAD, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdGBP, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiUSD, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiAUD, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiJPY, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiNZD, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiEUR, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiMXP, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiCAD, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiGBP, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdUSD, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdAUD, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdJPY, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdNZD, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdEUR, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdMXP, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdCAD, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdGBP, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiUSD, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiAUD, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiJPY, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiNZD, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiEUR, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiMXP, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiCAD, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiGBP, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlPdPercent, 75, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlPdPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlBiPercent, 76, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlBiPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalPercent, 77, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflPdPercent, 78, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflPdPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflBiPercent, 79, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflBiPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalPercent, 80, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalPercent
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalUSD, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivTotalUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalAUD, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivTotalAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalJPY, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivTotalJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalNZD, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivTotalNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalEUR, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivTotalEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalMXP, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivTotalMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalCAD, 87, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivTotalCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.TivTotalGBP, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.TivTotalGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalUSD, 89, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalAUD, 90, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalJPY, 91, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalNZD, 92, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalEUR, 93, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalMXP, 94, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalCAD, 95, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.PmlTotalGBP, 96, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.PmlTotalGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalUSD, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalUSD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalAUD, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalAUD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalJPY, 99, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalJPY
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalNZD, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalNZD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalEUR, 101, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalEUR
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalMXP, 102, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalMXP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalCAD, 103, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalCAD
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCCopeMainBMMetadata.ColumnNames.MflTotalGBP, 104, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCCopeMainBMMetadata.PropertyNames.MflTotalGBP
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCCopeMainBMMetadata
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
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Engineer As String = "Engineer"
			 Public Const Currency As String = "Currency"
			 Public Const BIReporting As String = "BIReporting"
			 Public Const ExchangeRate As String = "ExchangeRate"
			 Public Const ReptPD As String = "ReptPD"
			 Public Const ReptBI As String = "ReptBI"
			 Public Const ReptTIV As String = "ReptTIV"
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
			 Public Const SignificantBMDamageLossesInPast3Years As String = "SignificantB&MDamageLossesInPast3Years"
			 Public Const SignificantBMDescription As String = "SignificantB&MDescription"
			 Public Const FilePrefix As String = "FilePrefix"
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
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Engineer As String = "Engineer"
			 Public Const Currency As String = "Currency"
			 Public Const BIReporting As String = "BIReporting"
			 Public Const ExchangeRate As String = "ExchangeRate"
			 Public Const ReptPD As String = "ReptPD"
			 Public Const ReptBI As String = "ReptBI"
			 Public Const ReptTIV As String = "ReptTIV"
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
			 Public Const SignificantBMDamageLossesInPast3Years As String = "SignificantBMDamageLossesInPast3Years"
			 Public Const SignificantBMDescription As String = "SignificantBMDescription"
			 Public Const FilePrefix As String = "FilePrefix"
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
			SyncLock GetType(ViewCCCopeMainBMMetadata)
			
				If ViewCCCopeMainBMMetadata.mapDelegates Is Nothing Then
					ViewCCCopeMainBMMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCCopeMainBMMetadata._meta Is Nothing Then
					ViewCCCopeMainBMMetadata._meta = New ViewCCCopeMainBMMetadata()
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
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SurveyDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Engineer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Currency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIReporting", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExchangeRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ReptPD", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ReptBI", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ReptTIV", new esTypeMap("float", "System.Double"))
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
				meta.AddTypeMap("SignificantBMDamageLossesInPast3Years", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SignificantBMDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("TivPdUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivPdAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivPdJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivPdNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivPdEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivPdMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivPdCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivPdGBP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivBiUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivBiAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivBiJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivBiNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivBiEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivBiMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivBiCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivBiGBP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdGBP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlBiUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlBiAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlBiJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlBiNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlBiEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlBiMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlBiCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlBiGBP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflPdUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflPdAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflPdJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflPdNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflPdEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflPdMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflPdCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflPdGBP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflBiUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflBiAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflBiJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflBiNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflBiEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflBiMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflBiCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflBiGBP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlPdPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PmlBiPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("PmlTotalPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("MflPdPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("MflBiPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("MflTotalPercent", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("TivTotalUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivTotalAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivTotalJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivTotalNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivTotalEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivTotalMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivTotalCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TivTotalGBP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlTotalUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlTotalAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlTotalJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlTotalNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlTotalEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlTotalMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlTotalCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PmlTotalGBP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflTotalUSD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflTotalAUD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflTotalJPY", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflTotalNZD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflTotalEUR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflTotalMXP", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflTotalCAD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MflTotalGBP", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCCopeMainBM"
				meta.Destination = "viewCCCopeMainBM"
				
				meta.spInsert = "proc_viewCCCopeMainBMInsert"
				meta.spUpdate = "proc_viewCCCopeMainBMUpdate"
				meta.spDelete = "proc_viewCCCopeMainBMDelete"
				meta.spLoadAll = "proc_viewCCCopeMainBMLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCCopeMainBMLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCCopeMainBMMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
