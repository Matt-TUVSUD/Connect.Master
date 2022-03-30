
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/11/2017 3:27:39 PM
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
	' Encapsulates the 'viewCCGSafeSitemapItems' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCGSafeSitemapItems))> _
	<XmlType("ViewCCGSafeSitemapItems")> _	
	Partial Public Class ViewCCGSafeSitemapItems 
		Inherits esViewCCGSafeSitemapItems
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCGSafeSitemapItems()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCGSafeSitemapItemsCollection")> _
	Partial Public Class ViewCCGSafeSitemapItemsCollection
		Inherits esViewCCGSafeSitemapItemsCollection
		Implements IEnumerable(Of ViewCCGSafeSitemapItems)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCGSafeSitemapItems))> _
		Public Class ViewCCGSafeSitemapItemsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCGSafeSitemapItemsCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCGSafeSitemapItemsCollectionWCFPacket) As ViewCCGSafeSitemapItemsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCGSafeSitemapItemsCollection) As ViewCCGSafeSitemapItemsCollectionWCFPacket
				Return New ViewCCGSafeSitemapItemsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCGSafeSitemapItemsQuery 
		Inherits esViewCCGSafeSitemapItemsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCGSafeSitemapItemsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCGSafeSitemapItemsQuery) As String
			Return ViewCCGSafeSitemapItemsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCGSafeSitemapItemsQuery
			Return DirectCast(ViewCCGSafeSitemapItemsQuery.SerializeHelper.FromXml(query, GetType(ViewCCGSafeSitemapItemsQuery)), ViewCCGSafeSitemapItemsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCGSafeSitemapItems
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.GSafeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.GSafeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.GSafeId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.GSafeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavSiteMapKeyWord
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavSiteMapKeyWord As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavSiteMapKeyWord)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavSiteMapKeyWord, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavSiteMapKeyWord)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavAllReportsKeyword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavAllReportsKeyword As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavAllReportsKeyword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavAllReportsKeyword, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavAllReportsKeyword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavAllDataKeyword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavAllDataKeyword As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavAllDataKeyword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavAllDataKeyword, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavAllDataKeyword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavLinkId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavLinkId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavLinkId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavLinkId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavLinkId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavParentLinkId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavParentLinkId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavParentLinkId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavParentLinkId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavParentLinkId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavText As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavText, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavText)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavUrl
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavUrl As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavUrl)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavUrl, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavUrl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavOrder
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavOrder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavOrder, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavOrder)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavToolTip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavToolTip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavToolTip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavToolTip, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavToolTip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavVisible
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavVisible As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavVisible)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavVisible, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavVisible)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavEnabled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavEnabled As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavEnabled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavEnabled, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavEnabled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavTarget
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavTarget As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavTarget)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavTarget, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavTarget)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavType, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavConstant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavConstant As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavConstant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavConstant, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavConstant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavRptCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavRptCode As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavRptCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavRptCode, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavRptCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavGridId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavGridId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavGridId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavGridId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavGridId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavChartId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavChartId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavChartId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavChartId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavChartId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavExtractId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavExtractId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavExtractId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavExtractId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavExtractId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavBypassFilter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavBypassFilter As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavBypassFilter)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavBypassFilter, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavBypassFilter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.NavStatusToolTip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavStatusToolTip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavStatusToolTip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavStatusToolTip, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavStatusToolTip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.slideMenuId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideMenuId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideMenuId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideMenuId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideMenuId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.slideGroupId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideGroupId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideGroupId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideGroupId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideGroupId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.slideLevelId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideLevelId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideLevelId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideLevelId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideLevelId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.slideType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideType, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.slideParentId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideParentId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideParentId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideParentId, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideParentId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.slideOrder
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideOrder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideOrder, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideOrder)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGSafeSitemapItems.slideImageClassName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideImageClassName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideImageClassName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideImageClassName, value) Then
					OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideImageClassName)
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
												
						Case "GSafeId"
							Me.str().GSafeId = CType(value, string)
												
						Case "NavSiteMapKeyWord"
							Me.str().NavSiteMapKeyWord = CType(value, string)
												
						Case "NavAllReportsKeyword"
							Me.str().NavAllReportsKeyword = CType(value, string)
												
						Case "NavAllDataKeyword"
							Me.str().NavAllDataKeyword = CType(value, string)
												
						Case "NavLinkId"
							Me.str().NavLinkId = CType(value, string)
												
						Case "NavParentLinkId"
							Me.str().NavParentLinkId = CType(value, string)
												
						Case "NavText"
							Me.str().NavText = CType(value, string)
												
						Case "NavUrl"
							Me.str().NavUrl = CType(value, string)
												
						Case "NavOrder"
							Me.str().NavOrder = CType(value, string)
												
						Case "NavToolTip"
							Me.str().NavToolTip = CType(value, string)
												
						Case "NavVisible"
							Me.str().NavVisible = CType(value, string)
												
						Case "NavEnabled"
							Me.str().NavEnabled = CType(value, string)
												
						Case "NavTarget"
							Me.str().NavTarget = CType(value, string)
												
						Case "NavType"
							Me.str().NavType = CType(value, string)
												
						Case "NavConstant"
							Me.str().NavConstant = CType(value, string)
												
						Case "NavRptCode"
							Me.str().NavRptCode = CType(value, string)
												
						Case "NavGridId"
							Me.str().NavGridId = CType(value, string)
												
						Case "NavChartId"
							Me.str().NavChartId = CType(value, string)
												
						Case "NavExtractId"
							Me.str().NavExtractId = CType(value, string)
												
						Case "NavBypassFilter"
							Me.str().NavBypassFilter = CType(value, string)
												
						Case "NavStatusToolTip"
							Me.str().NavStatusToolTip = CType(value, string)
												
						Case "SlideMenuId"
							Me.str().SlideMenuId = CType(value, string)
												
						Case "SlideGroupId"
							Me.str().SlideGroupId = CType(value, string)
												
						Case "SlideLevelId"
							Me.str().SlideLevelId = CType(value, string)
												
						Case "SlideType"
							Me.str().SlideType = CType(value, string)
												
						Case "SlideParentId"
							Me.str().SlideParentId = CType(value, string)
												
						Case "SlideOrder"
							Me.str().SlideOrder = CType(value, string)
												
						Case "SlideImageClassName"
							Me.str().SlideImageClassName = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GSafeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GSafeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.GSafeId)
							End If
						
						Case "NavLinkId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavLinkId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavLinkId)
							End If
						
						Case "NavParentLinkId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavParentLinkId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavParentLinkId)
							End If
						
						Case "NavOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavOrder = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavOrder)
							End If
						
						Case "NavVisible"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavVisible = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavVisible)
							End If
						
						Case "NavEnabled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavEnabled = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavEnabled)
							End If
						
						Case "NavGridId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavGridId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavGridId)
							End If
						
						Case "NavChartId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavChartId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavChartId)
							End If
						
						Case "NavExtractId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavExtractId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavExtractId)
							End If
						
						Case "NavBypassFilter"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavBypassFilter = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavBypassFilter)
							End If
						
						Case "SlideMenuId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideMenuId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideMenuId)
							End If
						
						Case "SlideGroupId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideGroupId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideGroupId)
							End If
						
						Case "SlideLevelId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideLevelId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideLevelId)
							End If
						
						Case "SlideParentId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideParentId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideParentId)
							End If
						
						Case "SlideOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideOrder = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideOrder)
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
		
			Public Sub New(ByVal entity As esViewCCGSafeSitemapItems)
				Me.entity = entity
			End Sub				
		
	
			Public Property GSafeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.GSafeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GSafeId = Nothing
					Else
						entity.GSafeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavSiteMapKeyWord As System.String 
				Get
					Dim data_ As System.String = entity.NavSiteMapKeyWord
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavSiteMapKeyWord = Nothing
					Else
						entity.NavSiteMapKeyWord = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavAllReportsKeyword As System.String 
				Get
					Dim data_ As System.String = entity.NavAllReportsKeyword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavAllReportsKeyword = Nothing
					Else
						entity.NavAllReportsKeyword = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavAllDataKeyword As System.String 
				Get
					Dim data_ As System.String = entity.NavAllDataKeyword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavAllDataKeyword = Nothing
					Else
						entity.NavAllDataKeyword = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavLinkId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavLinkId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavLinkId = Nothing
					Else
						entity.NavLinkId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavParentLinkId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavParentLinkId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavParentLinkId = Nothing
					Else
						entity.NavParentLinkId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavText As System.String 
				Get
					Dim data_ As System.String = entity.NavText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavText = Nothing
					Else
						entity.NavText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavUrl As System.String 
				Get
					Dim data_ As System.String = entity.NavUrl
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavUrl = Nothing
					Else
						entity.NavUrl = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavOrder As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavOrder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavOrder = Nothing
					Else
						entity.NavOrder = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavToolTip As System.String 
				Get
					Dim data_ As System.String = entity.NavToolTip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavToolTip = Nothing
					Else
						entity.NavToolTip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavVisible As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavVisible
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavVisible = Nothing
					Else
						entity.NavVisible = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavEnabled As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavEnabled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavEnabled = Nothing
					Else
						entity.NavEnabled = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavTarget As System.String 
				Get
					Dim data_ As System.String = entity.NavTarget
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavTarget = Nothing
					Else
						entity.NavTarget = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavType As System.String 
				Get
					Dim data_ As System.String = entity.NavType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavType = Nothing
					Else
						entity.NavType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavConstant As System.String 
				Get
					Dim data_ As System.String = entity.NavConstant
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavConstant = Nothing
					Else
						entity.NavConstant = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavRptCode As System.String 
				Get
					Dim data_ As System.String = entity.NavRptCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavRptCode = Nothing
					Else
						entity.NavRptCode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavGridId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavGridId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavGridId = Nothing
					Else
						entity.NavGridId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavChartId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavChartId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavChartId = Nothing
					Else
						entity.NavChartId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavExtractId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavExtractId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavExtractId = Nothing
					Else
						entity.NavExtractId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavBypassFilter As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.NavBypassFilter
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavBypassFilter = Nothing
					Else
						entity.NavBypassFilter = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavStatusToolTip As System.String 
				Get
					Dim data_ As System.String = entity.NavStatusToolTip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavStatusToolTip = Nothing
					Else
						entity.NavStatusToolTip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SlideMenuId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SlideMenuId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SlideMenuId = Nothing
					Else
						entity.SlideMenuId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SlideGroupId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SlideGroupId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SlideGroupId = Nothing
					Else
						entity.SlideGroupId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SlideLevelId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SlideLevelId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SlideLevelId = Nothing
					Else
						entity.SlideLevelId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SlideType As System.String 
				Get
					Dim data_ As System.String = entity.SlideType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SlideType = Nothing
					Else
						entity.SlideType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SlideParentId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SlideParentId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SlideParentId = Nothing
					Else
						entity.SlideParentId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SlideOrder As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SlideOrder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SlideOrder = Nothing
					Else
						entity.SlideOrder = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SlideImageClassName As System.String 
				Get
					Dim data_ As System.String = entity.SlideImageClassName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SlideImageClassName = Nothing
					Else
						entity.SlideImageClassName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCGSafeSitemapItems
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCGSafeSitemapItemsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCGSafeSitemapItemsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCGSafeSitemapItemsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCGSafeSitemapItemsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCGSafeSitemapItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCGSafeSitemapItemsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCGSafeSitemapItemsCollection
		Inherits esEntityCollection(Of ViewCCGSafeSitemapItems)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCGSafeSitemapItemsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCGSafeSitemapItemsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCGSafeSitemapItemsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCGSafeSitemapItemsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCGSafeSitemapItemsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCGSafeSitemapItemsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCGSafeSitemapItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCGSafeSitemapItemsQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCGSafeSitemapItemsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCGSafeSitemapItemsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCGSafeSitemapItemsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GSafeId" 
					Return Me.GSafeId
				Case "NavSiteMapKeyWord" 
					Return Me.NavSiteMapKeyWord
				Case "NavAllReportsKeyword" 
					Return Me.NavAllReportsKeyword
				Case "NavAllDataKeyword" 
					Return Me.NavAllDataKeyword
				Case "NavLinkId" 
					Return Me.NavLinkId
				Case "NavParentLinkId" 
					Return Me.NavParentLinkId
				Case "NavText" 
					Return Me.NavText
				Case "NavUrl" 
					Return Me.NavUrl
				Case "NavOrder" 
					Return Me.NavOrder
				Case "NavToolTip" 
					Return Me.NavToolTip
				Case "NavVisible" 
					Return Me.NavVisible
				Case "NavEnabled" 
					Return Me.NavEnabled
				Case "NavTarget" 
					Return Me.NavTarget
				Case "NavType" 
					Return Me.NavType
				Case "NavConstant" 
					Return Me.NavConstant
				Case "NavRptCode" 
					Return Me.NavRptCode
				Case "NavGridId" 
					Return Me.NavGridId
				Case "NavChartId" 
					Return Me.NavChartId
				Case "NavExtractId" 
					Return Me.NavExtractId
				Case "NavBypassFilter" 
					Return Me.NavBypassFilter
				Case "NavStatusToolTip" 
					Return Me.NavStatusToolTip
				Case "SlideMenuId" 
					Return Me.SlideMenuId
				Case "SlideGroupId" 
					Return Me.SlideGroupId
				Case "SlideLevelId" 
					Return Me.SlideLevelId
				Case "SlideType" 
					Return Me.SlideType
				Case "SlideParentId" 
					Return Me.SlideParentId
				Case "SlideOrder" 
					Return Me.SlideOrder
				Case "SlideImageClassName" 
					Return Me.SlideImageClassName
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property GSafeId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.GSafeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavSiteMapKeyWord As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavSiteMapKeyWord, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavAllReportsKeyword As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavAllReportsKeyword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavAllDataKeyword As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavAllDataKeyword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavLinkId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavLinkId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavParentLinkId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavParentLinkId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavUrl As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavUrl, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavOrder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavOrder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavToolTip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavToolTip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavVisible As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavVisible, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavEnabled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavEnabled, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavTarget As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavTarget, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavConstant As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavConstant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavRptCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavRptCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavGridId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavGridId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavChartId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavChartId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavExtractId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavExtractId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavBypassFilter As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavBypassFilter, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavStatusToolTip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavStatusToolTip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SlideMenuId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideMenuId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideGroupId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideGroupId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideLevelId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideLevelId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SlideParentId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideParentId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideOrder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideOrder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideImageClassName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideImageClassName, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCGSafeSitemapItemsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.GSafeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.GSafeId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavSiteMapKeyWord, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavSiteMapKeyWord
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavAllReportsKeyword, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavAllReportsKeyword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavAllDataKeyword, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavAllDataKeyword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavLinkId, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavLinkId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavParentLinkId, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavParentLinkId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavText, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavText
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavUrl, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavUrl
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavOrder, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavOrder
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavToolTip, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavToolTip
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavVisible, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavVisible
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavEnabled, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavEnabled
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavTarget, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavTarget
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavType, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavConstant, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavConstant
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavRptCode, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavRptCode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavGridId, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavGridId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavChartId, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavChartId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavExtractId, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavExtractId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavBypassFilter, 19, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavBypassFilter
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.NavStatusToolTip, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.NavStatusToolTip
			c.CharacterMaxLength = 200
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideMenuId, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideMenuId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideGroupId, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideGroupId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideLevelId, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideLevelId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideType, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideType
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideParentId, 25, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideParentId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideOrder, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideOrder
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGSafeSitemapItemsMetadata.ColumnNames.SlideImageClassName, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGSafeSitemapItemsMetadata.PropertyNames.SlideImageClassName
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCGSafeSitemapItemsMetadata
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
			 Public Const GSafeId As String = "GSafeId"
			 Public Const NavSiteMapKeyWord As String = "NavSiteMapKeyWord"
			 Public Const NavAllReportsKeyword As String = "NavAllReportsKeyword"
			 Public Const NavAllDataKeyword As String = "NavAllDataKeyword"
			 Public Const NavLinkId As String = "NavLinkId"
			 Public Const NavParentLinkId As String = "NavParentLinkId"
			 Public Const NavText As String = "NavText"
			 Public Const NavUrl As String = "NavUrl"
			 Public Const NavOrder As String = "NavOrder"
			 Public Const NavToolTip As String = "NavToolTip"
			 Public Const NavVisible As String = "NavVisible"
			 Public Const NavEnabled As String = "NavEnabled"
			 Public Const NavTarget As String = "NavTarget"
			 Public Const NavType As String = "NavType"
			 Public Const NavConstant As String = "NavConstant"
			 Public Const NavRptCode As String = "NavRptCode"
			 Public Const NavGridId As String = "NavGridId"
			 Public Const NavChartId As String = "NavChartId"
			 Public Const NavExtractId As String = "NavExtractId"
			 Public Const NavBypassFilter As String = "NavBypassFilter"
			 Public Const NavStatusToolTip As String = "NavStatusToolTip"
			 Public Const SlideMenuId As String = "slideMenuId"
			 Public Const SlideGroupId As String = "slideGroupId"
			 Public Const SlideLevelId As String = "slideLevelId"
			 Public Const SlideType As String = "slideType"
			 Public Const SlideParentId As String = "slideParentId"
			 Public Const SlideOrder As String = "slideOrder"
			 Public Const SlideImageClassName As String = "slideImageClassName"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const GSafeId As String = "GSafeId"
			 Public Const NavSiteMapKeyWord As String = "NavSiteMapKeyWord"
			 Public Const NavAllReportsKeyword As String = "NavAllReportsKeyword"
			 Public Const NavAllDataKeyword As String = "NavAllDataKeyword"
			 Public Const NavLinkId As String = "NavLinkId"
			 Public Const NavParentLinkId As String = "NavParentLinkId"
			 Public Const NavText As String = "NavText"
			 Public Const NavUrl As String = "NavUrl"
			 Public Const NavOrder As String = "NavOrder"
			 Public Const NavToolTip As String = "NavToolTip"
			 Public Const NavVisible As String = "NavVisible"
			 Public Const NavEnabled As String = "NavEnabled"
			 Public Const NavTarget As String = "NavTarget"
			 Public Const NavType As String = "NavType"
			 Public Const NavConstant As String = "NavConstant"
			 Public Const NavRptCode As String = "NavRptCode"
			 Public Const NavGridId As String = "NavGridId"
			 Public Const NavChartId As String = "NavChartId"
			 Public Const NavExtractId As String = "NavExtractId"
			 Public Const NavBypassFilter As String = "NavBypassFilter"
			 Public Const NavStatusToolTip As String = "NavStatusToolTip"
			 Public Const SlideMenuId As String = "SlideMenuId"
			 Public Const SlideGroupId As String = "SlideGroupId"
			 Public Const SlideLevelId As String = "SlideLevelId"
			 Public Const SlideType As String = "SlideType"
			 Public Const SlideParentId As String = "SlideParentId"
			 Public Const SlideOrder As String = "SlideOrder"
			 Public Const SlideImageClassName As String = "SlideImageClassName"
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
			SyncLock GetType(ViewCCGSafeSitemapItemsMetadata)
			
				If ViewCCGSafeSitemapItemsMetadata.mapDelegates Is Nothing Then
					ViewCCGSafeSitemapItemsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCGSafeSitemapItemsMetadata._meta Is Nothing Then
					ViewCCGSafeSitemapItemsMetadata._meta = New ViewCCGSafeSitemapItemsMetadata()
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
				


				meta.AddTypeMap("GSafeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavSiteMapKeyWord", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavAllReportsKeyword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavAllDataKeyword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavLinkId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavParentLinkId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavUrl", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavOrder", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavToolTip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavVisible", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavEnabled", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavTarget", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavConstant", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavRptCode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavGridId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavChartId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavExtractId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavBypassFilter", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("NavStatusToolTip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SlideMenuId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SlideGroupId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SlideLevelId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SlideType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SlideParentId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SlideOrder", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SlideImageClassName", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCGSafeSitemapItems"
				meta.Destination = "viewCCGSafeSitemapItems"
				
				meta.spInsert = "proc_viewCCGSafeSitemapItemsInsert"
				meta.spUpdate = "proc_viewCCGSafeSitemapItemsUpdate"
				meta.spDelete = "proc_viewCCGSafeSitemapItemsDelete"
				meta.spLoadAll = "proc_viewCCGSafeSitemapItemsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCGSafeSitemapItemsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCGSafeSitemapItemsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
