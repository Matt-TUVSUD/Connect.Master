
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/11/2017 3:30:36 PM
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
	' Encapsulates the 'GSafeSitemapItems' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(GSafeSitemapItems))> _
	<XmlType("GSafeSitemapItems")> _	
	Partial Public Class GSafeSitemapItems 
		Inherits esGSafeSitemapItems
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New GSafeSitemapItems()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal navLinkId As System.Int32)
			Dim obj As New GSafeSitemapItems()
			obj.GSafeId = gSafeId
			obj.NavLinkId = navLinkId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal gSafeId As System.Int32, ByVal navLinkId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New GSafeSitemapItems()
			obj.GSafeId = gSafeId
			obj.NavLinkId = navLinkId
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("GSafeSitemapItemsCollection")> _
	Partial Public Class GSafeSitemapItemsCollection
		Inherits esGSafeSitemapItemsCollection
		Implements IEnumerable(Of GSafeSitemapItems)
	
		Public Function FindByPrimaryKey(ByVal gSafeId As System.Int32, ByVal navLinkId As System.Int32) As GSafeSitemapItems
			Return MyBase.SingleOrDefault(Function(e) e.GSafeId.HasValue AndAlso e.GSafeId.Value = gSafeId And e.NavLinkId.HasValue AndAlso e.NavLinkId.Value = navLinkId)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(GSafeSitemapItems))> _
		Public Class GSafeSitemapItemsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of GSafeSitemapItemsCollection)
			
			Public Shared Widening Operator CType(packet As GSafeSitemapItemsCollectionWCFPacket) As GSafeSitemapItemsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As GSafeSitemapItemsCollection) As GSafeSitemapItemsCollectionWCFPacket
				Return New GSafeSitemapItemsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class GSafeSitemapItemsQuery 
		Inherits esGSafeSitemapItemsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "GSafeSitemapItemsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As GSafeSitemapItemsQuery) As String
			Return GSafeSitemapItemsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As GSafeSitemapItemsQuery
			Return DirectCast(GSafeSitemapItemsQuery.SerializeHelper.FromXml(query, GetType(GSafeSitemapItemsQuery)), GSafeSitemapItemsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esGSafeSitemapItems
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal gSafeId As System.Int32, ByVal navLinkId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gSafeId, navLinkId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gSafeId, navLinkId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal gSafeId As System.Int32, ByVal navLinkId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(gSafeId, navLinkId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(gSafeId, navLinkId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal gSafeId As System.Int32, ByVal navLinkId As System.Int32) As Boolean
		
			Dim query As New GSafeSitemapItemsQuery()
			query.Where(query.GSafeId = gSafeId And query.NavLinkId = navLinkId)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal gSafeId As System.Int32, ByVal navLinkId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("GSafeId", gSafeId)
						parms.Add("NavLinkId", navLinkId)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to GSafeSitemapItems.GSafeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.GSafeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.GSafeId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.GSafeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavLinkId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavLinkId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavLinkId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavLinkId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavLinkId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavSiteMapKeyWord
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavSiteMapKeyWord As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavSiteMapKeyWord)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavSiteMapKeyWord, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavSiteMapKeyWord)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavAllReportsKeyword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavAllReportsKeyword As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavAllReportsKeyword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavAllReportsKeyword, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavAllReportsKeyword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavAllDataKeyword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavAllDataKeyword As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavAllDataKeyword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavAllDataKeyword, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavAllDataKeyword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavParentLinkId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavParentLinkId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavParentLinkId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavParentLinkId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavParentLinkId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavText As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavText, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavText)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavUrl
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavUrl As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavUrl)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavUrl, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavUrl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavOrder
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavOrder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavOrder, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavOrder)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavToolTip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavToolTip As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavToolTip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavToolTip, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavToolTip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavVisible
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavVisible As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(GSafeSitemapItemsMetadata.ColumnNames.NavVisible)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(GSafeSitemapItemsMetadata.ColumnNames.NavVisible, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavVisible)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavEnabled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavEnabled As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(GSafeSitemapItemsMetadata.ColumnNames.NavEnabled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(GSafeSitemapItemsMetadata.ColumnNames.NavEnabled, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavEnabled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavTarget
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavTarget As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavTarget)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavTarget, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavTarget)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavType As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavType, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavConstant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavConstant As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavConstant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavConstant, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavConstant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavRptCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavRptCode As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavRptCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavRptCode, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavRptCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavGridId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavGridId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavGridId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavGridId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavGridId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavChartId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavChartId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavChartId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavChartId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavChartId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavExtractId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavExtractId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavExtractId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.NavExtractId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavExtractId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavBypassFilter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavBypassFilter As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(GSafeSitemapItemsMetadata.ColumnNames.NavBypassFilter)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(GSafeSitemapItemsMetadata.ColumnNames.NavBypassFilter, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavBypassFilter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.NavStatusToolTip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavStatusToolTip As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavStatusToolTip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.NavStatusToolTip, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavStatusToolTip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.slideMenuId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideMenuId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideMenuId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideMenuId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideMenuId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.slideGroupId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideGroupId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideGroupId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideGroupId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideGroupId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.slideLevelId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideLevelId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideLevelId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideLevelId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideLevelId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.slideType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideType As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.SlideType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.SlideType, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.slideParentId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideParentId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideParentId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideParentId, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideParentId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.slideOrder
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideOrder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(GSafeSitemapItemsMetadata.ColumnNames.SlideOrder, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideOrder)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to GSafeSitemapItems.slideImageClassName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideImageClassName As System.String
			Get
				Return MyBase.GetSystemString(GSafeSitemapItemsMetadata.ColumnNames.SlideImageClassName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(GSafeSitemapItemsMetadata.ColumnNames.SlideImageClassName, value) Then
					OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideImageClassName)
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
												
						Case "NavLinkId"
							Me.str().NavLinkId = CType(value, string)
												
						Case "NavSiteMapKeyWord"
							Me.str().NavSiteMapKeyWord = CType(value, string)
												
						Case "NavAllReportsKeyword"
							Me.str().NavAllReportsKeyword = CType(value, string)
												
						Case "NavAllDataKeyword"
							Me.str().NavAllDataKeyword = CType(value, string)
												
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
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.GSafeId)
							End If
						
						Case "NavLinkId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavLinkId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavLinkId)
							End If
						
						Case "NavParentLinkId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavParentLinkId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavParentLinkId)
							End If
						
						Case "NavOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavOrder = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavOrder)
							End If
						
						Case "NavVisible"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavVisible = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavVisible)
							End If
						
						Case "NavEnabled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavEnabled = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavEnabled)
							End If
						
						Case "NavGridId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavGridId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavGridId)
							End If
						
						Case "NavChartId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavChartId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavChartId)
							End If
						
						Case "NavExtractId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavExtractId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavExtractId)
							End If
						
						Case "NavBypassFilter"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavBypassFilter = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.NavBypassFilter)
							End If
						
						Case "SlideMenuId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideMenuId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideMenuId)
							End If
						
						Case "SlideGroupId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideGroupId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideGroupId)
							End If
						
						Case "SlideLevelId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideLevelId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideLevelId)
							End If
						
						Case "SlideParentId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideParentId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideParentId)
							End If
						
						Case "SlideOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideOrder = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(GSafeSitemapItemsMetadata.PropertyNames.SlideOrder)
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
		
			Public Sub New(ByVal entity As esGSafeSitemapItems)
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
					Dim data_ As Nullable(Of System.Boolean) = entity.NavVisible
					
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
						entity.NavVisible = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavEnabled As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.NavEnabled
					
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
						entity.NavEnabled = Convert.ToBoolean(Value)
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
		  

			Private entity As esGSafeSitemapItems
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeSitemapItemsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As GSafeSitemapItemsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeSitemapItemsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As GSafeSitemapItemsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As GSafeSitemapItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As GSafeSitemapItemsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esGSafeSitemapItemsCollection
		Inherits esEntityCollection(Of GSafeSitemapItems)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return GSafeSitemapItemsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "GSafeSitemapItemsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As GSafeSitemapItemsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New GSafeSitemapItemsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As GSafeSitemapItemsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New GSafeSitemapItemsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As GSafeSitemapItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, GSafeSitemapItemsQuery))
		End Sub
		
		#End Region
						
		Private m_query As GSafeSitemapItemsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esGSafeSitemapItemsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return GSafeSitemapItemsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "GSafeId" 
					Return Me.GSafeId
				Case "NavLinkId" 
					Return Me.NavLinkId
				Case "NavSiteMapKeyWord" 
					Return Me.NavSiteMapKeyWord
				Case "NavAllReportsKeyword" 
					Return Me.NavAllReportsKeyword
				Case "NavAllDataKeyword" 
					Return Me.NavAllDataKeyword
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
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.GSafeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavLinkId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavLinkId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavSiteMapKeyWord As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavSiteMapKeyWord, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavAllReportsKeyword As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavAllReportsKeyword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavAllDataKeyword As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavAllDataKeyword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavParentLinkId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavParentLinkId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavText As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavUrl As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavUrl, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavOrder As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavOrder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavToolTip As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavToolTip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavVisible As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavVisible, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavEnabled As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavEnabled, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavTarget As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavTarget, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavType As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavConstant As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavConstant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavRptCode As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavRptCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavGridId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavGridId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavChartId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavChartId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavExtractId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavExtractId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavBypassFilter As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavBypassFilter, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavStatusToolTip As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.NavStatusToolTip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SlideMenuId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.SlideMenuId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideGroupId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.SlideGroupId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideLevelId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.SlideLevelId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideType As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.SlideType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SlideParentId As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.SlideParentId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideOrder As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.SlideOrder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideImageClassName As esQueryItem
			Get
				Return New esQueryItem(Me, GSafeSitemapItemsMetadata.ColumnNames.SlideImageClassName, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class GSafeSitemapItemsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.GSafeId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.GSafeId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavLinkId, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavLinkId
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavSiteMapKeyWord, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavSiteMapKeyWord
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavAllReportsKeyword, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavAllReportsKeyword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavAllDataKeyword, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavAllDataKeyword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavParentLinkId, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavParentLinkId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavText, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavText
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavUrl, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavUrl
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavOrder, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavOrder
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavToolTip, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavToolTip
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavVisible, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavVisible
			c.HasDefault = True
			c.Default = "((-1))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavEnabled, 11, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavEnabled
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavTarget, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavTarget
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavType, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavConstant, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavConstant
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavRptCode, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavRptCode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavGridId, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavGridId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavChartId, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavChartId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavExtractId, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavExtractId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavBypassFilter, 19, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavBypassFilter
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.NavStatusToolTip, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.NavStatusToolTip
			c.CharacterMaxLength = 200
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.SlideMenuId, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.SlideMenuId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.SlideGroupId, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.SlideGroupId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.SlideLevelId, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.SlideLevelId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.SlideType, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.SlideType
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.SlideParentId, 25, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.SlideParentId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.SlideOrder, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.SlideOrder
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(GSafeSitemapItemsMetadata.ColumnNames.SlideImageClassName, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = GSafeSitemapItemsMetadata.PropertyNames.SlideImageClassName
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As GSafeSitemapItemsMetadata
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
			 Public Const NavLinkId As String = "NavLinkId"
			 Public Const NavSiteMapKeyWord As String = "NavSiteMapKeyWord"
			 Public Const NavAllReportsKeyword As String = "NavAllReportsKeyword"
			 Public Const NavAllDataKeyword As String = "NavAllDataKeyword"
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
			 Public Const NavLinkId As String = "NavLinkId"
			 Public Const NavSiteMapKeyWord As String = "NavSiteMapKeyWord"
			 Public Const NavAllReportsKeyword As String = "NavAllReportsKeyword"
			 Public Const NavAllDataKeyword As String = "NavAllDataKeyword"
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
			SyncLock GetType(GSafeSitemapItemsMetadata)
			
				If GSafeSitemapItemsMetadata.mapDelegates Is Nothing Then
					GSafeSitemapItemsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If GSafeSitemapItemsMetadata._meta Is Nothing Then
					GSafeSitemapItemsMetadata._meta = New GSafeSitemapItemsMetadata()
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
				meta.AddTypeMap("NavLinkId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavSiteMapKeyWord", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavAllReportsKeyword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavAllDataKeyword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavParentLinkId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavUrl", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavOrder", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavToolTip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavVisible", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("NavEnabled", new esTypeMap("bit", "System.Boolean"))
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
				
				
				 
				meta.Source = "GSafeSitemapItems"
				meta.Destination = "GSafeSitemapItems"
				
				meta.spInsert = "proc_GSafeSitemapItemsInsert"
				meta.spUpdate = "proc_GSafeSitemapItemsUpdate"
				meta.spDelete = "proc_GSafeSitemapItemsDelete"
				meta.spLoadAll = "proc_GSafeSitemapItemsLoadAll"
				meta.spLoadByPrimaryKey = "proc_GSafeSitemapItemsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As GSafeSitemapItemsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
