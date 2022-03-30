
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
	' Encapsulates the 'NatHaz-Wind-General' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazWindGeneral))> _
	<XmlType("NatHazWindGeneral")> _	
	Partial Public Class NatHazWindGeneral 
		Inherits esNatHazWindGeneral
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazWindGeneral()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazWindGeneral()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazWindGeneral()
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
	<XmlType("NatHazWindGeneralCollection")> _
	Partial Public Class NatHazWindGeneralCollection
		Inherits esNatHazWindGeneralCollection
		Implements IEnumerable(Of NatHazWindGeneral)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazWindGeneral
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazWindGeneral))> _
		Public Class NatHazWindGeneralCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazWindGeneralCollection)
			
			Public Shared Widening Operator CType(packet As NatHazWindGeneralCollectionWCFPacket) As NatHazWindGeneralCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazWindGeneralCollection) As NatHazWindGeneralCollectionWCFPacket
				Return New NatHazWindGeneralCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazWindGeneralQuery 
		Inherits esNatHazWindGeneralQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazWindGeneralQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazWindGeneralQuery) As String
			Return NatHazWindGeneralQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazWindGeneralQuery
			Return DirectCast(NatHazWindGeneralQuery.SerializeHelper.FromXml(query, GetType(NatHazWindGeneralQuery)), NatHazWindGeneralQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazWindGeneral
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
		
			Dim query As New NatHazWindGeneralQuery()
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
		' Maps to NatHaz-Wind-General.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazWindGeneralMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazWindGeneralMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindGeneralMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindGeneralMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindGeneralMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindGeneralMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.Units
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Units As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindGeneralMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindGeneralMetadata.ColumnNames.Units, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Units)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.Area
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Area As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazWindGeneralMetadata.ColumnNames.Area)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazWindGeneralMetadata.ColumnNames.Area, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Area)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.Stories
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Stories As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindGeneralMetadata.ColumnNames.Stories)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindGeneralMetadata.ColumnNames.Stories, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Stories)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.NoBasementLevels
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoBasementLevels As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(NatHazWindGeneralMetadata.ColumnNames.NoBasementLevels)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(NatHazWindGeneralMetadata.ColumnNames.NoBasementLevels, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.NoBasementLevels)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.BldgHgt
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BldgHgt As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(NatHazWindGeneralMetadata.ColumnNames.BldgHgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(NatHazWindGeneralMetadata.ColumnNames.BldgHgt, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.BldgHgt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.Windspeed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Windspeed As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazWindGeneralMetadata.ColumnNames.Windspeed)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazWindGeneralMetadata.ColumnNames.Windspeed, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Windspeed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.FloodZone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodZone As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindGeneralMetadata.ColumnNames.FloodZone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindGeneralMetadata.ColumnNames.FloodZone, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.FloodZone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.SurfaceRoughnessCo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurfaceRoughnessCo As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(NatHazWindGeneralMetadata.ColumnNames.SurfaceRoughnessCo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(NatHazWindGeneralMetadata.ColumnNames.SurfaceRoughnessCo, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.SurfaceRoughnessCo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.SurfRoughDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurfRoughDesc As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindGeneralMetadata.ColumnNames.SurfRoughDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindGeneralMetadata.ColumnNames.SurfRoughDesc, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.SurfRoughDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(NatHazWindGeneralMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(NatHazWindGeneralMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(NatHazWindGeneralMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(NatHazWindGeneralMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.DistanceToCoast
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DistanceToCoast As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazWindGeneralMetadata.ColumnNames.DistanceToCoast)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazWindGeneralMetadata.ColumnNames.DistanceToCoast, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.DistanceToCoast)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.SiteGradeElevation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SiteGradeElevation As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazWindGeneralMetadata.ColumnNames.SiteGradeElevation)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazWindGeneralMetadata.ColumnNames.SiteGradeElevation, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.SiteGradeElevation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.StormSurge
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StormSurge As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(NatHazWindGeneralMetadata.ColumnNames.StormSurge)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(NatHazWindGeneralMetadata.ColumnNames.StormSurge, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.StormSurge)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.Summary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Summary As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindGeneralMetadata.ColumnNames.Summary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindGeneralMetadata.ColumnNames.Summary, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Summary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.PriorLossHistory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PriorLossHistory As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazWindGeneralMetadata.ColumnNames.PriorLossHistory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazWindGeneralMetadata.ColumnNames.PriorLossHistory, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.PriorLossHistory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.PLHComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PLHComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindGeneralMetadata.ColumnNames.PLHComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindGeneralMetadata.ColumnNames.PLHComments, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.PLHComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.WindStructRiskEval
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindStructRiskEval As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazWindGeneralMetadata.ColumnNames.WindStructRiskEval)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazWindGeneralMetadata.ColumnNames.WindStructRiskEval, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.WindStructRiskEval)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.WindStructRiskEvalComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindStructRiskEvalComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindGeneralMetadata.ColumnNames.WindStructRiskEvalComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindGeneralMetadata.ColumnNames.WindStructRiskEvalComments, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.WindStructRiskEvalComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindGeneralMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindGeneralMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-General.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindGeneralMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindGeneralMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Importorigdate)
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
												
						Case "Units"
							Me.str().Units = CType(value, string)
												
						Case "Area"
							Me.str().Area = CType(value, string)
												
						Case "Stories"
							Me.str().Stories = CType(value, string)
												
						Case "NoBasementLevels"
							Me.str().NoBasementLevels = CType(value, string)
												
						Case "BldgHgt"
							Me.str().BldgHgt = CType(value, string)
												
						Case "Windspeed"
							Me.str().Windspeed = CType(value, string)
												
						Case "FloodZone"
							Me.str().FloodZone = CType(value, string)
												
						Case "SurfaceRoughnessCo"
							Me.str().SurfaceRoughnessCo = CType(value, string)
												
						Case "SurfRoughDesc"
							Me.str().SurfRoughDesc = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "DistanceToCoast"
							Me.str().DistanceToCoast = CType(value, string)
												
						Case "SiteGradeElevation"
							Me.str().SiteGradeElevation = CType(value, string)
												
						Case "StormSurge"
							Me.str().StormSurge = CType(value, string)
												
						Case "Summary"
							Me.str().Summary = CType(value, string)
												
						Case "PriorLossHistory"
							Me.str().PriorLossHistory = CType(value, string)
												
						Case "PLHComments"
							Me.str().PLHComments = CType(value, string)
												
						Case "WindStructRiskEval"
							Me.str().WindStructRiskEval = CType(value, string)
												
						Case "WindStructRiskEvalComments"
							Me.str().WindStructRiskEvalComments = CType(value, string)
												
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
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Area"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Area = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Area)
							End If
						
						Case "NoBasementLevels"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.NoBasementLevels = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.NoBasementLevels)
							End If
						
						Case "BldgHgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.BldgHgt = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.BldgHgt)
							End If
						
						Case "Windspeed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Windspeed = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Windspeed)
							End If
						
						Case "SurfaceRoughnessCo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.SurfaceRoughnessCo = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.SurfaceRoughnessCo)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Longitude)
							End If
						
						Case "DistanceToCoast"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DistanceToCoast = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.DistanceToCoast)
							End If
						
						Case "SiteGradeElevation"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SiteGradeElevation = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.SiteGradeElevation)
							End If
						
						Case "StormSurge"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.StormSurge = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.StormSurge)
							End If
						
						Case "PriorLossHistory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.PriorLossHistory = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.PriorLossHistory)
							End If
						
						Case "WindStructRiskEval"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.WindStructRiskEval = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.WindStructRiskEval)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindGeneralMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazWindGeneral)
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
		  	
			Public Property Area As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Area
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Area = Nothing
					Else
						entity.Area = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stories As System.String 
				Get
					Dim data_ As System.String = entity.Stories
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stories = Nothing
					Else
						entity.Stories = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoBasementLevels As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.NoBasementLevels
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoBasementLevels = Nothing
					Else
						entity.NoBasementLevels = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property BldgHgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.BldgHgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BldgHgt = Nothing
					Else
						entity.BldgHgt = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Windspeed As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Windspeed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Windspeed = Nothing
					Else
						entity.Windspeed = Convert.ToInt32(Value)
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
		  	
			Public Property SurfaceRoughnessCo As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.SurfaceRoughnessCo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurfaceRoughnessCo = Nothing
					Else
						entity.SurfaceRoughnessCo = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property SurfRoughDesc As System.String 
				Get
					Dim data_ As System.String = entity.SurfRoughDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurfRoughDesc = Nothing
					Else
						entity.SurfRoughDesc = Convert.ToString(Value)
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
		  	
			Public Property DistanceToCoast As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.DistanceToCoast
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DistanceToCoast = Nothing
					Else
						entity.DistanceToCoast = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SiteGradeElevation As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SiteGradeElevation
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SiteGradeElevation = Nothing
					Else
						entity.SiteGradeElevation = Convert.ToInt32(Value)
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
		  	
			Public Property PriorLossHistory As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.PriorLossHistory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PriorLossHistory = Nothing
					Else
						entity.PriorLossHistory = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property PLHComments As System.String 
				Get
					Dim data_ As System.String = entity.PLHComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PLHComments = Nothing
					Else
						entity.PLHComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindStructRiskEval As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.WindStructRiskEval
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindStructRiskEval = Nothing
					Else
						entity.WindStructRiskEval = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindStructRiskEvalComments As System.String 
				Get
					Dim data_ As System.String = entity.WindStructRiskEvalComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindStructRiskEvalComments = Nothing
					Else
						entity.WindStructRiskEvalComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazWindGeneral
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazWindGeneralMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazWindGeneralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazWindGeneralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazWindGeneralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazWindGeneralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazWindGeneralQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazWindGeneralCollection
		Inherits esEntityCollection(Of NatHazWindGeneral)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazWindGeneralMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazWindGeneralCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazWindGeneralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazWindGeneralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazWindGeneralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazWindGeneralQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazWindGeneralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazWindGeneralQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazWindGeneralQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazWindGeneralQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazWindGeneralMetadata.Meta()
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
				Case "Units" 
					Return Me.Units
				Case "Area" 
					Return Me.Area
				Case "Stories" 
					Return Me.Stories
				Case "NoBasementLevels" 
					Return Me.NoBasementLevels
				Case "BldgHgt" 
					Return Me.BldgHgt
				Case "Windspeed" 
					Return Me.Windspeed
				Case "FloodZone" 
					Return Me.FloodZone
				Case "SurfaceRoughnessCo" 
					Return Me.SurfaceRoughnessCo
				Case "SurfRoughDesc" 
					Return Me.SurfRoughDesc
				Case "Latitude" 
					Return Me.Latitude
				Case "Longitude" 
					Return Me.Longitude
				Case "DistanceToCoast" 
					Return Me.DistanceToCoast
				Case "SiteGradeElevation" 
					Return Me.SiteGradeElevation
				Case "StormSurge" 
					Return Me.StormSurge
				Case "Summary" 
					Return Me.Summary
				Case "PriorLossHistory" 
					Return Me.PriorLossHistory
				Case "PLHComments" 
					Return Me.PLHComments
				Case "WindStructRiskEval" 
					Return Me.WindStructRiskEval
				Case "WindStructRiskEvalComments" 
					Return Me.WindStructRiskEvalComments
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
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Units, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Area As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Area, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Stories As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Stories, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoBasementLevels As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.NoBasementLevels, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property BldgHgt As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.BldgHgt, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Windspeed As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Windspeed, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FloodZone As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.FloodZone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurfaceRoughnessCo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.SurfaceRoughnessCo, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property SurfRoughDesc As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.SurfRoughDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property DistanceToCoast As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.DistanceToCoast, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SiteGradeElevation As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.SiteGradeElevation, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property StormSurge As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.StormSurge, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Summary As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Summary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PriorLossHistory As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.PriorLossHistory, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property PLHComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.PLHComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WindStructRiskEval As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.WindStructRiskEval, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property WindStructRiskEvalComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.WindStructRiskEvalComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindGeneralMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazWindGeneralMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Units, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Units
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Area, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Area
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Stories, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Stories
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.NoBasementLevels, 6, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.NoBasementLevels
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.BldgHgt, 7, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.BldgHgt
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Windspeed, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Windspeed
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.FloodZone, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.FloodZone
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.SurfaceRoughnessCo, 10, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.SurfaceRoughnessCo
			c.CharacterMaxLength = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.SurfRoughDesc, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.SurfRoughDesc
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Latitude, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Longitude, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.DistanceToCoast, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.DistanceToCoast
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.SiteGradeElevation, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.SiteGradeElevation
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.StormSurge, 16, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.StormSurge
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Summary, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Summary
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.PriorLossHistory, 18, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.PriorLossHistory
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.PLHComments, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.PLHComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.WindStructRiskEval, 20, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.WindStructRiskEval
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.WindStructRiskEvalComments, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.WindStructRiskEvalComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Importdate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindGeneralMetadata.ColumnNames.Importorigdate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindGeneralMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazWindGeneralMetadata
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
			 Public Const Units As String = "Units"
			 Public Const Area As String = "Area"
			 Public Const Stories As String = "Stories"
			 Public Const NoBasementLevels As String = "NoBasementLevels"
			 Public Const BldgHgt As String = "BldgHgt"
			 Public Const Windspeed As String = "Windspeed"
			 Public Const FloodZone As String = "FloodZone"
			 Public Const SurfaceRoughnessCo As String = "SurfaceRoughnessCo"
			 Public Const SurfRoughDesc As String = "SurfRoughDesc"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const DistanceToCoast As String = "DistanceToCoast"
			 Public Const SiteGradeElevation As String = "SiteGradeElevation"
			 Public Const StormSurge As String = "StormSurge"
			 Public Const Summary As String = "Summary"
			 Public Const PriorLossHistory As String = "PriorLossHistory"
			 Public Const PLHComments As String = "PLHComments"
			 Public Const WindStructRiskEval As String = "WindStructRiskEval"
			 Public Const WindStructRiskEvalComments As String = "WindStructRiskEvalComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Units As String = "Units"
			 Public Const Area As String = "Area"
			 Public Const Stories As String = "Stories"
			 Public Const NoBasementLevels As String = "NoBasementLevels"
			 Public Const BldgHgt As String = "BldgHgt"
			 Public Const Windspeed As String = "Windspeed"
			 Public Const FloodZone As String = "FloodZone"
			 Public Const SurfaceRoughnessCo As String = "SurfaceRoughnessCo"
			 Public Const SurfRoughDesc As String = "SurfRoughDesc"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const DistanceToCoast As String = "DistanceToCoast"
			 Public Const SiteGradeElevation As String = "SiteGradeElevation"
			 Public Const StormSurge As String = "StormSurge"
			 Public Const Summary As String = "Summary"
			 Public Const PriorLossHistory As String = "PriorLossHistory"
			 Public Const PLHComments As String = "PLHComments"
			 Public Const WindStructRiskEval As String = "WindStructRiskEval"
			 Public Const WindStructRiskEvalComments As String = "WindStructRiskEvalComments"
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
			SyncLock GetType(NatHazWindGeneralMetadata)
			
				If NatHazWindGeneralMetadata.mapDelegates Is Nothing Then
					NatHazWindGeneralMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazWindGeneralMetadata._meta Is Nothing Then
					NatHazWindGeneralMetadata._meta = New NatHazWindGeneralMetadata()
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
				meta.AddTypeMap("SurveyDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Units", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Area", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Stories", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NoBasementLevels", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("BldgHgt", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Windspeed", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FloodZone", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("SurfaceRoughnessCo", new esTypeMap("nvarchar", "System.Char"))
				meta.AddTypeMap("SurfRoughDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("DistanceToCoast", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SiteGradeElevation", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("StormSurge", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Summary", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("PriorLossHistory", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("PLHComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("WindStructRiskEval", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("WindStructRiskEvalComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Wind-General"
				meta.Destination = "NatHaz-Wind-General"
				
				meta.spInsert = "proc_NatHaz-Wind-GeneralInsert"
				meta.spUpdate = "proc_NatHaz-Wind-GeneralUpdate"
				meta.spDelete = "proc_NatHaz-Wind-GeneralDelete"
				meta.spLoadAll = "proc_NatHaz-Wind-GeneralLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Wind-GeneralLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazWindGeneralMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
