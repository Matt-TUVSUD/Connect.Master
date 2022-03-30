
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
	' Encapsulates the 'NatHaz-Seismic-Structural' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazSeismicStructural))> _
	<XmlType("NatHazSeismicStructural")> _	
	Partial Public Class NatHazSeismicStructural 
		Inherits esNatHazSeismicStructural
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazSeismicStructural()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazSeismicStructural()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazSeismicStructural()
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
	<XmlType("NatHazSeismicStructuralCollection")> _
	Partial Public Class NatHazSeismicStructuralCollection
		Inherits esNatHazSeismicStructuralCollection
		Implements IEnumerable(Of NatHazSeismicStructural)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazSeismicStructural
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazSeismicStructural))> _
		Public Class NatHazSeismicStructuralCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazSeismicStructuralCollection)
			
			Public Shared Widening Operator CType(packet As NatHazSeismicStructuralCollectionWCFPacket) As NatHazSeismicStructuralCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazSeismicStructuralCollection) As NatHazSeismicStructuralCollectionWCFPacket
				Return New NatHazSeismicStructuralCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazSeismicStructuralQuery 
		Inherits esNatHazSeismicStructuralQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazSeismicStructuralQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazSeismicStructuralQuery) As String
			Return NatHazSeismicStructuralQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazSeismicStructuralQuery
			Return DirectCast(NatHazSeismicStructuralQuery.SerializeHelper.FromXml(query, GetType(NatHazSeismicStructuralQuery)), NatHazSeismicStructuralQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazSeismicStructural
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
		
			Dim query As New NatHazSeismicStructuralQuery()
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
		' Maps to NatHaz-Seismic-Structural.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazSeismicStructuralMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazSeismicStructuralMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicStructuralMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicStructuralMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.WoodFrame
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WoodFrame As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.WoodFrame)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.WoodFrame, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.WoodFrame)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.URM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Urm As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.Urm)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.Urm, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Urm)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.ReinfMas
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReinfMas As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.ReinfMas)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.ReinfMas, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.ReinfMas)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.RMwRC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RMwRC As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.RMwRC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.RMwRC, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.RMwRC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.RC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rc As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.Rc)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.Rc, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Rc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.RCSheer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RCSheer As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.RCSheer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.RCSheer, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.RCSheer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.PreCast
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PreCast As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.PreCast)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.PreCast, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.PreCast)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.Tiltup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tiltup As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.Tiltup)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.Tiltup, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Tiltup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.LtMetal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LtMetal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.LtMetal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.LtMetal, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.LtMetal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.StFr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StFr As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.StFr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.StFr, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.StFr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.BrStFr
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BrStFr As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.BrStFr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.BrStFr, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.BrStFr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.Unk
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Unk As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.Unk)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicStructuralMetadata.ColumnNames.Unk, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Unk)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.UnkDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UnkDesc As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.UnkDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.UnkDesc, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.UnkDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.ConstComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.ConstComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.ConstComments, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.ConstComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.Irreg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Irreg As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazSeismicStructuralMetadata.ColumnNames.Irreg)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazSeismicStructuralMetadata.ColumnNames.Irreg, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Irreg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.Pounding
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pounding As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazSeismicStructuralMetadata.ColumnNames.Pounding)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazSeismicStructuralMetadata.ColumnNames.Pounding, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Pounding)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.SoftStory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SoftStory As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazSeismicStructuralMetadata.ColumnNames.SoftStory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazSeismicStructuralMetadata.ColumnNames.SoftStory, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.SoftStory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.SeismicStructRiskEval
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicStructRiskEval As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazSeismicStructuralMetadata.ColumnNames.SeismicStructRiskEval)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazSeismicStructuralMetadata.ColumnNames.SeismicStructRiskEval, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.SeismicStructRiskEval)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.SeismicStructRiskEvalComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicStructRiskEvalComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.SeismicStructRiskEvalComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.SeismicStructRiskEvalComments, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.SeismicStructRiskEvalComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.BldgCondition
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BldgCondition As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.BldgCondition)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.BldgCondition, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.BldgCondition)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.BldgConditionComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BldgConditionComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.BldgConditionComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicStructuralMetadata.ColumnNames.BldgConditionComments, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.BldgConditionComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicStructuralMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicStructuralMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-Structural.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicStructuralMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicStructuralMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Importorigdate)
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
												
						Case "WoodFrame"
							Me.str().WoodFrame = CType(value, string)
												
						Case "Urm"
							Me.str().Urm = CType(value, string)
												
						Case "ReinfMas"
							Me.str().ReinfMas = CType(value, string)
												
						Case "RMwRC"
							Me.str().RMwRC = CType(value, string)
												
						Case "Rc"
							Me.str().Rc = CType(value, string)
												
						Case "RCSheer"
							Me.str().RCSheer = CType(value, string)
												
						Case "PreCast"
							Me.str().PreCast = CType(value, string)
												
						Case "Tiltup"
							Me.str().Tiltup = CType(value, string)
												
						Case "LtMetal"
							Me.str().LtMetal = CType(value, string)
												
						Case "StFr"
							Me.str().StFr = CType(value, string)
												
						Case "BrStFr"
							Me.str().BrStFr = CType(value, string)
												
						Case "Unk"
							Me.str().Unk = CType(value, string)
												
						Case "UnkDesc"
							Me.str().UnkDesc = CType(value, string)
												
						Case "ConstComments"
							Me.str().ConstComments = CType(value, string)
												
						Case "Irreg"
							Me.str().Irreg = CType(value, string)
												
						Case "Pounding"
							Me.str().Pounding = CType(value, string)
												
						Case "SoftStory"
							Me.str().SoftStory = CType(value, string)
												
						Case "SeismicStructRiskEval"
							Me.str().SeismicStructRiskEval = CType(value, string)
												
						Case "SeismicStructRiskEvalComments"
							Me.str().SeismicStructRiskEvalComments = CType(value, string)
												
						Case "BldgCondition"
							Me.str().BldgCondition = CType(value, string)
												
						Case "BldgConditionComments"
							Me.str().BldgConditionComments = CType(value, string)
												
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
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "WoodFrame"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.WoodFrame = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.WoodFrame)
							End If
						
						Case "Urm"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Urm = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Urm)
							End If
						
						Case "ReinfMas"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ReinfMas = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.ReinfMas)
							End If
						
						Case "RMwRC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RMwRC = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.RMwRC)
							End If
						
						Case "Rc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Rc = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Rc)
							End If
						
						Case "RCSheer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RCSheer = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.RCSheer)
							End If
						
						Case "PreCast"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PreCast = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.PreCast)
							End If
						
						Case "Tiltup"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Tiltup = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Tiltup)
							End If
						
						Case "LtMetal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.LtMetal = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.LtMetal)
							End If
						
						Case "StFr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.StFr = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.StFr)
							End If
						
						Case "BrStFr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.BrStFr = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.BrStFr)
							End If
						
						Case "Unk"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Unk = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Unk)
							End If
						
						Case "Irreg"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Irreg = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Irreg)
							End If
						
						Case "Pounding"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Pounding = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Pounding)
							End If
						
						Case "SoftStory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SoftStory = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.SoftStory)
							End If
						
						Case "SeismicStructRiskEval"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SeismicStructRiskEval = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.SeismicStructRiskEval)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicStructuralMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazSeismicStructural)
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
		  	
			Public Property WoodFrame As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.WoodFrame
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WoodFrame = Nothing
					Else
						entity.WoodFrame = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Urm As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Urm
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Urm = Nothing
					Else
						entity.Urm = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReinfMas As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ReinfMas
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReinfMas = Nothing
					Else
						entity.ReinfMas = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMwRC As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RMwRC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMwRC = Nothing
					Else
						entity.RMwRC = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rc As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Rc
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rc = Nothing
					Else
						entity.Rc = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RCSheer As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RCSheer
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RCSheer = Nothing
					Else
						entity.RCSheer = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PreCast As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PreCast
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PreCast = Nothing
					Else
						entity.PreCast = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Tiltup As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Tiltup
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Tiltup = Nothing
					Else
						entity.Tiltup = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property LtMetal As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.LtMetal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LtMetal = Nothing
					Else
						entity.LtMetal = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property StFr As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.StFr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StFr = Nothing
					Else
						entity.StFr = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property BrStFr As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.BrStFr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BrStFr = Nothing
					Else
						entity.BrStFr = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unk As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Unk
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unk = Nothing
					Else
						entity.Unk = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property UnkDesc As System.String 
				Get
					Dim data_ As System.String = entity.UnkDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UnkDesc = Nothing
					Else
						entity.UnkDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstComments As System.String 
				Get
					Dim data_ As System.String = entity.ConstComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstComments = Nothing
					Else
						entity.ConstComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Irreg As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Irreg
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Irreg = Nothing
					Else
						entity.Irreg = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pounding As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Pounding
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pounding = Nothing
					Else
						entity.Pounding = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SoftStory As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SoftStory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SoftStory = Nothing
					Else
						entity.SoftStory = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicStructRiskEval As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SeismicStructRiskEval
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicStructRiskEval = Nothing
					Else
						entity.SeismicStructRiskEval = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicStructRiskEvalComments As System.String 
				Get
					Dim data_ As System.String = entity.SeismicStructRiskEvalComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicStructRiskEvalComments = Nothing
					Else
						entity.SeismicStructRiskEvalComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BldgCondition As System.String 
				Get
					Dim data_ As System.String = entity.BldgCondition
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BldgCondition = Nothing
					Else
						entity.BldgCondition = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BldgConditionComments As System.String 
				Get
					Dim data_ As System.String = entity.BldgConditionComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BldgConditionComments = Nothing
					Else
						entity.BldgConditionComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazSeismicStructural
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazSeismicStructuralMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazSeismicStructuralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazSeismicStructuralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazSeismicStructuralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazSeismicStructuralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazSeismicStructuralQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazSeismicStructuralCollection
		Inherits esEntityCollection(Of NatHazSeismicStructural)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazSeismicStructuralMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazSeismicStructuralCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazSeismicStructuralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazSeismicStructuralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazSeismicStructuralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazSeismicStructuralQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazSeismicStructuralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazSeismicStructuralQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazSeismicStructuralQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazSeismicStructuralQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazSeismicStructuralMetadata.Meta()
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
				Case "WoodFrame" 
					Return Me.WoodFrame
				Case "Urm" 
					Return Me.Urm
				Case "ReinfMas" 
					Return Me.ReinfMas
				Case "RMwRC" 
					Return Me.RMwRC
				Case "Rc" 
					Return Me.Rc
				Case "RCSheer" 
					Return Me.RCSheer
				Case "PreCast" 
					Return Me.PreCast
				Case "Tiltup" 
					Return Me.Tiltup
				Case "LtMetal" 
					Return Me.LtMetal
				Case "StFr" 
					Return Me.StFr
				Case "BrStFr" 
					Return Me.BrStFr
				Case "Unk" 
					Return Me.Unk
				Case "UnkDesc" 
					Return Me.UnkDesc
				Case "ConstComments" 
					Return Me.ConstComments
				Case "Irreg" 
					Return Me.Irreg
				Case "Pounding" 
					Return Me.Pounding
				Case "SoftStory" 
					Return Me.SoftStory
				Case "SeismicStructRiskEval" 
					Return Me.SeismicStructRiskEval
				Case "SeismicStructRiskEvalComments" 
					Return Me.SeismicStructRiskEvalComments
				Case "BldgCondition" 
					Return Me.BldgCondition
				Case "BldgConditionComments" 
					Return Me.BldgConditionComments
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
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property WoodFrame As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.WoodFrame, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Urm As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Urm, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ReinfMas As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.ReinfMas, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RMwRC As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.RMwRC, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Rc As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Rc, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RCSheer As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.RCSheer, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PreCast As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.PreCast, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Tiltup As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Tiltup, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property LtMetal As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.LtMetal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property StFr As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.StFr, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property BrStFr As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.BrStFr, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Unk As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Unk, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property UnkDesc As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.UnkDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ConstComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.ConstComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Irreg As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Irreg, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Pounding As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Pounding, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SoftStory As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.SoftStory, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicStructRiskEval As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.SeismicStructRiskEval, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicStructRiskEvalComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.SeismicStructRiskEvalComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BldgCondition As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.BldgCondition, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BldgConditionComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.BldgConditionComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicStructuralMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazSeismicStructuralMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.WoodFrame, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.WoodFrame
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Urm, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Urm
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.ReinfMas, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.ReinfMas
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.RMwRC, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.RMwRC
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Rc, 7, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Rc
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.RCSheer, 8, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.RCSheer
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.PreCast, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.PreCast
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Tiltup, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Tiltup
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.LtMetal, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.LtMetal
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.StFr, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.StFr
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.BrStFr, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.BrStFr
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Unk, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Unk
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.UnkDesc, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.UnkDesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.ConstComments, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.ConstComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Irreg, 17, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Irreg
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Pounding, 18, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Pounding
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.SoftStory, 19, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.SoftStory
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.SeismicStructRiskEval, 20, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.SeismicStructRiskEval
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.SeismicStructRiskEvalComments, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.SeismicStructRiskEvalComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.BldgCondition, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.BldgCondition
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.BldgConditionComments, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.BldgConditionComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Importdate, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicStructuralMetadata.ColumnNames.Importorigdate, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicStructuralMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazSeismicStructuralMetadata
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
			 Public Const WoodFrame As String = "WoodFrame"
			 Public Const Urm As String = "URM"
			 Public Const ReinfMas As String = "ReinfMas"
			 Public Const RMwRC As String = "RMwRC"
			 Public Const Rc As String = "RC"
			 Public Const RCSheer As String = "RCSheer"
			 Public Const PreCast As String = "PreCast"
			 Public Const Tiltup As String = "Tiltup"
			 Public Const LtMetal As String = "LtMetal"
			 Public Const StFr As String = "StFr"
			 Public Const BrStFr As String = "BrStFr"
			 Public Const Unk As String = "Unk"
			 Public Const UnkDesc As String = "UnkDesc"
			 Public Const ConstComments As String = "ConstComments"
			 Public Const Irreg As String = "Irreg"
			 Public Const Pounding As String = "Pounding"
			 Public Const SoftStory As String = "SoftStory"
			 Public Const SeismicStructRiskEval As String = "SeismicStructRiskEval"
			 Public Const SeismicStructRiskEvalComments As String = "SeismicStructRiskEvalComments"
			 Public Const BldgCondition As String = "BldgCondition"
			 Public Const BldgConditionComments As String = "BldgConditionComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const WoodFrame As String = "WoodFrame"
			 Public Const Urm As String = "Urm"
			 Public Const ReinfMas As String = "ReinfMas"
			 Public Const RMwRC As String = "RMwRC"
			 Public Const Rc As String = "Rc"
			 Public Const RCSheer As String = "RCSheer"
			 Public Const PreCast As String = "PreCast"
			 Public Const Tiltup As String = "Tiltup"
			 Public Const LtMetal As String = "LtMetal"
			 Public Const StFr As String = "StFr"
			 Public Const BrStFr As String = "BrStFr"
			 Public Const Unk As String = "Unk"
			 Public Const UnkDesc As String = "UnkDesc"
			 Public Const ConstComments As String = "ConstComments"
			 Public Const Irreg As String = "Irreg"
			 Public Const Pounding As String = "Pounding"
			 Public Const SoftStory As String = "SoftStory"
			 Public Const SeismicStructRiskEval As String = "SeismicStructRiskEval"
			 Public Const SeismicStructRiskEvalComments As String = "SeismicStructRiskEvalComments"
			 Public Const BldgCondition As String = "BldgCondition"
			 Public Const BldgConditionComments As String = "BldgConditionComments"
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
			SyncLock GetType(NatHazSeismicStructuralMetadata)
			
				If NatHazSeismicStructuralMetadata.mapDelegates Is Nothing Then
					NatHazSeismicStructuralMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazSeismicStructuralMetadata._meta Is Nothing Then
					NatHazSeismicStructuralMetadata._meta = New NatHazSeismicStructuralMetadata()
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
				meta.AddTypeMap("WoodFrame", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Urm", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ReinfMas", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RMwRC", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Rc", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RCSheer", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PreCast", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Tiltup", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("LtMetal", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("StFr", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("BrStFr", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Unk", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("UnkDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ConstComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Irreg", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Pounding", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SoftStory", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SeismicStructRiskEval", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SeismicStructRiskEvalComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("BldgCondition", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BldgConditionComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Seismic-Structural"
				meta.Destination = "NatHaz-Seismic-Structural"
				
				meta.spInsert = "proc_NatHaz-Seismic-StructuralInsert"
				meta.spUpdate = "proc_NatHaz-Seismic-StructuralUpdate"
				meta.spDelete = "proc_NatHaz-Seismic-StructuralDelete"
				meta.spLoadAll = "proc_NatHaz-Seismic-StructuralLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Seismic-StructuralLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazSeismicStructuralMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
