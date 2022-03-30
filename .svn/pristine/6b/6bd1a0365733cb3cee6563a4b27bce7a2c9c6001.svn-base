
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/13/2014 9:27:48 AM
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
	' Encapsulates the 'viewCCActiveRRLog' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCActiveRRLog))> _
	<XmlType("ViewCCActiveRRLog")> _	
	Partial Public Class ViewCCActiveRRLog 
		Inherits esViewCCActiveRRLog
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCActiveRRLog()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCActiveRRLogCollection")> _
	Partial Public Class ViewCCActiveRRLogCollection
		Inherits esViewCCActiveRRLogCollection
		Implements IEnumerable(Of ViewCCActiveRRLog)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCActiveRRLog))> _
		Public Class ViewCCActiveRRLogCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCActiveRRLogCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCActiveRRLogCollectionWCFPacket) As ViewCCActiveRRLogCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCActiveRRLogCollection) As ViewCCActiveRRLogCollectionWCFPacket
				Return New ViewCCActiveRRLogCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCActiveRRLogQuery 
		Inherits esViewCCActiveRRLogQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCActiveRRLogQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCActiveRRLogQuery) As String
			Return ViewCCActiveRRLogQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCActiveRRLogQuery
			Return DirectCast(ViewCCActiveRRLogQuery.SerializeHelper.FromXml(query, GetType(ViewCCActiveRRLogQuery)), ViewCCActiveRRLogQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCActiveRRLog
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCActiveRRLog.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCActiveRRLogMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCActiveRRLogMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCActiveRRLogMetadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCActiveRRLogMetadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.PracticeCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PracticeCode As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(ViewCCActiveRRLogMetadata.ColumnNames.PracticeCode)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(ViewCCActiveRRLogMetadata.ColumnNames.PracticeCode, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.PracticeCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.Hazard
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Hazard As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.Hazard)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.Hazard, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.Hazard)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.DateStamp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateStamp As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.DateStamp)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.DateStamp, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.DateStamp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.Sender
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Sender As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.Sender)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.Sender, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.Sender)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.RecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.RecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.RecipientName, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.RecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.RecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.RecipientEmail, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.Activity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Activity As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.Activity)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.Activity, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.Activity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.LinkActive
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkActive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCActiveRRLogMetadata.ColumnNames.LinkActive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCActiveRRLogMetadata.ColumnNames.LinkActive, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.LinkActive)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.LinkActivatedDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkActivatedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedDate, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.LinkActivatedDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.LinkActivatedBy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkActivatedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedBy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedBy, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.LinkActivatedBy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.LinkActivatedByEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LinkActivatedByEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedByEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedByEmail, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.LinkActivatedByEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.ResponseActive
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseActive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCActiveRRLogMetadata.ColumnNames.ResponseActive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCActiveRRLogMetadata.ColumnNames.ResponseActive, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.ResponseActive)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.ResponseLastActivity
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ResponseLastActivity As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.ResponseLastActivity)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.ResponseLastActivity, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.ResponseLastActivity)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.Changed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Changed As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCActiveRRLogMetadata.ColumnNames.Changed)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCActiveRRLogMetadata.ColumnNames.Changed, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.Changed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.RFU1Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU1Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.RFU1Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.RFU1Date, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RFU1Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.RFU2Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU2Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.RFU2Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.RFU2Date, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RFU2Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.RFU3Date
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RFU3Date As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.RFU3Date)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.RFU3Date, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RFU3Date)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.RRLogGuid
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RRLogGuid As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.RRLogGuid)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.RRLogGuid, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RRLogGuid)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.CurrentLink
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CurrentLink As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.CurrentLink)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.CurrentLink, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.CurrentLink)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.LanguagePreference
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LanguagePreference As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.LanguagePreference)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.LanguagePreference, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.LanguagePreference)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.AdminAlertDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminAlertDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.AdminAlertDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCActiveRRLogMetadata.ColumnNames.AdminAlertDate, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.AdminAlertDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCActiveRRLog.AdminAlertReason
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AdminAlertReason As System.String
			Get
				Return MyBase.GetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.AdminAlertReason)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCActiveRRLogMetadata.ColumnNames.AdminAlertReason, value) Then
					OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.AdminAlertReason)
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
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "PracticeCode"
							Me.str().PracticeCode = CType(value, string)
												
						Case "Hazard"
							Me.str().Hazard = CType(value, string)
												
						Case "DateStamp"
							Me.str().DateStamp = CType(value, string)
												
						Case "Sender"
							Me.str().Sender = CType(value, string)
												
						Case "RecipientName"
							Me.str().RecipientName = CType(value, string)
												
						Case "RecipientEmail"
							Me.str().RecipientEmail = CType(value, string)
												
						Case "Activity"
							Me.str().Activity = CType(value, string)
												
						Case "LinkActive"
							Me.str().LinkActive = CType(value, string)
												
						Case "LinkActivatedDate"
							Me.str().LinkActivatedDate = CType(value, string)
												
						Case "LinkActivatedBy"
							Me.str().LinkActivatedBy = CType(value, string)
												
						Case "LinkActivatedByEmail"
							Me.str().LinkActivatedByEmail = CType(value, string)
												
						Case "ResponseActive"
							Me.str().ResponseActive = CType(value, string)
												
						Case "ResponseLastActivity"
							Me.str().ResponseLastActivity = CType(value, string)
												
						Case "Changed"
							Me.str().Changed = CType(value, string)
												
						Case "RFU1Date"
							Me.str().RFU1Date = CType(value, string)
												
						Case "RFU2Date"
							Me.str().RFU2Date = CType(value, string)
												
						Case "RFU3Date"
							Me.str().RFU3Date = CType(value, string)
												
						Case "RRLogGuid"
							Me.str().RRLogGuid = CType(value, string)
												
						Case "CurrentLink"
							Me.str().CurrentLink = CType(value, string)
												
						Case "LanguagePreference"
							Me.str().LanguagePreference = CType(value, string)
												
						Case "AdminAlertDate"
							Me.str().AdminAlertDate = CType(value, string)
												
						Case "AdminAlertReason"
							Me.str().AdminAlertReason = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.Id)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.FilePrefix)
							End If
						
						Case "PracticeCode"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int16" Then
								Me.PracticeCode = CType(value, Nullable(Of System.Int16))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.PracticeCode)
							End If
						
						Case "DateStamp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateStamp = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.DateStamp)
							End If
						
						Case "LinkActive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.LinkActive = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.LinkActive)
							End If
						
						Case "LinkActivatedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LinkActivatedDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.LinkActivatedDate)
							End If
						
						Case "ResponseActive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ResponseActive = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.ResponseActive)
							End If
						
						Case "ResponseLastActivity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ResponseLastActivity = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.ResponseLastActivity)
							End If
						
						Case "Changed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Changed = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.Changed)
							End If
						
						Case "RFU1Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU1Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RFU1Date)
							End If
						
						Case "RFU2Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU2Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RFU2Date)
							End If
						
						Case "RFU3Date"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.RFU3Date = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.RFU3Date)
							End If
						
						Case "AdminAlertDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.AdminAlertDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCActiveRRLogMetadata.PropertyNames.AdminAlertDate)
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
		
			Public Sub New(ByVal entity As esViewCCActiveRRLog)
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
		  	
			Public Property DateStamp As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateStamp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateStamp = Nothing
					Else
						entity.DateStamp = Convert.ToDateTime(Value)
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
		  	
			Public Property RecipientName As System.String 
				Get
					Dim data_ As System.String = entity.RecipientName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecipientName = Nothing
					Else
						entity.RecipientName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property RecipientEmail As System.String 
				Get
					Dim data_ As System.String = entity.RecipientEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecipientEmail = Nothing
					Else
						entity.RecipientEmail = Convert.ToString(Value)
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
		  	
			Public Property LinkActivatedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LinkActivatedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkActivatedDate = Nothing
					Else
						entity.LinkActivatedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkActivatedBy As System.String 
				Get
					Dim data_ As System.String = entity.LinkActivatedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkActivatedBy = Nothing
					Else
						entity.LinkActivatedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkActivatedByEmail As System.String 
				Get
					Dim data_ As System.String = entity.LinkActivatedByEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkActivatedByEmail = Nothing
					Else
						entity.LinkActivatedByEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponseActive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ResponseActive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseActive = Nothing
					Else
						entity.ResponseActive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ResponseLastActivity As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ResponseLastActivity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ResponseLastActivity = Nothing
					Else
						entity.ResponseLastActivity = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changed As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Changed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changed = Nothing
					Else
						entity.Changed = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU1Date As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RFU1Date
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU1Date = Nothing
					Else
						entity.RFU1Date = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU2Date As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RFU2Date
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU2Date = Nothing
					Else
						entity.RFU2Date = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property RFU3Date As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.RFU3Date
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RFU3Date = Nothing
					Else
						entity.RFU3Date = Convert.ToDateTime(Value)
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
		  	
			Public Property LanguagePreference As System.String 
				Get
					Dim data_ As System.String = entity.LanguagePreference
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LanguagePreference = Nothing
					Else
						entity.LanguagePreference = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AdminAlertDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.AdminAlertDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AdminAlertDate = Nothing
					Else
						entity.AdminAlertDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property AdminAlertReason As System.String 
				Get
					Dim data_ As System.String = entity.AdminAlertReason
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AdminAlertReason = Nothing
					Else
						entity.AdminAlertReason = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCActiveRRLog
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCActiveRRLogMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCActiveRRLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCActiveRRLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCActiveRRLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCActiveRRLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCActiveRRLogQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCActiveRRLogCollection
		Inherits esEntityCollection(Of ViewCCActiveRRLog)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCActiveRRLogMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCActiveRRLogCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCActiveRRLogQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCActiveRRLogQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCActiveRRLogQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCActiveRRLogQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCActiveRRLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCActiveRRLogQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCActiveRRLogQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCActiveRRLogQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCActiveRRLogMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "FileNo" 
					Return Me.FileNo
				Case "PracticeCode" 
					Return Me.PracticeCode
				Case "Hazard" 
					Return Me.Hazard
				Case "DateStamp" 
					Return Me.DateStamp
				Case "Sender" 
					Return Me.Sender
				Case "RecipientName" 
					Return Me.RecipientName
				Case "RecipientEmail" 
					Return Me.RecipientEmail
				Case "Activity" 
					Return Me.Activity
				Case "LinkActive" 
					Return Me.LinkActive
				Case "LinkActivatedDate" 
					Return Me.LinkActivatedDate
				Case "LinkActivatedBy" 
					Return Me.LinkActivatedBy
				Case "LinkActivatedByEmail" 
					Return Me.LinkActivatedByEmail
				Case "ResponseActive" 
					Return Me.ResponseActive
				Case "ResponseLastActivity" 
					Return Me.ResponseLastActivity
				Case "Changed" 
					Return Me.Changed
				Case "RFU1Date" 
					Return Me.RFU1Date
				Case "RFU2Date" 
					Return Me.RFU2Date
				Case "RFU3Date" 
					Return Me.RFU3Date
				Case "RRLogGuid" 
					Return Me.RRLogGuid
				Case "CurrentLink" 
					Return Me.CurrentLink
				Case "LanguagePreference" 
					Return Me.LanguagePreference
				Case "AdminAlertDate" 
					Return Me.AdminAlertDate
				Case "AdminAlertReason" 
					Return Me.AdminAlertReason
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.FilePrefix, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PracticeCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.PracticeCode, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Hazard As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.Hazard, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DateStamp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.DateStamp, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Sender As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.Sender, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.RecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.RecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Activity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.Activity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkActive As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.LinkActive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property LinkActivatedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LinkActivatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkActivatedByEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedByEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseActive As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.ResponseActive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ResponseLastActivity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.ResponseLastActivity, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Changed As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.Changed, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property RFU1Date As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.RFU1Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU2Date As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.RFU2Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RFU3Date As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.RFU3Date, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property RRLogGuid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.RRLogGuid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CurrentLink As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.CurrentLink, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LanguagePreference As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.LanguagePreference, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AdminAlertDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.AdminAlertDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AdminAlertReason As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCActiveRRLogMetadata.ColumnNames.AdminAlertReason, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCActiveRRLogMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.FilePrefix, 1, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.FilePrefix
			c.NumericPrecision = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.FileNo, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.PracticeCode, 3, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.PracticeCode
			c.NumericPrecision = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.Hazard, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.Hazard
			c.CharacterMaxLength = 7
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.DateStamp, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.DateStamp
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.Sender, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.Sender
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.RecipientName, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.RecipientName
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.RecipientEmail, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.RecipientEmail
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.Activity, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.Activity
			c.CharacterMaxLength = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.LinkActive, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.LinkActive
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.LinkActivatedDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedBy, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.LinkActivatedBy
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.LinkActivatedByEmail, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.LinkActivatedByEmail
			c.CharacterMaxLength = 75
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.ResponseActive, 14, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.ResponseActive
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.ResponseLastActivity, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.ResponseLastActivity
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.Changed, 16, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.Changed
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.RFU1Date, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.RFU1Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.RFU2Date, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.RFU2Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.RFU3Date, 19, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.RFU3Date
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.RRLogGuid, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.RRLogGuid
			c.CharacterMaxLength = 38
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.CurrentLink, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.CurrentLink
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.LanguagePreference, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.LanguagePreference
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.AdminAlertDate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.AdminAlertDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCActiveRRLogMetadata.ColumnNames.AdminAlertReason, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCActiveRRLogMetadata.PropertyNames.AdminAlertReason
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCActiveRRLogMetadata
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
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Hazard As String = "Hazard"
			 Public Const DateStamp As String = "DateStamp"
			 Public Const Sender As String = "Sender"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const Activity As String = "Activity"
			 Public Const LinkActive As String = "LinkActive"
			 Public Const LinkActivatedDate As String = "LinkActivatedDate"
			 Public Const LinkActivatedBy As String = "LinkActivatedBy"
			 Public Const LinkActivatedByEmail As String = "LinkActivatedByEmail"
			 Public Const ResponseActive As String = "ResponseActive"
			 Public Const ResponseLastActivity As String = "ResponseLastActivity"
			 Public Const Changed As String = "Changed"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RRLogGuid As String = "RRLogGuid"
			 Public Const CurrentLink As String = "CurrentLink"
			 Public Const LanguagePreference As String = "LanguagePreference"
			 Public Const AdminAlertDate As String = "AdminAlertDate"
			 Public Const AdminAlertReason As String = "AdminAlertReason"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const FileNo As String = "FileNo"
			 Public Const PracticeCode As String = "PracticeCode"
			 Public Const Hazard As String = "Hazard"
			 Public Const DateStamp As String = "DateStamp"
			 Public Const Sender As String = "Sender"
			 Public Const RecipientName As String = "RecipientName"
			 Public Const RecipientEmail As String = "RecipientEmail"
			 Public Const Activity As String = "Activity"
			 Public Const LinkActive As String = "LinkActive"
			 Public Const LinkActivatedDate As String = "LinkActivatedDate"
			 Public Const LinkActivatedBy As String = "LinkActivatedBy"
			 Public Const LinkActivatedByEmail As String = "LinkActivatedByEmail"
			 Public Const ResponseActive As String = "ResponseActive"
			 Public Const ResponseLastActivity As String = "ResponseLastActivity"
			 Public Const Changed As String = "Changed"
			 Public Const RFU1Date As String = "RFU1Date"
			 Public Const RFU2Date As String = "RFU2Date"
			 Public Const RFU3Date As String = "RFU3Date"
			 Public Const RRLogGuid As String = "RRLogGuid"
			 Public Const CurrentLink As String = "CurrentLink"
			 Public Const LanguagePreference As String = "LanguagePreference"
			 Public Const AdminAlertDate As String = "AdminAlertDate"
			 Public Const AdminAlertReason As String = "AdminAlertReason"
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
			SyncLock GetType(ViewCCActiveRRLogMetadata)
			
				If ViewCCActiveRRLogMetadata.mapDelegates Is Nothing Then
					ViewCCActiveRRLogMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCActiveRRLogMetadata._meta Is Nothing Then
					ViewCCActiveRRLogMetadata._meta = New ViewCCActiveRRLogMetadata()
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
				meta.AddTypeMap("FilePrefix", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PracticeCode", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Hazard", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DateStamp", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Sender", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecipientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RecipientEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Activity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkActive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("LinkActivatedDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LinkActivatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkActivatedByEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ResponseActive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ResponseLastActivity", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Changed", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("RFU1Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU2Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RFU3Date", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("RRLogGuid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CurrentLink", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LanguagePreference", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AdminAlertDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("AdminAlertReason", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCActiveRRLog"
				meta.Destination = "viewCCActiveRRLog"
				
				meta.spInsert = "proc_viewCCActiveRRLogInsert"
				meta.spUpdate = "proc_viewCCActiveRRLogUpdate"
				meta.spDelete = "proc_viewCCActiveRRLogDelete"
				meta.spLoadAll = "proc_viewCCActiveRRLogLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCActiveRRLogLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCActiveRRLogMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
