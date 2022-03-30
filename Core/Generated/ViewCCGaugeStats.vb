
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/13/2015 3:32:17 PM
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
	' Encapsulates the 'viewCCGaugeStats' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCGaugeStats))> _
	<XmlType("ViewCCGaugeStats")> _	
	Partial Public Class ViewCCGaugeStats 
		Inherits esViewCCGaugeStats
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCGaugeStats()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCGaugeStatsCollection")> _
	Partial Public Class ViewCCGaugeStatsCollection
		Inherits esViewCCGaugeStatsCollection
		Implements IEnumerable(Of ViewCCGaugeStats)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCGaugeStats))> _
		Public Class ViewCCGaugeStatsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCGaugeStatsCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCGaugeStatsCollectionWCFPacket) As ViewCCGaugeStatsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCGaugeStatsCollection) As ViewCCGaugeStatsCollectionWCFPacket
				Return New ViewCCGaugeStatsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCGaugeStatsQuery 
		Inherits esViewCCGaugeStatsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCGaugeStatsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCGaugeStatsQuery) As String
			Return ViewCCGaugeStatsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCGaugeStatsQuery
			Return DirectCast(ViewCCGaugeStatsQuery.SerializeHelper.FromXml(query, GetType(ViewCCGaugeStatsQuery)), ViewCCGaugeStatsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCGaugeStats
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCGaugeStats.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGaugeStatsMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGaugeStatsMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.GSafeGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GSafeGUID As System.String
			Get
				Return MyBase.GetSystemString(ViewCCGaugeStatsMetadata.ColumnNames.GSafeGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCGaugeStatsMetadata.ColumnNames.GSafeGUID, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.GSafeGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.FireInspectionsDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireInspectionsDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsDue, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.FireInspectionsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireInspectionsComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsComplete, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.FireInspectionsPending
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireInspectionsPending As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsPending)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsPending, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsPending)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.FireInspectionsCancelled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireInspectionsCancelled As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsCancelled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsCancelled, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsCancelled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.BMInspectionsDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMInspectionsDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsDue, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.BMInspectionsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMInspectionsComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsComplete, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.BMInspectionsPending
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMInspectionsPending As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsPending)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsPending, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsPending)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.BMInspectionsCancelled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMInspectionsCancelled As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsCancelled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsCancelled, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsCancelled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.IRInspectionsDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRInspectionsDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsDue, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.IRInspectionsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRInspectionsComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsComplete, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.IRInspectionsPending
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRInspectionsPending As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsPending)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsPending, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsPending)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.IRInspectionsCancelled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IRInspectionsCancelled As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsCancelled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsCancelled, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsCancelled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.WindInspectionsDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindInspectionsDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsDue, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.WindInspectionsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindInspectionsComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsComplete, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.WindInspectionsPending
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindInspectionsPending As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsPending)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsPending, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsPending)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.WindInspectionsCancelled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WindInspectionsCancelled As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsCancelled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsCancelled, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsCancelled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.SeismicInspectionsDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicInspectionsDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsDue, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.SeismicInspectionsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicInspectionsComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsComplete, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.SeismicInspectionsPending
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicInspectionsPending As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsPending)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsPending, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsPending)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.SeismicInspectionsCancelled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SeismicInspectionsCancelled As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsCancelled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsCancelled, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsCancelled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.FloodInspectionsDue
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodInspectionsDue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsDue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsDue, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsDue)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.FloodInspectionsComplete
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodInspectionsComplete As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsComplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsComplete, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsComplete)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.FloodInspectionsPending
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodInspectionsPending As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsPending)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsPending, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsPending)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.FloodInspectionsCancelled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FloodInspectionsCancelled As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsCancelled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsCancelled, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsCancelled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.JurisNoObjections
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property JurisNoObjections As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.JurisNoObjections)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.JurisNoObjections, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.JurisNoObjections)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.JurisOpenViolations
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property JurisOpenViolations As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.JurisOpenViolations)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.JurisOpenViolations, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.JurisOpenViolations)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCGaugeStats.JurisNoActiveObjections
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property JurisNoActiveObjections As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.JurisNoActiveObjections)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCGaugeStatsMetadata.ColumnNames.JurisNoActiveObjections, value) Then
					OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.JurisNoActiveObjections)
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
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "GSafeGUID"
							Me.str().GSafeGUID = CType(value, string)
												
						Case "FireInspectionsDue"
							Me.str().FireInspectionsDue = CType(value, string)
												
						Case "FireInspectionsComplete"
							Me.str().FireInspectionsComplete = CType(value, string)
												
						Case "FireInspectionsPending"
							Me.str().FireInspectionsPending = CType(value, string)
												
						Case "FireInspectionsCancelled"
							Me.str().FireInspectionsCancelled = CType(value, string)
												
						Case "BMInspectionsDue"
							Me.str().BMInspectionsDue = CType(value, string)
												
						Case "BMInspectionsComplete"
							Me.str().BMInspectionsComplete = CType(value, string)
												
						Case "BMInspectionsPending"
							Me.str().BMInspectionsPending = CType(value, string)
												
						Case "BMInspectionsCancelled"
							Me.str().BMInspectionsCancelled = CType(value, string)
												
						Case "IRInspectionsDue"
							Me.str().IRInspectionsDue = CType(value, string)
												
						Case "IRInspectionsComplete"
							Me.str().IRInspectionsComplete = CType(value, string)
												
						Case "IRInspectionsPending"
							Me.str().IRInspectionsPending = CType(value, string)
												
						Case "IRInspectionsCancelled"
							Me.str().IRInspectionsCancelled = CType(value, string)
												
						Case "WindInspectionsDue"
							Me.str().WindInspectionsDue = CType(value, string)
												
						Case "WindInspectionsComplete"
							Me.str().WindInspectionsComplete = CType(value, string)
												
						Case "WindInspectionsPending"
							Me.str().WindInspectionsPending = CType(value, string)
												
						Case "WindInspectionsCancelled"
							Me.str().WindInspectionsCancelled = CType(value, string)
												
						Case "SeismicInspectionsDue"
							Me.str().SeismicInspectionsDue = CType(value, string)
												
						Case "SeismicInspectionsComplete"
							Me.str().SeismicInspectionsComplete = CType(value, string)
												
						Case "SeismicInspectionsPending"
							Me.str().SeismicInspectionsPending = CType(value, string)
												
						Case "SeismicInspectionsCancelled"
							Me.str().SeismicInspectionsCancelled = CType(value, string)
												
						Case "FloodInspectionsDue"
							Me.str().FloodInspectionsDue = CType(value, string)
												
						Case "FloodInspectionsComplete"
							Me.str().FloodInspectionsComplete = CType(value, string)
												
						Case "FloodInspectionsPending"
							Me.str().FloodInspectionsPending = CType(value, string)
												
						Case "FloodInspectionsCancelled"
							Me.str().FloodInspectionsCancelled = CType(value, string)
												
						Case "JurisNoObjections"
							Me.str().JurisNoObjections = CType(value, string)
												
						Case "JurisOpenViolations"
							Me.str().JurisOpenViolations = CType(value, string)
												
						Case "JurisNoActiveObjections"
							Me.str().JurisNoActiveObjections = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "FireInspectionsDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FireInspectionsDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsDue)
							End If
						
						Case "FireInspectionsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FireInspectionsComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsComplete)
							End If
						
						Case "FireInspectionsPending"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FireInspectionsPending = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsPending)
							End If
						
						Case "FireInspectionsCancelled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FireInspectionsCancelled = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsCancelled)
							End If
						
						Case "BMInspectionsDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BMInspectionsDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsDue)
							End If
						
						Case "BMInspectionsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BMInspectionsComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsComplete)
							End If
						
						Case "BMInspectionsPending"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BMInspectionsPending = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsPending)
							End If
						
						Case "BMInspectionsCancelled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BMInspectionsCancelled = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsCancelled)
							End If
						
						Case "IRInspectionsDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IRInspectionsDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsDue)
							End If
						
						Case "IRInspectionsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IRInspectionsComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsComplete)
							End If
						
						Case "IRInspectionsPending"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IRInspectionsPending = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsPending)
							End If
						
						Case "IRInspectionsCancelled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IRInspectionsCancelled = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsCancelled)
							End If
						
						Case "WindInspectionsDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.WindInspectionsDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsDue)
							End If
						
						Case "WindInspectionsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.WindInspectionsComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsComplete)
							End If
						
						Case "WindInspectionsPending"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.WindInspectionsPending = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsPending)
							End If
						
						Case "WindInspectionsCancelled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.WindInspectionsCancelled = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsCancelled)
							End If
						
						Case "SeismicInspectionsDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SeismicInspectionsDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsDue)
							End If
						
						Case "SeismicInspectionsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SeismicInspectionsComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsComplete)
							End If
						
						Case "SeismicInspectionsPending"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SeismicInspectionsPending = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsPending)
							End If
						
						Case "SeismicInspectionsCancelled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SeismicInspectionsCancelled = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsCancelled)
							End If
						
						Case "FloodInspectionsDue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FloodInspectionsDue = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsDue)
							End If
						
						Case "FloodInspectionsComplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FloodInspectionsComplete = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsComplete)
							End If
						
						Case "FloodInspectionsPending"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FloodInspectionsPending = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsPending)
							End If
						
						Case "FloodInspectionsCancelled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FloodInspectionsCancelled = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsCancelled)
							End If
						
						Case "JurisNoObjections"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.JurisNoObjections = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.JurisNoObjections)
							End If
						
						Case "JurisOpenViolations"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.JurisOpenViolations = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.JurisOpenViolations)
							End If
						
						Case "JurisNoActiveObjections"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.JurisNoActiveObjections = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCGaugeStatsMetadata.PropertyNames.JurisNoActiveObjections)
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
		
			Public Sub New(ByVal entity As esViewCCGaugeStats)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property GSafeGUID As System.String 
				Get
					Dim data_ As System.String = entity.GSafeGUID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GSafeGUID = Nothing
					Else
						entity.GSafeGUID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireInspectionsDue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FireInspectionsDue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireInspectionsDue = Nothing
					Else
						entity.FireInspectionsDue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireInspectionsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FireInspectionsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireInspectionsComplete = Nothing
					Else
						entity.FireInspectionsComplete = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireInspectionsPending As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FireInspectionsPending
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireInspectionsPending = Nothing
					Else
						entity.FireInspectionsPending = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireInspectionsCancelled As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FireInspectionsCancelled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireInspectionsCancelled = Nothing
					Else
						entity.FireInspectionsCancelled = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMInspectionsDue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BMInspectionsDue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMInspectionsDue = Nothing
					Else
						entity.BMInspectionsDue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMInspectionsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BMInspectionsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMInspectionsComplete = Nothing
					Else
						entity.BMInspectionsComplete = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMInspectionsPending As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BMInspectionsPending
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMInspectionsPending = Nothing
					Else
						entity.BMInspectionsPending = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMInspectionsCancelled As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BMInspectionsCancelled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMInspectionsCancelled = Nothing
					Else
						entity.BMInspectionsCancelled = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRInspectionsDue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.IRInspectionsDue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRInspectionsDue = Nothing
					Else
						entity.IRInspectionsDue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRInspectionsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.IRInspectionsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRInspectionsComplete = Nothing
					Else
						entity.IRInspectionsComplete = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRInspectionsPending As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.IRInspectionsPending
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRInspectionsPending = Nothing
					Else
						entity.IRInspectionsPending = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property IRInspectionsCancelled As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.IRInspectionsCancelled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IRInspectionsCancelled = Nothing
					Else
						entity.IRInspectionsCancelled = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindInspectionsDue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.WindInspectionsDue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindInspectionsDue = Nothing
					Else
						entity.WindInspectionsDue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindInspectionsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.WindInspectionsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindInspectionsComplete = Nothing
					Else
						entity.WindInspectionsComplete = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindInspectionsPending As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.WindInspectionsPending
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindInspectionsPending = Nothing
					Else
						entity.WindInspectionsPending = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property WindInspectionsCancelled As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.WindInspectionsCancelled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WindInspectionsCancelled = Nothing
					Else
						entity.WindInspectionsCancelled = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicInspectionsDue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SeismicInspectionsDue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicInspectionsDue = Nothing
					Else
						entity.SeismicInspectionsDue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicInspectionsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SeismicInspectionsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicInspectionsComplete = Nothing
					Else
						entity.SeismicInspectionsComplete = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicInspectionsPending As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SeismicInspectionsPending
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicInspectionsPending = Nothing
					Else
						entity.SeismicInspectionsPending = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SeismicInspectionsCancelled As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SeismicInspectionsCancelled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SeismicInspectionsCancelled = Nothing
					Else
						entity.SeismicInspectionsCancelled = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodInspectionsDue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FloodInspectionsDue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodInspectionsDue = Nothing
					Else
						entity.FloodInspectionsDue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodInspectionsComplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FloodInspectionsComplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodInspectionsComplete = Nothing
					Else
						entity.FloodInspectionsComplete = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodInspectionsPending As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FloodInspectionsPending
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodInspectionsPending = Nothing
					Else
						entity.FloodInspectionsPending = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FloodInspectionsCancelled As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FloodInspectionsCancelled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FloodInspectionsCancelled = Nothing
					Else
						entity.FloodInspectionsCancelled = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property JurisNoObjections As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.JurisNoObjections
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.JurisNoObjections = Nothing
					Else
						entity.JurisNoObjections = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property JurisOpenViolations As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.JurisOpenViolations
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.JurisOpenViolations = Nothing
					Else
						entity.JurisOpenViolations = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property JurisNoActiveObjections As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.JurisNoActiveObjections
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.JurisNoActiveObjections = Nothing
					Else
						entity.JurisNoActiveObjections = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCGaugeStats
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCGaugeStatsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCGaugeStatsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCGaugeStatsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCGaugeStatsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCGaugeStatsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCGaugeStatsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCGaugeStatsCollection
		Inherits esEntityCollection(Of ViewCCGaugeStats)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCGaugeStatsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCGaugeStatsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCGaugeStatsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCGaugeStatsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCGaugeStatsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCGaugeStatsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCGaugeStatsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCGaugeStatsQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCGaugeStatsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCGaugeStatsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCGaugeStatsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "GSafeGUID" 
					Return Me.GSafeGUID
				Case "FireInspectionsDue" 
					Return Me.FireInspectionsDue
				Case "FireInspectionsComplete" 
					Return Me.FireInspectionsComplete
				Case "FireInspectionsPending" 
					Return Me.FireInspectionsPending
				Case "FireInspectionsCancelled" 
					Return Me.FireInspectionsCancelled
				Case "BMInspectionsDue" 
					Return Me.BMInspectionsDue
				Case "BMInspectionsComplete" 
					Return Me.BMInspectionsComplete
				Case "BMInspectionsPending" 
					Return Me.BMInspectionsPending
				Case "BMInspectionsCancelled" 
					Return Me.BMInspectionsCancelled
				Case "IRInspectionsDue" 
					Return Me.IRInspectionsDue
				Case "IRInspectionsComplete" 
					Return Me.IRInspectionsComplete
				Case "IRInspectionsPending" 
					Return Me.IRInspectionsPending
				Case "IRInspectionsCancelled" 
					Return Me.IRInspectionsCancelled
				Case "WindInspectionsDue" 
					Return Me.WindInspectionsDue
				Case "WindInspectionsComplete" 
					Return Me.WindInspectionsComplete
				Case "WindInspectionsPending" 
					Return Me.WindInspectionsPending
				Case "WindInspectionsCancelled" 
					Return Me.WindInspectionsCancelled
				Case "SeismicInspectionsDue" 
					Return Me.SeismicInspectionsDue
				Case "SeismicInspectionsComplete" 
					Return Me.SeismicInspectionsComplete
				Case "SeismicInspectionsPending" 
					Return Me.SeismicInspectionsPending
				Case "SeismicInspectionsCancelled" 
					Return Me.SeismicInspectionsCancelled
				Case "FloodInspectionsDue" 
					Return Me.FloodInspectionsDue
				Case "FloodInspectionsComplete" 
					Return Me.FloodInspectionsComplete
				Case "FloodInspectionsPending" 
					Return Me.FloodInspectionsPending
				Case "FloodInspectionsCancelled" 
					Return Me.FloodInspectionsCancelled
				Case "JurisNoObjections" 
					Return Me.JurisNoObjections
				Case "JurisOpenViolations" 
					Return Me.JurisOpenViolations
				Case "JurisNoActiveObjections" 
					Return Me.JurisNoActiveObjections
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GSafeGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.GSafeGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireInspectionsDue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FireInspectionsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FireInspectionsPending As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsPending, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FireInspectionsCancelled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsCancelled, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BMInspectionsDue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BMInspectionsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BMInspectionsPending As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsPending, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BMInspectionsCancelled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsCancelled, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property IRInspectionsDue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property IRInspectionsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property IRInspectionsPending As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsPending, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property IRInspectionsCancelled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsCancelled, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WindInspectionsDue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WindInspectionsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WindInspectionsPending As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsPending, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WindInspectionsCancelled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsCancelled, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicInspectionsDue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicInspectionsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicInspectionsPending As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsPending, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SeismicInspectionsCancelled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsCancelled, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FloodInspectionsDue As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsDue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FloodInspectionsComplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsComplete, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FloodInspectionsPending As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsPending, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FloodInspectionsCancelled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsCancelled, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property JurisNoObjections As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.JurisNoObjections, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property JurisOpenViolations As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.JurisOpenViolations, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property JurisNoActiveObjections As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCGaugeStatsMetadata.ColumnNames.JurisNoActiveObjections, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCGaugeStatsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FilePrefix, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.GSafeGUID, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.GSafeGUID
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsDue, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsComplete, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsPending, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsPending
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FireInspectionsCancelled, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FireInspectionsCancelled
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsDue, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsComplete, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsPending, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsPending
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.BMInspectionsCancelled, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.BMInspectionsCancelled
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsDue, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsComplete, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsPending, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsPending
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.IRInspectionsCancelled, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.IRInspectionsCancelled
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsDue, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsComplete, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsPending, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsPending
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.WindInspectionsCancelled, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.WindInspectionsCancelled
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsDue, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsComplete, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsPending, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsPending
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.SeismicInspectionsCancelled, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.SeismicInspectionsCancelled
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsDue, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsDue
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsComplete, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsComplete
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsPending, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsPending
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.FloodInspectionsCancelled, 25, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.FloodInspectionsCancelled
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.JurisNoObjections, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.JurisNoObjections
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.JurisOpenViolations, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.JurisOpenViolations
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCGaugeStatsMetadata.ColumnNames.JurisNoActiveObjections, 28, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCGaugeStatsMetadata.PropertyNames.JurisNoActiveObjections
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCGaugeStatsMetadata
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
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const FireInspectionsDue As String = "FireInspectionsDue"
			 Public Const FireInspectionsComplete As String = "FireInspectionsComplete"
			 Public Const FireInspectionsPending As String = "FireInspectionsPending"
			 Public Const FireInspectionsCancelled As String = "FireInspectionsCancelled"
			 Public Const BMInspectionsDue As String = "BMInspectionsDue"
			 Public Const BMInspectionsComplete As String = "BMInspectionsComplete"
			 Public Const BMInspectionsPending As String = "BMInspectionsPending"
			 Public Const BMInspectionsCancelled As String = "BMInspectionsCancelled"
			 Public Const IRInspectionsDue As String = "IRInspectionsDue"
			 Public Const IRInspectionsComplete As String = "IRInspectionsComplete"
			 Public Const IRInspectionsPending As String = "IRInspectionsPending"
			 Public Const IRInspectionsCancelled As String = "IRInspectionsCancelled"
			 Public Const WindInspectionsDue As String = "WindInspectionsDue"
			 Public Const WindInspectionsComplete As String = "WindInspectionsComplete"
			 Public Const WindInspectionsPending As String = "WindInspectionsPending"
			 Public Const WindInspectionsCancelled As String = "WindInspectionsCancelled"
			 Public Const SeismicInspectionsDue As String = "SeismicInspectionsDue"
			 Public Const SeismicInspectionsComplete As String = "SeismicInspectionsComplete"
			 Public Const SeismicInspectionsPending As String = "SeismicInspectionsPending"
			 Public Const SeismicInspectionsCancelled As String = "SeismicInspectionsCancelled"
			 Public Const FloodInspectionsDue As String = "FloodInspectionsDue"
			 Public Const FloodInspectionsComplete As String = "FloodInspectionsComplete"
			 Public Const FloodInspectionsPending As String = "FloodInspectionsPending"
			 Public Const FloodInspectionsCancelled As String = "FloodInspectionsCancelled"
			 Public Const JurisNoObjections As String = "JurisNoObjections"
			 Public Const JurisOpenViolations As String = "JurisOpenViolations"
			 Public Const JurisNoActiveObjections As String = "JurisNoActiveObjections"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const GSafeGUID As String = "GSafeGUID"
			 Public Const FireInspectionsDue As String = "FireInspectionsDue"
			 Public Const FireInspectionsComplete As String = "FireInspectionsComplete"
			 Public Const FireInspectionsPending As String = "FireInspectionsPending"
			 Public Const FireInspectionsCancelled As String = "FireInspectionsCancelled"
			 Public Const BMInspectionsDue As String = "BMInspectionsDue"
			 Public Const BMInspectionsComplete As String = "BMInspectionsComplete"
			 Public Const BMInspectionsPending As String = "BMInspectionsPending"
			 Public Const BMInspectionsCancelled As String = "BMInspectionsCancelled"
			 Public Const IRInspectionsDue As String = "IRInspectionsDue"
			 Public Const IRInspectionsComplete As String = "IRInspectionsComplete"
			 Public Const IRInspectionsPending As String = "IRInspectionsPending"
			 Public Const IRInspectionsCancelled As String = "IRInspectionsCancelled"
			 Public Const WindInspectionsDue As String = "WindInspectionsDue"
			 Public Const WindInspectionsComplete As String = "WindInspectionsComplete"
			 Public Const WindInspectionsPending As String = "WindInspectionsPending"
			 Public Const WindInspectionsCancelled As String = "WindInspectionsCancelled"
			 Public Const SeismicInspectionsDue As String = "SeismicInspectionsDue"
			 Public Const SeismicInspectionsComplete As String = "SeismicInspectionsComplete"
			 Public Const SeismicInspectionsPending As String = "SeismicInspectionsPending"
			 Public Const SeismicInspectionsCancelled As String = "SeismicInspectionsCancelled"
			 Public Const FloodInspectionsDue As String = "FloodInspectionsDue"
			 Public Const FloodInspectionsComplete As String = "FloodInspectionsComplete"
			 Public Const FloodInspectionsPending As String = "FloodInspectionsPending"
			 Public Const FloodInspectionsCancelled As String = "FloodInspectionsCancelled"
			 Public Const JurisNoObjections As String = "JurisNoObjections"
			 Public Const JurisOpenViolations As String = "JurisOpenViolations"
			 Public Const JurisNoActiveObjections As String = "JurisNoActiveObjections"
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
			SyncLock GetType(ViewCCGaugeStatsMetadata)
			
				If ViewCCGaugeStatsMetadata.mapDelegates Is Nothing Then
					ViewCCGaugeStatsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCGaugeStatsMetadata._meta Is Nothing Then
					ViewCCGaugeStatsMetadata._meta = New ViewCCGaugeStatsMetadata()
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
				


				meta.AddTypeMap("FilePrefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("GSafeGUID", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireInspectionsDue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FireInspectionsComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FireInspectionsPending", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FireInspectionsCancelled", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BMInspectionsDue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BMInspectionsComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BMInspectionsPending", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BMInspectionsCancelled", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("IRInspectionsDue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("IRInspectionsComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("IRInspectionsPending", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("IRInspectionsCancelled", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WindInspectionsDue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WindInspectionsComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WindInspectionsPending", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WindInspectionsCancelled", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SeismicInspectionsDue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SeismicInspectionsComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SeismicInspectionsPending", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SeismicInspectionsCancelled", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FloodInspectionsDue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FloodInspectionsComplete", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FloodInspectionsPending", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FloodInspectionsCancelled", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("JurisNoObjections", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("JurisOpenViolations", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("JurisNoActiveObjections", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCGaugeStats"
				meta.Destination = "viewCCGaugeStats"
				
				meta.spInsert = "proc_viewCCGaugeStatsInsert"
				meta.spUpdate = "proc_viewCCGaugeStatsUpdate"
				meta.spDelete = "proc_viewCCGaugeStatsDelete"
				meta.spLoadAll = "proc_viewCCGaugeStatsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCGaugeStatsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCGaugeStatsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
