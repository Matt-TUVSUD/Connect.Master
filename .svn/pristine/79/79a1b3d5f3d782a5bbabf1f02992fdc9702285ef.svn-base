
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/16/2016 12:10:15 PM
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
	' Encapsulates the 'tblMetaColor' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaColor))> _
	<XmlType("TblMetaColor")> _	
	Partial Public Class TblMetaColor 
		Inherits esTblMetaColor
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaColor()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldId As System.Int32)
			Dim obj As New TblMetaColor()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaColor()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("TblMetaColorCollection")> _
	Partial Public Class TblMetaColorCollection
		Inherits esTblMetaColorCollection
		Implements IEnumerable(Of TblMetaColor)
	
		Public Function FindByPrimaryKey(ByVal fldId As System.Int32) As TblMetaColor
			Return MyBase.SingleOrDefault(Function(e) e.FldId.HasValue AndAlso e.FldId.Value = fldId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaColor))> _
		Public Class TblMetaColorCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaColorCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaColorCollectionWCFPacket) As TblMetaColorCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaColorCollection) As TblMetaColorCollectionWCFPacket
				Return New TblMetaColorCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaColorQuery 
		Inherits esTblMetaColorQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaColorQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaColorQuery) As String
			Return TblMetaColorQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaColorQuery
			Return DirectCast(TblMetaColorQuery.SerializeHelper.FromXml(query, GetType(TblMetaColorQuery)), TblMetaColorQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaColor
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fldId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fldId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fldId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fldId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fldId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fldId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fldId As System.Int32) As Boolean
		
			Dim query As New TblMetaColorQuery()
			query.Where(query.FldId = fldId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fldId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FldId", fldId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to tblMetaColor.fldId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaColorMetadata.ColumnNames.FldId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaColorMetadata.ColumnNames.FldId, value) Then
					OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaColor.fldColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldColor As System.String
			Get
				Return MyBase.GetSystemString(TblMetaColorMetadata.ColumnNames.FldColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaColorMetadata.ColumnNames.FldColor, value) Then
					OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaColor.fldHex
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldHex As System.String
			Get
				Return MyBase.GetSystemString(TblMetaColorMetadata.ColumnNames.FldHex)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaColorMetadata.ColumnNames.FldHex, value) Then
					OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldHex)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaColor.fldR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldR As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaColorMetadata.ColumnNames.FldR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaColorMetadata.ColumnNames.FldR, value) Then
					OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaColor.fldG
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldG As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaColorMetadata.ColumnNames.FldG)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaColorMetadata.ColumnNames.FldG, value) Then
					OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldG)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaColor.fldB
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldB As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaColorMetadata.ColumnNames.FldB)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaColorMetadata.ColumnNames.FldB, value) Then
					OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldB)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaColor.fldA
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldA As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TblMetaColorMetadata.ColumnNames.FldA)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(TblMetaColorMetadata.ColumnNames.FldA, value) Then
					OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldA)
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
												
						Case "FldId"
							Me.str().FldId = CType(value, string)
												
						Case "FldColor"
							Me.str().FldColor = CType(value, string)
												
						Case "FldHex"
							Me.str().FldHex = CType(value, string)
												
						Case "FldR"
							Me.str().FldR = CType(value, string)
												
						Case "FldG"
							Me.str().FldG = CType(value, string)
												
						Case "FldB"
							Me.str().FldB = CType(value, string)
												
						Case "FldA"
							Me.str().FldA = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FldId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldId)
							End If
						
						Case "FldR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldR = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldR)
							End If
						
						Case "FldG"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldG = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldG)
							End If
						
						Case "FldB"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldB = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldB)
							End If
						
						Case "FldA"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FldA = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(TblMetaColorMetadata.PropertyNames.FldA)
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
		
			Public Sub New(ByVal entity As esTblMetaColor)
				Me.entity = entity
			End Sub				
		
	
			Public Property FldId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldId = Nothing
					Else
						entity.FldId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldColor As System.String 
				Get
					Dim data_ As System.String = entity.FldColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldColor = Nothing
					Else
						entity.FldColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldHex As System.String 
				Get
					Dim data_ As System.String = entity.FldHex
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldHex = Nothing
					Else
						entity.FldHex = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldR As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldR = Nothing
					Else
						entity.FldR = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldG As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldG
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldG = Nothing
					Else
						entity.FldG = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldB As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldB
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldB = Nothing
					Else
						entity.FldB = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldA As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FldA
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldA = Nothing
					Else
						entity.FldA = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esTblMetaColor
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaColorMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaColorQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaColorQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaColorQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaColorQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblMetaColorQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblMetaColorCollection
		Inherits esEntityCollection(Of TblMetaColor)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaColorMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaColorCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TblMetaColorQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaColorQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TblMetaColorQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaColorQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaColorQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaColorQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaColorQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaColorQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaColorMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldId" 
					Return Me.FldId
				Case "FldColor" 
					Return Me.FldColor
				Case "FldHex" 
					Return Me.FldHex
				Case "FldR" 
					Return Me.FldR
				Case "FldG" 
					Return Me.FldG
				Case "FldB" 
					Return Me.FldB
				Case "FldA" 
					Return Me.FldA
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FldId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaColorMetadata.ColumnNames.FldId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldColor As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaColorMetadata.ColumnNames.FldColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FldHex As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaColorMetadata.ColumnNames.FldHex, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FldR As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaColorMetadata.ColumnNames.FldR, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldG As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaColorMetadata.ColumnNames.FldG, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldB As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaColorMetadata.ColumnNames.FldB, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldA As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaColorMetadata.ColumnNames.FldA, esSystemType.Decimal)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaColor 
		Inherits esTblMetaColor
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaColorMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaColorMetadata.ColumnNames.FldId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaColorMetadata.PropertyNames.FldId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaColorMetadata.ColumnNames.FldColor, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaColorMetadata.PropertyNames.FldColor
			c.CharacterMaxLength = 15
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaColorMetadata.ColumnNames.FldHex, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaColorMetadata.PropertyNames.FldHex
			c.CharacterMaxLength = 7
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaColorMetadata.ColumnNames.FldR, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaColorMetadata.PropertyNames.FldR
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaColorMetadata.ColumnNames.FldG, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaColorMetadata.PropertyNames.FldG
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaColorMetadata.ColumnNames.FldB, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaColorMetadata.PropertyNames.FldB
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaColorMetadata.ColumnNames.FldA, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TblMetaColorMetadata.PropertyNames.FldA
			c.NumericPrecision = 2
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaColorMetadata
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
			 Public Const FldId As String = "fldId"
			 Public Const FldColor As String = "fldColor"
			 Public Const FldHex As String = "fldHex"
			 Public Const FldR As String = "fldR"
			 Public Const FldG As String = "fldG"
			 Public Const FldB As String = "fldB"
			 Public Const FldA As String = "fldA"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldId As String = "FldId"
			 Public Const FldColor As String = "FldColor"
			 Public Const FldHex As String = "FldHex"
			 Public Const FldR As String = "FldR"
			 Public Const FldG As String = "FldG"
			 Public Const FldB As String = "FldB"
			 Public Const FldA As String = "FldA"
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
			SyncLock GetType(TblMetaColorMetadata)
			
				If TblMetaColorMetadata.mapDelegates Is Nothing Then
					TblMetaColorMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaColorMetadata._meta Is Nothing Then
					TblMetaColorMetadata._meta = New TblMetaColorMetadata()
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
				


				meta.AddTypeMap("FldId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FldHex", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FldR", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldG", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldB", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldA", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "tblMetaColor"
				meta.Destination = "tblMetaColor"
				
				meta.spInsert = "proc_tblMetaColorInsert"
				meta.spUpdate = "proc_tblMetaColorUpdate"
				meta.spDelete = "proc_tblMetaColorDelete"
				meta.spLoadAll = "proc_tblMetaColorLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaColorLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaColorMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
