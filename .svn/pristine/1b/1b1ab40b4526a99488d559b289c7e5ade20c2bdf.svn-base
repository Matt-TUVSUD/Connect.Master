
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:40 AM
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
	' Encapsulates the 'Cope-BMOccupancy' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMOccupancy))> _
	<XmlType("BMOccupancy")> _	
	Partial Public Class BMOccupancy 
		Inherits esBMOccupancy
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMOccupancy()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BMOccupancy()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMOccupancy()
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
	<XmlType("BMOccupancyCollection")> _
	Partial Public Class BMOccupancyCollection
		Inherits esBMOccupancyCollection
		Implements IEnumerable(Of BMOccupancy)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BMOccupancy
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMOccupancy))> _
		Public Class BMOccupancyCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMOccupancyCollection)
			
			Public Shared Widening Operator CType(packet As BMOccupancyCollectionWCFPacket) As BMOccupancyCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMOccupancyCollection) As BMOccupancyCollectionWCFPacket
				Return New BMOccupancyCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMOccupancyQuery 
		Inherits esBMOccupancyQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMOccupancyQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMOccupancyQuery) As String
			Return BMOccupancyQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMOccupancyQuery
			Return DirectCast(BMOccupancyQuery.SerializeHelper.FromXml(query, GetType(BMOccupancyQuery)), BMOccupancyQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMOccupancy
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
		
			Dim query As New BMOccupancyQuery()
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
		' Maps to Cope-BMOccupancy.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.IndustryGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IndustryGroup As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.IndustryGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.IndustryGroup, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.IndustryGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.MajorGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorGroup As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.MajorGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.MajorGroup, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.MajorGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.SpecificGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecificGroup As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.SpecificGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.SpecificGroup, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.SpecificGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.SICCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SICCode As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.SICCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.SICCode, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.SICCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.HoursDay
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HoursDay As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMOccupancyMetadata.ColumnNames.HoursDay)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMOccupancyMetadata.ColumnNames.HoursDay, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.HoursDay)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.DaysWeek
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DaysWeek As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMOccupancyMetadata.ColumnNames.DaysWeek)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMOccupancyMetadata.ColumnNames.DaysWeek, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.DaysWeek)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.NumberOfEmployees
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NumberOfEmployees As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMOccupancyMetadata.ColumnNames.NumberOfEmployees)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMOccupancyMetadata.ColumnNames.NumberOfEmployees, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.NumberOfEmployees)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.PercentManufacturing
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PercentManufacturing As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentManufacturing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentManufacturing, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentManufacturing)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.PercentUtilities
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PercentUtilities As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentUtilities)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentUtilities, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentUtilities)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.PercentWholesaleDistStge
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PercentWholesaleDistStge As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentWholesaleDistStge)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentWholesaleDistStge, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentWholesaleDistStge)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.PercentOffice
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PercentOffice As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentOffice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentOffice, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentOffice)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.PercentRetail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PercentRetail As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentRetail)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentRetail, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentRetail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.PercentOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PercentOther As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentOther)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMOccupancyMetadata.ColumnNames.PercentOther, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.OpsDetails
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OpsDetails As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.OpsDetails)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.OpsDetails, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.OpsDetails)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.OccupancyUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyUser1 As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.OccupancyUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.OccupancyUser1, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.OccupancyUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.OccupancyUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyUser2 As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.OccupancyUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.OccupancyUser2, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.OccupancyUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.OccupancyUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyUser3 As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.OccupancyUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.OccupancyUser3, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.OccupancyUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.OccupancyUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyUser4 As System.String
			Get
				Return MyBase.GetSystemString(BMOccupancyMetadata.ColumnNames.OccupancyUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMOccupancyMetadata.ColumnNames.OccupancyUser4, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.OccupancyUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMOccupancy.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(BMOccupancyMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(BMOccupancyMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BMOccupancyMetadata.PropertyNames.FilePrefix)
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
												
						Case "IndustryGroup"
							Me.str().IndustryGroup = CType(value, string)
												
						Case "MajorGroup"
							Me.str().MajorGroup = CType(value, string)
												
						Case "SpecificGroup"
							Me.str().SpecificGroup = CType(value, string)
												
						Case "SICCode"
							Me.str().SICCode = CType(value, string)
												
						Case "HoursDay"
							Me.str().HoursDay = CType(value, string)
												
						Case "DaysWeek"
							Me.str().DaysWeek = CType(value, string)
												
						Case "NumberOfEmployees"
							Me.str().NumberOfEmployees = CType(value, string)
												
						Case "PercentManufacturing"
							Me.str().PercentManufacturing = CType(value, string)
												
						Case "PercentUtilities"
							Me.str().PercentUtilities = CType(value, string)
												
						Case "PercentWholesaleDistStge"
							Me.str().PercentWholesaleDistStge = CType(value, string)
												
						Case "PercentOffice"
							Me.str().PercentOffice = CType(value, string)
												
						Case "PercentRetail"
							Me.str().PercentRetail = CType(value, string)
												
						Case "PercentOther"
							Me.str().PercentOther = CType(value, string)
												
						Case "OpsDetails"
							Me.str().OpsDetails = CType(value, string)
												
						Case "OccupancyUser1"
							Me.str().OccupancyUser1 = CType(value, string)
												
						Case "OccupancyUser2"
							Me.str().OccupancyUser2 = CType(value, string)
												
						Case "OccupancyUser3"
							Me.str().OccupancyUser3 = CType(value, string)
												
						Case "OccupancyUser4"
							Me.str().OccupancyUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "HoursDay"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.HoursDay = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.HoursDay)
							End If
						
						Case "DaysWeek"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.DaysWeek = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.DaysWeek)
							End If
						
						Case "NumberOfEmployees"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NumberOfEmployees = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.NumberOfEmployees)
							End If
						
						Case "PercentManufacturing"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PercentManufacturing = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentManufacturing)
							End If
						
						Case "PercentUtilities"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PercentUtilities = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentUtilities)
							End If
						
						Case "PercentWholesaleDistStge"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PercentWholesaleDistStge = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentWholesaleDistStge)
							End If
						
						Case "PercentOffice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PercentOffice = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentOffice)
							End If
						
						Case "PercentRetail"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PercentRetail = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentRetail)
							End If
						
						Case "PercentOther"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.PercentOther = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.PercentOther)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(BMOccupancyMetadata.PropertyNames.FilePrefix)
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
		
			Public Sub New(ByVal entity As esBMOccupancy)
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
		  	
			Public Property IndustryGroup As System.String 
				Get
					Dim data_ As System.String = entity.IndustryGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IndustryGroup = Nothing
					Else
						entity.IndustryGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MajorGroup As System.String 
				Get
					Dim data_ As System.String = entity.MajorGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MajorGroup = Nothing
					Else
						entity.MajorGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecificGroup As System.String 
				Get
					Dim data_ As System.String = entity.SpecificGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecificGroup = Nothing
					Else
						entity.SpecificGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SICCode As System.String 
				Get
					Dim data_ As System.String = entity.SICCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SICCode = Nothing
					Else
						entity.SICCode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HoursDay As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.HoursDay
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HoursDay = Nothing
					Else
						entity.HoursDay = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property DaysWeek As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.DaysWeek
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DaysWeek = Nothing
					Else
						entity.DaysWeek = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property NumberOfEmployees As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NumberOfEmployees
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NumberOfEmployees = Nothing
					Else
						entity.NumberOfEmployees = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PercentManufacturing As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PercentManufacturing
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PercentManufacturing = Nothing
					Else
						entity.PercentManufacturing = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PercentUtilities As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PercentUtilities
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PercentUtilities = Nothing
					Else
						entity.PercentUtilities = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PercentWholesaleDistStge As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PercentWholesaleDistStge
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PercentWholesaleDistStge = Nothing
					Else
						entity.PercentWholesaleDistStge = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PercentOffice As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PercentOffice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PercentOffice = Nothing
					Else
						entity.PercentOffice = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PercentRetail As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PercentRetail
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PercentRetail = Nothing
					Else
						entity.PercentRetail = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property PercentOther As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.PercentOther
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PercentOther = Nothing
					Else
						entity.PercentOther = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property OpsDetails As System.String 
				Get
					Dim data_ As System.String = entity.OpsDetails
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OpsDetails = Nothing
					Else
						entity.OpsDetails = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyUser1 As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyUser1 = Nothing
					Else
						entity.OccupancyUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyUser2 As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyUser2 = Nothing
					Else
						entity.OccupancyUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyUser3 As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyUser3 = Nothing
					Else
						entity.OccupancyUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyUser4 As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyUser4 = Nothing
					Else
						entity.OccupancyUser4 = Convert.ToString(Value)
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
		  

			Private entity As esBMOccupancy
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMOccupancyMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMOccupancyQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMOccupancyQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMOccupancyQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMOccupancyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMOccupancyQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMOccupancyCollection
		Inherits esEntityCollection(Of BMOccupancy)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMOccupancyMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMOccupancyCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMOccupancyQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMOccupancyQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMOccupancyQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMOccupancyQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMOccupancyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMOccupancyQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMOccupancyQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMOccupancyQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMOccupancyMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "IndustryGroup" 
					Return Me.IndustryGroup
				Case "MajorGroup" 
					Return Me.MajorGroup
				Case "SpecificGroup" 
					Return Me.SpecificGroup
				Case "SICCode" 
					Return Me.SICCode
				Case "HoursDay" 
					Return Me.HoursDay
				Case "DaysWeek" 
					Return Me.DaysWeek
				Case "NumberOfEmployees" 
					Return Me.NumberOfEmployees
				Case "PercentManufacturing" 
					Return Me.PercentManufacturing
				Case "PercentUtilities" 
					Return Me.PercentUtilities
				Case "PercentWholesaleDistStge" 
					Return Me.PercentWholesaleDistStge
				Case "PercentOffice" 
					Return Me.PercentOffice
				Case "PercentRetail" 
					Return Me.PercentRetail
				Case "PercentOther" 
					Return Me.PercentOther
				Case "OpsDetails" 
					Return Me.OpsDetails
				Case "OccupancyUser1" 
					Return Me.OccupancyUser1
				Case "OccupancyUser2" 
					Return Me.OccupancyUser2
				Case "OccupancyUser3" 
					Return Me.OccupancyUser3
				Case "OccupancyUser4" 
					Return Me.OccupancyUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IndustryGroup As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.IndustryGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MajorGroup As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.MajorGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecificGroup As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.SpecificGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SICCode As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.SICCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HoursDay As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.HoursDay, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property DaysWeek As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.DaysWeek, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property NumberOfEmployees As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.NumberOfEmployees, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PercentManufacturing As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.PercentManufacturing, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PercentUtilities As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.PercentUtilities, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PercentWholesaleDistStge As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.PercentWholesaleDistStge, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PercentOffice As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.PercentOffice, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PercentRetail As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.PercentRetail, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property PercentOther As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.PercentOther, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property OpsDetails As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.OpsDetails, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.OccupancyUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.OccupancyUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.OccupancyUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.OccupancyUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMOccupancyMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMOccupancy 
		Inherits esBMOccupancy
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BMOccupancyMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.IndustryGroup, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.IndustryGroup
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.MajorGroup, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.MajorGroup
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.SpecificGroup, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.SpecificGroup
			c.CharacterMaxLength = 40
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.SICCode, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.SICCode
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.HoursDay, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.HoursDay
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.DaysWeek, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.DaysWeek
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.NumberOfEmployees, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.NumberOfEmployees
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.PercentManufacturing, 8, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.PercentManufacturing
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.PercentUtilities, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.PercentUtilities
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.PercentWholesaleDistStge, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.PercentWholesaleDistStge
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.PercentOffice, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.PercentOffice
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.PercentRetail, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.PercentRetail
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.PercentOther, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.PercentOther
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.OpsDetails, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.OpsDetails
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.OccupancyUser1, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.OccupancyUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.OccupancyUser2, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.OccupancyUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.OccupancyUser3, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.OccupancyUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.OccupancyUser4, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.OccupancyUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMOccupancyMetadata.ColumnNames.FilePrefix, 19, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = BMOccupancyMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMOccupancyMetadata
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
			 Public Const IndustryGroup As String = "IndustryGroup"
			 Public Const MajorGroup As String = "MajorGroup"
			 Public Const SpecificGroup As String = "SpecificGroup"
			 Public Const SICCode As String = "SICCode"
			 Public Const HoursDay As String = "HoursDay"
			 Public Const DaysWeek As String = "DaysWeek"
			 Public Const NumberOfEmployees As String = "NumberOfEmployees"
			 Public Const PercentManufacturing As String = "PercentManufacturing"
			 Public Const PercentUtilities As String = "PercentUtilities"
			 Public Const PercentWholesaleDistStge As String = "PercentWholesaleDistStge"
			 Public Const PercentOffice As String = "PercentOffice"
			 Public Const PercentRetail As String = "PercentRetail"
			 Public Const PercentOther As String = "PercentOther"
			 Public Const OpsDetails As String = "OpsDetails"
			 Public Const OccupancyUser1 As String = "OccupancyUser1"
			 Public Const OccupancyUser2 As String = "OccupancyUser2"
			 Public Const OccupancyUser3 As String = "OccupancyUser3"
			 Public Const OccupancyUser4 As String = "OccupancyUser4"
			 Public Const FilePrefix As String = "FilePrefix"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const IndustryGroup As String = "IndustryGroup"
			 Public Const MajorGroup As String = "MajorGroup"
			 Public Const SpecificGroup As String = "SpecificGroup"
			 Public Const SICCode As String = "SICCode"
			 Public Const HoursDay As String = "HoursDay"
			 Public Const DaysWeek As String = "DaysWeek"
			 Public Const NumberOfEmployees As String = "NumberOfEmployees"
			 Public Const PercentManufacturing As String = "PercentManufacturing"
			 Public Const PercentUtilities As String = "PercentUtilities"
			 Public Const PercentWholesaleDistStge As String = "PercentWholesaleDistStge"
			 Public Const PercentOffice As String = "PercentOffice"
			 Public Const PercentRetail As String = "PercentRetail"
			 Public Const PercentOther As String = "PercentOther"
			 Public Const OpsDetails As String = "OpsDetails"
			 Public Const OccupancyUser1 As String = "OccupancyUser1"
			 Public Const OccupancyUser2 As String = "OccupancyUser2"
			 Public Const OccupancyUser3 As String = "OccupancyUser3"
			 Public Const OccupancyUser4 As String = "OccupancyUser4"
			 Public Const FilePrefix As String = "FilePrefix"
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
			SyncLock GetType(BMOccupancyMetadata)
			
				If BMOccupancyMetadata.mapDelegates Is Nothing Then
					BMOccupancyMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMOccupancyMetadata._meta Is Nothing Then
					BMOccupancyMetadata._meta = New BMOccupancyMetadata()
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
				meta.AddTypeMap("IndustryGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MajorGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecificGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SICCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HoursDay", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("DaysWeek", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("NumberOfEmployees", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PercentManufacturing", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PercentUtilities", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PercentWholesaleDistStge", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PercentOffice", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PercentRetail", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("PercentOther", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("OpsDetails", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OccupancyUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OccupancyUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OccupancyUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OccupancyUser4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))			
				
				
				 
				meta.Source = "Cope-BMOccupancy"
				meta.Destination = "Cope-BMOccupancy"
				
				meta.spInsert = "proc_Cope-BMOccupancyInsert"
				meta.spUpdate = "proc_Cope-BMOccupancyUpdate"
				meta.spDelete = "proc_Cope-BMOccupancyDelete"
				meta.spLoadAll = "proc_Cope-BMOccupancyLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMOccupancyLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMOccupancyMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
