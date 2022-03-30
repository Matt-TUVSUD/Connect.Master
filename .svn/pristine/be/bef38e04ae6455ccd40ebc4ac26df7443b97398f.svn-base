
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/17/2013 1:56:59 PM
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
	' Encapsulates the 'Cope-Boiler03-Mechanical' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BmMechanical))> _
	<XmlType("BmMechanical")> _	
	Partial Public Class BmMechanical 
		Inherits esBmMechanical
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BmMechanical()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BmMechanical()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BmMechanical()
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
	<XmlType("BmMechanicalCollection")> _
	Partial Public Class BmMechanicalCollection
		Inherits esBmMechanicalCollection
		Implements IEnumerable(Of BmMechanical)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BmMechanical
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BmMechanical))> _
		Public Class BmMechanicalCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BmMechanicalCollection)
			
			Public Shared Widening Operator CType(packet As BmMechanicalCollectionWCFPacket) As BmMechanicalCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BmMechanicalCollection) As BmMechanicalCollectionWCFPacket
				Return New BmMechanicalCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BmMechanicalQuery 
		Inherits esBmMechanicalQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BmMechanicalQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BmMechanicalQuery) As String
			Return BmMechanicalQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BmMechanicalQuery
			Return DirectCast(BmMechanicalQuery.SerializeHelper.FromXml(query, GetType(BmMechanicalQuery)), BmMechanicalQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBmMechanical
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
		
			Dim query As New BmMechanicalQuery()
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
		' Maps to Cope-Boiler03-Mechanical.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CompMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CompMajorExp, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CompAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CompAdeqCap, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmMechanicalMetadata.ColumnNames.CompNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmMechanicalMetadata.ColumnNames.CompNo, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompRental
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompRental As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CompRental)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CompRental, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompRental)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompSpares
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompSpares As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CompSpares)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CompSpares, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompSpares)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompProcess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompProcess As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.CompProcess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.CompProcess, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompProcess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompInstruments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompInstruments As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.CompInstruments)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.CompInstruments, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompInstruments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompGeneral
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompGeneral As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.CompGeneral)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.CompGeneral, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompGeneral)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompOther As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.CompOther)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.CompOther, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CompComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompComments As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CompComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CompComments, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.RefrigMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.RefrigMajorExp, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.RefrigAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.RefrigAdeqCap, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigProcess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigProcess As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.RefrigProcess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.RefrigProcess, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigProcess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigComfort
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigComfort As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.RefrigComfort)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.RefrigComfort, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigComfort)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigSpares
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigSpares As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.RefrigSpares)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.RefrigSpares, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigSpares)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigRental
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigRental As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.RefrigRental)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.RefrigRental, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigRental)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigProcessType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigProcessType As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.RefrigProcessType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.RefrigProcessType, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigProcessType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigComfortType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigComfortType As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.RefrigComfortType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.RefrigComfortType, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigComfortType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigProcessNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigProcessNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmMechanicalMetadata.ColumnNames.RefrigProcessNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmMechanicalMetadata.ColumnNames.RefrigProcessNo, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigProcessNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigComfortNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigComfortNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmMechanicalMetadata.ColumnNames.RefrigComfortNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmMechanicalMetadata.ColumnNames.RefrigComfortNo, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigComfortNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.RefrigComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RefrigComments As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.RefrigComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.RefrigComments, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.WaterMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.WaterMajorExp, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.WaterAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.WaterAdeqCap, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterPrimary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterPrimary As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.WaterPrimary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.WaterPrimary, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterPrimary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterSecondary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterSecondary As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.WaterSecondary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.WaterSecondary, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterSecondary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterProcess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterProcess As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.WaterProcess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.WaterProcess, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterProcess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterCooling
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterCooling As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.WaterCooling)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.WaterCooling, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterCooling)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterBoilers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterBoilers As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.WaterBoilers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.WaterBoilers, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterBoilers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterGeneral
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterGeneral As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.WaterGeneral)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.WaterGeneral, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterGeneral)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterReserveCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterReserveCap As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.WaterReserveCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.WaterReserveCap, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterReserveCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.WaterComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WaterComments As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.WaterComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.WaterComments, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CoolingMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CoolingMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CoolingMajorExp, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CoolingAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CoolingAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CoolingAdeqCap, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CoolingProcess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingProcess As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.CoolingProcess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.CoolingProcess, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingProcess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CoolingEquipment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingEquipment As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.CoolingEquipment)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.CoolingEquipment, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingEquipment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CoolingNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmMechanicalMetadata.ColumnNames.CoolingNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmMechanicalMetadata.ColumnNames.CoolingNo, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CoolingPumps
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingPumps As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CoolingPumps)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CoolingPumps, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingPumps)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CoolingReserve
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingReserve As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CoolingReserve)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CoolingReserve, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingReserve)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.CoolingComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CoolingComments As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.CoolingComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.CoolingComments, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.FuelMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.FuelMajorExp, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelMajorExp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelAdeqCap
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelAdeqCap As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.FuelAdeqCap)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.FuelAdeqCap, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelAdeqCap)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelPrimarySource
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelPrimarySource As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.FuelPrimarySource)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.FuelPrimarySource, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelPrimarySource)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelSecondarySource
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelSecondarySource As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.FuelSecondarySource)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.FuelSecondarySource, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelSecondarySource)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelSupplierNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelSupplierNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmMechanicalMetadata.ColumnNames.FuelSupplierNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmMechanicalMetadata.ColumnNames.FuelSupplierNo, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelSupplierNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelInventory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelInventory As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BmMechanicalMetadata.ColumnNames.FuelInventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BmMechanicalMetadata.ColumnNames.FuelInventory, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelInventory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelProcess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelProcess As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.FuelProcess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.FuelProcess, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelProcess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelBoilers
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelBoilers As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.FuelBoilers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.FuelBoilers, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelBoilers)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelOther As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BmMechanicalMetadata.ColumnNames.FuelOther)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BmMechanicalMetadata.ColumnNames.FuelOther, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FuelComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FuelComments As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.FuelComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.FuelComments, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.OtherMechanicalComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherMechanicalComments As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.OtherMechanicalComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.OtherMechanicalComments, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.OtherMechanicalComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.MechanicalUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechanicalUser1 As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.MechanicalUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.MechanicalUser1, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.MechanicalUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.MechanicalUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechanicalUser2 As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.MechanicalUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.MechanicalUser2, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.MechanicalUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.MechanicalUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechanicalUser3 As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.MechanicalUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.MechanicalUser3, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.MechanicalUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.MechanicalUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechanicalUser4 As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.MechanicalUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.MechanicalUser4, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.MechanicalUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BmMechanicalMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BmMechanicalMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-Boiler03-Mechanical.OtherMechanicalMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherMechanicalMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BmMechanicalMetadata.ColumnNames.OtherMechanicalMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BmMechanicalMetadata.ColumnNames.OtherMechanicalMajorExp, value) Then
					OnPropertyChanged(BmMechanicalMetadata.PropertyNames.OtherMechanicalMajorExp)
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
												
						Case "CompMajorExp"
							Me.str().CompMajorExp = CType(value, string)
												
						Case "CompAdeqCap"
							Me.str().CompAdeqCap = CType(value, string)
												
						Case "CompNo"
							Me.str().CompNo = CType(value, string)
												
						Case "CompRental"
							Me.str().CompRental = CType(value, string)
												
						Case "CompSpares"
							Me.str().CompSpares = CType(value, string)
												
						Case "CompProcess"
							Me.str().CompProcess = CType(value, string)
												
						Case "CompInstruments"
							Me.str().CompInstruments = CType(value, string)
												
						Case "CompGeneral"
							Me.str().CompGeneral = CType(value, string)
												
						Case "CompOther"
							Me.str().CompOther = CType(value, string)
												
						Case "CompComments"
							Me.str().CompComments = CType(value, string)
												
						Case "RefrigMajorExp"
							Me.str().RefrigMajorExp = CType(value, string)
												
						Case "RefrigAdeqCap"
							Me.str().RefrigAdeqCap = CType(value, string)
												
						Case "RefrigProcess"
							Me.str().RefrigProcess = CType(value, string)
												
						Case "RefrigComfort"
							Me.str().RefrigComfort = CType(value, string)
												
						Case "RefrigSpares"
							Me.str().RefrigSpares = CType(value, string)
												
						Case "RefrigRental"
							Me.str().RefrigRental = CType(value, string)
												
						Case "RefrigProcessType"
							Me.str().RefrigProcessType = CType(value, string)
												
						Case "RefrigComfortType"
							Me.str().RefrigComfortType = CType(value, string)
												
						Case "RefrigProcessNo"
							Me.str().RefrigProcessNo = CType(value, string)
												
						Case "RefrigComfortNo"
							Me.str().RefrigComfortNo = CType(value, string)
												
						Case "RefrigComments"
							Me.str().RefrigComments = CType(value, string)
												
						Case "WaterMajorExp"
							Me.str().WaterMajorExp = CType(value, string)
												
						Case "WaterAdeqCap"
							Me.str().WaterAdeqCap = CType(value, string)
												
						Case "WaterPrimary"
							Me.str().WaterPrimary = CType(value, string)
												
						Case "WaterSecondary"
							Me.str().WaterSecondary = CType(value, string)
												
						Case "WaterProcess"
							Me.str().WaterProcess = CType(value, string)
												
						Case "WaterCooling"
							Me.str().WaterCooling = CType(value, string)
												
						Case "WaterBoilers"
							Me.str().WaterBoilers = CType(value, string)
												
						Case "WaterGeneral"
							Me.str().WaterGeneral = CType(value, string)
												
						Case "WaterReserveCap"
							Me.str().WaterReserveCap = CType(value, string)
												
						Case "WaterComments"
							Me.str().WaterComments = CType(value, string)
												
						Case "CoolingMajorExp"
							Me.str().CoolingMajorExp = CType(value, string)
												
						Case "CoolingAdeqCap"
							Me.str().CoolingAdeqCap = CType(value, string)
												
						Case "CoolingProcess"
							Me.str().CoolingProcess = CType(value, string)
												
						Case "CoolingEquipment"
							Me.str().CoolingEquipment = CType(value, string)
												
						Case "CoolingNo"
							Me.str().CoolingNo = CType(value, string)
												
						Case "CoolingPumps"
							Me.str().CoolingPumps = CType(value, string)
												
						Case "CoolingReserve"
							Me.str().CoolingReserve = CType(value, string)
												
						Case "CoolingComments"
							Me.str().CoolingComments = CType(value, string)
												
						Case "FuelMajorExp"
							Me.str().FuelMajorExp = CType(value, string)
												
						Case "FuelAdeqCap"
							Me.str().FuelAdeqCap = CType(value, string)
												
						Case "FuelPrimarySource"
							Me.str().FuelPrimarySource = CType(value, string)
												
						Case "FuelSecondarySource"
							Me.str().FuelSecondarySource = CType(value, string)
												
						Case "FuelSupplierNo"
							Me.str().FuelSupplierNo = CType(value, string)
												
						Case "FuelInventory"
							Me.str().FuelInventory = CType(value, string)
												
						Case "FuelProcess"
							Me.str().FuelProcess = CType(value, string)
												
						Case "FuelBoilers"
							Me.str().FuelBoilers = CType(value, string)
												
						Case "FuelOther"
							Me.str().FuelOther = CType(value, string)
												
						Case "FuelComments"
							Me.str().FuelComments = CType(value, string)
												
						Case "OtherMechanicalComments"
							Me.str().OtherMechanicalComments = CType(value, string)
												
						Case "MechanicalUser1"
							Me.str().MechanicalUser1 = CType(value, string)
												
						Case "MechanicalUser2"
							Me.str().MechanicalUser2 = CType(value, string)
												
						Case "MechanicalUser3"
							Me.str().MechanicalUser3 = CType(value, string)
												
						Case "MechanicalUser4"
							Me.str().MechanicalUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "OtherMechanicalMajorExp"
							Me.str().OtherMechanicalMajorExp = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "CompNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CompNo = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompNo)
							End If
						
						Case "CompProcess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CompProcess = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompProcess)
							End If
						
						Case "CompInstruments"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CompInstruments = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompInstruments)
							End If
						
						Case "CompGeneral"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CompGeneral = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompGeneral)
							End If
						
						Case "CompOther"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CompOther = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CompOther)
							End If
						
						Case "RefrigProcess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.RefrigProcess = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigProcess)
							End If
						
						Case "RefrigComfort"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.RefrigComfort = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigComfort)
							End If
						
						Case "RefrigProcessNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RefrigProcessNo = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigProcessNo)
							End If
						
						Case "RefrigComfortNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RefrigComfortNo = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.RefrigComfortNo)
							End If
						
						Case "WaterProcess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.WaterProcess = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterProcess)
							End If
						
						Case "WaterCooling"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.WaterCooling = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterCooling)
							End If
						
						Case "WaterBoilers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.WaterBoilers = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterBoilers)
							End If
						
						Case "WaterGeneral"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.WaterGeneral = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.WaterGeneral)
							End If
						
						Case "CoolingProcess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CoolingProcess = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingProcess)
							End If
						
						Case "CoolingEquipment"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CoolingEquipment = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingEquipment)
							End If
						
						Case "CoolingNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CoolingNo = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.CoolingNo)
							End If
						
						Case "FuelSupplierNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FuelSupplierNo = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelSupplierNo)
							End If
						
						Case "FuelInventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FuelInventory = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelInventory)
							End If
						
						Case "FuelProcess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FuelProcess = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelProcess)
							End If
						
						Case "FuelBoilers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FuelBoilers = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelBoilers)
							End If
						
						Case "FuelOther"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FuelOther = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FuelOther)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BmMechanicalMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBmMechanical)
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
		  	
			Public Property CompMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.CompMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompMajorExp = Nothing
					Else
						entity.CompMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.CompAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompAdeqCap = Nothing
					Else
						entity.CompAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CompNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompNo = Nothing
					Else
						entity.CompNo = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompRental As System.String 
				Get
					Dim data_ As System.String = entity.CompRental
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompRental = Nothing
					Else
						entity.CompRental = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompSpares As System.String 
				Get
					Dim data_ As System.String = entity.CompSpares
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompSpares = Nothing
					Else
						entity.CompSpares = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompProcess As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CompProcess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompProcess = Nothing
					Else
						entity.CompProcess = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompInstruments As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CompInstruments
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompInstruments = Nothing
					Else
						entity.CompInstruments = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompGeneral As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CompGeneral
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompGeneral = Nothing
					Else
						entity.CompGeneral = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompOther As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CompOther
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompOther = Nothing
					Else
						entity.CompOther = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompComments As System.String 
				Get
					Dim data_ As System.String = entity.CompComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompComments = Nothing
					Else
						entity.CompComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.RefrigMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigMajorExp = Nothing
					Else
						entity.RefrigMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.RefrigAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigAdeqCap = Nothing
					Else
						entity.RefrigAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigProcess As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.RefrigProcess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigProcess = Nothing
					Else
						entity.RefrigProcess = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigComfort As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.RefrigComfort
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigComfort = Nothing
					Else
						entity.RefrigComfort = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigSpares As System.String 
				Get
					Dim data_ As System.String = entity.RefrigSpares
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigSpares = Nothing
					Else
						entity.RefrigSpares = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigRental As System.String 
				Get
					Dim data_ As System.String = entity.RefrigRental
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigRental = Nothing
					Else
						entity.RefrigRental = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigProcessType As System.String 
				Get
					Dim data_ As System.String = entity.RefrigProcessType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigProcessType = Nothing
					Else
						entity.RefrigProcessType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigComfortType As System.String 
				Get
					Dim data_ As System.String = entity.RefrigComfortType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigComfortType = Nothing
					Else
						entity.RefrigComfortType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigProcessNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RefrigProcessNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigProcessNo = Nothing
					Else
						entity.RefrigProcessNo = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigComfortNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RefrigComfortNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigComfortNo = Nothing
					Else
						entity.RefrigComfortNo = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RefrigComments As System.String 
				Get
					Dim data_ As System.String = entity.RefrigComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RefrigComments = Nothing
					Else
						entity.RefrigComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.WaterMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterMajorExp = Nothing
					Else
						entity.WaterMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.WaterAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterAdeqCap = Nothing
					Else
						entity.WaterAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterPrimary As System.String 
				Get
					Dim data_ As System.String = entity.WaterPrimary
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterPrimary = Nothing
					Else
						entity.WaterPrimary = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterSecondary As System.String 
				Get
					Dim data_ As System.String = entity.WaterSecondary
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterSecondary = Nothing
					Else
						entity.WaterSecondary = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterProcess As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.WaterProcess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterProcess = Nothing
					Else
						entity.WaterProcess = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterCooling As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.WaterCooling
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterCooling = Nothing
					Else
						entity.WaterCooling = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterBoilers As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.WaterBoilers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterBoilers = Nothing
					Else
						entity.WaterBoilers = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterGeneral As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.WaterGeneral
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterGeneral = Nothing
					Else
						entity.WaterGeneral = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterReserveCap As System.String 
				Get
					Dim data_ As System.String = entity.WaterReserveCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterReserveCap = Nothing
					Else
						entity.WaterReserveCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WaterComments As System.String 
				Get
					Dim data_ As System.String = entity.WaterComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WaterComments = Nothing
					Else
						entity.WaterComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.CoolingMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingMajorExp = Nothing
					Else
						entity.CoolingMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.CoolingAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingAdeqCap = Nothing
					Else
						entity.CoolingAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingProcess As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CoolingProcess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingProcess = Nothing
					Else
						entity.CoolingProcess = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingEquipment As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CoolingEquipment
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingEquipment = Nothing
					Else
						entity.CoolingEquipment = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CoolingNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingNo = Nothing
					Else
						entity.CoolingNo = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingPumps As System.String 
				Get
					Dim data_ As System.String = entity.CoolingPumps
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingPumps = Nothing
					Else
						entity.CoolingPumps = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingReserve As System.String 
				Get
					Dim data_ As System.String = entity.CoolingReserve
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingReserve = Nothing
					Else
						entity.CoolingReserve = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CoolingComments As System.String 
				Get
					Dim data_ As System.String = entity.CoolingComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CoolingComments = Nothing
					Else
						entity.CoolingComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.FuelMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelMajorExp = Nothing
					Else
						entity.FuelMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelAdeqCap As System.String 
				Get
					Dim data_ As System.String = entity.FuelAdeqCap
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelAdeqCap = Nothing
					Else
						entity.FuelAdeqCap = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelPrimarySource As System.String 
				Get
					Dim data_ As System.String = entity.FuelPrimarySource
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelPrimarySource = Nothing
					Else
						entity.FuelPrimarySource = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelSecondarySource As System.String 
				Get
					Dim data_ As System.String = entity.FuelSecondarySource
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelSecondarySource = Nothing
					Else
						entity.FuelSecondarySource = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelSupplierNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FuelSupplierNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelSupplierNo = Nothing
					Else
						entity.FuelSupplierNo = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelInventory As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FuelInventory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelInventory = Nothing
					Else
						entity.FuelInventory = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelProcess As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FuelProcess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelProcess = Nothing
					Else
						entity.FuelProcess = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelBoilers As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FuelBoilers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelBoilers = Nothing
					Else
						entity.FuelBoilers = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelOther As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FuelOther
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelOther = Nothing
					Else
						entity.FuelOther = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property FuelComments As System.String 
				Get
					Dim data_ As System.String = entity.FuelComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FuelComments = Nothing
					Else
						entity.FuelComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherMechanicalComments As System.String 
				Get
					Dim data_ As System.String = entity.OtherMechanicalComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherMechanicalComments = Nothing
					Else
						entity.OtherMechanicalComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechanicalUser1 As System.String 
				Get
					Dim data_ As System.String = entity.MechanicalUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechanicalUser1 = Nothing
					Else
						entity.MechanicalUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechanicalUser2 As System.String 
				Get
					Dim data_ As System.String = entity.MechanicalUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechanicalUser2 = Nothing
					Else
						entity.MechanicalUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechanicalUser3 As System.String 
				Get
					Dim data_ As System.String = entity.MechanicalUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechanicalUser3 = Nothing
					Else
						entity.MechanicalUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechanicalUser4 As System.String 
				Get
					Dim data_ As System.String = entity.MechanicalUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechanicalUser4 = Nothing
					Else
						entity.MechanicalUser4 = Convert.ToString(Value)
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
		  	
			Public Property OtherMechanicalMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.OtherMechanicalMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherMechanicalMajorExp = Nothing
					Else
						entity.OtherMechanicalMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBmMechanical
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmMechanicalMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BmMechanicalQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmMechanicalQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BmMechanicalQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BmMechanicalQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BmMechanicalQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBmMechanicalCollection
		Inherits esEntityCollection(Of BmMechanical)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BmMechanicalMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BmMechanicalCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BmMechanicalQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BmMechanicalQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BmMechanicalQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BmMechanicalQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BmMechanicalQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BmMechanicalQuery))
		End Sub
		
		#End Region
						
		Private m_query As BmMechanicalQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBmMechanicalQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BmMechanicalMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "CompMajorExp" 
					Return Me.CompMajorExp
				Case "CompAdeqCap" 
					Return Me.CompAdeqCap
				Case "CompNo" 
					Return Me.CompNo
				Case "CompRental" 
					Return Me.CompRental
				Case "CompSpares" 
					Return Me.CompSpares
				Case "CompProcess" 
					Return Me.CompProcess
				Case "CompInstruments" 
					Return Me.CompInstruments
				Case "CompGeneral" 
					Return Me.CompGeneral
				Case "CompOther" 
					Return Me.CompOther
				Case "CompComments" 
					Return Me.CompComments
				Case "RefrigMajorExp" 
					Return Me.RefrigMajorExp
				Case "RefrigAdeqCap" 
					Return Me.RefrigAdeqCap
				Case "RefrigProcess" 
					Return Me.RefrigProcess
				Case "RefrigComfort" 
					Return Me.RefrigComfort
				Case "RefrigSpares" 
					Return Me.RefrigSpares
				Case "RefrigRental" 
					Return Me.RefrigRental
				Case "RefrigProcessType" 
					Return Me.RefrigProcessType
				Case "RefrigComfortType" 
					Return Me.RefrigComfortType
				Case "RefrigProcessNo" 
					Return Me.RefrigProcessNo
				Case "RefrigComfortNo" 
					Return Me.RefrigComfortNo
				Case "RefrigComments" 
					Return Me.RefrigComments
				Case "WaterMajorExp" 
					Return Me.WaterMajorExp
				Case "WaterAdeqCap" 
					Return Me.WaterAdeqCap
				Case "WaterPrimary" 
					Return Me.WaterPrimary
				Case "WaterSecondary" 
					Return Me.WaterSecondary
				Case "WaterProcess" 
					Return Me.WaterProcess
				Case "WaterCooling" 
					Return Me.WaterCooling
				Case "WaterBoilers" 
					Return Me.WaterBoilers
				Case "WaterGeneral" 
					Return Me.WaterGeneral
				Case "WaterReserveCap" 
					Return Me.WaterReserveCap
				Case "WaterComments" 
					Return Me.WaterComments
				Case "CoolingMajorExp" 
					Return Me.CoolingMajorExp
				Case "CoolingAdeqCap" 
					Return Me.CoolingAdeqCap
				Case "CoolingProcess" 
					Return Me.CoolingProcess
				Case "CoolingEquipment" 
					Return Me.CoolingEquipment
				Case "CoolingNo" 
					Return Me.CoolingNo
				Case "CoolingPumps" 
					Return Me.CoolingPumps
				Case "CoolingReserve" 
					Return Me.CoolingReserve
				Case "CoolingComments" 
					Return Me.CoolingComments
				Case "FuelMajorExp" 
					Return Me.FuelMajorExp
				Case "FuelAdeqCap" 
					Return Me.FuelAdeqCap
				Case "FuelPrimarySource" 
					Return Me.FuelPrimarySource
				Case "FuelSecondarySource" 
					Return Me.FuelSecondarySource
				Case "FuelSupplierNo" 
					Return Me.FuelSupplierNo
				Case "FuelInventory" 
					Return Me.FuelInventory
				Case "FuelProcess" 
					Return Me.FuelProcess
				Case "FuelBoilers" 
					Return Me.FuelBoilers
				Case "FuelOther" 
					Return Me.FuelOther
				Case "FuelComments" 
					Return Me.FuelComments
				Case "OtherMechanicalComments" 
					Return Me.OtherMechanicalComments
				Case "MechanicalUser1" 
					Return Me.MechanicalUser1
				Case "MechanicalUser2" 
					Return Me.MechanicalUser2
				Case "MechanicalUser3" 
					Return Me.MechanicalUser3
				Case "MechanicalUser4" 
					Return Me.MechanicalUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "OtherMechanicalMajorExp" 
					Return Me.OtherMechanicalMajorExp
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CompRental As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompRental, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompSpares As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompSpares, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompProcess As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompProcess, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CompInstruments As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompInstruments, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CompGeneral As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompGeneral, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CompOther As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompOther, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CompComments As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CompComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigProcess As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigProcess, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigComfort As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigComfort, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigSpares As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigSpares, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigRental As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigRental, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigProcessType As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigProcessType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigComfortType As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigComfortType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigProcessNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigProcessNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigComfortNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigComfortNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RefrigComments As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.RefrigComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterPrimary As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterPrimary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterSecondary As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterSecondary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterProcess As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterProcess, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property WaterCooling As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterCooling, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property WaterBoilers As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterBoilers, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property WaterGeneral As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterGeneral, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property WaterReserveCap As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterReserveCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WaterComments As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.WaterComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CoolingMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CoolingAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingProcess As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CoolingProcess, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingEquipment As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CoolingEquipment, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CoolingNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingPumps As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CoolingPumps, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingReserve As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CoolingReserve, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CoolingComments As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.CoolingComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelMajorExp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelAdeqCap As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelAdeqCap, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelPrimarySource As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelPrimarySource, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelSecondarySource As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelSecondarySource, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FuelSupplierNo As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelSupplierNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FuelInventory As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelInventory, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FuelProcess As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelProcess, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property FuelBoilers As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelBoilers, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property FuelOther As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelOther, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property FuelComments As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FuelComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherMechanicalComments As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.OtherMechanicalComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechanicalUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.MechanicalUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechanicalUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.MechanicalUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechanicalUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.MechanicalUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechanicalUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.MechanicalUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property OtherMechanicalMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BmMechanicalMetadata.ColumnNames.OtherMechanicalMajorExp, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BmMechanical 
		Inherits esBmMechanical
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BmMechanicalMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompMajorExp, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompAdeqCap, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompNo, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompNo
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompRental, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompRental
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompSpares, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompSpares
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompProcess, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompProcess
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompInstruments, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompInstruments
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompGeneral, 8, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompGeneral
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompOther, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompOther
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CompComments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CompComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigMajorExp, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigAdeqCap, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigProcess, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigProcess
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigComfort, 14, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigComfort
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigSpares, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigSpares
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigRental, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigRental
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigProcessType, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigProcessType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigComfortType, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigComfortType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigProcessNo, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigProcessNo
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigComfortNo, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigComfortNo
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.RefrigComments, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.RefrigComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterMajorExp, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterAdeqCap, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterPrimary, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterPrimary
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterSecondary, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterSecondary
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterProcess, 26, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterProcess
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterCooling, 27, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterCooling
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterBoilers, 28, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterBoilers
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterGeneral, 29, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterGeneral
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterReserveCap, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterReserveCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.WaterComments, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.WaterComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CoolingMajorExp, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CoolingMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CoolingAdeqCap, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CoolingAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CoolingProcess, 34, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CoolingProcess
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CoolingEquipment, 35, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CoolingEquipment
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CoolingNo, 36, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CoolingNo
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CoolingPumps, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CoolingPumps
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CoolingReserve, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CoolingReserve
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.CoolingComments, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.CoolingComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelMajorExp, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelMajorExp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelAdeqCap, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelAdeqCap
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelPrimarySource, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelPrimarySource
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelSecondarySource, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelSecondarySource
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelSupplierNo, 44, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelSupplierNo
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelInventory, 45, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelInventory
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelProcess, 46, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelProcess
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelBoilers, 47, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelBoilers
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelOther, 48, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelOther
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FuelComments, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FuelComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.OtherMechanicalComments, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.OtherMechanicalComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.MechanicalUser1, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.MechanicalUser1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.MechanicalUser2, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.MechanicalUser2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.MechanicalUser3, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.MechanicalUser3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.MechanicalUser4, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.MechanicalUser4
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.FilePrefix, 55, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BmMechanicalMetadata.ColumnNames.OtherMechanicalMajorExp, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = BmMechanicalMetadata.PropertyNames.OtherMechanicalMajorExp
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BmMechanicalMetadata
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
			 Public Const CompMajorExp As String = "CompMajorExp"
			 Public Const CompAdeqCap As String = "CompAdeqCap"
			 Public Const CompNo As String = "CompNo"
			 Public Const CompRental As String = "CompRental"
			 Public Const CompSpares As String = "CompSpares"
			 Public Const CompProcess As String = "CompProcess"
			 Public Const CompInstruments As String = "CompInstruments"
			 Public Const CompGeneral As String = "CompGeneral"
			 Public Const CompOther As String = "CompOther"
			 Public Const CompComments As String = "CompComments"
			 Public Const RefrigMajorExp As String = "RefrigMajorExp"
			 Public Const RefrigAdeqCap As String = "RefrigAdeqCap"
			 Public Const RefrigProcess As String = "RefrigProcess"
			 Public Const RefrigComfort As String = "RefrigComfort"
			 Public Const RefrigSpares As String = "RefrigSpares"
			 Public Const RefrigRental As String = "RefrigRental"
			 Public Const RefrigProcessType As String = "RefrigProcessType"
			 Public Const RefrigComfortType As String = "RefrigComfortType"
			 Public Const RefrigProcessNo As String = "RefrigProcessNo"
			 Public Const RefrigComfortNo As String = "RefrigComfortNo"
			 Public Const RefrigComments As String = "RefrigComments"
			 Public Const WaterMajorExp As String = "WaterMajorExp"
			 Public Const WaterAdeqCap As String = "WaterAdeqCap"
			 Public Const WaterPrimary As String = "WaterPrimary"
			 Public Const WaterSecondary As String = "WaterSecondary"
			 Public Const WaterProcess As String = "WaterProcess"
			 Public Const WaterCooling As String = "WaterCooling"
			 Public Const WaterBoilers As String = "WaterBoilers"
			 Public Const WaterGeneral As String = "WaterGeneral"
			 Public Const WaterReserveCap As String = "WaterReserveCap"
			 Public Const WaterComments As String = "WaterComments"
			 Public Const CoolingMajorExp As String = "CoolingMajorExp"
			 Public Const CoolingAdeqCap As String = "CoolingAdeqCap"
			 Public Const CoolingProcess As String = "CoolingProcess"
			 Public Const CoolingEquipment As String = "CoolingEquipment"
			 Public Const CoolingNo As String = "CoolingNo"
			 Public Const CoolingPumps As String = "CoolingPumps"
			 Public Const CoolingReserve As String = "CoolingReserve"
			 Public Const CoolingComments As String = "CoolingComments"
			 Public Const FuelMajorExp As String = "FuelMajorExp"
			 Public Const FuelAdeqCap As String = "FuelAdeqCap"
			 Public Const FuelPrimarySource As String = "FuelPrimarySource"
			 Public Const FuelSecondarySource As String = "FuelSecondarySource"
			 Public Const FuelSupplierNo As String = "FuelSupplierNo"
			 Public Const FuelInventory As String = "FuelInventory"
			 Public Const FuelProcess As String = "FuelProcess"
			 Public Const FuelBoilers As String = "FuelBoilers"
			 Public Const FuelOther As String = "FuelOther"
			 Public Const FuelComments As String = "FuelComments"
			 Public Const OtherMechanicalComments As String = "OtherMechanicalComments"
			 Public Const MechanicalUser1 As String = "MechanicalUser1"
			 Public Const MechanicalUser2 As String = "MechanicalUser2"
			 Public Const MechanicalUser3 As String = "MechanicalUser3"
			 Public Const MechanicalUser4 As String = "MechanicalUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const OtherMechanicalMajorExp As String = "OtherMechanicalMajorExp"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const CompMajorExp As String = "CompMajorExp"
			 Public Const CompAdeqCap As String = "CompAdeqCap"
			 Public Const CompNo As String = "CompNo"
			 Public Const CompRental As String = "CompRental"
			 Public Const CompSpares As String = "CompSpares"
			 Public Const CompProcess As String = "CompProcess"
			 Public Const CompInstruments As String = "CompInstruments"
			 Public Const CompGeneral As String = "CompGeneral"
			 Public Const CompOther As String = "CompOther"
			 Public Const CompComments As String = "CompComments"
			 Public Const RefrigMajorExp As String = "RefrigMajorExp"
			 Public Const RefrigAdeqCap As String = "RefrigAdeqCap"
			 Public Const RefrigProcess As String = "RefrigProcess"
			 Public Const RefrigComfort As String = "RefrigComfort"
			 Public Const RefrigSpares As String = "RefrigSpares"
			 Public Const RefrigRental As String = "RefrigRental"
			 Public Const RefrigProcessType As String = "RefrigProcessType"
			 Public Const RefrigComfortType As String = "RefrigComfortType"
			 Public Const RefrigProcessNo As String = "RefrigProcessNo"
			 Public Const RefrigComfortNo As String = "RefrigComfortNo"
			 Public Const RefrigComments As String = "RefrigComments"
			 Public Const WaterMajorExp As String = "WaterMajorExp"
			 Public Const WaterAdeqCap As String = "WaterAdeqCap"
			 Public Const WaterPrimary As String = "WaterPrimary"
			 Public Const WaterSecondary As String = "WaterSecondary"
			 Public Const WaterProcess As String = "WaterProcess"
			 Public Const WaterCooling As String = "WaterCooling"
			 Public Const WaterBoilers As String = "WaterBoilers"
			 Public Const WaterGeneral As String = "WaterGeneral"
			 Public Const WaterReserveCap As String = "WaterReserveCap"
			 Public Const WaterComments As String = "WaterComments"
			 Public Const CoolingMajorExp As String = "CoolingMajorExp"
			 Public Const CoolingAdeqCap As String = "CoolingAdeqCap"
			 Public Const CoolingProcess As String = "CoolingProcess"
			 Public Const CoolingEquipment As String = "CoolingEquipment"
			 Public Const CoolingNo As String = "CoolingNo"
			 Public Const CoolingPumps As String = "CoolingPumps"
			 Public Const CoolingReserve As String = "CoolingReserve"
			 Public Const CoolingComments As String = "CoolingComments"
			 Public Const FuelMajorExp As String = "FuelMajorExp"
			 Public Const FuelAdeqCap As String = "FuelAdeqCap"
			 Public Const FuelPrimarySource As String = "FuelPrimarySource"
			 Public Const FuelSecondarySource As String = "FuelSecondarySource"
			 Public Const FuelSupplierNo As String = "FuelSupplierNo"
			 Public Const FuelInventory As String = "FuelInventory"
			 Public Const FuelProcess As String = "FuelProcess"
			 Public Const FuelBoilers As String = "FuelBoilers"
			 Public Const FuelOther As String = "FuelOther"
			 Public Const FuelComments As String = "FuelComments"
			 Public Const OtherMechanicalComments As String = "OtherMechanicalComments"
			 Public Const MechanicalUser1 As String = "MechanicalUser1"
			 Public Const MechanicalUser2 As String = "MechanicalUser2"
			 Public Const MechanicalUser3 As String = "MechanicalUser3"
			 Public Const MechanicalUser4 As String = "MechanicalUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const OtherMechanicalMajorExp As String = "OtherMechanicalMajorExp"
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
			SyncLock GetType(BmMechanicalMetadata)
			
				If BmMechanicalMetadata.mapDelegates Is Nothing Then
					BmMechanicalMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BmMechanicalMetadata._meta Is Nothing Then
					BmMechanicalMetadata._meta = New BmMechanicalMetadata()
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
				meta.AddTypeMap("CompMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CompRental", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompSpares", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompProcess", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CompInstruments", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CompGeneral", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CompOther", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CompComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigProcess", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("RefrigComfort", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("RefrigSpares", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigRental", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigProcessType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigComfortType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RefrigProcessNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RefrigComfortNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RefrigComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterPrimary", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterSecondary", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterProcess", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("WaterCooling", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("WaterBoilers", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("WaterGeneral", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("WaterReserveCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WaterComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CoolingMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CoolingAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CoolingProcess", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CoolingEquipment", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CoolingNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CoolingPumps", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CoolingReserve", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CoolingComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FuelMajorExp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FuelAdeqCap", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FuelPrimarySource", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FuelSecondarySource", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FuelSupplierNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FuelInventory", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FuelProcess", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("FuelBoilers", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("FuelOther", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("FuelComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OtherMechanicalComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechanicalUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechanicalUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechanicalUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechanicalUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("OtherMechanicalMajorExp", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
                meta.Source = "Cope-BMMechanical"
                meta.Destination = "Cope-BMMechanical"
				
				meta.spInsert = "proc_Cope-Boiler03-MechanicalInsert"
				meta.spUpdate = "proc_Cope-Boiler03-MechanicalUpdate"
				meta.spDelete = "proc_Cope-Boiler03-MechanicalDelete"
				meta.spLoadAll = "proc_Cope-Boiler03-MechanicalLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-Boiler03-MechanicalLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BmMechanicalMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
