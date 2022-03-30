
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/31/2013 12:02:00 PM
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
	' Encapsulates the 'viewCCUserActivityGrid' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCUserActivityGrid))> _
	<XmlType("ViewCCUserActivityGrid")> _	
	Partial Public Class ViewCCUserActivityGrid 
		Inherits esViewCCUserActivityGrid
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCUserActivityGrid()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCUserActivityGridCollection")> _
	Partial Public Class ViewCCUserActivityGridCollection
		Inherits esViewCCUserActivityGridCollection
		Implements IEnumerable(Of ViewCCUserActivityGrid)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCUserActivityGrid))> _
		Public Class ViewCCUserActivityGridCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCUserActivityGridCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCUserActivityGridCollectionWCFPacket) As ViewCCUserActivityGridCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCUserActivityGridCollection) As ViewCCUserActivityGridCollectionWCFPacket
				Return New ViewCCUserActivityGridCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCUserActivityGridQuery 
		Inherits esViewCCUserActivityGridQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCUserActivityGridQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCUserActivityGridQuery) As String
			Return ViewCCUserActivityGridQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCUserActivityGridQuery
			Return DirectCast(ViewCCUserActivityGridQuery.SerializeHelper.FromXml(query, GetType(ViewCCUserActivityGridQuery)), ViewCCUserActivityGridQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCUserActivityGrid
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCUserActivityGrid.UserID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UserID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.UserID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.UserID, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.UserID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Password
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Password As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Password)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Password, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Password)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.FullName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FullName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.FullName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.FullName, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.FullName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.RiskManager
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RiskManager As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.RiskManager)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.RiskManager, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.RiskManager)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.DivisionManager
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DivisionManager As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.DivisionManager)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.DivisionManager, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.DivisionManager)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Division
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Division As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Division)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Division, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Division)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.PlantManager
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantManager As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.PlantManager)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.PlantManager, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.PlantManager)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Plant
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Plant As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Plant)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Plant, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Plant)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Administrator
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Administrator As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.Administrator)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.Administrator, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Administrator)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.DocumentAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DocumentAccess As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.DocumentAccess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.DocumentAccess, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.DocumentAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.CustomAccessText
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccessText As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.CustomAccessText)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.CustomAccessText, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.CustomAccessText)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.OperatorStamp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OperatorStamp As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.OperatorStamp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.OperatorStamp, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.OperatorStamp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.DateTimeStamp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateTimeStamp As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.DateTimeStamp)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.DateTimeStamp, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.DateTimeStamp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Phone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Phone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Phone, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Phone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Fax
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Email
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Email As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Email)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Email, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Email)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.NotificationStamp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NotificationStamp As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.NotificationStamp)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.NotificationStamp, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.NotificationStamp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.ActiveUser
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveUser As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.ActiveUser)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.ActiveUser, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.ActiveUser)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCUserActivityGridMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCUserActivityGridMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.LastLogin
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastLogin As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.LastLogin)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.LastLogin, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.LastLogin)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.LastPWChange
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastPWChange As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.LastPWChange)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.LastPWChange, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.LastPWChange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Internal
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Internal As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.Internal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.Internal, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Internal)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.RInit
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RInit As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.RInit)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.RInit, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.RInit)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Rfu1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rfu1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Rfu1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Rfu1, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Rfu1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Rfu2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rfu2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Rfu2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Rfu2, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Rfu2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Rfu3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Rfu3 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Rfu3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Rfu3, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Rfu3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.RReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.RReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.RReport, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.RReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.ROverdue1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ROverdue1 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue1, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.ROverdue1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.ROverdue2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ROverdue2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue2, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.ROverdue2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.ROverdue3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ROverdue3 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue3, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.ROverdue3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.RActResp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RActResp As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.RActResp)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.RActResp, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.RActResp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.ExpOverdue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpOverdue As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.ExpOverdue)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.ExpOverdue, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.ExpOverdue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.Wo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Wo As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.Wo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.Wo, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Wo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.CCActive
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CCActive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.CCActive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.CCActive, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.CCActive)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.calist
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Calist As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Calist)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Calist, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Calist)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.divlist
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Divlist As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Divlist)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Divlist, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Divlist)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.loclist
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Loclist As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Loclist)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.Loclist, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Loclist)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.ThirdParty 
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdParty As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.ThirdParty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCUserActivityGridMetadata.ColumnNames.ThirdParty, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.ThirdParty)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.GRCAdministrator 
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCAdministrator As System.String
			Get
				Return MyBase.GetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.GRCAdministrator)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCUserActivityGridMetadata.ColumnNames.GRCAdministrator, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.GRCAdministrator)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.LastRecentUpdate 
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastRecentUpdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.LastRecentUpdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCUserActivityGridMetadata.ColumnNames.LastRecentUpdate, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.LastRecentUpdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCUserActivityGrid.EzyUserID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EzyUserID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCUserActivityGridMetadata.ColumnNames.EzyUserID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCUserActivityGridMetadata.ColumnNames.EzyUserID, value) Then
					OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.EzyUserID)
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
												
						Case "UserID"
							Me.str().UserID = CType(value, string)
												
						Case "Password"
							Me.str().Password = CType(value, string)
												
						Case "FullName"
							Me.str().FullName = CType(value, string)
												
						Case "RiskManager"
							Me.str().RiskManager = CType(value, string)
												
						Case "DivisionManager"
							Me.str().DivisionManager = CType(value, string)
												
						Case "Division"
							Me.str().Division = CType(value, string)
												
						Case "PlantManager"
							Me.str().PlantManager = CType(value, string)
												
						Case "Plant"
							Me.str().Plant = CType(value, string)
												
						Case "Administrator"
							Me.str().Administrator = CType(value, string)
												
						Case "DocumentAccess"
							Me.str().DocumentAccess = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "CustomAccessText"
							Me.str().CustomAccessText = CType(value, string)
												
						Case "OperatorStamp"
							Me.str().OperatorStamp = CType(value, string)
												
						Case "DateTimeStamp"
							Me.str().DateTimeStamp = CType(value, string)
												
						Case "Phone"
							Me.str().Phone = CType(value, string)
												
						Case "Fax"
							Me.str().Fax = CType(value, string)
												
						Case "Email"
							Me.str().Email = CType(value, string)
												
						Case "NotificationStamp"
							Me.str().NotificationStamp = CType(value, string)
												
						Case "ActiveUser"
							Me.str().ActiveUser = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "LastLogin"
							Me.str().LastLogin = CType(value, string)
												
						Case "LastPWChange"
							Me.str().LastPWChange = CType(value, string)
												
						Case "Internal"
							Me.str().Internal = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
												
						Case "RInit"
							Me.str().RInit = CType(value, string)
												
						Case "Rfu1"
							Me.str().Rfu1 = CType(value, string)
												
						Case "Rfu2"
							Me.str().Rfu2 = CType(value, string)
												
						Case "Rfu3"
							Me.str().Rfu3 = CType(value, string)
												
						Case "RReport"
							Me.str().RReport = CType(value, string)
												
						Case "ROverdue1"
							Me.str().ROverdue1 = CType(value, string)
												
						Case "ROverdue2"
							Me.str().ROverdue2 = CType(value, string)
												
						Case "ROverdue3"
							Me.str().ROverdue3 = CType(value, string)
												
						Case "RActResp"
							Me.str().RActResp = CType(value, string)
												
						Case "ExpOverdue"
							Me.str().ExpOverdue = CType(value, string)
												
						Case "Wo"
							Me.str().Wo = CType(value, string)
												
						Case "CCActive"
							Me.str().CCActive = CType(value, string)
												
						Case "Calist"
							Me.str().Calist = CType(value, string)
												
						Case "Divlist"
							Me.str().Divlist = CType(value, string)
												
						Case "Loclist"
							Me.str().Loclist = CType(value, string)
												
						Case "ThirdParty"
							Me.str().ThirdParty = CType(value, string)
												
						Case "GRCAdministrator"
							Me.str().GRCAdministrator = CType(value, string)
												
						Case "LastRecentUpdate"
							Me.str().LastRecentUpdate = CType(value, string)
												
						Case "EzyUserID"
							Me.str().EzyUserID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RiskManager"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.RiskManager = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.RiskManager)
							End If
						
						Case "DivisionManager"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.DivisionManager = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.DivisionManager)
							End If
						
						Case "PlantManager"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.PlantManager = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.PlantManager)
							End If
						
						Case "Administrator"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Administrator = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Administrator)
							End If
						
						Case "DocumentAccess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.DocumentAccess = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.DocumentAccess)
							End If
						
						Case "CustomAccess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CustomAccess = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.CustomAccess)
							End If
						
						Case "DateTimeStamp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateTimeStamp = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.DateTimeStamp)
							End If
						
						Case "NotificationStamp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.NotificationStamp = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.NotificationStamp)
							End If
						
						Case "ActiveUser"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ActiveUser = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.ActiveUser)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "LastLogin"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastLogin = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.LastLogin)
							End If
						
						Case "LastPWChange"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastPWChange = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.LastPWChange)
							End If
						
						Case "Internal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Internal = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Internal)
							End If
						
						Case "Wo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Wo = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.Wo)
							End If
						
						Case "CCActive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CCActive = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.CCActive)
							End If
						
						Case "ThirdParty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ThirdParty = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.ThirdParty)
							End If
						
						Case "LastRecentUpdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastRecentUpdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.LastRecentUpdate)
							End If
						
						Case "EzyUserID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EzyUserID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCUserActivityGridMetadata.PropertyNames.EzyUserID)
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
		
			Public Sub New(ByVal entity As esViewCCUserActivityGrid)
				Me.entity = entity
			End Sub				
		
	
			Public Property UserID As System.String 
				Get
					Dim data_ As System.String = entity.UserID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UserID = Nothing
					Else
						entity.UserID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Password As System.String 
				Get
					Dim data_ As System.String = entity.Password
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Password = Nothing
					Else
						entity.Password = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FullName As System.String 
				Get
					Dim data_ As System.String = entity.FullName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FullName = Nothing
					Else
						entity.FullName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RiskManager As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.RiskManager
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RiskManager = Nothing
					Else
						entity.RiskManager = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property DivisionManager As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.DivisionManager
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DivisionManager = Nothing
					Else
						entity.DivisionManager = Convert.ToBoolean(Value)
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
		  	
			Public Property PlantManager As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.PlantManager
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantManager = Nothing
					Else
						entity.PlantManager = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Plant As System.String 
				Get
					Dim data_ As System.String = entity.Plant
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Plant = Nothing
					Else
						entity.Plant = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Administrator As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Administrator
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Administrator = Nothing
					Else
						entity.Administrator = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property DocumentAccess As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.DocumentAccess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DocumentAccess = Nothing
					Else
						entity.DocumentAccess = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomAccess As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CustomAccess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomAccess = Nothing
					Else
						entity.CustomAccess = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomAccessText As System.String 
				Get
					Dim data_ As System.String = entity.CustomAccessText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomAccessText = Nothing
					Else
						entity.CustomAccessText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OperatorStamp As System.String 
				Get
					Dim data_ As System.String = entity.OperatorStamp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OperatorStamp = Nothing
					Else
						entity.OperatorStamp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateTimeStamp As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateTimeStamp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateTimeStamp = Nothing
					Else
						entity.DateTimeStamp = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phone As System.String 
				Get
					Dim data_ As System.String = entity.Phone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phone = Nothing
					Else
						entity.Phone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fax As System.String 
				Get
					Dim data_ As System.String = entity.Fax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fax = Nothing
					Else
						entity.Fax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Email As System.String 
				Get
					Dim data_ As System.String = entity.Email
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Email = Nothing
					Else
						entity.Email = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NotificationStamp As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.NotificationStamp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NotificationStamp = Nothing
					Else
						entity.NotificationStamp = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveUser As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ActiveUser
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveUser = Nothing
					Else
						entity.ActiveUser = Convert.ToBoolean(Value)
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
		  	
			Public Property LastLogin As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastLogin
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastLogin = Nothing
					Else
						entity.LastLogin = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastPWChange As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastPWChange
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastPWChange = Nothing
					Else
						entity.LastPWChange = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Internal As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Internal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Internal = Nothing
					Else
						entity.Internal = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Comments As System.String 
				Get
					Dim data_ As System.String = entity.Comments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Comments = Nothing
					Else
						entity.Comments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RInit As System.String 
				Get
					Dim data_ As System.String = entity.RInit
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RInit = Nothing
					Else
						entity.RInit = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rfu1 As System.String 
				Get
					Dim data_ As System.String = entity.Rfu1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rfu1 = Nothing
					Else
						entity.Rfu1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rfu2 As System.String 
				Get
					Dim data_ As System.String = entity.Rfu2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rfu2 = Nothing
					Else
						entity.Rfu2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rfu3 As System.String 
				Get
					Dim data_ As System.String = entity.Rfu3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rfu3 = Nothing
					Else
						entity.Rfu3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RReport As System.String 
				Get
					Dim data_ As System.String = entity.RReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RReport = Nothing
					Else
						entity.RReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ROverdue1 As System.String 
				Get
					Dim data_ As System.String = entity.ROverdue1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ROverdue1 = Nothing
					Else
						entity.ROverdue1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ROverdue2 As System.String 
				Get
					Dim data_ As System.String = entity.ROverdue2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ROverdue2 = Nothing
					Else
						entity.ROverdue2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ROverdue3 As System.String 
				Get
					Dim data_ As System.String = entity.ROverdue3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ROverdue3 = Nothing
					Else
						entity.ROverdue3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RActResp As System.String 
				Get
					Dim data_ As System.String = entity.RActResp
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RActResp = Nothing
					Else
						entity.RActResp = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExpOverdue As System.String 
				Get
					Dim data_ As System.String = entity.ExpOverdue
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpOverdue = Nothing
					Else
						entity.ExpOverdue = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Wo As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Wo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Wo = Nothing
					Else
						entity.Wo = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property CCActive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CCActive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CCActive = Nothing
					Else
						entity.CCActive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Calist As System.String 
				Get
					Dim data_ As System.String = entity.Calist
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Calist = Nothing
					Else
						entity.Calist = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Divlist As System.String 
				Get
					Dim data_ As System.String = entity.Divlist
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Divlist = Nothing
					Else
						entity.Divlist = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Loclist As System.String 
				Get
					Dim data_ As System.String = entity.Loclist
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Loclist = Nothing
					Else
						entity.Loclist = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdParty As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ThirdParty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdParty = Nothing
					Else
						entity.ThirdParty = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property GRCAdministrator As System.String 
				Get
					Dim data_ As System.String = entity.GRCAdministrator
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GRCAdministrator = Nothing
					Else
						entity.GRCAdministrator = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastRecentUpdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastRecentUpdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastRecentUpdate = Nothing
					Else
						entity.LastRecentUpdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property EzyUserID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EzyUserID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EzyUserID = Nothing
					Else
						entity.EzyUserID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCUserActivityGrid
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCUserActivityGridMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCUserActivityGridQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCUserActivityGridQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCUserActivityGridQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCUserActivityGridQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCUserActivityGridQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCUserActivityGridCollection
		Inherits esEntityCollection(Of ViewCCUserActivityGrid)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCUserActivityGridMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCUserActivityGridCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCUserActivityGridQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCUserActivityGridQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCUserActivityGridQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCUserActivityGridQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCUserActivityGridQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCUserActivityGridQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCUserActivityGridQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCUserActivityGridQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCUserActivityGridMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "UserID" 
					Return Me.UserID
				Case "Password" 
					Return Me.Password
				Case "FullName" 
					Return Me.FullName
				Case "RiskManager" 
					Return Me.RiskManager
				Case "DivisionManager" 
					Return Me.DivisionManager
				Case "Division" 
					Return Me.Division
				Case "PlantManager" 
					Return Me.PlantManager
				Case "Plant" 
					Return Me.Plant
				Case "Administrator" 
					Return Me.Administrator
				Case "DocumentAccess" 
					Return Me.DocumentAccess
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "CustomAccessText" 
					Return Me.CustomAccessText
				Case "OperatorStamp" 
					Return Me.OperatorStamp
				Case "DateTimeStamp" 
					Return Me.DateTimeStamp
				Case "Phone" 
					Return Me.Phone
				Case "Fax" 
					Return Me.Fax
				Case "Email" 
					Return Me.Email
				Case "NotificationStamp" 
					Return Me.NotificationStamp
				Case "ActiveUser" 
					Return Me.ActiveUser
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "LastLogin" 
					Return Me.LastLogin
				Case "LastPWChange" 
					Return Me.LastPWChange
				Case "Internal" 
					Return Me.Internal
				Case "Comments" 
					Return Me.Comments
				Case "RInit" 
					Return Me.RInit
				Case "Rfu1" 
					Return Me.Rfu1
				Case "Rfu2" 
					Return Me.Rfu2
				Case "Rfu3" 
					Return Me.Rfu3
				Case "RReport" 
					Return Me.RReport
				Case "ROverdue1" 
					Return Me.ROverdue1
				Case "ROverdue2" 
					Return Me.ROverdue2
				Case "ROverdue3" 
					Return Me.ROverdue3
				Case "RActResp" 
					Return Me.RActResp
				Case "ExpOverdue" 
					Return Me.ExpOverdue
				Case "Wo" 
					Return Me.Wo
				Case "CCActive" 
					Return Me.CCActive
				Case "Calist" 
					Return Me.Calist
				Case "Divlist" 
					Return Me.Divlist
				Case "Loclist" 
					Return Me.Loclist
				Case "ThirdParty" 
					Return Me.ThirdParty
				Case "GRCAdministrator" 
					Return Me.GRCAdministrator
				Case "LastRecentUpdate" 
					Return Me.LastRecentUpdate
				Case "EzyUserID" 
					Return Me.EzyUserID
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property UserID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.UserID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Password As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Password, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FullName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.FullName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RiskManager As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.RiskManager, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property DivisionManager As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.DivisionManager, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Division As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Division, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantManager As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.PlantManager, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Plant As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Plant, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Administrator As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Administrator, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property DocumentAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.DocumentAccess, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.CustomAccess, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccessText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.CustomAccessText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OperatorStamp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.OperatorStamp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateTimeStamp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.DateTimeStamp, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Phone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Phone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Email As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Email, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NotificationStamp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.NotificationStamp, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveUser As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.ActiveUser, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property LastLogin As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.LastLogin, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LastPWChange As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.LastPWChange, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Internal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Internal, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RInit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.RInit, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rfu1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Rfu1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rfu2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Rfu2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rfu3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Rfu3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.RReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ROverdue1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.ROverdue1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ROverdue2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.ROverdue2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ROverdue3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.ROverdue3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RActResp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.RActResp, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpOverdue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.ExpOverdue, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Wo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Wo, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property CCActive As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.CCActive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Calist As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Calist, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Divlist As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Divlist, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Loclist As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.Loclist, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdParty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.ThirdParty, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property GRCAdministrator As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.GRCAdministrator, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastRecentUpdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.LastRecentUpdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property EzyUserID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCUserActivityGridMetadata.ColumnNames.EzyUserID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCUserActivityGridMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.UserID, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.UserID
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Password, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Password
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.FullName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.FullName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.RiskManager, 3, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.RiskManager
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.DivisionManager, 4, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.DivisionManager
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Division, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Division
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.PlantManager, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.PlantManager
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Plant, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Plant
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Administrator, 8, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Administrator
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.DocumentAccess, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.DocumentAccess
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.CustomAccess, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.CustomAccess
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.CustomAccessText, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.CustomAccessText
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.OperatorStamp, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.OperatorStamp
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.DateTimeStamp, 13, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.DateTimeStamp
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Phone, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Phone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Fax, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Fax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Email, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Email
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.NotificationStamp, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.NotificationStamp
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.ActiveUser, 18, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.ActiveUser
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.FilePrefix, 19, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.LastLogin, 20, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.LastLogin
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.LastPWChange, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.LastPWChange
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Internal, 22, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Internal
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Comments, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.RInit, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.RInit
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Rfu1, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Rfu1
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Rfu2, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Rfu2
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Rfu3, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Rfu3
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.RReport, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.RReport
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue1, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.ROverdue1
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue2, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.ROverdue2
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.ROverdue3, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.ROverdue3
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.RActResp, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.RActResp
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.ExpOverdue, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.ExpOverdue
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Wo, 34, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Wo
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.CCActive, 35, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.CCActive
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Calist, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Calist
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Divlist, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Divlist
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.Loclist, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.Loclist
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.ThirdParty, 39, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.ThirdParty
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.GRCAdministrator, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.GRCAdministrator
			c.CharacterMaxLength = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.LastRecentUpdate, 41, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.LastRecentUpdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCUserActivityGridMetadata.ColumnNames.EzyUserID, 42, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCUserActivityGridMetadata.PropertyNames.EzyUserID
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCUserActivityGridMetadata
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
			 Public Const UserID As String = "UserID"
			 Public Const Password As String = "Password"
			 Public Const FullName As String = "FullName"
			 Public Const RiskManager As String = "RiskManager"
			 Public Const DivisionManager As String = "DivisionManager"
			 Public Const Division As String = "Division"
			 Public Const PlantManager As String = "PlantManager"
			 Public Const Plant As String = "Plant"
			 Public Const Administrator As String = "Administrator"
			 Public Const DocumentAccess As String = "DocumentAccess"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const CustomAccessText As String = "CustomAccessText"
			 Public Const OperatorStamp As String = "OperatorStamp"
			 Public Const DateTimeStamp As String = "DateTimeStamp"
			 Public Const Phone As String = "Phone"
			 Public Const Fax As String = "Fax"
			 Public Const Email As String = "Email"
			 Public Const NotificationStamp As String = "NotificationStamp"
			 Public Const ActiveUser As String = "ActiveUser"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const LastLogin As String = "LastLogin"
			 Public Const LastPWChange As String = "LastPWChange"
			 Public Const Internal As String = "Internal"
			 Public Const Comments As String = "Comments"
			 Public Const RInit As String = "RInit"
			 Public Const Rfu1 As String = "Rfu1"
			 Public Const Rfu2 As String = "Rfu2"
			 Public Const Rfu3 As String = "Rfu3"
			 Public Const RReport As String = "RReport"
			 Public Const ROverdue1 As String = "ROverdue1"
			 Public Const ROverdue2 As String = "ROverdue2"
			 Public Const ROverdue3 As String = "ROverdue3"
			 Public Const RActResp As String = "RActResp"
			 Public Const ExpOverdue As String = "ExpOverdue"
			 Public Const Wo As String = "Wo"
			 Public Const CCActive As String = "CCActive"
			 Public Const Calist As String = "calist"
			 Public Const Divlist As String = "divlist"
			 Public Const Loclist As String = "loclist"
			 Public Const ThirdParty As String = "ThirdParty "
			 Public Const GRCAdministrator As String = "GRCAdministrator "
			 Public Const LastRecentUpdate As String = "LastRecentUpdate "
			 Public Const EzyUserID As String = "EzyUserID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const UserID As String = "UserID"
			 Public Const Password As String = "Password"
			 Public Const FullName As String = "FullName"
			 Public Const RiskManager As String = "RiskManager"
			 Public Const DivisionManager As String = "DivisionManager"
			 Public Const Division As String = "Division"
			 Public Const PlantManager As String = "PlantManager"
			 Public Const Plant As String = "Plant"
			 Public Const Administrator As String = "Administrator"
			 Public Const DocumentAccess As String = "DocumentAccess"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const CustomAccessText As String = "CustomAccessText"
			 Public Const OperatorStamp As String = "OperatorStamp"
			 Public Const DateTimeStamp As String = "DateTimeStamp"
			 Public Const Phone As String = "Phone"
			 Public Const Fax As String = "Fax"
			 Public Const Email As String = "Email"
			 Public Const NotificationStamp As String = "NotificationStamp"
			 Public Const ActiveUser As String = "ActiveUser"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const LastLogin As String = "LastLogin"
			 Public Const LastPWChange As String = "LastPWChange"
			 Public Const Internal As String = "Internal"
			 Public Const Comments As String = "Comments"
			 Public Const RInit As String = "RInit"
			 Public Const Rfu1 As String = "Rfu1"
			 Public Const Rfu2 As String = "Rfu2"
			 Public Const Rfu3 As String = "Rfu3"
			 Public Const RReport As String = "RReport"
			 Public Const ROverdue1 As String = "ROverdue1"
			 Public Const ROverdue2 As String = "ROverdue2"
			 Public Const ROverdue3 As String = "ROverdue3"
			 Public Const RActResp As String = "RActResp"
			 Public Const ExpOverdue As String = "ExpOverdue"
			 Public Const Wo As String = "Wo"
			 Public Const CCActive As String = "CCActive"
			 Public Const Calist As String = "Calist"
			 Public Const Divlist As String = "Divlist"
			 Public Const Loclist As String = "Loclist"
			 Public Const ThirdParty As String = "ThirdParty"
			 Public Const GRCAdministrator As String = "GRCAdministrator"
			 Public Const LastRecentUpdate As String = "LastRecentUpdate"
			 Public Const EzyUserID As String = "EzyUserID"
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
			SyncLock GetType(ViewCCUserActivityGridMetadata)
			
				If ViewCCUserActivityGridMetadata.mapDelegates Is Nothing Then
					ViewCCUserActivityGridMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCUserActivityGridMetadata._meta Is Nothing Then
					ViewCCUserActivityGridMetadata._meta = New ViewCCUserActivityGridMetadata()
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
				


				meta.AddTypeMap("UserID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Password", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FullName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RiskManager", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("DivisionManager", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Division", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PlantManager", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Plant", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Administrator", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("DocumentAccess", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CustomAccessText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OperatorStamp", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DateTimeStamp", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Phone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NotificationStamp", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ActiveUser", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("LastLogin", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LastPWChange", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Internal", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RInit", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rfu1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rfu2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rfu3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RReport", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ROverdue1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ROverdue2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ROverdue3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RActResp", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExpOverdue", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Wo", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("CCActive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Calist", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Divlist", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Loclist", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdParty", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("GRCAdministrator", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LastRecentUpdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("EzyUserID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCUserActivityGrid"
				meta.Destination = "viewCCUserActivityGrid"
				
				meta.spInsert = "proc_viewCCUserActivityGridInsert"
				meta.spUpdate = "proc_viewCCUserActivityGridUpdate"
				meta.spDelete = "proc_viewCCUserActivityGridDelete"
				meta.spLoadAll = "proc_viewCCUserActivityGridLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCUserActivityGridLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCUserActivityGridMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
