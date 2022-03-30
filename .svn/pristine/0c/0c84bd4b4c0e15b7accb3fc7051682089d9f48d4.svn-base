
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/19/2017 10:00:01 AM
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
	' Encapsulates the 'GRIPSS-Workload' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(GRIPSSWorkload))> _
	<XmlType("GRIPSSWorkload")> _	
	Partial Public Class GRIPSSWorkload 
		Inherits esGRIPSSWorkload
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New GRIPSSWorkload()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal gripssRecordID As System.Int32)
			Dim obj As New GRIPSSWorkload()
			obj.GripssRecordID = gripssRecordID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal gripssRecordID As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New GRIPSSWorkload()
			obj.GripssRecordID = gripssRecordID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("GRIPSSWorkloadCollection")> _
	Partial Public Class GRIPSSWorkloadCollection
		Inherits esGRIPSSWorkloadCollection
		Implements IEnumerable(Of GRIPSSWorkload)
	
		Public Function FindByPrimaryKey(ByVal gripssRecordID As System.Int32) As GRIPSSWorkload
			Return MyBase.SingleOrDefault(Function(e) e.GripssRecordID.HasValue AndAlso e.GripssRecordID.Value = gripssRecordID)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(GRIPSSWorkload))> _
		Public Class GRIPSSWorkloadCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of GRIPSSWorkloadCollection)
			
			Public Shared Widening Operator CType(packet As GRIPSSWorkloadCollectionWCFPacket) As GRIPSSWorkloadCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As GRIPSSWorkloadCollection) As GRIPSSWorkloadCollectionWCFPacket
				Return New GRIPSSWorkloadCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class GRIPSSWorkloadQuery 
		Inherits esGRIPSSWorkloadQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "GRIPSSWorkloadQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As GRIPSSWorkloadQuery) As String
			Return GRIPSSWorkloadQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As GRIPSSWorkloadQuery
			Return DirectCast(GRIPSSWorkloadQuery.SerializeHelper.FromXml(query, GetType(GRIPSSWorkloadQuery)), GRIPSSWorkloadQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esGRIPSSWorkload
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal gripssRecordID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gripssRecordID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gripssRecordID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal gripssRecordID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gripssRecordID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gripssRecordID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal gripssRecordID As System.Int32) As Boolean
		
			Dim query As New GRIPSSWorkloadQuery()
			query.Where(query.GripssRecordID = gripssRecordID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal gripssRecordID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("GripssRecordID", gripssRecordID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to GRIPSS-Workload.GripssRecordID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GripssRecordID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.GripssRecordID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.GripssRecordID, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.GripssRecordID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Parent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Parent As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Parent)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Parent, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Parent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ParentNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ParentNo As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ParentNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ParentNo, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ParentNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Abbr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Abbr As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Abbr)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Abbr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Abbr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Facility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Address1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Address2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address2 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Address2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Address2, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Address2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Address3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address3 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Address3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Address3, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Address3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.StProv
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProv As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.StProv)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.StProv, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.StProv)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.StProvName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StProvName As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.StProvName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.StProvName, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.StProvName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Zip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.County
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property County As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.County)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.County, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.County)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PHONE1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone1 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Phone1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Phone1, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Phone1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.FAX
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ClientLocNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientLocNo As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ClientLocNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ClientLocNo, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ClientLocNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(GRIPSSWorkloadMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(GRIPSSWorkloadMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ContractYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContractYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(GRIPSSWorkloadMetadata.ColumnNames.ContractYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(GRIPSSWorkloadMetadata.ColumnNames.ContractYr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ContractYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.AriseStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AriseStatus As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.AriseStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.AriseStatus, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.AriseStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.LocationStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationStatus As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.LocationStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.LocationStatus, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.LocationStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Frequency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Frequency As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Frequency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Frequency, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Frequency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.NextInspYr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NextInspYr As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(GRIPSSWorkloadMetadata.ColumnNames.NextInspYr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(GRIPSSWorkloadMetadata.ColumnNames.NextInspYr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.NextInspYr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.District
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property District As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.District)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.District, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.District)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Region
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Region As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Region)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Region, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Region)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InspPerFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspPerFROM As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.InspPerFROM)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.InspPerFROM, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspPerFROM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InspPerTO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspPerTO As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.InspPerTO)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.InspPerTO, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspPerTO)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ServicedBy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ServicedBy As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ServicedBy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ServicedBy, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ServicedBy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.LocationComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationComment As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.LocationComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.LocationComment, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.LocationComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.SchedulingComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedulingComment As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.SchedulingComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.SchedulingComment, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.SchedulingComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.CancelDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CancelDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.CancelDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.CancelDate, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.CancelDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.CancelNote
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CancelNote As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.CancelNote)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.CancelNote, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.CancelNote)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ReinstateDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReinstateDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.ReinstateDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.ReinstateDate, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ReinstateDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ReinstateNote
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReinstateNote As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ReinstateNote)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ReinstateNote, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ReinstateNote)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ContractOwnership
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContractOwnership As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ContractOwnership)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ContractOwnership, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ContractOwnership)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InspDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.InspDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.InspDue, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InspRemaining
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspRemaining As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.InspRemaining)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.InspRemaining, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspRemaining)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.LastYrInspection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastYrInspection As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.LastYrInspection)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.LastYrInspection, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.LastYrInspection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.LastYrEngineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastYrEngineer As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.LastYrEngineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.LastYrEngineer, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.LastYrEngineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InspectionStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionStatus As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.InspectionStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.InspectionStatus, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspectionStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Engineer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engineer As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Engineer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Engineer, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Engineer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.DateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.DateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.DateCompleted, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.DateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ClientTargetMo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientTargetMo As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.ClientTargetMo)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.ClientTargetMo, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ClientTargetMo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EngTargetMo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngTargetMo As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.EngTargetMo)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.EngTargetMo, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngTargetMo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.SchedFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedFROM As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.SchedFROM)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.SchedFROM, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.SchedFROM)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.SchedTO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SchedTO As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.SchedTO)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.SchedTO, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.SchedTO)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.TripGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TripGroup As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.TripGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.TripGroup, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.TripGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Report1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report1 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Report1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Report1, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Report1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt1Procr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt1Procr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Procr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Procr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt1Procr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt1Revwr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt1Revwr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Revwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Revwr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt1Revwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt1Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt1Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Client, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt1Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Report2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report2 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Report2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Report2, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Report2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt2Procr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Procr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Procr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Procr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt2Procr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt2Revwr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Revwr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Revwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Revwr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt2Revwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt2Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt2Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Client, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt2Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Report3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report3 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Report3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Report3, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Report3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt3Procr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt3Procr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Procr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Procr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt3Procr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt3Revwr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt3Revwr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Revwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Revwr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt3Revwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt3Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt3Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Client, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt3Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Report4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report4 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Report4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Report4, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Report4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt4Procr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt4Procr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Procr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Procr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt4Procr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt4Revwr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt4Revwr As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Revwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Revwr, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt4Revwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Rpt4Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rpt4Client As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Client)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Client, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt4Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.DiagrSubm
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DiagrSubm As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.DiagrSubm)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.DiagrSubm, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.DiagrSubm)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.DiagrIssued
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DiagrIssued As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.DiagrIssued)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.DiagrIssued, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.DiagrIssued)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EstInspHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EstInspHrs As Nullable(Of System.Single)
			Get
				Return MyBase.GetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.EstInspHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Single))
				If MyBase.SetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.EstInspHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EstInspHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EstRptHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EstRptHrs As Nullable(Of System.Single)
			Get
				Return MyBase.GetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.EstRptHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Single))
				If MyBase.SetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.EstRptHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EstRptHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EstTravelHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EstTravelHrs As Nullable(Of System.Single)
			Get
				Return MyBase.GetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.EstTravelHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Single))
				If MyBase.SetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.EstTravelHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EstTravelHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EstOtherHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EstOtherHrs As Nullable(Of System.Single)
			Get
				Return MyBase.GetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.EstOtherHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Single))
				If MyBase.SetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.EstOtherHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EstOtherHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.TotalEstHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalEstHrs As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames.TotalEstHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames.TotalEstHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.TotalEstHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.QuotInspHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property QuotInspHrs As Nullable(Of System.Single)
			Get
				Return MyBase.GetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.QuotInspHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Single))
				If MyBase.SetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.QuotInspHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.QuotInspHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.QuotRptHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property QuotRptHrs As Nullable(Of System.Single)
			Get
				Return MyBase.GetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.QuotRptHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Single))
				If MyBase.SetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.QuotRptHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.QuotRptHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.QuotTravelHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property QuotTravelHrs As Nullable(Of System.Single)
			Get
				Return MyBase.GetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.QuotTravelHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Single))
				If MyBase.SetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.QuotTravelHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.QuotTravelHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.QuotOtherHrs
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property QuotOtherHrs As Nullable(Of System.Single)
			Get
				Return MyBase.GetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.QuotOtherHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Single))
				If MyBase.SetSystemSingle(GRIPSSWorkloadMetadata.ColumnNames.QuotOtherHrs, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.QuotOtherHrs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InspNotes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspNotes As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.InspNotes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.InspNotes, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspNotes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EffectiveDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EffectiveDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.EffectiveDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.EffectiveDate, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EffectiveDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.CurrencyCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrencyCode As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.CurrencyCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.CurrencyCode, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.CurrencyCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PD_Building
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDBuilding As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDBuilding)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDBuilding, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PDBuilding)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PD_Equipment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDEquipment As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDEquipment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDEquipment, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PDEquipment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PD_Finished
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDFinished As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDFinished)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDFinished, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PDFinished)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PD_RawStock
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDRawStock As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDRawStock)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDRawStock, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PDRawStock)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PD_BuildersRisk
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDBuildersRisk As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDBuildersRisk)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDBuildersRisk, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PDBuildersRisk)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PD_Misc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDMisc As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDMisc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDMisc, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PDMisc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.PD_Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PDTotal As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDTotal)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.PDTotal, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PDTotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.BI_GrossProfit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIGrossProfit As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BIGrossProfit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BIGrossProfit, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.BIGrossProfit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.BI_WageExtraExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIWageExtraExp As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BIWageExtraExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BIWageExtraExp, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.BIWageExtraExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.BI_Misc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIMisc As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BIMisc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BIMisc, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.BIMisc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.BI_Other
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BIOther As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BIOther)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BIOther, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.BIOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.BI_Total
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BITotal As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BITotal)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.BITotal, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.BITotal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.GrossProfitIndemnity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GrossProfitIndemnity As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames.GrossProfitIndemnity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames.GrossProfitIndemnity, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.GrossProfitIndemnity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.WagesExtraExpIndem
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WagesExtraExpIndem As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames.WagesExtraExpIndem)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames.WagesExtraExpIndem, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.WagesExtraExpIndem)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.TotalUS_PD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSPD As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.TotalUSPD)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.TotalUSPD, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.TotalUSPD)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.TotalUS_BI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSBI As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.TotalUSBI)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.TotalUSBI, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.TotalUSBI)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.TotalUS_TIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalUSTIV As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.TotalUSTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.TotalUSTIV, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.TotalUSTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.LocalTIV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocalTIV As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.LocalTIV)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.LocalTIV, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.LocalTIV)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Office
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Office As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Office)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Office, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Office)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InspectRegID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectRegID As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.InspectRegID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.InspectRegID, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspectRegID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ContractNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContractNo As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ContractNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.ContractNo, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ContractNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InspectionID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionID As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.InspectionID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.InspectionID, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspectionID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.SQFootage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SQFootage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames.SQFootage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(GRIPSSWorkloadMetadata.ColumnNames.SQFootage, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.SQFootage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Client1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client1 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Client1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Client1, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Client1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Client2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client2 As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Client2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Client2, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Client2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Occupancy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occupancy As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Occupancy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.Occupancy, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Occupancy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.FieldFileOffice
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FieldFileOffice As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.FieldFileOffice)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.FieldFileOffice, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.FieldFileOffice)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EngInspHours
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngInspHours As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngInspHours)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngInspHours, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngInspHours)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EngReportHours
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngReportHours As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngReportHours)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngReportHours, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngReportHours)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EngTravelHours
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngTravelHours As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngTravelHours)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngTravelHours, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngTravelHours)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EngOtherHours
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngOtherHours As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngOtherHours)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngOtherHours, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngOtherHours)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.InitialInspection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InitialInspection As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(GRIPSSWorkloadMetadata.ColumnNames.InitialInspection)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(GRIPSSWorkloadMetadata.ColumnNames.InitialInspection, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InitialInspection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Audit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Audit As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(GRIPSSWorkloadMetadata.ColumnNames.Audit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(GRIPSSWorkloadMetadata.ColumnNames.Audit, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Audit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Audit Type
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AuditType As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.AuditType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.AuditType, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.AuditType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.LastUpdated
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastUpdated As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.LastUpdated)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(GRIPSSWorkloadMetadata.ColumnNames.LastUpdated, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.LastUpdated)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(GRIPSSWorkloadMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GRIPSSWorkloadMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(GRIPSSWorkloadMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(GRIPSSWorkloadMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(GRIPSSWorkloadMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(GRIPSSWorkloadMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.EngineerId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EngineerId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngineerId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GRIPSSWorkloadMetadata.ColumnNames.EngineerId, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngineerId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.ExcludeCDB
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExcludeCDB As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(GRIPSSWorkloadMetadata.ColumnNames.ExcludeCDB)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(GRIPSSWorkloadMetadata.ColumnNames.ExcludeCDB, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ExcludeCDB)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GRIPSS-Workload.BingEnabled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BingEnabled As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(GRIPSSWorkloadMetadata.ColumnNames.BingEnabled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(GRIPSSWorkloadMetadata.ColumnNames.BingEnabled, value) Then
					OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.BingEnabled)
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
												
						Case "GripssRecordID"
							Me.str().GripssRecordID = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "Client"
							Me.str().Client = CType(value, string)
												
						Case "Parent"
							Me.str().Parent = CType(value, string)
												
						Case "ParentNo"
							Me.str().ParentNo = CType(value, string)
												
						Case "Abbr"
							Me.str().Abbr = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
												
						Case "Facility"
							Me.str().Facility = CType(value, string)
												
						Case "Address1"
							Me.str().Address1 = CType(value, string)
												
						Case "Address2"
							Me.str().Address2 = CType(value, string)
												
						Case "Address3"
							Me.str().Address3 = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "StProv"
							Me.str().StProv = CType(value, string)
												
						Case "StProvName"
							Me.str().StProvName = CType(value, string)
												
						Case "Zip"
							Me.str().Zip = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "County"
							Me.str().County = CType(value, string)
												
						Case "Phone1"
							Me.str().Phone1 = CType(value, string)
												
						Case "Fax"
							Me.str().Fax = CType(value, string)
												
						Case "ClientLocNo"
							Me.str().ClientLocNo = CType(value, string)
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
						Case "ContractYr"
							Me.str().ContractYr = CType(value, string)
												
						Case "AriseStatus"
							Me.str().AriseStatus = CType(value, string)
												
						Case "LocationStatus"
							Me.str().LocationStatus = CType(value, string)
												
						Case "Frequency"
							Me.str().Frequency = CType(value, string)
												
						Case "NextInspYr"
							Me.str().NextInspYr = CType(value, string)
												
						Case "District"
							Me.str().District = CType(value, string)
												
						Case "Region"
							Me.str().Region = CType(value, string)
												
						Case "InspPerFROM"
							Me.str().InspPerFROM = CType(value, string)
												
						Case "InspPerTO"
							Me.str().InspPerTO = CType(value, string)
												
						Case "ServicedBy"
							Me.str().ServicedBy = CType(value, string)
												
						Case "LocationComment"
							Me.str().LocationComment = CType(value, string)
												
						Case "SchedulingComment"
							Me.str().SchedulingComment = CType(value, string)
												
						Case "CancelDate"
							Me.str().CancelDate = CType(value, string)
												
						Case "CancelNote"
							Me.str().CancelNote = CType(value, string)
												
						Case "ReinstateDate"
							Me.str().ReinstateDate = CType(value, string)
												
						Case "ReinstateNote"
							Me.str().ReinstateNote = CType(value, string)
												
						Case "ContractOwnership"
							Me.str().ContractOwnership = CType(value, string)
												
						Case "InspDue"
							Me.str().InspDue = CType(value, string)
												
						Case "InspRemaining"
							Me.str().InspRemaining = CType(value, string)
												
						Case "LastYrInspection"
							Me.str().LastYrInspection = CType(value, string)
												
						Case "LastYrEngineer"
							Me.str().LastYrEngineer = CType(value, string)
												
						Case "InspectionStatus"
							Me.str().InspectionStatus = CType(value, string)
												
						Case "Engineer"
							Me.str().Engineer = CType(value, string)
												
						Case "DateCompleted"
							Me.str().DateCompleted = CType(value, string)
												
						Case "ClientTargetMo"
							Me.str().ClientTargetMo = CType(value, string)
												
						Case "EngTargetMo"
							Me.str().EngTargetMo = CType(value, string)
												
						Case "SchedFROM"
							Me.str().SchedFROM = CType(value, string)
												
						Case "SchedTO"
							Me.str().SchedTO = CType(value, string)
												
						Case "TripGroup"
							Me.str().TripGroup = CType(value, string)
												
						Case "Report1"
							Me.str().Report1 = CType(value, string)
												
						Case "Rpt1Procr"
							Me.str().Rpt1Procr = CType(value, string)
												
						Case "Rpt1Revwr"
							Me.str().Rpt1Revwr = CType(value, string)
												
						Case "Rpt1Client"
							Me.str().Rpt1Client = CType(value, string)
												
						Case "Report2"
							Me.str().Report2 = CType(value, string)
												
						Case "Rpt2Procr"
							Me.str().Rpt2Procr = CType(value, string)
												
						Case "Rpt2Revwr"
							Me.str().Rpt2Revwr = CType(value, string)
												
						Case "Rpt2Client"
							Me.str().Rpt2Client = CType(value, string)
												
						Case "Report3"
							Me.str().Report3 = CType(value, string)
												
						Case "Rpt3Procr"
							Me.str().Rpt3Procr = CType(value, string)
												
						Case "Rpt3Revwr"
							Me.str().Rpt3Revwr = CType(value, string)
												
						Case "Rpt3Client"
							Me.str().Rpt3Client = CType(value, string)
												
						Case "Report4"
							Me.str().Report4 = CType(value, string)
												
						Case "Rpt4Procr"
							Me.str().Rpt4Procr = CType(value, string)
												
						Case "Rpt4Revwr"
							Me.str().Rpt4Revwr = CType(value, string)
												
						Case "Rpt4Client"
							Me.str().Rpt4Client = CType(value, string)
												
						Case "DiagrSubm"
							Me.str().DiagrSubm = CType(value, string)
												
						Case "DiagrIssued"
							Me.str().DiagrIssued = CType(value, string)
												
						Case "EstInspHrs"
							Me.str().EstInspHrs = CType(value, string)
												
						Case "EstRptHrs"
							Me.str().EstRptHrs = CType(value, string)
												
						Case "EstTravelHrs"
							Me.str().EstTravelHrs = CType(value, string)
												
						Case "EstOtherHrs"
							Me.str().EstOtherHrs = CType(value, string)
												
						Case "TotalEstHrs"
							Me.str().TotalEstHrs = CType(value, string)
												
						Case "QuotInspHrs"
							Me.str().QuotInspHrs = CType(value, string)
												
						Case "QuotRptHrs"
							Me.str().QuotRptHrs = CType(value, string)
												
						Case "QuotTravelHrs"
							Me.str().QuotTravelHrs = CType(value, string)
												
						Case "QuotOtherHrs"
							Me.str().QuotOtherHrs = CType(value, string)
												
						Case "InspNotes"
							Me.str().InspNotes = CType(value, string)
												
						Case "EffectiveDate"
							Me.str().EffectiveDate = CType(value, string)
												
						Case "CurrencyCode"
							Me.str().CurrencyCode = CType(value, string)
												
						Case "PDBuilding"
							Me.str().PDBuilding = CType(value, string)
												
						Case "PDEquipment"
							Me.str().PDEquipment = CType(value, string)
												
						Case "PDFinished"
							Me.str().PDFinished = CType(value, string)
												
						Case "PDRawStock"
							Me.str().PDRawStock = CType(value, string)
												
						Case "PDBuildersRisk"
							Me.str().PDBuildersRisk = CType(value, string)
												
						Case "PDMisc"
							Me.str().PDMisc = CType(value, string)
												
						Case "PDTotal"
							Me.str().PDTotal = CType(value, string)
												
						Case "BIGrossProfit"
							Me.str().BIGrossProfit = CType(value, string)
												
						Case "BIWageExtraExp"
							Me.str().BIWageExtraExp = CType(value, string)
												
						Case "BIMisc"
							Me.str().BIMisc = CType(value, string)
												
						Case "BIOther"
							Me.str().BIOther = CType(value, string)
												
						Case "BITotal"
							Me.str().BITotal = CType(value, string)
												
						Case "GrossProfitIndemnity"
							Me.str().GrossProfitIndemnity = CType(value, string)
												
						Case "WagesExtraExpIndem"
							Me.str().WagesExtraExpIndem = CType(value, string)
												
						Case "TotalUSPD"
							Me.str().TotalUSPD = CType(value, string)
												
						Case "TotalUSBI"
							Me.str().TotalUSBI = CType(value, string)
												
						Case "TotalUSTIV"
							Me.str().TotalUSTIV = CType(value, string)
												
						Case "LocalTIV"
							Me.str().LocalTIV = CType(value, string)
												
						Case "Office"
							Me.str().Office = CType(value, string)
												
						Case "InspectRegID"
							Me.str().InspectRegID = CType(value, string)
												
						Case "ContractNo"
							Me.str().ContractNo = CType(value, string)
												
						Case "InspectionID"
							Me.str().InspectionID = CType(value, string)
												
						Case "_100PercentUSTot"
							Me.str()._100PercentUSTot = CType(value, string)
												
						Case "SQFootage"
							Me.str().SQFootage = CType(value, string)
												
						Case "Client1"
							Me.str().Client1 = CType(value, string)
												
						Case "Client2"
							Me.str().Client2 = CType(value, string)
												
						Case "Occupancy"
							Me.str().Occupancy = CType(value, string)
												
						Case "FieldFileOffice"
							Me.str().FieldFileOffice = CType(value, string)
												
						Case "EngInspHours"
							Me.str().EngInspHours = CType(value, string)
												
						Case "EngReportHours"
							Me.str().EngReportHours = CType(value, string)
												
						Case "EngTravelHours"
							Me.str().EngTravelHours = CType(value, string)
												
						Case "EngOtherHours"
							Me.str().EngOtherHours = CType(value, string)
												
						Case "InitialInspection"
							Me.str().InitialInspection = CType(value, string)
												
						Case "Audit"
							Me.str().Audit = CType(value, string)
												
						Case "AuditType"
							Me.str().AuditType = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "LastUpdated"
							Me.str().LastUpdated = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "EngineerId"
							Me.str().EngineerId = CType(value, string)
												
						Case "ExcludeCDB"
							Me.str().ExcludeCDB = CType(value, string)
												
						Case "BingEnabled"
							Me.str().BingEnabled = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GripssRecordID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GripssRecordID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.GripssRecordID)
							End If
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "ContractYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.ContractYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ContractYr)
							End If
						
						Case "NextInspYr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NextInspYr = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.NextInspYr)
							End If
						
						Case "InspPerFROM"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspPerFROM = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspPerFROM)
							End If
						
						Case "InspPerTO"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspPerTO = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspPerTO)
							End If
						
						Case "CancelDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CancelDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.CancelDate)
							End If
						
						Case "ReinstateDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ReinstateDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ReinstateDate)
							End If
						
						Case "InspDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspDue)
							End If
						
						Case "InspRemaining"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InspRemaining = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InspRemaining)
							End If
						
						Case "LastYrInspection"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastYrInspection = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.LastYrInspection)
							End If
						
						Case "DateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.DateCompleted)
							End If
						
						Case "ClientTargetMo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ClientTargetMo = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ClientTargetMo)
							End If
						
						Case "EngTargetMo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EngTargetMo = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngTargetMo)
							End If
						
						Case "SchedFROM"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedFROM = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.SchedFROM)
							End If
						
						Case "SchedTO"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SchedTO = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.SchedTO)
							End If
						
						Case "Rpt1Procr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt1Procr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt1Procr)
							End If
						
						Case "Rpt1Revwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt1Revwr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt1Revwr)
							End If
						
						Case "Rpt1Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt1Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt1Client)
							End If
						
						Case "Rpt2Procr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Procr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt2Procr)
							End If
						
						Case "Rpt2Revwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Revwr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt2Revwr)
							End If
						
						Case "Rpt2Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt2Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt2Client)
							End If
						
						Case "Rpt3Procr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt3Procr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt3Procr)
							End If
						
						Case "Rpt3Revwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt3Revwr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt3Revwr)
							End If
						
						Case "Rpt3Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt3Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt3Client)
							End If
						
						Case "Rpt4Procr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt4Procr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt4Procr)
							End If
						
						Case "Rpt4Revwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt4Revwr = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt4Revwr)
							End If
						
						Case "Rpt4Client"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rpt4Client = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Rpt4Client)
							End If
						
						Case "DiagrSubm"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DiagrSubm = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.DiagrSubm)
							End If
						
						Case "DiagrIssued"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DiagrIssued = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.DiagrIssued)
							End If
						
						Case "EstInspHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Single" Then
								Me.EstInspHrs = CType(value, Nullable(Of System.Single))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EstInspHrs)
							End If
						
						Case "EstRptHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Single" Then
								Me.EstRptHrs = CType(value, Nullable(Of System.Single))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EstRptHrs)
							End If
						
						Case "EstTravelHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Single" Then
								Me.EstTravelHrs = CType(value, Nullable(Of System.Single))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EstTravelHrs)
							End If
						
						Case "EstOtherHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Single" Then
								Me.EstOtherHrs = CType(value, Nullable(Of System.Single))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EstOtherHrs)
							End If
						
						Case "TotalEstHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotalEstHrs = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.TotalEstHrs)
							End If
						
						Case "QuotInspHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Single" Then
								Me.QuotInspHrs = CType(value, Nullable(Of System.Single))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.QuotInspHrs)
							End If
						
						Case "QuotRptHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Single" Then
								Me.QuotRptHrs = CType(value, Nullable(Of System.Single))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.QuotRptHrs)
							End If
						
						Case "QuotTravelHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Single" Then
								Me.QuotTravelHrs = CType(value, Nullable(Of System.Single))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.QuotTravelHrs)
							End If
						
						Case "QuotOtherHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Single" Then
								Me.QuotOtherHrs = CType(value, Nullable(Of System.Single))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.QuotOtherHrs)
							End If
						
						Case "EffectiveDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EffectiveDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EffectiveDate)
							End If
						
						Case "GrossProfitIndemnity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.GrossProfitIndemnity = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.GrossProfitIndemnity)
							End If
						
						Case "WagesExtraExpIndem"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.WagesExtraExpIndem = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.WagesExtraExpIndem)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "SQFootage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.SQFootage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.SQFootage)
							End If
						
						Case "EngInspHours"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EngInspHours = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngInspHours)
							End If
						
						Case "EngReportHours"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EngReportHours = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngReportHours)
							End If
						
						Case "EngTravelHours"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EngTravelHours = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngTravelHours)
							End If
						
						Case "EngOtherHours"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EngOtherHours = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngOtherHours)
							End If
						
						Case "InitialInspection"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.InitialInspection = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.InitialInspection)
							End If
						
						Case "Audit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Audit = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Audit)
							End If
						
						Case "LastUpdated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastUpdated = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.LastUpdated)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.Longitude)
							End If
						
						Case "EngineerId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EngineerId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.EngineerId)
							End If
						
						Case "ExcludeCDB"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ExcludeCDB = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.ExcludeCDB)
							End If
						
						Case "BingEnabled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.BingEnabled = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(GRIPSSWorkloadMetadata.PropertyNames.BingEnabled)
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
		
			Public Sub New(ByVal entity As esGRIPSSWorkload)
				Me.entity = entity
			End Sub				
		
	
			Public Property GripssRecordID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.GripssRecordID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GripssRecordID = Nothing
					Else
						entity.GripssRecordID = Convert.ToInt32(Value)
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
		  	
			Public Property Parent As System.String 
				Get
					Dim data_ As System.String = entity.Parent
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Parent = Nothing
					Else
						entity.Parent = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ParentNo As System.String 
				Get
					Dim data_ As System.String = entity.ParentNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ParentNo = Nothing
					Else
						entity.ParentNo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Abbr As System.String 
				Get
					Dim data_ As System.String = entity.Abbr
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Abbr = Nothing
					Else
						entity.Abbr = Convert.ToString(Value)
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
		  	
			Public Property Address2 As System.String 
				Get
					Dim data_ As System.String = entity.Address2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address2 = Nothing
					Else
						entity.Address2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Address3 As System.String 
				Get
					Dim data_ As System.String = entity.Address3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address3 = Nothing
					Else
						entity.Address3 = Convert.ToString(Value)
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
		  	
			Public Property County As System.String 
				Get
					Dim data_ As System.String = entity.County
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.County = Nothing
					Else
						entity.County = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phone1 As System.String 
				Get
					Dim data_ As System.String = entity.Phone1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phone1 = Nothing
					Else
						entity.Phone1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fax As System.String 
				Get
					Dim data_ As System.String = entity.Fax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fax = Nothing
					Else
						entity.Fax = Convert.ToString(Value)
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
		  	
			Public Property PracticeCode As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.PracticeCode
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeCode = Nothing
					Else
						entity.PracticeCode = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContractYr As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.ContractYr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContractYr = Nothing
					Else
						entity.ContractYr = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property AriseStatus As System.String 
				Get
					Dim data_ As System.String = entity.AriseStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AriseStatus = Nothing
					Else
						entity.AriseStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationStatus As System.String 
				Get
					Dim data_ As System.String = entity.LocationStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationStatus = Nothing
					Else
						entity.LocationStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Frequency As System.String 
				Get
					Dim data_ As System.String = entity.Frequency
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Frequency = Nothing
					Else
						entity.Frequency = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NextInspYr As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.NextInspYr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NextInspYr = Nothing
					Else
						entity.NextInspYr = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property District As System.String 
				Get
					Dim data_ As System.String = entity.District
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.District = Nothing
					Else
						entity.District = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Region As System.String 
				Get
					Dim data_ As System.String = entity.Region
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Region = Nothing
					Else
						entity.Region = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspPerFROM As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspPerFROM
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspPerFROM = Nothing
					Else
						entity.InspPerFROM = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspPerTO As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspPerTO
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspPerTO = Nothing
					Else
						entity.InspPerTO = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ServicedBy As System.String 
				Get
					Dim data_ As System.String = entity.ServicedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ServicedBy = Nothing
					Else
						entity.ServicedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationComment As System.String 
				Get
					Dim data_ As System.String = entity.LocationComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationComment = Nothing
					Else
						entity.LocationComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedulingComment As System.String 
				Get
					Dim data_ As System.String = entity.SchedulingComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedulingComment = Nothing
					Else
						entity.SchedulingComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CancelDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CancelDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CancelDate = Nothing
					Else
						entity.CancelDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CancelNote As System.String 
				Get
					Dim data_ As System.String = entity.CancelNote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CancelNote = Nothing
					Else
						entity.CancelNote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReinstateDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ReinstateDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReinstateDate = Nothing
					Else
						entity.ReinstateDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReinstateNote As System.String 
				Get
					Dim data_ As System.String = entity.ReinstateNote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReinstateNote = Nothing
					Else
						entity.ReinstateNote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContractOwnership As System.String 
				Get
					Dim data_ As System.String = entity.ContractOwnership
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContractOwnership = Nothing
					Else
						entity.ContractOwnership = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspDue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InspDue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspDue = Nothing
					Else
						entity.InspDue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspRemaining As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InspRemaining
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspRemaining = Nothing
					Else
						entity.InspRemaining = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastYrInspection As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastYrInspection
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastYrInspection = Nothing
					Else
						entity.LastYrInspection = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastYrEngineer As System.String 
				Get
					Dim data_ As System.String = entity.LastYrEngineer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastYrEngineer = Nothing
					Else
						entity.LastYrEngineer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionStatus As System.String 
				Get
					Dim data_ As System.String = entity.InspectionStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionStatus = Nothing
					Else
						entity.InspectionStatus = Convert.ToString(Value)
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
		  	
			Public Property DateCompleted As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateCompleted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateCompleted = Nothing
					Else
						entity.DateCompleted = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ClientTargetMo As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ClientTargetMo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClientTargetMo = Nothing
					Else
						entity.ClientTargetMo = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property EngTargetMo As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.EngTargetMo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EngTargetMo = Nothing
					Else
						entity.EngTargetMo = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedFROM As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SchedFROM
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedFROM = Nothing
					Else
						entity.SchedFROM = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedTO As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SchedTO
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedTO = Nothing
					Else
						entity.SchedTO = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property TripGroup As System.String 
				Get
					Dim data_ As System.String = entity.TripGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TripGroup = Nothing
					Else
						entity.TripGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Report1 As System.String 
				Get
					Dim data_ As System.String = entity.Report1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Report1 = Nothing
					Else
						entity.Report1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt1Procr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt1Procr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt1Procr = Nothing
					Else
						entity.Rpt1Procr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt1Revwr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt1Revwr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt1Revwr = Nothing
					Else
						entity.Rpt1Revwr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt1Client As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt1Client
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt1Client = Nothing
					Else
						entity.Rpt1Client = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Report2 As System.String 
				Get
					Dim data_ As System.String = entity.Report2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Report2 = Nothing
					Else
						entity.Report2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt2Procr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt2Procr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt2Procr = Nothing
					Else
						entity.Rpt2Procr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt2Revwr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt2Revwr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt2Revwr = Nothing
					Else
						entity.Rpt2Revwr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt2Client As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt2Client
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt2Client = Nothing
					Else
						entity.Rpt2Client = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Report3 As System.String 
				Get
					Dim data_ As System.String = entity.Report3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Report3 = Nothing
					Else
						entity.Report3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt3Procr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt3Procr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt3Procr = Nothing
					Else
						entity.Rpt3Procr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt3Revwr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt3Revwr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt3Revwr = Nothing
					Else
						entity.Rpt3Revwr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt3Client As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt3Client
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt3Client = Nothing
					Else
						entity.Rpt3Client = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Report4 As System.String 
				Get
					Dim data_ As System.String = entity.Report4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Report4 = Nothing
					Else
						entity.Report4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt4Procr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt4Procr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt4Procr = Nothing
					Else
						entity.Rpt4Procr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt4Revwr As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt4Revwr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt4Revwr = Nothing
					Else
						entity.Rpt4Revwr = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rpt4Client As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rpt4Client
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rpt4Client = Nothing
					Else
						entity.Rpt4Client = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DiagrSubm As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DiagrSubm
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DiagrSubm = Nothing
					Else
						entity.DiagrSubm = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DiagrIssued As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DiagrIssued
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DiagrIssued = Nothing
					Else
						entity.DiagrIssued = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property EstInspHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Single) = entity.EstInspHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EstInspHrs = Nothing
					Else
						entity.EstInspHrs = Convert.ToSingle(Value)
					End If
				End Set
			End Property
		  	
			Public Property EstRptHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Single) = entity.EstRptHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EstRptHrs = Nothing
					Else
						entity.EstRptHrs = Convert.ToSingle(Value)
					End If
				End Set
			End Property
		  	
			Public Property EstTravelHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Single) = entity.EstTravelHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EstTravelHrs = Nothing
					Else
						entity.EstTravelHrs = Convert.ToSingle(Value)
					End If
				End Set
			End Property
		  	
			Public Property EstOtherHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Single) = entity.EstOtherHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EstOtherHrs = Nothing
					Else
						entity.EstOtherHrs = Convert.ToSingle(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalEstHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TotalEstHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalEstHrs = Nothing
					Else
						entity.TotalEstHrs = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property QuotInspHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Single) = entity.QuotInspHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuotInspHrs = Nothing
					Else
						entity.QuotInspHrs = Convert.ToSingle(Value)
					End If
				End Set
			End Property
		  	
			Public Property QuotRptHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Single) = entity.QuotRptHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuotRptHrs = Nothing
					Else
						entity.QuotRptHrs = Convert.ToSingle(Value)
					End If
				End Set
			End Property
		  	
			Public Property QuotTravelHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Single) = entity.QuotTravelHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuotTravelHrs = Nothing
					Else
						entity.QuotTravelHrs = Convert.ToSingle(Value)
					End If
				End Set
			End Property
		  	
			Public Property QuotOtherHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Single) = entity.QuotOtherHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuotOtherHrs = Nothing
					Else
						entity.QuotOtherHrs = Convert.ToSingle(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspNotes As System.String 
				Get
					Dim data_ As System.String = entity.InspNotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspNotes = Nothing
					Else
						entity.InspNotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EffectiveDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.EffectiveDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EffectiveDate = Nothing
					Else
						entity.EffectiveDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CurrencyCode As System.String 
				Get
					Dim data_ As System.String = entity.CurrencyCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CurrencyCode = Nothing
					Else
						entity.CurrencyCode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDBuilding As System.String 
				Get
					Dim data_ As System.String = entity.PDBuilding
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDBuilding = Nothing
					Else
						entity.PDBuilding = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDEquipment As System.String 
				Get
					Dim data_ As System.String = entity.PDEquipment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDEquipment = Nothing
					Else
						entity.PDEquipment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDFinished As System.String 
				Get
					Dim data_ As System.String = entity.PDFinished
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDFinished = Nothing
					Else
						entity.PDFinished = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDRawStock As System.String 
				Get
					Dim data_ As System.String = entity.PDRawStock
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDRawStock = Nothing
					Else
						entity.PDRawStock = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDBuildersRisk As System.String 
				Get
					Dim data_ As System.String = entity.PDBuildersRisk
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDBuildersRisk = Nothing
					Else
						entity.PDBuildersRisk = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDMisc As System.String 
				Get
					Dim data_ As System.String = entity.PDMisc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDMisc = Nothing
					Else
						entity.PDMisc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PDTotal As System.String 
				Get
					Dim data_ As System.String = entity.PDTotal
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PDTotal = Nothing
					Else
						entity.PDTotal = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIGrossProfit As System.String 
				Get
					Dim data_ As System.String = entity.BIGrossProfit
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIGrossProfit = Nothing
					Else
						entity.BIGrossProfit = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIWageExtraExp As System.String 
				Get
					Dim data_ As System.String = entity.BIWageExtraExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIWageExtraExp = Nothing
					Else
						entity.BIWageExtraExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIMisc As System.String 
				Get
					Dim data_ As System.String = entity.BIMisc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIMisc = Nothing
					Else
						entity.BIMisc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BIOther As System.String 
				Get
					Dim data_ As System.String = entity.BIOther
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BIOther = Nothing
					Else
						entity.BIOther = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BITotal As System.String 
				Get
					Dim data_ As System.String = entity.BITotal
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BITotal = Nothing
					Else
						entity.BITotal = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GrossProfitIndemnity As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.GrossProfitIndemnity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GrossProfitIndemnity = Nothing
					Else
						entity.GrossProfitIndemnity = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property WagesExtraExpIndem As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.WagesExtraExpIndem
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WagesExtraExpIndem = Nothing
					Else
						entity.WagesExtraExpIndem = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalUSPD As System.String 
				Get
					Dim data_ As System.String = entity.TotalUSPD
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalUSPD = Nothing
					Else
						entity.TotalUSPD = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalUSBI As System.String 
				Get
					Dim data_ As System.String = entity.TotalUSBI
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalUSBI = Nothing
					Else
						entity.TotalUSBI = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalUSTIV As System.String 
				Get
					Dim data_ As System.String = entity.TotalUSTIV
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalUSTIV = Nothing
					Else
						entity.TotalUSTIV = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocalTIV As System.String 
				Get
					Dim data_ As System.String = entity.LocalTIV
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocalTIV = Nothing
					Else
						entity.LocalTIV = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Office As System.String 
				Get
					Dim data_ As System.String = entity.Office
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Office = Nothing
					Else
						entity.Office = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectRegID As System.String 
				Get
					Dim data_ As System.String = entity.InspectRegID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectRegID = Nothing
					Else
						entity.InspectRegID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContractNo As System.String 
				Get
					Dim data_ As System.String = entity.ContractNo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContractNo = Nothing
					Else
						entity.ContractNo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionID As System.String 
				Get
					Dim data_ As System.String = entity.InspectionID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionID = Nothing
					Else
						entity.InspectionID = Convert.ToString(Value)
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
		  	
			Public Property SQFootage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.SQFootage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SQFootage = Nothing
					Else
						entity.SQFootage = Convert.ToDouble(Value)
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
		  	
			Public Property Client2 As System.String 
				Get
					Dim data_ As System.String = entity.Client2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Client2 = Nothing
					Else
						entity.Client2 = Convert.ToString(Value)
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
		  	
			Public Property FieldFileOffice As System.String 
				Get
					Dim data_ As System.String = entity.FieldFileOffice
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FieldFileOffice = Nothing
					Else
						entity.FieldFileOffice = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EngInspHours As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EngInspHours
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EngInspHours = Nothing
					Else
						entity.EngInspHours = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EngReportHours As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EngReportHours
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EngReportHours = Nothing
					Else
						entity.EngReportHours = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EngTravelHours As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EngTravelHours
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EngTravelHours = Nothing
					Else
						entity.EngTravelHours = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EngOtherHours As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EngOtherHours
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EngOtherHours = Nothing
					Else
						entity.EngOtherHours = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property InitialInspection As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.InitialInspection
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InitialInspection = Nothing
					Else
						entity.InitialInspection = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Audit As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Audit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Audit = Nothing
					Else
						entity.Audit = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property AuditType As System.String 
				Get
					Dim data_ As System.String = entity.AuditType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AuditType = Nothing
					Else
						entity.AuditType = Convert.ToString(Value)
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
		  	
			Public Property LastUpdated As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastUpdated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastUpdated = Nothing
					Else
						entity.LastUpdated = Convert.ToDateTime(Value)
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
		  	
			Public Property EngineerId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EngineerId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EngineerId = Nothing
					Else
						entity.EngineerId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExcludeCDB As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ExcludeCDB
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExcludeCDB = Nothing
					Else
						entity.ExcludeCDB = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property BingEnabled As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.BingEnabled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BingEnabled = Nothing
					Else
						entity.BingEnabled = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esGRIPSSWorkload
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GRIPSSWorkloadMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As GRIPSSWorkloadQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GRIPSSWorkloadQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As GRIPSSWorkloadQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As GRIPSSWorkloadQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As GRIPSSWorkloadQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esGRIPSSWorkloadCollection
		Inherits esEntityCollection(Of GRIPSSWorkload)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GRIPSSWorkloadMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "GRIPSSWorkloadCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As GRIPSSWorkloadQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GRIPSSWorkloadQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As GRIPSSWorkloadQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New GRIPSSWorkloadQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As GRIPSSWorkloadQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, GRIPSSWorkloadQuery))
		End Sub
		
		#End Region
						
		Private m_query As GRIPSSWorkloadQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esGRIPSSWorkloadQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GRIPSSWorkloadMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GripssRecordID" 
					Return Me.GripssRecordID
				Case "FileNo" 
					Return Me.FileNo
				Case "Client" 
					Return Me.Client
				Case "Parent" 
					Return Me.Parent
				Case "ParentNo" 
					Return Me.ParentNo
				Case "Abbr" 
					Return Me.Abbr
				Case "Division" 
					Return Me.Division
				Case "Facility" 
					Return Me.Facility
				Case "Address1" 
					Return Me.Address1
				Case "Address2" 
					Return Me.Address2
				Case "Address3" 
					Return Me.Address3
				Case "City" 
					Return Me.City
				Case "StProv" 
					Return Me.StProv
				Case "StProvName" 
					Return Me.StProvName
				Case "Zip" 
					Return Me.Zip
				Case "Country" 
					Return Me.Country
				Case "County" 
					Return Me.County
				Case "Phone1" 
					Return Me.Phone1
				Case "Fax" 
					Return Me.Fax
				Case "ClientLocNo" 
					Return Me.ClientLocNo
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "ContractYr" 
					Return Me.ContractYr
				Case "AriseStatus" 
					Return Me.AriseStatus
				Case "LocationStatus" 
					Return Me.LocationStatus
				Case "Frequency" 
					Return Me.Frequency
				Case "NextInspYr" 
					Return Me.NextInspYr
				Case "District" 
					Return Me.District
				Case "Region" 
					Return Me.Region
				Case "InspPerFROM" 
					Return Me.InspPerFROM
				Case "InspPerTO" 
					Return Me.InspPerTO
				Case "ServicedBy" 
					Return Me.ServicedBy
				Case "LocationComment" 
					Return Me.LocationComment
				Case "SchedulingComment" 
					Return Me.SchedulingComment
				Case "CancelDate" 
					Return Me.CancelDate
				Case "CancelNote" 
					Return Me.CancelNote
				Case "ReinstateDate" 
					Return Me.ReinstateDate
				Case "ReinstateNote" 
					Return Me.ReinstateNote
				Case "ContractOwnership" 
					Return Me.ContractOwnership
				Case "InspDue" 
					Return Me.InspDue
				Case "InspRemaining" 
					Return Me.InspRemaining
				Case "LastYrInspection" 
					Return Me.LastYrInspection
				Case "LastYrEngineer" 
					Return Me.LastYrEngineer
				Case "InspectionStatus" 
					Return Me.InspectionStatus
				Case "Engineer" 
					Return Me.Engineer
				Case "DateCompleted" 
					Return Me.DateCompleted
				Case "ClientTargetMo" 
					Return Me.ClientTargetMo
				Case "EngTargetMo" 
					Return Me.EngTargetMo
				Case "SchedFROM" 
					Return Me.SchedFROM
				Case "SchedTO" 
					Return Me.SchedTO
				Case "TripGroup" 
					Return Me.TripGroup
				Case "Report1" 
					Return Me.Report1
				Case "Rpt1Procr" 
					Return Me.Rpt1Procr
				Case "Rpt1Revwr" 
					Return Me.Rpt1Revwr
				Case "Rpt1Client" 
					Return Me.Rpt1Client
				Case "Report2" 
					Return Me.Report2
				Case "Rpt2Procr" 
					Return Me.Rpt2Procr
				Case "Rpt2Revwr" 
					Return Me.Rpt2Revwr
				Case "Rpt2Client" 
					Return Me.Rpt2Client
				Case "Report3" 
					Return Me.Report3
				Case "Rpt3Procr" 
					Return Me.Rpt3Procr
				Case "Rpt3Revwr" 
					Return Me.Rpt3Revwr
				Case "Rpt3Client" 
					Return Me.Rpt3Client
				Case "Report4" 
					Return Me.Report4
				Case "Rpt4Procr" 
					Return Me.Rpt4Procr
				Case "Rpt4Revwr" 
					Return Me.Rpt4Revwr
				Case "Rpt4Client" 
					Return Me.Rpt4Client
				Case "DiagrSubm" 
					Return Me.DiagrSubm
				Case "DiagrIssued" 
					Return Me.DiagrIssued
				Case "EstInspHrs" 
					Return Me.EstInspHrs
				Case "EstRptHrs" 
					Return Me.EstRptHrs
				Case "EstTravelHrs" 
					Return Me.EstTravelHrs
				Case "EstOtherHrs" 
					Return Me.EstOtherHrs
				Case "TotalEstHrs" 
					Return Me.TotalEstHrs
				Case "QuotInspHrs" 
					Return Me.QuotInspHrs
				Case "QuotRptHrs" 
					Return Me.QuotRptHrs
				Case "QuotTravelHrs" 
					Return Me.QuotTravelHrs
				Case "QuotOtherHrs" 
					Return Me.QuotOtherHrs
				Case "InspNotes" 
					Return Me.InspNotes
				Case "EffectiveDate" 
					Return Me.EffectiveDate
				Case "CurrencyCode" 
					Return Me.CurrencyCode
				Case "PDBuilding" 
					Return Me.PDBuilding
				Case "PDEquipment" 
					Return Me.PDEquipment
				Case "PDFinished" 
					Return Me.PDFinished
				Case "PDRawStock" 
					Return Me.PDRawStock
				Case "PDBuildersRisk" 
					Return Me.PDBuildersRisk
				Case "PDMisc" 
					Return Me.PDMisc
				Case "PDTotal" 
					Return Me.PDTotal
				Case "BIGrossProfit" 
					Return Me.BIGrossProfit
				Case "BIWageExtraExp" 
					Return Me.BIWageExtraExp
				Case "BIMisc" 
					Return Me.BIMisc
				Case "BIOther" 
					Return Me.BIOther
				Case "BITotal" 
					Return Me.BITotal
				Case "GrossProfitIndemnity" 
					Return Me.GrossProfitIndemnity
				Case "WagesExtraExpIndem" 
					Return Me.WagesExtraExpIndem
				Case "TotalUSPD" 
					Return Me.TotalUSPD
				Case "TotalUSBI" 
					Return Me.TotalUSBI
				Case "TotalUSTIV" 
					Return Me.TotalUSTIV
				Case "LocalTIV" 
					Return Me.LocalTIV
				Case "Office" 
					Return Me.Office
				Case "InspectRegID" 
					Return Me.InspectRegID
				Case "ContractNo" 
					Return Me.ContractNo
				Case "InspectionID" 
					Return Me.InspectionID
				Case "_100PercentUSTot" 
					Return Me._100PercentUSTot
				Case "SQFootage" 
					Return Me.SQFootage
				Case "Client1" 
					Return Me.Client1
				Case "Client2" 
					Return Me.Client2
				Case "Occupancy" 
					Return Me.Occupancy
				Case "FieldFileOffice" 
					Return Me.FieldFileOffice
				Case "EngInspHours" 
					Return Me.EngInspHours
				Case "EngReportHours" 
					Return Me.EngReportHours
				Case "EngTravelHours" 
					Return Me.EngTravelHours
				Case "EngOtherHours" 
					Return Me.EngOtherHours
				Case "InitialInspection" 
					Return Me.InitialInspection
				Case "Audit" 
					Return Me.Audit
				Case "AuditType" 
					Return Me.AuditType
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "LastUpdated" 
					Return Me.LastUpdated
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "Latitude" 
					Return Me.Latitude
				Case "Longitude" 
					Return Me.Longitude
				Case "EngineerId" 
					Return Me.EngineerId
				Case "ExcludeCDB" 
					Return Me.ExcludeCDB
				Case "BingEnabled" 
					Return Me.BingEnabled
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property GripssRecordID As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.GripssRecordID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Parent As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Parent, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ParentNo As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ParentNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Abbr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Abbr, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address2 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Address2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address3 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Address3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProv As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.StProv, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StProvName As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.StProvName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property County As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.County, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone1 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Phone1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientLocNo As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ClientLocNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property ContractYr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ContractYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property AriseStatus As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.AriseStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationStatus As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.LocationStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Frequency As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Frequency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NextInspYr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.NextInspYr, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property District As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.District, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Region As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Region, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspPerFROM As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InspPerFROM, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InspPerTO As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InspPerTO, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ServicedBy As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ServicedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationComment As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.LocationComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedulingComment As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.SchedulingComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CancelDate As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.CancelDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CancelNote As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.CancelNote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReinstateDate As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ReinstateDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ReinstateNote As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ReinstateNote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContractOwnership As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ContractOwnership, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspDue As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InspDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InspRemaining As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InspRemaining, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LastYrInspection As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.LastYrInspection, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastYrEngineer As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.LastYrEngineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionStatus As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InspectionStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Engineer As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Engineer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.DateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ClientTargetMo As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ClientTargetMo, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property EngTargetMo As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EngTargetMo, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SchedFROM As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.SchedFROM, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SchedTO As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.SchedTO, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property TripGroup As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.TripGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Report1 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Report1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt1Procr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt1Procr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt1Revwr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt1Revwr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt1Client As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt1Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Report2 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Report2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Procr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt2Procr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Revwr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt2Revwr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt2Client As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt2Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Report3 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Report3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt3Procr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt3Procr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt3Revwr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt3Revwr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt3Client As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt3Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Report4 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Report4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt4Procr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt4Procr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt4Revwr As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt4Revwr, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rpt4Client As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Rpt4Client, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DiagrSubm As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.DiagrSubm, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DiagrIssued As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.DiagrIssued, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property EstInspHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EstInspHrs, esSystemType.Single)
			End Get
		End Property 
		
		Public ReadOnly Property EstRptHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EstRptHrs, esSystemType.Single)
			End Get
		End Property 
		
		Public ReadOnly Property EstTravelHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EstTravelHrs, esSystemType.Single)
			End Get
		End Property 
		
		Public ReadOnly Property EstOtherHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EstOtherHrs, esSystemType.Single)
			End Get
		End Property 
		
		Public ReadOnly Property TotalEstHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.TotalEstHrs, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property QuotInspHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.QuotInspHrs, esSystemType.Single)
			End Get
		End Property 
		
		Public ReadOnly Property QuotRptHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.QuotRptHrs, esSystemType.Single)
			End Get
		End Property 
		
		Public ReadOnly Property QuotTravelHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.QuotTravelHrs, esSystemType.Single)
			End Get
		End Property 
		
		Public ReadOnly Property QuotOtherHrs As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.QuotOtherHrs, esSystemType.Single)
			End Get
		End Property 
		
		Public ReadOnly Property InspNotes As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InspNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EffectiveDate As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EffectiveDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CurrencyCode As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.CurrencyCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDBuilding As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.PDBuilding, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDEquipment As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.PDEquipment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDFinished As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.PDFinished, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDRawStock As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.PDRawStock, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDBuildersRisk As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.PDBuildersRisk, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDMisc As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.PDMisc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PDTotal As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.PDTotal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIGrossProfit As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.BIGrossProfit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIWageExtraExp As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.BIWageExtraExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIMisc As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.BIMisc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BIOther As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.BIOther, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BITotal As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.BITotal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GrossProfitIndemnity As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.GrossProfitIndemnity, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property WagesExtraExpIndem As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.WagesExtraExpIndem, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSPD As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.TotalUSPD, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSBI As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.TotalUSBI, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalUSTIV As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.TotalUSTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocalTIV As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.LocalTIV, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Office As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Office, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectRegID As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InspectRegID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContractNo As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ContractNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionID As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InspectionID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property SQFootage As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.SQFootage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Client1 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Client1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client2 As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Client2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occupancy As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Occupancy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FieldFileOffice As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.FieldFileOffice, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EngInspHours As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EngInspHours, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EngReportHours As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EngReportHours, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EngTravelHours As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EngTravelHours, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EngOtherHours As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EngOtherHours, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InitialInspection As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.InitialInspection, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Audit As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Audit, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property AuditType As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.AuditType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastUpdated As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.LastUpdated, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property EngineerId As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.EngineerId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExcludeCDB As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.ExcludeCDB, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property BingEnabled As esQueryItem
			Get
				Return New esQueryItem(Me, GRIPSSWorkloadMetadata.ColumnNames.BingEnabled, esSystemType.Boolean)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class GRIPSSWorkloadMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.GripssRecordID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.GripssRecordID
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Parent, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Parent
			c.CharacterMaxLength = 35
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ParentNo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ParentNo
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Abbr, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Abbr
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Division, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Division
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Facility, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Address1, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Address2, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Address2
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Address3, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Address3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.City, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.StProv, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.StProv
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.StProvName, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.StProvName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Zip, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Country, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.County, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.County
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Phone1, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Phone1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Fax, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Fax
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ClientLocNo, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ClientLocNo
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.PracticeCode, 20, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ContractYr, 21, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ContractYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.AriseStatus, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.AriseStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.LocationStatus, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.LocationStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Frequency, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Frequency
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.NextInspYr, 25, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.NextInspYr
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.District, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.District
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Region, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Region
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InspPerFROM, 28, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InspPerFROM
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InspPerTO, 29, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InspPerTO
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ServicedBy, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ServicedBy
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.LocationComment, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.LocationComment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.SchedulingComment, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.SchedulingComment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.CancelDate, 33, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.CancelDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.CancelNote, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.CancelNote
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ReinstateDate, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ReinstateDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ReinstateNote, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ReinstateNote
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ContractOwnership, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ContractOwnership
			c.CharacterMaxLength = 8
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InspDue, 38, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InspDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InspRemaining, 39, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InspRemaining
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.LastYrInspection, 40, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.LastYrInspection
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.LastYrEngineer, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.LastYrEngineer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InspectionStatus, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InspectionStatus
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Engineer, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Engineer
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.DateCompleted, 44, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.DateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ClientTargetMo, 45, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ClientTargetMo
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EngTargetMo, 46, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EngTargetMo
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.SchedFROM, 47, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.SchedFROM
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.SchedTO, 48, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.SchedTO
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.TripGroup, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.TripGroup
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Report1, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Report1
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Procr, 51, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt1Procr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Revwr, 52, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt1Revwr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt1Client, 53, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt1Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Report2, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Report2
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Procr, 55, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt2Procr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Revwr, 56, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt2Revwr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt2Client, 57, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt2Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Report3, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Report3
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Procr, 59, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt3Procr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Revwr, 60, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt3Revwr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt3Client, 61, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt3Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Report4, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Report4
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Procr, 63, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt4Procr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Revwr, 64, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt4Revwr
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Rpt4Client, 65, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Rpt4Client
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.DiagrSubm, 66, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.DiagrSubm
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.DiagrIssued, 67, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.DiagrIssued
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EstInspHrs, 68, GetType(System.Single), esSystemType.Single)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EstInspHrs
			c.NumericPrecision = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EstRptHrs, 69, GetType(System.Single), esSystemType.Single)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EstRptHrs
			c.NumericPrecision = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EstTravelHrs, 70, GetType(System.Single), esSystemType.Single)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EstTravelHrs
			c.NumericPrecision = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EstOtherHrs, 71, GetType(System.Single), esSystemType.Single)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EstOtherHrs
			c.NumericPrecision = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.TotalEstHrs, 72, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.TotalEstHrs
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.QuotInspHrs, 73, GetType(System.Single), esSystemType.Single)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.QuotInspHrs
			c.NumericPrecision = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.QuotRptHrs, 74, GetType(System.Single), esSystemType.Single)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.QuotRptHrs
			c.NumericPrecision = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.QuotTravelHrs, 75, GetType(System.Single), esSystemType.Single)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.QuotTravelHrs
			c.NumericPrecision = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.QuotOtherHrs, 76, GetType(System.Single), esSystemType.Single)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.QuotOtherHrs
			c.NumericPrecision = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InspNotes, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InspNotes
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EffectiveDate, 78, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EffectiveDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.CurrencyCode, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.CurrencyCode
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.PDBuilding, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.PDBuilding
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.PDEquipment, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.PDEquipment
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.PDFinished, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.PDFinished
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.PDRawStock, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.PDRawStock
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.PDBuildersRisk, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.PDBuildersRisk
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.PDMisc, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.PDMisc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.PDTotal, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.PDTotal
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.BIGrossProfit, 87, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.BIGrossProfit
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.BIWageExtraExp, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.BIWageExtraExp
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.BIMisc, 89, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.BIMisc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.BIOther, 90, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.BIOther
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.BITotal, 91, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.BITotal
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.GrossProfitIndemnity, 92, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.GrossProfitIndemnity
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.WagesExtraExpIndem, 93, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.WagesExtraExpIndem
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.TotalUSPD, 94, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.TotalUSPD
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.TotalUSBI, 95, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.TotalUSBI
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.TotalUSTIV, 96, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.TotalUSTIV
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.LocalTIV, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.LocalTIV
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Office, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Office
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InspectRegID, 99, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InspectRegID
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ContractNo, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ContractNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InspectionID, 101, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InspectionID
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames._100PercentUSTot, 102, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.SQFootage, 103, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.SQFootage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Client1, 104, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Client1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Client2, 105, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Client2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Occupancy, 106, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Occupancy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.FieldFileOffice, 107, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.FieldFileOffice
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EngInspHours, 108, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EngInspHours
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EngReportHours, 109, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EngReportHours
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EngTravelHours, 110, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EngTravelHours
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EngOtherHours, 111, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EngOtherHours
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.InitialInspection, 112, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.InitialInspection
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Audit, 113, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Audit
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.AuditType, 114, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.AuditType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.CustomAccess, 115, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.LastUpdated, 116, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.LastUpdated
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.FilePrefix, 117, GetType(System.String), esSystemType.String)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Latitude, 118, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.Longitude, 119, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.EngineerId, 120, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.EngineerId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.ExcludeCDB, 121, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.ExcludeCDB
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GRIPSSWorkloadMetadata.ColumnNames.BingEnabled, 122, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = GRIPSSWorkloadMetadata.PropertyNames.BingEnabled
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As GRIPSSWorkloadMetadata
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
			 Public Const GripssRecordID As String = "GripssRecordID"
			 Public Const FileNo As String = "FileNo"
			 Public Const Client As String = "Client"
			 Public Const Parent As String = "Parent"
			 Public Const ParentNo As String = "ParentNo"
			 Public Const Abbr As String = "Abbr"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const Address1 As String = "Address1"
			 Public Const Address2 As String = "Address2"
			 Public Const Address3 As String = "Address3"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const StProvName As String = "StProvName"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const County As String = "County"
			 Public Const Phone1 As String = "PHONE1"
			 Public Const Fax As String = "FAX"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const ContractYr As String = "ContractYr"
			 Public Const AriseStatus As String = "AriseStatus"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const Frequency As String = "Frequency"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const District As String = "District"
			 Public Const Region As String = "Region"
			 Public Const InspPerFROM As String = "InspPerFROM"
			 Public Const InspPerTO As String = "InspPerTO"
			 Public Const ServicedBy As String = "ServicedBy"
			 Public Const LocationComment As String = "LocationComment"
			 Public Const SchedulingComment As String = "SchedulingComment"
			 Public Const CancelDate As String = "CancelDate"
			 Public Const CancelNote As String = "CancelNote"
			 Public Const ReinstateDate As String = "ReinstateDate"
			 Public Const ReinstateNote As String = "ReinstateNote"
			 Public Const ContractOwnership As String = "ContractOwnership"
			 Public Const InspDue As String = "InspDue"
			 Public Const InspRemaining As String = "InspRemaining"
			 Public Const LastYrInspection As String = "LastYrInspection"
			 Public Const LastYrEngineer As String = "LastYrEngineer"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const Engineer As String = "Engineer"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const ClientTargetMo As String = "ClientTargetMo"
			 Public Const EngTargetMo As String = "EngTargetMo"
			 Public Const SchedFROM As String = "SchedFROM"
			 Public Const SchedTO As String = "SchedTO"
			 Public Const TripGroup As String = "TripGroup"
			 Public Const Report1 As String = "Report1"
			 Public Const Rpt1Procr As String = "Rpt1Procr"
			 Public Const Rpt1Revwr As String = "Rpt1Revwr"
			 Public Const Rpt1Client As String = "Rpt1Client"
			 Public Const Report2 As String = "Report2"
			 Public Const Rpt2Procr As String = "Rpt2Procr"
			 Public Const Rpt2Revwr As String = "Rpt2Revwr"
			 Public Const Rpt2Client As String = "Rpt2Client"
			 Public Const Report3 As String = "Report3"
			 Public Const Rpt3Procr As String = "Rpt3Procr"
			 Public Const Rpt3Revwr As String = "Rpt3Revwr"
			 Public Const Rpt3Client As String = "Rpt3Client"
			 Public Const Report4 As String = "Report4"
			 Public Const Rpt4Procr As String = "Rpt4Procr"
			 Public Const Rpt4Revwr As String = "Rpt4Revwr"
			 Public Const Rpt4Client As String = "Rpt4Client"
			 Public Const DiagrSubm As String = "DiagrSubm"
			 Public Const DiagrIssued As String = "DiagrIssued"
			 Public Const EstInspHrs As String = "EstInspHrs"
			 Public Const EstRptHrs As String = "EstRptHrs"
			 Public Const EstTravelHrs As String = "EstTravelHrs"
			 Public Const EstOtherHrs As String = "EstOtherHrs"
			 Public Const TotalEstHrs As String = "TotalEstHrs"
			 Public Const QuotInspHrs As String = "QuotInspHrs"
			 Public Const QuotRptHrs As String = "QuotRptHrs"
			 Public Const QuotTravelHrs As String = "QuotTravelHrs"
			 Public Const QuotOtherHrs As String = "QuotOtherHrs"
			 Public Const InspNotes As String = "InspNotes"
			 Public Const EffectiveDate As String = "EffectiveDate"
			 Public Const CurrencyCode As String = "CurrencyCode"
			 Public Const PDBuilding As String = "PD_Building"
			 Public Const PDEquipment As String = "PD_Equipment"
			 Public Const PDFinished As String = "PD_Finished"
			 Public Const PDRawStock As String = "PD_RawStock"
			 Public Const PDBuildersRisk As String = "PD_BuildersRisk"
			 Public Const PDMisc As String = "PD_Misc"
			 Public Const PDTotal As String = "PD_Total"
			 Public Const BIGrossProfit As String = "BI_GrossProfit"
			 Public Const BIWageExtraExp As String = "BI_WageExtraExp"
			 Public Const BIMisc As String = "BI_Misc"
			 Public Const BIOther As String = "BI_Other"
			 Public Const BITotal As String = "BI_Total"
			 Public Const GrossProfitIndemnity As String = "GrossProfitIndemnity"
			 Public Const WagesExtraExpIndem As String = "WagesExtraExpIndem"
			 Public Const TotalUSPD As String = "TotalUS_PD"
			 Public Const TotalUSBI As String = "TotalUS_BI"
			 Public Const TotalUSTIV As String = "TotalUS_TIV"
			 Public Const LocalTIV As String = "LocalTIV"
			 Public Const Office As String = "Office"
			 Public Const InspectRegID As String = "InspectRegID"
			 Public Const ContractNo As String = "ContractNo"
			 Public Const InspectionID As String = "InspectionID"
			 Public Const _100PercentUSTot As String = "100PercentUSTot"
			 Public Const SQFootage As String = "SQFootage"
			 Public Const Client1 As String = "Client1"
			 Public Const Client2 As String = "Client2"
			 Public Const Occupancy As String = "Occupancy"
			 Public Const FieldFileOffice As String = "FieldFileOffice"
			 Public Const EngInspHours As String = "EngInspHours"
			 Public Const EngReportHours As String = "EngReportHours"
			 Public Const EngTravelHours As String = "EngTravelHours"
			 Public Const EngOtherHours As String = "EngOtherHours"
			 Public Const InitialInspection As String = "InitialInspection"
			 Public Const Audit As String = "Audit"
			 Public Const AuditType As String = "Audit Type"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const LastUpdated As String = "LastUpdated"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const EngineerId As String = "EngineerId"
			 Public Const ExcludeCDB As String = "ExcludeCDB"
			 Public Const BingEnabled As String = "BingEnabled"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const GripssRecordID As String = "GripssRecordID"
			 Public Const FileNo As String = "FileNo"
			 Public Const Client As String = "Client"
			 Public Const Parent As String = "Parent"
			 Public Const ParentNo As String = "ParentNo"
			 Public Const Abbr As String = "Abbr"
			 Public Const Division As String = "Division"
			 Public Const Facility As String = "Facility"
			 Public Const Address1 As String = "Address1"
			 Public Const Address2 As String = "Address2"
			 Public Const Address3 As String = "Address3"
			 Public Const City As String = "City"
			 Public Const StProv As String = "StProv"
			 Public Const StProvName As String = "StProvName"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const County As String = "County"
			 Public Const Phone1 As String = "Phone1"
			 Public Const Fax As String = "Fax"
			 Public Const ClientLocNo As String = "ClientLocNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const ContractYr As String = "ContractYr"
			 Public Const AriseStatus As String = "AriseStatus"
			 Public Const LocationStatus As String = "LocationStatus"
			 Public Const Frequency As String = "Frequency"
			 Public Const NextInspYr As String = "NextInspYr"
			 Public Const District As String = "District"
			 Public Const Region As String = "Region"
			 Public Const InspPerFROM As String = "InspPerFROM"
			 Public Const InspPerTO As String = "InspPerTO"
			 Public Const ServicedBy As String = "ServicedBy"
			 Public Const LocationComment As String = "LocationComment"
			 Public Const SchedulingComment As String = "SchedulingComment"
			 Public Const CancelDate As String = "CancelDate"
			 Public Const CancelNote As String = "CancelNote"
			 Public Const ReinstateDate As String = "ReinstateDate"
			 Public Const ReinstateNote As String = "ReinstateNote"
			 Public Const ContractOwnership As String = "ContractOwnership"
			 Public Const InspDue As String = "InspDue"
			 Public Const InspRemaining As String = "InspRemaining"
			 Public Const LastYrInspection As String = "LastYrInspection"
			 Public Const LastYrEngineer As String = "LastYrEngineer"
			 Public Const InspectionStatus As String = "InspectionStatus"
			 Public Const Engineer As String = "Engineer"
			 Public Const DateCompleted As String = "DateCompleted"
			 Public Const ClientTargetMo As String = "ClientTargetMo"
			 Public Const EngTargetMo As String = "EngTargetMo"
			 Public Const SchedFROM As String = "SchedFROM"
			 Public Const SchedTO As String = "SchedTO"
			 Public Const TripGroup As String = "TripGroup"
			 Public Const Report1 As String = "Report1"
			 Public Const Rpt1Procr As String = "Rpt1Procr"
			 Public Const Rpt1Revwr As String = "Rpt1Revwr"
			 Public Const Rpt1Client As String = "Rpt1Client"
			 Public Const Report2 As String = "Report2"
			 Public Const Rpt2Procr As String = "Rpt2Procr"
			 Public Const Rpt2Revwr As String = "Rpt2Revwr"
			 Public Const Rpt2Client As String = "Rpt2Client"
			 Public Const Report3 As String = "Report3"
			 Public Const Rpt3Procr As String = "Rpt3Procr"
			 Public Const Rpt3Revwr As String = "Rpt3Revwr"
			 Public Const Rpt3Client As String = "Rpt3Client"
			 Public Const Report4 As String = "Report4"
			 Public Const Rpt4Procr As String = "Rpt4Procr"
			 Public Const Rpt4Revwr As String = "Rpt4Revwr"
			 Public Const Rpt4Client As String = "Rpt4Client"
			 Public Const DiagrSubm As String = "DiagrSubm"
			 Public Const DiagrIssued As String = "DiagrIssued"
			 Public Const EstInspHrs As String = "EstInspHrs"
			 Public Const EstRptHrs As String = "EstRptHrs"
			 Public Const EstTravelHrs As String = "EstTravelHrs"
			 Public Const EstOtherHrs As String = "EstOtherHrs"
			 Public Const TotalEstHrs As String = "TotalEstHrs"
			 Public Const QuotInspHrs As String = "QuotInspHrs"
			 Public Const QuotRptHrs As String = "QuotRptHrs"
			 Public Const QuotTravelHrs As String = "QuotTravelHrs"
			 Public Const QuotOtherHrs As String = "QuotOtherHrs"
			 Public Const InspNotes As String = "InspNotes"
			 Public Const EffectiveDate As String = "EffectiveDate"
			 Public Const CurrencyCode As String = "CurrencyCode"
			 Public Const PDBuilding As String = "PDBuilding"
			 Public Const PDEquipment As String = "PDEquipment"
			 Public Const PDFinished As String = "PDFinished"
			 Public Const PDRawStock As String = "PDRawStock"
			 Public Const PDBuildersRisk As String = "PDBuildersRisk"
			 Public Const PDMisc As String = "PDMisc"
			 Public Const PDTotal As String = "PDTotal"
			 Public Const BIGrossProfit As String = "BIGrossProfit"
			 Public Const BIWageExtraExp As String = "BIWageExtraExp"
			 Public Const BIMisc As String = "BIMisc"
			 Public Const BIOther As String = "BIOther"
			 Public Const BITotal As String = "BITotal"
			 Public Const GrossProfitIndemnity As String = "GrossProfitIndemnity"
			 Public Const WagesExtraExpIndem As String = "WagesExtraExpIndem"
			 Public Const TotalUSPD As String = "TotalUSPD"
			 Public Const TotalUSBI As String = "TotalUSBI"
			 Public Const TotalUSTIV As String = "TotalUSTIV"
			 Public Const LocalTIV As String = "LocalTIV"
			 Public Const Office As String = "Office"
			 Public Const InspectRegID As String = "InspectRegID"
			 Public Const ContractNo As String = "ContractNo"
			 Public Const InspectionID As String = "InspectionID"
			 Public Const _100PercentUSTot As String = "_100PercentUSTot"
			 Public Const SQFootage As String = "SQFootage"
			 Public Const Client1 As String = "Client1"
			 Public Const Client2 As String = "Client2"
			 Public Const Occupancy As String = "Occupancy"
			 Public Const FieldFileOffice As String = "FieldFileOffice"
			 Public Const EngInspHours As String = "EngInspHours"
			 Public Const EngReportHours As String = "EngReportHours"
			 Public Const EngTravelHours As String = "EngTravelHours"
			 Public Const EngOtherHours As String = "EngOtherHours"
			 Public Const InitialInspection As String = "InitialInspection"
			 Public Const Audit As String = "Audit"
			 Public Const AuditType As String = "AuditType"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const LastUpdated As String = "LastUpdated"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const EngineerId As String = "EngineerId"
			 Public Const ExcludeCDB As String = "ExcludeCDB"
			 Public Const BingEnabled As String = "BingEnabled"
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
			SyncLock GetType(GRIPSSWorkloadMetadata)
			
				If GRIPSSWorkloadMetadata.mapDelegates Is Nothing Then
					GRIPSSWorkloadMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If GRIPSSWorkloadMetadata._meta Is Nothing Then
					GRIPSSWorkloadMetadata._meta = New GRIPSSWorkloadMetadata()
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
				


				meta.AddTypeMap("GripssRecordID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Client", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Parent", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ParentNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Abbr", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Facility", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProv", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StProvName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("County", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Phone1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ClientLocNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("ContractYr", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("AriseStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Frequency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NextInspYr", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("District", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Region", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspPerFROM", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("InspPerTO", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ServicedBy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationComment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SchedulingComment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CancelDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("CancelNote", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ReinstateDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ReinstateNote", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ContractOwnership", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspDue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InspRemaining", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LastYrInspection", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("LastYrEngineer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectionStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Engineer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DateCompleted", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ClientTargetMo", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("EngTargetMo", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("SchedFROM", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("SchedTO", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("TripGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Report1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Rpt1Procr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt1Revwr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt1Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Report2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Rpt2Procr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt2Revwr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt2Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Report3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Rpt3Procr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt3Revwr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt3Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Report4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Rpt4Procr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt4Revwr", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Rpt4Client", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("DiagrSubm", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("DiagrIssued", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("EstInspHrs", new esTypeMap("real", "System.Single"))
				meta.AddTypeMap("EstRptHrs", new esTypeMap("real", "System.Single"))
				meta.AddTypeMap("EstTravelHrs", new esTypeMap("real", "System.Single"))
				meta.AddTypeMap("EstOtherHrs", new esTypeMap("real", "System.Single"))
				meta.AddTypeMap("TotalEstHrs", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("QuotInspHrs", new esTypeMap("real", "System.Single"))
				meta.AddTypeMap("QuotRptHrs", new esTypeMap("real", "System.Single"))
				meta.AddTypeMap("QuotTravelHrs", new esTypeMap("real", "System.Single"))
				meta.AddTypeMap("QuotOtherHrs", new esTypeMap("real", "System.Single"))
				meta.AddTypeMap("InspNotes", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EffectiveDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("CurrencyCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDBuilding", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDEquipment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDFinished", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDRawStock", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDBuildersRisk", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDMisc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PDTotal", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIGrossProfit", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIWageExtraExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIMisc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BIOther", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BITotal", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("GrossProfitIndemnity", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("WagesExtraExpIndem", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotalUSPD", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalUSBI", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalUSTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocalTIV", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Office", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectRegID", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ContractNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InspectionID", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("_100PercentUSTot", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("SQFootage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Client1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Client2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Occupancy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FieldFileOffice", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EngInspHours", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EngReportHours", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EngTravelHours", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EngOtherHours", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InitialInspection", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Audit", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("AuditType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastUpdated", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("EngineerId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExcludeCDB", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("BingEnabled", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "GRIPSS-Workload"
				meta.Destination = "GRIPSS-Workload"
				
				meta.spInsert = "proc_GRIPSS-WorkloadInsert"
				meta.spUpdate = "proc_GRIPSS-WorkloadUpdate"
				meta.spDelete = "proc_GRIPSS-WorkloadDelete"
				meta.spLoadAll = "proc_GRIPSS-WorkloadLoadAll"
				meta.spLoadByPrimaryKey = "proc_GRIPSS-WorkloadLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As GRIPSSWorkloadMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
