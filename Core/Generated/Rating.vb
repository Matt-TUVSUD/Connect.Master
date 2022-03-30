
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:25 PM
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
	' Encapsulates the 'Rating' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Rating))> _
	<XmlType("Rating")> _	
	Partial Public Class Rating 
		Inherits esRating
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Rating()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Decimal)
			Dim obj As New Rating()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Decimal, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Rating()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("RatingCollection")> _
	Partial Public Class RatingCollection
		Inherits esRatingCollection
		Implements IEnumerable(Of Rating)
	
		Public Function FindByPrimaryKey(ByVal id As System.Decimal) As Rating
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Rating))> _
		Public Class RatingCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of RatingCollection)
			
			Public Shared Widening Operator CType(packet As RatingCollectionWCFPacket) As RatingCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As RatingCollection) As RatingCollectionWCFPacket
				Return New RatingCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class RatingQuery 
		Inherits esRatingQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "RatingQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As RatingQuery) As String
			Return RatingQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As RatingQuery
			Return DirectCast(RatingQuery.SerializeHelper.FromXml(query, GetType(RatingQuery)), RatingQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esRating
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Decimal) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Decimal) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Decimal) As Boolean
		
			Dim query As New RatingQuery()
			query.Where(query.Id = id)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Decimal) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Rating.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(RatingMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(RatingMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.ConstructionRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.ConstructionRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.ConstructionRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.ConstructionRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.Grade
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Grade As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.Grade)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.Grade, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.Grade)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OccupancyRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.OccupancyRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.OccupancyRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OccupancyRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.FloodRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.FloodRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.FloodRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.FloodRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.EarthquakeRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EarthquakeRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.EarthquakeRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.EarthquakeRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.EarthquakeRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.WindstormRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindstormRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.WindstormRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.WindstormRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.WindstormRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OtherRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.OtherRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.OtherRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OtherRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.PhysicalProtectionRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PhysicalProtectionRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.PhysicalProtectionRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.PhysicalProtectionRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.PhysicalProtectionRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.HumanElementRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.HumanElementRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.HumanElementRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.HumanElementRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.NaturalHazardsProtectionRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NaturalHazardsProtectionRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.NaturalHazardsProtectionRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.NaturalHazardsProtectionRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.NaturalHazardsProtectionRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.BusinessContinuityRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessContinuityRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.BusinessContinuityRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.BusinessContinuityRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.BusinessContinuityRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.APL
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Apl As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.Apl)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.Apl, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.Apl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.APLFactor
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLFactor As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.APLFactor)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.APLFactor, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.APLFactor)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OverallPlantRatingRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallPlantRatingRating As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.OverallPlantRatingRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.OverallPlantRatingRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OverallPlantRatingRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.PassiveScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PassiveScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.PassiveScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.PassiveScore, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.PassiveScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.ActiveScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.ActiveScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.ActiveScore, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.ActiveScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.TotalScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.TotalScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.TotalScore, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.TotalScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.TotalScoreRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalScoreRating As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.TotalScoreRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.TotalScoreRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.TotalScoreRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.TotalFacilityScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TotalFacilityScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.TotalFacilityScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.TotalFacilityScore, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.TotalFacilityScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OtherWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.OtherWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.OtherWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OtherWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.ConstructionWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.ConstructionWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.ConstructionWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.ConstructionWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OccupancyWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.OccupancyWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.OccupancyWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OccupancyWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.PhysicalProtectionWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PhysicalProtectionWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.PhysicalProtectionWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.PhysicalProtectionWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.PhysicalProtectionWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.HumanElementWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.HumanElementWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.HumanElementWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.HumanElementWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.NaturalHazardsProtectionWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NaturalHazardsProtectionWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.NaturalHazardsProtectionWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.NaturalHazardsProtectionWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.NaturalHazardsProtectionWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.BusinessContinuityWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessContinuityWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.BusinessContinuityWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.BusinessContinuityWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.BusinessContinuityWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.FireProtectionAllRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireProtectionAllRecsCompleteRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.FireProtectionAllRecsCompleteRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.FireProtectionAllRecsCompleteRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.FireProtectionAllRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.HumanElementAllRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanElementAllRecsCompleteRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.HumanElementAllRecsCompleteRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.HumanElementAllRecsCompleteRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.HumanElementAllRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.NatHazProtAllRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NatHazProtAllRecsCompleteRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.NatHazProtAllRecsCompleteRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.NatHazProtAllRecsCompleteRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.NatHazProtAllRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.BCPAllRecsCompletRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BCPAllRecsCompletRating As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.BCPAllRecsCompletRating)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.BCPAllRecsCompletRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.BCPAllRecsCompletRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.ActiveScoreWithRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActiveScoreWithRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.ActiveScoreWithRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.ActiveScoreWithRecsComplete, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.ActiveScoreWithRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.APLWithAllRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLWithAllRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.APLWithAllRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.APLWithAllRecsComplete, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.APLWithAllRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.FloodWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.FloodWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.FloodWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.FloodWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.EarthquakeWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EarthquakeWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.EarthquakeWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.EarthquakeWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.EarthquakeWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.WindstormWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindstormWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.WindstormWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.WindstormWeight, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.WindstormWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OverallScoreWithRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallScoreWithRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.OverallScoreWithRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.OverallScoreWithRecsComplete, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OverallScoreWithRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.MaxPossibleScore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MaxPossibleScore As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.MaxPossibleScore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.MaxPossibleScore, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.MaxPossibleScore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.APLFactorWithAllRecsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property APLFactorWithAllRecsComplete As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.APLFactorWithAllRecsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.APLFactorWithAllRecsComplete, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.APLFactorWithAllRecsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.FloodDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.FloodDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.FloodDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.FloodDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.EarthquakeDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EarthquakeDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.EarthquakeDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.EarthquakeDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.EarthquakeDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.WindstormDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindstormDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.WindstormDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.WindstormDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.WindstormDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.ConstructionDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ConstructionDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.ConstructionDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.ConstructionDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.ConstructionDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OccupancyDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OccupancyDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.OccupancyDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.OccupancyDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OccupancyDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OtherDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.OtherDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.OtherDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OtherDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.FireDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.FireDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.FireDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.FireDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.HumanDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.HumanDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.HumanDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.HumanDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.NaturalDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NaturalDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.NaturalDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.NaturalDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.NaturalDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.BusinessDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.BusinessDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.BusinessDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.BusinessDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.FireRecDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireRecDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.FireRecDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.FireRecDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.FireRecDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.HumanRecDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property HumanRecDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.HumanRecDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.HumanRecDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.HumanRecDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.NaturalRecDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property NaturalRecDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.NaturalRecDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.NaturalRecDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.NaturalRecDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.BusinessRecDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BusinessRecDescription As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.BusinessRecDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.BusinessRecDescription, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.BusinessRecDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.ExchangeRate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRate As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(RatingMetadata.ColumnNames.ExchangeRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(RatingMetadata.ColumnNames.ExchangeRate, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.ExchangeRate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.AdminMemo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminMemo As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.AdminMemo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.AdminMemo, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.AdminMemo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.OverallScoreWithRecsCompleteRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OverallScoreWithRecsCompleteRating As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.OverallScoreWithRecsCompleteRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.OverallScoreWithRecsCompleteRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Rating.MaxPossibleRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MaxPossibleRating As System.String
			Get
				Return MyBase.GetSystemString(RatingMetadata.ColumnNames.MaxPossibleRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RatingMetadata.ColumnNames.MaxPossibleRating, value) Then
					OnPropertyChanged(RatingMetadata.PropertyNames.MaxPossibleRating)
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
												
						Case "Id"
							Me.str().Id = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "InspectionDate"
							Me.str().InspectionDate = CType(value, string)
												
						Case "ConstructionRating"
							Me.str().ConstructionRating = CType(value, string)
												
						Case "Grade"
							Me.str().Grade = CType(value, string)
												
						Case "OccupancyRating"
							Me.str().OccupancyRating = CType(value, string)
												
						Case "FloodRating"
							Me.str().FloodRating = CType(value, string)
												
						Case "EarthquakeRating"
							Me.str().EarthquakeRating = CType(value, string)
												
						Case "WindstormRating"
							Me.str().WindstormRating = CType(value, string)
												
						Case "OtherRating"
							Me.str().OtherRating = CType(value, string)
												
						Case "PhysicalProtectionRating"
							Me.str().PhysicalProtectionRating = CType(value, string)
												
						Case "HumanElementRating"
							Me.str().HumanElementRating = CType(value, string)
												
						Case "NaturalHazardsProtectionRating"
							Me.str().NaturalHazardsProtectionRating = CType(value, string)
												
						Case "BusinessContinuityRating"
							Me.str().BusinessContinuityRating = CType(value, string)
												
						Case "Apl"
							Me.str().Apl = CType(value, string)
												
						Case "APLFactor"
							Me.str().APLFactor = CType(value, string)
												
						Case "OverallPlantRatingRating"
							Me.str().OverallPlantRatingRating = CType(value, string)
												
						Case "PassiveScore"
							Me.str().PassiveScore = CType(value, string)
												
						Case "ActiveScore"
							Me.str().ActiveScore = CType(value, string)
												
						Case "TotalScore"
							Me.str().TotalScore = CType(value, string)
												
						Case "TotalScoreRating"
							Me.str().TotalScoreRating = CType(value, string)
												
						Case "TotalFacilityScore"
							Me.str().TotalFacilityScore = CType(value, string)
												
						Case "OtherWeight"
							Me.str().OtherWeight = CType(value, string)
												
						Case "ConstructionWeight"
							Me.str().ConstructionWeight = CType(value, string)
												
						Case "OccupancyWeight"
							Me.str().OccupancyWeight = CType(value, string)
												
						Case "PhysicalProtectionWeight"
							Me.str().PhysicalProtectionWeight = CType(value, string)
												
						Case "HumanElementWeight"
							Me.str().HumanElementWeight = CType(value, string)
												
						Case "NaturalHazardsProtectionWeight"
							Me.str().NaturalHazardsProtectionWeight = CType(value, string)
												
						Case "BusinessContinuityWeight"
							Me.str().BusinessContinuityWeight = CType(value, string)
												
						Case "FireProtectionAllRecsCompleteRating"
							Me.str().FireProtectionAllRecsCompleteRating = CType(value, string)
												
						Case "HumanElementAllRecsCompleteRating"
							Me.str().HumanElementAllRecsCompleteRating = CType(value, string)
												
						Case "NatHazProtAllRecsCompleteRating"
							Me.str().NatHazProtAllRecsCompleteRating = CType(value, string)
												
						Case "BCPAllRecsCompletRating"
							Me.str().BCPAllRecsCompletRating = CType(value, string)
												
						Case "ActiveScoreWithRecsComplete"
							Me.str().ActiveScoreWithRecsComplete = CType(value, string)
												
						Case "APLWithAllRecsComplete"
							Me.str().APLWithAllRecsComplete = CType(value, string)
												
						Case "FloodWeight"
							Me.str().FloodWeight = CType(value, string)
												
						Case "EarthquakeWeight"
							Me.str().EarthquakeWeight = CType(value, string)
												
						Case "WindstormWeight"
							Me.str().WindstormWeight = CType(value, string)
												
						Case "OverallScoreWithRecsComplete"
							Me.str().OverallScoreWithRecsComplete = CType(value, string)
												
						Case "MaxPossibleScore"
							Me.str().MaxPossibleScore = CType(value, string)
												
						Case "APLFactorWithAllRecsComplete"
							Me.str().APLFactorWithAllRecsComplete = CType(value, string)
												
						Case "FloodDescription"
							Me.str().FloodDescription = CType(value, string)
												
						Case "EarthquakeDescription"
							Me.str().EarthquakeDescription = CType(value, string)
												
						Case "WindstormDescription"
							Me.str().WindstormDescription = CType(value, string)
												
						Case "ConstructionDescription"
							Me.str().ConstructionDescription = CType(value, string)
												
						Case "OccupancyDescription"
							Me.str().OccupancyDescription = CType(value, string)
												
						Case "OtherDescription"
							Me.str().OtherDescription = CType(value, string)
												
						Case "FireDescription"
							Me.str().FireDescription = CType(value, string)
												
						Case "HumanDescription"
							Me.str().HumanDescription = CType(value, string)
												
						Case "NaturalDescription"
							Me.str().NaturalDescription = CType(value, string)
												
						Case "BusinessDescription"
							Me.str().BusinessDescription = CType(value, string)
												
						Case "FireRecDescription"
							Me.str().FireRecDescription = CType(value, string)
												
						Case "HumanRecDescription"
							Me.str().HumanRecDescription = CType(value, string)
												
						Case "NaturalRecDescription"
							Me.str().NaturalRecDescription = CType(value, string)
												
						Case "BusinessRecDescription"
							Me.str().BusinessRecDescription = CType(value, string)
												
						Case "ExchangeRate"
							Me.str().ExchangeRate = CType(value, string)
												
						Case "AdminMemo"
							Me.str().AdminMemo = CType(value, string)
												
						Case "OverallScoreWithRecsCompleteRating"
							Me.str().OverallScoreWithRecsCompleteRating = CType(value, string)
												
						Case "MaxPossibleRating"
							Me.str().MaxPossibleRating = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Id = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.Id)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(RatingMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "ConstructionRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ConstructionRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.ConstructionRating)
							End If
						
						Case "Grade"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Grade = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.Grade)
							End If
						
						Case "OccupancyRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OccupancyRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.OccupancyRating)
							End If
						
						Case "FloodRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FloodRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.FloodRating)
							End If
						
						Case "EarthquakeRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.EarthquakeRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.EarthquakeRating)
							End If
						
						Case "WindstormRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WindstormRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.WindstormRating)
							End If
						
						Case "OtherRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OtherRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.OtherRating)
							End If
						
						Case "PhysicalProtectionRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PhysicalProtectionRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.PhysicalProtectionRating)
							End If
						
						Case "HumanElementRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.HumanElementRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.HumanElementRating)
							End If
						
						Case "NaturalHazardsProtectionRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.NaturalHazardsProtectionRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.NaturalHazardsProtectionRating)
							End If
						
						Case "BusinessContinuityRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BusinessContinuityRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.BusinessContinuityRating)
							End If
						
						Case "Apl"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Apl = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.Apl)
							End If
						
						Case "APLFactor"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLFactor = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.APLFactor)
							End If
						
						Case "PassiveScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PassiveScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.PassiveScore)
							End If
						
						Case "ActiveScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ActiveScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.ActiveScore)
							End If
						
						Case "TotalScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.TotalScore)
							End If
						
						Case "TotalFacilityScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalFacilityScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.TotalFacilityScore)
							End If
						
						Case "OtherWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OtherWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.OtherWeight)
							End If
						
						Case "ConstructionWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ConstructionWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.ConstructionWeight)
							End If
						
						Case "OccupancyWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OccupancyWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.OccupancyWeight)
							End If
						
						Case "PhysicalProtectionWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.PhysicalProtectionWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.PhysicalProtectionWeight)
							End If
						
						Case "HumanElementWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.HumanElementWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.HumanElementWeight)
							End If
						
						Case "NaturalHazardsProtectionWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.NaturalHazardsProtectionWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.NaturalHazardsProtectionWeight)
							End If
						
						Case "BusinessContinuityWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BusinessContinuityWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.BusinessContinuityWeight)
							End If
						
						Case "FireProtectionAllRecsCompleteRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FireProtectionAllRecsCompleteRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.FireProtectionAllRecsCompleteRating)
							End If
						
						Case "HumanElementAllRecsCompleteRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.HumanElementAllRecsCompleteRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.HumanElementAllRecsCompleteRating)
							End If
						
						Case "NatHazProtAllRecsCompleteRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.NatHazProtAllRecsCompleteRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.NatHazProtAllRecsCompleteRating)
							End If
						
						Case "BCPAllRecsCompletRating"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BCPAllRecsCompletRating = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.BCPAllRecsCompletRating)
							End If
						
						Case "ActiveScoreWithRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ActiveScoreWithRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.ActiveScoreWithRecsComplete)
							End If
						
						Case "APLWithAllRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLWithAllRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.APLWithAllRecsComplete)
							End If
						
						Case "FloodWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FloodWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.FloodWeight)
							End If
						
						Case "EarthquakeWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.EarthquakeWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.EarthquakeWeight)
							End If
						
						Case "WindstormWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WindstormWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.WindstormWeight)
							End If
						
						Case "OverallScoreWithRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OverallScoreWithRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.OverallScoreWithRecsComplete)
							End If
						
						Case "MaxPossibleScore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.MaxPossibleScore = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.MaxPossibleScore)
							End If
						
						Case "APLFactorWithAllRecsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.APLFactorWithAllRecsComplete = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.APLFactorWithAllRecsComplete)
							End If
						
						Case "ExchangeRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ExchangeRate = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(RatingMetadata.PropertyNames.ExchangeRate)
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
		
			Public Sub New(ByVal entity As esRating)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property InspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionDate = Nothing
					Else
						entity.InspectionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ConstructionRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionRating = Nothing
					Else
						entity.ConstructionRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Grade As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Grade
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Grade = Nothing
					Else
						entity.Grade = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OccupancyRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyRating = Nothing
					Else
						entity.OccupancyRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FloodRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodRating = Nothing
					Else
						entity.FloodRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property EarthquakeRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.EarthquakeRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EarthquakeRating = Nothing
					Else
						entity.EarthquakeRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindstormRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WindstormRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindstormRating = Nothing
					Else
						entity.WindstormRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OtherRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherRating = Nothing
					Else
						entity.OtherRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PhysicalProtectionRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PhysicalProtectionRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PhysicalProtectionRating = Nothing
					Else
						entity.PhysicalProtectionRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.HumanElementRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementRating = Nothing
					Else
						entity.HumanElementRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property NaturalHazardsProtectionRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.NaturalHazardsProtectionRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NaturalHazardsProtectionRating = Nothing
					Else
						entity.NaturalHazardsProtectionRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BusinessContinuityRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BusinessContinuityRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessContinuityRating = Nothing
					Else
						entity.BusinessContinuityRating = Convert.ToDecimal(Value)
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
		  	
			Public Property APLFactor As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLFactor
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLFactor = Nothing
					Else
						entity.APLFactor = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallPlantRatingRating As System.String 
				Get
					Dim data_ As System.String = entity.OverallPlantRatingRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallPlantRatingRating = Nothing
					Else
						entity.OverallPlantRatingRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PassiveScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PassiveScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PassiveScore = Nothing
					Else
						entity.PassiveScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ActiveScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveScore = Nothing
					Else
						entity.ActiveScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalScore = Nothing
					Else
						entity.TotalScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalScoreRating As System.String 
				Get
					Dim data_ As System.String = entity.TotalScoreRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalScoreRating = Nothing
					Else
						entity.TotalScoreRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalFacilityScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalFacilityScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalFacilityScore = Nothing
					Else
						entity.TotalFacilityScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OtherWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherWeight = Nothing
					Else
						entity.OtherWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ConstructionWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionWeight = Nothing
					Else
						entity.ConstructionWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OccupancyWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyWeight = Nothing
					Else
						entity.OccupancyWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property PhysicalProtectionWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.PhysicalProtectionWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PhysicalProtectionWeight = Nothing
					Else
						entity.PhysicalProtectionWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.HumanElementWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementWeight = Nothing
					Else
						entity.HumanElementWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property NaturalHazardsProtectionWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.NaturalHazardsProtectionWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NaturalHazardsProtectionWeight = Nothing
					Else
						entity.NaturalHazardsProtectionWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BusinessContinuityWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BusinessContinuityWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessContinuityWeight = Nothing
					Else
						entity.BusinessContinuityWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireProtectionAllRecsCompleteRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FireProtectionAllRecsCompleteRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireProtectionAllRecsCompleteRating = Nothing
					Else
						entity.FireProtectionAllRecsCompleteRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanElementAllRecsCompleteRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.HumanElementAllRecsCompleteRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanElementAllRecsCompleteRating = Nothing
					Else
						entity.HumanElementAllRecsCompleteRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property NatHazProtAllRecsCompleteRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.NatHazProtAllRecsCompleteRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NatHazProtAllRecsCompleteRating = Nothing
					Else
						entity.NatHazProtAllRecsCompleteRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BCPAllRecsCompletRating As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BCPAllRecsCompletRating
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BCPAllRecsCompletRating = Nothing
					Else
						entity.BCPAllRecsCompletRating = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActiveScoreWithRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ActiveScoreWithRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActiveScoreWithRecsComplete = Nothing
					Else
						entity.ActiveScoreWithRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLWithAllRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLWithAllRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLWithAllRecsComplete = Nothing
					Else
						entity.APLWithAllRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FloodWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodWeight = Nothing
					Else
						entity.FloodWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property EarthquakeWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.EarthquakeWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EarthquakeWeight = Nothing
					Else
						entity.EarthquakeWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindstormWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WindstormWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindstormWeight = Nothing
					Else
						entity.WindstormWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OverallScoreWithRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OverallScoreWithRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OverallScoreWithRecsComplete = Nothing
					Else
						entity.OverallScoreWithRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property MaxPossibleScore As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.MaxPossibleScore
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxPossibleScore = Nothing
					Else
						entity.MaxPossibleScore = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property APLFactorWithAllRecsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.APLFactorWithAllRecsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APLFactorWithAllRecsComplete = Nothing
					Else
						entity.APLFactorWithAllRecsComplete = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodDescription As System.String 
				Get
					Dim data_ As System.String = entity.FloodDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodDescription = Nothing
					Else
						entity.FloodDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EarthquakeDescription As System.String 
				Get
					Dim data_ As System.String = entity.EarthquakeDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EarthquakeDescription = Nothing
					Else
						entity.EarthquakeDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindstormDescription As System.String 
				Get
					Dim data_ As System.String = entity.WindstormDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindstormDescription = Nothing
					Else
						entity.WindstormDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConstructionDescription As System.String 
				Get
					Dim data_ As System.String = entity.ConstructionDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConstructionDescription = Nothing
					Else
						entity.ConstructionDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OccupancyDescription As System.String 
				Get
					Dim data_ As System.String = entity.OccupancyDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OccupancyDescription = Nothing
					Else
						entity.OccupancyDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherDescription As System.String 
				Get
					Dim data_ As System.String = entity.OtherDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherDescription = Nothing
					Else
						entity.OtherDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireDescription As System.String 
				Get
					Dim data_ As System.String = entity.FireDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireDescription = Nothing
					Else
						entity.FireDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanDescription As System.String 
				Get
					Dim data_ As System.String = entity.HumanDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanDescription = Nothing
					Else
						entity.HumanDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NaturalDescription As System.String 
				Get
					Dim data_ As System.String = entity.NaturalDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NaturalDescription = Nothing
					Else
						entity.NaturalDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BusinessDescription As System.String 
				Get
					Dim data_ As System.String = entity.BusinessDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessDescription = Nothing
					Else
						entity.BusinessDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireRecDescription As System.String 
				Get
					Dim data_ As System.String = entity.FireRecDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireRecDescription = Nothing
					Else
						entity.FireRecDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HumanRecDescription As System.String 
				Get
					Dim data_ As System.String = entity.HumanRecDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HumanRecDescription = Nothing
					Else
						entity.HumanRecDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NaturalRecDescription As System.String 
				Get
					Dim data_ As System.String = entity.NaturalRecDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NaturalRecDescription = Nothing
					Else
						entity.NaturalRecDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BusinessRecDescription As System.String 
				Get
					Dim data_ As System.String = entity.BusinessRecDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BusinessRecDescription = Nothing
					Else
						entity.BusinessRecDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExchangeRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ExchangeRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExchangeRate = Nothing
					Else
						entity.ExchangeRate = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property AdminMemo As System.String 
				Get
					Dim data_ As System.String = entity.AdminMemo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AdminMemo = Nothing
					Else
						entity.AdminMemo = Convert.ToString(Value)
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
		  	
			Public Property MaxPossibleRating As System.String 
				Get
					Dim data_ As System.String = entity.MaxPossibleRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MaxPossibleRating = Nothing
					Else
						entity.MaxPossibleRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esRating
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return RatingMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As RatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New RatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As RatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As RatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As RatingQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esRatingCollection
		Inherits esEntityCollection(Of Rating)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return RatingMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "RatingCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As RatingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New RatingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As RatingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New RatingQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As RatingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, RatingQuery))
		End Sub
		
		#End Region
						
		Private m_query As RatingQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esRatingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RatingMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "InspectionDate" 
					Return Me.InspectionDate
				Case "ConstructionRating" 
					Return Me.ConstructionRating
				Case "Grade" 
					Return Me.Grade
				Case "OccupancyRating" 
					Return Me.OccupancyRating
				Case "FloodRating" 
					Return Me.FloodRating
				Case "EarthquakeRating" 
					Return Me.EarthquakeRating
				Case "WindstormRating" 
					Return Me.WindstormRating
				Case "OtherRating" 
					Return Me.OtherRating
				Case "PhysicalProtectionRating" 
					Return Me.PhysicalProtectionRating
				Case "HumanElementRating" 
					Return Me.HumanElementRating
				Case "NaturalHazardsProtectionRating" 
					Return Me.NaturalHazardsProtectionRating
				Case "BusinessContinuityRating" 
					Return Me.BusinessContinuityRating
				Case "Apl" 
					Return Me.Apl
				Case "APLFactor" 
					Return Me.APLFactor
				Case "OverallPlantRatingRating" 
					Return Me.OverallPlantRatingRating
				Case "PassiveScore" 
					Return Me.PassiveScore
				Case "ActiveScore" 
					Return Me.ActiveScore
				Case "TotalScore" 
					Return Me.TotalScore
				Case "TotalScoreRating" 
					Return Me.TotalScoreRating
				Case "TotalFacilityScore" 
					Return Me.TotalFacilityScore
				Case "OtherWeight" 
					Return Me.OtherWeight
				Case "ConstructionWeight" 
					Return Me.ConstructionWeight
				Case "OccupancyWeight" 
					Return Me.OccupancyWeight
				Case "PhysicalProtectionWeight" 
					Return Me.PhysicalProtectionWeight
				Case "HumanElementWeight" 
					Return Me.HumanElementWeight
				Case "NaturalHazardsProtectionWeight" 
					Return Me.NaturalHazardsProtectionWeight
				Case "BusinessContinuityWeight" 
					Return Me.BusinessContinuityWeight
				Case "FireProtectionAllRecsCompleteRating" 
					Return Me.FireProtectionAllRecsCompleteRating
				Case "HumanElementAllRecsCompleteRating" 
					Return Me.HumanElementAllRecsCompleteRating
				Case "NatHazProtAllRecsCompleteRating" 
					Return Me.NatHazProtAllRecsCompleteRating
				Case "BCPAllRecsCompletRating" 
					Return Me.BCPAllRecsCompletRating
				Case "ActiveScoreWithRecsComplete" 
					Return Me.ActiveScoreWithRecsComplete
				Case "APLWithAllRecsComplete" 
					Return Me.APLWithAllRecsComplete
				Case "FloodWeight" 
					Return Me.FloodWeight
				Case "EarthquakeWeight" 
					Return Me.EarthquakeWeight
				Case "WindstormWeight" 
					Return Me.WindstormWeight
				Case "OverallScoreWithRecsComplete" 
					Return Me.OverallScoreWithRecsComplete
				Case "MaxPossibleScore" 
					Return Me.MaxPossibleScore
				Case "APLFactorWithAllRecsComplete" 
					Return Me.APLFactorWithAllRecsComplete
				Case "FloodDescription" 
					Return Me.FloodDescription
				Case "EarthquakeDescription" 
					Return Me.EarthquakeDescription
				Case "WindstormDescription" 
					Return Me.WindstormDescription
				Case "ConstructionDescription" 
					Return Me.ConstructionDescription
				Case "OccupancyDescription" 
					Return Me.OccupancyDescription
				Case "OtherDescription" 
					Return Me.OtherDescription
				Case "FireDescription" 
					Return Me.FireDescription
				Case "HumanDescription" 
					Return Me.HumanDescription
				Case "NaturalDescription" 
					Return Me.NaturalDescription
				Case "BusinessDescription" 
					Return Me.BusinessDescription
				Case "FireRecDescription" 
					Return Me.FireRecDescription
				Case "HumanRecDescription" 
					Return Me.HumanRecDescription
				Case "NaturalRecDescription" 
					Return Me.NaturalRecDescription
				Case "BusinessRecDescription" 
					Return Me.BusinessRecDescription
				Case "ExchangeRate" 
					Return Me.ExchangeRate
				Case "AdminMemo" 
					Return Me.AdminMemo
				Case "OverallScoreWithRecsCompleteRating" 
					Return Me.OverallScoreWithRecsCompleteRating
				Case "MaxPossibleRating" 
					Return Me.MaxPossibleRating
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.Id, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.ConstructionRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Grade As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.Grade, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OccupancyRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FloodRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.FloodRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property EarthquakeRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.EarthquakeRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WindstormRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.WindstormRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OtherRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OtherRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PhysicalProtectionRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.PhysicalProtectionRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.HumanElementRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property NaturalHazardsProtectionRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.NaturalHazardsProtectionRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessContinuityRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.BusinessContinuityRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Apl As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.Apl, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLFactor As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.APLFactor, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OverallPlantRatingRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OverallPlantRatingRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PassiveScore As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.PassiveScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveScore As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.ActiveScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalScore As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.TotalScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalScoreRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.TotalScoreRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalFacilityScore As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.TotalFacilityScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OtherWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OtherWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.ConstructionWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OccupancyWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property PhysicalProtectionWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.PhysicalProtectionWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.HumanElementWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property NaturalHazardsProtectionWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.NaturalHazardsProtectionWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessContinuityWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.BusinessContinuityWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FireProtectionAllRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.FireProtectionAllRecsCompleteRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property HumanElementAllRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.HumanElementAllRecsCompleteRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property NatHazProtAllRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.NatHazProtAllRecsCompleteRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BCPAllRecsCompletRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.BCPAllRecsCompletRating, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ActiveScoreWithRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.ActiveScoreWithRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLWithAllRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.APLWithAllRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FloodWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.FloodWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property EarthquakeWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.EarthquakeWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WindstormWeight As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.WindstormWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OverallScoreWithRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OverallScoreWithRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MaxPossibleScore As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.MaxPossibleScore, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property APLFactorWithAllRecsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.APLFactorWithAllRecsComplete, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FloodDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.FloodDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EarthquakeDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.EarthquakeDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WindstormDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.WindstormDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ConstructionDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.ConstructionDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OccupancyDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OccupancyDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OtherDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.FireDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.HumanDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NaturalDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.NaturalDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.BusinessDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireRecDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.FireRecDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HumanRecDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.HumanRecDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NaturalRecDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.NaturalRecDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BusinessRecDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.BusinessRecDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRate As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.ExchangeRate, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property AdminMemo As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.AdminMemo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OverallScoreWithRecsCompleteRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MaxPossibleRating As esQueryItem
			Get
				Return New esQueryItem(Me, RatingMetadata.ColumnNames.MaxPossibleRating, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class RatingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(RatingMetadata.ColumnNames.Id, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.InspectionDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = RatingMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.ConstructionRating, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.ConstructionRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.Grade, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.Grade
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OccupancyRating, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.OccupancyRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.FloodRating, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.FloodRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.EarthquakeRating, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.EarthquakeRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.WindstormRating, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.WindstormRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OtherRating, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.OtherRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.PhysicalProtectionRating, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.PhysicalProtectionRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.HumanElementRating, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.HumanElementRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.NaturalHazardsProtectionRating, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.NaturalHazardsProtectionRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.BusinessContinuityRating, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.BusinessContinuityRating
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.Apl, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.Apl
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.APLFactor, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.APLFactor
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OverallPlantRatingRating, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.OverallPlantRatingRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.PassiveScore, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.PassiveScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.ActiveScore, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.ActiveScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.TotalScore, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.TotalScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.TotalScoreRating, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.TotalScoreRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.TotalFacilityScore, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.TotalFacilityScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OtherWeight, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.OtherWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.ConstructionWeight, 23, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.ConstructionWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OccupancyWeight, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.OccupancyWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.PhysicalProtectionWeight, 25, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.PhysicalProtectionWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.HumanElementWeight, 26, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.HumanElementWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.NaturalHazardsProtectionWeight, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.NaturalHazardsProtectionWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.BusinessContinuityWeight, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.BusinessContinuityWeight
			c.NumericPrecision = 10
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.FireProtectionAllRecsCompleteRating, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.FireProtectionAllRecsCompleteRating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.HumanElementAllRecsCompleteRating, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.HumanElementAllRecsCompleteRating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.NatHazProtAllRecsCompleteRating, 31, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.NatHazProtAllRecsCompleteRating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.BCPAllRecsCompletRating, 32, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.BCPAllRecsCompletRating
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.ActiveScoreWithRecsComplete, 33, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.ActiveScoreWithRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.APLWithAllRecsComplete, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.APLWithAllRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.FloodWeight, 35, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.FloodWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.EarthquakeWeight, 36, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.EarthquakeWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.WindstormWeight, 37, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.WindstormWeight
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OverallScoreWithRecsComplete, 38, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.OverallScoreWithRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.MaxPossibleScore, 39, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.MaxPossibleScore
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.APLFactorWithAllRecsComplete, 40, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.APLFactorWithAllRecsComplete
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.FloodDescription, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.FloodDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.EarthquakeDescription, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.EarthquakeDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.WindstormDescription, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.WindstormDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.ConstructionDescription, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.ConstructionDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OccupancyDescription, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.OccupancyDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OtherDescription, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.OtherDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.FireDescription, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.FireDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.HumanDescription, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.HumanDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.NaturalDescription, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.NaturalDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.BusinessDescription, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.BusinessDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.FireRecDescription, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.FireRecDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.HumanRecDescription, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.HumanRecDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.NaturalRecDescription, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.NaturalRecDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.BusinessRecDescription, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.BusinessRecDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.ExchangeRate, 55, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = RatingMetadata.PropertyNames.ExchangeRate
			c.NumericPrecision = 18
			c.NumericScale = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.AdminMemo, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.AdminMemo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.OverallScoreWithRecsCompleteRating, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.OverallScoreWithRecsCompleteRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RatingMetadata.ColumnNames.MaxPossibleRating, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = RatingMetadata.PropertyNames.MaxPossibleRating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As RatingMetadata
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
			 Public Const Id As String = "ID"
			 Public Const FileNo As String = "FileNo"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const ConstructionRating As String = "ConstructionRating"
			 Public Const Grade As String = "Grade"
			 Public Const OccupancyRating As String = "OccupancyRating"
			 Public Const FloodRating As String = "FloodRating"
			 Public Const EarthquakeRating As String = "EarthquakeRating"
			 Public Const WindstormRating As String = "WindstormRating"
			 Public Const OtherRating As String = "OtherRating"
			 Public Const PhysicalProtectionRating As String = "PhysicalProtectionRating"
			 Public Const HumanElementRating As String = "HumanElementRating"
			 Public Const NaturalHazardsProtectionRating As String = "NaturalHazardsProtectionRating"
			 Public Const BusinessContinuityRating As String = "BusinessContinuityRating"
			 Public Const Apl As String = "APL"
			 Public Const APLFactor As String = "APLFactor"
			 Public Const OverallPlantRatingRating As String = "OverallPlantRatingRating"
			 Public Const PassiveScore As String = "PassiveScore"
			 Public Const ActiveScore As String = "ActiveScore"
			 Public Const TotalScore As String = "TotalScore"
			 Public Const TotalScoreRating As String = "TotalScoreRating"
			 Public Const TotalFacilityScore As String = "TotalFacilityScore"
			 Public Const OtherWeight As String = "OtherWeight"
			 Public Const ConstructionWeight As String = "ConstructionWeight"
			 Public Const OccupancyWeight As String = "OccupancyWeight"
			 Public Const PhysicalProtectionWeight As String = "PhysicalProtectionWeight"
			 Public Const HumanElementWeight As String = "HumanElementWeight"
			 Public Const NaturalHazardsProtectionWeight As String = "NaturalHazardsProtectionWeight"
			 Public Const BusinessContinuityWeight As String = "BusinessContinuityWeight"
			 Public Const FireProtectionAllRecsCompleteRating As String = "FireProtectionAllRecsCompleteRating"
			 Public Const HumanElementAllRecsCompleteRating As String = "HumanElementAllRecsCompleteRating"
			 Public Const NatHazProtAllRecsCompleteRating As String = "NatHazProtAllRecsCompleteRating"
			 Public Const BCPAllRecsCompletRating As String = "BCPAllRecsCompletRating"
			 Public Const ActiveScoreWithRecsComplete As String = "ActiveScoreWithRecsComplete"
			 Public Const APLWithAllRecsComplete As String = "APLWithAllRecsComplete"
			 Public Const FloodWeight As String = "FloodWeight"
			 Public Const EarthquakeWeight As String = "EarthquakeWeight"
			 Public Const WindstormWeight As String = "WindstormWeight"
			 Public Const OverallScoreWithRecsComplete As String = "OverallScoreWithRecsComplete"
			 Public Const MaxPossibleScore As String = "MaxPossibleScore"
			 Public Const APLFactorWithAllRecsComplete As String = "APLFactorWithAllRecsComplete"
			 Public Const FloodDescription As String = "FloodDescription"
			 Public Const EarthquakeDescription As String = "EarthquakeDescription"
			 Public Const WindstormDescription As String = "WindstormDescription"
			 Public Const ConstructionDescription As String = "ConstructionDescription"
			 Public Const OccupancyDescription As String = "OccupancyDescription"
			 Public Const OtherDescription As String = "OtherDescription"
			 Public Const FireDescription As String = "FireDescription"
			 Public Const HumanDescription As String = "HumanDescription"
			 Public Const NaturalDescription As String = "NaturalDescription"
			 Public Const BusinessDescription As String = "BusinessDescription"
			 Public Const FireRecDescription As String = "FireRecDescription"
			 Public Const HumanRecDescription As String = "HumanRecDescription"
			 Public Const NaturalRecDescription As String = "NaturalRecDescription"
			 Public Const BusinessRecDescription As String = "BusinessRecDescription"
			 Public Const ExchangeRate As String = "ExchangeRate"
			 Public Const AdminMemo As String = "AdminMemo"
			 Public Const OverallScoreWithRecsCompleteRating As String = "OverallScoreWithRecsCompleteRating"
			 Public Const MaxPossibleRating As String = "MaxPossibleRating"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const ConstructionRating As String = "ConstructionRating"
			 Public Const Grade As String = "Grade"
			 Public Const OccupancyRating As String = "OccupancyRating"
			 Public Const FloodRating As String = "FloodRating"
			 Public Const EarthquakeRating As String = "EarthquakeRating"
			 Public Const WindstormRating As String = "WindstormRating"
			 Public Const OtherRating As String = "OtherRating"
			 Public Const PhysicalProtectionRating As String = "PhysicalProtectionRating"
			 Public Const HumanElementRating As String = "HumanElementRating"
			 Public Const NaturalHazardsProtectionRating As String = "NaturalHazardsProtectionRating"
			 Public Const BusinessContinuityRating As String = "BusinessContinuityRating"
			 Public Const Apl As String = "Apl"
			 Public Const APLFactor As String = "APLFactor"
			 Public Const OverallPlantRatingRating As String = "OverallPlantRatingRating"
			 Public Const PassiveScore As String = "PassiveScore"
			 Public Const ActiveScore As String = "ActiveScore"
			 Public Const TotalScore As String = "TotalScore"
			 Public Const TotalScoreRating As String = "TotalScoreRating"
			 Public Const TotalFacilityScore As String = "TotalFacilityScore"
			 Public Const OtherWeight As String = "OtherWeight"
			 Public Const ConstructionWeight As String = "ConstructionWeight"
			 Public Const OccupancyWeight As String = "OccupancyWeight"
			 Public Const PhysicalProtectionWeight As String = "PhysicalProtectionWeight"
			 Public Const HumanElementWeight As String = "HumanElementWeight"
			 Public Const NaturalHazardsProtectionWeight As String = "NaturalHazardsProtectionWeight"
			 Public Const BusinessContinuityWeight As String = "BusinessContinuityWeight"
			 Public Const FireProtectionAllRecsCompleteRating As String = "FireProtectionAllRecsCompleteRating"
			 Public Const HumanElementAllRecsCompleteRating As String = "HumanElementAllRecsCompleteRating"
			 Public Const NatHazProtAllRecsCompleteRating As String = "NatHazProtAllRecsCompleteRating"
			 Public Const BCPAllRecsCompletRating As String = "BCPAllRecsCompletRating"
			 Public Const ActiveScoreWithRecsComplete As String = "ActiveScoreWithRecsComplete"
			 Public Const APLWithAllRecsComplete As String = "APLWithAllRecsComplete"
			 Public Const FloodWeight As String = "FloodWeight"
			 Public Const EarthquakeWeight As String = "EarthquakeWeight"
			 Public Const WindstormWeight As String = "WindstormWeight"
			 Public Const OverallScoreWithRecsComplete As String = "OverallScoreWithRecsComplete"
			 Public Const MaxPossibleScore As String = "MaxPossibleScore"
			 Public Const APLFactorWithAllRecsComplete As String = "APLFactorWithAllRecsComplete"
			 Public Const FloodDescription As String = "FloodDescription"
			 Public Const EarthquakeDescription As String = "EarthquakeDescription"
			 Public Const WindstormDescription As String = "WindstormDescription"
			 Public Const ConstructionDescription As String = "ConstructionDescription"
			 Public Const OccupancyDescription As String = "OccupancyDescription"
			 Public Const OtherDescription As String = "OtherDescription"
			 Public Const FireDescription As String = "FireDescription"
			 Public Const HumanDescription As String = "HumanDescription"
			 Public Const NaturalDescription As String = "NaturalDescription"
			 Public Const BusinessDescription As String = "BusinessDescription"
			 Public Const FireRecDescription As String = "FireRecDescription"
			 Public Const HumanRecDescription As String = "HumanRecDescription"
			 Public Const NaturalRecDescription As String = "NaturalRecDescription"
			 Public Const BusinessRecDescription As String = "BusinessRecDescription"
			 Public Const ExchangeRate As String = "ExchangeRate"
			 Public Const AdminMemo As String = "AdminMemo"
			 Public Const OverallScoreWithRecsCompleteRating As String = "OverallScoreWithRecsCompleteRating"
			 Public Const MaxPossibleRating As String = "MaxPossibleRating"
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
			SyncLock GetType(RatingMetadata)
			
				If RatingMetadata.mapDelegates Is Nothing Then
					RatingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If RatingMetadata._meta Is Nothing Then
					RatingMetadata._meta = New RatingMetadata()
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
				


				meta.AddTypeMap("Id", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("InspectionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ConstructionRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Grade", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OccupancyRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FloodRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("EarthquakeRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("WindstormRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OtherRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("PhysicalProtectionRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("HumanElementRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("NaturalHazardsProtectionRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("BusinessContinuityRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Apl", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLFactor", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OverallPlantRatingRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PassiveScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ActiveScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("TotalScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("TotalScoreRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalFacilityScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OtherWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ConstructionWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OccupancyWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("PhysicalProtectionWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("HumanElementWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("NaturalHazardsProtectionWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("BusinessContinuityWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FireProtectionAllRecsCompleteRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("HumanElementAllRecsCompleteRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("NatHazProtAllRecsCompleteRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("BCPAllRecsCompletRating", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("ActiveScoreWithRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLWithAllRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FloodWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("EarthquakeWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("WindstormWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OverallScoreWithRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("MaxPossibleScore", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("APLFactorWithAllRecsComplete", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FloodDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EarthquakeDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WindstormDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ConstructionDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OccupancyDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OtherDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HumanDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NaturalDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BusinessDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireRecDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HumanRecDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NaturalRecDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BusinessRecDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExchangeRate", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("AdminMemo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OverallScoreWithRecsCompleteRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MaxPossibleRating", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "Rating"
				meta.Destination = "Rating"
				
				meta.spInsert = "proc_RatingInsert"
				meta.spUpdate = "proc_RatingUpdate"
				meta.spDelete = "proc_RatingDelete"
				meta.spLoadAll = "proc_RatingLoadAll"
				meta.spLoadByPrimaryKey = "proc_RatingLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As RatingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
