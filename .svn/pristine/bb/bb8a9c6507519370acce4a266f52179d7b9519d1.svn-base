
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/28/2013 2:22:04 PM
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
	' Encapsulates the 'tblARISELocations' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(TblARISELocations))> _
	<XmlType("TblARISELocations")> _	
	Partial Public Class TblARISELocations 
		Inherits esTblARISELocations
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New TblARISELocations()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal locationID As System.Int32)
			Dim obj As New TblARISELocations()
			obj.LocationID = locationID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal locationID As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New TblARISELocations()
			obj.LocationID = locationID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("TblARISELocationsCollection")> _
	Partial Public Class TblARISELocationsCollection
		Inherits esTblARISELocationsCollection
		Implements IEnumerable(Of TblARISELocations)
	
		Public Function FindByPrimaryKey(ByVal locationID As System.Int32) As TblARISELocations
			Return MyBase.SingleOrDefault(Function(e) e.LocationID.HasValue AndAlso e.LocationID.Value = locationID)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(TblARISELocations))> _
		Public Class TblARISELocationsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TblARISELocationsCollection)
			
			Public Shared Widening Operator CType(packet As TblARISELocationsCollectionWCFPacket) As TblARISELocationsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TblARISELocationsCollection) As TblARISELocationsCollectionWCFPacket
				Return New TblARISELocationsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class TblARISELocationsQuery 
		Inherits esTblARISELocationsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TblARISELocationsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TblARISELocationsQuery) As String
			Return TblARISELocationsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TblARISELocationsQuery
			Return DirectCast(TblARISELocationsQuery.SerializeHelper.FromXml(query, GetType(TblARISELocationsQuery)), TblARISELocationsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTblARISELocations
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal locationID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(locationID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(locationID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal locationID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(locationID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(locationID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal locationID As System.Int32) As Boolean
		
			Dim query As New TblARISELocationsQuery()
			query.Where(query.LocationID = locationID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal locationID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LocationID", locationID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to tblARISELocations.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.intlocationid
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Intlocationid As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(TblARISELocationsMetadata.ColumnNames.Intlocationid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(TblARISELocationsMetadata.ColumnNames.Intlocationid, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.Intlocationid)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strClientLocationNum
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrClientLocationNum As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrClientLocationNum)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrClientLocationNum, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrClientLocationNum)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strClientNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrClientNumber As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrClientNumber)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrClientNumber, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrClientNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strClientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrClientName As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrClientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrClientName, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrClientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strDivisionName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrDivisionName As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrDivisionName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrDivisionName, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrDivisionName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strCompanyLocationNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrCompanyLocationNumber As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrCompanyLocationNumber)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrCompanyLocationNumber, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrCompanyLocationNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strLocationName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrLocationName As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrLocationName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrLocationName, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrLocationName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strAddr1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrAddr1 As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrAddr1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrAddr1, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrAddr1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strAddr2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrAddr2 As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrAddr2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrAddr2, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrAddr2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strCity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrCity As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrCity)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrCity, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrCity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strState
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrState As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrState)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrState, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrState)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strZip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrZip As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrZip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrZip, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrZip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strCountry
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrCountry As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrCountry)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrCountry, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrCountry)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.strCustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrCustomAccess As System.String
			Get
				Return MyBase.GetSystemString(TblARISELocationsMetadata.ColumnNames.StrCustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TblARISELocationsMetadata.ColumnNames.StrCustomAccess, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.StrCustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.LastUpdated
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastUpdated As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(TblARISELocationsMetadata.ColumnNames.LastUpdated)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(TblARISELocationsMetadata.ColumnNames.LastUpdated, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.LastUpdated)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to tblARISELocations.LocationID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TblARISELocationsMetadata.ColumnNames.LocationID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TblARISELocationsMetadata.ColumnNames.LocationID, value) Then
					OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.LocationID)
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
												
						Case "Intlocationid"
							Me.str().Intlocationid = CType(value, string)
												
						Case "StrClientLocationNum"
							Me.str().StrClientLocationNum = CType(value, string)
												
						Case "StrClientNumber"
							Me.str().StrClientNumber = CType(value, string)
												
						Case "StrClientName"
							Me.str().StrClientName = CType(value, string)
												
						Case "StrDivisionName"
							Me.str().StrDivisionName = CType(value, string)
												
						Case "StrCompanyLocationNumber"
							Me.str().StrCompanyLocationNumber = CType(value, string)
												
						Case "StrLocationName"
							Me.str().StrLocationName = CType(value, string)
												
						Case "StrAddr1"
							Me.str().StrAddr1 = CType(value, string)
												
						Case "StrAddr2"
							Me.str().StrAddr2 = CType(value, string)
												
						Case "StrCity"
							Me.str().StrCity = CType(value, string)
												
						Case "StrState"
							Me.str().StrState = CType(value, string)
												
						Case "StrZip"
							Me.str().StrZip = CType(value, string)
												
						Case "StrCountry"
							Me.str().StrCountry = CType(value, string)
												
						Case "StrCustomAccess"
							Me.str().StrCustomAccess = CType(value, string)
												
						Case "LastUpdated"
							Me.str().LastUpdated = CType(value, string)
												
						Case "LocationID"
							Me.str().LocationID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Intlocationid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Intlocationid = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.Intlocationid)
							End If
						
						Case "LastUpdated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastUpdated = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.LastUpdated)
							End If
						
						Case "LocationID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LocationID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(TblARISELocationsMetadata.PropertyNames.LocationID)
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
		
			Public Sub New(ByVal entity As esTblARISELocations)
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
		  	
			Public Property Intlocationid As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Intlocationid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Intlocationid = Nothing
					Else
						entity.Intlocationid = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrClientLocationNum As System.String 
				Get
					Dim data_ As System.String = entity.StrClientLocationNum
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrClientLocationNum = Nothing
					Else
						entity.StrClientLocationNum = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrClientNumber As System.String 
				Get
					Dim data_ As System.String = entity.StrClientNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrClientNumber = Nothing
					Else
						entity.StrClientNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrClientName As System.String 
				Get
					Dim data_ As System.String = entity.StrClientName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrClientName = Nothing
					Else
						entity.StrClientName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrDivisionName As System.String 
				Get
					Dim data_ As System.String = entity.StrDivisionName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrDivisionName = Nothing
					Else
						entity.StrDivisionName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrCompanyLocationNumber As System.String 
				Get
					Dim data_ As System.String = entity.StrCompanyLocationNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrCompanyLocationNumber = Nothing
					Else
						entity.StrCompanyLocationNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrLocationName As System.String 
				Get
					Dim data_ As System.String = entity.StrLocationName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrLocationName = Nothing
					Else
						entity.StrLocationName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrAddr1 As System.String 
				Get
					Dim data_ As System.String = entity.StrAddr1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrAddr1 = Nothing
					Else
						entity.StrAddr1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrAddr2 As System.String 
				Get
					Dim data_ As System.String = entity.StrAddr2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrAddr2 = Nothing
					Else
						entity.StrAddr2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrCity As System.String 
				Get
					Dim data_ As System.String = entity.StrCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrCity = Nothing
					Else
						entity.StrCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrState As System.String 
				Get
					Dim data_ As System.String = entity.StrState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrState = Nothing
					Else
						entity.StrState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrZip As System.String 
				Get
					Dim data_ As System.String = entity.StrZip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrZip = Nothing
					Else
						entity.StrZip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrCountry As System.String 
				Get
					Dim data_ As System.String = entity.StrCountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrCountry = Nothing
					Else
						entity.StrCountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StrCustomAccess As System.String 
				Get
					Dim data_ As System.String = entity.StrCustomAccess
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StrCustomAccess = Nothing
					Else
						entity.StrCustomAccess = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastUpdated As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastUpdated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastUpdated = Nothing
					Else
						entity.LastUpdated = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LocationID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationID = Nothing
					Else
						entity.LocationID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esTblARISELocations
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblARISELocationsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TblARISELocationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblARISELocationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TblARISELocationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TblARISELocationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TblARISELocationsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTblARISELocationsCollection
		Inherits esEntityCollection(Of TblARISELocations)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TblARISELocationsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TblARISELocationsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TblARISELocationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TblARISELocationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TblARISELocationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TblARISELocationsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TblARISELocationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TblARISELocationsQuery))
		End Sub
		
		#End Region
						
		Private m_query As TblARISELocationsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTblARISELocationsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TblARISELocationsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "Intlocationid" 
					Return Me.Intlocationid
				Case "StrClientLocationNum" 
					Return Me.StrClientLocationNum
				Case "StrClientNumber" 
					Return Me.StrClientNumber
				Case "StrClientName" 
					Return Me.StrClientName
				Case "StrDivisionName" 
					Return Me.StrDivisionName
				Case "StrCompanyLocationNumber" 
					Return Me.StrCompanyLocationNumber
				Case "StrLocationName" 
					Return Me.StrLocationName
				Case "StrAddr1" 
					Return Me.StrAddr1
				Case "StrAddr2" 
					Return Me.StrAddr2
				Case "StrCity" 
					Return Me.StrCity
				Case "StrState" 
					Return Me.StrState
				Case "StrZip" 
					Return Me.StrZip
				Case "StrCountry" 
					Return Me.StrCountry
				Case "StrCustomAccess" 
					Return Me.StrCustomAccess
				Case "LastUpdated" 
					Return Me.LastUpdated
				Case "LocationID" 
					Return Me.LocationID
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Intlocationid As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.Intlocationid, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property StrClientLocationNum As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrClientLocationNum, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrClientNumber As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrClientNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrClientName As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrClientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrDivisionName As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrDivisionName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrCompanyLocationNumber As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrCompanyLocationNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrLocationName As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrLocationName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrAddr1 As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrAddr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrAddr2 As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrAddr2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrCity As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrState As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrZip As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrCountry As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrCustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.StrCustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastUpdated As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.LastUpdated, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LocationID As esQueryItem
			Get
				Return New esQueryItem(Me, TblARISELocationsMetadata.ColumnNames.LocationID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class TblARISELocationsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.Intlocationid, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.Intlocationid
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrClientLocationNum, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrClientLocationNum
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrClientNumber, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrClientNumber
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrClientName, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrClientName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrDivisionName, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrDivisionName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrCompanyLocationNumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrCompanyLocationNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrLocationName, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrLocationName
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrAddr1, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrAddr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrAddr2, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrAddr2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrCity, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrState, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrZip, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrZip
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrCountry, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.StrCustomAccess, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.StrCustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.LastUpdated, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.LastUpdated
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(TblARISELocationsMetadata.ColumnNames.LocationID, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TblARISELocationsMetadata.PropertyNames.LocationID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TblARISELocationsMetadata
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
			 Public Const Intlocationid As String = "intlocationid"
			 Public Const StrClientLocationNum As String = "strClientLocationNum"
			 Public Const StrClientNumber As String = "strClientNumber"
			 Public Const StrClientName As String = "strClientName"
			 Public Const StrDivisionName As String = "strDivisionName"
			 Public Const StrCompanyLocationNumber As String = "strCompanyLocationNumber"
			 Public Const StrLocationName As String = "strLocationName"
			 Public Const StrAddr1 As String = "strAddr1"
			 Public Const StrAddr2 As String = "strAddr2"
			 Public Const StrCity As String = "strCity"
			 Public Const StrState As String = "strState"
			 Public Const StrZip As String = "strZip"
			 Public Const StrCountry As String = "strCountry"
			 Public Const StrCustomAccess As String = "strCustomAccess"
			 Public Const LastUpdated As String = "LastUpdated"
			 Public Const LocationID As String = "LocationID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const Intlocationid As String = "Intlocationid"
			 Public Const StrClientLocationNum As String = "StrClientLocationNum"
			 Public Const StrClientNumber As String = "StrClientNumber"
			 Public Const StrClientName As String = "StrClientName"
			 Public Const StrDivisionName As String = "StrDivisionName"
			 Public Const StrCompanyLocationNumber As String = "StrCompanyLocationNumber"
			 Public Const StrLocationName As String = "StrLocationName"
			 Public Const StrAddr1 As String = "StrAddr1"
			 Public Const StrAddr2 As String = "StrAddr2"
			 Public Const StrCity As String = "StrCity"
			 Public Const StrState As String = "StrState"
			 Public Const StrZip As String = "StrZip"
			 Public Const StrCountry As String = "StrCountry"
			 Public Const StrCustomAccess As String = "StrCustomAccess"
			 Public Const LastUpdated As String = "LastUpdated"
			 Public Const LocationID As String = "LocationID"
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
			SyncLock GetType(TblARISELocationsMetadata)
			
				If TblARISELocationsMetadata.mapDelegates Is Nothing Then
					TblARISELocationsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TblARISELocationsMetadata._meta Is Nothing Then
					TblARISELocationsMetadata._meta = New TblARISELocationsMetadata()
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
				


				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Intlocationid", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("StrClientLocationNum", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrClientNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrClientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrDivisionName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrCompanyLocationNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrLocationName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrAddr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrAddr2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrZip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrCountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrCustomAccess", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LastUpdated", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LocationID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "tblARISELocations"
				meta.Destination = "tblARISELocations"
				
				meta.spInsert = "proc_tblARISELocationsInsert"
				meta.spUpdate = "proc_tblARISELocationsUpdate"
				meta.spDelete = "proc_tblARISELocationsDelete"
				meta.spLoadAll = "proc_tblARISELocationsLoadAll"
				meta.spLoadByPrimaryKey = "proc_tblARISELocationsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TblARISELocationsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
