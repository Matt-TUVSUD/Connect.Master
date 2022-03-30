
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
	' Encapsulates the 'viewCCAdminWindowDocManagerJuris' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCAdminWindowDocManagerJuris))> _
	<XmlType("ViewCCAdminWindowDocManagerJuris")> _	
	Partial Public Class ViewCCAdminWindowDocManagerJuris 
		Inherits esViewCCAdminWindowDocManagerJuris
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCAdminWindowDocManagerJuris()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCAdminWindowDocManagerJurisCollection")> _
	Partial Public Class ViewCCAdminWindowDocManagerJurisCollection
		Inherits esViewCCAdminWindowDocManagerJurisCollection
		Implements IEnumerable(Of ViewCCAdminWindowDocManagerJuris)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCAdminWindowDocManagerJuris))> _
		Public Class ViewCCAdminWindowDocManagerJurisCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCAdminWindowDocManagerJurisCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCAdminWindowDocManagerJurisCollectionWCFPacket) As ViewCCAdminWindowDocManagerJurisCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCAdminWindowDocManagerJurisCollection) As ViewCCAdminWindowDocManagerJurisCollectionWCFPacket
				Return New ViewCCAdminWindowDocManagerJurisCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCAdminWindowDocManagerJurisQuery 
		Inherits esViewCCAdminWindowDocManagerJurisQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCAdminWindowDocManagerJurisQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCAdminWindowDocManagerJurisQuery) As String
			Return ViewCCAdminWindowDocManagerJurisQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCAdminWindowDocManagerJurisQuery
			Return DirectCast(ViewCCAdminWindowDocManagerJurisQuery.SerializeHelper.FromXml(query, GetType(ViewCCAdminWindowDocManagerJurisQuery)), ViewCCAdminWindowDocManagerJurisQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerJuris
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.ReportArchiveID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReportArchiveID As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.ReportArchiveID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.ReportArchiveID, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.ReportArchiveID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.PracticeName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.PracticeName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.PracticeName, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.PracticeName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.DateOfInspection
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateOfInspection As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateOfInspection)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateOfInspection, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateOfInspection)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.DateMailedToClient
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateMailedToClient As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateMailedToClient)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateMailedToClient, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateMailedToClient)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.DateOfInspectionCurrent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateOfInspectionCurrent As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateOfInspectionCurrent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateOfInspectionCurrent, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateOfInspectionCurrent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.DateMailedToClientCurrent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateMailedToClientCurrent As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateMailedToClientCurrent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateMailedToClientCurrent, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateMailedToClientCurrent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.LinkToReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToReport As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToReport)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToReport, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.LinkToReport2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToReport2 As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToReport2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToReport2, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToReport2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.LinkToDiagram
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToDiagram As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToDiagram)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToDiagram, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToDiagram)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowDocManagerJuris.MetaPracticeID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MetaPracticeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.MetaPracticeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.MetaPracticeID, value) Then
					OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.MetaPracticeID)
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
												
						Case "ReportArchiveID"
							Me.str().ReportArchiveID = CType(value, string)
												
						Case "PracticeName"
							Me.str().PracticeName = CType(value, string)
												
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
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "ReportArchiveID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.ReportArchiveID = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.ReportArchiveID)
							End If
						
						Case "DateOfInspection"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.DateOfInspection = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateOfInspection)
							End If
						
						Case "DateMailedToClient"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.DateMailedToClient = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateMailedToClient)
							End If
						
						Case "DateOfInspectionCurrent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.DateOfInspectionCurrent = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateOfInspectionCurrent)
							End If
						
						Case "DateMailedToClientCurrent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.DateMailedToClientCurrent = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateMailedToClientCurrent)
							End If
						
						Case "LinkToReport"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LinkToReport = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToReport)
							End If
						
						Case "LinkToReport2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LinkToReport2 = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToReport2)
							End If
						
						Case "LinkToDiagram"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LinkToDiagram = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToDiagram)
							End If
						
						Case "MetaPracticeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MetaPracticeID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.MetaPracticeID)
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
		
			Public Sub New(ByVal entity As esViewCCAdminWindowDocManagerJuris)
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
					Dim data_ As Nullable(Of System.Char) = entity.PracticeCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeCode = Nothing
					Else
						entity.PracticeCode = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReportArchiveID As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.ReportArchiveID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReportArchiveID = Nothing
					Else
						entity.ReportArchiveID = Convert.ToChar(Value)
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
		  	
			Public Property DateOfInspection As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.DateOfInspection
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateOfInspection = Nothing
					Else
						entity.DateOfInspection = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateMailedToClient As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.DateMailedToClient
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateMailedToClient = Nothing
					Else
						entity.DateMailedToClient = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateOfInspectionCurrent As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.DateOfInspectionCurrent
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateOfInspectionCurrent = Nothing
					Else
						entity.DateOfInspectionCurrent = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateMailedToClientCurrent As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.DateMailedToClientCurrent
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateMailedToClientCurrent = Nothing
					Else
						entity.DateMailedToClientCurrent = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToReport As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LinkToReport
					
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
						entity.LinkToReport = Convert.ToChar(Value)
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
		  

			Private entity As esViewCCAdminWindowDocManagerJuris
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerJurisMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCAdminWindowDocManagerJurisQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowDocManagerJurisQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCAdminWindowDocManagerJurisQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowDocManagerJurisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCAdminWindowDocManagerJurisQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerJurisCollection
		Inherits esEntityCollection(Of ViewCCAdminWindowDocManagerJuris)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerJurisMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCAdminWindowDocManagerJurisCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCAdminWindowDocManagerJurisQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowDocManagerJurisQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCAdminWindowDocManagerJurisQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCAdminWindowDocManagerJurisQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowDocManagerJurisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCAdminWindowDocManagerJurisQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCAdminWindowDocManagerJurisQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCAdminWindowDocManagerJurisQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowDocManagerJurisMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "ReportArchiveID" 
					Return Me.ReportArchiveID
				Case "PracticeName" 
					Return Me.PracticeName
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
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.PracticeCode, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property ReportArchiveID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.ReportArchiveID, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.PracticeName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateOfInspection As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateOfInspection, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property DateMailedToClient As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateMailedToClient, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property DateOfInspectionCurrent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateOfInspectionCurrent, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property DateMailedToClientCurrent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateMailedToClientCurrent, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToReport, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToReport2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToReport2, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToDiagram As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToDiagram, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property MetaPracticeID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.MetaPracticeID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCAdminWindowDocManagerJurisMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.PracticeCode, 1, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.PracticeCode
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.ReportArchiveID, 2, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.ReportArchiveID
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.PracticeName, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.PracticeName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateOfInspection, 4, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateOfInspection
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateMailedToClient, 5, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateMailedToClient
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateOfInspectionCurrent, 6, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateOfInspectionCurrent
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.DateMailedToClientCurrent, 7, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.DateMailedToClientCurrent
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToReport, 8, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToReport
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToReport2, 9, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToReport2
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.LinkToDiagram, 10, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.LinkToDiagram
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowDocManagerJurisMetadata.ColumnNames.MetaPracticeID, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowDocManagerJurisMetadata.PropertyNames.MetaPracticeID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCAdminWindowDocManagerJurisMetadata
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
			 Public Const ReportArchiveID As String = "ReportArchiveID"
			 Public Const PracticeName As String = "PracticeName"
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
			 Public Const ReportArchiveID As String = "ReportArchiveID"
			 Public Const PracticeName As String = "PracticeName"
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
			SyncLock GetType(ViewCCAdminWindowDocManagerJurisMetadata)
			
				If ViewCCAdminWindowDocManagerJurisMetadata.mapDelegates Is Nothing Then
					ViewCCAdminWindowDocManagerJurisMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCAdminWindowDocManagerJurisMetadata._meta Is Nothing Then
					ViewCCAdminWindowDocManagerJurisMetadata._meta = New ViewCCAdminWindowDocManagerJurisMetadata()
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
				meta.AddTypeMap("PracticeCode", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("ReportArchiveID", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("PracticeName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DateOfInspection", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("DateMailedToClient", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("DateOfInspectionCurrent", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("DateMailedToClientCurrent", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LinkToReport", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LinkToReport2", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LinkToDiagram", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("MetaPracticeID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCAdminWindowDocManagerJuris"
				meta.Destination = "viewCCAdminWindowDocManagerJuris"
				
				meta.spInsert = "proc_viewCCAdminWindowDocManagerJurisInsert"
				meta.spUpdate = "proc_viewCCAdminWindowDocManagerJurisUpdate"
				meta.spDelete = "proc_viewCCAdminWindowDocManagerJurisDelete"
				meta.spLoadAll = "proc_viewCCAdminWindowDocManagerJurisLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCAdminWindowDocManagerJurisLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCAdminWindowDocManagerJurisMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
