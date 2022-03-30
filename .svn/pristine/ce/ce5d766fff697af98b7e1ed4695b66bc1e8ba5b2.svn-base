
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/25/2017 8:27:16 AM
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
	' Encapsulates the 'viewCCNavLink' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCNavLink))> _
	<XmlType("ViewCCNavLink")> _	
	Partial Public Class ViewCCNavLink 
		Inherits esViewCCNavLink
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCNavLink()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCNavLinkCollection")> _
	Partial Public Class ViewCCNavLinkCollection
		Inherits esViewCCNavLinkCollection
		Implements IEnumerable(Of ViewCCNavLink)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCNavLink))> _
		Public Class ViewCCNavLinkCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCNavLinkCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCNavLinkCollectionWCFPacket) As ViewCCNavLinkCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCNavLinkCollection) As ViewCCNavLinkCollectionWCFPacket
				Return New ViewCCNavLinkCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCNavLinkQuery 
		Inherits esViewCCNavLinkQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCNavLinkQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCNavLinkQuery) As String
			Return ViewCCNavLinkQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCNavLinkQuery
			Return DirectCast(ViewCCNavLinkQuery.SerializeHelper.FromXml(query, GetType(ViewCCNavLinkQuery)), ViewCCNavLinkQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCNavLink
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCNavLink.NavControlId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavControlId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavControlId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavControlId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavControlId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavPracticeID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavPracticeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavPracticeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavPracticeID, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavPracticeID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavLevelId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavLevelId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavLevelId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavLevelId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavLevelId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavParentLinkId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavParentLinkId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavParentLinkId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavParentLinkId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavParentLinkId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavLinkId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavLinkId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavLinkId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavLinkId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavLinkId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavText As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavText, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavText)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavUrl
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavUrl As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavUrl)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavUrl, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavUrl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavOrder
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavOrder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavOrder, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavOrder)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavToolTip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavToolTip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavToolTip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavToolTip, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavToolTip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavVisible
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavVisible As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavVisible)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavVisible, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavVisible)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavEnabled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavEnabled As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavEnabled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavEnabled, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavEnabled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavSpcFeature
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavSpcFeature As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavSpcFeature)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavSpcFeature, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavSpcFeature)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavIsPracticeTopLink
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavIsPracticeTopLink As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavIsPracticeTopLink)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavIsPracticeTopLink, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavIsPracticeTopLink)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavDefaultExpanded
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavDefaultExpanded As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavDefaultExpanded)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavDefaultExpanded, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavDefaultExpanded)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavSiteMapKeyword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavSiteMapKeyword As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavSiteMapKeyword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavSiteMapKeyword, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavSiteMapKeyword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavAllReportsKeyword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavAllReportsKeyword As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavAllReportsKeyword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavAllReportsKeyword, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavAllReportsKeyword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavAllDataKeyword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavAllDataKeyword As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavAllDataKeyword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavAllDataKeyword, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavAllDataKeyword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavTarget
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavTarget As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavTarget)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavTarget, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavTarget)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavType, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavComment, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavConstant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavConstant As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavConstant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavConstant, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavConstant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavRptCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavRptCode As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavRptCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavRptCode, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavRptCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavGridId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavGridId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavGridId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavGridId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavGridId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavChartId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavChartId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavChartId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavChartId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavChartId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavExtractId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavExtractId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavExtractId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.NavExtractId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavExtractId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavBypassFilter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavBypassFilter As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavBypassFilter)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.NavBypassFilter, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavBypassFilter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.NavStatusToolTip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NavStatusToolTip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavStatusToolTip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.NavStatusToolTip, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavStatusToolTip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.slideMenuId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideMenuId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideMenuId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideMenuId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideMenuId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.slideGroupId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideGroupId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideGroupId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideGroupId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideGroupId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.slideLevelId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideLevelId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideLevelId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideLevelId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideLevelId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.slideType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.SlideType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.SlideType, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.slideParentId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideParentId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideParentId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideParentId, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideParentId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.slideOrder
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideOrder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCNavLinkMetadata.ColumnNames.SlideOrder, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideOrder)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.slideImageClassName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SlideImageClassName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCNavLinkMetadata.ColumnNames.SlideImageClassName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCNavLinkMetadata.ColumnNames.SlideImageClassName, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideImageClassName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCNavLink.IsClientAdmin
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IsClientAdmin As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.IsClientAdmin)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCNavLinkMetadata.ColumnNames.IsClientAdmin, value) Then
					OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.IsClientAdmin)
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
												
						Case "NavControlId"
							Me.str().NavControlId = CType(value, string)
												
						Case "NavPracticeID"
							Me.str().NavPracticeID = CType(value, string)
												
						Case "NavLevelId"
							Me.str().NavLevelId = CType(value, string)
												
						Case "NavParentLinkId"
							Me.str().NavParentLinkId = CType(value, string)
												
						Case "NavLinkId"
							Me.str().NavLinkId = CType(value, string)
												
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
												
						Case "NavSpcFeature"
							Me.str().NavSpcFeature = CType(value, string)
												
						Case "NavIsPracticeTopLink"
							Me.str().NavIsPracticeTopLink = CType(value, string)
												
						Case "NavDefaultExpanded"
							Me.str().NavDefaultExpanded = CType(value, string)
												
						Case "NavSiteMapKeyword"
							Me.str().NavSiteMapKeyword = CType(value, string)
												
						Case "NavAllReportsKeyword"
							Me.str().NavAllReportsKeyword = CType(value, string)
												
						Case "NavAllDataKeyword"
							Me.str().NavAllDataKeyword = CType(value, string)
												
						Case "NavTarget"
							Me.str().NavTarget = CType(value, string)
												
						Case "NavType"
							Me.str().NavType = CType(value, string)
												
						Case "NavComment"
							Me.str().NavComment = CType(value, string)
												
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
												
						Case "IsClientAdmin"
							Me.str().IsClientAdmin = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "NavControlId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavControlId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavControlId)
							End If
						
						Case "NavPracticeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavPracticeID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavPracticeID)
							End If
						
						Case "NavLevelId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavLevelId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavLevelId)
							End If
						
						Case "NavParentLinkId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavParentLinkId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavParentLinkId)
							End If
						
						Case "NavLinkId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavLinkId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavLinkId)
							End If
						
						Case "NavOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavOrder = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavOrder)
							End If
						
						Case "NavVisible"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavVisible = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavVisible)
							End If
						
						Case "NavEnabled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavEnabled = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavEnabled)
							End If
						
						Case "NavIsPracticeTopLink"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavIsPracticeTopLink = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavIsPracticeTopLink)
							End If
						
						Case "NavDefaultExpanded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavDefaultExpanded = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavDefaultExpanded)
							End If
						
						Case "NavGridId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavGridId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavGridId)
							End If
						
						Case "NavChartId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavChartId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavChartId)
							End If
						
						Case "NavExtractId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NavExtractId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavExtractId)
							End If
						
						Case "NavBypassFilter"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.NavBypassFilter = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.NavBypassFilter)
							End If
						
						Case "SlideMenuId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideMenuId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideMenuId)
							End If
						
						Case "SlideGroupId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideGroupId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideGroupId)
							End If
						
						Case "SlideLevelId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideLevelId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideLevelId)
							End If
						
						Case "SlideParentId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideParentId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideParentId)
							End If
						
						Case "SlideOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SlideOrder = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.SlideOrder)
							End If
						
						Case "IsClientAdmin"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsClientAdmin = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCNavLinkMetadata.PropertyNames.IsClientAdmin)
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
		
			Public Sub New(ByVal entity As esViewCCNavLink)
				Me.entity = entity
			End Sub				
		
	
			Public Property NavControlId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavControlId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavControlId = Nothing
					Else
						entity.NavControlId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavPracticeID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavPracticeID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavPracticeID = Nothing
					Else
						entity.NavPracticeID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavLevelId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NavLevelId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavLevelId = Nothing
					Else
						entity.NavLevelId = Convert.ToInt32(Value)
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
		  	
			Public Property NavSpcFeature As System.String 
				Get
					Dim data_ As System.String = entity.NavSpcFeature
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavSpcFeature = Nothing
					Else
						entity.NavSpcFeature = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavIsPracticeTopLink As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.NavIsPracticeTopLink
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavIsPracticeTopLink = Nothing
					Else
						entity.NavIsPracticeTopLink = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavDefaultExpanded As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.NavDefaultExpanded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavDefaultExpanded = Nothing
					Else
						entity.NavDefaultExpanded = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property NavSiteMapKeyword As System.String 
				Get
					Dim data_ As System.String = entity.NavSiteMapKeyword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavSiteMapKeyword = Nothing
					Else
						entity.NavSiteMapKeyword = Convert.ToString(Value)
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
		  	
			Public Property NavComment As System.String 
				Get
					Dim data_ As System.String = entity.NavComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NavComment = Nothing
					Else
						entity.NavComment = Convert.ToString(Value)
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
		  	
			Public Property IsClientAdmin As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IsClientAdmin
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsClientAdmin = Nothing
					Else
						entity.IsClientAdmin = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCNavLink
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCNavLinkMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCNavLinkQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCNavLinkQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCNavLinkQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCNavLinkQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCNavLinkQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCNavLinkCollection
		Inherits esEntityCollection(Of ViewCCNavLink)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCNavLinkMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCNavLinkCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCNavLinkQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCNavLinkQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCNavLinkQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCNavLinkQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCNavLinkQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCNavLinkQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCNavLinkQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCNavLinkQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCNavLinkMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "NavControlId" 
					Return Me.NavControlId
				Case "NavPracticeID" 
					Return Me.NavPracticeID
				Case "NavLevelId" 
					Return Me.NavLevelId
				Case "NavParentLinkId" 
					Return Me.NavParentLinkId
				Case "NavLinkId" 
					Return Me.NavLinkId
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
				Case "NavSpcFeature" 
					Return Me.NavSpcFeature
				Case "NavIsPracticeTopLink" 
					Return Me.NavIsPracticeTopLink
				Case "NavDefaultExpanded" 
					Return Me.NavDefaultExpanded
				Case "NavSiteMapKeyword" 
					Return Me.NavSiteMapKeyword
				Case "NavAllReportsKeyword" 
					Return Me.NavAllReportsKeyword
				Case "NavAllDataKeyword" 
					Return Me.NavAllDataKeyword
				Case "NavTarget" 
					Return Me.NavTarget
				Case "NavType" 
					Return Me.NavType
				Case "NavComment" 
					Return Me.NavComment
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
				Case "IsClientAdmin" 
					Return Me.IsClientAdmin
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property NavControlId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavControlId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavPracticeID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavPracticeID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavLevelId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavLevelId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavParentLinkId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavParentLinkId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavLinkId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavLinkId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavUrl As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavUrl, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavOrder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavOrder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavToolTip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavToolTip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavVisible As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavVisible, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavEnabled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavEnabled, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavSpcFeature As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavSpcFeature, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavIsPracticeTopLink As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavIsPracticeTopLink, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavDefaultExpanded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavDefaultExpanded, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavSiteMapKeyword As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavSiteMapKeyword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavAllReportsKeyword As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavAllReportsKeyword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavAllDataKeyword As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavAllDataKeyword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavTarget As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavTarget, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavConstant As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavConstant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavRptCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavRptCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NavGridId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavGridId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavChartId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavChartId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavExtractId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavExtractId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NavBypassFilter As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavBypassFilter, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property NavStatusToolTip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.NavStatusToolTip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SlideMenuId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.SlideMenuId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideGroupId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.SlideGroupId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideLevelId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.SlideLevelId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.SlideType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SlideParentId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.SlideParentId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideOrder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.SlideOrder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SlideImageClassName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.SlideImageClassName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IsClientAdmin As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCNavLinkMetadata.ColumnNames.IsClientAdmin, esSystemType.Boolean)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCNavLinkMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavControlId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavControlId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavPracticeID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavPracticeID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavLevelId, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavLevelId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavParentLinkId, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavParentLinkId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavLinkId, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavLinkId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavText, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavText
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavUrl, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavUrl
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavOrder, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavOrder
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavToolTip, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavToolTip
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavVisible, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavVisible
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavEnabled, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavEnabled
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavSpcFeature, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavSpcFeature
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavIsPracticeTopLink, 12, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavIsPracticeTopLink
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavDefaultExpanded, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavDefaultExpanded
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavSiteMapKeyword, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavSiteMapKeyword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavAllReportsKeyword, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavAllReportsKeyword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavAllDataKeyword, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavAllDataKeyword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavTarget, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavTarget
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavType, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavComment, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavComment
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavConstant, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavConstant
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavRptCode, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavRptCode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavGridId, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavGridId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavChartId, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavChartId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavExtractId, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavExtractId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavBypassFilter, 25, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavBypassFilter
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.NavStatusToolTip, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.NavStatusToolTip
			c.CharacterMaxLength = 200
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.SlideMenuId, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.SlideMenuId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.SlideGroupId, 28, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.SlideGroupId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.SlideLevelId, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.SlideLevelId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.SlideType, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.SlideType
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.SlideParentId, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.SlideParentId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.SlideOrder, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.SlideOrder
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.SlideImageClassName, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.SlideImageClassName
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCNavLinkMetadata.ColumnNames.IsClientAdmin, 34, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCNavLinkMetadata.PropertyNames.IsClientAdmin
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCNavLinkMetadata
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
			 Public Const NavControlId As String = "NavControlId"
			 Public Const NavPracticeID As String = "NavPracticeID"
			 Public Const NavLevelId As String = "NavLevelId"
			 Public Const NavParentLinkId As String = "NavParentLinkId"
			 Public Const NavLinkId As String = "NavLinkId"
			 Public Const NavText As String = "NavText"
			 Public Const NavUrl As String = "NavUrl"
			 Public Const NavOrder As String = "NavOrder"
			 Public Const NavToolTip As String = "NavToolTip"
			 Public Const NavVisible As String = "NavVisible"
			 Public Const NavEnabled As String = "NavEnabled"
			 Public Const NavSpcFeature As String = "NavSpcFeature"
			 Public Const NavIsPracticeTopLink As String = "NavIsPracticeTopLink"
			 Public Const NavDefaultExpanded As String = "NavDefaultExpanded"
			 Public Const NavSiteMapKeyword As String = "NavSiteMapKeyword"
			 Public Const NavAllReportsKeyword As String = "NavAllReportsKeyword"
			 Public Const NavAllDataKeyword As String = "NavAllDataKeyword"
			 Public Const NavTarget As String = "NavTarget"
			 Public Const NavType As String = "NavType"
			 Public Const NavComment As String = "NavComment"
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
			 Public Const IsClientAdmin As String = "IsClientAdmin"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const NavControlId As String = "NavControlId"
			 Public Const NavPracticeID As String = "NavPracticeID"
			 Public Const NavLevelId As String = "NavLevelId"
			 Public Const NavParentLinkId As String = "NavParentLinkId"
			 Public Const NavLinkId As String = "NavLinkId"
			 Public Const NavText As String = "NavText"
			 Public Const NavUrl As String = "NavUrl"
			 Public Const NavOrder As String = "NavOrder"
			 Public Const NavToolTip As String = "NavToolTip"
			 Public Const NavVisible As String = "NavVisible"
			 Public Const NavEnabled As String = "NavEnabled"
			 Public Const NavSpcFeature As String = "NavSpcFeature"
			 Public Const NavIsPracticeTopLink As String = "NavIsPracticeTopLink"
			 Public Const NavDefaultExpanded As String = "NavDefaultExpanded"
			 Public Const NavSiteMapKeyword As String = "NavSiteMapKeyword"
			 Public Const NavAllReportsKeyword As String = "NavAllReportsKeyword"
			 Public Const NavAllDataKeyword As String = "NavAllDataKeyword"
			 Public Const NavTarget As String = "NavTarget"
			 Public Const NavType As String = "NavType"
			 Public Const NavComment As String = "NavComment"
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
			 Public Const IsClientAdmin As String = "IsClientAdmin"
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
			SyncLock GetType(ViewCCNavLinkMetadata)
			
				If ViewCCNavLinkMetadata.mapDelegates Is Nothing Then
					ViewCCNavLinkMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCNavLinkMetadata._meta Is Nothing Then
					ViewCCNavLinkMetadata._meta = New ViewCCNavLinkMetadata()
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
				


				meta.AddTypeMap("NavControlId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavPracticeID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavLevelId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavParentLinkId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavLinkId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavUrl", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavOrder", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NavToolTip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavVisible", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("NavEnabled", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("NavSpcFeature", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavIsPracticeTopLink", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("NavDefaultExpanded", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("NavSiteMapKeyword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavAllReportsKeyword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavAllDataKeyword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavTarget", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NavComment", new esTypeMap("varchar", "System.String"))
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
				meta.AddTypeMap("IsClientAdmin", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "viewCCNavLink"
				meta.Destination = "viewCCNavLink"
				
				meta.spInsert = "proc_viewCCNavLinkInsert"
				meta.spUpdate = "proc_viewCCNavLinkUpdate"
				meta.spDelete = "proc_viewCCNavLinkDelete"
				meta.spLoadAll = "proc_viewCCNavLinkLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCNavLinkLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCNavLinkMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
