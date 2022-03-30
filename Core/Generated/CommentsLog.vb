
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:19 PM
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
	' Encapsulates the 'CommentsLog' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(CommentsLog))> _
	<XmlType("CommentsLog")> _	
	Partial Public Class CommentsLog 
		Inherits esCommentsLog
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New CommentsLog()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New CommentsLog()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New CommentsLog()
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
	<XmlType("CommentsLogCollection")> _
	Partial Public Class CommentsLogCollection
		Inherits esCommentsLogCollection
		Implements IEnumerable(Of CommentsLog)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As CommentsLog
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(CommentsLog))> _
		Public Class CommentsLogCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of CommentsLogCollection)
			
			Public Shared Widening Operator CType(packet As CommentsLogCollectionWCFPacket) As CommentsLogCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As CommentsLogCollection) As CommentsLogCollectionWCFPacket
				Return New CommentsLogCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class CommentsLogQuery 
		Inherits esCommentsLogQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "CommentsLogQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As CommentsLogQuery) As String
			Return CommentsLogQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As CommentsLogQuery
			Return DirectCast(CommentsLogQuery.SerializeHelper.FromXml(query, GetType(CommentsLogQuery)), CommentsLogQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esCommentsLog
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
		
			Dim query As New CommentsLogQuery()
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
		' Maps to CommentsLog.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommentsLogMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CommentsLogMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.DateOfComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateOfComment As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CommentsLogMetadata.ColumnNames.DateOfComment)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CommentsLogMetadata.ColumnNames.DateOfComment, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.DateOfComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.UserFullName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UserFullName As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.UserFullName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.UserFullName, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.UserFullName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.UserEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UserEmail As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.UserEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.UserEmail, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.UserEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.ClientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientName As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.ClientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.ClientName, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.ClientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.Practice
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Practice As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.Practice)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.Practice, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.Practice)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.PageParentGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PageParentGroup As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.PageParentGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.PageParentGroup, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.PageParentGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.ParentId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ParentId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommentsLogMetadata.ColumnNames.ParentId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CommentsLogMetadata.ColumnNames.ParentId, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.ParentId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.PageId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PageId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommentsLogMetadata.ColumnNames.PageId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CommentsLogMetadata.ColumnNames.PageId, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.PageId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.PageName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PageName As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.PageName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.PageName, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.PageName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.PageURL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PageURL As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.PageURL)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.PageURL, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.PageURL)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.Status
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.Status, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.Status)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to CommentsLog.GRCComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCComments As System.String
			Get
				Return MyBase.GetSystemString(CommentsLogMetadata.ColumnNames.GRCComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CommentsLogMetadata.ColumnNames.GRCComments, value) Then
					OnPropertyChanged(CommentsLogMetadata.PropertyNames.GRCComments)
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
												
						Case "DateOfComment"
							Me.str().DateOfComment = CType(value, string)
												
						Case "UserFullName"
							Me.str().UserFullName = CType(value, string)
												
						Case "UserEmail"
							Me.str().UserEmail = CType(value, string)
												
						Case "ClientName"
							Me.str().ClientName = CType(value, string)
												
						Case "Practice"
							Me.str().Practice = CType(value, string)
												
						Case "PageParentGroup"
							Me.str().PageParentGroup = CType(value, string)
												
						Case "ParentId"
							Me.str().ParentId = CType(value, string)
												
						Case "PageId"
							Me.str().PageId = CType(value, string)
												
						Case "PageName"
							Me.str().PageName = CType(value, string)
												
						Case "PageURL"
							Me.str().PageURL = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
												
						Case "Status"
							Me.str().Status = CType(value, string)
												
						Case "GRCComments"
							Me.str().GRCComments = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CommentsLogMetadata.PropertyNames.Id)
							End If
						
						Case "DateOfComment"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateOfComment = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CommentsLogMetadata.PropertyNames.DateOfComment)
							End If
						
						Case "ParentId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ParentId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CommentsLogMetadata.PropertyNames.ParentId)
							End If
						
						Case "PageId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PageId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CommentsLogMetadata.PropertyNames.PageId)
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
		
			Public Sub New(ByVal entity As esCommentsLog)
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
		  	
			Public Property DateOfComment As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateOfComment
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateOfComment = Nothing
					Else
						entity.DateOfComment = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property UserFullName As System.String 
				Get
					Dim data_ As System.String = entity.UserFullName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UserFullName = Nothing
					Else
						entity.UserFullName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UserEmail As System.String 
				Get
					Dim data_ As System.String = entity.UserEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UserEmail = Nothing
					Else
						entity.UserEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ClientName As System.String 
				Get
					Dim data_ As System.String = entity.ClientName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClientName = Nothing
					Else
						entity.ClientName = Convert.ToString(Value)
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
		  	
			Public Property PageParentGroup As System.String 
				Get
					Dim data_ As System.String = entity.PageParentGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PageParentGroup = Nothing
					Else
						entity.PageParentGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ParentId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ParentId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ParentId = Nothing
					Else
						entity.ParentId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PageId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PageId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PageId = Nothing
					Else
						entity.PageId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PageName As System.String 
				Get
					Dim data_ As System.String = entity.PageName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PageName = Nothing
					Else
						entity.PageName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PageURL As System.String 
				Get
					Dim data_ As System.String = entity.PageURL
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PageURL = Nothing
					Else
						entity.PageURL = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Comments As System.String 
				Get
					Dim data_ As System.String = entity.Comments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Comments = Nothing
					Else
						entity.Comments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Status As System.String 
				Get
					Dim data_ As System.String = entity.Status
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Status = Nothing
					Else
						entity.Status = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GRCComments As System.String 
				Get
					Dim data_ As System.String = entity.GRCComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GRCComments = Nothing
					Else
						entity.GRCComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCommentsLog
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CommentsLogMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As CommentsLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CommentsLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As CommentsLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As CommentsLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CommentsLogQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esCommentsLogCollection
		Inherits esEntityCollection(Of CommentsLog)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CommentsLogMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "CommentsLogCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As CommentsLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CommentsLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As CommentsLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New CommentsLogQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As CommentsLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, CommentsLogQuery))
		End Sub
		
		#End Region
						
		Private m_query As CommentsLogQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esCommentsLogQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommentsLogMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "DateOfComment" 
					Return Me.DateOfComment
				Case "UserFullName" 
					Return Me.UserFullName
				Case "UserEmail" 
					Return Me.UserEmail
				Case "ClientName" 
					Return Me.ClientName
				Case "Practice" 
					Return Me.Practice
				Case "PageParentGroup" 
					Return Me.PageParentGroup
				Case "ParentId" 
					Return Me.ParentId
				Case "PageId" 
					Return Me.PageId
				Case "PageName" 
					Return Me.PageName
				Case "PageURL" 
					Return Me.PageURL
				Case "Comments" 
					Return Me.Comments
				Case "Status" 
					Return Me.Status
				Case "GRCComments" 
					Return Me.GRCComments
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateOfComment As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.DateOfComment, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property UserFullName As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.UserFullName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UserEmail As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.UserEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClientName As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.ClientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Practice As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.Practice, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PageParentGroup As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.PageParentGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ParentId As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.ParentId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PageId As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.PageId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PageName As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.PageName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PageURL As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.PageURL, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCComments As esQueryItem
			Get
				Return New esQueryItem(Me, CommentsLogMetadata.ColumnNames.GRCComments, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class CommentsLogMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.DateOfComment, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.DateOfComment
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.UserFullName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.UserFullName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.UserEmail, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.UserEmail
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.ClientName, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.ClientName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.Practice, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.Practice
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.PageParentGroup, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.PageParentGroup
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.ParentId, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.ParentId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.PageId, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.PageId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.PageName, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.PageName
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.PageURL, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.PageURL
			c.CharacterMaxLength = 200
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.Comments, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.Status, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.Status
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CommentsLogMetadata.ColumnNames.GRCComments, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommentsLogMetadata.PropertyNames.GRCComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As CommentsLogMetadata
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
			 Public Const DateOfComment As String = "DateOfComment"
			 Public Const UserFullName As String = "UserFullName"
			 Public Const UserEmail As String = "UserEmail"
			 Public Const ClientName As String = "ClientName"
			 Public Const Practice As String = "Practice"
			 Public Const PageParentGroup As String = "PageParentGroup"
			 Public Const ParentId As String = "ParentId"
			 Public Const PageId As String = "PageId"
			 Public Const PageName As String = "PageName"
			 Public Const PageURL As String = "PageURL"
			 Public Const Comments As String = "Comments"
			 Public Const Status As String = "Status"
			 Public Const GRCComments As String = "GRCComments"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const DateOfComment As String = "DateOfComment"
			 Public Const UserFullName As String = "UserFullName"
			 Public Const UserEmail As String = "UserEmail"
			 Public Const ClientName As String = "ClientName"
			 Public Const Practice As String = "Practice"
			 Public Const PageParentGroup As String = "PageParentGroup"
			 Public Const ParentId As String = "ParentId"
			 Public Const PageId As String = "PageId"
			 Public Const PageName As String = "PageName"
			 Public Const PageURL As String = "PageURL"
			 Public Const Comments As String = "Comments"
			 Public Const Status As String = "Status"
			 Public Const GRCComments As String = "GRCComments"
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
			SyncLock GetType(CommentsLogMetadata)
			
				If CommentsLogMetadata.mapDelegates Is Nothing Then
					CommentsLogMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If CommentsLogMetadata._meta Is Nothing Then
					CommentsLogMetadata._meta = New CommentsLogMetadata()
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
				meta.AddTypeMap("DateOfComment", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("UserFullName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("UserEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ClientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Practice", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PageParentGroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ParentId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PageId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PageName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PageURL", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Comments", new esTypeMap("text", "System.String"))
				meta.AddTypeMap("Status", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("GRCComments", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "CommentsLog"
				meta.Destination = "CommentsLog"
				
				meta.spInsert = "proc_CommentsLogInsert"
				meta.spUpdate = "proc_CommentsLogUpdate"
				meta.spDelete = "proc_CommentsLogDelete"
				meta.spLoadAll = "proc_CommentsLogLoadAll"
				meta.spLoadByPrimaryKey = "proc_CommentsLogLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As CommentsLogMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
