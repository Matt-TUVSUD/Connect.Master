
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:40 AM
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
	' Encapsulates the 'Cope-FireMain' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(CopeFireMain))> _
	<XmlType("CopeFireMain")> _	
	Partial Public Class CopeFireMain 
		Inherits esCopeFireMain
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New CopeFireMain()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New CopeFireMain()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New CopeFireMain()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("CopeFireMainCollection")> _
	Partial Public Class CopeFireMainCollection
		Inherits esCopeFireMainCollection
		Implements IEnumerable(Of CopeFireMain)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As CopeFireMain
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(CopeFireMain))> _
		Public Class CopeFireMainCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of CopeFireMainCollection)
			
			Public Shared Widening Operator CType(packet As CopeFireMainCollectionWCFPacket) As CopeFireMainCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As CopeFireMainCollection) As CopeFireMainCollectionWCFPacket
				Return New CopeFireMainCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class CopeFireMainQuery 
		Inherits esCopeFireMainQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "CopeFireMainQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As CopeFireMainQuery) As String
			Return CopeFireMainQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As CopeFireMainQuery
			Return DirectCast(CopeFireMainQuery.SerializeHelper.FromXml(query, GetType(CopeFireMainQuery)), CopeFireMainQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esCopeFireMain
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Int32) As Boolean
		
			Dim query As New CopeFireMainQuery()
			query.Where(query.Id = id)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Cope-FireMain.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeFireMainMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeFireMainMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(CopeFireMainMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(CopeFireMainMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(CopeFireMainMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(CopeFireMainMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CopeFireMainMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CopeFireMainMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.Consultant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Consultant As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.Consultant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.Consultant, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Consultant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.Units
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Units As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.Units, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Units)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.Currency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Currency As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.Currency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.Currency, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Currency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.BIReporting
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIReporting As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.BIReporting)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.BIReporting, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.BIReporting)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.ExchangeRate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.ExchangeRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.ExchangeRate, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.ExchangeRate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.TIVPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Tivpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Tivpd, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Tivpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.TIVBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tivbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Tivbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Tivbi, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Tivbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.TIVTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TIVTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.TIVTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.TIVTotal, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.TIVTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.APLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Aplpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Aplpd, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Aplpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.APLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Aplbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Aplbi, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Aplbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.APLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.APLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.APLTotal, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.APLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.APLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.APLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.APLPDPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.APLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.APLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.APLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.APLBIPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.APLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.APLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.APLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.APLTotalPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.APLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.PMLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Pmlpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Pmlpd, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Pmlpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.PMLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Pmlbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Pmlbi, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Pmlbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.PMLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.PMLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.PMLTotal, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PMLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.PMLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.PMLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.PMLPDPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PMLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.PMLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.PMLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.PMLBIPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PMLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.PMLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.PMLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.PMLTotalPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PMLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MFLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Mflpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Mflpd, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Mflpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MFLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Mflbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Mflbi, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Mflbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MFLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.MFLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.MFLTotal, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MFLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MFLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.MFLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.MFLPDPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MFLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MFLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.MFLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.MFLBIPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MFLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MFLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.MFLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.MFLTotalPercentage, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MFLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.Interdependencies
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Interdependencies As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.Interdependencies)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.Interdependencies, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Interdependencies)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.LEandInterdependecyComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEandInterdependecyComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.LEandInterdependecyComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.LEandInterdependecyComments, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.LEandInterdependecyComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.SignificantPropertyDamageLossesInPast3Years
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SignificantPropertyDamageLossesInPast3Years As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.SignificantPropertyDamageLossesInPast3Years)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.SignificantPropertyDamageLossesInPast3Years, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.SignificantPropertyDamageLossesInPast3Years)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.SignificantPropertyDescriptionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SignificantPropertyDescriptionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.SignificantPropertyDescriptionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.SignificantPropertyDescriptionField, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.SignificantPropertyDescriptionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.AdminMemo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminMemo As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.AdminMemo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.AdminMemo, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.AdminMemo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.PropertyValuesReasonable
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PropertyValuesReasonable As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.PropertyValuesReasonable)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.PropertyValuesReasonable, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PropertyValuesReasonable)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.IBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ibi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireMainMetadata.ColumnNames.Ibi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireMainMetadata.ColumnNames.Ibi, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Ibi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MainUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MainUser1 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.MainUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.MainUser1, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MainUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MainUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MainUser2 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.MainUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.MainUser2, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MainUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MainUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MainUser3 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.MainUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.MainUser3, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MainUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireMain.MainUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MainUser4 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireMainMetadata.ColumnNames.MainUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireMainMetadata.ColumnNames.MainUser4, value) Then
					OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MainUser4)
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
												
						Case "PropertyValuesReasonable"
							Me.str().PropertyValuesReasonable = CType(value, string)
												
						Case "Ibi"
							Me.str().Ibi = CType(value, string)
												
						Case "MainUser1"
							Me.str().MainUser1 = CType(value, string)
												
						Case "MainUser2"
							Me.str().MainUser2 = CType(value, string)
												
						Case "MainUser3"
							Me.str().MainUser3 = CType(value, string)
												
						Case "MainUser4"
							Me.str().MainUser4 = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Id)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Longitude)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "ExchangeRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ExchangeRate = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.ExchangeRate)
							End If
						
						Case "Tivpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Tivpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Tivpd)
							End If
						
						Case "Tivbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Tivbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Tivbi)
							End If
						
						Case "TIVTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TIVTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.TIVTotal)
							End If
						
						Case "Aplpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Aplpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Aplpd)
							End If
						
						Case "Aplbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Aplbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Aplbi)
							End If
						
						Case "APLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.APLTotal)
							End If
						
						Case "APLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.APLPDPercentage)
							End If
						
						Case "APLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.APLBIPercentage)
							End If
						
						Case "APLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.APLTotalPercentage)
							End If
						
						Case "Pmlpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pmlpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Pmlpd)
							End If
						
						Case "Pmlbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pmlbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Pmlbi)
							End If
						
						Case "PMLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PMLTotal)
							End If
						
						Case "PMLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PMLPDPercentage)
							End If
						
						Case "PMLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PMLBIPercentage)
							End If
						
						Case "PMLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.PMLTotalPercentage)
							End If
						
						Case "Mflpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Mflpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Mflpd)
							End If
						
						Case "Mflbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Mflbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Mflbi)
							End If
						
						Case "MFLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MFLTotal)
							End If
						
						Case "MFLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MFLPDPercentage)
							End If
						
						Case "MFLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MFLBIPercentage)
							End If
						
						Case "MFLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.MFLTotalPercentage)
							End If
						
						Case "Ibi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Ibi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireMainMetadata.PropertyNames.Ibi)
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
		
			Public Sub New(ByVal entity As esCopeFireMain)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property PropertyValuesReasonable As System.String 
				Get
					Dim data_ As System.String = entity.PropertyValuesReasonable
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PropertyValuesReasonable = Nothing
					Else
						entity.PropertyValuesReasonable = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ibi As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Ibi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ibi = Nothing
					Else
						entity.Ibi = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MainUser1 As System.String 
				Get
					Dim data_ As System.String = entity.MainUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MainUser1 = Nothing
					Else
						entity.MainUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MainUser2 As System.String 
				Get
					Dim data_ As System.String = entity.MainUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MainUser2 = Nothing
					Else
						entity.MainUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MainUser3 As System.String 
				Get
					Dim data_ As System.String = entity.MainUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MainUser3 = Nothing
					Else
						entity.MainUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MainUser4 As System.String 
				Get
					Dim data_ As System.String = entity.MainUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MainUser4 = Nothing
					Else
						entity.MainUser4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCopeFireMain
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeFireMainMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As CopeFireMainQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeFireMainQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As CopeFireMainQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As CopeFireMainQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CopeFireMainQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esCopeFireMainCollection
		Inherits esEntityCollection(Of CopeFireMain)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeFireMainMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "CopeFireMainCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As CopeFireMainQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeFireMainQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As CopeFireMainQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New CopeFireMainQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As CopeFireMainQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, CopeFireMainQuery))
		End Sub
		
		#End Region
						
		Private m_query As CopeFireMainQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esCopeFireMainQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CopeFireMainMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
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
				Case "PropertyValuesReasonable" 
					Return Me.PropertyValuesReasonable
				Case "Ibi" 
					Return Me.Ibi
				Case "MainUser1" 
					Return Me.MainUser1
				Case "MainUser2" 
					Return Me.MainUser2
				Case "MainUser3" 
					Return Me.MainUser3
				Case "MainUser4" 
					Return Me.MainUser4
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Consultant As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Consultant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Units, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Currency As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Currency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIReporting As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.BIReporting, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.ExchangeRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Tivpd As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Tivpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Tivbi As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Tivbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TIVTotal As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.TIVTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Aplpd As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Aplpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Aplbi As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Aplbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property APLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.APLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property APLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.APLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property APLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.APLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property APLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.APLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlpd As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Pmlpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlbi As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Pmlbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.PMLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.PMLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.PMLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.PMLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Mflpd As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Mflpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Mflbi As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Mflbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.MFLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.MFLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.MFLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.MFLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Interdependencies As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Interdependencies, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LEandInterdependecyComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.LEandInterdependecyComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SignificantPropertyDamageLossesInPast3Years As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.SignificantPropertyDamageLossesInPast3Years, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SignificantPropertyDescriptionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.SignificantPropertyDescriptionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AdminMemo As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.AdminMemo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PropertyValuesReasonable As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.PropertyValuesReasonable, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ibi As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.Ibi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MainUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.MainUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MainUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.MainUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MainUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.MainUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MainUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireMainMetadata.ColumnNames.MainUser4, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class CopeFireMain 
		Inherits esCopeFireMain
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class CopeFireMainMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Latitude, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Longitude, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.SurveyDate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Consultant, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Consultant
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Units, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Units
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Currency, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Currency
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.BIReporting, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.BIReporting
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.ExchangeRate, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.ExchangeRate
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Tivpd, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Tivpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Tivbi, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Tivbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.TIVTotal, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.TIVTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Aplpd, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Aplpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Aplbi, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Aplbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.APLTotal, 15, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.APLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.APLPDPercentage, 16, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.APLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.APLBIPercentage, 17, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.APLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.APLTotalPercentage, 18, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.APLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Pmlpd, 19, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Pmlpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Pmlbi, 20, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Pmlbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.PMLTotal, 21, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.PMLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.PMLPDPercentage, 22, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.PMLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.PMLBIPercentage, 23, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.PMLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.PMLTotalPercentage, 24, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.PMLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Mflpd, 25, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Mflpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Mflbi, 26, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Mflbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.MFLTotal, 27, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.MFLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.MFLPDPercentage, 28, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.MFLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.MFLBIPercentage, 29, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.MFLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.MFLTotalPercentage, 30, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.MFLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Interdependencies, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Interdependencies
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.LEandInterdependecyComments, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.LEandInterdependecyComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.SignificantPropertyDamageLossesInPast3Years, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.SignificantPropertyDamageLossesInPast3Years
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.SignificantPropertyDescriptionField, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.SignificantPropertyDescriptionField
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.AdminMemo, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.AdminMemo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.PropertyValuesReasonable, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.PropertyValuesReasonable
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.Ibi, 37, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.Ibi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.MainUser1, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.MainUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.MainUser2, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.MainUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.MainUser3, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.MainUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireMainMetadata.ColumnNames.MainUser4, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireMainMetadata.PropertyNames.MainUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As CopeFireMainMetadata
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
			 Public Const PropertyValuesReasonable As String = "PropertyValuesReasonable"
			 Public Const Ibi As String = "IBI"
			 Public Const MainUser1 As String = "MainUser1"
			 Public Const MainUser2 As String = "MainUser2"
			 Public Const MainUser3 As String = "MainUser3"
			 Public Const MainUser4 As String = "MainUser4"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
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
			 Public Const PropertyValuesReasonable As String = "PropertyValuesReasonable"
			 Public Const Ibi As String = "Ibi"
			 Public Const MainUser1 As String = "MainUser1"
			 Public Const MainUser2 As String = "MainUser2"
			 Public Const MainUser3 As String = "MainUser3"
			 Public Const MainUser4 As String = "MainUser4"
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
			SyncLock GetType(CopeFireMainMetadata)
			
				If CopeFireMainMetadata.mapDelegates Is Nothing Then
					CopeFireMainMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If CopeFireMainMetadata._meta Is Nothing Then
					CopeFireMainMetadata._meta = New CopeFireMainMetadata()
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
				meta.AddTypeMap("PropertyValuesReasonable", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ibi", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MainUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MainUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MainUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MainUser4", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-FireMain"
				meta.Destination = "Cope-FireMain"
				
				meta.spInsert = "proc_Cope-FireMainInsert"
				meta.spUpdate = "proc_Cope-FireMainUpdate"
				meta.spDelete = "proc_Cope-FireMainDelete"
				meta.spLoadAll = "proc_Cope-FireMainLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-FireMainLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As CopeFireMainMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
