
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/3/2018 4:26:33 PM
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
	' Encapsulates the 'ReportArchive' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ReportArchive))> _
	<XmlType("ReportArchive")> _	
	Partial Public Class ReportArchive 
		Inherits esReportArchive
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ReportArchive()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New ReportArchive()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New ReportArchive()
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
	<XmlType("ReportArchiveCollection")> _
	Partial Public Class ReportArchiveCollection
		Inherits esReportArchiveCollection
		Implements IEnumerable(Of ReportArchive)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As ReportArchive
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ReportArchive))> _
		Public Class ReportArchiveCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ReportArchiveCollection)
			
			Public Shared Widening Operator CType(packet As ReportArchiveCollectionWCFPacket) As ReportArchiveCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ReportArchiveCollection) As ReportArchiveCollectionWCFPacket
				Return New ReportArchiveCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ReportArchiveQuery 
		Inherits esReportArchiveQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ReportArchiveQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ReportArchiveQuery) As String
			Return ReportArchiveQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ReportArchiveQuery
			Return DirectCast(ReportArchiveQuery.SerializeHelper.FromXml(query, GetType(ReportArchiveQuery)), ReportArchiveQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esReportArchive
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
		
			Dim query As New ReportArchiveQuery()
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
		' Maps to ReportArchive.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReportArchiveMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ReportArchiveMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ReportArchiveMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ReportArchiveMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReportDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReportArchiveMetadata.ColumnNames.ReportDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ReportArchiveMetadata.ColumnNames.ReportDate, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.ReportDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.Report 1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report1 As System.String
			Get
				Return MyBase.GetSystemString(ReportArchiveMetadata.ColumnNames.Report1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ReportArchiveMetadata.ColumnNames.Report1, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.Report1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.Report 2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Report2 As System.String
			Get
				Return MyBase.GetSystemString(ReportArchiveMetadata.ColumnNames.Report2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ReportArchiveMetadata.ColumnNames.Report2, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.Report2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.Diagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Diagram As System.String
			Get
				Return MyBase.GetSystemString(ReportArchiveMetadata.ColumnNames.Diagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ReportArchiveMetadata.ColumnNames.Diagram, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.Diagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.Practice
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Practice As System.String
			Get
				Return MyBase.GetSystemString(ReportArchiveMetadata.ColumnNames.Practice)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ReportArchiveMetadata.ColumnNames.Practice, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.Practice)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.DatePosted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DatePosted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReportArchiveMetadata.ColumnNames.DatePosted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ReportArchiveMetadata.ColumnNames.DatePosted, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.DatePosted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.DateTransferred
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateTransferred As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReportArchiveMetadata.ColumnNames.DateTransferred)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ReportArchiveMetadata.ColumnNames.DateTransferred, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.DateTransferred)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.DateToClient
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateToClient As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReportArchiveMetadata.ColumnNames.DateToClient)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ReportArchiveMetadata.ColumnNames.DateToClient, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.DateToClient)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.PreviousDateCompleted
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PreviousDateCompleted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReportArchiveMetadata.ColumnNames.PreviousDateCompleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ReportArchiveMetadata.ColumnNames.PreviousDateCompleted, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.PreviousDateCompleted)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.PreviousReport1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PreviousReport1 As System.String
			Get
				Return MyBase.GetSystemString(ReportArchiveMetadata.ColumnNames.PreviousReport1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ReportArchiveMetadata.ColumnNames.PreviousReport1, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.PreviousReport1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.PreviousDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PreviousDiagram As System.String
			Get
				Return MyBase.GetSystemString(ReportArchiveMetadata.ColumnNames.PreviousDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ReportArchiveMetadata.ColumnNames.PreviousDiagram, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.PreviousDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.ReportGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReportGUID As System.String
			Get
				Return MyBase.GetSystemString(ReportArchiveMetadata.ColumnNames.ReportGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ReportArchiveMetadata.ColumnNames.ReportGUID, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.ReportGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ReportArchive.MetaPracticeID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MetaPracticeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReportArchiveMetadata.ColumnNames.MetaPracticeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ReportArchiveMetadata.ColumnNames.MetaPracticeID, value) Then
					OnPropertyChanged(ReportArchiveMetadata.PropertyNames.MetaPracticeID)
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
												
						Case "ReportDate"
							Me.str().ReportDate = CType(value, string)
												
						Case "Report1"
							Me.str().Report1 = CType(value, string)
												
						Case "Report2"
							Me.str().Report2 = CType(value, string)
												
						Case "Diagram"
							Me.str().Diagram = CType(value, string)
												
						Case "Practice"
							Me.str().Practice = CType(value, string)
												
						Case "DatePosted"
							Me.str().DatePosted = CType(value, string)
												
						Case "DateTransferred"
							Me.str().DateTransferred = CType(value, string)
												
						Case "DateToClient"
							Me.str().DateToClient = CType(value, string)
												
						Case "PreviousDateCompleted"
							Me.str().PreviousDateCompleted = CType(value, string)
												
						Case "PreviousReport1"
							Me.str().PreviousReport1 = CType(value, string)
												
						Case "PreviousDiagram"
							Me.str().PreviousDiagram = CType(value, string)
												
						Case "ReportGUID"
							Me.str().ReportGUID = CType(value, string)
												
						Case "MetaPracticeID"
							Me.str().MetaPracticeID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ReportArchiveMetadata.PropertyNames.Id)
							End If
						
						Case "ReportDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ReportDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ReportArchiveMetadata.PropertyNames.ReportDate)
							End If
						
						Case "DatePosted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DatePosted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ReportArchiveMetadata.PropertyNames.DatePosted)
							End If
						
						Case "DateTransferred"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateTransferred = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ReportArchiveMetadata.PropertyNames.DateTransferred)
							End If
						
						Case "DateToClient"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateToClient = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ReportArchiveMetadata.PropertyNames.DateToClient)
							End If
						
						Case "PreviousDateCompleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PreviousDateCompleted = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ReportArchiveMetadata.PropertyNames.PreviousDateCompleted)
							End If
						
						Case "MetaPracticeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MetaPracticeID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ReportArchiveMetadata.PropertyNames.MetaPracticeID)
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
		
			Public Sub New(ByVal entity As esReportArchive)
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
		  	
			Public Property ReportDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ReportDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReportDate = Nothing
					Else
						entity.ReportDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Report1 As System.String 
				Get
					Dim data_ As System.String = entity.Report1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Report1 = Nothing
					Else
						entity.Report1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Report2 As System.String 
				Get
					Dim data_ As System.String = entity.Report2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Report2 = Nothing
					Else
						entity.Report2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Diagram As System.String 
				Get
					Dim data_ As System.String = entity.Diagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Diagram = Nothing
					Else
						entity.Diagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Practice As System.String 
				Get
					Dim data_ As System.String = entity.Practice
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Practice = Nothing
					Else
						entity.Practice = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DatePosted As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DatePosted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DatePosted = Nothing
					Else
						entity.DatePosted = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateTransferred As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateTransferred
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateTransferred = Nothing
					Else
						entity.DateTransferred = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateToClient As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateToClient
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateToClient = Nothing
					Else
						entity.DateToClient = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property PreviousDateCompleted As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PreviousDateCompleted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PreviousDateCompleted = Nothing
					Else
						entity.PreviousDateCompleted = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property PreviousReport1 As System.String 
				Get
					Dim data_ As System.String = entity.PreviousReport1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PreviousReport1 = Nothing
					Else
						entity.PreviousReport1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PreviousDiagram As System.String 
				Get
					Dim data_ As System.String = entity.PreviousDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PreviousDiagram = Nothing
					Else
						entity.PreviousDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReportGUID As System.String 
				Get
					Dim data_ As System.String = entity.ReportGUID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReportGUID = Nothing
					Else
						entity.ReportGUID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MetaPracticeID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MetaPracticeID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MetaPracticeID = Nothing
					Else
						entity.MetaPracticeID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esReportArchive
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ReportArchiveMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ReportArchiveQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ReportArchiveQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ReportArchiveQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ReportArchiveQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ReportArchiveQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esReportArchiveCollection
		Inherits esEntityCollection(Of ReportArchive)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ReportArchiveMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ReportArchiveCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ReportArchiveQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ReportArchiveQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ReportArchiveQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ReportArchiveQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ReportArchiveQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ReportArchiveQuery))
		End Sub
		
		#End Region
						
		Private m_query As ReportArchiveQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esReportArchiveQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReportArchiveMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "ReportDate" 
					Return Me.ReportDate
				Case "Report1" 
					Return Me.Report1
				Case "Report2" 
					Return Me.Report2
				Case "Diagram" 
					Return Me.Diagram
				Case "Practice" 
					Return Me.Practice
				Case "DatePosted" 
					Return Me.DatePosted
				Case "DateTransferred" 
					Return Me.DateTransferred
				Case "DateToClient" 
					Return Me.DateToClient
				Case "PreviousDateCompleted" 
					Return Me.PreviousDateCompleted
				Case "PreviousReport1" 
					Return Me.PreviousReport1
				Case "PreviousDiagram" 
					Return Me.PreviousDiagram
				Case "ReportGUID" 
					Return Me.ReportGUID
				Case "MetaPracticeID" 
					Return Me.MetaPracticeID
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReportDate As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.ReportDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Report1 As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.Report1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Report2 As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.Report2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Diagram As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.Diagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Practice As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.Practice, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DatePosted As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.DatePosted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateTransferred As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.DateTransferred, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateToClient As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.DateToClient, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PreviousDateCompleted As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.PreviousDateCompleted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PreviousReport1 As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.PreviousReport1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PreviousDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.PreviousDiagram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReportGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.ReportGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MetaPracticeID As esQueryItem
			Get
				Return New esQueryItem(Me, ReportArchiveMetadata.ColumnNames.MetaPracticeID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class ReportArchive 
		Inherits esReportArchive
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class ReportArchiveMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.ReportDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.ReportDate
			c.IsNullable = True
			c.Alias = "ReportDate"
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.Report1, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.Report1
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.Report2, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.Report2
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.Diagram, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.Diagram
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.Practice, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.Practice
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.DatePosted, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.DatePosted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.DateTransferred, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.DateTransferred
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.DateToClient, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.DateToClient
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.PreviousDateCompleted, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.PreviousDateCompleted
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.PreviousReport1, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.PreviousReport1
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.PreviousDiagram, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.PreviousDiagram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.ReportGUID, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.ReportGUID
			c.CharacterMaxLength = 50
			c.HasDefault = True
			c.Default = "(newid())"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ReportArchiveMetadata.ColumnNames.MetaPracticeID, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReportArchiveMetadata.PropertyNames.MetaPracticeID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ReportArchiveMetadata
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
			 Public Const ReportDate As String = "Date"
			 Public Const Report1 As String = "Report 1"
			 Public Const Report2 As String = "Report 2"
			 Public Const Diagram As String = "Diagram"
			 Public Const Practice As String = "Practice"
			 Public Const DatePosted As String = "DatePosted"
			 Public Const DateTransferred As String = "DateTransferred"
			 Public Const DateToClient As String = "DateToClient"
			 Public Const PreviousDateCompleted As String = "PreviousDateCompleted"
			 Public Const PreviousReport1 As String = "PreviousReport1"
			 Public Const PreviousDiagram As String = "PreviousDiagram"
			 Public Const ReportGUID As String = "ReportGUID"
			 Public Const MetaPracticeID As String = "MetaPracticeID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const ReportDate As String = "ReportDate"
			 Public Const Report1 As String = "Report1"
			 Public Const Report2 As String = "Report2"
			 Public Const Diagram As String = "Diagram"
			 Public Const Practice As String = "Practice"
			 Public Const DatePosted As String = "DatePosted"
			 Public Const DateTransferred As String = "DateTransferred"
			 Public Const DateToClient As String = "DateToClient"
			 Public Const PreviousDateCompleted As String = "PreviousDateCompleted"
			 Public Const PreviousReport1 As String = "PreviousReport1"
			 Public Const PreviousDiagram As String = "PreviousDiagram"
			 Public Const ReportGUID As String = "ReportGUID"
			 Public Const MetaPracticeID As String = "MetaPracticeID"
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
			SyncLock GetType(ReportArchiveMetadata)
			
				If ReportArchiveMetadata.mapDelegates Is Nothing Then
					ReportArchiveMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ReportArchiveMetadata._meta Is Nothing Then
					ReportArchiveMetadata._meta = New ReportArchiveMetadata()
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
				meta.AddTypeMap("ReportDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Report1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Report2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Diagram", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Practice", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DatePosted", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DateTransferred", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DateToClient", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PreviousDateCompleted", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PreviousReport1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PreviousDiagram", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReportGUID", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MetaPracticeID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "ReportArchive"
				meta.Destination = "ReportArchive"
				
				meta.spInsert = "proc_ReportArchiveInsert"
				meta.spUpdate = "proc_ReportArchiveUpdate"
				meta.spDelete = "proc_ReportArchiveDelete"
				meta.spLoadAll = "proc_ReportArchiveLoadAll"
				meta.spLoadByPrimaryKey = "proc_ReportArchiveLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ReportArchiveMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
