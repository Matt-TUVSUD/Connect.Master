
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:22 PM
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
	' Encapsulates the 'ezy_AuditLog' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(EzyAuditLog))> _
	<XmlType("EzyAuditLog")> _	
	Partial Public Class EzyAuditLog 
		Inherits esEzyAuditLog
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New EzyAuditLog()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal logID As System.Decimal)
			Dim obj As New EzyAuditLog()
			obj.LogID = logID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal logID As System.Decimal, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New EzyAuditLog()
			obj.LogID = logID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("EzyAuditLogCollection")> _
	Partial Public Class EzyAuditLogCollection
		Inherits esEzyAuditLogCollection
		Implements IEnumerable(Of EzyAuditLog)
	
		Public Function FindByPrimaryKey(ByVal logID As System.Decimal) As EzyAuditLog
			Return MyBase.SingleOrDefault(Function(e) e.LogID.HasValue AndAlso e.LogID.Value = logID)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(EzyAuditLog))> _
		Public Class EzyAuditLogCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of EzyAuditLogCollection)
			
			Public Shared Widening Operator CType(packet As EzyAuditLogCollectionWCFPacket) As EzyAuditLogCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As EzyAuditLogCollection) As EzyAuditLogCollectionWCFPacket
				Return New EzyAuditLogCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class EzyAuditLogQuery 
		Inherits esEzyAuditLogQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "EzyAuditLogQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As EzyAuditLogQuery) As String
			Return EzyAuditLogQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As EzyAuditLogQuery
			Return DirectCast(EzyAuditLogQuery.SerializeHelper.FromXml(query, GetType(EzyAuditLogQuery)), EzyAuditLogQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esEzyAuditLog
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal logID As System.Decimal) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(logID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(logID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal logID As System.Decimal) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(logID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(logID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal logID As System.Decimal) As Boolean
		
			Dim query As New EzyAuditLogQuery()
			query.Where(query.LogID = logID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal logID As System.Decimal) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LogID", logID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to ezy_AuditLog.LogID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LogID As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(EzyAuditLogMetadata.ColumnNames.LogID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(EzyAuditLogMetadata.ColumnNames.LogID, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.LogID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.fileprefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fileprefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(EzyAuditLogMetadata.ColumnNames.Fileprefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(EzyAuditLogMetadata.ColumnNames.Fileprefix, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.Fileprefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.DateTime
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(EzyAuditLogMetadata.ColumnNames.DateTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(EzyAuditLogMetadata.ColumnNames.DateTime, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.DateTime)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.LogIn
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LogIn As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(EzyAuditLogMetadata.ColumnNames.LogIn)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(EzyAuditLogMetadata.ColumnNames.LogIn, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.LogIn)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.LogOut
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LogOut As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(EzyAuditLogMetadata.ColumnNames.LogOut)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(EzyAuditLogMetadata.ColumnNames.LogOut, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.LogOut)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.Duration
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Duration As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(EzyAuditLogMetadata.ColumnNames.Duration)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(EzyAuditLogMetadata.ColumnNames.Duration, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.Duration)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.username
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Username As System.String
			Get
				Return MyBase.GetSystemString(EzyAuditLogMetadata.ColumnNames.Username)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EzyAuditLogMetadata.ColumnNames.Username, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.Username)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.UserID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UserID As System.String
			Get
				Return MyBase.GetSystemString(EzyAuditLogMetadata.ColumnNames.UserID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EzyAuditLogMetadata.ColumnNames.UserID, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.UserID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.User
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property User As System.String
			Get
				Return MyBase.GetSystemString(EzyAuditLogMetadata.ColumnNames.User)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EzyAuditLogMetadata.ColumnNames.User, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.User)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.Object
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property fldObject As System.String
			Get
				Return MyBase.GetSystemString(EzyAuditLogMetadata.ColumnNames.fldObject)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EzyAuditLogMetadata.ColumnNames.fldObject, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.fldObject)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.Action
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Action As System.String
			Get
				Return MyBase.GetSystemString(EzyAuditLogMetadata.ColumnNames.Action)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EzyAuditLogMetadata.ColumnNames.Action, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.Action)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.DataKey
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataKey As System.String
			Get
				Return MyBase.GetSystemString(EzyAuditLogMetadata.ColumnNames.DataKey)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EzyAuditLogMetadata.ColumnNames.DataKey, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.DataKey)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.GRCAdministrator
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCAdministrator As System.String
			Get
				Return MyBase.GetSystemString(EzyAuditLogMetadata.ColumnNames.GRCAdministrator)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EzyAuditLogMetadata.ColumnNames.GRCAdministrator, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.GRCAdministrator)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.SessionTimeout
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SessionTimeout As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(EzyAuditLogMetadata.ColumnNames.SessionTimeout)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(EzyAuditLogMetadata.ColumnNames.SessionTimeout, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.SessionTimeout)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to ezy_AuditLog.EzyUserID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EzyUserID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EzyAuditLogMetadata.ColumnNames.EzyUserID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(EzyAuditLogMetadata.ColumnNames.EzyUserID, value) Then
					OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.EzyUserID)
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
												
						Case "LogID"
							Me.str().LogID = CType(value, string)
												
						Case "Fileprefix"
							Me.str().Fileprefix = CType(value, string)
												
						Case "DateTime"
							Me.str().DateTime = CType(value, string)
												
						Case "LogIn"
							Me.str().LogIn = CType(value, string)
												
						Case "LogOut"
							Me.str().LogOut = CType(value, string)
												
						Case "Duration"
							Me.str().Duration = CType(value, string)
												
						Case "Username"
							Me.str().Username = CType(value, string)
												
						Case "UserID"
							Me.str().UserID = CType(value, string)
												
						Case "User"
							Me.str().User = CType(value, string)
												
						Case "fldObject"
							Me.str().fldObject = CType(value, string)
												
						Case "Action"
							Me.str().Action = CType(value, string)
												
						Case "DataKey"
							Me.str().DataKey = CType(value, string)
												
						Case "GRCAdministrator"
							Me.str().GRCAdministrator = CType(value, string)
												
						Case "SessionTimeout"
							Me.str().SessionTimeout = CType(value, string)
												
						Case "EzyUserID"
							Me.str().EzyUserID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LogID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.LogID = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.LogID)
							End If
						
						Case "Fileprefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Fileprefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.Fileprefix)
							End If
						
						Case "DateTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateTime = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.DateTime)
							End If
						
						Case "LogIn"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LogIn = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.LogIn)
							End If
						
						Case "LogOut"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LogOut = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.LogOut)
							End If
						
						Case "Duration"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Duration = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.Duration)
							End If
						
						Case "SessionTimeout"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SessionTimeout = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.SessionTimeout)
							End If
						
						Case "EzyUserID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EzyUserID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(EzyAuditLogMetadata.PropertyNames.EzyUserID)
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
		
			Public Sub New(ByVal entity As esEzyAuditLog)
				Me.entity = entity
			End Sub				
		
	
			Public Property LogID As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.LogID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogID = Nothing
					Else
						entity.LogID = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fileprefix As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Fileprefix
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fileprefix = Nothing
					Else
						entity.Fileprefix = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateTime = Nothing
					Else
						entity.DateTime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LogIn As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LogIn
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogIn = Nothing
					Else
						entity.LogIn = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LogOut As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LogOut
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogOut = Nothing
					Else
						entity.LogOut = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Duration As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Duration
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Duration = Nothing
					Else
						entity.Duration = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Username As System.String 
				Get
					Dim data_ As System.String = entity.Username
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Username = Nothing
					Else
						entity.Username = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UserID As System.String 
				Get
					Dim data_ As System.String = entity.UserID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UserID = Nothing
					Else
						entity.UserID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property User As System.String 
				Get
					Dim data_ As System.String = entity.User
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.User = Nothing
					Else
						entity.User = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property fldObject As System.String 
				Get
					Dim data_ As System.String = entity.fldObject
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.fldObject = Nothing
					Else
						entity.fldObject = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Action As System.String 
				Get
					Dim data_ As System.String = entity.Action
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Action = Nothing
					Else
						entity.Action = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataKey As System.String 
				Get
					Dim data_ As System.String = entity.DataKey
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataKey = Nothing
					Else
						entity.DataKey = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GRCAdministrator As System.String 
				Get
					Dim data_ As System.String = entity.GRCAdministrator
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GRCAdministrator = Nothing
					Else
						entity.GRCAdministrator = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SessionTimeout As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SessionTimeout
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SessionTimeout = Nothing
					Else
						entity.SessionTimeout = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property EzyUserID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EzyUserID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EzyUserID = Nothing
					Else
						entity.EzyUserID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esEzyAuditLog
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EzyAuditLogMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As EzyAuditLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EzyAuditLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As EzyAuditLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As EzyAuditLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As EzyAuditLogQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esEzyAuditLogCollection
		Inherits esEntityCollection(Of EzyAuditLog)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EzyAuditLogMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "EzyAuditLogCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As EzyAuditLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EzyAuditLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As EzyAuditLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New EzyAuditLogQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As EzyAuditLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, EzyAuditLogQuery))
		End Sub
		
		#End Region
						
		Private m_query As EzyAuditLogQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esEzyAuditLogQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EzyAuditLogMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "LogID" 
					Return Me.LogID
				Case "Fileprefix" 
					Return Me.Fileprefix
				Case "DateTime" 
					Return Me.DateTime
				Case "LogIn" 
					Return Me.LogIn
				Case "LogOut" 
					Return Me.LogOut
				Case "Duration" 
					Return Me.Duration
				Case "Username" 
					Return Me.Username
				Case "UserID" 
					Return Me.UserID
				Case "User" 
					Return Me.User
				Case "fldObject" 
					Return Me.fldObject
				Case "Action" 
					Return Me.Action
				Case "DataKey" 
					Return Me.DataKey
				Case "GRCAdministrator" 
					Return Me.GRCAdministrator
				Case "SessionTimeout" 
					Return Me.SessionTimeout
				Case "EzyUserID" 
					Return Me.EzyUserID
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property LogID As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.LogID, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Fileprefix As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.Fileprefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property DateTime As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.DateTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LogIn As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.LogIn, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LogOut As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.LogOut, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Duration As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.Duration, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Username As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.Username, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UserID As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.UserID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property User As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.User, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property fldObject As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.fldObject, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Action As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.Action, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataKey As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.DataKey, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCAdministrator As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.GRCAdministrator, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SessionTimeout As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.SessionTimeout, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property EzyUserID As esQueryItem
			Get
				Return New esQueryItem(Me, EzyAuditLogMetadata.ColumnNames.EzyUserID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class EzyAuditLogMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.LogID, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.LogID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.Fileprefix, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.Fileprefix
			c.NumericPrecision = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.DateTime, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.DateTime
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.LogIn, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.LogIn
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.LogOut, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.LogOut
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.Duration, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.Duration
			c.NumericPrecision = 18
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.Username, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.Username
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.UserID, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.UserID
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.User, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.User
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.fldObject, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.fldObject
			c.CharacterMaxLength = 100
			c.IsNullable = True
			c.Alias = "fldObject"
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.Action, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.Action
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.DataKey, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.DataKey
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.GRCAdministrator, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.GRCAdministrator
			c.CharacterMaxLength = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.SessionTimeout, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.SessionTimeout
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EzyAuditLogMetadata.ColumnNames.EzyUserID, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EzyAuditLogMetadata.PropertyNames.EzyUserID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As EzyAuditLogMetadata
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
			 Public Const LogID As String = "LogID"
			 Public Const Fileprefix As String = "fileprefix"
			 Public Const DateTime As String = "DateTime"
			 Public Const LogIn As String = "LogIn"
			 Public Const LogOut As String = "LogOut"
			 Public Const Duration As String = "Duration"
			 Public Const Username As String = "username"
			 Public Const UserID As String = "UserID"
			 Public Const User As String = "User"
			 Public Const fldObject As String = "Object"
			 Public Const Action As String = "Action"
			 Public Const DataKey As String = "DataKey"
			 Public Const GRCAdministrator As String = "GRCAdministrator"
			 Public Const SessionTimeout As String = "SessionTimeout"
			 Public Const EzyUserID As String = "EzyUserID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LogID As String = "LogID"
			 Public Const Fileprefix As String = "Fileprefix"
			 Public Const DateTime As String = "DateTime"
			 Public Const LogIn As String = "LogIn"
			 Public Const LogOut As String = "LogOut"
			 Public Const Duration As String = "Duration"
			 Public Const Username As String = "Username"
			 Public Const UserID As String = "UserID"
			 Public Const User As String = "User"
			 Public Const fldObject As String = "fldObject"
			 Public Const Action As String = "Action"
			 Public Const DataKey As String = "DataKey"
			 Public Const GRCAdministrator As String = "GRCAdministrator"
			 Public Const SessionTimeout As String = "SessionTimeout"
			 Public Const EzyUserID As String = "EzyUserID"
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
			SyncLock GetType(EzyAuditLogMetadata)
			
				If EzyAuditLogMetadata.mapDelegates Is Nothing Then
					EzyAuditLogMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If EzyAuditLogMetadata._meta Is Nothing Then
					EzyAuditLogMetadata._meta = New EzyAuditLogMetadata()
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
				


				meta.AddTypeMap("LogID", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Fileprefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("DateTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LogIn", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LogOut", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Duration", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Username", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("UserID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("User", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("fldObject", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Action", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DataKey", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("GRCAdministrator", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SessionTimeout", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("EzyUserID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "ezy_AuditLog"
				meta.Destination = "ezy_AuditLog"
				
				meta.spInsert = "proc_ezy_AuditLogInsert"
				meta.spUpdate = "proc_ezy_AuditLogUpdate"
				meta.spDelete = "proc_ezy_AuditLogDelete"
				meta.spLoadAll = "proc_ezy_AuditLogLoadAll"
				meta.spLoadByPrimaryKey = "proc_ezy_AuditLogLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As EzyAuditLogMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
