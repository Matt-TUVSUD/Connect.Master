
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/27/2013 9:15:31 AM
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
	' Encapsulates the 'tblUserDefinableLabel' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblUserDefinableLabel))> _
	<XmlType("TblUserDefinableLabel")> _	
	Partial Public Class TblUserDefinableLabel 
		Inherits esTblUserDefinableLabel
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblUserDefinableLabel()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal labelID As System.Int32)
			Dim obj As New TblUserDefinableLabel()
			obj.LabelID = labelID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal labelID As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblUserDefinableLabel()
			obj.LabelID = labelID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("TblUserDefinableLabelCollection")> _
	Partial Public Class TblUserDefinableLabelCollection
		Inherits esTblUserDefinableLabelCollection
		Implements IEnumerable(Of TblUserDefinableLabel)
	
		Public Function FindByPrimaryKey(ByVal labelID As System.Int32) As TblUserDefinableLabel
			Return MyBase.SingleOrDefault(Function(e) e.LabelID.HasValue AndAlso e.LabelID.Value = labelID)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblUserDefinableLabel))> _
		Public Class TblUserDefinableLabelCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblUserDefinableLabelCollection)
			
			Public Shared Widening Operator CType(packet As TblUserDefinableLabelCollectionWCFPacket) As TblUserDefinableLabelCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblUserDefinableLabelCollection) As TblUserDefinableLabelCollectionWCFPacket
				Return New TblUserDefinableLabelCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblUserDefinableLabelQuery 
		Inherits esTblUserDefinableLabelQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblUserDefinableLabelQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblUserDefinableLabelQuery) As String
			Return TblUserDefinableLabelQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblUserDefinableLabelQuery
			Return DirectCast(TblUserDefinableLabelQuery.SerializeHelper.FromXml(query, GetType(TblUserDefinableLabelQuery)), TblUserDefinableLabelQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblUserDefinableLabel
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal labelID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(labelID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(labelID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal labelID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(labelID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(labelID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal labelID As System.Int32) As Boolean
		
			Dim query As New TblUserDefinableLabelQuery()
			query.Where(query.LabelID = labelID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal labelID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LabelID", labelID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to tblUserDefinableLabel.LabelID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LabelID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblUserDefinableLabelMetadata.ColumnNames.LabelID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblUserDefinableLabelMetadata.ColumnNames.LabelID, value) Then
					OnPropertyChanged(TblUserDefinableLabelMetadata.PropertyNames.LabelID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblUserDefinableLabel.GridID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GridID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblUserDefinableLabelMetadata.ColumnNames.GridID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblUserDefinableLabelMetadata.ColumnNames.GridID, value) Then
					OnPropertyChanged(TblUserDefinableLabelMetadata.PropertyNames.GridID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblUserDefinableLabel.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(TblUserDefinableLabelMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblUserDefinableLabelMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(TblUserDefinableLabelMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblUserDefinableLabel.FieldName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FieldName As System.String
			Get
				Return MyBase.GetSystemString(TblUserDefinableLabelMetadata.ColumnNames.FieldName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblUserDefinableLabelMetadata.ColumnNames.FieldName, value) Then
					OnPropertyChanged(TblUserDefinableLabelMetadata.PropertyNames.FieldName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblUserDefinableLabel.LabelText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LabelText As System.String
			Get
				Return MyBase.GetSystemString(TblUserDefinableLabelMetadata.ColumnNames.LabelText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblUserDefinableLabelMetadata.ColumnNames.LabelText, value) Then
					OnPropertyChanged(TblUserDefinableLabelMetadata.PropertyNames.LabelText)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblUserDefinableLabel.Description
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(TblUserDefinableLabelMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblUserDefinableLabelMetadata.ColumnNames.Description, value) Then
					OnPropertyChanged(TblUserDefinableLabelMetadata.PropertyNames.Description)
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
												
						Case "LabelID"
							Me.str().LabelID = CType(value, string)
												
						Case "GridID"
							Me.str().GridID = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "FieldName"
							Me.str().FieldName = CType(value, string)
												
						Case "LabelText"
							Me.str().LabelText = CType(value, string)
												
						Case "Description"
							Me.str().Description = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LabelID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LabelID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblUserDefinableLabelMetadata.PropertyNames.LabelID)
							End If
						
						Case "GridID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GridID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblUserDefinableLabelMetadata.PropertyNames.GridID)
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
		
			Public Sub New(ByVal entity As esTblUserDefinableLabel)
				Me.entity = entity
			End Sub				
		
	
			Public Property LabelID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LabelID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LabelID = Nothing
					Else
						entity.LabelID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property GridID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.GridID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GridID = Nothing
					Else
						entity.GridID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As System.String = entity.FilePrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FieldName As System.String 
				Get
					Dim data_ As System.String = entity.FieldName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FieldName = Nothing
					Else
						entity.FieldName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LabelText As System.String 
				Get
					Dim data_ As System.String = entity.LabelText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LabelText = Nothing
					Else
						entity.LabelText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Description As System.String 
				Get
					Dim data_ As System.String = entity.Description
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Description = Nothing
					Else
						entity.Description = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esTblUserDefinableLabel
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblUserDefinableLabelMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblUserDefinableLabelQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblUserDefinableLabelQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblUserDefinableLabelQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblUserDefinableLabelQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblUserDefinableLabelQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblUserDefinableLabelCollection
		Inherits esEntityCollection(Of TblUserDefinableLabel)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblUserDefinableLabelMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblUserDefinableLabelCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TblUserDefinableLabelQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblUserDefinableLabelQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TblUserDefinableLabelQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblUserDefinableLabelQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblUserDefinableLabelQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblUserDefinableLabelQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblUserDefinableLabelQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblUserDefinableLabelQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblUserDefinableLabelMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "LabelID" 
					Return Me.LabelID
				Case "GridID" 
					Return Me.GridID
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "FieldName" 
					Return Me.FieldName
				Case "LabelText" 
					Return Me.LabelText
				Case "Description" 
					Return Me.Description
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property LabelID As esQueryItem
			Get
				Return New esQueryItem(Me, TblUserDefinableLabelMetadata.ColumnNames.LabelID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property GridID As esQueryItem
			Get
				Return New esQueryItem(Me, TblUserDefinableLabelMetadata.ColumnNames.GridID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, TblUserDefinableLabelMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FieldName As esQueryItem
			Get
				Return New esQueryItem(Me, TblUserDefinableLabelMetadata.ColumnNames.FieldName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LabelText As esQueryItem
			Get
				Return New esQueryItem(Me, TblUserDefinableLabelMetadata.ColumnNames.LabelText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, TblUserDefinableLabelMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblUserDefinableLabel 
		Inherits esTblUserDefinableLabel
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class TblUserDefinableLabelMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblUserDefinableLabelMetadata.ColumnNames.LabelID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblUserDefinableLabelMetadata.PropertyNames.LabelID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblUserDefinableLabelMetadata.ColumnNames.GridID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblUserDefinableLabelMetadata.PropertyNames.GridID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblUserDefinableLabelMetadata.ColumnNames.FilePrefix, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblUserDefinableLabelMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblUserDefinableLabelMetadata.ColumnNames.FieldName, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblUserDefinableLabelMetadata.PropertyNames.FieldName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblUserDefinableLabelMetadata.ColumnNames.LabelText, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblUserDefinableLabelMetadata.PropertyNames.LabelText
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblUserDefinableLabelMetadata.ColumnNames.Description, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblUserDefinableLabelMetadata.PropertyNames.Description
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblUserDefinableLabelMetadata
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
			 Public Const LabelID As String = "LabelID"
			 Public Const GridID As String = "GridID"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FieldName As String = "FieldName"
			 Public Const LabelText As String = "LabelText"
			 Public Const Description As String = "Description"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LabelID As String = "LabelID"
			 Public Const GridID As String = "GridID"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FieldName As String = "FieldName"
			 Public Const LabelText As String = "LabelText"
			 Public Const Description As String = "Description"
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
			SyncLock GetType(TblUserDefinableLabelMetadata)
			
				If TblUserDefinableLabelMetadata.mapDelegates Is Nothing Then
					TblUserDefinableLabelMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblUserDefinableLabelMetadata._meta Is Nothing Then
					TblUserDefinableLabelMetadata._meta = New TblUserDefinableLabelMetadata()
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
				


				meta.AddTypeMap("LabelID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("GridID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FieldName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LabelText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Description", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "tblUserDefinableLabel"
				meta.Destination = "tblUserDefinableLabel"
				
				meta.spInsert = "proc_tblUserDefinableLabelInsert"
				meta.spUpdate = "proc_tblUserDefinableLabelUpdate"
				meta.spDelete = "proc_tblUserDefinableLabelDelete"
				meta.spLoadAll = "proc_tblUserDefinableLabelLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblUserDefinableLabelLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblUserDefinableLabelMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
