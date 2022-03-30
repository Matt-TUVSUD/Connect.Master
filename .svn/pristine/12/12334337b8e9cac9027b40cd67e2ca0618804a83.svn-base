
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/14/2021 11:06:27 AM
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
	' Encapsulates the 'BM-Recommendations' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMRecommendations))> _
	<XmlType("BMRecommendations")> _	
	Partial Public Class BMRecommendations 
		Inherits esBMRecommendations
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMRecommendations()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New BMRecommendations()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMRecommendations()
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
	<XmlType("BMRecommendationsCollection")> _
	Partial Public Class BMRecommendationsCollection
		Inherits esBMRecommendationsCollection
		Implements IEnumerable(Of BMRecommendations)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As BMRecommendations
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMRecommendations))> _
		Public Class BMRecommendationsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMRecommendationsCollection)
			
			Public Shared Widening Operator CType(packet As BMRecommendationsCollectionWCFPacket) As BMRecommendationsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMRecommendationsCollection) As BMRecommendationsCollectionWCFPacket
				Return New BMRecommendationsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMRecommendationsQuery 
		Inherits esBMRecommendationsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMRecommendationsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMRecommendationsQuery) As String
			Return BMRecommendationsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMRecommendationsQuery
			Return DirectCast(BMRecommendationsQuery.SerializeHelper.FromXml(query, GetType(BMRecommendationsQuery)), BMRecommendationsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMRecommendations
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Int32) As Boolean
		
			Dim query As New BMRecommendationsQuery()
			query.Where(query.Id = id)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to BM-Recommendations.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ItemNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ItemNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.ItemNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.ItemNo, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ItemNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecCategory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategory As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecCategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecCategory, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecCategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecPrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPrefix As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecPrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecPrefix, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecPrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMonth As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecMonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecMonth, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecSubletter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecSubletter As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecSubletter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecSubletter, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecSubletter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCode As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecCode, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecAction As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecAction, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ReferenceSource
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReferenceSource As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.ReferenceSource)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.ReferenceSource, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ReferenceSource)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecKeyWords
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecKeyWords As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecKeyWords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecKeyWords, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecKeyWords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ReferenceSourceDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReferenceSourceDescription As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.ReferenceSourceDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.ReferenceSourceDescription, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ReferenceSourceDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.BreifExplanationOfRec
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BreifExplanationOfRec As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.BreifExplanationOfRec)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.BreifExplanationOfRec, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.BreifExplanationOfRec)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.LossExpectancyBefore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBefore As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.LossExpectancyBefore)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.LossExpectancyBefore, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyBefore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.LossExpectancyAfter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfter As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfter, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyAfter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.CostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToComplete As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.CostToComplete)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.CostToComplete, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.CostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.SavingsRatio
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SavingsRatio As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(BMRecommendationsMetadata.ColumnNames.SavingsRatio)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(BMRecommendationsMetadata.ColumnNames.SavingsRatio, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.SavingsRatio)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ResponseFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseFrom As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.ResponseFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.ResponseFrom, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ResponseFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.PlantComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantComment As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.PlantComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.PlantComment, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.PlantComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.PlantFeedback
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantFeedback As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.PlantFeedback)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.PlantFeedback, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.PlantFeedback)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ExpectedCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.ExpectedCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ExpectedCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.PreviousInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PreviousInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.PreviousInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.PreviousInspectionDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.PreviousInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.Link
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Link As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.Link)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.Link, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.Link)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.FollowupDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FollowupDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.FollowupDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.FollowupDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.FollowupDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.FollowupNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FollowupNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.FollowupNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.FollowupNumber, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.FollowupNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.LossExpectancyBeforeActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeActual As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(BMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(BMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.LossExpectancyAfterActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterActual As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.CostToCompleteActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.CostToCompleteActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.CostToCompleteActual, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.CostToCompleteActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.AdminMemo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminMemo As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.AdminMemo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.AdminMemo, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.AdminMemo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.OriginationDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OriginationDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.OriginationDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.OriginationDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.OriginationDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.Importorigdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ActualCostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.ActualCostToComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.ActualCostToComplete, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ActualCostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.EzyUserID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EzyUserID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.EzyUserID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.EzyUserID, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.EzyUserID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.MgmtRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.MgmtRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.MgmtRespDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.MgmtRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.MgmtRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespFrom As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.MgmtRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.MgmtRespFrom, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.MgmtRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.MgmtRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespAction As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.MgmtRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.MgmtRespAction, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.MgmtRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.MgmtRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespComment As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.MgmtRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.MgmtRespComment, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.MgmtRespComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecConfirmedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecConfirmedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.RecConfirmedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.RecConfirmedDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecConfirmedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.BenchmarkID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BenchmarkID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.BenchmarkID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.BenchmarkID, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.BenchmarkID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RatingCat
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCat As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RatingCat)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RatingCat, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingCat)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecPriority
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPriority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecPriority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecPriority, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecPriority)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RatingCatWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCatWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingCatWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingCatWeight, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingCatWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RatingCatPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCatPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingCatPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingCatPts, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingCatPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RatingScoreChange
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingScoreChange As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingScoreChange)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingScoreChange, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingScoreChange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RatingHEPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingHEPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingHEPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingHEPts, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingHEPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RatingPPPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingPPPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingPPPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingPPPts, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingPPPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RatingNHPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingNHPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingNHPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingNHPts, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingNHPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RatingBCPPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingBCPPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingBCPPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(BMRecommendationsMetadata.ColumnNames.RatingBCPPts, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingBCPPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.LossExpectancyBeforeMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeMedian, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.LossExpectancyAfterMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfterMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfterMedian, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyAfterMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.CostToCompleteMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.CostToCompleteMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.CostToCompleteMedian, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.CostToCompleteMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ThirdLevelRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespDate, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ThirdLevelRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ThirdLevelRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespFrom As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespFrom, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ThirdLevelRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ThirdLevelRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespAction As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespAction, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ThirdLevelRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ThirdLevelRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespComment As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespComment, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ThirdLevelRespComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecDetail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecDetail As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.RecDetail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.RecDetail, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecDetail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.UpdateBy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UpdateBy As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.UpdateBy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.UpdateBy, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.UpdateBy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RowGuid
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RowGuid As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(BMRecommendationsMetadata.ColumnNames.RowGuid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(BMRecommendationsMetadata.ColumnNames.RowGuid, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RowGuid)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.IntendedActionId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedActionId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.IntendedActionId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.IntendedActionId, value) Then
					Me._UpToTblMetaRecIntendedActionByIntendedActionId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecIntendedActionByIntendedActionId")
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.IntendedActionId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.MgmtRespActionId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespActionId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.MgmtRespActionId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.MgmtRespActionId, value) Then
					Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId")
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.MgmtRespActionId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecStatusId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatusId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecStatusId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecStatusId, value) Then
					Me._UpToTblMetaRecStatusByRecStatusId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecStatusByRecStatusId")
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecStatusId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.PrimaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.PrimaryRecTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.PrimaryRecTypeId, value) Then
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecTypePairByPrimaryRecTypeId")
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.PrimaryRecTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.SecondaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.SecondaryRecTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.SecondaryRecTypeId, value) Then
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecTypePairByPrimaryRecTypeId")
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.SecondaryRecTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.RecCategoryId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategoryId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecCategoryId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.RecCategoryId, value) Then
					Me._UpToTblMetaRecImpactByRecCategoryId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecImpactByRecCategoryId")
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecCategoryId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.ThirdLevelRespActionId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespActionId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, value) Then
					Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId")
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ThirdLevelRespActionId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to BM-Recommendations.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(BMRecommendationsMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMRecommendationsMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToTblMetaRecImpactByRecCategoryId As TblMetaRecImpact
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToTblMetaRecIntendedActionByIntendedActionId As TblMetaRecIntendedAction
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId As TblMetaRecMgmtIntendedAction
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToTblMetaRecStatusByRecStatusId As TblMetaRecStatus
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId As TblMetaRecThirdLevelIntendedAction
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToTblMetaRecTypePairByPrimaryRecTypeId As TblMetaRecTypePair
		
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
												
						Case "ItemNo"
							Me.str().ItemNo = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "RecCategory"
							Me.str().RecCategory = CType(value, string)
												
						Case "RecPrefix"
							Me.str().RecPrefix = CType(value, string)
												
						Case "RecYear"
							Me.str().RecYear = CType(value, string)
												
						Case "RecNumber"
							Me.str().RecNumber = CType(value, string)
												
						Case "RecMonth"
							Me.str().RecMonth = CType(value, string)
												
						Case "RecSubletter"
							Me.str().RecSubletter = CType(value, string)
												
						Case "RecStatus"
							Me.str().RecStatus = CType(value, string)
												
						Case "StatusDate"
							Me.str().StatusDate = CType(value, string)
												
						Case "RecCode"
							Me.str().RecCode = CType(value, string)
												
						Case "PrimaryRecType"
							Me.str().PrimaryRecType = CType(value, string)
												
						Case "SecondaryRecType"
							Me.str().SecondaryRecType = CType(value, string)
												
						Case "RecAction"
							Me.str().RecAction = CType(value, string)
												
						Case "ReferenceSource"
							Me.str().ReferenceSource = CType(value, string)
												
						Case "RecKeyWords"
							Me.str().RecKeyWords = CType(value, string)
												
						Case "ReferenceSourceDescription"
							Me.str().ReferenceSourceDescription = CType(value, string)
												
						Case "BreifExplanationOfRec"
							Me.str().BreifExplanationOfRec = CType(value, string)
												
						Case "LossExpectancyBefore"
							Me.str().LossExpectancyBefore = CType(value, string)
												
						Case "LossExpectancyAfter"
							Me.str().LossExpectancyAfter = CType(value, string)
												
						Case "CostToComplete"
							Me.str().CostToComplete = CType(value, string)
												
						Case "SavingsRatio"
							Me.str().SavingsRatio = CType(value, string)
												
						Case "ResponseDate"
							Me.str().ResponseDate = CType(value, string)
												
						Case "ResponseFrom"
							Me.str().ResponseFrom = CType(value, string)
												
						Case "PlantComment"
							Me.str().PlantComment = CType(value, string)
												
						Case "PlantFeedback"
							Me.str().PlantFeedback = CType(value, string)
												
						Case "ExpectedCompletionDate"
							Me.str().ExpectedCompletionDate = CType(value, string)
												
						Case "PreviousInspectionDate"
							Me.str().PreviousInspectionDate = CType(value, string)
												
						Case "IntendedAction"
							Me.str().IntendedAction = CType(value, string)
												
						Case "Link"
							Me.str().Link = CType(value, string)
												
						Case "FollowupDate"
							Me.str().FollowupDate = CType(value, string)
												
						Case "FollowupNumber"
							Me.str().FollowupNumber = CType(value, string)
												
						Case "LossExpectancyBeforeActual"
							Me.str().LossExpectancyBeforeActual = CType(value, string)
												
						Case "LossExpectancyAfterActual"
							Me.str().LossExpectancyAfterActual = CType(value, string)
												
						Case "CostToCompleteActual"
							Me.str().CostToCompleteActual = CType(value, string)
												
						Case "AdminMemo"
							Me.str().AdminMemo = CType(value, string)
												
						Case "OriginationDate"
							Me.str().OriginationDate = CType(value, string)
												
						Case "Importdate"
							Me.str().Importdate = CType(value, string)
												
						Case "Importorigdate"
							Me.str().Importorigdate = CType(value, string)
												
						Case "ActualCostToComplete"
							Me.str().ActualCostToComplete = CType(value, string)
												
						Case "EzyUserID"
							Me.str().EzyUserID = CType(value, string)
												
						Case "MgmtRespDate"
							Me.str().MgmtRespDate = CType(value, string)
												
						Case "MgmtRespFrom"
							Me.str().MgmtRespFrom = CType(value, string)
												
						Case "MgmtRespAction"
							Me.str().MgmtRespAction = CType(value, string)
												
						Case "MgmtRespComment"
							Me.str().MgmtRespComment = CType(value, string)
												
						Case "RecConfirmedDate"
							Me.str().RecConfirmedDate = CType(value, string)
												
						Case "BenchmarkID"
							Me.str().BenchmarkID = CType(value, string)
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "RatingCat"
							Me.str().RatingCat = CType(value, string)
												
						Case "RecPriority"
							Me.str().RecPriority = CType(value, string)
												
						Case "RatingCatWeight"
							Me.str().RatingCatWeight = CType(value, string)
												
						Case "RatingCatPts"
							Me.str().RatingCatPts = CType(value, string)
												
						Case "RatingScoreChange"
							Me.str().RatingScoreChange = CType(value, string)
												
						Case "RatingHEPts"
							Me.str().RatingHEPts = CType(value, string)
												
						Case "RatingPPPts"
							Me.str().RatingPPPts = CType(value, string)
												
						Case "RatingNHPts"
							Me.str().RatingNHPts = CType(value, string)
												
						Case "RatingBCPPts"
							Me.str().RatingBCPPts = CType(value, string)
												
						Case "LossExpectancyBeforeMedian"
							Me.str().LossExpectancyBeforeMedian = CType(value, string)
												
						Case "LossExpectancyAfterMedian"
							Me.str().LossExpectancyAfterMedian = CType(value, string)
												
						Case "CostToCompleteMedian"
							Me.str().CostToCompleteMedian = CType(value, string)
												
						Case "ThirdLevelRespDate"
							Me.str().ThirdLevelRespDate = CType(value, string)
												
						Case "ThirdLevelRespFrom"
							Me.str().ThirdLevelRespFrom = CType(value, string)
												
						Case "ThirdLevelRespAction"
							Me.str().ThirdLevelRespAction = CType(value, string)
												
						Case "ThirdLevelRespComment"
							Me.str().ThirdLevelRespComment = CType(value, string)
												
						Case "RecDetail"
							Me.str().RecDetail = CType(value, string)
												
						Case "UpdateBy"
							Me.str().UpdateBy = CType(value, string)
												
						Case "RowGuid"
							Me.str().RowGuid = CType(value, string)
												
						Case "IntendedActionId"
							Me.str().IntendedActionId = CType(value, string)
												
						Case "MgmtRespActionId"
							Me.str().MgmtRespActionId = CType(value, string)
												
						Case "RecStatusId"
							Me.str().RecStatusId = CType(value, string)
												
						Case "PrimaryRecTypeId"
							Me.str().PrimaryRecTypeId = CType(value, string)
												
						Case "SecondaryRecTypeId"
							Me.str().SecondaryRecTypeId = CType(value, string)
												
						Case "RecCategoryId"
							Me.str().RecCategoryId = CType(value, string)
												
						Case "ThirdLevelRespActionId"
							Me.str().ThirdLevelRespActionId = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.Id)
							End If
						
						Case "ItemNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ItemNo = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ItemNo)
							End If
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecYear)
							End If
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecNumber)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.StatusDate)
							End If
						
						Case "SavingsRatio"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.SavingsRatio = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.SavingsRatio)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "ExpectedCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ExpectedCompletionDate)
							End If
						
						Case "PreviousInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PreviousInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.PreviousInspectionDate)
							End If
						
						Case "FollowupDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FollowupDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.FollowupDate)
							End If
						
						Case "FollowupNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FollowupNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.FollowupNumber)
							End If
						
						Case "LossExpectancyBeforeActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.LossExpectancyBeforeActual = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
							End If
						
						Case "LossExpectancyAfterActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.LossExpectancyAfterActual = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
							End If
						
						Case "CostToCompleteActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.CostToCompleteActual)
							End If
						
						Case "OriginationDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.OriginationDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.OriginationDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.Importorigdate)
							End If
						
						Case "ActualCostToComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ActualCostToComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ActualCostToComplete)
							End If
						
						Case "EzyUserID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EzyUserID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.EzyUserID)
							End If
						
						Case "MgmtRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.MgmtRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.MgmtRespDate)
							End If
						
						Case "RecConfirmedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RecConfirmedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecConfirmedDate)
							End If
						
						Case "BenchmarkID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BenchmarkID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.BenchmarkID)
							End If
						
						Case "RecPriority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecPriority = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecPriority)
							End If
						
						Case "RatingCatWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingCatWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingCatWeight)
							End If
						
						Case "RatingCatPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingCatPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingCatPts)
							End If
						
						Case "RatingScoreChange"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingScoreChange = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingScoreChange)
							End If
						
						Case "RatingHEPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingHEPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingHEPts)
							End If
						
						Case "RatingPPPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingPPPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingPPPts)
							End If
						
						Case "RatingNHPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingNHPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingNHPts)
							End If
						
						Case "RatingBCPPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingBCPPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RatingBCPPts)
							End If
						
						Case "LossExpectancyBeforeMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyBeforeMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeMedian)
							End If
						
						Case "LossExpectancyAfterMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyAfterMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.LossExpectancyAfterMedian)
							End If
						
						Case "CostToCompleteMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.CostToCompleteMedian)
							End If
						
						Case "ThirdLevelRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ThirdLevelRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ThirdLevelRespDate)
							End If
						
						Case "RowGuid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Guid" Then
								Me.RowGuid = CType(value, Nullable(Of System.Guid))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RowGuid)
							End If
						
						Case "IntendedActionId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IntendedActionId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.IntendedActionId)
							End If
						
						Case "MgmtRespActionId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MgmtRespActionId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.MgmtRespActionId)
							End If
						
						Case "RecStatusId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecStatusId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecStatusId)
							End If
						
						Case "PrimaryRecTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PrimaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.PrimaryRecTypeId)
							End If
						
						Case "SecondaryRecTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecondaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.SecondaryRecTypeId)
							End If
						
						Case "RecCategoryId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCategoryId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.RecCategoryId)
							End If
						
						Case "ThirdLevelRespActionId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ThirdLevelRespActionId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(BMRecommendationsMetadata.PropertyNames.ThirdLevelRespActionId)
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
		
			Public Sub New(ByVal entity As esBMRecommendations)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property ItemNo As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ItemNo
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemNo = Nothing
					Else
						entity.ItemNo = Convert.ToInt32(Value)
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
		  	
			Public Property RecCategory As System.String 
				Get
					Dim data_ As System.String = entity.RecCategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCategory = Nothing
					Else
						entity.RecCategory = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecPrefix As System.String 
				Get
					Dim data_ As System.String = entity.RecPrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecPrefix = Nothing
					Else
						entity.RecPrefix = Convert.ToString(Value)
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
		  	
			Public Property RecSubletter As System.String 
				Get
					Dim data_ As System.String = entity.RecSubletter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecSubletter = Nothing
					Else
						entity.RecSubletter = Convert.ToString(Value)
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
		  	
			Public Property RecAction As System.String 
				Get
					Dim data_ As System.String = entity.RecAction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecAction = Nothing
					Else
						entity.RecAction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReferenceSource As System.String 
				Get
					Dim data_ As System.String = entity.ReferenceSource
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReferenceSource = Nothing
					Else
						entity.ReferenceSource = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecKeyWords As System.String 
				Get
					Dim data_ As System.String = entity.RecKeyWords
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecKeyWords = Nothing
					Else
						entity.RecKeyWords = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReferenceSourceDescription As System.String 
				Get
					Dim data_ As System.String = entity.ReferenceSourceDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReferenceSourceDescription = Nothing
					Else
						entity.ReferenceSourceDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BreifExplanationOfRec As System.String 
				Get
					Dim data_ As System.String = entity.BreifExplanationOfRec
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BreifExplanationOfRec = Nothing
					Else
						entity.BreifExplanationOfRec = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyBefore As System.String 
				Get
					Dim data_ As System.String = entity.LossExpectancyBefore
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyBefore = Nothing
					Else
						entity.LossExpectancyBefore = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyAfter As System.String 
				Get
					Dim data_ As System.String = entity.LossExpectancyAfter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyAfter = Nothing
					Else
						entity.LossExpectancyAfter = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CostToComplete As System.String 
				Get
					Dim data_ As System.String = entity.CostToComplete
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CostToComplete = Nothing
					Else
						entity.CostToComplete = Convert.ToString(Value)
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
		  	
			Public Property PlantFeedback As System.String 
				Get
					Dim data_ As System.String = entity.PlantFeedback
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlantFeedback = Nothing
					Else
						entity.PlantFeedback = Convert.ToString(Value)
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
		  	
			Public Property PreviousInspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PreviousInspectionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PreviousInspectionDate = Nothing
					Else
						entity.PreviousInspectionDate = Convert.ToDateTime(Value)
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
		  	
			Public Property Link As System.String 
				Get
					Dim data_ As System.String = entity.Link
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Link = Nothing
					Else
						entity.Link = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FollowupDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.FollowupDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FollowupDate = Nothing
					Else
						entity.FollowupDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property FollowupNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FollowupNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FollowupNumber = Nothing
					Else
						entity.FollowupNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyBeforeActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.LossExpectancyBeforeActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyBeforeActual = Nothing
					Else
						entity.LossExpectancyBeforeActual = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyAfterActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int64) = entity.LossExpectancyAfterActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyAfterActual = Nothing
					Else
						entity.LossExpectancyAfterActual = Convert.ToInt64(Value)
					End If
				End Set
			End Property
		  	
			Public Property CostToCompleteActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CostToCompleteActual
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CostToCompleteActual = Nothing
					Else
						entity.CostToCompleteActual = Convert.ToInt32(Value)
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
		  	
			Public Property OriginationDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.OriginationDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginationDate = Nothing
					Else
						entity.OriginationDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Importdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Importdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Importdate = Nothing
					Else
						entity.Importdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Importorigdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Importorigdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Importorigdate = Nothing
					Else
						entity.Importorigdate = Convert.ToDateTime(Value)
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
		  	
			Public Property RecConfirmedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RecConfirmedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecConfirmedDate = Nothing
					Else
						entity.RecConfirmedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property BenchmarkID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BenchmarkID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BenchmarkID = Nothing
					Else
						entity.BenchmarkID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazard As System.String 
				Get
					Dim data_ As System.String = entity.Hazard
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazard = Nothing
					Else
						entity.Hazard = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingCat As System.String 
				Get
					Dim data_ As System.String = entity.RatingCat
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingCat = Nothing
					Else
						entity.RatingCat = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecPriority As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecPriority
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecPriority = Nothing
					Else
						entity.RecPriority = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingCatWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingCatWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingCatWeight = Nothing
					Else
						entity.RatingCatWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingCatPts As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingCatPts
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingCatPts = Nothing
					Else
						entity.RatingCatPts = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingScoreChange As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingScoreChange
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingScoreChange = Nothing
					Else
						entity.RatingScoreChange = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingHEPts As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingHEPts
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingHEPts = Nothing
					Else
						entity.RatingHEPts = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingPPPts As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingPPPts
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingPPPts = Nothing
					Else
						entity.RatingPPPts = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingNHPts As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingNHPts
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingNHPts = Nothing
					Else
						entity.RatingNHPts = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RatingBCPPts As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RatingBCPPts
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RatingBCPPts = Nothing
					Else
						entity.RatingBCPPts = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyBeforeMedian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LossExpectancyBeforeMedian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyBeforeMedian = Nothing
					Else
						entity.LossExpectancyBeforeMedian = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyAfterMedian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LossExpectancyAfterMedian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyAfterMedian = Nothing
					Else
						entity.LossExpectancyAfterMedian = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CostToCompleteMedian As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CostToCompleteMedian
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CostToCompleteMedian = Nothing
					Else
						entity.CostToCompleteMedian = Convert.ToInt32(Value)
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
		  	
			Public Property RecDetail As System.String 
				Get
					Dim data_ As System.String = entity.RecDetail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecDetail = Nothing
					Else
						entity.RecDetail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UpdateBy As System.String 
				Get
					Dim data_ As System.String = entity.UpdateBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UpdateBy = Nothing
					Else
						entity.UpdateBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RowGuid As System.String 
				Get
					Dim data_ As Nullable(Of System.Guid) = entity.RowGuid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RowGuid = Nothing
					Else
						entity.RowGuid = new Guid(Value)
					End If
				End Set
			End Property
		  	
			Public Property IntendedActionId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.IntendedActionId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IntendedActionId = Nothing
					Else
						entity.IntendedActionId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtRespActionId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.MgmtRespActionId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtRespActionId = Nothing
					Else
						entity.MgmtRespActionId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecStatusId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecStatusId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecStatusId = Nothing
					Else
						entity.RecStatusId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PrimaryRecTypeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PrimaryRecTypeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimaryRecTypeId = Nothing
					Else
						entity.PrimaryRecTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecondaryRecTypeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SecondaryRecTypeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecondaryRecTypeId = Nothing
					Else
						entity.SecondaryRecTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecCategoryId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecCategoryId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCategoryId = Nothing
					Else
						entity.RecCategoryId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ThirdLevelRespActionId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ThirdLevelRespActionId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ThirdLevelRespActionId = Nothing
					Else
						entity.ThirdLevelRespActionId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As System.String = entity.FilePrefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FilePrefix = Nothing
					Else
						entity.FilePrefix = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBMRecommendations
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMRecommendationsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMRecommendationsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMRecommendationsCollection
		Inherits esEntityCollection(Of BMRecommendations)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMRecommendationsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMRecommendationsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMRecommendationsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMRecommendationsQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMRecommendationsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMRecommendationsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMRecommendationsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "ItemNo" 
					Return Me.ItemNo
				Case "FileNo" 
					Return Me.FileNo
				Case "RecCategory" 
					Return Me.RecCategory
				Case "RecPrefix" 
					Return Me.RecPrefix
				Case "RecYear" 
					Return Me.RecYear
				Case "RecNumber" 
					Return Me.RecNumber
				Case "RecMonth" 
					Return Me.RecMonth
				Case "RecSubletter" 
					Return Me.RecSubletter
				Case "RecStatus" 
					Return Me.RecStatus
				Case "StatusDate" 
					Return Me.StatusDate
				Case "RecCode" 
					Return Me.RecCode
				Case "PrimaryRecType" 
					Return Me.PrimaryRecType
				Case "SecondaryRecType" 
					Return Me.SecondaryRecType
				Case "RecAction" 
					Return Me.RecAction
				Case "ReferenceSource" 
					Return Me.ReferenceSource
				Case "RecKeyWords" 
					Return Me.RecKeyWords
				Case "ReferenceSourceDescription" 
					Return Me.ReferenceSourceDescription
				Case "BreifExplanationOfRec" 
					Return Me.BreifExplanationOfRec
				Case "LossExpectancyBefore" 
					Return Me.LossExpectancyBefore
				Case "LossExpectancyAfter" 
					Return Me.LossExpectancyAfter
				Case "CostToComplete" 
					Return Me.CostToComplete
				Case "SavingsRatio" 
					Return Me.SavingsRatio
				Case "ResponseDate" 
					Return Me.ResponseDate
				Case "ResponseFrom" 
					Return Me.ResponseFrom
				Case "PlantComment" 
					Return Me.PlantComment
				Case "PlantFeedback" 
					Return Me.PlantFeedback
				Case "ExpectedCompletionDate" 
					Return Me.ExpectedCompletionDate
				Case "PreviousInspectionDate" 
					Return Me.PreviousInspectionDate
				Case "IntendedAction" 
					Return Me.IntendedAction
				Case "Link" 
					Return Me.Link
				Case "FollowupDate" 
					Return Me.FollowupDate
				Case "FollowupNumber" 
					Return Me.FollowupNumber
				Case "LossExpectancyBeforeActual" 
					Return Me.LossExpectancyBeforeActual
				Case "LossExpectancyAfterActual" 
					Return Me.LossExpectancyAfterActual
				Case "CostToCompleteActual" 
					Return Me.CostToCompleteActual
				Case "AdminMemo" 
					Return Me.AdminMemo
				Case "OriginationDate" 
					Return Me.OriginationDate
				Case "Importdate" 
					Return Me.Importdate
				Case "Importorigdate" 
					Return Me.Importorigdate
				Case "ActualCostToComplete" 
					Return Me.ActualCostToComplete
				Case "EzyUserID" 
					Return Me.EzyUserID
				Case "MgmtRespDate" 
					Return Me.MgmtRespDate
				Case "MgmtRespFrom" 
					Return Me.MgmtRespFrom
				Case "MgmtRespAction" 
					Return Me.MgmtRespAction
				Case "MgmtRespComment" 
					Return Me.MgmtRespComment
				Case "RecConfirmedDate" 
					Return Me.RecConfirmedDate
				Case "BenchmarkID" 
					Return Me.BenchmarkID
				Case "Hazard" 
					Return Me.Hazard
				Case "RatingCat" 
					Return Me.RatingCat
				Case "RecPriority" 
					Return Me.RecPriority
				Case "RatingCatWeight" 
					Return Me.RatingCatWeight
				Case "RatingCatPts" 
					Return Me.RatingCatPts
				Case "RatingScoreChange" 
					Return Me.RatingScoreChange
				Case "RatingHEPts" 
					Return Me.RatingHEPts
				Case "RatingPPPts" 
					Return Me.RatingPPPts
				Case "RatingNHPts" 
					Return Me.RatingNHPts
				Case "RatingBCPPts" 
					Return Me.RatingBCPPts
				Case "LossExpectancyBeforeMedian" 
					Return Me.LossExpectancyBeforeMedian
				Case "LossExpectancyAfterMedian" 
					Return Me.LossExpectancyAfterMedian
				Case "CostToCompleteMedian" 
					Return Me.CostToCompleteMedian
				Case "ThirdLevelRespDate" 
					Return Me.ThirdLevelRespDate
				Case "ThirdLevelRespFrom" 
					Return Me.ThirdLevelRespFrom
				Case "ThirdLevelRespAction" 
					Return Me.ThirdLevelRespAction
				Case "ThirdLevelRespComment" 
					Return Me.ThirdLevelRespComment
				Case "RecDetail" 
					Return Me.RecDetail
				Case "UpdateBy" 
					Return Me.UpdateBy
				Case "RowGuid" 
					Return Me.RowGuid
				Case "IntendedActionId" 
					Return Me.IntendedActionId
				Case "MgmtRespActionId" 
					Return Me.MgmtRespActionId
				Case "RecStatusId" 
					Return Me.RecStatusId
				Case "PrimaryRecTypeId" 
					Return Me.PrimaryRecTypeId
				Case "SecondaryRecTypeId" 
					Return Me.SecondaryRecTypeId
				Case "RecCategoryId" 
					Return Me.RecCategoryId
				Case "ThirdLevelRespActionId" 
					Return Me.ThirdLevelRespActionId
				Case "FilePrefix" 
					Return Me.FilePrefix
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ItemNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ItemNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategory As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecCategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecPrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecPrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecMonth As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecMonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecSubletter As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecSubletter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecCode As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecAction As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReferenceSource As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ReferenceSource, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecKeyWords As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecKeyWords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReferenceSourceDescription As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ReferenceSourceDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BreifExplanationOfRec As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.BreifExplanationOfRec, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBefore As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.LossExpectancyBefore, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfter As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.LossExpectancyAfter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.CostToComplete, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SavingsRatio As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.SavingsRatio, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseFrom As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ResponseFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantComment As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.PlantComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantFeedback As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.PlantFeedback, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PreviousInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.PreviousInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Link As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.Link, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FollowupDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.FollowupDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FollowupNumber As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.FollowupNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeActual As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterActual As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteActual As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.CostToCompleteActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property AdminMemo As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.AdminMemo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginationDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.OriginationDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ActualCostToComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EzyUserID As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.EzyUserID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.MgmtRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.MgmtRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.MgmtRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.MgmtRespComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecConfirmedDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecConfirmedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property BenchmarkID As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.BenchmarkID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCat As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RatingCat, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecPriority As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecPriority, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCatWeight As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RatingCatWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCatPts As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RatingCatPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingScoreChange As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RatingScoreChange, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingHEPts As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RatingHEPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingPPPts As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RatingPPPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingNHPts As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RatingNHPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingBCPPts As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RatingBCPPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeMedian As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterMedian As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.LossExpectancyAfterMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteMedian As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.CostToCompleteMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ThirdLevelRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ThirdLevelRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ThirdLevelRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ThirdLevelRespComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecDetail As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecDetail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UpdateBy As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.UpdateBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RowGuid As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RowGuid, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedActionId As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.IntendedActionId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespActionId As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.MgmtRespActionId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatusId As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecStatusId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.PrimaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.SecondaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategoryId As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.RecCategoryId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespActionId As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMRecommendationsMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMRecommendations 
		Inherits esBMRecommendations
		
	
		#Region "UpToTblMetaRecImpactByRecCategoryId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_BmRec_RecCategoryId
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecImpactByRecCategoryId As TblMetaRecImpact
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecImpactByRecCategoryId Is Nothing _
						 AndAlso Not RecCategoryId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecImpactByRecCategoryId = New TblMetaRecImpact()
					Me._UpToTblMetaRecImpactByRecCategoryId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecImpactByRecCategoryId", Me._UpToTblMetaRecImpactByRecCategoryId)
					Me._UpToTblMetaRecImpactByRecCategoryId.Query.Where(Me._UpToTblMetaRecImpactByRecCategoryId.Query.FldId = Me.RecCategoryId)
					Me._UpToTblMetaRecImpactByRecCategoryId.Query.Load()
				End If

				Return Me._UpToTblMetaRecImpactByRecCategoryId
			End Get
			
            Set(ByVal value As TblMetaRecImpact)
				Me.RemovePreSave("UpToTblMetaRecImpactByRecCategoryId")
				

				If value Is Nothing Then
				
					Me.RecCategoryId = Nothing
				
					Me._UpToTblMetaRecImpactByRecCategoryId = Nothing
				Else
				
					Me.RecCategoryId = value.FldId
					
					Me._UpToTblMetaRecImpactByRecCategoryId = value
					Me.SetPreSave("UpToTblMetaRecImpactByRecCategoryId", Me._UpToTblMetaRecImpactByRecCategoryId)
				End If
				
			End Set	

		End Property
		#End Region

		#Region "UpToTblMetaRecIntendedActionByIntendedActionId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_BmRec_IntendedActionId
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecIntendedActionByIntendedActionId As TblMetaRecIntendedAction
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecIntendedActionByIntendedActionId Is Nothing _
						 AndAlso Not IntendedActionId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecIntendedActionByIntendedActionId = New TblMetaRecIntendedAction()
					Me._UpToTblMetaRecIntendedActionByIntendedActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecIntendedActionByIntendedActionId", Me._UpToTblMetaRecIntendedActionByIntendedActionId)
					Me._UpToTblMetaRecIntendedActionByIntendedActionId.Query.Where(Me._UpToTblMetaRecIntendedActionByIntendedActionId.Query.FldId = Me.IntendedActionId)
					Me._UpToTblMetaRecIntendedActionByIntendedActionId.Query.Load()
				End If

				Return Me._UpToTblMetaRecIntendedActionByIntendedActionId
			End Get
			
            Set(ByVal value As TblMetaRecIntendedAction)
				Me.RemovePreSave("UpToTblMetaRecIntendedActionByIntendedActionId")
				

				If value Is Nothing Then
				
					Me.IntendedActionId = Nothing
				
					Me._UpToTblMetaRecIntendedActionByIntendedActionId = Nothing
				Else
				
					Me.IntendedActionId = value.FldId
					
					Me._UpToTblMetaRecIntendedActionByIntendedActionId = value
					Me.SetPreSave("UpToTblMetaRecIntendedActionByIntendedActionId", Me._UpToTblMetaRecIntendedActionByIntendedActionId)
				End If
				
			End Set	

		End Property
		#End Region

		#Region "UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_BmRec_MgmtRespActionId
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId As TblMetaRecMgmtIntendedAction
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId Is Nothing _
						 AndAlso Not MgmtRespActionId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId = New TblMetaRecMgmtIntendedAction()
					Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId", Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId)
					Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId.Query.Where(Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId.Query.FldId = Me.MgmtRespActionId)
					Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId.Query.Load()
				End If

				Return Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId
			End Get
			
            Set(ByVal value As TblMetaRecMgmtIntendedAction)
				Me.RemovePreSave("UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId")
				

				If value Is Nothing Then
				
					Me.MgmtRespActionId = Nothing
				
					Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId = Nothing
				Else
				
					Me.MgmtRespActionId = value.FldId
					
					Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId = value
					Me.SetPreSave("UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId", Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId)
				End If
				
			End Set	

		End Property
		#End Region

		#Region "UpToTblMetaRecStatusByRecStatusId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_BmRec_RecStatusId
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecStatusByRecStatusId As TblMetaRecStatus
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecStatusByRecStatusId Is Nothing _
						 AndAlso Not RecStatusId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecStatusByRecStatusId = New TblMetaRecStatus()
					Me._UpToTblMetaRecStatusByRecStatusId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecStatusByRecStatusId", Me._UpToTblMetaRecStatusByRecStatusId)
					Me._UpToTblMetaRecStatusByRecStatusId.Query.Where(Me._UpToTblMetaRecStatusByRecStatusId.Query.FldId = Me.RecStatusId)
					Me._UpToTblMetaRecStatusByRecStatusId.Query.Load()
				End If

				Return Me._UpToTblMetaRecStatusByRecStatusId
			End Get
			
            Set(ByVal value As TblMetaRecStatus)
				Me.RemovePreSave("UpToTblMetaRecStatusByRecStatusId")
				

				If value Is Nothing Then
				
					Me.RecStatusId = Nothing
				
					Me._UpToTblMetaRecStatusByRecStatusId = Nothing
				Else
				
					Me.RecStatusId = value.FldId
					
					Me._UpToTblMetaRecStatusByRecStatusId = value
					Me.SetPreSave("UpToTblMetaRecStatusByRecStatusId", Me._UpToTblMetaRecStatusByRecStatusId)
				End If
				
			End Set	

		End Property
		#End Region

		#Region "UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_BmRec_ThirdLabelRespActionId
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId As TblMetaRecThirdLevelIntendedAction
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId Is Nothing _
						 AndAlso Not ThirdLevelRespActionId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId = New TblMetaRecThirdLevelIntendedAction()
					Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId", Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId)
					Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId.Query.Where(Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId.Query.FldId = Me.ThirdLevelRespActionId)
					Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId.Query.Load()
				End If

				Return Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId
			End Get
			
            Set(ByVal value As TblMetaRecThirdLevelIntendedAction)
				Me.RemovePreSave("UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId")
				

				If value Is Nothing Then
				
					Me.ThirdLevelRespActionId = Nothing
				
					Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId = Nothing
				Else
				
					Me.ThirdLevelRespActionId = value.FldId
					
					Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId = value
					Me.SetPreSave("UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId", Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId)
				End If
				
			End Set	

		End Property
		#End Region

		#Region "UpToTblMetaRecTypePairByPrimaryRecTypeId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_BmRec_PrimaryRecTypeId_SecondaryRecTypeId
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToTblMetaRecTypePairByPrimaryRecTypeId As TblMetaRecTypePair
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToTblMetaRecTypePairByPrimaryRecTypeId Is Nothing _
						 AndAlso Not PrimaryRecTypeId.Equals(Nothing)  AndAlso Not SecondaryRecTypeId.Equals(Nothing)  Then
						
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId = New TblMetaRecTypePair()
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToTblMetaRecTypePairByPrimaryRecTypeId", Me._UpToTblMetaRecTypePairByPrimaryRecTypeId)
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId.Query.Where(Me._UpToTblMetaRecTypePairByPrimaryRecTypeId.Query.FldPrimaryRecTypeId = Me.PrimaryRecTypeId)
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId.Query.Where(Me._UpToTblMetaRecTypePairByPrimaryRecTypeId.Query.FldSecondaryRecTypeId = Me.SecondaryRecTypeId)
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId.Query.Load()
				End If

				Return Me._UpToTblMetaRecTypePairByPrimaryRecTypeId
			End Get
			
            Set(ByVal value As TblMetaRecTypePair)
				Me.RemovePreSave("UpToTblMetaRecTypePairByPrimaryRecTypeId")
				

				If value Is Nothing Then
				
					Me.PrimaryRecTypeId = Nothing
				
					Me.SecondaryRecTypeId = Nothing
				
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId = Nothing
				Else
				
					Me.PrimaryRecTypeId = value.FldPrimaryRecTypeId
					
					Me.SecondaryRecTypeId = value.FldSecondaryRecTypeId
					
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId = value
					Me.SetPreSave("UpToTblMetaRecTypePairByPrimaryRecTypeId", Me._UpToTblMetaRecTypePairByPrimaryRecTypeId)
				End If
				
			End Set	

		End Property
		#End Region

		
			
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
			If Not Me.es.IsDeleted And Not Me._UpToTblMetaRecImpactByRecCategoryId Is Nothing Then
				Me.RecCategoryId = Me._UpToTblMetaRecImpactByRecCategoryId.FldId
			End If
			
			If Not Me.es.IsDeleted And Not Me._UpToTblMetaRecIntendedActionByIntendedActionId Is Nothing Then
				Me.IntendedActionId = Me._UpToTblMetaRecIntendedActionByIntendedActionId.FldId
			End If
			
			If Not Me.es.IsDeleted And Not Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId Is Nothing Then
				Me.MgmtRespActionId = Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId.FldId
			End If
			
			If Not Me.es.IsDeleted And Not Me._UpToTblMetaRecStatusByRecStatusId Is Nothing Then
				Me.RecStatusId = Me._UpToTblMetaRecStatusByRecStatusId.FldId
			End If
			
			If Not Me.es.IsDeleted And Not Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId Is Nothing Then
				Me.ThirdLevelRespActionId = Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId.FldId
			End If
			
		End Sub
	End Class
		



	<Serializable> _
	Partial Public Class BMRecommendationsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ItemNo, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ItemNo
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.FileNo, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecCategory, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecCategory
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecPrefix, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecPrefix
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecYear, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecNumber, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecMonth, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecMonth
			c.CharacterMaxLength = 255
			c.HasDefault = True
			c.Default = "('')"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecSubletter, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecSubletter
			c.CharacterMaxLength = 255
			c.HasDefault = True
			c.Default = "('')"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecStatus, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.StatusDate, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecCode, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecCode
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.PrimaryRecType, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.SecondaryRecType, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecAction, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecAction
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ReferenceSource, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ReferenceSource
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecKeyWords, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecKeyWords
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ReferenceSourceDescription, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ReferenceSourceDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.BreifExplanationOfRec, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.BreifExplanationOfRec
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.LossExpectancyBefore, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.LossExpectancyBefore
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfter, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.LossExpectancyAfter
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.CostToComplete, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.CostToComplete
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.SavingsRatio, 22, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.SavingsRatio
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ResponseDate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ResponseFrom, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ResponseFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.PlantComment, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.PlantComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.PlantFeedback, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.PlantFeedback
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ExpectedCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.PreviousInspectionDate, 28, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.PreviousInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.IntendedAction, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.Link, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.Link
			c.CharacterMaxLength = 255
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.FollowupDate, 31, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.FollowupDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.FollowupNumber, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.FollowupNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, 33, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, 34, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.CostToCompleteActual, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.CostToCompleteActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.AdminMemo, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.AdminMemo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.OriginationDate, 37, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.OriginationDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.Importdate, 38, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.Importorigdate, 39, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ActualCostToComplete, 40, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ActualCostToComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.EzyUserID, 41, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.EzyUserID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.MgmtRespDate, 42, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.MgmtRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.MgmtRespFrom, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.MgmtRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.MgmtRespAction, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.MgmtRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.MgmtRespComment, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.MgmtRespComment
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecConfirmedDate, 46, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecConfirmedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.BenchmarkID, 47, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.BenchmarkID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.Hazard, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RatingCat, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RatingCat
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecPriority, 50, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecPriority
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RatingCatWeight, 51, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RatingCatWeight
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RatingCatPts, 52, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RatingCatPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RatingScoreChange, 53, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RatingScoreChange
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RatingHEPts, 54, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RatingHEPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RatingPPPts, 55, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RatingPPPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RatingNHPts, 56, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RatingNHPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RatingBCPPts, 57, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RatingBCPPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.LossExpectancyBeforeMedian, 58, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.LossExpectancyBeforeMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.LossExpectancyAfterMedian, 59, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.LossExpectancyAfterMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.CostToCompleteMedian, 60, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.CostToCompleteMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespDate, 61, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ThirdLevelRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespFrom, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ThirdLevelRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespAction, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ThirdLevelRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespComment, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ThirdLevelRespComment
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecDetail, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecDetail
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.UpdateBy, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.UpdateBy
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RowGuid, 67, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RowGuid
			c.HasDefault = True
			c.Default = "(newid())"
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.IntendedActionId, 68, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.IntendedActionId
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((1))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.MgmtRespActionId, 69, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.MgmtRespActionId
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((1))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecStatusId, 70, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecStatusId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.PrimaryRecTypeId, 71, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.PrimaryRecTypeId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.SecondaryRecTypeId, 72, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.SecondaryRecTypeId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.RecCategoryId, 73, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.RecCategoryId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, 74, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.ThirdLevelRespActionId
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((1))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMRecommendationsMetadata.ColumnNames.FilePrefix, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMRecommendationsMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMRecommendationsMetadata
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
			 Public Const ItemNo As String = "ItemNo"
			 Public Const FileNo As String = "FileNo"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const RecPrefix As String = "RecPrefix"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecSubletter As String = "RecSubletter"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecAction As String = "RecAction"
			 Public Const ReferenceSource As String = "ReferenceSource"
			 Public Const RecKeyWords As String = "RecKeyWords"
			 Public Const ReferenceSourceDescription As String = "ReferenceSourceDescription"
			 Public Const BreifExplanationOfRec As String = "BreifExplanationOfRec"
			 Public Const LossExpectancyBefore As String = "LossExpectancyBefore"
			 Public Const LossExpectancyAfter As String = "LossExpectancyAfter"
			 Public Const CostToComplete As String = "CostToComplete"
			 Public Const SavingsRatio As String = "SavingsRatio"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const PlantFeedback As String = "PlantFeedback"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const PreviousInspectionDate As String = "PreviousInspectionDate"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const Link As String = "Link"
			 Public Const FollowupDate As String = "FollowupDate"
			 Public Const FollowupNumber As String = "FollowupNumber"
			 Public Const LossExpectancyBeforeActual As String = "LossExpectancyBeforeActual"
			 Public Const LossExpectancyAfterActual As String = "LossExpectancyAfterActual"
			 Public Const CostToCompleteActual As String = "CostToCompleteActual"
			 Public Const AdminMemo As String = "AdminMemo"
			 Public Const OriginationDate As String = "OriginationDate"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
			 Public Const ActualCostToComplete As String = "ActualCostToComplete"
			 Public Const EzyUserID As String = "EzyUserID"
			 Public Const MgmtRespDate As String = "MgmtRespDate"
			 Public Const MgmtRespFrom As String = "MgmtRespFrom"
			 Public Const MgmtRespAction As String = "MgmtRespAction"
			 Public Const MgmtRespComment As String = "MgmtRespComment"
			 Public Const RecConfirmedDate As String = "RecConfirmedDate"
			 Public Const BenchmarkID As String = "BenchmarkID"
			 Public Const Hazard As String = "Hazard"
			 Public Const RatingCat As String = "RatingCat"
			 Public Const RecPriority As String = "RecPriority"
			 Public Const RatingCatWeight As String = "RatingCatWeight"
			 Public Const RatingCatPts As String = "RatingCatPts"
			 Public Const RatingScoreChange As String = "RatingScoreChange"
			 Public Const RatingHEPts As String = "RatingHEPts"
			 Public Const RatingPPPts As String = "RatingPPPts"
			 Public Const RatingNHPts As String = "RatingNHPts"
			 Public Const RatingBCPPts As String = "RatingBCPPts"
			 Public Const LossExpectancyBeforeMedian As String = "LossExpectancyBeforeMedian"
			 Public Const LossExpectancyAfterMedian As String = "LossExpectancyAfterMedian"
			 Public Const CostToCompleteMedian As String = "CostToCompleteMedian"
			 Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
			 Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
			 Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
			 Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
			 Public Const RecDetail As String = "RecDetail"
			 Public Const UpdateBy As String = "UpdateBy"
			 Public Const RowGuid As String = "RowGuid"
			 Public Const IntendedActionId As String = "IntendedActionId"
			 Public Const MgmtRespActionId As String = "MgmtRespActionId"
			 Public Const RecStatusId As String = "RecStatusId"
			 Public Const PrimaryRecTypeId As String = "PrimaryRecTypeId"
			 Public Const SecondaryRecTypeId As String = "SecondaryRecTypeId"
			 Public Const RecCategoryId As String = "RecCategoryId"
			 Public Const ThirdLevelRespActionId As String = "ThirdLevelRespActionId"
			 Public Const FilePrefix As String = "FilePrefix"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const FileNo As String = "FileNo"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const RecPrefix As String = "RecPrefix"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecSubletter As String = "RecSubletter"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const RecAction As String = "RecAction"
			 Public Const ReferenceSource As String = "ReferenceSource"
			 Public Const RecKeyWords As String = "RecKeyWords"
			 Public Const ReferenceSourceDescription As String = "ReferenceSourceDescription"
			 Public Const BreifExplanationOfRec As String = "BreifExplanationOfRec"
			 Public Const LossExpectancyBefore As String = "LossExpectancyBefore"
			 Public Const LossExpectancyAfter As String = "LossExpectancyAfter"
			 Public Const CostToComplete As String = "CostToComplete"
			 Public Const SavingsRatio As String = "SavingsRatio"
			 Public Const ResponseDate As String = "ResponseDate"
			 Public Const ResponseFrom As String = "ResponseFrom"
			 Public Const PlantComment As String = "PlantComment"
			 Public Const PlantFeedback As String = "PlantFeedback"
			 Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
			 Public Const PreviousInspectionDate As String = "PreviousInspectionDate"
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const Link As String = "Link"
			 Public Const FollowupDate As String = "FollowupDate"
			 Public Const FollowupNumber As String = "FollowupNumber"
			 Public Const LossExpectancyBeforeActual As String = "LossExpectancyBeforeActual"
			 Public Const LossExpectancyAfterActual As String = "LossExpectancyAfterActual"
			 Public Const CostToCompleteActual As String = "CostToCompleteActual"
			 Public Const AdminMemo As String = "AdminMemo"
			 Public Const OriginationDate As String = "OriginationDate"
			 Public Const Importdate As String = "Importdate"
			 Public Const Importorigdate As String = "Importorigdate"
			 Public Const ActualCostToComplete As String = "ActualCostToComplete"
			 Public Const EzyUserID As String = "EzyUserID"
			 Public Const MgmtRespDate As String = "MgmtRespDate"
			 Public Const MgmtRespFrom As String = "MgmtRespFrom"
			 Public Const MgmtRespAction As String = "MgmtRespAction"
			 Public Const MgmtRespComment As String = "MgmtRespComment"
			 Public Const RecConfirmedDate As String = "RecConfirmedDate"
			 Public Const BenchmarkID As String = "BenchmarkID"
			 Public Const Hazard As String = "Hazard"
			 Public Const RatingCat As String = "RatingCat"
			 Public Const RecPriority As String = "RecPriority"
			 Public Const RatingCatWeight As String = "RatingCatWeight"
			 Public Const RatingCatPts As String = "RatingCatPts"
			 Public Const RatingScoreChange As String = "RatingScoreChange"
			 Public Const RatingHEPts As String = "RatingHEPts"
			 Public Const RatingPPPts As String = "RatingPPPts"
			 Public Const RatingNHPts As String = "RatingNHPts"
			 Public Const RatingBCPPts As String = "RatingBCPPts"
			 Public Const LossExpectancyBeforeMedian As String = "LossExpectancyBeforeMedian"
			 Public Const LossExpectancyAfterMedian As String = "LossExpectancyAfterMedian"
			 Public Const CostToCompleteMedian As String = "CostToCompleteMedian"
			 Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
			 Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
			 Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
			 Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
			 Public Const RecDetail As String = "RecDetail"
			 Public Const UpdateBy As String = "UpdateBy"
			 Public Const RowGuid As String = "RowGuid"
			 Public Const IntendedActionId As String = "IntendedActionId"
			 Public Const MgmtRespActionId As String = "MgmtRespActionId"
			 Public Const RecStatusId As String = "RecStatusId"
			 Public Const PrimaryRecTypeId As String = "PrimaryRecTypeId"
			 Public Const SecondaryRecTypeId As String = "SecondaryRecTypeId"
			 Public Const RecCategoryId As String = "RecCategoryId"
			 Public Const ThirdLevelRespActionId As String = "ThirdLevelRespActionId"
			 Public Const FilePrefix As String = "FilePrefix"
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
			SyncLock GetType(BMRecommendationsMetadata)
			
				If BMRecommendationsMetadata.mapDelegates Is Nothing Then
					BMRecommendationsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMRecommendationsMetadata._meta Is Nothing Then
					BMRecommendationsMetadata._meta = New BMRecommendationsMetadata()
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
				


				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ItemNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecCategory", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecPrefix", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecMonth", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecSubletter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StatusDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("RecCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PrimaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SecondaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ReferenceSource", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecKeyWords", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ReferenceSourceDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BreifExplanationOfRec", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LossExpectancyBefore", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LossExpectancyAfter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CostToComplete", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SavingsRatio", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ResponseDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ResponseFrom", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PlantComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PlantFeedback", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ExpectedCompletionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("PreviousInspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("IntendedAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Link", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FollowupDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("FollowupNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LossExpectancyBeforeActual", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("LossExpectancyAfterActual", new esTypeMap("bigint", "System.Int64"))
				meta.AddTypeMap("CostToCompleteActual", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("AdminMemo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("OriginationDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("ActualCostToComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EzyUserID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MgmtRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("MgmtRespFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecConfirmedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("BenchmarkID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RatingCat", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecPriority", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RatingCatWeight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("RatingCatPts", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("RatingScoreChange", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("RatingHEPts", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("RatingPPPts", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("RatingNHPts", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("RatingBCPPts", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("LossExpectancyBeforeMedian", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LossExpectancyAfterMedian", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CostToCompleteMedian", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ThirdLevelRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ThirdLevelRespFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ThirdLevelRespComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecDetail", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("UpdateBy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RowGuid", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("IntendedActionId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MgmtRespActionId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecStatusId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PrimaryRecTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SecondaryRecTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecCategoryId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ThirdLevelRespActionId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "BM-Recommendations"
				meta.Destination = "BM-Recommendations"
				
				meta.spInsert = "proc_BM-RecommendationsInsert"
				meta.spUpdate = "proc_BM-RecommendationsUpdate"
				meta.spDelete = "proc_BM-RecommendationsDelete"
				meta.spLoadAll = "proc_BM-RecommendationsLoadAll"
				meta.spLoadByPrimaryKey = "proc_BM-RecommendationsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMRecommendationsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
