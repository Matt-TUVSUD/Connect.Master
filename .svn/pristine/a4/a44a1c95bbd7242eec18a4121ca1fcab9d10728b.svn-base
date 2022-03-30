
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/14/2021 11:06:30 AM
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
	' Encapsulates the 'PSRecommendations' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(PSRecommendations))> _
	<XmlType("PSRecommendations")> _	
	Partial Public Class PSRecommendations 
		Inherits esPSRecommendations
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New PSRecommendations()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New PSRecommendations()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New PSRecommendations()
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
	<XmlType("PSRecommendationsCollection")> _
	Partial Public Class PSRecommendationsCollection
		Inherits esPSRecommendationsCollection
		Implements IEnumerable(Of PSRecommendations)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As PSRecommendations
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(PSRecommendations))> _
		Public Class PSRecommendationsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of PSRecommendationsCollection)
			
			Public Shared Widening Operator CType(packet As PSRecommendationsCollectionWCFPacket) As PSRecommendationsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As PSRecommendationsCollection) As PSRecommendationsCollectionWCFPacket
				Return New PSRecommendationsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class PSRecommendationsQuery 
		Inherits esPSRecommendationsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "PSRecommendationsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As PSRecommendationsQuery) As String
			Return PSRecommendationsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As PSRecommendationsQuery
			Return DirectCast(PSRecommendationsQuery.SerializeHelper.FromXml(query, GetType(PSRecommendationsQuery)), PSRecommendationsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esPSRecommendations
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
		
			Dim query As New PSRecommendationsQuery()
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
		' Maps to PSRecommendations.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecPrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPrefix As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecPrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecPrefix, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecPrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecYear
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecYear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecYear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecYear, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecYear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecMonth
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecMonth As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecMonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecMonth, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecMonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecNumber, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecSubletter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecSubletter As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecSubletter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecSubletter, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecSubletter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecCategory
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategory As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecCategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecCategory, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecCategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatus As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecStatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecStatus, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.StatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.StatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.StatusDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.StatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecConfirmedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecConfirmedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.RecConfirmedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.RecConfirmedDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecConfirmedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCode As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecCode, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.PrimaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecType As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.PrimaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.PrimaryRecType, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.PrimaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.SecondaryRecType
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecType As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.SecondaryRecType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.SecondaryRecType, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.SecondaryRecType)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ReferenceSourceDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReferenceSourceDescription As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.ReferenceSourceDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.ReferenceSourceDescription, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ReferenceSourceDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecKeyWords
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecKeyWords As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecKeyWords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecKeyWords, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecKeyWords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.BreifExplanationOfRec
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BreifExplanationOfRec As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.BreifExplanationOfRec)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.BreifExplanationOfRec, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.BreifExplanationOfRec)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.LossExpectancyBefore
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBefore As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.LossExpectancyBefore)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.LossExpectancyBefore, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyBefore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.LossExpectancyAfter
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfter As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfter)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfter, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyAfter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.CostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToComplete As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.CostToComplete)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.CostToComplete, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.CostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.SavingsRatio
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SavingsRatio As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(PSRecommendationsMetadata.ColumnNames.SavingsRatio)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(PSRecommendationsMetadata.ColumnNames.SavingsRatio, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.SavingsRatio)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ResponseDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.ResponseDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.ResponseDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ResponseDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ResponseFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseFrom As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.ResponseFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.ResponseFrom, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ResponseFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.PlantComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantComment As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.PlantComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.PlantComment, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.PlantComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.PlantFeedback
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PlantFeedback As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.PlantFeedback)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.PlantFeedback, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.PlantFeedback)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ExpectedCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.ExpectedCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ExpectedCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.IntendedAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedAction As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.IntendedAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.IntendedAction, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.IntendedAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.PreviousInspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PreviousInspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.PreviousInspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.PreviousInspectionDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.PreviousInspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.FollowupDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FollowupDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.FollowupDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.FollowupDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.FollowupDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.FollowupNumber
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FollowupNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.FollowupNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.FollowupNumber, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.FollowupNumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.LossExpectancyBeforeActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeActual As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(PSRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(PSRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.LossExpectancyAfterActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterActual As Nullable(Of System.Int64)
			Get
				Return MyBase.GetSystemInt64(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int64))
				If MyBase.SetSystemInt64(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.CostToCompleteActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteActual As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.CostToCompleteActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.CostToCompleteActual, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.CostToCompleteActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.AdminMemo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminMemo As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.AdminMemo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.AdminMemo, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.AdminMemo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.OriginationDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OriginationDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.OriginationDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.OriginationDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.OriginationDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.Importorigdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ActualCostToComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ActualCostToComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.ActualCostToComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.ActualCostToComplete, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ActualCostToComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.MgmtRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.MgmtRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.MgmtRespDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.MgmtRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.MgmtRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespFrom As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.MgmtRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.MgmtRespFrom, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.MgmtRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.MgmtRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespAction As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.MgmtRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.MgmtRespAction, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.MgmtRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.MgmtRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespComment As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.MgmtRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.MgmtRespComment, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.MgmtRespComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.Link
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Link As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.Link)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.Link, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.Link)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ItemNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ItemNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.ItemNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.ItemNo, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ItemNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.BenchmarkID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BenchmarkID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.BenchmarkID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.BenchmarkID, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.BenchmarkID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.EzyUserID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EzyUserID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.EzyUserID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.EzyUserID, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.EzyUserID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RatingCat
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCat As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RatingCat)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RatingCat, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingCat)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecPriority
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecPriority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecPriority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecPriority, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecPriority)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RatingCatWeight
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCatWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingCatWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingCatWeight, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingCatWeight)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RatingCatPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingCatPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingCatPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingCatPts, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingCatPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RatingScoreChange
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingScoreChange As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingScoreChange)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingScoreChange, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingScoreChange)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RatingHEPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingHEPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingHEPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingHEPts, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingHEPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RatingPPPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingPPPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingPPPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingPPPts, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingPPPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RatingNHPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingNHPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingNHPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingNHPts, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingNHPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RatingBCPPts
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RatingBCPPts As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingBCPPts)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(PSRecommendationsMetadata.ColumnNames.RatingBCPPts, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingBCPPts)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.LossExpectancyBeforeMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.LossExpectancyBeforeMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.LossExpectancyBeforeMedian, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyBeforeMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.LossExpectancyAfterMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfterMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfterMedian, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyAfterMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.CostToCompleteMedian
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CostToCompleteMedian As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.CostToCompleteMedian)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.CostToCompleteMedian, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.CostToCompleteMedian)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ThirdLevelRespDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespDate, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ThirdLevelRespDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ThirdLevelRespFrom
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespFrom As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespFrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespFrom, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ThirdLevelRespFrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ThirdLevelRespAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespAction As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespAction, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ThirdLevelRespAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ThirdLevelRespComment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespComment As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespComment, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ThirdLevelRespComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecDetail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecDetail As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecDetail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecDetail, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecDetail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.UpdateBy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property UpdateBy As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.UpdateBy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.UpdateBy, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.UpdateBy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecAction
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecAction As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.RecAction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.RecAction, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecAction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ReferenceSource
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReferenceSource As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.ReferenceSource)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.ReferenceSource, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ReferenceSource)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RowGuid
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RowGuid As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(PSRecommendationsMetadata.ColumnNames.RowGuid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(PSRecommendationsMetadata.ColumnNames.RowGuid, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RowGuid)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.IntendedActionId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IntendedActionId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.IntendedActionId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.IntendedActionId, value) Then
					Me._UpToTblMetaRecIntendedActionByIntendedActionId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecIntendedActionByIntendedActionId")
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.IntendedActionId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.MgmtRespActionId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtRespActionId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.MgmtRespActionId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.MgmtRespActionId, value) Then
					Me._UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecMgmtIntendedActionByMgmtRespActionId")
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.MgmtRespActionId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecStatusId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecStatusId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecStatusId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecStatusId, value) Then
					Me._UpToTblMetaRecStatusByRecStatusId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecStatusByRecStatusId")
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecStatusId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.PrimaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PrimaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.PrimaryRecTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.PrimaryRecTypeId, value) Then
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecTypePairByPrimaryRecTypeId")
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.PrimaryRecTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.SecondaryRecTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecondaryRecTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.SecondaryRecTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.SecondaryRecTypeId, value) Then
					Me._UpToTblMetaRecTypePairByPrimaryRecTypeId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecTypePairByPrimaryRecTypeId")
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.SecondaryRecTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.RecCategoryId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCategoryId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecCategoryId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.RecCategoryId, value) Then
					Me._UpToTblMetaRecImpactByRecCategoryId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecImpactByRecCategoryId")
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecCategoryId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.ThirdLevelRespActionId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ThirdLevelRespActionId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, value) Then
					Me._UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId = Nothing
					Me.OnPropertyChanged("UpToTblMetaRecThirdLevelIntendedActionByThirdLevelRespActionId")
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ThirdLevelRespActionId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to PSRecommendations.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(PSRecommendationsMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(PSRecommendationsMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.FilePrefix)
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
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "RecPrefix"
							Me.str().RecPrefix = CType(value, string)
												
						Case "RecYear"
							Me.str().RecYear = CType(value, string)
												
						Case "RecMonth"
							Me.str().RecMonth = CType(value, string)
												
						Case "RecNumber"
							Me.str().RecNumber = CType(value, string)
												
						Case "RecSubletter"
							Me.str().RecSubletter = CType(value, string)
												
						Case "RecCategory"
							Me.str().RecCategory = CType(value, string)
												
						Case "RecStatus"
							Me.str().RecStatus = CType(value, string)
												
						Case "StatusDate"
							Me.str().StatusDate = CType(value, string)
												
						Case "RecConfirmedDate"
							Me.str().RecConfirmedDate = CType(value, string)
												
						Case "RecCode"
							Me.str().RecCode = CType(value, string)
												
						Case "PrimaryRecType"
							Me.str().PrimaryRecType = CType(value, string)
												
						Case "SecondaryRecType"
							Me.str().SecondaryRecType = CType(value, string)
												
						Case "ReferenceSourceDescription"
							Me.str().ReferenceSourceDescription = CType(value, string)
												
						Case "RecKeyWords"
							Me.str().RecKeyWords = CType(value, string)
												
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
												
						Case "IntendedAction"
							Me.str().IntendedAction = CType(value, string)
												
						Case "PreviousInspectionDate"
							Me.str().PreviousInspectionDate = CType(value, string)
												
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
												
						Case "MgmtRespDate"
							Me.str().MgmtRespDate = CType(value, string)
												
						Case "MgmtRespFrom"
							Me.str().MgmtRespFrom = CType(value, string)
												
						Case "MgmtRespAction"
							Me.str().MgmtRespAction = CType(value, string)
												
						Case "MgmtRespComment"
							Me.str().MgmtRespComment = CType(value, string)
												
						Case "Link"
							Me.str().Link = CType(value, string)
												
						Case "ItemNo"
							Me.str().ItemNo = CType(value, string)
												
						Case "BenchmarkID"
							Me.str().BenchmarkID = CType(value, string)
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "EzyUserID"
							Me.str().EzyUserID = CType(value, string)
												
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
												
						Case "RecAction"
							Me.str().RecAction = CType(value, string)
												
						Case "ReferenceSource"
							Me.str().ReferenceSource = CType(value, string)
												
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
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.Id)
							End If
						
						Case "RecYear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecYear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecYear)
							End If
						
						Case "RecNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecNumber)
							End If
						
						Case "StatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.StatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.StatusDate)
							End If
						
						Case "RecConfirmedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RecConfirmedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecConfirmedDate)
							End If
						
						Case "SavingsRatio"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.SavingsRatio = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.SavingsRatio)
							End If
						
						Case "ResponseDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ResponseDate)
							End If
						
						Case "ExpectedCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ExpectedCompletionDate)
							End If
						
						Case "PreviousInspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PreviousInspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.PreviousInspectionDate)
							End If
						
						Case "FollowupDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FollowupDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.FollowupDate)
							End If
						
						Case "FollowupNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FollowupNumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.FollowupNumber)
							End If
						
						Case "LossExpectancyBeforeActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.LossExpectancyBeforeActual = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
							End If
						
						Case "LossExpectancyAfterActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int64" Then
								Me.LossExpectancyAfterActual = CType(value, Nullable(Of System.Int64))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
							End If
						
						Case "CostToCompleteActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteActual = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.CostToCompleteActual)
							End If
						
						Case "OriginationDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.OriginationDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.OriginationDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.Importorigdate)
							End If
						
						Case "ActualCostToComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ActualCostToComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ActualCostToComplete)
							End If
						
						Case "MgmtRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.MgmtRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.MgmtRespDate)
							End If
						
						Case "ItemNo"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ItemNo = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ItemNo)
							End If
						
						Case "BenchmarkID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BenchmarkID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.BenchmarkID)
							End If
						
						Case "EzyUserID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EzyUserID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.EzyUserID)
							End If
						
						Case "RecPriority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecPriority = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecPriority)
							End If
						
						Case "RatingCatWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingCatWeight = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingCatWeight)
							End If
						
						Case "RatingCatPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingCatPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingCatPts)
							End If
						
						Case "RatingScoreChange"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingScoreChange = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingScoreChange)
							End If
						
						Case "RatingHEPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingHEPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingHEPts)
							End If
						
						Case "RatingPPPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingPPPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingPPPts)
							End If
						
						Case "RatingNHPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingNHPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingNHPts)
							End If
						
						Case "RatingBCPPts"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RatingBCPPts = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RatingBCPPts)
							End If
						
						Case "LossExpectancyBeforeMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyBeforeMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyBeforeMedian)
							End If
						
						Case "LossExpectancyAfterMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LossExpectancyAfterMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.LossExpectancyAfterMedian)
							End If
						
						Case "CostToCompleteMedian"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CostToCompleteMedian = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.CostToCompleteMedian)
							End If
						
						Case "ThirdLevelRespDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ThirdLevelRespDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ThirdLevelRespDate)
							End If
						
						Case "RowGuid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Guid" Then
								Me.RowGuid = CType(value, Nullable(Of System.Guid))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RowGuid)
							End If
						
						Case "IntendedActionId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IntendedActionId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.IntendedActionId)
							End If
						
						Case "MgmtRespActionId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.MgmtRespActionId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.MgmtRespActionId)
							End If
						
						Case "RecStatusId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecStatusId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecStatusId)
							End If
						
						Case "PrimaryRecTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PrimaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.PrimaryRecTypeId)
							End If
						
						Case "SecondaryRecTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecondaryRecTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.SecondaryRecTypeId)
							End If
						
						Case "RecCategoryId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCategoryId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.RecCategoryId)
							End If
						
						Case "ThirdLevelRespActionId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ThirdLevelRespActionId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(PSRecommendationsMetadata.PropertyNames.ThirdLevelRespActionId)
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
		
			Public Sub New(ByVal entity As esPSRecommendations)
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
		  

			Private entity As esPSRecommendations
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return PSRecommendationsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As PSRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New PSRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As PSRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As PSRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As PSRecommendationsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esPSRecommendationsCollection
		Inherits esEntityCollection(Of PSRecommendations)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return PSRecommendationsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "PSRecommendationsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As PSRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New PSRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As PSRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New PSRecommendationsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As PSRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, PSRecommendationsQuery))
		End Sub
		
		#End Region
						
		Private m_query As PSRecommendationsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esPSRecommendationsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PSRecommendationsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "RecPrefix" 
					Return Me.RecPrefix
				Case "RecYear" 
					Return Me.RecYear
				Case "RecMonth" 
					Return Me.RecMonth
				Case "RecNumber" 
					Return Me.RecNumber
				Case "RecSubletter" 
					Return Me.RecSubletter
				Case "RecCategory" 
					Return Me.RecCategory
				Case "RecStatus" 
					Return Me.RecStatus
				Case "StatusDate" 
					Return Me.StatusDate
				Case "RecConfirmedDate" 
					Return Me.RecConfirmedDate
				Case "RecCode" 
					Return Me.RecCode
				Case "PrimaryRecType" 
					Return Me.PrimaryRecType
				Case "SecondaryRecType" 
					Return Me.SecondaryRecType
				Case "ReferenceSourceDescription" 
					Return Me.ReferenceSourceDescription
				Case "RecKeyWords" 
					Return Me.RecKeyWords
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
				Case "IntendedAction" 
					Return Me.IntendedAction
				Case "PreviousInspectionDate" 
					Return Me.PreviousInspectionDate
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
				Case "MgmtRespDate" 
					Return Me.MgmtRespDate
				Case "MgmtRespFrom" 
					Return Me.MgmtRespFrom
				Case "MgmtRespAction" 
					Return Me.MgmtRespAction
				Case "MgmtRespComment" 
					Return Me.MgmtRespComment
				Case "Link" 
					Return Me.Link
				Case "ItemNo" 
					Return Me.ItemNo
				Case "BenchmarkID" 
					Return Me.BenchmarkID
				Case "Hazard" 
					Return Me.Hazard
				Case "EzyUserID" 
					Return Me.EzyUserID
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
				Case "RecAction" 
					Return Me.RecAction
				Case "ReferenceSource" 
					Return Me.ReferenceSource
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
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecPrefix As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecPrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecYear As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecYear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecMonth As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecMonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecNumber As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecSubletter As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecSubletter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategory As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecCategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatus As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecConfirmedDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecConfirmedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RecCode As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecType As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReferenceSourceDescription As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ReferenceSourceDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecKeyWords As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecKeyWords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BreifExplanationOfRec As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.BreifExplanationOfRec, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBefore As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.LossExpectancyBefore, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfter As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.LossExpectancyAfter, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.CostToComplete, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SavingsRatio As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.SavingsRatio, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseFrom As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ResponseFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantComment As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.PlantComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlantFeedback As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.PlantFeedback, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExpectedCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedAction As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.IntendedAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PreviousInspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.PreviousInspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FollowupDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.FollowupDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FollowupNumber As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.FollowupNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeActual As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterActual As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, esSystemType.Int64)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteActual As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.CostToCompleteActual, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property AdminMemo As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.AdminMemo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginationDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.OriginationDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualCostToComplete As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ActualCostToComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.MgmtRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.MgmtRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.MgmtRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.MgmtRespComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Link As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.Link, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemNo As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ItemNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BenchmarkID As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.BenchmarkID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EzyUserID As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.EzyUserID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCat As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RatingCat, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecPriority As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecPriority, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCatWeight As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RatingCatWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingCatPts As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RatingCatPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingScoreChange As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RatingScoreChange, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingHEPts As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RatingHEPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingPPPts As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RatingPPPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingNHPts As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RatingNHPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RatingBCPPts As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RatingBCPPts, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeMedian As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.LossExpectancyBeforeMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterMedian As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.LossExpectancyAfterMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CostToCompleteMedian As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.CostToCompleteMedian, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespDate As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ThirdLevelRespDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespFrom As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ThirdLevelRespFrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespAction As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ThirdLevelRespAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespComment As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ThirdLevelRespComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecDetail As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecDetail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UpdateBy As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.UpdateBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecAction As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecAction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReferenceSource As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ReferenceSource, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RowGuid As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RowGuid, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property IntendedActionId As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.IntendedActionId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtRespActionId As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.MgmtRespActionId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecStatusId As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecStatusId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PrimaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.PrimaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SecondaryRecTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.SecondaryRecTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RecCategoryId As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.RecCategoryId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ThirdLevelRespActionId As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, PSRecommendationsMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class PSRecommendations 
		Inherits esPSRecommendations
		
	
		#Region "UpToTblMetaRecImpactByRecCategoryId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_PsRec_RecCategoryId
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
		''' Foreign Key Name - FK_PsRec_IntendedActionId
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
		''' Foreign Key Name - FK_PsRec_MgmtRespActionId
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
		''' Foreign Key Name - FK_PsRec_RecStatusId
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
		''' Foreign Key Name - FK_PsRec_ThirdLabelRespActionId
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
		''' Foreign Key Name - FK_PsRec_PrimaryRecTypeId_SecondaryRecTypeId
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
	Partial Public Class PSRecommendationsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecPrefix, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecPrefix
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecYear, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecYear
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecMonth, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecMonth
			c.CharacterMaxLength = 255
			c.HasDefault = True
			c.Default = "('')"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecNumber, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecNumber
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "(NULL)"
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecSubletter, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecSubletter
			c.CharacterMaxLength = 255
			c.HasDefault = True
			c.Default = "('')"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecCategory, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecCategory
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecStatus, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecStatus
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.StatusDate, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.StatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecConfirmedDate, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecConfirmedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecCode, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecCode
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.PrimaryRecType, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.PrimaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.SecondaryRecType, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.SecondaryRecType
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ReferenceSourceDescription, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ReferenceSourceDescription
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecKeyWords, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecKeyWords
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.BreifExplanationOfRec, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.BreifExplanationOfRec
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.LossExpectancyBefore, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.LossExpectancyBefore
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfter, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.LossExpectancyAfter
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.CostToComplete, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.CostToComplete
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.SavingsRatio, 20, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.SavingsRatio
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ResponseDate, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ResponseDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ResponseFrom, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ResponseFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.PlantComment, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.PlantComment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.PlantFeedback, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.PlantFeedback
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ExpectedCompletionDate, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ExpectedCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.IntendedAction, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.IntendedAction
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.PreviousInspectionDate, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.PreviousInspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.FollowupDate, 28, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.FollowupDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.FollowupNumber, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.FollowupNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, 30, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, 31, GetType(System.Int64), esSystemType.Int64)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.CostToCompleteActual, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.CostToCompleteActual
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.AdminMemo, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.AdminMemo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.OriginationDate, 34, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.OriginationDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.Importdate, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.Importorigdate, 36, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ActualCostToComplete, 37, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ActualCostToComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.MgmtRespDate, 38, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.MgmtRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.MgmtRespFrom, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.MgmtRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.MgmtRespAction, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.MgmtRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.MgmtRespComment, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.MgmtRespComment
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.Link, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.Link
			c.CharacterMaxLength = 255
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ItemNo, 43, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ItemNo
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.BenchmarkID, 44, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.BenchmarkID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.Hazard, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.EzyUserID, 46, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.EzyUserID
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RatingCat, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RatingCat
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecPriority, 48, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecPriority
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RatingCatWeight, 49, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RatingCatWeight
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RatingCatPts, 50, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RatingCatPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RatingScoreChange, 51, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RatingScoreChange
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RatingHEPts, 52, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RatingHEPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RatingPPPts, 53, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RatingPPPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RatingNHPts, 54, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RatingNHPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RatingBCPPts, 55, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RatingBCPPts
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.LossExpectancyBeforeMedian, 56, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.LossExpectancyBeforeMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.LossExpectancyAfterMedian, 57, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.LossExpectancyAfterMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.CostToCompleteMedian, 58, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.CostToCompleteMedian
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespDate, 59, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ThirdLevelRespDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespFrom, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ThirdLevelRespFrom
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespAction, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ThirdLevelRespAction
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespComment, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ThirdLevelRespComment
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecDetail, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecDetail
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.UpdateBy, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.UpdateBy
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecAction, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecAction
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ReferenceSource, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ReferenceSource
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RowGuid, 67, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RowGuid
			c.HasDefault = True
			c.Default = "(newid())"
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.IntendedActionId, 68, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.IntendedActionId
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.MgmtRespActionId, 69, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.MgmtRespActionId
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((1))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecStatusId, 70, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecStatusId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.PrimaryRecTypeId, 71, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.PrimaryRecTypeId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.SecondaryRecTypeId, 72, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.SecondaryRecTypeId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.RecCategoryId, 73, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.RecCategoryId
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.ThirdLevelRespActionId, 74, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.ThirdLevelRespActionId
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((1))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(PSRecommendationsMetadata.ColumnNames.FilePrefix, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = PSRecommendationsMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As PSRecommendationsMetadata
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
			 Public Const RecPrefix As String = "RecPrefix"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecSubletter As String = "RecSubletter"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecConfirmedDate As String = "RecConfirmedDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const ReferenceSourceDescription As String = "ReferenceSourceDescription"
			 Public Const RecKeyWords As String = "RecKeyWords"
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
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const PreviousInspectionDate As String = "PreviousInspectionDate"
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
			 Public Const MgmtRespDate As String = "MgmtRespDate"
			 Public Const MgmtRespFrom As String = "MgmtRespFrom"
			 Public Const MgmtRespAction As String = "MgmtRespAction"
			 Public Const MgmtRespComment As String = "MgmtRespComment"
			 Public Const Link As String = "Link"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const BenchmarkID As String = "BenchmarkID"
			 Public Const Hazard As String = "Hazard"
			 Public Const EzyUserID As String = "EzyUserID"
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
			 Public Const RecAction As String = "RecAction"
			 Public Const ReferenceSource As String = "ReferenceSource"
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
			 Public Const FileNo As String = "FileNo"
			 Public Const RecPrefix As String = "RecPrefix"
			 Public Const RecYear As String = "RecYear"
			 Public Const RecMonth As String = "RecMonth"
			 Public Const RecNumber As String = "RecNumber"
			 Public Const RecSubletter As String = "RecSubletter"
			 Public Const RecCategory As String = "RecCategory"
			 Public Const RecStatus As String = "RecStatus"
			 Public Const StatusDate As String = "StatusDate"
			 Public Const RecConfirmedDate As String = "RecConfirmedDate"
			 Public Const RecCode As String = "RecCode"
			 Public Const PrimaryRecType As String = "PrimaryRecType"
			 Public Const SecondaryRecType As String = "SecondaryRecType"
			 Public Const ReferenceSourceDescription As String = "ReferenceSourceDescription"
			 Public Const RecKeyWords As String = "RecKeyWords"
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
			 Public Const IntendedAction As String = "IntendedAction"
			 Public Const PreviousInspectionDate As String = "PreviousInspectionDate"
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
			 Public Const MgmtRespDate As String = "MgmtRespDate"
			 Public Const MgmtRespFrom As String = "MgmtRespFrom"
			 Public Const MgmtRespAction As String = "MgmtRespAction"
			 Public Const MgmtRespComment As String = "MgmtRespComment"
			 Public Const Link As String = "Link"
			 Public Const ItemNo As String = "ItemNo"
			 Public Const BenchmarkID As String = "BenchmarkID"
			 Public Const Hazard As String = "Hazard"
			 Public Const EzyUserID As String = "EzyUserID"
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
			 Public Const RecAction As String = "RecAction"
			 Public Const ReferenceSource As String = "ReferenceSource"
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
			SyncLock GetType(PSRecommendationsMetadata)
			
				If PSRecommendationsMetadata.mapDelegates Is Nothing Then
					PSRecommendationsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If PSRecommendationsMetadata._meta Is Nothing Then
					PSRecommendationsMetadata._meta = New PSRecommendationsMetadata()
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
				meta.AddTypeMap("FileNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecPrefix", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecYear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecMonth", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecSubletter", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecCategory", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecStatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("StatusDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("RecConfirmedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("RecCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PrimaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SecondaryRecType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ReferenceSourceDescription", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RecKeyWords", new esTypeMap("nvarchar", "System.String"))
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
				meta.AddTypeMap("IntendedAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PreviousInspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
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
				meta.AddTypeMap("MgmtRespDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("MgmtRespFrom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespAction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtRespComment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Link", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ItemNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BenchmarkID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EzyUserID", new esTypeMap("int", "System.Int32"))
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
				meta.AddTypeMap("RecAction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ReferenceSource", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RowGuid", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("IntendedActionId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MgmtRespActionId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecStatusId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PrimaryRecTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SecondaryRecTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RecCategoryId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ThirdLevelRespActionId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "PSRecommendations"
				meta.Destination = "PSRecommendations"
				
				meta.spInsert = "proc_PSRecommendationsInsert"
				meta.spUpdate = "proc_PSRecommendationsUpdate"
				meta.spDelete = "proc_PSRecommendationsDelete"
				meta.spLoadAll = "proc_PSRecommendationsLoadAll"
				meta.spLoadByPrimaryKey = "proc_PSRecommendationsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As PSRecommendationsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
