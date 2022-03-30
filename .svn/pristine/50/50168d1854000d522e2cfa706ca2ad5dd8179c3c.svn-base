
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/10/2012 9:52:58 AM
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
	' Encapsulates the 'aplfactorkey' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Aplfactorkey))> _
	<XmlType("Aplfactorkey")> _	
	Partial Public Class Aplfactorkey 
		Inherits esAplfactorkey
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Aplfactorkey()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileprefix As System.Int16)
			Dim obj As New Aplfactorkey()
			obj.Fileprefix = fileprefix
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileprefix As System.Int16, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Aplfactorkey()
			obj.Fileprefix = fileprefix
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("AplfactorkeyCollection")> _
	Partial Public Class AplfactorkeyCollection
		Inherits esAplfactorkeyCollection
		Implements IEnumerable(Of Aplfactorkey)
	
		Public Function FindByPrimaryKey(ByVal fileprefix As System.Int16) As Aplfactorkey
			Return MyBase.SingleOrDefault(Function(e) e.Fileprefix.HasValue AndAlso e.Fileprefix.Value = fileprefix)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Aplfactorkey))> _
		Public Class AplfactorkeyCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of AplfactorkeyCollection)
			
			Public Shared Widening Operator CType(packet As AplfactorkeyCollectionWCFPacket) As AplfactorkeyCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As AplfactorkeyCollection) As AplfactorkeyCollectionWCFPacket
				Return New AplfactorkeyCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class AplfactorkeyQuery 
		Inherits esAplfactorkeyQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "AplfactorkeyQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As AplfactorkeyQuery) As String
			Return AplfactorkeyQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As AplfactorkeyQuery
			Return DirectCast(AplfactorkeyQuery.SerializeHelper.FromXml(query, GetType(AplfactorkeyQuery)), AplfactorkeyQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esAplfactorkey
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fileprefix As System.Int16) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileprefix)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileprefix)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fileprefix As System.Int16) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileprefix)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileprefix)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fileprefix As System.Int16) As Boolean
		
			Dim query As New AplfactorkeyQuery()
			query.Where(query.Fileprefix = fileprefix)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fileprefix As System.Int16) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Fileprefix", fileprefix)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to aplfactorkey.fileprefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fileprefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(AplfactorkeyMetadata.ColumnNames.Fileprefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(AplfactorkeyMetadata.ColumnNames.Fileprefix, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Fileprefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to aplfactorkey.range1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Range1 As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(AplfactorkeyMetadata.ColumnNames.Range1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(AplfactorkeyMetadata.ColumnNames.Range1, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Range1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to aplfactorkey.factor1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Factor1 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(AplfactorkeyMetadata.ColumnNames.Factor1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(AplfactorkeyMetadata.ColumnNames.Factor1, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Factor1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to aplfactorkey.range2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Range2 As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(AplfactorkeyMetadata.ColumnNames.Range2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(AplfactorkeyMetadata.ColumnNames.Range2, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Range2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to aplfactorkey.factor2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Factor2 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(AplfactorkeyMetadata.ColumnNames.Factor2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(AplfactorkeyMetadata.ColumnNames.Factor2, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Factor2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to aplfactorkey.range3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Range3 As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(AplfactorkeyMetadata.ColumnNames.Range3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(AplfactorkeyMetadata.ColumnNames.Range3, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Range3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to aplfactorkey.factor3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Factor3 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(AplfactorkeyMetadata.ColumnNames.Factor3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(AplfactorkeyMetadata.ColumnNames.Factor3, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Factor3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to aplfactorkey.range4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Range4 As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(AplfactorkeyMetadata.ColumnNames.Range4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(AplfactorkeyMetadata.ColumnNames.Range4, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Range4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to aplfactorkey.factor4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Factor4 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(AplfactorkeyMetadata.ColumnNames.Factor4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(AplfactorkeyMetadata.ColumnNames.Factor4, value) Then
					OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Factor4)
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
												
						Case "Fileprefix"
							Me.str().Fileprefix = CType(value, string)
												
						Case "Range1"
							Me.str().Range1 = CType(value, string)
												
						Case "Factor1"
							Me.str().Factor1 = CType(value, string)
												
						Case "Range2"
							Me.str().Range2 = CType(value, string)
												
						Case "Factor2"
							Me.str().Factor2 = CType(value, string)
												
						Case "Range3"
							Me.str().Range3 = CType(value, string)
												
						Case "Factor3"
							Me.str().Factor3 = CType(value, string)
												
						Case "Range4"
							Me.str().Range4 = CType(value, string)
												
						Case "Factor4"
							Me.str().Factor4 = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Fileprefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Fileprefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Fileprefix)
							End If
						
						Case "Range1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.Range1 = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Range1)
							End If
						
						Case "Factor1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Factor1 = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Factor1)
							End If
						
						Case "Range2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.Range2 = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Range2)
							End If
						
						Case "Factor2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Factor2 = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Factor2)
							End If
						
						Case "Range3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.Range3 = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Range3)
							End If
						
						Case "Factor3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Factor3 = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Factor3)
							End If
						
						Case "Range4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.Range4 = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Range4)
							End If
						
						Case "Factor4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Factor4 = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(AplfactorkeyMetadata.PropertyNames.Factor4)
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
		
			Public Sub New(ByVal entity As esAplfactorkey)
				Me.entity = entity
			End Sub				
		
	
			Public Property Fileprefix As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Fileprefix
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fileprefix = Nothing
					Else
						entity.Fileprefix = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Range1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.Range1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Range1 = Nothing
					Else
						entity.Range1 = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property Factor1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Factor1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Factor1 = Nothing
					Else
						entity.Factor1 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Range2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.Range2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Range2 = Nothing
					Else
						entity.Range2 = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property Factor2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Factor2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Factor2 = Nothing
					Else
						entity.Factor2 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Range3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.Range3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Range3 = Nothing
					Else
						entity.Range3 = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property Factor3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Factor3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Factor3 = Nothing
					Else
						entity.Factor3 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Range4 As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.Range4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Range4 = Nothing
					Else
						entity.Range4 = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property Factor4 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Factor4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Factor4 = Nothing
					Else
						entity.Factor4 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esAplfactorkey
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return AplfactorkeyMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As AplfactorkeyQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New AplfactorkeyQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As AplfactorkeyQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As AplfactorkeyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As AplfactorkeyQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esAplfactorkeyCollection
		Inherits esEntityCollection(Of Aplfactorkey)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return AplfactorkeyMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "AplfactorkeyCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As AplfactorkeyQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New AplfactorkeyQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As AplfactorkeyQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New AplfactorkeyQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As AplfactorkeyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, AplfactorkeyQuery))
		End Sub
		
		#End Region
						
		Private m_query As AplfactorkeyQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esAplfactorkeyQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AplfactorkeyMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Fileprefix" 
					Return Me.Fileprefix
				Case "Range1" 
					Return Me.Range1
				Case "Factor1" 
					Return Me.Factor1
				Case "Range2" 
					Return Me.Range2
				Case "Factor2" 
					Return Me.Factor2
				Case "Range3" 
					Return Me.Range3
				Case "Factor3" 
					Return Me.Factor3
				Case "Range4" 
					Return Me.Range4
				Case "Factor4" 
					Return Me.Factor4
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Fileprefix As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Fileprefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Range1 As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Range1, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Factor1 As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Factor1, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Range2 As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Range2, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Factor2 As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Factor2, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Range3 As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Range3, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Factor3 As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Factor3, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Range4 As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Range4, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Factor4 As esQueryItem
			Get
				Return New esQueryItem(Me, AplfactorkeyMetadata.ColumnNames.Factor4, esSystemType.Decimal)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class Aplfactorkey 
		Inherits esAplfactorkey
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class AplfactorkeyMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Fileprefix, 0, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Fileprefix
			c.IsInPrimaryKey = True
			c.NumericPrecision = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Range1, 1, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Range1
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Factor1, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Factor1
			c.NumericPrecision = 3
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Range2, 3, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Range2
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Factor2, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Factor2
			c.NumericPrecision = 3
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Range3, 5, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Range3
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Factor3, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Factor3
			c.NumericPrecision = 3
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Range4, 7, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Range4
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(AplfactorkeyMetadata.ColumnNames.Factor4, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = AplfactorkeyMetadata.PropertyNames.Factor4
			c.NumericPrecision = 3
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As AplfactorkeyMetadata
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
			 Public Const Fileprefix As String = "fileprefix"
			 Public Const Range1 As String = "range1"
			 Public Const Factor1 As String = "factor1"
			 Public Const Range2 As String = "range2"
			 Public Const Factor2 As String = "factor2"
			 Public Const Range3 As String = "range3"
			 Public Const Factor3 As String = "factor3"
			 Public Const Range4 As String = "range4"
			 Public Const Factor4 As String = "factor4"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Fileprefix As String = "Fileprefix"
			 Public Const Range1 As String = "Range1"
			 Public Const Factor1 As String = "Factor1"
			 Public Const Range2 As String = "Range2"
			 Public Const Factor2 As String = "Factor2"
			 Public Const Range3 As String = "Range3"
			 Public Const Factor3 As String = "Factor3"
			 Public Const Range4 As String = "Range4"
			 Public Const Factor4 As String = "Factor4"
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
			SyncLock GetType(AplfactorkeyMetadata)
			
				If AplfactorkeyMetadata.mapDelegates Is Nothing Then
					AplfactorkeyMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If AplfactorkeyMetadata._meta Is Nothing Then
					AplfactorkeyMetadata._meta = New AplfactorkeyMetadata()
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
				


				meta.AddTypeMap("Fileprefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Range1", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("Factor1", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Range2", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("Factor2", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Range3", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("Factor3", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Range4", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("Factor4", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "aplfactorkey"
				meta.Destination = "aplfactorkey"
				
				meta.spInsert = "proc_aplfactorkeyInsert"
				meta.spUpdate = "proc_aplfactorkeyUpdate"
				meta.spDelete = "proc_aplfactorkeyDelete"
				meta.spLoadAll = "proc_aplfactorkeyLoadAll"
				meta.spLoadByPrimaryKey = "proc_aplfactorkeyLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As AplfactorkeyMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
