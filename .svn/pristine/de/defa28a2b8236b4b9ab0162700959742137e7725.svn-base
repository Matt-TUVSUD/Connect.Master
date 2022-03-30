
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/16/2016 12:10:17 PM
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
	' Encapsulates the 'tblMetaRatingKeyRange' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblMetaRatingKeyRange))> _
	<XmlType("TblMetaRatingKeyRange")> _	
	Partial Public Class TblMetaRatingKeyRange 
		Inherits esTblMetaRatingKeyRange
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblMetaRatingKeyRange()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fldId As System.Int32)
			Dim obj As New TblMetaRatingKeyRange()
			obj.FldId = fldId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fldId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblMetaRatingKeyRange()
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
	<XmlType("TblMetaRatingKeyRangeCollection")> _
	Partial Public Class TblMetaRatingKeyRangeCollection
		Inherits esTblMetaRatingKeyRangeCollection
		Implements IEnumerable(Of TblMetaRatingKeyRange)
	
		Public Function FindByPrimaryKey(ByVal fldId As System.Int32) As TblMetaRatingKeyRange
			Return MyBase.SingleOrDefault(Function(e) e.FldId.HasValue AndAlso e.FldId.Value = fldId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblMetaRatingKeyRange))> _
		Public Class TblMetaRatingKeyRangeCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblMetaRatingKeyRangeCollection)
			
			Public Shared Widening Operator CType(packet As TblMetaRatingKeyRangeCollectionWCFPacket) As TblMetaRatingKeyRangeCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblMetaRatingKeyRangeCollection) As TblMetaRatingKeyRangeCollectionWCFPacket
				Return New TblMetaRatingKeyRangeCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblMetaRatingKeyRangeQuery 
		Inherits esTblMetaRatingKeyRangeQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblMetaRatingKeyRangeQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblMetaRatingKeyRangeQuery) As String
			Return TblMetaRatingKeyRangeQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblMetaRatingKeyRangeQuery
			Return DirectCast(TblMetaRatingKeyRangeQuery.SerializeHelper.FromXml(query, GetType(TblMetaRatingKeyRangeQuery)), TblMetaRatingKeyRangeQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRatingKeyRange
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
		
			Dim query As New TblMetaRatingKeyRangeQuery()
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
		' Maps to tblMetaRatingKeyRange.fldId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRatingKeyRangeMetadata.ColumnNames.FldId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRatingKeyRangeMetadata.ColumnNames.FldId, value) Then
					OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRatingKeyRange.fldKeyId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldKeyId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRatingKeyRangeMetadata.ColumnNames.FldKeyId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRatingKeyRangeMetadata.ColumnNames.FldKeyId, value) Then
					OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldKeyId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRatingKeyRange.fldRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldRating As System.String
			Get
				Return MyBase.GetSystemString(TblMetaRatingKeyRangeMetadata.ColumnNames.FldRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaRatingKeyRangeMetadata.ColumnNames.FldRating, value) Then
					OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRatingKeyRange.fldDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldDescription As System.String
			Get
				Return MyBase.GetSystemString(TblMetaRatingKeyRangeMetadata.ColumnNames.FldDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaRatingKeyRangeMetadata.ColumnNames.FldDescription, value) Then
					OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRatingKeyRange.fldScoreLow
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldScoreLow As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(TblMetaRatingKeyRangeMetadata.ColumnNames.FldScoreLow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(TblMetaRatingKeyRangeMetadata.ColumnNames.FldScoreLow, value) Then
					OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldScoreLow)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRatingKeyRange.fldScoreHigh
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldScoreHigh As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(TblMetaRatingKeyRangeMetadata.ColumnNames.FldScoreHigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(TblMetaRatingKeyRangeMetadata.ColumnNames.FldScoreHigh, value) Then
					OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldScoreHigh)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRatingKeyRange.fldMetaColorId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldMetaColorId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblMetaRatingKeyRangeMetadata.ColumnNames.FldMetaColorId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblMetaRatingKeyRangeMetadata.ColumnNames.FldMetaColorId, value) Then
					OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldMetaColorId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblMetaRatingKeyRange.fldPSRatingKey
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FldPSRatingKey As System.String
			Get
				Return MyBase.GetSystemString(TblMetaRatingKeyRangeMetadata.ColumnNames.FldPSRatingKey)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblMetaRatingKeyRangeMetadata.ColumnNames.FldPSRatingKey, value) Then
					OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldPSRatingKey)
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
												
						Case "FldKeyId"
							Me.str().FldKeyId = CType(value, string)
												
						Case "FldRating"
							Me.str().FldRating = CType(value, string)
												
						Case "FldDescription"
							Me.str().FldDescription = CType(value, string)
												
						Case "FldScoreLow"
							Me.str().FldScoreLow = CType(value, string)
												
						Case "FldScoreHigh"
							Me.str().FldScoreHigh = CType(value, string)
												
						Case "FldMetaColorId"
							Me.str().FldMetaColorId = CType(value, string)
												
						Case "FldPSRatingKey"
							Me.str().FldPSRatingKey = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FldId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldId)
							End If
						
						Case "FldKeyId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldKeyId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldKeyId)
							End If
						
						Case "FldScoreLow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.FldScoreLow = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldScoreLow)
							End If
						
						Case "FldScoreHigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.FldScoreHigh = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldScoreHigh)
							End If
						
						Case "FldMetaColorId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FldMetaColorId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblMetaRatingKeyRangeMetadata.PropertyNames.FldMetaColorId)
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
		
			Public Sub New(ByVal entity As esTblMetaRatingKeyRange)
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
		  	
			Public Property FldKeyId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldKeyId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldKeyId = Nothing
					Else
						entity.FldKeyId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldRating As System.String 
				Get
					Dim data_ As System.String = entity.FldRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldRating = Nothing
					Else
						entity.FldRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldDescription As System.String 
				Get
					Dim data_ As System.String = entity.FldDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldDescription = Nothing
					Else
						entity.FldDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldScoreLow As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.FldScoreLow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldScoreLow = Nothing
					Else
						entity.FldScoreLow = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldScoreHigh As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.FldScoreHigh
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldScoreHigh = Nothing
					Else
						entity.FldScoreHigh = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldMetaColorId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FldMetaColorId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldMetaColorId = Nothing
					Else
						entity.FldMetaColorId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FldPSRatingKey As System.String 
				Get
					Dim data_ As System.String = entity.FldPSRatingKey
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FldPSRatingKey = Nothing
					Else
						entity.FldPSRatingKey = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esTblMetaRatingKeyRange
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRatingKeyRangeMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblMetaRatingKeyRangeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRatingKeyRangeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblMetaRatingKeyRangeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblMetaRatingKeyRangeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblMetaRatingKeyRangeQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblMetaRatingKeyRangeCollection
		Inherits esEntityCollection(Of TblMetaRatingKeyRange)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblMetaRatingKeyRangeMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblMetaRatingKeyRangeCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TblMetaRatingKeyRangeQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblMetaRatingKeyRangeQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TblMetaRatingKeyRangeQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblMetaRatingKeyRangeQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblMetaRatingKeyRangeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblMetaRatingKeyRangeQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblMetaRatingKeyRangeQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblMetaRatingKeyRangeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblMetaRatingKeyRangeMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FldId" 
					Return Me.FldId
				Case "FldKeyId" 
					Return Me.FldKeyId
				Case "FldRating" 
					Return Me.FldRating
				Case "FldDescription" 
					Return Me.FldDescription
				Case "FldScoreLow" 
					Return Me.FldScoreLow
				Case "FldScoreHigh" 
					Return Me.FldScoreHigh
				Case "FldMetaColorId" 
					Return Me.FldMetaColorId
				Case "FldPSRatingKey" 
					Return Me.FldPSRatingKey
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FldId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyRangeMetadata.ColumnNames.FldId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldKeyId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyRangeMetadata.ColumnNames.FldKeyId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldRating As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyRangeMetadata.ColumnNames.FldRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FldDescription As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyRangeMetadata.ColumnNames.FldDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FldScoreLow As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyRangeMetadata.ColumnNames.FldScoreLow, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property FldScoreHigh As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyRangeMetadata.ColumnNames.FldScoreHigh, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property FldMetaColorId As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyRangeMetadata.ColumnNames.FldMetaColorId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FldPSRatingKey As esQueryItem
			Get
				Return New esQueryItem(Me, TblMetaRatingKeyRangeMetadata.ColumnNames.FldPSRatingKey, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class TblMetaRatingKeyRange 
		Inherits esTblMetaRatingKeyRange
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class TblMetaRatingKeyRangeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblMetaRatingKeyRangeMetadata.ColumnNames.FldId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRatingKeyRangeMetadata.PropertyNames.FldId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRatingKeyRangeMetadata.ColumnNames.FldKeyId, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRatingKeyRangeMetadata.PropertyNames.FldKeyId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRatingKeyRangeMetadata.ColumnNames.FldRating, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaRatingKeyRangeMetadata.PropertyNames.FldRating
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRatingKeyRangeMetadata.ColumnNames.FldDescription, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaRatingKeyRangeMetadata.PropertyNames.FldDescription
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRatingKeyRangeMetadata.ColumnNames.FldScoreLow, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = TblMetaRatingKeyRangeMetadata.PropertyNames.FldScoreLow
			c.NumericPrecision = 15
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRatingKeyRangeMetadata.ColumnNames.FldScoreHigh, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = TblMetaRatingKeyRangeMetadata.PropertyNames.FldScoreHigh
			c.NumericPrecision = 15
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRatingKeyRangeMetadata.ColumnNames.FldMetaColorId, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblMetaRatingKeyRangeMetadata.PropertyNames.FldMetaColorId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblMetaRatingKeyRangeMetadata.ColumnNames.FldPSRatingKey, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblMetaRatingKeyRangeMetadata.PropertyNames.FldPSRatingKey
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblMetaRatingKeyRangeMetadata
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
			 Public Const FldKeyId As String = "fldKeyId"
			 Public Const FldRating As String = "fldRating"
			 Public Const FldDescription As String = "fldDescription"
			 Public Const FldScoreLow As String = "fldScoreLow"
			 Public Const FldScoreHigh As String = "fldScoreHigh"
			 Public Const FldMetaColorId As String = "fldMetaColorId"
			 Public Const FldPSRatingKey As String = "fldPSRatingKey"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FldId As String = "FldId"
			 Public Const FldKeyId As String = "FldKeyId"
			 Public Const FldRating As String = "FldRating"
			 Public Const FldDescription As String = "FldDescription"
			 Public Const FldScoreLow As String = "FldScoreLow"
			 Public Const FldScoreHigh As String = "FldScoreHigh"
			 Public Const FldMetaColorId As String = "FldMetaColorId"
			 Public Const FldPSRatingKey As String = "FldPSRatingKey"
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
			SyncLock GetType(TblMetaRatingKeyRangeMetadata)
			
				If TblMetaRatingKeyRangeMetadata.mapDelegates Is Nothing Then
					TblMetaRatingKeyRangeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblMetaRatingKeyRangeMetadata._meta Is Nothing Then
					TblMetaRatingKeyRangeMetadata._meta = New TblMetaRatingKeyRangeMetadata()
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
				meta.AddTypeMap("FldKeyId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldRating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FldDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FldScoreLow", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("FldScoreHigh", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("FldMetaColorId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FldPSRatingKey", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "tblMetaRatingKeyRange"
				meta.Destination = "tblMetaRatingKeyRange"
				
				meta.spInsert = "proc_tblMetaRatingKeyRangeInsert"
				meta.spUpdate = "proc_tblMetaRatingKeyRangeUpdate"
				meta.spDelete = "proc_tblMetaRatingKeyRangeDelete"
				meta.spLoadAll = "proc_tblMetaRatingKeyRangeLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblMetaRatingKeyRangeLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblMetaRatingKeyRangeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
