
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:25 PM
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
	' Encapsulates the 'NatHaz-Wind-Utilities' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazWindUtilities))> _
	<XmlType("NatHazWindUtilities")> _	
	Partial Public Class NatHazWindUtilities 
		Inherits esNatHazWindUtilities
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazWindUtilities()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazWindUtilities()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazWindUtilities()
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
	<XmlType("NatHazWindUtilitiesCollection")> _
	Partial Public Class NatHazWindUtilitiesCollection
		Inherits esNatHazWindUtilitiesCollection
		Implements IEnumerable(Of NatHazWindUtilities)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazWindUtilities
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazWindUtilities))> _
		Public Class NatHazWindUtilitiesCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazWindUtilitiesCollection)
			
			Public Shared Widening Operator CType(packet As NatHazWindUtilitiesCollectionWCFPacket) As NatHazWindUtilitiesCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazWindUtilitiesCollection) As NatHazWindUtilitiesCollectionWCFPacket
				Return New NatHazWindUtilitiesCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazWindUtilitiesQuery 
		Inherits esNatHazWindUtilitiesQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazWindUtilitiesQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazWindUtilitiesQuery) As String
			Return NatHazWindUtilitiesQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazWindUtilitiesQuery
			Return DirectCast(NatHazWindUtilitiesQuery.SerializeHelper.FromXml(query, GetType(NatHazWindUtilitiesQuery)), NatHazWindUtilitiesQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazWindUtilities
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
		
			Dim query As New NatHazWindUtilitiesQuery()
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
		' Maps to NatHaz-Wind-Utilities.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazWindUtilitiesMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazWindUtilitiesMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindUtilitiesMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindUtilitiesMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.WaterRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.WaterRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.WaterRating, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.WaterRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.WaterComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.WaterComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.WaterComments, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.WaterComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.ElectricRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.ElectricRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.ElectricRating, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.ElectricRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.ElectricComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.ElectricComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.ElectricComments, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.ElectricComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.FuelsRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelsRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.FuelsRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.FuelsRating, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.FuelsRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.FuelsComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelsComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.FuelsComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.FuelsComments, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.FuelsComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.BoilersRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.BoilersRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.BoilersRating, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.BoilersRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.BoilersComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.BoilersComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.BoilersComments, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.BoilersComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.TelephoneDataRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TelephoneDataRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.TelephoneDataRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.TelephoneDataRating, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.TelephoneDataRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.TelephoneDataComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TelephoneDataComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.TelephoneDataComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.TelephoneDataComments, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.TelephoneDataComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.HVACCoolingTowersRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HVACCoolingTowersRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.HVACCoolingTowersRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.HVACCoolingTowersRating, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.HVACCoolingTowersRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.HVACCoolingTowersComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HVACCoolingTowersComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.HVACCoolingTowersComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.HVACCoolingTowersComments, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.HVACCoolingTowersComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.OtherRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.OtherRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.OtherRating, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.OtherRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.OtherComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.OtherComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindUtilitiesMetadata.ColumnNames.OtherComments, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.OtherComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindUtilitiesMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindUtilitiesMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-Utilities.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindUtilitiesMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindUtilitiesMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.Importorigdate)
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
												
						Case "WaterRating"
							Me.str().WaterRating = CType(value, string)
												
						Case "WaterComments"
							Me.str().WaterComments = CType(value, string)
												
						Case "ElectricRating"
							Me.str().ElectricRating = CType(value, string)
												
						Case "ElectricComments"
							Me.str().ElectricComments = CType(value, string)
												
						Case "FuelsRating"
							Me.str().FuelsRating = CType(value, string)
												
						Case "FuelsComments"
							Me.str().FuelsComments = CType(value, string)
												
						Case "BoilersRating"
							Me.str().BoilersRating = CType(value, string)
												
						Case "BoilersComments"
							Me.str().BoilersComments = CType(value, string)
												
						Case "TelephoneDataRating"
							Me.str().TelephoneDataRating = CType(value, string)
												
						Case "TelephoneDataComments"
							Me.str().TelephoneDataComments = CType(value, string)
												
						Case "HVACCoolingTowersRating"
							Me.str().HVACCoolingTowersRating = CType(value, string)
												
						Case "HVACCoolingTowersComments"
							Me.str().HVACCoolingTowersComments = CType(value, string)
												
						Case "OtherRating"
							Me.str().OtherRating = CType(value, string)
												
						Case "OtherComments"
							Me.str().OtherComments = CType(value, string)
												
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
								OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindUtilitiesMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazWindUtilities)
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
		  	
			Public Property WaterRating As System.String 
				Get
					Dim data_ As System.String = entity.WaterRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterRating = Nothing
					Else
						entity.WaterRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterComments As System.String 
				Get
					Dim data_ As System.String = entity.WaterComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterComments = Nothing
					Else
						entity.WaterComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricRating As System.String 
				Get
					Dim data_ As System.String = entity.ElectricRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricRating = Nothing
					Else
						entity.ElectricRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricComments As System.String 
				Get
					Dim data_ As System.String = entity.ElectricComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricComments = Nothing
					Else
						entity.ElectricComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelsRating As System.String 
				Get
					Dim data_ As System.String = entity.FuelsRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelsRating = Nothing
					Else
						entity.FuelsRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelsComments As System.String 
				Get
					Dim data_ As System.String = entity.FuelsComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelsComments = Nothing
					Else
						entity.FuelsComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersRating As System.String 
				Get
					Dim data_ As System.String = entity.BoilersRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersRating = Nothing
					Else
						entity.BoilersRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersComments As System.String 
				Get
					Dim data_ As System.String = entity.BoilersComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersComments = Nothing
					Else
						entity.BoilersComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TelephoneDataRating As System.String 
				Get
					Dim data_ As System.String = entity.TelephoneDataRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TelephoneDataRating = Nothing
					Else
						entity.TelephoneDataRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TelephoneDataComments As System.String 
				Get
					Dim data_ As System.String = entity.TelephoneDataComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TelephoneDataComments = Nothing
					Else
						entity.TelephoneDataComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HVACCoolingTowersRating As System.String 
				Get
					Dim data_ As System.String = entity.HVACCoolingTowersRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HVACCoolingTowersRating = Nothing
					Else
						entity.HVACCoolingTowersRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HVACCoolingTowersComments As System.String 
				Get
					Dim data_ As System.String = entity.HVACCoolingTowersComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HVACCoolingTowersComments = Nothing
					Else
						entity.HVACCoolingTowersComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherRating As System.String 
				Get
					Dim data_ As System.String = entity.OtherRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherRating = Nothing
					Else
						entity.OtherRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherComments As System.String 
				Get
					Dim data_ As System.String = entity.OtherComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherComments = Nothing
					Else
						entity.OtherComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazWindUtilities
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazWindUtilitiesMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazWindUtilitiesQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazWindUtilitiesQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazWindUtilitiesQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazWindUtilitiesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazWindUtilitiesQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazWindUtilitiesCollection
		Inherits esEntityCollection(Of NatHazWindUtilities)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazWindUtilitiesMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazWindUtilitiesCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazWindUtilitiesQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazWindUtilitiesQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazWindUtilitiesQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazWindUtilitiesQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazWindUtilitiesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazWindUtilitiesQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazWindUtilitiesQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazWindUtilitiesQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazWindUtilitiesMetadata.Meta()
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
				Case "WaterRating" 
					Return Me.WaterRating
				Case "WaterComments" 
					Return Me.WaterComments
				Case "ElectricRating" 
					Return Me.ElectricRating
				Case "ElectricComments" 
					Return Me.ElectricComments
				Case "FuelsRating" 
					Return Me.FuelsRating
				Case "FuelsComments" 
					Return Me.FuelsComments
				Case "BoilersRating" 
					Return Me.BoilersRating
				Case "BoilersComments" 
					Return Me.BoilersComments
				Case "TelephoneDataRating" 
					Return Me.TelephoneDataRating
				Case "TelephoneDataComments" 
					Return Me.TelephoneDataComments
				Case "HVACCoolingTowersRating" 
					Return Me.HVACCoolingTowersRating
				Case "HVACCoolingTowersComments" 
					Return Me.HVACCoolingTowersComments
				Case "OtherRating" 
					Return Me.OtherRating
				Case "OtherComments" 
					Return Me.OtherComments
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
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property WaterRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.WaterRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.WaterComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.ElectricRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.ElectricComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelsRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.FuelsRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelsComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.FuelsComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.BoilersRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.BoilersComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TelephoneDataRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.TelephoneDataRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TelephoneDataComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.TelephoneDataComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HVACCoolingTowersRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.HVACCoolingTowersRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HVACCoolingTowersComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.HVACCoolingTowersComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.OtherRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.OtherComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindUtilitiesMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazWindUtilitiesMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.WaterRating, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.WaterRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.WaterComments, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.WaterComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.ElectricRating, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.ElectricRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.ElectricComments, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.ElectricComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.FuelsRating, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.FuelsRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.FuelsComments, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.FuelsComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.BoilersRating, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.BoilersRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.BoilersComments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.BoilersComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.TelephoneDataRating, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.TelephoneDataRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.TelephoneDataComments, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.TelephoneDataComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.HVACCoolingTowersRating, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.HVACCoolingTowersRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.HVACCoolingTowersComments, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.HVACCoolingTowersComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.OtherRating, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.OtherRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.OtherComments, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.OtherComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.Importdate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindUtilitiesMetadata.ColumnNames.Importorigdate, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindUtilitiesMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazWindUtilitiesMetadata
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
			 Public Const WaterRating As String = "WaterRating"
			 Public Const WaterComments As String = "WaterComments"
			 Public Const ElectricRating As String = "ElectricRating"
			 Public Const ElectricComments As String = "ElectricComments"
			 Public Const FuelsRating As String = "FuelsRating"
			 Public Const FuelsComments As String = "FuelsComments"
			 Public Const BoilersRating As String = "BoilersRating"
			 Public Const BoilersComments As String = "BoilersComments"
			 Public Const TelephoneDataRating As String = "TelephoneDataRating"
			 Public Const TelephoneDataComments As String = "TelephoneDataComments"
			 Public Const HVACCoolingTowersRating As String = "HVACCoolingTowersRating"
			 Public Const HVACCoolingTowersComments As String = "HVACCoolingTowersComments"
			 Public Const OtherRating As String = "OtherRating"
			 Public Const OtherComments As String = "OtherComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const WaterRating As String = "WaterRating"
			 Public Const WaterComments As String = "WaterComments"
			 Public Const ElectricRating As String = "ElectricRating"
			 Public Const ElectricComments As String = "ElectricComments"
			 Public Const FuelsRating As String = "FuelsRating"
			 Public Const FuelsComments As String = "FuelsComments"
			 Public Const BoilersRating As String = "BoilersRating"
			 Public Const BoilersComments As String = "BoilersComments"
			 Public Const TelephoneDataRating As String = "TelephoneDataRating"
			 Public Const TelephoneDataComments As String = "TelephoneDataComments"
			 Public Const HVACCoolingTowersRating As String = "HVACCoolingTowersRating"
			 Public Const HVACCoolingTowersComments As String = "HVACCoolingTowersComments"
			 Public Const OtherRating As String = "OtherRating"
			 Public Const OtherComments As String = "OtherComments"
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
			SyncLock GetType(NatHazWindUtilitiesMetadata)
			
				If NatHazWindUtilitiesMetadata.mapDelegates Is Nothing Then
					NatHazWindUtilitiesMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazWindUtilitiesMetadata._meta Is Nothing Then
					NatHazWindUtilitiesMetadata._meta = New NatHazWindUtilitiesMetadata()
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
				meta.AddTypeMap("WaterRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("ElectricRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("FuelsRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FuelsComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("BoilersRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("TelephoneDataRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TelephoneDataComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("HVACCoolingTowersRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HVACCoolingTowersComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("OtherRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OtherComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Wind-Utilities"
				meta.Destination = "NatHaz-Wind-Utilities"
				
				meta.spInsert = "proc_NatHaz-Wind-UtilitiesInsert"
				meta.spUpdate = "proc_NatHaz-Wind-UtilitiesUpdate"
				meta.spDelete = "proc_NatHaz-Wind-UtilitiesDelete"
				meta.spLoadAll = "proc_NatHaz-Wind-UtilitiesLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Wind-UtilitiesLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazWindUtilitiesMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
