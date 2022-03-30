
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
	' Encapsulates the 'Cope-BMEPPMHeader' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMEPPMs))> _
	<XmlType("BMEPPMs")> _	
	Partial Public Class BMEPPMs 
		Inherits esBMEPPMs
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMEPPMs()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BMEPPMs()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMEPPMs()
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
	<XmlType("BMEPPMsCollection")> _
	Partial Public Class BMEPPMsCollection
		Inherits esBMEPPMsCollection
		Implements IEnumerable(Of BMEPPMs)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BMEPPMs
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMEPPMs))> _
		Public Class BMEPPMsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMEPPMsCollection)
			
			Public Shared Widening Operator CType(packet As BMEPPMsCollectionWCFPacket) As BMEPPMsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMEPPMsCollection) As BMEPPMsCollectionWCFPacket
				Return New BMEPPMsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMEPPMsQuery 
		Inherits esBMEPPMsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMEPPMsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMEPPMsQuery) As String
			Return BMEPPMsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMEPPMsQuery
			Return DirectCast(BMEPPMsQuery.SerializeHelper.FromXml(query, GetType(BMEPPMsQuery)), BMEPPMsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMEPPMs
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
		
			Dim query As New BMEPPMsQuery()
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
		' Maps to Cope-BMEPPMHeader.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecPreMaintAdequate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecPreMaintAdequate As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecPreMaintAdequate)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecPreMaintAdequate, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecPreMaintAdequate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecPreMaintCMMS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecPreMaintCMMS As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecPreMaintCMMS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecPreMaintCMMS, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecPreMaintCMMS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElectIR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectIR As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElectIR)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElectIR, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElectIR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecUltrasound
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecUltrasound As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecUltrasound)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecUltrasound, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecUltrasound)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecNETA
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecNETA As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecNETA)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecNETA, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecNETA)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecTranOil
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecTranOil As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecTranOil)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecTranOil, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecTranOil)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecMotor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecMotor As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecMotor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecMotor, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecMotor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecIEEE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecIEEE As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecIEEE)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecIEEE, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecIEEE)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecSwitch
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecSwitch As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecSwitch)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecSwitch, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecSwitch)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecOther As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecOther)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecOther, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecGRC
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecGRC As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecGRC)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecGRC, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecGRC)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecRelay
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecRelay As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecRelay)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecRelay, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecRelay)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecBestPractices
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecBestPractices As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecBestPractices)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecBestPractices, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecBestPractices)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecBattery
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecBattery As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecBattery)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecBattery, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecBattery)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecGrounding
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecGrounding As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElecGrounding)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElecGrounding, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecGrounding)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElecPerOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElecPerOther As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecPerOther)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(BMEPPMsMetadata.ColumnNames.ElecPerOther, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecPerOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElectMaintOtherComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectMaintOtherComments As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElectMaintOtherComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElectMaintOtherComments, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElectMaintOtherComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElectMaintSpecialComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectMaintSpecialComments As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElectMaintSpecialComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElectMaintSpecialComments, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElectMaintSpecialComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.SparesMaintained
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesMaintained As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.SparesMaintained)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.SparesMaintained, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.SparesMaintained)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.SparesComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SparesComments As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.SparesComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.SparesComments, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.SparesComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElectricalSpareUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalSpareUser1 As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser1, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElectricalSpareUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElectricalSpareUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalSpareUser2 As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser2, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElectricalSpareUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElectricalSpareUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalSpareUser3 As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser3, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElectricalSpareUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.ElectricalSpareUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ElectricalSpareUser4 As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser4, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElectricalSpareUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BMEPPMsMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BMEPPMsMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.LastArcFlashInspDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastArcFlashInspDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMEPPMsMetadata.ColumnNames.LastArcFlashInspDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMEPPMsMetadata.ColumnNames.LastArcFlashInspDate, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.LastArcFlashInspDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.LastArcFlashInspOrg
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastArcFlashInspOrg As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.LastArcFlashInspOrg)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.LastArcFlashInspOrg, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.LastArcFlashInspOrg)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMEPPMHeader.LastArcFlashComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastArcFlashComments As System.String
			Get
				Return MyBase.GetSystemString(BMEPPMsMetadata.ColumnNames.LastArcFlashComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMEPPMsMetadata.ColumnNames.LastArcFlashComments, value) Then
					OnPropertyChanged(BMEPPMsMetadata.PropertyNames.LastArcFlashComments)
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
												
						Case "ElecPreMaintAdequate"
							Me.str().ElecPreMaintAdequate = CType(value, string)
												
						Case "ElecPreMaintCMMS"
							Me.str().ElecPreMaintCMMS = CType(value, string)
												
						Case "ElectIR"
							Me.str().ElectIR = CType(value, string)
												
						Case "ElecUltrasound"
							Me.str().ElecUltrasound = CType(value, string)
												
						Case "ElecNETA"
							Me.str().ElecNETA = CType(value, string)
												
						Case "ElecTranOil"
							Me.str().ElecTranOil = CType(value, string)
												
						Case "ElecMotor"
							Me.str().ElecMotor = CType(value, string)
												
						Case "ElecIEEE"
							Me.str().ElecIEEE = CType(value, string)
												
						Case "ElecSwitch"
							Me.str().ElecSwitch = CType(value, string)
												
						Case "ElecOther"
							Me.str().ElecOther = CType(value, string)
												
						Case "ElecGRC"
							Me.str().ElecGRC = CType(value, string)
												
						Case "ElecRelay"
							Me.str().ElecRelay = CType(value, string)
												
						Case "ElecBestPractices"
							Me.str().ElecBestPractices = CType(value, string)
												
						Case "ElecBattery"
							Me.str().ElecBattery = CType(value, string)
												
						Case "ElecGrounding"
							Me.str().ElecGrounding = CType(value, string)
												
						Case "ElecPerOther"
							Me.str().ElecPerOther = CType(value, string)
												
						Case "ElectMaintOtherComments"
							Me.str().ElectMaintOtherComments = CType(value, string)
												
						Case "ElectMaintSpecialComments"
							Me.str().ElectMaintSpecialComments = CType(value, string)
												
						Case "SparesMaintained"
							Me.str().SparesMaintained = CType(value, string)
												
						Case "SparesComments"
							Me.str().SparesComments = CType(value, string)
												
						Case "ElectricalSpareUser1"
							Me.str().ElectricalSpareUser1 = CType(value, string)
												
						Case "ElectricalSpareUser2"
							Me.str().ElectricalSpareUser2 = CType(value, string)
												
						Case "ElectricalSpareUser3"
							Me.str().ElectricalSpareUser3 = CType(value, string)
												
						Case "ElectricalSpareUser4"
							Me.str().ElectricalSpareUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "LastArcFlashInspDate"
							Me.str().LastArcFlashInspDate = CType(value, string)
												
						Case "LastArcFlashInspOrg"
							Me.str().LastArcFlashInspOrg = CType(value, string)
												
						Case "LastArcFlashComments"
							Me.str().LastArcFlashComments = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "ElecNETA"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ElecNETA = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecNETA)
							End If
						
						Case "ElecIEEE"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ElecIEEE = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecIEEE)
							End If
						
						Case "ElecGRC"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ElecGRC = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecGRC)
							End If
						
						Case "ElecBestPractices"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ElecBestPractices = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecBestPractices)
							End If
						
						Case "ElecPerOther"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ElecPerOther = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(BMEPPMsMetadata.PropertyNames.ElecPerOther)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BMEPPMsMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "LastArcFlashInspDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastArcFlashInspDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMEPPMsMetadata.PropertyNames.LastArcFlashInspDate)
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
		
			Public Sub New(ByVal entity As esBMEPPMs)
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
		  	
			Public Property ElecPreMaintAdequate As System.String 
				Get
					Dim data_ As System.String = entity.ElecPreMaintAdequate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecPreMaintAdequate = Nothing
					Else
						entity.ElecPreMaintAdequate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecPreMaintCMMS As System.String 
				Get
					Dim data_ As System.String = entity.ElecPreMaintCMMS
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecPreMaintCMMS = Nothing
					Else
						entity.ElecPreMaintCMMS = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectIR As System.String 
				Get
					Dim data_ As System.String = entity.ElectIR
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectIR = Nothing
					Else
						entity.ElectIR = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecUltrasound As System.String 
				Get
					Dim data_ As System.String = entity.ElecUltrasound
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecUltrasound = Nothing
					Else
						entity.ElecUltrasound = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecNETA As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ElecNETA
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecNETA = Nothing
					Else
						entity.ElecNETA = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecTranOil As System.String 
				Get
					Dim data_ As System.String = entity.ElecTranOil
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecTranOil = Nothing
					Else
						entity.ElecTranOil = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecMotor As System.String 
				Get
					Dim data_ As System.String = entity.ElecMotor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecMotor = Nothing
					Else
						entity.ElecMotor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecIEEE As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ElecIEEE
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecIEEE = Nothing
					Else
						entity.ElecIEEE = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecSwitch As System.String 
				Get
					Dim data_ As System.String = entity.ElecSwitch
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecSwitch = Nothing
					Else
						entity.ElecSwitch = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecOther As System.String 
				Get
					Dim data_ As System.String = entity.ElecOther
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecOther = Nothing
					Else
						entity.ElecOther = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecGRC As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ElecGRC
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecGRC = Nothing
					Else
						entity.ElecGRC = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecRelay As System.String 
				Get
					Dim data_ As System.String = entity.ElecRelay
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecRelay = Nothing
					Else
						entity.ElecRelay = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecBestPractices As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ElecBestPractices
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecBestPractices = Nothing
					Else
						entity.ElecBestPractices = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecBattery As System.String 
				Get
					Dim data_ As System.String = entity.ElecBattery
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecBattery = Nothing
					Else
						entity.ElecBattery = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecGrounding As System.String 
				Get
					Dim data_ As System.String = entity.ElecGrounding
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecGrounding = Nothing
					Else
						entity.ElecGrounding = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElecPerOther As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ElecPerOther
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElecPerOther = Nothing
					Else
						entity.ElecPerOther = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectMaintOtherComments As System.String 
				Get
					Dim data_ As System.String = entity.ElectMaintOtherComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectMaintOtherComments = Nothing
					Else
						entity.ElectMaintOtherComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectMaintSpecialComments As System.String 
				Get
					Dim data_ As System.String = entity.ElectMaintSpecialComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectMaintSpecialComments = Nothing
					Else
						entity.ElectMaintSpecialComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesMaintained As System.String 
				Get
					Dim data_ As System.String = entity.SparesMaintained
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesMaintained = Nothing
					Else
						entity.SparesMaintained = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SparesComments As System.String 
				Get
					Dim data_ As System.String = entity.SparesComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SparesComments = Nothing
					Else
						entity.SparesComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricalSpareUser1 As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalSpareUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalSpareUser1 = Nothing
					Else
						entity.ElectricalSpareUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricalSpareUser2 As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalSpareUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalSpareUser2 = Nothing
					Else
						entity.ElectricalSpareUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricalSpareUser3 As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalSpareUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalSpareUser3 = Nothing
					Else
						entity.ElectricalSpareUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ElectricalSpareUser4 As System.String 
				Get
					Dim data_ As System.String = entity.ElectricalSpareUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ElectricalSpareUser4 = Nothing
					Else
						entity.ElectricalSpareUser4 = Convert.ToString(Value)
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
		  	
			Public Property LastArcFlashInspDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastArcFlashInspDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastArcFlashInspDate = Nothing
					Else
						entity.LastArcFlashInspDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastArcFlashInspOrg As System.String 
				Get
					Dim data_ As System.String = entity.LastArcFlashInspOrg
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastArcFlashInspOrg = Nothing
					Else
						entity.LastArcFlashInspOrg = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastArcFlashComments As System.String 
				Get
					Dim data_ As System.String = entity.LastArcFlashComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastArcFlashComments = Nothing
					Else
						entity.LastArcFlashComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBMEPPMs
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMEPPMsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMEPPMsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMEPPMsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMEPPMsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMEPPMsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMEPPMsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMEPPMsCollection
		Inherits esEntityCollection(Of BMEPPMs)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMEPPMsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMEPPMsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMEPPMsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMEPPMsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMEPPMsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMEPPMsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMEPPMsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMEPPMsQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMEPPMsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMEPPMsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMEPPMsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "ElecPreMaintAdequate" 
					Return Me.ElecPreMaintAdequate
				Case "ElecPreMaintCMMS" 
					Return Me.ElecPreMaintCMMS
				Case "ElectIR" 
					Return Me.ElectIR
				Case "ElecUltrasound" 
					Return Me.ElecUltrasound
				Case "ElecNETA" 
					Return Me.ElecNETA
				Case "ElecTranOil" 
					Return Me.ElecTranOil
				Case "ElecMotor" 
					Return Me.ElecMotor
				Case "ElecIEEE" 
					Return Me.ElecIEEE
				Case "ElecSwitch" 
					Return Me.ElecSwitch
				Case "ElecOther" 
					Return Me.ElecOther
				Case "ElecGRC" 
					Return Me.ElecGRC
				Case "ElecRelay" 
					Return Me.ElecRelay
				Case "ElecBestPractices" 
					Return Me.ElecBestPractices
				Case "ElecBattery" 
					Return Me.ElecBattery
				Case "ElecGrounding" 
					Return Me.ElecGrounding
				Case "ElecPerOther" 
					Return Me.ElecPerOther
				Case "ElectMaintOtherComments" 
					Return Me.ElectMaintOtherComments
				Case "ElectMaintSpecialComments" 
					Return Me.ElectMaintSpecialComments
				Case "SparesMaintained" 
					Return Me.SparesMaintained
				Case "SparesComments" 
					Return Me.SparesComments
				Case "ElectricalSpareUser1" 
					Return Me.ElectricalSpareUser1
				Case "ElectricalSpareUser2" 
					Return Me.ElectricalSpareUser2
				Case "ElectricalSpareUser3" 
					Return Me.ElectricalSpareUser3
				Case "ElectricalSpareUser4" 
					Return Me.ElectricalSpareUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "LastArcFlashInspDate" 
					Return Me.LastArcFlashInspDate
				Case "LastArcFlashInspOrg" 
					Return Me.LastArcFlashInspOrg
				Case "LastArcFlashComments" 
					Return Me.LastArcFlashComments
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecPreMaintAdequate As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecPreMaintAdequate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecPreMaintCMMS As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecPreMaintCMMS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectIR As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElectIR, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecUltrasound As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecUltrasound, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecNETA As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecNETA, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ElecTranOil As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecTranOil, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecMotor As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecMotor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecIEEE As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecIEEE, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ElecSwitch As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecSwitch, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecOther As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecOther, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecGRC As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecGRC, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ElecRelay As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecRelay, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecBestPractices As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecBestPractices, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ElecBattery As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecBattery, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecGrounding As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecGrounding, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElecPerOther As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElecPerOther, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ElectMaintOtherComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElectMaintOtherComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectMaintSpecialComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElectMaintSpecialComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesMaintained As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.SparesMaintained, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SparesComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.SparesComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalSpareUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElectricalSpareUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalSpareUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElectricalSpareUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalSpareUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElectricalSpareUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ElectricalSpareUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.ElectricalSpareUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property LastArcFlashInspDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.LastArcFlashInspDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastArcFlashInspOrg As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.LastArcFlashInspOrg, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastArcFlashComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMEPPMsMetadata.ColumnNames.LastArcFlashComments, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMEPPMs 
		Inherits esBMEPPMs
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BMEPPMsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecPreMaintAdequate, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecPreMaintAdequate
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecPreMaintCMMS, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecPreMaintCMMS
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElectIR, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElectIR
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecUltrasound, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecUltrasound
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecNETA, 5, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecNETA
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecTranOil, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecTranOil
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecMotor, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecMotor
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecIEEE, 8, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecIEEE
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecSwitch, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecSwitch
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecOther, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecOther
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecGRC, 11, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecGRC
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecRelay, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecRelay
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecBestPractices, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecBestPractices
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecBattery, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecBattery
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecGrounding, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecGrounding
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElecPerOther, 16, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElecPerOther
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElectMaintOtherComments, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElectMaintOtherComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElectMaintSpecialComments, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElectMaintSpecialComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.SparesMaintained, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.SparesMaintained
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.SparesComments, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.SparesComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser1, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElectricalSpareUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser2, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElectricalSpareUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser3, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElectricalSpareUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.ElectricalSpareUser4, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.ElectricalSpareUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.FilePrefix, 25, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.LastArcFlashInspDate, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.LastArcFlashInspDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.LastArcFlashInspOrg, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.LastArcFlashInspOrg
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMEPPMsMetadata.ColumnNames.LastArcFlashComments, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMEPPMsMetadata.PropertyNames.LastArcFlashComments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMEPPMsMetadata
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
			 Public Const ElecPreMaintAdequate As String = "ElecPreMaintAdequate"
			 Public Const ElecPreMaintCMMS As String = "ElecPreMaintCMMS"
			 Public Const ElectIR As String = "ElectIR"
			 Public Const ElecUltrasound As String = "ElecUltrasound"
			 Public Const ElecNETA As String = "ElecNETA"
			 Public Const ElecTranOil As String = "ElecTranOil"
			 Public Const ElecMotor As String = "ElecMotor"
			 Public Const ElecIEEE As String = "ElecIEEE"
			 Public Const ElecSwitch As String = "ElecSwitch"
			 Public Const ElecOther As String = "ElecOther"
			 Public Const ElecGRC As String = "ElecGRC"
			 Public Const ElecRelay As String = "ElecRelay"
			 Public Const ElecBestPractices As String = "ElecBestPractices"
			 Public Const ElecBattery As String = "ElecBattery"
			 Public Const ElecGrounding As String = "ElecGrounding"
			 Public Const ElecPerOther As String = "ElecPerOther"
			 Public Const ElectMaintOtherComments As String = "ElectMaintOtherComments"
			 Public Const ElectMaintSpecialComments As String = "ElectMaintSpecialComments"
			 Public Const SparesMaintained As String = "SparesMaintained"
			 Public Const SparesComments As String = "SparesComments"
			 Public Const ElectricalSpareUser1 As String = "ElectricalSpareUser1"
			 Public Const ElectricalSpareUser2 As String = "ElectricalSpareUser2"
			 Public Const ElectricalSpareUser3 As String = "ElectricalSpareUser3"
			 Public Const ElectricalSpareUser4 As String = "ElectricalSpareUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const LastArcFlashInspDate As String = "LastArcFlashInspDate"
			 Public Const LastArcFlashInspOrg As String = "LastArcFlashInspOrg"
			 Public Const LastArcFlashComments As String = "LastArcFlashComments"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const ElecPreMaintAdequate As String = "ElecPreMaintAdequate"
			 Public Const ElecPreMaintCMMS As String = "ElecPreMaintCMMS"
			 Public Const ElectIR As String = "ElectIR"
			 Public Const ElecUltrasound As String = "ElecUltrasound"
			 Public Const ElecNETA As String = "ElecNETA"
			 Public Const ElecTranOil As String = "ElecTranOil"
			 Public Const ElecMotor As String = "ElecMotor"
			 Public Const ElecIEEE As String = "ElecIEEE"
			 Public Const ElecSwitch As String = "ElecSwitch"
			 Public Const ElecOther As String = "ElecOther"
			 Public Const ElecGRC As String = "ElecGRC"
			 Public Const ElecRelay As String = "ElecRelay"
			 Public Const ElecBestPractices As String = "ElecBestPractices"
			 Public Const ElecBattery As String = "ElecBattery"
			 Public Const ElecGrounding As String = "ElecGrounding"
			 Public Const ElecPerOther As String = "ElecPerOther"
			 Public Const ElectMaintOtherComments As String = "ElectMaintOtherComments"
			 Public Const ElectMaintSpecialComments As String = "ElectMaintSpecialComments"
			 Public Const SparesMaintained As String = "SparesMaintained"
			 Public Const SparesComments As String = "SparesComments"
			 Public Const ElectricalSpareUser1 As String = "ElectricalSpareUser1"
			 Public Const ElectricalSpareUser2 As String = "ElectricalSpareUser2"
			 Public Const ElectricalSpareUser3 As String = "ElectricalSpareUser3"
			 Public Const ElectricalSpareUser4 As String = "ElectricalSpareUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const LastArcFlashInspDate As String = "LastArcFlashInspDate"
			 Public Const LastArcFlashInspOrg As String = "LastArcFlashInspOrg"
			 Public Const LastArcFlashComments As String = "LastArcFlashComments"
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
			SyncLock GetType(BMEPPMsMetadata)
			
				If BMEPPMsMetadata.mapDelegates Is Nothing Then
					BMEPPMsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMEPPMsMetadata._meta Is Nothing Then
					BMEPPMsMetadata._meta = New BMEPPMsMetadata()
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
				meta.AddTypeMap("ElecPreMaintAdequate", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecPreMaintCMMS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectIR", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecUltrasound", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecNETA", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ElecTranOil", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecMotor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecIEEE", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ElecSwitch", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecOther", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecGRC", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ElecRelay", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecBestPractices", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ElecBattery", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecGrounding", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElecPerOther", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ElectMaintOtherComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectMaintSpecialComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SparesMaintained", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SparesComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricalSpareUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricalSpareUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricalSpareUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ElectricalSpareUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("LastArcFlashInspDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastArcFlashInspOrg", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastArcFlashComments", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-BMEPPMHeader"
				meta.Destination = "Cope-BMEPPMHeader"
				
				meta.spInsert = "proc_Cope-BMEPPMHeaderInsert"
				meta.spUpdate = "proc_Cope-BMEPPMHeaderUpdate"
				meta.spDelete = "proc_Cope-BMEPPMHeaderDelete"
				meta.spLoadAll = "proc_Cope-BMEPPMHeaderLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMEPPMHeaderLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMEPPMsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
