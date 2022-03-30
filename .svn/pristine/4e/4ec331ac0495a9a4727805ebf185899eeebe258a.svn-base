
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
	' Encapsulates the 'Cope-BMHEBCP' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMHEBCP))> _
	<XmlType("BMHEBCP")> _	
	Partial Public Class BMHEBCP 
		Inherits esBMHEBCP
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMHEBCP()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BMHEBCP()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMHEBCP()
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
	<XmlType("BMHEBCPCollection")> _
	Partial Public Class BMHEBCPCollection
		Inherits esBMHEBCPCollection
		Implements IEnumerable(Of BMHEBCP)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BMHEBCP
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMHEBCP))> _
		Public Class BMHEBCPCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMHEBCPCollection)
			
			Public Shared Widening Operator CType(packet As BMHEBCPCollectionWCFPacket) As BMHEBCPCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMHEBCPCollection) As BMHEBCPCollectionWCFPacket
				Return New BMHEBCPCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMHEBCPQuery 
		Inherits esBMHEBCPQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMHEBCPQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMHEBCPQuery) As String
			Return BMHEBCPQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMHEBCPQuery
			Return DirectCast(BMHEBCPQuery.SerializeHelper.FromXml(query, GetType(BMHEBCPQuery)), BMHEBCPQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMHEBCP
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
		
			Dim query As New BMHEBCPQuery()
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
		' Maps to Cope-BMHEBCP.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEAdequate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEAdequate As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEAdequate)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEAdequate, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEAdequate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEMechMaintTrain
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEMechMaintTrain As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEMechMaintTrain)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEMechMaintTrain, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEMechMaintTrain)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEElecSafetyTrain
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEElecSafetyTrain As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEElecSafetyTrain)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEElecSafetyTrain, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEElecSafetyTrain)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEGenOpsTrain
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEGenOpsTrain As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEGenOpsTrain)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEGenOpsTrain, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEGenOpsTrain)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEConfinedSpace
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEConfinedSpace As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEConfinedSpace)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEConfinedSpace, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEConfinedSpace)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HERecordKeeping
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HERecordKeeping As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HERecordKeeping)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HERecordKeeping, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HERecordKeeping)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEElecMaintTrain
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEElecMaintTrain As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEElecMaintTrain)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEElecMaintTrain, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEElecMaintTrain)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEBoilerOpTrain
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEBoilerOpTrain As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEBoilerOpTrain)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEBoilerOpTrain, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEBoilerOpTrain)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HELockout
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HELockout As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HELockout)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HELockout, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HELockout)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEMgmtofChng
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEMgmtofChng As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEMgmtofChng)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEMgmtofChng, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEMgmtofChng)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEHousekeeping
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEHousekeeping As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEHousekeeping)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEHousekeeping, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEHousekeeping)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEGenMaint
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEGenMaint As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEGenMaint)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEGenMaint, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEGenMaint)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEComments As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEComments, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.BCP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bcp As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.Bcp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.Bcp, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.Bcp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.BCPUpdateFreq
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPUpdateFreq As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.BCPUpdateFreq)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.BCPUpdateFreq, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.BCPUpdateFreq)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.BCPComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPComments As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.BCPComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.BCPComments, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.BCPComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEBCPUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEBCPUser1 As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEBCPUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEBCPUser1, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEBCPUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEBCPUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEBCPUser2 As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEBCPUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEBCPUser2, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEBCPUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEBCPUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEBCPUser3 As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEBCPUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEBCPUser3, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEBCPUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.HEBCPUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HEBCPUser4 As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.HEBCPUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.HEBCPUser4, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.HEBCPUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BMHEBCPMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BMHEBCPMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMHEBCP.OperProc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OperProc As System.String
			Get
				Return MyBase.GetSystemString(BMHEBCPMetadata.ColumnNames.OperProc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMHEBCPMetadata.ColumnNames.OperProc, value) Then
					OnPropertyChanged(BMHEBCPMetadata.PropertyNames.OperProc)
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
												
						Case "HEAdequate"
							Me.str().HEAdequate = CType(value, string)
												
						Case "HEMechMaintTrain"
							Me.str().HEMechMaintTrain = CType(value, string)
												
						Case "HEElecSafetyTrain"
							Me.str().HEElecSafetyTrain = CType(value, string)
												
						Case "HEGenOpsTrain"
							Me.str().HEGenOpsTrain = CType(value, string)
												
						Case "HEConfinedSpace"
							Me.str().HEConfinedSpace = CType(value, string)
												
						Case "HERecordKeeping"
							Me.str().HERecordKeeping = CType(value, string)
												
						Case "HEElecMaintTrain"
							Me.str().HEElecMaintTrain = CType(value, string)
												
						Case "HEBoilerOpTrain"
							Me.str().HEBoilerOpTrain = CType(value, string)
												
						Case "HELockout"
							Me.str().HELockout = CType(value, string)
												
						Case "HEMgmtofChng"
							Me.str().HEMgmtofChng = CType(value, string)
												
						Case "HEHousekeeping"
							Me.str().HEHousekeeping = CType(value, string)
												
						Case "HEGenMaint"
							Me.str().HEGenMaint = CType(value, string)
												
						Case "HEComments"
							Me.str().HEComments = CType(value, string)
												
						Case "Bcp"
							Me.str().Bcp = CType(value, string)
												
						Case "BCPUpdateFreq"
							Me.str().BCPUpdateFreq = CType(value, string)
												
						Case "BCPComments"
							Me.str().BCPComments = CType(value, string)
												
						Case "HEBCPUser1"
							Me.str().HEBCPUser1 = CType(value, string)
												
						Case "HEBCPUser2"
							Me.str().HEBCPUser2 = CType(value, string)
												
						Case "HEBCPUser3"
							Me.str().HEBCPUser3 = CType(value, string)
												
						Case "HEBCPUser4"
							Me.str().HEBCPUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "OperProc"
							Me.str().OperProc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BMHEBCPMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBMHEBCP)
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
		  	
			Public Property HEAdequate As System.String 
				Get
					Dim data_ As System.String = entity.HEAdequate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEAdequate = Nothing
					Else
						entity.HEAdequate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEMechMaintTrain As System.String 
				Get
					Dim data_ As System.String = entity.HEMechMaintTrain
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEMechMaintTrain = Nothing
					Else
						entity.HEMechMaintTrain = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEElecSafetyTrain As System.String 
				Get
					Dim data_ As System.String = entity.HEElecSafetyTrain
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEElecSafetyTrain = Nothing
					Else
						entity.HEElecSafetyTrain = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEGenOpsTrain As System.String 
				Get
					Dim data_ As System.String = entity.HEGenOpsTrain
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEGenOpsTrain = Nothing
					Else
						entity.HEGenOpsTrain = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEConfinedSpace As System.String 
				Get
					Dim data_ As System.String = entity.HEConfinedSpace
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEConfinedSpace = Nothing
					Else
						entity.HEConfinedSpace = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HERecordKeeping As System.String 
				Get
					Dim data_ As System.String = entity.HERecordKeeping
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HERecordKeeping = Nothing
					Else
						entity.HERecordKeeping = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEElecMaintTrain As System.String 
				Get
					Dim data_ As System.String = entity.HEElecMaintTrain
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEElecMaintTrain = Nothing
					Else
						entity.HEElecMaintTrain = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEBoilerOpTrain As System.String 
				Get
					Dim data_ As System.String = entity.HEBoilerOpTrain
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEBoilerOpTrain = Nothing
					Else
						entity.HEBoilerOpTrain = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HELockout As System.String 
				Get
					Dim data_ As System.String = entity.HELockout
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HELockout = Nothing
					Else
						entity.HELockout = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEMgmtofChng As System.String 
				Get
					Dim data_ As System.String = entity.HEMgmtofChng
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEMgmtofChng = Nothing
					Else
						entity.HEMgmtofChng = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEHousekeeping As System.String 
				Get
					Dim data_ As System.String = entity.HEHousekeeping
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEHousekeeping = Nothing
					Else
						entity.HEHousekeeping = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEGenMaint As System.String 
				Get
					Dim data_ As System.String = entity.HEGenMaint
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEGenMaint = Nothing
					Else
						entity.HEGenMaint = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEComments As System.String 
				Get
					Dim data_ As System.String = entity.HEComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEComments = Nothing
					Else
						entity.HEComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bcp As System.String 
				Get
					Dim data_ As System.String = entity.Bcp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bcp = Nothing
					Else
						entity.Bcp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPUpdateFreq As System.String 
				Get
					Dim data_ As System.String = entity.BCPUpdateFreq
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPUpdateFreq = Nothing
					Else
						entity.BCPUpdateFreq = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPComments As System.String 
				Get
					Dim data_ As System.String = entity.BCPComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPComments = Nothing
					Else
						entity.BCPComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEBCPUser1 As System.String 
				Get
					Dim data_ As System.String = entity.HEBCPUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEBCPUser1 = Nothing
					Else
						entity.HEBCPUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEBCPUser2 As System.String 
				Get
					Dim data_ As System.String = entity.HEBCPUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEBCPUser2 = Nothing
					Else
						entity.HEBCPUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEBCPUser3 As System.String 
				Get
					Dim data_ As System.String = entity.HEBCPUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEBCPUser3 = Nothing
					Else
						entity.HEBCPUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HEBCPUser4 As System.String 
				Get
					Dim data_ As System.String = entity.HEBCPUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HEBCPUser4 = Nothing
					Else
						entity.HEBCPUser4 = Convert.ToString(Value)
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
		  	
			Public Property OperProc As System.String 
				Get
					Dim data_ As System.String = entity.OperProc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OperProc = Nothing
					Else
						entity.OperProc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBMHEBCP
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMHEBCPMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMHEBCPQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMHEBCPQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMHEBCPQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMHEBCPQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMHEBCPQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMHEBCPCollection
		Inherits esEntityCollection(Of BMHEBCP)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMHEBCPMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMHEBCPCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMHEBCPQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMHEBCPQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMHEBCPQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMHEBCPQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMHEBCPQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMHEBCPQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMHEBCPQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMHEBCPQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMHEBCPMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "HEAdequate" 
					Return Me.HEAdequate
				Case "HEMechMaintTrain" 
					Return Me.HEMechMaintTrain
				Case "HEElecSafetyTrain" 
					Return Me.HEElecSafetyTrain
				Case "HEGenOpsTrain" 
					Return Me.HEGenOpsTrain
				Case "HEConfinedSpace" 
					Return Me.HEConfinedSpace
				Case "HERecordKeeping" 
					Return Me.HERecordKeeping
				Case "HEElecMaintTrain" 
					Return Me.HEElecMaintTrain
				Case "HEBoilerOpTrain" 
					Return Me.HEBoilerOpTrain
				Case "HELockout" 
					Return Me.HELockout
				Case "HEMgmtofChng" 
					Return Me.HEMgmtofChng
				Case "HEHousekeeping" 
					Return Me.HEHousekeeping
				Case "HEGenMaint" 
					Return Me.HEGenMaint
				Case "HEComments" 
					Return Me.HEComments
				Case "Bcp" 
					Return Me.Bcp
				Case "BCPUpdateFreq" 
					Return Me.BCPUpdateFreq
				Case "BCPComments" 
					Return Me.BCPComments
				Case "HEBCPUser1" 
					Return Me.HEBCPUser1
				Case "HEBCPUser2" 
					Return Me.HEBCPUser2
				Case "HEBCPUser3" 
					Return Me.HEBCPUser3
				Case "HEBCPUser4" 
					Return Me.HEBCPUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "OperProc" 
					Return Me.OperProc
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEAdequate As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEAdequate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEMechMaintTrain As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEMechMaintTrain, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEElecSafetyTrain As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEElecSafetyTrain, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEGenOpsTrain As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEGenOpsTrain, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEConfinedSpace As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEConfinedSpace, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HERecordKeeping As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HERecordKeeping, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEElecMaintTrain As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEElecMaintTrain, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEBoilerOpTrain As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEBoilerOpTrain, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HELockout As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HELockout, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEMgmtofChng As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEMgmtofChng, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEHousekeeping As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEHousekeeping, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEGenMaint As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEGenMaint, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bcp As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.Bcp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BCPUpdateFreq As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.BCPUpdateFreq, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BCPComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.BCPComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEBCPUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEBCPUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEBCPUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEBCPUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEBCPUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEBCPUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HEBCPUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.HEBCPUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property OperProc As esQueryItem
			Get
				Return New esQueryItem(Me, BMHEBCPMetadata.ColumnNames.OperProc, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMHEBCP 
		Inherits esBMHEBCP
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BMHEBCPMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEAdequate, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEAdequate
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEMechMaintTrain, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEMechMaintTrain
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEElecSafetyTrain, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEElecSafetyTrain
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEGenOpsTrain, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEGenOpsTrain
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEConfinedSpace, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEConfinedSpace
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HERecordKeeping, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HERecordKeeping
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEElecMaintTrain, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEElecMaintTrain
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEBoilerOpTrain, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEBoilerOpTrain
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HELockout, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HELockout
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEMgmtofChng, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEMgmtofChng
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEHousekeeping, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEHousekeeping
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEGenMaint, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEGenMaint
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEComments, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.Bcp, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.Bcp
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.BCPUpdateFreq, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.BCPUpdateFreq
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.BCPComments, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.BCPComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEBCPUser1, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEBCPUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEBCPUser2, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEBCPUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEBCPUser3, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEBCPUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.HEBCPUser4, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.HEBCPUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.FilePrefix, 21, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMHEBCPMetadata.ColumnNames.OperProc, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMHEBCPMetadata.PropertyNames.OperProc
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMHEBCPMetadata
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
			 Public Const HEAdequate As String = "HEAdequate"
			 Public Const HEMechMaintTrain As String = "HEMechMaintTrain"
			 Public Const HEElecSafetyTrain As String = "HEElecSafetyTrain"
			 Public Const HEGenOpsTrain As String = "HEGenOpsTrain"
			 Public Const HEConfinedSpace As String = "HEConfinedSpace"
			 Public Const HERecordKeeping As String = "HERecordKeeping"
			 Public Const HEElecMaintTrain As String = "HEElecMaintTrain"
			 Public Const HEBoilerOpTrain As String = "HEBoilerOpTrain"
			 Public Const HELockout As String = "HELockout"
			 Public Const HEMgmtofChng As String = "HEMgmtofChng"
			 Public Const HEHousekeeping As String = "HEHousekeeping"
			 Public Const HEGenMaint As String = "HEGenMaint"
			 Public Const HEComments As String = "HEComments"
			 Public Const Bcp As String = "BCP"
			 Public Const BCPUpdateFreq As String = "BCPUpdateFreq"
			 Public Const BCPComments As String = "BCPComments"
			 Public Const HEBCPUser1 As String = "HEBCPUser1"
			 Public Const HEBCPUser2 As String = "HEBCPUser2"
			 Public Const HEBCPUser3 As String = "HEBCPUser3"
			 Public Const HEBCPUser4 As String = "HEBCPUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const OperProc As String = "OperProc"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const HEAdequate As String = "HEAdequate"
			 Public Const HEMechMaintTrain As String = "HEMechMaintTrain"
			 Public Const HEElecSafetyTrain As String = "HEElecSafetyTrain"
			 Public Const HEGenOpsTrain As String = "HEGenOpsTrain"
			 Public Const HEConfinedSpace As String = "HEConfinedSpace"
			 Public Const HERecordKeeping As String = "HERecordKeeping"
			 Public Const HEElecMaintTrain As String = "HEElecMaintTrain"
			 Public Const HEBoilerOpTrain As String = "HEBoilerOpTrain"
			 Public Const HELockout As String = "HELockout"
			 Public Const HEMgmtofChng As String = "HEMgmtofChng"
			 Public Const HEHousekeeping As String = "HEHousekeeping"
			 Public Const HEGenMaint As String = "HEGenMaint"
			 Public Const HEComments As String = "HEComments"
			 Public Const Bcp As String = "Bcp"
			 Public Const BCPUpdateFreq As String = "BCPUpdateFreq"
			 Public Const BCPComments As String = "BCPComments"
			 Public Const HEBCPUser1 As String = "HEBCPUser1"
			 Public Const HEBCPUser2 As String = "HEBCPUser2"
			 Public Const HEBCPUser3 As String = "HEBCPUser3"
			 Public Const HEBCPUser4 As String = "HEBCPUser4"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const OperProc As String = "OperProc"
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
			SyncLock GetType(BMHEBCPMetadata)
			
				If BMHEBCPMetadata.mapDelegates Is Nothing Then
					BMHEBCPMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMHEBCPMetadata._meta Is Nothing Then
					BMHEBCPMetadata._meta = New BMHEBCPMetadata()
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
				meta.AddTypeMap("HEAdequate", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEMechMaintTrain", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEElecSafetyTrain", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEGenOpsTrain", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEConfinedSpace", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HERecordKeeping", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEElecMaintTrain", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEBoilerOpTrain", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HELockout", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEMgmtofChng", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEHousekeeping", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEGenMaint", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Bcp", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BCPUpdateFreq", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BCPComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEBCPUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEBCPUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEBCPUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HEBCPUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("OperProc", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Cope-BMHEBCP"
				meta.Destination = "Cope-BMHEBCP"
				
				meta.spInsert = "proc_Cope-BMHEBCPInsert"
				meta.spUpdate = "proc_Cope-BMHEBCPUpdate"
				meta.spDelete = "proc_Cope-BMHEBCPDelete"
				meta.spLoadAll = "proc_Cope-BMHEBCPLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMHEBCPLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMHEBCPMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
