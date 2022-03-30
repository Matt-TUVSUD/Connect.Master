
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/26/2014 2:31:44 PM
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
	' Encapsulates the 'viewCCInspectionDateGreaterDateStampAll' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCInspectionDateGreaterDateStampAll))> _
	<XmlType("ViewCCInspectionDateGreaterDateStampAll")> _	
	Partial Public Class ViewCCInspectionDateGreaterDateStampAll 
		Inherits esViewCCInspectionDateGreaterDateStampAll
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCInspectionDateGreaterDateStampAll()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCInspectionDateGreaterDateStampAllCollection")> _
	Partial Public Class ViewCCInspectionDateGreaterDateStampAllCollection
		Inherits esViewCCInspectionDateGreaterDateStampAllCollection
		Implements IEnumerable(Of ViewCCInspectionDateGreaterDateStampAll)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCInspectionDateGreaterDateStampAll))> _
		Public Class ViewCCInspectionDateGreaterDateStampAllCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCInspectionDateGreaterDateStampAllCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCInspectionDateGreaterDateStampAllCollectionWCFPacket) As ViewCCInspectionDateGreaterDateStampAllCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCInspectionDateGreaterDateStampAllCollection) As ViewCCInspectionDateGreaterDateStampAllCollectionWCFPacket
				Return New ViewCCInspectionDateGreaterDateStampAllCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCInspectionDateGreaterDateStampAllQuery 
		Inherits esViewCCInspectionDateGreaterDateStampAllQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCInspectionDateGreaterDateStampAllQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCInspectionDateGreaterDateStampAllQuery) As String
			Return ViewCCInspectionDateGreaterDateStampAllQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCInspectionDateGreaterDateStampAllQuery
			Return DirectCast(ViewCCInspectionDateGreaterDateStampAllQuery.SerializeHelper.FromXml(query, GetType(ViewCCInspectionDateGreaterDateStampAllQuery)), ViewCCInspectionDateGreaterDateStampAllQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCInspectionDateGreaterDateStampAll
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCInspectionDateGreaterDateStampAll.RowNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RowNumber As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.RowNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.RowNumber, value) Then
					OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.RowNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCInspectionDateGreaterDateStampAll.Id
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCInspectionDateGreaterDateStampAll.Client
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client As System.String
			Get
				Return MyBase.GetSystemString(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.Client)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.Client, value) Then
					OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.Client)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCInspectionDateGreaterDateStampAll.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCInspectionDateGreaterDateStampAll.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCInspectionDateGreaterDateStampAll.DateStamp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateStamp As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.DateStamp)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.DateStamp, value) Then
					OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.DateStamp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCInspectionDateGreaterDateStampAll.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.InspectionDate)
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
												
						Case "RowNumber"
							Me.str().RowNumber = CType(value, string)
												
						Case "Id"
							Me.str().Id = CType(value, string)
												
						Case "Client"
							Me.str().Client = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
						Case "DateStamp"
							Me.str().DateStamp = CType(value, string)
												
						Case "InspectionDate"
							Me.str().InspectionDate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RowNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.RowNumber = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.RowNumber)
							End If
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.Id)
							End If
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "DateStamp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateStamp = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.DateStamp)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.InspectionDate)
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
		
			Public Sub New(ByVal entity As esViewCCInspectionDateGreaterDateStampAll)
				Me.entity = entity
			End Sub				
		
	
			Public Property RowNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.RowNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RowNumber = Nothing
					Else
						entity.RowNumber = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Client As System.String 
				Get
					Dim data_ As System.String = entity.Client
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Client = Nothing
					Else
						entity.Client = Convert.ToString(Value)
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
		  	
			Public Property PracticeCode As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.PracticeCode
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeCode = Nothing
					Else
						entity.PracticeCode = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateStamp As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateStamp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateStamp = Nothing
					Else
						entity.DateStamp = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionDate = Nothing
					Else
						entity.InspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCInspectionDateGreaterDateStampAll
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCInspectionDateGreaterDateStampAllMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCInspectionDateGreaterDateStampAllQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCInspectionDateGreaterDateStampAllQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCInspectionDateGreaterDateStampAllQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCInspectionDateGreaterDateStampAllQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCInspectionDateGreaterDateStampAllQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCInspectionDateGreaterDateStampAllCollection
		Inherits esEntityCollection(Of ViewCCInspectionDateGreaterDateStampAll)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCInspectionDateGreaterDateStampAllMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCInspectionDateGreaterDateStampAllCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCInspectionDateGreaterDateStampAllQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCInspectionDateGreaterDateStampAllQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCInspectionDateGreaterDateStampAllQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCInspectionDateGreaterDateStampAllQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCInspectionDateGreaterDateStampAllQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCInspectionDateGreaterDateStampAllQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCInspectionDateGreaterDateStampAllQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCInspectionDateGreaterDateStampAllQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCInspectionDateGreaterDateStampAllMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "RowNumber" 
					Return Me.RowNumber
				Case "Id" 
					Return Me.Id
				Case "Client" 
					Return Me.Client
				Case "FileNo" 
					Return Me.FileNo
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "DateStamp" 
					Return Me.DateStamp
				Case "InspectionDate" 
					Return Me.InspectionDate
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property RowNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.RowNumber, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Client As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.Client, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property DateStamp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.DateStamp, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCInspectionDateGreaterDateStampAllMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.RowNumber, 0, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.RowNumber
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.Id, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.Client, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.Client
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.FileNo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.PracticeCode, 4, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.DateStamp, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.DateStamp
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCInspectionDateGreaterDateStampAllMetadata.ColumnNames.InspectionDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCInspectionDateGreaterDateStampAllMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCInspectionDateGreaterDateStampAllMetadata
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
			 Public Const RowNumber As String = "RowNumber"
			 Public Const Id As String = "Id"
			 Public Const Client As String = "Client"
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const DateStamp As String = "DateStamp"
			 Public Const InspectionDate As String = "InspectionDate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const RowNumber As String = "RowNumber"
			 Public Const Id As String = "Id"
			 Public Const Client As String = "Client"
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const DateStamp As String = "DateStamp"
			 Public Const InspectionDate As String = "InspectionDate"
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
			SyncLock GetType(ViewCCInspectionDateGreaterDateStampAllMetadata)
			
				If ViewCCInspectionDateGreaterDateStampAllMetadata.mapDelegates Is Nothing Then
					ViewCCInspectionDateGreaterDateStampAllMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCInspectionDateGreaterDateStampAllMetadata._meta Is Nothing Then
					ViewCCInspectionDateGreaterDateStampAllMetadata._meta = New ViewCCInspectionDateGreaterDateStampAllMetadata()
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
				


				meta.AddTypeMap("RowNumber", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Client", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("DateStamp", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("InspectionDate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewCCInspectionDateGreaterDateStampAll"
				meta.Destination = "viewCCInspectionDateGreaterDateStampAll"
				
				meta.spInsert = "proc_viewCCInspectionDateGreaterDateStampAllInsert"
				meta.spUpdate = "proc_viewCCInspectionDateGreaterDateStampAllUpdate"
				meta.spDelete = "proc_viewCCInspectionDateGreaterDateStampAllDelete"
				meta.spLoadAll = "proc_viewCCInspectionDateGreaterDateStampAllLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCInspectionDateGreaterDateStampAllLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCInspectionDateGreaterDateStampAllMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
