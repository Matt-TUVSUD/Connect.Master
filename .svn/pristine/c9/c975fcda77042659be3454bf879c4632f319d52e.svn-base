
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2013 1:05:41 PM
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
	' Encapsulates the 'viewCCLocationListingJuris' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCLocationListingJuris))> _
	<XmlType("ViewCCLocationListingJuris")> _	
	Partial Public Class ViewCCLocationListingJuris 
		Inherits esViewCCLocationListingJuris
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCLocationListingJuris()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCLocationListingJurisCollection")> _
	Partial Public Class ViewCCLocationListingJurisCollection
		Inherits esViewCCLocationListingJurisCollection
		Implements IEnumerable(Of ViewCCLocationListingJuris)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCLocationListingJuris))> _
		Public Class ViewCCLocationListingJurisCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCLocationListingJurisCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCLocationListingJurisCollectionWCFPacket) As ViewCCLocationListingJurisCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCLocationListingJurisCollection) As ViewCCLocationListingJurisCollectionWCFPacket
				Return New ViewCCLocationListingJurisCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCLocationListingJurisQuery 
		Inherits esViewCCLocationListingJurisQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCLocationListingJurisQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCLocationListingJurisQuery) As String
			Return ViewCCLocationListingJurisQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCLocationListingJurisQuery
			Return DirectCast(ViewCCLocationListingJurisQuery.SerializeHelper.FromXml(query, GetType(ViewCCLocationListingJurisQuery)), ViewCCLocationListingJurisQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingJuris
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCLocationListingJuris.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strClientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrClientName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientName, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrClientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strCountry
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrCountry)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrCountry, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrCountry)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.COUNTRY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.intlocationid
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Intlocationid As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingJurisMetadata.ColumnNames.Intlocationid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingJurisMetadata.ColumnNames.Intlocationid, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Intlocationid)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strClientLocationNum
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrClientLocationNum As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientLocationNum)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientLocationNum, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrClientLocationNum)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.CLIENTLOCNO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientlocno As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Clientlocno)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Clientlocno, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Clientlocno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strClientNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrClientNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientNumber)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientNumber, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrClientNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strDivisionName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrDivisionName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrDivisionName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrDivisionName, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrDivisionName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.DIVISION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingJurisMetadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingJurisMetadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCLocationListingJurisMetadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCLocationListingJurisMetadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strCompanyLocationNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrCompanyLocationNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrCompanyLocationNumber)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrCompanyLocationNumber, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrCompanyLocationNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strLocationName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrLocationName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrLocationName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrLocationName, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrLocationName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.FACILITY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Facility As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Facility)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Facility, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Facility)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strAddr1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrAddr1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrAddr1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrAddr1, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrAddr1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.ADDRESS1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strAddr2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrAddr2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrAddr2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrAddr2, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrAddr2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strCity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrCity As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrCity)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrCity, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrCity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.CITY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.strState
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StrState As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrState)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.StrState, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.StrState)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.STPROV
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Stprov As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Stprov)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Stprov, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Stprov)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.ZIP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.100PercentUSTot
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _100PercentUSTot As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCLocationListingJurisMetadata.ColumnNames._100PercentUSTot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCLocationListingJurisMetadata.ColumnNames._100PercentUSTot, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames._100PercentUSTot)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.GSafeGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeGUID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.GSafeGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCLocationListingJurisMetadata.ColumnNames.GSafeGUID, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.GSafeGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.RecCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingJurisMetadata.ColumnNames.RecCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingJurisMetadata.ColumnNames.RecCount, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.RecCount)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCLocationListingJuris.RecNum
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCLocationListingJurisMetadata.ColumnNames.RecNum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCLocationListingJurisMetadata.ColumnNames.RecNum, value) Then
					OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.RecNum)
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
												
						Case "StrClientName"
							Me.str().StrClientName = CType(value, string)
												
						Case "StrCountry"
							Me.str().StrCountry = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "Intlocationid"
							Me.str().Intlocationid = CType(value, string)
												
						Case "StrClientLocationNum"
							Me.str().StrClientLocationNum = CType(value, string)
												
						Case "Clientlocno"
							Me.str().Clientlocno = CType(value, string)
												
						Case "StrClientNumber"
							Me.str().StrClientNumber = CType(value, string)
												
						Case "StrDivisionName"
							Me.str().StrDivisionName = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "StrCompanyLocationNumber"
							Me.str().StrCompanyLocationNumber = CType(value, string)
												
						Case "StrLocationName"
							Me.str().StrLocationName = CType(value, string)
												
						Case "Facility"
							Me.str().Facility = CType(value, string)
												
						Case "StrAddr1"
							Me.str().StrAddr1 = CType(value, string)
												
						Case "Address1"
							Me.str().Address1 = CType(value, string)
												
						Case "StrAddr2"
							Me.str().StrAddr2 = CType(value, string)
												
						Case "StrCity"
							Me.str().StrCity = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "StrState"
							Me.str().StrState = CType(value, string)
												
						Case "Stprov"
							Me.str().Stprov = CType(value, string)
												
						Case "Zip"
							Me.str().Zip = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "_100PercentUSTot"
							Me.str()._100PercentUSTot = CType(value, string)
												
						Case "GSafeGUID"
							Me.str().GSafeGUID = CType(value, string)
												
						Case "RecCount"
							Me.str().RecCount = CType(value, string)
												
						Case "RecNum"
							Me.str().RecNum = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Intlocationid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Intlocationid = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Intlocationid)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.Longitude)
							End If
						
						Case "_100PercentUSTot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me._100PercentUSTot = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames._100PercentUSTot)
							End If
						
						Case "RecCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.RecCount)
							End If
						
						Case "RecNum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNum = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCLocationListingJurisMetadata.PropertyNames.RecNum)
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
		
			Public Sub New(ByVal entity As esViewCCLocationListingJuris)
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
		  	
			Public Property Country As System.String 
				Get
					Dim data_ As System.String = entity.Country
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Country = Nothing
					Else
						entity.Country = Convert.ToString(Value)
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
		  	
			Public Property Clientlocno As System.String 
				Get
					Dim data_ As System.String = entity.Clientlocno
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Clientlocno = Nothing
					Else
						entity.Clientlocno = Convert.ToString(Value)
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
		  	
			Public Property Division As System.String 
				Get
					Dim data_ As System.String = entity.Division
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Division = Nothing
					Else
						entity.Division = Convert.ToString(Value)
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
		  	
			Public Property Facility As System.String 
				Get
					Dim data_ As System.String = entity.Facility
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Facility = Nothing
					Else
						entity.Facility = Convert.ToString(Value)
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
		  	
			Public Property Address1 As System.String 
				Get
					Dim data_ As System.String = entity.Address1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address1 = Nothing
					Else
						entity.Address1 = Convert.ToString(Value)
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
		  	
			Public Property Stprov As System.String 
				Get
					Dim data_ As System.String = entity.Stprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stprov = Nothing
					Else
						entity.Stprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Zip As System.String 
				Get
					Dim data_ As System.String = entity.Zip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Zip = Nothing
					Else
						entity.Zip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomAccess As System.String 
				Get
					Dim data_ As System.String = entity.CustomAccess
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomAccess = Nothing
					Else
						entity.CustomAccess = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _100PercentUSTot As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity._100PercentUSTot
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._100PercentUSTot = Nothing
					Else
						entity._100PercentUSTot = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property GSafeGUID As System.String 
				Get
					Dim data_ As System.String = entity.GSafeGUID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GSafeGUID = Nothing
					Else
						entity.GSafeGUID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecCount As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecCount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCount = Nothing
					Else
						entity.RecCount = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecNum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecNum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecNum = Nothing
					Else
						entity.RecNum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCLocationListingJuris
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingJurisMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCLocationListingJurisQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingJurisQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCLocationListingJurisQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCLocationListingJurisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCLocationListingJurisQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCLocationListingJurisCollection
		Inherits esEntityCollection(Of ViewCCLocationListingJuris)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingJurisMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCLocationListingJurisCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCLocationListingJurisQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCLocationListingJurisQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCLocationListingJurisQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCLocationListingJurisQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCLocationListingJurisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCLocationListingJurisQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCLocationListingJurisQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCLocationListingJurisQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCLocationListingJurisMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "StrClientName" 
					Return Me.StrClientName
				Case "StrCountry" 
					Return Me.StrCountry
				Case "Country" 
					Return Me.Country
				Case "Intlocationid" 
					Return Me.Intlocationid
				Case "StrClientLocationNum" 
					Return Me.StrClientLocationNum
				Case "Clientlocno" 
					Return Me.Clientlocno
				Case "StrClientNumber" 
					Return Me.StrClientNumber
				Case "StrDivisionName" 
					Return Me.StrDivisionName
				Case "Division" 
					Return Me.Division
				Case "Latitude" 
					Return Me.Latitude
				Case "Longitude" 
					Return Me.Longitude
				Case "StrCompanyLocationNumber" 
					Return Me.StrCompanyLocationNumber
				Case "StrLocationName" 
					Return Me.StrLocationName
				Case "Facility" 
					Return Me.Facility
				Case "StrAddr1" 
					Return Me.StrAddr1
				Case "Address1" 
					Return Me.Address1
				Case "StrAddr2" 
					Return Me.StrAddr2
				Case "StrCity" 
					Return Me.StrCity
				Case "City" 
					Return Me.City
				Case "StrState" 
					Return Me.StrState
				Case "Stprov" 
					Return Me.Stprov
				Case "Zip" 
					Return Me.Zip
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "_100PercentUSTot" 
					Return Me._100PercentUSTot
				Case "GSafeGUID" 
					Return Me.GSafeGUID
				Case "RecCount" 
					Return Me.RecCount
				Case "RecNum" 
					Return Me.RecNum
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrClientName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrClientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Intlocationid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Intlocationid, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property StrClientLocationNum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrClientLocationNum, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Clientlocno As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Clientlocno, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrClientNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrClientNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrDivisionName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrDivisionName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property StrCompanyLocationNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrCompanyLocationNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrLocationName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrLocationName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Facility As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Facility, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrAddr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrAddr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrAddr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrAddr2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StrState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.StrState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Stprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _100PercentUSTot As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames._100PercentUSTot, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property GSafeGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.GSafeGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.RecCount, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecNum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCLocationListingJurisMetadata.ColumnNames.RecNum, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCLocationListingJurisMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrClientName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrCountry, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Country, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Country
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Intlocationid, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Intlocationid
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientLocationNum, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrClientLocationNum
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Clientlocno, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Clientlocno
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrClientNumber, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrClientNumber
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrDivisionName, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrDivisionName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Division, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Division
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Latitude, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Longitude, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrCompanyLocationNumber, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrCompanyLocationNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrLocationName, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrLocationName
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Facility, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Facility
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrAddr1, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrAddr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Address1, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Address1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrAddr2, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrAddr2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrCity, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.City, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.City
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.StrState, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.StrState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Stprov, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Stprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.Zip, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.Zip
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.CustomAccess, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames._100PercentUSTot, 24, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames._100PercentUSTot
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.GSafeGUID, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.GSafeGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.RecCount, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.RecCount
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCLocationListingJurisMetadata.ColumnNames.RecNum, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCLocationListingJurisMetadata.PropertyNames.RecNum
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCLocationListingJurisMetadata
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
			 Public Const StrClientName As String = "strClientName"
			 Public Const StrCountry As String = "strCountry"
			 Public Const Country As String = "COUNTRY"
			 Public Const Intlocationid As String = "intlocationid"
			 Public Const StrClientLocationNum As String = "strClientLocationNum"
			 Public Const Clientlocno As String = "CLIENTLOCNO"
			 Public Const StrClientNumber As String = "strClientNumber"
			 Public Const StrDivisionName As String = "strDivisionName"
			 Public Const Division As String = "DIVISION"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const StrCompanyLocationNumber As String = "strCompanyLocationNumber"
			 Public Const StrLocationName As String = "strLocationName"
			 Public Const Facility As String = "FACILITY"
			 Public Const StrAddr1 As String = "strAddr1"
			 Public Const Address1 As String = "ADDRESS1"
			 Public Const StrAddr2 As String = "strAddr2"
			 Public Const StrCity As String = "strCity"
			 Public Const City As String = "CITY"
			 Public Const StrState As String = "strState"
			 Public Const Stprov As String = "STPROV"
			 Public Const Zip As String = "ZIP"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const _100PercentUSTot As String = "100PercentUSTot"
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const RecCount As String = "RecCount"
			 Public Const RecNum As String = "RecNum"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const StrClientName As String = "StrClientName"
			 Public Const StrCountry As String = "StrCountry"
			 Public Const Country As String = "Country"
			 Public Const Intlocationid As String = "Intlocationid"
			 Public Const StrClientLocationNum As String = "StrClientLocationNum"
			 Public Const Clientlocno As String = "Clientlocno"
			 Public Const StrClientNumber As String = "StrClientNumber"
			 Public Const StrDivisionName As String = "StrDivisionName"
			 Public Const Division As String = "Division"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const StrCompanyLocationNumber As String = "StrCompanyLocationNumber"
			 Public Const StrLocationName As String = "StrLocationName"
			 Public Const Facility As String = "Facility"
			 Public Const StrAddr1 As String = "StrAddr1"
			 Public Const Address1 As String = "Address1"
			 Public Const StrAddr2 As String = "StrAddr2"
			 Public Const StrCity As String = "StrCity"
			 Public Const City As String = "City"
			 Public Const StrState As String = "StrState"
			 Public Const Stprov As String = "Stprov"
			 Public Const Zip As String = "Zip"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const _100PercentUSTot As String = "_100PercentUSTot"
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const RecCount As String = "RecCount"
			 Public Const RecNum As String = "RecNum"
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
			SyncLock GetType(ViewCCLocationListingJurisMetadata)
			
				If ViewCCLocationListingJurisMetadata.mapDelegates Is Nothing Then
					ViewCCLocationListingJurisMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCLocationListingJurisMetadata._meta Is Nothing Then
					ViewCCLocationListingJurisMetadata._meta = New ViewCCLocationListingJurisMetadata()
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
				meta.AddTypeMap("StrClientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrCountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Intlocationid", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("StrClientLocationNum", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Clientlocno", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrClientNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrDivisionName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Division", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("StrCompanyLocationNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrLocationName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Facility", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrAddr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Address1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrAddr2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("StrState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Zip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_100PercentUSTot", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("GSafeGUID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecCount", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecNum", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCLocationListingJuris"
				meta.Destination = "viewCCLocationListingJuris"
				
				meta.spInsert = "proc_viewCCLocationListingJurisInsert"
				meta.spUpdate = "proc_viewCCLocationListingJurisUpdate"
				meta.spDelete = "proc_viewCCLocationListingJurisDelete"
				meta.spLoadAll = "proc_viewCCLocationListingJurisLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCLocationListingJurisLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCLocationListingJurisMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
