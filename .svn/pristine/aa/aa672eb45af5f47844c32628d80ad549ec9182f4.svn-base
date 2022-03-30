
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:39 AM
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
	' Encapsulates the 'Cope-BMComputerSystem' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMComputerSystem))> _
	<XmlType("BMComputerSystem")> _	
	Partial Public Class BMComputerSystem 
		Inherits esBMComputerSystem
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMComputerSystem()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BMComputerSystem()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMComputerSystem()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("BMComputerSystemCollection")> _
	Partial Public Class BMComputerSystemCollection
		Inherits esBMComputerSystemCollection
		Implements IEnumerable(Of BMComputerSystem)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BMComputerSystem
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMComputerSystem))> _
		Public Class BMComputerSystemCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMComputerSystemCollection)
			
			Public Shared Widening Operator CType(packet As BMComputerSystemCollectionWCFPacket) As BMComputerSystemCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMComputerSystemCollection) As BMComputerSystemCollectionWCFPacket
				Return New BMComputerSystemCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMComputerSystemQuery 
		Inherits esBMComputerSystemQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMComputerSystemQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMComputerSystemQuery) As String
			Return BMComputerSystemQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMComputerSystemQuery
			Return DirectCast(BMComputerSystemQuery.SerializeHelper.FromXml(query, GetType(BMComputerSystemQuery)), BMComputerSystemQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMComputerSystem
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fileNo As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileNo)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileNo)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fileNo As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileNo)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileNo)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fileNo As System.String) As Boolean
		
			Dim query As New BMComputerSystemQuery()
			query.Where(query.FileNo = fileNo)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fileNo As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FileNo", fileNo)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Cope-BMComputerSystem.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.ComputersInstalled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ComputersInstalled As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.ComputersInstalled)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.ComputersInstalled, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.ComputersInstalled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.CanPlantOperate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CanPlantOperate As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.CanPlantOperate)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.CanPlantOperate, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.CanPlantOperate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.UPSInstalled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UPSInstalled As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.UPSInstalled)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.UPSInstalled, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.UPSInstalled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.ComputerSystemsComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ComputerSystemsComments As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.ComputerSystemsComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.ComputerSystemsComments, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.ComputerSystemsComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.ProcessEquipUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcessEquipUser1 As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser1, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.ProcessEquipUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.ProcessEquipUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcessEquipUser2 As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser2, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.ProcessEquipUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.ProcessEquipUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcessEquipUser3 As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser3, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.ProcessEquipUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.ProcessEquipUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProcessEquipUser4 As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser4, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.ProcessEquipUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BMComputerSystemMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BMComputerSystemMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMComputerSystem.CompSysMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSysMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BMComputerSystemMetadata.ColumnNames.CompSysMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMComputerSystemMetadata.ColumnNames.CompSysMajorExp, value) Then
					OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.CompSysMajorExp)
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
												
						Case "ComputersInstalled"
							Me.str().ComputersInstalled = CType(value, string)
												
						Case "CanPlantOperate"
							Me.str().CanPlantOperate = CType(value, string)
												
						Case "UPSInstalled"
							Me.str().UPSInstalled = CType(value, string)
												
						Case "ComputerSystemsComments"
							Me.str().ComputerSystemsComments = CType(value, string)
												
						Case "ProcessEquipUser1"
							Me.str().ProcessEquipUser1 = CType(value, string)
												
						Case "ProcessEquipUser2"
							Me.str().ProcessEquipUser2 = CType(value, string)
												
						Case "ProcessEquipUser3"
							Me.str().ProcessEquipUser3 = CType(value, string)
												
						Case "ProcessEquipUser4"
							Me.str().ProcessEquipUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "CompSysMajorExp"
							Me.str().CompSysMajorExp = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BMComputerSystemMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBMComputerSystem)
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
		  	
			Public Property ComputersInstalled As System.String 
				Get
					Dim data_ As System.String = entity.ComputersInstalled
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ComputersInstalled = Nothing
					Else
						entity.ComputersInstalled = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CanPlantOperate As System.String 
				Get
					Dim data_ As System.String = entity.CanPlantOperate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CanPlantOperate = Nothing
					Else
						entity.CanPlantOperate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UPSInstalled As System.String 
				Get
					Dim data_ As System.String = entity.UPSInstalled
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UPSInstalled = Nothing
					Else
						entity.UPSInstalled = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ComputerSystemsComments As System.String 
				Get
					Dim data_ As System.String = entity.ComputerSystemsComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ComputerSystemsComments = Nothing
					Else
						entity.ComputerSystemsComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcessEquipUser1 As System.String 
				Get
					Dim data_ As System.String = entity.ProcessEquipUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcessEquipUser1 = Nothing
					Else
						entity.ProcessEquipUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcessEquipUser2 As System.String 
				Get
					Dim data_ As System.String = entity.ProcessEquipUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcessEquipUser2 = Nothing
					Else
						entity.ProcessEquipUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcessEquipUser3 As System.String 
				Get
					Dim data_ As System.String = entity.ProcessEquipUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcessEquipUser3 = Nothing
					Else
						entity.ProcessEquipUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProcessEquipUser4 As System.String 
				Get
					Dim data_ As System.String = entity.ProcessEquipUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProcessEquipUser4 = Nothing
					Else
						entity.ProcessEquipUser4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.FilePrefix
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSysMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.CompSysMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSysMajorExp = Nothing
					Else
						entity.CompSysMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBMComputerSystem
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMComputerSystemMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMComputerSystemQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMComputerSystemQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMComputerSystemQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMComputerSystemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMComputerSystemQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMComputerSystemCollection
		Inherits esEntityCollection(Of BMComputerSystem)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMComputerSystemMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMComputerSystemCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMComputerSystemQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMComputerSystemQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMComputerSystemQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMComputerSystemQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMComputerSystemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMComputerSystemQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMComputerSystemQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMComputerSystemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMComputerSystemMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "ComputersInstalled" 
					Return Me.ComputersInstalled
				Case "CanPlantOperate" 
					Return Me.CanPlantOperate
				Case "UPSInstalled" 
					Return Me.UPSInstalled
				Case "ComputerSystemsComments" 
					Return Me.ComputerSystemsComments
				Case "ProcessEquipUser1" 
					Return Me.ProcessEquipUser1
				Case "ProcessEquipUser2" 
					Return Me.ProcessEquipUser2
				Case "ProcessEquipUser3" 
					Return Me.ProcessEquipUser3
				Case "ProcessEquipUser4" 
					Return Me.ProcessEquipUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "CompSysMajorExp" 
					Return Me.CompSysMajorExp
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ComputersInstalled As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.ComputersInstalled, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CanPlantOperate As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.CanPlantOperate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UPSInstalled As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.UPSInstalled, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ComputerSystemsComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.ComputerSystemsComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcessEquipUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.ProcessEquipUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcessEquipUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.ProcessEquipUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcessEquipUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.ProcessEquipUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProcessEquipUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.ProcessEquipUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property CompSysMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BMComputerSystemMetadata.ColumnNames.CompSysMajorExp, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMComputerSystem 
		Inherits esBMComputerSystem
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BMComputerSystemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.ComputersInstalled, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.ComputersInstalled
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.CanPlantOperate, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.CanPlantOperate
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.UPSInstalled, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.UPSInstalled
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.ComputerSystemsComments, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.ComputerSystemsComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser1, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.ProcessEquipUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser2, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.ProcessEquipUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser3, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.ProcessEquipUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.ProcessEquipUser4, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.ProcessEquipUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.FilePrefix, 9, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMComputerSystemMetadata.ColumnNames.CompSysMajorExp, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMComputerSystemMetadata.PropertyNames.CompSysMajorExp
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMComputerSystemMetadata
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
			 Public Const ComputersInstalled As String = "ComputersInstalled"
			 Public Const CanPlantOperate As String = "CanPlantOperate"
			 Public Const UPSInstalled As String = "UPSInstalled"
			 Public Const ComputerSystemsComments As String = "ComputerSystemsComments"
			 Public Const ProcessEquipUser1 As String = "ProcessEquipUser1"
			 Public Const ProcessEquipUser2 As String = "ProcessEquipUser2"
			 Public Const ProcessEquipUser3 As String = "ProcessEquipUser3"
			 Public Const ProcessEquipUser4 As String = "ProcessEquipUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const CompSysMajorExp As String = "CompSysMajorExp"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const ComputersInstalled As String = "ComputersInstalled"
			 Public Const CanPlantOperate As String = "CanPlantOperate"
			 Public Const UPSInstalled As String = "UPSInstalled"
			 Public Const ComputerSystemsComments As String = "ComputerSystemsComments"
			 Public Const ProcessEquipUser1 As String = "ProcessEquipUser1"
			 Public Const ProcessEquipUser2 As String = "ProcessEquipUser2"
			 Public Const ProcessEquipUser3 As String = "ProcessEquipUser3"
			 Public Const ProcessEquipUser4 As String = "ProcessEquipUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const CompSysMajorExp As String = "CompSysMajorExp"
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
			SyncLock GetType(BMComputerSystemMetadata)
			
				If BMComputerSystemMetadata.mapDelegates Is Nothing Then
					BMComputerSystemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMComputerSystemMetadata._meta Is Nothing Then
					BMComputerSystemMetadata._meta = New BMComputerSystemMetadata()
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
				meta.AddTypeMap("ComputersInstalled", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CanPlantOperate", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("UPSInstalled", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ComputerSystemsComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProcessEquipUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProcessEquipUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProcessEquipUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProcessEquipUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("CompSysMajorExp", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-BMComputerSystem"
				meta.Destination = "Cope-BMComputerSystem"
				
				meta.spInsert = "proc_Cope-BMComputerSystemInsert"
				meta.spUpdate = "proc_Cope-BMComputerSystemUpdate"
				meta.spDelete = "proc_Cope-BMComputerSystemDelete"
				meta.spLoadAll = "proc_Cope-BMComputerSystemLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMComputerSystemLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMComputerSystemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
