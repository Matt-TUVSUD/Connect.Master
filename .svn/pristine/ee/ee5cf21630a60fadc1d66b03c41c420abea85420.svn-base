
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/6/2013 5:51:25 PM
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
	' Encapsulates the 'NatHaz-Wind-MiscellaneousOther' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(NatHazWindMiscellaneousOther))> _
	<XmlType("NatHazWindMiscellaneousOther")> _	
	Partial Public Class NatHazWindMiscellaneousOther 
		Inherits esNatHazWindMiscellaneousOther
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New NatHazWindMiscellaneousOther()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Int32)
			Dim obj As New NatHazWindMiscellaneousOther()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New NatHazWindMiscellaneousOther()
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
	<XmlType("NatHazWindMiscellaneousOtherCollection")> _
	Partial Public Class NatHazWindMiscellaneousOtherCollection
		Inherits esNatHazWindMiscellaneousOtherCollection
		Implements IEnumerable(Of NatHazWindMiscellaneousOther)
	
		Public Function FindByPrimaryKey(ByVal id As System.Int32) As NatHazWindMiscellaneousOther
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(NatHazWindMiscellaneousOther))> _
		Public Class NatHazWindMiscellaneousOtherCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of NatHazWindMiscellaneousOtherCollection)
			
			Public Shared Widening Operator CType(packet As NatHazWindMiscellaneousOtherCollectionWCFPacket) As NatHazWindMiscellaneousOtherCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As NatHazWindMiscellaneousOtherCollection) As NatHazWindMiscellaneousOtherCollectionWCFPacket
				Return New NatHazWindMiscellaneousOtherCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class NatHazWindMiscellaneousOtherQuery 
		Inherits esNatHazWindMiscellaneousOtherQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "NatHazWindMiscellaneousOtherQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As NatHazWindMiscellaneousOtherQuery) As String
			Return NatHazWindMiscellaneousOtherQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As NatHazWindMiscellaneousOtherQuery
			Return DirectCast(NatHazWindMiscellaneousOtherQuery.SerializeHelper.FromXml(query, GetType(NatHazWindMiscellaneousOtherQuery)), NatHazWindMiscellaneousOtherQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esNatHazWindMiscellaneousOther
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
		
			Dim query As New NatHazWindMiscellaneousOtherQuery()
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
		' Maps to NatHaz-Wind-MiscellaneousOther.ID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.Id)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.SurveyDate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SurveyDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SurveyDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SurveyDate, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.SurveyDate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.ProjProtRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProjProtRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.ProjProtRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.ProjProtRating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.ProjProtRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.ProjProtComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ProjProtComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.ProjProtComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.ProjProtComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.ProjProtComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.OES-RGRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OESRGRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OESRGRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OESRGRating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.OESRGRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.OES-RGComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OESRGComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OESRGComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OESRGComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.OESRGComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.SARating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SARating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SARating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SARating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.SARating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.SAComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property SAComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SAComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SAComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.SAComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.TreesRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TreesRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.TreesRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.TreesRating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.TreesRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.TreesComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TreesComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.TreesComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.TreesComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.TreesComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.CLCRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CLCRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CLCRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CLCRating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.CLCRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.CLCComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CLCComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CLCComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CLCComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.CLCComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.PBRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PBRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.PBRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.PBRating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.PBRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.PBComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PBComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.PBComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.PBComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.PBComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.EmergRespSuppliesRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmergRespSuppliesRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.EmergRespSuppliesRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.EmergRespSuppliesRating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.EmergRespSuppliesRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.EmergRespSuppliesComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property EmergRespSuppliesComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.EmergRespSuppliesComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.EmergRespSuppliesComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.EmergRespSuppliesComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.OtherMiscExpRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherMiscExpRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OtherMiscExpRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OtherMiscExpRating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.OtherMiscExpRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.OtherMiscExpComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property OtherMiscExpComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OtherMiscExpComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OtherMiscExpComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.OtherMiscExpComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.CVBEGRating
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CVBEGRating As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CVBEGRating)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CVBEGRating, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.CVBEGRating)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.CVBEGComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CVBEGComments As System.String
			Get
				Return MyBase.GetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CVBEGComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CVBEGComments, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.CVBEGComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.importdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Importdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Importdate, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.Importdate)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to NatHaz-Wind-MiscellaneousOther.importorigdate
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Importorigdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Importorigdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Importorigdate, value) Then
					OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.Importorigdate)
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
												
						Case "FileNo"
							Me.str().FileNo = CType(value, string)
												
						Case "SurveyDate"
							Me.str().SurveyDate = CType(value, string)
												
						Case "ProjProtRating"
							Me.str().ProjProtRating = CType(value, string)
												
						Case "ProjProtComments"
							Me.str().ProjProtComments = CType(value, string)
												
						Case "OESRGRating"
							Me.str().OESRGRating = CType(value, string)
												
						Case "OESRGComments"
							Me.str().OESRGComments = CType(value, string)
												
						Case "SARating"
							Me.str().SARating = CType(value, string)
												
						Case "SAComments"
							Me.str().SAComments = CType(value, string)
												
						Case "TreesRating"
							Me.str().TreesRating = CType(value, string)
												
						Case "TreesComments"
							Me.str().TreesComments = CType(value, string)
												
						Case "CLCRating"
							Me.str().CLCRating = CType(value, string)
												
						Case "CLCComments"
							Me.str().CLCComments = CType(value, string)
												
						Case "PBRating"
							Me.str().PBRating = CType(value, string)
												
						Case "PBComments"
							Me.str().PBComments = CType(value, string)
												
						Case "EmergRespSuppliesRating"
							Me.str().EmergRespSuppliesRating = CType(value, string)
												
						Case "EmergRespSuppliesComments"
							Me.str().EmergRespSuppliesComments = CType(value, string)
												
						Case "OtherMiscExpRating"
							Me.str().OtherMiscExpRating = CType(value, string)
												
						Case "OtherMiscExpComments"
							Me.str().OtherMiscExpComments = CType(value, string)
												
						Case "CVBEGRating"
							Me.str().CVBEGRating = CType(value, string)
												
						Case "CVBEGComments"
							Me.str().CVBEGComments = CType(value, string)
												
						Case "Importdate"
							Me.str().Importdate = CType(value, string)
												
						Case "Importorigdate"
							Me.str().Importorigdate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.Id)
							End If
						
						Case "SurveyDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.SurveyDate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.SurveyDate)
							End If
						
						Case "Importdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.Importdate)
							End If
						
						Case "Importorigdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Importorigdate = CType(value, Nullable(Of System.DateTime))
								OnPropertyChanged(NatHazWindMiscellaneousOtherMetadata.PropertyNames.Importorigdate)
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
		
			Public Sub New(ByVal entity As esNatHazWindMiscellaneousOther)
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
		  	
			Public Property SurveyDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.SurveyDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SurveyDate = Nothing
					Else
						entity.SurveyDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProjProtRating As System.String 
				Get
					Dim data_ As System.String = entity.ProjProtRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProjProtRating = Nothing
					Else
						entity.ProjProtRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProjProtComments As System.String 
				Get
					Dim data_ As System.String = entity.ProjProtComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProjProtComments = Nothing
					Else
						entity.ProjProtComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OESRGRating As System.String 
				Get
					Dim data_ As System.String = entity.OESRGRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OESRGRating = Nothing
					Else
						entity.OESRGRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OESRGComments As System.String 
				Get
					Dim data_ As System.String = entity.OESRGComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OESRGComments = Nothing
					Else
						entity.OESRGComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SARating As System.String 
				Get
					Dim data_ As System.String = entity.SARating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SARating = Nothing
					Else
						entity.SARating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SAComments As System.String 
				Get
					Dim data_ As System.String = entity.SAComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SAComments = Nothing
					Else
						entity.SAComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TreesRating As System.String 
				Get
					Dim data_ As System.String = entity.TreesRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TreesRating = Nothing
					Else
						entity.TreesRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TreesComments As System.String 
				Get
					Dim data_ As System.String = entity.TreesComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TreesComments = Nothing
					Else
						entity.TreesComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CLCRating As System.String 
				Get
					Dim data_ As System.String = entity.CLCRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CLCRating = Nothing
					Else
						entity.CLCRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CLCComments As System.String 
				Get
					Dim data_ As System.String = entity.CLCComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CLCComments = Nothing
					Else
						entity.CLCComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PBRating As System.String 
				Get
					Dim data_ As System.String = entity.PBRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PBRating = Nothing
					Else
						entity.PBRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PBComments As System.String 
				Get
					Dim data_ As System.String = entity.PBComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PBComments = Nothing
					Else
						entity.PBComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmergRespSuppliesRating As System.String 
				Get
					Dim data_ As System.String = entity.EmergRespSuppliesRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmergRespSuppliesRating = Nothing
					Else
						entity.EmergRespSuppliesRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmergRespSuppliesComments As System.String 
				Get
					Dim data_ As System.String = entity.EmergRespSuppliesComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmergRespSuppliesComments = Nothing
					Else
						entity.EmergRespSuppliesComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherMiscExpRating As System.String 
				Get
					Dim data_ As System.String = entity.OtherMiscExpRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherMiscExpRating = Nothing
					Else
						entity.OtherMiscExpRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OtherMiscExpComments As System.String 
				Get
					Dim data_ As System.String = entity.OtherMiscExpComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OtherMiscExpComments = Nothing
					Else
						entity.OtherMiscExpComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CVBEGRating As System.String 
				Get
					Dim data_ As System.String = entity.CVBEGRating
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CVBEGRating = Nothing
					Else
						entity.CVBEGRating = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CVBEGComments As System.String 
				Get
					Dim data_ As System.String = entity.CVBEGComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CVBEGComments = Nothing
					Else
						entity.CVBEGComments = Convert.ToString(Value)
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
		  

			Private entity As esNatHazWindMiscellaneousOther
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazWindMiscellaneousOtherMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As NatHazWindMiscellaneousOtherQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazWindMiscellaneousOtherQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As NatHazWindMiscellaneousOtherQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As NatHazWindMiscellaneousOtherQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NatHazWindMiscellaneousOtherQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esNatHazWindMiscellaneousOtherCollection
		Inherits esEntityCollection(Of NatHazWindMiscellaneousOther)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return NatHazWindMiscellaneousOtherMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "NatHazWindMiscellaneousOtherCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As NatHazWindMiscellaneousOtherQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New NatHazWindMiscellaneousOtherQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As NatHazWindMiscellaneousOtherQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New NatHazWindMiscellaneousOtherQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As NatHazWindMiscellaneousOtherQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, NatHazWindMiscellaneousOtherQuery))
		End Sub
		
		#End Region
						
		Private m_query As NatHazWindMiscellaneousOtherQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esNatHazWindMiscellaneousOtherQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NatHazWindMiscellaneousOtherMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "Id" 
					Return Me.Id
				Case "FileNo" 
					Return Me.FileNo
				Case "SurveyDate" 
					Return Me.SurveyDate
				Case "ProjProtRating" 
					Return Me.ProjProtRating
				Case "ProjProtComments" 
					Return Me.ProjProtComments
				Case "OESRGRating" 
					Return Me.OESRGRating
				Case "OESRGComments" 
					Return Me.OESRGComments
				Case "SARating" 
					Return Me.SARating
				Case "SAComments" 
					Return Me.SAComments
				Case "TreesRating" 
					Return Me.TreesRating
				Case "TreesComments" 
					Return Me.TreesComments
				Case "CLCRating" 
					Return Me.CLCRating
				Case "CLCComments" 
					Return Me.CLCComments
				Case "PBRating" 
					Return Me.PBRating
				Case "PBComments" 
					Return Me.PBComments
				Case "EmergRespSuppliesRating" 
					Return Me.EmergRespSuppliesRating
				Case "EmergRespSuppliesComments" 
					Return Me.EmergRespSuppliesComments
				Case "OtherMiscExpRating" 
					Return Me.OtherMiscExpRating
				Case "OtherMiscExpComments" 
					Return Me.OtherMiscExpComments
				Case "CVBEGRating" 
					Return Me.CVBEGRating
				Case "CVBEGComments" 
					Return Me.CVBEGComments
				Case "Importdate" 
					Return Me.Importdate
				Case "Importorigdate" 
					Return Me.Importorigdate
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SurveyDate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.SurveyDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ProjProtRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.ProjProtRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProjProtComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.ProjProtComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OESRGRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.OESRGRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OESRGComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.OESRGComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SARating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.SARating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SAComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.SAComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TreesRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.TreesRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TreesComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.TreesComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CLCRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.CLCRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CLCComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.CLCComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PBRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.PBRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PBComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.PBComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmergRespSuppliesRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.EmergRespSuppliesRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmergRespSuppliesComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.EmergRespSuppliesComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherMiscExpRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.OtherMiscExpRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OtherMiscExpComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.OtherMiscExpComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CVBEGRating As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.CVBEGRating, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CVBEGComments As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.CVBEGComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Importdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.Importdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Importorigdate As esQueryItem
			Get
				Return New esQueryItem(Me, NatHazWindMiscellaneousOtherMetadata.ColumnNames.Importorigdate, esSystemType.DateTime)
			End Get
		End Property 
		
#End Region	
		
	End Class



	<Serializable> _
	Partial Public Class NatHazWindMiscellaneousOtherMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.FileNo
			c.CharacterMaxLength = 9
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SurveyDate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.SurveyDate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.ProjProtRating, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.ProjProtRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.ProjProtComments, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.ProjProtComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OESRGRating, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.OESRGRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OESRGComments, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.OESRGComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SARating, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.SARating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.SAComments, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.SAComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.TreesRating, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.TreesRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.TreesComments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.TreesComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CLCRating, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.CLCRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CLCComments, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.CLCComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.PBRating, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.PBRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.PBComments, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.PBComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.EmergRespSuppliesRating, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.EmergRespSuppliesRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.EmergRespSuppliesComments, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.EmergRespSuppliesComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OtherMiscExpRating, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.OtherMiscExpRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.OtherMiscExpComments, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.OtherMiscExpComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CVBEGRating, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.CVBEGRating
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.CVBEGComments, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.CVBEGComments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Importdate, 21, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.Importdate
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(NatHazWindMiscellaneousOtherMetadata.ColumnNames.Importorigdate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NatHazWindMiscellaneousOtherMetadata.PropertyNames.Importorigdate
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As NatHazWindMiscellaneousOtherMetadata
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
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const ProjProtRating As String = "ProjProtRating"
			 Public Const ProjProtComments As String = "ProjProtComments"
			 Public Const OESRGRating As String = "OES-RGRating"
			 Public Const OESRGComments As String = "OES-RGComments"
			 Public Const SARating As String = "SARating"
			 Public Const SAComments As String = "SAComments"
			 Public Const TreesRating As String = "TreesRating"
			 Public Const TreesComments As String = "TreesComments"
			 Public Const CLCRating As String = "CLCRating"
			 Public Const CLCComments As String = "CLCComments"
			 Public Const PBRating As String = "PBRating"
			 Public Const PBComments As String = "PBComments"
			 Public Const EmergRespSuppliesRating As String = "EmergRespSuppliesRating"
			 Public Const EmergRespSuppliesComments As String = "EmergRespSuppliesComments"
			 Public Const OtherMiscExpRating As String = "OtherMiscExpRating"
			 Public Const OtherMiscExpComments As String = "OtherMiscExpComments"
			 Public Const CVBEGRating As String = "CVBEGRating"
			 Public Const CVBEGComments As String = "CVBEGComments"
			 Public Const Importdate As String = "importdate"
			 Public Const Importorigdate As String = "importorigdate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FileNo As String = "FileNo"
			 Public Const SurveyDate As String = "SurveyDate"
			 Public Const ProjProtRating As String = "ProjProtRating"
			 Public Const ProjProtComments As String = "ProjProtComments"
			 Public Const OESRGRating As String = "OESRGRating"
			 Public Const OESRGComments As String = "OESRGComments"
			 Public Const SARating As String = "SARating"
			 Public Const SAComments As String = "SAComments"
			 Public Const TreesRating As String = "TreesRating"
			 Public Const TreesComments As String = "TreesComments"
			 Public Const CLCRating As String = "CLCRating"
			 Public Const CLCComments As String = "CLCComments"
			 Public Const PBRating As String = "PBRating"
			 Public Const PBComments As String = "PBComments"
			 Public Const EmergRespSuppliesRating As String = "EmergRespSuppliesRating"
			 Public Const EmergRespSuppliesComments As String = "EmergRespSuppliesComments"
			 Public Const OtherMiscExpRating As String = "OtherMiscExpRating"
			 Public Const OtherMiscExpComments As String = "OtherMiscExpComments"
			 Public Const CVBEGRating As String = "CVBEGRating"
			 Public Const CVBEGComments As String = "CVBEGComments"
			 Public Const Importdate As String = "Importdate"
			 Public Const Importorigdate As String = "Importorigdate"
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
			SyncLock GetType(NatHazWindMiscellaneousOtherMetadata)
			
				If NatHazWindMiscellaneousOtherMetadata.mapDelegates Is Nothing Then
					NatHazWindMiscellaneousOtherMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If NatHazWindMiscellaneousOtherMetadata._meta Is Nothing Then
					NatHazWindMiscellaneousOtherMetadata._meta = New NatHazWindMiscellaneousOtherMetadata()
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
				meta.AddTypeMap("FileNo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SurveyDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ProjProtRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProjProtComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("OESRGRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OESRGComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("SARating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SAComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("TreesRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TreesComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("CLCRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CLCComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("PBRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PBComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("EmergRespSuppliesRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmergRespSuppliesComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("OtherMiscExpRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OtherMiscExpComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("CVBEGRating", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CVBEGComments", new esTypeMap("ntext", "System.String"))
				meta.AddTypeMap("Importdate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Importorigdate", new esTypeMap("smalldatetime", "System.DateTime"))			
				
				
				 
				meta.Source = "NatHaz-Wind-MiscellaneousOther"
				meta.Destination = "NatHaz-Wind-MiscellaneousOther"
				
				meta.spInsert = "proc_NatHaz-Wind-MiscellaneousOtherInsert"
				meta.spUpdate = "proc_NatHaz-Wind-MiscellaneousOtherUpdate"
				meta.spDelete = "proc_NatHaz-Wind-MiscellaneousOtherDelete"
				meta.spLoadAll = "proc_NatHaz-Wind-MiscellaneousOtherLoadAll"
				meta.spLoadByPrimaryKey = "proc_NatHaz-Wind-MiscellaneousOtherLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As NatHazWindMiscellaneousOtherMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
