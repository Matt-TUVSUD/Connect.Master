
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/20/2013 8:34:29 AM
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
	' Encapsulates the 'viewCCAdminWindowRecResponseFire' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCAdminWindowRecResponseFire))> _
	<XmlType("ViewCCAdminWindowRecResponseFire")> _	
	Partial Public Class ViewCCAdminWindowRecResponseFire 
		Inherits esViewCCAdminWindowRecResponseFire
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCAdminWindowRecResponseFire()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCAdminWindowRecResponseFireCollection")> _
	Partial Public Class ViewCCAdminWindowRecResponseFireCollection
		Inherits esViewCCAdminWindowRecResponseFireCollection
		Implements IEnumerable(Of ViewCCAdminWindowRecResponseFire)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCAdminWindowRecResponseFire))> _
		Public Class ViewCCAdminWindowRecResponseFireCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCAdminWindowRecResponseFireCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCAdminWindowRecResponseFireCollectionWCFPacket) As ViewCCAdminWindowRecResponseFireCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCAdminWindowRecResponseFireCollection) As ViewCCAdminWindowRecResponseFireCollectionWCFPacket
				Return New ViewCCAdminWindowRecResponseFireCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCAdminWindowRecResponseFireQuery 
		Inherits esViewCCAdminWindowRecResponseFireQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCAdminWindowRecResponseFireQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCAdminWindowRecResponseFireQuery) As String
			Return ViewCCAdminWindowRecResponseFireQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCAdminWindowRecResponseFireQuery
			Return DirectCast(ViewCCAdminWindowRecResponseFireQuery.SerializeHelper.FromXml(query, GetType(ViewCCAdminWindowRecResponseFireQuery)), ViewCCAdminWindowRecResponseFireQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowRecResponseFire
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.RRLogId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RRLogId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RRLogId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RRLogId, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.RRLogId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.RRLogGuid
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RRLogGuid As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RRLogGuid)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RRLogGuid, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.RRLogGuid)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.CurrentLink
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrentLink As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.CurrentLink)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.CurrentLink, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.CurrentLink)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.LinkActive
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkActive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LinkActive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LinkActive, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LinkActive)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.Sender
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Sender As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Sender)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Sender, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.Sender)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.LastRecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastRecipientName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LastRecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LastRecipientName, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LastRecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.LastRecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastRecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LastRecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LastRecipientEmail, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LastRecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.DateRecEmailed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateRecEmailed As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.DateRecEmailed)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.DateRecEmailed, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.DateRecEmailed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.InspectionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.InspectionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.InspectionDate, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.InspectionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.InspectionEmailedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property InspectionEmailedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.InspectionEmailedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.InspectionEmailedDate, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.InspectionEmailedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.LinkToReport
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkToReport As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LinkToReport)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LinkToReport, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LinkToReport)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.Activity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Activity As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Activity)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Activity, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.Activity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.RecCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RecCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RecCount, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.RecCount)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.LatestStatusDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LatestStatusDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LatestStatusDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LatestStatusDate, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LatestStatusDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAdminWindowRecResponseFire.StatusDateCount
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property StatusDateCount As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.StatusDateCount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.StatusDateCount, value) Then
					OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.StatusDateCount)
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
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.RRLogId)
							End If
						
						Case "LinkActive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.LinkActive = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LinkActive)
							End If
						
						Case "DateRecEmailed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateRecEmailed = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.DateRecEmailed)
							End If
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "InspectionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.InspectionDate)
							End If
						
						Case "InspectionEmailedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InspectionEmailedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.InspectionEmailedDate)
							End If
						
						Case "RecCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.RecCount)
							End If
						
						Case "LatestStatusDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LatestStatusDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LatestStatusDate)
							End If
						
						Case "StatusDateCount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.StatusDateCount = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.StatusDateCount)
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
		
			Public Sub New(ByVal entity As esViewCCAdminWindowRecResponseFire)
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
					Dim data_ As System.String = entity.CurrentLink
					
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
						entity.CurrentLink = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkActive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.LinkActive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkActive = Nothing
					Else
						entity.LinkActive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sender As System.String 
				Get
					Dim data_ As System.String = entity.Sender
					
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
						entity.Sender = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastRecipientName As System.String 
				Get
					Dim data_ As System.String = entity.LastRecipientName
					
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
						entity.LastRecipientName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastRecipientEmail As System.String 
				Get
					Dim data_ As System.String = entity.LastRecipientEmail
					
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
						entity.LastRecipientEmail = Convert.ToString(Value)
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
		  	
			Public Property DateRecEmailed As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateRecEmailed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateRecEmailed = Nothing
					Else
						entity.DateRecEmailed = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property PracticeCode As System.String 
				Get
					Dim data_ As Nullable(Of System.Int16) = entity.PracticeCode
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PracticeCode = Nothing
					Else
						entity.PracticeCode = Convert.ToInt16(Value)
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
		  	
			Public Property InspectionEmailedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InspectionEmailedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InspectionEmailedDate = Nothing
					Else
						entity.InspectionEmailedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkToReport As System.String 
				Get
					Dim data_ As System.String = entity.LinkToReport
					
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
						entity.LinkToReport = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Activity As System.String 
				Get
					Dim data_ As System.String = entity.Activity
					
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
						entity.Activity = Convert.ToString(Value)
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
					Dim data_ As Nullable(Of System.DateTime) = entity.LatestStatusDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LatestStatusDate = Nothing
					Else
						entity.LatestStatusDate = Convert.ToDateTime(Value)
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
		  

			Private entity As esViewCCAdminWindowRecResponseFire
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowRecResponseFireMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCAdminWindowRecResponseFireQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowRecResponseFireQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCAdminWindowRecResponseFireQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowRecResponseFireQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCAdminWindowRecResponseFireQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCAdminWindowRecResponseFireCollection
		Inherits esEntityCollection(Of ViewCCAdminWindowRecResponseFire)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowRecResponseFireMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCAdminWindowRecResponseFireCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCAdminWindowRecResponseFireQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAdminWindowRecResponseFireQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCAdminWindowRecResponseFireQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCAdminWindowRecResponseFireQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCAdminWindowRecResponseFireQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCAdminWindowRecResponseFireQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCAdminWindowRecResponseFireQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCAdminWindowRecResponseFireQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCAdminWindowRecResponseFireMetadata.Meta()
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
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RRLogId As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RRLogId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RRLogGuid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RRLogGuid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CurrentLink As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.CurrentLink, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkActive As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LinkActive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Sender As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Sender, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastRecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LastRecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastRecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LastRecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateRecEmailed As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.DateRecEmailed, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.InspectionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InspectionEmailedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.InspectionEmailedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LinkToReport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LinkToReport, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Activity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Activity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RecCount, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LatestStatusDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LatestStatusDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property StatusDateCount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.StatusDateCount, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCAdminWindowRecResponseFireMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RRLogId, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.RRLogId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RRLogGuid, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.RRLogGuid
			c.CharacterMaxLength = 38
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.CurrentLink, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.CurrentLink
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LinkActive, 4, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LinkActive
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Sender, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.Sender
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LastRecipientName, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LastRecipientName
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LastRecipientEmail, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LastRecipientEmail
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Hazard, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.DateRecEmailed, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.DateRecEmailed
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.PracticeCode, 10, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.InspectionDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.InspectionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.InspectionEmailedDate, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.InspectionEmailedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LinkToReport, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LinkToReport
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.Activity, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.Activity
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.RecCount, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.RecCount
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.LatestStatusDate, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.LatestStatusDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAdminWindowRecResponseFireMetadata.ColumnNames.StatusDateCount, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAdminWindowRecResponseFireMetadata.PropertyNames.StatusDateCount
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCAdminWindowRecResponseFireMetadata
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
			SyncLock GetType(ViewCCAdminWindowRecResponseFireMetadata)
			
				If ViewCCAdminWindowRecResponseFireMetadata.mapDelegates Is Nothing Then
					ViewCCAdminWindowRecResponseFireMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCAdminWindowRecResponseFireMetadata._meta Is Nothing Then
					ViewCCAdminWindowRecResponseFireMetadata._meta = New ViewCCAdminWindowRecResponseFireMetadata()
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
				meta.AddTypeMap("RRLogId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RRLogGuid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CurrentLink", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkActive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Sender", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LastRecipientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LastRecipientEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DateRecEmailed", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("InspectionDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("InspectionEmailedDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("LinkToReport", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Activity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecCount", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LatestStatusDate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("StatusDateCount", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCCAdminWindowRecResponseFire"
				meta.Destination = "viewCCAdminWindowRecResponseFire"
				
				meta.spInsert = "proc_viewCCAdminWindowRecResponseFireInsert"
				meta.spUpdate = "proc_viewCCAdminWindowRecResponseFireUpdate"
				meta.spDelete = "proc_viewCCAdminWindowRecResponseFireDelete"
				meta.spLoadAll = "proc_viewCCAdminWindowRecResponseFireLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCAdminWindowRecResponseFireLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCAdminWindowRecResponseFireMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
