
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/23/2020 2:30:45 PM
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
	' Encapsulates the 'viewCCIRRecommendationGrid' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCIRRecommendationGrid))> _
	<XmlType("ViewCCIRRecommendationGrid")> _	
	Partial Public Class ViewCCIRRecommendationGrid 
		Inherits esViewCCIRRecommendationGrid
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCIRRecommendationGrid()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCIRRecommendationGridCollection")> _
	Partial Public Class ViewCCIRRecommendationGridCollection
		Inherits esViewCCIRRecommendationGridCollection
		Implements IEnumerable(Of ViewCCIRRecommendationGrid)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCIRRecommendationGrid))> _
		Public Class ViewCCIRRecommendationGridCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCIRRecommendationGridCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCIRRecommendationGridCollectionWCFPacket) As ViewCCIRRecommendationGridCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCIRRecommendationGridCollection) As ViewCCIRRecommendationGridCollectionWCFPacket
				Return New ViewCCIRRecommendationGridCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCIRRecommendationGridQuery 
		Inherits esViewCCIRRecommendationGridQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCIRRecommendationGridQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCIRRecommendationGridQuery) As String
			Return ViewCCIRRecommendationGridQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCIRRecommendationGridQuery
			Return DirectCast(ViewCCIRRecommendationGridQuery.SerializeHelper.FromXml(query, GetType(ViewCCIRRecommendationGridQuery)), ViewCCIRRecommendationGridQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCIRRecommendationGrid
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.RecMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMonth As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RecMonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RecMonth, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.findingno
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Findingno As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCCIRRecommendationGridMetadata.ColumnNames.Findingno)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(ViewCCIRRecommendationGridMetadata.ColumnNames.Findingno, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Findingno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.itemno
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Itemno As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.Itemno)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.Itemno, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Itemno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.severityrating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Severityrating As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Severityrating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Severityrating, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Severityrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.Recommendation
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recommendation As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Recommendation)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Recommendation, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Recommendation)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.RecommendationID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecommendationID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.RecommendationID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.RecommendationID, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecommendationID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.FindEquip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FindEquip As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.FindEquip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.FindEquip, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.FindEquip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.PlantAreaAffected
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantAreaAffected As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.PlantAreaAffected)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.PlantAreaAffected, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.PlantAreaAffected)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.FaultType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FaultType As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.FaultType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.FaultType, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.FaultType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ProbableEquipmentDamageCost
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProbableEquipmentDamageCost As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.ProbableEquipmentDamageCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.ProbableEquipmentDamageCost, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ProbableEquipmentDamageCost)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.LengthOfBusinessInterruption
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LengthOfBusinessInterruption As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.LengthOfBusinessInterruption)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.LengthOfBusinessInterruption, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.LengthOfBusinessInterruption)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.CostOfBusinessInterruption
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostOfBusinessInterruption As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.CostOfBusinessInterruption)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.CostOfBusinessInterruption, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.CostOfBusinessInterruption)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.DetectedWith
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DetectedWith As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.DetectedWith)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.DetectedWith, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.DetectedWith)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.Impact
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Impact As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Impact)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Impact, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Impact)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.Comments2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments2 As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Comments2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Comments2, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Comments2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ResponseFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseFrom As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseFrom, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ResponseComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseComment, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ResponseStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseStatus, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.RedundancySpare
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RedundancySpare As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RedundancySpare)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RedundancySpare, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RedundancySpare)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.RecPrimary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPrimary As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RecPrimary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RecPrimary, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecPrimary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.RecSecondary
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecSecondary As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RecSecondary)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.RecSecondary, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecSecondary)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.PlantComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.PlantComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.PlantComment, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.PlantComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCIRRecommendationGridMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.History
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property History As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.History)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.History, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.History)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.Comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ExpectedCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.ExpectedCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.ExpectedCompletionDate, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ExpectedCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.MgmtRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespAction As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespAction, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.MgmtRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespDate, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.MgmtRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespFrom As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespFrom, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.MgmtRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespComment, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ThirdLevelRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespAction As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ThirdLevelRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ThirdLevelRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespFrom As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCIRRecommendationGrid.ThirdLevelRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespComment As System.String
			Get
				Return MyBase.GetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, value) Then
					OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespComment)
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
												
						Case "RecMonth"
							Me.str().RecMonth = CType(value, string)
												
						Case "RecNumber"
							Me.str().RecNumber = CType(value, string)
												
						Case "RecYear"
							Me.str().RecYear = CType(value, string)
												
						Case "Findingno"
							Me.str().Findingno = CType(value, string)
												
						Case "Itemno"
							Me.str().Itemno = CType(value, string)
												
						Case "Severityrating"
							Me.str().Severityrating = CType(value, string)
												
						Case "Recommendation"
							Me.str().Recommendation = CType(value, string)
												
						Case "RecommendationID"
							Me.str().RecommendationID = CType(value, string)
												
						Case "FindEquip"
							Me.str().FindEquip = CType(value, string)
												
						Case "PlantAreaAffected"
							Me.str().PlantAreaAffected = CType(value, string)
												
						Case "FaultType"
							Me.str().FaultType = CType(value, string)
												
						Case "ProbableEquipmentDamageCost"
							Me.str().ProbableEquipmentDamageCost = CType(value, string)
												
						Case "LengthOfBusinessInterruption"
							Me.str().LengthOfBusinessInterruption = CType(value, string)
												
						Case "CostOfBusinessInterruption"
							Me.str().CostOfBusinessInterruption = CType(value, string)
												
						Case "DetectedWith"
							Me.str().DetectedWith = CType(value, string)
												
						Case "Impact"
							Me.str().Impact = CType(value, string)
												
						Case "Comments2"
							Me.str().Comments2 = CType(value, string)
												
						Case "RecStatus"
							Me.str().RecStatus = CType(value, string)
												
						Case "StatusDate"
							Me.str().StatusDate = CType(value, string)
												
						Case "ResponseFrom"
							Me.str().ResponseFrom = CType(value, string)
												
						Case "ResponseDate"
							Me.str().ResponseDate = CType(value, string)
												
						Case "ResponseComment"
							Me.str().ResponseComment = CType(value, string)
												
						Case "ResponseStatus"
							Me.str().ResponseStatus = CType(value, string)
												
						Case "RedundancySpare"
							Me.str().RedundancySpare = CType(value, string)
												
						Case "RecPrimary"
							Me.str().RecPrimary = CType(value, string)
												
						Case "RecSecondary"
							Me.str().RecSecondary = CType(value, string)
												
						Case "IntendedAction"
							Me.str().IntendedAction = CType(value, string)
												
						Case "PlantComment"
							Me.str().PlantComment = CType(value, string)
												
						Case "Id"
							Me.str().Id = CType(value, string)
												
						Case "History"
							Me.str().History = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
												
						Case "ExpectedCompletionDate"
							Me.str().ExpectedCompletionDate = CType(value, string)
												
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
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecNumber)
							End If
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecYear)
							End If
						
						Case "Findingno"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Findingno = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Findingno)
							End If
						
						Case "Itemno"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemno = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Itemno)
							End If
						
						Case "RecommendationID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecommendationID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.RecommendationID)
							End If
						
						Case "ProbableEquipmentDamageCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProbableEquipmentDamageCost = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ProbableEquipmentDamageCost)
							End If
						
						Case "CostOfBusinessInterruption"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostOfBusinessInterruption = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.CostOfBusinessInterruption)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.StatusDate)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.Id)
							End If
						
						Case "ExpectedCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ExpectedCompletionDate)
							End If
						
						Case "MgmtRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.MgmtRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespDate)
							End If
						
						Case "ThirdLevelRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ThirdLevelRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate)
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
		
			Public Sub New(ByVal entity As esViewCCIRRecommendationGrid)
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
		  	
			Public Property RecMonth As System.String 
				Get
					Dim data_ As System.String = entity.RecMonth
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecMonth = Nothing
					Else
						entity.RecMonth = Convert.ToString(Value)
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
		  	
			Public Property Findingno As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Findingno
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Findingno = Nothing
					Else
						entity.Findingno = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemno As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Itemno
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemno = Nothing
					Else
						entity.Itemno = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Severityrating As System.String 
				Get
					Dim data_ As System.String = entity.Severityrating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Severityrating = Nothing
					Else
						entity.Severityrating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recommendation As System.String 
				Get
					Dim data_ As System.String = entity.Recommendation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recommendation = Nothing
					Else
						entity.Recommendation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecommendationID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecommendationID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecommendationID = Nothing
					Else
						entity.RecommendationID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FindEquip As System.String 
				Get
					Dim data_ As System.String = entity.FindEquip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FindEquip = Nothing
					Else
						entity.FindEquip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlantAreaAffected As System.String 
				Get
					Dim data_ As System.String = entity.PlantAreaAffected
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantAreaAffected = Nothing
					Else
						entity.PlantAreaAffected = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FaultType As System.String 
				Get
					Dim data_ As System.String = entity.FaultType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FaultType = Nothing
					Else
						entity.FaultType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProbableEquipmentDamageCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProbableEquipmentDamageCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProbableEquipmentDamageCost = Nothing
					Else
						entity.ProbableEquipmentDamageCost = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LengthOfBusinessInterruption As System.String 
				Get
					Dim data_ As System.String = entity.LengthOfBusinessInterruption
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LengthOfBusinessInterruption = Nothing
					Else
						entity.LengthOfBusinessInterruption = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CostOfBusinessInterruption As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CostOfBusinessInterruption
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CostOfBusinessInterruption = Nothing
					Else
						entity.CostOfBusinessInterruption = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DetectedWith As System.String 
				Get
					Dim data_ As System.String = entity.DetectedWith
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DetectedWith = Nothing
					Else
						entity.DetectedWith = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Impact As System.String 
				Get
					Dim data_ As System.String = entity.Impact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Impact = Nothing
					Else
						entity.Impact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Comments2 As System.String 
				Get
					Dim data_ As System.String = entity.Comments2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Comments2 = Nothing
					Else
						entity.Comments2 = Convert.ToString(Value)
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
		  	
			Public Property ResponseFrom As System.String 
				Get
					Dim data_ As System.String = entity.ResponseFrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseFrom = Nothing
					Else
						entity.ResponseFrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponseDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ResponseDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseDate = Nothing
					Else
						entity.ResponseDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponseComment As System.String 
				Get
					Dim data_ As System.String = entity.ResponseComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseComment = Nothing
					Else
						entity.ResponseComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponseStatus As System.String 
				Get
					Dim data_ As System.String = entity.ResponseStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseStatus = Nothing
					Else
						entity.ResponseStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RedundancySpare As System.String 
				Get
					Dim data_ As System.String = entity.RedundancySpare
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RedundancySpare = Nothing
					Else
						entity.RedundancySpare = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecPrimary As System.String 
				Get
					Dim data_ As System.String = entity.RecPrimary
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecPrimary = Nothing
					Else
						entity.RecPrimary = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecSecondary As System.String 
				Get
					Dim data_ As System.String = entity.RecSecondary
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecSecondary = Nothing
					Else
						entity.RecSecondary = Convert.ToString(Value)
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
		  	
			Public Property PlantComment As System.String 
				Get
					Dim data_ As System.String = entity.PlantComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantComment = Nothing
					Else
						entity.PlantComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Id
					
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
						entity.Id = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property History As System.String 
				Get
					Dim data_ As System.String = entity.History
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.History = Nothing
					Else
						entity.History = Convert.ToString(Value)
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
		  	
			Public Property ExpectedCompletionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ExpectedCompletionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExpectedCompletionDate = Nothing
					Else
						entity.ExpectedCompletionDate = Convert.ToDateTime(Value)
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
		  

			Private entity As esViewCCIRRecommendationGrid
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCIRRecommendationGridMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCIRRecommendationGridQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCIRRecommendationGridQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCIRRecommendationGridQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCIRRecommendationGridQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCIRRecommendationGridQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCIRRecommendationGridCollection
		Inherits esEntityCollection(Of ViewCCIRRecommendationGrid)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCIRRecommendationGridMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCIRRecommendationGridCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCIRRecommendationGridQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCIRRecommendationGridQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCIRRecommendationGridQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCIRRecommendationGridQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCIRRecommendationGridQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCIRRecommendationGridQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCIRRecommendationGridQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCIRRecommendationGridQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCIRRecommendationGridMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "RecMonth" 
					Return Me.RecMonth
				Case "RecNumber" 
					Return Me.RecNumber
				Case "RecYear" 
					Return Me.RecYear
				Case "Findingno" 
					Return Me.Findingno
				Case "Itemno" 
					Return Me.Itemno
				Case "Severityrating" 
					Return Me.Severityrating
				Case "Recommendation" 
					Return Me.Recommendation
				Case "RecommendationID" 
					Return Me.RecommendationID
				Case "FindEquip" 
					Return Me.FindEquip
				Case "PlantAreaAffected" 
					Return Me.PlantAreaAffected
				Case "FaultType" 
					Return Me.FaultType
				Case "ProbableEquipmentDamageCost" 
					Return Me.ProbableEquipmentDamageCost
				Case "LengthOfBusinessInterruption" 
					Return Me.LengthOfBusinessInterruption
				Case "CostOfBusinessInterruption" 
					Return Me.CostOfBusinessInterruption
				Case "DetectedWith" 
					Return Me.DetectedWith
				Case "Impact" 
					Return Me.Impact
				Case "Comments2" 
					Return Me.Comments2
				Case "RecStatus" 
					Return Me.RecStatus
				Case "StatusDate" 
					Return Me.StatusDate
				Case "ResponseFrom" 
					Return Me.ResponseFrom
				Case "ResponseDate" 
					Return Me.ResponseDate
				Case "ResponseComment" 
					Return Me.ResponseComment
				Case "ResponseStatus" 
					Return Me.ResponseStatus
				Case "RedundancySpare" 
					Return Me.RedundancySpare
				Case "RecPrimary" 
					Return Me.RecPrimary
				Case "RecSecondary" 
					Return Me.RecSecondary
				Case "IntendedAction" 
					Return Me.IntendedAction
				Case "PlantComment" 
					Return Me.PlantComment
				Case "Id" 
					Return Me.Id
				Case "History" 
					Return Me.History
				Case "Comments" 
					Return Me.Comments
				Case "ExpectedCompletionDate" 
					Return Me.ExpectedCompletionDate
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
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecMonth As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.RecMonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Findingno As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.Findingno, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Itemno As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.Itemno, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Severityrating As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.Severityrating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recommendation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.Recommendation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecommendationID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.RecommendationID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FindEquip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.FindEquip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantAreaAffected As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.PlantAreaAffected, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FaultType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.FaultType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProbableEquipmentDamageCost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ProbableEquipmentDamageCost, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LengthOfBusinessInterruption As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.LengthOfBusinessInterruption, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CostOfBusinessInterruption As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.CostOfBusinessInterruption, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DetectedWith As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.DetectedWith, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Impact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.Impact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.Comments2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseFrom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RedundancySpare As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.RedundancySpare, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecPrimary As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.RecPrimary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecSecondary As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.RecSecondary, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.PlantComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property History As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.History, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCIRRecommendationGridMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.RecMonth, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.RecMonth
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.RecNumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.RecYear, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.Findingno, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.Findingno
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.Itemno, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.Itemno
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.Severityrating, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.Severityrating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.Recommendation, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.Recommendation
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.RecommendationID, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.RecommendationID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.FindEquip, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.FindEquip
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.PlantAreaAffected, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.PlantAreaAffected
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.FaultType, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.FaultType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ProbableEquipmentDamageCost, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ProbableEquipmentDamageCost
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.LengthOfBusinessInterruption, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.LengthOfBusinessInterruption
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.CostOfBusinessInterruption, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.CostOfBusinessInterruption
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.DetectedWith, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.DetectedWith
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.Impact, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.Impact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.Comments2, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.Comments2
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.RecStatus, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.StatusDate, 19, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseFrom, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseFrom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseDate, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseComment, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseComment
			c.CharacterMaxLength = 250
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ResponseStatus, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ResponseStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.RedundancySpare, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.RedundancySpare
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.RecPrimary, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.RecPrimary
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.RecSecondary, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.RecSecondary
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.IntendedAction, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.PlantComment, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.PlantComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.Id, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.History, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.History
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.Comments, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ExpectedCompletionDate, 32, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ExpectedCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespAction, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespDate, 34, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespFrom, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.MgmtRespComment, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.MgmtRespComment
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, 38, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCIRRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCIRRecommendationGridMetadata.PropertyNames.ThirdLevelRespComment
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCIRRecommendationGridMetadata
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
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecYear As String = "RecYear"
			 Public Const Findingno As String = "findingno"
			 Public Const Itemno As String = "itemno"
			 Public Const Severityrating As String = "severityrating"
			 Public Const Recommendation As String = "Recommendation"
			 Public Const RecommendationID As String = "RecommendationID"
			 Public Const FindEquip As String = "FindEquip"
			 Public Const PlantAreaAffected As String = "PlantAreaAffected"
			 Public Const FaultType As String = "FaultType"
			 Public Const ProbableEquipmentDamageCost As String = "ProbableEquipmentDamageCost"
			 Public Const LengthOfBusinessInterruption As String = "LengthOfBusinessInterruption"
			 Public Const CostOfBusinessInterruption As String = "CostOfBusinessInterruption"
			 Public Const DetectedWith As String = "DetectedWith"
			 Public Const Impact As String = "Impact"
			 Public Const Comments2 As String = "Comments2"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const ResponseComment As String = "ResponseComment"
			 Public Const ResponseStatus As String = "ResponseStatus"
			 Public Const RedundancySpare As String = "RedundancySpare"
			 Public Const RecPrimary As String = "RecPrimary"
			 Public Const RecSecondary As String = "RecSecondary"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const Id As String = "ID"
			 Public Const History As String = "History"
			 Public Const Comments As String = "Comments"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
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
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecYear As String = "RecYear"
			 Public Const Findingno As String = "Findingno"
			 Public Const Itemno As String = "Itemno"
			 Public Const Severityrating As String = "Severityrating"
			 Public Const Recommendation As String = "Recommendation"
			 Public Const RecommendationID As String = "RecommendationID"
			 Public Const FindEquip As String = "FindEquip"
			 Public Const PlantAreaAffected As String = "PlantAreaAffected"
			 Public Const FaultType As String = "FaultType"
			 Public Const ProbableEquipmentDamageCost As String = "ProbableEquipmentDamageCost"
			 Public Const LengthOfBusinessInterruption As String = "LengthOfBusinessInterruption"
			 Public Const CostOfBusinessInterruption As String = "CostOfBusinessInterruption"
			 Public Const DetectedWith As String = "DetectedWith"
			 Public Const Impact As String = "Impact"
			 Public Const Comments2 As String = "Comments2"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const ResponseComment As String = "ResponseComment"
			 Public Const ResponseStatus As String = "ResponseStatus"
			 Public Const RedundancySpare As String = "RedundancySpare"
			 Public Const RecPrimary As String = "RecPrimary"
			 Public Const RecSecondary As String = "RecSecondary"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const Id As String = "Id"
			 Public Const History As String = "History"
			 Public Const Comments As String = "Comments"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
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
			SyncLock GetType(ViewCCIRRecommendationGridMetadata)
			
				If ViewCCIRRecommendationGridMetadata.mapDelegates Is Nothing Then
					ViewCCIRRecommendationGridMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCIRRecommendationGridMetadata._meta Is Nothing Then
					ViewCCIRRecommendationGridMetadata._meta = New ViewCCIRRecommendationGridMetadata()
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
				meta.AddTypeMap("RecMonth", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Findingno", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Itemno", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Severityrating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Recommendation", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecommendationID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FindEquip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantAreaAffected", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FaultType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ProbableEquipmentDamageCost", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LengthOfBusinessInterruption", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CostOfBusinessInterruption", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DetectedWith", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Impact", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Comments2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StatusDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ResponseFrom", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ResponseDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ResponseComment", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ResponseStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RedundancySpare", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecPrimary", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecSecondary", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("IntendedAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("History", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Comments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("MgmtRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("MgmtRespFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ThirdLevelRespFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespComment", new esTypeMap("varchar", "System.String"))			
				
				meta.Schema = "dbo"
				 
				meta.Source = "viewCCIRRecommendationGrid"
				meta.Destination = "viewCCIRRecommendationGrid"
				
				meta.spInsert = "proc_viewCCIRRecommendationGridInsert"
				meta.spUpdate = "proc_viewCCIRRecommendationGridUpdate"
				meta.spDelete = "proc_viewCCIRRecommendationGridDelete"
				meta.spLoadAll = "proc_viewCCIRRecommendationGridLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCIRRecommendationGridLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCIRRecommendationGridMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
