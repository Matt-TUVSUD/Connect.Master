
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:40 AM
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
	' Encapsulates the 'Cope-FireExposure' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(CopeFireExposure))> _
	<XmlType("CopeFireExposure")> _	
	Partial Public Class CopeFireExposure 
		Inherits esCopeFireExposure
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New CopeFireExposure()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New CopeFireExposure()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New CopeFireExposure()
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
	<XmlType("CopeFireExposureCollection")> _
	Partial Public Class CopeFireExposureCollection
		Inherits esCopeFireExposureCollection
		Implements IEnumerable(Of CopeFireExposure)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As CopeFireExposure
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(CopeFireExposure))> _
		Public Class CopeFireExposureCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of CopeFireExposureCollection)
			
			Public Shared Widening Operator CType(packet As CopeFireExposureCollectionWCFPacket) As CopeFireExposureCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As CopeFireExposureCollection) As CopeFireExposureCollectionWCFPacket
				Return New CopeFireExposureCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class CopeFireExposureQuery 
		Inherits esCopeFireExposureQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "CopeFireExposureQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As CopeFireExposureQuery) As String
			Return CopeFireExposureQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As CopeFireExposureQuery
			Return DirectCast(CopeFireExposureQuery.SerializeHelper.FromXml(query, GetType(CopeFireExposureQuery)), CopeFireExposureQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esCopeFireExposure
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
		
			Dim query As New CopeFireExposureQuery()
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
		' Maps to Cope-FireExposure.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeFireExposureMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeFireExposureMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ExternalFire
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExternalFire As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ExternalFire)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ExternalFire, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ExternalFire)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ExternalFireProtectionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExternalFireProtectionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ExternalFireProtectionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ExternalFireProtectionField, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ExternalFireProtectionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ExternalFireDescriptionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExternalFireDescriptionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ExternalFireDescriptionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ExternalFireDescriptionField, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ExternalFireDescriptionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.Flood
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Flood As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.Flood)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.Flood, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.Flood)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.FloodProtectionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodProtectionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.FloodProtectionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.FloodProtectionField, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.FloodProtectionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.Zone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zone As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.Zone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.Zone, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.Zone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.InundationDepth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InundationDepth As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.InundationDepth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.InundationDepth, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.InundationDepth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.Seismic
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Seismic As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.Seismic)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.Seismic, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.Seismic)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.SeismicProtectionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicProtectionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.SeismicProtectionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.SeismicProtectionField, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.SeismicProtectionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.FMSeismicZone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FMSeismicZone As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.FMSeismicZone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.FMSeismicZone, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.FMSeismicZone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.PeakGroundAcceleration2PercentIn50Years
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PeakGroundAcceleration2PercentIn50Years As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireExposureMetadata.ColumnNames.PeakGroundAcceleration2PercentIn50Years)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireExposureMetadata.ColumnNames.PeakGroundAcceleration2PercentIn50Years, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.PeakGroundAcceleration2PercentIn50Years)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.Windstorm
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Windstorm As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.Windstorm)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.Windstorm, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.Windstorm)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.WindstormProtectionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindstormProtectionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.WindstormProtectionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.WindstormProtectionField, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.WindstormProtectionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.MaxSustainedWindSpeed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MaxSustainedWindSpeed As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeFireExposureMetadata.ColumnNames.MaxSustainedWindSpeed)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeFireExposureMetadata.ColumnNames.MaxSustainedWindSpeed, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.MaxSustainedWindSpeed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.OtherExternal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherExternal As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.OtherExternal)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.OtherExternal, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.OtherExternal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.OtherProtectionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherProtectionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.OtherProtectionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.OtherProtectionField, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.OtherProtectionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.OtherProtectionDescriptionField
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherProtectionDescriptionField As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.OtherProtectionDescriptionField)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.OtherProtectionDescriptionField, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.OtherProtectionDescriptionField)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ModifiedMercalliIndex
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ModifiedMercalliIndex As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ModifiedMercalliIndex)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ModifiedMercalliIndex, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ModifiedMercalliIndex)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ExposureComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExposureComments As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureComments, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ExposureComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ExposureUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExposureUser1 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureUser1, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ExposureUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ExposureUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExposureUser2 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureUser2, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ExposureUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ExposureUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExposureUser3 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureUser3, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ExposureUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-FireExposure.ExposureUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExposureUser4 As System.String
			Get
				Return MyBase.GetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeFireExposureMetadata.ColumnNames.ExposureUser4, value) Then
					OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.ExposureUser4)
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
												
						Case "ExternalFire"
							Me.str().ExternalFire = CType(value, string)
												
						Case "ExternalFireProtectionField"
							Me.str().ExternalFireProtectionField = CType(value, string)
												
						Case "ExternalFireDescriptionField"
							Me.str().ExternalFireDescriptionField = CType(value, string)
												
						Case "Flood"
							Me.str().Flood = CType(value, string)
												
						Case "FloodProtectionField"
							Me.str().FloodProtectionField = CType(value, string)
												
						Case "Zone"
							Me.str().Zone = CType(value, string)
												
						Case "InundationDepth"
							Me.str().InundationDepth = CType(value, string)
												
						Case "Seismic"
							Me.str().Seismic = CType(value, string)
												
						Case "SeismicProtectionField"
							Me.str().SeismicProtectionField = CType(value, string)
												
						Case "FMSeismicZone"
							Me.str().FMSeismicZone = CType(value, string)
												
						Case "PeakGroundAcceleration2PercentIn50Years"
							Me.str().PeakGroundAcceleration2PercentIn50Years = CType(value, string)
												
						Case "Windstorm"
							Me.str().Windstorm = CType(value, string)
												
						Case "WindstormProtectionField"
							Me.str().WindstormProtectionField = CType(value, string)
												
						Case "MaxSustainedWindSpeed"
							Me.str().MaxSustainedWindSpeed = CType(value, string)
												
						Case "OtherExternal"
							Me.str().OtherExternal = CType(value, string)
												
						Case "OtherProtectionField"
							Me.str().OtherProtectionField = CType(value, string)
												
						Case "OtherProtectionDescriptionField"
							Me.str().OtherProtectionDescriptionField = CType(value, string)
												
						Case "ModifiedMercalliIndex"
							Me.str().ModifiedMercalliIndex = CType(value, string)
												
						Case "ExposureComments"
							Me.str().ExposureComments = CType(value, string)
												
						Case "ExposureUser1"
							Me.str().ExposureUser1 = CType(value, string)
												
						Case "ExposureUser2"
							Me.str().ExposureUser2 = CType(value, string)
												
						Case "ExposureUser3"
							Me.str().ExposureUser3 = CType(value, string)
												
						Case "ExposureUser4"
							Me.str().ExposureUser4 = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.Id)
							End If
						
						Case "PeakGroundAcceleration2PercentIn50Years"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PeakGroundAcceleration2PercentIn50Years = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.PeakGroundAcceleration2PercentIn50Years)
							End If
						
						Case "MaxSustainedWindSpeed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.MaxSustainedWindSpeed = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeFireExposureMetadata.PropertyNames.MaxSustainedWindSpeed)
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
		
			Public Sub New(ByVal entity As esCopeFireExposure)
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
		  	
			Public Property ExternalFire As System.String 
				Get
					Dim data_ As System.String = entity.ExternalFire
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExternalFire = Nothing
					Else
						entity.ExternalFire = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExternalFireProtectionField As System.String 
				Get
					Dim data_ As System.String = entity.ExternalFireProtectionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExternalFireProtectionField = Nothing
					Else
						entity.ExternalFireProtectionField = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExternalFireDescriptionField As System.String 
				Get
					Dim data_ As System.String = entity.ExternalFireDescriptionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExternalFireDescriptionField = Nothing
					Else
						entity.ExternalFireDescriptionField = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Flood As System.String 
				Get
					Dim data_ As System.String = entity.Flood
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Flood = Nothing
					Else
						entity.Flood = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodProtectionField As System.String 
				Get
					Dim data_ As System.String = entity.FloodProtectionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodProtectionField = Nothing
					Else
						entity.FloodProtectionField = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Zone As System.String 
				Get
					Dim data_ As System.String = entity.Zone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Zone = Nothing
					Else
						entity.Zone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InundationDepth As System.String 
				Get
					Dim data_ As System.String = entity.InundationDepth
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InundationDepth = Nothing
					Else
						entity.InundationDepth = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Seismic As System.String 
				Get
					Dim data_ As System.String = entity.Seismic
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Seismic = Nothing
					Else
						entity.Seismic = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicProtectionField As System.String 
				Get
					Dim data_ As System.String = entity.SeismicProtectionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicProtectionField = Nothing
					Else
						entity.SeismicProtectionField = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FMSeismicZone As System.String 
				Get
					Dim data_ As System.String = entity.FMSeismicZone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FMSeismicZone = Nothing
					Else
						entity.FMSeismicZone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PeakGroundAcceleration2PercentIn50Years As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PeakGroundAcceleration2PercentIn50Years
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PeakGroundAcceleration2PercentIn50Years = Nothing
					Else
						entity.PeakGroundAcceleration2PercentIn50Years = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Windstorm As System.String 
				Get
					Dim data_ As System.String = entity.Windstorm
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Windstorm = Nothing
					Else
						entity.Windstorm = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindstormProtectionField As System.String 
				Get
					Dim data_ As System.String = entity.WindstormProtectionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindstormProtectionField = Nothing
					Else
						entity.WindstormProtectionField = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxSustainedWindSpeed As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.MaxSustainedWindSpeed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxSustainedWindSpeed = Nothing
					Else
						entity.MaxSustainedWindSpeed = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherExternal As System.String 
				Get
					Dim data_ As System.String = entity.OtherExternal
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherExternal = Nothing
					Else
						entity.OtherExternal = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherProtectionField As System.String 
				Get
					Dim data_ As System.String = entity.OtherProtectionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherProtectionField = Nothing
					Else
						entity.OtherProtectionField = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherProtectionDescriptionField As System.String 
				Get
					Dim data_ As System.String = entity.OtherProtectionDescriptionField
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherProtectionDescriptionField = Nothing
					Else
						entity.OtherProtectionDescriptionField = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifiedMercalliIndex As System.String 
				Get
					Dim data_ As System.String = entity.ModifiedMercalliIndex
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifiedMercalliIndex = Nothing
					Else
						entity.ModifiedMercalliIndex = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExposureComments As System.String 
				Get
					Dim data_ As System.String = entity.ExposureComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExposureComments = Nothing
					Else
						entity.ExposureComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExposureUser1 As System.String 
				Get
					Dim data_ As System.String = entity.ExposureUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExposureUser1 = Nothing
					Else
						entity.ExposureUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExposureUser2 As System.String 
				Get
					Dim data_ As System.String = entity.ExposureUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExposureUser2 = Nothing
					Else
						entity.ExposureUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExposureUser3 As System.String 
				Get
					Dim data_ As System.String = entity.ExposureUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExposureUser3 = Nothing
					Else
						entity.ExposureUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExposureUser4 As System.String 
				Get
					Dim data_ As System.String = entity.ExposureUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExposureUser4 = Nothing
					Else
						entity.ExposureUser4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCopeFireExposure
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeFireExposureMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As CopeFireExposureQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeFireExposureQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As CopeFireExposureQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As CopeFireExposureQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CopeFireExposureQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esCopeFireExposureCollection
		Inherits esEntityCollection(Of CopeFireExposure)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeFireExposureMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "CopeFireExposureCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As CopeFireExposureQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeFireExposureQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As CopeFireExposureQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New CopeFireExposureQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As CopeFireExposureQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, CopeFireExposureQuery))
		End Sub
		
		#End Region
						
		Private m_query As CopeFireExposureQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esCopeFireExposureQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CopeFireExposureMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "ExternalFire" 
					Return Me.ExternalFire
				Case "ExternalFireProtectionField" 
					Return Me.ExternalFireProtectionField
				Case "ExternalFireDescriptionField" 
					Return Me.ExternalFireDescriptionField
				Case "Flood" 
					Return Me.Flood
				Case "FloodProtectionField" 
					Return Me.FloodProtectionField
				Case "Zone" 
					Return Me.Zone
				Case "InundationDepth" 
					Return Me.InundationDepth
				Case "Seismic" 
					Return Me.Seismic
				Case "SeismicProtectionField" 
					Return Me.SeismicProtectionField
				Case "FMSeismicZone" 
					Return Me.FMSeismicZone
				Case "PeakGroundAcceleration2PercentIn50Years" 
					Return Me.PeakGroundAcceleration2PercentIn50Years
				Case "Windstorm" 
					Return Me.Windstorm
				Case "WindstormProtectionField" 
					Return Me.WindstormProtectionField
				Case "MaxSustainedWindSpeed" 
					Return Me.MaxSustainedWindSpeed
				Case "OtherExternal" 
					Return Me.OtherExternal
				Case "OtherProtectionField" 
					Return Me.OtherProtectionField
				Case "OtherProtectionDescriptionField" 
					Return Me.OtherProtectionDescriptionField
				Case "ModifiedMercalliIndex" 
					Return Me.ModifiedMercalliIndex
				Case "ExposureComments" 
					Return Me.ExposureComments
				Case "ExposureUser1" 
					Return Me.ExposureUser1
				Case "ExposureUser2" 
					Return Me.ExposureUser2
				Case "ExposureUser3" 
					Return Me.ExposureUser3
				Case "ExposureUser4" 
					Return Me.ExposureUser4
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExternalFire As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ExternalFire, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExternalFireProtectionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ExternalFireProtectionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExternalFireDescriptionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ExternalFireDescriptionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Flood As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.Flood, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FloodProtectionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.FloodProtectionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zone As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.Zone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InundationDepth As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.InundationDepth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Seismic As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.Seismic, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicProtectionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.SeismicProtectionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FMSeismicZone As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.FMSeismicZone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PeakGroundAcceleration2PercentIn50Years As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.PeakGroundAcceleration2PercentIn50Years, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Windstorm As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.Windstorm, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WindstormProtectionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.WindstormProtectionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MaxSustainedWindSpeed As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.MaxSustainedWindSpeed, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property OtherExternal As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.OtherExternal, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherProtectionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.OtherProtectionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherProtectionDescriptionField As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.OtherProtectionDescriptionField, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedMercalliIndex As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ModifiedMercalliIndex, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExposureComments As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ExposureComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExposureUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ExposureUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExposureUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ExposureUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExposureUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ExposureUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExposureUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeFireExposureMetadata.ColumnNames.ExposureUser4, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class CopeFireExposure 
		Inherits esCopeFireExposure
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class CopeFireExposureMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ExternalFire, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ExternalFire
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ExternalFireProtectionField, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ExternalFireProtectionField
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ExternalFireDescriptionField, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ExternalFireDescriptionField
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.Flood, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.Flood
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.FloodProtectionField, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.FloodProtectionField
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.Zone, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.Zone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.InundationDepth, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.InundationDepth
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.Seismic, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.Seismic
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.SeismicProtectionField, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.SeismicProtectionField
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.FMSeismicZone, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.FMSeismicZone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.PeakGroundAcceleration2PercentIn50Years, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.PeakGroundAcceleration2PercentIn50Years
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.Windstorm, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.Windstorm
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.WindstormProtectionField, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.WindstormProtectionField
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.MaxSustainedWindSpeed, 15, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.MaxSustainedWindSpeed
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.OtherExternal, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.OtherExternal
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.OtherProtectionField, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.OtherProtectionField
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.OtherProtectionDescriptionField, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.OtherProtectionDescriptionField
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ModifiedMercalliIndex, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ModifiedMercalliIndex
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ExposureComments, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ExposureComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ExposureUser1, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ExposureUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ExposureUser2, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ExposureUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ExposureUser3, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ExposureUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeFireExposureMetadata.ColumnNames.ExposureUser4, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeFireExposureMetadata.PropertyNames.ExposureUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As CopeFireExposureMetadata
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
			 Public Const ExternalFire As String = "ExternalFire"
			 Public Const ExternalFireProtectionField As String = "ExternalFireProtectionField"
			 Public Const ExternalFireDescriptionField As String = "ExternalFireDescriptionField"
			 Public Const Flood As String = "Flood"
			 Public Const FloodProtectionField As String = "FloodProtectionField"
			 Public Const Zone As String = "Zone"
			 Public Const InundationDepth As String = "InundationDepth"
			 Public Const Seismic As String = "Seismic"
			 Public Const SeismicProtectionField As String = "SeismicProtectionField"
			 Public Const FMSeismicZone As String = "FMSeismicZone"
			 Public Const PeakGroundAcceleration2PercentIn50Years As String = "PeakGroundAcceleration2PercentIn50Years"
			 Public Const Windstorm As String = "Windstorm"
			 Public Const WindstormProtectionField As String = "WindstormProtectionField"
			 Public Const MaxSustainedWindSpeed As String = "MaxSustainedWindSpeed"
			 Public Const OtherExternal As String = "OtherExternal"
			 Public Const OtherProtectionField As String = "OtherProtectionField"
			 Public Const OtherProtectionDescriptionField As String = "OtherProtectionDescriptionField"
			 Public Const ModifiedMercalliIndex As String = "ModifiedMercalliIndex"
			 Public Const ExposureComments As String = "ExposureComments"
			 Public Const ExposureUser1 As String = "ExposureUser1"
			 Public Const ExposureUser2 As String = "ExposureUser2"
			 Public Const ExposureUser3 As String = "ExposureUser3"
			 Public Const ExposureUser4 As String = "ExposureUser4"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const ExternalFire As String = "ExternalFire"
			 Public Const ExternalFireProtectionField As String = "ExternalFireProtectionField"
			 Public Const ExternalFireDescriptionField As String = "ExternalFireDescriptionField"
			 Public Const Flood As String = "Flood"
			 Public Const FloodProtectionField As String = "FloodProtectionField"
			 Public Const Zone As String = "Zone"
			 Public Const InundationDepth As String = "InundationDepth"
			 Public Const Seismic As String = "Seismic"
			 Public Const SeismicProtectionField As String = "SeismicProtectionField"
			 Public Const FMSeismicZone As String = "FMSeismicZone"
			 Public Const PeakGroundAcceleration2PercentIn50Years As String = "PeakGroundAcceleration2PercentIn50Years"
			 Public Const Windstorm As String = "Windstorm"
			 Public Const WindstormProtectionField As String = "WindstormProtectionField"
			 Public Const MaxSustainedWindSpeed As String = "MaxSustainedWindSpeed"
			 Public Const OtherExternal As String = "OtherExternal"
			 Public Const OtherProtectionField As String = "OtherProtectionField"
			 Public Const OtherProtectionDescriptionField As String = "OtherProtectionDescriptionField"
			 Public Const ModifiedMercalliIndex As String = "ModifiedMercalliIndex"
			 Public Const ExposureComments As String = "ExposureComments"
			 Public Const ExposureUser1 As String = "ExposureUser1"
			 Public Const ExposureUser2 As String = "ExposureUser2"
			 Public Const ExposureUser3 As String = "ExposureUser3"
			 Public Const ExposureUser4 As String = "ExposureUser4"
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
			SyncLock GetType(CopeFireExposureMetadata)
			
				If CopeFireExposureMetadata.mapDelegates Is Nothing Then
					CopeFireExposureMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If CopeFireExposureMetadata._meta Is Nothing Then
					CopeFireExposureMetadata._meta = New CopeFireExposureMetadata()
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
				meta.AddTypeMap("ExternalFire", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExternalFireProtectionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExternalFireDescriptionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Flood", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FloodProtectionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zone", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("InundationDepth", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Seismic", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SeismicProtectionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FMSeismicZone", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PeakGroundAcceleration2PercentIn50Years", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Windstorm", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WindstormProtectionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MaxSustainedWindSpeed", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("OtherExternal", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OtherProtectionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OtherProtectionDescriptionField", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ModifiedMercalliIndex", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExposureComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExposureUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExposureUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExposureUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExposureUser4", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-FireExposure"
				meta.Destination = "Cope-FireExposure"
				
				meta.spInsert = "proc_Cope-FireExposureInsert"
				meta.spUpdate = "proc_Cope-FireExposureUpdate"
				meta.spDelete = "proc_Cope-FireExposureDelete"
				meta.spLoadAll = "proc_Cope-FireExposureLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-FireExposureLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As CopeFireExposureMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
