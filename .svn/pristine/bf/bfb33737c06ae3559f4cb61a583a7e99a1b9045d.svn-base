
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
	' Encapsulates the 'Cope-BMElectrical' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMElectrical))> _
	<XmlType("BMElectrical")> _	
	Partial Public Class BMElectrical 
		Inherits esBMElectrical
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMElectrical()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BMElectrical()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMElectrical()
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
	<XmlType("BMElectricalCollection")> _
	Partial Public Class BMElectricalCollection
		Inherits esBMElectricalCollection
		Implements IEnumerable(Of BMElectrical)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BMElectrical
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMElectrical))> _
		Public Class BMElectricalCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMElectricalCollection)
			
			Public Shared Widening Operator CType(packet As BMElectricalCollectionWCFPacket) As BMElectricalCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMElectricalCollection) As BMElectricalCollectionWCFPacket
				Return New BMElectricalCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMElectricalQuery 
		Inherits esBMElectricalQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMElectricalQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMElectricalQuery) As String
			Return BMElectricalQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMElectricalQuery
			Return DirectCast(BMElectricalQuery.SerializeHelper.FromXml(query, GetType(BMElectricalQuery)), BMElectricalQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMElectrical
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
		
			Dim query As New BMElectricalQuery()
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
		' Maps to Cope-BMElectrical.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.NoUtilityLines
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NoUtilityLines As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMElectricalMetadata.ColumnNames.NoUtilityLines)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMElectricalMetadata.ColumnNames.NoUtilityLines, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.NoUtilityLines)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.SupplyVoltage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SupplyVoltage As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.SupplyVoltage)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.SupplyVoltage, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.SupplyVoltage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.PowerDemand
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PowerDemand As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.PowerDemand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.PowerDemand, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.PowerDemand)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformRegulating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformRegulating As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMElectricalMetadata.ColumnNames.XformRegulating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMElectricalMetadata.ColumnNames.XformRegulating, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformRegulating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformArcFurnace
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformArcFurnace As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMElectricalMetadata.ColumnNames.XformArcFurnace)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMElectricalMetadata.ColumnNames.XformArcFurnace, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformArcFurnace)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformRectifying
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformRectifying As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMElectricalMetadata.ColumnNames.XformRectifying)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMElectricalMetadata.ColumnNames.XformRectifying, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformRectifying)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformPhaseShifting
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformPhaseShifting As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMElectricalMetadata.ColumnNames.XformPhaseShifting)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMElectricalMetadata.ColumnNames.XformPhaseShifting, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformPhaseShifting)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformOther As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMElectricalMetadata.ColumnNames.XformOther)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMElectricalMetadata.ColumnNames.XformOther, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformSparePrimary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformSparePrimary As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.XformSparePrimary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.XformSparePrimary, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformSparePrimary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformSpareDist
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformSpareDist As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.XformSpareDist)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.XformSpareDist, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformSpareDist)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformRental
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformRental As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.XformRental)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.XformRental, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformRental)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformBreaker
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformBreaker As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.XformBreaker)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.XformBreaker, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformBreaker)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.XformPCB
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property XformPCB As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.XformPCB)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.XformPCB, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformPCB)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.ElectComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectComments As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.ElectComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.ElectComments, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.ElectComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.ElectricalUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalUser1 As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.ElectricalUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.ElectricalUser1, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.ElectricalUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.ElectricalUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalUser2 As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.ElectricalUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.ElectricalUser2, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.ElectricalUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.ElectricalUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalUser3 As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.ElectricalUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.ElectricalUser3, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.ElectricalUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.ElectricalUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalUser4 As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.ElectricalUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.ElectricalUser4, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.ElectricalUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BMElectricalMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BMElectricalMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMElectrical.ElectricalMajorExp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalMajorExp As System.String
			Get
				Return MyBase.GetSystemString(BMElectricalMetadata.ColumnNames.ElectricalMajorExp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMElectricalMetadata.ColumnNames.ElectricalMajorExp, value) Then
					OnPropertyChanged(BMElectricalMetadata.PropertyNames.ElectricalMajorExp)
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
												
						Case "NoUtilityLines"
							Me.str().NoUtilityLines = CType(value, string)
												
						Case "SupplyVoltage"
							Me.str().SupplyVoltage = CType(value, string)
												
						Case "PowerDemand"
							Me.str().PowerDemand = CType(value, string)
												
						Case "XformRegulating"
							Me.str().XformRegulating = CType(value, string)
												
						Case "XformArcFurnace"
							Me.str().XformArcFurnace = CType(value, string)
												
						Case "XformRectifying"
							Me.str().XformRectifying = CType(value, string)
												
						Case "XformPhaseShifting"
							Me.str().XformPhaseShifting = CType(value, string)
												
						Case "XformOther"
							Me.str().XformOther = CType(value, string)
												
						Case "XformSparePrimary"
							Me.str().XformSparePrimary = CType(value, string)
												
						Case "XformSpareDist"
							Me.str().XformSpareDist = CType(value, string)
												
						Case "XformRental"
							Me.str().XformRental = CType(value, string)
												
						Case "XformBreaker"
							Me.str().XformBreaker = CType(value, string)
												
						Case "XformPCB"
							Me.str().XformPCB = CType(value, string)
												
						Case "ElectComments"
							Me.str().ElectComments = CType(value, string)
												
						Case "ElectricalUser1"
							Me.str().ElectricalUser1 = CType(value, string)
												
						Case "ElectricalUser2"
							Me.str().ElectricalUser2 = CType(value, string)
												
						Case "ElectricalUser3"
							Me.str().ElectricalUser3 = CType(value, string)
												
						Case "ElectricalUser4"
							Me.str().ElectricalUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "ElectricalMajorExp"
							Me.str().ElectricalMajorExp = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "NoUtilityLines"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NoUtilityLines = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMElectricalMetadata.PropertyNames.NoUtilityLines)
							End If
						
						Case "XformRegulating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.XformRegulating = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformRegulating)
							End If
						
						Case "XformArcFurnace"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.XformArcFurnace = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformArcFurnace)
							End If
						
						Case "XformRectifying"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.XformRectifying = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformRectifying)
							End If
						
						Case "XformPhaseShifting"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.XformPhaseShifting = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformPhaseShifting)
							End If
						
						Case "XformOther"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.XformOther = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMElectricalMetadata.PropertyNames.XformOther)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BMElectricalMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBMElectrical)
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
		  	
			Public Property NoUtilityLines As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NoUtilityLines
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoUtilityLines = Nothing
					Else
						entity.NoUtilityLines = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SupplyVoltage As System.String 
				Get
					Dim data_ As System.String = entity.SupplyVoltage
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SupplyVoltage = Nothing
					Else
						entity.SupplyVoltage = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PowerDemand As System.String 
				Get
					Dim data_ As System.String = entity.PowerDemand
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PowerDemand = Nothing
					Else
						entity.PowerDemand = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformRegulating As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.XformRegulating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformRegulating = Nothing
					Else
						entity.XformRegulating = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformArcFurnace As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.XformArcFurnace
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformArcFurnace = Nothing
					Else
						entity.XformArcFurnace = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformRectifying As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.XformRectifying
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformRectifying = Nothing
					Else
						entity.XformRectifying = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformPhaseShifting As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.XformPhaseShifting
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformPhaseShifting = Nothing
					Else
						entity.XformPhaseShifting = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformOther As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.XformOther
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformOther = Nothing
					Else
						entity.XformOther = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformSparePrimary As System.String 
				Get
					Dim data_ As System.String = entity.XformSparePrimary
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformSparePrimary = Nothing
					Else
						entity.XformSparePrimary = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformSpareDist As System.String 
				Get
					Dim data_ As System.String = entity.XformSpareDist
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformSpareDist = Nothing
					Else
						entity.XformSpareDist = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformRental As System.String 
				Get
					Dim data_ As System.String = entity.XformRental
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformRental = Nothing
					Else
						entity.XformRental = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformBreaker As System.String 
				Get
					Dim data_ As System.String = entity.XformBreaker
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformBreaker = Nothing
					Else
						entity.XformBreaker = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property XformPCB As System.String 
				Get
					Dim data_ As System.String = entity.XformPCB
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.XformPCB = Nothing
					Else
						entity.XformPCB = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectComments As System.String 
				Get
					Dim data_ As System.String = entity.ElectComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectComments = Nothing
					Else
						entity.ElectComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricalUser1 As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalUser1 = Nothing
					Else
						entity.ElectricalUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricalUser2 As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalUser2 = Nothing
					Else
						entity.ElectricalUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricalUser3 As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalUser3 = Nothing
					Else
						entity.ElectricalUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricalUser4 As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalUser4 = Nothing
					Else
						entity.ElectricalUser4 = Convert.ToString(Value)
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
		  	
			Public Property ElectricalMajorExp As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalMajorExp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalMajorExp = Nothing
					Else
						entity.ElectricalMajorExp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBMElectrical
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMElectricalMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMElectricalQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMElectricalQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMElectricalQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMElectricalQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMElectricalQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMElectricalCollection
		Inherits esEntityCollection(Of BMElectrical)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMElectricalMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMElectricalCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMElectricalQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMElectricalQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMElectricalQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMElectricalQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMElectricalQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMElectricalQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMElectricalQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMElectricalQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMElectricalMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "NoUtilityLines" 
					Return Me.NoUtilityLines
				Case "SupplyVoltage" 
					Return Me.SupplyVoltage
				Case "PowerDemand" 
					Return Me.PowerDemand
				Case "XformRegulating" 
					Return Me.XformRegulating
				Case "XformArcFurnace" 
					Return Me.XformArcFurnace
				Case "XformRectifying" 
					Return Me.XformRectifying
				Case "XformPhaseShifting" 
					Return Me.XformPhaseShifting
				Case "XformOther" 
					Return Me.XformOther
				Case "XformSparePrimary" 
					Return Me.XformSparePrimary
				Case "XformSpareDist" 
					Return Me.XformSpareDist
				Case "XformRental" 
					Return Me.XformRental
				Case "XformBreaker" 
					Return Me.XformBreaker
				Case "XformPCB" 
					Return Me.XformPCB
				Case "ElectComments" 
					Return Me.ElectComments
				Case "ElectricalUser1" 
					Return Me.ElectricalUser1
				Case "ElectricalUser2" 
					Return Me.ElectricalUser2
				Case "ElectricalUser3" 
					Return Me.ElectricalUser3
				Case "ElectricalUser4" 
					Return Me.ElectricalUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "ElectricalMajorExp" 
					Return Me.ElectricalMajorExp
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NoUtilityLines As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.NoUtilityLines, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SupplyVoltage As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.SupplyVoltage, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PowerDemand As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.PowerDemand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property XformRegulating As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformRegulating, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property XformArcFurnace As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformArcFurnace, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property XformRectifying As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformRectifying, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property XformPhaseShifting As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformPhaseShifting, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property XformOther As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformOther, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property XformSparePrimary As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformSparePrimary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property XformSpareDist As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformSpareDist, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property XformRental As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformRental, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property XformBreaker As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformBreaker, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property XformPCB As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.XformPCB, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.ElectComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.ElectricalUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.ElectricalUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.ElectricalUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.ElectricalUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalMajorExp As esQueryItem
			Get
				Return New esQueryItem(Me, BMElectricalMetadata.ColumnNames.ElectricalMajorExp, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMElectrical 
		Inherits esBMElectrical
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BMElectricalMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.NoUtilityLines, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.NoUtilityLines
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.SupplyVoltage, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.SupplyVoltage
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.PowerDemand, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.PowerDemand
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformRegulating, 4, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformRegulating
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformArcFurnace, 5, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformArcFurnace
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformRectifying, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformRectifying
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformPhaseShifting, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformPhaseShifting
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformOther, 8, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformOther
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformSparePrimary, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformSparePrimary
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformSpareDist, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformSpareDist
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformRental, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformRental
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformBreaker, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformBreaker
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.XformPCB, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.XformPCB
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.ElectComments, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.ElectComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.ElectricalUser1, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.ElectricalUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.ElectricalUser2, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.ElectricalUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.ElectricalUser3, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.ElectricalUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.ElectricalUser4, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.ElectricalUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.FilePrefix, 19, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMElectricalMetadata.ColumnNames.ElectricalMajorExp, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMElectricalMetadata.PropertyNames.ElectricalMajorExp
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMElectricalMetadata
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
			 Public Const NoUtilityLines As String = "NoUtilityLines"
			 Public Const SupplyVoltage As String = "SupplyVoltage"
			 Public Const PowerDemand As String = "PowerDemand"
			 Public Const XformRegulating As String = "XformRegulating"
			 Public Const XformArcFurnace As String = "XformArcFurnace"
			 Public Const XformRectifying As String = "XformRectifying"
			 Public Const XformPhaseShifting As String = "XformPhaseShifting"
			 Public Const XformOther As String = "XformOther"
			 Public Const XformSparePrimary As String = "XformSparePrimary"
			 Public Const XformSpareDist As String = "XformSpareDist"
			 Public Const XformRental As String = "XformRental"
			 Public Const XformBreaker As String = "XformBreaker"
			 Public Const XformPCB As String = "XformPCB"
			 Public Const ElectComments As String = "ElectComments"
			 Public Const ElectricalUser1 As String = "ElectricalUser1"
			 Public Const ElectricalUser2 As String = "ElectricalUser2"
			 Public Const ElectricalUser3 As String = "ElectricalUser3"
			 Public Const ElectricalUser4 As String = "ElectricalUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const ElectricalMajorExp As String = "ElectricalMajorExp"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const NoUtilityLines As String = "NoUtilityLines"
			 Public Const SupplyVoltage As String = "SupplyVoltage"
			 Public Const PowerDemand As String = "PowerDemand"
			 Public Const XformRegulating As String = "XformRegulating"
			 Public Const XformArcFurnace As String = "XformArcFurnace"
			 Public Const XformRectifying As String = "XformRectifying"
			 Public Const XformPhaseShifting As String = "XformPhaseShifting"
			 Public Const XformOther As String = "XformOther"
			 Public Const XformSparePrimary As String = "XformSparePrimary"
			 Public Const XformSpareDist As String = "XformSpareDist"
			 Public Const XformRental As String = "XformRental"
			 Public Const XformBreaker As String = "XformBreaker"
			 Public Const XformPCB As String = "XformPCB"
			 Public Const ElectComments As String = "ElectComments"
			 Public Const ElectricalUser1 As String = "ElectricalUser1"
			 Public Const ElectricalUser2 As String = "ElectricalUser2"
			 Public Const ElectricalUser3 As String = "ElectricalUser3"
			 Public Const ElectricalUser4 As String = "ElectricalUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const ElectricalMajorExp As String = "ElectricalMajorExp"
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
			SyncLock GetType(BMElectricalMetadata)
			
				If BMElectricalMetadata.mapDelegates Is Nothing Then
					BMElectricalMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMElectricalMetadata._meta Is Nothing Then
					BMElectricalMetadata._meta = New BMElectricalMetadata()
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
				meta.AddTypeMap("NoUtilityLines", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SupplyVoltage", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PowerDemand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("XformRegulating", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("XformArcFurnace", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("XformRectifying", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("XformPhaseShifting", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("XformOther", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("XformSparePrimary", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("XformSpareDist", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("XformRental", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("XformBreaker", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("XformPCB", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricalUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricalUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricalUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricalUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("ElectricalMajorExp", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-BMElectrical"
				meta.Destination = "Cope-BMElectrical"
				
				meta.spInsert = "proc_Cope-BMElectricalInsert"
				meta.spUpdate = "proc_Cope-BMElectricalUpdate"
				meta.spDelete = "proc_Cope-BMElectricalDelete"
				meta.spLoadAll = "proc_Cope-BMElectricalLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMElectricalLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMElectricalMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
