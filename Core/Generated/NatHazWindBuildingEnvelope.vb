
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
	' Encapsulates the 'NatHaz-Wind-BuildingEnvelope' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazWindBuildingEnvelope))> _
	<XmlType("NatHazWindBuildingEnvelope")> _	
	Partial Public Class NatHazWindBuildingEnvelope 
		Inherits esNatHazWindBuildingEnvelope
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazWindBuildingEnvelope()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazWindBuildingEnvelope()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazWindBuildingEnvelope()
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
	<XmlType("NatHazWindBuildingEnvelopeCollection")> _
	Partial Public Class NatHazWindBuildingEnvelopeCollection
		Inherits esNatHazWindBuildingEnvelopeCollection
		Implements IEnumerable(Of NatHazWindBuildingEnvelope)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazWindBuildingEnvelope
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazWindBuildingEnvelope))> _
		Public Class NatHazWindBuildingEnvelopeCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazWindBuildingEnvelopeCollection)
			
			Public Shared Widening Operator CType(packet As NatHazWindBuildingEnvelopeCollectionWCFPacket) As NatHazWindBuildingEnvelopeCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazWindBuildingEnvelopeCollection) As NatHazWindBuildingEnvelopeCollectionWCFPacket
				Return New NatHazWindBuildingEnvelopeCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazWindBuildingEnvelopeQuery 
		Inherits esNatHazWindBuildingEnvelopeQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazWindBuildingEnvelopeQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazWindBuildingEnvelopeQuery) As String
			Return NatHazWindBuildingEnvelopeQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazWindBuildingEnvelopeQuery
			Return DirectCast(NatHazWindBuildingEnvelopeQuery.SerializeHelper.FromXml(query, GetType(NatHazWindBuildingEnvelopeQuery)), NatHazWindBuildingEnvelopeQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazWindBuildingEnvelope
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
		
			Dim query As New NatHazWindBuildingEnvelopeQuery()
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
		' Maps to NatHaz-Wind-BuildingEnvelope.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.DrainageRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DrainageRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DrainageRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DrainageRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.DrainageRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.DrainageComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DrainageComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DrainageComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DrainageComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.DrainageComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.FasteningRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FasteningRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FasteningRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FasteningRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.FasteningRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.FasteningComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FasteningComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FasteningComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FasteningComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.FasteningComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.FlashingRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FlashingRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FlashingRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FlashingRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.FlashingRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.FlashingComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FlashingComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FlashingComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FlashingComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.FlashingComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.CoveringRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoveringRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.CoveringRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.CoveringRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.CoveringRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.CoveringComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoveringComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.CoveringComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.CoveringComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.CoveringComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.GlassRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GlassRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.GlassRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.GlassRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.GlassRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.GlassComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GlassComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.GlassComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.GlassComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.GlassComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.WallSurfaceRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WallSurfaceRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.WallSurfaceRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.WallSurfaceRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.WallSurfaceRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.WallSurfaceComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WallSurfaceComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.WallSurfaceComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.WallSurfaceComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.WallSurfaceComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.DoorResistanceRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DoorResistanceRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DoorResistanceRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DoorResistanceRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.DoorResistanceRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.DoorResistanceComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DoorResistanceComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DoorResistanceComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DoorResistanceComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.DoorResistanceComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.OtherOpeningsLouversRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherOpeningsLouversRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.OtherOpeningsLouversRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.OtherOpeningsLouversRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.OtherOpeningsLouversRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.OtherOpeningsLouversComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherOpeningsLouversComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.OtherOpeningsLouversComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.OtherOpeningsLouversComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.OtherOpeningsLouversComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.SkylightAtriaRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SkylightAtriaRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SkylightAtriaRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SkylightAtriaRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.SkylightAtriaRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.SkylightAtriaComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SkylightAtriaComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SkylightAtriaComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SkylightAtriaComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.SkylightAtriaComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.ParapetOtherRoofRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ParapetOtherRoofRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.ParapetOtherRoofRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.ParapetOtherRoofRating, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.ParapetOtherRoofRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.ParapetOtherRoofComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ParapetOtherRoofComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.ParapetOtherRoofComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindBuildingEnvelopeMetadata.ColumnNames.ParapetOtherRoofComments, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.ParapetOtherRoofComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-BuildingEnvelope.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.Importorigdate)
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
												
						Case "DrainageRating"
							Me.str().DrainageRating = CType(value, string)
												
						Case "DrainageComments"
							Me.str().DrainageComments = CType(value, string)
												
						Case "FasteningRating"
							Me.str().FasteningRating = CType(value, string)
												
						Case "FasteningComments"
							Me.str().FasteningComments = CType(value, string)
												
						Case "FlashingRating"
							Me.str().FlashingRating = CType(value, string)
												
						Case "FlashingComments"
							Me.str().FlashingComments = CType(value, string)
												
						Case "CoveringRating"
							Me.str().CoveringRating = CType(value, string)
												
						Case "CoveringComments"
							Me.str().CoveringComments = CType(value, string)
												
						Case "GlassRating"
							Me.str().GlassRating = CType(value, string)
												
						Case "GlassComments"
							Me.str().GlassComments = CType(value, string)
												
						Case "WallSurfaceRating"
							Me.str().WallSurfaceRating = CType(value, string)
												
						Case "WallSurfaceComments"
							Me.str().WallSurfaceComments = CType(value, string)
												
						Case "DoorResistanceRating"
							Me.str().DoorResistanceRating = CType(value, string)
												
						Case "DoorResistanceComments"
							Me.str().DoorResistanceComments = CType(value, string)
												
						Case "OtherOpeningsLouversRating"
							Me.str().OtherOpeningsLouversRating = CType(value, string)
												
						Case "OtherOpeningsLouversComments"
							Me.str().OtherOpeningsLouversComments = CType(value, string)
												
						Case "SkylightAtriaRating"
							Me.str().SkylightAtriaRating = CType(value, string)
												
						Case "SkylightAtriaComments"
							Me.str().SkylightAtriaComments = CType(value, string)
												
						Case "ParapetOtherRoofRating"
							Me.str().ParapetOtherRoofRating = CType(value, string)
												
						Case "ParapetOtherRoofComments"
							Me.str().ParapetOtherRoofComments = CType(value, string)
												
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
								OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindBuildingEnvelopeMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazWindBuildingEnvelope)
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
		  	
			Public Property DrainageRating As System.String 
				Get
					Dim data_ As System.String = entity.DrainageRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DrainageRating = Nothing
					Else
						entity.DrainageRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DrainageComments As System.String 
				Get
					Dim data_ As System.String = entity.DrainageComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DrainageComments = Nothing
					Else
						entity.DrainageComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FasteningRating As System.String 
				Get
					Dim data_ As System.String = entity.FasteningRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FasteningRating = Nothing
					Else
						entity.FasteningRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FasteningComments As System.String 
				Get
					Dim data_ As System.String = entity.FasteningComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FasteningComments = Nothing
					Else
						entity.FasteningComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FlashingRating As System.String 
				Get
					Dim data_ As System.String = entity.FlashingRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FlashingRating = Nothing
					Else
						entity.FlashingRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FlashingComments As System.String 
				Get
					Dim data_ As System.String = entity.FlashingComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FlashingComments = Nothing
					Else
						entity.FlashingComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoveringRating As System.String 
				Get
					Dim data_ As System.String = entity.CoveringRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoveringRating = Nothing
					Else
						entity.CoveringRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoveringComments As System.String 
				Get
					Dim data_ As System.String = entity.CoveringComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoveringComments = Nothing
					Else
						entity.CoveringComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GlassRating As System.String 
				Get
					Dim data_ As System.String = entity.GlassRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GlassRating = Nothing
					Else
						entity.GlassRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GlassComments As System.String 
				Get
					Dim data_ As System.String = entity.GlassComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GlassComments = Nothing
					Else
						entity.GlassComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WallSurfaceRating As System.String 
				Get
					Dim data_ As System.String = entity.WallSurfaceRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WallSurfaceRating = Nothing
					Else
						entity.WallSurfaceRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WallSurfaceComments As System.String 
				Get
					Dim data_ As System.String = entity.WallSurfaceComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WallSurfaceComments = Nothing
					Else
						entity.WallSurfaceComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DoorResistanceRating As System.String 
				Get
					Dim data_ As System.String = entity.DoorResistanceRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DoorResistanceRating = Nothing
					Else
						entity.DoorResistanceRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DoorResistanceComments As System.String 
				Get
					Dim data_ As System.String = entity.DoorResistanceComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DoorResistanceComments = Nothing
					Else
						entity.DoorResistanceComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherOpeningsLouversRating As System.String 
				Get
					Dim data_ As System.String = entity.OtherOpeningsLouversRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherOpeningsLouversRating = Nothing
					Else
						entity.OtherOpeningsLouversRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherOpeningsLouversComments As System.String 
				Get
					Dim data_ As System.String = entity.OtherOpeningsLouversComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherOpeningsLouversComments = Nothing
					Else
						entity.OtherOpeningsLouversComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SkylightAtriaRating As System.String 
				Get
					Dim data_ As System.String = entity.SkylightAtriaRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SkylightAtriaRating = Nothing
					Else
						entity.SkylightAtriaRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SkylightAtriaComments As System.String 
				Get
					Dim data_ As System.String = entity.SkylightAtriaComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SkylightAtriaComments = Nothing
					Else
						entity.SkylightAtriaComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ParapetOtherRoofRating As System.String 
				Get
					Dim data_ As System.String = entity.ParapetOtherRoofRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ParapetOtherRoofRating = Nothing
					Else
						entity.ParapetOtherRoofRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ParapetOtherRoofComments As System.String 
				Get
					Dim data_ As System.String = entity.ParapetOtherRoofComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ParapetOtherRoofComments = Nothing
					Else
						entity.ParapetOtherRoofComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazWindBuildingEnvelope
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazWindBuildingEnvelopeMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazWindBuildingEnvelopeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazWindBuildingEnvelopeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazWindBuildingEnvelopeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazWindBuildingEnvelopeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazWindBuildingEnvelopeQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazWindBuildingEnvelopeCollection
		Inherits esEntityCollection(Of NatHazWindBuildingEnvelope)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazWindBuildingEnvelopeMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazWindBuildingEnvelopeCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazWindBuildingEnvelopeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazWindBuildingEnvelopeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazWindBuildingEnvelopeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazWindBuildingEnvelopeQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazWindBuildingEnvelopeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazWindBuildingEnvelopeQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazWindBuildingEnvelopeQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazWindBuildingEnvelopeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazWindBuildingEnvelopeMetadata.Meta()
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
				Case "DrainageRating" 
					Return Me.DrainageRating
				Case "DrainageComments" 
					Return Me.DrainageComments
				Case "FasteningRating" 
					Return Me.FasteningRating
				Case "FasteningComments" 
					Return Me.FasteningComments
				Case "FlashingRating" 
					Return Me.FlashingRating
				Case "FlashingComments" 
					Return Me.FlashingComments
				Case "CoveringRating" 
					Return Me.CoveringRating
				Case "CoveringComments" 
					Return Me.CoveringComments
				Case "GlassRating" 
					Return Me.GlassRating
				Case "GlassComments" 
					Return Me.GlassComments
				Case "WallSurfaceRating" 
					Return Me.WallSurfaceRating
				Case "WallSurfaceComments" 
					Return Me.WallSurfaceComments
				Case "DoorResistanceRating" 
					Return Me.DoorResistanceRating
				Case "DoorResistanceComments" 
					Return Me.DoorResistanceComments
				Case "OtherOpeningsLouversRating" 
					Return Me.OtherOpeningsLouversRating
				Case "OtherOpeningsLouversComments" 
					Return Me.OtherOpeningsLouversComments
				Case "SkylightAtriaRating" 
					Return Me.SkylightAtriaRating
				Case "SkylightAtriaComments" 
					Return Me.SkylightAtriaComments
				Case "ParapetOtherRoofRating" 
					Return Me.ParapetOtherRoofRating
				Case "ParapetOtherRoofComments" 
					Return Me.ParapetOtherRoofComments
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
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DrainageRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.DrainageRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DrainageComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.DrainageComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FasteningRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.FasteningRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FasteningComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.FasteningComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FlashingRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.FlashingRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FlashingComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.FlashingComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoveringRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.CoveringRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoveringComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.CoveringComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GlassRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.GlassRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GlassComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.GlassComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WallSurfaceRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.WallSurfaceRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WallSurfaceComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.WallSurfaceComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DoorResistanceRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.DoorResistanceRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DoorResistanceComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.DoorResistanceComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherOpeningsLouversRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.OtherOpeningsLouversRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherOpeningsLouversComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.OtherOpeningsLouversComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SkylightAtriaRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.SkylightAtriaRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SkylightAtriaComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.SkylightAtriaComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ParapetOtherRoofRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.ParapetOtherRoofRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ParapetOtherRoofComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.ParapetOtherRoofComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindBuildingEnvelopeMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazWindBuildingEnvelopeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DrainageRating, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.DrainageRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DrainageComments, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.DrainageComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FasteningRating, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.FasteningRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FasteningComments, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.FasteningComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FlashingRating, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.FlashingRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.FlashingComments, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.FlashingComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.CoveringRating, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.CoveringRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.CoveringComments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.CoveringComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.GlassRating, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.GlassRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.GlassComments, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.GlassComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.WallSurfaceRating, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.WallSurfaceRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.WallSurfaceComments, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.WallSurfaceComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DoorResistanceRating, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.DoorResistanceRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.DoorResistanceComments, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.DoorResistanceComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.OtherOpeningsLouversRating, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.OtherOpeningsLouversRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.OtherOpeningsLouversComments, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.OtherOpeningsLouversComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SkylightAtriaRating, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.SkylightAtriaRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.SkylightAtriaComments, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.SkylightAtriaComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.ParapetOtherRoofRating, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.ParapetOtherRoofRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.ParapetOtherRoofComments, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.ParapetOtherRoofComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Importdate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindBuildingEnvelopeMetadata.ColumnNames.Importorigdate, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindBuildingEnvelopeMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazWindBuildingEnvelopeMetadata
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
			 Public Const DrainageRating As String = "DrainageRating"
			 Public Const DrainageComments As String = "DrainageComments"
			 Public Const FasteningRating As String = "FasteningRating"
			 Public Const FasteningComments As String = "FasteningComments"
			 Public Const FlashingRating As String = "FlashingRating"
			 Public Const FlashingComments As String = "FlashingComments"
			 Public Const CoveringRating As String = "CoveringRating"
			 Public Const CoveringComments As String = "CoveringComments"
			 Public Const GlassRating As String = "GlassRating"
			 Public Const GlassComments As String = "GlassComments"
			 Public Const WallSurfaceRating As String = "WallSurfaceRating"
			 Public Const WallSurfaceComments As String = "WallSurfaceComments"
			 Public Const DoorResistanceRating As String = "DoorResistanceRating"
			 Public Const DoorResistanceComments As String = "DoorResistanceComments"
			 Public Const OtherOpeningsLouversRating As String = "OtherOpeningsLouversRating"
			 Public Const OtherOpeningsLouversComments As String = "OtherOpeningsLouversComments"
			 Public Const SkylightAtriaRating As String = "SkylightAtriaRating"
			 Public Const SkylightAtriaComments As String = "SkylightAtriaComments"
			 Public Const ParapetOtherRoofRating As String = "ParapetOtherRoofRating"
			 Public Const ParapetOtherRoofComments As String = "ParapetOtherRoofComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const DrainageRating As String = "DrainageRating"
			 Public Const DrainageComments As String = "DrainageComments"
			 Public Const FasteningRating As String = "FasteningRating"
			 Public Const FasteningComments As String = "FasteningComments"
			 Public Const FlashingRating As String = "FlashingRating"
			 Public Const FlashingComments As String = "FlashingComments"
			 Public Const CoveringRating As String = "CoveringRating"
			 Public Const CoveringComments As String = "CoveringComments"
			 Public Const GlassRating As String = "GlassRating"
			 Public Const GlassComments As String = "GlassComments"
			 Public Const WallSurfaceRating As String = "WallSurfaceRating"
			 Public Const WallSurfaceComments As String = "WallSurfaceComments"
			 Public Const DoorResistanceRating As String = "DoorResistanceRating"
			 Public Const DoorResistanceComments As String = "DoorResistanceComments"
			 Public Const OtherOpeningsLouversRating As String = "OtherOpeningsLouversRating"
			 Public Const OtherOpeningsLouversComments As String = "OtherOpeningsLouversComments"
			 Public Const SkylightAtriaRating As String = "SkylightAtriaRating"
			 Public Const SkylightAtriaComments As String = "SkylightAtriaComments"
			 Public Const ParapetOtherRoofRating As String = "ParapetOtherRoofRating"
			 Public Const ParapetOtherRoofComments As String = "ParapetOtherRoofComments"
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
			SyncLock GetType(NatHazWindBuildingEnvelopeMetadata)
			
				If NatHazWindBuildingEnvelopeMetadata.mapDelegates Is Nothing Then
					NatHazWindBuildingEnvelopeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazWindBuildingEnvelopeMetadata._meta Is Nothing Then
					NatHazWindBuildingEnvelopeMetadata._meta = New NatHazWindBuildingEnvelopeMetadata()
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
				meta.AddTypeMap("DrainageRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DrainageComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("FasteningRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FasteningComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("FlashingRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FlashingComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("CoveringRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CoveringComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("GlassRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("GlassComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("WallSurfaceRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WallSurfaceComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("DoorResistanceRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DoorResistanceComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("OtherOpeningsLouversRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OtherOpeningsLouversComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("SkylightAtriaRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SkylightAtriaComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("ParapetOtherRoofRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ParapetOtherRoofComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Wind-BuildingEnvelope"
				meta.Destination = "NatHaz-Wind-BuildingEnvelope"
				
				meta.spInsert = "proc_NatHaz-Wind-BuildingEnvelopeInsert"
				meta.spUpdate = "proc_NatHaz-Wind-BuildingEnvelopeUpdate"
				meta.spDelete = "proc_NatHaz-Wind-BuildingEnvelopeDelete"
				meta.spLoadAll = "proc_NatHaz-Wind-BuildingEnvelopeLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Wind-BuildingEnvelopeLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazWindBuildingEnvelopeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
