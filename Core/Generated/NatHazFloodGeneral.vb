
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
	' Encapsulates the 'NatHaz-Flood-General' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazFloodGeneral))> _
	<XmlType("NatHazFloodGeneral")> _	
	Partial Public Class NatHazFloodGeneral 
		Inherits esNatHazFloodGeneral
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazFloodGeneral()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazFloodGeneral()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazFloodGeneral()
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
	<XmlType("NatHazFloodGeneralCollection")> _
	Partial Public Class NatHazFloodGeneralCollection
		Inherits esNatHazFloodGeneralCollection
		Implements IEnumerable(Of NatHazFloodGeneral)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazFloodGeneral
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazFloodGeneral))> _
		Public Class NatHazFloodGeneralCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazFloodGeneralCollection)
			
			Public Shared Widening Operator CType(packet As NatHazFloodGeneralCollectionWCFPacket) As NatHazFloodGeneralCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazFloodGeneralCollection) As NatHazFloodGeneralCollectionWCFPacket
				Return New NatHazFloodGeneralCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazFloodGeneralQuery 
		Inherits esNatHazFloodGeneralQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazFloodGeneralQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazFloodGeneralQuery) As String
			Return NatHazFloodGeneralQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazFloodGeneralQuery
			Return DirectCast(NatHazFloodGeneralQuery.SerializeHelper.FromXml(query, GetType(NatHazFloodGeneralQuery)), NatHazFloodGeneralQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazFloodGeneral
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
		
			Dim query As New NatHazFloodGeneralQuery()
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
		' Maps to NatHaz-Flood-General.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazFloodGeneralMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazFloodGeneralMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodGeneralMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodGeneralMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.Fsummary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fsummary As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames.Fsummary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames.Fsummary, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Fsummary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.Flosses
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Flosses As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazFloodGeneralMetadata.ColumnNames.Flosses)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazFloodGeneralMetadata.ColumnNames.Flosses, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Flosses)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.FLossDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FLossDesc As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames.FLossDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames.FLossDesc, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.FLossDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.FloodZone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodZone As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames.FloodZone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames.FloodZone, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.FloodZone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.FZoneDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FZoneDesc As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames.FZoneDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames.FZoneDesc, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.FZoneDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.SiteGradeElevation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SiteGradeElevation As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames.SiteGradeElevation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames.SiteGradeElevation, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.SiteGradeElevation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.1stFloorWaterEntryElev
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _1stFloorWaterEntryElev As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames._1stFloorWaterEntryElev)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames._1stFloorWaterEntryElev, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames._1stFloorWaterEntryElev)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.BelowGradeDepth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BelowGradeDepth As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames.BelowGradeDepth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames.BelowGradeDepth, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.BelowGradeDepth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.100YrFloodElev
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100YrFloodElev As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames._100YrFloodElev)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames._100YrFloodElev, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames._100YrFloodElev)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.500YrFloodElev
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _500YrFloodElev As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames._500YrFloodElev)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames._500YrFloodElev, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames._500YrFloodElev)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.100YrDepth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100YrDepth As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames._100YrDepth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames._100YrDepth, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames._100YrDepth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.500YrDepth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _500YrDepth As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames._500YrDepth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames._500YrDepth, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames._500YrDepth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.DistancetoCoast
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DistancetoCoast As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazFloodGeneralMetadata.ColumnNames.DistancetoCoast)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazFloodGeneralMetadata.ColumnNames.DistancetoCoast, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.DistancetoCoast)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.StormSurge
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StormSurge As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(NatHazFloodGeneralMetadata.ColumnNames.StormSurge)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(NatHazFloodGeneralMetadata.ColumnNames.StormSurge, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.StormSurge)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.StructRec
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StructRec As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazFloodGeneralMetadata.ColumnNames.StructRec)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazFloodGeneralMetadata.ColumnNames.StructRec, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.StructRec)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.StructRecComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StructRecComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodGeneralMetadata.ColumnNames.StructRecComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodGeneralMetadata.ColumnNames.StructRecComments, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.StructRecComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodGeneralMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodGeneralMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-General.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodGeneralMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodGeneralMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Importorigdate)
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
												
						Case "Fsummary"
							Me.str().Fsummary = CType(value, string)
												
						Case "Flosses"
							Me.str().Flosses = CType(value, string)
												
						Case "FLossDesc"
							Me.str().FLossDesc = CType(value, string)
												
						Case "FloodZone"
							Me.str().FloodZone = CType(value, string)
												
						Case "FZoneDesc"
							Me.str().FZoneDesc = CType(value, string)
												
						Case "SiteGradeElevation"
							Me.str().SiteGradeElevation = CType(value, string)
												
						Case "_1stFloorWaterEntryElev"
							Me.str()._1stFloorWaterEntryElev = CType(value, string)
												
						Case "BelowGradeDepth"
							Me.str().BelowGradeDepth = CType(value, string)
												
						Case "_100YrFloodElev"
							Me.str()._100YrFloodElev = CType(value, string)
												
						Case "_500YrFloodElev"
							Me.str()._500YrFloodElev = CType(value, string)
												
						Case "_100YrDepth"
							Me.str()._100YrDepth = CType(value, string)
												
						Case "_500YrDepth"
							Me.str()._500YrDepth = CType(value, string)
												
						Case "DistancetoCoast"
							Me.str().DistancetoCoast = CType(value, string)
												
						Case "StormSurge"
							Me.str().StormSurge = CType(value, string)
												
						Case "StructRec"
							Me.str().StructRec = CType(value, string)
												
						Case "StructRecComments"
							Me.str().StructRecComments = CType(value, string)
												
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
								OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Flosses"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Flosses = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Flosses)
							End If
						
						Case "DistancetoCoast"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DistancetoCoast = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.DistancetoCoast)
							End If
						
						Case "StormSurge"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.StormSurge = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.StormSurge)
							End If
						
						Case "StructRec"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.StructRec = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.StructRec)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodGeneralMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazFloodGeneral)
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
		  	
			Public Property Fsummary As System.String 
				Get
					Dim data_ As System.String = entity.Fsummary
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fsummary = Nothing
					Else
						entity.Fsummary = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Flosses As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Flosses
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Flosses = Nothing
					Else
						entity.Flosses = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property FLossDesc As System.String 
				Get
					Dim data_ As System.String = entity.FLossDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FLossDesc = Nothing
					Else
						entity.FLossDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodZone As System.String 
				Get
					Dim data_ As System.String = entity.FloodZone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodZone = Nothing
					Else
						entity.FloodZone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FZoneDesc As System.String 
				Get
					Dim data_ As System.String = entity.FZoneDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FZoneDesc = Nothing
					Else
						entity.FZoneDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SiteGradeElevation As System.String 
				Get
					Dim data_ As System.String = entity.SiteGradeElevation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SiteGradeElevation = Nothing
					Else
						entity.SiteGradeElevation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _1stFloorWaterEntryElev As System.String 
				Get
					Dim data_ As System.String = entity._1stFloorWaterEntryElev
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._1stFloorWaterEntryElev = Nothing
					Else
						entity._1stFloorWaterEntryElev = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BelowGradeDepth As System.String 
				Get
					Dim data_ As System.String = entity.BelowGradeDepth
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BelowGradeDepth = Nothing
					Else
						entity.BelowGradeDepth = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _100YrFloodElev As System.String 
				Get
					Dim data_ As System.String = entity._100YrFloodElev
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._100YrFloodElev = Nothing
					Else
						entity._100YrFloodElev = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _500YrFloodElev As System.String 
				Get
					Dim data_ As System.String = entity._500YrFloodElev
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._500YrFloodElev = Nothing
					Else
						entity._500YrFloodElev = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _100YrDepth As System.String 
				Get
					Dim data_ As System.String = entity._100YrDepth
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._100YrDepth = Nothing
					Else
						entity._100YrDepth = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _500YrDepth As System.String 
				Get
					Dim data_ As System.String = entity._500YrDepth
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._500YrDepth = Nothing
					Else
						entity._500YrDepth = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DistancetoCoast As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.DistancetoCoast
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DistancetoCoast = Nothing
					Else
						entity.DistancetoCoast = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property StormSurge As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.StormSurge
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StormSurge = Nothing
					Else
						entity.StormSurge = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property StructRec As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.StructRec
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StructRec = Nothing
					Else
						entity.StructRec = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property StructRecComments As System.String 
				Get
					Dim data_ As System.String = entity.StructRecComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StructRecComments = Nothing
					Else
						entity.StructRecComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazFloodGeneral
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazFloodGeneralMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazFloodGeneralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazFloodGeneralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazFloodGeneralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazFloodGeneralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazFloodGeneralQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazFloodGeneralCollection
		Inherits esEntityCollection(Of NatHazFloodGeneral)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazFloodGeneralMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazFloodGeneralCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazFloodGeneralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazFloodGeneralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazFloodGeneralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazFloodGeneralQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazFloodGeneralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazFloodGeneralQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazFloodGeneralQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazFloodGeneralQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazFloodGeneralMetadata.Meta()
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
				Case "Fsummary" 
					Return Me.Fsummary
				Case "Flosses" 
					Return Me.Flosses
				Case "FLossDesc" 
					Return Me.FLossDesc
				Case "FloodZone" 
					Return Me.FloodZone
				Case "FZoneDesc" 
					Return Me.FZoneDesc
				Case "SiteGradeElevation" 
					Return Me.SiteGradeElevation
				Case "_1stFloorWaterEntryElev" 
					Return Me._1stFloorWaterEntryElev
				Case "BelowGradeDepth" 
					Return Me.BelowGradeDepth
				Case "_100YrFloodElev" 
					Return Me._100YrFloodElev
				Case "_500YrFloodElev" 
					Return Me._500YrFloodElev
				Case "_100YrDepth" 
					Return Me._100YrDepth
				Case "_500YrDepth" 
					Return Me._500YrDepth
				Case "DistancetoCoast" 
					Return Me.DistancetoCoast
				Case "StormSurge" 
					Return Me.StormSurge
				Case "StructRec" 
					Return Me.StructRec
				Case "StructRecComments" 
					Return Me.StructRecComments
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
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Fsummary As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.Fsummary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Flosses As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.Flosses, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property FLossDesc As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.FLossDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FloodZone As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.FloodZone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FZoneDesc As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.FZoneDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SiteGradeElevation As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.SiteGradeElevation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _1stFloorWaterEntryElev As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames._1stFloorWaterEntryElev, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BelowGradeDepth As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.BelowGradeDepth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100YrFloodElev As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames._100YrFloodElev, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _500YrFloodElev As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames._500YrFloodElev, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100YrDepth As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames._100YrDepth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _500YrDepth As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames._500YrDepth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DistancetoCoast As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.DistancetoCoast, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StormSurge As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.StormSurge, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property StructRec As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.StructRec, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property StructRecComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.StructRecComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodGeneralMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazFloodGeneralMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.Fsummary, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.Fsummary
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.Flosses, 4, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.Flosses
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.FLossDesc, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.FLossDesc
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.FloodZone, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.FloodZone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.FZoneDesc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.FZoneDesc
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.SiteGradeElevation, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.SiteGradeElevation
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames._1stFloorWaterEntryElev, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames._1stFloorWaterEntryElev
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.BelowGradeDepth, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.BelowGradeDepth
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames._100YrFloodElev, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames._100YrFloodElev
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames._500YrFloodElev, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames._500YrFloodElev
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames._100YrDepth, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames._100YrDepth
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames._500YrDepth, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames._500YrDepth
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.DistancetoCoast, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.DistancetoCoast
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.StormSurge, 16, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.StormSurge
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.StructRec, 17, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.StructRec
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.StructRecComments, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.StructRecComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.Importdate, 19, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodGeneralMetadata.ColumnNames.Importorigdate, 20, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodGeneralMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazFloodGeneralMetadata
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
			 Public Const Fsummary As String = "Fsummary"
			 Public Const Flosses As String = "Flosses"
			 Public Const FLossDesc As String = "FLossDesc"
			 Public Const FloodZone As String = "FloodZone"
			 Public Const FZoneDesc As String = "FZoneDesc"
			 Public Const SiteGradeElevation As String = "SiteGradeElevation"
			 Public Const _1stFloorWaterEntryElev As String = "1stFloorWaterEntryElev"
			 Public Const BelowGradeDepth As String = "BelowGradeDepth"
			 Public Const _100YrFloodElev As String = "100YrFloodElev"
			 Public Const _500YrFloodElev As String = "500YrFloodElev"
			 Public Const _100YrDepth As String = "100YrDepth"
			 Public Const _500YrDepth As String = "500YrDepth"
			 Public Const DistancetoCoast As String = "DistancetoCoast"
			 Public Const StormSurge As String = "StormSurge"
			 Public Const StructRec As String = "StructRec"
			 Public Const StructRecComments As String = "StructRecComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Fsummary As String = "Fsummary"
			 Public Const Flosses As String = "Flosses"
			 Public Const FLossDesc As String = "FLossDesc"
			 Public Const FloodZone As String = "FloodZone"
			 Public Const FZoneDesc As String = "FZoneDesc"
			 Public Const SiteGradeElevation As String = "SiteGradeElevation"
			 Public Const _1stFloorWaterEntryElev As String = "_1stFloorWaterEntryElev"
			 Public Const BelowGradeDepth As String = "BelowGradeDepth"
			 Public Const _100YrFloodElev As String = "_100YrFloodElev"
			 Public Const _500YrFloodElev As String = "_500YrFloodElev"
			 Public Const _100YrDepth As String = "_100YrDepth"
			 Public Const _500YrDepth As String = "_500YrDepth"
			 Public Const DistancetoCoast As String = "DistancetoCoast"
			 Public Const StormSurge As String = "StormSurge"
			 Public Const StructRec As String = "StructRec"
			 Public Const StructRecComments As String = "StructRecComments"
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
			SyncLock GetType(NatHazFloodGeneralMetadata)
			
				If NatHazFloodGeneralMetadata.mapDelegates Is Nothing Then
					NatHazFloodGeneralMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazFloodGeneralMetadata._meta Is Nothing Then
					NatHazFloodGeneralMetadata._meta = New NatHazFloodGeneralMetadata()
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
				meta.AddTypeMap("Fsummary", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Flosses", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("FLossDesc", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("FloodZone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FZoneDesc", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("SiteGradeElevation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_1stFloorWaterEntryElev", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BelowGradeDepth", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_100YrFloodElev", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_500YrFloodElev", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_100YrDepth", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_500YrDepth", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DistancetoCoast", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StormSurge", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("StructRec", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("StructRecComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Flood-General"
				meta.Destination = "NatHaz-Flood-General"
				
				meta.spInsert = "proc_NatHaz-Flood-GeneralInsert"
				meta.spUpdate = "proc_NatHaz-Flood-GeneralUpdate"
				meta.spDelete = "proc_NatHaz-Flood-GeneralDelete"
				meta.spLoadAll = "proc_NatHaz-Flood-GeneralLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Flood-GeneralLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazFloodGeneralMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
