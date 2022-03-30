
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/20/2017 11:54:34 AM
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
	' Encapsulates the 'viewCCAdminWindowRecResponseDiversified' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCAdminWindowRecResponseDiversified))> _
	<XmlType("ViewCCAdminWindowRecResponseDiversified")> _	
	Partial Public Class ViewCCAdminWindowRecResponseDiversified 
		Inherits esViewCCAdminWindowRecResponseDiversified
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCAdminWindowRecResponseDiversified()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCAdminWindowRecResponseDiversifiedCollection")> _
	Partial Public Class ViewCCAdminWindowRecResponseDiversifiedCollection
		Inherits esViewCCAdminWindowRecResponseDiversifiedCollection
		Implements IEnumerable(Of ViewCCAdminWindowRecResponseDiversified)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCAdminWindowRecResponseDiversified))> _
		Public Class ViewCCAdminWindowRecResponseDiversifiedCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCAdminWindowRecResponseDiversifiedCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCAdminWindowRecResponseDiversifiedCollectionWCFPacket) As ViewCCAdminWindowRecResponseDiversifiedCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCAdminWindowRecResponseDiversifiedCollection) As ViewCCAdminWindowRecResponseDiversifiedCollectionWCFPacket
				Return New ViewCCAdminWindowRecResponseDiversifiedCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCAdminWindowRecResponseDiversifiedQuery 
		Inherits esViewCCAdminWindowRecResponseDiversifiedQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCAdminWindowRecResponseDiversifiedQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCAdminWindowRecResponseDiversifiedQuery) As String
			Return ViewCCAdminWindowRecResponseDiversifiedQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCAdminWindowRecResponseDiversifiedQuery
			Return DirectCast(ViewCCAdminWindowRecResponseDiversifiedQuery.SerializeHelper.FromXml(query, GetType(ViewCCAdminWindowRecResponseDiversifiedQuery)), ViewCCAdminWindowRecResponseDiversifiedQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowRecResponseDiversified
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.RRLogId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RRLogId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RRLogId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RRLogId, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.RRLogId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.RRLogGuid
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RRLogGuid As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RRLogGuid)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RRLogGuid, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.RRLogGuid)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.CurrentLink
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrentLink As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.CurrentLink)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.CurrentLink, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.CurrentLink)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.LinkActive
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkActive As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LinkActive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LinkActive, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LinkActive)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.Sender
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Sender As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Sender)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Sender, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Sender)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.LastRecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastRecipientName As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LastRecipientName)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LastRecipientName, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LastRecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.LastRecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastRecipientEmail As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LastRecipientEmail)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LastRecipientEmail, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LastRecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.DateRecEmailed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateRecEmailed As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.DateRecEmailed)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.DateRecEmailed, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.DateRecEmailed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.InspectionEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionEmailedDate As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.InspectionEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.InspectionEmailedDate, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.InspectionEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.LinkToReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToReport As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LinkToReport)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LinkToReport, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LinkToReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.Activity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Activity As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Activity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Activity, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Activity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.RecCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RecCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RecCount, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.RecCount)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.LatestStatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LatestStatusDate As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LatestStatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LatestStatusDate, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LatestStatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseDiversified.StatusDateCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.StatusDateCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.StatusDateCount, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.StatusDateCount)
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
												
						Case "RRLogId"
							Me.str().RRLogId = CType(value, string)
												
						Case "RRLogGuid"
							Me.str().RRLogGuid = CType(value, string)
												
						Case "CurrentLink"
							Me.str().CurrentLink = CType(value, string)
												
						Case "LinkActive"
							Me.str().LinkActive = CType(value, string)
												
						Case "Sender"
							Me.str().Sender = CType(value, string)
												
						Case "LastRecipientName"
							Me.str().LastRecipientName = CType(value, string)
												
						Case "LastRecipientEmail"
							Me.str().LastRecipientEmail = CType(value, string)
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "DateRecEmailed"
							Me.str().DateRecEmailed = CType(value, string)
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
						Case "InspectionDate"
							Me.str().InspectionDate = CType(value, string)
												
						Case "InspectionEmailedDate"
							Me.str().InspectionEmailedDate = CType(value, string)
												
						Case "LinkToReport"
							Me.str().LinkToReport = CType(value, string)
												
						Case "Activity"
							Me.str().Activity = CType(value, string)
												
						Case "RecCount"
							Me.str().RecCount = CType(value, string)
												
						Case "LatestStatusDate"
							Me.str().LatestStatusDate = CType(value, string)
												
						Case "StatusDateCount"
							Me.str().StatusDateCount = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RRLogId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RRLogId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.RRLogId)
							End If
						
						Case "CurrentLink"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.CurrentLink = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.CurrentLink)
							End If
						
						Case "LinkActive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LinkActive = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LinkActive)
							End If
						
						Case "Sender"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Sender = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Sender)
							End If
						
						Case "LastRecipientName"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LastRecipientName = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LastRecipientName)
							End If
						
						Case "LastRecipientEmail"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LastRecipientEmail = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LastRecipientEmail)
							End If
						
						Case "Hazard"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Hazard = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Hazard)
							End If
						
						Case "DateRecEmailed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.DateRecEmailed = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.DateRecEmailed)
							End If
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.InspectionDate = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "InspectionEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.InspectionEmailedDate = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.InspectionEmailedDate)
							End If
						
						Case "LinkToReport"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LinkToReport = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LinkToReport)
							End If
						
						Case "Activity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Activity = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Activity)
							End If
						
						Case "RecCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.RecCount)
							End If
						
						Case "LatestStatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.LatestStatusDate = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LatestStatusDate)
							End If
						
						Case "StatusDateCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.StatusDateCount)
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
		
			Public Sub New(ByVal entity As esViewCCAdminWindowRecResponseDiversified)
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
		  	
			Public Property RRLogId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RRLogId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RRLogId = Nothing
					Else
						entity.RRLogId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RRLogGuid As System.String 
				Get
					Dim data_ As System.String = entity.RRLogGuid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RRLogGuid = Nothing
					Else
						entity.RRLogGuid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CurrentLink As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.CurrentLink
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CurrentLink = Nothing
					Else
						entity.CurrentLink = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkActive As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LinkActive
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkActive = Nothing
					Else
						entity.LinkActive = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sender As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Sender
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sender = Nothing
					Else
						entity.Sender = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastRecipientName As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LastRecipientName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastRecipientName = Nothing
					Else
						entity.LastRecipientName = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastRecipientEmail As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LastRecipientEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastRecipientEmail = Nothing
					Else
						entity.LastRecipientEmail = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazard As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Hazard
					
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
						entity.Hazard = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateRecEmailed As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.DateRecEmailed
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateRecEmailed = Nothing
					Else
						entity.DateRecEmailed = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property PracticeCode As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.PracticeCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeCode = Nothing
					Else
						entity.PracticeCode = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.InspectionDate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionDate = Nothing
					Else
						entity.InspectionDate = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property InspectionEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.InspectionEmailedDate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionEmailedDate = Nothing
					Else
						entity.InspectionEmailedDate = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToReport As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LinkToReport
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkToReport = Nothing
					Else
						entity.LinkToReport = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property Activity As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Activity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Activity = Nothing
					Else
						entity.Activity = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecCount As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecCount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecCount = Nothing
					Else
						entity.RecCount = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LatestStatusDate As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.LatestStatusDate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LatestStatusDate = Nothing
					Else
						entity.LatestStatusDate = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property StatusDateCount As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.StatusDateCount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.StatusDateCount = Nothing
					Else
						entity.StatusDateCount = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCAdminWindowRecResponseDiversified
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowRecResponseDiversifiedMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCAdminWindowRecResponseDiversifiedQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowRecResponseDiversifiedQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCAdminWindowRecResponseDiversifiedQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowRecResponseDiversifiedQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCAdminWindowRecResponseDiversifiedQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowRecResponseDiversifiedCollection
		Inherits esEntityCollection(Of ViewCCAdminWindowRecResponseDiversified)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowRecResponseDiversifiedMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCAdminWindowRecResponseDiversifiedCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCAdminWindowRecResponseDiversifiedQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowRecResponseDiversifiedQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCAdminWindowRecResponseDiversifiedQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCAdminWindowRecResponseDiversifiedQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowRecResponseDiversifiedQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCAdminWindowRecResponseDiversifiedQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCAdminWindowRecResponseDiversifiedQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCAdminWindowRecResponseDiversifiedQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowRecResponseDiversifiedMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "RRLogId" 
					Return Me.RRLogId
				Case "RRLogGuid" 
					Return Me.RRLogGuid
				Case "CurrentLink" 
					Return Me.CurrentLink
				Case "LinkActive" 
					Return Me.LinkActive
				Case "Sender" 
					Return Me.Sender
				Case "LastRecipientName" 
					Return Me.LastRecipientName
				Case "LastRecipientEmail" 
					Return Me.LastRecipientEmail
				Case "Hazard" 
					Return Me.Hazard
				Case "DateRecEmailed" 
					Return Me.DateRecEmailed
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "InspectionDate" 
					Return Me.InspectionDate
				Case "InspectionEmailedDate" 
					Return Me.InspectionEmailedDate
				Case "LinkToReport" 
					Return Me.LinkToReport
				Case "Activity" 
					Return Me.Activity
				Case "RecCount" 
					Return Me.RecCount
				Case "LatestStatusDate" 
					Return Me.LatestStatusDate
				Case "StatusDateCount" 
					Return Me.StatusDateCount
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RRLogId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RRLogId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RRLogGuid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RRLogGuid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CurrentLink As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.CurrentLink, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LinkActive As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LinkActive, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Sender As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Sender, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LastRecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LastRecipientName, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LastRecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LastRecipientEmail, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Hazard, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property DateRecEmailed As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.DateRecEmailed, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.PracticeCode, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.InspectionDate, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.InspectionEmailedDate, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LinkToReport, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property Activity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Activity, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property RecCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RecCount, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LatestStatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LatestStatusDate, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.StatusDateCount, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCAdminWindowRecResponseDiversifiedMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RRLogId, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.RRLogId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RRLogGuid, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.RRLogGuid
			c.CharacterMaxLength = 38
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.CurrentLink, 3, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.CurrentLink
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LinkActive, 4, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LinkActive
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Sender, 5, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Sender
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LastRecipientName, 6, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LastRecipientName
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LastRecipientEmail, 7, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LastRecipientEmail
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Hazard, 8, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.DateRecEmailed, 9, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.DateRecEmailed
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.PracticeCode, 10, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.PracticeCode
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.InspectionDate, 11, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.InspectionDate
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.InspectionEmailedDate, 12, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.InspectionEmailedDate
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LinkToReport, 13, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LinkToReport
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.Activity, 14, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.Activity
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.RecCount, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.RecCount
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.LatestStatusDate, 16, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.LatestStatusDate
			c.CharacterMaxLength = 1
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseDiversifiedMetadata.ColumnNames.StatusDateCount, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowRecResponseDiversifiedMetadata.PropertyNames.StatusDateCount
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCAdminWindowRecResponseDiversifiedMetadata
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
			 Public Const RRLogId As String = "RRLogId"
			 Public Const RRLogGuid As String = "RRLogGuid"
			 Public Const CurrentLink As String = "CurrentLink"
			 Public Const LinkActive As String = "LinkActive"
			 Public Const Sender As String = "Sender"
			 Public Const LastRecipientName As String = "LastRecipientName"
			 Public Const LastRecipientEmail As String = "LastRecipientEmail"
			 Public Const Hazard As String = "Hazard"
			 Public Const DateRecEmailed As String = "DateRecEmailed"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const InspectionEmailedDate As String = "InspectionEmailedDate"
			 Public Const LinkToReport As String = "LinkToReport"
			 Public Const Activity As String = "Activity"
			 Public Const RecCount As String = "RecCount"
			 Public Const LatestStatusDate As String = "LatestStatusDate"
			 Public Const StatusDateCount As String = "StatusDateCount"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const RRLogId As String = "RRLogId"
			 Public Const RRLogGuid As String = "RRLogGuid"
			 Public Const CurrentLink As String = "CurrentLink"
			 Public Const LinkActive As String = "LinkActive"
			 Public Const Sender As String = "Sender"
			 Public Const LastRecipientName As String = "LastRecipientName"
			 Public Const LastRecipientEmail As String = "LastRecipientEmail"
			 Public Const Hazard As String = "Hazard"
			 Public Const DateRecEmailed As String = "DateRecEmailed"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const InspectionDate As String = "InspectionDate"
			 Public Const InspectionEmailedDate As String = "InspectionEmailedDate"
			 Public Const LinkToReport As String = "LinkToReport"
			 Public Const Activity As String = "Activity"
			 Public Const RecCount As String = "RecCount"
			 Public Const LatestStatusDate As String = "LatestStatusDate"
			 Public Const StatusDateCount As String = "StatusDateCount"
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
			SyncLock GetType(ViewCCAdminWindowRecResponseDiversifiedMetadata)
			
				If ViewCCAdminWindowRecResponseDiversifiedMetadata.mapDelegates Is Nothing Then
					ViewCCAdminWindowRecResponseDiversifiedMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCAdminWindowRecResponseDiversifiedMetadata._meta Is Nothing Then
					ViewCCAdminWindowRecResponseDiversifiedMetadata._meta = New ViewCCAdminWindowRecResponseDiversifiedMetadata()
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
				meta.AddTypeMap("RRLogId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RRLogGuid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CurrentLink", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LinkActive", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Sender", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LastRecipientName", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LastRecipientEmail", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("DateRecEmailed", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("InspectionDate", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("InspectionEmailedDate", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("LinkToReport", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("Activity", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("RecCount", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LatestStatusDate", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("StatusDateCount", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCAdminWindowRecResponseDiversified"
				meta.Destination = "viewCCAdminWindowRecResponseDiversified"
				
				meta.spInsert = "proc_viewCCAdminWindowRecResponseDiversifiedInsert"
				meta.spUpdate = "proc_viewCCAdminWindowRecResponseDiversifiedUpdate"
				meta.spDelete = "proc_viewCCAdminWindowRecResponseDiversifiedDelete"
				meta.spLoadAll = "proc_viewCCAdminWindowRecResponseDiversifiedLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCAdminWindowRecResponseDiversifiedLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCAdminWindowRecResponseDiversifiedMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
