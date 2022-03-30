
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:39 AM
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
	' Encapsulates the 'Cope-BMMain' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMMain))> _
	<XmlType("BMMain")> _	
	Partial Public Class BMMain 
		Inherits esBMMain
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMMain()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BMMain()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMMain()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("BMMainCollection")> _
	Partial Public Class BMMainCollection
		Inherits esBMMainCollection
		Implements IEnumerable(Of BMMain)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BMMain
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMMain))> _
		Public Class BMMainCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMMainCollection)
			
			Public Shared Widening Operator CType(packet As BMMainCollectionWCFPacket) As BMMainCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMMainCollection) As BMMainCollectionWCFPacket
				Return New BMMainCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMMainQuery 
		Inherits esBMMainQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMMainQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMMainQuery) As String
			Return BMMainQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMMainQuery
			Return DirectCast(BMMainQuery.SerializeHelper.FromXml(query, GetType(BMMainQuery)), BMMainQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMMain
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fileNo As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileNo)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileNo)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fileNo As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileNo)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileNo)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fileNo As System.String) As Boolean
		
			Dim query As New BMMainQuery()
			query.Where(query.FileNo = fileNo)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fileNo As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FileNo", fileNo)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Cope-BMMain.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMMainMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMMainMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.Currency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Currency As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.Currency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.Currency, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.Currency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.BIReporting
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIReporting As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.BIReporting)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.BIReporting, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.BIReporting)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.ExchangeRate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.ExchangeRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.ExchangeRate, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.ExchangeRate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.ReptPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReptPD As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.ReptPD)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.ReptPD, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.ReptPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.ReptBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReptBI As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.ReptBI)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.ReptBI, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.ReptBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.ReptTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReptTIV As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.ReptTIV)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.ReptTIV, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.ReptTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.PMLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.Pmlpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.Pmlpd, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.Pmlpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.PMLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pmlbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.Pmlbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.Pmlbi, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.Pmlbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.PMLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.PMLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.PMLTotal, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.PMLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.PMLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.PMLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.PMLPDPercentage, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.PMLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.PMLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.PMLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.PMLBIPercentage, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.PMLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.PMLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.PMLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.PMLTotalPercentage, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.PMLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MFLPD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflpd As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.Mflpd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.Mflpd, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.Mflpd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MFLBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mflbi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.Mflbi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.Mflbi, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.Mflbi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MFLTotal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.MFLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.MFLTotal, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MFLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MFLPDPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLPDPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.MFLPDPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.MFLPDPercentage, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MFLPDPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MFLBIPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLBIPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.MFLBIPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.MFLBIPercentage, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MFLBIPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MFLTotalPercentage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotalPercentage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.MFLTotalPercentage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.MFLTotalPercentage, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MFLTotalPercentage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.Interdependencies
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Interdependencies As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.Interdependencies)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.Interdependencies, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.Interdependencies)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.LEandInterdependecyComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LEandInterdependecyComments As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.LEandInterdependecyComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.LEandInterdependecyComments, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.LEandInterdependecyComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.SignificantB&MDamageLossesInPast3Years
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SignificantBMDamageLossesInPast3Years As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.SignificantBMDamageLossesInPast3Years)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.SignificantBMDamageLossesInPast3Years, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.SignificantBMDamageLossesInPast3Years)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.SignificantB&MDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SignificantBMDescription As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.SignificantBMDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.SignificantBMDescription, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.SignificantBMDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BMMainMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BMMainMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.PropertyValuesReasonable
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PropertyValuesReasonable As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.PropertyValuesReasonable)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.PropertyValuesReasonable, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.PropertyValuesReasonable)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MajorProjectsPlanned
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorProjectsPlanned As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.MajorProjectsPlanned)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.MajorProjectsPlanned, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MajorProjectsPlanned)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MajorProjectsValueRange
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorProjectsValueRange As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.MajorProjectsValueRange)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.MajorProjectsValueRange, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MajorProjectsValueRange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.IBI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ibi As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMMainMetadata.ColumnNames.Ibi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMMainMetadata.ColumnNames.Ibi, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.Ibi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MainUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MainUser1 As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.MainUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.MainUser1, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MainUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MainUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MainUser2 As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.MainUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.MainUser2, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MainUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MainUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MainUser3 As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.MainUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.MainUser3, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MainUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMain.MainUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MainUser4 As System.String
			Get
				Return MyBase.GetSystemString(BMMainMetadata.ColumnNames.MainUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMainMetadata.ColumnNames.MainUser4, value) Then
					OnPropertyChanged(BMMainMetadata.PropertyNames.MainUser4)
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
												
						Case "PropertyValuesReasonable"
							Me.str().PropertyValuesReasonable = CType(value, string)
												
						Case "MajorProjectsPlanned"
							Me.str().MajorProjectsPlanned = CType(value, string)
												
						Case "MajorProjectsValueRange"
							Me.str().MajorProjectsValueRange = CType(value, string)
												
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
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMMainMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "ExchangeRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ExchangeRate = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.ExchangeRate)
							End If
						
						Case "ReptPD"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ReptPD = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.ReptPD)
							End If
						
						Case "ReptBI"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ReptBI = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.ReptBI)
							End If
						
						Case "ReptTIV"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ReptTIV = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.ReptTIV)
							End If
						
						Case "Pmlpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pmlpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.Pmlpd)
							End If
						
						Case "Pmlbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pmlbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.Pmlbi)
							End If
						
						Case "PMLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.PMLTotal)
							End If
						
						Case "PMLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.PMLPDPercentage)
							End If
						
						Case "PMLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.PMLBIPercentage)
							End If
						
						Case "PMLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PMLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.PMLTotalPercentage)
							End If
						
						Case "Mflpd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Mflpd = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.Mflpd)
							End If
						
						Case "Mflbi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Mflbi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.Mflbi)
							End If
						
						Case "MFLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLTotal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.MFLTotal)
							End If
						
						Case "MFLPDPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLPDPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.MFLPDPercentage)
							End If
						
						Case "MFLBIPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLBIPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.MFLBIPercentage)
							End If
						
						Case "MFLTotalPercentage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MFLTotalPercentage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.MFLTotalPercentage)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BMMainMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "Ibi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Ibi = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMMainMetadata.PropertyNames.Ibi)
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
		
			Public Sub New(ByVal entity As esBMMain)
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
		  	
			Public Property MajorProjectsPlanned As System.String 
				Get
					Dim data_ As System.String = entity.MajorProjectsPlanned
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MajorProjectsPlanned = Nothing
					Else
						entity.MajorProjectsPlanned = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MajorProjectsValueRange As System.String 
				Get
					Dim data_ As System.String = entity.MajorProjectsValueRange
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MajorProjectsValueRange = Nothing
					Else
						entity.MajorProjectsValueRange = Convert.ToString(Value)
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
		  

			Private entity As esBMMain
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMMainMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMMainQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMMainQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMMainQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMMainQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMMainQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMMainCollection
		Inherits esEntityCollection(Of BMMain)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMMainMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMMainCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMMainQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMMainQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMMainQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMMainQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMMainQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMMainQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMMainQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMMainQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMMainMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
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
				Case "PropertyValuesReasonable" 
					Return Me.PropertyValuesReasonable
				Case "MajorProjectsPlanned" 
					Return Me.MajorProjectsPlanned
				Case "MajorProjectsValueRange" 
					Return Me.MajorProjectsValueRange
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


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Currency As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.Currency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIReporting As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.BIReporting, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRate As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.ExchangeRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ReptPD As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.ReptPD, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ReptBI As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.ReptBI, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ReptTIV As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.ReptTIV, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlpd As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.Pmlpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Pmlbi As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.Pmlbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.PMLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.PMLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.PMLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.PMLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Mflpd As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.Mflpd, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Mflbi As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.Mflbi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MFLTotal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLPDPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MFLPDPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLBIPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MFLBIPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotalPercentage As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MFLTotalPercentage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Interdependencies As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.Interdependencies, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LEandInterdependecyComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.LEandInterdependecyComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SignificantBMDamageLossesInPast3Years As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.SignificantBMDamageLossesInPast3Years, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SignificantBMDescription As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.SignificantBMDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property PropertyValuesReasonable As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.PropertyValuesReasonable, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MajorProjectsPlanned As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MajorProjectsPlanned, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MajorProjectsValueRange As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MajorProjectsValueRange, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ibi As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.Ibi, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MainUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MainUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MainUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MainUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MainUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MainUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MainUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BMMainMetadata.ColumnNames.MainUser4, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMMain 
		Inherits esBMMain
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BMMainMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMMainMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.SurveyDate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMMainMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.Engineer, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.Currency, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.Currency
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.BIReporting, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.BIReporting
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.ExchangeRate, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.ExchangeRate
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.ReptPD, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.ReptPD
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.ReptBI, 7, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.ReptBI
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.ReptTIV, 8, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.ReptTIV
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.Pmlpd, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.Pmlpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.Pmlbi, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.Pmlbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.PMLTotal, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.PMLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.PMLPDPercentage, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.PMLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.PMLBIPercentage, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.PMLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.PMLTotalPercentage, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.PMLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.Mflpd, 15, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.Mflpd
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.Mflbi, 16, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.Mflbi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MFLTotal, 17, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.MFLTotal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MFLPDPercentage, 18, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.MFLPDPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MFLBIPercentage, 19, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.MFLBIPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MFLTotalPercentage, 20, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.MFLTotalPercentage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.Interdependencies, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.Interdependencies
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.LEandInterdependecyComments, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.LEandInterdependecyComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.SignificantBMDamageLossesInPast3Years, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.SignificantBMDamageLossesInPast3Years
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.SignificantBMDescription, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.SignificantBMDescription
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.FilePrefix, 25, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BMMainMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.PropertyValuesReasonable, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.PropertyValuesReasonable
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MajorProjectsPlanned, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.MajorProjectsPlanned
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MajorProjectsValueRange, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.MajorProjectsValueRange
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.Ibi, 29, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMMainMetadata.PropertyNames.Ibi
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MainUser1, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.MainUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MainUser2, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.MainUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MainUser3, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.MainUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMainMetadata.ColumnNames.MainUser4, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMainMetadata.PropertyNames.MainUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMMainMetadata
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
			 Public Const PropertyValuesReasonable As String = "PropertyValuesReasonable"
			 Public Const MajorProjectsPlanned As String = "MajorProjectsPlanned"
			 Public Const MajorProjectsValueRange As String = "MajorProjectsValueRange"
			 Public Const Ibi As String = "IBI"
			 Public Const MainUser1 As String = "MainUser1"
			 Public Const MainUser2 As String = "MainUser2"
			 Public Const MainUser3 As String = "MainUser3"
			 Public Const MainUser4 As String = "MainUser4"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
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
			 Public Const PropertyValuesReasonable As String = "PropertyValuesReasonable"
			 Public Const MajorProjectsPlanned As String = "MajorProjectsPlanned"
			 Public Const MajorProjectsValueRange As String = "MajorProjectsValueRange"
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
			SyncLock GetType(BMMainMetadata)
			
				If BMMainMetadata.mapDelegates Is Nothing Then
					BMMainMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMMainMetadata._meta Is Nothing Then
					BMMainMetadata._meta = New BMMainMetadata()
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
				meta.AddTypeMap("PropertyValuesReasonable", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MajorProjectsPlanned", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MajorProjectsValueRange", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ibi", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MainUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MainUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MainUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MainUser4", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-BMMain"
				meta.Destination = "Cope-BMMain"
				
				meta.spInsert = "proc_Cope-BMMainInsert"
				meta.spUpdate = "proc_Cope-BMMainUpdate"
				meta.spDelete = "proc_Cope-BMMainDelete"
				meta.spLoadAll = "proc_Cope-BMMainLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMMainLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMMainMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
