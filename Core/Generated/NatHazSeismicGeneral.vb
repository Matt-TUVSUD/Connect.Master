
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
	' Encapsulates the 'NatHaz-Seismic-General' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazSeismicGeneral))> _
	<XmlType("NatHazSeismicGeneral")> _	
	Partial Public Class NatHazSeismicGeneral 
		Inherits esNatHazSeismicGeneral
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazSeismicGeneral()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazSeismicGeneral()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazSeismicGeneral()
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
	<XmlType("NatHazSeismicGeneralCollection")> _
	Partial Public Class NatHazSeismicGeneralCollection
		Inherits esNatHazSeismicGeneralCollection
		Implements IEnumerable(Of NatHazSeismicGeneral)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazSeismicGeneral
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazSeismicGeneral))> _
		Public Class NatHazSeismicGeneralCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazSeismicGeneralCollection)
			
			Public Shared Widening Operator CType(packet As NatHazSeismicGeneralCollectionWCFPacket) As NatHazSeismicGeneralCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazSeismicGeneralCollection) As NatHazSeismicGeneralCollectionWCFPacket
				Return New NatHazSeismicGeneralCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazSeismicGeneralQuery 
		Inherits esNatHazSeismicGeneralQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazSeismicGeneralQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazSeismicGeneralQuery) As String
			Return NatHazSeismicGeneralQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazSeismicGeneralQuery
			Return DirectCast(NatHazSeismicGeneralQuery.SerializeHelper.FromXml(query, GetType(NatHazSeismicGeneralQuery)), NatHazSeismicGeneralQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazSeismicGeneral
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
		
			Dim query As New NatHazSeismicGeneralQuery()
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
		' Maps to NatHaz-Seismic-General.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazSeismicGeneralMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazSeismicGeneralMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicGeneralMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicGeneralMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.Ssummary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ssummary As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.Ssummary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.Ssummary, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Ssummary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.Slosses
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Slosses As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazSeismicGeneralMetadata.ColumnNames.Slosses)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazSeismicGeneralMetadata.ColumnNames.Slosses, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Slosses)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.SLossDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SLossDesc As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.SLossDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.SLossDesc, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.SLossDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.PGA
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pga As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(NatHazSeismicGeneralMetadata.ColumnNames.Pga)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(NatHazSeismicGeneralMetadata.ColumnNames.Pga, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Pga)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.FMSeismic
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FMSeismic As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.FMSeismic)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.FMSeismic, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.FMSeismic)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.MMI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mmi As System.String
			Get
				Return MyBase.GetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.Mmi)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazSeismicGeneralMetadata.ColumnNames.Mmi, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Mmi)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.Liquefaction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Liquefaction As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazSeismicGeneralMetadata.ColumnNames.Liquefaction)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazSeismicGeneralMetadata.ColumnNames.Liquefaction, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Liquefaction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.SteepSlopes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SteepSlopes As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NatHazSeismicGeneralMetadata.ColumnNames.SteepSlopes)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(NatHazSeismicGeneralMetadata.ColumnNames.SteepSlopes, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.SteepSlopes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicGeneralMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicGeneralMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Seismic-General.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazSeismicGeneralMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazSeismicGeneralMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Importorigdate)
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
												
						Case "Ssummary"
							Me.str().Ssummary = CType(value, string)
												
						Case "Slosses"
							Me.str().Slosses = CType(value, string)
												
						Case "SLossDesc"
							Me.str().SLossDesc = CType(value, string)
												
						Case "Pga"
							Me.str().Pga = CType(value, string)
												
						Case "FMSeismic"
							Me.str().FMSeismic = CType(value, string)
												
						Case "Mmi"
							Me.str().Mmi = CType(value, string)
												
						Case "Liquefaction"
							Me.str().Liquefaction = CType(value, string)
												
						Case "SteepSlopes"
							Me.str().SteepSlopes = CType(value, string)
												
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
								OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Slosses"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Slosses = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Slosses)
							End If
						
						Case "Pga"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pga = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Pga)
							End If
						
						Case "Liquefaction"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Liquefaction = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Liquefaction)
							End If
						
						Case "SteepSlopes"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SteepSlopes = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.SteepSlopes)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazSeismicGeneralMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazSeismicGeneral)
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
		  	
			Public Property Ssummary As System.String 
				Get
					Dim data_ As System.String = entity.Ssummary
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ssummary = Nothing
					Else
						entity.Ssummary = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Slosses As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Slosses
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Slosses = Nothing
					Else
						entity.Slosses = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SLossDesc As System.String 
				Get
					Dim data_ As System.String = entity.SLossDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SLossDesc = Nothing
					Else
						entity.SLossDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pga As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Pga
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pga = Nothing
					Else
						entity.Pga = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property FMSeismic As System.String 
				Get
					Dim data_ As System.String = entity.FMSeismic
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FMSeismic = Nothing
					Else
						entity.FMSeismic = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mmi As System.String 
				Get
					Dim data_ As System.String = entity.Mmi
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mmi = Nothing
					Else
						entity.Mmi = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Liquefaction As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Liquefaction
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Liquefaction = Nothing
					Else
						entity.Liquefaction = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SteepSlopes As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SteepSlopes
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SteepSlopes = Nothing
					Else
						entity.SteepSlopes = Convert.ToBoolean(Value)
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
		  

			Private entity As esNatHazSeismicGeneral
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazSeismicGeneralMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazSeismicGeneralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazSeismicGeneralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazSeismicGeneralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazSeismicGeneralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazSeismicGeneralQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazSeismicGeneralCollection
		Inherits esEntityCollection(Of NatHazSeismicGeneral)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazSeismicGeneralMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazSeismicGeneralCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazSeismicGeneralQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazSeismicGeneralQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazSeismicGeneralQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazSeismicGeneralQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazSeismicGeneralQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazSeismicGeneralQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazSeismicGeneralQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazSeismicGeneralQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazSeismicGeneralMetadata.Meta()
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
				Case "Ssummary" 
					Return Me.Ssummary
				Case "Slosses" 
					Return Me.Slosses
				Case "SLossDesc" 
					Return Me.SLossDesc
				Case "Pga" 
					Return Me.Pga
				Case "FMSeismic" 
					Return Me.FMSeismic
				Case "Mmi" 
					Return Me.Mmi
				Case "Liquefaction" 
					Return Me.Liquefaction
				Case "SteepSlopes" 
					Return Me.SteepSlopes
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
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Ssummary As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.Ssummary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Slosses As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.Slosses, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SLossDesc As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.SLossDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Pga As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.Pga, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property FMSeismic As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.FMSeismic, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Mmi As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.Mmi, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Liquefaction As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.Liquefaction, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SteepSlopes As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.SteepSlopes, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazSeismicGeneralMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazSeismicGeneralMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.Ssummary, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.Ssummary
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.Slosses, 4, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.Slosses
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.SLossDesc, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.SLossDesc
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.Pga, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.Pga
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.FMSeismic, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.FMSeismic
			c.CharacterMaxLength = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.Mmi, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.Mmi
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.Liquefaction, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.Liquefaction
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.SteepSlopes, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.SteepSlopes
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.Importdate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazSeismicGeneralMetadata.ColumnNames.Importorigdate, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazSeismicGeneralMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazSeismicGeneralMetadata
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
			 Public Const Ssummary As String = "Ssummary"
			 Public Const Slosses As String = "Slosses"
			 Public Const SLossDesc As String = "SLossDesc"
			 Public Const Pga As String = "PGA"
			 Public Const FMSeismic As String = "FMSeismic"
			 Public Const Mmi As String = "MMI"
			 Public Const Liquefaction As String = "Liquefaction"
			 Public Const SteepSlopes As String = "SteepSlopes"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Ssummary As String = "Ssummary"
			 Public Const Slosses As String = "Slosses"
			 Public Const SLossDesc As String = "SLossDesc"
			 Public Const Pga As String = "Pga"
			 Public Const FMSeismic As String = "FMSeismic"
			 Public Const Mmi As String = "Mmi"
			 Public Const Liquefaction As String = "Liquefaction"
			 Public Const SteepSlopes As String = "SteepSlopes"
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
			SyncLock GetType(NatHazSeismicGeneralMetadata)
			
				If NatHazSeismicGeneralMetadata.mapDelegates Is Nothing Then
					NatHazSeismicGeneralMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazSeismicGeneralMetadata._meta Is Nothing Then
					NatHazSeismicGeneralMetadata._meta = New NatHazSeismicGeneralMetadata()
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
				meta.AddTypeMap("Ssummary", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Slosses", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SLossDesc", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Pga", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("FMSeismic", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Mmi", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Liquefaction", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SteepSlopes", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Seismic-General"
				meta.Destination = "NatHaz-Seismic-General"
				
				meta.spInsert = "proc_NatHaz-Seismic-GeneralInsert"
				meta.spUpdate = "proc_NatHaz-Seismic-GeneralUpdate"
				meta.spDelete = "proc_NatHaz-Seismic-GeneralDelete"
				meta.spLoadAll = "proc_NatHaz-Seismic-GeneralLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Seismic-GeneralLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazSeismicGeneralMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
