
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:21 PM
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
	' Encapsulates the 'Cope-NatHazModeling' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(CopeNatHazModeling))> _
	<XmlType("CopeNatHazModeling")> _	
	Partial Public Class CopeNatHazModeling 
		Inherits esCopeNatHazModeling
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New CopeNatHazModeling()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New CopeNatHazModeling()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New CopeNatHazModeling()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("CopeNatHazModelingCollection")> _
	Partial Public Class CopeNatHazModelingCollection
		Inherits esCopeNatHazModelingCollection
		Implements IEnumerable(Of CopeNatHazModeling)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As CopeNatHazModeling
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(CopeNatHazModeling))> _
		Public Class CopeNatHazModelingCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of CopeNatHazModelingCollection)
			
			Public Shared Widening Operator CType(packet As CopeNatHazModelingCollectionWCFPacket) As CopeNatHazModelingCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As CopeNatHazModelingCollection) As CopeNatHazModelingCollectionWCFPacket
				Return New CopeNatHazModelingCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class CopeNatHazModelingQuery 
		Inherits esCopeNatHazModelingQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "CopeNatHazModelingQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As CopeNatHazModelingQuery) As String
			Return CopeNatHazModelingQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As CopeNatHazModelingQuery
			Return DirectCast(CopeNatHazModelingQuery.SerializeHelper.FromXml(query, GetType(CopeNatHazModelingQuery)), CopeNatHazModelingQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esCopeNatHazModeling
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Int32) As Boolean
		
			Dim query As New CopeNatHazModelingQuery()
			query.Where(query.Id = id)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Cope-NatHazModeling.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.FILENO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fileno As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Fileno)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Fileno, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Fileno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.INSPDATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Inspdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CopeNatHazModelingMetadata.ColumnNames.Inspdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(CopeNatHazModelingMetadata.ColumnNames.Inspdate, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Inspdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.LOCNUM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Locnum As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Locnum)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Locnum, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Locnum)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.LOCNAME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Locname As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Locname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Locname, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Locname)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.USERGEO1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Usergeo1 As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Usergeo1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Usergeo1, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Usergeo1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.STREETNAME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Streetname As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Streetname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Streetname, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Streetname)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.CITY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.STATECODE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Statecode As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Statecode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Statecode, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Statecode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.POSTALCODE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Postalcode As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Postalcode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Postalcode, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Postalcode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.CNTRYCODE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Cntrycode As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Cntrycode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Cntrycode, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Cntrycode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.LONGITUDE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(CopeNatHazModelingMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(CopeNatHazModelingMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.LATITUDE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(CopeNatHazModelingMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(CopeNatHazModelingMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQWS_CV1VAL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EqwsCv1val As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(CopeNatHazModelingMetadata.ColumnNames.EqwsCv1val)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(CopeNatHazModelingMetadata.ColumnNames.EqwsCv1val, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv1val)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQWS_CV2VAL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EqwsCv2val As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(CopeNatHazModelingMetadata.ColumnNames.EqwsCv2val)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(CopeNatHazModelingMetadata.ColumnNames.EqwsCv2val, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv2val)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQWS_CV2CVM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EqwsCv2cvm As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.EqwsCv2cvm)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.EqwsCv2cvm, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv2cvm)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQWS_CV9VAL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EqwsCv9val As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(CopeNatHazModelingMetadata.ColumnNames.EqwsCv9val)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(CopeNatHazModelingMetadata.ColumnNames.EqwsCv9val, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv9val)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQWS_CV9CVM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EqwsCv9cvm As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.EqwsCv9cvm)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.EqwsCv9cvm, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv9cvm)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQWS_CV3VAL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EqwsCv3val As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(CopeNatHazModelingMetadata.ColumnNames.EqwsCv3val)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(CopeNatHazModelingMetadata.ColumnNames.EqwsCv3val, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv3val)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BIPREPAREDNESS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bipreparedness As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Bipreparedness)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Bipreparedness, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Bipreparedness)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BIREDUNDANCY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Biredundancy As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Biredundancy)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Biredundancy, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Biredundancy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.NUMBLDGS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Numbldgs As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Numbldgs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Numbldgs, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Numbldgs)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.NUMSTORIES
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Numstories As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Numstories)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Numstories, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Numstories)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.NUMSTORIESBG
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Numstoriesbg As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Numstoriesbg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Numstoriesbg, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Numstoriesbg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BUILDINGELEVATION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Buildingelevation As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Buildingelevation)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Buildingelevation, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Buildingelevation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BLDGCLASS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bldgclass As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Bldgclass)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Bldgclass, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Bldgclass)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BLDGSCHEME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bldgscheme As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Bldgscheme)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Bldgscheme, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Bldgscheme)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.OCCTYPE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occtype As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Occtype)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Occtype, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Occtype)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.OCCSCHEME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occscheme As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Occscheme)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Occscheme, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Occscheme)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.YEARBUILT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Yearbuilt As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Yearbuilt)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Yearbuilt, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Yearbuilt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.YEARUPGRAD
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Yearupgrad As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Yearupgrad)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Yearupgrad, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Yearupgrad)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.CONQUAL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Conqual As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Conqual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Conqual, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Conqual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.SHAPECONF
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Shapeconf As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Shapeconf)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Shapeconf, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Shapeconf)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.STORYPROF
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Storyprof As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Storyprof)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Storyprof, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Storyprof)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.OVERPROF
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Overprof As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Overprof)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Overprof, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Overprof)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.CLADDING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Cladding As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Cladding)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Cladding, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Cladding)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.SHORTCOL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Shortcol As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Shortcol)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Shortcol, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Shortcol)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ORNAMENT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ornament As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Ornament)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Ornament, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Ornament)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.MECHELEC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mechelec As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Mechelec)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Mechelec, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Mechelec)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.DURESS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Duress As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Duress)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Duress, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Duress)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.POUNDING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pounding As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Pounding)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Pounding, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Pounding)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ENGFOUND
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Engfound As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Engfound)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Engfound, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Engfound)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BASEISOL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Baseisol As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Baseisol)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Baseisol, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Baseisol)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.FRAMEBOLT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Framebolt As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Framebolt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Framebolt, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Framebolt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.TILTUPRET
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Tiltupret As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Tiltupret)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Tiltupret, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Tiltupret)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.URMPROV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Urmprov As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Urmprov)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Urmprov, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Urmprov)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.STRUCTUP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Structup As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Structup)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Structup, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Structup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.MASINTPART
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Masintpart As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Masintpart)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Masintpart, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Masintpart)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQSLINS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Eqslins As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Eqslins)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Eqslins, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Eqslins)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQSLSUSCEPTIBILITY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Eqslsusceptibility As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Eqslsusceptibility)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Eqslsusceptibility, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Eqslsusceptibility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.SPKLRTYPE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Spklrtype As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Spklrtype)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Spklrtype, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Spklrtype)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQCV2PCTSP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Eqcv2pctsp As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Eqcv2pctsp)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Eqcv2pctsp, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Eqcv2pctsp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EQCV9PCTSP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Eqcv9pctsp As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Eqcv9pctsp)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Eqcv9pctsp, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Eqcv9pctsp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.CONSTQUALI
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Constquali As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Constquali)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Constquali, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Constquali)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ROOFSYS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Roofsys As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofsys)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofsys, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofsys)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ROOFGEOM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Roofgeom As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofgeom)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofgeom, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofgeom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ROOFANCH
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Roofanch As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofanch)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofanch, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofanch)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ROOFAGE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Roofage As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofage, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ROOFEQUIP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Roofequip As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofequip)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Roofequip, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofequip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BASEMENT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Basement As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Basement)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Basement, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Basement)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.EXTORN
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Extorn As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Extorn)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Extorn, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Extorn)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.CLADSYS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Cladsys As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Cladsys)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Cladsys, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Cladsys)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.FOUNDSYS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Foundsys As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Foundsys)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Foundsys, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Foundsys)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.MECHGROUND
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Mechground As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Mechground)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Mechground, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Mechground)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.RESISTOPEN
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Resistopen As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Resistopen)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Resistopen, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Resistopen)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ARCHITECT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Architect As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Architect)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(CopeNatHazModelingMetadata.ColumnNames.Architect, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Architect)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.PRIMARYBLDG
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Primarybldg As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Primarybldg)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Primarybldg, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Primarybldg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.SITENAME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Sitename As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Sitename)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Sitename, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Sitename)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.ADDRESSNUM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Addressnum As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Addressnum)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Addressnum, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Addressnum)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.COUNTY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property County As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.County)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.County, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.County)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.STATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property State As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.State)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.State, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.State)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.CNTRYSCHEME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Cntryscheme As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Cntryscheme)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Cntryscheme, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Cntryscheme)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.USERID1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Userid1 As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Userid1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Userid1, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Userid1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.USERID2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Userid2 As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Userid2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Userid2, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Userid2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BLDGHEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bldgheight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Bldgheight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Bldgheight, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Bldgheight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.HEIGHTUNIT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Heightunit As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Heightunit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Heightunit, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Heightunit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.FLOOROCCUPANCY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Flooroccupancy As System.String
			Get
				Return MyBase.GetSystemString(CopeNatHazModelingMetadata.ColumnNames.Flooroccupancy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CopeNatHazModelingMetadata.ColumnNames.Flooroccupancy, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Flooroccupancy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.PCNTCOMPLT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pcntcomplt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(CopeNatHazModelingMetadata.ColumnNames.Pcntcomplt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(CopeNatHazModelingMetadata.ColumnNames.Pcntcomplt, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Pcntcomplt)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.CLADRATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Cladrate As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Cladrate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Cladrate, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Cladrate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.FLASHING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Flashing As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Flashing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Flashing, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Flashing)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.BUILDINGELEVATIONMATCH
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Buildingelevationmatch As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Buildingelevationmatch)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Buildingelevationmatch, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Buildingelevationmatch)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.FLOODDEFENSEELEVATION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Flooddefenseelevation As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Flooddefenseelevation)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Flooddefenseelevation, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Flooddefenseelevation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-NatHazModeling.FLOODDEFENSEELEVATIONUNIT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Flooddefenseelevationunit As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Flooddefenseelevationunit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(CopeNatHazModelingMetadata.ColumnNames.Flooddefenseelevationunit, value) Then
					OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Flooddefenseelevationunit)
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
												
						Case "Id"
							Me.str().Id = CType(value, string)
												
						Case "Fileno"
							Me.str().Fileno = CType(value, string)
												
						Case "Inspdate"
							Me.str().Inspdate = CType(value, string)
												
						Case "Locnum"
							Me.str().Locnum = CType(value, string)
												
						Case "Locname"
							Me.str().Locname = CType(value, string)
												
						Case "Usergeo1"
							Me.str().Usergeo1 = CType(value, string)
												
						Case "Streetname"
							Me.str().Streetname = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "Statecode"
							Me.str().Statecode = CType(value, string)
												
						Case "Postalcode"
							Me.str().Postalcode = CType(value, string)
												
						Case "Cntrycode"
							Me.str().Cntrycode = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "EqwsCv1val"
							Me.str().EqwsCv1val = CType(value, string)
												
						Case "EqwsCv2val"
							Me.str().EqwsCv2val = CType(value, string)
												
						Case "EqwsCv2cvm"
							Me.str().EqwsCv2cvm = CType(value, string)
												
						Case "EqwsCv9val"
							Me.str().EqwsCv9val = CType(value, string)
												
						Case "EqwsCv9cvm"
							Me.str().EqwsCv9cvm = CType(value, string)
												
						Case "EqwsCv3val"
							Me.str().EqwsCv3val = CType(value, string)
												
						Case "Bipreparedness"
							Me.str().Bipreparedness = CType(value, string)
												
						Case "Biredundancy"
							Me.str().Biredundancy = CType(value, string)
												
						Case "Numbldgs"
							Me.str().Numbldgs = CType(value, string)
												
						Case "Numstories"
							Me.str().Numstories = CType(value, string)
												
						Case "Numstoriesbg"
							Me.str().Numstoriesbg = CType(value, string)
												
						Case "Buildingelevation"
							Me.str().Buildingelevation = CType(value, string)
												
						Case "Bldgclass"
							Me.str().Bldgclass = CType(value, string)
												
						Case "Bldgscheme"
							Me.str().Bldgscheme = CType(value, string)
												
						Case "Occtype"
							Me.str().Occtype = CType(value, string)
												
						Case "Occscheme"
							Me.str().Occscheme = CType(value, string)
												
						Case "Yearbuilt"
							Me.str().Yearbuilt = CType(value, string)
												
						Case "Yearupgrad"
							Me.str().Yearupgrad = CType(value, string)
												
						Case "Conqual"
							Me.str().Conqual = CType(value, string)
												
						Case "Shapeconf"
							Me.str().Shapeconf = CType(value, string)
												
						Case "Storyprof"
							Me.str().Storyprof = CType(value, string)
												
						Case "Overprof"
							Me.str().Overprof = CType(value, string)
												
						Case "Cladding"
							Me.str().Cladding = CType(value, string)
												
						Case "Shortcol"
							Me.str().Shortcol = CType(value, string)
												
						Case "Ornament"
							Me.str().Ornament = CType(value, string)
												
						Case "Mechelec"
							Me.str().Mechelec = CType(value, string)
												
						Case "Duress"
							Me.str().Duress = CType(value, string)
												
						Case "Pounding"
							Me.str().Pounding = CType(value, string)
												
						Case "Engfound"
							Me.str().Engfound = CType(value, string)
												
						Case "Baseisol"
							Me.str().Baseisol = CType(value, string)
												
						Case "Framebolt"
							Me.str().Framebolt = CType(value, string)
												
						Case "Tiltupret"
							Me.str().Tiltupret = CType(value, string)
												
						Case "Urmprov"
							Me.str().Urmprov = CType(value, string)
												
						Case "Structup"
							Me.str().Structup = CType(value, string)
												
						Case "Masintpart"
							Me.str().Masintpart = CType(value, string)
												
						Case "Eqslins"
							Me.str().Eqslins = CType(value, string)
												
						Case "Eqslsusceptibility"
							Me.str().Eqslsusceptibility = CType(value, string)
												
						Case "Spklrtype"
							Me.str().Spklrtype = CType(value, string)
												
						Case "Eqcv2pctsp"
							Me.str().Eqcv2pctsp = CType(value, string)
												
						Case "Eqcv9pctsp"
							Me.str().Eqcv9pctsp = CType(value, string)
												
						Case "Constquali"
							Me.str().Constquali = CType(value, string)
												
						Case "Roofsys"
							Me.str().Roofsys = CType(value, string)
												
						Case "Roofgeom"
							Me.str().Roofgeom = CType(value, string)
												
						Case "Roofanch"
							Me.str().Roofanch = CType(value, string)
												
						Case "Roofage"
							Me.str().Roofage = CType(value, string)
												
						Case "Roofequip"
							Me.str().Roofequip = CType(value, string)
												
						Case "Basement"
							Me.str().Basement = CType(value, string)
												
						Case "Extorn"
							Me.str().Extorn = CType(value, string)
												
						Case "Cladsys"
							Me.str().Cladsys = CType(value, string)
												
						Case "Foundsys"
							Me.str().Foundsys = CType(value, string)
												
						Case "Mechground"
							Me.str().Mechground = CType(value, string)
												
						Case "Resistopen"
							Me.str().Resistopen = CType(value, string)
												
						Case "Architect"
							Me.str().Architect = CType(value, string)
												
						Case "Primarybldg"
							Me.str().Primarybldg = CType(value, string)
												
						Case "Sitename"
							Me.str().Sitename = CType(value, string)
												
						Case "Addressnum"
							Me.str().Addressnum = CType(value, string)
												
						Case "County"
							Me.str().County = CType(value, string)
												
						Case "State"
							Me.str().State = CType(value, string)
												
						Case "Cntryscheme"
							Me.str().Cntryscheme = CType(value, string)
												
						Case "Userid1"
							Me.str().Userid1 = CType(value, string)
												
						Case "Userid2"
							Me.str().Userid2 = CType(value, string)
												
						Case "Bldgheight"
							Me.str().Bldgheight = CType(value, string)
												
						Case "Heightunit"
							Me.str().Heightunit = CType(value, string)
												
						Case "Flooroccupancy"
							Me.str().Flooroccupancy = CType(value, string)
												
						Case "Pcntcomplt"
							Me.str().Pcntcomplt = CType(value, string)
												
						Case "Cladrate"
							Me.str().Cladrate = CType(value, string)
												
						Case "Flashing"
							Me.str().Flashing = CType(value, string)
												
						Case "Buildingelevationmatch"
							Me.str().Buildingelevationmatch = CType(value, string)
												
						Case "Flooddefenseelevation"
							Me.str().Flooddefenseelevation = CType(value, string)
												
						Case "Flooddefenseelevationunit"
							Me.str().Flooddefenseelevationunit = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Id)
							End If
						
						Case "Inspdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Inspdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Inspdate)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Longitude)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Latitude)
							End If
						
						Case "EqwsCv1val"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.EqwsCv1val = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv1val)
							End If
						
						Case "EqwsCv2val"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.EqwsCv2val = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv2val)
							End If
						
						Case "EqwsCv2cvm"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.EqwsCv2cvm = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv2cvm)
							End If
						
						Case "EqwsCv9val"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.EqwsCv9val = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv9val)
							End If
						
						Case "EqwsCv9cvm"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.EqwsCv9cvm = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv9cvm)
							End If
						
						Case "EqwsCv3val"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.EqwsCv3val = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.EqwsCv3val)
							End If
						
						Case "Bipreparedness"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Bipreparedness = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Bipreparedness)
							End If
						
						Case "Biredundancy"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Biredundancy = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Biredundancy)
							End If
						
						Case "Numbldgs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Numbldgs = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Numbldgs)
							End If
						
						Case "Buildingelevation"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Buildingelevation = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Buildingelevation)
							End If
						
						Case "Conqual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Conqual = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Conqual)
							End If
						
						Case "Shapeconf"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Shapeconf = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Shapeconf)
							End If
						
						Case "Storyprof"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Storyprof = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Storyprof)
							End If
						
						Case "Overprof"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Overprof = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Overprof)
							End If
						
						Case "Cladding"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Cladding = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Cladding)
							End If
						
						Case "Shortcol"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Shortcol = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Shortcol)
							End If
						
						Case "Ornament"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Ornament = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Ornament)
							End If
						
						Case "Mechelec"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Mechelec = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Mechelec)
							End If
						
						Case "Duress"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Duress = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Duress)
							End If
						
						Case "Pounding"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Pounding = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Pounding)
							End If
						
						Case "Engfound"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Engfound = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Engfound)
							End If
						
						Case "Baseisol"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Baseisol = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Baseisol)
							End If
						
						Case "Framebolt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Framebolt = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Framebolt)
							End If
						
						Case "Tiltupret"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Tiltupret = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Tiltupret)
							End If
						
						Case "Urmprov"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Urmprov = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Urmprov)
							End If
						
						Case "Structup"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Structup = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Structup)
							End If
						
						Case "Masintpart"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Masintpart = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Masintpart)
							End If
						
						Case "Eqslins"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Eqslins = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Eqslins)
							End If
						
						Case "Eqslsusceptibility"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Eqslsusceptibility = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Eqslsusceptibility)
							End If
						
						Case "Spklrtype"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Spklrtype = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Spklrtype)
							End If
						
						Case "Eqcv2pctsp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Eqcv2pctsp = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Eqcv2pctsp)
							End If
						
						Case "Eqcv9pctsp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Eqcv9pctsp = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Eqcv9pctsp)
							End If
						
						Case "Constquali"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Constquali = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Constquali)
							End If
						
						Case "Roofsys"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Roofsys = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofsys)
							End If
						
						Case "Roofgeom"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Roofgeom = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofgeom)
							End If
						
						Case "Roofanch"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Roofanch = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofanch)
							End If
						
						Case "Roofage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Roofage = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofage)
							End If
						
						Case "Roofequip"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Roofequip = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Roofequip)
							End If
						
						Case "Basement"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Basement = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Basement)
							End If
						
						Case "Extorn"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Extorn = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Extorn)
							End If
						
						Case "Cladsys"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Cladsys = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Cladsys)
							End If
						
						Case "Foundsys"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Foundsys = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Foundsys)
							End If
						
						Case "Mechground"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Mechground = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Mechground)
							End If
						
						Case "Resistopen"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Resistopen = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Resistopen)
							End If
						
						Case "Architect"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.Architect = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Architect)
							End If
						
						Case "Primarybldg"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Primarybldg = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Primarybldg)
							End If
						
						Case "Bldgheight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bldgheight = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Bldgheight)
							End If
						
						Case "Heightunit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Heightunit = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Heightunit)
							End If
						
						Case "Pcntcomplt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Pcntcomplt = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Pcntcomplt)
							End If
						
						Case "Cladrate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Cladrate = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Cladrate)
							End If
						
						Case "Flashing"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Flashing = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Flashing)
							End If
						
						Case "Buildingelevationmatch"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Buildingelevationmatch = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Buildingelevationmatch)
							End If
						
						Case "Flooddefenseelevation"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Flooddefenseelevation = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Flooddefenseelevation)
							End If
						
						Case "Flooddefenseelevationunit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Flooddefenseelevationunit = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(CopeNatHazModelingMetadata.PropertyNames.Flooddefenseelevationunit)
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
		
			Public Sub New(ByVal entity As esCopeNatHazModeling)
				Me.entity = entity
			End Sub				
		
	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Id
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Id = Nothing
					Else
						entity.Id = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fileno As System.String 
				Get
					Dim data_ As System.String = entity.Fileno
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fileno = Nothing
					Else
						entity.Fileno = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inspdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Inspdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inspdate = Nothing
					Else
						entity.Inspdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Locnum As System.String 
				Get
					Dim data_ As System.String = entity.Locnum
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Locnum = Nothing
					Else
						entity.Locnum = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Locname As System.String 
				Get
					Dim data_ As System.String = entity.Locname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Locname = Nothing
					Else
						entity.Locname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Usergeo1 As System.String 
				Get
					Dim data_ As System.String = entity.Usergeo1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Usergeo1 = Nothing
					Else
						entity.Usergeo1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Streetname As System.String 
				Get
					Dim data_ As System.String = entity.Streetname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Streetname = Nothing
					Else
						entity.Streetname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property City As System.String 
				Get
					Dim data_ As System.String = entity.City
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.City = Nothing
					Else
						entity.City = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Statecode As System.String 
				Get
					Dim data_ As System.String = entity.Statecode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Statecode = Nothing
					Else
						entity.Statecode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Postalcode As System.String 
				Get
					Dim data_ As System.String = entity.Postalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Postalcode = Nothing
					Else
						entity.Postalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Cntrycode As System.String 
				Get
					Dim data_ As System.String = entity.Cntrycode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Cntrycode = Nothing
					Else
						entity.Cntrycode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Longitude As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Longitude
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Longitude = Nothing
					Else
						entity.Longitude = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Latitude As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Latitude
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Latitude = Nothing
					Else
						entity.Latitude = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property EqwsCv1val As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.EqwsCv1val
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EqwsCv1val = Nothing
					Else
						entity.EqwsCv1val = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property EqwsCv2val As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.EqwsCv2val
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EqwsCv2val = Nothing
					Else
						entity.EqwsCv2val = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property EqwsCv2cvm As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.EqwsCv2cvm
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EqwsCv2cvm = Nothing
					Else
						entity.EqwsCv2cvm = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property EqwsCv9val As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.EqwsCv9val
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EqwsCv9val = Nothing
					Else
						entity.EqwsCv9val = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property EqwsCv9cvm As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.EqwsCv9cvm
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EqwsCv9cvm = Nothing
					Else
						entity.EqwsCv9cvm = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property EqwsCv3val As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.EqwsCv3val
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EqwsCv3val = Nothing
					Else
						entity.EqwsCv3val = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bipreparedness As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Bipreparedness
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bipreparedness = Nothing
					Else
						entity.Bipreparedness = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Biredundancy As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Biredundancy
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Biredundancy = Nothing
					Else
						entity.Biredundancy = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Numbldgs As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Numbldgs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Numbldgs = Nothing
					Else
						entity.Numbldgs = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Numstories As System.String 
				Get
					Dim data_ As System.String = entity.Numstories
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Numstories = Nothing
					Else
						entity.Numstories = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Numstoriesbg As System.String 
				Get
					Dim data_ As System.String = entity.Numstoriesbg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Numstoriesbg = Nothing
					Else
						entity.Numstoriesbg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Buildingelevation As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Buildingelevation
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Buildingelevation = Nothing
					Else
						entity.Buildingelevation = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bldgclass As System.String 
				Get
					Dim data_ As System.String = entity.Bldgclass
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bldgclass = Nothing
					Else
						entity.Bldgclass = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bldgscheme As System.String 
				Get
					Dim data_ As System.String = entity.Bldgscheme
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bldgscheme = Nothing
					Else
						entity.Bldgscheme = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occtype As System.String 
				Get
					Dim data_ As System.String = entity.Occtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occtype = Nothing
					Else
						entity.Occtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occscheme As System.String 
				Get
					Dim data_ As System.String = entity.Occscheme
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occscheme = Nothing
					Else
						entity.Occscheme = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Yearbuilt As System.String 
				Get
					Dim data_ As System.String = entity.Yearbuilt
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Yearbuilt = Nothing
					Else
						entity.Yearbuilt = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Yearupgrad As System.String 
				Get
					Dim data_ As System.String = entity.Yearupgrad
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Yearupgrad = Nothing
					Else
						entity.Yearupgrad = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Conqual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Conqual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Conqual = Nothing
					Else
						entity.Conqual = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shapeconf As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Shapeconf
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shapeconf = Nothing
					Else
						entity.Shapeconf = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Storyprof As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Storyprof
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Storyprof = Nothing
					Else
						entity.Storyprof = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Overprof As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Overprof
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Overprof = Nothing
					Else
						entity.Overprof = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Cladding As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Cladding
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Cladding = Nothing
					Else
						entity.Cladding = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shortcol As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Shortcol
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shortcol = Nothing
					Else
						entity.Shortcol = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ornament As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Ornament
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ornament = Nothing
					Else
						entity.Ornament = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mechelec As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Mechelec
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mechelec = Nothing
					Else
						entity.Mechelec = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Duress As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Duress
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Duress = Nothing
					Else
						entity.Duress = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pounding As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Pounding
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pounding = Nothing
					Else
						entity.Pounding = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Engfound As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Engfound
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Engfound = Nothing
					Else
						entity.Engfound = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Baseisol As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Baseisol
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Baseisol = Nothing
					Else
						entity.Baseisol = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Framebolt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Framebolt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Framebolt = Nothing
					Else
						entity.Framebolt = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Tiltupret As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Tiltupret
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Tiltupret = Nothing
					Else
						entity.Tiltupret = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Urmprov As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Urmprov
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Urmprov = Nothing
					Else
						entity.Urmprov = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Structup As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Structup
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Structup = Nothing
					Else
						entity.Structup = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Masintpart As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Masintpart
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Masintpart = Nothing
					Else
						entity.Masintpart = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Eqslins As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Eqslins
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Eqslins = Nothing
					Else
						entity.Eqslins = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Eqslsusceptibility As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Eqslsusceptibility
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Eqslsusceptibility = Nothing
					Else
						entity.Eqslsusceptibility = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Spklrtype As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Spklrtype
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Spklrtype = Nothing
					Else
						entity.Spklrtype = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Eqcv2pctsp As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Eqcv2pctsp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Eqcv2pctsp = Nothing
					Else
						entity.Eqcv2pctsp = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Eqcv9pctsp As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Eqcv9pctsp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Eqcv9pctsp = Nothing
					Else
						entity.Eqcv9pctsp = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Constquali As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Constquali
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Constquali = Nothing
					Else
						entity.Constquali = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Roofsys As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Roofsys
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Roofsys = Nothing
					Else
						entity.Roofsys = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Roofgeom As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Roofgeom
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Roofgeom = Nothing
					Else
						entity.Roofgeom = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Roofanch As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Roofanch
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Roofanch = Nothing
					Else
						entity.Roofanch = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Roofage As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Roofage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Roofage = Nothing
					Else
						entity.Roofage = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Roofequip As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Roofequip
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Roofequip = Nothing
					Else
						entity.Roofequip = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Basement As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Basement
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Basement = Nothing
					Else
						entity.Basement = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Extorn As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Extorn
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extorn = Nothing
					Else
						entity.Extorn = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Cladsys As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Cladsys
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Cladsys = Nothing
					Else
						entity.Cladsys = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Foundsys As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Foundsys
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Foundsys = Nothing
					Else
						entity.Foundsys = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mechground As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Mechground
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mechground = Nothing
					Else
						entity.Mechground = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resistopen As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Resistopen
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resistopen = Nothing
					Else
						entity.Resistopen = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Architect As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.Architect
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Architect = Nothing
					Else
						entity.Architect = Convert.ToInt16(Value)
					End If
				End Set
			End Property
		  	
			Public Property Primarybldg As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Primarybldg
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Primarybldg = Nothing
					Else
						entity.Primarybldg = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sitename As System.String 
				Get
					Dim data_ As System.String = entity.Sitename
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sitename = Nothing
					Else
						entity.Sitename = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Addressnum As System.String 
				Get
					Dim data_ As System.String = entity.Addressnum
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Addressnum = Nothing
					Else
						entity.Addressnum = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property County As System.String 
				Get
					Dim data_ As System.String = entity.County
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.County = Nothing
					Else
						entity.County = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property State As System.String 
				Get
					Dim data_ As System.String = entity.State
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.State = Nothing
					Else
						entity.State = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Cntryscheme As System.String 
				Get
					Dim data_ As System.String = entity.Cntryscheme
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Cntryscheme = Nothing
					Else
						entity.Cntryscheme = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userid1 As System.String 
				Get
					Dim data_ As System.String = entity.Userid1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userid1 = Nothing
					Else
						entity.Userid1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userid2 As System.String 
				Get
					Dim data_ As System.String = entity.Userid2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userid2 = Nothing
					Else
						entity.Userid2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bldgheight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bldgheight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bldgheight = Nothing
					Else
						entity.Bldgheight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Heightunit As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Heightunit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Heightunit = Nothing
					Else
						entity.Heightunit = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Flooroccupancy As System.String 
				Get
					Dim data_ As System.String = entity.Flooroccupancy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Flooroccupancy = Nothing
					Else
						entity.Flooroccupancy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pcntcomplt As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Pcntcomplt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pcntcomplt = Nothing
					Else
						entity.Pcntcomplt = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Cladrate As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Cladrate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Cladrate = Nothing
					Else
						entity.Cladrate = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Flashing As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Flashing
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Flashing = Nothing
					Else
						entity.Flashing = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Buildingelevationmatch As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Buildingelevationmatch
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Buildingelevationmatch = Nothing
					Else
						entity.Buildingelevationmatch = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Flooddefenseelevation As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Flooddefenseelevation
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Flooddefenseelevation = Nothing
					Else
						entity.Flooddefenseelevation = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Flooddefenseelevationunit As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Flooddefenseelevationunit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Flooddefenseelevationunit = Nothing
					Else
						entity.Flooddefenseelevationunit = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCopeNatHazModeling
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeNatHazModelingMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As CopeNatHazModelingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeNatHazModelingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As CopeNatHazModelingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As CopeNatHazModelingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CopeNatHazModelingQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esCopeNatHazModelingCollection
		Inherits esEntityCollection(Of CopeNatHazModeling)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CopeNatHazModelingMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "CopeNatHazModelingCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As CopeNatHazModelingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CopeNatHazModelingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As CopeNatHazModelingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New CopeNatHazModelingQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As CopeNatHazModelingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, CopeNatHazModelingQuery))
		End Sub
		
		#End Region
						
		Private m_query As CopeNatHazModelingQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esCopeNatHazModelingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CopeNatHazModelingMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "Fileno" 
					Return Me.Fileno
				Case "Inspdate" 
					Return Me.Inspdate
				Case "Locnum" 
					Return Me.Locnum
				Case "Locname" 
					Return Me.Locname
				Case "Usergeo1" 
					Return Me.Usergeo1
				Case "Streetname" 
					Return Me.Streetname
				Case "City" 
					Return Me.City
				Case "Statecode" 
					Return Me.Statecode
				Case "Postalcode" 
					Return Me.Postalcode
				Case "Cntrycode" 
					Return Me.Cntrycode
				Case "Longitude" 
					Return Me.Longitude
				Case "Latitude" 
					Return Me.Latitude
				Case "EqwsCv1val" 
					Return Me.EqwsCv1val
				Case "EqwsCv2val" 
					Return Me.EqwsCv2val
				Case "EqwsCv2cvm" 
					Return Me.EqwsCv2cvm
				Case "EqwsCv9val" 
					Return Me.EqwsCv9val
				Case "EqwsCv9cvm" 
					Return Me.EqwsCv9cvm
				Case "EqwsCv3val" 
					Return Me.EqwsCv3val
				Case "Bipreparedness" 
					Return Me.Bipreparedness
				Case "Biredundancy" 
					Return Me.Biredundancy
				Case "Numbldgs" 
					Return Me.Numbldgs
				Case "Numstories" 
					Return Me.Numstories
				Case "Numstoriesbg" 
					Return Me.Numstoriesbg
				Case "Buildingelevation" 
					Return Me.Buildingelevation
				Case "Bldgclass" 
					Return Me.Bldgclass
				Case "Bldgscheme" 
					Return Me.Bldgscheme
				Case "Occtype" 
					Return Me.Occtype
				Case "Occscheme" 
					Return Me.Occscheme
				Case "Yearbuilt" 
					Return Me.Yearbuilt
				Case "Yearupgrad" 
					Return Me.Yearupgrad
				Case "Conqual" 
					Return Me.Conqual
				Case "Shapeconf" 
					Return Me.Shapeconf
				Case "Storyprof" 
					Return Me.Storyprof
				Case "Overprof" 
					Return Me.Overprof
				Case "Cladding" 
					Return Me.Cladding
				Case "Shortcol" 
					Return Me.Shortcol
				Case "Ornament" 
					Return Me.Ornament
				Case "Mechelec" 
					Return Me.Mechelec
				Case "Duress" 
					Return Me.Duress
				Case "Pounding" 
					Return Me.Pounding
				Case "Engfound" 
					Return Me.Engfound
				Case "Baseisol" 
					Return Me.Baseisol
				Case "Framebolt" 
					Return Me.Framebolt
				Case "Tiltupret" 
					Return Me.Tiltupret
				Case "Urmprov" 
					Return Me.Urmprov
				Case "Structup" 
					Return Me.Structup
				Case "Masintpart" 
					Return Me.Masintpart
				Case "Eqslins" 
					Return Me.Eqslins
				Case "Eqslsusceptibility" 
					Return Me.Eqslsusceptibility
				Case "Spklrtype" 
					Return Me.Spklrtype
				Case "Eqcv2pctsp" 
					Return Me.Eqcv2pctsp
				Case "Eqcv9pctsp" 
					Return Me.Eqcv9pctsp
				Case "Constquali" 
					Return Me.Constquali
				Case "Roofsys" 
					Return Me.Roofsys
				Case "Roofgeom" 
					Return Me.Roofgeom
				Case "Roofanch" 
					Return Me.Roofanch
				Case "Roofage" 
					Return Me.Roofage
				Case "Roofequip" 
					Return Me.Roofequip
				Case "Basement" 
					Return Me.Basement
				Case "Extorn" 
					Return Me.Extorn
				Case "Cladsys" 
					Return Me.Cladsys
				Case "Foundsys" 
					Return Me.Foundsys
				Case "Mechground" 
					Return Me.Mechground
				Case "Resistopen" 
					Return Me.Resistopen
				Case "Architect" 
					Return Me.Architect
				Case "Primarybldg" 
					Return Me.Primarybldg
				Case "Sitename" 
					Return Me.Sitename
				Case "Addressnum" 
					Return Me.Addressnum
				Case "County" 
					Return Me.County
				Case "State" 
					Return Me.State
				Case "Cntryscheme" 
					Return Me.Cntryscheme
				Case "Userid1" 
					Return Me.Userid1
				Case "Userid2" 
					Return Me.Userid2
				Case "Bldgheight" 
					Return Me.Bldgheight
				Case "Heightunit" 
					Return Me.Heightunit
				Case "Flooroccupancy" 
					Return Me.Flooroccupancy
				Case "Pcntcomplt" 
					Return Me.Pcntcomplt
				Case "Cladrate" 
					Return Me.Cladrate
				Case "Flashing" 
					Return Me.Flashing
				Case "Buildingelevationmatch" 
					Return Me.Buildingelevationmatch
				Case "Flooddefenseelevation" 
					Return Me.Flooddefenseelevation
				Case "Flooddefenseelevationunit" 
					Return Me.Flooddefenseelevationunit
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fileno As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Fileno, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inspdate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Inspdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Locnum As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Locnum, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Locname As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Locname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Usergeo1 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Usergeo1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Streetname As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Streetname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Statecode As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Statecode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Postalcode As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Postalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Cntrycode As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Cntrycode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property EqwsCv1val As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.EqwsCv1val, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property EqwsCv2val As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.EqwsCv2val, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property EqwsCv2cvm As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.EqwsCv2cvm, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property EqwsCv9val As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.EqwsCv9val, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property EqwsCv9cvm As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.EqwsCv9cvm, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property EqwsCv3val As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.EqwsCv3val, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property Bipreparedness As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Bipreparedness, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Biredundancy As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Biredundancy, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Numbldgs As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Numbldgs, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Numstories As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Numstories, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Numstoriesbg As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Numstoriesbg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Buildingelevation As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Buildingelevation, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Bldgclass As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Bldgclass, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bldgscheme As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Bldgscheme, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occtype As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Occtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occscheme As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Occscheme, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Yearbuilt As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Yearbuilt, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Yearupgrad As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Yearupgrad, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Conqual As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Conqual, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Shapeconf As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Shapeconf, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Storyprof As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Storyprof, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Overprof As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Overprof, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Cladding As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Cladding, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Shortcol As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Shortcol, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Ornament As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Ornament, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Mechelec As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Mechelec, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Duress As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Duress, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Pounding As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Pounding, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Engfound As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Engfound, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Baseisol As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Baseisol, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Framebolt As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Framebolt, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Tiltupret As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Tiltupret, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Urmprov As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Urmprov, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Structup As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Structup, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Masintpart As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Masintpart, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Eqslins As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Eqslins, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Eqslsusceptibility As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Eqslsusceptibility, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Spklrtype As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Spklrtype, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Eqcv2pctsp As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Eqcv2pctsp, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Eqcv9pctsp As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Eqcv9pctsp, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Constquali As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Constquali, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Roofsys As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Roofsys, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Roofgeom As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Roofgeom, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Roofanch As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Roofanch, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Roofage As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Roofage, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Roofequip As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Roofequip, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Basement As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Basement, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Extorn As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Extorn, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Cladsys As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Cladsys, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Foundsys As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Foundsys, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Mechground As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Mechground, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Resistopen As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Resistopen, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Architect As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Architect, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Primarybldg As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Primarybldg, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sitename As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Sitename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Addressnum As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Addressnum, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property County As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.County, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property State As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.State, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Cntryscheme As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Cntryscheme, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Userid1 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Userid1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Userid2 As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Userid2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bldgheight As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Bldgheight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Heightunit As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Heightunit, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Flooroccupancy As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Flooroccupancy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Pcntcomplt As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Pcntcomplt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Cladrate As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Cladrate, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Flashing As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Flashing, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Buildingelevationmatch As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Buildingelevationmatch, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Flooddefenseelevation As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Flooddefenseelevation, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Flooddefenseelevationunit As esQueryItem
			Get
				Return New esQueryItem(Me, CopeNatHazModelingMetadata.ColumnNames.Flooddefenseelevationunit, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class CopeNatHazModelingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Fileno, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Fileno
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Inspdate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Inspdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Locnum, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Locnum
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Locname, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Locname
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Usergeo1, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Usergeo1
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Streetname, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Streetname
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.City, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.City
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Statecode, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Statecode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Postalcode, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Postalcode
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Cntrycode, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Cntrycode
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Longitude, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Longitude
			c.NumericPrecision = 9
			c.NumericScale = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Latitude, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Latitude
			c.NumericPrecision = 9
			c.NumericScale = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.EqwsCv1val, 13, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.EqwsCv1val
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.EqwsCv2val, 14, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.EqwsCv2val
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.EqwsCv2cvm, 15, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.EqwsCv2cvm
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.EqwsCv9val, 16, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.EqwsCv9val
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.EqwsCv9cvm, 17, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.EqwsCv9cvm
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.EqwsCv3val, 18, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.EqwsCv3val
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Bipreparedness, 19, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Bipreparedness
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Biredundancy, 20, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Biredundancy
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Numbldgs, 21, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Numbldgs
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Numstories, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Numstories
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Numstoriesbg, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Numstoriesbg
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Buildingelevation, 24, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Buildingelevation
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Bldgclass, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Bldgclass
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Bldgscheme, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Bldgscheme
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Occtype, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Occtype
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Occscheme, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Occscheme
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Yearbuilt, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Yearbuilt
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Yearupgrad, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Yearupgrad
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Conqual, 31, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Conqual
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Shapeconf, 32, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Shapeconf
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Storyprof, 33, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Storyprof
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Overprof, 34, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Overprof
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Cladding, 35, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Cladding
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Shortcol, 36, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Shortcol
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Ornament, 37, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Ornament
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Mechelec, 38, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Mechelec
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Duress, 39, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Duress
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Pounding, 40, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Pounding
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Engfound, 41, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Engfound
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Baseisol, 42, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Baseisol
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Framebolt, 43, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Framebolt
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Tiltupret, 44, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Tiltupret
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Urmprov, 45, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Urmprov
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Structup, 46, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Structup
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Masintpart, 47, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Masintpart
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Eqslins, 48, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Eqslins
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Eqslsusceptibility, 49, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Eqslsusceptibility
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Spklrtype, 50, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Spklrtype
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Eqcv2pctsp, 51, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Eqcv2pctsp
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Eqcv9pctsp, 52, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Eqcv9pctsp
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Constquali, 53, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Constquali
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Roofsys, 54, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Roofsys
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Roofgeom, 55, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Roofgeom
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Roofanch, 56, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Roofanch
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Roofage, 57, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Roofage
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Roofequip, 58, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Roofequip
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Basement, 59, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Basement
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Extorn, 60, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Extorn
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Cladsys, 61, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Cladsys
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Foundsys, 62, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Foundsys
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Mechground, 63, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Mechground
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Resistopen, 64, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Resistopen
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Architect, 65, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Architect
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Primarybldg, 66, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Primarybldg
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Sitename, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Sitename
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Addressnum, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Addressnum
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.County, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.County
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.State, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.State
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Cntryscheme, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Cntryscheme
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Userid1, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Userid1
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Userid2, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Userid2
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Bldgheight, 74, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Bldgheight
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Heightunit, 75, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Heightunit
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Flooroccupancy, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Flooroccupancy
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Pcntcomplt, 77, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Pcntcomplt
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Cladrate, 78, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Cladrate
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Flashing, 79, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Flashing
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Buildingelevationmatch, 80, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Buildingelevationmatch
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Flooddefenseelevation, 81, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Flooddefenseelevation
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CopeNatHazModelingMetadata.ColumnNames.Flooddefenseelevationunit, 82, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CopeNatHazModelingMetadata.PropertyNames.Flooddefenseelevationunit
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As CopeNatHazModelingMetadata
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
			 Public Const Id As String = "ID"
			 Public Const Fileno As String = "FILENO"
			 Public Const Inspdate As String = "INSPDATE"
			 Public Const Locnum As String = "LOCNUM"
			 Public Const Locname As String = "LOCNAME"
			 Public Const Usergeo1 As String = "USERGEO1"
			 Public Const Streetname As String = "STREETNAME"
			 Public Const City As String = "CITY"
			 Public Const Statecode As String = "STATECODE"
			 Public Const Postalcode As String = "POSTALCODE"
			 Public Const Cntrycode As String = "CNTRYCODE"
			 Public Const Longitude As String = "LONGITUDE"
			 Public Const Latitude As String = "LATITUDE"
			 Public Const EqwsCv1val As String = "EQWS_CV1VAL"
			 Public Const EqwsCv2val As String = "EQWS_CV2VAL"
			 Public Const EqwsCv2cvm As String = "EQWS_CV2CVM"
			 Public Const EqwsCv9val As String = "EQWS_CV9VAL"
			 Public Const EqwsCv9cvm As String = "EQWS_CV9CVM"
			 Public Const EqwsCv3val As String = "EQWS_CV3VAL"
			 Public Const Bipreparedness As String = "BIPREPAREDNESS"
			 Public Const Biredundancy As String = "BIREDUNDANCY"
			 Public Const Numbldgs As String = "NUMBLDGS"
			 Public Const Numstories As String = "NUMSTORIES"
			 Public Const Numstoriesbg As String = "NUMSTORIESBG"
			 Public Const Buildingelevation As String = "BUILDINGELEVATION"
			 Public Const Bldgclass As String = "BLDGCLASS"
			 Public Const Bldgscheme As String = "BLDGSCHEME"
			 Public Const Occtype As String = "OCCTYPE"
			 Public Const Occscheme As String = "OCCSCHEME"
			 Public Const Yearbuilt As String = "YEARBUILT"
			 Public Const Yearupgrad As String = "YEARUPGRAD"
			 Public Const Conqual As String = "CONQUAL"
			 Public Const Shapeconf As String = "SHAPECONF"
			 Public Const Storyprof As String = "STORYPROF"
			 Public Const Overprof As String = "OVERPROF"
			 Public Const Cladding As String = "CLADDING"
			 Public Const Shortcol As String = "SHORTCOL"
			 Public Const Ornament As String = "ORNAMENT"
			 Public Const Mechelec As String = "MECHELEC"
			 Public Const Duress As String = "DURESS"
			 Public Const Pounding As String = "POUNDING"
			 Public Const Engfound As String = "ENGFOUND"
			 Public Const Baseisol As String = "BASEISOL"
			 Public Const Framebolt As String = "FRAMEBOLT"
			 Public Const Tiltupret As String = "TILTUPRET"
			 Public Const Urmprov As String = "URMPROV"
			 Public Const Structup As String = "STRUCTUP"
			 Public Const Masintpart As String = "MASINTPART"
			 Public Const Eqslins As String = "EQSLINS"
			 Public Const Eqslsusceptibility As String = "EQSLSUSCEPTIBILITY"
			 Public Const Spklrtype As String = "SPKLRTYPE"
			 Public Const Eqcv2pctsp As String = "EQCV2PCTSP"
			 Public Const Eqcv9pctsp As String = "EQCV9PCTSP"
			 Public Const Constquali As String = "CONSTQUALI"
			 Public Const Roofsys As String = "ROOFSYS"
			 Public Const Roofgeom As String = "ROOFGEOM"
			 Public Const Roofanch As String = "ROOFANCH"
			 Public Const Roofage As String = "ROOFAGE"
			 Public Const Roofequip As String = "ROOFEQUIP"
			 Public Const Basement As String = "BASEMENT"
			 Public Const Extorn As String = "EXTORN"
			 Public Const Cladsys As String = "CLADSYS"
			 Public Const Foundsys As String = "FOUNDSYS"
			 Public Const Mechground As String = "MECHGROUND"
			 Public Const Resistopen As String = "RESISTOPEN"
			 Public Const Architect As String = "ARCHITECT"
			 Public Const Primarybldg As String = "PRIMARYBLDG"
			 Public Const Sitename As String = "SITENAME"
			 Public Const Addressnum As String = "ADDRESSNUM"
			 Public Const County As String = "COUNTY"
			 Public Const State As String = "STATE"
			 Public Const Cntryscheme As String = "CNTRYSCHEME"
			 Public Const Userid1 As String = "USERID1"
			 Public Const Userid2 As String = "USERID2"
			 Public Const Bldgheight As String = "BLDGHEIGHT"
			 Public Const Heightunit As String = "HEIGHTUNIT"
			 Public Const Flooroccupancy As String = "FLOOROCCUPANCY"
			 Public Const Pcntcomplt As String = "PCNTCOMPLT"
			 Public Const Cladrate As String = "CLADRATE"
			 Public Const Flashing As String = "FLASHING"
			 Public Const Buildingelevationmatch As String = "BUILDINGELEVATIONMATCH"
			 Public Const Flooddefenseelevation As String = "FLOODDEFENSEELEVATION"
			 Public Const Flooddefenseelevationunit As String = "FLOODDEFENSEELEVATIONUNIT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const Fileno As String = "Fileno"
			 Public Const Inspdate As String = "Inspdate"
			 Public Const Locnum As String = "Locnum"
			 Public Const Locname As String = "Locname"
			 Public Const Usergeo1 As String = "Usergeo1"
			 Public Const Streetname As String = "Streetname"
			 Public Const City As String = "City"
			 Public Const Statecode As String = "Statecode"
			 Public Const Postalcode As String = "Postalcode"
			 Public Const Cntrycode As String = "Cntrycode"
			 Public Const Longitude As String = "Longitude"
			 Public Const Latitude As String = "Latitude"
			 Public Const EqwsCv1val As String = "EqwsCv1val"
			 Public Const EqwsCv2val As String = "EqwsCv2val"
			 Public Const EqwsCv2cvm As String = "EqwsCv2cvm"
			 Public Const EqwsCv9val As String = "EqwsCv9val"
			 Public Const EqwsCv9cvm As String = "EqwsCv9cvm"
			 Public Const EqwsCv3val As String = "EqwsCv3val"
			 Public Const Bipreparedness As String = "Bipreparedness"
			 Public Const Biredundancy As String = "Biredundancy"
			 Public Const Numbldgs As String = "Numbldgs"
			 Public Const Numstories As String = "Numstories"
			 Public Const Numstoriesbg As String = "Numstoriesbg"
			 Public Const Buildingelevation As String = "Buildingelevation"
			 Public Const Bldgclass As String = "Bldgclass"
			 Public Const Bldgscheme As String = "Bldgscheme"
			 Public Const Occtype As String = "Occtype"
			 Public Const Occscheme As String = "Occscheme"
			 Public Const Yearbuilt As String = "Yearbuilt"
			 Public Const Yearupgrad As String = "Yearupgrad"
			 Public Const Conqual As String = "Conqual"
			 Public Const Shapeconf As String = "Shapeconf"
			 Public Const Storyprof As String = "Storyprof"
			 Public Const Overprof As String = "Overprof"
			 Public Const Cladding As String = "Cladding"
			 Public Const Shortcol As String = "Shortcol"
			 Public Const Ornament As String = "Ornament"
			 Public Const Mechelec As String = "Mechelec"
			 Public Const Duress As String = "Duress"
			 Public Const Pounding As String = "Pounding"
			 Public Const Engfound As String = "Engfound"
			 Public Const Baseisol As String = "Baseisol"
			 Public Const Framebolt As String = "Framebolt"
			 Public Const Tiltupret As String = "Tiltupret"
			 Public Const Urmprov As String = "Urmprov"
			 Public Const Structup As String = "Structup"
			 Public Const Masintpart As String = "Masintpart"
			 Public Const Eqslins As String = "Eqslins"
			 Public Const Eqslsusceptibility As String = "Eqslsusceptibility"
			 Public Const Spklrtype As String = "Spklrtype"
			 Public Const Eqcv2pctsp As String = "Eqcv2pctsp"
			 Public Const Eqcv9pctsp As String = "Eqcv9pctsp"
			 Public Const Constquali As String = "Constquali"
			 Public Const Roofsys As String = "Roofsys"
			 Public Const Roofgeom As String = "Roofgeom"
			 Public Const Roofanch As String = "Roofanch"
			 Public Const Roofage As String = "Roofage"
			 Public Const Roofequip As String = "Roofequip"
			 Public Const Basement As String = "Basement"
			 Public Const Extorn As String = "Extorn"
			 Public Const Cladsys As String = "Cladsys"
			 Public Const Foundsys As String = "Foundsys"
			 Public Const Mechground As String = "Mechground"
			 Public Const Resistopen As String = "Resistopen"
			 Public Const Architect As String = "Architect"
			 Public Const Primarybldg As String = "Primarybldg"
			 Public Const Sitename As String = "Sitename"
			 Public Const Addressnum As String = "Addressnum"
			 Public Const County As String = "County"
			 Public Const State As String = "State"
			 Public Const Cntryscheme As String = "Cntryscheme"
			 Public Const Userid1 As String = "Userid1"
			 Public Const Userid2 As String = "Userid2"
			 Public Const Bldgheight As String = "Bldgheight"
			 Public Const Heightunit As String = "Heightunit"
			 Public Const Flooroccupancy As String = "Flooroccupancy"
			 Public Const Pcntcomplt As String = "Pcntcomplt"
			 Public Const Cladrate As String = "Cladrate"
			 Public Const Flashing As String = "Flashing"
			 Public Const Buildingelevationmatch As String = "Buildingelevationmatch"
			 Public Const Flooddefenseelevation As String = "Flooddefenseelevation"
			 Public Const Flooddefenseelevationunit As String = "Flooddefenseelevationunit"
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
			SyncLock GetType(CopeNatHazModelingMetadata)
			
				If CopeNatHazModelingMetadata.mapDelegates Is Nothing Then
					CopeNatHazModelingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If CopeNatHazModelingMetadata._meta Is Nothing Then
					CopeNatHazModelingMetadata._meta = New CopeNatHazModelingMetadata()
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
				


				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fileno", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Inspdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Locnum", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Locname", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Usergeo1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Streetname", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Statecode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Postalcode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Cntrycode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("EqwsCv1val", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("EqwsCv2val", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("EqwsCv2cvm", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("EqwsCv9val", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("EqwsCv9cvm", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("EqwsCv3val", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("Bipreparedness", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Biredundancy", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Numbldgs", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Numstories", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Numstoriesbg", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Buildingelevation", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Bldgclass", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Bldgscheme", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Occtype", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Occscheme", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Yearbuilt", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Yearupgrad", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Conqual", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Shapeconf", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Storyprof", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Overprof", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Cladding", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Shortcol", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Ornament", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Mechelec", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Duress", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Pounding", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Engfound", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Baseisol", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Framebolt", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Tiltupret", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Urmprov", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Structup", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Masintpart", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Eqslins", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Eqslsusceptibility", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Spklrtype", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Eqcv2pctsp", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Eqcv9pctsp", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Constquali", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Roofsys", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Roofgeom", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Roofanch", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Roofage", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Roofequip", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Basement", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Extorn", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Cladsys", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Foundsys", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Mechground", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Resistopen", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Architect", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Primarybldg", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sitename", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Addressnum", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("County", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("State", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Cntryscheme", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Userid1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Userid2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Bldgheight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Heightunit", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Flooroccupancy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Pcntcomplt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Cladrate", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Flashing", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Buildingelevationmatch", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Flooddefenseelevation", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Flooddefenseelevationunit", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "Cope-NatHazModeling"
				meta.Destination = "Cope-NatHazModeling"
				
				meta.spInsert = "proc_Cope-NatHazModelingInsert"
				meta.spUpdate = "proc_Cope-NatHazModelingUpdate"
				meta.spDelete = "proc_Cope-NatHazModelingDelete"
				meta.spLoadAll = "proc_Cope-NatHazModelingLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-NatHazModelingLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As CopeNatHazModelingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
