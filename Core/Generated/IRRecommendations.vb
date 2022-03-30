
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/28/2013 10:30:42 AM
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
	' Encapsulates the 'IR-Recommendations' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(IRRecommendations))> _
	<XmlType("IRRecommendations")> _	
	Partial Public Class IRRecommendations 
		Inherits esIRRecommendations
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New IRRecommendations()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("IRRecommendationsCollection")> _
	Partial Public Class IRRecommendationsCollection
		Inherits esIRRecommendationsCollection
		Implements IEnumerable(Of IRRecommendations)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(IRRecommendations))> _
		Public Class IRRecommendationsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of IRRecommendationsCollection)
			
			Public Shared Widening Operator CType(packet As IRRecommendationsCollectionWCFPacket) As IRRecommendationsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As IRRecommendationsCollection) As IRRecommendationsCollectionWCFPacket
				Return New IRRecommendationsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class IRRecommendationsQuery 
		Inherits esIRRecommendationsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "IRRecommendationsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As IRRecommendationsQuery) As String
			Return IRRecommendationsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As IRRecommendationsQuery
			Return DirectCast(IRRecommendationsQuery.SerializeHelper.FromXml(query, GetType(IRRecommendationsQuery)), IRRecommendationsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esIRRecommendations
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to IR-Recommendations.id
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(IRRecommendationsMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(IRRecommendationsMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.itemno
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Itemno As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(IRRecommendationsMetadata.ColumnNames.Itemno)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(IRRecommendationsMetadata.ColumnNames.Itemno, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Itemno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.fileno
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fileno As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Fileno)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Fileno, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Fileno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RECCATEGORY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Reccategory As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Reccategory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Reccategory, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Reccategory)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RECYEAR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recyear As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(IRRecommendationsMetadata.ColumnNames.Recyear)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(IRRecommendationsMetadata.ColumnNames.Recyear, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Recyear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RECMONTH
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recmonth As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Recmonth)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Recmonth, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Recmonth)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RECNUMBER
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(IRRecommendationsMetadata.ColumnNames.Recnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(IRRecommendationsMetadata.ColumnNames.Recnumber, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Recnumber)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RECSUBLETTER
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recsubletter As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.Recsubletter)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.Recsubletter, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Recsubletter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RECSTATUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recstatus As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Recstatus)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Recstatus, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Recstatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.STATUSDATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Statusdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(IRRecommendationsMetadata.ColumnNames.Statusdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(IRRecommendationsMetadata.ColumnNames.Statusdate, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Statusdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.PRIMARYRECTYPE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Primaryrectype As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Primaryrectype)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Primaryrectype, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Primaryrectype)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.SECONDARYRECTYPE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Secondaryrectype As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Secondaryrectype)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Secondaryrectype, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Secondaryrectype)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.LOSSEXPECTANCYBEFORE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Lossexpectancybefore As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.Lossexpectancybefore)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.Lossexpectancybefore, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Lossexpectancybefore)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.LOSSEXPECTANCYAFTER
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Lossexpectancyafter As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.Lossexpectancyafter)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.Lossexpectancyafter, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Lossexpectancyafter)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.COSTTOCOMPLETE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Costtocomplete As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.Costtocomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.Costtocomplete, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Costtocomplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.SAVINGSRATIO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Savingsratio As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.Savingsratio)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.Savingsratio, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Savingsratio)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RECKEYWORDS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Reckeywords As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Reckeywords)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Reckeywords, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Reckeywords)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.INTENDEDACTION
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Intendedaction As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Intendedaction)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Intendedaction, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Intendedaction)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RESPONSEDATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Responsedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(IRRecommendationsMetadata.ColumnNames.Responsedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(IRRecommendationsMetadata.ColumnNames.Responsedate, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Responsedate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.RESPONSEFROM
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Responsefrom As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Responsefrom)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Responsefrom, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Responsefrom)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.EXPECTEDCOMPLETIONDATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Expectedcompletiondate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(IRRecommendationsMetadata.ColumnNames.Expectedcompletiondate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(IRRecommendationsMetadata.ColumnNames.Expectedcompletiondate, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Expectedcompletiondate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.PLANTCOMMENT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Plantcomment As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Plantcomment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Plantcomment, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Plantcomment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.plantfeedback
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Plantfeedback As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.Plantfeedback)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.Plantfeedback, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Plantfeedback)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.LossExpectancyBeforeActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyBeforeActual As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.LossExpectancyAfterActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LossExpectancyAfterActual As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.CosttoCompleteActual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CosttoCompleteActual As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(IRRecommendationsMetadata.ColumnNames.CosttoCompleteActual)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(IRRecommendationsMetadata.ColumnNames.CosttoCompleteActual, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.CosttoCompleteActual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.severityrating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Severityrating As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Severityrating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Severityrating, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Severityrating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.history
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property History As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.History)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.History, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.History)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.findingno
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Findingno As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(IRRecommendationsMetadata.ColumnNames.Findingno)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(IRRecommendationsMetadata.ColumnNames.Findingno, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Findingno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.plantareaaffected
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Plantareaaffected As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Plantareaaffected)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Plantareaaffected, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Plantareaaffected)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.probableequipmentdamagecost
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Probableequipmentdamagecost As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(IRRecommendationsMetadata.ColumnNames.Probableequipmentdamagecost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(IRRecommendationsMetadata.ColumnNames.Probableequipmentdamagecost, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Probableequipmentdamagecost)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.faulttype
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Faulttype As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Faulttype)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Faulttype, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Faulttype)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.lengthofbusinessinterruption
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Lengthofbusinessinterruption As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Lengthofbusinessinterruption)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Lengthofbusinessinterruption, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Lengthofbusinessinterruption)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.detectedwith
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Detectedwith As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Detectedwith)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Detectedwith, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Detectedwith)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.redundancyspare
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Redundancyspare As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Redundancyspare)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Redundancyspare, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Redundancyspare)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.specitemdetail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Specitemdetail As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Specitemdetail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Specitemdetail, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Specitemdetail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.findequip
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Findequip As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Findequip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Findequip, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Findequip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.probablecause
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Probablecause As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Probablecause)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Probablecause, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Probablecause)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.comments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to IR-Recommendations.Link
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Link As System.String
			Get
				Return MyBase.GetSystemString(IRRecommendationsMetadata.ColumnNames.Link)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(IRRecommendationsMetadata.ColumnNames.Link, value) Then
					OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Link)
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
												
						Case "Itemno"
							Me.str().Itemno = CType(value, string)
												
						Case "Fileno"
							Me.str().Fileno = CType(value, string)
												
						Case "Reccategory"
							Me.str().Reccategory = CType(value, string)
												
						Case "Recyear"
							Me.str().Recyear = CType(value, string)
												
						Case "Recmonth"
							Me.str().Recmonth = CType(value, string)
												
						Case "Recnumber"
							Me.str().Recnumber = CType(value, string)
												
						Case "Recsubletter"
							Me.str().Recsubletter = CType(value, string)
												
						Case "Recstatus"
							Me.str().Recstatus = CType(value, string)
												
						Case "Statusdate"
							Me.str().Statusdate = CType(value, string)
												
						Case "Primaryrectype"
							Me.str().Primaryrectype = CType(value, string)
												
						Case "Secondaryrectype"
							Me.str().Secondaryrectype = CType(value, string)
												
						Case "Lossexpectancybefore"
							Me.str().Lossexpectancybefore = CType(value, string)
												
						Case "Lossexpectancyafter"
							Me.str().Lossexpectancyafter = CType(value, string)
												
						Case "Costtocomplete"
							Me.str().Costtocomplete = CType(value, string)
												
						Case "Savingsratio"
							Me.str().Savingsratio = CType(value, string)
												
						Case "Reckeywords"
							Me.str().Reckeywords = CType(value, string)
												
						Case "Intendedaction"
							Me.str().Intendedaction = CType(value, string)
												
						Case "Responsedate"
							Me.str().Responsedate = CType(value, string)
												
						Case "Responsefrom"
							Me.str().Responsefrom = CType(value, string)
												
						Case "Expectedcompletiondate"
							Me.str().Expectedcompletiondate = CType(value, string)
												
						Case "Plantcomment"
							Me.str().Plantcomment = CType(value, string)
												
						Case "Plantfeedback"
							Me.str().Plantfeedback = CType(value, string)
												
						Case "LossExpectancyBeforeActual"
							Me.str().LossExpectancyBeforeActual = CType(value, string)
												
						Case "LossExpectancyAfterActual"
							Me.str().LossExpectancyAfterActual = CType(value, string)
												
						Case "CosttoCompleteActual"
							Me.str().CosttoCompleteActual = CType(value, string)
												
						Case "Severityrating"
							Me.str().Severityrating = CType(value, string)
												
						Case "History"
							Me.str().History = CType(value, string)
												
						Case "Findingno"
							Me.str().Findingno = CType(value, string)
												
						Case "Plantareaaffected"
							Me.str().Plantareaaffected = CType(value, string)
												
						Case "Probableequipmentdamagecost"
							Me.str().Probableequipmentdamagecost = CType(value, string)
												
						Case "Faulttype"
							Me.str().Faulttype = CType(value, string)
												
						Case "Lengthofbusinessinterruption"
							Me.str().Lengthofbusinessinterruption = CType(value, string)
												
						Case "Detectedwith"
							Me.str().Detectedwith = CType(value, string)
												
						Case "Redundancyspare"
							Me.str().Redundancyspare = CType(value, string)
												
						Case "Specitemdetail"
							Me.str().Specitemdetail = CType(value, string)
												
						Case "Findequip"
							Me.str().Findequip = CType(value, string)
												
						Case "Probablecause"
							Me.str().Probablecause = CType(value, string)
												
						Case "Comments"
							Me.str().Comments = CType(value, string)
												
						Case "Link"
							Me.str().Link = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Id)
							End If
						
						Case "Itemno"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemno = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Itemno)
							End If
						
						Case "Recyear"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recyear = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Recyear)
							End If
						
						Case "Recnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recnumber = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Recnumber)
							End If
						
						Case "Recsubletter"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Recsubletter = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Recsubletter)
							End If
						
						Case "Statusdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Statusdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Statusdate)
							End If
						
						Case "Lossexpectancybefore"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Lossexpectancybefore = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Lossexpectancybefore)
							End If
						
						Case "Lossexpectancyafter"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Lossexpectancyafter = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Lossexpectancyafter)
							End If
						
						Case "Costtocomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Costtocomplete = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Costtocomplete)
							End If
						
						Case "Savingsratio"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Savingsratio = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Savingsratio)
							End If
						
						Case "Responsedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Responsedate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Responsedate)
							End If
						
						Case "Expectedcompletiondate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expectedcompletiondate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Expectedcompletiondate)
							End If
						
						Case "Plantfeedback"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Plantfeedback = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Plantfeedback)
							End If
						
						Case "LossExpectancyBeforeActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LossExpectancyBeforeActual = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual)
							End If
						
						Case "LossExpectancyAfterActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LossExpectancyAfterActual = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual)
							End If
						
						Case "CosttoCompleteActual"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.CosttoCompleteActual = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.CosttoCompleteActual)
							End If
						
						Case "Findingno"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Findingno = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Findingno)
							End If
						
						Case "Probableequipmentdamagecost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Probableequipmentdamagecost = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(IRRecommendationsMetadata.PropertyNames.Probableequipmentdamagecost)
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
		
			Public Sub New(ByVal entity As esIRRecommendations)
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
		  	
			Public Property Reccategory As System.String 
				Get
					Dim data_ As System.String = entity.Reccategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reccategory = Nothing
					Else
						entity.Reccategory = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recyear As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recyear
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recyear = Nothing
					Else
						entity.Recyear = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recmonth As System.String 
				Get
					Dim data_ As System.String = entity.Recmonth
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recmonth = Nothing
					Else
						entity.Recmonth = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recnumber = Nothing
					Else
						entity.Recnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recsubletter As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Recsubletter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recsubletter = Nothing
					Else
						entity.Recsubletter = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recstatus As System.String 
				Get
					Dim data_ As System.String = entity.Recstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recstatus = Nothing
					Else
						entity.Recstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Statusdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Statusdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Statusdate = Nothing
					Else
						entity.Statusdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Primaryrectype As System.String 
				Get
					Dim data_ As System.String = entity.Primaryrectype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Primaryrectype = Nothing
					Else
						entity.Primaryrectype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Secondaryrectype As System.String 
				Get
					Dim data_ As System.String = entity.Secondaryrectype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Secondaryrectype = Nothing
					Else
						entity.Secondaryrectype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lossexpectancybefore As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Lossexpectancybefore
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lossexpectancybefore = Nothing
					Else
						entity.Lossexpectancybefore = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lossexpectancyafter As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Lossexpectancyafter
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lossexpectancyafter = Nothing
					Else
						entity.Lossexpectancyafter = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Costtocomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Costtocomplete
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Costtocomplete = Nothing
					Else
						entity.Costtocomplete = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Savingsratio As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Savingsratio
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Savingsratio = Nothing
					Else
						entity.Savingsratio = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reckeywords As System.String 
				Get
					Dim data_ As System.String = entity.Reckeywords
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reckeywords = Nothing
					Else
						entity.Reckeywords = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Intendedaction As System.String 
				Get
					Dim data_ As System.String = entity.Intendedaction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Intendedaction = Nothing
					Else
						entity.Intendedaction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Responsedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Responsedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Responsedate = Nothing
					Else
						entity.Responsedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Responsefrom As System.String 
				Get
					Dim data_ As System.String = entity.Responsefrom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Responsefrom = Nothing
					Else
						entity.Responsefrom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expectedcompletiondate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expectedcompletiondate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expectedcompletiondate = Nothing
					Else
						entity.Expectedcompletiondate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Plantcomment As System.String 
				Get
					Dim data_ As System.String = entity.Plantcomment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Plantcomment = Nothing
					Else
						entity.Plantcomment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Plantfeedback As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Plantfeedback
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Plantfeedback = Nothing
					Else
						entity.Plantfeedback = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyBeforeActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LossExpectancyBeforeActual
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyBeforeActual = Nothing
					Else
						entity.LossExpectancyBeforeActual = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property LossExpectancyAfterActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LossExpectancyAfterActual
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LossExpectancyAfterActual = Nothing
					Else
						entity.LossExpectancyAfterActual = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property CosttoCompleteActual As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.CosttoCompleteActual
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CosttoCompleteActual = Nothing
					Else
						entity.CosttoCompleteActual = Convert.ToChar(Value)
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
		  	
			Public Property Plantareaaffected As System.String 
				Get
					Dim data_ As System.String = entity.Plantareaaffected
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Plantareaaffected = Nothing
					Else
						entity.Plantareaaffected = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Probableequipmentdamagecost As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Probableequipmentdamagecost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Probableequipmentdamagecost = Nothing
					Else
						entity.Probableequipmentdamagecost = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Faulttype As System.String 
				Get
					Dim data_ As System.String = entity.Faulttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Faulttype = Nothing
					Else
						entity.Faulttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lengthofbusinessinterruption As System.String 
				Get
					Dim data_ As System.String = entity.Lengthofbusinessinterruption
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lengthofbusinessinterruption = Nothing
					Else
						entity.Lengthofbusinessinterruption = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Detectedwith As System.String 
				Get
					Dim data_ As System.String = entity.Detectedwith
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Detectedwith = Nothing
					Else
						entity.Detectedwith = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Redundancyspare As System.String 
				Get
					Dim data_ As System.String = entity.Redundancyspare
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Redundancyspare = Nothing
					Else
						entity.Redundancyspare = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Specitemdetail As System.String 
				Get
					Dim data_ As System.String = entity.Specitemdetail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Specitemdetail = Nothing
					Else
						entity.Specitemdetail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Findequip As System.String 
				Get
					Dim data_ As System.String = entity.Findequip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Findequip = Nothing
					Else
						entity.Findequip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Probablecause As System.String 
				Get
					Dim data_ As System.String = entity.Probablecause
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Probablecause = Nothing
					Else
						entity.Probablecause = Convert.ToString(Value)
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
		  

			Private entity As esIRRecommendations
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return IRRecommendationsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As IRRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New IRRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As IRRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As IRRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As IRRecommendationsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esIRRecommendationsCollection
		Inherits esEntityCollection(Of IRRecommendations)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return IRRecommendationsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "IRRecommendationsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As IRRecommendationsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New IRRecommendationsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As IRRecommendationsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New IRRecommendationsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As IRRecommendationsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, IRRecommendationsQuery))
		End Sub
		
		#End Region
						
		Private m_query As IRRecommendationsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esIRRecommendationsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return IRRecommendationsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "Itemno" 
					Return Me.Itemno
				Case "Fileno" 
					Return Me.Fileno
				Case "Reccategory" 
					Return Me.Reccategory
				Case "Recyear" 
					Return Me.Recyear
				Case "Recmonth" 
					Return Me.Recmonth
				Case "Recnumber" 
					Return Me.Recnumber
				Case "Recsubletter" 
					Return Me.Recsubletter
				Case "Recstatus" 
					Return Me.Recstatus
				Case "Statusdate" 
					Return Me.Statusdate
				Case "Primaryrectype" 
					Return Me.Primaryrectype
				Case "Secondaryrectype" 
					Return Me.Secondaryrectype
				Case "Lossexpectancybefore" 
					Return Me.Lossexpectancybefore
				Case "Lossexpectancyafter" 
					Return Me.Lossexpectancyafter
				Case "Costtocomplete" 
					Return Me.Costtocomplete
				Case "Savingsratio" 
					Return Me.Savingsratio
				Case "Reckeywords" 
					Return Me.Reckeywords
				Case "Intendedaction" 
					Return Me.Intendedaction
				Case "Responsedate" 
					Return Me.Responsedate
				Case "Responsefrom" 
					Return Me.Responsefrom
				Case "Expectedcompletiondate" 
					Return Me.Expectedcompletiondate
				Case "Plantcomment" 
					Return Me.Plantcomment
				Case "Plantfeedback" 
					Return Me.Plantfeedback
				Case "LossExpectancyBeforeActual" 
					Return Me.LossExpectancyBeforeActual
				Case "LossExpectancyAfterActual" 
					Return Me.LossExpectancyAfterActual
				Case "CosttoCompleteActual" 
					Return Me.CosttoCompleteActual
				Case "Severityrating" 
					Return Me.Severityrating
				Case "History" 
					Return Me.History
				Case "Findingno" 
					Return Me.Findingno
				Case "Plantareaaffected" 
					Return Me.Plantareaaffected
				Case "Probableequipmentdamagecost" 
					Return Me.Probableequipmentdamagecost
				Case "Faulttype" 
					Return Me.Faulttype
				Case "Lengthofbusinessinterruption" 
					Return Me.Lengthofbusinessinterruption
				Case "Detectedwith" 
					Return Me.Detectedwith
				Case "Redundancyspare" 
					Return Me.Redundancyspare
				Case "Specitemdetail" 
					Return Me.Specitemdetail
				Case "Findequip" 
					Return Me.Findequip
				Case "Probablecause" 
					Return Me.Probablecause
				Case "Comments" 
					Return Me.Comments
				Case "Link" 
					Return Me.Link
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemno As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Itemno, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fileno As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Fileno, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Reccategory As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Reccategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recyear As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Recyear, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Recmonth As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Recmonth, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recnumber As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Recnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Recsubletter As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Recsubletter, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Recstatus As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Recstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Statusdate As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Statusdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Primaryrectype As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Primaryrectype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Secondaryrectype As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Secondaryrectype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lossexpectancybefore As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Lossexpectancybefore, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Lossexpectancyafter As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Lossexpectancyafter, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Costtocomplete As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Costtocomplete, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Savingsratio As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Savingsratio, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Reckeywords As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Reckeywords, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Intendedaction As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Intendedaction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Responsedate As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Responsedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Responsefrom As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Responsefrom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedcompletiondate As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Expectedcompletiondate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Plantcomment As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Plantcomment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Plantfeedback As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Plantfeedback, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyBeforeActual As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LossExpectancyAfterActual As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property CosttoCompleteActual As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.CosttoCompleteActual, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Severityrating As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Severityrating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property History As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.History, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Findingno As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Findingno, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Plantareaaffected As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Plantareaaffected, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Probableequipmentdamagecost As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Probableequipmentdamagecost, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Faulttype As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Faulttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lengthofbusinessinterruption As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Lengthofbusinessinterruption, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Detectedwith As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Detectedwith, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Redundancyspare As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Redundancyspare, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Specitemdetail As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Specitemdetail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Findequip As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Findequip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Probablecause As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Probablecause, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Link As esQueryItem
			Get
				Return New esQueryItem(Me, IRRecommendationsMetadata.ColumnNames.Link, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class IRRecommendationsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Itemno, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Itemno
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Fileno, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Fileno
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Reccategory, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Reccategory
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Recyear, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Recyear
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Recmonth, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Recmonth
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Recnumber, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Recnumber
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Recsubletter, 7, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Recsubletter
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Recstatus, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Recstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Statusdate, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Statusdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Primaryrectype, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Primaryrectype
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Secondaryrectype, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Secondaryrectype
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Lossexpectancybefore, 12, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Lossexpectancybefore
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Lossexpectancyafter, 13, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Lossexpectancyafter
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Costtocomplete, 14, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Costtocomplete
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Savingsratio, 15, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Savingsratio
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Reckeywords, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Reckeywords
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Intendedaction, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Intendedaction
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Responsedate, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Responsedate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Responsefrom, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Responsefrom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Expectedcompletiondate, 20, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Expectedcompletiondate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Plantcomment, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Plantcomment
			c.CharacterMaxLength = 8000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Plantfeedback, 22, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Plantfeedback
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.LossExpectancyBeforeActual, 23, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.LossExpectancyBeforeActual
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.LossExpectancyAfterActual, 24, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.LossExpectancyAfterActual
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.CosttoCompleteActual, 25, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.CosttoCompleteActual
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Severityrating, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Severityrating
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.History, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.History
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Findingno, 28, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Findingno
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Plantareaaffected, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Plantareaaffected
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Probableequipmentdamagecost, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Probableequipmentdamagecost
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Faulttype, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Faulttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Lengthofbusinessinterruption, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Lengthofbusinessinterruption
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Detectedwith, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Detectedwith
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Redundancyspare, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Redundancyspare
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Specitemdetail, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Specitemdetail
			c.CharacterMaxLength = 186
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Findequip, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Findequip
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Probablecause, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Probablecause
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Comments, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(IRRecommendationsMetadata.ColumnNames.Link, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = IRRecommendationsMetadata.PropertyNames.Link
			c.CharacterMaxLength = 114
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As IRRecommendationsMetadata
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
			 Public Const Id As String = "id"
			 Public Const Itemno As String = "itemno"
			 Public Const Fileno As String = "fileno"
			 Public Const Reccategory As String = "RECCATEGORY"
			 Public Const Recyear As String = "RECYEAR"
			 Public Const Recmonth As String = "RECMONTH"
			 Public Const Recnumber As String = "RECNUMBER"
			 Public Const Recsubletter As String = "RECSUBLETTER"
			 Public Const Recstatus As String = "RECSTATUS"
			 Public Const Statusdate As String = "STATUSDATE"
			 Public Const Primaryrectype As String = "PRIMARYRECTYPE"
			 Public Const Secondaryrectype As String = "SECONDARYRECTYPE"
			 Public Const Lossexpectancybefore As String = "LOSSEXPECTANCYBEFORE"
			 Public Const Lossexpectancyafter As String = "LOSSEXPECTANCYAFTER"
			 Public Const Costtocomplete As String = "COSTTOCOMPLETE"
			 Public Const Savingsratio As String = "SAVINGSRATIO"
			 Public Const Reckeywords As String = "RECKEYWORDS"
			 Public Const Intendedaction As String = "INTENDEDACTION"
			 Public Const Responsedate As String = "RESPONSEDATE"
			 Public Const Responsefrom As String = "RESPONSEFROM"
			 Public Const Expectedcompletiondate As String = "EXPECTEDCOMPLETIONDATE"
			 Public Const Plantcomment As String = "PLANTCOMMENT"
			 Public Const Plantfeedback As String = "plantfeedback"
			 Public Const LossExpectancyBeforeActual As String = "LossExpectancyBeforeActual"
			 Public Const LossExpectancyAfterActual As String = "LossExpectancyAfterActual"
			 Public Const CosttoCompleteActual As String = "CosttoCompleteActual"
			 Public Const Severityrating As String = "severityrating"
			 Public Const History As String = "history"
			 Public Const Findingno As String = "findingno"
			 Public Const Plantareaaffected As String = "plantareaaffected"
			 Public Const Probableequipmentdamagecost As String = "probableequipmentdamagecost"
			 Public Const Faulttype As String = "faulttype"
			 Public Const Lengthofbusinessinterruption As String = "lengthofbusinessinterruption"
			 Public Const Detectedwith As String = "detectedwith"
			 Public Const Redundancyspare As String = "redundancyspare"
			 Public Const Specitemdetail As String = "specitemdetail"
			 Public Const Findequip As String = "findequip"
			 Public Const Probablecause As String = "probablecause"
			 Public Const Comments As String = "comments"
			 Public Const Link As String = "Link"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const Itemno As String = "Itemno"
			 Public Const Fileno As String = "Fileno"
			 Public Const Reccategory As String = "Reccategory"
			 Public Const Recyear As String = "Recyear"
			 Public Const Recmonth As String = "Recmonth"
			 Public Const Recnumber As String = "Recnumber"
			 Public Const Recsubletter As String = "Recsubletter"
			 Public Const Recstatus As String = "Recstatus"
			 Public Const Statusdate As String = "Statusdate"
			 Public Const Primaryrectype As String = "Primaryrectype"
			 Public Const Secondaryrectype As String = "Secondaryrectype"
			 Public Const Lossexpectancybefore As String = "Lossexpectancybefore"
			 Public Const Lossexpectancyafter As String = "Lossexpectancyafter"
			 Public Const Costtocomplete As String = "Costtocomplete"
			 Public Const Savingsratio As String = "Savingsratio"
			 Public Const Reckeywords As String = "Reckeywords"
			 Public Const Intendedaction As String = "Intendedaction"
			 Public Const Responsedate As String = "Responsedate"
			 Public Const Responsefrom As String = "Responsefrom"
			 Public Const Expectedcompletiondate As String = "Expectedcompletiondate"
			 Public Const Plantcomment As String = "Plantcomment"
			 Public Const Plantfeedback As String = "Plantfeedback"
			 Public Const LossExpectancyBeforeActual As String = "LossExpectancyBeforeActual"
			 Public Const LossExpectancyAfterActual As String = "LossExpectancyAfterActual"
			 Public Const CosttoCompleteActual As String = "CosttoCompleteActual"
			 Public Const Severityrating As String = "Severityrating"
			 Public Const History As String = "History"
			 Public Const Findingno As String = "Findingno"
			 Public Const Plantareaaffected As String = "Plantareaaffected"
			 Public Const Probableequipmentdamagecost As String = "Probableequipmentdamagecost"
			 Public Const Faulttype As String = "Faulttype"
			 Public Const Lengthofbusinessinterruption As String = "Lengthofbusinessinterruption"
			 Public Const Detectedwith As String = "Detectedwith"
			 Public Const Redundancyspare As String = "Redundancyspare"
			 Public Const Specitemdetail As String = "Specitemdetail"
			 Public Const Findequip As String = "Findequip"
			 Public Const Probablecause As String = "Probablecause"
			 Public Const Comments As String = "Comments"
			 Public Const Link As String = "Link"
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
			SyncLock GetType(IRRecommendationsMetadata)
			
				If IRRecommendationsMetadata.mapDelegates Is Nothing Then
					IRRecommendationsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If IRRecommendationsMetadata._meta Is Nothing Then
					IRRecommendationsMetadata._meta = New IRRecommendationsMetadata()
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
				meta.AddTypeMap("Itemno", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fileno", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Reccategory", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Recyear", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Recmonth", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Recnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Recsubletter", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Recstatus", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Statusdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Primaryrectype", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Secondaryrectype", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lossexpectancybefore", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Lossexpectancyafter", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Costtocomplete", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Savingsratio", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Reckeywords", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Intendedaction", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Responsedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Responsefrom", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Expectedcompletiondate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Plantcomment", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Plantfeedback", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LossExpectancyBeforeActual", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LossExpectancyAfterActual", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("CosttoCompleteActual", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Severityrating", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("History", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Findingno", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Plantareaaffected", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Probableequipmentdamagecost", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Faulttype", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lengthofbusinessinterruption", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Detectedwith", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Redundancyspare", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Specitemdetail", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Findequip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Probablecause", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Comments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Link", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "IR-Recommendations"
				meta.Destination = "IR-Recommendations"
				
				meta.spInsert = "proc_IR-RecommendationsInsert"
				meta.spUpdate = "proc_IR-RecommendationsUpdate"
				meta.spDelete = "proc_IR-RecommendationsDelete"
				meta.spLoadAll = "proc_IR-RecommendationsLoadAll"
				meta.spLoadByPrimaryKey = "proc_IR-RecommendationsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As IRRecommendationsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
