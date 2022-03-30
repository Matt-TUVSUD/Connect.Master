
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:23 PM
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
	' Encapsulates the 'Fire-Retail' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(FireRetail))> _
	<XmlType("FireRetail")> _	
	Partial Public Class FireRetail 
		Inherits esFireRetail
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New FireRetail()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal surveyDate As System.DateTime)
			Dim obj As New FireRetail()
			obj.FileNo = fileNo
			obj.SurveyDate = surveyDate
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal surveyDate As System.DateTime, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New FireRetail()
			obj.FileNo = fileNo
			obj.SurveyDate = surveyDate
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("FireRetailCollection")> _
	Partial Public Class FireRetailCollection
		Inherits esFireRetailCollection
		Implements IEnumerable(Of FireRetail)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String, ByVal surveyDate As System.DateTime) As FireRetail
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo And e.SurveyDate.HasValue AndAlso e.SurveyDate.Value = surveyDate)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(FireRetail))> _
		Public Class FireRetailCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of FireRetailCollection)
			
			Public Shared Widening Operator CType(packet As FireRetailCollectionWCFPacket) As FireRetailCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As FireRetailCollection) As FireRetailCollectionWCFPacket
				Return New FireRetailCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class FireRetailQuery 
		Inherits esFireRetailQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "FireRetailQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As FireRetailQuery) As String
			Return FireRetailQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As FireRetailQuery
			Return DirectCast(FireRetailQuery.SerializeHelper.FromXml(query, GetType(FireRetailQuery)), FireRetailQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esFireRetail
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fileNo As System.String, ByVal surveyDate As System.DateTime) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileNo, surveyDate)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileNo, surveyDate)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fileNo As System.String, ByVal surveyDate As System.DateTime) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileNo, surveyDate)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileNo, surveyDate)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fileNo As System.String, ByVal surveyDate As System.DateTime) As Boolean
		
			Dim query As New FireRetailQuery()
			query.Where(query.FileNo = fileNo And query.SurveyDate = surveyDate)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fileNo As System.String, ByVal surveyDate As System.DateTime) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FileNo", fileNo)
						parms.Add("SurveyDate", surveyDate)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Fire-Retail.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(FireRetailMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(FireRetailMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.Summary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Summary As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.Summary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.Summary, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.Summary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.TypeStore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TypeStore As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.TypeStore)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.TypeStore, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.TypeStore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.MilesToCoast
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MilesToCoast As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(FireRetailMetadata.ColumnNames.MilesToCoast)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(FireRetailMetadata.ColumnNames.MilesToCoast, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.MilesToCoast)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.RespTime
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespTime As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(FireRetailMetadata.ColumnNames.RespTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(FireRetailMetadata.ColumnNames.RespTime, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.RespTime)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.HydrantDistance
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HydrantDistance As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.HydrantDistance)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.HydrantDistance, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.HydrantDistance)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FootprintBldg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FootprintBldg As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FireRetailMetadata.ColumnNames.FootprintBldg)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(FireRetailMetadata.ColumnNames.FootprintBldg, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FootprintBldg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.RackStorArea
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RackStorArea As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FireRetailMetadata.ColumnNames.RackStorArea)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(FireRetailMetadata.ColumnNames.RackStorArea, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.RackStorArea)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.BackroomStorArea
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BackroomStorArea As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FireRetailMetadata.ColumnNames.BackroomStorArea)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(FireRetailMetadata.ColumnNames.BackroomStorArea, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.BackroomStorArea)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.BackroomStorHgt
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BackroomStorHgt As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FireRetailMetadata.ColumnNames.BackroomStorHgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(FireRetailMetadata.ColumnNames.BackroomStorHgt, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.BackroomStorHgt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SalesFlStorArea
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SalesFlStorArea As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FireRetailMetadata.ColumnNames.SalesFlStorArea)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(FireRetailMetadata.ColumnNames.SalesFlStorArea, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SalesFlStorArea)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SalesFlStorHgt
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SalesFlStorHgt As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FireRetailMetadata.ColumnNames.SalesFlStorHgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(FireRetailMetadata.ColumnNames.SalesFlStorHgt, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SalesFlStorHgt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.AverSlAreaProdHgt
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AverSlAreaProdHgt As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FireRetailMetadata.ColumnNames.AverSlAreaProdHgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(FireRetailMetadata.ColumnNames.AverSlAreaProdHgt, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.AverSlAreaProdHgt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.MaxSlAreaProdHgt
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MaxSlAreaProdHgt As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FireRetailMetadata.ColumnNames.MaxSlAreaProdHgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(FireRetailMetadata.ColumnNames.MaxSlAreaProdHgt, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.MaxSlAreaProdHgt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.%CeilASSP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CeilASSP As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(FireRetailMetadata.ColumnNames.CeilASSP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(FireRetailMetadata.ColumnNames.CeilASSP, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.CeilASSP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.%CeilASSN
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CeilASSN As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(FireRetailMetadata.ColumnNames.CeilASSN)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(FireRetailMetadata.ColumnNames.CeilASSN, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.CeilASSN)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.%RackAASP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RackAASP As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(FireRetailMetadata.ColumnNames.RackAASP)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(FireRetailMetadata.ColumnNames.RackAASP, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.RackAASP)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.%RackAASN
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RackAASN As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(FireRetailMetadata.ColumnNames.RackAASN)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(FireRetailMetadata.ColumnNames.RackAASN, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.RackAASN)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireDetProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireDetProv As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireDetProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireDetProv, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireDetProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireDetNeed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireDetNeed As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireDetNeed)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireDetNeed, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireDetNeed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.LevelsRAS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LevelsRAS As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.LevelsRAS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.LevelsRAS, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.LevelsRAS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.WaterFlowMonYesNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterFlowMonYesNo As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.WaterFlowMonYesNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.WaterFlowMonYesNo, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.WaterFlowMonYesNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.WaterFlowMonByWhom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterFlowMonByWhom As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.WaterFlowMonByWhom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.WaterFlowMonByWhom, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.WaterFlowMonByWhom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ValveTamMonYesNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ValveTamMonYesNo As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ValveTamMonYesNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ValveTamMonYesNo, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ValveTamMonYesNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ValveTamMonByWhom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ValveTamMonByWhom As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ValveTamMonByWhom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ValveTamMonByWhom, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ValveTamMonByWhom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoOfValves
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoOfValves As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(FireRetailMetadata.ColumnNames.NoOfValves)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(FireRetailMetadata.ColumnNames.NoOfValves, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoOfValves)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoOfValvesC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoOfValvesC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoOfValvesC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoOfValvesC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoOfValvesC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.AllValvesOpen
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AllValvesOpen As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.AllValvesOpen)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.AllValvesOpen, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.AllValvesOpen)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.AllValvesOpenC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AllValvesOpenC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.AllValvesOpenC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.AllValvesOpenC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.AllValvesOpenC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ValvesLocked
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ValvesLocked As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ValvesLocked)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ValvesLocked, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ValvesLocked)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ValvesLockedC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ValvesLockedC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ValvesLockedC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ValvesLockedC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ValvesLockedC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ValvesLabeled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ValvesLabeled As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ValvesLabeled)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ValvesLabeled, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ValvesLabeled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ValvesLabeledC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ValvesLabeledC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ValvesLabeledC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ValvesLabeledC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ValvesLabeledC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ValvesInspMonthly
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ValvesInspMonthly As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ValvesInspMonthly)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ValvesInspMonthly, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ValvesInspMonthly)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ValvesInspMonthlyC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ValvesInspMonthlyC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ValvesInspMonthlyC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ValvesInspMonthlyC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ValvesInspMonthlyC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SSHeadBoxMonthly
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSHeadBoxMonthly As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.SSHeadBoxMonthly)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.SSHeadBoxMonthly, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SSHeadBoxMonthly)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SSHeadBoxMonthlyC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSHeadBoxMonthlyC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.SSHeadBoxMonthlyC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.SSHeadBoxMonthlyC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SSHeadBoxMonthlyC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SSHeadsAvail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSHeadsAvail As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.SSHeadsAvail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.SSHeadsAvail, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SSHeadsAvail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SSHeadsAvailC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSHeadsAvailC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.SSHeadsAvailC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.SSHeadsAvailC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SSHeadsAvailC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SSHeadWrenchInBox
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSHeadWrenchInBox As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.SSHeadWrenchInBox)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.SSHeadWrenchInBox, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SSHeadWrenchInBox)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SSHeadWrenchInBoxC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSHeadWrenchInBoxC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.SSHeadWrenchInBoxC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.SSHeadWrenchInBoxC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SSHeadWrenchInBoxC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.CorrectHeadsProvided
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CorrectHeadsProvided As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.CorrectHeadsProvided)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.CorrectHeadsProvided, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.CorrectHeadsProvided)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.CorrectHeadsProvidedC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CorrectHeadsProvidedC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.CorrectHeadsProvidedC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.CorrectHeadsProvidedC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.CorrectHeadsProvidedC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ImpProcObserved
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpProcObserved As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ImpProcObserved)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ImpProcObserved, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ImpProcObserved)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ImpProcObservedC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpProcObservedC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ImpProcObservedC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ImpProcObservedC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ImpProcObservedC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATV2inDrain
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATV2inDrain As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATV2inDrain)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATV2inDrain, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATV2inDrain)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATV2inDrainC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATV2inDrainC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATV2inDrainC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATV2inDrainC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATV2inDrainC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVDryPipeValve
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVDryPipeValve As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVDryPipeValve)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVDryPipeValve, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVDryPipeValve)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVDryPipeValveC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVDryPipeValveC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVDryPipeValveC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVDryPipeValveC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVDryPipeValveC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVFirePump
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVFirePump As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVFirePump)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVFirePump, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVFirePump)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVFirePumpC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVFirePumpC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVFirePumpC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVFirePumpC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVFirePumpC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVAntifreeze
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVAntifreeze As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVAntifreeze)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVAntifreeze, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVAntifreeze)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVAntifreezeC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVAntifreezeC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVAntifreezeC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVAntifreezeC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVAntifreezeC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoMissingCapsFDC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoMissingCapsFDC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoMissingCapsFDC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoMissingCapsFDC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoMissingCapsFDC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoMissingCapsFDCC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoMissingCapsFDCC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoMissingCapsFDCC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoMissingCapsFDCC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoMissingCapsFDCC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVValveTamper
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVValveTamper As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVValveTamper)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVValveTamper, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVValveTamper)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVValveTamperC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVValveTamperC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVValveTamperC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVValveTamperC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVValveTamperC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVWaterFlow
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVWaterFlow As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVWaterFlow)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVWaterFlow, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVWaterFlow)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVWaterFlowC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVWaterFlowC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVWaterFlowC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVWaterFlowC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVWaterFlowC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVDrySysLowAir
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVDrySysLowAir As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVDrySysLowAir)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVDrySysLowAir, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVDrySysLowAir)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ATVDrySysLowAirC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ATVDrySysLowAirC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ATVDrySysLowAirC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ATVDrySysLowAirC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ATVDrySysLowAirC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireSupSysOver
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireSupSysOver As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireSupSysOver)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireSupSysOver, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireSupSysOver)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireSupSysOverC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireSupSysOverC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireSupSysOverC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireSupSysOverC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireSupSysOverC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.BlowOffCaps
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BlowOffCaps As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.BlowOffCaps)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.BlowOffCaps, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.BlowOffCaps)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.BlowOffCapsC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BlowOffCapsC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.BlowOffCapsC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.BlowOffCapsC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.BlowOffCapsC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ManualRelease
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ManualRelease As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ManualRelease)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ManualRelease, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ManualRelease)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ManualReleaseC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ManualReleaseC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ManualReleaseC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ManualReleaseC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ManualReleaseC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.Min18Clearance
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Min18Clearance As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.Min18Clearance)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.Min18Clearance, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.Min18Clearance)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.Min18ClearanceC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Min18ClearanceC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.Min18ClearanceC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.Min18ClearanceC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.Min18ClearanceC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireAlarmZonePosted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireAlarmZonePosted As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireAlarmZonePosted)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireAlarmZonePosted, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireAlarmZonePosted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireAlarmZonePostedC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireAlarmZonePostedC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireAlarmZonePostedC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireAlarmZonePostedC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireAlarmZonePostedC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PFEInspMonthly
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PFEInspMonthly As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PFEInspMonthly)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PFEInspMonthly, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PFEInspMonthly)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PFEInspMonthlyC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PFEInspMonthlyC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PFEInspMonthlyC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PFEInspMonthlyC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PFEInspMonthlyC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PFEServAnn
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PFEServAnn As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PFEServAnn)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PFEServAnn, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PFEServAnn)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PFEServAnnC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PFEServAnnC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PFEServAnnC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PFEServAnnC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PFEServAnnC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PFEAppTypeSize
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PFEAppTypeSize As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PFEAppTypeSize)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PFEAppTypeSize, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PFEAppTypeSize)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PFEAppTypeSizeC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PFEAppTypeSizeC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PFEAppTypeSizeC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PFEAppTypeSizeC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PFEAppTypeSizeC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PFEMounted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PFEMounted As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PFEMounted)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PFEMounted, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PFEMounted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PFEMountedC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PFEMountedC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PFEMountedC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PFEMountedC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PFEMountedC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireHosesInsp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireHosesInsp As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireHosesInsp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireHosesInsp, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireHosesInsp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireHosesInspC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireHosesInspC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireHosesInspC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireHosesInspC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireHosesInspC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ExhaustHoodsDuct
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExhaustHoodsDuct As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ExhaustHoodsDuct)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ExhaustHoodsDuct, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ExhaustHoodsDuct)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ExhaustHoodsDuctC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExhaustHoodsDuctC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ExhaustHoodsDuctC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ExhaustHoodsDuctC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ExhaustHoodsDuctC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FiltersForCooking
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FiltersForCooking As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FiltersForCooking)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FiltersForCooking, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FiltersForCooking)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FiltersForCookingC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FiltersForCookingC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FiltersForCookingC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FiltersForCookingC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FiltersForCookingC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ELProvided
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ELProvided As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ELProvided)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ELProvided, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ELProvided)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ELProvidedC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ELProvidedC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ELProvidedC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ELProvidedC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ELProvidedC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.BatOpEmerExit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BatOpEmerExit As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.BatOpEmerExit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.BatOpEmerExit, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.BatOpEmerExit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.BatOpEmerExitC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BatOpEmerExitC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.BatOpEmerExitC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.BatOpEmerExitC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.BatOpEmerExitC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.EmergGenOptMonthly
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmergGenOptMonthly As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.EmergGenOptMonthly)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.EmergGenOptMonthly, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.EmergGenOptMonthly)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.EmergGenOptMonthlyC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmergGenOptMonthlyC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.EmergGenOptMonthlyC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.EmergGenOptMonthlyC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.EmergGenOptMonthlyC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.GenSecPreUnauth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GenSecPreUnauth As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.GenSecPreUnauth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.GenSecPreUnauth, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.GenSecPreUnauth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.GenSecPreUnauthC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GenSecPreUnauthC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.GenSecPreUnauthC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.GenSecPreUnauthC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.GenSecPreUnauthC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ExitSignsProvIll
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExitSignsProvIll As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ExitSignsProvIll)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ExitSignsProvIll, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ExitSignsProvIll)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ExitSignsProvIllC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExitSignsProvIllC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ExitSignsProvIllC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ExitSignsProvIllC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ExitSignsProvIllC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ExitDoorsUnobstr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExitDoorsUnobstr As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ExitDoorsUnobstr)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ExitDoorsUnobstr, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ExitDoorsUnobstr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ExitDoorsUnobstrC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExitDoorsUnobstrC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ExitDoorsUnobstrC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ExitDoorsUnobstrC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ExitDoorsUnobstrC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NatGasFryer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatGasFryer As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NatGasFryer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NatGasFryer, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NatGasFryer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NatGasFryerC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatGasFryerC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NatGasFryerC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NatGasFryerC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NatGasFryerC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SeismicGasShutoff
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicGasShutoff As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.SeismicGasShutoff)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.SeismicGasShutoff, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SeismicGasShutoff)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.SeismicGasShutoffC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicGasShutoffC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.SeismicGasShutoffC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.SeismicGasShutoffC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.SeismicGasShutoffC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.StorRacksBolted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StorRacksBolted As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.StorRacksBolted)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.StorRacksBolted, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.StorRacksBolted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.StorRacksBoltedC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StorRacksBoltedC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.StorRacksBoltedC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.StorRacksBoltedC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.StorRacksBoltedC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.HotWorkPermit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HotWorkPermit As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.HotWorkPermit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.HotWorkPermit, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.HotWorkPermit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.HotWorkPermitC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HotWorkPermitC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.HotWorkPermitC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.HotWorkPermitC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.HotWorkPermitC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FlamLiqStored
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FlamLiqStored As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FlamLiqStored)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FlamLiqStored, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FlamLiqStored)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FlamLiqStoredC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FlamLiqStoredC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FlamLiqStoredC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FlamLiqStoredC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FlamLiqStoredC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.16Separation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _16Separation As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames._16Separation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames._16Separation, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames._16Separation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.16SeparationC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _16SeparationC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames._16SeparationC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames._16SeparationC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames._16SeparationC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PropCylinders
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PropCylinders As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PropCylinders)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PropCylinders, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PropCylinders)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PropCylindersC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PropCylindersC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PropCylindersC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PropCylindersC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PropCylindersC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PropStorage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PropStorage As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PropStorage)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PropStorage, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PropStorage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PropStorageC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PropStorageC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PropStorageC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PropStorageC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PropStorageC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoSmoking
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoSmoking As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoSmoking)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoSmoking, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoSmoking)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoSmokingC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoSmokingC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoSmokingC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoSmokingC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoSmokingC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireDoorsNotObstr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireDoorsNotObstr As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireDoorsNotObstr)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireDoorsNotObstr, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireDoorsNotObstr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.FireDoorsNotObstrC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireDoorsNotObstrC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.FireDoorsNotObstrC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.FireDoorsNotObstrC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.FireDoorsNotObstrC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoMissCealTiles
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoMissCealTiles As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoMissCealTiles)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoMissCealTiles, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoMissCealTiles)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoMissCealTilesC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoMissCealTilesC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoMissCealTilesC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoMissCealTilesC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoMissCealTilesC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.BarricadeProvided
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BarricadeProvided As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.BarricadeProvided)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.BarricadeProvided, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.BarricadeProvided)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.BarricadeProvidedC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BarricadeProvidedC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.BarricadeProvidedC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.BarricadeProvidedC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.BarricadeProvidedC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoStorageInElecRm
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoStorageInElecRm As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoStorageInElecRm)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoStorageInElecRm, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoStorageInElecRm)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.NoStorageInElecRmC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoStorageInElecRmC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.NoStorageInElecRmC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.NoStorageInElecRmC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.NoStorageInElecRmC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PlasSkids
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlasSkids As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PlasSkids)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PlasSkids, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PlasSkids)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.PlasSkidsC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlasSkidsC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.PlasSkidsC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.PlasSkidsC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.PlasSkidsC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ElectExtCords
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectExtCords As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ElectExtCords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ElectExtCords, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ElectExtCords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ElectExtCordsC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectExtCordsC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ElectExtCordsC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ElectExtCordsC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ElectExtCordsC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ElectEquipFreeDam
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectEquipFreeDam As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ElectEquipFreeDam)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ElectEquipFreeDam, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ElectEquipFreeDam)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.ElectEquipFreeDamC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectEquipFreeDamC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames.ElectEquipFreeDamC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames.ElectEquipFreeDamC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames.ElectEquipFreeDamC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.36Clearance
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _36Clearance As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames._36Clearance)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames._36Clearance, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames._36Clearance)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Fire-Retail.36ClearanceC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _36ClearanceC As System.String
			Get
				Return MyBase.GetSystemString(FireRetailMetadata.ColumnNames._36ClearanceC)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(FireRetailMetadata.ColumnNames._36ClearanceC, value) Then
					OnPropertyChanged(FireRetailMetadata.PropertyNames._36ClearanceC)
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
												
						Case "Summary"
							Me.str().Summary = CType(value, string)
												
						Case "TypeStore"
							Me.str().TypeStore = CType(value, string)
												
						Case "MilesToCoast"
							Me.str().MilesToCoast = CType(value, string)
												
						Case "RespTime"
							Me.str().RespTime = CType(value, string)
												
						Case "HydrantDistance"
							Me.str().HydrantDistance = CType(value, string)
												
						Case "FootprintBldg"
							Me.str().FootprintBldg = CType(value, string)
												
						Case "RackStorArea"
							Me.str().RackStorArea = CType(value, string)
												
						Case "BackroomStorArea"
							Me.str().BackroomStorArea = CType(value, string)
												
						Case "BackroomStorHgt"
							Me.str().BackroomStorHgt = CType(value, string)
												
						Case "SalesFlStorArea"
							Me.str().SalesFlStorArea = CType(value, string)
												
						Case "SalesFlStorHgt"
							Me.str().SalesFlStorHgt = CType(value, string)
												
						Case "AverSlAreaProdHgt"
							Me.str().AverSlAreaProdHgt = CType(value, string)
												
						Case "MaxSlAreaProdHgt"
							Me.str().MaxSlAreaProdHgt = CType(value, string)
												
						Case "CeilASSP"
							Me.str().CeilASSP = CType(value, string)
												
						Case "CeilASSN"
							Me.str().CeilASSN = CType(value, string)
												
						Case "RackAASP"
							Me.str().RackAASP = CType(value, string)
												
						Case "RackAASN"
							Me.str().RackAASN = CType(value, string)
												
						Case "FireDetProv"
							Me.str().FireDetProv = CType(value, string)
												
						Case "FireDetNeed"
							Me.str().FireDetNeed = CType(value, string)
												
						Case "LevelsRAS"
							Me.str().LevelsRAS = CType(value, string)
												
						Case "WaterFlowMonYesNo"
							Me.str().WaterFlowMonYesNo = CType(value, string)
												
						Case "WaterFlowMonByWhom"
							Me.str().WaterFlowMonByWhom = CType(value, string)
												
						Case "ValveTamMonYesNo"
							Me.str().ValveTamMonYesNo = CType(value, string)
												
						Case "ValveTamMonByWhom"
							Me.str().ValveTamMonByWhom = CType(value, string)
												
						Case "NoOfValves"
							Me.str().NoOfValves = CType(value, string)
												
						Case "NoOfValvesC"
							Me.str().NoOfValvesC = CType(value, string)
												
						Case "AllValvesOpen"
							Me.str().AllValvesOpen = CType(value, string)
												
						Case "AllValvesOpenC"
							Me.str().AllValvesOpenC = CType(value, string)
												
						Case "ValvesLocked"
							Me.str().ValvesLocked = CType(value, string)
												
						Case "ValvesLockedC"
							Me.str().ValvesLockedC = CType(value, string)
												
						Case "ValvesLabeled"
							Me.str().ValvesLabeled = CType(value, string)
												
						Case "ValvesLabeledC"
							Me.str().ValvesLabeledC = CType(value, string)
												
						Case "ValvesInspMonthly"
							Me.str().ValvesInspMonthly = CType(value, string)
												
						Case "ValvesInspMonthlyC"
							Me.str().ValvesInspMonthlyC = CType(value, string)
												
						Case "SSHeadBoxMonthly"
							Me.str().SSHeadBoxMonthly = CType(value, string)
												
						Case "SSHeadBoxMonthlyC"
							Me.str().SSHeadBoxMonthlyC = CType(value, string)
												
						Case "SSHeadsAvail"
							Me.str().SSHeadsAvail = CType(value, string)
												
						Case "SSHeadsAvailC"
							Me.str().SSHeadsAvailC = CType(value, string)
												
						Case "SSHeadWrenchInBox"
							Me.str().SSHeadWrenchInBox = CType(value, string)
												
						Case "SSHeadWrenchInBoxC"
							Me.str().SSHeadWrenchInBoxC = CType(value, string)
												
						Case "CorrectHeadsProvided"
							Me.str().CorrectHeadsProvided = CType(value, string)
												
						Case "CorrectHeadsProvidedC"
							Me.str().CorrectHeadsProvidedC = CType(value, string)
												
						Case "ImpProcObserved"
							Me.str().ImpProcObserved = CType(value, string)
												
						Case "ImpProcObservedC"
							Me.str().ImpProcObservedC = CType(value, string)
												
						Case "ATV2inDrain"
							Me.str().ATV2inDrain = CType(value, string)
												
						Case "ATV2inDrainC"
							Me.str().ATV2inDrainC = CType(value, string)
												
						Case "ATVDryPipeValve"
							Me.str().ATVDryPipeValve = CType(value, string)
												
						Case "ATVDryPipeValveC"
							Me.str().ATVDryPipeValveC = CType(value, string)
												
						Case "ATVFirePump"
							Me.str().ATVFirePump = CType(value, string)
												
						Case "ATVFirePumpC"
							Me.str().ATVFirePumpC = CType(value, string)
												
						Case "ATVAntifreeze"
							Me.str().ATVAntifreeze = CType(value, string)
												
						Case "ATVAntifreezeC"
							Me.str().ATVAntifreezeC = CType(value, string)
												
						Case "NoMissingCapsFDC"
							Me.str().NoMissingCapsFDC = CType(value, string)
												
						Case "NoMissingCapsFDCC"
							Me.str().NoMissingCapsFDCC = CType(value, string)
												
						Case "ATVValveTamper"
							Me.str().ATVValveTamper = CType(value, string)
												
						Case "ATVValveTamperC"
							Me.str().ATVValveTamperC = CType(value, string)
												
						Case "ATVWaterFlow"
							Me.str().ATVWaterFlow = CType(value, string)
												
						Case "ATVWaterFlowC"
							Me.str().ATVWaterFlowC = CType(value, string)
												
						Case "ATVDrySysLowAir"
							Me.str().ATVDrySysLowAir = CType(value, string)
												
						Case "ATVDrySysLowAirC"
							Me.str().ATVDrySysLowAirC = CType(value, string)
												
						Case "FireSupSysOver"
							Me.str().FireSupSysOver = CType(value, string)
												
						Case "FireSupSysOverC"
							Me.str().FireSupSysOverC = CType(value, string)
												
						Case "BlowOffCaps"
							Me.str().BlowOffCaps = CType(value, string)
												
						Case "BlowOffCapsC"
							Me.str().BlowOffCapsC = CType(value, string)
												
						Case "ManualRelease"
							Me.str().ManualRelease = CType(value, string)
												
						Case "ManualReleaseC"
							Me.str().ManualReleaseC = CType(value, string)
												
						Case "Min18Clearance"
							Me.str().Min18Clearance = CType(value, string)
												
						Case "Min18ClearanceC"
							Me.str().Min18ClearanceC = CType(value, string)
												
						Case "FireAlarmZonePosted"
							Me.str().FireAlarmZonePosted = CType(value, string)
												
						Case "FireAlarmZonePostedC"
							Me.str().FireAlarmZonePostedC = CType(value, string)
												
						Case "PFEInspMonthly"
							Me.str().PFEInspMonthly = CType(value, string)
												
						Case "PFEInspMonthlyC"
							Me.str().PFEInspMonthlyC = CType(value, string)
												
						Case "PFEServAnn"
							Me.str().PFEServAnn = CType(value, string)
												
						Case "PFEServAnnC"
							Me.str().PFEServAnnC = CType(value, string)
												
						Case "PFEAppTypeSize"
							Me.str().PFEAppTypeSize = CType(value, string)
												
						Case "PFEAppTypeSizeC"
							Me.str().PFEAppTypeSizeC = CType(value, string)
												
						Case "PFEMounted"
							Me.str().PFEMounted = CType(value, string)
												
						Case "PFEMountedC"
							Me.str().PFEMountedC = CType(value, string)
												
						Case "FireHosesInsp"
							Me.str().FireHosesInsp = CType(value, string)
												
						Case "FireHosesInspC"
							Me.str().FireHosesInspC = CType(value, string)
												
						Case "ExhaustHoodsDuct"
							Me.str().ExhaustHoodsDuct = CType(value, string)
												
						Case "ExhaustHoodsDuctC"
							Me.str().ExhaustHoodsDuctC = CType(value, string)
												
						Case "FiltersForCooking"
							Me.str().FiltersForCooking = CType(value, string)
												
						Case "FiltersForCookingC"
							Me.str().FiltersForCookingC = CType(value, string)
												
						Case "ELProvided"
							Me.str().ELProvided = CType(value, string)
												
						Case "ELProvidedC"
							Me.str().ELProvidedC = CType(value, string)
												
						Case "BatOpEmerExit"
							Me.str().BatOpEmerExit = CType(value, string)
												
						Case "BatOpEmerExitC"
							Me.str().BatOpEmerExitC = CType(value, string)
												
						Case "EmergGenOptMonthly"
							Me.str().EmergGenOptMonthly = CType(value, string)
												
						Case "EmergGenOptMonthlyC"
							Me.str().EmergGenOptMonthlyC = CType(value, string)
												
						Case "GenSecPreUnauth"
							Me.str().GenSecPreUnauth = CType(value, string)
												
						Case "GenSecPreUnauthC"
							Me.str().GenSecPreUnauthC = CType(value, string)
												
						Case "ExitSignsProvIll"
							Me.str().ExitSignsProvIll = CType(value, string)
												
						Case "ExitSignsProvIllC"
							Me.str().ExitSignsProvIllC = CType(value, string)
												
						Case "ExitDoorsUnobstr"
							Me.str().ExitDoorsUnobstr = CType(value, string)
												
						Case "ExitDoorsUnobstrC"
							Me.str().ExitDoorsUnobstrC = CType(value, string)
												
						Case "NatGasFryer"
							Me.str().NatGasFryer = CType(value, string)
												
						Case "NatGasFryerC"
							Me.str().NatGasFryerC = CType(value, string)
												
						Case "SeismicGasShutoff"
							Me.str().SeismicGasShutoff = CType(value, string)
												
						Case "SeismicGasShutoffC"
							Me.str().SeismicGasShutoffC = CType(value, string)
												
						Case "StorRacksBolted"
							Me.str().StorRacksBolted = CType(value, string)
												
						Case "StorRacksBoltedC"
							Me.str().StorRacksBoltedC = CType(value, string)
												
						Case "HotWorkPermit"
							Me.str().HotWorkPermit = CType(value, string)
												
						Case "HotWorkPermitC"
							Me.str().HotWorkPermitC = CType(value, string)
												
						Case "FlamLiqStored"
							Me.str().FlamLiqStored = CType(value, string)
												
						Case "FlamLiqStoredC"
							Me.str().FlamLiqStoredC = CType(value, string)
												
						Case "_16Separation"
							Me.str()._16Separation = CType(value, string)
												
						Case "_16SeparationC"
							Me.str()._16SeparationC = CType(value, string)
												
						Case "PropCylinders"
							Me.str().PropCylinders = CType(value, string)
												
						Case "PropCylindersC"
							Me.str().PropCylindersC = CType(value, string)
												
						Case "PropStorage"
							Me.str().PropStorage = CType(value, string)
												
						Case "PropStorageC"
							Me.str().PropStorageC = CType(value, string)
												
						Case "NoSmoking"
							Me.str().NoSmoking = CType(value, string)
												
						Case "NoSmokingC"
							Me.str().NoSmokingC = CType(value, string)
												
						Case "FireDoorsNotObstr"
							Me.str().FireDoorsNotObstr = CType(value, string)
												
						Case "FireDoorsNotObstrC"
							Me.str().FireDoorsNotObstrC = CType(value, string)
												
						Case "NoMissCealTiles"
							Me.str().NoMissCealTiles = CType(value, string)
												
						Case "NoMissCealTilesC"
							Me.str().NoMissCealTilesC = CType(value, string)
												
						Case "BarricadeProvided"
							Me.str().BarricadeProvided = CType(value, string)
												
						Case "BarricadeProvidedC"
							Me.str().BarricadeProvidedC = CType(value, string)
												
						Case "NoStorageInElecRm"
							Me.str().NoStorageInElecRm = CType(value, string)
												
						Case "NoStorageInElecRmC"
							Me.str().NoStorageInElecRmC = CType(value, string)
												
						Case "PlasSkids"
							Me.str().PlasSkids = CType(value, string)
												
						Case "PlasSkidsC"
							Me.str().PlasSkidsC = CType(value, string)
												
						Case "ElectExtCords"
							Me.str().ElectExtCords = CType(value, string)
												
						Case "ElectExtCordsC"
							Me.str().ElectExtCordsC = CType(value, string)
												
						Case "ElectEquipFreeDam"
							Me.str().ElectEquipFreeDam = CType(value, string)
												
						Case "ElectEquipFreeDamC"
							Me.str().ElectEquipFreeDamC = CType(value, string)
												
						Case "_36Clearance"
							Me.str()._36Clearance = CType(value, string)
												
						Case "_36ClearanceC"
							Me.str()._36ClearanceC = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "MilesToCoast"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.MilesToCoast = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.MilesToCoast)
							End If
						
						Case "RespTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.RespTime = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.RespTime)
							End If
						
						Case "FootprintBldg"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FootprintBldg = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.FootprintBldg)
							End If
						
						Case "RackStorArea"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RackStorArea = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.RackStorArea)
							End If
						
						Case "BackroomStorArea"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BackroomStorArea = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.BackroomStorArea)
							End If
						
						Case "BackroomStorHgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BackroomStorHgt = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.BackroomStorHgt)
							End If
						
						Case "SalesFlStorArea"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalesFlStorArea = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.SalesFlStorArea)
							End If
						
						Case "SalesFlStorHgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalesFlStorHgt = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.SalesFlStorHgt)
							End If
						
						Case "AverSlAreaProdHgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.AverSlAreaProdHgt = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.AverSlAreaProdHgt)
							End If
						
						Case "MaxSlAreaProdHgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MaxSlAreaProdHgt = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.MaxSlAreaProdHgt)
							End If
						
						Case "CeilASSP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.CeilASSP = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.CeilASSP)
							End If
						
						Case "CeilASSN"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.CeilASSN = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.CeilASSN)
							End If
						
						Case "RackAASP"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.RackAASP = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.RackAASP)
							End If
						
						Case "RackAASN"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.RackAASN = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.RackAASN)
							End If
						
						Case "NoOfValves"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NoOfValves = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(FireRetailMetadata.PropertyNames.NoOfValves)
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
		
			Public Sub New(ByVal entity As esFireRetail)
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
		  	
			Public Property Summary As System.String 
				Get
					Dim data_ As System.String = entity.Summary
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Summary = Nothing
					Else
						entity.Summary = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TypeStore As System.String 
				Get
					Dim data_ As System.String = entity.TypeStore
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TypeStore = Nothing
					Else
						entity.TypeStore = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MilesToCoast As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.MilesToCoast
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MilesToCoast = Nothing
					Else
						entity.MilesToCoast = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespTime As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.RespTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespTime = Nothing
					Else
						entity.RespTime = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property HydrantDistance As System.String 
				Get
					Dim data_ As System.String = entity.HydrantDistance
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HydrantDistance = Nothing
					Else
						entity.HydrantDistance = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FootprintBldg As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FootprintBldg
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FootprintBldg = Nothing
					Else
						entity.FootprintBldg = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RackStorArea As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RackStorArea
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RackStorArea = Nothing
					Else
						entity.RackStorArea = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BackroomStorArea As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BackroomStorArea
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BackroomStorArea = Nothing
					Else
						entity.BackroomStorArea = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BackroomStorHgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BackroomStorHgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BackroomStorHgt = Nothing
					Else
						entity.BackroomStorHgt = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SalesFlStorArea As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalesFlStorArea
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalesFlStorArea = Nothing
					Else
						entity.SalesFlStorArea = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SalesFlStorHgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalesFlStorHgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalesFlStorHgt = Nothing
					Else
						entity.SalesFlStorHgt = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property AverSlAreaProdHgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.AverSlAreaProdHgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AverSlAreaProdHgt = Nothing
					Else
						entity.AverSlAreaProdHgt = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxSlAreaProdHgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MaxSlAreaProdHgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxSlAreaProdHgt = Nothing
					Else
						entity.MaxSlAreaProdHgt = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CeilASSP As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.CeilASSP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CeilASSP = Nothing
					Else
						entity.CeilASSP = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property CeilASSN As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.CeilASSN
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CeilASSN = Nothing
					Else
						entity.CeilASSN = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property RackAASP As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.RackAASP
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RackAASP = Nothing
					Else
						entity.RackAASP = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property RackAASN As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.RackAASN
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RackAASN = Nothing
					Else
						entity.RackAASN = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireDetProv As System.String 
				Get
					Dim data_ As System.String = entity.FireDetProv
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireDetProv = Nothing
					Else
						entity.FireDetProv = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireDetNeed As System.String 
				Get
					Dim data_ As System.String = entity.FireDetNeed
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireDetNeed = Nothing
					Else
						entity.FireDetNeed = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LevelsRAS As System.String 
				Get
					Dim data_ As System.String = entity.LevelsRAS
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LevelsRAS = Nothing
					Else
						entity.LevelsRAS = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterFlowMonYesNo As System.String 
				Get
					Dim data_ As System.String = entity.WaterFlowMonYesNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterFlowMonYesNo = Nothing
					Else
						entity.WaterFlowMonYesNo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterFlowMonByWhom As System.String 
				Get
					Dim data_ As System.String = entity.WaterFlowMonByWhom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterFlowMonByWhom = Nothing
					Else
						entity.WaterFlowMonByWhom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ValveTamMonYesNo As System.String 
				Get
					Dim data_ As System.String = entity.ValveTamMonYesNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ValveTamMonYesNo = Nothing
					Else
						entity.ValveTamMonYesNo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ValveTamMonByWhom As System.String 
				Get
					Dim data_ As System.String = entity.ValveTamMonByWhom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ValveTamMonByWhom = Nothing
					Else
						entity.ValveTamMonByWhom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoOfValves As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.NoOfValves
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoOfValves = Nothing
					Else
						entity.NoOfValves = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoOfValvesC As System.String 
				Get
					Dim data_ As System.String = entity.NoOfValvesC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoOfValvesC = Nothing
					Else
						entity.NoOfValvesC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AllValvesOpen As System.String 
				Get
					Dim data_ As System.String = entity.AllValvesOpen
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AllValvesOpen = Nothing
					Else
						entity.AllValvesOpen = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AllValvesOpenC As System.String 
				Get
					Dim data_ As System.String = entity.AllValvesOpenC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AllValvesOpenC = Nothing
					Else
						entity.AllValvesOpenC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ValvesLocked As System.String 
				Get
					Dim data_ As System.String = entity.ValvesLocked
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ValvesLocked = Nothing
					Else
						entity.ValvesLocked = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ValvesLockedC As System.String 
				Get
					Dim data_ As System.String = entity.ValvesLockedC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ValvesLockedC = Nothing
					Else
						entity.ValvesLockedC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ValvesLabeled As System.String 
				Get
					Dim data_ As System.String = entity.ValvesLabeled
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ValvesLabeled = Nothing
					Else
						entity.ValvesLabeled = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ValvesLabeledC As System.String 
				Get
					Dim data_ As System.String = entity.ValvesLabeledC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ValvesLabeledC = Nothing
					Else
						entity.ValvesLabeledC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ValvesInspMonthly As System.String 
				Get
					Dim data_ As System.String = entity.ValvesInspMonthly
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ValvesInspMonthly = Nothing
					Else
						entity.ValvesInspMonthly = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ValvesInspMonthlyC As System.String 
				Get
					Dim data_ As System.String = entity.ValvesInspMonthlyC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ValvesInspMonthlyC = Nothing
					Else
						entity.ValvesInspMonthlyC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSHeadBoxMonthly As System.String 
				Get
					Dim data_ As System.String = entity.SSHeadBoxMonthly
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSHeadBoxMonthly = Nothing
					Else
						entity.SSHeadBoxMonthly = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSHeadBoxMonthlyC As System.String 
				Get
					Dim data_ As System.String = entity.SSHeadBoxMonthlyC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSHeadBoxMonthlyC = Nothing
					Else
						entity.SSHeadBoxMonthlyC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSHeadsAvail As System.String 
				Get
					Dim data_ As System.String = entity.SSHeadsAvail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSHeadsAvail = Nothing
					Else
						entity.SSHeadsAvail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSHeadsAvailC As System.String 
				Get
					Dim data_ As System.String = entity.SSHeadsAvailC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSHeadsAvailC = Nothing
					Else
						entity.SSHeadsAvailC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSHeadWrenchInBox As System.String 
				Get
					Dim data_ As System.String = entity.SSHeadWrenchInBox
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSHeadWrenchInBox = Nothing
					Else
						entity.SSHeadWrenchInBox = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSHeadWrenchInBoxC As System.String 
				Get
					Dim data_ As System.String = entity.SSHeadWrenchInBoxC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSHeadWrenchInBoxC = Nothing
					Else
						entity.SSHeadWrenchInBoxC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CorrectHeadsProvided As System.String 
				Get
					Dim data_ As System.String = entity.CorrectHeadsProvided
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CorrectHeadsProvided = Nothing
					Else
						entity.CorrectHeadsProvided = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CorrectHeadsProvidedC As System.String 
				Get
					Dim data_ As System.String = entity.CorrectHeadsProvidedC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CorrectHeadsProvidedC = Nothing
					Else
						entity.CorrectHeadsProvidedC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpProcObserved As System.String 
				Get
					Dim data_ As System.String = entity.ImpProcObserved
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpProcObserved = Nothing
					Else
						entity.ImpProcObserved = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpProcObservedC As System.String 
				Get
					Dim data_ As System.String = entity.ImpProcObservedC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpProcObservedC = Nothing
					Else
						entity.ImpProcObservedC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATV2inDrain As System.String 
				Get
					Dim data_ As System.String = entity.ATV2inDrain
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATV2inDrain = Nothing
					Else
						entity.ATV2inDrain = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATV2inDrainC As System.String 
				Get
					Dim data_ As System.String = entity.ATV2inDrainC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATV2inDrainC = Nothing
					Else
						entity.ATV2inDrainC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVDryPipeValve As System.String 
				Get
					Dim data_ As System.String = entity.ATVDryPipeValve
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVDryPipeValve = Nothing
					Else
						entity.ATVDryPipeValve = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVDryPipeValveC As System.String 
				Get
					Dim data_ As System.String = entity.ATVDryPipeValveC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVDryPipeValveC = Nothing
					Else
						entity.ATVDryPipeValveC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVFirePump As System.String 
				Get
					Dim data_ As System.String = entity.ATVFirePump
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVFirePump = Nothing
					Else
						entity.ATVFirePump = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVFirePumpC As System.String 
				Get
					Dim data_ As System.String = entity.ATVFirePumpC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVFirePumpC = Nothing
					Else
						entity.ATVFirePumpC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVAntifreeze As System.String 
				Get
					Dim data_ As System.String = entity.ATVAntifreeze
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVAntifreeze = Nothing
					Else
						entity.ATVAntifreeze = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVAntifreezeC As System.String 
				Get
					Dim data_ As System.String = entity.ATVAntifreezeC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVAntifreezeC = Nothing
					Else
						entity.ATVAntifreezeC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoMissingCapsFDC As System.String 
				Get
					Dim data_ As System.String = entity.NoMissingCapsFDC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoMissingCapsFDC = Nothing
					Else
						entity.NoMissingCapsFDC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoMissingCapsFDCC As System.String 
				Get
					Dim data_ As System.String = entity.NoMissingCapsFDCC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoMissingCapsFDCC = Nothing
					Else
						entity.NoMissingCapsFDCC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVValveTamper As System.String 
				Get
					Dim data_ As System.String = entity.ATVValveTamper
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVValveTamper = Nothing
					Else
						entity.ATVValveTamper = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVValveTamperC As System.String 
				Get
					Dim data_ As System.String = entity.ATVValveTamperC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVValveTamperC = Nothing
					Else
						entity.ATVValveTamperC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVWaterFlow As System.String 
				Get
					Dim data_ As System.String = entity.ATVWaterFlow
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVWaterFlow = Nothing
					Else
						entity.ATVWaterFlow = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVWaterFlowC As System.String 
				Get
					Dim data_ As System.String = entity.ATVWaterFlowC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVWaterFlowC = Nothing
					Else
						entity.ATVWaterFlowC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVDrySysLowAir As System.String 
				Get
					Dim data_ As System.String = entity.ATVDrySysLowAir
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVDrySysLowAir = Nothing
					Else
						entity.ATVDrySysLowAir = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ATVDrySysLowAirC As System.String 
				Get
					Dim data_ As System.String = entity.ATVDrySysLowAirC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ATVDrySysLowAirC = Nothing
					Else
						entity.ATVDrySysLowAirC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireSupSysOver As System.String 
				Get
					Dim data_ As System.String = entity.FireSupSysOver
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireSupSysOver = Nothing
					Else
						entity.FireSupSysOver = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireSupSysOverC As System.String 
				Get
					Dim data_ As System.String = entity.FireSupSysOverC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireSupSysOverC = Nothing
					Else
						entity.FireSupSysOverC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BlowOffCaps As System.String 
				Get
					Dim data_ As System.String = entity.BlowOffCaps
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BlowOffCaps = Nothing
					Else
						entity.BlowOffCaps = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BlowOffCapsC As System.String 
				Get
					Dim data_ As System.String = entity.BlowOffCapsC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BlowOffCapsC = Nothing
					Else
						entity.BlowOffCapsC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ManualRelease As System.String 
				Get
					Dim data_ As System.String = entity.ManualRelease
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ManualRelease = Nothing
					Else
						entity.ManualRelease = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ManualReleaseC As System.String 
				Get
					Dim data_ As System.String = entity.ManualReleaseC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ManualReleaseC = Nothing
					Else
						entity.ManualReleaseC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Min18Clearance As System.String 
				Get
					Dim data_ As System.String = entity.Min18Clearance
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Min18Clearance = Nothing
					Else
						entity.Min18Clearance = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Min18ClearanceC As System.String 
				Get
					Dim data_ As System.String = entity.Min18ClearanceC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Min18ClearanceC = Nothing
					Else
						entity.Min18ClearanceC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireAlarmZonePosted As System.String 
				Get
					Dim data_ As System.String = entity.FireAlarmZonePosted
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireAlarmZonePosted = Nothing
					Else
						entity.FireAlarmZonePosted = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireAlarmZonePostedC As System.String 
				Get
					Dim data_ As System.String = entity.FireAlarmZonePostedC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireAlarmZonePostedC = Nothing
					Else
						entity.FireAlarmZonePostedC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PFEInspMonthly As System.String 
				Get
					Dim data_ As System.String = entity.PFEInspMonthly
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PFEInspMonthly = Nothing
					Else
						entity.PFEInspMonthly = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PFEInspMonthlyC As System.String 
				Get
					Dim data_ As System.String = entity.PFEInspMonthlyC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PFEInspMonthlyC = Nothing
					Else
						entity.PFEInspMonthlyC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PFEServAnn As System.String 
				Get
					Dim data_ As System.String = entity.PFEServAnn
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PFEServAnn = Nothing
					Else
						entity.PFEServAnn = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PFEServAnnC As System.String 
				Get
					Dim data_ As System.String = entity.PFEServAnnC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PFEServAnnC = Nothing
					Else
						entity.PFEServAnnC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PFEAppTypeSize As System.String 
				Get
					Dim data_ As System.String = entity.PFEAppTypeSize
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PFEAppTypeSize = Nothing
					Else
						entity.PFEAppTypeSize = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PFEAppTypeSizeC As System.String 
				Get
					Dim data_ As System.String = entity.PFEAppTypeSizeC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PFEAppTypeSizeC = Nothing
					Else
						entity.PFEAppTypeSizeC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PFEMounted As System.String 
				Get
					Dim data_ As System.String = entity.PFEMounted
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PFEMounted = Nothing
					Else
						entity.PFEMounted = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PFEMountedC As System.String 
				Get
					Dim data_ As System.String = entity.PFEMountedC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PFEMountedC = Nothing
					Else
						entity.PFEMountedC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireHosesInsp As System.String 
				Get
					Dim data_ As System.String = entity.FireHosesInsp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireHosesInsp = Nothing
					Else
						entity.FireHosesInsp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireHosesInspC As System.String 
				Get
					Dim data_ As System.String = entity.FireHosesInspC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireHosesInspC = Nothing
					Else
						entity.FireHosesInspC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExhaustHoodsDuct As System.String 
				Get
					Dim data_ As System.String = entity.ExhaustHoodsDuct
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExhaustHoodsDuct = Nothing
					Else
						entity.ExhaustHoodsDuct = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExhaustHoodsDuctC As System.String 
				Get
					Dim data_ As System.String = entity.ExhaustHoodsDuctC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExhaustHoodsDuctC = Nothing
					Else
						entity.ExhaustHoodsDuctC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FiltersForCooking As System.String 
				Get
					Dim data_ As System.String = entity.FiltersForCooking
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FiltersForCooking = Nothing
					Else
						entity.FiltersForCooking = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FiltersForCookingC As System.String 
				Get
					Dim data_ As System.String = entity.FiltersForCookingC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FiltersForCookingC = Nothing
					Else
						entity.FiltersForCookingC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ELProvided As System.String 
				Get
					Dim data_ As System.String = entity.ELProvided
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ELProvided = Nothing
					Else
						entity.ELProvided = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ELProvidedC As System.String 
				Get
					Dim data_ As System.String = entity.ELProvidedC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ELProvidedC = Nothing
					Else
						entity.ELProvidedC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BatOpEmerExit As System.String 
				Get
					Dim data_ As System.String = entity.BatOpEmerExit
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BatOpEmerExit = Nothing
					Else
						entity.BatOpEmerExit = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BatOpEmerExitC As System.String 
				Get
					Dim data_ As System.String = entity.BatOpEmerExitC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BatOpEmerExitC = Nothing
					Else
						entity.BatOpEmerExitC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmergGenOptMonthly As System.String 
				Get
					Dim data_ As System.String = entity.EmergGenOptMonthly
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmergGenOptMonthly = Nothing
					Else
						entity.EmergGenOptMonthly = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmergGenOptMonthlyC As System.String 
				Get
					Dim data_ As System.String = entity.EmergGenOptMonthlyC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmergGenOptMonthlyC = Nothing
					Else
						entity.EmergGenOptMonthlyC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GenSecPreUnauth As System.String 
				Get
					Dim data_ As System.String = entity.GenSecPreUnauth
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GenSecPreUnauth = Nothing
					Else
						entity.GenSecPreUnauth = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GenSecPreUnauthC As System.String 
				Get
					Dim data_ As System.String = entity.GenSecPreUnauthC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GenSecPreUnauthC = Nothing
					Else
						entity.GenSecPreUnauthC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExitSignsProvIll As System.String 
				Get
					Dim data_ As System.String = entity.ExitSignsProvIll
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExitSignsProvIll = Nothing
					Else
						entity.ExitSignsProvIll = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExitSignsProvIllC As System.String 
				Get
					Dim data_ As System.String = entity.ExitSignsProvIllC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExitSignsProvIllC = Nothing
					Else
						entity.ExitSignsProvIllC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExitDoorsUnobstr As System.String 
				Get
					Dim data_ As System.String = entity.ExitDoorsUnobstr
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExitDoorsUnobstr = Nothing
					Else
						entity.ExitDoorsUnobstr = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExitDoorsUnobstrC As System.String 
				Get
					Dim data_ As System.String = entity.ExitDoorsUnobstrC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExitDoorsUnobstrC = Nothing
					Else
						entity.ExitDoorsUnobstrC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatGasFryer As System.String 
				Get
					Dim data_ As System.String = entity.NatGasFryer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatGasFryer = Nothing
					Else
						entity.NatGasFryer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatGasFryerC As System.String 
				Get
					Dim data_ As System.String = entity.NatGasFryerC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatGasFryerC = Nothing
					Else
						entity.NatGasFryerC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicGasShutoff As System.String 
				Get
					Dim data_ As System.String = entity.SeismicGasShutoff
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicGasShutoff = Nothing
					Else
						entity.SeismicGasShutoff = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicGasShutoffC As System.String 
				Get
					Dim data_ As System.String = entity.SeismicGasShutoffC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicGasShutoffC = Nothing
					Else
						entity.SeismicGasShutoffC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StorRacksBolted As System.String 
				Get
					Dim data_ As System.String = entity.StorRacksBolted
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StorRacksBolted = Nothing
					Else
						entity.StorRacksBolted = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StorRacksBoltedC As System.String 
				Get
					Dim data_ As System.String = entity.StorRacksBoltedC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StorRacksBoltedC = Nothing
					Else
						entity.StorRacksBoltedC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HotWorkPermit As System.String 
				Get
					Dim data_ As System.String = entity.HotWorkPermit
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HotWorkPermit = Nothing
					Else
						entity.HotWorkPermit = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HotWorkPermitC As System.String 
				Get
					Dim data_ As System.String = entity.HotWorkPermitC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HotWorkPermitC = Nothing
					Else
						entity.HotWorkPermitC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FlamLiqStored As System.String 
				Get
					Dim data_ As System.String = entity.FlamLiqStored
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FlamLiqStored = Nothing
					Else
						entity.FlamLiqStored = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FlamLiqStoredC As System.String 
				Get
					Dim data_ As System.String = entity.FlamLiqStoredC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FlamLiqStoredC = Nothing
					Else
						entity.FlamLiqStoredC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _16Separation As System.String 
				Get
					Dim data_ As System.String = entity._16Separation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._16Separation = Nothing
					Else
						entity._16Separation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _16SeparationC As System.String 
				Get
					Dim data_ As System.String = entity._16SeparationC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._16SeparationC = Nothing
					Else
						entity._16SeparationC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PropCylinders As System.String 
				Get
					Dim data_ As System.String = entity.PropCylinders
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PropCylinders = Nothing
					Else
						entity.PropCylinders = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PropCylindersC As System.String 
				Get
					Dim data_ As System.String = entity.PropCylindersC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PropCylindersC = Nothing
					Else
						entity.PropCylindersC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PropStorage As System.String 
				Get
					Dim data_ As System.String = entity.PropStorage
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PropStorage = Nothing
					Else
						entity.PropStorage = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PropStorageC As System.String 
				Get
					Dim data_ As System.String = entity.PropStorageC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PropStorageC = Nothing
					Else
						entity.PropStorageC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoSmoking As System.String 
				Get
					Dim data_ As System.String = entity.NoSmoking
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoSmoking = Nothing
					Else
						entity.NoSmoking = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoSmokingC As System.String 
				Get
					Dim data_ As System.String = entity.NoSmokingC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoSmokingC = Nothing
					Else
						entity.NoSmokingC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireDoorsNotObstr As System.String 
				Get
					Dim data_ As System.String = entity.FireDoorsNotObstr
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireDoorsNotObstr = Nothing
					Else
						entity.FireDoorsNotObstr = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireDoorsNotObstrC As System.String 
				Get
					Dim data_ As System.String = entity.FireDoorsNotObstrC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireDoorsNotObstrC = Nothing
					Else
						entity.FireDoorsNotObstrC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoMissCealTiles As System.String 
				Get
					Dim data_ As System.String = entity.NoMissCealTiles
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoMissCealTiles = Nothing
					Else
						entity.NoMissCealTiles = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoMissCealTilesC As System.String 
				Get
					Dim data_ As System.String = entity.NoMissCealTilesC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoMissCealTilesC = Nothing
					Else
						entity.NoMissCealTilesC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BarricadeProvided As System.String 
				Get
					Dim data_ As System.String = entity.BarricadeProvided
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BarricadeProvided = Nothing
					Else
						entity.BarricadeProvided = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BarricadeProvidedC As System.String 
				Get
					Dim data_ As System.String = entity.BarricadeProvidedC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BarricadeProvidedC = Nothing
					Else
						entity.BarricadeProvidedC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoStorageInElecRm As System.String 
				Get
					Dim data_ As System.String = entity.NoStorageInElecRm
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoStorageInElecRm = Nothing
					Else
						entity.NoStorageInElecRm = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoStorageInElecRmC As System.String 
				Get
					Dim data_ As System.String = entity.NoStorageInElecRmC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoStorageInElecRmC = Nothing
					Else
						entity.NoStorageInElecRmC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlasSkids As System.String 
				Get
					Dim data_ As System.String = entity.PlasSkids
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlasSkids = Nothing
					Else
						entity.PlasSkids = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlasSkidsC As System.String 
				Get
					Dim data_ As System.String = entity.PlasSkidsC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlasSkidsC = Nothing
					Else
						entity.PlasSkidsC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectExtCords As System.String 
				Get
					Dim data_ As System.String = entity.ElectExtCords
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectExtCords = Nothing
					Else
						entity.ElectExtCords = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectExtCordsC As System.String 
				Get
					Dim data_ As System.String = entity.ElectExtCordsC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectExtCordsC = Nothing
					Else
						entity.ElectExtCordsC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectEquipFreeDam As System.String 
				Get
					Dim data_ As System.String = entity.ElectEquipFreeDam
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectEquipFreeDam = Nothing
					Else
						entity.ElectEquipFreeDam = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectEquipFreeDamC As System.String 
				Get
					Dim data_ As System.String = entity.ElectEquipFreeDamC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectEquipFreeDamC = Nothing
					Else
						entity.ElectEquipFreeDamC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _36Clearance As System.String 
				Get
					Dim data_ As System.String = entity._36Clearance
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._36Clearance = Nothing
					Else
						entity._36Clearance = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _36ClearanceC As System.String 
				Get
					Dim data_ As System.String = entity._36ClearanceC
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._36ClearanceC = Nothing
					Else
						entity._36ClearanceC = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esFireRetail
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return FireRetailMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As FireRetailQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New FireRetailQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As FireRetailQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As FireRetailQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As FireRetailQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esFireRetailCollection
		Inherits esEntityCollection(Of FireRetail)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return FireRetailMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "FireRetailCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As FireRetailQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New FireRetailQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As FireRetailQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New FireRetailQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As FireRetailQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, FireRetailQuery))
		End Sub
		
		#End Region
						
		Private m_query As FireRetailQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esFireRetailQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FireRetailMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "SurveyDate" 
					Return Me.SurveyDate
				Case "Summary" 
					Return Me.Summary
				Case "TypeStore" 
					Return Me.TypeStore
				Case "MilesToCoast" 
					Return Me.MilesToCoast
				Case "RespTime" 
					Return Me.RespTime
				Case "HydrantDistance" 
					Return Me.HydrantDistance
				Case "FootprintBldg" 
					Return Me.FootprintBldg
				Case "RackStorArea" 
					Return Me.RackStorArea
				Case "BackroomStorArea" 
					Return Me.BackroomStorArea
				Case "BackroomStorHgt" 
					Return Me.BackroomStorHgt
				Case "SalesFlStorArea" 
					Return Me.SalesFlStorArea
				Case "SalesFlStorHgt" 
					Return Me.SalesFlStorHgt
				Case "AverSlAreaProdHgt" 
					Return Me.AverSlAreaProdHgt
				Case "MaxSlAreaProdHgt" 
					Return Me.MaxSlAreaProdHgt
				Case "CeilASSP" 
					Return Me.CeilASSP
				Case "CeilASSN" 
					Return Me.CeilASSN
				Case "RackAASP" 
					Return Me.RackAASP
				Case "RackAASN" 
					Return Me.RackAASN
				Case "FireDetProv" 
					Return Me.FireDetProv
				Case "FireDetNeed" 
					Return Me.FireDetNeed
				Case "LevelsRAS" 
					Return Me.LevelsRAS
				Case "WaterFlowMonYesNo" 
					Return Me.WaterFlowMonYesNo
				Case "WaterFlowMonByWhom" 
					Return Me.WaterFlowMonByWhom
				Case "ValveTamMonYesNo" 
					Return Me.ValveTamMonYesNo
				Case "ValveTamMonByWhom" 
					Return Me.ValveTamMonByWhom
				Case "NoOfValves" 
					Return Me.NoOfValves
				Case "NoOfValvesC" 
					Return Me.NoOfValvesC
				Case "AllValvesOpen" 
					Return Me.AllValvesOpen
				Case "AllValvesOpenC" 
					Return Me.AllValvesOpenC
				Case "ValvesLocked" 
					Return Me.ValvesLocked
				Case "ValvesLockedC" 
					Return Me.ValvesLockedC
				Case "ValvesLabeled" 
					Return Me.ValvesLabeled
				Case "ValvesLabeledC" 
					Return Me.ValvesLabeledC
				Case "ValvesInspMonthly" 
					Return Me.ValvesInspMonthly
				Case "ValvesInspMonthlyC" 
					Return Me.ValvesInspMonthlyC
				Case "SSHeadBoxMonthly" 
					Return Me.SSHeadBoxMonthly
				Case "SSHeadBoxMonthlyC" 
					Return Me.SSHeadBoxMonthlyC
				Case "SSHeadsAvail" 
					Return Me.SSHeadsAvail
				Case "SSHeadsAvailC" 
					Return Me.SSHeadsAvailC
				Case "SSHeadWrenchInBox" 
					Return Me.SSHeadWrenchInBox
				Case "SSHeadWrenchInBoxC" 
					Return Me.SSHeadWrenchInBoxC
				Case "CorrectHeadsProvided" 
					Return Me.CorrectHeadsProvided
				Case "CorrectHeadsProvidedC" 
					Return Me.CorrectHeadsProvidedC
				Case "ImpProcObserved" 
					Return Me.ImpProcObserved
				Case "ImpProcObservedC" 
					Return Me.ImpProcObservedC
				Case "ATV2inDrain" 
					Return Me.ATV2inDrain
				Case "ATV2inDrainC" 
					Return Me.ATV2inDrainC
				Case "ATVDryPipeValve" 
					Return Me.ATVDryPipeValve
				Case "ATVDryPipeValveC" 
					Return Me.ATVDryPipeValveC
				Case "ATVFirePump" 
					Return Me.ATVFirePump
				Case "ATVFirePumpC" 
					Return Me.ATVFirePumpC
				Case "ATVAntifreeze" 
					Return Me.ATVAntifreeze
				Case "ATVAntifreezeC" 
					Return Me.ATVAntifreezeC
				Case "NoMissingCapsFDC" 
					Return Me.NoMissingCapsFDC
				Case "NoMissingCapsFDCC" 
					Return Me.NoMissingCapsFDCC
				Case "ATVValveTamper" 
					Return Me.ATVValveTamper
				Case "ATVValveTamperC" 
					Return Me.ATVValveTamperC
				Case "ATVWaterFlow" 
					Return Me.ATVWaterFlow
				Case "ATVWaterFlowC" 
					Return Me.ATVWaterFlowC
				Case "ATVDrySysLowAir" 
					Return Me.ATVDrySysLowAir
				Case "ATVDrySysLowAirC" 
					Return Me.ATVDrySysLowAirC
				Case "FireSupSysOver" 
					Return Me.FireSupSysOver
				Case "FireSupSysOverC" 
					Return Me.FireSupSysOverC
				Case "BlowOffCaps" 
					Return Me.BlowOffCaps
				Case "BlowOffCapsC" 
					Return Me.BlowOffCapsC
				Case "ManualRelease" 
					Return Me.ManualRelease
				Case "ManualReleaseC" 
					Return Me.ManualReleaseC
				Case "Min18Clearance" 
					Return Me.Min18Clearance
				Case "Min18ClearanceC" 
					Return Me.Min18ClearanceC
				Case "FireAlarmZonePosted" 
					Return Me.FireAlarmZonePosted
				Case "FireAlarmZonePostedC" 
					Return Me.FireAlarmZonePostedC
				Case "PFEInspMonthly" 
					Return Me.PFEInspMonthly
				Case "PFEInspMonthlyC" 
					Return Me.PFEInspMonthlyC
				Case "PFEServAnn" 
					Return Me.PFEServAnn
				Case "PFEServAnnC" 
					Return Me.PFEServAnnC
				Case "PFEAppTypeSize" 
					Return Me.PFEAppTypeSize
				Case "PFEAppTypeSizeC" 
					Return Me.PFEAppTypeSizeC
				Case "PFEMounted" 
					Return Me.PFEMounted
				Case "PFEMountedC" 
					Return Me.PFEMountedC
				Case "FireHosesInsp" 
					Return Me.FireHosesInsp
				Case "FireHosesInspC" 
					Return Me.FireHosesInspC
				Case "ExhaustHoodsDuct" 
					Return Me.ExhaustHoodsDuct
				Case "ExhaustHoodsDuctC" 
					Return Me.ExhaustHoodsDuctC
				Case "FiltersForCooking" 
					Return Me.FiltersForCooking
				Case "FiltersForCookingC" 
					Return Me.FiltersForCookingC
				Case "ELProvided" 
					Return Me.ELProvided
				Case "ELProvidedC" 
					Return Me.ELProvidedC
				Case "BatOpEmerExit" 
					Return Me.BatOpEmerExit
				Case "BatOpEmerExitC" 
					Return Me.BatOpEmerExitC
				Case "EmergGenOptMonthly" 
					Return Me.EmergGenOptMonthly
				Case "EmergGenOptMonthlyC" 
					Return Me.EmergGenOptMonthlyC
				Case "GenSecPreUnauth" 
					Return Me.GenSecPreUnauth
				Case "GenSecPreUnauthC" 
					Return Me.GenSecPreUnauthC
				Case "ExitSignsProvIll" 
					Return Me.ExitSignsProvIll
				Case "ExitSignsProvIllC" 
					Return Me.ExitSignsProvIllC
				Case "ExitDoorsUnobstr" 
					Return Me.ExitDoorsUnobstr
				Case "ExitDoorsUnobstrC" 
					Return Me.ExitDoorsUnobstrC
				Case "NatGasFryer" 
					Return Me.NatGasFryer
				Case "NatGasFryerC" 
					Return Me.NatGasFryerC
				Case "SeismicGasShutoff" 
					Return Me.SeismicGasShutoff
				Case "SeismicGasShutoffC" 
					Return Me.SeismicGasShutoffC
				Case "StorRacksBolted" 
					Return Me.StorRacksBolted
				Case "StorRacksBoltedC" 
					Return Me.StorRacksBoltedC
				Case "HotWorkPermit" 
					Return Me.HotWorkPermit
				Case "HotWorkPermitC" 
					Return Me.HotWorkPermitC
				Case "FlamLiqStored" 
					Return Me.FlamLiqStored
				Case "FlamLiqStoredC" 
					Return Me.FlamLiqStoredC
				Case "_16Separation" 
					Return Me._16Separation
				Case "_16SeparationC" 
					Return Me._16SeparationC
				Case "PropCylinders" 
					Return Me.PropCylinders
				Case "PropCylindersC" 
					Return Me.PropCylindersC
				Case "PropStorage" 
					Return Me.PropStorage
				Case "PropStorageC" 
					Return Me.PropStorageC
				Case "NoSmoking" 
					Return Me.NoSmoking
				Case "NoSmokingC" 
					Return Me.NoSmokingC
				Case "FireDoorsNotObstr" 
					Return Me.FireDoorsNotObstr
				Case "FireDoorsNotObstrC" 
					Return Me.FireDoorsNotObstrC
				Case "NoMissCealTiles" 
					Return Me.NoMissCealTiles
				Case "NoMissCealTilesC" 
					Return Me.NoMissCealTilesC
				Case "BarricadeProvided" 
					Return Me.BarricadeProvided
				Case "BarricadeProvidedC" 
					Return Me.BarricadeProvidedC
				Case "NoStorageInElecRm" 
					Return Me.NoStorageInElecRm
				Case "NoStorageInElecRmC" 
					Return Me.NoStorageInElecRmC
				Case "PlasSkids" 
					Return Me.PlasSkids
				Case "PlasSkidsC" 
					Return Me.PlasSkidsC
				Case "ElectExtCords" 
					Return Me.ElectExtCords
				Case "ElectExtCordsC" 
					Return Me.ElectExtCordsC
				Case "ElectEquipFreeDam" 
					Return Me.ElectEquipFreeDam
				Case "ElectEquipFreeDamC" 
					Return Me.ElectEquipFreeDamC
				Case "_36Clearance" 
					Return Me._36Clearance
				Case "_36ClearanceC" 
					Return Me._36ClearanceC
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Summary As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.Summary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TypeStore As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.TypeStore, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MilesToCoast As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.MilesToCoast, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property RespTime As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.RespTime, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property HydrantDistance As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.HydrantDistance, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FootprintBldg As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FootprintBldg, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RackStorArea As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.RackStorArea, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BackroomStorArea As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.BackroomStorArea, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BackroomStorHgt As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.BackroomStorHgt, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SalesFlStorArea As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SalesFlStorArea, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SalesFlStorHgt As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SalesFlStorHgt, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property AverSlAreaProdHgt As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.AverSlAreaProdHgt, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MaxSlAreaProdHgt As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.MaxSlAreaProdHgt, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CeilASSP As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.CeilASSP, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property CeilASSN As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.CeilASSN, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property RackAASP As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.RackAASP, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property RackAASN As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.RackAASN, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property FireDetProv As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireDetProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireDetNeed As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireDetNeed, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LevelsRAS As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.LevelsRAS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterFlowMonYesNo As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.WaterFlowMonYesNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterFlowMonByWhom As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.WaterFlowMonByWhom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ValveTamMonYesNo As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ValveTamMonYesNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ValveTamMonByWhom As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ValveTamMonByWhom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoOfValves As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoOfValves, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property NoOfValvesC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoOfValvesC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AllValvesOpen As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.AllValvesOpen, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AllValvesOpenC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.AllValvesOpenC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ValvesLocked As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ValvesLocked, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ValvesLockedC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ValvesLockedC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ValvesLabeled As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ValvesLabeled, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ValvesLabeledC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ValvesLabeledC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ValvesInspMonthly As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ValvesInspMonthly, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ValvesInspMonthlyC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ValvesInspMonthlyC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSHeadBoxMonthly As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SSHeadBoxMonthly, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSHeadBoxMonthlyC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SSHeadBoxMonthlyC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSHeadsAvail As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SSHeadsAvail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSHeadsAvailC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SSHeadsAvailC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSHeadWrenchInBox As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SSHeadWrenchInBox, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSHeadWrenchInBoxC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SSHeadWrenchInBoxC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CorrectHeadsProvided As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.CorrectHeadsProvided, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CorrectHeadsProvidedC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.CorrectHeadsProvidedC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpProcObserved As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ImpProcObserved, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpProcObservedC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ImpProcObservedC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATV2inDrain As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATV2inDrain, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATV2inDrainC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATV2inDrainC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVDryPipeValve As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVDryPipeValve, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVDryPipeValveC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVDryPipeValveC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVFirePump As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVFirePump, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVFirePumpC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVFirePumpC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVAntifreeze As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVAntifreeze, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVAntifreezeC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVAntifreezeC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoMissingCapsFDC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoMissingCapsFDC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoMissingCapsFDCC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoMissingCapsFDCC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVValveTamper As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVValveTamper, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVValveTamperC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVValveTamperC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVWaterFlow As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVWaterFlow, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVWaterFlowC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVWaterFlowC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVDrySysLowAir As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVDrySysLowAir, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ATVDrySysLowAirC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ATVDrySysLowAirC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireSupSysOver As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireSupSysOver, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireSupSysOverC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireSupSysOverC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BlowOffCaps As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.BlowOffCaps, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BlowOffCapsC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.BlowOffCapsC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ManualRelease As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ManualRelease, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ManualReleaseC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ManualReleaseC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Min18Clearance As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.Min18Clearance, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Min18ClearanceC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.Min18ClearanceC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireAlarmZonePosted As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireAlarmZonePosted, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireAlarmZonePostedC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireAlarmZonePostedC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PFEInspMonthly As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PFEInspMonthly, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PFEInspMonthlyC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PFEInspMonthlyC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PFEServAnn As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PFEServAnn, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PFEServAnnC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PFEServAnnC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PFEAppTypeSize As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PFEAppTypeSize, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PFEAppTypeSizeC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PFEAppTypeSizeC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PFEMounted As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PFEMounted, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PFEMountedC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PFEMountedC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireHosesInsp As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireHosesInsp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireHosesInspC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireHosesInspC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExhaustHoodsDuct As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ExhaustHoodsDuct, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExhaustHoodsDuctC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ExhaustHoodsDuctC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FiltersForCooking As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FiltersForCooking, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FiltersForCookingC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FiltersForCookingC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ELProvided As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ELProvided, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ELProvidedC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ELProvidedC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BatOpEmerExit As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.BatOpEmerExit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BatOpEmerExitC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.BatOpEmerExitC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmergGenOptMonthly As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.EmergGenOptMonthly, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmergGenOptMonthlyC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.EmergGenOptMonthlyC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GenSecPreUnauth As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.GenSecPreUnauth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GenSecPreUnauthC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.GenSecPreUnauthC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExitSignsProvIll As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ExitSignsProvIll, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExitSignsProvIllC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ExitSignsProvIllC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExitDoorsUnobstr As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ExitDoorsUnobstr, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExitDoorsUnobstrC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ExitDoorsUnobstrC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatGasFryer As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NatGasFryer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatGasFryerC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NatGasFryerC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicGasShutoff As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SeismicGasShutoff, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicGasShutoffC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.SeismicGasShutoffC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StorRacksBolted As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.StorRacksBolted, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StorRacksBoltedC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.StorRacksBoltedC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HotWorkPermit As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.HotWorkPermit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HotWorkPermitC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.HotWorkPermitC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FlamLiqStored As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FlamLiqStored, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FlamLiqStoredC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FlamLiqStoredC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _16Separation As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames._16Separation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _16SeparationC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames._16SeparationC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PropCylinders As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PropCylinders, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PropCylindersC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PropCylindersC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PropStorage As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PropStorage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PropStorageC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PropStorageC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoSmoking As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoSmoking, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoSmokingC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoSmokingC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireDoorsNotObstr As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireDoorsNotObstr, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireDoorsNotObstrC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.FireDoorsNotObstrC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoMissCealTiles As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoMissCealTiles, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoMissCealTilesC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoMissCealTilesC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BarricadeProvided As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.BarricadeProvided, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BarricadeProvidedC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.BarricadeProvidedC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoStorageInElecRm As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoStorageInElecRm, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoStorageInElecRmC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.NoStorageInElecRmC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlasSkids As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PlasSkids, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlasSkidsC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.PlasSkidsC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectExtCords As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ElectExtCords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectExtCordsC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ElectExtCordsC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectEquipFreeDam As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ElectEquipFreeDam, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectEquipFreeDamC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames.ElectEquipFreeDamC, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _36Clearance As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames._36Clearance, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _36ClearanceC As esQueryItem
			Get
				Return New esQueryItem(Me, FireRetailMetadata.ColumnNames._36ClearanceC, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class FireRetailMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SurveyDate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SurveyDate
			c.IsInPrimaryKey = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.Summary, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.Summary
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.TypeStore, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.TypeStore
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.MilesToCoast, 4, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = FireRetailMetadata.PropertyNames.MilesToCoast
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.RespTime, 5, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = FireRetailMetadata.PropertyNames.RespTime
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.HydrantDistance, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.HydrantDistance
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FootprintBldg, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FootprintBldg
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.RackStorArea, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FireRetailMetadata.PropertyNames.RackStorArea
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.BackroomStorArea, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FireRetailMetadata.PropertyNames.BackroomStorArea
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.BackroomStorHgt, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FireRetailMetadata.PropertyNames.BackroomStorHgt
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SalesFlStorArea, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SalesFlStorArea
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SalesFlStorHgt, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SalesFlStorHgt
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.AverSlAreaProdHgt, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FireRetailMetadata.PropertyNames.AverSlAreaProdHgt
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.MaxSlAreaProdHgt, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FireRetailMetadata.PropertyNames.MaxSlAreaProdHgt
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.CeilASSP, 15, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = FireRetailMetadata.PropertyNames.CeilASSP
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.CeilASSN, 16, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = FireRetailMetadata.PropertyNames.CeilASSN
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.RackAASP, 17, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = FireRetailMetadata.PropertyNames.RackAASP
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.RackAASN, 18, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = FireRetailMetadata.PropertyNames.RackAASN
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireDetProv, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireDetProv
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireDetNeed, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireDetNeed
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.LevelsRAS, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.LevelsRAS
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.WaterFlowMonYesNo, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.WaterFlowMonYesNo
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.WaterFlowMonByWhom, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.WaterFlowMonByWhom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ValveTamMonYesNo, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ValveTamMonYesNo
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ValveTamMonByWhom, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ValveTamMonByWhom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoOfValves, 26, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoOfValves
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoOfValvesC, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoOfValvesC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.AllValvesOpen, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.AllValvesOpen
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.AllValvesOpenC, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.AllValvesOpenC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ValvesLocked, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ValvesLocked
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ValvesLockedC, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ValvesLockedC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ValvesLabeled, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ValvesLabeled
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ValvesLabeledC, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ValvesLabeledC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ValvesInspMonthly, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ValvesInspMonthly
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ValvesInspMonthlyC, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ValvesInspMonthlyC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SSHeadBoxMonthly, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SSHeadBoxMonthly
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SSHeadBoxMonthlyC, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SSHeadBoxMonthlyC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SSHeadsAvail, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SSHeadsAvail
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SSHeadsAvailC, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SSHeadsAvailC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SSHeadWrenchInBox, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SSHeadWrenchInBox
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SSHeadWrenchInBoxC, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SSHeadWrenchInBoxC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.CorrectHeadsProvided, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.CorrectHeadsProvided
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.CorrectHeadsProvidedC, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.CorrectHeadsProvidedC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ImpProcObserved, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ImpProcObserved
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ImpProcObservedC, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ImpProcObservedC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATV2inDrain, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATV2inDrain
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATV2inDrainC, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATV2inDrainC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVDryPipeValve, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVDryPipeValve
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVDryPipeValveC, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVDryPipeValveC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVFirePump, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVFirePump
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVFirePumpC, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVFirePumpC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVAntifreeze, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVAntifreeze
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVAntifreezeC, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVAntifreezeC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoMissingCapsFDC, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoMissingCapsFDC
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoMissingCapsFDCC, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoMissingCapsFDCC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVValveTamper, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVValveTamper
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVValveTamperC, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVValveTamperC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVWaterFlow, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVWaterFlow
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVWaterFlowC, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVWaterFlowC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVDrySysLowAir, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVDrySysLowAir
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ATVDrySysLowAirC, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ATVDrySysLowAirC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireSupSysOver, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireSupSysOver
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireSupSysOverC, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireSupSysOverC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.BlowOffCaps, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.BlowOffCaps
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.BlowOffCapsC, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.BlowOffCapsC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ManualRelease, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ManualRelease
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ManualReleaseC, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ManualReleaseC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.Min18Clearance, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.Min18Clearance
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.Min18ClearanceC, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.Min18ClearanceC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireAlarmZonePosted, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireAlarmZonePosted
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireAlarmZonePostedC, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireAlarmZonePostedC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PFEInspMonthly, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PFEInspMonthly
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PFEInspMonthlyC, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PFEInspMonthlyC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PFEServAnn, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PFEServAnn
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PFEServAnnC, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PFEServAnnC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PFEAppTypeSize, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PFEAppTypeSize
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PFEAppTypeSizeC, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PFEAppTypeSizeC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PFEMounted, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PFEMounted
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PFEMountedC, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PFEMountedC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireHosesInsp, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireHosesInsp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireHosesInspC, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireHosesInspC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ExhaustHoodsDuct, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ExhaustHoodsDuct
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ExhaustHoodsDuctC, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ExhaustHoodsDuctC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FiltersForCooking, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FiltersForCooking
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FiltersForCookingC, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FiltersForCookingC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ELProvided, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ELProvided
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ELProvidedC, 87, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ELProvidedC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.BatOpEmerExit, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.BatOpEmerExit
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.BatOpEmerExitC, 89, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.BatOpEmerExitC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.EmergGenOptMonthly, 90, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.EmergGenOptMonthly
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.EmergGenOptMonthlyC, 91, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.EmergGenOptMonthlyC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.GenSecPreUnauth, 92, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.GenSecPreUnauth
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.GenSecPreUnauthC, 93, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.GenSecPreUnauthC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ExitSignsProvIll, 94, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ExitSignsProvIll
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ExitSignsProvIllC, 95, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ExitSignsProvIllC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ExitDoorsUnobstr, 96, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ExitDoorsUnobstr
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ExitDoorsUnobstrC, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ExitDoorsUnobstrC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NatGasFryer, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NatGasFryer
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NatGasFryerC, 99, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NatGasFryerC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SeismicGasShutoff, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SeismicGasShutoff
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.SeismicGasShutoffC, 101, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.SeismicGasShutoffC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.StorRacksBolted, 102, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.StorRacksBolted
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.StorRacksBoltedC, 103, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.StorRacksBoltedC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.HotWorkPermit, 104, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.HotWorkPermit
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.HotWorkPermitC, 105, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.HotWorkPermitC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FlamLiqStored, 106, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FlamLiqStored
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FlamLiqStoredC, 107, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FlamLiqStoredC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames._16Separation, 108, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames._16Separation
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames._16SeparationC, 109, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames._16SeparationC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PropCylinders, 110, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PropCylinders
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PropCylindersC, 111, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PropCylindersC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PropStorage, 112, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PropStorage
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PropStorageC, 113, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PropStorageC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoSmoking, 114, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoSmoking
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoSmokingC, 115, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoSmokingC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireDoorsNotObstr, 116, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireDoorsNotObstr
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.FireDoorsNotObstrC, 117, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.FireDoorsNotObstrC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoMissCealTiles, 118, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoMissCealTiles
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoMissCealTilesC, 119, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoMissCealTilesC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.BarricadeProvided, 120, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.BarricadeProvided
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.BarricadeProvidedC, 121, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.BarricadeProvidedC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoStorageInElecRm, 122, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoStorageInElecRm
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.NoStorageInElecRmC, 123, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.NoStorageInElecRmC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PlasSkids, 124, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PlasSkids
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.PlasSkidsC, 125, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.PlasSkidsC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ElectExtCords, 126, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ElectExtCords
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ElectExtCordsC, 127, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ElectExtCordsC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ElectEquipFreeDam, 128, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ElectEquipFreeDam
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames.ElectEquipFreeDamC, 129, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames.ElectEquipFreeDamC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames._36Clearance, 130, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames._36Clearance
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(FireRetailMetadata.ColumnNames._36ClearanceC, 131, GetType(System.String), esSystemType.String)	
			c.PropertyName = FireRetailMetadata.PropertyNames._36ClearanceC
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As FireRetailMetadata
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
			 Public Const Summary As String = "Summary"
			 Public Const TypeStore As String = "TypeStore"
			 Public Const MilesToCoast As String = "MilesToCoast"
			 Public Const RespTime As String = "RespTime"
			 Public Const HydrantDistance As String = "HydrantDistance"
			 Public Const FootprintBldg As String = "FootprintBldg"
			 Public Const RackStorArea As String = "RackStorArea"
			 Public Const BackroomStorArea As String = "BackroomStorArea"
			 Public Const BackroomStorHgt As String = "BackroomStorHgt"
			 Public Const SalesFlStorArea As String = "SalesFlStorArea"
			 Public Const SalesFlStorHgt As String = "SalesFlStorHgt"
			 Public Const AverSlAreaProdHgt As String = "AverSlAreaProdHgt"
			 Public Const MaxSlAreaProdHgt As String = "MaxSlAreaProdHgt"
			 Public Const CeilASSP As String = "%CeilASSP"
			 Public Const CeilASSN As String = "%CeilASSN"
			 Public Const RackAASP As String = "%RackAASP"
			 Public Const RackAASN As String = "%RackAASN"
			 Public Const FireDetProv As String = "FireDetProv"
			 Public Const FireDetNeed As String = "FireDetNeed"
			 Public Const LevelsRAS As String = "LevelsRAS"
			 Public Const WaterFlowMonYesNo As String = "WaterFlowMonYesNo"
			 Public Const WaterFlowMonByWhom As String = "WaterFlowMonByWhom"
			 Public Const ValveTamMonYesNo As String = "ValveTamMonYesNo"
			 Public Const ValveTamMonByWhom As String = "ValveTamMonByWhom"
			 Public Const NoOfValves As String = "NoOfValves"
			 Public Const NoOfValvesC As String = "NoOfValvesC"
			 Public Const AllValvesOpen As String = "AllValvesOpen"
			 Public Const AllValvesOpenC As String = "AllValvesOpenC"
			 Public Const ValvesLocked As String = "ValvesLocked"
			 Public Const ValvesLockedC As String = "ValvesLockedC"
			 Public Const ValvesLabeled As String = "ValvesLabeled"
			 Public Const ValvesLabeledC As String = "ValvesLabeledC"
			 Public Const ValvesInspMonthly As String = "ValvesInspMonthly"
			 Public Const ValvesInspMonthlyC As String = "ValvesInspMonthlyC"
			 Public Const SSHeadBoxMonthly As String = "SSHeadBoxMonthly"
			 Public Const SSHeadBoxMonthlyC As String = "SSHeadBoxMonthlyC"
			 Public Const SSHeadsAvail As String = "SSHeadsAvail"
			 Public Const SSHeadsAvailC As String = "SSHeadsAvailC"
			 Public Const SSHeadWrenchInBox As String = "SSHeadWrenchInBox"
			 Public Const SSHeadWrenchInBoxC As String = "SSHeadWrenchInBoxC"
			 Public Const CorrectHeadsProvided As String = "CorrectHeadsProvided"
			 Public Const CorrectHeadsProvidedC As String = "CorrectHeadsProvidedC"
			 Public Const ImpProcObserved As String = "ImpProcObserved"
			 Public Const ImpProcObservedC As String = "ImpProcObservedC"
			 Public Const ATV2inDrain As String = "ATV2inDrain"
			 Public Const ATV2inDrainC As String = "ATV2inDrainC"
			 Public Const ATVDryPipeValve As String = "ATVDryPipeValve"
			 Public Const ATVDryPipeValveC As String = "ATVDryPipeValveC"
			 Public Const ATVFirePump As String = "ATVFirePump"
			 Public Const ATVFirePumpC As String = "ATVFirePumpC"
			 Public Const ATVAntifreeze As String = "ATVAntifreeze"
			 Public Const ATVAntifreezeC As String = "ATVAntifreezeC"
			 Public Const NoMissingCapsFDC As String = "NoMissingCapsFDC"
			 Public Const NoMissingCapsFDCC As String = "NoMissingCapsFDCC"
			 Public Const ATVValveTamper As String = "ATVValveTamper"
			 Public Const ATVValveTamperC As String = "ATVValveTamperC"
			 Public Const ATVWaterFlow As String = "ATVWaterFlow"
			 Public Const ATVWaterFlowC As String = "ATVWaterFlowC"
			 Public Const ATVDrySysLowAir As String = "ATVDrySysLowAir"
			 Public Const ATVDrySysLowAirC As String = "ATVDrySysLowAirC"
			 Public Const FireSupSysOver As String = "FireSupSysOver"
			 Public Const FireSupSysOverC As String = "FireSupSysOverC"
			 Public Const BlowOffCaps As String = "BlowOffCaps"
			 Public Const BlowOffCapsC As String = "BlowOffCapsC"
			 Public Const ManualRelease As String = "ManualRelease"
			 Public Const ManualReleaseC As String = "ManualReleaseC"
			 Public Const Min18Clearance As String = "Min18Clearance"
			 Public Const Min18ClearanceC As String = "Min18ClearanceC"
			 Public Const FireAlarmZonePosted As String = "FireAlarmZonePosted"
			 Public Const FireAlarmZonePostedC As String = "FireAlarmZonePostedC"
			 Public Const PFEInspMonthly As String = "PFEInspMonthly"
			 Public Const PFEInspMonthlyC As String = "PFEInspMonthlyC"
			 Public Const PFEServAnn As String = "PFEServAnn"
			 Public Const PFEServAnnC As String = "PFEServAnnC"
			 Public Const PFEAppTypeSize As String = "PFEAppTypeSize"
			 Public Const PFEAppTypeSizeC As String = "PFEAppTypeSizeC"
			 Public Const PFEMounted As String = "PFEMounted"
			 Public Const PFEMountedC As String = "PFEMountedC"
			 Public Const FireHosesInsp As String = "FireHosesInsp"
			 Public Const FireHosesInspC As String = "FireHosesInspC"
			 Public Const ExhaustHoodsDuct As String = "ExhaustHoodsDuct"
			 Public Const ExhaustHoodsDuctC As String = "ExhaustHoodsDuctC"
			 Public Const FiltersForCooking As String = "FiltersForCooking"
			 Public Const FiltersForCookingC As String = "FiltersForCookingC"
			 Public Const ELProvided As String = "ELProvided"
			 Public Const ELProvidedC As String = "ELProvidedC"
			 Public Const BatOpEmerExit As String = "BatOpEmerExit"
			 Public Const BatOpEmerExitC As String = "BatOpEmerExitC"
			 Public Const EmergGenOptMonthly As String = "EmergGenOptMonthly"
			 Public Const EmergGenOptMonthlyC As String = "EmergGenOptMonthlyC"
			 Public Const GenSecPreUnauth As String = "GenSecPreUnauth"
			 Public Const GenSecPreUnauthC As String = "GenSecPreUnauthC"
			 Public Const ExitSignsProvIll As String = "ExitSignsProvIll"
			 Public Const ExitSignsProvIllC As String = "ExitSignsProvIllC"
			 Public Const ExitDoorsUnobstr As String = "ExitDoorsUnobstr"
			 Public Const ExitDoorsUnobstrC As String = "ExitDoorsUnobstrC"
			 Public Const NatGasFryer As String = "NatGasFryer"
			 Public Const NatGasFryerC As String = "NatGasFryerC"
			 Public Const SeismicGasShutoff As String = "SeismicGasShutoff"
			 Public Const SeismicGasShutoffC As String = "SeismicGasShutoffC"
			 Public Const StorRacksBolted As String = "StorRacksBolted"
			 Public Const StorRacksBoltedC As String = "StorRacksBoltedC"
			 Public Const HotWorkPermit As String = "HotWorkPermit"
			 Public Const HotWorkPermitC As String = "HotWorkPermitC"
			 Public Const FlamLiqStored As String = "FlamLiqStored"
			 Public Const FlamLiqStoredC As String = "FlamLiqStoredC"
			 Public Const _16Separation As String = "16Separation"
			 Public Const _16SeparationC As String = "16SeparationC"
			 Public Const PropCylinders As String = "PropCylinders"
			 Public Const PropCylindersC As String = "PropCylindersC"
			 Public Const PropStorage As String = "PropStorage"
			 Public Const PropStorageC As String = "PropStorageC"
			 Public Const NoSmoking As String = "NoSmoking"
			 Public Const NoSmokingC As String = "NoSmokingC"
			 Public Const FireDoorsNotObstr As String = "FireDoorsNotObstr"
			 Public Const FireDoorsNotObstrC As String = "FireDoorsNotObstrC"
			 Public Const NoMissCealTiles As String = "NoMissCealTiles"
			 Public Const NoMissCealTilesC As String = "NoMissCealTilesC"
			 Public Const BarricadeProvided As String = "BarricadeProvided"
			 Public Const BarricadeProvidedC As String = "BarricadeProvidedC"
			 Public Const NoStorageInElecRm As String = "NoStorageInElecRm"
			 Public Const NoStorageInElecRmC As String = "NoStorageInElecRmC"
			 Public Const PlasSkids As String = "PlasSkids"
			 Public Const PlasSkidsC As String = "PlasSkidsC"
			 Public Const ElectExtCords As String = "ElectExtCords"
			 Public Const ElectExtCordsC As String = "ElectExtCordsC"
			 Public Const ElectEquipFreeDam As String = "ElectEquipFreeDam"
			 Public Const ElectEquipFreeDamC As String = "ElectEquipFreeDamC"
			 Public Const _36Clearance As String = "36Clearance"
			 Public Const _36ClearanceC As String = "36ClearanceC"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Summary As String = "Summary"
			 Public Const TypeStore As String = "TypeStore"
			 Public Const MilesToCoast As String = "MilesToCoast"
			 Public Const RespTime As String = "RespTime"
			 Public Const HydrantDistance As String = "HydrantDistance"
			 Public Const FootprintBldg As String = "FootprintBldg"
			 Public Const RackStorArea As String = "RackStorArea"
			 Public Const BackroomStorArea As String = "BackroomStorArea"
			 Public Const BackroomStorHgt As String = "BackroomStorHgt"
			 Public Const SalesFlStorArea As String = "SalesFlStorArea"
			 Public Const SalesFlStorHgt As String = "SalesFlStorHgt"
			 Public Const AverSlAreaProdHgt As String = "AverSlAreaProdHgt"
			 Public Const MaxSlAreaProdHgt As String = "MaxSlAreaProdHgt"
			 Public Const CeilASSP As String = "CeilASSP"
			 Public Const CeilASSN As String = "CeilASSN"
			 Public Const RackAASP As String = "RackAASP"
			 Public Const RackAASN As String = "RackAASN"
			 Public Const FireDetProv As String = "FireDetProv"
			 Public Const FireDetNeed As String = "FireDetNeed"
			 Public Const LevelsRAS As String = "LevelsRAS"
			 Public Const WaterFlowMonYesNo As String = "WaterFlowMonYesNo"
			 Public Const WaterFlowMonByWhom As String = "WaterFlowMonByWhom"
			 Public Const ValveTamMonYesNo As String = "ValveTamMonYesNo"
			 Public Const ValveTamMonByWhom As String = "ValveTamMonByWhom"
			 Public Const NoOfValves As String = "NoOfValves"
			 Public Const NoOfValvesC As String = "NoOfValvesC"
			 Public Const AllValvesOpen As String = "AllValvesOpen"
			 Public Const AllValvesOpenC As String = "AllValvesOpenC"
			 Public Const ValvesLocked As String = "ValvesLocked"
			 Public Const ValvesLockedC As String = "ValvesLockedC"
			 Public Const ValvesLabeled As String = "ValvesLabeled"
			 Public Const ValvesLabeledC As String = "ValvesLabeledC"
			 Public Const ValvesInspMonthly As String = "ValvesInspMonthly"
			 Public Const ValvesInspMonthlyC As String = "ValvesInspMonthlyC"
			 Public Const SSHeadBoxMonthly As String = "SSHeadBoxMonthly"
			 Public Const SSHeadBoxMonthlyC As String = "SSHeadBoxMonthlyC"
			 Public Const SSHeadsAvail As String = "SSHeadsAvail"
			 Public Const SSHeadsAvailC As String = "SSHeadsAvailC"
			 Public Const SSHeadWrenchInBox As String = "SSHeadWrenchInBox"
			 Public Const SSHeadWrenchInBoxC As String = "SSHeadWrenchInBoxC"
			 Public Const CorrectHeadsProvided As String = "CorrectHeadsProvided"
			 Public Const CorrectHeadsProvidedC As String = "CorrectHeadsProvidedC"
			 Public Const ImpProcObserved As String = "ImpProcObserved"
			 Public Const ImpProcObservedC As String = "ImpProcObservedC"
			 Public Const ATV2inDrain As String = "ATV2inDrain"
			 Public Const ATV2inDrainC As String = "ATV2inDrainC"
			 Public Const ATVDryPipeValve As String = "ATVDryPipeValve"
			 Public Const ATVDryPipeValveC As String = "ATVDryPipeValveC"
			 Public Const ATVFirePump As String = "ATVFirePump"
			 Public Const ATVFirePumpC As String = "ATVFirePumpC"
			 Public Const ATVAntifreeze As String = "ATVAntifreeze"
			 Public Const ATVAntifreezeC As String = "ATVAntifreezeC"
			 Public Const NoMissingCapsFDC As String = "NoMissingCapsFDC"
			 Public Const NoMissingCapsFDCC As String = "NoMissingCapsFDCC"
			 Public Const ATVValveTamper As String = "ATVValveTamper"
			 Public Const ATVValveTamperC As String = "ATVValveTamperC"
			 Public Const ATVWaterFlow As String = "ATVWaterFlow"
			 Public Const ATVWaterFlowC As String = "ATVWaterFlowC"
			 Public Const ATVDrySysLowAir As String = "ATVDrySysLowAir"
			 Public Const ATVDrySysLowAirC As String = "ATVDrySysLowAirC"
			 Public Const FireSupSysOver As String = "FireSupSysOver"
			 Public Const FireSupSysOverC As String = "FireSupSysOverC"
			 Public Const BlowOffCaps As String = "BlowOffCaps"
			 Public Const BlowOffCapsC As String = "BlowOffCapsC"
			 Public Const ManualRelease As String = "ManualRelease"
			 Public Const ManualReleaseC As String = "ManualReleaseC"
			 Public Const Min18Clearance As String = "Min18Clearance"
			 Public Const Min18ClearanceC As String = "Min18ClearanceC"
			 Public Const FireAlarmZonePosted As String = "FireAlarmZonePosted"
			 Public Const FireAlarmZonePostedC As String = "FireAlarmZonePostedC"
			 Public Const PFEInspMonthly As String = "PFEInspMonthly"
			 Public Const PFEInspMonthlyC As String = "PFEInspMonthlyC"
			 Public Const PFEServAnn As String = "PFEServAnn"
			 Public Const PFEServAnnC As String = "PFEServAnnC"
			 Public Const PFEAppTypeSize As String = "PFEAppTypeSize"
			 Public Const PFEAppTypeSizeC As String = "PFEAppTypeSizeC"
			 Public Const PFEMounted As String = "PFEMounted"
			 Public Const PFEMountedC As String = "PFEMountedC"
			 Public Const FireHosesInsp As String = "FireHosesInsp"
			 Public Const FireHosesInspC As String = "FireHosesInspC"
			 Public Const ExhaustHoodsDuct As String = "ExhaustHoodsDuct"
			 Public Const ExhaustHoodsDuctC As String = "ExhaustHoodsDuctC"
			 Public Const FiltersForCooking As String = "FiltersForCooking"
			 Public Const FiltersForCookingC As String = "FiltersForCookingC"
			 Public Const ELProvided As String = "ELProvided"
			 Public Const ELProvidedC As String = "ELProvidedC"
			 Public Const BatOpEmerExit As String = "BatOpEmerExit"
			 Public Const BatOpEmerExitC As String = "BatOpEmerExitC"
			 Public Const EmergGenOptMonthly As String = "EmergGenOptMonthly"
			 Public Const EmergGenOptMonthlyC As String = "EmergGenOptMonthlyC"
			 Public Const GenSecPreUnauth As String = "GenSecPreUnauth"
			 Public Const GenSecPreUnauthC As String = "GenSecPreUnauthC"
			 Public Const ExitSignsProvIll As String = "ExitSignsProvIll"
			 Public Const ExitSignsProvIllC As String = "ExitSignsProvIllC"
			 Public Const ExitDoorsUnobstr As String = "ExitDoorsUnobstr"
			 Public Const ExitDoorsUnobstrC As String = "ExitDoorsUnobstrC"
			 Public Const NatGasFryer As String = "NatGasFryer"
			 Public Const NatGasFryerC As String = "NatGasFryerC"
			 Public Const SeismicGasShutoff As String = "SeismicGasShutoff"
			 Public Const SeismicGasShutoffC As String = "SeismicGasShutoffC"
			 Public Const StorRacksBolted As String = "StorRacksBolted"
			 Public Const StorRacksBoltedC As String = "StorRacksBoltedC"
			 Public Const HotWorkPermit As String = "HotWorkPermit"
			 Public Const HotWorkPermitC As String = "HotWorkPermitC"
			 Public Const FlamLiqStored As String = "FlamLiqStored"
			 Public Const FlamLiqStoredC As String = "FlamLiqStoredC"
			 Public Const _16Separation As String = "_16Separation"
			 Public Const _16SeparationC As String = "_16SeparationC"
			 Public Const PropCylinders As String = "PropCylinders"
			 Public Const PropCylindersC As String = "PropCylindersC"
			 Public Const PropStorage As String = "PropStorage"
			 Public Const PropStorageC As String = "PropStorageC"
			 Public Const NoSmoking As String = "NoSmoking"
			 Public Const NoSmokingC As String = "NoSmokingC"
			 Public Const FireDoorsNotObstr As String = "FireDoorsNotObstr"
			 Public Const FireDoorsNotObstrC As String = "FireDoorsNotObstrC"
			 Public Const NoMissCealTiles As String = "NoMissCealTiles"
			 Public Const NoMissCealTilesC As String = "NoMissCealTilesC"
			 Public Const BarricadeProvided As String = "BarricadeProvided"
			 Public Const BarricadeProvidedC As String = "BarricadeProvidedC"
			 Public Const NoStorageInElecRm As String = "NoStorageInElecRm"
			 Public Const NoStorageInElecRmC As String = "NoStorageInElecRmC"
			 Public Const PlasSkids As String = "PlasSkids"
			 Public Const PlasSkidsC As String = "PlasSkidsC"
			 Public Const ElectExtCords As String = "ElectExtCords"
			 Public Const ElectExtCordsC As String = "ElectExtCordsC"
			 Public Const ElectEquipFreeDam As String = "ElectEquipFreeDam"
			 Public Const ElectEquipFreeDamC As String = "ElectEquipFreeDamC"
			 Public Const _36Clearance As String = "_36Clearance"
			 Public Const _36ClearanceC As String = "_36ClearanceC"
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
			SyncLock GetType(FireRetailMetadata)
			
				If FireRetailMetadata.mapDelegates Is Nothing Then
					FireRetailMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If FireRetailMetadata._meta Is Nothing Then
					FireRetailMetadata._meta = New FireRetailMetadata()
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
				meta.AddTypeMap("SurveyDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Summary", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TypeStore", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MilesToCoast", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("RespTime", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("HydrantDistance", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FootprintBldg", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RackStorArea", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BackroomStorArea", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BackroomStorHgt", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SalesFlStorArea", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SalesFlStorHgt", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("AverSlAreaProdHgt", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MaxSlAreaProdHgt", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CeilASSP", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("CeilASSN", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("RackAASP", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("RackAASN", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("FireDetProv", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("FireDetNeed", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("LevelsRAS", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("WaterFlowMonYesNo", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("WaterFlowMonByWhom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ValveTamMonYesNo", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ValveTamMonByWhom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NoOfValves", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("NoOfValvesC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AllValvesOpen", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("AllValvesOpenC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ValvesLocked", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ValvesLockedC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ValvesLabeled", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ValvesLabeledC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ValvesInspMonthly", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ValvesInspMonthlyC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SSHeadBoxMonthly", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("SSHeadBoxMonthlyC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SSHeadsAvail", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("SSHeadsAvailC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SSHeadWrenchInBox", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("SSHeadWrenchInBoxC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CorrectHeadsProvided", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("CorrectHeadsProvidedC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpProcObserved", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ImpProcObservedC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ATV2inDrain", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ATV2inDrainC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ATVDryPipeValve", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ATVDryPipeValveC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ATVFirePump", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ATVFirePumpC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ATVAntifreeze", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ATVAntifreezeC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NoMissingCapsFDC", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("NoMissingCapsFDCC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ATVValveTamper", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ATVValveTamperC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ATVWaterFlow", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ATVWaterFlowC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ATVDrySysLowAir", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ATVDrySysLowAirC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireSupSysOver", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("FireSupSysOverC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BlowOffCaps", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("BlowOffCapsC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ManualRelease", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ManualReleaseC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Min18Clearance", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("Min18ClearanceC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireAlarmZonePosted", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("FireAlarmZonePostedC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PFEInspMonthly", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("PFEInspMonthlyC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PFEServAnn", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("PFEServAnnC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PFEAppTypeSize", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("PFEAppTypeSizeC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PFEMounted", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("PFEMountedC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireHosesInsp", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("FireHosesInspC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExhaustHoodsDuct", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ExhaustHoodsDuctC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FiltersForCooking", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("FiltersForCookingC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ELProvided", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ELProvidedC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BatOpEmerExit", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("BatOpEmerExitC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmergGenOptMonthly", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("EmergGenOptMonthlyC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("GenSecPreUnauth", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("GenSecPreUnauthC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExitSignsProvIll", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ExitSignsProvIllC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExitDoorsUnobstr", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ExitDoorsUnobstrC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NatGasFryer", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("NatGasFryerC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SeismicGasShutoff", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("SeismicGasShutoffC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StorRacksBolted", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("StorRacksBoltedC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HotWorkPermit", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("HotWorkPermitC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FlamLiqStored", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("FlamLiqStoredC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_16Separation", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("_16SeparationC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PropCylinders", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("PropCylindersC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PropStorage", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("PropStorageC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NoSmoking", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("NoSmokingC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireDoorsNotObstr", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("FireDoorsNotObstrC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NoMissCealTiles", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("NoMissCealTilesC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BarricadeProvided", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("BarricadeProvidedC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NoStorageInElecRm", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("NoStorageInElecRmC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PlasSkids", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("PlasSkidsC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ElectExtCords", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ElectExtCordsC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ElectEquipFreeDam", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("ElectEquipFreeDamC", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_36Clearance", new esTypeMap("char", "System.String"))
				meta.AddTypeMap("_36ClearanceC", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "Fire-Retail"
				meta.Destination = "Fire-Retail"
				
				meta.spInsert = "proc_Fire-RetailInsert"
				meta.spUpdate = "proc_Fire-RetailUpdate"
				meta.spDelete = "proc_Fire-RetailDelete"
				meta.spLoadAll = "proc_Fire-RetailLoadAll"
				meta.spLoadByPrimaryKey = "proc_Fire-RetailLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As FireRetailMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
