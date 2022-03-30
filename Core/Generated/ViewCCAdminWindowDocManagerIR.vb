
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
	' Encapsulates the 'viewCCAdminWindowDocManagerIR' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCAdminWindowDocManagerIR))> _
	<XmlType("ViewCCAdminWindowDocManagerIR")> _	
	Partial Public Class ViewCCAdminWindowDocManagerIR 
		Inherits esViewCCAdminWindowDocManagerIR
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCAdminWindowDocManagerIR()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCAdminWindowDocManagerIRCollection")> _
	Partial Public Class ViewCCAdminWindowDocManagerIRCollection
		Inherits esViewCCAdminWindowDocManagerIRCollection
		Implements IEnumerable(Of ViewCCAdminWindowDocManagerIR)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCAdminWindowDocManagerIR))> _
		Public Class ViewCCAdminWindowDocManagerIRCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCAdminWindowDocManagerIRCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCAdminWindowDocManagerIRCollectionWCFPacket) As ViewCCAdminWindowDocManagerIRCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCAdminWindowDocManagerIRCollection) As ViewCCAdminWindowDocManagerIRCollectionWCFPacket
				Return New ViewCCAdminWindowDocManagerIRCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCAdminWindowDocManagerIRQuery 
		Inherits esViewCCAdminWindowDocManagerIRQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCAdminWindowDocManagerIRQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCAdminWindowDocManagerIRQuery) As String
			Return ViewCCAdminWindowDocManagerIRQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCAdminWindowDocManagerIRQuery
			Return DirectCast(ViewCCAdminWindowDocManagerIRQuery.SerializeHelper.FromXml(query, GetType(ViewCCAdminWindowDocManagerIRQuery)), ViewCCAdminWindowDocManagerIRQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerIR
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.PracticeName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.PracticeName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.PracticeName, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.PracticeName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.ReportArchiveID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReportArchiveID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.ReportArchiveID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.ReportArchiveID, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.ReportArchiveID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.DateOfInspection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateOfInspection As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateOfInspection)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateOfInspection, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateOfInspection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.DateMailedToClient
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateMailedToClient As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateMailedToClient)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateMailedToClient, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateMailedToClient)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.DateOfInspectionCurrent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateOfInspectionCurrent As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateOfInspectionCurrent)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateOfInspectionCurrent, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateOfInspectionCurrent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.DateMailedToClientCurrent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateMailedToClientCurrent As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateMailedToClientCurrent)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateMailedToClientCurrent, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateMailedToClientCurrent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.LinkToReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToReport, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.LinkToReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.LinkToReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToReport2 As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToReport2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToReport2, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.LinkToReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.LinkToDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToDiagram As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToDiagram)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToDiagram, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.LinkToDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerIR.MetaPracticeID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MetaPracticeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.MetaPracticeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.MetaPracticeID, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.MetaPracticeID)
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
												
						Case "MetaPracticeID"
							Me.str().MetaPracticeID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "ReportArchiveID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ReportArchiveID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.ReportArchiveID)
							End If
						
						Case "DateOfInspection"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateOfInspection = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateOfInspection)
							End If
						
						Case "DateMailedToClient"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateMailedToClient = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateMailedToClient)
							End If
						
						Case "DateOfInspectionCurrent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateOfInspectionCurrent = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateOfInspectionCurrent)
							End If
						
						Case "DateMailedToClientCurrent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateMailedToClientCurrent = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateMailedToClientCurrent)
							End If
						
						Case "LinkToReport2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LinkToReport2 = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.LinkToReport2)
							End If
						
						Case "LinkToDiagram"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LinkToDiagram = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.LinkToDiagram)
							End If
						
						Case "MetaPracticeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MetaPracticeID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.MetaPracticeID)
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
		
			Public Sub New(ByVal entity As esViewCCAdminWindowDocManagerIR)
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
					Dim data_ As Nullable(Of System.Char) = entity.LinkToReport2
					
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
						entity.LinkToReport2 = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToDiagram As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LinkToDiagram
					
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
						entity.LinkToDiagram = Convert.ToChar(Value)
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
		  

			Private entity As esViewCCAdminWindowDocManagerIR
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerIRMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCAdminWindowDocManagerIRQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowDocManagerIRQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCAdminWindowDocManagerIRQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowDocManagerIRQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCAdminWindowDocManagerIRQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerIRCollection
		Inherits esEntityCollection(Of ViewCCAdminWindowDocManagerIR)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerIRMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCAdminWindowDocManagerIRCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCAdminWindowDocManagerIRQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowDocManagerIRQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCAdminWindowDocManagerIRQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCAdminWindowDocManagerIRQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowDocManagerIRQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCAdminWindowDocManagerIRQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCAdminWindowDocManagerIRQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerIRQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerIRMetadata.Meta()
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
				Case "MetaPracticeID" 
					Return Me.MetaPracticeID
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.PracticeName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReportArchiveID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.ReportArchiveID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateOfInspection As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateOfInspection, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateMailedToClient As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateMailedToClient, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateOfInspectionCurrent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateOfInspectionCurrent, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DateMailedToClientCurrent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateMailedToClientCurrent, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToReport2, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToDiagram, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property MetaPracticeID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.MetaPracticeID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCAdminWindowDocManagerIRMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.PracticeCode, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.PracticeName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.PracticeName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.ReportArchiveID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.ReportArchiveID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateOfInspection, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateOfInspection
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateMailedToClient, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateMailedToClient
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateOfInspectionCurrent, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateOfInspectionCurrent
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.DateMailedToClientCurrent, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.DateMailedToClientCurrent
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToReport, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.LinkToReport
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToReport2, 9, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.LinkToReport2
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.LinkToDiagram, 10, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.LinkToDiagram
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerIRMetadata.ColumnNames.MetaPracticeID, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowDocManagerIRMetadata.PropertyNames.MetaPracticeID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCAdminWindowDocManagerIRMetadata
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
			 Public Const MetaPracticeID As String = "MetaPracticeID"
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
			SyncLock GetType(ViewCCAdminWindowDocManagerIRMetadata)
			
				If ViewCCAdminWindowDocManagerIRMetadata.mapDelegates Is Nothing Then
					ViewCCAdminWindowDocManagerIRMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCAdminWindowDocManagerIRMetadata._meta Is Nothing Then
					ViewCCAdminWindowDocManagerIRMetadata._meta = New ViewCCAdminWindowDocManagerIRMetadata()
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
				meta.AddTypeMap("PracticeName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ReportArchiveID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DateOfInspection", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DateMailedToClient", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DateOfInspectionCurrent", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("DateMailedToClientCurrent", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("LinkToReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkToReport2", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LinkToDiagram", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("MetaPracticeID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCAdminWindowDocManagerIR"
				meta.Destination = "viewCCAdminWindowDocManagerIR"
				
				meta.spInsert = "proc_viewCCAdminWindowDocManagerIRInsert"
				meta.spUpdate = "proc_viewCCAdminWindowDocManagerIRUpdate"
				meta.spDelete = "proc_viewCCAdminWindowDocManagerIRDelete"
				meta.spLoadAll = "proc_viewCCAdminWindowDocManagerIRLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCAdminWindowDocManagerIRLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCAdminWindowDocManagerIRMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
