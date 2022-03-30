
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/4/2018 9:44:50 AM
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
	' Encapsulates the 'viewCCAdminWindowDocManagerWind' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCAdminWindowDocManagerWind))> _
	<XmlType("ViewCCAdminWindowDocManagerWind")> _	
	Partial Public Class ViewCCAdminWindowDocManagerWind 
		Inherits esViewCCAdminWindowDocManagerWind
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCAdminWindowDocManagerWind()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCAdminWindowDocManagerWindCollection")> _
	Partial Public Class ViewCCAdminWindowDocManagerWindCollection
		Inherits esViewCCAdminWindowDocManagerWindCollection
		Implements IEnumerable(Of ViewCCAdminWindowDocManagerWind)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCAdminWindowDocManagerWind))> _
		Public Class ViewCCAdminWindowDocManagerWindCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCAdminWindowDocManagerWindCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCAdminWindowDocManagerWindCollectionWCFPacket) As ViewCCAdminWindowDocManagerWindCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCAdminWindowDocManagerWindCollection) As ViewCCAdminWindowDocManagerWindCollectionWCFPacket
				Return New ViewCCAdminWindowDocManagerWindCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCAdminWindowDocManagerWindQuery 
		Inherits esViewCCAdminWindowDocManagerWindQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCAdminWindowDocManagerWindQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCAdminWindowDocManagerWindQuery) As String
			Return ViewCCAdminWindowDocManagerWindQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCAdminWindowDocManagerWindQuery
			Return DirectCast(ViewCCAdminWindowDocManagerWindQuery.SerializeHelper.FromXml(query, GetType(ViewCCAdminWindowDocManagerWindQuery)), ViewCCAdminWindowDocManagerWindQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerWind
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.PracticeName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.PracticeName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.PracticeName, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.PracticeName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.ReportArchiveID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReportArchiveID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.ReportArchiveID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.ReportArchiveID, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.ReportArchiveID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.DateOfInspection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateOfInspection As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateOfInspection)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateOfInspection, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateOfInspection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.DateMailedToClient
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateMailedToClient As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateMailedToClient)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateMailedToClient, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateMailedToClient)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.DateOfInspectionCurrent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateOfInspectionCurrent As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateOfInspectionCurrent)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateOfInspectionCurrent, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateOfInspectionCurrent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.DateMailedToClientCurrent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateMailedToClientCurrent As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateMailedToClientCurrent)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateMailedToClientCurrent, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateMailedToClientCurrent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.LinkToReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToReport, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.LinkToReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.LinkToReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToReport2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToReport2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToReport2, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.LinkToReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerWind.LinkToDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToDiagram As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToDiagram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToDiagram, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.LinkToDiagram)
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
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
						Case "PracticeName"
							Me.str().PracticeName = CType(value, string)
												
						Case "ReportArchiveID"
							Me.str().ReportArchiveID = CType(value, string)
												
						Case "DateOfInspection"
							Me.str().DateOfInspection = CType(value, string)
												
						Case "DateMailedToClient"
							Me.str().DateMailedToClient = CType(value, string)
												
						Case "DateOfInspectionCurrent"
							Me.str().DateOfInspectionCurrent = CType(value, string)
												
						Case "DateMailedToClientCurrent"
							Me.str().DateMailedToClientCurrent = CType(value, string)
												
						Case "LinkToReport"
							Me.str().LinkToReport = CType(value, string)
												
						Case "LinkToReport2"
							Me.str().LinkToReport2 = CType(value, string)
												
						Case "LinkToDiagram"
							Me.str().LinkToDiagram = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "ReportArchiveID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ReportArchiveID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.ReportArchiveID)
							End If
						
						Case "DateOfInspection"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateOfInspection = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateOfInspection)
							End If
						
						Case "DateMailedToClient"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateMailedToClient = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateMailedToClient)
							End If
						
						Case "DateOfInspectionCurrent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateOfInspectionCurrent = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateOfInspectionCurrent)
							End If
						
						Case "DateMailedToClientCurrent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateMailedToClientCurrent = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateMailedToClientCurrent)
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
		
			Public Sub New(ByVal entity As esViewCCAdminWindowDocManagerWind)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property PracticeName As System.String 
				Get
					Dim data_ As System.String = entity.PracticeName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeName = Nothing
					Else
						entity.PracticeName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReportArchiveID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ReportArchiveID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReportArchiveID = Nothing
					Else
						entity.ReportArchiveID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateOfInspection As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateOfInspection
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateOfInspection = Nothing
					Else
						entity.DateOfInspection = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateMailedToClient As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateMailedToClient
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateMailedToClient = Nothing
					Else
						entity.DateMailedToClient = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateOfInspectionCurrent As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateOfInspectionCurrent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateOfInspectionCurrent = Nothing
					Else
						entity.DateOfInspectionCurrent = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateMailedToClientCurrent As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateMailedToClientCurrent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateMailedToClientCurrent = Nothing
					Else
						entity.DateMailedToClientCurrent = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToReport As System.String 
				Get
					Dim data_ As System.String = entity.LinkToReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkToReport = Nothing
					Else
						entity.LinkToReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToReport2 As System.String 
				Get
					Dim data_ As System.String = entity.LinkToReport2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkToReport2 = Nothing
					Else
						entity.LinkToReport2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToDiagram As System.String 
				Get
					Dim data_ As System.String = entity.LinkToDiagram
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkToDiagram = Nothing
					Else
						entity.LinkToDiagram = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCAdminWindowDocManagerWind
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerWindMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCAdminWindowDocManagerWindQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowDocManagerWindQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCAdminWindowDocManagerWindQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowDocManagerWindQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCAdminWindowDocManagerWindQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerWindCollection
		Inherits esEntityCollection(Of ViewCCAdminWindowDocManagerWind)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerWindMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCAdminWindowDocManagerWindCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCAdminWindowDocManagerWindQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowDocManagerWindQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCAdminWindowDocManagerWindQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCAdminWindowDocManagerWindQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowDocManagerWindQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCAdminWindowDocManagerWindQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCAdminWindowDocManagerWindQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerWindQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerWindMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "PracticeName" 
					Return Me.PracticeName
				Case "ReportArchiveID" 
					Return Me.ReportArchiveID
				Case "DateOfInspection" 
					Return Me.DateOfInspection
				Case "DateMailedToClient" 
					Return Me.DateMailedToClient
				Case "DateOfInspectionCurrent" 
					Return Me.DateOfInspectionCurrent
				Case "DateMailedToClientCurrent" 
					Return Me.DateMailedToClientCurrent
				Case "LinkToReport" 
					Return Me.LinkToReport
				Case "LinkToReport2" 
					Return Me.LinkToReport2
				Case "LinkToDiagram" 
					Return Me.LinkToDiagram
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.PracticeName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReportArchiveID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.ReportArchiveID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateOfInspection As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateOfInspection, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateMailedToClient As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateMailedToClient, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateOfInspectionCurrent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateOfInspectionCurrent, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateMailedToClientCurrent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateMailedToClientCurrent, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToReport2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToDiagram, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCAdminWindowDocManagerWindMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.PracticeCode, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.PracticeName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.PracticeName
			c.CharacterMaxLength = 4
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.ReportArchiveID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.ReportArchiveID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateOfInspection, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateOfInspection
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateMailedToClient, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateMailedToClient
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateOfInspectionCurrent, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateOfInspectionCurrent
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.DateMailedToClientCurrent, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.DateMailedToClientCurrent
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToReport, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.LinkToReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToReport2, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.LinkToReport2
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerWindMetadata.ColumnNames.LinkToDiagram, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerWindMetadata.PropertyNames.LinkToDiagram
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCAdminWindowDocManagerWindMetadata
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
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const PracticeName As String = "PracticeName"
			 Public Const ReportArchiveID As String = "ReportArchiveID"
			 Public Const DateOfInspection As String = "DateOfInspection"
			 Public Const DateMailedToClient As String = "DateMailedToClient"
			 Public Const DateOfInspectionCurrent As String = "DateOfInspectionCurrent"
			 Public Const DateMailedToClientCurrent As String = "DateMailedToClientCurrent"
			 Public Const LinkToReport As String = "LinkToReport"
			 Public Const LinkToReport2 As String = "LinkToReport2"
			 Public Const LinkToDiagram As String = "LinkToDiagram"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const PracticeName As String = "PracticeName"
			 Public Const ReportArchiveID As String = "ReportArchiveID"
			 Public Const DateOfInspection As String = "DateOfInspection"
			 Public Const DateMailedToClient As String = "DateMailedToClient"
			 Public Const DateOfInspectionCurrent As String = "DateOfInspectionCurrent"
			 Public Const DateMailedToClientCurrent As String = "DateMailedToClientCurrent"
			 Public Const LinkToReport As String = "LinkToReport"
			 Public Const LinkToReport2 As String = "LinkToReport2"
			 Public Const LinkToDiagram As String = "LinkToDiagram"
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
			SyncLock GetType(ViewCCAdminWindowDocManagerWindMetadata)
			
				If ViewCCAdminWindowDocManagerWindMetadata.mapDelegates Is Nothing Then
					ViewCCAdminWindowDocManagerWindMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCAdminWindowDocManagerWindMetadata._meta Is Nothing Then
					ViewCCAdminWindowDocManagerWindMetadata._meta = New ViewCCAdminWindowDocManagerWindMetadata()
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
				


				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("PracticeName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReportArchiveID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DateOfInspection", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DateMailedToClient", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DateOfInspectionCurrent", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("DateMailedToClientCurrent", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("LinkToReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkToReport2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkToDiagram", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCAdminWindowDocManagerWind"
				meta.Destination = "viewCCAdminWindowDocManagerWind"
				
				meta.spInsert = "proc_viewCCAdminWindowDocManagerWindInsert"
				meta.spUpdate = "proc_viewCCAdminWindowDocManagerWindUpdate"
				meta.spDelete = "proc_viewCCAdminWindowDocManagerWindDelete"
				meta.spLoadAll = "proc_viewCCAdminWindowDocManagerWindLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCAdminWindowDocManagerWindLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCAdminWindowDocManagerWindMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
