
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
	' Encapsulates the 'NatHaz-Flood-OtherDetails' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazFloodOtherDetails))> _
	<XmlType("NatHazFloodOtherDetails")> _	
	Partial Public Class NatHazFloodOtherDetails 
		Inherits esNatHazFloodOtherDetails
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazFloodOtherDetails()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazFloodOtherDetails()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazFloodOtherDetails()
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
	<XmlType("NatHazFloodOtherDetailsCollection")> _
	Partial Public Class NatHazFloodOtherDetailsCollection
		Inherits esNatHazFloodOtherDetailsCollection
		Implements IEnumerable(Of NatHazFloodOtherDetails)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazFloodOtherDetails
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazFloodOtherDetails))> _
		Public Class NatHazFloodOtherDetailsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazFloodOtherDetailsCollection)
			
			Public Shared Widening Operator CType(packet As NatHazFloodOtherDetailsCollectionWCFPacket) As NatHazFloodOtherDetailsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazFloodOtherDetailsCollection) As NatHazFloodOtherDetailsCollectionWCFPacket
				Return New NatHazFloodOtherDetailsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazFloodOtherDetailsQuery 
		Inherits esNatHazFloodOtherDetailsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazFloodOtherDetailsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazFloodOtherDetailsQuery) As String
			Return NatHazFloodOtherDetailsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazFloodOtherDetailsQuery
			Return DirectCast(NatHazFloodOtherDetailsQuery.SerializeHelper.FromXml(query, GetType(NatHazFloodOtherDetailsQuery)), NatHazFloodOtherDetailsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazFloodOtherDetails
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
		
			Dim query As New NatHazFloodOtherDetailsQuery()
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
		' Maps to NatHaz-Flood-OtherDetails.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazFloodOtherDetailsMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazFloodOtherDetailsMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodOtherDetailsMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodOtherDetailsMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.PrepRespPlan
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrepRespPlan As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.PrepRespPlan)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.PrepRespPlan, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.PrepRespPlan)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.PrepRespPlanComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrepRespPlanComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.PrepRespPlanComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.PrepRespPlanComments, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.PrepRespPlanComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.SiteAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SiteAccess As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.SiteAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.SiteAccess, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.SiteAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.SAccessComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SAccessComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.SAccessComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.SAccessComments, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.SAccessComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.Utilities
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Utilities As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.Utilities)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.Utilities, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.Utilities)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.UtilitiesComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UtilitiesComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.UtilitiesComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.UtilitiesComments, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.UtilitiesComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.YardStge
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property YardStge As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.YardStge)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.YardStge, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.YardStge)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.YardStgeComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property YardStgeComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.YardStgeComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.YardStgeComments, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.YardStgeComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.OtherFloodExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherFloodExp As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.OtherFloodExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.OtherFloodExp, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.OtherFloodExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.OtherFloodExpComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherFloodExpComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.OtherFloodExpComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodOtherDetailsMetadata.ColumnNames.OtherFloodExpComments, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.OtherFloodExpComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodOtherDetailsMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodOtherDetailsMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-OtherDetails.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodOtherDetailsMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodOtherDetailsMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.Importorigdate)
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
												
						Case "PrepRespPlan"
							Me.str().PrepRespPlan = CType(value, string)
												
						Case "PrepRespPlanComments"
							Me.str().PrepRespPlanComments = CType(value, string)
												
						Case "SiteAccess"
							Me.str().SiteAccess = CType(value, string)
												
						Case "SAccessComments"
							Me.str().SAccessComments = CType(value, string)
												
						Case "Utilities"
							Me.str().Utilities = CType(value, string)
												
						Case "UtilitiesComments"
							Me.str().UtilitiesComments = CType(value, string)
												
						Case "YardStge"
							Me.str().YardStge = CType(value, string)
												
						Case "YardStgeComments"
							Me.str().YardStgeComments = CType(value, string)
												
						Case "OtherFloodExp"
							Me.str().OtherFloodExp = CType(value, string)
												
						Case "OtherFloodExpComments"
							Me.str().OtherFloodExpComments = CType(value, string)
												
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
								OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodOtherDetailsMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazFloodOtherDetails)
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
		  	
			Public Property PrepRespPlan As System.String 
				Get
					Dim data_ As System.String = entity.PrepRespPlan
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrepRespPlan = Nothing
					Else
						entity.PrepRespPlan = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrepRespPlanComments As System.String 
				Get
					Dim data_ As System.String = entity.PrepRespPlanComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrepRespPlanComments = Nothing
					Else
						entity.PrepRespPlanComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SiteAccess As System.String 
				Get
					Dim data_ As System.String = entity.SiteAccess
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SiteAccess = Nothing
					Else
						entity.SiteAccess = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SAccessComments As System.String 
				Get
					Dim data_ As System.String = entity.SAccessComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SAccessComments = Nothing
					Else
						entity.SAccessComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Utilities As System.String 
				Get
					Dim data_ As System.String = entity.Utilities
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Utilities = Nothing
					Else
						entity.Utilities = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UtilitiesComments As System.String 
				Get
					Dim data_ As System.String = entity.UtilitiesComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UtilitiesComments = Nothing
					Else
						entity.UtilitiesComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property YardStge As System.String 
				Get
					Dim data_ As System.String = entity.YardStge
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.YardStge = Nothing
					Else
						entity.YardStge = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property YardStgeComments As System.String 
				Get
					Dim data_ As System.String = entity.YardStgeComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.YardStgeComments = Nothing
					Else
						entity.YardStgeComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherFloodExp As System.String 
				Get
					Dim data_ As System.String = entity.OtherFloodExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherFloodExp = Nothing
					Else
						entity.OtherFloodExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherFloodExpComments As System.String 
				Get
					Dim data_ As System.String = entity.OtherFloodExpComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherFloodExpComments = Nothing
					Else
						entity.OtherFloodExpComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazFloodOtherDetails
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazFloodOtherDetailsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazFloodOtherDetailsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazFloodOtherDetailsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazFloodOtherDetailsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazFloodOtherDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazFloodOtherDetailsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazFloodOtherDetailsCollection
		Inherits esEntityCollection(Of NatHazFloodOtherDetails)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazFloodOtherDetailsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazFloodOtherDetailsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazFloodOtherDetailsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazFloodOtherDetailsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazFloodOtherDetailsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazFloodOtherDetailsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazFloodOtherDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazFloodOtherDetailsQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazFloodOtherDetailsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazFloodOtherDetailsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazFloodOtherDetailsMetadata.Meta()
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
				Case "PrepRespPlan" 
					Return Me.PrepRespPlan
				Case "PrepRespPlanComments" 
					Return Me.PrepRespPlanComments
				Case "SiteAccess" 
					Return Me.SiteAccess
				Case "SAccessComments" 
					Return Me.SAccessComments
				Case "Utilities" 
					Return Me.Utilities
				Case "UtilitiesComments" 
					Return Me.UtilitiesComments
				Case "YardStge" 
					Return Me.YardStge
				Case "YardStgeComments" 
					Return Me.YardStgeComments
				Case "OtherFloodExp" 
					Return Me.OtherFloodExp
				Case "OtherFloodExpComments" 
					Return Me.OtherFloodExpComments
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
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PrepRespPlan As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.PrepRespPlan, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrepRespPlanComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.PrepRespPlanComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SiteAccess As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.SiteAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SAccessComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.SAccessComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Utilities As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.Utilities, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UtilitiesComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.UtilitiesComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property YardStge As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.YardStge, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property YardStgeComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.YardStgeComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherFloodExp As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.OtherFloodExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherFloodExpComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.OtherFloodExpComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodOtherDetailsMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazFloodOtherDetailsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.PrepRespPlan, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.PrepRespPlan
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.PrepRespPlanComments, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.PrepRespPlanComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.SiteAccess, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.SiteAccess
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.SAccessComments, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.SAccessComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.Utilities, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.Utilities
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.UtilitiesComments, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.UtilitiesComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.YardStge, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.YardStge
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.YardStgeComments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.YardStgeComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.OtherFloodExp, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.OtherFloodExp
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.OtherFloodExpComments, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.OtherFloodExpComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.Importdate, 13, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodOtherDetailsMetadata.ColumnNames.Importorigdate, 14, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodOtherDetailsMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazFloodOtherDetailsMetadata
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
			 Public Const PrepRespPlan As String = "PrepRespPlan"
			 Public Const PrepRespPlanComments As String = "PrepRespPlanComments"
			 Public Const SiteAccess As String = "SiteAccess"
			 Public Const SAccessComments As String = "SAccessComments"
			 Public Const Utilities As String = "Utilities"
			 Public Const UtilitiesComments As String = "UtilitiesComments"
			 Public Const YardStge As String = "YardStge"
			 Public Const YardStgeComments As String = "YardStgeComments"
			 Public Const OtherFloodExp As String = "OtherFloodExp"
			 Public Const OtherFloodExpComments As String = "OtherFloodExpComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const PrepRespPlan As String = "PrepRespPlan"
			 Public Const PrepRespPlanComments As String = "PrepRespPlanComments"
			 Public Const SiteAccess As String = "SiteAccess"
			 Public Const SAccessComments As String = "SAccessComments"
			 Public Const Utilities As String = "Utilities"
			 Public Const UtilitiesComments As String = "UtilitiesComments"
			 Public Const YardStge As String = "YardStge"
			 Public Const YardStgeComments As String = "YardStgeComments"
			 Public Const OtherFloodExp As String = "OtherFloodExp"
			 Public Const OtherFloodExpComments As String = "OtherFloodExpComments"
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
			SyncLock GetType(NatHazFloodOtherDetailsMetadata)
			
				If NatHazFloodOtherDetailsMetadata.mapDelegates Is Nothing Then
					NatHazFloodOtherDetailsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazFloodOtherDetailsMetadata._meta Is Nothing Then
					NatHazFloodOtherDetailsMetadata._meta = New NatHazFloodOtherDetailsMetadata()
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
				meta.AddTypeMap("PrepRespPlan", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PrepRespPlanComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("SiteAccess", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SAccessComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Utilities", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("UtilitiesComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("YardStge", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("YardStgeComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("OtherFloodExp", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OtherFloodExpComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Flood-OtherDetails"
				meta.Destination = "NatHaz-Flood-OtherDetails"
				
				meta.spInsert = "proc_NatHaz-Flood-OtherDetailsInsert"
				meta.spUpdate = "proc_NatHaz-Flood-OtherDetailsUpdate"
				meta.spDelete = "proc_NatHaz-Flood-OtherDetailsDelete"
				meta.spLoadAll = "proc_NatHaz-Flood-OtherDetailsLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Flood-OtherDetailsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazFloodOtherDetailsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
