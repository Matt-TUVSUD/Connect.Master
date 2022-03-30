
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/4/2019 9:37:44 PM
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
	' Encapsulates the 'viewCCFireFacilityRating' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCFireFacilityRating))> _
	<XmlType("ViewCCFireFacilityRating")> _	
	Partial Public Class ViewCCFireFacilityRating 
		Inherits esViewCCFireFacilityRating
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCFireFacilityRating()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCFireFacilityRatingCollection")> _
	Partial Public Class ViewCCFireFacilityRatingCollection
		Inherits esViewCCFireFacilityRatingCollection
		Implements IEnumerable(Of ViewCCFireFacilityRating)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCFireFacilityRating))> _
		Public Class ViewCCFireFacilityRatingCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCFireFacilityRatingCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCFireFacilityRatingCollectionWCFPacket) As ViewCCFireFacilityRatingCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCFireFacilityRatingCollection) As ViewCCFireFacilityRatingCollectionWCFPacket
				Return New ViewCCFireFacilityRatingCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCFireFacilityRatingQuery 
		Inherits esViewCCFireFacilityRatingQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCFireFacilityRatingQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCFireFacilityRatingQuery) As String
			Return ViewCCFireFacilityRatingQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCFireFacilityRatingQuery
			Return DirectCast(ViewCCFireFacilityRatingQuery.SerializeHelper.FromXml(query, GetType(ViewCCFireFacilityRatingQuery)), ViewCCFireFacilityRatingQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCFireFacilityRating
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCFireFacilityRating.GSafeGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeGUID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.GSafeGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.GSafeGUID, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.GSafeGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.Currency
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Currency As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Currency)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Currency, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Currency)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.CurrencyCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrencyCode As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.CurrencyCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.CurrencyCode, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.CurrencyCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.CurrencySymbol
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrencySymbol As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.CurrencySymbol)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.CurrencySymbol, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.CurrencySymbol)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLString As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLString, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLWITHALLRECSCOMPLETEString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWITHALLRECSCOMPLETEString As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLWITHALLRECSCOMPLETEString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLWITHALLRECSCOMPLETEString, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLWITHALLRECSCOMPLETEString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Apl As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Apl)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Apl, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Apl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLWITHALLRECSCOMPLETE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplwithallrecscomplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplwithallrecscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplwithallrecscomplete, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Aplwithallrecscomplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FILENO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fileno As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Fileno)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Fileno, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Fileno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.INSPECTIONDATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Inspectiondate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCFireFacilityRatingMetadata.ColumnNames.Inspectiondate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCFireFacilityRatingMetadata.ColumnNames.Inspectiondate, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Inspectiondate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FLOODWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Floodweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Floodweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.EARTHQUAKEWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Earthquakeweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakeweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakeweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakeweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.WINDSTORMWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Windstormweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.CONSTRUCTIONWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Constructionweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Constructionweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OCCUPANCYWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occupancyweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancyweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OTHERWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Otherweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Otherweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FLOODRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Floodrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Floodrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.EARTHQUAKERATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Earthquakerating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakerating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakerating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakerating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.WINDSTORMRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Windstormrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.CONSTRUCTIONRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Constructionrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Constructionrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OCCUPANCYRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occupancyrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancyrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OTHERRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Otherrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Otherrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FLOODDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Flooddescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Flooddescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Flooddescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Flooddescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.EARTHQUAKEDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Earthquakedescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakedescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakedescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakedescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.WINDSTORMDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Windstormdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormdescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormdescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormdescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.CONSTRUCTIONDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Constructiondescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructiondescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructiondescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Constructiondescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OCCUPANCYDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occupancydescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancydescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancydescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancydescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OTHERDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Otherdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherdescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherdescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Otherdescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.PASSIVESCORE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Passivescore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Passivescore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Passivescore, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Passivescore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.PHYSICALPROTECTIONWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Physicalprotectionweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Physicalprotectionweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.HUMANELEMENTWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Humanelementweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.NATURALHAZARDSPROTECTIONWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Naturalhazardsprotectionweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalhazardsprotectionweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.BUSINESSCONTINUITYWEIGHT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Businesscontinuityweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityweight, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Businesscontinuityweight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.PHYSICALPROTECTIONRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Physicalprotectionrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Physicalprotectionrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.HUMANELEMENTRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Humanelementrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.NATURALHAZARDSPROTECTIONRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Naturalhazardsprotectionrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalhazardsprotectionrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.BUSINESSCONTINUITYRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Businesscontinuityrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Businesscontinuityrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FIREDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Firedescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Firedescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Firedescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Firedescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.HUMANDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Humandescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Humandescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Humandescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humandescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.NATURALDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Naturaldescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturaldescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturaldescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Naturaldescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.BUSINESSDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Businessdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Businessdescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Businessdescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Businessdescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FIREPROTECTIONALLRECSCOMPLETERATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fireprotectionallrecscompleterating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Fireprotectionallrecscompleterating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Fireprotectionallrecscompleterating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Fireprotectionallrecscompleterating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.HUMANELEMENTALLRECSCOMPLETERATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Humanelementallrecscompleterating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementallrecscompleterating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementallrecscompleterating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementallrecscompleterating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.NATHAZPROTALLRECSCOMPLETERATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Nathazprotallrecscompleterating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Nathazprotallrecscompleterating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Nathazprotallrecscompleterating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Nathazprotallrecscompleterating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.BCPALLRECSCOMPLETRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bcpallrecscompletrating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Bcpallrecscompletrating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Bcpallrecscompletrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Bcpallrecscompletrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FIRERECDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Firerecdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Firerecdescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Firerecdescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Firerecdescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.HUMANRECDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Humanrecdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanrecdescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanrecdescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanrecdescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.NATURALRECDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Naturalrecdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalrecdescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalrecdescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalrecdescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.BUSINESSRECDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Businessrecdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Businessrecdescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Businessrecdescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Businessrecdescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.ACTIVESCORE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Activescore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Activescore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Activescore, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Activescore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.ACTIVESCOREWITHRECSCOMPLETE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Activescorewithrecscomplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Activescorewithrecscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Activescorewithrecscomplete, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Activescorewithrecscomplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.TOTALSCORE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Totalscore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Totalscore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Totalscore, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Totalscore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLFACTOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplfactor As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplfactor)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplfactor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Aplfactor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OVERALLPLANTRATINGRATING
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Overallplantratingrating As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallplantratingrating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallplantratingrating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Overallplantratingrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OVERALLSCOREWITHRECSCOMPLETE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Overallscorewithrecscomplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallscorewithrecscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallscorewithrecscomplete, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Overallscorewithrecscomplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLFACTORWITHALLRECSCOMPLETE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aplfactorwithallrecscomplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplfactorwithallrecscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplfactorwithallrecscomplete, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Aplfactorwithallrecscomplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.MAXPOSSIBLESCORE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Maxpossiblescore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescore, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Maxpossiblescore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FLOODRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Floodratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Floodratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.EARTHQUAKERATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Earthquakeratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakeratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakeratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakeratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.WINDSTORMRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Windstormratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.CONSTRUCTIONRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Constructionratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Constructionratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OCCUPANCYRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occupancyratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancyratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OTHERRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Otherratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Otherratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.PHYSICALPROTECTIONRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Physicalprotectionratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Physicalprotectionratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.HUMANELEMENTRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Humanelementratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.NATURALHAZARDSPROTECTIONRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Naturalhazardsprotectionratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalhazardsprotectionratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.BUSINESSCONTINUITYRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Businesscontinuityratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Businesscontinuityratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.FIREPROTECTIONALLRECSCOMPLETERATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fireprotectionallrecscompleteratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Fireprotectionallrecscompleteratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Fireprotectionallrecscompleteratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Fireprotectionallrecscompleteratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.HUMANELEMENTALLRECSCOMPLETERATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Humanelementallrecscompleteratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementallrecscompleteratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementallrecscompleteratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementallrecscompleteratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.NATHAZPROTALLRECSCOMPLETERATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Nathazprotallrecscompleteratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Nathazprotallrecscompleteratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Nathazprotallrecscompleteratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Nathazprotallrecscompleteratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.BCPALLRECSCOMPLETRATINGCOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Bcpallrecscompletratingcolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Bcpallrecscompletratingcolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Bcpallrecscompletratingcolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Bcpallrecscompletratingcolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.TOTALSCORECOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Totalscorecolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Totalscorecolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Totalscorecolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Totalscorecolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OVERALLPLANTRATINGDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Overallplantratingdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallplantratingdescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallplantratingdescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Overallplantratingdescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.MAXPOSSIBLESCORECOLOR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Maxpossiblescorecolor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescorecolor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescorecolor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Maxpossiblescorecolor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.MAXPOSSIBLESCOREDESCRIPTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Maxpossiblescoredescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescoredescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescoredescription, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Maxpossiblescoredescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLKeyRange1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLKeyRange1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange1, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyRange1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLKeyFactor1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLKeyFactor1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor1, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyFactor1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLKeyRange2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLKeyRange2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange2, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyRange2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLKeyFactor2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLKeyFactor2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor2, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyFactor2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLKeyRange3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLKeyRange3 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange3, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyRange3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLKeyFactor3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLKeyFactor3 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor3, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyFactor3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLKeyRange4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLKeyRange4 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange4, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyRange4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.APLKeyFactor4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLKeyFactor4 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor4, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyFactor4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyDescription5
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription5 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription5)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription5, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription5)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyDescription4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription4 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription4, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyDescription3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription3 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription3, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyDescription2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription2, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyDescription1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyDescription1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription1, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyColor5
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor5 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor5)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor5, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor5)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyColor4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor4 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor4, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyColor3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor3 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor3, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyColor2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor2, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.RatingKeyColor1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingKeyColor1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor1, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.AchievableScorePercentString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AchievableScorePercentString As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.AchievableScorePercentString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.AchievableScorePercentString, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.AchievableScorePercentString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.AchievableScorePercent
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AchievableScorePercent As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.AchievableScorePercent)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ViewCCFireFacilityRatingMetadata.ColumnNames.AchievableScorePercent, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.AchievableScorePercent)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OverallScoreWithRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallScoreWithRecsCompleteRating As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.OverallScoreWithRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OverallScoreWithRecsCompleteHexBackColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallScoreWithRecsCompleteHexBackColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteHexBackColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteHexBackColor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.OverallScoreWithRecsCompleteHexBackColor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCFireFacilityRating.OverallScoreWithRecsCompleteHexForeColor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallScoreWithRecsCompleteHexForeColor As System.String
			Get
				Return MyBase.GetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteHexForeColor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteHexForeColor, value) Then
					OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.OverallScoreWithRecsCompleteHexForeColor)
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
												
						Case "GSafeGUID"
							Me.str().GSafeGUID = CType(value, string)
												
						Case "Currency"
							Me.str().Currency = CType(value, string)
												
						Case "CurrencyCode"
							Me.str().CurrencyCode = CType(value, string)
												
						Case "CurrencySymbol"
							Me.str().CurrencySymbol = CType(value, string)
												
						Case "APLString"
							Me.str().APLString = CType(value, string)
												
						Case "APLWITHALLRECSCOMPLETEString"
							Me.str().APLWITHALLRECSCOMPLETEString = CType(value, string)
												
						Case "Apl"
							Me.str().Apl = CType(value, string)
												
						Case "Aplwithallrecscomplete"
							Me.str().Aplwithallrecscomplete = CType(value, string)
												
						Case "Id"
							Me.str().Id = CType(value, string)
												
						Case "Fileno"
							Me.str().Fileno = CType(value, string)
												
						Case "Inspectiondate"
							Me.str().Inspectiondate = CType(value, string)
												
						Case "Floodweight"
							Me.str().Floodweight = CType(value, string)
												
						Case "Earthquakeweight"
							Me.str().Earthquakeweight = CType(value, string)
												
						Case "Windstormweight"
							Me.str().Windstormweight = CType(value, string)
												
						Case "Constructionweight"
							Me.str().Constructionweight = CType(value, string)
												
						Case "Occupancyweight"
							Me.str().Occupancyweight = CType(value, string)
												
						Case "Otherweight"
							Me.str().Otherweight = CType(value, string)
												
						Case "Floodrating"
							Me.str().Floodrating = CType(value, string)
												
						Case "Earthquakerating"
							Me.str().Earthquakerating = CType(value, string)
												
						Case "Windstormrating"
							Me.str().Windstormrating = CType(value, string)
												
						Case "Constructionrating"
							Me.str().Constructionrating = CType(value, string)
												
						Case "Occupancyrating"
							Me.str().Occupancyrating = CType(value, string)
												
						Case "Otherrating"
							Me.str().Otherrating = CType(value, string)
												
						Case "Flooddescription"
							Me.str().Flooddescription = CType(value, string)
												
						Case "Earthquakedescription"
							Me.str().Earthquakedescription = CType(value, string)
												
						Case "Windstormdescription"
							Me.str().Windstormdescription = CType(value, string)
												
						Case "Constructiondescription"
							Me.str().Constructiondescription = CType(value, string)
												
						Case "Occupancydescription"
							Me.str().Occupancydescription = CType(value, string)
												
						Case "Otherdescription"
							Me.str().Otherdescription = CType(value, string)
												
						Case "Passivescore"
							Me.str().Passivescore = CType(value, string)
												
						Case "Physicalprotectionweight"
							Me.str().Physicalprotectionweight = CType(value, string)
												
						Case "Humanelementweight"
							Me.str().Humanelementweight = CType(value, string)
												
						Case "Naturalhazardsprotectionweight"
							Me.str().Naturalhazardsprotectionweight = CType(value, string)
												
						Case "Businesscontinuityweight"
							Me.str().Businesscontinuityweight = CType(value, string)
												
						Case "Physicalprotectionrating"
							Me.str().Physicalprotectionrating = CType(value, string)
												
						Case "Humanelementrating"
							Me.str().Humanelementrating = CType(value, string)
												
						Case "Naturalhazardsprotectionrating"
							Me.str().Naturalhazardsprotectionrating = CType(value, string)
												
						Case "Businesscontinuityrating"
							Me.str().Businesscontinuityrating = CType(value, string)
												
						Case "Firedescription"
							Me.str().Firedescription = CType(value, string)
												
						Case "Humandescription"
							Me.str().Humandescription = CType(value, string)
												
						Case "Naturaldescription"
							Me.str().Naturaldescription = CType(value, string)
												
						Case "Businessdescription"
							Me.str().Businessdescription = CType(value, string)
												
						Case "Fireprotectionallrecscompleterating"
							Me.str().Fireprotectionallrecscompleterating = CType(value, string)
												
						Case "Humanelementallrecscompleterating"
							Me.str().Humanelementallrecscompleterating = CType(value, string)
												
						Case "Nathazprotallrecscompleterating"
							Me.str().Nathazprotallrecscompleterating = CType(value, string)
												
						Case "Bcpallrecscompletrating"
							Me.str().Bcpallrecscompletrating = CType(value, string)
												
						Case "Firerecdescription"
							Me.str().Firerecdescription = CType(value, string)
												
						Case "Humanrecdescription"
							Me.str().Humanrecdescription = CType(value, string)
												
						Case "Naturalrecdescription"
							Me.str().Naturalrecdescription = CType(value, string)
												
						Case "Businessrecdescription"
							Me.str().Businessrecdescription = CType(value, string)
												
						Case "Activescore"
							Me.str().Activescore = CType(value, string)
												
						Case "Activescorewithrecscomplete"
							Me.str().Activescorewithrecscomplete = CType(value, string)
												
						Case "Totalscore"
							Me.str().Totalscore = CType(value, string)
												
						Case "Aplfactor"
							Me.str().Aplfactor = CType(value, string)
												
						Case "Overallplantratingrating"
							Me.str().Overallplantratingrating = CType(value, string)
												
						Case "Overallscorewithrecscomplete"
							Me.str().Overallscorewithrecscomplete = CType(value, string)
												
						Case "Aplfactorwithallrecscomplete"
							Me.str().Aplfactorwithallrecscomplete = CType(value, string)
												
						Case "Maxpossiblescore"
							Me.str().Maxpossiblescore = CType(value, string)
												
						Case "Floodratingcolor"
							Me.str().Floodratingcolor = CType(value, string)
												
						Case "Earthquakeratingcolor"
							Me.str().Earthquakeratingcolor = CType(value, string)
												
						Case "Windstormratingcolor"
							Me.str().Windstormratingcolor = CType(value, string)
												
						Case "Constructionratingcolor"
							Me.str().Constructionratingcolor = CType(value, string)
												
						Case "Occupancyratingcolor"
							Me.str().Occupancyratingcolor = CType(value, string)
												
						Case "Otherratingcolor"
							Me.str().Otherratingcolor = CType(value, string)
												
						Case "Physicalprotectionratingcolor"
							Me.str().Physicalprotectionratingcolor = CType(value, string)
												
						Case "Humanelementratingcolor"
							Me.str().Humanelementratingcolor = CType(value, string)
												
						Case "Naturalhazardsprotectionratingcolor"
							Me.str().Naturalhazardsprotectionratingcolor = CType(value, string)
												
						Case "Businesscontinuityratingcolor"
							Me.str().Businesscontinuityratingcolor = CType(value, string)
												
						Case "Fireprotectionallrecscompleteratingcolor"
							Me.str().Fireprotectionallrecscompleteratingcolor = CType(value, string)
												
						Case "Humanelementallrecscompleteratingcolor"
							Me.str().Humanelementallrecscompleteratingcolor = CType(value, string)
												
						Case "Nathazprotallrecscompleteratingcolor"
							Me.str().Nathazprotallrecscompleteratingcolor = CType(value, string)
												
						Case "Bcpallrecscompletratingcolor"
							Me.str().Bcpallrecscompletratingcolor = CType(value, string)
												
						Case "Totalscorecolor"
							Me.str().Totalscorecolor = CType(value, string)
												
						Case "Overallplantratingdescription"
							Me.str().Overallplantratingdescription = CType(value, string)
												
						Case "Maxpossiblescorecolor"
							Me.str().Maxpossiblescorecolor = CType(value, string)
												
						Case "Maxpossiblescoredescription"
							Me.str().Maxpossiblescoredescription = CType(value, string)
												
						Case "APLKeyRange1"
							Me.str().APLKeyRange1 = CType(value, string)
												
						Case "APLKeyFactor1"
							Me.str().APLKeyFactor1 = CType(value, string)
												
						Case "APLKeyRange2"
							Me.str().APLKeyRange2 = CType(value, string)
												
						Case "APLKeyFactor2"
							Me.str().APLKeyFactor2 = CType(value, string)
												
						Case "APLKeyRange3"
							Me.str().APLKeyRange3 = CType(value, string)
												
						Case "APLKeyFactor3"
							Me.str().APLKeyFactor3 = CType(value, string)
												
						Case "APLKeyRange4"
							Me.str().APLKeyRange4 = CType(value, string)
												
						Case "APLKeyFactor4"
							Me.str().APLKeyFactor4 = CType(value, string)
												
						Case "RatingKeyDescription5"
							Me.str().RatingKeyDescription5 = CType(value, string)
												
						Case "RatingKeyDescription4"
							Me.str().RatingKeyDescription4 = CType(value, string)
												
						Case "RatingKeyDescription3"
							Me.str().RatingKeyDescription3 = CType(value, string)
												
						Case "RatingKeyDescription2"
							Me.str().RatingKeyDescription2 = CType(value, string)
												
						Case "RatingKeyDescription1"
							Me.str().RatingKeyDescription1 = CType(value, string)
												
						Case "RatingKeyColor5"
							Me.str().RatingKeyColor5 = CType(value, string)
												
						Case "RatingKeyColor4"
							Me.str().RatingKeyColor4 = CType(value, string)
												
						Case "RatingKeyColor3"
							Me.str().RatingKeyColor3 = CType(value, string)
												
						Case "RatingKeyColor2"
							Me.str().RatingKeyColor2 = CType(value, string)
												
						Case "RatingKeyColor1"
							Me.str().RatingKeyColor1 = CType(value, string)
												
						Case "AchievableScorePercentString"
							Me.str().AchievableScorePercentString = CType(value, string)
												
						Case "AchievableScorePercent"
							Me.str().AchievableScorePercent = CType(value, string)
												
						Case "OverallScoreWithRecsCompleteRating"
							Me.str().OverallScoreWithRecsCompleteRating = CType(value, string)
												
						Case "OverallScoreWithRecsCompleteHexBackColor"
							Me.str().OverallScoreWithRecsCompleteHexBackColor = CType(value, string)
												
						Case "OverallScoreWithRecsCompleteHexForeColor"
							Me.str().OverallScoreWithRecsCompleteHexForeColor = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apl"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Apl = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Apl)
							End If
						
						Case "Aplwithallrecscomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Aplwithallrecscomplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Aplwithallrecscomplete)
							End If
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Id = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Id)
							End If
						
						Case "Inspectiondate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Inspectiondate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Inspectiondate)
							End If
						
						Case "Floodweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Floodweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Floodweight)
							End If
						
						Case "Earthquakeweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Earthquakeweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakeweight)
							End If
						
						Case "Windstormweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Windstormweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormweight)
							End If
						
						Case "Constructionweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Constructionweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Constructionweight)
							End If
						
						Case "Occupancyweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Occupancyweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancyweight)
							End If
						
						Case "Otherweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Otherweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Otherweight)
							End If
						
						Case "Floodrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Floodrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Floodrating)
							End If
						
						Case "Earthquakerating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Earthquakerating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakerating)
							End If
						
						Case "Windstormrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Windstormrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormrating)
							End If
						
						Case "Constructionrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Constructionrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Constructionrating)
							End If
						
						Case "Occupancyrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Occupancyrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancyrating)
							End If
						
						Case "Otherrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Otherrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Otherrating)
							End If
						
						Case "Passivescore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Passivescore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Passivescore)
							End If
						
						Case "Physicalprotectionweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Physicalprotectionweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Physicalprotectionweight)
							End If
						
						Case "Humanelementweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Humanelementweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementweight)
							End If
						
						Case "Naturalhazardsprotectionweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Naturalhazardsprotectionweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalhazardsprotectionweight)
							End If
						
						Case "Businesscontinuityweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Businesscontinuityweight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Businesscontinuityweight)
							End If
						
						Case "Physicalprotectionrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Physicalprotectionrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Physicalprotectionrating)
							End If
						
						Case "Humanelementrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Humanelementrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementrating)
							End If
						
						Case "Naturalhazardsprotectionrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Naturalhazardsprotectionrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalhazardsprotectionrating)
							End If
						
						Case "Businesscontinuityrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Businesscontinuityrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Businesscontinuityrating)
							End If
						
						Case "Fireprotectionallrecscompleterating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Fireprotectionallrecscompleterating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Fireprotectionallrecscompleterating)
							End If
						
						Case "Humanelementallrecscompleterating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Humanelementallrecscompleterating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementallrecscompleterating)
							End If
						
						Case "Nathazprotallrecscompleterating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Nathazprotallrecscompleterating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Nathazprotallrecscompleterating)
							End If
						
						Case "Bcpallrecscompletrating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Bcpallrecscompletrating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Bcpallrecscompletrating)
							End If
						
						Case "Activescore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Activescore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Activescore)
							End If
						
						Case "Activescorewithrecscomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Activescorewithrecscomplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Activescorewithrecscomplete)
							End If
						
						Case "Totalscore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Totalscore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Totalscore)
							End If
						
						Case "Aplfactor"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Aplfactor = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Aplfactor)
							End If
						
						Case "Overallscorewithrecscomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Overallscorewithrecscomplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Overallscorewithrecscomplete)
							End If
						
						Case "Aplfactorwithallrecscomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Aplfactorwithallrecscomplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Aplfactorwithallrecscomplete)
							End If
						
						Case "Maxpossiblescore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Maxpossiblescore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.Maxpossiblescore)
							End If
						
						Case "AchievableScorePercent"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.AchievableScorePercent = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(ViewCCFireFacilityRatingMetadata.PropertyNames.AchievableScorePercent)
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
		
			Public Sub New(ByVal entity As esViewCCFireFacilityRating)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Currency As System.String 
				Get
					Dim data_ As System.String = entity.Currency
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Currency = Nothing
					Else
						entity.Currency = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CurrencyCode As System.String 
				Get
					Dim data_ As System.String = entity.CurrencyCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CurrencyCode = Nothing
					Else
						entity.CurrencyCode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CurrencySymbol As System.String 
				Get
					Dim data_ As System.String = entity.CurrencySymbol
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CurrencySymbol = Nothing
					Else
						entity.CurrencySymbol = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLString As System.String 
				Get
					Dim data_ As System.String = entity.APLString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLString = Nothing
					Else
						entity.APLString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWITHALLRECSCOMPLETEString As System.String 
				Get
					Dim data_ As System.String = entity.APLWITHALLRECSCOMPLETEString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWITHALLRECSCOMPLETEString = Nothing
					Else
						entity.APLWITHALLRECSCOMPLETEString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apl As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Apl
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apl = Nothing
					Else
						entity.Apl = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Aplwithallrecscomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Aplwithallrecscomplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aplwithallrecscomplete = Nothing
					Else
						entity.Aplwithallrecscomplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Id
					
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
						entity.Id = Convert.ToDecimal(Value)
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
		  	
			Public Property Inspectiondate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Inspectiondate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inspectiondate = Nothing
					Else
						entity.Inspectiondate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Floodweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Floodweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Floodweight = Nothing
					Else
						entity.Floodweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Earthquakeweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Earthquakeweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Earthquakeweight = Nothing
					Else
						entity.Earthquakeweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Windstormweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Windstormweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Windstormweight = Nothing
					Else
						entity.Windstormweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Constructionweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Constructionweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Constructionweight = Nothing
					Else
						entity.Constructionweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occupancyweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Occupancyweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occupancyweight = Nothing
					Else
						entity.Occupancyweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Otherweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Otherweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Otherweight = Nothing
					Else
						entity.Otherweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Floodrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Floodrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Floodrating = Nothing
					Else
						entity.Floodrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Earthquakerating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Earthquakerating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Earthquakerating = Nothing
					Else
						entity.Earthquakerating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Windstormrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Windstormrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Windstormrating = Nothing
					Else
						entity.Windstormrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Constructionrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Constructionrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Constructionrating = Nothing
					Else
						entity.Constructionrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occupancyrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Occupancyrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occupancyrating = Nothing
					Else
						entity.Occupancyrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Otherrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Otherrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Otherrating = Nothing
					Else
						entity.Otherrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Flooddescription As System.String 
				Get
					Dim data_ As System.String = entity.Flooddescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Flooddescription = Nothing
					Else
						entity.Flooddescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Earthquakedescription As System.String 
				Get
					Dim data_ As System.String = entity.Earthquakedescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Earthquakedescription = Nothing
					Else
						entity.Earthquakedescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Windstormdescription As System.String 
				Get
					Dim data_ As System.String = entity.Windstormdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Windstormdescription = Nothing
					Else
						entity.Windstormdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Constructiondescription As System.String 
				Get
					Dim data_ As System.String = entity.Constructiondescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Constructiondescription = Nothing
					Else
						entity.Constructiondescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occupancydescription As System.String 
				Get
					Dim data_ As System.String = entity.Occupancydescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occupancydescription = Nothing
					Else
						entity.Occupancydescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Otherdescription As System.String 
				Get
					Dim data_ As System.String = entity.Otherdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Otherdescription = Nothing
					Else
						entity.Otherdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Passivescore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Passivescore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Passivescore = Nothing
					Else
						entity.Passivescore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Physicalprotectionweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Physicalprotectionweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Physicalprotectionweight = Nothing
					Else
						entity.Physicalprotectionweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Humanelementweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Humanelementweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Humanelementweight = Nothing
					Else
						entity.Humanelementweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Naturalhazardsprotectionweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Naturalhazardsprotectionweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Naturalhazardsprotectionweight = Nothing
					Else
						entity.Naturalhazardsprotectionweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Businesscontinuityweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Businesscontinuityweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Businesscontinuityweight = Nothing
					Else
						entity.Businesscontinuityweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Physicalprotectionrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Physicalprotectionrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Physicalprotectionrating = Nothing
					Else
						entity.Physicalprotectionrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Humanelementrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Humanelementrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Humanelementrating = Nothing
					Else
						entity.Humanelementrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Naturalhazardsprotectionrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Naturalhazardsprotectionrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Naturalhazardsprotectionrating = Nothing
					Else
						entity.Naturalhazardsprotectionrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Businesscontinuityrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Businesscontinuityrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Businesscontinuityrating = Nothing
					Else
						entity.Businesscontinuityrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Firedescription As System.String 
				Get
					Dim data_ As System.String = entity.Firedescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Firedescription = Nothing
					Else
						entity.Firedescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Humandescription As System.String 
				Get
					Dim data_ As System.String = entity.Humandescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Humandescription = Nothing
					Else
						entity.Humandescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Naturaldescription As System.String 
				Get
					Dim data_ As System.String = entity.Naturaldescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Naturaldescription = Nothing
					Else
						entity.Naturaldescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Businessdescription As System.String 
				Get
					Dim data_ As System.String = entity.Businessdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Businessdescription = Nothing
					Else
						entity.Businessdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fireprotectionallrecscompleterating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Fireprotectionallrecscompleterating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fireprotectionallrecscompleterating = Nothing
					Else
						entity.Fireprotectionallrecscompleterating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Humanelementallrecscompleterating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Humanelementallrecscompleterating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Humanelementallrecscompleterating = Nothing
					Else
						entity.Humanelementallrecscompleterating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Nathazprotallrecscompleterating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Nathazprotallrecscompleterating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Nathazprotallrecscompleterating = Nothing
					Else
						entity.Nathazprotallrecscompleterating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bcpallrecscompletrating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Bcpallrecscompletrating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bcpallrecscompletrating = Nothing
					Else
						entity.Bcpallrecscompletrating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Firerecdescription As System.String 
				Get
					Dim data_ As System.String = entity.Firerecdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Firerecdescription = Nothing
					Else
						entity.Firerecdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Humanrecdescription As System.String 
				Get
					Dim data_ As System.String = entity.Humanrecdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Humanrecdescription = Nothing
					Else
						entity.Humanrecdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Naturalrecdescription As System.String 
				Get
					Dim data_ As System.String = entity.Naturalrecdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Naturalrecdescription = Nothing
					Else
						entity.Naturalrecdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Businessrecdescription As System.String 
				Get
					Dim data_ As System.String = entity.Businessrecdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Businessrecdescription = Nothing
					Else
						entity.Businessrecdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Activescore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Activescore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Activescore = Nothing
					Else
						entity.Activescore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Activescorewithrecscomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Activescorewithrecscomplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Activescorewithrecscomplete = Nothing
					Else
						entity.Activescorewithrecscomplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Totalscore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Totalscore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalscore = Nothing
					Else
						entity.Totalscore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Aplfactor As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Aplfactor
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aplfactor = Nothing
					Else
						entity.Aplfactor = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Overallplantratingrating As System.String 
				Get
					Dim data_ As System.String = entity.Overallplantratingrating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Overallplantratingrating = Nothing
					Else
						entity.Overallplantratingrating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Overallscorewithrecscomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Overallscorewithrecscomplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Overallscorewithrecscomplete = Nothing
					Else
						entity.Overallscorewithrecscomplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Aplfactorwithallrecscomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Aplfactorwithallrecscomplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aplfactorwithallrecscomplete = Nothing
					Else
						entity.Aplfactorwithallrecscomplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Maxpossiblescore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Maxpossiblescore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Maxpossiblescore = Nothing
					Else
						entity.Maxpossiblescore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Floodratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Floodratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Floodratingcolor = Nothing
					Else
						entity.Floodratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Earthquakeratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Earthquakeratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Earthquakeratingcolor = Nothing
					Else
						entity.Earthquakeratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Windstormratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Windstormratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Windstormratingcolor = Nothing
					Else
						entity.Windstormratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Constructionratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Constructionratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Constructionratingcolor = Nothing
					Else
						entity.Constructionratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occupancyratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Occupancyratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occupancyratingcolor = Nothing
					Else
						entity.Occupancyratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Otherratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Otherratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Otherratingcolor = Nothing
					Else
						entity.Otherratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Physicalprotectionratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Physicalprotectionratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Physicalprotectionratingcolor = Nothing
					Else
						entity.Physicalprotectionratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Humanelementratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Humanelementratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Humanelementratingcolor = Nothing
					Else
						entity.Humanelementratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Naturalhazardsprotectionratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Naturalhazardsprotectionratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Naturalhazardsprotectionratingcolor = Nothing
					Else
						entity.Naturalhazardsprotectionratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Businesscontinuityratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Businesscontinuityratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Businesscontinuityratingcolor = Nothing
					Else
						entity.Businesscontinuityratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fireprotectionallrecscompleteratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Fireprotectionallrecscompleteratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fireprotectionallrecscompleteratingcolor = Nothing
					Else
						entity.Fireprotectionallrecscompleteratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Humanelementallrecscompleteratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Humanelementallrecscompleteratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Humanelementallrecscompleteratingcolor = Nothing
					Else
						entity.Humanelementallrecscompleteratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Nathazprotallrecscompleteratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Nathazprotallrecscompleteratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Nathazprotallrecscompleteratingcolor = Nothing
					Else
						entity.Nathazprotallrecscompleteratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bcpallrecscompletratingcolor As System.String 
				Get
					Dim data_ As System.String = entity.Bcpallrecscompletratingcolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bcpallrecscompletratingcolor = Nothing
					Else
						entity.Bcpallrecscompletratingcolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Totalscorecolor As System.String 
				Get
					Dim data_ As System.String = entity.Totalscorecolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalscorecolor = Nothing
					Else
						entity.Totalscorecolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Overallplantratingdescription As System.String 
				Get
					Dim data_ As System.String = entity.Overallplantratingdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Overallplantratingdescription = Nothing
					Else
						entity.Overallplantratingdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Maxpossiblescorecolor As System.String 
				Get
					Dim data_ As System.String = entity.Maxpossiblescorecolor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Maxpossiblescorecolor = Nothing
					Else
						entity.Maxpossiblescorecolor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Maxpossiblescoredescription As System.String 
				Get
					Dim data_ As System.String = entity.Maxpossiblescoredescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Maxpossiblescoredescription = Nothing
					Else
						entity.Maxpossiblescoredescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLKeyRange1 As System.String 
				Get
					Dim data_ As System.String = entity.APLKeyRange1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLKeyRange1 = Nothing
					Else
						entity.APLKeyRange1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLKeyFactor1 As System.String 
				Get
					Dim data_ As System.String = entity.APLKeyFactor1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLKeyFactor1 = Nothing
					Else
						entity.APLKeyFactor1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLKeyRange2 As System.String 
				Get
					Dim data_ As System.String = entity.APLKeyRange2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLKeyRange2 = Nothing
					Else
						entity.APLKeyRange2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLKeyFactor2 As System.String 
				Get
					Dim data_ As System.String = entity.APLKeyFactor2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLKeyFactor2 = Nothing
					Else
						entity.APLKeyFactor2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLKeyRange3 As System.String 
				Get
					Dim data_ As System.String = entity.APLKeyRange3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLKeyRange3 = Nothing
					Else
						entity.APLKeyRange3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLKeyFactor3 As System.String 
				Get
					Dim data_ As System.String = entity.APLKeyFactor3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLKeyFactor3 = Nothing
					Else
						entity.APLKeyFactor3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLKeyRange4 As System.String 
				Get
					Dim data_ As System.String = entity.APLKeyRange4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLKeyRange4 = Nothing
					Else
						entity.APLKeyRange4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLKeyFactor4 As System.String 
				Get
					Dim data_ As System.String = entity.APLKeyFactor4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLKeyFactor4 = Nothing
					Else
						entity.APLKeyFactor4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription5 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription5 = Nothing
					Else
						entity.RatingKeyDescription5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription4 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription4 = Nothing
					Else
						entity.RatingKeyDescription4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription3 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription3 = Nothing
					Else
						entity.RatingKeyDescription3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription2 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription2 = Nothing
					Else
						entity.RatingKeyDescription2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyDescription1 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyDescription1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyDescription1 = Nothing
					Else
						entity.RatingKeyDescription1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor5 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor5 = Nothing
					Else
						entity.RatingKeyColor5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor4 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor4 = Nothing
					Else
						entity.RatingKeyColor4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor3 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor3 = Nothing
					Else
						entity.RatingKeyColor3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor2 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor2 = Nothing
					Else
						entity.RatingKeyColor2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingKeyColor1 As System.String 
				Get
					Dim data_ As System.String = entity.RatingKeyColor1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingKeyColor1 = Nothing
					Else
						entity.RatingKeyColor1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AchievableScorePercentString As System.String 
				Get
					Dim data_ As System.String = entity.AchievableScorePercentString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AchievableScorePercentString = Nothing
					Else
						entity.AchievableScorePercentString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AchievableScorePercent As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.AchievableScorePercent
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AchievableScorePercent = Nothing
					Else
						entity.AchievableScorePercent = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallScoreWithRecsCompleteRating As System.String 
				Get
					Dim data_ As System.String = entity.OverallScoreWithRecsCompleteRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallScoreWithRecsCompleteRating = Nothing
					Else
						entity.OverallScoreWithRecsCompleteRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallScoreWithRecsCompleteHexBackColor As System.String 
				Get
					Dim data_ As System.String = entity.OverallScoreWithRecsCompleteHexBackColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallScoreWithRecsCompleteHexBackColor = Nothing
					Else
						entity.OverallScoreWithRecsCompleteHexBackColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallScoreWithRecsCompleteHexForeColor As System.String 
				Get
					Dim data_ As System.String = entity.OverallScoreWithRecsCompleteHexForeColor
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallScoreWithRecsCompleteHexForeColor = Nothing
					Else
						entity.OverallScoreWithRecsCompleteHexForeColor = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCFireFacilityRating
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCFireFacilityRatingMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCFireFacilityRatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCFireFacilityRatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCFireFacilityRatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCFireFacilityRatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCFireFacilityRatingQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCFireFacilityRatingCollection
		Inherits esEntityCollection(Of ViewCCFireFacilityRating)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCFireFacilityRatingMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCFireFacilityRatingCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCFireFacilityRatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCFireFacilityRatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCFireFacilityRatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCFireFacilityRatingQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCFireFacilityRatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCFireFacilityRatingQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCFireFacilityRatingQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCFireFacilityRatingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCFireFacilityRatingMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GSafeGUID" 
					Return Me.GSafeGUID
				Case "Currency" 
					Return Me.Currency
				Case "CurrencyCode" 
					Return Me.CurrencyCode
				Case "CurrencySymbol" 
					Return Me.CurrencySymbol
				Case "APLString" 
					Return Me.APLString
				Case "APLWITHALLRECSCOMPLETEString" 
					Return Me.APLWITHALLRECSCOMPLETEString
				Case "Apl" 
					Return Me.Apl
				Case "Aplwithallrecscomplete" 
					Return Me.Aplwithallrecscomplete
				Case "Id" 
					Return Me.Id
				Case "Fileno" 
					Return Me.Fileno
				Case "Inspectiondate" 
					Return Me.Inspectiondate
				Case "Floodweight" 
					Return Me.Floodweight
				Case "Earthquakeweight" 
					Return Me.Earthquakeweight
				Case "Windstormweight" 
					Return Me.Windstormweight
				Case "Constructionweight" 
					Return Me.Constructionweight
				Case "Occupancyweight" 
					Return Me.Occupancyweight
				Case "Otherweight" 
					Return Me.Otherweight
				Case "Floodrating" 
					Return Me.Floodrating
				Case "Earthquakerating" 
					Return Me.Earthquakerating
				Case "Windstormrating" 
					Return Me.Windstormrating
				Case "Constructionrating" 
					Return Me.Constructionrating
				Case "Occupancyrating" 
					Return Me.Occupancyrating
				Case "Otherrating" 
					Return Me.Otherrating
				Case "Flooddescription" 
					Return Me.Flooddescription
				Case "Earthquakedescription" 
					Return Me.Earthquakedescription
				Case "Windstormdescription" 
					Return Me.Windstormdescription
				Case "Constructiondescription" 
					Return Me.Constructiondescription
				Case "Occupancydescription" 
					Return Me.Occupancydescription
				Case "Otherdescription" 
					Return Me.Otherdescription
				Case "Passivescore" 
					Return Me.Passivescore
				Case "Physicalprotectionweight" 
					Return Me.Physicalprotectionweight
				Case "Humanelementweight" 
					Return Me.Humanelementweight
				Case "Naturalhazardsprotectionweight" 
					Return Me.Naturalhazardsprotectionweight
				Case "Businesscontinuityweight" 
					Return Me.Businesscontinuityweight
				Case "Physicalprotectionrating" 
					Return Me.Physicalprotectionrating
				Case "Humanelementrating" 
					Return Me.Humanelementrating
				Case "Naturalhazardsprotectionrating" 
					Return Me.Naturalhazardsprotectionrating
				Case "Businesscontinuityrating" 
					Return Me.Businesscontinuityrating
				Case "Firedescription" 
					Return Me.Firedescription
				Case "Humandescription" 
					Return Me.Humandescription
				Case "Naturaldescription" 
					Return Me.Naturaldescription
				Case "Businessdescription" 
					Return Me.Businessdescription
				Case "Fireprotectionallrecscompleterating" 
					Return Me.Fireprotectionallrecscompleterating
				Case "Humanelementallrecscompleterating" 
					Return Me.Humanelementallrecscompleterating
				Case "Nathazprotallrecscompleterating" 
					Return Me.Nathazprotallrecscompleterating
				Case "Bcpallrecscompletrating" 
					Return Me.Bcpallrecscompletrating
				Case "Firerecdescription" 
					Return Me.Firerecdescription
				Case "Humanrecdescription" 
					Return Me.Humanrecdescription
				Case "Naturalrecdescription" 
					Return Me.Naturalrecdescription
				Case "Businessrecdescription" 
					Return Me.Businessrecdescription
				Case "Activescore" 
					Return Me.Activescore
				Case "Activescorewithrecscomplete" 
					Return Me.Activescorewithrecscomplete
				Case "Totalscore" 
					Return Me.Totalscore
				Case "Aplfactor" 
					Return Me.Aplfactor
				Case "Overallplantratingrating" 
					Return Me.Overallplantratingrating
				Case "Overallscorewithrecscomplete" 
					Return Me.Overallscorewithrecscomplete
				Case "Aplfactorwithallrecscomplete" 
					Return Me.Aplfactorwithallrecscomplete
				Case "Maxpossiblescore" 
					Return Me.Maxpossiblescore
				Case "Floodratingcolor" 
					Return Me.Floodratingcolor
				Case "Earthquakeratingcolor" 
					Return Me.Earthquakeratingcolor
				Case "Windstormratingcolor" 
					Return Me.Windstormratingcolor
				Case "Constructionratingcolor" 
					Return Me.Constructionratingcolor
				Case "Occupancyratingcolor" 
					Return Me.Occupancyratingcolor
				Case "Otherratingcolor" 
					Return Me.Otherratingcolor
				Case "Physicalprotectionratingcolor" 
					Return Me.Physicalprotectionratingcolor
				Case "Humanelementratingcolor" 
					Return Me.Humanelementratingcolor
				Case "Naturalhazardsprotectionratingcolor" 
					Return Me.Naturalhazardsprotectionratingcolor
				Case "Businesscontinuityratingcolor" 
					Return Me.Businesscontinuityratingcolor
				Case "Fireprotectionallrecscompleteratingcolor" 
					Return Me.Fireprotectionallrecscompleteratingcolor
				Case "Humanelementallrecscompleteratingcolor" 
					Return Me.Humanelementallrecscompleteratingcolor
				Case "Nathazprotallrecscompleteratingcolor" 
					Return Me.Nathazprotallrecscompleteratingcolor
				Case "Bcpallrecscompletratingcolor" 
					Return Me.Bcpallrecscompletratingcolor
				Case "Totalscorecolor" 
					Return Me.Totalscorecolor
				Case "Overallplantratingdescription" 
					Return Me.Overallplantratingdescription
				Case "Maxpossiblescorecolor" 
					Return Me.Maxpossiblescorecolor
				Case "Maxpossiblescoredescription" 
					Return Me.Maxpossiblescoredescription
				Case "APLKeyRange1" 
					Return Me.APLKeyRange1
				Case "APLKeyFactor1" 
					Return Me.APLKeyFactor1
				Case "APLKeyRange2" 
					Return Me.APLKeyRange2
				Case "APLKeyFactor2" 
					Return Me.APLKeyFactor2
				Case "APLKeyRange3" 
					Return Me.APLKeyRange3
				Case "APLKeyFactor3" 
					Return Me.APLKeyFactor3
				Case "APLKeyRange4" 
					Return Me.APLKeyRange4
				Case "APLKeyFactor4" 
					Return Me.APLKeyFactor4
				Case "RatingKeyDescription5" 
					Return Me.RatingKeyDescription5
				Case "RatingKeyDescription4" 
					Return Me.RatingKeyDescription4
				Case "RatingKeyDescription3" 
					Return Me.RatingKeyDescription3
				Case "RatingKeyDescription2" 
					Return Me.RatingKeyDescription2
				Case "RatingKeyDescription1" 
					Return Me.RatingKeyDescription1
				Case "RatingKeyColor5" 
					Return Me.RatingKeyColor5
				Case "RatingKeyColor4" 
					Return Me.RatingKeyColor4
				Case "RatingKeyColor3" 
					Return Me.RatingKeyColor3
				Case "RatingKeyColor2" 
					Return Me.RatingKeyColor2
				Case "RatingKeyColor1" 
					Return Me.RatingKeyColor1
				Case "AchievableScorePercentString" 
					Return Me.AchievableScorePercentString
				Case "AchievableScorePercent" 
					Return Me.AchievableScorePercent
				Case "OverallScoreWithRecsCompleteRating" 
					Return Me.OverallScoreWithRecsCompleteRating
				Case "OverallScoreWithRecsCompleteHexBackColor" 
					Return Me.OverallScoreWithRecsCompleteHexBackColor
				Case "OverallScoreWithRecsCompleteHexForeColor" 
					Return Me.OverallScoreWithRecsCompleteHexForeColor
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property GSafeGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.GSafeGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Currency As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Currency, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CurrencyCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.CurrencyCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CurrencySymbol As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.CurrencySymbol, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLString As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLWITHALLRECSCOMPLETEString As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLWITHALLRECSCOMPLETEString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Apl As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Apl, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Aplwithallrecscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Aplwithallrecscomplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Id, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Fileno As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Fileno, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inspectiondate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Inspectiondate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Floodweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Floodweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Earthquakeweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakeweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Windstormweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Constructionweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Occupancyweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Otherweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Otherweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Floodrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Floodrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Earthquakerating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakerating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Windstormrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Constructionrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Occupancyrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Otherrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Otherrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Flooddescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Flooddescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Earthquakedescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakedescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Windstormdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Constructiondescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Constructiondescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occupancydescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancydescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Otherdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Otherdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Passivescore As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Passivescore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Physicalprotectionweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Humanelementweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Naturalhazardsprotectionweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Businesscontinuityweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Physicalprotectionrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Humanelementrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Naturalhazardsprotectionrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Businesscontinuityrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Firedescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Firedescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Humandescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Humandescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Naturaldescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Naturaldescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Businessdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Businessdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fireprotectionallrecscompleterating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Fireprotectionallrecscompleterating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Humanelementallrecscompleterating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementallrecscompleterating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Nathazprotallrecscompleterating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Nathazprotallrecscompleterating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Bcpallrecscompletrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Bcpallrecscompletrating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Firerecdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Firerecdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Humanrecdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Humanrecdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Naturalrecdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalrecdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Businessrecdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Businessrecdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Activescore As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Activescore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Activescorewithrecscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Activescorewithrecscomplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Totalscore As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Totalscore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Aplfactor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Aplfactor, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Overallplantratingrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Overallplantratingrating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Overallscorewithrecscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Overallscorewithrecscomplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Aplfactorwithallrecscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Aplfactorwithallrecscomplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Maxpossiblescore As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Floodratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Floodratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Earthquakeratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakeratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Windstormratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Constructionratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occupancyratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Otherratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Otherratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Physicalprotectionratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Humanelementratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Naturalhazardsprotectionratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Businesscontinuityratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fireprotectionallrecscompleteratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Fireprotectionallrecscompleteratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Humanelementallrecscompleteratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementallrecscompleteratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Nathazprotallrecscompleteratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Nathazprotallrecscompleteratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bcpallrecscompletratingcolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Bcpallrecscompletratingcolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Totalscorecolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Totalscorecolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Overallplantratingdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Overallplantratingdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Maxpossiblescorecolor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescorecolor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Maxpossiblescoredescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescoredescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLKeyRange1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLKeyFactor1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLKeyRange2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLKeyFactor2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLKeyRange3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLKeyFactor3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLKeyRange4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APLKeyFactor4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription5 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription5, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyDescription1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor5 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor5, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingKeyColor1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AchievableScorePercentString As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.AchievableScorePercentString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AchievableScorePercent As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.AchievableScorePercent, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OverallScoreWithRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverallScoreWithRecsCompleteHexBackColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteHexBackColor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverallScoreWithRecsCompleteHexForeColor As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteHexForeColor, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCFireFacilityRatingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.GSafeGUID, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.GSafeGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Currency, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Currency
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.CurrencyCode, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.CurrencyCode
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.CurrencySymbol, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.CurrencySymbol
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLString, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLString
			c.CharacterMaxLength = 65
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLWITHALLRECSCOMPLETEString, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLWITHALLRECSCOMPLETEString
			c.CharacterMaxLength = 65
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Apl, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Apl
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplwithallrecscomplete, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Aplwithallrecscomplete
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Id, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Fileno, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Fileno
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Inspectiondate, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Inspectiondate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodweight, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Floodweight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakeweight, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakeweight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormweight, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormweight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionweight, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Constructionweight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyweight, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancyweight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherweight, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Otherweight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodrating, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Floodrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakerating, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakerating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormrating, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionrating, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Constructionrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyrating, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancyrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherrating, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Otherrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Flooddescription, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Flooddescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakedescription, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakedescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormdescription, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormdescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructiondescription, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Constructiondescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancydescription, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancydescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherdescription, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Otherdescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Passivescore, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Passivescore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionweight, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Physicalprotectionweight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementweight, 31, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementweight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionweight, 32, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalhazardsprotectionweight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityweight, 33, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Businesscontinuityweight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionrating, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Physicalprotectionrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementrating, 35, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionrating, 36, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalhazardsprotectionrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityrating, 37, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Businesscontinuityrating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Firedescription, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Firedescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Humandescription, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Humandescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturaldescription, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Naturaldescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Businessdescription, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Businessdescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Fireprotectionallrecscompleterating, 42, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Fireprotectionallrecscompleterating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementallrecscompleterating, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementallrecscompleterating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Nathazprotallrecscompleterating, 44, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Nathazprotallrecscompleterating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Bcpallrecscompletrating, 45, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Bcpallrecscompletrating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Firerecdescription, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Firerecdescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanrecdescription, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Humanrecdescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalrecdescription, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalrecdescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Businessrecdescription, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Businessrecdescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Activescore, 50, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Activescore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Activescorewithrecscomplete, 51, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Activescorewithrecscomplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Totalscore, 52, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Totalscore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplfactor, 53, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Aplfactor
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallplantratingrating, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Overallplantratingrating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallscorewithrecscomplete, 55, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Overallscorewithrecscomplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Aplfactorwithallrecscomplete, 56, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Aplfactorwithallrecscomplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescore, 57, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Maxpossiblescore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Floodratingcolor, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Floodratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Earthquakeratingcolor, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Earthquakeratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Windstormratingcolor, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Windstormratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Constructionratingcolor, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Constructionratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Occupancyratingcolor, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Occupancyratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Otherratingcolor, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Otherratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Physicalprotectionratingcolor, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Physicalprotectionratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementratingcolor, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Naturalhazardsprotectionratingcolor, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Naturalhazardsprotectionratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Businesscontinuityratingcolor, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Businesscontinuityratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Fireprotectionallrecscompleteratingcolor, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Fireprotectionallrecscompleteratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Humanelementallrecscompleteratingcolor, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Humanelementallrecscompleteratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Nathazprotallrecscompleteratingcolor, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Nathazprotallrecscompleteratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Bcpallrecscompletratingcolor, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Bcpallrecscompletratingcolor
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Totalscorecolor, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Totalscorecolor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Overallplantratingdescription, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Overallplantratingdescription
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescorecolor, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Maxpossiblescorecolor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.Maxpossiblescoredescription, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.Maxpossiblescoredescription
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange1, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyRange1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor1, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyFactor1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange2, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyRange2
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor2, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyFactor2
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange3, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyRange3
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor3, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyFactor3
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyRange4, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyRange4
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.APLKeyFactor4, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.APLKeyFactor4
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription5, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription5
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription4, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription4
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription3, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription3
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription2, 87, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription2
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyDescription1, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyDescription1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor5, 89, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor5
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor4, 90, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor4
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor3, 91, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor3
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor2, 92, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor2
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.RatingKeyColor1, 93, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.RatingKeyColor1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.AchievableScorePercentString, 94, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.AchievableScorePercentString
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.AchievableScorePercent, 95, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.AchievableScorePercent
			c.NumericPrecision = 38
			c.NumericScale = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, 96, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.OverallScoreWithRecsCompleteRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteHexBackColor, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.OverallScoreWithRecsCompleteHexBackColor
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCFireFacilityRatingMetadata.ColumnNames.OverallScoreWithRecsCompleteHexForeColor, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCFireFacilityRatingMetadata.PropertyNames.OverallScoreWithRecsCompleteHexForeColor
			c.CharacterMaxLength = 7
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCFireFacilityRatingMetadata
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
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const Currency As String = "Currency"
			 Public Const CurrencyCode As String = "CurrencyCode"
			 Public Const CurrencySymbol As String = "CurrencySymbol"
			 Public Const APLString As String = "APLString"
			 Public Const APLWITHALLRECSCOMPLETEString As String = "APLWITHALLRECSCOMPLETEString"
			 Public Const Apl As String = "APL"
			 Public Const Aplwithallrecscomplete As String = "APLWITHALLRECSCOMPLETE"
			 Public Const Id As String = "ID"
			 Public Const Fileno As String = "FILENO"
			 Public Const Inspectiondate As String = "INSPECTIONDATE"
			 Public Const Floodweight As String = "FLOODWEIGHT"
			 Public Const Earthquakeweight As String = "EARTHQUAKEWEIGHT"
			 Public Const Windstormweight As String = "WINDSTORMWEIGHT"
			 Public Const Constructionweight As String = "CONSTRUCTIONWEIGHT"
			 Public Const Occupancyweight As String = "OCCUPANCYWEIGHT"
			 Public Const Otherweight As String = "OTHERWEIGHT"
			 Public Const Floodrating As String = "FLOODRATING"
			 Public Const Earthquakerating As String = "EARTHQUAKERATING"
			 Public Const Windstormrating As String = "WINDSTORMRATING"
			 Public Const Constructionrating As String = "CONSTRUCTIONRATING"
			 Public Const Occupancyrating As String = "OCCUPANCYRATING"
			 Public Const Otherrating As String = "OTHERRATING"
			 Public Const Flooddescription As String = "FLOODDESCRIPTION"
			 Public Const Earthquakedescription As String = "EARTHQUAKEDESCRIPTION"
			 Public Const Windstormdescription As String = "WINDSTORMDESCRIPTION"
			 Public Const Constructiondescription As String = "CONSTRUCTIONDESCRIPTION"
			 Public Const Occupancydescription As String = "OCCUPANCYDESCRIPTION"
			 Public Const Otherdescription As String = "OTHERDESCRIPTION"
			 Public Const Passivescore As String = "PASSIVESCORE"
			 Public Const Physicalprotectionweight As String = "PHYSICALPROTECTIONWEIGHT"
			 Public Const Humanelementweight As String = "HUMANELEMENTWEIGHT"
			 Public Const Naturalhazardsprotectionweight As String = "NATURALHAZARDSPROTECTIONWEIGHT"
			 Public Const Businesscontinuityweight As String = "BUSINESSCONTINUITYWEIGHT"
			 Public Const Physicalprotectionrating As String = "PHYSICALPROTECTIONRATING"
			 Public Const Humanelementrating As String = "HUMANELEMENTRATING"
			 Public Const Naturalhazardsprotectionrating As String = "NATURALHAZARDSPROTECTIONRATING"
			 Public Const Businesscontinuityrating As String = "BUSINESSCONTINUITYRATING"
			 Public Const Firedescription As String = "FIREDESCRIPTION"
			 Public Const Humandescription As String = "HUMANDESCRIPTION"
			 Public Const Naturaldescription As String = "NATURALDESCRIPTION"
			 Public Const Businessdescription As String = "BUSINESSDESCRIPTION"
			 Public Const Fireprotectionallrecscompleterating As String = "FIREPROTECTIONALLRECSCOMPLETERATING"
			 Public Const Humanelementallrecscompleterating As String = "HUMANELEMENTALLRECSCOMPLETERATING"
			 Public Const Nathazprotallrecscompleterating As String = "NATHAZPROTALLRECSCOMPLETERATING"
			 Public Const Bcpallrecscompletrating As String = "BCPALLRECSCOMPLETRATING"
			 Public Const Firerecdescription As String = "FIRERECDESCRIPTION"
			 Public Const Humanrecdescription As String = "HUMANRECDESCRIPTION"
			 Public Const Naturalrecdescription As String = "NATURALRECDESCRIPTION"
			 Public Const Businessrecdescription As String = "BUSINESSRECDESCRIPTION"
			 Public Const Activescore As String = "ACTIVESCORE"
			 Public Const Activescorewithrecscomplete As String = "ACTIVESCOREWITHRECSCOMPLETE"
			 Public Const Totalscore As String = "TOTALSCORE"
			 Public Const Aplfactor As String = "APLFACTOR"
			 Public Const Overallplantratingrating As String = "OVERALLPLANTRATINGRATING"
			 Public Const Overallscorewithrecscomplete As String = "OVERALLSCOREWITHRECSCOMPLETE"
			 Public Const Aplfactorwithallrecscomplete As String = "APLFACTORWITHALLRECSCOMPLETE"
			 Public Const Maxpossiblescore As String = "MAXPOSSIBLESCORE"
			 Public Const Floodratingcolor As String = "FLOODRATINGCOLOR"
			 Public Const Earthquakeratingcolor As String = "EARTHQUAKERATINGCOLOR"
			 Public Const Windstormratingcolor As String = "WINDSTORMRATINGCOLOR"
			 Public Const Constructionratingcolor As String = "CONSTRUCTIONRATINGCOLOR"
			 Public Const Occupancyratingcolor As String = "OCCUPANCYRATINGCOLOR"
			 Public Const Otherratingcolor As String = "OTHERRATINGCOLOR"
			 Public Const Physicalprotectionratingcolor As String = "PHYSICALPROTECTIONRATINGCOLOR"
			 Public Const Humanelementratingcolor As String = "HUMANELEMENTRATINGCOLOR"
			 Public Const Naturalhazardsprotectionratingcolor As String = "NATURALHAZARDSPROTECTIONRATINGCOLOR"
			 Public Const Businesscontinuityratingcolor As String = "BUSINESSCONTINUITYRATINGCOLOR"
			 Public Const Fireprotectionallrecscompleteratingcolor As String = "FIREPROTECTIONALLRECSCOMPLETERATINGCOLOR"
			 Public Const Humanelementallrecscompleteratingcolor As String = "HUMANELEMENTALLRECSCOMPLETERATINGCOLOR"
			 Public Const Nathazprotallrecscompleteratingcolor As String = "NATHAZPROTALLRECSCOMPLETERATINGCOLOR"
			 Public Const Bcpallrecscompletratingcolor As String = "BCPALLRECSCOMPLETRATINGCOLOR"
			 Public Const Totalscorecolor As String = "TOTALSCORECOLOR"
			 Public Const Overallplantratingdescription As String = "OVERALLPLANTRATINGDESCRIPTION"
			 Public Const Maxpossiblescorecolor As String = "MAXPOSSIBLESCORECOLOR"
			 Public Const Maxpossiblescoredescription As String = "MAXPOSSIBLESCOREDESCRIPTION"
			 Public Const APLKeyRange1 As String = "APLKeyRange1"
			 Public Const APLKeyFactor1 As String = "APLKeyFactor1"
			 Public Const APLKeyRange2 As String = "APLKeyRange2"
			 Public Const APLKeyFactor2 As String = "APLKeyFactor2"
			 Public Const APLKeyRange3 As String = "APLKeyRange3"
			 Public Const APLKeyFactor3 As String = "APLKeyFactor3"
			 Public Const APLKeyRange4 As String = "APLKeyRange4"
			 Public Const APLKeyFactor4 As String = "APLKeyFactor4"
			 Public Const RatingKeyDescription5 As String = "RatingKeyDescription5"
			 Public Const RatingKeyDescription4 As String = "RatingKeyDescription4"
			 Public Const RatingKeyDescription3 As String = "RatingKeyDescription3"
			 Public Const RatingKeyDescription2 As String = "RatingKeyDescription2"
			 Public Const RatingKeyDescription1 As String = "RatingKeyDescription1"
			 Public Const RatingKeyColor5 As String = "RatingKeyColor5"
			 Public Const RatingKeyColor4 As String = "RatingKeyColor4"
			 Public Const RatingKeyColor3 As String = "RatingKeyColor3"
			 Public Const RatingKeyColor2 As String = "RatingKeyColor2"
			 Public Const RatingKeyColor1 As String = "RatingKeyColor1"
			 Public Const AchievableScorePercentString As String = "AchievableScorePercentString"
			 Public Const AchievableScorePercent As String = "AchievableScorePercent"
			 Public Const OverallScoreWithRecsCompleteRating As String = "OverallScoreWithRecsCompleteRating"
			 Public Const OverallScoreWithRecsCompleteHexBackColor As String = "OverallScoreWithRecsCompleteHexBackColor"
			 Public Const OverallScoreWithRecsCompleteHexForeColor As String = "OverallScoreWithRecsCompleteHexForeColor"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const Currency As String = "Currency"
			 Public Const CurrencyCode As String = "CurrencyCode"
			 Public Const CurrencySymbol As String = "CurrencySymbol"
			 Public Const APLString As String = "APLString"
			 Public Const APLWITHALLRECSCOMPLETEString As String = "APLWITHALLRECSCOMPLETEString"
			 Public Const Apl As String = "Apl"
			 Public Const Aplwithallrecscomplete As String = "Aplwithallrecscomplete"
			 Public Const Id As String = "Id"
			 Public Const Fileno As String = "Fileno"
			 Public Const Inspectiondate As String = "Inspectiondate"
			 Public Const Floodweight As String = "Floodweight"
			 Public Const Earthquakeweight As String = "Earthquakeweight"
			 Public Const Windstormweight As String = "Windstormweight"
			 Public Const Constructionweight As String = "Constructionweight"
			 Public Const Occupancyweight As String = "Occupancyweight"
			 Public Const Otherweight As String = "Otherweight"
			 Public Const Floodrating As String = "Floodrating"
			 Public Const Earthquakerating As String = "Earthquakerating"
			 Public Const Windstormrating As String = "Windstormrating"
			 Public Const Constructionrating As String = "Constructionrating"
			 Public Const Occupancyrating As String = "Occupancyrating"
			 Public Const Otherrating As String = "Otherrating"
			 Public Const Flooddescription As String = "Flooddescription"
			 Public Const Earthquakedescription As String = "Earthquakedescription"
			 Public Const Windstormdescription As String = "Windstormdescription"
			 Public Const Constructiondescription As String = "Constructiondescription"
			 Public Const Occupancydescription As String = "Occupancydescription"
			 Public Const Otherdescription As String = "Otherdescription"
			 Public Const Passivescore As String = "Passivescore"
			 Public Const Physicalprotectionweight As String = "Physicalprotectionweight"
			 Public Const Humanelementweight As String = "Humanelementweight"
			 Public Const Naturalhazardsprotectionweight As String = "Naturalhazardsprotectionweight"
			 Public Const Businesscontinuityweight As String = "Businesscontinuityweight"
			 Public Const Physicalprotectionrating As String = "Physicalprotectionrating"
			 Public Const Humanelementrating As String = "Humanelementrating"
			 Public Const Naturalhazardsprotectionrating As String = "Naturalhazardsprotectionrating"
			 Public Const Businesscontinuityrating As String = "Businesscontinuityrating"
			 Public Const Firedescription As String = "Firedescription"
			 Public Const Humandescription As String = "Humandescription"
			 Public Const Naturaldescription As String = "Naturaldescription"
			 Public Const Businessdescription As String = "Businessdescription"
			 Public Const Fireprotectionallrecscompleterating As String = "Fireprotectionallrecscompleterating"
			 Public Const Humanelementallrecscompleterating As String = "Humanelementallrecscompleterating"
			 Public Const Nathazprotallrecscompleterating As String = "Nathazprotallrecscompleterating"
			 Public Const Bcpallrecscompletrating As String = "Bcpallrecscompletrating"
			 Public Const Firerecdescription As String = "Firerecdescription"
			 Public Const Humanrecdescription As String = "Humanrecdescription"
			 Public Const Naturalrecdescription As String = "Naturalrecdescription"
			 Public Const Businessrecdescription As String = "Businessrecdescription"
			 Public Const Activescore As String = "Activescore"
			 Public Const Activescorewithrecscomplete As String = "Activescorewithrecscomplete"
			 Public Const Totalscore As String = "Totalscore"
			 Public Const Aplfactor As String = "Aplfactor"
			 Public Const Overallplantratingrating As String = "Overallplantratingrating"
			 Public Const Overallscorewithrecscomplete As String = "Overallscorewithrecscomplete"
			 Public Const Aplfactorwithallrecscomplete As String = "Aplfactorwithallrecscomplete"
			 Public Const Maxpossiblescore As String = "Maxpossiblescore"
			 Public Const Floodratingcolor As String = "Floodratingcolor"
			 Public Const Earthquakeratingcolor As String = "Earthquakeratingcolor"
			 Public Const Windstormratingcolor As String = "Windstormratingcolor"
			 Public Const Constructionratingcolor As String = "Constructionratingcolor"
			 Public Const Occupancyratingcolor As String = "Occupancyratingcolor"
			 Public Const Otherratingcolor As String = "Otherratingcolor"
			 Public Const Physicalprotectionratingcolor As String = "Physicalprotectionratingcolor"
			 Public Const Humanelementratingcolor As String = "Humanelementratingcolor"
			 Public Const Naturalhazardsprotectionratingcolor As String = "Naturalhazardsprotectionratingcolor"
			 Public Const Businesscontinuityratingcolor As String = "Businesscontinuityratingcolor"
			 Public Const Fireprotectionallrecscompleteratingcolor As String = "Fireprotectionallrecscompleteratingcolor"
			 Public Const Humanelementallrecscompleteratingcolor As String = "Humanelementallrecscompleteratingcolor"
			 Public Const Nathazprotallrecscompleteratingcolor As String = "Nathazprotallrecscompleteratingcolor"
			 Public Const Bcpallrecscompletratingcolor As String = "Bcpallrecscompletratingcolor"
			 Public Const Totalscorecolor As String = "Totalscorecolor"
			 Public Const Overallplantratingdescription As String = "Overallplantratingdescription"
			 Public Const Maxpossiblescorecolor As String = "Maxpossiblescorecolor"
			 Public Const Maxpossiblescoredescription As String = "Maxpossiblescoredescription"
			 Public Const APLKeyRange1 As String = "APLKeyRange1"
			 Public Const APLKeyFactor1 As String = "APLKeyFactor1"
			 Public Const APLKeyRange2 As String = "APLKeyRange2"
			 Public Const APLKeyFactor2 As String = "APLKeyFactor2"
			 Public Const APLKeyRange3 As String = "APLKeyRange3"
			 Public Const APLKeyFactor3 As String = "APLKeyFactor3"
			 Public Const APLKeyRange4 As String = "APLKeyRange4"
			 Public Const APLKeyFactor4 As String = "APLKeyFactor4"
			 Public Const RatingKeyDescription5 As String = "RatingKeyDescription5"
			 Public Const RatingKeyDescription4 As String = "RatingKeyDescription4"
			 Public Const RatingKeyDescription3 As String = "RatingKeyDescription3"
			 Public Const RatingKeyDescription2 As String = "RatingKeyDescription2"
			 Public Const RatingKeyDescription1 As String = "RatingKeyDescription1"
			 Public Const RatingKeyColor5 As String = "RatingKeyColor5"
			 Public Const RatingKeyColor4 As String = "RatingKeyColor4"
			 Public Const RatingKeyColor3 As String = "RatingKeyColor3"
			 Public Const RatingKeyColor2 As String = "RatingKeyColor2"
			 Public Const RatingKeyColor1 As String = "RatingKeyColor1"
			 Public Const AchievableScorePercentString As String = "AchievableScorePercentString"
			 Public Const AchievableScorePercent As String = "AchievableScorePercent"
			 Public Const OverallScoreWithRecsCompleteRating As String = "OverallScoreWithRecsCompleteRating"
			 Public Const OverallScoreWithRecsCompleteHexBackColor As String = "OverallScoreWithRecsCompleteHexBackColor"
			 Public Const OverallScoreWithRecsCompleteHexForeColor As String = "OverallScoreWithRecsCompleteHexForeColor"
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
			SyncLock GetType(ViewCCFireFacilityRatingMetadata)
			
				If ViewCCFireFacilityRatingMetadata.mapDelegates Is Nothing Then
					ViewCCFireFacilityRatingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCFireFacilityRatingMetadata._meta Is Nothing Then
					ViewCCFireFacilityRatingMetadata._meta = New ViewCCFireFacilityRatingMetadata()
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
				


				meta.AddTypeMap("GSafeGUID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Currency", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CurrencyCode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CurrencySymbol", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("APLString", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("APLWITHALLRECSCOMPLETEString", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Apl", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Aplwithallrecscomplete", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Id", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Fileno", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Inspectiondate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Floodweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Earthquakeweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Windstormweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Constructionweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Occupancyweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Otherweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Floodrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Earthquakerating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Windstormrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Constructionrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Occupancyrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Otherrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Flooddescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Earthquakedescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Windstormdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Constructiondescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Occupancydescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Otherdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Passivescore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Physicalprotectionweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Humanelementweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Naturalhazardsprotectionweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Businesscontinuityweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Physicalprotectionrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Humanelementrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Naturalhazardsprotectionrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Businesscontinuityrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Firedescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Humandescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Naturaldescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Businessdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fireprotectionallrecscompleterating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Humanelementallrecscompleterating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Nathazprotallrecscompleterating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Bcpallrecscompletrating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Firerecdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Humanrecdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Naturalrecdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Businessrecdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Activescore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Activescorewithrecscomplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Totalscore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Aplfactor", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Overallplantratingrating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Overallscorewithrecscomplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Aplfactorwithallrecscomplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Maxpossiblescore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Floodratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Earthquakeratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Windstormratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Constructionratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Occupancyratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Otherratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Physicalprotectionratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Humanelementratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Naturalhazardsprotectionratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Businesscontinuityratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fireprotectionallrecscompleteratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Humanelementallrecscompleteratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Nathazprotallrecscompleteratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Bcpallrecscompletratingcolor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Totalscorecolor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Overallplantratingdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Maxpossiblescorecolor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Maxpossiblescoredescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APLKeyRange1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APLKeyFactor1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APLKeyRange2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APLKeyFactor2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APLKeyRange3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APLKeyFactor3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APLKeyRange4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APLKeyFactor4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription5", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyDescription1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor5", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingKeyColor1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AchievableScorePercentString", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("AchievableScorePercent", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OverallScoreWithRecsCompleteRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OverallScoreWithRecsCompleteHexBackColor", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OverallScoreWithRecsCompleteHexForeColor", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCFireFacilityRating"
				meta.Destination = "viewCCFireFacilityRating"
				
				meta.spInsert = "proc_viewCCFireFacilityRatingInsert"
				meta.spUpdate = "proc_viewCCFireFacilityRatingUpdate"
				meta.spDelete = "proc_viewCCFireFacilityRatingDelete"
				meta.spLoadAll = "proc_viewCCFireFacilityRatingLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCFireFacilityRatingLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCFireFacilityRatingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
