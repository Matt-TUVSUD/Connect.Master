
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:24 PM
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
	' Encapsulates the 'NatHaz-Seismic-Nonstructural' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazSeismicNonstructural))> _
	<XmlType("NatHazSeismicNonstructural")> _	
	Partial Public Class NatHazSeismicNonstructural 
		Inherits esNatHazSeismicNonstructural
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazSeismicNonstructural()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazSeismicNonstructural()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazSeismicNonstructural()
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
	<XmlType("NatHazSeismicNonstructuralCollection")> _
	Partial Public Class NatHazSeismicNonstructuralCollection
		Inherits esNatHazSeismicNonstructuralCollection
		Implements IEnumerable(Of NatHazSeismicNonstructural)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazSeismicNonstructural
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazSeismicNonstructural))> _
		Public Class NatHazSeismicNonstructuralCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazSeismicNonstructuralCollection)
			
			Public Shared Widening Operator CType(packet As NatHazSeismicNonstructuralCollectionWCFPacket) As NatHazSeismicNonstructuralCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazSeismicNonstructuralCollection) As NatHazSeismicNonstructuralCollectionWCFPacket
				Return New NatHazSeismicNonstructuralCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazSeismicNonstructuralQuery 
		Inherits esNatHazSeismicNonstructuralQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazSeismicNonstructuralQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazSeismicNonstructuralQuery) As String
			Return NatHazSeismicNonstructuralQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazSeismicNonstructuralQuery
			Return DirectCast(NatHazSeismicNonstructuralQuery.SerializeHelper.FromXml(query, GetType(NatHazSeismicNonstructuralQuery)), NatHazSeismicNonstructuralQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazSeismicNonstructural
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
		
			Dim query As New NatHazSeismicNonstructuralQuery()
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
		' Maps to NatHaz-Seismic-Nonstructural.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazSeismicNonstructuralMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazSeismicNonstructuralMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicNonstructuralMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicNonstructuralMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.SSOV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ssov As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Ssov)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Ssov, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Ssov)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.SSOVComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSOVComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SSOVComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SSOVComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.SSOVComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.FPGen
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FPGen As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.FPGen)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.FPGen, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.FPGen)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.FPGenComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FPGenComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.FPGenComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.FPGenComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.FPGenComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.HazMat
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HazMat As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.HazMat)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.HazMat, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.HazMat)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.HazMatComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HazMatComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.HazMatComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.HazMatComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.HazMatComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.UGUtil
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UGUtil As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.UGUtil)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.UGUtil, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.UGUtil)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.UGUtilComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UGUtilComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.UGUtilComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.UGUtilComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.UGUtilComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.Xform
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Xform As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Xform)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Xform, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Xform)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.XformComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.XformComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.XformComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.XformComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.Switchgear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Switchgear As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Switchgear)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Switchgear, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Switchgear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.SwitchgearComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SwitchgearComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SwitchgearComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SwitchgearComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.SwitchgearComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.ITTele
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ITTele As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.ITTele)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.ITTele, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.ITTele)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.ITTeleComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ITTeleComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.ITTeleComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.ITTeleComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.ITTeleComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.SSBrace
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSBrace As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SSBrace)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SSBrace, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.SSBrace)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.SSBraceComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SSBraceComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SSBraceComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SSBraceComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.SSBraceComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.PipeCable
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PipeCable As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.PipeCable)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.PipeCable, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.PipeCable)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.PipeCableComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PipeCableComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.PipeCableComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.PipeCableComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.PipeCableComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.HVACCT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hvacct As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Hvacct)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Hvacct, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Hvacct)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.HVACCTComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HVACCTComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.HVACCTComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.HVACCTComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.HVACCTComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.Storage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Storage As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Storage)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Storage, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Storage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.StorageComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StorageComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.StorageComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.StorageComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.StorageComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.Process
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Process As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Process)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.Process, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Process)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.ProcessComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcessComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.ProcessComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.ProcessComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.ProcessComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.EmerRespRecoveryRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmerRespRecoveryRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.EmerRespRecoveryRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.EmerRespRecoveryRating, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.EmerRespRecoveryRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.EmerRespRecoveryComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmerRespRecoveryComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.EmerRespRecoveryComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.EmerRespRecoveryComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.EmerRespRecoveryComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.SNSOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SNSOther As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SNSOther)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SNSOther, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.SNSOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.SNSOtherComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SNSOtherComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SNSOtherComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicNonstructuralMetadata.ColumnNames.SNSOtherComments, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.SNSOtherComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicNonstructuralMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicNonstructuralMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Nonstructural.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicNonstructuralMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicNonstructuralMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Importorigdate)
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
												
						Case "SurveyDate"
							Me.str().SurveyDate = CType(value, string)
												
						Case "Ssov"
							Me.str().Ssov = CType(value, string)
												
						Case "SSOVComments"
							Me.str().SSOVComments = CType(value, string)
												
						Case "FPGen"
							Me.str().FPGen = CType(value, string)
												
						Case "FPGenComments"
							Me.str().FPGenComments = CType(value, string)
												
						Case "HazMat"
							Me.str().HazMat = CType(value, string)
												
						Case "HazMatComments"
							Me.str().HazMatComments = CType(value, string)
												
						Case "UGUtil"
							Me.str().UGUtil = CType(value, string)
												
						Case "UGUtilComments"
							Me.str().UGUtilComments = CType(value, string)
												
						Case "Xform"
							Me.str().Xform = CType(value, string)
												
						Case "XformComments"
							Me.str().XformComments = CType(value, string)
												
						Case "Switchgear"
							Me.str().Switchgear = CType(value, string)
												
						Case "SwitchgearComments"
							Me.str().SwitchgearComments = CType(value, string)
												
						Case "ITTele"
							Me.str().ITTele = CType(value, string)
												
						Case "ITTeleComments"
							Me.str().ITTeleComments = CType(value, string)
												
						Case "SSBrace"
							Me.str().SSBrace = CType(value, string)
												
						Case "SSBraceComments"
							Me.str().SSBraceComments = CType(value, string)
												
						Case "PipeCable"
							Me.str().PipeCable = CType(value, string)
												
						Case "PipeCableComments"
							Me.str().PipeCableComments = CType(value, string)
												
						Case "Hvacct"
							Me.str().Hvacct = CType(value, string)
												
						Case "HVACCTComments"
							Me.str().HVACCTComments = CType(value, string)
												
						Case "Storage"
							Me.str().Storage = CType(value, string)
												
						Case "StorageComments"
							Me.str().StorageComments = CType(value, string)
												
						Case "Process"
							Me.str().Process = CType(value, string)
												
						Case "ProcessComments"
							Me.str().ProcessComments = CType(value, string)
												
						Case "EmerRespRecoveryRating"
							Me.str().EmerRespRecoveryRating = CType(value, string)
												
						Case "EmerRespRecoveryComments"
							Me.str().EmerRespRecoveryComments = CType(value, string)
												
						Case "SNSOther"
							Me.str().SNSOther = CType(value, string)
												
						Case "SNSOtherComments"
							Me.str().SNSOtherComments = CType(value, string)
												
						Case "Importdate"
							Me.str().Importdate = CType(value, string)
												
						Case "Importorigdate"
							Me.str().Importorigdate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicNonstructuralMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazSeismicNonstructural)
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
		  	
			Public Property Ssov As System.String 
				Get
					Dim data_ As System.String = entity.Ssov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ssov = Nothing
					Else
						entity.Ssov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSOVComments As System.String 
				Get
					Dim data_ As System.String = entity.SSOVComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSOVComments = Nothing
					Else
						entity.SSOVComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FPGen As System.String 
				Get
					Dim data_ As System.String = entity.FPGen
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FPGen = Nothing
					Else
						entity.FPGen = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FPGenComments As System.String 
				Get
					Dim data_ As System.String = entity.FPGenComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FPGenComments = Nothing
					Else
						entity.FPGenComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazMat As System.String 
				Get
					Dim data_ As System.String = entity.HazMat
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazMat = Nothing
					Else
						entity.HazMat = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazMatComments As System.String 
				Get
					Dim data_ As System.String = entity.HazMatComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazMatComments = Nothing
					Else
						entity.HazMatComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UGUtil As System.String 
				Get
					Dim data_ As System.String = entity.UGUtil
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UGUtil = Nothing
					Else
						entity.UGUtil = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UGUtilComments As System.String 
				Get
					Dim data_ As System.String = entity.UGUtilComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UGUtilComments = Nothing
					Else
						entity.UGUtilComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Xform As System.String 
				Get
					Dim data_ As System.String = entity.Xform
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Xform = Nothing
					Else
						entity.Xform = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformComments As System.String 
				Get
					Dim data_ As System.String = entity.XformComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformComments = Nothing
					Else
						entity.XformComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Switchgear As System.String 
				Get
					Dim data_ As System.String = entity.Switchgear
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Switchgear = Nothing
					Else
						entity.Switchgear = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SwitchgearComments As System.String 
				Get
					Dim data_ As System.String = entity.SwitchgearComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SwitchgearComments = Nothing
					Else
						entity.SwitchgearComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ITTele As System.String 
				Get
					Dim data_ As System.String = entity.ITTele
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ITTele = Nothing
					Else
						entity.ITTele = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ITTeleComments As System.String 
				Get
					Dim data_ As System.String = entity.ITTeleComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ITTeleComments = Nothing
					Else
						entity.ITTeleComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSBrace As System.String 
				Get
					Dim data_ As System.String = entity.SSBrace
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSBrace = Nothing
					Else
						entity.SSBrace = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SSBraceComments As System.String 
				Get
					Dim data_ As System.String = entity.SSBraceComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SSBraceComments = Nothing
					Else
						entity.SSBraceComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PipeCable As System.String 
				Get
					Dim data_ As System.String = entity.PipeCable
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PipeCable = Nothing
					Else
						entity.PipeCable = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PipeCableComments As System.String 
				Get
					Dim data_ As System.String = entity.PipeCableComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PipeCableComments = Nothing
					Else
						entity.PipeCableComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hvacct As System.String 
				Get
					Dim data_ As System.String = entity.Hvacct
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hvacct = Nothing
					Else
						entity.Hvacct = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HVACCTComments As System.String 
				Get
					Dim data_ As System.String = entity.HVACCTComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HVACCTComments = Nothing
					Else
						entity.HVACCTComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Storage As System.String 
				Get
					Dim data_ As System.String = entity.Storage
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Storage = Nothing
					Else
						entity.Storage = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StorageComments As System.String 
				Get
					Dim data_ As System.String = entity.StorageComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StorageComments = Nothing
					Else
						entity.StorageComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Process As System.String 
				Get
					Dim data_ As System.String = entity.Process
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Process = Nothing
					Else
						entity.Process = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcessComments As System.String 
				Get
					Dim data_ As System.String = entity.ProcessComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcessComments = Nothing
					Else
						entity.ProcessComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmerRespRecoveryRating As System.String 
				Get
					Dim data_ As System.String = entity.EmerRespRecoveryRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmerRespRecoveryRating = Nothing
					Else
						entity.EmerRespRecoveryRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmerRespRecoveryComments As System.String 
				Get
					Dim data_ As System.String = entity.EmerRespRecoveryComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmerRespRecoveryComments = Nothing
					Else
						entity.EmerRespRecoveryComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SNSOther As System.String 
				Get
					Dim data_ As System.String = entity.SNSOther
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SNSOther = Nothing
					Else
						entity.SNSOther = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SNSOtherComments As System.String 
				Get
					Dim data_ As System.String = entity.SNSOtherComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SNSOtherComments = Nothing
					Else
						entity.SNSOtherComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Importdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Importdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Importdate = Nothing
					Else
						entity.Importdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Importorigdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Importorigdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Importorigdate = Nothing
					Else
						entity.Importorigdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esNatHazSeismicNonstructural
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazSeismicNonstructuralMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazSeismicNonstructuralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazSeismicNonstructuralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazSeismicNonstructuralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazSeismicNonstructuralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazSeismicNonstructuralQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazSeismicNonstructuralCollection
		Inherits esEntityCollection(Of NatHazSeismicNonstructural)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazSeismicNonstructuralMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazSeismicNonstructuralCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazSeismicNonstructuralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazSeismicNonstructuralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazSeismicNonstructuralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazSeismicNonstructuralQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazSeismicNonstructuralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazSeismicNonstructuralQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazSeismicNonstructuralQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazSeismicNonstructuralQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazSeismicNonstructuralMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "SurveyDate" 
					Return Me.SurveyDate
				Case "Ssov" 
					Return Me.Ssov
				Case "SSOVComments" 
					Return Me.SSOVComments
				Case "FPGen" 
					Return Me.FPGen
				Case "FPGenComments" 
					Return Me.FPGenComments
				Case "HazMat" 
					Return Me.HazMat
				Case "HazMatComments" 
					Return Me.HazMatComments
				Case "UGUtil" 
					Return Me.UGUtil
				Case "UGUtilComments" 
					Return Me.UGUtilComments
				Case "Xform" 
					Return Me.Xform
				Case "XformComments" 
					Return Me.XformComments
				Case "Switchgear" 
					Return Me.Switchgear
				Case "SwitchgearComments" 
					Return Me.SwitchgearComments
				Case "ITTele" 
					Return Me.ITTele
				Case "ITTeleComments" 
					Return Me.ITTeleComments
				Case "SSBrace" 
					Return Me.SSBrace
				Case "SSBraceComments" 
					Return Me.SSBraceComments
				Case "PipeCable" 
					Return Me.PipeCable
				Case "PipeCableComments" 
					Return Me.PipeCableComments
				Case "Hvacct" 
					Return Me.Hvacct
				Case "HVACCTComments" 
					Return Me.HVACCTComments
				Case "Storage" 
					Return Me.Storage
				Case "StorageComments" 
					Return Me.StorageComments
				Case "Process" 
					Return Me.Process
				Case "ProcessComments" 
					Return Me.ProcessComments
				Case "EmerRespRecoveryRating" 
					Return Me.EmerRespRecoveryRating
				Case "EmerRespRecoveryComments" 
					Return Me.EmerRespRecoveryComments
				Case "SNSOther" 
					Return Me.SNSOther
				Case "SNSOtherComments" 
					Return Me.SNSOtherComments
				Case "Importdate" 
					Return Me.Importdate
				Case "Importorigdate" 
					Return Me.Importorigdate
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Ssov As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Ssov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSOVComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.SSOVComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FPGen As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.FPGen, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FPGenComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.FPGenComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazMat As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.HazMat, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazMatComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.HazMatComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UGUtil As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.UGUtil, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UGUtilComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.UGUtilComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Xform As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Xform, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property XformComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.XformComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Switchgear As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Switchgear, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SwitchgearComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.SwitchgearComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ITTele As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.ITTele, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ITTeleComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.ITTeleComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSBrace As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.SSBrace, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SSBraceComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.SSBraceComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PipeCable As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.PipeCable, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PipeCableComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.PipeCableComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hvacct As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Hvacct, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HVACCTComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.HVACCTComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Storage As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Storage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StorageComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.StorageComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Process As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Process, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcessComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.ProcessComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmerRespRecoveryRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.EmerRespRecoveryRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmerRespRecoveryComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.EmerRespRecoveryComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SNSOther As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.SNSOther, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SNSOtherComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.SNSOtherComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicNonstructuralMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazSeismicNonstructuralMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Ssov, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Ssov
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.SSOVComments, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.SSOVComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.FPGen, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.FPGen
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.FPGenComments, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.FPGenComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.HazMat, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.HazMat
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.HazMatComments, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.HazMatComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.UGUtil, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.UGUtil
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.UGUtilComments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.UGUtilComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Xform, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Xform
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.XformComments, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.XformComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Switchgear, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Switchgear
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.SwitchgearComments, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.SwitchgearComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.ITTele, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.ITTele
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.ITTeleComments, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.ITTeleComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.SSBrace, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.SSBrace
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.SSBraceComments, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.SSBraceComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.PipeCable, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.PipeCable
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.PipeCableComments, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.PipeCableComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Hvacct, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Hvacct
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.HVACCTComments, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.HVACCTComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Storage, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Storage
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.StorageComments, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.StorageComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Process, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Process
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.ProcessComments, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.ProcessComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.EmerRespRecoveryRating, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.EmerRespRecoveryRating
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.EmerRespRecoveryComments, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.EmerRespRecoveryComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.SNSOther, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.SNSOther
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.SNSOtherComments, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.SNSOtherComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Importdate, 31, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicNonstructuralMetadata.ColumnNames.Importorigdate, 32, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicNonstructuralMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazSeismicNonstructuralMetadata
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
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Ssov As String = "SSOV"
			 Public Const SSOVComments As String = "SSOVComments"
			 Public Const FPGen As String = "FPGen"
			 Public Const FPGenComments As String = "FPGenComments"
			 Public Const HazMat As String = "HazMat"
			 Public Const HazMatComments As String = "HazMatComments"
			 Public Const UGUtil As String = "UGUtil"
			 Public Const UGUtilComments As String = "UGUtilComments"
			 Public Const Xform As String = "Xform"
			 Public Const XformComments As String = "XformComments"
			 Public Const Switchgear As String = "Switchgear"
			 Public Const SwitchgearComments As String = "SwitchgearComments"
			 Public Const ITTele As String = "ITTele"
			 Public Const ITTeleComments As String = "ITTeleComments"
			 Public Const SSBrace As String = "SSBrace"
			 Public Const SSBraceComments As String = "SSBraceComments"
			 Public Const PipeCable As String = "PipeCable"
			 Public Const PipeCableComments As String = "PipeCableComments"
			 Public Const Hvacct As String = "HVACCT"
			 Public Const HVACCTComments As String = "HVACCTComments"
			 Public Const Storage As String = "Storage"
			 Public Const StorageComments As String = "StorageComments"
			 Public Const Process As String = "Process"
			 Public Const ProcessComments As String = "ProcessComments"
			 Public Const EmerRespRecoveryRating As String = "EmerRespRecoveryRating"
			 Public Const EmerRespRecoveryComments As String = "EmerRespRecoveryComments"
			 Public Const SNSOther As String = "SNSOther"
			 Public Const SNSOtherComments As String = "SNSOtherComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Ssov As String = "Ssov"
			 Public Const SSOVComments As String = "SSOVComments"
			 Public Const FPGen As String = "FPGen"
			 Public Const FPGenComments As String = "FPGenComments"
			 Public Const HazMat As String = "HazMat"
			 Public Const HazMatComments As String = "HazMatComments"
			 Public Const UGUtil As String = "UGUtil"
			 Public Const UGUtilComments As String = "UGUtilComments"
			 Public Const Xform As String = "Xform"
			 Public Const XformComments As String = "XformComments"
			 Public Const Switchgear As String = "Switchgear"
			 Public Const SwitchgearComments As String = "SwitchgearComments"
			 Public Const ITTele As String = "ITTele"
			 Public Const ITTeleComments As String = "ITTeleComments"
			 Public Const SSBrace As String = "SSBrace"
			 Public Const SSBraceComments As String = "SSBraceComments"
			 Public Const PipeCable As String = "PipeCable"
			 Public Const PipeCableComments As String = "PipeCableComments"
			 Public Const Hvacct As String = "Hvacct"
			 Public Const HVACCTComments As String = "HVACCTComments"
			 Public Const Storage As String = "Storage"
			 Public Const StorageComments As String = "StorageComments"
			 Public Const Process As String = "Process"
			 Public Const ProcessComments As String = "ProcessComments"
			 Public Const EmerRespRecoveryRating As String = "EmerRespRecoveryRating"
			 Public Const EmerRespRecoveryComments As String = "EmerRespRecoveryComments"
			 Public Const SNSOther As String = "SNSOther"
			 Public Const SNSOtherComments As String = "SNSOtherComments"
			 Public Const Importdate As String = "Importdate"
			 Public Const Importorigdate As String = "Importorigdate"
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
			SyncLock GetType(NatHazSeismicNonstructuralMetadata)
			
				If NatHazSeismicNonstructuralMetadata.mapDelegates Is Nothing Then
					NatHazSeismicNonstructuralMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazSeismicNonstructuralMetadata._meta Is Nothing Then
					NatHazSeismicNonstructuralMetadata._meta = New NatHazSeismicNonstructuralMetadata()
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
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SurveyDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Ssov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SSOVComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("FPGen", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FPGenComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("HazMat", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HazMatComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("UGUtil", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("UGUtilComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Xform", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("XformComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Switchgear", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SwitchgearComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("ITTele", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ITTeleComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("SSBrace", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SSBraceComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("PipeCable", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PipeCableComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Hvacct", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HVACCTComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Storage", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StorageComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Process", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProcessComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("EmerRespRecoveryRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmerRespRecoveryComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("SNSOther", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SNSOtherComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Seismic-Nonstructural"
				meta.Destination = "NatHaz-Seismic-Nonstructural"
				
				meta.spInsert = "proc_NatHaz-Seismic-NonstructuralInsert"
				meta.spUpdate = "proc_NatHaz-Seismic-NonstructuralUpdate"
				meta.spDelete = "proc_NatHaz-Seismic-NonstructuralDelete"
				meta.spLoadAll = "proc_NatHaz-Seismic-NonstructuralLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Seismic-NonstructuralLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazSeismicNonstructuralMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
