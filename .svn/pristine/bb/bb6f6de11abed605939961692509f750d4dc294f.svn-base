
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:18 PM
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
	' Encapsulates the 'BM-Rating' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMRating))> _
	<XmlType("BMRating")> _	
	Partial Public Class BMRating 
		Inherits esBMRating
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMRating()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New BMRating()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMRating()
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
	<XmlType("BMRatingCollection")> _
	Partial Public Class BMRatingCollection
		Inherits esBMRatingCollection
		Implements IEnumerable(Of BMRating)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As BMRating
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMRating))> _
		Public Class BMRatingCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMRatingCollection)
			
			Public Shared Widening Operator CType(packet As BMRatingCollectionWCFPacket) As BMRatingCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMRatingCollection) As BMRatingCollectionWCFPacket
				Return New BMRatingCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMRatingQuery 
		Inherits esBMRatingQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMRatingQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMRatingQuery) As String
			Return BMRatingQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMRatingQuery
			Return DirectCast(BMRatingQuery.SerializeHelper.FromXml(query, GetType(BMRatingQuery)), BMRatingQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMRating
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
		
			Dim query As New BMRatingQuery()
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
		' Maps to BM-Rating.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRatingMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRatingMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.MechEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.MechEquipC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.ElecEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.ElecEquipC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BoilersC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.BoilersC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.BoilersC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.BoilersC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ProcEquipC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.ProcEquipC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.ProcEquipC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ProcEquipC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.OccupancyC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.OccupancyC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.OccupancyC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.OccupancyC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.CompSysC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.CompSysC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.CompSysC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.CompSysC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechMaintC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.MechMaintC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.MechMaintC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechMaintC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecMaintC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.ElecMaintC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.ElecMaintC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecMaintC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.SparesC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.SparesC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.SparesC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.SparesC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.HumanElementC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementC As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.HumanElementC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.HumanElementC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.HumanElementC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BCPC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bcpc As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.Bcpc)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.Bcpc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.Bcpc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechEquipWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.MechEquipWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.MechEquipWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechEquipWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecEquipWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.ElecEquipWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.ElecEquipWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecEquipWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BoilersWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.BoilersWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.BoilersWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.BoilersWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ProcEquipWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.ProcEquipWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.ProcEquipWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ProcEquipWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.OccupancyWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.OccupancyWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.OccupancyWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.OccupancyWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.CompSysWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.CompSysWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.CompSysWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.CompSysWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechMaintWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.MechMaintWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.MechMaintWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechMaintWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecMaintWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.ElecMaintWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.ElecMaintWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecMaintWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.SparesWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.SparesWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.SparesWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.SparesWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.HumanElementWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.HumanElementWR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.HumanElementWR, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.HumanElementWR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BCPWR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bcpwr As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRatingMetadata.ColumnNames.Bcpwr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRatingMetadata.ColumnNames.Bcpwr, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.Bcpwr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechEquipWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.MechEquipWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.MechEquipWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechEquipWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecEquipWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.ElecEquipWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.ElecEquipWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecEquipWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BoilersWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.BoilersWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.BoilersWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.BoilersWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ProcEquipWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.ProcEquipWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.ProcEquipWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ProcEquipWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.OccupancyWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.OccupancyWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.OccupancyWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.OccupancyWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.CompSysWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.CompSysWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.CompSysWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.CompSysWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechMaintWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.MechMaintWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.MechMaintWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechMaintWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecMaintWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.ElecMaintWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.ElecMaintWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecMaintWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.SparesWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.SparesWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.SparesWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.SparesWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.HumanElementWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.HumanElementWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.HumanElementWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.HumanElementWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BCPWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPWeight As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.BCPWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.BCPWeight, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.BCPWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.PassiveC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PassiveC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.PassiveC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.PassiveC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.PassiveC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.PassiveWC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PassiveWC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.PassiveWC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.PassiveWC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.PassiveWC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ActiveC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.ActiveC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.ActiveC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ActiveC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ActiveWC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveWC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.ActiveWC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.ActiveWC, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ActiveWC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.TotalScoreCurrent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalScoreCurrent As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.TotalScoreCurrent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.TotalScoreCurrent, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.TotalScoreCurrent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.TotalRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalRating As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.TotalRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.TotalRating, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.TotalRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.TotalWRComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalWRComplete As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRatingMetadata.ColumnNames.TotalWRComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRatingMetadata.ColumnNames.TotalWRComplete, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.TotalWRComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechEquipDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.MechEquipDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.MechEquipDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechEquipDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecEquipDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.ElecEquipDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.ElecEquipDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecEquipDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BoilersDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.BoilersDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.BoilersDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.BoilersDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ProcEquipDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.ProcEquipDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.ProcEquipDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ProcEquipDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.OccupancyDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.OccupancyDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.OccupancyDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.OccupancyDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.CompSysDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.CompSysDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.CompSysDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.CompSysDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechMaintDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.MechMaintDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.MechMaintDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechMaintDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecMaintDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.ElecMaintDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.ElecMaintDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecMaintDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.SparesDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.SparesDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.SparesDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.SparesDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.HumanElementDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.HumanElementDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.HumanElementDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.HumanElementDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BCPDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.BCPDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.BCPDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.BCPDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechEquipWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechEquipWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.MechEquipWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.MechEquipWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechEquipWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecEquipWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecEquipWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.ElecEquipWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.ElecEquipWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecEquipWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BoilersWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.BoilersWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.BoilersWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.BoilersWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ProcEquipWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcEquipWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.ProcEquipWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.ProcEquipWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ProcEquipWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.OccupancyWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.OccupancyWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.OccupancyWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.OccupancyWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.CompSysWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.CompSysWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.CompSysWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.CompSysWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.MechMaintWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechMaintWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.MechMaintWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.MechMaintWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.MechMaintWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.ElecMaintWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMaintWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.ElecMaintWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.ElecMaintWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecMaintWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.SparesWrDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesWrDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.SparesWrDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.SparesWrDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.SparesWrDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.HumanElementWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.HumanElementWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.HumanElementWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.HumanElementWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.BCPWRDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPWRDesc As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.BCPWRDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.BCPWRDesc, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.BCPWRDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.OverallPlantRatingRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallPlantRatingRating As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.OverallPlantRatingRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.OverallPlantRatingRating, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.OverallPlantRatingRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Rating.TotalWRCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalWRCompleteRating As System.String
			Get
				Return MyBase.GetSystemString(BMRatingMetadata.ColumnNames.TotalWRCompleteRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRatingMetadata.ColumnNames.TotalWRCompleteRating, value) Then
					OnPropertyChanged(BMRatingMetadata.PropertyNames.TotalWRCompleteRating)
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
												
						Case "InspectionDate"
							Me.str().InspectionDate = CType(value, string)
												
						Case "MechEquipC"
							Me.str().MechEquipC = CType(value, string)
												
						Case "ElecEquipC"
							Me.str().ElecEquipC = CType(value, string)
												
						Case "BoilersC"
							Me.str().BoilersC = CType(value, string)
												
						Case "ProcEquipC"
							Me.str().ProcEquipC = CType(value, string)
												
						Case "OccupancyC"
							Me.str().OccupancyC = CType(value, string)
												
						Case "CompSysC"
							Me.str().CompSysC = CType(value, string)
												
						Case "MechMaintC"
							Me.str().MechMaintC = CType(value, string)
												
						Case "ElecMaintC"
							Me.str().ElecMaintC = CType(value, string)
												
						Case "SparesC"
							Me.str().SparesC = CType(value, string)
												
						Case "HumanElementC"
							Me.str().HumanElementC = CType(value, string)
												
						Case "Bcpc"
							Me.str().Bcpc = CType(value, string)
												
						Case "MechEquipWR"
							Me.str().MechEquipWR = CType(value, string)
												
						Case "ElecEquipWR"
							Me.str().ElecEquipWR = CType(value, string)
												
						Case "BoilersWR"
							Me.str().BoilersWR = CType(value, string)
												
						Case "ProcEquipWR"
							Me.str().ProcEquipWR = CType(value, string)
												
						Case "OccupancyWR"
							Me.str().OccupancyWR = CType(value, string)
												
						Case "CompSysWR"
							Me.str().CompSysWR = CType(value, string)
												
						Case "MechMaintWR"
							Me.str().MechMaintWR = CType(value, string)
												
						Case "ElecMaintWR"
							Me.str().ElecMaintWR = CType(value, string)
												
						Case "SparesWR"
							Me.str().SparesWR = CType(value, string)
												
						Case "HumanElementWR"
							Me.str().HumanElementWR = CType(value, string)
												
						Case "Bcpwr"
							Me.str().Bcpwr = CType(value, string)
												
						Case "MechEquipWeight"
							Me.str().MechEquipWeight = CType(value, string)
												
						Case "ElecEquipWeight"
							Me.str().ElecEquipWeight = CType(value, string)
												
						Case "BoilersWeight"
							Me.str().BoilersWeight = CType(value, string)
												
						Case "ProcEquipWeight"
							Me.str().ProcEquipWeight = CType(value, string)
												
						Case "OccupancyWeight"
							Me.str().OccupancyWeight = CType(value, string)
												
						Case "CompSysWeight"
							Me.str().CompSysWeight = CType(value, string)
												
						Case "MechMaintWeight"
							Me.str().MechMaintWeight = CType(value, string)
												
						Case "ElecMaintWeight"
							Me.str().ElecMaintWeight = CType(value, string)
												
						Case "SparesWeight"
							Me.str().SparesWeight = CType(value, string)
												
						Case "HumanElementWeight"
							Me.str().HumanElementWeight = CType(value, string)
												
						Case "BCPWeight"
							Me.str().BCPWeight = CType(value, string)
												
						Case "PassiveC"
							Me.str().PassiveC = CType(value, string)
												
						Case "PassiveWC"
							Me.str().PassiveWC = CType(value, string)
												
						Case "ActiveC"
							Me.str().ActiveC = CType(value, string)
												
						Case "ActiveWC"
							Me.str().ActiveWC = CType(value, string)
												
						Case "TotalScoreCurrent"
							Me.str().TotalScoreCurrent = CType(value, string)
												
						Case "TotalRating"
							Me.str().TotalRating = CType(value, string)
												
						Case "TotalWRComplete"
							Me.str().TotalWRComplete = CType(value, string)
												
						Case "MechEquipDesc"
							Me.str().MechEquipDesc = CType(value, string)
												
						Case "ElecEquipDesc"
							Me.str().ElecEquipDesc = CType(value, string)
												
						Case "BoilersDesc"
							Me.str().BoilersDesc = CType(value, string)
												
						Case "ProcEquipDesc"
							Me.str().ProcEquipDesc = CType(value, string)
												
						Case "OccupancyDesc"
							Me.str().OccupancyDesc = CType(value, string)
												
						Case "CompSysDesc"
							Me.str().CompSysDesc = CType(value, string)
												
						Case "MechMaintDesc"
							Me.str().MechMaintDesc = CType(value, string)
												
						Case "ElecMaintDesc"
							Me.str().ElecMaintDesc = CType(value, string)
												
						Case "SparesDesc"
							Me.str().SparesDesc = CType(value, string)
												
						Case "HumanElementDesc"
							Me.str().HumanElementDesc = CType(value, string)
												
						Case "BCPDesc"
							Me.str().BCPDesc = CType(value, string)
												
						Case "MechEquipWRDesc"
							Me.str().MechEquipWRDesc = CType(value, string)
												
						Case "ElecEquipWRDesc"
							Me.str().ElecEquipWRDesc = CType(value, string)
												
						Case "BoilersWRDesc"
							Me.str().BoilersWRDesc = CType(value, string)
												
						Case "ProcEquipWRDesc"
							Me.str().ProcEquipWRDesc = CType(value, string)
												
						Case "OccupancyWRDesc"
							Me.str().OccupancyWRDesc = CType(value, string)
												
						Case "CompSysWRDesc"
							Me.str().CompSysWRDesc = CType(value, string)
												
						Case "MechMaintWRDesc"
							Me.str().MechMaintWRDesc = CType(value, string)
												
						Case "ElecMaintWRDesc"
							Me.str().ElecMaintWRDesc = CType(value, string)
												
						Case "SparesWrDesc"
							Me.str().SparesWrDesc = CType(value, string)
												
						Case "HumanElementWRDesc"
							Me.str().HumanElementWRDesc = CType(value, string)
												
						Case "BCPWRDesc"
							Me.str().BCPWRDesc = CType(value, string)
												
						Case "OverallPlantRatingRating"
							Me.str().OverallPlantRatingRating = CType(value, string)
												
						Case "TotalWRCompleteRating"
							Me.str().TotalWRCompleteRating = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.Id)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "MechEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MechEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.MechEquipC)
							End If
						
						Case "ElecEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecEquipC)
							End If
						
						Case "BoilersC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BoilersC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.BoilersC)
							End If
						
						Case "ProcEquipC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProcEquipC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ProcEquipC)
							End If
						
						Case "OccupancyC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.OccupancyC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.OccupancyC)
							End If
						
						Case "CompSysC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CompSysC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.CompSysC)
							End If
						
						Case "MechMaintC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MechMaintC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.MechMaintC)
							End If
						
						Case "ElecMaintC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecMaintC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecMaintC)
							End If
						
						Case "SparesC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SparesC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.SparesC)
							End If
						
						Case "HumanElementC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.HumanElementC = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.HumanElementC)
							End If
						
						Case "Bcpc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bcpc = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.Bcpc)
							End If
						
						Case "MechEquipWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MechEquipWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.MechEquipWR)
							End If
						
						Case "ElecEquipWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecEquipWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecEquipWR)
							End If
						
						Case "BoilersWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BoilersWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.BoilersWR)
							End If
						
						Case "ProcEquipWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProcEquipWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ProcEquipWR)
							End If
						
						Case "OccupancyWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.OccupancyWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.OccupancyWR)
							End If
						
						Case "CompSysWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CompSysWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.CompSysWR)
							End If
						
						Case "MechMaintWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MechMaintWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.MechMaintWR)
							End If
						
						Case "ElecMaintWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ElecMaintWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecMaintWR)
							End If
						
						Case "SparesWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SparesWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.SparesWR)
							End If
						
						Case "HumanElementWR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.HumanElementWR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.HumanElementWR)
							End If
						
						Case "Bcpwr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bcpwr = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.Bcpwr)
							End If
						
						Case "MechEquipWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MechEquipWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.MechEquipWeight)
							End If
						
						Case "ElecEquipWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ElecEquipWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecEquipWeight)
							End If
						
						Case "BoilersWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.BoilersWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.BoilersWeight)
							End If
						
						Case "ProcEquipWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ProcEquipWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ProcEquipWeight)
							End If
						
						Case "OccupancyWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.OccupancyWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.OccupancyWeight)
							End If
						
						Case "CompSysWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CompSysWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.CompSysWeight)
							End If
						
						Case "MechMaintWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MechMaintWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.MechMaintWeight)
							End If
						
						Case "ElecMaintWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ElecMaintWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ElecMaintWeight)
							End If
						
						Case "SparesWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.SparesWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.SparesWeight)
							End If
						
						Case "HumanElementWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.HumanElementWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.HumanElementWeight)
							End If
						
						Case "BCPWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.BCPWeight = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.BCPWeight)
							End If
						
						Case "PassiveC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PassiveC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.PassiveC)
							End If
						
						Case "PassiveWC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PassiveWC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.PassiveWC)
							End If
						
						Case "ActiveC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ActiveC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ActiveC)
							End If
						
						Case "ActiveWC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ActiveWC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.ActiveWC)
							End If
						
						Case "TotalScoreCurrent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotalScoreCurrent = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.TotalScoreCurrent)
							End If
						
						Case "TotalWRComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.TotalWRComplete = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRatingMetadata.PropertyNames.TotalWRComplete)
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
		
			Public Sub New(ByVal entity As esBMRating)
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
		  	
			Public Property InspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionDate = Nothing
					Else
						entity.InspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MechEquipC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipC = Nothing
					Else
						entity.MechEquipC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ElecEquipC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipC = Nothing
					Else
						entity.ElecEquipC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BoilersC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersC = Nothing
					Else
						entity.BoilersC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProcEquipC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipC = Nothing
					Else
						entity.ProcEquipC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.OccupancyC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyC = Nothing
					Else
						entity.OccupancyC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CompSysC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysC = Nothing
					Else
						entity.CompSysC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MechMaintC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintC = Nothing
					Else
						entity.MechMaintC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ElecMaintC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintC = Nothing
					Else
						entity.ElecMaintC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SparesC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesC = Nothing
					Else
						entity.SparesC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementC As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.HumanElementC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementC = Nothing
					Else
						entity.HumanElementC = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bcpc As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bcpc
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bcpc = Nothing
					Else
						entity.Bcpc = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MechEquipWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipWR = Nothing
					Else
						entity.MechEquipWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ElecEquipWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipWR = Nothing
					Else
						entity.ElecEquipWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BoilersWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersWR = Nothing
					Else
						entity.BoilersWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProcEquipWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipWR = Nothing
					Else
						entity.ProcEquipWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.OccupancyWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWR = Nothing
					Else
						entity.OccupancyWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CompSysWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysWR = Nothing
					Else
						entity.CompSysWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MechMaintWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintWR = Nothing
					Else
						entity.MechMaintWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ElecMaintWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintWR = Nothing
					Else
						entity.ElecMaintWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SparesWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesWR = Nothing
					Else
						entity.SparesWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.HumanElementWR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWR = Nothing
					Else
						entity.HumanElementWR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bcpwr As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bcpwr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bcpwr = Nothing
					Else
						entity.Bcpwr = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MechEquipWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipWeight = Nothing
					Else
						entity.MechEquipWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ElecEquipWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipWeight = Nothing
					Else
						entity.ElecEquipWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.BoilersWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersWeight = Nothing
					Else
						entity.BoilersWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ProcEquipWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipWeight = Nothing
					Else
						entity.ProcEquipWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.OccupancyWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWeight = Nothing
					Else
						entity.OccupancyWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CompSysWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysWeight = Nothing
					Else
						entity.CompSysWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MechMaintWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintWeight = Nothing
					Else
						entity.MechMaintWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ElecMaintWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintWeight = Nothing
					Else
						entity.ElecMaintWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.SparesWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesWeight = Nothing
					Else
						entity.SparesWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.HumanElementWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWeight = Nothing
					Else
						entity.HumanElementWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.BCPWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPWeight = Nothing
					Else
						entity.BCPWeight = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PassiveC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PassiveC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PassiveC = Nothing
					Else
						entity.PassiveC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PassiveWC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PassiveWC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PassiveWC = Nothing
					Else
						entity.PassiveWC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ActiveC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveC = Nothing
					Else
						entity.ActiveC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveWC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ActiveWC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveWC = Nothing
					Else
						entity.ActiveWC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalScoreCurrent As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TotalScoreCurrent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalScoreCurrent = Nothing
					Else
						entity.TotalScoreCurrent = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalRating As System.String 
				Get
					Dim data_ As System.String = entity.TotalRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalRating = Nothing
					Else
						entity.TotalRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalWRComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.TotalWRComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalWRComplete = Nothing
					Else
						entity.TotalWRComplete = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipDesc As System.String 
				Get
					Dim data_ As System.String = entity.MechEquipDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipDesc = Nothing
					Else
						entity.MechEquipDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipDesc As System.String 
				Get
					Dim data_ As System.String = entity.ElecEquipDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipDesc = Nothing
					Else
						entity.ElecEquipDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersDesc As System.String 
				Get
					Dim data_ As System.String = entity.BoilersDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersDesc = Nothing
					Else
						entity.BoilersDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipDesc As System.String 
				Get
					Dim data_ As System.String = entity.ProcEquipDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipDesc = Nothing
					Else
						entity.ProcEquipDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyDesc As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyDesc = Nothing
					Else
						entity.OccupancyDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysDesc As System.String 
				Get
					Dim data_ As System.String = entity.CompSysDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysDesc = Nothing
					Else
						entity.CompSysDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintDesc As System.String 
				Get
					Dim data_ As System.String = entity.MechMaintDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintDesc = Nothing
					Else
						entity.MechMaintDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintDesc As System.String 
				Get
					Dim data_ As System.String = entity.ElecMaintDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintDesc = Nothing
					Else
						entity.ElecMaintDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesDesc As System.String 
				Get
					Dim data_ As System.String = entity.SparesDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesDesc = Nothing
					Else
						entity.SparesDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementDesc As System.String 
				Get
					Dim data_ As System.String = entity.HumanElementDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementDesc = Nothing
					Else
						entity.HumanElementDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPDesc As System.String 
				Get
					Dim data_ As System.String = entity.BCPDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPDesc = Nothing
					Else
						entity.BCPDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechEquipWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.MechEquipWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechEquipWRDesc = Nothing
					Else
						entity.MechEquipWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecEquipWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.ElecEquipWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecEquipWRDesc = Nothing
					Else
						entity.ElecEquipWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.BoilersWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersWRDesc = Nothing
					Else
						entity.BoilersWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcEquipWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.ProcEquipWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcEquipWRDesc = Nothing
					Else
						entity.ProcEquipWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWRDesc = Nothing
					Else
						entity.OccupancyWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.CompSysWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysWRDesc = Nothing
					Else
						entity.CompSysWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechMaintWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.MechMaintWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechMaintWRDesc = Nothing
					Else
						entity.MechMaintWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMaintWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.ElecMaintWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMaintWRDesc = Nothing
					Else
						entity.ElecMaintWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesWrDesc As System.String 
				Get
					Dim data_ As System.String = entity.SparesWrDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesWrDesc = Nothing
					Else
						entity.SparesWrDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.HumanElementWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWRDesc = Nothing
					Else
						entity.HumanElementWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPWRDesc As System.String 
				Get
					Dim data_ As System.String = entity.BCPWRDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPWRDesc = Nothing
					Else
						entity.BCPWRDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallPlantRatingRating As System.String 
				Get
					Dim data_ As System.String = entity.OverallPlantRatingRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallPlantRatingRating = Nothing
					Else
						entity.OverallPlantRatingRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalWRCompleteRating As System.String 
				Get
					Dim data_ As System.String = entity.TotalWRCompleteRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalWRCompleteRating = Nothing
					Else
						entity.TotalWRCompleteRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBMRating
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMRatingMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMRatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMRatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMRatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMRatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMRatingQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMRatingCollection
		Inherits esEntityCollection(Of BMRating)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMRatingMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMRatingCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMRatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMRatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMRatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMRatingQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMRatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMRatingQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMRatingQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMRatingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMRatingMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "InspectionDate" 
					Return Me.InspectionDate
				Case "MechEquipC" 
					Return Me.MechEquipC
				Case "ElecEquipC" 
					Return Me.ElecEquipC
				Case "BoilersC" 
					Return Me.BoilersC
				Case "ProcEquipC" 
					Return Me.ProcEquipC
				Case "OccupancyC" 
					Return Me.OccupancyC
				Case "CompSysC" 
					Return Me.CompSysC
				Case "MechMaintC" 
					Return Me.MechMaintC
				Case "ElecMaintC" 
					Return Me.ElecMaintC
				Case "SparesC" 
					Return Me.SparesC
				Case "HumanElementC" 
					Return Me.HumanElementC
				Case "Bcpc" 
					Return Me.Bcpc
				Case "MechEquipWR" 
					Return Me.MechEquipWR
				Case "ElecEquipWR" 
					Return Me.ElecEquipWR
				Case "BoilersWR" 
					Return Me.BoilersWR
				Case "ProcEquipWR" 
					Return Me.ProcEquipWR
				Case "OccupancyWR" 
					Return Me.OccupancyWR
				Case "CompSysWR" 
					Return Me.CompSysWR
				Case "MechMaintWR" 
					Return Me.MechMaintWR
				Case "ElecMaintWR" 
					Return Me.ElecMaintWR
				Case "SparesWR" 
					Return Me.SparesWR
				Case "HumanElementWR" 
					Return Me.HumanElementWR
				Case "Bcpwr" 
					Return Me.Bcpwr
				Case "MechEquipWeight" 
					Return Me.MechEquipWeight
				Case "ElecEquipWeight" 
					Return Me.ElecEquipWeight
				Case "BoilersWeight" 
					Return Me.BoilersWeight
				Case "ProcEquipWeight" 
					Return Me.ProcEquipWeight
				Case "OccupancyWeight" 
					Return Me.OccupancyWeight
				Case "CompSysWeight" 
					Return Me.CompSysWeight
				Case "MechMaintWeight" 
					Return Me.MechMaintWeight
				Case "ElecMaintWeight" 
					Return Me.ElecMaintWeight
				Case "SparesWeight" 
					Return Me.SparesWeight
				Case "HumanElementWeight" 
					Return Me.HumanElementWeight
				Case "BCPWeight" 
					Return Me.BCPWeight
				Case "PassiveC" 
					Return Me.PassiveC
				Case "PassiveWC" 
					Return Me.PassiveWC
				Case "ActiveC" 
					Return Me.ActiveC
				Case "ActiveWC" 
					Return Me.ActiveWC
				Case "TotalScoreCurrent" 
					Return Me.TotalScoreCurrent
				Case "TotalRating" 
					Return Me.TotalRating
				Case "TotalWRComplete" 
					Return Me.TotalWRComplete
				Case "MechEquipDesc" 
					Return Me.MechEquipDesc
				Case "ElecEquipDesc" 
					Return Me.ElecEquipDesc
				Case "BoilersDesc" 
					Return Me.BoilersDesc
				Case "ProcEquipDesc" 
					Return Me.ProcEquipDesc
				Case "OccupancyDesc" 
					Return Me.OccupancyDesc
				Case "CompSysDesc" 
					Return Me.CompSysDesc
				Case "MechMaintDesc" 
					Return Me.MechMaintDesc
				Case "ElecMaintDesc" 
					Return Me.ElecMaintDesc
				Case "SparesDesc" 
					Return Me.SparesDesc
				Case "HumanElementDesc" 
					Return Me.HumanElementDesc
				Case "BCPDesc" 
					Return Me.BCPDesc
				Case "MechEquipWRDesc" 
					Return Me.MechEquipWRDesc
				Case "ElecEquipWRDesc" 
					Return Me.ElecEquipWRDesc
				Case "BoilersWRDesc" 
					Return Me.BoilersWRDesc
				Case "ProcEquipWRDesc" 
					Return Me.ProcEquipWRDesc
				Case "OccupancyWRDesc" 
					Return Me.OccupancyWRDesc
				Case "CompSysWRDesc" 
					Return Me.CompSysWRDesc
				Case "MechMaintWRDesc" 
					Return Me.MechMaintWRDesc
				Case "ElecMaintWRDesc" 
					Return Me.ElecMaintWRDesc
				Case "SparesWrDesc" 
					Return Me.SparesWrDesc
				Case "HumanElementWRDesc" 
					Return Me.HumanElementWRDesc
				Case "BCPWRDesc" 
					Return Me.BCPWRDesc
				Case "OverallPlantRatingRating" 
					Return Me.OverallPlantRatingRating
				Case "TotalWRCompleteRating" 
					Return Me.TotalWRCompleteRating
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.BoilersC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ProcEquipC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.OccupancyC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.CompSysC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechMaintC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecMaintC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SparesC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.SparesC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.HumanElementC, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bcpc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.Bcpc, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechEquipWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecEquipWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.BoilersWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ProcEquipWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.OccupancyWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.CompSysWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechMaintWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecMaintWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SparesWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.SparesWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWR As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.HumanElementWR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bcpwr As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.Bcpwr, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechEquipWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecEquipWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.BoilersWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ProcEquipWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.OccupancyWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.CompSysWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechMaintWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecMaintWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property SparesWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.SparesWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.HumanElementWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property BCPWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.BCPWeight, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PassiveC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.PassiveC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PassiveWC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.PassiveWC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ActiveC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveWC As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ActiveWC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalScoreCurrent As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.TotalScoreCurrent, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property TotalRating As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.TotalRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWRComplete As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.TotalWRComplete, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechEquipDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecEquipDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.BoilersDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ProcEquipDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.OccupancyDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.CompSysDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechMaintDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecMaintDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.SparesDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.HumanElementDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BCPDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.BCPDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechEquipWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechEquipWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecEquipWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecEquipWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.BoilersWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcEquipWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ProcEquipWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.OccupancyWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.CompSysWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechMaintWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.MechMaintWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMaintWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.ElecMaintWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesWrDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.SparesWrDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.HumanElementWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BCPWRDesc As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.BCPWRDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverallPlantRatingRating As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.OverallPlantRatingRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWRCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, BMRatingMetadata.ColumnNames.TotalWRCompleteRating, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class BMRatingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.InspectionDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRatingMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechEquipC, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecEquipC, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.BoilersC, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.BoilersC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ProcEquipC, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ProcEquipC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.OccupancyC, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.OccupancyC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.CompSysC, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.CompSysC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechMaintC, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechMaintC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecMaintC, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecMaintC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.SparesC, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.SparesC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.HumanElementC, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.HumanElementC
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.Bcpc, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.Bcpc
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechEquipWR, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechEquipWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecEquipWR, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecEquipWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.BoilersWR, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.BoilersWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ProcEquipWR, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ProcEquipWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.OccupancyWR, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.OccupancyWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.CompSysWR, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.CompSysWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechMaintWR, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechMaintWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecMaintWR, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecMaintWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.SparesWR, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.SparesWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.HumanElementWR, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.HumanElementWR
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.Bcpwr, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRatingMetadata.PropertyNames.Bcpwr
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechEquipWeight, 25, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechEquipWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecEquipWeight, 26, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecEquipWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.BoilersWeight, 27, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.BoilersWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ProcEquipWeight, 28, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ProcEquipWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.OccupancyWeight, 29, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.OccupancyWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.CompSysWeight, 30, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.CompSysWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechMaintWeight, 31, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechMaintWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecMaintWeight, 32, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecMaintWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.SparesWeight, 33, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.SparesWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.HumanElementWeight, 34, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.HumanElementWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.BCPWeight, 35, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.BCPWeight
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.PassiveC, 36, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.PassiveC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.PassiveWC, 37, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.PassiveWC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ActiveC, 38, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ActiveC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ActiveWC, 39, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ActiveWC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.TotalScoreCurrent, 40, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.TotalScoreCurrent
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.TotalRating, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.TotalRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.TotalWRComplete, 42, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRatingMetadata.PropertyNames.TotalWRComplete
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechEquipDesc, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechEquipDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecEquipDesc, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecEquipDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.BoilersDesc, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.BoilersDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ProcEquipDesc, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ProcEquipDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.OccupancyDesc, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.OccupancyDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.CompSysDesc, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.CompSysDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechMaintDesc, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechMaintDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecMaintDesc, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecMaintDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.SparesDesc, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.SparesDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.HumanElementDesc, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.HumanElementDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.BCPDesc, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.BCPDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechEquipWRDesc, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechEquipWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecEquipWRDesc, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecEquipWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.BoilersWRDesc, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.BoilersWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ProcEquipWRDesc, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ProcEquipWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.OccupancyWRDesc, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.OccupancyWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.CompSysWRDesc, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.CompSysWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.MechMaintWRDesc, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.MechMaintWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.ElecMaintWRDesc, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.ElecMaintWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.SparesWrDesc, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.SparesWrDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.HumanElementWRDesc, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.HumanElementWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.BCPWRDesc, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.BCPWRDesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.OverallPlantRatingRating, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.OverallPlantRatingRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRatingMetadata.ColumnNames.TotalWRCompleteRating, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRatingMetadata.PropertyNames.TotalWRCompleteRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMRatingMetadata
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
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const MechEquipC As String = "MechEquipC"
			 Public Const ElecEquipC As String = "ElecEquipC"
			 Public Const BoilersC As String = "BoilersC"
			 Public Const ProcEquipC As String = "ProcEquipC"
			 Public Const OccupancyC As String = "OccupancyC"
			 Public Const CompSysC As String = "CompSysC"
			 Public Const MechMaintC As String = "MechMaintC"
			 Public Const ElecMaintC As String = "ElecMaintC"
			 Public Const SparesC As String = "SparesC"
			 Public Const HumanElementC As String = "HumanElementC"
			 Public Const Bcpc As String = "BCPC"
			 Public Const MechEquipWR As String = "MechEquipWR"
			 Public Const ElecEquipWR As String = "ElecEquipWR"
			 Public Const BoilersWR As String = "BoilersWR"
			 Public Const ProcEquipWR As String = "ProcEquipWR"
			 Public Const OccupancyWR As String = "OccupancyWR"
			 Public Const CompSysWR As String = "CompSysWR"
			 Public Const MechMaintWR As String = "MechMaintWR"
			 Public Const ElecMaintWR As String = "ElecMaintWR"
			 Public Const SparesWR As String = "SparesWR"
			 Public Const HumanElementWR As String = "HumanElementWR"
			 Public Const Bcpwr As String = "BCPWR"
			 Public Const MechEquipWeight As String = "MechEquipWeight"
			 Public Const ElecEquipWeight As String = "ElecEquipWeight"
			 Public Const BoilersWeight As String = "BoilersWeight"
			 Public Const ProcEquipWeight As String = "ProcEquipWeight"
			 Public Const OccupancyWeight As String = "OccupancyWeight"
			 Public Const CompSysWeight As String = "CompSysWeight"
			 Public Const MechMaintWeight As String = "MechMaintWeight"
			 Public Const ElecMaintWeight As String = "ElecMaintWeight"
			 Public Const SparesWeight As String = "SparesWeight"
			 Public Const HumanElementWeight As String = "HumanElementWeight"
			 Public Const BCPWeight As String = "BCPWeight"
			 Public Const PassiveC As String = "PassiveC"
			 Public Const PassiveWC As String = "PassiveWC"
			 Public Const ActiveC As String = "ActiveC"
			 Public Const ActiveWC As String = "ActiveWC"
			 Public Const TotalScoreCurrent As String = "TotalScoreCurrent"
			 Public Const TotalRating As String = "TotalRating"
			 Public Const TotalWRComplete As String = "TotalWRComplete"
			 Public Const MechEquipDesc As String = "MechEquipDesc"
			 Public Const ElecEquipDesc As String = "ElecEquipDesc"
			 Public Const BoilersDesc As String = "BoilersDesc"
			 Public Const ProcEquipDesc As String = "ProcEquipDesc"
			 Public Const OccupancyDesc As String = "OccupancyDesc"
			 Public Const CompSysDesc As String = "CompSysDesc"
			 Public Const MechMaintDesc As String = "MechMaintDesc"
			 Public Const ElecMaintDesc As String = "ElecMaintDesc"
			 Public Const SparesDesc As String = "SparesDesc"
			 Public Const HumanElementDesc As String = "HumanElementDesc"
			 Public Const BCPDesc As String = "BCPDesc"
			 Public Const MechEquipWRDesc As String = "MechEquipWRDesc"
			 Public Const ElecEquipWRDesc As String = "ElecEquipWRDesc"
			 Public Const BoilersWRDesc As String = "BoilersWRDesc"
			 Public Const ProcEquipWRDesc As String = "ProcEquipWRDesc"
			 Public Const OccupancyWRDesc As String = "OccupancyWRDesc"
			 Public Const CompSysWRDesc As String = "CompSysWRDesc"
			 Public Const MechMaintWRDesc As String = "MechMaintWRDesc"
			 Public Const ElecMaintWRDesc As String = "ElecMaintWRDesc"
			 Public Const SparesWrDesc As String = "SparesWrDesc"
			 Public Const HumanElementWRDesc As String = "HumanElementWRDesc"
			 Public Const BCPWRDesc As String = "BCPWRDesc"
			 Public Const OverallPlantRatingRating As String = "OverallPlantRatingRating"
			 Public Const TotalWRCompleteRating As String = "TotalWRCompleteRating"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const MechEquipC As String = "MechEquipC"
			 Public Const ElecEquipC As String = "ElecEquipC"
			 Public Const BoilersC As String = "BoilersC"
			 Public Const ProcEquipC As String = "ProcEquipC"
			 Public Const OccupancyC As String = "OccupancyC"
			 Public Const CompSysC As String = "CompSysC"
			 Public Const MechMaintC As String = "MechMaintC"
			 Public Const ElecMaintC As String = "ElecMaintC"
			 Public Const SparesC As String = "SparesC"
			 Public Const HumanElementC As String = "HumanElementC"
			 Public Const Bcpc As String = "Bcpc"
			 Public Const MechEquipWR As String = "MechEquipWR"
			 Public Const ElecEquipWR As String = "ElecEquipWR"
			 Public Const BoilersWR As String = "BoilersWR"
			 Public Const ProcEquipWR As String = "ProcEquipWR"
			 Public Const OccupancyWR As String = "OccupancyWR"
			 Public Const CompSysWR As String = "CompSysWR"
			 Public Const MechMaintWR As String = "MechMaintWR"
			 Public Const ElecMaintWR As String = "ElecMaintWR"
			 Public Const SparesWR As String = "SparesWR"
			 Public Const HumanElementWR As String = "HumanElementWR"
			 Public Const Bcpwr As String = "Bcpwr"
			 Public Const MechEquipWeight As String = "MechEquipWeight"
			 Public Const ElecEquipWeight As String = "ElecEquipWeight"
			 Public Const BoilersWeight As String = "BoilersWeight"
			 Public Const ProcEquipWeight As String = "ProcEquipWeight"
			 Public Const OccupancyWeight As String = "OccupancyWeight"
			 Public Const CompSysWeight As String = "CompSysWeight"
			 Public Const MechMaintWeight As String = "MechMaintWeight"
			 Public Const ElecMaintWeight As String = "ElecMaintWeight"
			 Public Const SparesWeight As String = "SparesWeight"
			 Public Const HumanElementWeight As String = "HumanElementWeight"
			 Public Const BCPWeight As String = "BCPWeight"
			 Public Const PassiveC As String = "PassiveC"
			 Public Const PassiveWC As String = "PassiveWC"
			 Public Const ActiveC As String = "ActiveC"
			 Public Const ActiveWC As String = "ActiveWC"
			 Public Const TotalScoreCurrent As String = "TotalScoreCurrent"
			 Public Const TotalRating As String = "TotalRating"
			 Public Const TotalWRComplete As String = "TotalWRComplete"
			 Public Const MechEquipDesc As String = "MechEquipDesc"
			 Public Const ElecEquipDesc As String = "ElecEquipDesc"
			 Public Const BoilersDesc As String = "BoilersDesc"
			 Public Const ProcEquipDesc As String = "ProcEquipDesc"
			 Public Const OccupancyDesc As String = "OccupancyDesc"
			 Public Const CompSysDesc As String = "CompSysDesc"
			 Public Const MechMaintDesc As String = "MechMaintDesc"
			 Public Const ElecMaintDesc As String = "ElecMaintDesc"
			 Public Const SparesDesc As String = "SparesDesc"
			 Public Const HumanElementDesc As String = "HumanElementDesc"
			 Public Const BCPDesc As String = "BCPDesc"
			 Public Const MechEquipWRDesc As String = "MechEquipWRDesc"
			 Public Const ElecEquipWRDesc As String = "ElecEquipWRDesc"
			 Public Const BoilersWRDesc As String = "BoilersWRDesc"
			 Public Const ProcEquipWRDesc As String = "ProcEquipWRDesc"
			 Public Const OccupancyWRDesc As String = "OccupancyWRDesc"
			 Public Const CompSysWRDesc As String = "CompSysWRDesc"
			 Public Const MechMaintWRDesc As String = "MechMaintWRDesc"
			 Public Const ElecMaintWRDesc As String = "ElecMaintWRDesc"
			 Public Const SparesWrDesc As String = "SparesWrDesc"
			 Public Const HumanElementWRDesc As String = "HumanElementWRDesc"
			 Public Const BCPWRDesc As String = "BCPWRDesc"
			 Public Const OverallPlantRatingRating As String = "OverallPlantRatingRating"
			 Public Const TotalWRCompleteRating As String = "TotalWRCompleteRating"
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
			SyncLock GetType(BMRatingMetadata)
			
				If BMRatingMetadata.mapDelegates Is Nothing Then
					BMRatingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMRatingMetadata._meta Is Nothing Then
					BMRatingMetadata._meta = New BMRatingMetadata()
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
				meta.AddTypeMap("InspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("MechEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BoilersC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProcEquipC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("OccupancyC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CompSysC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechMaintC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecMaintC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SparesC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("HumanElementC", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bcpc", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechEquipWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecEquipWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BoilersWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProcEquipWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("OccupancyWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CompSysWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechMaintWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ElecMaintWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SparesWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("HumanElementWR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bcpwr", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MechEquipWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ElecEquipWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("BoilersWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ProcEquipWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("OccupancyWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CompSysWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MechMaintWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ElecMaintWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("SparesWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("HumanElementWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("BCPWeight", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PassiveC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PassiveWC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ActiveC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ActiveWC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotalScoreCurrent", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("TotalRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TotalWRComplete", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("MechEquipDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecEquipDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProcEquipDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OccupancyDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompSysDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechMaintDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecMaintDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SparesDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HumanElementDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BCPDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechEquipWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecEquipWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProcEquipWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OccupancyWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompSysWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechMaintWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecMaintWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SparesWrDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HumanElementWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BCPWRDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OverallPlantRatingRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalWRCompleteRating", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "BM-Rating"
				meta.Destination = "BM-Rating"
				
				meta.spInsert = "proc_BM-RatingInsert"
				meta.spUpdate = "proc_BM-RatingUpdate"
				meta.spDelete = "proc_BM-RatingDelete"
				meta.spLoadAll = "proc_BM-RatingLoadAll"
				meta.spLoadByPrimaryKey = "proc_BM-RatingLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMRatingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
