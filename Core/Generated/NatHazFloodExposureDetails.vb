
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
	' Encapsulates the 'NatHaz-Flood-ExposureDetails' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazFloodExposureDetails))> _
	<XmlType("NatHazFloodExposureDetails")> _	
	Partial Public Class NatHazFloodExposureDetails 
		Inherits esNatHazFloodExposureDetails
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazFloodExposureDetails()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazFloodExposureDetails()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazFloodExposureDetails()
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
	<XmlType("NatHazFloodExposureDetailsCollection")> _
	Partial Public Class NatHazFloodExposureDetailsCollection
		Inherits esNatHazFloodExposureDetailsCollection
		Implements IEnumerable(Of NatHazFloodExposureDetails)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazFloodExposureDetails
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazFloodExposureDetails))> _
		Public Class NatHazFloodExposureDetailsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazFloodExposureDetailsCollection)
			
			Public Shared Widening Operator CType(packet As NatHazFloodExposureDetailsCollectionWCFPacket) As NatHazFloodExposureDetailsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazFloodExposureDetailsCollection) As NatHazFloodExposureDetailsCollectionWCFPacket
				Return New NatHazFloodExposureDetailsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazFloodExposureDetailsQuery 
		Inherits esNatHazFloodExposureDetailsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazFloodExposureDetailsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazFloodExposureDetailsQuery) As String
			Return NatHazFloodExposureDetailsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazFloodExposureDetailsQuery
			Return DirectCast(NatHazFloodExposureDetailsQuery.SerializeHelper.FromXml(query, GetType(NatHazFloodExposureDetailsQuery)), NatHazFloodExposureDetailsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazFloodExposureDetails
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
		
			Dim query As New NatHazFloodExposureDetailsQuery()
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
		' Maps to NatHaz-Flood-ExposureDetails.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazFloodExposureDetailsMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazFloodExposureDetailsMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodExposureDetailsMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodExposureDetailsMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.100YrFlood
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100YrFlood As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames._100YrFlood)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames._100YrFlood, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames._100YrFlood)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.100YrComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100YrComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames._100YrComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames._100YrComments, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames._100YrComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.500YrFlood
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _500YrFlood As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames._500YrFlood)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames._500YrFlood, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames._500YrFlood)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.500YrComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _500YrComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames._500YrComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames._500YrComments, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames._500YrComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.StormSurge
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StormSurge As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.StormSurge)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.StormSurge, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.StormSurge)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.StormSurgeComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StormSurgeComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.StormSurgeComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.StormSurgeComments, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.StormSurgeComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.SurfWater
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurfWater As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.SurfWater)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.SurfWater, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.SurfWater)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.SurfWaterComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurfWaterComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.SurfWaterComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.SurfWaterComments, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.SurfWaterComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.FixedProtection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FixedProtection As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.FixedProtection)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.FixedProtection, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.FixedProtection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.FixedProtComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FixedProtComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.FixedProtComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodExposureDetailsMetadata.ColumnNames.FixedProtComments, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.FixedProtComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodExposureDetailsMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodExposureDetailsMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-ExposureDetails.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodExposureDetailsMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodExposureDetailsMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.Importorigdate)
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
												
						Case "_100YrFlood"
							Me.str()._100YrFlood = CType(value, string)
												
						Case "_100YrComments"
							Me.str()._100YrComments = CType(value, string)
												
						Case "_500YrFlood"
							Me.str()._500YrFlood = CType(value, string)
												
						Case "_500YrComments"
							Me.str()._500YrComments = CType(value, string)
												
						Case "StormSurge"
							Me.str().StormSurge = CType(value, string)
												
						Case "StormSurgeComments"
							Me.str().StormSurgeComments = CType(value, string)
												
						Case "SurfWater"
							Me.str().SurfWater = CType(value, string)
												
						Case "SurfWaterComments"
							Me.str().SurfWaterComments = CType(value, string)
												
						Case "FixedProtection"
							Me.str().FixedProtection = CType(value, string)
												
						Case "FixedProtComments"
							Me.str().FixedProtComments = CType(value, string)
												
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
								OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodExposureDetailsMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazFloodExposureDetails)
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
		  	
			Public Property _100YrFlood As System.String 
				Get
					Dim data_ As System.String = entity._100YrFlood
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._100YrFlood = Nothing
					Else
						entity._100YrFlood = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _100YrComments As System.String 
				Get
					Dim data_ As System.String = entity._100YrComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._100YrComments = Nothing
					Else
						entity._100YrComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _500YrFlood As System.String 
				Get
					Dim data_ As System.String = entity._500YrFlood
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._500YrFlood = Nothing
					Else
						entity._500YrFlood = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _500YrComments As System.String 
				Get
					Dim data_ As System.String = entity._500YrComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._500YrComments = Nothing
					Else
						entity._500YrComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StormSurge As System.String 
				Get
					Dim data_ As System.String = entity.StormSurge
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StormSurge = Nothing
					Else
						entity.StormSurge = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StormSurgeComments As System.String 
				Get
					Dim data_ As System.String = entity.StormSurgeComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StormSurgeComments = Nothing
					Else
						entity.StormSurgeComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SurfWater As System.String 
				Get
					Dim data_ As System.String = entity.SurfWater
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurfWater = Nothing
					Else
						entity.SurfWater = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SurfWaterComments As System.String 
				Get
					Dim data_ As System.String = entity.SurfWaterComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurfWaterComments = Nothing
					Else
						entity.SurfWaterComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FixedProtection As System.String 
				Get
					Dim data_ As System.String = entity.FixedProtection
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FixedProtection = Nothing
					Else
						entity.FixedProtection = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FixedProtComments As System.String 
				Get
					Dim data_ As System.String = entity.FixedProtComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FixedProtComments = Nothing
					Else
						entity.FixedProtComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazFloodExposureDetails
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazFloodExposureDetailsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazFloodExposureDetailsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazFloodExposureDetailsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazFloodExposureDetailsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazFloodExposureDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazFloodExposureDetailsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazFloodExposureDetailsCollection
		Inherits esEntityCollection(Of NatHazFloodExposureDetails)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazFloodExposureDetailsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazFloodExposureDetailsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazFloodExposureDetailsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazFloodExposureDetailsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazFloodExposureDetailsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazFloodExposureDetailsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazFloodExposureDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazFloodExposureDetailsQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazFloodExposureDetailsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazFloodExposureDetailsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazFloodExposureDetailsMetadata.Meta()
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
				Case "_100YrFlood" 
					Return Me._100YrFlood
				Case "_100YrComments" 
					Return Me._100YrComments
				Case "_500YrFlood" 
					Return Me._500YrFlood
				Case "_500YrComments" 
					Return Me._500YrComments
				Case "StormSurge" 
					Return Me.StormSurge
				Case "StormSurgeComments" 
					Return Me.StormSurgeComments
				Case "SurfWater" 
					Return Me.SurfWater
				Case "SurfWaterComments" 
					Return Me.SurfWaterComments
				Case "FixedProtection" 
					Return Me.FixedProtection
				Case "FixedProtComments" 
					Return Me.FixedProtComments
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
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property _100YrFlood As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames._100YrFlood, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100YrComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames._100YrComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _500YrFlood As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames._500YrFlood, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _500YrComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames._500YrComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StormSurge As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.StormSurge, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StormSurgeComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.StormSurgeComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurfWater As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.SurfWater, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurfWaterComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.SurfWaterComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FixedProtection As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.FixedProtection, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FixedProtComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.FixedProtComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodExposureDetailsMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazFloodExposureDetailsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames._100YrFlood, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames._100YrFlood
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames._100YrComments, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames._100YrComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames._500YrFlood, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames._500YrFlood
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames._500YrComments, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames._500YrComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.StormSurge, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.StormSurge
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.StormSurgeComments, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.StormSurgeComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.SurfWater, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.SurfWater
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.SurfWaterComments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.SurfWaterComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.FixedProtection, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.FixedProtection
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.FixedProtComments, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.FixedProtComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.Importdate, 13, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodExposureDetailsMetadata.ColumnNames.Importorigdate, 14, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodExposureDetailsMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazFloodExposureDetailsMetadata
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
			 Public Const _100YrFlood As String = "100YrFlood"
			 Public Const _100YrComments As String = "100YrComments"
			 Public Const _500YrFlood As String = "500YrFlood"
			 Public Const _500YrComments As String = "500YrComments"
			 Public Const StormSurge As String = "StormSurge"
			 Public Const StormSurgeComments As String = "StormSurgeComments"
			 Public Const SurfWater As String = "SurfWater"
			 Public Const SurfWaterComments As String = "SurfWaterComments"
			 Public Const FixedProtection As String = "FixedProtection"
			 Public Const FixedProtComments As String = "FixedProtComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const _100YrFlood As String = "_100YrFlood"
			 Public Const _100YrComments As String = "_100YrComments"
			 Public Const _500YrFlood As String = "_500YrFlood"
			 Public Const _500YrComments As String = "_500YrComments"
			 Public Const StormSurge As String = "StormSurge"
			 Public Const StormSurgeComments As String = "StormSurgeComments"
			 Public Const SurfWater As String = "SurfWater"
			 Public Const SurfWaterComments As String = "SurfWaterComments"
			 Public Const FixedProtection As String = "FixedProtection"
			 Public Const FixedProtComments As String = "FixedProtComments"
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
			SyncLock GetType(NatHazFloodExposureDetailsMetadata)
			
				If NatHazFloodExposureDetailsMetadata.mapDelegates Is Nothing Then
					NatHazFloodExposureDetailsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazFloodExposureDetailsMetadata._meta Is Nothing Then
					NatHazFloodExposureDetailsMetadata._meta = New NatHazFloodExposureDetailsMetadata()
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
				meta.AddTypeMap("_100YrFlood", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_100YrComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("_500YrFlood", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_500YrComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("StormSurge", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StormSurgeComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("SurfWater", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SurfWaterComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("FixedProtection", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FixedProtComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Flood-ExposureDetails"
				meta.Destination = "NatHaz-Flood-ExposureDetails"
				
				meta.spInsert = "proc_NatHaz-Flood-ExposureDetailsInsert"
				meta.spUpdate = "proc_NatHaz-Flood-ExposureDetailsUpdate"
				meta.spDelete = "proc_NatHaz-Flood-ExposureDetailsDelete"
				meta.spLoadAll = "proc_NatHaz-Flood-ExposureDetailsLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Flood-ExposureDetailsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazFloodExposureDetailsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
