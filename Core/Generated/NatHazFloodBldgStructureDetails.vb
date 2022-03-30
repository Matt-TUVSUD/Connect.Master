
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
	' Encapsulates the 'NatHaz-Flood-BldgStructureDetails' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazFloodBldgStructureDetails))> _
	<XmlType("NatHazFloodBldgStructureDetails")> _	
	Partial Public Class NatHazFloodBldgStructureDetails 
		Inherits esNatHazFloodBldgStructureDetails
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazFloodBldgStructureDetails()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazFloodBldgStructureDetails()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazFloodBldgStructureDetails()
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
	<XmlType("NatHazFloodBldgStructureDetailsCollection")> _
	Partial Public Class NatHazFloodBldgStructureDetailsCollection
		Inherits esNatHazFloodBldgStructureDetailsCollection
		Implements IEnumerable(Of NatHazFloodBldgStructureDetails)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazFloodBldgStructureDetails
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazFloodBldgStructureDetails))> _
		Public Class NatHazFloodBldgStructureDetailsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazFloodBldgStructureDetailsCollection)
			
			Public Shared Widening Operator CType(packet As NatHazFloodBldgStructureDetailsCollectionWCFPacket) As NatHazFloodBldgStructureDetailsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazFloodBldgStructureDetailsCollection) As NatHazFloodBldgStructureDetailsCollectionWCFPacket
				Return New NatHazFloodBldgStructureDetailsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazFloodBldgStructureDetailsQuery 
		Inherits esNatHazFloodBldgStructureDetailsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazFloodBldgStructureDetailsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazFloodBldgStructureDetailsQuery) As String
			Return NatHazFloodBldgStructureDetailsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazFloodBldgStructureDetailsQuery
			Return DirectCast(NatHazFloodBldgStructureDetailsQuery.SerializeHelper.FromXml(query, GetType(NatHazFloodBldgStructureDetailsQuery)), NatHazFloodBldgStructureDetailsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazFloodBldgStructureDetails
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
		
			Dim query As New NatHazFloodBldgStructureDetailsQuery()
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
		' Maps to NatHaz-Flood-BldgStructureDetails.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.AEBG
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aebg As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Aebg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Aebg, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Aebg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.AEBGComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AEBGComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.AEBGComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.AEBGComments, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.AEBGComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.ContConst
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContConst As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.ContConst)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.ContConst, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.ContConst)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.ContContComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContContComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.ContContComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.ContContComments, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.ContContComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.OtherBldgStruc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherBldgStruc As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.OtherBldgStruc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.OtherBldgStruc, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.OtherBldgStruc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.OtherBSComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherBSComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.OtherBSComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.OtherBSComments, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.OtherBSComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Flood-BldgStructureDetails.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Importorigdate)
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
												
						Case "Aebg"
							Me.str().Aebg = CType(value, string)
												
						Case "AEBGComments"
							Me.str().AEBGComments = CType(value, string)
												
						Case "ContConst"
							Me.str().ContConst = CType(value, string)
												
						Case "ContContComments"
							Me.str().ContContComments = CType(value, string)
												
						Case "OtherBldgStruc"
							Me.str().OtherBldgStruc = CType(value, string)
												
						Case "OtherBSComments"
							Me.str().OtherBSComments = CType(value, string)
												
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
								OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazFloodBldgStructureDetails)
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
		  	
			Public Property Aebg As System.String 
				Get
					Dim data_ As System.String = entity.Aebg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aebg = Nothing
					Else
						entity.Aebg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AEBGComments As System.String 
				Get
					Dim data_ As System.String = entity.AEBGComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AEBGComments = Nothing
					Else
						entity.AEBGComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContConst As System.String 
				Get
					Dim data_ As System.String = entity.ContConst
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContConst = Nothing
					Else
						entity.ContConst = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContContComments As System.String 
				Get
					Dim data_ As System.String = entity.ContContComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContContComments = Nothing
					Else
						entity.ContContComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherBldgStruc As System.String 
				Get
					Dim data_ As System.String = entity.OtherBldgStruc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherBldgStruc = Nothing
					Else
						entity.OtherBldgStruc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherBSComments As System.String 
				Get
					Dim data_ As System.String = entity.OtherBSComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherBSComments = Nothing
					Else
						entity.OtherBSComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazFloodBldgStructureDetails
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazFloodBldgStructureDetailsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazFloodBldgStructureDetailsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazFloodBldgStructureDetailsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazFloodBldgStructureDetailsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazFloodBldgStructureDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazFloodBldgStructureDetailsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazFloodBldgStructureDetailsCollection
		Inherits esEntityCollection(Of NatHazFloodBldgStructureDetails)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazFloodBldgStructureDetailsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazFloodBldgStructureDetailsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazFloodBldgStructureDetailsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazFloodBldgStructureDetailsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazFloodBldgStructureDetailsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazFloodBldgStructureDetailsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazFloodBldgStructureDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazFloodBldgStructureDetailsQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazFloodBldgStructureDetailsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazFloodBldgStructureDetailsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazFloodBldgStructureDetailsMetadata.Meta()
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
				Case "Aebg" 
					Return Me.Aebg
				Case "AEBGComments" 
					Return Me.AEBGComments
				Case "ContConst" 
					Return Me.ContConst
				Case "ContContComments" 
					Return Me.ContContComments
				Case "OtherBldgStruc" 
					Return Me.OtherBldgStruc
				Case "OtherBSComments" 
					Return Me.OtherBSComments
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
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Aebg As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Aebg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AEBGComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.AEBGComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContConst As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.ContConst, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContContComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.ContContComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherBldgStruc As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.OtherBldgStruc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherBSComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.OtherBSComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazFloodBldgStructureDetailsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Aebg, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Aebg
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.AEBGComments, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.AEBGComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.ContConst, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.ContConst
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.ContContComments, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.ContContComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.OtherBldgStruc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.OtherBldgStruc
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.OtherBSComments, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.OtherBSComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Importdate, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazFloodBldgStructureDetailsMetadata.ColumnNames.Importorigdate, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazFloodBldgStructureDetailsMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazFloodBldgStructureDetailsMetadata
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
			 Public Const Aebg As String = "AEBG"
			 Public Const AEBGComments As String = "AEBGComments"
			 Public Const ContConst As String = "ContConst"
			 Public Const ContContComments As String = "ContContComments"
			 Public Const OtherBldgStruc As String = "OtherBldgStruc"
			 Public Const OtherBSComments As String = "OtherBSComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const Aebg As String = "Aebg"
			 Public Const AEBGComments As String = "AEBGComments"
			 Public Const ContConst As String = "ContConst"
			 Public Const ContContComments As String = "ContContComments"
			 Public Const OtherBldgStruc As String = "OtherBldgStruc"
			 Public Const OtherBSComments As String = "OtherBSComments"
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
			SyncLock GetType(NatHazFloodBldgStructureDetailsMetadata)
			
				If NatHazFloodBldgStructureDetailsMetadata.mapDelegates Is Nothing Then
					NatHazFloodBldgStructureDetailsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazFloodBldgStructureDetailsMetadata._meta Is Nothing Then
					NatHazFloodBldgStructureDetailsMetadata._meta = New NatHazFloodBldgStructureDetailsMetadata()
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
				meta.AddTypeMap("Aebg", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AEBGComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("ContConst", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ContContComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("OtherBldgStruc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OtherBSComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Flood-BldgStructureDetails"
				meta.Destination = "NatHaz-Flood-BldgStructureDetails"
				
				meta.spInsert = "proc_NatHaz-Flood-BldgStructureDetailsInsert"
				meta.spUpdate = "proc_NatHaz-Flood-BldgStructureDetailsUpdate"
				meta.spDelete = "proc_NatHaz-Flood-BldgStructureDetailsDelete"
				meta.spLoadAll = "proc_NatHaz-Flood-BldgStructureDetailsLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Flood-BldgStructureDetailsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazFloodBldgStructureDetailsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
