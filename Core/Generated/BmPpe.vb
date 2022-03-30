
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:40 AM
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
	' Encapsulates the 'Cope-BMProcessEquipmentHeader' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BmPpe))> _
	<XmlType("BmPpe")> _	
	Partial Public Class BmPpe 
		Inherits esBmPpe
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BmPpe()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BmPpe()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BmPpe()
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
	<XmlType("BmPpeCollection")> _
	Partial Public Class BmPpeCollection
		Inherits esBmPpeCollection
		Implements IEnumerable(Of BmPpe)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BmPpe
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BmPpe))> _
		Public Class BmPpeCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BmPpeCollection)
			
			Public Shared Widening Operator CType(packet As BmPpeCollectionWCFPacket) As BmPpeCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BmPpeCollection) As BmPpeCollectionWCFPacket
				Return New BmPpeCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BmPpeQuery 
		Inherits esBmPpeQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BmPpeQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BmPpeQuery) As String
			Return BmPpeQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BmPpeQuery
			Return DirectCast(BmPpeQuery.SerializeHelper.FromXml(query, GetType(BmPpeQuery)), BmPpeQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBmPpe
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
		
			Dim query As New BmPpeQuery()
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
		' Maps to Cope-BMProcessEquipmentHeader.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BmPpeMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPpeMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMProcessEquipmentHeader.CPVExposure
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CPVExposure As System.String
			Get
				Return MyBase.GetSystemString(BmPpeMetadata.ColumnNames.CPVExposure)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPpeMetadata.ColumnNames.CPVExposure, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.CPVExposure)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMProcessEquipmentHeader.PPEExposure
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PPEExposure As System.String
			Get
				Return MyBase.GetSystemString(BmPpeMetadata.ColumnNames.PPEExposure)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPpeMetadata.ColumnNames.PPEExposure, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.PPEExposure)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMProcessEquipmentHeader.PressureVesselsUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PressureVesselsUser1 As System.String
			Get
				Return MyBase.GetSystemString(BmPpeMetadata.ColumnNames.PressureVesselsUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPpeMetadata.ColumnNames.PressureVesselsUser1, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.PressureVesselsUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMProcessEquipmentHeader.PressureVesselsUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PressureVesselsUser2 As System.String
			Get
				Return MyBase.GetSystemString(BmPpeMetadata.ColumnNames.PressureVesselsUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPpeMetadata.ColumnNames.PressureVesselsUser2, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.PressureVesselsUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMProcessEquipmentHeader.PressureVesselsUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PressureVesselsUser3 As System.String
			Get
				Return MyBase.GetSystemString(BmPpeMetadata.ColumnNames.PressureVesselsUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPpeMetadata.ColumnNames.PressureVesselsUser3, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.PressureVesselsUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMProcessEquipmentHeader.PressureVesselsUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PressureVesselsUser4 As System.String
			Get
				Return MyBase.GetSystemString(BmPpeMetadata.ColumnNames.PressureVesselsUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPpeMetadata.ColumnNames.PressureVesselsUser4, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.PressureVesselsUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMProcessEquipmentHeader.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BmPpeMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BmPpeMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMProcessEquipmentHeader.PrimeMoverExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimeMoverExp As System.String
			Get
				Return MyBase.GetSystemString(BmPpeMetadata.ColumnNames.PrimeMoverExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmPpeMetadata.ColumnNames.PrimeMoverExp, value) Then
					OnPropertyChanged(BmPpeMetadata.PropertyNames.PrimeMoverExp)
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
												
						Case "CPVExposure"
							Me.str().CPVExposure = CType(value, string)
												
						Case "PPEExposure"
							Me.str().PPEExposure = CType(value, string)
												
						Case "PressureVesselsUser1"
							Me.str().PressureVesselsUser1 = CType(value, string)
												
						Case "PressureVesselsUser2"
							Me.str().PressureVesselsUser2 = CType(value, string)
												
						Case "PressureVesselsUser3"
							Me.str().PressureVesselsUser3 = CType(value, string)
												
						Case "PressureVesselsUser4"
							Me.str().PressureVesselsUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "PrimeMoverExp"
							Me.str().PrimeMoverExp = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BmPpeMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBmPpe)
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
		  	
			Public Property CPVExposure As System.String 
				Get
					Dim data_ As System.String = entity.CPVExposure
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CPVExposure = Nothing
					Else
						entity.CPVExposure = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PPEExposure As System.String 
				Get
					Dim data_ As System.String = entity.PPEExposure
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PPEExposure = Nothing
					Else
						entity.PPEExposure = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PressureVesselsUser1 As System.String 
				Get
					Dim data_ As System.String = entity.PressureVesselsUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PressureVesselsUser1 = Nothing
					Else
						entity.PressureVesselsUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PressureVesselsUser2 As System.String 
				Get
					Dim data_ As System.String = entity.PressureVesselsUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PressureVesselsUser2 = Nothing
					Else
						entity.PressureVesselsUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PressureVesselsUser3 As System.String 
				Get
					Dim data_ As System.String = entity.PressureVesselsUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PressureVesselsUser3 = Nothing
					Else
						entity.PressureVesselsUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PressureVesselsUser4 As System.String 
				Get
					Dim data_ As System.String = entity.PressureVesselsUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PressureVesselsUser4 = Nothing
					Else
						entity.PressureVesselsUser4 = Convert.ToString(Value)
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
		  	
			Public Property PrimeMoverExp As System.String 
				Get
					Dim data_ As System.String = entity.PrimeMoverExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimeMoverExp = Nothing
					Else
						entity.PrimeMoverExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBmPpe
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmPpeMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BmPpeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmPpeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BmPpeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BmPpeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BmPpeQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBmPpeCollection
		Inherits esEntityCollection(Of BmPpe)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmPpeMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BmPpeCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BmPpeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmPpeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BmPpeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BmPpeQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BmPpeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BmPpeQuery))
		End Sub
		
		#End Region
						
		Private m_query As BmPpeQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBmPpeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BmPpeMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "CPVExposure" 
					Return Me.CPVExposure
				Case "PPEExposure" 
					Return Me.PPEExposure
				Case "PressureVesselsUser1" 
					Return Me.PressureVesselsUser1
				Case "PressureVesselsUser2" 
					Return Me.PressureVesselsUser2
				Case "PressureVesselsUser3" 
					Return Me.PressureVesselsUser3
				Case "PressureVesselsUser4" 
					Return Me.PressureVesselsUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "PrimeMoverExp" 
					Return Me.PrimeMoverExp
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CPVExposure As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.CPVExposure, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PPEExposure As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.PPEExposure, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PressureVesselsUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.PressureVesselsUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PressureVesselsUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.PressureVesselsUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PressureVesselsUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.PressureVesselsUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PressureVesselsUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.PressureVesselsUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property PrimeMoverExp As esQueryItem
			Get
				Return New esQueryItem(Me, BmPpeMetadata.ColumnNames.PrimeMoverExp, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BmPpe 
		Inherits esBmPpe
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BmPpeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPpeMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.CPVExposure, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPpeMetadata.PropertyNames.CPVExposure
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.PPEExposure, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPpeMetadata.PropertyNames.PPEExposure
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.PressureVesselsUser1, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPpeMetadata.PropertyNames.PressureVesselsUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.PressureVesselsUser2, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPpeMetadata.PropertyNames.PressureVesselsUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.PressureVesselsUser3, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPpeMetadata.PropertyNames.PressureVesselsUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.PressureVesselsUser4, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPpeMetadata.PropertyNames.PressureVesselsUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.FilePrefix, 7, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BmPpeMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmPpeMetadata.ColumnNames.PrimeMoverExp, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmPpeMetadata.PropertyNames.PrimeMoverExp
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BmPpeMetadata
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
			 Public Const CPVExposure As String = "CPVExposure"
			 Public Const PPEExposure As String = "PPEExposure"
			 Public Const PressureVesselsUser1 As String = "PressureVesselsUser1"
			 Public Const PressureVesselsUser2 As String = "PressureVesselsUser2"
			 Public Const PressureVesselsUser3 As String = "PressureVesselsUser3"
			 Public Const PressureVesselsUser4 As String = "PressureVesselsUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const PrimeMoverExp As String = "PrimeMoverExp"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const CPVExposure As String = "CPVExposure"
			 Public Const PPEExposure As String = "PPEExposure"
			 Public Const PressureVesselsUser1 As String = "PressureVesselsUser1"
			 Public Const PressureVesselsUser2 As String = "PressureVesselsUser2"
			 Public Const PressureVesselsUser3 As String = "PressureVesselsUser3"
			 Public Const PressureVesselsUser4 As String = "PressureVesselsUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const PrimeMoverExp As String = "PrimeMoverExp"
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
			SyncLock GetType(BmPpeMetadata)
			
				If BmPpeMetadata.mapDelegates Is Nothing Then
					BmPpeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BmPpeMetadata._meta Is Nothing Then
					BmPpeMetadata._meta = New BmPpeMetadata()
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
				meta.AddTypeMap("CPVExposure", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PPEExposure", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PressureVesselsUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PressureVesselsUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PressureVesselsUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PressureVesselsUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("PrimeMoverExp", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-BMProcessEquipmentHeader"
				meta.Destination = "Cope-BMProcessEquipmentHeader"
				
				meta.spInsert = "proc_Cope-BMProcessEquipmentHeaderInsert"
				meta.spUpdate = "proc_Cope-BMProcessEquipmentHeaderUpdate"
				meta.spDelete = "proc_Cope-BMProcessEquipmentHeaderDelete"
				meta.spLoadAll = "proc_Cope-BMProcessEquipmentHeaderLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMProcessEquipmentHeaderLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BmPpeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
