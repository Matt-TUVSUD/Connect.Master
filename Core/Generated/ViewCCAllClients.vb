
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/14/2019 9:13:45 AM
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
	' Encapsulates the 'viewCCAllClients' view
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(ViewCCAllClients))> _
	<XmlType("ViewCCAllClients")> _	
	Partial Public Class ViewCCAllClients 
		Inherits esViewCCAllClients
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New ViewCCAllClients()
		End Function
		
		#Region "Static Quick Access Methods"
		
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ViewCCAllClientsCollection")> _
	Partial Public Class ViewCCAllClientsCollection
		Inherits esViewCCAllClientsCollection
		Implements IEnumerable(Of ViewCCAllClients)
	


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(ViewCCAllClients))> _
		Public Class ViewCCAllClientsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ViewCCAllClientsCollection)
			
			Public Shared Widening Operator CType(packet As ViewCCAllClientsCollectionWCFPacket) As ViewCCAllClientsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ViewCCAllClientsCollection) As ViewCCAllClientsCollectionWCFPacket
				Return New ViewCCAllClientsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ViewCCAllClientsQuery 
		Inherits esViewCCAllClientsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ViewCCAllClientsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ViewCCAllClientsQuery) As String
			Return ViewCCAllClientsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCAllClientsQuery
			Return DirectCast(ViewCCAllClientsQuery.SerializeHelper.FromXml(query, GetType(ViewCCAllClientsQuery)), ViewCCAllClientsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esViewCCAllClients
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to viewCCAllClients.fileprefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fileprefix As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.Fileprefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.Fileprefix, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Fileprefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.clientdesigneenotify
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientdesigneenotify As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneenotify)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneenotify, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Clientdesigneenotify)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.clientdesigneename
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientdesigneename As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneename)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneename, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Clientdesigneename)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.clientdesigneeemail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientdesigneeemail As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneeemail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneeemail, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Clientdesigneeemail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.580active
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _580active As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCAllClientsMetadata.ColumnNames._580active)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCAllClientsMetadata.ColumnNames._580active, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames._580active)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.recrespemail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recrespemail As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.Recrespemail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.Recrespemail, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recrespemail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.recautofollowup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recautofollowup As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCCAllClientsMetadata.ColumnNames.Recautofollowup)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ViewCCAllClientsMetadata.ColumnNames.Recautofollowup, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recautofollowup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.recfollowup1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recfollowup1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAllClientsMetadata.ColumnNames.Recfollowup1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAllClientsMetadata.ColumnNames.Recfollowup1, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recfollowup1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.recfollowup2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recfollowup2 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAllClientsMetadata.ColumnNames.Recfollowup2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAllClientsMetadata.ColumnNames.Recfollowup2, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recfollowup2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.recfollowup3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recfollowup3 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCCAllClientsMetadata.ColumnNames.Recfollowup3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ViewCCAllClientsMetadata.ColumnNames.Recfollowup3, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recfollowup3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.datatransfer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Datatransfer As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.Datatransfer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.Datatransfer, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Datatransfer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.timestamp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Timestamp As System.Byte()
			Get
				Return MyBase.GetSystemByteArray(ViewCCAllClientsMetadata.ColumnNames.Timestamp)
			End Get
			
			Set(ByVal value As System.Byte())
				If MyBase.SetSystemByteArray(ViewCCAllClientsMetadata.ColumnNames.Timestamp, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Timestamp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.AutoRecStartDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AutoRecStartDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCCAllClientsMetadata.ColumnNames.AutoRecStartDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ViewCCAllClientsMetadata.ColumnNames.AutoRecStartDate, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.AutoRecStartDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.AutoRecComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AutoRecComments As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.AutoRecComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.AutoRecComments, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.AutoRecComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.FireRatingKeyID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireRatingKeyID As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(ViewCCAllClientsMetadata.ColumnNames.FireRatingKeyID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(ViewCCAllClientsMetadata.ColumnNames.FireRatingKeyID, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.FireRatingKeyID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.BMRatingKeyID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMRatingKeyID As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(ViewCCAllClientsMetadata.ColumnNames.BMRatingKeyID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(ViewCCAllClientsMetadata.ColumnNames.BMRatingKeyID, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.BMRatingKeyID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.CustomAccessLabel
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccessLabel As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.CustomAccessLabel)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.CustomAccessLabel, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.CustomAccessLabel)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.WORecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WORecipientName As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.WORecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.WORecipientName, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.WORecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.WORecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WORecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.WORecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.WORecipientEmail, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.WORecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.WOSubject
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WOSubject As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.WOSubject)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.WOSubject, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.WOSubject)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.ExchangeRateGroupID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRateGroupID As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(ViewCCAllClientsMetadata.ColumnNames.ExchangeRateGroupID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(ViewCCAllClientsMetadata.ColumnNames.ExchangeRateGroupID, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.ExchangeRateGroupID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.features
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Features As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.Features)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.Features, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Features)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.Clientname
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientname As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.Clientname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.Clientname, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Clientname)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to viewCCAllClients.cldbname
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Cldbname As System.String
			Get
				Return MyBase.GetSystemString(ViewCCAllClientsMetadata.ColumnNames.Cldbname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ViewCCAllClientsMetadata.ColumnNames.Cldbname, value) Then
					OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Cldbname)
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
												
						Case "Fileprefix"
							Me.str().Fileprefix = CType(value, string)
												
						Case "Clientdesigneenotify"
							Me.str().Clientdesigneenotify = CType(value, string)
												
						Case "Clientdesigneename"
							Me.str().Clientdesigneename = CType(value, string)
												
						Case "Clientdesigneeemail"
							Me.str().Clientdesigneeemail = CType(value, string)
												
						Case "_580active"
							Me.str()._580active = CType(value, string)
												
						Case "Recrespemail"
							Me.str().Recrespemail = CType(value, string)
												
						Case "Recautofollowup"
							Me.str().Recautofollowup = CType(value, string)
												
						Case "Recfollowup1"
							Me.str().Recfollowup1 = CType(value, string)
												
						Case "Recfollowup2"
							Me.str().Recfollowup2 = CType(value, string)
												
						Case "Recfollowup3"
							Me.str().Recfollowup3 = CType(value, string)
												
						Case "Datatransfer"
							Me.str().Datatransfer = CType(value, string)
												
						Case "AutoRecStartDate"
							Me.str().AutoRecStartDate = CType(value, string)
												
						Case "AutoRecComments"
							Me.str().AutoRecComments = CType(value, string)
												
						Case "FireRatingKeyID"
							Me.str().FireRatingKeyID = CType(value, string)
												
						Case "BMRatingKeyID"
							Me.str().BMRatingKeyID = CType(value, string)
												
						Case "CustomAccessLabel"
							Me.str().CustomAccessLabel = CType(value, string)
												
						Case "WORecipientName"
							Me.str().WORecipientName = CType(value, string)
												
						Case "WORecipientEmail"
							Me.str().WORecipientEmail = CType(value, string)
												
						Case "WOSubject"
							Me.str().WOSubject = CType(value, string)
												
						Case "ExchangeRateGroupID"
							Me.str().ExchangeRateGroupID = CType(value, string)
												
						Case "Features"
							Me.str().Features = CType(value, string)
												
						Case "Clientname"
							Me.str().Clientname = CType(value, string)
												
						Case "Cldbname"
							Me.str().Cldbname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Clientdesigneenotify"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Clientdesigneenotify = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Clientdesigneenotify)
							End If
						
						Case "_580active"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me._580active = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames._580active)
							End If
						
						Case "Recautofollowup"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Recautofollowup = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recautofollowup)
							End If
						
						Case "Recfollowup1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recfollowup1 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recfollowup1)
							End If
						
						Case "Recfollowup2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recfollowup2 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recfollowup2)
							End If
						
						Case "Recfollowup3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recfollowup3 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Recfollowup3)
							End If
						
						Case "Timestamp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte()" Then
								Me.Timestamp = CType(value, System.Byte())
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.Timestamp)
							End If
						
						Case "AutoRecStartDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.AutoRecStartDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.AutoRecStartDate)
							End If
						
						Case "FireRatingKeyID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.FireRatingKeyID = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.FireRatingKeyID)
							End If
						
						Case "BMRatingKeyID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.BMRatingKeyID = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.BMRatingKeyID)
							End If
						
						Case "ExchangeRateGroupID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.ExchangeRateGroupID = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(ViewCCAllClientsMetadata.PropertyNames.ExchangeRateGroupID)
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
		
			Public Sub New(ByVal entity As esViewCCAllClients)
				Me.entity = entity
			End Sub				
		
	
			Public Property Fileprefix As System.String 
				Get
					Dim data_ As System.String = entity.Fileprefix
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fileprefix = Nothing
					Else
						entity.Fileprefix = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Clientdesigneenotify As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Clientdesigneenotify
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Clientdesigneenotify = Nothing
					Else
						entity.Clientdesigneenotify = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Clientdesigneename As System.String 
				Get
					Dim data_ As System.String = entity.Clientdesigneename
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Clientdesigneename = Nothing
					Else
						entity.Clientdesigneename = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Clientdesigneeemail As System.String 
				Get
					Dim data_ As System.String = entity.Clientdesigneeemail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Clientdesigneeemail = Nothing
					Else
						entity.Clientdesigneeemail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property _580active As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity._580active
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity._580active = Nothing
					Else
						entity._580active = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recrespemail As System.String 
				Get
					Dim data_ As System.String = entity.Recrespemail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recrespemail = Nothing
					Else
						entity.Recrespemail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recautofollowup As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Recautofollowup
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recautofollowup = Nothing
					Else
						entity.Recautofollowup = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recfollowup1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recfollowup1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recfollowup1 = Nothing
					Else
						entity.Recfollowup1 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recfollowup2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recfollowup2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recfollowup2 = Nothing
					Else
						entity.Recfollowup2 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recfollowup3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recfollowup3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recfollowup3 = Nothing
					Else
						entity.Recfollowup3 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datatransfer As System.String 
				Get
					Dim data_ As System.String = entity.Datatransfer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datatransfer = Nothing
					Else
						entity.Datatransfer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AutoRecStartDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.AutoRecStartDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AutoRecStartDate = Nothing
					Else
						entity.AutoRecStartDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property AutoRecComments As System.String 
				Get
					Dim data_ As System.String = entity.AutoRecComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AutoRecComments = Nothing
					Else
						entity.AutoRecComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FireRatingKeyID As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.FireRatingKeyID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FireRatingKeyID = Nothing
					Else
						entity.FireRatingKeyID = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property BMRatingKeyID As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.BMRatingKeyID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BMRatingKeyID = Nothing
					Else
						entity.BMRatingKeyID = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomAccessLabel As System.String 
				Get
					Dim data_ As System.String = entity.CustomAccessLabel
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomAccessLabel = Nothing
					Else
						entity.CustomAccessLabel = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WORecipientName As System.String 
				Get
					Dim data_ As System.String = entity.WORecipientName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WORecipientName = Nothing
					Else
						entity.WORecipientName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WORecipientEmail As System.String 
				Get
					Dim data_ As System.String = entity.WORecipientEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WORecipientEmail = Nothing
					Else
						entity.WORecipientEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WOSubject As System.String 
				Get
					Dim data_ As System.String = entity.WOSubject
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WOSubject = Nothing
					Else
						entity.WOSubject = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExchangeRateGroupID As System.String 
				Get
					Dim data_ As Nullable(Of System.Byte) = entity.ExchangeRateGroupID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExchangeRateGroupID = Nothing
					Else
						entity.ExchangeRateGroupID = Convert.ToByte(Value)
					End If
				End Set
			End Property
		  	
			Public Property Features As System.String 
				Get
					Dim data_ As System.String = entity.Features
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Features = Nothing
					Else
						entity.Features = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Clientname As System.String 
				Get
					Dim data_ As System.String = entity.Clientname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Clientname = Nothing
					Else
						entity.Clientname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Cldbname As System.String 
				Get
					Dim data_ As System.String = entity.Cldbname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Cldbname = Nothing
					Else
						entity.Cldbname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCCAllClients
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAllClientsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ViewCCAllClientsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAllClientsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ViewCCAllClientsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ViewCCAllClientsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCAllClientsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esViewCCAllClientsCollection
		Inherits esEntityCollection(Of ViewCCAllClients)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ViewCCAllClientsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ViewCCAllClientsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ViewCCAllClientsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ViewCCAllClientsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ViewCCAllClientsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ViewCCAllClientsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ViewCCAllClientsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ViewCCAllClientsQuery))
		End Sub
		
		#End Region
						
		Private m_query As ViewCCAllClientsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esViewCCAllClientsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCCAllClientsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Fileprefix" 
					Return Me.Fileprefix
				Case "Clientdesigneenotify" 
					Return Me.Clientdesigneenotify
				Case "Clientdesigneename" 
					Return Me.Clientdesigneename
				Case "Clientdesigneeemail" 
					Return Me.Clientdesigneeemail
				Case "_580active" 
					Return Me._580active
				Case "Recrespemail" 
					Return Me.Recrespemail
				Case "Recautofollowup" 
					Return Me.Recautofollowup
				Case "Recfollowup1" 
					Return Me.Recfollowup1
				Case "Recfollowup2" 
					Return Me.Recfollowup2
				Case "Recfollowup3" 
					Return Me.Recfollowup3
				Case "Datatransfer" 
					Return Me.Datatransfer
				Case "Timestamp" 
					Return Me.Timestamp
				Case "AutoRecStartDate" 
					Return Me.AutoRecStartDate
				Case "AutoRecComments" 
					Return Me.AutoRecComments
				Case "FireRatingKeyID" 
					Return Me.FireRatingKeyID
				Case "BMRatingKeyID" 
					Return Me.BMRatingKeyID
				Case "CustomAccessLabel" 
					Return Me.CustomAccessLabel
				Case "WORecipientName" 
					Return Me.WORecipientName
				Case "WORecipientEmail" 
					Return Me.WORecipientEmail
				Case "WOSubject" 
					Return Me.WOSubject
				Case "ExchangeRateGroupID" 
					Return Me.ExchangeRateGroupID
				Case "Features" 
					Return Me.Features
				Case "Clientname" 
					Return Me.Clientname
				Case "Cldbname" 
					Return Me.Cldbname
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Fileprefix As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Fileprefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Clientdesigneenotify As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Clientdesigneenotify, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Clientdesigneename As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Clientdesigneename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Clientdesigneeemail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Clientdesigneeemail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _580active As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames._580active, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Recrespemail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Recrespemail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recautofollowup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Recautofollowup, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Recfollowup1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Recfollowup1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Recfollowup2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Recfollowup2, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Recfollowup3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Recfollowup3, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Datatransfer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Datatransfer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Timestamp As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Timestamp, esSystemType.ByteArray)
			End Get
		End Property 
		
		Public ReadOnly Property AutoRecStartDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.AutoRecStartDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AutoRecComments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.AutoRecComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireRatingKeyID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.FireRatingKeyID, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property BMRatingKeyID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.BMRatingKeyID, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccessLabel As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.CustomAccessLabel, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WORecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.WORecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WORecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.WORecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WOSubject As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.WOSubject, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRateGroupID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.ExchangeRateGroupID, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property Features As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Features, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Clientname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Clientname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Cldbname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCCAllClientsMetadata.ColumnNames.Cldbname, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ViewCCAllClientsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Fileprefix, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Fileprefix
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneenotify, 1, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Clientdesigneenotify
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneename, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Clientdesigneename
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Clientdesigneeemail, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Clientdesigneeemail
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames._580active, 4, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames._580active
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Recrespemail, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Recrespemail
			c.CharacterMaxLength = 12
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Recautofollowup, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Recautofollowup
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Recfollowup1, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Recfollowup1
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Recfollowup2, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Recfollowup2
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Recfollowup3, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Recfollowup3
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Datatransfer, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Datatransfer
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Timestamp, 11, GetType(System.Byte()), esSystemType.ByteArray)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Timestamp
			c.CharacterMaxLength = 8
			c.IsComputed = True
			c.IsConcurrency = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.AutoRecStartDate, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.AutoRecStartDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.AutoRecComments, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.AutoRecComments
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.FireRatingKeyID, 14, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.FireRatingKeyID
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.BMRatingKeyID, 15, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.BMRatingKeyID
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.CustomAccessLabel, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.CustomAccessLabel
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.WORecipientName, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.WORecipientName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.WORecipientEmail, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.WORecipientEmail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.WOSubject, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.WOSubject
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.ExchangeRateGroupID, 20, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.ExchangeRateGroupID
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Features, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Features
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Clientname, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Clientname
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ViewCCAllClientsMetadata.ColumnNames.Cldbname, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCCAllClientsMetadata.PropertyNames.Cldbname
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ViewCCAllClientsMetadata
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
			 Public Const Fileprefix As String = "fileprefix"
			 Public Const Clientdesigneenotify As String = "clientdesigneenotify"
			 Public Const Clientdesigneename As String = "clientdesigneename"
			 Public Const Clientdesigneeemail As String = "clientdesigneeemail"
			 Public Const _580active As String = "580active"
			 Public Const Recrespemail As String = "recrespemail"
			 Public Const Recautofollowup As String = "recautofollowup"
			 Public Const Recfollowup1 As String = "recfollowup1"
			 Public Const Recfollowup2 As String = "recfollowup2"
			 Public Const Recfollowup3 As String = "recfollowup3"
			 Public Const Datatransfer As String = "datatransfer"
			 Public Const Timestamp As String = "timestamp"
			 Public Const AutoRecStartDate As String = "AutoRecStartDate"
			 Public Const AutoRecComments As String = "AutoRecComments"
			 Public Const FireRatingKeyID As String = "FireRatingKeyID"
			 Public Const BMRatingKeyID As String = "BMRatingKeyID"
			 Public Const CustomAccessLabel As String = "CustomAccessLabel"
			 Public Const WORecipientName As String = "WORecipientName"
			 Public Const WORecipientEmail As String = "WORecipientEmail"
			 Public Const WOSubject As String = "WOSubject"
			 Public Const ExchangeRateGroupID As String = "ExchangeRateGroupID"
			 Public Const Features As String = "features"
			 Public Const Clientname As String = "Clientname"
			 Public Const Cldbname As String = "cldbname"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Fileprefix As String = "Fileprefix"
			 Public Const Clientdesigneenotify As String = "Clientdesigneenotify"
			 Public Const Clientdesigneename As String = "Clientdesigneename"
			 Public Const Clientdesigneeemail As String = "Clientdesigneeemail"
			 Public Const _580active As String = "_580active"
			 Public Const Recrespemail As String = "Recrespemail"
			 Public Const Recautofollowup As String = "Recautofollowup"
			 Public Const Recfollowup1 As String = "Recfollowup1"
			 Public Const Recfollowup2 As String = "Recfollowup2"
			 Public Const Recfollowup3 As String = "Recfollowup3"
			 Public Const Datatransfer As String = "Datatransfer"
			 Public Const Timestamp As String = "Timestamp"
			 Public Const AutoRecStartDate As String = "AutoRecStartDate"
			 Public Const AutoRecComments As String = "AutoRecComments"
			 Public Const FireRatingKeyID As String = "FireRatingKeyID"
			 Public Const BMRatingKeyID As String = "BMRatingKeyID"
			 Public Const CustomAccessLabel As String = "CustomAccessLabel"
			 Public Const WORecipientName As String = "WORecipientName"
			 Public Const WORecipientEmail As String = "WORecipientEmail"
			 Public Const WOSubject As String = "WOSubject"
			 Public Const ExchangeRateGroupID As String = "ExchangeRateGroupID"
			 Public Const Features As String = "Features"
			 Public Const Clientname As String = "Clientname"
			 Public Const Cldbname As String = "Cldbname"
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
			SyncLock GetType(ViewCCAllClientsMetadata)
			
				If ViewCCAllClientsMetadata.mapDelegates Is Nothing Then
					ViewCCAllClientsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ViewCCAllClientsMetadata._meta Is Nothing Then
					ViewCCAllClientsMetadata._meta = New ViewCCAllClientsMetadata()
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
				


				meta.AddTypeMap("Fileprefix", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Clientdesigneenotify", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Clientdesigneename", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Clientdesigneeemail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("_580active", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Recrespemail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Recautofollowup", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Recfollowup1", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Recfollowup2", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Recfollowup3", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Datatransfer", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Timestamp", new esTypeMap("timestamp", "System.Byte()"))
				meta.AddTypeMap("AutoRecStartDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("AutoRecComments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FireRatingKeyID", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("BMRatingKeyID", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("CustomAccessLabel", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WORecipientName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WORecipientEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WOSubject", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ExchangeRateGroupID", new esTypeMap("tinyint", "System.Byte"))
				meta.AddTypeMap("Features", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Clientname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Cldbname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCCAllClients"
				meta.Destination = "viewCCAllClients"
				
				meta.spInsert = "proc_viewCCAllClientsInsert"
				meta.spUpdate = "proc_viewCCAllClientsUpdate"
				meta.spDelete = "proc_viewCCAllClientsDelete"
				meta.spLoadAll = "proc_viewCCAllClientsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCCAllClientsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ViewCCAllClientsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
