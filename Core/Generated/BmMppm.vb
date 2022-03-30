
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:39 AM
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
	' Encapsulates the 'Cope-BMMPPM' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(BMMPPM))> _
	<XmlType("BMMPPM")> _	
	Partial Public Class BMMPPM 
		Inherits esBMMPPM
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New BMMPPM()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal fileNo As System.String)
			Dim obj As New BMMPPM()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal fileNo As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New BMMPPM()
			obj.FileNo = fileNo
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("BMMPPMCollection")> _
	Partial Public Class BMMPPMCollection
		Inherits esBMMPPMCollection
		Implements IEnumerable(Of BMMPPM)
	
		Public Function FindByPrimaryKey(ByVal fileNo As System.String) As BMMPPM
			Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo)
		End Function


				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(BMMPPM))> _
		Public Class BMMPPMCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of BMMPPMCollection)
			
			Public Shared Widening Operator CType(packet As BMMPPMCollectionWCFPacket) As BMMPPMCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As BMMPPMCollection) As BMMPPMCollectionWCFPacket
				Return New BMMPPMCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	Partial Public Class BMMPPMQuery 
		Inherits esBMMPPMQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BMMPPMQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BMMPPMQuery) As String
			Return BMMPPMQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BMMPPMQuery
			Return DirectCast(BMMPPMQuery.SerializeHelper.FromXml(query, GetType(BMMPPMQuery)), BMMPPMQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esBMMPPM
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fileNo As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileNo)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileNo)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fileNo As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fileNo)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fileNo)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fileNo As System.String) As Boolean
		
			Dim query As New BMMPPMQuery()
			query.Where(query.FileNo = fileNo)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fileNo As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FileNo", fileNo)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Cope-BMMPPM.FileNo
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property FileNo As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.FileNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.FileNo, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.FileNo)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintAdequacy
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintAdequacy As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintAdequacy)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintAdequacy, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintAdequacy)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintCMMS
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintCMMS As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintCMMS)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintCMMS, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintCMMS)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintVibe
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintVibe As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintVibe)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintVibe, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintVibe)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintLubeOil
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintLubeOil As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintLubeOil)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintLubeOil, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintLubeOil)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintNDE
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintNDE As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintNDE)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintNDE, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintNDE)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintOverspeed
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintOverspeed As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintOverspeed)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintOverspeed, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintOverspeed)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintVisual
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintVisual As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintVisual)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintVisual, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintVisual)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintAlign
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintAlign As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintAlign)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintAlign, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintAlign)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintOther
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintOther As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintOther)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintOther, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintOther)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintOtherComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintOtherComments As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintOtherComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintOtherComments, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintOtherComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechPreMaintSpecComments
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechPreMaintSpecComments As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintSpecComments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechPreMaintSpecComments, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechPreMaintSpecComments)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechanicalMainUser1
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechanicalMainUser1 As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechanicalMainUser1)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechanicalMainUser1, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechanicalMainUser1)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechanicalMainUser2
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechanicalMainUser2 As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechanicalMainUser2)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechanicalMainUser2, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechanicalMainUser2)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechanicalMainUser3
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechanicalMainUser3 As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechanicalMainUser3)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechanicalMainUser3, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechanicalMainUser3)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.MechanicalMainUser4
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property MechanicalMainUser4 As System.String
			Get
				Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.MechanicalMainUser4)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.MechanicalMainUser4, value) Then
					OnPropertyChanged(BMMPPMMetadata.PropertyNames.MechanicalMainUser4)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Cope-BMMPPM.FilePrefix
		' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FilePrefix As Nullable(Of System.Int16)
            Get
                Return MyBase.GetSystemString(BMMPPMMetadata.ColumnNames.FilePrefix)
            End Get

            Set(ByVal value As Nullable(Of System.Int16))
                If MyBase.SetSystemString(BMMPPMMetadata.ColumnNames.FilePrefix, value) Then
                    OnPropertyChanged(BMMPPMMetadata.PropertyNames.FilePrefix)
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
												
						Case "MechPreMaintAdequacy"
							Me.str().MechPreMaintAdequacy = CType(value, string)
												
						Case "MechPreMaintCMMS"
							Me.str().MechPreMaintCMMS = CType(value, string)
												
						Case "MechPreMaintVibe"
							Me.str().MechPreMaintVibe = CType(value, string)
												
						Case "MechPreMaintLubeOil"
							Me.str().MechPreMaintLubeOil = CType(value, string)
												
						Case "MechPreMaintNDE"
							Me.str().MechPreMaintNDE = CType(value, string)
												
						Case "MechPreMaintOverspeed"
							Me.str().MechPreMaintOverspeed = CType(value, string)
												
						Case "MechPreMaintVisual"
							Me.str().MechPreMaintVisual = CType(value, string)
												
						Case "MechPreMaintAlign"
							Me.str().MechPreMaintAlign = CType(value, string)
												
						Case "MechPreMaintOther"
							Me.str().MechPreMaintOther = CType(value, string)
												
						Case "MechPreMaintOtherComments"
							Me.str().MechPreMaintOtherComments = CType(value, string)
												
						Case "MechPreMaintSpecComments"
							Me.str().MechPreMaintSpecComments = CType(value, string)
												
						Case "MechanicalMainUser1"
							Me.str().MechanicalMainUser1 = CType(value, string)
												
						Case "MechanicalMainUser2"
							Me.str().MechanicalMainUser2 = CType(value, string)
												
						Case "MechanicalMainUser3"
							Me.str().MechanicalMainUser3 = CType(value, string)
												
						Case "MechanicalMainUser4"
							Me.str().MechanicalMainUser4 = CType(value, string)
												
						Case "FilePrefix"
							Me.str().FilePrefix = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
					
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
		
			Public Sub New(ByVal entity As esBMMPPM)
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
		  	
			Public Property MechPreMaintAdequacy As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintAdequacy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintAdequacy = Nothing
					Else
						entity.MechPreMaintAdequacy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintCMMS As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintCMMS
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintCMMS = Nothing
					Else
						entity.MechPreMaintCMMS = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintVibe As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintVibe
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintVibe = Nothing
					Else
						entity.MechPreMaintVibe = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintLubeOil As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintLubeOil
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintLubeOil = Nothing
					Else
						entity.MechPreMaintLubeOil = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintNDE As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintNDE
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintNDE = Nothing
					Else
						entity.MechPreMaintNDE = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintOverspeed As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintOverspeed
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintOverspeed = Nothing
					Else
						entity.MechPreMaintOverspeed = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintVisual As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintVisual
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintVisual = Nothing
					Else
						entity.MechPreMaintVisual = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintAlign As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintAlign
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintAlign = Nothing
					Else
						entity.MechPreMaintAlign = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintOther As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintOther
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintOther = Nothing
					Else
						entity.MechPreMaintOther = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintOtherComments As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintOtherComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintOtherComments = Nothing
					Else
						entity.MechPreMaintOtherComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechPreMaintSpecComments As System.String 
				Get
					Dim data_ As System.String = entity.MechPreMaintSpecComments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechPreMaintSpecComments = Nothing
					Else
						entity.MechPreMaintSpecComments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechanicalMainUser1 As System.String 
				Get
					Dim data_ As System.String = entity.MechanicalMainUser1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechanicalMainUser1 = Nothing
					Else
						entity.MechanicalMainUser1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechanicalMainUser2 As System.String 
				Get
					Dim data_ As System.String = entity.MechanicalMainUser2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechanicalMainUser2 = Nothing
					Else
						entity.MechanicalMainUser2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechanicalMainUser3 As System.String 
				Get
					Dim data_ As System.String = entity.MechanicalMainUser3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechanicalMainUser3 = Nothing
					Else
						entity.MechanicalMainUser3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MechanicalMainUser4 As System.String 
				Get
					Dim data_ As System.String = entity.MechanicalMainUser4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MechanicalMainUser4 = Nothing
					Else
						entity.MechanicalMainUser4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
            Public Property FilePrefix As Nullable(Of System.Int16)
                Get
                    Dim data_ As System.String = entity.FilePrefix

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As Nullable(Of System.Int16))
                    If String.IsNullOrEmpty(Value) Then
                        entity.FilePrefix = Nothing
                    Else
                        entity.FilePrefix = Convert.ToString(Value)
                    End If
                End Set
            End Property
		  

			Private entity As esBMMPPM
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMMPPMMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BMMPPMQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMMPPMQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BMMPPMQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BMMPPMQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As BMMPPMQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esBMMPPMCollection
		Inherits esEntityCollection(Of BMMPPM)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BMMPPMMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BMMPPMCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BMMPPMQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BMMPPMQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BMMPPMQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BMMPPMQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BMMPPMQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BMMPPMQuery))
		End Sub
		
		#End Region
						
		Private m_query As BMMPPMQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esBMMPPMQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BMMPPMMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "FileNo" 
					Return Me.FileNo
				Case "MechPreMaintAdequacy" 
					Return Me.MechPreMaintAdequacy
				Case "MechPreMaintCMMS" 
					Return Me.MechPreMaintCMMS
				Case "MechPreMaintVibe" 
					Return Me.MechPreMaintVibe
				Case "MechPreMaintLubeOil" 
					Return Me.MechPreMaintLubeOil
				Case "MechPreMaintNDE" 
					Return Me.MechPreMaintNDE
				Case "MechPreMaintOverspeed" 
					Return Me.MechPreMaintOverspeed
				Case "MechPreMaintVisual" 
					Return Me.MechPreMaintVisual
				Case "MechPreMaintAlign" 
					Return Me.MechPreMaintAlign
				Case "MechPreMaintOther" 
					Return Me.MechPreMaintOther
				Case "MechPreMaintOtherComments" 
					Return Me.MechPreMaintOtherComments
				Case "MechPreMaintSpecComments" 
					Return Me.MechPreMaintSpecComments
				Case "MechanicalMainUser1" 
					Return Me.MechanicalMainUser1
				Case "MechanicalMainUser2" 
					Return Me.MechanicalMainUser2
				Case "MechanicalMainUser3" 
					Return Me.MechanicalMainUser3
				Case "MechanicalMainUser4" 
					Return Me.MechanicalMainUser4
				Case "FilePrefix" 
					Return Me.FilePrefix
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property FileNo As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.FileNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintAdequacy As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintAdequacy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintCMMS As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintCMMS, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintVibe As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintVibe, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintLubeOil As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintLubeOil, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintNDE As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintNDE, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintOverspeed As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintOverspeed, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintVisual As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintVisual, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintAlign As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintAlign, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintOther As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintOther, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintOtherComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintOtherComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechPreMaintSpecComments As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechPreMaintSpecComments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechanicalMainUser1 As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechanicalMainUser1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechanicalMainUser2 As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechanicalMainUser2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechanicalMainUser3 As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechanicalMainUser3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MechanicalMainUser4 As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.MechanicalMainUser4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FilePrefix As esQueryItem
			Get
				Return New esQueryItem(Me, BMMPPMMetadata.ColumnNames.FilePrefix, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class BMMPPM 
		Inherits esBMMPPM
		
	
		
		
	End Class
		



	<Serializable> _
	Partial Public Class BMMPPMMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.FileNo
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 9
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintAdequacy, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintAdequacy
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintCMMS, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintCMMS
			c.CharacterMaxLength = 3
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintVibe, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintVibe
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintLubeOil, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintLubeOil
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintNDE, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintNDE
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintOverspeed, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintOverspeed
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintVisual, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintVisual
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintAlign, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintAlign
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintOther, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintOther
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintOtherComments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintOtherComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechPreMaintSpecComments, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechPreMaintSpecComments
			c.CharacterMaxLength = 300
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechanicalMainUser1, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechanicalMainUser1
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechanicalMainUser2, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechanicalMainUser2
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechanicalMainUser3, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechanicalMainUser3
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.MechanicalMainUser4, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = BMMPPMMetadata.PropertyNames.MechanicalMainUser4
			c.CharacterMaxLength = 4000
			c.IsNullable = True
			m_columns.Add(c)
				
            c = New esColumnMetadata(BMMPPMMetadata.ColumnNames.FilePrefix, 16, GetType(System.Int16), esSystemType.String)
			c.PropertyName = BMMPPMMetadata.PropertyNames.FilePrefix
			c.CharacterMaxLength = 14
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BMMPPMMetadata
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
			 Public Const MechPreMaintAdequacy As String = "MechPreMaintAdequacy"
			 Public Const MechPreMaintCMMS As String = "MechPreMaintCMMS"
			 Public Const MechPreMaintVibe As String = "MechPreMaintVibe"
			 Public Const MechPreMaintLubeOil As String = "MechPreMaintLubeOil"
			 Public Const MechPreMaintNDE As String = "MechPreMaintNDE"
			 Public Const MechPreMaintOverspeed As String = "MechPreMaintOverspeed"
			 Public Const MechPreMaintVisual As String = "MechPreMaintVisual"
			 Public Const MechPreMaintAlign As String = "MechPreMaintAlign"
			 Public Const MechPreMaintOther As String = "MechPreMaintOther"
			 Public Const MechPreMaintOtherComments As String = "MechPreMaintOtherComments"
			 Public Const MechPreMaintSpecComments As String = "MechPreMaintSpecComments"
			 Public Const MechanicalMainUser1 As String = "MechanicalMainUser1"
			 Public Const MechanicalMainUser2 As String = "MechanicalMainUser2"
			 Public Const MechanicalMainUser3 As String = "MechanicalMainUser3"
			 Public Const MechanicalMainUser4 As String = "MechanicalMainUser4"
			 Public Const FilePrefix As String = "FilePrefix"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const FileNo As String = "FileNo"
			 Public Const MechPreMaintAdequacy As String = "MechPreMaintAdequacy"
			 Public Const MechPreMaintCMMS As String = "MechPreMaintCMMS"
			 Public Const MechPreMaintVibe As String = "MechPreMaintVibe"
			 Public Const MechPreMaintLubeOil As String = "MechPreMaintLubeOil"
			 Public Const MechPreMaintNDE As String = "MechPreMaintNDE"
			 Public Const MechPreMaintOverspeed As String = "MechPreMaintOverspeed"
			 Public Const MechPreMaintVisual As String = "MechPreMaintVisual"
			 Public Const MechPreMaintAlign As String = "MechPreMaintAlign"
			 Public Const MechPreMaintOther As String = "MechPreMaintOther"
			 Public Const MechPreMaintOtherComments As String = "MechPreMaintOtherComments"
			 Public Const MechPreMaintSpecComments As String = "MechPreMaintSpecComments"
			 Public Const MechanicalMainUser1 As String = "MechanicalMainUser1"
			 Public Const MechanicalMainUser2 As String = "MechanicalMainUser2"
			 Public Const MechanicalMainUser3 As String = "MechanicalMainUser3"
			 Public Const MechanicalMainUser4 As String = "MechanicalMainUser4"
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
			SyncLock GetType(BMMPPMMetadata)
			
				If BMMPPMMetadata.mapDelegates Is Nothing Then
					BMMPPMMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BMMPPMMetadata._meta Is Nothing Then
					BMMPPMMetadata._meta = New BMMPPMMetadata()
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
				meta.AddTypeMap("MechPreMaintAdequacy", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintCMMS", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintVibe", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintLubeOil", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintNDE", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintOverspeed", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintVisual", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintAlign", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintOther", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintOtherComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechPreMaintSpecComments", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechanicalMainUser1", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechanicalMainUser2", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechanicalMainUser3", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MechanicalMainUser4", new esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("FilePrefix", New esTypeMap("smallint", "System.Int16"))
				
				
				 
				meta.Source = "Cope-BMMPPM"
				meta.Destination = "Cope-BMMPPM"
				
				meta.spInsert = "proc_Cope-BMMPPMInsert"
				meta.spUpdate = "proc_Cope-BMMPPMUpdate"
				meta.spDelete = "proc_Cope-BMMPPMDelete"
				meta.spLoadAll = "proc_Cope-BMMPPMLoadAll"
				meta.spLoadByPrimaryKey = "proc_Cope-BMMPPMLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BMMPPMMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
