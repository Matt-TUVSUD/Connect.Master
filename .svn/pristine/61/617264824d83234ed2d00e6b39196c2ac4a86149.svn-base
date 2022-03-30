
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:19 PM
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
	' Encapsulates the 'Contact1' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Contact1))> _
	<XmlType("Contact1")> _	
	Partial Public Class Contact1 
		Inherits esContact1
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Contact1()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal contactID As System.Int32)
			Dim obj As New Contact1()
			obj.ContactID = contactID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal contactID As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Contact1()
			obj.ContactID = contactID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("Contact1Collection")> _
	Partial Public Class Contact1Collection
		Inherits esContact1Collection
		Implements IEnumerable(Of Contact1)
	
		Public Function FindByPrimaryKey(ByVal contactID As System.Int32) As Contact1
			Return MyBase.SingleOrDefault(Function(e) e.ContactID.HasValue AndAlso e.ContactID.Value = contactID)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Contact1))> _
		Public Class Contact1CollectionWCFPacket
			Inherits esCollectionWCFPacket(Of Contact1Collection)
			
			Public Shared Widening Operator CType(packet As Contact1CollectionWCFPacket) As Contact1Collection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As Contact1Collection) As Contact1CollectionWCFPacket
				Return New Contact1CollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class Contact1Query 
		Inherits esContact1Query
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "Contact1Query"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As Contact1Query) As String
			Return Contact1Query.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As Contact1Query
			Return DirectCast(Contact1Query.SerializeHelper.FromXml(query, GetType(Contact1Query)), Contact1Query)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esContact1
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal contactID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(contactID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(contactID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal contactID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(contactID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(contactID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal contactID As System.Int32) As Boolean
		
			Dim query As New Contact1Query()
			query.Where(query.ContactID = contactID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal contactID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("ContactID", contactID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Contact1.ACCOUNTNO
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Accountno As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Accountno)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Accountno, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Accountno)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.COMPANY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Company As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Company)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Company, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Company)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.CONTACT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Contact As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Contact)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Contact, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Contact)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.LASTNAME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Lastname As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Lastname)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Lastname, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Lastname)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.DEPARTMENT
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Department As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Department)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Department, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Department)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.TITLE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Title As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Title)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Title, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Title)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.SECR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Secr As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Secr)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Secr, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Secr)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.PHONE1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone1 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Phone1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Phone1, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Phone1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.PHONE2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone2 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Phone2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Phone2, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Phone2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.PHONE3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone3 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Phone3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Phone3, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Phone3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.FAX
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.EXT1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ext1 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Ext1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Ext1, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Ext1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.EXT2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ext2 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Ext2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Ext2, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Ext2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.EXT3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ext3 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Ext3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Ext3, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Ext3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.EXT4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Ext4 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Ext4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Ext4, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Ext4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.ADDRESS1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address1 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Address1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Address1, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Address1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.ADDRESS2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address2 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Address2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Address2, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Address2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.CITY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.City, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.STATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property State As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.State)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.State, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.State)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.ZIP
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Zip As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Zip)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Zip, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Zip)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.COUNTRY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Country, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.DEAR
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Dear As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Dear)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Dear, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Dear)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.SOURCE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Source As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Source)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Source, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Source)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.KEY1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Key1 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Key1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Key1, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Key1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.KEY2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Key2 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Key2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Key2, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Key2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.KEY3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Key3 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Key3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Key3, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Key3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.KEY4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Key4 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Key4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Key4, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Key4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.KEY5
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Key5 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Key5)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Key5, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Key5)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.STATUS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Status, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Status)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.NOTES
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Notes As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Notes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Notes, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Notes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.OWNER
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Owner As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Owner)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Owner, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Owner)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.CREATEBY
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Createby As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Createby)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Createby, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Createby)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.LASTUSER
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Lastuser As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Lastuser)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Lastuser, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Lastuser)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.LASTDATE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Lastdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(Contact1Metadata.ColumnNames.Lastdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(Contact1Metadata.ColumnNames.Lastdate, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Lastdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.LASTTIME
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Lasttime As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Lasttime)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Lasttime, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Lasttime)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Address3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address3 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Address3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Address3, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Address3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Location Comment
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property LocationComment As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.LocationComment)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.LocationComment, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.LocationComment)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.GRC Notes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property GRCNotes As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.GRCNotes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.GRCNotes, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.GRCNotes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.ARISE Notes
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ARISENotes As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.ARISENotes)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.ARISENotes, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.ARISENotes)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.RECID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Recid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(Contact1Metadata.ColumnNames.Recid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(Contact1Metadata.ColumnNames.Recid, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Recid)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Date Entered
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property DateEntered As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(Contact1Metadata.ColumnNames.DateEntered)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(Contact1Metadata.ColumnNames.DateEntered, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.DateEntered)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Time Entered
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TimeEntered As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(Contact1Metadata.ColumnNames.TimeEntered)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(Contact1Metadata.ColumnNames.TimeEntered, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.TimeEntered)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.DELETEFLAG
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Deleteflag As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(Contact1Metadata.ColumnNames.Deleteflag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(Contact1Metadata.ColumnNames.Deleteflag, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Deleteflag)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Sqfootage
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Sqfootage As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(Contact1Metadata.ColumnNames.Sqfootage)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				If MyBase.SetSystemDouble(Contact1Metadata.ColumnNames.Sqfootage, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Sqfootage)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Client1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client1 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Client1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Client1, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Client1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Client2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Client2 As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Client2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Client2, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Client2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Occupancy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Occupancy As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.Occupancy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.Occupancy, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Occupancy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.CustomAccess
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomAccess As System.String
			Get
				Return MyBase.GetSystemString(Contact1Metadata.ColumnNames.CustomAccess)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(Contact1Metadata.ColumnNames.CustomAccess, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.CustomAccess)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.FilePrefix
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FilePrefix As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(Contact1Metadata.ColumnNames.FilePrefix)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(Contact1Metadata.ColumnNames.FilePrefix, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.FilePrefix)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Latitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Latitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(Contact1Metadata.ColumnNames.Latitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(Contact1Metadata.ColumnNames.Latitude, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Latitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.Longitude
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Longitude As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(Contact1Metadata.ColumnNames.Longitude)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(Contact1Metadata.ColumnNames.Longitude, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.Longitude)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Contact1.ContactID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContactID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(Contact1Metadata.ColumnNames.ContactID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(Contact1Metadata.ColumnNames.ContactID, value) Then
					OnPropertyChanged(Contact1Metadata.PropertyNames.ContactID)
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
												
						Case "Accountno"
							Me.str().Accountno = CType(value, string)
												
						Case "Company"
							Me.str().Company = CType(value, string)
												
						Case "Contact"
							Me.str().Contact = CType(value, string)
												
						Case "Lastname"
							Me.str().Lastname = CType(value, string)
												
						Case "Department"
							Me.str().Department = CType(value, string)
												
						Case "Title"
							Me.str().Title = CType(value, string)
												
						Case "Secr"
							Me.str().Secr = CType(value, string)
												
						Case "Phone1"
							Me.str().Phone1 = CType(value, string)
												
						Case "Phone2"
							Me.str().Phone2 = CType(value, string)
												
						Case "Phone3"
							Me.str().Phone3 = CType(value, string)
												
						Case "Fax"
							Me.str().Fax = CType(value, string)
												
						Case "Ext1"
							Me.str().Ext1 = CType(value, string)
												
						Case "Ext2"
							Me.str().Ext2 = CType(value, string)
												
						Case "Ext3"
							Me.str().Ext3 = CType(value, string)
												
						Case "Ext4"
							Me.str().Ext4 = CType(value, string)
												
						Case "Address1"
							Me.str().Address1 = CType(value, string)
												
						Case "Address2"
							Me.str().Address2 = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "State"
							Me.str().State = CType(value, string)
												
						Case "Zip"
							Me.str().Zip = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "Dear"
							Me.str().Dear = CType(value, string)
												
						Case "Source"
							Me.str().Source = CType(value, string)
												
						Case "Key1"
							Me.str().Key1 = CType(value, string)
												
						Case "Key2"
							Me.str().Key2 = CType(value, string)
												
						Case "Key3"
							Me.str().Key3 = CType(value, string)
												
						Case "Key4"
							Me.str().Key4 = CType(value, string)
												
						Case "Key5"
							Me.str().Key5 = CType(value, string)
												
						Case "Status"
							Me.str().Status = CType(value, string)
												
						Case "Notes"
							Me.str().Notes = CType(value, string)
												
						Case "Owner"
							Me.str().Owner = CType(value, string)
												
						Case "Createby"
							Me.str().Createby = CType(value, string)
												
						Case "Lastuser"
							Me.str().Lastuser = CType(value, string)
												
						Case "Lastdate"
							Me.str().Lastdate = CType(value, string)
												
						Case "Lasttime"
							Me.str().Lasttime = CType(value, string)
												
						Case "Address3"
							Me.str().Address3 = CType(value, string)
												
						Case "LocationComment"
							Me.str().LocationComment = CType(value, string)
												
						Case "GRCNotes"
							Me.str().GRCNotes = CType(value, string)
												
						Case "ARISENotes"
							Me.str().ARISENotes = CType(value, string)
												
						Case "Recid"
							Me.str().Recid = CType(value, string)
												
						Case "DateEntered"
							Me.str().DateEntered = CType(value, string)
												
						Case "TimeEntered"
							Me.str().TimeEntered = CType(value, string)
												
						Case "Deleteflag"
							Me.str().Deleteflag = CType(value, string)
												
						Case "Sqfootage"
							Me.str().Sqfootage = CType(value, string)
												
						Case "Client1"
							Me.str().Client1 = CType(value, string)
												
						Case "Client2"
							Me.str().Client2 = CType(value, string)
												
						Case "Occupancy"
							Me.str().Occupancy = CType(value, string)
												
						Case "CustomAccess"
							Me.str().CustomAccess = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
												
						Case "Latitude"
							Me.str().Latitude = CType(value, string)
												
						Case "Longitude"
							Me.str().Longitude = CType(value, string)
												
						Case "ContactID"
							Me.str().ContactID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Lastdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Lastdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(Contact1Metadata.PropertyNames.Lastdate)
							End If
						
						Case "Recid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recid = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(Contact1Metadata.PropertyNames.Recid)
							End If
						
						Case "DateEntered"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateEntered = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(Contact1Metadata.PropertyNames.DateEntered)
							End If
						
						Case "TimeEntered"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.TimeEntered = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(Contact1Metadata.PropertyNames.TimeEntered)
							End If
						
						Case "Deleteflag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Deleteflag = CType(value, Nullable(Of System.Boolean))
								OnPropertyChanged(Contact1Metadata.PropertyNames.Deleteflag)
							End If
						
						Case "Sqfootage"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Sqfootage = CType(value, Nullable(Of System.Double))
								OnPropertyChanged(Contact1Metadata.PropertyNames.Sqfootage)
							End If
						
						Case "FilePrefix"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FilePrefix = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(Contact1Metadata.PropertyNames.FilePrefix)
							End If
						
						Case "Latitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Latitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(Contact1Metadata.PropertyNames.Latitude)
							End If
						
						Case "Longitude"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Longitude = CType(value, Nullable(Of System.Decimal))
								OnPropertyChanged(Contact1Metadata.PropertyNames.Longitude)
							End If
						
						Case "ContactID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ContactID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(Contact1Metadata.PropertyNames.ContactID)
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
		
			Public Sub New(ByVal entity As esContact1)
				Me.entity = entity
			End Sub				
		
	
			Public Property Accountno As System.String 
				Get
					Dim data_ As System.String = entity.Accountno
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Accountno = Nothing
					Else
						entity.Accountno = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Company As System.String 
				Get
					Dim data_ As System.String = entity.Company
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Company = Nothing
					Else
						entity.Company = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Contact As System.String 
				Get
					Dim data_ As System.String = entity.Contact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Contact = Nothing
					Else
						entity.Contact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lastname As System.String 
				Get
					Dim data_ As System.String = entity.Lastname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lastname = Nothing
					Else
						entity.Lastname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Department As System.String 
				Get
					Dim data_ As System.String = entity.Department
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Department = Nothing
					Else
						entity.Department = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Title As System.String 
				Get
					Dim data_ As System.String = entity.Title
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Title = Nothing
					Else
						entity.Title = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Secr As System.String 
				Get
					Dim data_ As System.String = entity.Secr
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Secr = Nothing
					Else
						entity.Secr = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phone1 As System.String 
				Get
					Dim data_ As System.String = entity.Phone1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phone1 = Nothing
					Else
						entity.Phone1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phone2 As System.String 
				Get
					Dim data_ As System.String = entity.Phone2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phone2 = Nothing
					Else
						entity.Phone2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phone3 As System.String 
				Get
					Dim data_ As System.String = entity.Phone3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phone3 = Nothing
					Else
						entity.Phone3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fax As System.String 
				Get
					Dim data_ As System.String = entity.Fax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fax = Nothing
					Else
						entity.Fax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ext1 As System.String 
				Get
					Dim data_ As System.String = entity.Ext1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ext1 = Nothing
					Else
						entity.Ext1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ext2 As System.String 
				Get
					Dim data_ As System.String = entity.Ext2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ext2 = Nothing
					Else
						entity.Ext2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ext3 As System.String 
				Get
					Dim data_ As System.String = entity.Ext3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ext3 = Nothing
					Else
						entity.Ext3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ext4 As System.String 
				Get
					Dim data_ As System.String = entity.Ext4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ext4 = Nothing
					Else
						entity.Ext4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Address1 As System.String 
				Get
					Dim data_ As System.String = entity.Address1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address1 = Nothing
					Else
						entity.Address1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Address2 As System.String 
				Get
					Dim data_ As System.String = entity.Address2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address2 = Nothing
					Else
						entity.Address2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property City As System.String 
				Get
					Dim data_ As System.String = entity.City
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.City = Nothing
					Else
						entity.City = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property State As System.String 
				Get
					Dim data_ As System.String = entity.State
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.State = Nothing
					Else
						entity.State = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Zip As System.String 
				Get
					Dim data_ As System.String = entity.Zip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Zip = Nothing
					Else
						entity.Zip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Country As System.String 
				Get
					Dim data_ As System.String = entity.Country
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Country = Nothing
					Else
						entity.Country = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dear As System.String 
				Get
					Dim data_ As System.String = entity.Dear
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dear = Nothing
					Else
						entity.Dear = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Source As System.String 
				Get
					Dim data_ As System.String = entity.Source
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Source = Nothing
					Else
						entity.Source = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Key1 As System.String 
				Get
					Dim data_ As System.String = entity.Key1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Key1 = Nothing
					Else
						entity.Key1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Key2 As System.String 
				Get
					Dim data_ As System.String = entity.Key2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Key2 = Nothing
					Else
						entity.Key2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Key3 As System.String 
				Get
					Dim data_ As System.String = entity.Key3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Key3 = Nothing
					Else
						entity.Key3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Key4 As System.String 
				Get
					Dim data_ As System.String = entity.Key4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Key4 = Nothing
					Else
						entity.Key4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Key5 As System.String 
				Get
					Dim data_ As System.String = entity.Key5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Key5 = Nothing
					Else
						entity.Key5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Status As System.String 
				Get
					Dim data_ As System.String = entity.Status
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Status = Nothing
					Else
						entity.Status = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Notes As System.String 
				Get
					Dim data_ As System.String = entity.Notes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Notes = Nothing
					Else
						entity.Notes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Owner As System.String 
				Get
					Dim data_ As System.String = entity.Owner
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Owner = Nothing
					Else
						entity.Owner = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createby As System.String 
				Get
					Dim data_ As System.String = entity.Createby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createby = Nothing
					Else
						entity.Createby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lastuser As System.String 
				Get
					Dim data_ As System.String = entity.Lastuser
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lastuser = Nothing
					Else
						entity.Lastuser = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lastdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Lastdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lastdate = Nothing
					Else
						entity.Lastdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lasttime As System.String 
				Get
					Dim data_ As System.String = entity.Lasttime
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lasttime = Nothing
					Else
						entity.Lasttime = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Address3 As System.String 
				Get
					Dim data_ As System.String = entity.Address3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address3 = Nothing
					Else
						entity.Address3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LocationComment As System.String 
				Get
					Dim data_ As System.String = entity.LocationComment
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LocationComment = Nothing
					Else
						entity.LocationComment = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GRCNotes As System.String 
				Get
					Dim data_ As System.String = entity.GRCNotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GRCNotes = Nothing
					Else
						entity.GRCNotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ARISENotes As System.String 
				Get
					Dim data_ As System.String = entity.ARISENotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ARISENotes = Nothing
					Else
						entity.ARISENotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recid = Nothing
					Else
						entity.Recid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateEntered As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateEntered
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateEntered = Nothing
					Else
						entity.DateEntered = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property TimeEntered As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.TimeEntered
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TimeEntered = Nothing
					Else
						entity.TimeEntered = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Deleteflag As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Deleteflag
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Deleteflag = Nothing
					Else
						entity.Deleteflag = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sqfootage As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Sqfootage
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sqfootage = Nothing
					Else
						entity.Sqfootage = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Client1 As System.String 
				Get
					Dim data_ As System.String = entity.Client1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Client1 = Nothing
					Else
						entity.Client1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Client2 As System.String 
				Get
					Dim data_ As System.String = entity.Client2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Client2 = Nothing
					Else
						entity.Client2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occupancy As System.String 
				Get
					Dim data_ As System.String = entity.Occupancy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occupancy = Nothing
					Else
						entity.Occupancy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomAccess As System.String 
				Get
					Dim data_ As System.String = entity.CustomAccess
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomAccess = Nothing
					Else
						entity.CustomAccess = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FilePrefix As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FilePrefix
					
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
						entity.FilePrefix = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Latitude As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Latitude
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Latitude = Nothing
					Else
						entity.Latitude = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Longitude As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Longitude
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Longitude = Nothing
					Else
						entity.Longitude = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContactID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ContactID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContactID = Nothing
					Else
						entity.ContactID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esContact1
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return Contact1Metadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As Contact1Query
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New Contact1Query()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As Contact1Query) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As Contact1Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As Contact1Query

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esContact1Collection
		Inherits esEntityCollection(Of Contact1)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return Contact1Metadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "Contact1Collection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As Contact1Query
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New Contact1Query()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As Contact1Query) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New Contact1Query()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As Contact1Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, Contact1Query))
		End Sub
		
		#End Region
						
		Private m_query As Contact1Query
	End Class



	<Serializable> _
	MustInherit Public Partial Class esContact1Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return Contact1Metadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Accountno" 
					Return Me.Accountno
				Case "Company" 
					Return Me.Company
				Case "Contact" 
					Return Me.Contact
				Case "Lastname" 
					Return Me.Lastname
				Case "Department" 
					Return Me.Department
				Case "Title" 
					Return Me.Title
				Case "Secr" 
					Return Me.Secr
				Case "Phone1" 
					Return Me.Phone1
				Case "Phone2" 
					Return Me.Phone2
				Case "Phone3" 
					Return Me.Phone3
				Case "Fax" 
					Return Me.Fax
				Case "Ext1" 
					Return Me.Ext1
				Case "Ext2" 
					Return Me.Ext2
				Case "Ext3" 
					Return Me.Ext3
				Case "Ext4" 
					Return Me.Ext4
				Case "Address1" 
					Return Me.Address1
				Case "Address2" 
					Return Me.Address2
				Case "City" 
					Return Me.City
				Case "State" 
					Return Me.State
				Case "Zip" 
					Return Me.Zip
				Case "Country" 
					Return Me.Country
				Case "Dear" 
					Return Me.Dear
				Case "Source" 
					Return Me.Source
				Case "Key1" 
					Return Me.Key1
				Case "Key2" 
					Return Me.Key2
				Case "Key3" 
					Return Me.Key3
				Case "Key4" 
					Return Me.Key4
				Case "Key5" 
					Return Me.Key5
				Case "Status" 
					Return Me.Status
				Case "Notes" 
					Return Me.Notes
				Case "Owner" 
					Return Me.Owner
				Case "Createby" 
					Return Me.Createby
				Case "Lastuser" 
					Return Me.Lastuser
				Case "Lastdate" 
					Return Me.Lastdate
				Case "Lasttime" 
					Return Me.Lasttime
				Case "Address3" 
					Return Me.Address3
				Case "LocationComment" 
					Return Me.LocationComment
				Case "GRCNotes" 
					Return Me.GRCNotes
				Case "ARISENotes" 
					Return Me.ARISENotes
				Case "Recid" 
					Return Me.Recid
				Case "DateEntered" 
					Return Me.DateEntered
				Case "TimeEntered" 
					Return Me.TimeEntered
				Case "Deleteflag" 
					Return Me.Deleteflag
				Case "Sqfootage" 
					Return Me.Sqfootage
				Case "Client1" 
					Return Me.Client1
				Case "Client2" 
					Return Me.Client2
				Case "Occupancy" 
					Return Me.Occupancy
				Case "CustomAccess" 
					Return Me.CustomAccess
				Case "FilePrefix" 
					Return Me.FilePrefix
				Case "Latitude" 
					Return Me.Latitude
				Case "Longitude" 
					Return Me.Longitude
				Case "ContactID" 
					Return Me.ContactID
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Accountno As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Accountno, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Company As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Company, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Contact As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Contact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lastname As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Lastname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Department As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Department, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Title As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Title, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Secr As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Secr, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone1 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Phone1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone2 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Phone2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone3 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Phone3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ext1 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Ext1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ext2 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Ext2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ext3 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Ext3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ext4 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Ext4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address1 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Address1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address2 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Address2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property State As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.State, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Zip As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Zip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dear As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Dear, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Source As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Source, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Key1 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Key1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Key2 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Key2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Key3 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Key3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Key4 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Key4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Key5 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Key5, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Notes As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Notes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Owner As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Owner, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createby As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Createby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lastuser As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Lastuser, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lastdate As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Lastdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Lasttime As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Lasttime, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address3 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Address3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LocationComment As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.LocationComment, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GRCNotes As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.GRCNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ARISENotes As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.ARISENotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recid As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Recid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateEntered As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.DateEntered, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property TimeEntered As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.TimeEntered, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Deleteflag As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Deleteflag, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Sqfootage As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Sqfootage, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Client1 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Client1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Client2 As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Client2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occupancy As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Occupancy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomAccess As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.CustomAccess, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.FilePrefix, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Latitude As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Latitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Longitude As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.Longitude, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ContactID As esQueryItem
			Get
				Return New esQueryItem(Me, Contact1Metadata.ColumnNames.ContactID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class Contact1Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Accountno, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Accountno
			c.CharacterMaxLength = 20
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Company, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Company
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Contact, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Contact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Lastname, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Lastname
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Department, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Department
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Title, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Title
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Secr, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Secr
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Phone1, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Phone1
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Phone2, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Phone2
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Phone3, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Phone3
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Fax, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Fax
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Ext1, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Ext1
			c.CharacterMaxLength = 12
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Ext2, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Ext2
			c.CharacterMaxLength = 12
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Ext3, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Ext3
			c.CharacterMaxLength = 12
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Ext4, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Ext4
			c.CharacterMaxLength = 6
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Address1, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Address1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Address2, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Address2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.City, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.City
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.State, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.State
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Zip, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Zip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Country, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Country
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Dear, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Dear
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Source, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Source
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Key1, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Key1
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Key2, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Key2
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Key3, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Key3
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Key4, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Key4
			c.CharacterMaxLength = 20
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Key5, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Key5
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Status, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Status
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Notes, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Notes
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Owner, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Owner
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Createby, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Createby
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Lastuser, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Lastuser
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Lastdate, 33, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = Contact1Metadata.PropertyNames.Lastdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Lasttime, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Lasttime
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Address3, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Address3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.LocationComment, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.LocationComment
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.GRCNotes, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.GRCNotes
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.ARISENotes, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.ARISENotes
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Recid, 39, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = Contact1Metadata.PropertyNames.Recid
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.DateEntered, 40, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = Contact1Metadata.PropertyNames.DateEntered
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.TimeEntered, 41, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = Contact1Metadata.PropertyNames.TimeEntered
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Deleteflag, 42, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = Contact1Metadata.PropertyNames.Deleteflag
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Sqfootage, 43, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = Contact1Metadata.PropertyNames.Sqfootage
			c.NumericPrecision = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Client1, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Client1
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Client2, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Client2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Occupancy, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.Occupancy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.CustomAccess, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = Contact1Metadata.PropertyNames.CustomAccess
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.FilePrefix, 48, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = Contact1Metadata.PropertyNames.FilePrefix
			c.NumericPrecision = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Latitude, 49, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = Contact1Metadata.PropertyNames.Latitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.Longitude, 50, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = Contact1Metadata.PropertyNames.Longitude
			c.NumericPrecision = 7
			c.NumericScale = 4
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(Contact1Metadata.ColumnNames.ContactID, 51, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = Contact1Metadata.PropertyNames.ContactID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As Contact1Metadata
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
			 Public Const Accountno As String = "ACCOUNTNO"
			 Public Const Company As String = "COMPANY"
			 Public Const Contact As String = "CONTACT"
			 Public Const Lastname As String = "LASTNAME"
			 Public Const Department As String = "DEPARTMENT"
			 Public Const Title As String = "TITLE"
			 Public Const Secr As String = "SECR"
			 Public Const Phone1 As String = "PHONE1"
			 Public Const Phone2 As String = "PHONE2"
			 Public Const Phone3 As String = "PHONE3"
			 Public Const Fax As String = "FAX"
			 Public Const Ext1 As String = "EXT1"
			 Public Const Ext2 As String = "EXT2"
			 Public Const Ext3 As String = "EXT3"
			 Public Const Ext4 As String = "EXT4"
			 Public Const Address1 As String = "ADDRESS1"
			 Public Const Address2 As String = "ADDRESS2"
			 Public Const City As String = "CITY"
			 Public Const State As String = "STATE"
			 Public Const Zip As String = "ZIP"
			 Public Const Country As String = "COUNTRY"
			 Public Const Dear As String = "DEAR"
			 Public Const Source As String = "SOURCE"
			 Public Const Key1 As String = "KEY1"
			 Public Const Key2 As String = "KEY2"
			 Public Const Key3 As String = "KEY3"
			 Public Const Key4 As String = "KEY4"
			 Public Const Key5 As String = "KEY5"
			 Public Const Status As String = "STATUS"
			 Public Const Notes As String = "NOTES"
			 Public Const Owner As String = "OWNER"
			 Public Const Createby As String = "CREATEBY"
			 Public Const Lastuser As String = "LASTUSER"
			 Public Const Lastdate As String = "LASTDATE"
			 Public Const Lasttime As String = "LASTTIME"
			 Public Const Address3 As String = "Address3"
			 Public Const LocationComment As String = "Location Comment"
			 Public Const GRCNotes As String = "GRC Notes"
			 Public Const ARISENotes As String = "ARISE Notes"
			 Public Const Recid As String = "RECID"
			 Public Const DateEntered As String = "Date Entered"
			 Public Const TimeEntered As String = "Time Entered"
			 Public Const Deleteflag As String = "DELETEFLAG"
			 Public Const Sqfootage As String = "Sqfootage"
			 Public Const Client1 As String = "Client1"
			 Public Const Client2 As String = "Client2"
			 Public Const Occupancy As String = "Occupancy"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const ContactID As String = "ContactID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Accountno As String = "Accountno"
			 Public Const Company As String = "Company"
			 Public Const Contact As String = "Contact"
			 Public Const Lastname As String = "Lastname"
			 Public Const Department As String = "Department"
			 Public Const Title As String = "Title"
			 Public Const Secr As String = "Secr"
			 Public Const Phone1 As String = "Phone1"
			 Public Const Phone2 As String = "Phone2"
			 Public Const Phone3 As String = "Phone3"
			 Public Const Fax As String = "Fax"
			 Public Const Ext1 As String = "Ext1"
			 Public Const Ext2 As String = "Ext2"
			 Public Const Ext3 As String = "Ext3"
			 Public Const Ext4 As String = "Ext4"
			 Public Const Address1 As String = "Address1"
			 Public Const Address2 As String = "Address2"
			 Public Const City As String = "City"
			 Public Const State As String = "State"
			 Public Const Zip As String = "Zip"
			 Public Const Country As String = "Country"
			 Public Const Dear As String = "Dear"
			 Public Const Source As String = "Source"
			 Public Const Key1 As String = "Key1"
			 Public Const Key2 As String = "Key2"
			 Public Const Key3 As String = "Key3"
			 Public Const Key4 As String = "Key4"
			 Public Const Key5 As String = "Key5"
			 Public Const Status As String = "Status"
			 Public Const Notes As String = "Notes"
			 Public Const Owner As String = "Owner"
			 Public Const Createby As String = "Createby"
			 Public Const Lastuser As String = "Lastuser"
			 Public Const Lastdate As String = "Lastdate"
			 Public Const Lasttime As String = "Lasttime"
			 Public Const Address3 As String = "Address3"
			 Public Const LocationComment As String = "LocationComment"
			 Public Const GRCNotes As String = "GRCNotes"
			 Public Const ARISENotes As String = "ARISENotes"
			 Public Const Recid As String = "Recid"
			 Public Const DateEntered As String = "DateEntered"
			 Public Const TimeEntered As String = "TimeEntered"
			 Public Const Deleteflag As String = "Deleteflag"
			 Public Const Sqfootage As String = "Sqfootage"
			 Public Const Client1 As String = "Client1"
			 Public Const Client2 As String = "Client2"
			 Public Const Occupancy As String = "Occupancy"
			 Public Const CustomAccess As String = "CustomAccess"
			 Public Const FilePrefix As String = "FilePrefix"
			 Public Const Latitude As String = "Latitude"
			 Public Const Longitude As String = "Longitude"
			 Public Const ContactID As String = "ContactID"
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
			SyncLock GetType(Contact1Metadata)
			
				If Contact1Metadata.mapDelegates Is Nothing Then
					Contact1Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If Contact1Metadata._meta Is Nothing Then
					Contact1Metadata._meta = New Contact1Metadata()
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
				


				meta.AddTypeMap("Accountno", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Company", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Contact", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lastname", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Department", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Title", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Secr", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Phone1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Phone2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Phone3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ext1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ext2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ext3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ext4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("State", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Zip", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Dear", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Source", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Key1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Key2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Key3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Key4", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Key5", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Status", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Notes", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Owner", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Createby", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lastuser", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Lastdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Lasttime", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LocationComment", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("GRCNotes", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("ARISENotes", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Recid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DateEntered", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("TimeEntered", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Deleteflag", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Sqfootage", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Client1", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Client2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Occupancy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CustomAccess", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("FilePrefix", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Latitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Longitude", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("ContactID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "Contact1"
				meta.Destination = "Contact1"
				
				meta.spInsert = "proc_Contact1Insert"
				meta.spUpdate = "proc_Contact1Update"
				meta.spDelete = "proc_Contact1Delete"
				meta.spLoadAll = "proc_Contact1LoadAll"
				meta.spLoadByPrimaryKey = "proc_Contact1LoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As Contact1Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
