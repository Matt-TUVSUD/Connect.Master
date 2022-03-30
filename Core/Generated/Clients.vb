
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/14/2019 11:19:56 AM
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
	' Encapsulates the 'clients' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Clients))> _
	<XmlType("Clients")> _	
	Partial Public Class Clients 
		Inherits esClients
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Clients()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileprefix As System.String)
			Dim obj As New Clients()
			obj.Fileprefix = fileprefix
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileprefix As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Clients()
			obj.Fileprefix = fileprefix
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("ClientsCollection")> _
	Partial Public Class ClientsCollection
		Inherits esClientsCollection
		Implements IEnumerable(Of Clients)
	
		Public Function FindByPrimaryKey(ByVal fileprefix As System.String) As Clients
			Return MyBase.SingleOrDefault(Function(e) e.Fileprefix = fileprefix)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Clients))> _
		Public Class ClientsCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of ClientsCollection)
			
			Public Shared Widening Operator CType(packet As ClientsCollectionWCFPacket) As ClientsCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As ClientsCollection) As ClientsCollectionWCFPacket
				Return New ClientsCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class ClientsQuery 
		Inherits esClientsQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ClientsQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ClientsQuery) As String
			Return ClientsQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ClientsQuery
			Return DirectCast(ClientsQuery.SerializeHelper.FromXml(query, GetType(ClientsQuery)), ClientsQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esClients
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fileprefix As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileprefix)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileprefix)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fileprefix As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileprefix)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileprefix)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fileprefix As System.String) As Boolean
		
			Dim query As New ClientsQuery()
			query.Where(query.Fileprefix = fileprefix)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fileprefix As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Fileprefix", fileprefix)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to clients.cldbname
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Cldbname As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.Cldbname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.Cldbname, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Cldbname)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.clientname
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientname As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.Clientname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.Clientname, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Clientname)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.features
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Features As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.Features)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.Features, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Features)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.fileprefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fileprefix As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.Fileprefix)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.Fileprefix, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Fileprefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.clientdesigneenotify
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientdesigneenotify As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.Clientdesigneenotify)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.Clientdesigneenotify, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Clientdesigneenotify)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.clientdesigneename
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientdesigneename As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.Clientdesigneename)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.Clientdesigneename, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Clientdesigneename)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.clientdesigneeemail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Clientdesigneeemail As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.Clientdesigneeemail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.Clientdesigneeemail, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Clientdesigneeemail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.580active
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property _580active As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames._580active)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames._580active, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames._580active)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.recrespemail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recrespemail As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.Recrespemail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.Recrespemail, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Recrespemail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.recautofollowup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recautofollowup As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.Recautofollowup)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.Recautofollowup, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Recautofollowup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.recfollowup1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recfollowup1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.Recfollowup1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.Recfollowup1, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Recfollowup1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.recfollowup2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recfollowup2 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.Recfollowup2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.Recfollowup2, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Recfollowup2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.recfollowup3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recfollowup3 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.Recfollowup3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.Recfollowup3, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Recfollowup3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.datatransfer
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Datatransfer As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.Datatransfer)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.Datatransfer, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Datatransfer)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.timestamp
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Timestamp As System.Byte()
			Get
				Return MyBase.GetSystemByteArray(ClientsMetadata.ColumnNames.Timestamp)
			End Get
			
			Set(ByVal value As System.Byte())
				If MyBase.SetSystemByteArray(ClientsMetadata.ColumnNames.Timestamp, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Timestamp)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.AutoRecStartDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AutoRecStartDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.AutoRecStartDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.AutoRecStartDate, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.AutoRecStartDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.AutoRecComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AutoRecComments As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.AutoRecComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.AutoRecComments, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.AutoRecComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.FireRatingKeyID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FireRatingKeyID As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(ClientsMetadata.ColumnNames.FireRatingKeyID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(ClientsMetadata.ColumnNames.FireRatingKeyID, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.FireRatingKeyID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.BMRatingKeyID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property BMRatingKeyID As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(ClientsMetadata.ColumnNames.BMRatingKeyID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(ClientsMetadata.ColumnNames.BMRatingKeyID, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.BMRatingKeyID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.CustomAccessLabel
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccessLabel As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.CustomAccessLabel)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.CustomAccessLabel, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.CustomAccessLabel)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.WORecipientName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WORecipientName As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.WORecipientName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.WORecipientName, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.WORecipientName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.WORecipientEmail
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WORecipientEmail As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.WORecipientEmail)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.WORecipientEmail, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.WORecipientEmail)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.WOSubject
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property WOSubject As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.WOSubject)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.WOSubject, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.WOSubject)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ExchangeRateGroupID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ExchangeRateGroupID As Nullable(Of System.Byte)
			Get
				Return MyBase.GetSystemByte(ClientsMetadata.ColumnNames.ExchangeRateGroupID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Byte))
				If MyBase.SetSystemByte(ClientsMetadata.ColumnNames.ExchangeRateGroupID, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ExchangeRateGroupID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.AutoRecLastProcessDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property AutoRecLastProcessDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.AutoRecLastProcessDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.AutoRecLastProcessDate, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.AutoRecLastProcessDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.IFU
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ifu As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.Ifu)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.Ifu, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Ifu)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.PIFU1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pifu1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.Pifu1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.Pifu1, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Pifu1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.PIFU2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pifu2 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.Pifu2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.Pifu2, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Pifu2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.PIFU3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pifu3 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.Pifu3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.Pifu3, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Pifu3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.PIFU4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Pifu4 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.Pifu4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.Pifu4, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Pifu4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesName1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesName1 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName1, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesName1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesEmail1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesEmail1 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail1, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesEmail1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesName2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesName2 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName2, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesName2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesEmail2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesEmail2 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail2, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesEmail2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesName3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesName3 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName3, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesName3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesEmail3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesEmail3 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail3, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesEmail3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.AIFU
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Aifu As Nullable(Of System.Char)
			Get
				Return MyBase.GetSystemChar(ClientsMetadata.ColumnNames.Aifu)
			End Get
			
			Set(ByVal value As Nullable(Of System.Char))
				If MyBase.SetSystemChar(ClientsMetadata.ColumnNames.Aifu, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.Aifu)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesName4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesName4 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName4, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesName4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesEmail4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesEmail4 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail4, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesEmail4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesName5
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesName5 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName5)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesName5, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesName5)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpClientDesEmail5
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpClientDesEmail5 As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail5)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpClientDesEmail5, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpClientDesEmail5)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.MgmtARR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MgmtARR As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.MgmtARR)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.MgmtARR, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.MgmtARR)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpEmailAll
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpEmailAll As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.ImpEmailAll)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.ImpEmailAll, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpEmailAll)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SecurityPasswordExpireDays
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecurityPasswordExpireDays As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.SecurityPasswordExpireDays)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.SecurityPasswordExpireDays, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityPasswordExpireDays)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SecurityInactivityLockoutDays
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecurityInactivityLockoutDays As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.SecurityInactivityLockoutDays)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.SecurityInactivityLockoutDays, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityInactivityLockoutDays)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SecurityInactivityLockoutRemindDays
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecurityInactivityLockoutRemindDays As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.SecurityInactivityLockoutRemindDays)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.SecurityInactivityLockoutRemindDays, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityInactivityLockoutRemindDays)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SecurityPasswordMinimumLength
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecurityPasswordMinimumLength As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.SecurityPasswordMinimumLength)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.SecurityPasswordMinimumLength, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityPasswordMinimumLength)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SecurityPasswordTypeId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecurityPasswordTypeId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.SecurityPasswordTypeId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.SecurityPasswordTypeId, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityPasswordTypeId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferPackageId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferPackageId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.DataTransferPackageId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.DataTransferPackageId, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferPackageId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferPassword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferPassword As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferPassword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferPassword, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferPassword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferEncryptionKey
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferEncryptionKey As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferEncryptionKey)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferEncryptionKey, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferEncryptionKey)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SecurityAllowChangePassword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SecurityAllowChangePassword As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.SecurityAllowChangePassword)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.SecurityAllowChangePassword, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityAllowChangePassword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ReclassificationEmailSentDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReclassificationEmailSentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.ReclassificationEmailSentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.ReclassificationEmailSentDate, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ReclassificationEmailSentDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ReclassificationEmailFollowUpDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReclassificationEmailFollowUpDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.ReclassificationEmailFollowUpDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.ReclassificationEmailFollowUpDate, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ReclassificationEmailFollowUpDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ReclassificationCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReclassificationCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.ReclassificationCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.ReclassificationCompletionDate, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ReclassificationCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ReclassificationLinkGUID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ReclassificationLinkGUID As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ReclassificationLinkGUID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ReclassificationLinkGUID, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ReclassificationLinkGUID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.LastReclassificationCompletionDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LastReclassificationCompletionDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.LastReclassificationCompletionDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.LastReclassificationCompletionDate, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.LastReclassificationCompletionDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SysUserCreated
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SysUserCreated As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.SysUserCreated)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.SysUserCreated, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SysUserCreated)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SysDateCreated
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SysDateCreated As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.SysDateCreated)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.SysDateCreated, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SysDateCreated)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SysUserModified
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SysUserModified As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.SysUserModified)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.SysUserModified, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SysUserModified)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SysDateModified
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SysDateModified As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.SysDateModified)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.SysDateModified, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SysDateModified)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ClientId
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ClientId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.ClientId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.ClientId, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ClientId)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferPgpEnabled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferPgpEnabled As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.DataTransferPgpEnabled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.DataTransferPgpEnabled, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferPgpEnabled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferPgpPublicKey
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferPgpPublicKey As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferPgpPublicKey)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferPgpPublicKey, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferPgpPublicKey)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferFtpUrl
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferFtpUrl As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpUrl)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpUrl, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFtpUrl)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferFtpUserName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferFtpUserName As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpUserName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpUserName, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFtpUserName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferFtpPassword
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferFtpPassword As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpPassword)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpPassword, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFtpPassword)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferPgpFileExtension
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferPgpFileExtension As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferPgpFileExtension)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferPgpFileExtension, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferPgpFileExtension)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferFtpEnabled
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferFtpEnabled As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.DataTransferFtpEnabled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.DataTransferFtpEnabled, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFtpEnabled)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferRetrievalDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferRetrievalDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ClientsMetadata.ColumnNames.DataTransferRetrievalDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ClientsMetadata.ColumnNames.DataTransferRetrievalDate, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferRetrievalDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DefaultMetaCurrencyID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DefaultMetaCurrencyID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ClientsMetadata.ColumnNames.DefaultMetaCurrencyID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ClientsMetadata.ColumnNames.DefaultMetaCurrencyID, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DefaultMetaCurrencyID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ARRRolloutOption
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARRRolloutOption As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ARRRolloutOption)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ARRRolloutOption, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ARRRolloutOption)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ARRRolloutOptionDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARRRolloutOptionDesc As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ARRRolloutOptionDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ARRRolloutOptionDesc, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ARRRolloutOptionDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpairmentStatus
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpairmentStatus As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.ImpairmentStatus)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.ImpairmentStatus, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpairmentStatus)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpairmentSpecialHandling
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpairmentSpecialHandling As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ClientsMetadata.ColumnNames.ImpairmentSpecialHandling)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ClientsMetadata.ColumnNames.ImpairmentSpecialHandling, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpairmentSpecialHandling)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.ImpairmentSpecialHandlingDesc
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ImpairmentSpecialHandlingDesc As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.ImpairmentSpecialHandlingDesc)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.ImpairmentSpecialHandlingDesc, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.ImpairmentSpecialHandlingDesc)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferFtpLocalFolder
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferFtpLocalFolder As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpLocalFolder)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpLocalFolder, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFtpLocalFolder)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferFileNameFormatString
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferFileNameFormatString As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferFileNameFormatString)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferFileNameFormatString, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFileNameFormatString)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferFtpMonthJson
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferFtpMonthJson As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpMonthJson)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpMonthJson, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFtpMonthJson)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.DataTransferFtpDayJson
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DataTransferFtpDayJson As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpDayJson)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.DataTransferFtpDayJson, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFtpDayJson)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.IndustryGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property IndustryGroup As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.IndustryGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.IndustryGroup, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.IndustryGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.MajorGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MajorGroup As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.MajorGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.MajorGroup, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.MajorGroup)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to clients.SpecificGroup
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SpecificGroup As System.String
			Get
				Return MyBase.GetSystemString(ClientsMetadata.ColumnNames.SpecificGroup)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ClientsMetadata.ColumnNames.SpecificGroup, value) Then
					OnPropertyChanged(ClientsMetadata.PropertyNames.SpecificGroup)
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
												
						Case "Cldbname"
							Me.str().Cldbname = CType(value, string)
												
						Case "Clientname"
							Me.str().Clientname = CType(value, string)
												
						Case "Features"
							Me.str().Features = CType(value, string)
												
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
												
						Case "AutoRecLastProcessDate"
							Me.str().AutoRecLastProcessDate = CType(value, string)
												
						Case "Ifu"
							Me.str().Ifu = CType(value, string)
												
						Case "Pifu1"
							Me.str().Pifu1 = CType(value, string)
												
						Case "Pifu2"
							Me.str().Pifu2 = CType(value, string)
												
						Case "Pifu3"
							Me.str().Pifu3 = CType(value, string)
												
						Case "Pifu4"
							Me.str().Pifu4 = CType(value, string)
												
						Case "ImpClientDesName1"
							Me.str().ImpClientDesName1 = CType(value, string)
												
						Case "ImpClientDesEmail1"
							Me.str().ImpClientDesEmail1 = CType(value, string)
												
						Case "ImpClientDesName2"
							Me.str().ImpClientDesName2 = CType(value, string)
												
						Case "ImpClientDesEmail2"
							Me.str().ImpClientDesEmail2 = CType(value, string)
												
						Case "ImpClientDesName3"
							Me.str().ImpClientDesName3 = CType(value, string)
												
						Case "ImpClientDesEmail3"
							Me.str().ImpClientDesEmail3 = CType(value, string)
												
						Case "Aifu"
							Me.str().Aifu = CType(value, string)
												
						Case "ImpClientDesName4"
							Me.str().ImpClientDesName4 = CType(value, string)
												
						Case "ImpClientDesEmail4"
							Me.str().ImpClientDesEmail4 = CType(value, string)
												
						Case "ImpClientDesName5"
							Me.str().ImpClientDesName5 = CType(value, string)
												
						Case "ImpClientDesEmail5"
							Me.str().ImpClientDesEmail5 = CType(value, string)
												
						Case "MgmtARR"
							Me.str().MgmtARR = CType(value, string)
												
						Case "ImpEmailAll"
							Me.str().ImpEmailAll = CType(value, string)
												
						Case "SecurityPasswordExpireDays"
							Me.str().SecurityPasswordExpireDays = CType(value, string)
												
						Case "SecurityInactivityLockoutDays"
							Me.str().SecurityInactivityLockoutDays = CType(value, string)
												
						Case "SecurityInactivityLockoutRemindDays"
							Me.str().SecurityInactivityLockoutRemindDays = CType(value, string)
												
						Case "SecurityPasswordMinimumLength"
							Me.str().SecurityPasswordMinimumLength = CType(value, string)
												
						Case "SecurityPasswordTypeId"
							Me.str().SecurityPasswordTypeId = CType(value, string)
												
						Case "DataTransferPackageId"
							Me.str().DataTransferPackageId = CType(value, string)
												
						Case "DataTransferPassword"
							Me.str().DataTransferPassword = CType(value, string)
												
						Case "DataTransferEncryptionKey"
							Me.str().DataTransferEncryptionKey = CType(value, string)
												
						Case "SecurityAllowChangePassword"
							Me.str().SecurityAllowChangePassword = CType(value, string)
												
						Case "ReclassificationEmailSentDate"
							Me.str().ReclassificationEmailSentDate = CType(value, string)
												
						Case "ReclassificationEmailFollowUpDate"
							Me.str().ReclassificationEmailFollowUpDate = CType(value, string)
												
						Case "ReclassificationCompletionDate"
							Me.str().ReclassificationCompletionDate = CType(value, string)
												
						Case "ReclassificationLinkGUID"
							Me.str().ReclassificationLinkGUID = CType(value, string)
												
						Case "LastReclassificationCompletionDate"
							Me.str().LastReclassificationCompletionDate = CType(value, string)
												
						Case "SysUserCreated"
							Me.str().SysUserCreated = CType(value, string)
												
						Case "SysDateCreated"
							Me.str().SysDateCreated = CType(value, string)
												
						Case "SysUserModified"
							Me.str().SysUserModified = CType(value, string)
												
						Case "SysDateModified"
							Me.str().SysDateModified = CType(value, string)
												
						Case "ClientId"
							Me.str().ClientId = CType(value, string)
												
						Case "DataTransferPgpEnabled"
							Me.str().DataTransferPgpEnabled = CType(value, string)
												
						Case "DataTransferPgpPublicKey"
							Me.str().DataTransferPgpPublicKey = CType(value, string)
												
						Case "DataTransferFtpUrl"
							Me.str().DataTransferFtpUrl = CType(value, string)
												
						Case "DataTransferFtpUserName"
							Me.str().DataTransferFtpUserName = CType(value, string)
												
						Case "DataTransferFtpPassword"
							Me.str().DataTransferFtpPassword = CType(value, string)
												
						Case "DataTransferPgpFileExtension"
							Me.str().DataTransferPgpFileExtension = CType(value, string)
												
						Case "DataTransferFtpEnabled"
							Me.str().DataTransferFtpEnabled = CType(value, string)
												
						Case "DataTransferRetrievalDate"
							Me.str().DataTransferRetrievalDate = CType(value, string)
												
						Case "DefaultMetaCurrencyID"
							Me.str().DefaultMetaCurrencyID = CType(value, string)
												
						Case "ARRRolloutOption"
							Me.str().ARRRolloutOption = CType(value, string)
												
						Case "ARRRolloutOptionDesc"
							Me.str().ARRRolloutOptionDesc = CType(value, string)
												
						Case "ImpairmentStatus"
							Me.str().ImpairmentStatus = CType(value, string)
												
						Case "ImpairmentSpecialHandling"
							Me.str().ImpairmentSpecialHandling = CType(value, string)
												
						Case "ImpairmentSpecialHandlingDesc"
							Me.str().ImpairmentSpecialHandlingDesc = CType(value, string)
												
						Case "DataTransferFtpLocalFolder"
							Me.str().DataTransferFtpLocalFolder = CType(value, string)
												
						Case "DataTransferFileNameFormatString"
							Me.str().DataTransferFileNameFormatString = CType(value, string)
												
						Case "DataTransferFtpMonthJson"
							Me.str().DataTransferFtpMonthJson = CType(value, string)
												
						Case "DataTransferFtpDayJson"
							Me.str().DataTransferFtpDayJson = CType(value, string)
												
						Case "IndustryGroup"
							Me.str().IndustryGroup = CType(value, string)
												
						Case "MajorGroup"
							Me.str().MajorGroup = CType(value, string)
												
						Case "SpecificGroup"
							Me.str().SpecificGroup = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Clientdesigneenotify"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Clientdesigneenotify = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Clientdesigneenotify)
							End If
						
						Case "_580active"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me._580active = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames._580active)
							End If
						
						Case "Recautofollowup"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Recautofollowup = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Recautofollowup)
							End If
						
						Case "Recfollowup1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recfollowup1 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Recfollowup1)
							End If
						
						Case "Recfollowup2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recfollowup2 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Recfollowup2)
							End If
						
						Case "Recfollowup3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recfollowup3 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Recfollowup3)
							End If
						
						Case "Timestamp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte()" Then
								Me.Timestamp = CType(value, System.Byte())
								OnPropertyChanged(ClientsMetadata.PropertyNames.Timestamp)
							End If
						
						Case "AutoRecStartDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.AutoRecStartDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.AutoRecStartDate)
							End If
						
						Case "FireRatingKeyID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.FireRatingKeyID = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(ClientsMetadata.PropertyNames.FireRatingKeyID)
							End If
						
						Case "BMRatingKeyID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.BMRatingKeyID = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(ClientsMetadata.PropertyNames.BMRatingKeyID)
							End If
						
						Case "ExchangeRateGroupID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte" Then
								Me.ExchangeRateGroupID = CType(value, Nullable(Of System.Byte))
								OnPropertyChanged(ClientsMetadata.PropertyNames.ExchangeRateGroupID)
							End If
						
						Case "AutoRecLastProcessDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.AutoRecLastProcessDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.AutoRecLastProcessDate)
							End If
						
						Case "Ifu"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Ifu = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Ifu)
							End If
						
						Case "Pifu1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pifu1 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Pifu1)
							End If
						
						Case "Pifu2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pifu2 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Pifu2)
							End If
						
						Case "Pifu3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pifu3 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Pifu3)
							End If
						
						Case "Pifu4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pifu4 = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Pifu4)
							End If
						
						Case "Aifu"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Char" Then
								Me.Aifu = CType(value, Nullable(Of System.Char))
								OnPropertyChanged(ClientsMetadata.PropertyNames.Aifu)
							End If
						
						Case "MgmtARR"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.MgmtARR = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.MgmtARR)
							End If
						
						Case "ImpEmailAll"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ImpEmailAll = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.ImpEmailAll)
							End If
						
						Case "SecurityPasswordExpireDays"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecurityPasswordExpireDays = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityPasswordExpireDays)
							End If
						
						Case "SecurityInactivityLockoutDays"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecurityInactivityLockoutDays = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityInactivityLockoutDays)
							End If
						
						Case "SecurityInactivityLockoutRemindDays"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecurityInactivityLockoutRemindDays = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityInactivityLockoutRemindDays)
							End If
						
						Case "SecurityPasswordMinimumLength"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecurityPasswordMinimumLength = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityPasswordMinimumLength)
							End If
						
						Case "SecurityPasswordTypeId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SecurityPasswordTypeId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityPasswordTypeId)
							End If
						
						Case "DataTransferPackageId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DataTransferPackageId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferPackageId)
							End If
						
						Case "SecurityAllowChangePassword"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.SecurityAllowChangePassword = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.SecurityAllowChangePassword)
							End If
						
						Case "ReclassificationEmailSentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ReclassificationEmailSentDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.ReclassificationEmailSentDate)
							End If
						
						Case "ReclassificationEmailFollowUpDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ReclassificationEmailFollowUpDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.ReclassificationEmailFollowUpDate)
							End If
						
						Case "ReclassificationCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ReclassificationCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.ReclassificationCompletionDate)
							End If
						
						Case "LastReclassificationCompletionDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastReclassificationCompletionDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.LastReclassificationCompletionDate)
							End If
						
						Case "SysDateCreated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SysDateCreated = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.SysDateCreated)
							End If
						
						Case "SysDateModified"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SysDateModified = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.SysDateModified)
							End If
						
						Case "ClientId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ClientId = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.ClientId)
							End If
						
						Case "DataTransferPgpEnabled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.DataTransferPgpEnabled = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferPgpEnabled)
							End If
						
						Case "DataTransferFtpEnabled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.DataTransferFtpEnabled = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferFtpEnabled)
							End If
						
						Case "DataTransferRetrievalDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DataTransferRetrievalDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(ClientsMetadata.PropertyNames.DataTransferRetrievalDate)
							End If
						
						Case "DefaultMetaCurrencyID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DefaultMetaCurrencyID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(ClientsMetadata.PropertyNames.DefaultMetaCurrencyID)
							End If
						
						Case "ImpairmentStatus"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ImpairmentStatus = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.ImpairmentStatus)
							End If
						
						Case "ImpairmentSpecialHandling"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.ImpairmentSpecialHandling = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(ClientsMetadata.PropertyNames.ImpairmentSpecialHandling)
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
		
			Public Sub New(ByVal entity As esClients)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property AutoRecLastProcessDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.AutoRecLastProcessDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AutoRecLastProcessDate = Nothing
					Else
						entity.AutoRecLastProcessDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ifu As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Ifu
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ifu = Nothing
					Else
						entity.Ifu = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pifu1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pifu1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pifu1 = Nothing
					Else
						entity.Pifu1 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pifu2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pifu2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pifu2 = Nothing
					Else
						entity.Pifu2 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pifu3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pifu3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pifu3 = Nothing
					Else
						entity.Pifu3 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pifu4 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pifu4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pifu4 = Nothing
					Else
						entity.Pifu4 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesName1 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesName1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesName1 = Nothing
					Else
						entity.ImpClientDesName1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesEmail1 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesEmail1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesEmail1 = Nothing
					Else
						entity.ImpClientDesEmail1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesName2 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesName2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesName2 = Nothing
					Else
						entity.ImpClientDesName2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesEmail2 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesEmail2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesEmail2 = Nothing
					Else
						entity.ImpClientDesEmail2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesName3 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesName3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesName3 = Nothing
					Else
						entity.ImpClientDesName3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesEmail3 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesEmail3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesEmail3 = Nothing
					Else
						entity.ImpClientDesEmail3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Aifu As System.String 
				Get
					Dim data_ As Nullable(Of System.Char) = entity.Aifu
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Aifu = Nothing
					Else
						entity.Aifu = Convert.ToChar(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesName4 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesName4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesName4 = Nothing
					Else
						entity.ImpClientDesName4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesEmail4 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesEmail4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesEmail4 = Nothing
					Else
						entity.ImpClientDesEmail4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesName5 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesName5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesName5 = Nothing
					Else
						entity.ImpClientDesName5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpClientDesEmail5 As System.String 
				Get
					Dim data_ As System.String = entity.ImpClientDesEmail5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpClientDesEmail5 = Nothing
					Else
						entity.ImpClientDesEmail5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MgmtARR As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.MgmtARR
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MgmtARR = Nothing
					Else
						entity.MgmtARR = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpEmailAll As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ImpEmailAll
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpEmailAll = Nothing
					Else
						entity.ImpEmailAll = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecurityPasswordExpireDays As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SecurityPasswordExpireDays
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecurityPasswordExpireDays = Nothing
					Else
						entity.SecurityPasswordExpireDays = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecurityInactivityLockoutDays As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SecurityInactivityLockoutDays
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecurityInactivityLockoutDays = Nothing
					Else
						entity.SecurityInactivityLockoutDays = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecurityInactivityLockoutRemindDays As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SecurityInactivityLockoutRemindDays
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecurityInactivityLockoutRemindDays = Nothing
					Else
						entity.SecurityInactivityLockoutRemindDays = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecurityPasswordMinimumLength As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SecurityPasswordMinimumLength
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecurityPasswordMinimumLength = Nothing
					Else
						entity.SecurityPasswordMinimumLength = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecurityPasswordTypeId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SecurityPasswordTypeId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecurityPasswordTypeId = Nothing
					Else
						entity.SecurityPasswordTypeId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferPackageId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.DataTransferPackageId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferPackageId = Nothing
					Else
						entity.DataTransferPackageId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferPassword As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferPassword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferPassword = Nothing
					Else
						entity.DataTransferPassword = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferEncryptionKey As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferEncryptionKey
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferEncryptionKey = Nothing
					Else
						entity.DataTransferEncryptionKey = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SecurityAllowChangePassword As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.SecurityAllowChangePassword
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SecurityAllowChangePassword = Nothing
					Else
						entity.SecurityAllowChangePassword = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReclassificationEmailSentDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ReclassificationEmailSentDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReclassificationEmailSentDate = Nothing
					Else
						entity.ReclassificationEmailSentDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReclassificationEmailFollowUpDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ReclassificationEmailFollowUpDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReclassificationEmailFollowUpDate = Nothing
					Else
						entity.ReclassificationEmailFollowUpDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReclassificationCompletionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ReclassificationCompletionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReclassificationCompletionDate = Nothing
					Else
						entity.ReclassificationCompletionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReclassificationLinkGUID As System.String 
				Get
					Dim data_ As System.String = entity.ReclassificationLinkGUID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReclassificationLinkGUID = Nothing
					Else
						entity.ReclassificationLinkGUID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastReclassificationCompletionDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastReclassificationCompletionDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastReclassificationCompletionDate = Nothing
					Else
						entity.LastReclassificationCompletionDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property SysUserCreated As System.String 
				Get
					Dim data_ As System.String = entity.SysUserCreated
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SysUserCreated = Nothing
					Else
						entity.SysUserCreated = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SysDateCreated As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SysDateCreated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SysDateCreated = Nothing
					Else
						entity.SysDateCreated = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property SysUserModified As System.String 
				Get
					Dim data_ As System.String = entity.SysUserModified
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SysUserModified = Nothing
					Else
						entity.SysUserModified = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SysDateModified As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SysDateModified
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SysDateModified = Nothing
					Else
						entity.SysDateModified = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ClientId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ClientId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClientId = Nothing
					Else
						entity.ClientId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferPgpEnabled As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.DataTransferPgpEnabled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferPgpEnabled = Nothing
					Else
						entity.DataTransferPgpEnabled = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferPgpPublicKey As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferPgpPublicKey
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferPgpPublicKey = Nothing
					Else
						entity.DataTransferPgpPublicKey = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferFtpUrl As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferFtpUrl
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferFtpUrl = Nothing
					Else
						entity.DataTransferFtpUrl = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferFtpUserName As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferFtpUserName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferFtpUserName = Nothing
					Else
						entity.DataTransferFtpUserName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferFtpPassword As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferFtpPassword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferFtpPassword = Nothing
					Else
						entity.DataTransferFtpPassword = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferPgpFileExtension As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferPgpFileExtension
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferPgpFileExtension = Nothing
					Else
						entity.DataTransferPgpFileExtension = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferFtpEnabled As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.DataTransferFtpEnabled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferFtpEnabled = Nothing
					Else
						entity.DataTransferFtpEnabled = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferRetrievalDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DataTransferRetrievalDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferRetrievalDate = Nothing
					Else
						entity.DataTransferRetrievalDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property DefaultMetaCurrencyID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.DefaultMetaCurrencyID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DefaultMetaCurrencyID = Nothing
					Else
						entity.DefaultMetaCurrencyID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ARRRolloutOption As System.String 
				Get
					Dim data_ As System.String = entity.ARRRolloutOption
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ARRRolloutOption = Nothing
					Else
						entity.ARRRolloutOption = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ARRRolloutOptionDesc As System.String 
				Get
					Dim data_ As System.String = entity.ARRRolloutOptionDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ARRRolloutOptionDesc = Nothing
					Else
						entity.ARRRolloutOptionDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpairmentStatus As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ImpairmentStatus
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpairmentStatus = Nothing
					Else
						entity.ImpairmentStatus = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpairmentSpecialHandling As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.ImpairmentSpecialHandling
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpairmentSpecialHandling = Nothing
					Else
						entity.ImpairmentSpecialHandling = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImpairmentSpecialHandlingDesc As System.String 
				Get
					Dim data_ As System.String = entity.ImpairmentSpecialHandlingDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImpairmentSpecialHandlingDesc = Nothing
					Else
						entity.ImpairmentSpecialHandlingDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferFtpLocalFolder As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferFtpLocalFolder
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferFtpLocalFolder = Nothing
					Else
						entity.DataTransferFtpLocalFolder = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferFileNameFormatString As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferFileNameFormatString
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferFileNameFormatString = Nothing
					Else
						entity.DataTransferFileNameFormatString = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferFtpMonthJson As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferFtpMonthJson
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferFtpMonthJson = Nothing
					Else
						entity.DataTransferFtpMonthJson = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DataTransferFtpDayJson As System.String 
				Get
					Dim data_ As System.String = entity.DataTransferFtpDayJson
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DataTransferFtpDayJson = Nothing
					Else
						entity.DataTransferFtpDayJson = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IndustryGroup As System.String 
				Get
					Dim data_ As System.String = entity.IndustryGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IndustryGroup = Nothing
					Else
						entity.IndustryGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MajorGroup As System.String 
				Get
					Dim data_ As System.String = entity.MajorGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MajorGroup = Nothing
					Else
						entity.MajorGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SpecificGroup As System.String 
				Get
					Dim data_ As System.String = entity.SpecificGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SpecificGroup = Nothing
					Else
						entity.SpecificGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esClients
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ClientsMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ClientsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ClientsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ClientsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ClientsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ClientsQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esClientsCollection
		Inherits esEntityCollection(Of Clients)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ClientsMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ClientsCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ClientsQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ClientsQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ClientsQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ClientsQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ClientsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ClientsQuery))
		End Sub
		
		#End Region
						
		Private m_query As ClientsQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esClientsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ClientsMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Cldbname" 
					Return Me.Cldbname
				Case "Clientname" 
					Return Me.Clientname
				Case "Features" 
					Return Me.Features
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
				Case "AutoRecLastProcessDate" 
					Return Me.AutoRecLastProcessDate
				Case "Ifu" 
					Return Me.Ifu
				Case "Pifu1" 
					Return Me.Pifu1
				Case "Pifu2" 
					Return Me.Pifu2
				Case "Pifu3" 
					Return Me.Pifu3
				Case "Pifu4" 
					Return Me.Pifu4
				Case "ImpClientDesName1" 
					Return Me.ImpClientDesName1
				Case "ImpClientDesEmail1" 
					Return Me.ImpClientDesEmail1
				Case "ImpClientDesName2" 
					Return Me.ImpClientDesName2
				Case "ImpClientDesEmail2" 
					Return Me.ImpClientDesEmail2
				Case "ImpClientDesName3" 
					Return Me.ImpClientDesName3
				Case "ImpClientDesEmail3" 
					Return Me.ImpClientDesEmail3
				Case "Aifu" 
					Return Me.Aifu
				Case "ImpClientDesName4" 
					Return Me.ImpClientDesName4
				Case "ImpClientDesEmail4" 
					Return Me.ImpClientDesEmail4
				Case "ImpClientDesName5" 
					Return Me.ImpClientDesName5
				Case "ImpClientDesEmail5" 
					Return Me.ImpClientDesEmail5
				Case "MgmtARR" 
					Return Me.MgmtARR
				Case "ImpEmailAll" 
					Return Me.ImpEmailAll
				Case "SecurityPasswordExpireDays" 
					Return Me.SecurityPasswordExpireDays
				Case "SecurityInactivityLockoutDays" 
					Return Me.SecurityInactivityLockoutDays
				Case "SecurityInactivityLockoutRemindDays" 
					Return Me.SecurityInactivityLockoutRemindDays
				Case "SecurityPasswordMinimumLength" 
					Return Me.SecurityPasswordMinimumLength
				Case "SecurityPasswordTypeId" 
					Return Me.SecurityPasswordTypeId
				Case "DataTransferPackageId" 
					Return Me.DataTransferPackageId
				Case "DataTransferPassword" 
					Return Me.DataTransferPassword
				Case "DataTransferEncryptionKey" 
					Return Me.DataTransferEncryptionKey
				Case "SecurityAllowChangePassword" 
					Return Me.SecurityAllowChangePassword
				Case "ReclassificationEmailSentDate" 
					Return Me.ReclassificationEmailSentDate
				Case "ReclassificationEmailFollowUpDate" 
					Return Me.ReclassificationEmailFollowUpDate
				Case "ReclassificationCompletionDate" 
					Return Me.ReclassificationCompletionDate
				Case "ReclassificationLinkGUID" 
					Return Me.ReclassificationLinkGUID
				Case "LastReclassificationCompletionDate" 
					Return Me.LastReclassificationCompletionDate
				Case "SysUserCreated" 
					Return Me.SysUserCreated
				Case "SysDateCreated" 
					Return Me.SysDateCreated
				Case "SysUserModified" 
					Return Me.SysUserModified
				Case "SysDateModified" 
					Return Me.SysDateModified
				Case "ClientId" 
					Return Me.ClientId
				Case "DataTransferPgpEnabled" 
					Return Me.DataTransferPgpEnabled
				Case "DataTransferPgpPublicKey" 
					Return Me.DataTransferPgpPublicKey
				Case "DataTransferFtpUrl" 
					Return Me.DataTransferFtpUrl
				Case "DataTransferFtpUserName" 
					Return Me.DataTransferFtpUserName
				Case "DataTransferFtpPassword" 
					Return Me.DataTransferFtpPassword
				Case "DataTransferPgpFileExtension" 
					Return Me.DataTransferPgpFileExtension
				Case "DataTransferFtpEnabled" 
					Return Me.DataTransferFtpEnabled
				Case "DataTransferRetrievalDate" 
					Return Me.DataTransferRetrievalDate
				Case "DefaultMetaCurrencyID" 
					Return Me.DefaultMetaCurrencyID
				Case "ARRRolloutOption" 
					Return Me.ARRRolloutOption
				Case "ARRRolloutOptionDesc" 
					Return Me.ARRRolloutOptionDesc
				Case "ImpairmentStatus" 
					Return Me.ImpairmentStatus
				Case "ImpairmentSpecialHandling" 
					Return Me.ImpairmentSpecialHandling
				Case "ImpairmentSpecialHandlingDesc" 
					Return Me.ImpairmentSpecialHandlingDesc
				Case "DataTransferFtpLocalFolder" 
					Return Me.DataTransferFtpLocalFolder
				Case "DataTransferFileNameFormatString" 
					Return Me.DataTransferFileNameFormatString
				Case "DataTransferFtpMonthJson" 
					Return Me.DataTransferFtpMonthJson
				Case "DataTransferFtpDayJson" 
					Return Me.DataTransferFtpDayJson
				Case "IndustryGroup" 
					Return Me.IndustryGroup
				Case "MajorGroup" 
					Return Me.MajorGroup
				Case "SpecificGroup" 
					Return Me.SpecificGroup
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Cldbname As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Cldbname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Clientname As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Clientname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Features As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Features, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fileprefix As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Fileprefix, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Clientdesigneenotify As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Clientdesigneenotify, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Clientdesigneename As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Clientdesigneename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Clientdesigneeemail As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Clientdesigneeemail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property _580active As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames._580active, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Recrespemail As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Recrespemail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recautofollowup As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Recautofollowup, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Recfollowup1 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Recfollowup1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Recfollowup2 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Recfollowup2, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Recfollowup3 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Recfollowup3, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Datatransfer As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Datatransfer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Timestamp As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Timestamp, esSystemType.ByteArray)
			End Get
		End Property 
		
		Public ReadOnly Property AutoRecStartDate As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.AutoRecStartDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AutoRecComments As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.AutoRecComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FireRatingKeyID As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.FireRatingKeyID, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property BMRatingKeyID As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.BMRatingKeyID, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccessLabel As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.CustomAccessLabel, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WORecipientName As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.WORecipientName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WORecipientEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.WORecipientEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WOSubject As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.WOSubject, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ExchangeRateGroupID As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ExchangeRateGroupID, esSystemType.Byte)
			End Get
		End Property 
		
		Public ReadOnly Property AutoRecLastProcessDate As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.AutoRecLastProcessDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Ifu As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Ifu, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Pifu1 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Pifu1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pifu2 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Pifu2, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pifu3 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Pifu3, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pifu4 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Pifu4, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesName1 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesName1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesEmail1 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesEmail1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesName2 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesName2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesEmail2 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesEmail2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesName3 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesName3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesEmail3 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesEmail3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Aifu As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.Aifu, esSystemType.Char)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesName4 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesName4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesEmail4 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesEmail4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesName5 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesName5, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpClientDesEmail5 As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpClientDesEmail5, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MgmtARR As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.MgmtARR, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ImpEmailAll As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpEmailAll, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property SecurityPasswordExpireDays As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SecurityPasswordExpireDays, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SecurityInactivityLockoutDays As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SecurityInactivityLockoutDays, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SecurityInactivityLockoutRemindDays As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SecurityInactivityLockoutRemindDays, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SecurityPasswordMinimumLength As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SecurityPasswordMinimumLength, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SecurityPasswordTypeId As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SecurityPasswordTypeId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferPackageId As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferPackageId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferPassword As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferPassword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferEncryptionKey As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferEncryptionKey, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SecurityAllowChangePassword As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SecurityAllowChangePassword, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ReclassificationEmailSentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ReclassificationEmailSentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ReclassificationEmailFollowUpDate As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ReclassificationEmailFollowUpDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ReclassificationCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ReclassificationCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ReclassificationLinkGUID As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ReclassificationLinkGUID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastReclassificationCompletionDate As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.LastReclassificationCompletionDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SysUserCreated As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SysUserCreated, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SysDateCreated As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SysDateCreated, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property SysUserModified As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SysUserModified, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SysDateModified As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SysDateModified, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ClientId As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ClientId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferPgpEnabled As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferPgpEnabled, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferPgpPublicKey As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferPgpPublicKey, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferFtpUrl As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferFtpUrl, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferFtpUserName As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferFtpUserName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferFtpPassword As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferFtpPassword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferPgpFileExtension As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferPgpFileExtension, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferFtpEnabled As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferFtpEnabled, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferRetrievalDate As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferRetrievalDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property DefaultMetaCurrencyID As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DefaultMetaCurrencyID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ARRRolloutOption As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ARRRolloutOption, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ARRRolloutOptionDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ARRRolloutOptionDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImpairmentStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpairmentStatus, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ImpairmentSpecialHandling As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpairmentSpecialHandling, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ImpairmentSpecialHandlingDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.ImpairmentSpecialHandlingDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferFtpLocalFolder As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferFtpLocalFolder, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferFileNameFormatString As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferFileNameFormatString, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferFtpMonthJson As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferFtpMonthJson, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DataTransferFtpDayJson As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.DataTransferFtpDayJson, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IndustryGroup As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.IndustryGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MajorGroup As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.MajorGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SpecificGroup As esQueryItem
			Get
				Return New esQueryItem(Me, ClientsMetadata.ColumnNames.SpecificGroup, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class ClientsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Cldbname, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.Cldbname
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Clientname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.Clientname
			c.CharacterMaxLength = 150
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Features, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.Features
			c.CharacterMaxLength = 255
			c.HasDefault = True
			c.Default = "('')"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Fileprefix, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.Fileprefix
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Clientdesigneenotify, 4, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.Clientdesigneenotify
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Clientdesigneename, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.Clientdesigneename
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Clientdesigneeemail, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.Clientdesigneeemail
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames._580active, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames._580active
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Recrespemail, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.Recrespemail
			c.CharacterMaxLength = 12
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Recautofollowup, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.Recautofollowup
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Recfollowup1, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.Recfollowup1
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Recfollowup2, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.Recfollowup2
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Recfollowup3, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.Recfollowup3
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Datatransfer, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.Datatransfer
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Timestamp, 14, GetType(System.Byte()), esSystemType.ByteArray)	
			c.PropertyName = ClientsMetadata.PropertyNames.Timestamp
			c.CharacterMaxLength = 8
			c.IsComputed = True
			c.IsConcurrency = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.AutoRecStartDate, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.AutoRecStartDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.AutoRecComments, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.AutoRecComments
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.FireRatingKeyID, 17, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = ClientsMetadata.PropertyNames.FireRatingKeyID
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.BMRatingKeyID, 18, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = ClientsMetadata.PropertyNames.BMRatingKeyID
			c.NumericPrecision = 3
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.CustomAccessLabel, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.CustomAccessLabel
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.WORecipientName, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.WORecipientName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.WORecipientEmail, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.WORecipientEmail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.WOSubject, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.WOSubject
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ExchangeRateGroupID, 23, GetType(System.Byte), esSystemType.Byte)	
			c.PropertyName = ClientsMetadata.PropertyNames.ExchangeRateGroupID
			c.NumericPrecision = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.AutoRecLastProcessDate, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.AutoRecLastProcessDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Ifu, 25, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.Ifu
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Pifu1, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.Pifu1
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Pifu2, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.Pifu2
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Pifu3, 28, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.Pifu3
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Pifu4, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.Pifu4
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesName1, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesName1
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesEmail1, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesEmail1
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesName2, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesName2
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesEmail2, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesEmail2
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesName3, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesName3
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesEmail3, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesEmail3
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.Aifu, 36, GetType(System.Char), esSystemType.Char)	
			c.PropertyName = ClientsMetadata.PropertyNames.Aifu
			c.CharacterMaxLength = 1
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesName4, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesName4
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesEmail4, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesEmail4
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesName5, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesName5
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpClientDesEmail5, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpClientDesEmail5
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.MgmtARR, 41, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.MgmtARR
			c.HasDefault = True
			c.Default = "((-1))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpEmailAll, 42, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpEmailAll
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SecurityPasswordExpireDays, 43, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.SecurityPasswordExpireDays
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((180))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SecurityInactivityLockoutDays, 44, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.SecurityInactivityLockoutDays
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SecurityInactivityLockoutRemindDays, 45, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.SecurityInactivityLockoutRemindDays
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SecurityPasswordMinimumLength, 46, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.SecurityPasswordMinimumLength
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SecurityPasswordTypeId, 47, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.SecurityPasswordTypeId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferPackageId, 48, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferPackageId
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferPassword, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferPassword
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferEncryptionKey, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferEncryptionKey
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SecurityAllowChangePassword, 51, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.SecurityAllowChangePassword
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ReclassificationEmailSentDate, 52, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.ReclassificationEmailSentDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ReclassificationEmailFollowUpDate, 53, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.ReclassificationEmailFollowUpDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ReclassificationCompletionDate, 54, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.ReclassificationCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ReclassificationLinkGUID, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ReclassificationLinkGUID
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.LastReclassificationCompletionDate, 56, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.LastReclassificationCompletionDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SysUserCreated, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.SysUserCreated
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SysDateCreated, 58, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.SysDateCreated
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SysUserModified, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.SysUserModified
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SysDateModified, 60, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.SysDateModified
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ClientId, 61, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.ClientId
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferPgpEnabled, 62, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferPgpEnabled
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferPgpPublicKey, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferPgpPublicKey
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferFtpUrl, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferFtpUrl
			c.CharacterMaxLength = 500
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferFtpUserName, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferFtpUserName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferFtpPassword, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferFtpPassword
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferPgpFileExtension, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferPgpFileExtension
			c.CharacterMaxLength = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferFtpEnabled, 68, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferFtpEnabled
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferRetrievalDate, 69, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferRetrievalDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DefaultMetaCurrencyID, 70, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ClientsMetadata.PropertyNames.DefaultMetaCurrencyID
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ARRRolloutOption, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ARRRolloutOption
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ARRRolloutOptionDesc, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ARRRolloutOptionDesc
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpairmentStatus, 73, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpairmentStatus
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpairmentSpecialHandling, 74, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpairmentSpecialHandling
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.ImpairmentSpecialHandlingDesc, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.ImpairmentSpecialHandlingDesc
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferFtpLocalFolder, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferFtpLocalFolder
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferFileNameFormatString, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferFileNameFormatString
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferFtpMonthJson, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferFtpMonthJson
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.DataTransferFtpDayJson, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.DataTransferFtpDayJson
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.IndustryGroup, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.IndustryGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.MajorGroup, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.MajorGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ClientsMetadata.ColumnNames.SpecificGroup, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = ClientsMetadata.PropertyNames.SpecificGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ClientsMetadata
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
			 Public Const Cldbname As String = "cldbname"
			 Public Const Clientname As String = "clientname"
			 Public Const Features As String = "features"
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
			 Public Const AutoRecLastProcessDate As String = "AutoRecLastProcessDate"
			 Public Const Ifu As String = "IFU"
			 Public Const Pifu1 As String = "PIFU1"
			 Public Const Pifu2 As String = "PIFU2"
			 Public Const Pifu3 As String = "PIFU3"
			 Public Const Pifu4 As String = "PIFU4"
			 Public Const ImpClientDesName1 As String = "ImpClientDesName1"
			 Public Const ImpClientDesEmail1 As String = "ImpClientDesEmail1"
			 Public Const ImpClientDesName2 As String = "ImpClientDesName2"
			 Public Const ImpClientDesEmail2 As String = "ImpClientDesEmail2"
			 Public Const ImpClientDesName3 As String = "ImpClientDesName3"
			 Public Const ImpClientDesEmail3 As String = "ImpClientDesEmail3"
			 Public Const Aifu As String = "AIFU"
			 Public Const ImpClientDesName4 As String = "ImpClientDesName4"
			 Public Const ImpClientDesEmail4 As String = "ImpClientDesEmail4"
			 Public Const ImpClientDesName5 As String = "ImpClientDesName5"
			 Public Const ImpClientDesEmail5 As String = "ImpClientDesEmail5"
			 Public Const MgmtARR As String = "MgmtARR"
			 Public Const ImpEmailAll As String = "ImpEmailAll"
			 Public Const SecurityPasswordExpireDays As String = "SecurityPasswordExpireDays"
			 Public Const SecurityInactivityLockoutDays As String = "SecurityInactivityLockoutDays"
			 Public Const SecurityInactivityLockoutRemindDays As String = "SecurityInactivityLockoutRemindDays"
			 Public Const SecurityPasswordMinimumLength As String = "SecurityPasswordMinimumLength"
			 Public Const SecurityPasswordTypeId As String = "SecurityPasswordTypeId"
			 Public Const DataTransferPackageId As String = "DataTransferPackageId"
			 Public Const DataTransferPassword As String = "DataTransferPassword"
			 Public Const DataTransferEncryptionKey As String = "DataTransferEncryptionKey"
			 Public Const SecurityAllowChangePassword As String = "SecurityAllowChangePassword"
			 Public Const ReclassificationEmailSentDate As String = "ReclassificationEmailSentDate"
			 Public Const ReclassificationEmailFollowUpDate As String = "ReclassificationEmailFollowUpDate"
			 Public Const ReclassificationCompletionDate As String = "ReclassificationCompletionDate"
			 Public Const ReclassificationLinkGUID As String = "ReclassificationLinkGUID"
			 Public Const LastReclassificationCompletionDate As String = "LastReclassificationCompletionDate"
			 Public Const SysUserCreated As String = "SysUserCreated"
			 Public Const SysDateCreated As String = "SysDateCreated"
			 Public Const SysUserModified As String = "SysUserModified"
			 Public Const SysDateModified As String = "SysDateModified"
			 Public Const ClientId As String = "ClientId"
			 Public Const DataTransferPgpEnabled As String = "DataTransferPgpEnabled"
			 Public Const DataTransferPgpPublicKey As String = "DataTransferPgpPublicKey"
			 Public Const DataTransferFtpUrl As String = "DataTransferFtpUrl"
			 Public Const DataTransferFtpUserName As String = "DataTransferFtpUserName"
			 Public Const DataTransferFtpPassword As String = "DataTransferFtpPassword"
			 Public Const DataTransferPgpFileExtension As String = "DataTransferPgpFileExtension"
			 Public Const DataTransferFtpEnabled As String = "DataTransferFtpEnabled"
			 Public Const DataTransferRetrievalDate As String = "DataTransferRetrievalDate"
			 Public Const DefaultMetaCurrencyID As String = "DefaultMetaCurrencyID"
			 Public Const ARRRolloutOption As String = "ARRRolloutOption"
			 Public Const ARRRolloutOptionDesc As String = "ARRRolloutOptionDesc"
			 Public Const ImpairmentStatus As String = "ImpairmentStatus"
			 Public Const ImpairmentSpecialHandling As String = "ImpairmentSpecialHandling"
			 Public Const ImpairmentSpecialHandlingDesc As String = "ImpairmentSpecialHandlingDesc"
			 Public Const DataTransferFtpLocalFolder As String = "DataTransferFtpLocalFolder"
			 Public Const DataTransferFileNameFormatString As String = "DataTransferFileNameFormatString"
			 Public Const DataTransferFtpMonthJson As String = "DataTransferFtpMonthJson"
			 Public Const DataTransferFtpDayJson As String = "DataTransferFtpDayJson"
			 Public Const IndustryGroup As String = "IndustryGroup"
			 Public Const MajorGroup As String = "MajorGroup"
			 Public Const SpecificGroup As String = "SpecificGroup"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Cldbname As String = "Cldbname"
			 Public Const Clientname As String = "Clientname"
			 Public Const Features As String = "Features"
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
			 Public Const AutoRecLastProcessDate As String = "AutoRecLastProcessDate"
			 Public Const Ifu As String = "Ifu"
			 Public Const Pifu1 As String = "Pifu1"
			 Public Const Pifu2 As String = "Pifu2"
			 Public Const Pifu3 As String = "Pifu3"
			 Public Const Pifu4 As String = "Pifu4"
			 Public Const ImpClientDesName1 As String = "ImpClientDesName1"
			 Public Const ImpClientDesEmail1 As String = "ImpClientDesEmail1"
			 Public Const ImpClientDesName2 As String = "ImpClientDesName2"
			 Public Const ImpClientDesEmail2 As String = "ImpClientDesEmail2"
			 Public Const ImpClientDesName3 As String = "ImpClientDesName3"
			 Public Const ImpClientDesEmail3 As String = "ImpClientDesEmail3"
			 Public Const Aifu As String = "Aifu"
			 Public Const ImpClientDesName4 As String = "ImpClientDesName4"
			 Public Const ImpClientDesEmail4 As String = "ImpClientDesEmail4"
			 Public Const ImpClientDesName5 As String = "ImpClientDesName5"
			 Public Const ImpClientDesEmail5 As String = "ImpClientDesEmail5"
			 Public Const MgmtARR As String = "MgmtARR"
			 Public Const ImpEmailAll As String = "ImpEmailAll"
			 Public Const SecurityPasswordExpireDays As String = "SecurityPasswordExpireDays"
			 Public Const SecurityInactivityLockoutDays As String = "SecurityInactivityLockoutDays"
			 Public Const SecurityInactivityLockoutRemindDays As String = "SecurityInactivityLockoutRemindDays"
			 Public Const SecurityPasswordMinimumLength As String = "SecurityPasswordMinimumLength"
			 Public Const SecurityPasswordTypeId As String = "SecurityPasswordTypeId"
			 Public Const DataTransferPackageId As String = "DataTransferPackageId"
			 Public Const DataTransferPassword As String = "DataTransferPassword"
			 Public Const DataTransferEncryptionKey As String = "DataTransferEncryptionKey"
			 Public Const SecurityAllowChangePassword As String = "SecurityAllowChangePassword"
			 Public Const ReclassificationEmailSentDate As String = "ReclassificationEmailSentDate"
			 Public Const ReclassificationEmailFollowUpDate As String = "ReclassificationEmailFollowUpDate"
			 Public Const ReclassificationCompletionDate As String = "ReclassificationCompletionDate"
			 Public Const ReclassificationLinkGUID As String = "ReclassificationLinkGUID"
			 Public Const LastReclassificationCompletionDate As String = "LastReclassificationCompletionDate"
			 Public Const SysUserCreated As String = "SysUserCreated"
			 Public Const SysDateCreated As String = "SysDateCreated"
			 Public Const SysUserModified As String = "SysUserModified"
			 Public Const SysDateModified As String = "SysDateModified"
			 Public Const ClientId As String = "ClientId"
			 Public Const DataTransferPgpEnabled As String = "DataTransferPgpEnabled"
			 Public Const DataTransferPgpPublicKey As String = "DataTransferPgpPublicKey"
			 Public Const DataTransferFtpUrl As String = "DataTransferFtpUrl"
			 Public Const DataTransferFtpUserName As String = "DataTransferFtpUserName"
			 Public Const DataTransferFtpPassword As String = "DataTransferFtpPassword"
			 Public Const DataTransferPgpFileExtension As String = "DataTransferPgpFileExtension"
			 Public Const DataTransferFtpEnabled As String = "DataTransferFtpEnabled"
			 Public Const DataTransferRetrievalDate As String = "DataTransferRetrievalDate"
			 Public Const DefaultMetaCurrencyID As String = "DefaultMetaCurrencyID"
			 Public Const ARRRolloutOption As String = "ARRRolloutOption"
			 Public Const ARRRolloutOptionDesc As String = "ARRRolloutOptionDesc"
			 Public Const ImpairmentStatus As String = "ImpairmentStatus"
			 Public Const ImpairmentSpecialHandling As String = "ImpairmentSpecialHandling"
			 Public Const ImpairmentSpecialHandlingDesc As String = "ImpairmentSpecialHandlingDesc"
			 Public Const DataTransferFtpLocalFolder As String = "DataTransferFtpLocalFolder"
			 Public Const DataTransferFileNameFormatString As String = "DataTransferFileNameFormatString"
			 Public Const DataTransferFtpMonthJson As String = "DataTransferFtpMonthJson"
			 Public Const DataTransferFtpDayJson As String = "DataTransferFtpDayJson"
			 Public Const IndustryGroup As String = "IndustryGroup"
			 Public Const MajorGroup As String = "MajorGroup"
			 Public Const SpecificGroup As String = "SpecificGroup"
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
			SyncLock GetType(ClientsMetadata)
			
				If ClientsMetadata.mapDelegates Is Nothing Then
					ClientsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ClientsMetadata._meta Is Nothing Then
					ClientsMetadata._meta = New ClientsMetadata()
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
				


				meta.AddTypeMap("Cldbname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Clientname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Features", new esTypeMap("varchar", "System.String"))
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
				meta.AddTypeMap("AutoRecLastProcessDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Ifu", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Pifu1", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pifu2", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pifu3", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pifu4", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ImpClientDesName1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpClientDesEmail1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpClientDesName2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpClientDesEmail2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpClientDesName3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpClientDesEmail3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Aifu", new esTypeMap("varchar", "System.Char"))
				meta.AddTypeMap("ImpClientDesName4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpClientDesEmail4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpClientDesName5", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImpClientDesEmail5", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MgmtARR", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ImpEmailAll", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("SecurityPasswordExpireDays", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SecurityInactivityLockoutDays", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SecurityInactivityLockoutRemindDays", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SecurityPasswordMinimumLength", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SecurityPasswordTypeId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DataTransferPackageId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DataTransferPassword", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferEncryptionKey", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SecurityAllowChangePassword", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ReclassificationEmailSentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ReclassificationEmailFollowUpDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ReclassificationCompletionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ReclassificationLinkGUID", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastReclassificationCompletionDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("SysUserCreated", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SysDateCreated", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("SysUserModified", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SysDateModified", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ClientId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DataTransferPgpEnabled", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("DataTransferPgpPublicKey", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferFtpUrl", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferFtpUserName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferFtpPassword", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferPgpFileExtension", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferFtpEnabled", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("DataTransferRetrievalDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("DefaultMetaCurrencyID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ARRRolloutOption", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ARRRolloutOptionDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ImpairmentStatus", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ImpairmentSpecialHandling", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ImpairmentSpecialHandlingDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferFtpLocalFolder", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferFileNameFormatString", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferFtpMonthJson", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DataTransferFtpDayJson", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("IndustryGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MajorGroup", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("SpecificGroup", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "clients"
				meta.Destination = "clients"
				
				meta.spInsert = "proc_clientsInsert"
				meta.spUpdate = "proc_clientsUpdate"
				meta.spDelete = "proc_clientsDelete"
				meta.spLoadAll = "proc_clientsLoadAll"
				meta.spLoadByPrimaryKey = "proc_clientsLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ClientsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
