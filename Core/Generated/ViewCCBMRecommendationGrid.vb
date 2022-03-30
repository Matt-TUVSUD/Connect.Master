
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/22/2019 3:53:09 PM
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
	' Encapsulates the 'viewCCBMRecommendationGrid' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCBMRecommendationGrid))> _
	<XmlType("ViewCCBMRecommendationGrid")> _	
	Partial Public Class ViewCCBMRecommendationGrid 
		Inherits esViewCCBMRecommendationGrid
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCBMRecommendationGrid()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCBMRecommendationGridCollection")> _
	Partial Public Class ViewCCBMRecommendationGridCollection
		Inherits esViewCCBMRecommendationGridCollection
		Implements IEnumerable(Of ViewCCBMRecommendationGrid)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCBMRecommendationGrid))> _
		Public Class ViewCCBMRecommendationGridCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCBMRecommendationGridCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCBMRecommendationGridCollectionWCFPacket) As ViewCCBMRecommendationGridCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCBMRecommendationGridCollection) As ViewCCBMRecommendationGridCollectionWCFPacket
				Return New ViewCCBMRecommendationGridCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCBMRecommendationGridQuery 
		Inherits esViewCCBMRecommendationGridQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCBMRecommendationGridQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCBMRecommendationGridQuery) As String
			Return ViewCCBMRecommendationGridQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCBMRecommendationGridQuery
			Return DirectCast(ViewCCBMRecommendationGridQuery.SerializeHelper.FromXml(query, GetType(ViewCCBMRecommendationGridQuery)), ViewCCBMRecommendationGridQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCBMRecommendationGrid
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RecMo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecMo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecMo, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecMo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RecSubLetter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecSubLetter As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecSubLetter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecSubLetter, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecSubLetter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RecCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCode As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecCode, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RecImpact
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecImpact As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecImpact)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecImpact, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecImpact)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RecKeywords
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecKeywords As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecKeywords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RecKeywords, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecKeywords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.Current_LE_Actual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrentLEActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.CurrentLEActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.CurrentLEActual, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.CurrentLEActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.Current_LE_Range
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrentLERange As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.CurrentLERange)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.CurrentLERange, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.CurrentLERange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.Completed_LE_Actual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompletedLEActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.CompletedLEActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.CompletedLEActual, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.CompletedLEActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.Completed_LE_Range
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompletedLERange As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.CompletedLERange)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.CompletedLERange, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.CompletedLERange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.Est_CostToComplete_Actual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EstCostToCompleteActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.EstCostToCompleteActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.EstCostToCompleteActual, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.EstCostToCompleteActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.Est_CostToComplete_Range
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EstCostToCompleteRange As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.EstCostToCompleteRange)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.EstCostToCompleteRange, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.EstCostToCompleteRange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.Actual_CostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.ActualCostToComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCBMRecommendationGridMetadata.ColumnNames.ActualCostToComplete, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ActualCostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.ExpdComplDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpdComplDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.ExpdComplDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.ExpdComplDate, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ExpdComplDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.SavingsRatio
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SavingsRatio As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCBMRecommendationGridMetadata.ColumnNames.SavingsRatio)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCBMRecommendationGridMetadata.ColumnNames.SavingsRatio, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.SavingsRatio)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.RespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.RespDate, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.RespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RespFrom As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.RespFrom, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.FacilityComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FacilityComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.FacilityComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.FacilityComment, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.FacilityComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.MgmtRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespAction As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespAction, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.MgmtRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespDate, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.MgmtRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespFrom As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespFrom, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.MgmtRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespComment, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.ThirdLevelRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespAction As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.ThirdLevelRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.ThirdLevelRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespFrom As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCBMRecommendationGrid.ThirdLevelRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, value) Then
					OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespComment)
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
												
						Case "RecYear"
							Me.str().RecYear = CType(value, string)
												
						Case "RecMo"
							Me.str().RecMo = CType(value, string)
												
						Case "RecNumber"
							Me.str().RecNumber = CType(value, string)
												
						Case "RecSubLetter"
							Me.str().RecSubLetter = CType(value, string)
												
						Case "RecStatus"
							Me.str().RecStatus = CType(value, string)
												
						Case "StatusDate"
							Me.str().StatusDate = CType(value, string)
												
						Case "RecCode"
							Me.str().RecCode = CType(value, string)
												
						Case "RecImpact"
							Me.str().RecImpact = CType(value, string)
												
						Case "PrimaryRecType"
							Me.str().PrimaryRecType = CType(value, string)
												
						Case "SecondaryRecType"
							Me.str().SecondaryRecType = CType(value, string)
												
						Case "RecKeywords"
							Me.str().RecKeywords = CType(value, string)
												
						Case "CurrentLEActual"
							Me.str().CurrentLEActual = CType(value, string)
												
						Case "CurrentLERange"
							Me.str().CurrentLERange = CType(value, string)
												
						Case "CompletedLEActual"
							Me.str().CompletedLEActual = CType(value, string)
												
						Case "CompletedLERange"
							Me.str().CompletedLERange = CType(value, string)
												
						Case "EstCostToCompleteActual"
							Me.str().EstCostToCompleteActual = CType(value, string)
												
						Case "EstCostToCompleteRange"
							Me.str().EstCostToCompleteRange = CType(value, string)
												
						Case "ActualCostToComplete"
							Me.str().ActualCostToComplete = CType(value, string)
												
						Case "ExpdComplDate"
							Me.str().ExpdComplDate = CType(value, string)
												
						Case "SavingsRatio"
							Me.str().SavingsRatio = CType(value, string)
												
						Case "IntendedAction"
							Me.str().IntendedAction = CType(value, string)
												
						Case "RespDate"
							Me.str().RespDate = CType(value, string)
												
						Case "RespFrom"
							Me.str().RespFrom = CType(value, string)
												
						Case "FacilityComment"
							Me.str().FacilityComment = CType(value, string)
												
						Case "MgmtRespAction"
							Me.str().MgmtRespAction = CType(value, string)
												
						Case "MgmtRespDate"
							Me.str().MgmtRespDate = CType(value, string)
												
						Case "MgmtRespFrom"
							Me.str().MgmtRespFrom = CType(value, string)
												
						Case "MgmtRespComment"
							Me.str().MgmtRespComment = CType(value, string)
												
						Case "ThirdLevelRespAction"
							Me.str().ThirdLevelRespAction = CType(value, string)
												
						Case "ThirdLevelRespDate"
							Me.str().ThirdLevelRespDate = CType(value, string)
												
						Case "ThirdLevelRespFrom"
							Me.str().ThirdLevelRespFrom = CType(value, string)
												
						Case "ThirdLevelRespComment"
							Me.str().ThirdLevelRespComment = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecYear)
							End If
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RecNumber)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.StatusDate)
							End If
						
						Case "CurrentLEActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CurrentLEActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.CurrentLEActual)
							End If
						
						Case "CompletedLEActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CompletedLEActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.CompletedLEActual)
							End If
						
						Case "EstCostToCompleteActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EstCostToCompleteActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.EstCostToCompleteActual)
							End If
						
						Case "ActualCostToComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ActualCostToComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ActualCostToComplete)
							End If
						
						Case "ExpdComplDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpdComplDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ExpdComplDate)
							End If
						
						Case "SavingsRatio"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.SavingsRatio = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.SavingsRatio)
							End If
						
						Case "RespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.RespDate)
							End If
						
						Case "MgmtRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.MgmtRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespDate)
							End If
						
						Case "ThirdLevelRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ThirdLevelRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate)
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
		
			Public Sub New(ByVal entity As esViewCCBMRecommendationGrid)
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
		  	
			Public Property RecYear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecYear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecYear = Nothing
					Else
						entity.RecYear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecMo As System.String 
				Get
					Dim data_ As System.String = entity.RecMo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecMo = Nothing
					Else
						entity.RecMo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecNumber = Nothing
					Else
						entity.RecNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecSubLetter As System.String 
				Get
					Dim data_ As System.String = entity.RecSubLetter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecSubLetter = Nothing
					Else
						entity.RecSubLetter = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecStatus As System.String 
				Get
					Dim data_ As System.String = entity.RecStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecStatus = Nothing
					Else
						entity.RecStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property StatusDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.StatusDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StatusDate = Nothing
					Else
						entity.StatusDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecCode As System.String 
				Get
					Dim data_ As System.String = entity.RecCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCode = Nothing
					Else
						entity.RecCode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecImpact As System.String 
				Get
					Dim data_ As System.String = entity.RecImpact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecImpact = Nothing
					Else
						entity.RecImpact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrimaryRecType As System.String 
				Get
					Dim data_ As System.String = entity.PrimaryRecType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimaryRecType = Nothing
					Else
						entity.PrimaryRecType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecondaryRecType As System.String 
				Get
					Dim data_ As System.String = entity.SecondaryRecType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecondaryRecType = Nothing
					Else
						entity.SecondaryRecType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecKeywords As System.String 
				Get
					Dim data_ As System.String = entity.RecKeywords
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecKeywords = Nothing
					Else
						entity.RecKeywords = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CurrentLEActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CurrentLEActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CurrentLEActual = Nothing
					Else
						entity.CurrentLEActual = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CurrentLERange As System.String 
				Get
					Dim data_ As System.String = entity.CurrentLERange
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CurrentLERange = Nothing
					Else
						entity.CurrentLERange = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompletedLEActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CompletedLEActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompletedLEActual = Nothing
					Else
						entity.CompletedLEActual = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompletedLERange As System.String 
				Get
					Dim data_ As System.String = entity.CompletedLERange
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompletedLERange = Nothing
					Else
						entity.CompletedLERange = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EstCostToCompleteActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EstCostToCompleteActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EstCostToCompleteActual = Nothing
					Else
						entity.EstCostToCompleteActual = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EstCostToCompleteRange As System.String 
				Get
					Dim data_ As System.String = entity.EstCostToCompleteRange
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EstCostToCompleteRange = Nothing
					Else
						entity.EstCostToCompleteRange = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualCostToComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ActualCostToComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualCostToComplete = Nothing
					Else
						entity.ActualCostToComplete = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExpdComplDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ExpdComplDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpdComplDate = Nothing
					Else
						entity.ExpdComplDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property SavingsRatio As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.SavingsRatio
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SavingsRatio = Nothing
					Else
						entity.SavingsRatio = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property IntendedAction As System.String 
				Get
					Dim data_ As System.String = entity.IntendedAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IntendedAction = Nothing
					Else
						entity.IntendedAction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RespDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespDate = Nothing
					Else
						entity.RespDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RespFrom As System.String 
				Get
					Dim data_ As System.String = entity.RespFrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RespFrom = Nothing
					Else
						entity.RespFrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FacilityComment As System.String 
				Get
					Dim data_ As System.String = entity.FacilityComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FacilityComment = Nothing
					Else
						entity.FacilityComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtRespAction As System.String 
				Get
					Dim data_ As System.String = entity.MgmtRespAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespAction = Nothing
					Else
						entity.MgmtRespAction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtRespDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.MgmtRespDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespDate = Nothing
					Else
						entity.MgmtRespDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtRespFrom As System.String 
				Get
					Dim data_ As System.String = entity.MgmtRespFrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespFrom = Nothing
					Else
						entity.MgmtRespFrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtRespComment As System.String 
				Get
					Dim data_ As System.String = entity.MgmtRespComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespComment = Nothing
					Else
						entity.MgmtRespComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespAction As System.String 
				Get
					Dim data_ As System.String = entity.ThirdLevelRespAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespAction = Nothing
					Else
						entity.ThirdLevelRespAction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ThirdLevelRespDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespDate = Nothing
					Else
						entity.ThirdLevelRespDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespFrom As System.String 
				Get
					Dim data_ As System.String = entity.ThirdLevelRespFrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespFrom = Nothing
					Else
						entity.ThirdLevelRespFrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespComment As System.String 
				Get
					Dim data_ As System.String = entity.ThirdLevelRespComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespComment = Nothing
					Else
						entity.ThirdLevelRespComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCBMRecommendationGrid
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCBMRecommendationGridMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCBMRecommendationGridQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCBMRecommendationGridQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCBMRecommendationGridQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCBMRecommendationGridQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCBMRecommendationGridQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCBMRecommendationGridCollection
		Inherits esEntityCollection(Of ViewCCBMRecommendationGrid)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCBMRecommendationGridMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCBMRecommendationGridCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCBMRecommendationGridQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCBMRecommendationGridQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCBMRecommendationGridQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCBMRecommendationGridQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCBMRecommendationGridQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCBMRecommendationGridQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCBMRecommendationGridQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCBMRecommendationGridQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCBMRecommendationGridMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "RecYear" 
					Return Me.RecYear
				Case "RecMo" 
					Return Me.RecMo
				Case "RecNumber" 
					Return Me.RecNumber
				Case "RecSubLetter" 
					Return Me.RecSubLetter
				Case "RecStatus" 
					Return Me.RecStatus
				Case "StatusDate" 
					Return Me.StatusDate
				Case "RecCode" 
					Return Me.RecCode
				Case "RecImpact" 
					Return Me.RecImpact
				Case "PrimaryRecType" 
					Return Me.PrimaryRecType
				Case "SecondaryRecType" 
					Return Me.SecondaryRecType
				Case "RecKeywords" 
					Return Me.RecKeywords
				Case "CurrentLEActual" 
					Return Me.CurrentLEActual
				Case "CurrentLERange" 
					Return Me.CurrentLERange
				Case "CompletedLEActual" 
					Return Me.CompletedLEActual
				Case "CompletedLERange" 
					Return Me.CompletedLERange
				Case "EstCostToCompleteActual" 
					Return Me.EstCostToCompleteActual
				Case "EstCostToCompleteRange" 
					Return Me.EstCostToCompleteRange
				Case "ActualCostToComplete" 
					Return Me.ActualCostToComplete
				Case "ExpdComplDate" 
					Return Me.ExpdComplDate
				Case "SavingsRatio" 
					Return Me.SavingsRatio
				Case "IntendedAction" 
					Return Me.IntendedAction
				Case "RespDate" 
					Return Me.RespDate
				Case "RespFrom" 
					Return Me.RespFrom
				Case "FacilityComment" 
					Return Me.FacilityComment
				Case "MgmtRespAction" 
					Return Me.MgmtRespAction
				Case "MgmtRespDate" 
					Return Me.MgmtRespDate
				Case "MgmtRespFrom" 
					Return Me.MgmtRespFrom
				Case "MgmtRespComment" 
					Return Me.MgmtRespComment
				Case "ThirdLevelRespAction" 
					Return Me.ThirdLevelRespAction
				Case "ThirdLevelRespDate" 
					Return Me.ThirdLevelRespDate
				Case "ThirdLevelRespFrom" 
					Return Me.ThirdLevelRespFrom
				Case "ThirdLevelRespComment" 
					Return Me.ThirdLevelRespComment
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecMo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RecMo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecSubLetter As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RecSubLetter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RecCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecImpact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RecImpact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecKeywords As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RecKeywords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CurrentLEActual As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.CurrentLEActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CurrentLERange As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.CurrentLERange, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompletedLEActual As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.CompletedLEActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CompletedLERange As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.CompletedLERange, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EstCostToCompleteActual As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.EstCostToCompleteActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EstCostToCompleteRange As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.EstCostToCompleteRange, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.ActualCostToComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExpdComplDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.ExpdComplDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SavingsRatio As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.SavingsRatio, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RespDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.RespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FacilityComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.FacilityComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCBMRecommendationGridMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RecYear, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RecMo, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RecMo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RecNumber, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RecSubLetter, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RecSubLetter
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RecStatus, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.StatusDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RecCode, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RecCode
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RecImpact, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RecImpact
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.PrimaryRecType, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.SecondaryRecType, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RecKeywords, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RecKeywords
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.CurrentLEActual, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.CurrentLEActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.CurrentLERange, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.CurrentLERange
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.CompletedLEActual, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.CompletedLEActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.CompletedLERange, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.CompletedLERange
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.EstCostToCompleteActual, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.EstCostToCompleteActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.EstCostToCompleteRange, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.EstCostToCompleteRange
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.ActualCostToComplete, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.ActualCostToComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.ExpdComplDate, 19, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.ExpdComplDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.SavingsRatio, 20, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.SavingsRatio
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.IntendedAction, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RespDate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.RespFrom, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.RespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.FacilityComment, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.FacilityComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespAction, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespDate, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespFrom, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.MgmtRespComment, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.MgmtRespComment
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, 30, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCBMRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCBMRecommendationGridMetadata.PropertyNames.ThirdLevelRespComment
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCBMRecommendationGridMetadata
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
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMo As String = "RecMo"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecSubLetter As String = "RecSubLetter"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const RecImpact As String = "RecImpact"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecKeywords As String = "RecKeywords"
			 Public Const CurrentLEActual As String = "Current_LE_Actual"
			 Public Const CurrentLERange As String = "Current_LE_Range"
			 Public Const CompletedLEActual As String = "Completed_LE_Actual"
			 Public Const CompletedLERange As String = "Completed_LE_Range"
			 Public Const EstCostToCompleteActual As String = "Est_CostToComplete_Actual"
			 Public Const EstCostToCompleteRange As String = "Est_CostToComplete_Range"
			 Public Const ActualCostToComplete As String = "Actual_CostToComplete"
			 Public Const ExpdComplDate As String = "ExpdComplDate"
			 Public Const SavingsRatio As String = "SavingsRatio"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const RespDate As String = "RespDate"
			 Public Const RespFrom As String = "RespFrom"
			 Public Const FacilityComment As String = "FacilityComment"
			 Public Const MgmtRespAction As String = "MgmtRespAction"
			 Public Const MgmtRespDate As String = "MgmtRespDate"
			 Public Const MgmtRespFrom As String = "MgmtRespFrom"
			 Public Const MgmtRespComment As String = "MgmtRespComment"
			 Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
			 Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
			 Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
			 Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMo As String = "RecMo"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecSubLetter As String = "RecSubLetter"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const RecImpact As String = "RecImpact"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecKeywords As String = "RecKeywords"
			 Public Const CurrentLEActual As String = "CurrentLEActual"
			 Public Const CurrentLERange As String = "CurrentLERange"
			 Public Const CompletedLEActual As String = "CompletedLEActual"
			 Public Const CompletedLERange As String = "CompletedLERange"
			 Public Const EstCostToCompleteActual As String = "EstCostToCompleteActual"
			 Public Const EstCostToCompleteRange As String = "EstCostToCompleteRange"
			 Public Const ActualCostToComplete As String = "ActualCostToComplete"
			 Public Const ExpdComplDate As String = "ExpdComplDate"
			 Public Const SavingsRatio As String = "SavingsRatio"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const RespDate As String = "RespDate"
			 Public Const RespFrom As String = "RespFrom"
			 Public Const FacilityComment As String = "FacilityComment"
			 Public Const MgmtRespAction As String = "MgmtRespAction"
			 Public Const MgmtRespDate As String = "MgmtRespDate"
			 Public Const MgmtRespFrom As String = "MgmtRespFrom"
			 Public Const MgmtRespComment As String = "MgmtRespComment"
			 Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
			 Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
			 Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
			 Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
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
			SyncLock GetType(ViewCCBMRecommendationGridMetadata)
			
				If ViewCCBMRecommendationGridMetadata.mapDelegates Is Nothing Then
					ViewCCBMRecommendationGridMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCBMRecommendationGridMetadata._meta Is Nothing Then
					ViewCCBMRecommendationGridMetadata._meta = New ViewCCBMRecommendationGridMetadata()
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
				meta.AddTypeMap("RecYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecMo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecSubLetter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StatusDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("RecCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecImpact", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PrimaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SecondaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecKeywords", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CurrentLEActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CurrentLERange", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CompletedLEActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CompletedLERange", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EstCostToCompleteActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EstCostToCompleteRange", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ActualCostToComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExpdComplDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("SavingsRatio", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("IntendedAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RespFrom", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FacilityComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("MgmtRespFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ThirdLevelRespFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespComment", new esTypeMap("varchar", "System.String"))			
				
				meta.Schema = "dbo"
				 
				meta.Source = "viewCCBMRecommendationGrid"
				meta.Destination = "viewCCBMRecommendationGrid"
				
				meta.spInsert = "proc_viewCCBMRecommendationGridInsert"
				meta.spUpdate = "proc_viewCCBMRecommendationGridUpdate"
				meta.spDelete = "proc_viewCCBMRecommendationGridDelete"
				meta.spLoadAll = "proc_viewCCBMRecommendationGridLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCBMRecommendationGridLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCBMRecommendationGridMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
