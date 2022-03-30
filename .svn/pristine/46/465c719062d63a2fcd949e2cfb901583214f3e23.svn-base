
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
	' Encapsulates the 'Cope-BMBPVHeader' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMBPV))> _
	<XmlType("BMBPV")> _	
	Partial Public Class BMBPV 
		Inherits esBMBPV
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMBPV()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BMBPV()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMBPV()
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
	<XmlType("BMBPVCollection")> _
	Partial Public Class BMBPVCollection
		Inherits esBMBPVCollection
		Implements IEnumerable(Of BMBPV)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BMBPV
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMBPV))> _
		Public Class BMBPVCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMBPVCollection)
			
			Public Shared Widening Operator CType(packet As BMBPVCollectionWCFPacket) As BMBPVCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMBPVCollection) As BMBPVCollectionWCFPacket
				Return New BMBPVCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMBPVQuery 
		Inherits esBMBPVQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMBPVQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMBPVQuery) As String
			Return BMBPVQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMBPVQuery
			Return DirectCast(BMBPVQuery.SerializeHelper.FromXml(query, GetType(BMBPVQuery)), BMBPVQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMBPV
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
		
			Dim query As New BMBPVQuery()
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
		' Maps to Cope-BMBPVHeader.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMBPVMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMBPVMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilerNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilerNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMBPVMetadata.ColumnNames.BoilerNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMBPVMetadata.ColumnNames.BoilerNo, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilerNoBLRB
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilerNoBLRB As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMBPVMetadata.ColumnNames.BoilerNoBLRB)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMBPVMetadata.ColumnNames.BoilerNoBLRB, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerNoBLRB)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilerNoUtility
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilerNoUtility As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMBPVMetadata.ColumnNames.BoilerNoUtility)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMBPVMetadata.ColumnNames.BoilerNoUtility, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerNoUtility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilerOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilerOther As System.String
			Get
				Return MyBase.GetSystemString(BMBPVMetadata.ColumnNames.BoilerOther)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMBPVMetadata.ColumnNames.BoilerOther, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilerComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilerComments As System.String
			Get
				Return MyBase.GetSystemString(BMBPVMetadata.ColumnNames.BoilerComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMBPVMetadata.ColumnNames.BoilerComments, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilersUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersUser1 As System.String
			Get
				Return MyBase.GetSystemString(BMBPVMetadata.ColumnNames.BoilersUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMBPVMetadata.ColumnNames.BoilersUser1, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilersUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilersUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersUser2 As System.String
			Get
				Return MyBase.GetSystemString(BMBPVMetadata.ColumnNames.BoilersUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMBPVMetadata.ColumnNames.BoilersUser2, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilersUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilersUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersUser3 As System.String
			Get
				Return MyBase.GetSystemString(BMBPVMetadata.ColumnNames.BoilersUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMBPVMetadata.ColumnNames.BoilersUser3, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilersUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilersUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilersUser4 As System.String
			Get
				Return MyBase.GetSystemString(BMBPVMetadata.ColumnNames.BoilersUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMBPVMetadata.ColumnNames.BoilersUser4, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilersUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BMBPVMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BMBPVMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMBPVHeader.BoilerMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BoilerMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BMBPVMetadata.ColumnNames.BoilerMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMBPVMetadata.ColumnNames.BoilerMajorExp, value) Then
					OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerMajorExp)
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
												
						Case "BoilerNo"
							Me.str().BoilerNo = CType(value, string)
												
						Case "BoilerNoBLRB"
							Me.str().BoilerNoBLRB = CType(value, string)
												
						Case "BoilerNoUtility"
							Me.str().BoilerNoUtility = CType(value, string)
												
						Case "BoilerOther"
							Me.str().BoilerOther = CType(value, string)
												
						Case "BoilerComments"
							Me.str().BoilerComments = CType(value, string)
												
						Case "BoilersUser1"
							Me.str().BoilersUser1 = CType(value, string)
												
						Case "BoilersUser2"
							Me.str().BoilersUser2 = CType(value, string)
												
						Case "BoilersUser3"
							Me.str().BoilersUser3 = CType(value, string)
												
						Case "BoilersUser4"
							Me.str().BoilersUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "BoilerMajorExp"
							Me.str().BoilerMajorExp = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "BoilerNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BoilerNo = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerNo)
							End If
						
						Case "BoilerNoBLRB"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BoilerNoBLRB = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerNoBLRB)
							End If
						
						Case "BoilerNoUtility"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BoilerNoUtility = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMBPVMetadata.PropertyNames.BoilerNoUtility)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BMBPVMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBMBPV)
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
		  	
			Public Property BoilerNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BoilerNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilerNo = Nothing
					Else
						entity.BoilerNo = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilerNoBLRB As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BoilerNoBLRB
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilerNoBLRB = Nothing
					Else
						entity.BoilerNoBLRB = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilerNoUtility As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BoilerNoUtility
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilerNoUtility = Nothing
					Else
						entity.BoilerNoUtility = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilerOther As System.String 
				Get
					Dim data_ As System.String = entity.BoilerOther
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilerOther = Nothing
					Else
						entity.BoilerOther = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilerComments As System.String 
				Get
					Dim data_ As System.String = entity.BoilerComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilerComments = Nothing
					Else
						entity.BoilerComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersUser1 As System.String 
				Get
					Dim data_ As System.String = entity.BoilersUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersUser1 = Nothing
					Else
						entity.BoilersUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersUser2 As System.String 
				Get
					Dim data_ As System.String = entity.BoilersUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersUser2 = Nothing
					Else
						entity.BoilersUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersUser3 As System.String 
				Get
					Dim data_ As System.String = entity.BoilersUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersUser3 = Nothing
					Else
						entity.BoilersUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BoilersUser4 As System.String 
				Get
					Dim data_ As System.String = entity.BoilersUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilersUser4 = Nothing
					Else
						entity.BoilersUser4 = Convert.ToString(Value)
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
		  	
			Public Property BoilerMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.BoilerMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BoilerMajorExp = Nothing
					Else
						entity.BoilerMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBMBPV
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMBPVMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMBPVQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMBPVQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMBPVQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMBPVQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMBPVQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMBPVCollection
		Inherits esEntityCollection(Of BMBPV)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMBPVMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMBPVCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMBPVQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMBPVQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMBPVQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMBPVQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMBPVQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMBPVQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMBPVQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMBPVQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMBPVMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "BoilerNo" 
					Return Me.BoilerNo
				Case "BoilerNoBLRB" 
					Return Me.BoilerNoBLRB
				Case "BoilerNoUtility" 
					Return Me.BoilerNoUtility
				Case "BoilerOther" 
					Return Me.BoilerOther
				Case "BoilerComments" 
					Return Me.BoilerComments
				Case "BoilersUser1" 
					Return Me.BoilersUser1
				Case "BoilersUser2" 
					Return Me.BoilersUser2
				Case "BoilersUser3" 
					Return Me.BoilersUser3
				Case "BoilersUser4" 
					Return Me.BoilersUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "BoilerMajorExp" 
					Return Me.BoilerMajorExp
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilerNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilerNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BoilerNoBLRB As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilerNoBLRB, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BoilerNoUtility As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilerNoUtility, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BoilerOther As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilerOther, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilerComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilerComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilersUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilersUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilersUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BoilersUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilersUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property BoilerMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BMBPVMetadata.ColumnNames.BoilerMajorExp, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMBPV 
		Inherits esBMBPV
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BMBPVMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMBPVMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilerNo, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilerNo
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilerNoBLRB, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilerNoBLRB
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilerNoUtility, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilerNoUtility
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilerOther, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilerOther
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilerComments, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilerComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilersUser1, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilersUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilersUser2, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilersUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilersUser3, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilersUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilersUser4, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilersUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.FilePrefix, 10, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BMBPVMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMBPVMetadata.ColumnNames.BoilerMajorExp, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMBPVMetadata.PropertyNames.BoilerMajorExp
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMBPVMetadata
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
			 Public Const BoilerNo As String = "BoilerNo"
			 Public Const BoilerNoBLRB As String = "BoilerNoBLRB"
			 Public Const BoilerNoUtility As String = "BoilerNoUtility"
			 Public Const BoilerOther As String = "BoilerOther"
			 Public Const BoilerComments As String = "BoilerComments"
			 Public Const BoilersUser1 As String = "BoilersUser1"
			 Public Const BoilersUser2 As String = "BoilersUser2"
			 Public Const BoilersUser3 As String = "BoilersUser3"
			 Public Const BoilersUser4 As String = "BoilersUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const BoilerMajorExp As String = "BoilerMajorExp"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const BoilerNo As String = "BoilerNo"
			 Public Const BoilerNoBLRB As String = "BoilerNoBLRB"
			 Public Const BoilerNoUtility As String = "BoilerNoUtility"
			 Public Const BoilerOther As String = "BoilerOther"
			 Public Const BoilerComments As String = "BoilerComments"
			 Public Const BoilersUser1 As String = "BoilersUser1"
			 Public Const BoilersUser2 As String = "BoilersUser2"
			 Public Const BoilersUser3 As String = "BoilersUser3"
			 Public Const BoilersUser4 As String = "BoilersUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const BoilerMajorExp As String = "BoilerMajorExp"
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
			SyncLock GetType(BMBPVMetadata)
			
				If BMBPVMetadata.mapDelegates Is Nothing Then
					BMBPVMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMBPVMetadata._meta Is Nothing Then
					BMBPVMetadata._meta = New BMBPVMetadata()
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
				meta.AddTypeMap("BoilerNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BoilerNoBLRB", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BoilerNoUtility", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BoilerOther", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilerComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BoilersUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("BoilerMajorExp", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-BMBPVHeader"
				meta.Destination = "Cope-BMBPVHeader"
				
				meta.spInsert = "proc_Cope-BMBPVHeaderInsert"
				meta.spUpdate = "proc_Cope-BMBPVHeaderUpdate"
				meta.spDelete = "proc_Cope-BMBPVHeaderDelete"
				meta.spLoadAll = "proc_Cope-BMBPVHeaderLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMBPVHeaderLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMBPVMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
