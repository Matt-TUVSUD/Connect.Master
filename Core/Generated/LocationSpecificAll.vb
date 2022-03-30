
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2013 10:42:11 AM
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
	' Encapsulates the 'LocationSpecific-All' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(LocationSpecificAll))> _
	<XmlType("LocationSpecificAll")> _	
	Partial Public Class LocationSpecificAll 
		Inherits esLocationSpecificAll
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New LocationSpecificAll()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New LocationSpecificAll()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New LocationSpecificAll()
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
	<XmlType("LocationSpecificAllCollection")> _
	Partial Public Class LocationSpecificAllCollection
		Inherits esLocationSpecificAllCollection
		Implements IEnumerable(Of LocationSpecificAll)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As LocationSpecificAll
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(LocationSpecificAll))> _
		Public Class LocationSpecificAllCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of LocationSpecificAllCollection)
			
			Public Shared Widening Operator CType(packet As LocationSpecificAllCollectionWCFPacket) As LocationSpecificAllCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As LocationSpecificAllCollection) As LocationSpecificAllCollectionWCFPacket
				Return New LocationSpecificAllCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class LocationSpecificAllQuery 
		Inherits esLocationSpecificAllQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "LocationSpecificAllQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As LocationSpecificAllQuery) As String
			Return LocationSpecificAllQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As LocationSpecificAllQuery
			Return DirectCast(LocationSpecificAllQuery.SerializeHelper.FromXml(query, GetType(LocationSpecificAllQuery)), LocationSpecificAllQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esLocationSpecificAll
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
		
			Dim query As New LocationSpecificAllQuery()
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
		' Maps to LocationSpecific-All.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Field1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Field1 As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.Field1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.Field1, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Field1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.MasterDivision
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MasterDivision As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.MasterDivision)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.MasterDivision, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.MasterDivision)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Ownership
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ownership As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.Ownership)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.Ownership, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Ownership)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.IRINo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRINo As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.IRINo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.IRINo, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRINo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.AccountablePerson
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AccountablePerson As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.AccountablePerson)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.AccountablePerson, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.AccountablePerson)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.PlantID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantID As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.PlantID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.PlantID, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PlantID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.PlantName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantName As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.PlantName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.PlantName, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PlantName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.GRCEngineerFire
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCEngineerFire As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.GRCEngineerFire)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.GRCEngineerFire, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.GRCEngineerFire)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.GRCEngineerBM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCEngineerBM As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.GRCEngineerBM)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.GRCEngineerBM, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.GRCEngineerBM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.GRCTitle
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCTitle As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.GRCTitle)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.GRCTitle, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.GRCTitle)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ClientLocation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocation As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.ClientLocation)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.ClientLocation, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ClientLocation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.LOCATIONNAME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Locationname As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.Locationname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.Locationname, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Locationname)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Status
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.Status, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Status)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BusinessUnit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessUnit As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BusinessUnit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BusinessUnit, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BusinessUnit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Entity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property [Entity1] As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.[Entity1])
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.[Entity1], value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.[Entity1])
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.OCCUPANCY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occupancy As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.Occupancy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.Occupancy, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Occupancy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ZONE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zone As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Zone)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Zone, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Zone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.STRUCTURE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property [STRUCTURE] As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.[STRUCTURE])
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.[STRUCTURE], value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.[STRUCTURE])
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.EQUIPMENT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Equipment As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Equipment)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Equipment, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Equipment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.INVENTORY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Inventory As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Inventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Inventory, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Inventory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Pd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Pd, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Pd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bi As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bi, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.TIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tiv As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Tiv)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Tiv, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Tiv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireFreq
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireFreq As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.FireFreq)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.FireFreq, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireFreq)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Fire2000
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2000 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2000)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2000, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2000)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Fire2001
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2001 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2001)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2001, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2001)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Fire2002
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2002 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2002)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2002, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2002)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Fire2003
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2003 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2003)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2003, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2003)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Fire2004
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2004 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2004)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2004, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2004)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Fire2005
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fire2005 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2005)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Fire2005, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2005)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireTargetMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireTargetMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.FireTargetMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.FireTargetMonth, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireTargetMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.FireLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.FireLastInspectionReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.FireLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.FireLastInspectionDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireScheduledDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireScheduledDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.FireScheduledDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.FireScheduledDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireScheduledDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.FireActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.FireActualDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToFireReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToFireReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToFireReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToFireReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToFireReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireReport2 As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToFireReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToFireReport2, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToFireReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToFireDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToFireDiagram As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToFireDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToFireDiagram, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToFireDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToBPVReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToBPVReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToBPVReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToBPVReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToBPVReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.FireEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.FireEmailedDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireInspectionCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireInspectionCount As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.FireInspectionCount)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.FireInspectionCount, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireInspectionCount)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.SpecialReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecialReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.SpecialReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.SpecialReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.SpecialReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.PlanReview
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlanReview As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.PlanReview)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.PlanReview, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PlanReview)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireRecResponseRecevied
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireRecResponseRecevied As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.FireRecResponseRecevied)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.FireRecResponseRecevied, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireRecResponseRecevied)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireAQEDateRecevied
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireAQEDateRecevied As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.FireAQEDateRecevied)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.FireAQEDateRecevied, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireAQEDateRecevied)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireAQERating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireAQERating As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.FireAQERating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.FireAQERating, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireAQERating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMFreq
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMFreq As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BMFreq)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BMFreq, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMFreq)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM2000
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2000 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2000)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2000, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2000)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM2001
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2001 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2001)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2001, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2001)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM2002
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2002 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2002)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2002, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2002)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM2003
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2003 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2003)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2003, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2003)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM2004
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2004 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2004)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2004, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2004)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM2005
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm2005 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2005)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.Bm2005, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2005)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMTarget
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMTarget As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.BMTarget)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.BMTarget, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMTarget)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.EngineerRequired
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngineerRequired As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.EngineerRequired)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.EngineerRequired, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.EngineerRequired)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BMLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BMLastInspectionReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.BMLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.BMLastInspectionDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToBMDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToBMDiagram As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToBMDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToBMDiagram, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToBMDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMScheduledDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMScheduledDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.BMScheduledDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.BMScheduledDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMScheduledDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.BMActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.BMActualDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.BMEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.BMEmailedDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToBMReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToBMReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToBMReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToBMReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToBMReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToBMReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToBMReport2 As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToBMReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToBMReport2, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToBMReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMRecResponseReceived
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMRecResponseReceived As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BMRecResponseReceived)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BMRecResponseReceived, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMRecResponseReceived)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMAQEDateRecevied
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMAQEDateRecevied As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BMAQEDateRecevied)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BMAQEDateRecevied, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMAQEDateRecevied)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMAQERating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMAQERating As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BMAQERating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BMAQERating, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMAQERating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMInspectionCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMInspectionCount As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BMInspectionCount)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BMInspectionCount, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMInspectionCount)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.LocationManager
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationManager As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.LocationManager)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.LocationManager, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.LocationManager)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.LocationPhone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationPhone As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.LocationPhone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.LocationPhone, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.LocationPhone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.LocationFax
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationFax As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.LocationFax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.LocationFax, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.LocationFax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.LocationEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationEmail As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.LocationEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.LocationEmail, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.LocationEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ARISELastInspection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARISELastInspection As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ARISELastInspection)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ARISELastInspection, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ARISELastInspection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ARISEInspectionLetter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARISEInspectionLetter As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ARISEInspectionLetter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ARISEInspectionLetter, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ARISEInspectionLetter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ARISELocationManager
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARISELocationManager As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ARISELocationManager)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ARISELocationManager, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ARISELocationManager)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireComments As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.FireComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.FireComments, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMComments As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BMComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BMComments, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BPVComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BPVComments As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.BPVComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.BPVComments, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BPVComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.APL-PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplPd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.AplPd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.AplPd, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.AplPd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.APL-BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AplBi As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.AplBi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.AplBi, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.AplBi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.APL-Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.APLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.APLTotal, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.APLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.PML-PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlPd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.PmlPd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.PmlPd, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PmlPd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.PML-BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PmlBi As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.PmlBi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.PmlBi, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PmlBi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.PML-Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PMLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.PMLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.PMLTotal, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PMLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.MFL-PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflPd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.MflPd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.MflPd, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.MflPd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.MFL-BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MflBi As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.MflBi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.MflBi, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.MflBi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.MFL-Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MFLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.MFLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.MFLTotal, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.MFLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_APL-PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm_AplPd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_AplPd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_AplPd, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_AplPd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_APL-BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm_AplBi As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_AplBi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_AplBi, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_AplBi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_APL-Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BM_APLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.BM_APLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.BM_APLTotal, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BM_APLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_PML-PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm_PmlPd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_PmlPd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_PmlPd, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_PmlPd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_PML-BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm_PmlBi As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_PmlBi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_PmlBi, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_PmlBi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_PML-Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BM_PMLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.BM_PMLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.BM_PMLTotal, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BM_PMLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_MFL-PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm_MflPd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_MflPd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_MflPd, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_MflPd)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_MFL-BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bm_MflBi As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_MflBi)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.Bm_MflBi, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_MflBi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BM_MFL-Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BM_MFLTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.BM_MFLTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(LocationSpecificAllMetadata.ColumnNames.BM_MFLTotal, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BM_MFLTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.FireUpdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireUpdate As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LocationSpecificAllMetadata.ColumnNames.FireUpdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(LocationSpecificAllMetadata.ColumnNames.FireUpdate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireUpdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BMUpdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMUpdate As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LocationSpecificAllMetadata.ColumnNames.BMUpdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(LocationSpecificAllMetadata.ColumnNames.BMUpdate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMUpdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.IRUpdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRUpdate As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LocationSpecificAllMetadata.ColumnNames.IRUpdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(LocationSpecificAllMetadata.ColumnNames.IRUpdate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRUpdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.SquareFootage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SquareFootage As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.SquareFootage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.SquareFootage, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.SquareFootage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.BusinessContinuationPlan
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessContinuationPlan As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LocationSpecificAllMetadata.ColumnNames.BusinessContinuationPlan)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(LocationSpecificAllMetadata.ColumnNames.BusinessContinuationPlan, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BusinessContinuationPlan)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.IRTargetMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRTargetMonth As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LocationSpecificAllMetadata.ColumnNames.IRTargetMonth)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(LocationSpecificAllMetadata.ColumnNames.IRTargetMonth, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRTargetMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.IRLastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.IRLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.IRLastInspectionReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.IRLastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.IRLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.IRLastInspectionDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.IRScheduledDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRScheduledDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.IRScheduledDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.IRScheduledDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRScheduledDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.IRActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.IRActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.IRActualDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToIRReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToIRReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToIRReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToIRReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToIRReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.IREmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IREmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.IREmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.IREmailedDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IREmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Wind-LastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.NatHazWindLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.NatHazWindLastInspectionReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazWindLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Wind-LastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazWindLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazWindLastInspectionDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazWindLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Wind-ActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazWindActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazWindActualDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazWindActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Wind-Report
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazWindReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazWindReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Wind-Report2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazWindReport2 As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindReport2, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazWindReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Wind-Diagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazWindDiagram As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindDiagram, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazWindDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Wind-EmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazWindEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazWindEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazWindEmailedDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazWindEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Seismic-LastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicLastInspectionReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazSeismicLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Seismic-LastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicLastInspectionDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazSeismicLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Seismic-ActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicActualDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazSeismicActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Seismic-Report
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazSeismicReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazSeismicReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Seismic-Report2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazSeismicReport2 As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicReport2, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazSeismicReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Seismic-Diagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazSeismicDiagram As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicDiagram, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazSeismicDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Seismic-EmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazSeismicEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicEmailedDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazSeismicEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Flood-LastInspectionReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodLastInspectionReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.NatHazFloodLastInspectionReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.NatHazFloodLastInspectionReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazFloodLastInspectionReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Flood-LastInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodLastInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazFloodLastInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazFloodLastInspectionDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazFloodLastInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Flood-ActualDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodActualDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazFloodActualDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazFloodActualDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazFloodActualDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Flood-Report
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazFloodReport As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodReport, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazFloodReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Flood-Report2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazFloodReport2 As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodReport2, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazFloodReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.ToNatHaz-Flood-Diagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ToNatHazFloodDiagram As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodDiagram, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ToNatHazFloodDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.NatHaz-Flood-EmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazFloodEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazFloodEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(LocationSpecificAllMetadata.ColumnNames.NatHazFloodEmailedDate, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazFloodEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to LocationSpecific-All.AdminMemo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminMemo As System.String
			Get
				Return MyBase.GetSystemString(LocationSpecificAllMetadata.ColumnNames.AdminMemo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(LocationSpecificAllMetadata.ColumnNames.AdminMemo, value) Then
					OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.AdminMemo)
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
												
						Case "Id"
							Me.str().Id = CType(value, string)
												
						Case "Field1"
							Me.str().Field1 = CType(value, string)
												
						Case "MasterDivision"
							Me.str().MasterDivision = CType(value, string)
												
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
												
						Case "[Entity1]"
							Me.str().[Entity1] = CType(value, string)
												
						Case "Occupancy"
							Me.str().Occupancy = CType(value, string)
												
						Case "Zone"
							Me.str().Zone = CType(value, string)
												
						Case "[STRUCTURE]"
							Me.str().[STRUCTURE] = CType(value, string)
												
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
												
						Case "ToBMReport2"
							Me.str().ToBMReport2 = CType(value, string)
												
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
												
						Case "AplPd"
							Me.str().AplPd = CType(value, string)
												
						Case "AplBi"
							Me.str().AplBi = CType(value, string)
												
						Case "APLTotal"
							Me.str().APLTotal = CType(value, string)
												
						Case "PmlPd"
							Me.str().PmlPd = CType(value, string)
												
						Case "PmlBi"
							Me.str().PmlBi = CType(value, string)
												
						Case "PMLTotal"
							Me.str().PMLTotal = CType(value, string)
												
						Case "MflPd"
							Me.str().MflPd = CType(value, string)
												
						Case "MflBi"
							Me.str().MflBi = CType(value, string)
												
						Case "MFLTotal"
							Me.str().MFLTotal = CType(value, string)
												
						Case "Bm_AplPd"
							Me.str().Bm_AplPd = CType(value, string)
												
						Case "Bm_AplBi"
							Me.str().Bm_AplBi = CType(value, string)
												
						Case "BM_APLTotal"
							Me.str().BM_APLTotal = CType(value, string)
												
						Case "Bm_PmlPd"
							Me.str().Bm_PmlPd = CType(value, string)
												
						Case "Bm_PmlBi"
							Me.str().Bm_PmlBi = CType(value, string)
												
						Case "BM_PMLTotal"
							Me.str().BM_PMLTotal = CType(value, string)
												
						Case "Bm_MflPd"
							Me.str().Bm_MflPd = CType(value, string)
												
						Case "Bm_MflBi"
							Me.str().Bm_MflBi = CType(value, string)
												
						Case "BM_MFLTotal"
							Me.str().BM_MFLTotal = CType(value, string)
												
						Case "FireUpdate"
							Me.str().FireUpdate = CType(value, string)
												
						Case "BMUpdate"
							Me.str().BMUpdate = CType(value, string)
												
						Case "IRUpdate"
							Me.str().IRUpdate = CType(value, string)
												
						Case "SquareFootage"
							Me.str().SquareFootage = CType(value, string)
												
						Case "BusinessContinuationPlan"
							Me.str().BusinessContinuationPlan = CType(value, string)
												
						Case "IRTargetMonth"
							Me.str().IRTargetMonth = CType(value, string)
												
						Case "IRLastInspectionReport"
							Me.str().IRLastInspectionReport = CType(value, string)
												
						Case "IRLastInspectionDate"
							Me.str().IRLastInspectionDate = CType(value, string)
												
						Case "IRScheduledDate"
							Me.str().IRScheduledDate = CType(value, string)
												
						Case "IRActualDate"
							Me.str().IRActualDate = CType(value, string)
												
						Case "ToIRReport"
							Me.str().ToIRReport = CType(value, string)
												
						Case "IREmailedDate"
							Me.str().IREmailedDate = CType(value, string)
												
						Case "NatHazWindLastInspectionReport"
							Me.str().NatHazWindLastInspectionReport = CType(value, string)
												
						Case "NatHazWindLastInspectionDate"
							Me.str().NatHazWindLastInspectionDate = CType(value, string)
												
						Case "NatHazWindActualDate"
							Me.str().NatHazWindActualDate = CType(value, string)
												
						Case "ToNatHazWindReport"
							Me.str().ToNatHazWindReport = CType(value, string)
												
						Case "ToNatHazWindReport2"
							Me.str().ToNatHazWindReport2 = CType(value, string)
												
						Case "ToNatHazWindDiagram"
							Me.str().ToNatHazWindDiagram = CType(value, string)
												
						Case "NatHazWindEmailedDate"
							Me.str().NatHazWindEmailedDate = CType(value, string)
												
						Case "NatHazSeismicLastInspectionReport"
							Me.str().NatHazSeismicLastInspectionReport = CType(value, string)
												
						Case "NatHazSeismicLastInspectionDate"
							Me.str().NatHazSeismicLastInspectionDate = CType(value, string)
												
						Case "NatHazSeismicActualDate"
							Me.str().NatHazSeismicActualDate = CType(value, string)
												
						Case "ToNatHazSeismicReport"
							Me.str().ToNatHazSeismicReport = CType(value, string)
												
						Case "ToNatHazSeismicReport2"
							Me.str().ToNatHazSeismicReport2 = CType(value, string)
												
						Case "ToNatHazSeismicDiagram"
							Me.str().ToNatHazSeismicDiagram = CType(value, string)
												
						Case "NatHazSeismicEmailedDate"
							Me.str().NatHazSeismicEmailedDate = CType(value, string)
												
						Case "NatHazFloodLastInspectionReport"
							Me.str().NatHazFloodLastInspectionReport = CType(value, string)
												
						Case "NatHazFloodLastInspectionDate"
							Me.str().NatHazFloodLastInspectionDate = CType(value, string)
												
						Case "NatHazFloodActualDate"
							Me.str().NatHazFloodActualDate = CType(value, string)
												
						Case "ToNatHazFloodReport"
							Me.str().ToNatHazFloodReport = CType(value, string)
												
						Case "ToNatHazFloodReport2"
							Me.str().ToNatHazFloodReport2 = CType(value, string)
												
						Case "ToNatHazFloodDiagram"
							Me.str().ToNatHazFloodDiagram = CType(value, string)
												
						Case "NatHazFloodEmailedDate"
							Me.str().NatHazFloodEmailedDate = CType(value, string)
												
						Case "AdminMemo"
							Me.str().AdminMemo = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Id)
							End If
						
						Case "ClientLocation"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ClientLocation = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ClientLocation)
							End If
						
						Case "Zone"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Zone = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Zone)
							End If
						
						Case "[STRUCTURE]"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.[STRUCTURE] = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.[STRUCTURE])
							End If
						
						Case "Equipment"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Equipment = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Equipment)
							End If
						
						Case "Inventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Inventory = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Inventory)
							End If
						
						Case "Pd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Pd = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Pd)
							End If
						
						Case "Bi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bi = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bi)
							End If
						
						Case "Tiv"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Tiv = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Tiv)
							End If
						
						Case "Fire2000"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2000 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2000)
							End If
						
						Case "Fire2001"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2001 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2001)
							End If
						
						Case "Fire2002"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2002 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2002)
							End If
						
						Case "Fire2003"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2003 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2003)
							End If
						
						Case "Fire2004"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2004 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2004)
							End If
						
						Case "Fire2005"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire2005 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Fire2005)
							End If
						
						Case "FireTargetMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FireTargetMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireTargetMonth)
							End If
						
						Case "FireLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireLastInspectionDate)
							End If
						
						Case "FireScheduledDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireScheduledDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireScheduledDate)
							End If
						
						Case "FireActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireActualDate)
							End If
						
						Case "FireEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FireEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireEmailedDate)
							End If
						
						Case "Bm2000"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2000 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2000)
							End If
						
						Case "Bm2001"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2001 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2001)
							End If
						
						Case "Bm2002"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2002 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2002)
							End If
						
						Case "Bm2003"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2003 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2003)
							End If
						
						Case "Bm2004"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2004 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2004)
							End If
						
						Case "Bm2005"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bm2005 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm2005)
							End If
						
						Case "BMTarget"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BMTarget = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMTarget)
							End If
						
						Case "BMLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BMLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMLastInspectionDate)
							End If
						
						Case "BMScheduledDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BMScheduledDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMScheduledDate)
							End If
						
						Case "BMActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BMActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMActualDate)
							End If
						
						Case "BMEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BMEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMEmailedDate)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "AplPd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.AplPd = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.AplPd)
							End If
						
						Case "AplBi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.AplBi = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.AplBi)
							End If
						
						Case "APLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.APLTotal)
							End If
						
						Case "PmlPd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PmlPd = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PmlPd)
							End If
						
						Case "PmlBi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PmlBi = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PmlBi)
							End If
						
						Case "PMLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PMLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.PMLTotal)
							End If
						
						Case "MflPd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MflPd = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.MflPd)
							End If
						
						Case "MflBi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MflBi = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.MflBi)
							End If
						
						Case "MFLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MFLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.MFLTotal)
							End If
						
						Case "Bm_AplPd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bm_AplPd = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_AplPd)
							End If
						
						Case "Bm_AplBi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bm_AplBi = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_AplBi)
							End If
						
						Case "BM_APLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BM_APLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BM_APLTotal)
							End If
						
						Case "Bm_PmlPd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bm_PmlPd = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_PmlPd)
							End If
						
						Case "Bm_PmlBi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bm_PmlBi = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_PmlBi)
							End If
						
						Case "BM_PMLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BM_PMLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BM_PMLTotal)
							End If
						
						Case "Bm_MflPd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bm_MflPd = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_MflPd)
							End If
						
						Case "Bm_MflBi"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bm_MflBi = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.Bm_MflBi)
							End If
						
						Case "BM_MFLTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BM_MFLTotal = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BM_MFLTotal)
							End If
						
						Case "FireUpdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FireUpdate = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.FireUpdate)
							End If
						
						Case "BMUpdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.BMUpdate = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BMUpdate)
							End If
						
						Case "IRUpdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IRUpdate = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRUpdate)
							End If
						
						Case "SquareFootage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SquareFootage = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.SquareFootage)
							End If
						
						Case "BusinessContinuationPlan"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.BusinessContinuationPlan = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.BusinessContinuationPlan)
							End If
						
						Case "IRTargetMonth"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IRTargetMonth = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRTargetMonth)
							End If
						
						Case "IRLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.IRLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRLastInspectionDate)
							End If
						
						Case "IRScheduledDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.IRScheduledDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRScheduledDate)
							End If
						
						Case "IRActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.IRActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IRActualDate)
							End If
						
						Case "IREmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.IREmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.IREmailedDate)
							End If
						
						Case "NatHazWindLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazWindLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazWindLastInspectionDate)
							End If
						
						Case "NatHazWindActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazWindActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazWindActualDate)
							End If
						
						Case "NatHazWindEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazWindEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazWindEmailedDate)
							End If
						
						Case "NatHazSeismicLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazSeismicLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazSeismicLastInspectionDate)
							End If
						
						Case "NatHazSeismicActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazSeismicActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazSeismicActualDate)
							End If
						
						Case "NatHazSeismicEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazSeismicEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazSeismicEmailedDate)
							End If
						
						Case "NatHazFloodLastInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazFloodLastInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazFloodLastInspectionDate)
							End If
						
						Case "NatHazFloodActualDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazFloodActualDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazFloodActualDate)
							End If
						
						Case "NatHazFloodEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NatHazFloodEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(LocationSpecificAllMetadata.PropertyNames.NatHazFloodEmailedDate)
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
		
			Public Sub New(ByVal entity As esLocationSpecificAll)
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
		  	
			Public Property MasterDivision As System.String 
				Get
					Dim data_ As System.String = entity.MasterDivision
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MasterDivision = Nothing
					Else
						entity.MasterDivision = Convert.ToString(Value)
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
		  	
			Public Property [Entity1] As System.String 
				Get
					Dim data_ As System.String = entity.[Entity1]
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.[Entity1] = Nothing
					Else
						entity.[Entity1] = Convert.ToString(Value)
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
		  	
			Public Property [STRUCTURE] As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.[STRUCTURE]
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.[STRUCTURE] = Nothing
					Else
						entity.[STRUCTURE] = Convert.ToDecimal(Value)
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
		  	
			Public Property ToBMReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToBMReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToBMReport2 = Nothing
					Else
						entity.ToBMReport2 = Convert.ToString(Value)
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
		  	
			Public Property AplPd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.AplPd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplPd = Nothing
					Else
						entity.AplPd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property AplBi As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.AplBi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AplBi = Nothing
					Else
						entity.AplBi = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLTotal
					
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
						entity.APLTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlPd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PmlPd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlPd = Nothing
					Else
						entity.PmlPd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PmlBi As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PmlBi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PmlBi = Nothing
					Else
						entity.PmlBi = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PMLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PMLTotal
					
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
						entity.PMLTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflPd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MflPd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflPd = Nothing
					Else
						entity.MflPd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property MflBi As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MflBi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MflBi = Nothing
					Else
						entity.MflBi = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property MFLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MFLTotal
					
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
						entity.MFLTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm_AplPd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Bm_AplPd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm_AplPd = Nothing
					Else
						entity.Bm_AplPd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm_AplBi As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Bm_AplBi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm_AplBi = Nothing
					Else
						entity.Bm_AplBi = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BM_APLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BM_APLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BM_APLTotal = Nothing
					Else
						entity.BM_APLTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm_PmlPd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Bm_PmlPd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm_PmlPd = Nothing
					Else
						entity.Bm_PmlPd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm_PmlBi As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Bm_PmlBi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm_PmlBi = Nothing
					Else
						entity.Bm_PmlBi = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BM_PMLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BM_PMLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BM_PMLTotal = Nothing
					Else
						entity.BM_PMLTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm_MflPd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Bm_MflPd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm_MflPd = Nothing
					Else
						entity.Bm_MflPd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bm_MflBi As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Bm_MflBi
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bm_MflBi = Nothing
					Else
						entity.Bm_MflBi = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BM_MFLTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BM_MFLTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BM_MFLTotal = Nothing
					Else
						entity.BM_MFLTotal = Convert.ToDecimal(Value)
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
		  	
			Public Property IRUpdate As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IRUpdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRUpdate = Nothing
					Else
						entity.IRUpdate = Convert.ToBoolean(Value)
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
		  	
			Public Property IRTargetMonth As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.IRTargetMonth
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRTargetMonth = Nothing
					Else
						entity.IRTargetMonth = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.IRLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRLastInspectionReport = Nothing
					Else
						entity.IRLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.IRLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRLastInspectionDate = Nothing
					Else
						entity.IRLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRScheduledDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.IRScheduledDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRScheduledDate = Nothing
					Else
						entity.IRScheduledDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.IRActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRActualDate = Nothing
					Else
						entity.IRActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToIRReport As System.String 
				Get
					Dim data_ As System.String = entity.ToIRReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToIRReport = Nothing
					Else
						entity.ToIRReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IREmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.IREmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IREmailedDate = Nothing
					Else
						entity.IREmailedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazWindLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.NatHazWindLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindLastInspectionReport = Nothing
					Else
						entity.NatHazWindLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazWindLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazWindLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindLastInspectionDate = Nothing
					Else
						entity.NatHazWindLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazWindActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazWindActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindActualDate = Nothing
					Else
						entity.NatHazWindActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazWindReport As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazWindReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazWindReport = Nothing
					Else
						entity.ToNatHazWindReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazWindReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazWindReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazWindReport2 = Nothing
					Else
						entity.ToNatHazWindReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazWindDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazWindDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazWindDiagram = Nothing
					Else
						entity.ToNatHazWindDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazWindEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazWindEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazWindEmailedDate = Nothing
					Else
						entity.NatHazWindEmailedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.NatHazSeismicLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicLastInspectionReport = Nothing
					Else
						entity.NatHazSeismicLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazSeismicLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicLastInspectionDate = Nothing
					Else
						entity.NatHazSeismicLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazSeismicActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicActualDate = Nothing
					Else
						entity.NatHazSeismicActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazSeismicReport As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazSeismicReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazSeismicReport = Nothing
					Else
						entity.ToNatHazSeismicReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazSeismicReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazSeismicReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazSeismicReport2 = Nothing
					Else
						entity.ToNatHazSeismicReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazSeismicDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazSeismicDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazSeismicDiagram = Nothing
					Else
						entity.ToNatHazSeismicDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazSeismicEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazSeismicEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazSeismicEmailedDate = Nothing
					Else
						entity.NatHazSeismicEmailedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodLastInspectionReport As System.String 
				Get
					Dim data_ As System.String = entity.NatHazFloodLastInspectionReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodLastInspectionReport = Nothing
					Else
						entity.NatHazFloodLastInspectionReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodLastInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazFloodLastInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodLastInspectionDate = Nothing
					Else
						entity.NatHazFloodLastInspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodActualDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazFloodActualDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodActualDate = Nothing
					Else
						entity.NatHazFloodActualDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazFloodReport As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazFloodReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazFloodReport = Nothing
					Else
						entity.ToNatHazFloodReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazFloodReport2 As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazFloodReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazFloodReport2 = Nothing
					Else
						entity.ToNatHazFloodReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ToNatHazFloodDiagram As System.String 
				Get
					Dim data_ As System.String = entity.ToNatHazFloodDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ToNatHazFloodDiagram = Nothing
					Else
						entity.ToNatHazFloodDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazFloodEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NatHazFloodEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazFloodEmailedDate = Nothing
					Else
						entity.NatHazFloodEmailedDate = Convert.ToDateTime(Value)
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
		  

			Private entity As esLocationSpecificAll
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return LocationSpecificAllMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As LocationSpecificAllQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New LocationSpecificAllQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As LocationSpecificAllQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As LocationSpecificAllQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As LocationSpecificAllQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esLocationSpecificAllCollection
		Inherits esEntityCollection(Of LocationSpecificAll)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return LocationSpecificAllMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "LocationSpecificAllCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As LocationSpecificAllQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New LocationSpecificAllQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As LocationSpecificAllQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New LocationSpecificAllQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As LocationSpecificAllQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, LocationSpecificAllQuery))
		End Sub
		
		#End Region
						
		Private m_query As LocationSpecificAllQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esLocationSpecificAllQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LocationSpecificAllMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "Id" 
					Return Me.Id
				Case "Field1" 
					Return Me.Field1
				Case "MasterDivision" 
					Return Me.MasterDivision
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
				Case "[Entity1]" 
					Return Me.[Entity1]
				Case "Occupancy" 
					Return Me.Occupancy
				Case "Zone" 
					Return Me.Zone
				Case "[STRUCTURE]" 
					Return Me.[STRUCTURE]
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
				Case "ToBMReport2" 
					Return Me.ToBMReport2
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
				Case "AplPd" 
					Return Me.AplPd
				Case "AplBi" 
					Return Me.AplBi
				Case "APLTotal" 
					Return Me.APLTotal
				Case "PmlPd" 
					Return Me.PmlPd
				Case "PmlBi" 
					Return Me.PmlBi
				Case "PMLTotal" 
					Return Me.PMLTotal
				Case "MflPd" 
					Return Me.MflPd
				Case "MflBi" 
					Return Me.MflBi
				Case "MFLTotal" 
					Return Me.MFLTotal
				Case "Bm_AplPd" 
					Return Me.Bm_AplPd
				Case "Bm_AplBi" 
					Return Me.Bm_AplBi
				Case "BM_APLTotal" 
					Return Me.BM_APLTotal
				Case "Bm_PmlPd" 
					Return Me.Bm_PmlPd
				Case "Bm_PmlBi" 
					Return Me.Bm_PmlBi
				Case "BM_PMLTotal" 
					Return Me.BM_PMLTotal
				Case "Bm_MflPd" 
					Return Me.Bm_MflPd
				Case "Bm_MflBi" 
					Return Me.Bm_MflBi
				Case "BM_MFLTotal" 
					Return Me.BM_MFLTotal
				Case "FireUpdate" 
					Return Me.FireUpdate
				Case "BMUpdate" 
					Return Me.BMUpdate
				Case "IRUpdate" 
					Return Me.IRUpdate
				Case "SquareFootage" 
					Return Me.SquareFootage
				Case "BusinessContinuationPlan" 
					Return Me.BusinessContinuationPlan
				Case "IRTargetMonth" 
					Return Me.IRTargetMonth
				Case "IRLastInspectionReport" 
					Return Me.IRLastInspectionReport
				Case "IRLastInspectionDate" 
					Return Me.IRLastInspectionDate
				Case "IRScheduledDate" 
					Return Me.IRScheduledDate
				Case "IRActualDate" 
					Return Me.IRActualDate
				Case "ToIRReport" 
					Return Me.ToIRReport
				Case "IREmailedDate" 
					Return Me.IREmailedDate
				Case "NatHazWindLastInspectionReport" 
					Return Me.NatHazWindLastInspectionReport
				Case "NatHazWindLastInspectionDate" 
					Return Me.NatHazWindLastInspectionDate
				Case "NatHazWindActualDate" 
					Return Me.NatHazWindActualDate
				Case "ToNatHazWindReport" 
					Return Me.ToNatHazWindReport
				Case "ToNatHazWindReport2" 
					Return Me.ToNatHazWindReport2
				Case "ToNatHazWindDiagram" 
					Return Me.ToNatHazWindDiagram
				Case "NatHazWindEmailedDate" 
					Return Me.NatHazWindEmailedDate
				Case "NatHazSeismicLastInspectionReport" 
					Return Me.NatHazSeismicLastInspectionReport
				Case "NatHazSeismicLastInspectionDate" 
					Return Me.NatHazSeismicLastInspectionDate
				Case "NatHazSeismicActualDate" 
					Return Me.NatHazSeismicActualDate
				Case "ToNatHazSeismicReport" 
					Return Me.ToNatHazSeismicReport
				Case "ToNatHazSeismicReport2" 
					Return Me.ToNatHazSeismicReport2
				Case "ToNatHazSeismicDiagram" 
					Return Me.ToNatHazSeismicDiagram
				Case "NatHazSeismicEmailedDate" 
					Return Me.NatHazSeismicEmailedDate
				Case "NatHazFloodLastInspectionReport" 
					Return Me.NatHazFloodLastInspectionReport
				Case "NatHazFloodLastInspectionDate" 
					Return Me.NatHazFloodLastInspectionDate
				Case "NatHazFloodActualDate" 
					Return Me.NatHazFloodActualDate
				Case "ToNatHazFloodReport" 
					Return Me.ToNatHazFloodReport
				Case "ToNatHazFloodReport2" 
					Return Me.ToNatHazFloodReport2
				Case "ToNatHazFloodDiagram" 
					Return Me.ToNatHazFloodDiagram
				Case "NatHazFloodEmailedDate" 
					Return Me.NatHazFloodEmailedDate
				Case "AdminMemo" 
					Return Me.AdminMemo
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Field1 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Field1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MasterDivision As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.MasterDivision, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ownership As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Ownership, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IRINo As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.IRINo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AccountablePerson As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.AccountablePerson, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantID As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.PlantID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantName As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.PlantName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCEngineerFire As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.GRCEngineerFire, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCEngineerBM As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.GRCEngineerBM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCTitle As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.GRCTitle, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocation As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ClientLocation, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Locationname As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Locationname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessUnit As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BusinessUnit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property [Entity1] As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.[Entity1], esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occupancy As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Occupancy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zone As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Zone, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property [STRUCTURE] As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.[STRUCTURE], esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Equipment As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Equipment, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Inventory As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Inventory, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pd As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Pd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bi As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bi, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Tiv As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Tiv, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FireFreq As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireFreq, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2000 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Fire2000, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2001 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Fire2001, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2002 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Fire2002, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2003 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Fire2003, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2004 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Fire2004, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire2005 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Fire2005, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FireTargetMonth As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireTargetMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FireLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FireScheduledDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireScheduledDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FireActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToFireReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToFireReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToFireDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToFireDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToBPVReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToBPVReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FireInspectionCount As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireInspectionCount, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecialReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.SpecialReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlanReview As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.PlanReview, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireRecResponseRecevied As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireRecResponseRecevied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireAQEDateRecevied As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireAQEDateRecevied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireAQERating As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireAQERating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMFreq As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMFreq, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2000 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm2000, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2001 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm2001, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2002 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm2002, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2003 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm2003, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2004 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm2004, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bm2005 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm2005, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BMTarget As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMTarget, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EngineerRequired As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.EngineerRequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToBMDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToBMDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMScheduledDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMScheduledDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property BMActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property BMEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToBMReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToBMReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToBMReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToBMReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMRecResponseReceived As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMRecResponseReceived, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMAQEDateRecevied As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMAQEDateRecevied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMAQERating As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMAQERating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMInspectionCount As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMInspectionCount, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationManager As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.LocationManager, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationPhone As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.LocationPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationFax As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.LocationFax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationEmail As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.LocationEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ARISELastInspection As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ARISELastInspection, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ARISEInspectionLetter As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ARISEInspectionLetter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ARISELocationManager As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ARISELocationManager, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireComments As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BMComments As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BPVComments As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BPVComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AplPd As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.AplPd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property AplBi As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.AplBi, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.APLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PmlPd As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.PmlPd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PmlBi As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.PmlBi, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PMLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.PMLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MflPd As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.MflPd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MflBi As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.MflBi, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MFLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.MFLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bm_AplPd As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm_AplPd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bm_AplBi As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm_AplBi, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BM_APLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BM_APLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bm_PmlPd As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm_PmlPd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bm_PmlBi As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm_PmlBi, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BM_PMLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BM_PMLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bm_MflPd As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm_MflPd, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bm_MflBi As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.Bm_MflBi, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BM_MFLTotal As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BM_MFLTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FireUpdate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.FireUpdate, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property BMUpdate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BMUpdate, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property IRUpdate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.IRUpdate, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SquareFootage As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.SquareFootage, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessContinuationPlan As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.BusinessContinuationPlan, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property IRTargetMonth As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.IRTargetMonth, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property IRLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.IRLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IRLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.IRLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property IRScheduledDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.IRScheduledDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property IRActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.IRActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToIRReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToIRReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IREmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.IREmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazWindLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazWindLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazWindActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazWindReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazWindReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazWindReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazWindReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazWindDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazWindDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazWindEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazWindEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazSeismicLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazSeismicLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazSeismicActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazSeismicReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazSeismicReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazSeismicDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazSeismicEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazSeismicEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodLastInspectionReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazFloodLastInspectionReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodLastInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazFloodLastInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodActualDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazFloodActualDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazFloodReport As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazFloodReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ToNatHazFloodDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazFloodEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.NatHazFloodEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AdminMemo As esQueryItem
			Get
				Return New esQueryItem(Me, LocationSpecificAllMetadata.ColumnNames.AdminMemo, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class LocationSpecificAll 
		Inherits esLocationSpecificAll
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class LocationSpecificAllMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Id, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Id
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Field1, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Field1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.MasterDivision, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.MasterDivision
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Ownership, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Ownership
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.IRINo, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.IRINo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.AccountablePerson, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.AccountablePerson
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.PlantID, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.PlantID
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.PlantName, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.PlantName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.GRCEngineerFire, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.GRCEngineerFire
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.GRCEngineerBM, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.GRCEngineerBM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.GRCTitle, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.GRCTitle
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ClientLocation, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ClientLocation
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Locationname, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Locationname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Status, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Status
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BusinessUnit, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BusinessUnit
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.[Entity1], 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.[Entity1]
			c.CharacterMaxLength = 50
			c.IsNullable = True
			c.Alias = "[Entity1]"
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Occupancy, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Occupancy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Zone, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Zone
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.[STRUCTURE], 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.[STRUCTURE]
			c.NumericPrecision = 19
			c.IsNullable = True
			c.Alias = "[STRUCTURE]"
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Equipment, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Equipment
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Inventory, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Inventory
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Pd, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Pd
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bi, 23, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bi
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Tiv, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Tiv
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireFreq, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireFreq
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Fire2000, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Fire2000
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Fire2001, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Fire2001
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Fire2002, 28, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Fire2002
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Fire2003, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Fire2003
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Fire2004, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Fire2004
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Fire2005, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Fire2005
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireTargetMonth, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireTargetMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireLastInspectionReport, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireLastInspectionDate, 34, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireScheduledDate, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireScheduledDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireActualDate, 36, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToFireReport, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToFireReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToFireReport2, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToFireReport2
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToFireDiagram, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToFireDiagram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToBPVReport, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToBPVReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireEmailedDate, 41, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireInspectionCount, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireInspectionCount
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.SpecialReport, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.SpecialReport
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.PlanReview, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.PlanReview
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireRecResponseRecevied, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireRecResponseRecevied
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireAQEDateRecevied, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireAQEDateRecevied
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireAQERating, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireAQERating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMFreq, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMFreq
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm2000, 49, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm2000
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm2001, 50, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm2001
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm2002, 51, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm2002
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm2003, 52, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm2003
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm2004, 53, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm2004
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm2005, 54, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm2005
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMTarget, 55, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMTarget
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.EngineerRequired, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.EngineerRequired
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMLastInspectionReport, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMLastInspectionDate, 58, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToBMDiagram, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToBMDiagram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMScheduledDate, 60, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMScheduledDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMActualDate, 61, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMEmailedDate, 62, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToBMReport, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToBMReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToBMReport2, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToBMReport2
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMRecResponseReceived, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMRecResponseReceived
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMAQEDateRecevied, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMAQEDateRecevied
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMAQERating, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMAQERating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMInspectionCount, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMInspectionCount
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.LocationManager, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.LocationManager
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.LocationPhone, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.LocationPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.LocationFax, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.LocationFax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.LocationEmail, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.LocationEmail
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ARISELastInspection, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ARISELastInspection
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ARISEInspectionLetter, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ARISEInspectionLetter
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ARISELocationManager, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ARISELocationManager
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireComments, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMComments, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMComments
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BPVComments, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BPVComments
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Comments, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ResponseDate, 80, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.AplPd, 81, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.AplPd
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.AplBi, 82, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.AplBi
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.APLTotal, 83, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.APLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.PmlPd, 84, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.PmlPd
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.PmlBi, 85, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.PmlBi
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.PMLTotal, 86, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.PMLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.MflPd, 87, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.MflPd
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.MflBi, 88, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.MflBi
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.MFLTotal, 89, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.MFLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm_AplPd, 90, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm_AplPd
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm_AplBi, 91, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm_AplBi
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BM_APLTotal, 92, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BM_APLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm_PmlPd, 93, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm_PmlPd
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm_PmlBi, 94, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm_PmlBi
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BM_PMLTotal, 95, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BM_PMLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm_MflPd, 96, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm_MflPd
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.Bm_MflBi, 97, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.Bm_MflBi
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BM_MFLTotal, 98, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BM_MFLTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.FireUpdate, 99, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.FireUpdate
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BMUpdate, 100, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BMUpdate
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.IRUpdate, 101, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.IRUpdate
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.SquareFootage, 102, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.SquareFootage
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.BusinessContinuationPlan, 103, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.BusinessContinuationPlan
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.IRTargetMonth, 104, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.IRTargetMonth
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.IRLastInspectionReport, 105, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.IRLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.IRLastInspectionDate, 106, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.IRLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.IRScheduledDate, 107, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.IRScheduledDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.IRActualDate, 108, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.IRActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToIRReport, 109, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToIRReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.IREmailedDate, 110, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.IREmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazWindLastInspectionReport, 111, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazWindLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazWindLastInspectionDate, 112, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazWindLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazWindActualDate, 113, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazWindActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindReport, 114, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazWindReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindReport2, 115, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazWindReport2
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazWindDiagram, 116, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazWindDiagram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazWindEmailedDate, 117, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazWindEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicLastInspectionReport, 118, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazSeismicLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicLastInspectionDate, 119, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazSeismicLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicActualDate, 120, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazSeismicActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicReport, 121, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazSeismicReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicReport2, 122, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazSeismicReport2
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazSeismicDiagram, 123, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazSeismicDiagram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazSeismicEmailedDate, 124, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazSeismicEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazFloodLastInspectionReport, 125, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazFloodLastInspectionReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazFloodLastInspectionDate, 126, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazFloodLastInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazFloodActualDate, 127, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazFloodActualDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodReport, 128, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazFloodReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodReport2, 129, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazFloodReport2
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.ToNatHazFloodDiagram, 130, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.ToNatHazFloodDiagram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.NatHazFloodEmailedDate, 131, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.NatHazFloodEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(LocationSpecificAllMetadata.ColumnNames.AdminMemo, 132, GetType(System.String), esSystemType.String)	
			c.PropertyName = LocationSpecificAllMetadata.PropertyNames.AdminMemo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As LocationSpecificAllMetadata
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
			 Public Const Id As String = "ID"
			 Public Const Field1 As String = "Field1"
			 Public Const MasterDivision As String = "MasterDivision"
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
			 Public Const [Entity1] As String = "Entity"
			 Public Const Occupancy As String = "OCCUPANCY"
			 Public Const Zone As String = "ZONE"
			 Public Const [STRUCTURE] As String = "STRUCTURE"
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
			 Public Const ToBMReport2 As String = "ToBMReport2"
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
			 Public Const AplPd As String = "APL-PD"
			 Public Const AplBi As String = "APL-BI"
			 Public Const APLTotal As String = "APL-Total"
			 Public Const PmlPd As String = "PML-PD"
			 Public Const PmlBi As String = "PML-BI"
			 Public Const PMLTotal As String = "PML-Total"
			 Public Const MflPd As String = "MFL-PD"
			 Public Const MflBi As String = "MFL-BI"
			 Public Const MFLTotal As String = "MFL-Total"
			 Public Const Bm_AplPd As String = "BM_APL-PD"
			 Public Const Bm_AplBi As String = "BM_APL-BI"
			 Public Const BM_APLTotal As String = "BM_APL-Total"
			 Public Const Bm_PmlPd As String = "BM_PML-PD"
			 Public Const Bm_PmlBi As String = "BM_PML-BI"
			 Public Const BM_PMLTotal As String = "BM_PML-Total"
			 Public Const Bm_MflPd As String = "BM_MFL-PD"
			 Public Const Bm_MflBi As String = "BM_MFL-BI"
			 Public Const BM_MFLTotal As String = "BM_MFL-Total"
			 Public Const FireUpdate As String = "FireUpdate"
			 Public Const BMUpdate As String = "BMUpdate"
			 Public Const IRUpdate As String = "IRUpdate"
			 Public Const SquareFootage As String = "SquareFootage"
			 Public Const BusinessContinuationPlan As String = "BusinessContinuationPlan"
			 Public Const IRTargetMonth As String = "IRTargetMonth"
			 Public Const IRLastInspectionReport As String = "IRLastInspectionReport"
			 Public Const IRLastInspectionDate As String = "IRLastInspectionDate"
			 Public Const IRScheduledDate As String = "IRScheduledDate"
			 Public Const IRActualDate As String = "IRActualDate"
			 Public Const ToIRReport As String = "ToIRReport"
			 Public Const IREmailedDate As String = "IREmailedDate"
			 Public Const NatHazWindLastInspectionReport As String = "NatHaz-Wind-LastInspectionReport"
			 Public Const NatHazWindLastInspectionDate As String = "NatHaz-Wind-LastInspectionDate"
			 Public Const NatHazWindActualDate As String = "NatHaz-Wind-ActualDate"
			 Public Const ToNatHazWindReport As String = "ToNatHaz-Wind-Report"
			 Public Const ToNatHazWindReport2 As String = "ToNatHaz-Wind-Report2"
			 Public Const ToNatHazWindDiagram As String = "ToNatHaz-Wind-Diagram"
			 Public Const NatHazWindEmailedDate As String = "NatHaz-Wind-EmailedDate"
			 Public Const NatHazSeismicLastInspectionReport As String = "NatHaz-Seismic-LastInspectionReport"
			 Public Const NatHazSeismicLastInspectionDate As String = "NatHaz-Seismic-LastInspectionDate"
			 Public Const NatHazSeismicActualDate As String = "NatHaz-Seismic-ActualDate"
			 Public Const ToNatHazSeismicReport As String = "ToNatHaz-Seismic-Report"
			 Public Const ToNatHazSeismicReport2 As String = "ToNatHaz-Seismic-Report2"
			 Public Const ToNatHazSeismicDiagram As String = "ToNatHaz-Seismic-Diagram"
			 Public Const NatHazSeismicEmailedDate As String = "NatHaz-Seismic-EmailedDate"
			 Public Const NatHazFloodLastInspectionReport As String = "NatHaz-Flood-LastInspectionReport"
			 Public Const NatHazFloodLastInspectionDate As String = "NatHaz-Flood-LastInspectionDate"
			 Public Const NatHazFloodActualDate As String = "NatHaz-Flood-ActualDate"
			 Public Const ToNatHazFloodReport As String = "ToNatHaz-Flood-Report"
			 Public Const ToNatHazFloodReport2 As String = "ToNatHaz-Flood-Report2"
			 Public Const ToNatHazFloodDiagram As String = "ToNatHaz-Flood-Diagram"
			 Public Const NatHazFloodEmailedDate As String = "NatHaz-Flood-EmailedDate"
			 Public Const AdminMemo As String = "AdminMemo"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const Id As String = "Id"
			 Public Const Field1 As String = "Field1"
			 Public Const MasterDivision As String = "MasterDivision"
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
			 Public Const [Entity1] As String = "[Entity1]"
			 Public Const Occupancy As String = "Occupancy"
			 Public Const Zone As String = "Zone"
			 Public Const [STRUCTURE] As String = "[STRUCTURE]"
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
			 Public Const ToBMReport2 As String = "ToBMReport2"
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
			 Public Const AplPd As String = "AplPd"
			 Public Const AplBi As String = "AplBi"
			 Public Const APLTotal As String = "APLTotal"
			 Public Const PmlPd As String = "PmlPd"
			 Public Const PmlBi As String = "PmlBi"
			 Public Const PMLTotal As String = "PMLTotal"
			 Public Const MflPd As String = "MflPd"
			 Public Const MflBi As String = "MflBi"
			 Public Const MFLTotal As String = "MFLTotal"
			 Public Const Bm_AplPd As String = "Bm_AplPd"
			 Public Const Bm_AplBi As String = "Bm_AplBi"
			 Public Const BM_APLTotal As String = "BM_APLTotal"
			 Public Const Bm_PmlPd As String = "Bm_PmlPd"
			 Public Const Bm_PmlBi As String = "Bm_PmlBi"
			 Public Const BM_PMLTotal As String = "BM_PMLTotal"
			 Public Const Bm_MflPd As String = "Bm_MflPd"
			 Public Const Bm_MflBi As String = "Bm_MflBi"
			 Public Const BM_MFLTotal As String = "BM_MFLTotal"
			 Public Const FireUpdate As String = "FireUpdate"
			 Public Const BMUpdate As String = "BMUpdate"
			 Public Const IRUpdate As String = "IRUpdate"
			 Public Const SquareFootage As String = "SquareFootage"
			 Public Const BusinessContinuationPlan As String = "BusinessContinuationPlan"
			 Public Const IRTargetMonth As String = "IRTargetMonth"
			 Public Const IRLastInspectionReport As String = "IRLastInspectionReport"
			 Public Const IRLastInspectionDate As String = "IRLastInspectionDate"
			 Public Const IRScheduledDate As String = "IRScheduledDate"
			 Public Const IRActualDate As String = "IRActualDate"
			 Public Const ToIRReport As String = "ToIRReport"
			 Public Const IREmailedDate As String = "IREmailedDate"
			 Public Const NatHazWindLastInspectionReport As String = "NatHazWindLastInspectionReport"
			 Public Const NatHazWindLastInspectionDate As String = "NatHazWindLastInspectionDate"
			 Public Const NatHazWindActualDate As String = "NatHazWindActualDate"
			 Public Const ToNatHazWindReport As String = "ToNatHazWindReport"
			 Public Const ToNatHazWindReport2 As String = "ToNatHazWindReport2"
			 Public Const ToNatHazWindDiagram As String = "ToNatHazWindDiagram"
			 Public Const NatHazWindEmailedDate As String = "NatHazWindEmailedDate"
			 Public Const NatHazSeismicLastInspectionReport As String = "NatHazSeismicLastInspectionReport"
			 Public Const NatHazSeismicLastInspectionDate As String = "NatHazSeismicLastInspectionDate"
			 Public Const NatHazSeismicActualDate As String = "NatHazSeismicActualDate"
			 Public Const ToNatHazSeismicReport As String = "ToNatHazSeismicReport"
			 Public Const ToNatHazSeismicReport2 As String = "ToNatHazSeismicReport2"
			 Public Const ToNatHazSeismicDiagram As String = "ToNatHazSeismicDiagram"
			 Public Const NatHazSeismicEmailedDate As String = "NatHazSeismicEmailedDate"
			 Public Const NatHazFloodLastInspectionReport As String = "NatHazFloodLastInspectionReport"
			 Public Const NatHazFloodLastInspectionDate As String = "NatHazFloodLastInspectionDate"
			 Public Const NatHazFloodActualDate As String = "NatHazFloodActualDate"
			 Public Const ToNatHazFloodReport As String = "ToNatHazFloodReport"
			 Public Const ToNatHazFloodReport2 As String = "ToNatHazFloodReport2"
			 Public Const ToNatHazFloodDiagram As String = "ToNatHazFloodDiagram"
			 Public Const NatHazFloodEmailedDate As String = "NatHazFloodEmailedDate"
			 Public Const AdminMemo As String = "AdminMemo"
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
			SyncLock GetType(LocationSpecificAllMetadata)
			
				If LocationSpecificAllMetadata.mapDelegates Is Nothing Then
					LocationSpecificAllMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If LocationSpecificAllMetadata._meta Is Nothing Then
					LocationSpecificAllMetadata._meta = New LocationSpecificAllMetadata()
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
				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Field1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MasterDivision", new esTypeMap("nvarchar", "System.String"))
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
				meta.AddTypeMap("[Entity1]", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Occupancy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zone", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("[STRUCTURE]", new esTypeMap("money", "System.Decimal"))
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
				meta.AddTypeMap("ToBMReport2", new esTypeMap("nvarchar", "System.String"))
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
				meta.AddTypeMap("AplPd", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("AplBi", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("APLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("PmlPd", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("PmlBi", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("PMLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("MflPd", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("MflBi", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("MFLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Bm_AplPd", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Bm_AplBi", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("BM_APLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Bm_PmlPd", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Bm_PmlBi", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("BM_PMLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Bm_MflPd", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Bm_MflBi", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("BM_MFLTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FireUpdate", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("BMUpdate", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("IRUpdate", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SquareFootage", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BusinessContinuationPlan", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("IRTargetMonth", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("IRLastInspectionReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("IRLastInspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("IRScheduledDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("IRActualDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ToIRReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("IREmailedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("NatHazWindLastInspectionReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NatHazWindLastInspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("NatHazWindActualDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ToNatHazWindReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToNatHazWindReport2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToNatHazWindDiagram", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NatHazWindEmailedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("NatHazSeismicLastInspectionReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NatHazSeismicLastInspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("NatHazSeismicActualDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ToNatHazSeismicReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToNatHazSeismicReport2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToNatHazSeismicDiagram", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NatHazSeismicEmailedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("NatHazFloodLastInspectionReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NatHazFloodLastInspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("NatHazFloodActualDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ToNatHazFloodReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToNatHazFloodReport2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ToNatHazFloodDiagram", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NatHazFloodEmailedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("AdminMemo", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "LocationSpecific-All"
				meta.Destination = "LocationSpecific-All"
				
				meta.spInsert = "proc_LocationSpecific-AllInsert"
				meta.spUpdate = "proc_LocationSpecific-AllUpdate"
				meta.spDelete = "proc_LocationSpecific-AllDelete"
				meta.spLoadAll = "proc_LocationSpecific-AllLoadAll"
				meta.spLoadByPrimaryKey = "proc_LocationSpecific-AllLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As LocationSpecificAllMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
