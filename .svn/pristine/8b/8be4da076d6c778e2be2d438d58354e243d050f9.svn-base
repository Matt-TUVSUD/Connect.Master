
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/10/2019 10:36:41 AM
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
    ' Encapsulates the 'Findings' table
    ' </summary>

    <System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _
    <Serializable> _
    <DataContract> _
    <KnownType(GetType(Findings))> _
    <XmlType("Findings")> _
    Partial Public Class Findings
        Inherits esFindings

        <DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _
        Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
            Get
                Return MyBase.Debug
            End Get
        End Property

        Public Overrides Function CreateInstance() As esEntity
            Return New Findings()
        End Function

#Region "Static Quick Access Methods"
        Public Shared Sub Delete(ByVal fileNo As System.String, ByVal recMonth As System.String, ByVal recNumber As System.Int32, ByVal recYear As System.Int32)
            Dim obj As New Findings()
            obj.FileNo = fileNo
            obj.RecMonth = recMonth
            obj.RecNumber = recNumber
            obj.RecYear = recYear
            obj.AcceptChanges()
            obj.MarkAsDeleted()
            obj.Save()
        End Sub

        Public Shared Sub Delete(ByVal fileNo As System.String, ByVal recMonth As System.String, ByVal recNumber As System.Int32, ByVal recYear As System.Int32, ByVal sqlAccessType As esSqlAccessType)
            Dim obj As New Findings()
            obj.FileNo = fileNo
            obj.RecMonth = recMonth
            obj.RecNumber = recNumber
            obj.RecYear = recYear
            obj.AcceptChanges()
            obj.MarkAsDeleted()
            obj.Save(sqlAccessType)
        End Sub
#End Region



    End Class



    <DebuggerDisplay("Count = {Count}")> _
    <Serializable> _
    <CollectionDataContract> _
    <XmlType("FindingsCollection")> _
    Partial Public Class FindingsCollection
        Inherits esFindingsCollection
        Implements IEnumerable(Of Findings)

        Public Function FindByPrimaryKey(ByVal fileNo As System.String, ByVal recMonth As System.String, ByVal recNumber As System.Int32, ByVal recYear As System.Int32) As Findings
            Return MyBase.SingleOrDefault(Function(e) e.FileNo = fileNo And e.RecMonth = recMonth And e.RecNumber.HasValue AndAlso e.RecNumber.Value = recNumber And e.RecYear.HasValue AndAlso e.RecYear.Value = recYear)
        End Function



#Region "WCF Service Class"

        <DataContract> _
        <KnownType(GetType(Findings))> _
        Public Class FindingsCollectionWCFPacket
            Inherits esCollectionWCFPacket(Of FindingsCollection)

            Public Shared Widening Operator CType(packet As FindingsCollectionWCFPacket) As FindingsCollection
                Return packet.Collection
            End Operator

            Public Shared Widening Operator CType(collection As FindingsCollection) As FindingsCollectionWCFPacket
                Return New FindingsCollectionWCFPacket() With {.Collection = collection}
            End Operator

        End Class

#End Region



    End Class




    <DebuggerDisplay("Query = {Parse()}")> _
    <Serializable> _
    Partial Public Class FindingsQuery
        Inherits esFindingsQuery

        Public Sub New(ByVal joinAlias As String)
            Me.es.JoinAlias = joinAlias
        End Sub

        Protected Overrides Function GetQueryName() As String
            Return "FindingsQuery"
        End Function

#Region "Explicit Casts"

        Public Shared Narrowing Operator CType(ByVal query As FindingsQuery) As String
            Return FindingsQuery.SerializeHelper.ToXml(query)
        End Operator

        Public Shared Narrowing Operator CType(ByVal query As String) As FindingsQuery
            Return DirectCast(FindingsQuery.SerializeHelper.FromXml(query, GetType(FindingsQuery)), FindingsQuery)
        End Operator

#End Region

    End Class


    <DataContract> _
    <Serializable()> _
    Partial Public MustInherit Class esFindings
        Inherits esEntity
        Implements INotifyPropertyChanged

        Public Sub New()

        End Sub

#Region "LoadByPrimaryKey"
        Public Overridable Function LoadByPrimaryKey(ByVal fileNo As System.String, ByVal recMonth As System.String, ByVal recNumber As System.Int32, ByVal recYear As System.Int32) As Boolean

            If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic(fileNo, recMonth, recNumber, recYear)
            Else
                Return LoadByPrimaryKeyStoredProcedure(fileNo, recMonth, recNumber, recYear)
            End If

        End Function

        Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fileNo As System.String, ByVal recMonth As System.String, ByVal recNumber As System.Int32, ByVal recYear As System.Int32) As Boolean

            If sqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic(fileNo, recMonth, recNumber, recYear)
            Else
                Return LoadByPrimaryKeyStoredProcedure(fileNo, recMonth, recNumber, recYear)
            End If

        End Function

        Private Function LoadByPrimaryKeyDynamic(ByVal fileNo As System.String, ByVal recMonth As System.String, ByVal recNumber As System.Int32, ByVal recYear As System.Int32) As Boolean

            Dim query As New FindingsQuery()
            query.Where(query.FileNo = fileNo And query.RecMonth = recMonth And query.RecNumber = recNumber And query.RecYear = recYear)
            Return Me.Load(query)

        End Function

        Private Function LoadByPrimaryKeyStoredProcedure(ByVal fileNo As System.String, ByVal recMonth As System.String, ByVal recNumber As System.Int32, ByVal recYear As System.Int32) As Boolean

            Dim parms As esParameters = New esParameters()
            parms.Add("FileNo", fileNo)
            parms.Add("RecMonth", recMonth)
            parms.Add("RecNumber", recNumber)
            parms.Add("RecYear", recYear)

            Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)

        End Function
#End Region

#Region "Properties"



        ' <summary>
        ' Maps to Findings.FileNo
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FileNo As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.FileNo)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.FileNo, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.FileNo)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RecMonth
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecMonth As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.RecMonth)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.RecMonth, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RecMonth)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RecNumber
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecNumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.RecNumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.RecNumber, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RecNumber)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RecYear
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecYear As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.RecYear)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.RecYear, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RecYear)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Arc#
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property fldArc As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.fldArc)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.fldArc, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.fldArc)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.reportid
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Reportid As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.Reportid)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.Reportid, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Reportid)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.findingno
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Findingno As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(FindingsMetadata.ColumnNames.Findingno)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(FindingsMetadata.ColumnNames.Findingno, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Findingno)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.itemno
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Itemno As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.Itemno)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.Itemno, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Itemno)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.severityrating
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Severityrating As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.Severityrating)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.Severityrating, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Severityrating)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ProbableCause
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ProbableCause As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.ProbableCause)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.ProbableCause, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ProbableCause)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ProbableCauseID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ProbableCauseID As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.ProbableCauseID)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.ProbableCauseID, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ProbableCauseID)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Recommendation
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Recommendation As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.Recommendation)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.Recommendation, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Recommendation)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RecommendationID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecommendationID As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.RecommendationID)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.RecommendationID, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RecommendationID)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.SpecItem
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SpecItem As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.SpecItem)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.SpecItem, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.SpecItem)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.SpecItemID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SpecItemID As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.SpecItemID)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.SpecItemID, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.SpecItemID)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.SpecItemDetail
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SpecItemDetail As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.SpecItemDetail)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.SpecItemDetail, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.SpecItemDetail)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.SpecItemDetailID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SpecItemDetailID As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.SpecItemDetailID)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.SpecItemDetailID, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.SpecItemDetailID)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.FindEquip
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FindEquip As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.FindEquip)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.FindEquip, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.FindEquip)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Load
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property fldLoad As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.fldLoad)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.fldLoad, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.fldLoad)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.PlantAreaAffected
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PlantAreaAffected As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.PlantAreaAffected)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.PlantAreaAffected, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.PlantAreaAffected)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.FaultType
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FaultType As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.FaultType)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.FaultType, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.FaultType)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ProbableEquipmentDamageCost
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ProbableEquipmentDamageCost As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.ProbableEquipmentDamageCost)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.ProbableEquipmentDamageCost, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ProbableEquipmentDamageCost)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.LenghtOfBusinessInterruption
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property LengthOfBusinessInterruption As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.LengthOfBusinessInterruption)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.LengthOfBusinessInterruption, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.LengthOfBusinessInterruption)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.CostOfBusinessInterruption
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property CostOfBusinessInterruption As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.CostOfBusinessInterruption)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.CostOfBusinessInterruption, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.CostOfBusinessInterruption)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.DetectedWith
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property DetectedWith As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.DetectedWith)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.DetectedWith, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.DetectedWith)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Impact
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Impact As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.Impact)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.Impact, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Impact)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Comments2
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Comments2 As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.Comments2)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.Comments2, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Comments2)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.MaxTemp
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MaxTemp As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(FindingsMetadata.ColumnNames.MaxTemp)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(FindingsMetadata.ColumnNames.MaxTemp, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.MaxTemp)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RefTemp
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RefTemp As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(FindingsMetadata.ColumnNames.RefTemp)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(FindingsMetadata.ColumnNames.RefTemp, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RefTemp)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RiseTemp
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RiseTemp As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(FindingsMetadata.ColumnNames.RiseTemp)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(FindingsMetadata.ColumnNames.RiseTemp, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RiseTemp)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.PrevenativeMaintenance
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PreventativeMaintenance As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.PreventativeMaintenance)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.PreventativeMaintenance, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.PreventativeMaintenance)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Engineering
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Engineering As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.Engineering)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.Engineering, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Engineering)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Construction
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Construction As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.Construction)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.Construction, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Construction)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Age
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Age As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.Age)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.Age, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Age)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.PoorCondition
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PoorCondition As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.PoorCondition)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.PoorCondition, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.PoorCondition)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.NoTimeForMaintenance
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NoTimeForMaintenance As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.NoTimeForMaintenance)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.NoTimeForMaintenance, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.NoTimeForMaintenance)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.PoorMaintenance
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PoorMaintenance As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.PoorMaintenance)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.PoorMaintenance, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.PoorMaintenance)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Heat
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Heat As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.Heat)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.Heat, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Heat)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Water
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Water As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.Water)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.Water, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Water)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Vibration
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Vibration As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.Vibration)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.Vibration, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Vibration)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Contamination
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Contamination As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.Contamination)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.Contamination, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Contamination)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.NoRiskIQ
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NoRiskIQ As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.NoRiskIQ)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.NoRiskIQ, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.NoRiskIQ)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.LastUpdated
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property LastUpdated As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.LastUpdated)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.LastUpdated, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.LastUpdated)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RecStatus
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecStatus As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.RecStatus)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.RecStatus, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RecStatus)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.StatusDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property StatusDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.StatusDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.StatusDate, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.StatusDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ResponseFrom
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ResponseFrom As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.ResponseFrom)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.ResponseFrom, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ResponseFrom)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ResponseDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ResponseDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.ResponseDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.ResponseDate, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ResponseDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ResponseComment
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ResponseComment As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.ResponseComment)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.ResponseComment, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ResponseComment)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ResponseStatus
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ResponseStatus As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.ResponseStatus)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.ResponseStatus, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ResponseStatus)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.FollowupDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FollowupDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.FollowupDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.FollowupDate, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.FollowupDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.FollowupNumber
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FollowupNumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.FollowupNumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.FollowupNumber, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.FollowupNumber)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RedundancySpare
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RedundancySpare As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.RedundancySpare)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.RedundancySpare, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RedundancySpare)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RecPrimary
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecPrimary As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.RecPrimary)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.RecPrimary, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RecPrimary)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.RecSecondary
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecSecondary As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.RecSecondary)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.RecSecondary, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.RecSecondary)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.IntendedAction
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property IntendedAction As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.IntendedAction)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.IntendedAction, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.IntendedAction)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.PlantComment
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PlantComment As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.PlantComment)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.PlantComment, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.PlantComment)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.DateOfOrigination
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property DateOfOrigination As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.DateOfOrigination)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.DateOfOrigination, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.DateOfOrigination)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.DateOfOriginalImport
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property DateOfOriginalImport As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.DateOfOriginalImport)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.DateOfOriginalImport, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.DateOfOriginalImport)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.DateOfLastImport
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property DateOfLastImport As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.DateOfLastImport)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.DateOfLastImport, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.DateOfLastImport)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Id As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.Id)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.Id, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Id)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Object
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property fldObject As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.fldObject)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.fldObject, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.fldObject)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.History
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property History As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.History)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.History, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.History)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Comments
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Comments As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.Comments)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.Comments, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Comments)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ExpectedCompletionDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ExpectedCompletionDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.ExpectedCompletionDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.ExpectedCompletionDate, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ExpectedCompletionDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.EzyUserID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property EzyUserID As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.EzyUserID)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.EzyUserID, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.EzyUserID)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.SyncId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SyncId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.SyncId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.SyncId, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.SyncId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.MgmtRespDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MgmtRespDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.MgmtRespDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.MgmtRespDate, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.MgmtRespDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.MgmtRespFrom
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MgmtRespFrom As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.MgmtRespFrom)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.MgmtRespFrom, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.MgmtRespFrom)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.MgmtRespAction
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MgmtRespAction As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.MgmtRespAction)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.MgmtRespAction, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.MgmtRespAction)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.MgmtRespComment
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MgmtRespComment As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.MgmtRespComment)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.MgmtRespComment, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.MgmtRespComment)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.CommentsID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property CommentsID As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.CommentsID)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.CommentsID, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.CommentsID)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.Exported
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Exported As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(FindingsMetadata.ColumnNames.Exported)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(FindingsMetadata.ColumnNames.Exported, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Exported)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.KFTS
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Kfts As System.Byte()
            Get
                Return MyBase.GetSystemByteArray(FindingsMetadata.ColumnNames.Kfts)
            End Get

            Set(ByVal value As System.Byte())
                If MyBase.SetSystemByteArray(FindingsMetadata.ColumnNames.Kfts, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.Kfts)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ReorderNumber
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ReorderNumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(FindingsMetadata.ColumnNames.ReorderNumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(FindingsMetadata.ColumnNames.ReorderNumber, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ReorderNumber)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.TimeData
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property TimeData As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.TimeData)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.TimeData, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.TimeData)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ThirdLevelRespDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ThirdLevelRespDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(FindingsMetadata.ColumnNames.ThirdLevelRespDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(FindingsMetadata.ColumnNames.ThirdLevelRespDate, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ThirdLevelRespDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ThirdLevelRespFrom
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ThirdLevelRespFrom As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.ThirdLevelRespFrom)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.ThirdLevelRespFrom, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ThirdLevelRespFrom)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ThirdLevelRespAction
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ThirdLevelRespAction As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.ThirdLevelRespAction)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.ThirdLevelRespAction, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ThirdLevelRespAction)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.ThirdLevelRespComment
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ThirdLevelRespComment As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.ThirdLevelRespComment)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.ThirdLevelRespComment, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.ThirdLevelRespComment)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Findings.UpdateBy
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property UpdateBy As System.String
            Get
                Return MyBase.GetSystemString(FindingsMetadata.ColumnNames.UpdateBy)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(FindingsMetadata.ColumnNames.UpdateBy, value) Then
                    OnPropertyChanged(FindingsMetadata.PropertyNames.UpdateBy)
                End If
            End Set
        End Property

#End Region

#Region ".str() Properties"

        Public Overrides Sub SetProperties(values As IDictionary)

            Dim propertyName As String
            For Each propertyName In values.Keys
                Me.SetProperty(propertyName, values(propertyName))
            Next

        End Sub

        Public Overrides Sub SetProperty(name As String, value As Object)

            Dim col As esColumnMetadata = Me.Meta.Columns.FindByPropertyName(name)
            If Not col Is Nothing Then

                If value Is Nothing OrElse value.GetType().ToString() = "System.String" Then

                    ' Use the strongly typed property
                    Select Case name

                        Case "FileNo"
                            Me.str().FileNo = CType(value, String)

                        Case "RecMonth"
                            Me.str().RecMonth = CType(value, String)

                        Case "RecNumber"
                            Me.str().RecNumber = CType(value, String)

                        Case "RecYear"
                            Me.str().RecYear = CType(value, String)

                        Case "fldArc"
                            Me.str().fldArc = CType(value, String)

                        Case "Reportid"
                            Me.str().Reportid = CType(value, String)

                        Case "Findingno"
                            Me.str().Findingno = CType(value, String)

                        Case "Itemno"
                            Me.str().Itemno = CType(value, String)

                        Case "Severityrating"
                            Me.str().Severityrating = CType(value, String)

                        Case "ProbableCause"
                            Me.str().ProbableCause = CType(value, String)

                        Case "ProbableCauseID"
                            Me.str().ProbableCauseID = CType(value, String)

                        Case "Recommendation"
                            Me.str().Recommendation = CType(value, String)

                        Case "RecommendationID"
                            Me.str().RecommendationID = CType(value, String)

                        Case "SpecItem"
                            Me.str().SpecItem = CType(value, String)

                        Case "SpecItemID"
                            Me.str().SpecItemID = CType(value, String)

                        Case "SpecItemDetail"
                            Me.str().SpecItemDetail = CType(value, String)

                        Case "SpecItemDetailID"
                            Me.str().SpecItemDetailID = CType(value, String)

                        Case "FindEquip"
                            Me.str().FindEquip = CType(value, String)

                        Case "fldLoad"
                            Me.str().fldLoad = CType(value, String)

                        Case "PlantAreaAffected"
                            Me.str().PlantAreaAffected = CType(value, String)

                        Case "FaultType"
                            Me.str().FaultType = CType(value, String)

                        Case "ProbableEquipmentDamageCost"
                            Me.str().ProbableEquipmentDamageCost = CType(value, String)

                        Case "LengthOfBusinessInterruption"
                            Me.str().LengthOfBusinessInterruption = CType(value, String)

                        Case "CostOfBusinessInterruption"
                            Me.str().CostOfBusinessInterruption = CType(value, String)

                        Case "DetectedWith"
                            Me.str().DetectedWith = CType(value, String)

                        Case "Impact"
                            Me.str().Impact = CType(value, String)

                        Case "Comments2"
                            Me.str().Comments2 = CType(value, String)

                        Case "MaxTemp"
                            Me.str().MaxTemp = CType(value, String)

                        Case "RefTemp"
                            Me.str().RefTemp = CType(value, String)

                        Case "RiseTemp"
                            Me.str().RiseTemp = CType(value, String)

                        Case "PreventativeMaintenance"
                            Me.str().PreventativeMaintenance = CType(value, String)

                        Case "Engineering"
                            Me.str().Engineering = CType(value, String)

                        Case "Construction"
                            Me.str().Construction = CType(value, String)

                        Case "Age"
                            Me.str().Age = CType(value, String)

                        Case "PoorCondition"
                            Me.str().PoorCondition = CType(value, String)

                        Case "NoTimeForMaintenance"
                            Me.str().NoTimeForMaintenance = CType(value, String)

                        Case "PoorMaintenance"
                            Me.str().PoorMaintenance = CType(value, String)

                        Case "Heat"
                            Me.str().Heat = CType(value, String)

                        Case "Water"
                            Me.str().Water = CType(value, String)

                        Case "Vibration"
                            Me.str().Vibration = CType(value, String)

                        Case "Contamination"
                            Me.str().Contamination = CType(value, String)

                        Case "NoRiskIQ"
                            Me.str().NoRiskIQ = CType(value, String)

                        Case "LastUpdated"
                            Me.str().LastUpdated = CType(value, String)

                        Case "RecStatus"
                            Me.str().RecStatus = CType(value, String)

                        Case "StatusDate"
                            Me.str().StatusDate = CType(value, String)

                        Case "ResponseFrom"
                            Me.str().ResponseFrom = CType(value, String)

                        Case "ResponseDate"
                            Me.str().ResponseDate = CType(value, String)

                        Case "ResponseComment"
                            Me.str().ResponseComment = CType(value, String)

                        Case "ResponseStatus"
                            Me.str().ResponseStatus = CType(value, String)

                        Case "FollowupDate"
                            Me.str().FollowupDate = CType(value, String)

                        Case "FollowupNumber"
                            Me.str().FollowupNumber = CType(value, String)

                        Case "RedundancySpare"
                            Me.str().RedundancySpare = CType(value, String)

                        Case "RecPrimary"
                            Me.str().RecPrimary = CType(value, String)

                        Case "RecSecondary"
                            Me.str().RecSecondary = CType(value, String)

                        Case "IntendedAction"
                            Me.str().IntendedAction = CType(value, String)

                        Case "PlantComment"
                            Me.str().PlantComment = CType(value, String)

                        Case "DateOfOrigination"
                            Me.str().DateOfOrigination = CType(value, String)

                        Case "DateOfOriginalImport"
                            Me.str().DateOfOriginalImport = CType(value, String)

                        Case "DateOfLastImport"
                            Me.str().DateOfLastImport = CType(value, String)

                        Case "Id"
                            Me.str().Id = CType(value, String)

                        Case "fldObject"
                            Me.str().fldObject = CType(value, String)

                        Case "History"
                            Me.str().History = CType(value, String)

                        Case "Comments"
                            Me.str().Comments = CType(value, String)

                        Case "ExpectedCompletionDate"
                            Me.str().ExpectedCompletionDate = CType(value, String)

                        Case "EzyUserID"
                            Me.str().EzyUserID = CType(value, String)

                        Case "SyncId"
                            Me.str().SyncId = CType(value, String)

                        Case "MgmtRespDate"
                            Me.str().MgmtRespDate = CType(value, String)

                        Case "MgmtRespFrom"
                            Me.str().MgmtRespFrom = CType(value, String)

                        Case "MgmtRespAction"
                            Me.str().MgmtRespAction = CType(value, String)

                        Case "MgmtRespComment"
                            Me.str().MgmtRespComment = CType(value, String)

                        Case "CommentsID"
                            Me.str().CommentsID = CType(value, String)

                        Case "Exported"
                            Me.str().Exported = CType(value, String)

                        Case "ReorderNumber"
                            Me.str().ReorderNumber = CType(value, String)

                        Case "TimeData"
                            Me.str().TimeData = CType(value, String)

                        Case "ThirdLevelRespDate"
                            Me.str().ThirdLevelRespDate = CType(value, String)

                        Case "ThirdLevelRespFrom"
                            Me.str().ThirdLevelRespFrom = CType(value, String)

                        Case "ThirdLevelRespAction"
                            Me.str().ThirdLevelRespAction = CType(value, String)

                        Case "ThirdLevelRespComment"
                            Me.str().ThirdLevelRespComment = CType(value, String)

                        Case "UpdateBy"
                            Me.str().UpdateBy = CType(value, String)

                    End Select

                Else

                    Select Case name

                        Case "RecNumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.RecNumber = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.RecNumber)
                            End If

                        Case "RecYear"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.RecYear = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.RecYear)
                            End If

                        Case "Reportid"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Reportid = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Reportid)
                            End If

                        Case "Findingno"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.Findingno = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Findingno)
                            End If

                        Case "Itemno"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Itemno = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Itemno)
                            End If

                        Case "ProbableCauseID"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.ProbableCauseID = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.ProbableCauseID)
                            End If

                        Case "RecommendationID"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.RecommendationID = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.RecommendationID)
                            End If

                        Case "SpecItemID"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.SpecItemID = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.SpecItemID)
                            End If

                        Case "SpecItemDetailID"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.SpecItemDetailID = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.SpecItemDetailID)
                            End If

                        Case "ProbableEquipmentDamageCost"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.ProbableEquipmentDamageCost = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.ProbableEquipmentDamageCost)
                            End If

                        Case "CostOfBusinessInterruption"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.CostOfBusinessInterruption = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.CostOfBusinessInterruption)
                            End If

                        Case "MaxTemp"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.MaxTemp = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.MaxTemp)
                            End If

                        Case "RefTemp"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.RefTemp = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.RefTemp)
                            End If

                        Case "RiseTemp"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.RiseTemp = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.RiseTemp)
                            End If

                        Case "PreventativeMaintenance"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.PreventativeMaintenance = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.PreventativeMaintenance)
                            End If

                        Case "Engineering"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.Engineering = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Engineering)
                            End If

                        Case "Construction"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.Construction = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Construction)
                            End If

                        Case "Age"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.Age = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Age)
                            End If

                        Case "PoorCondition"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.PoorCondition = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.PoorCondition)
                            End If

                        Case "NoTimeForMaintenance"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.NoTimeForMaintenance = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.NoTimeForMaintenance)
                            End If

                        Case "PoorMaintenance"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.PoorMaintenance = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.PoorMaintenance)
                            End If

                        Case "Heat"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.Heat = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Heat)
                            End If

                        Case "Water"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.Water = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Water)
                            End If

                        Case "Vibration"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.Vibration = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Vibration)
                            End If

                        Case "Contamination"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.Contamination = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Contamination)
                            End If

                        Case "NoRiskIQ"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.NoRiskIQ = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.NoRiskIQ)
                            End If

                        Case "LastUpdated"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.LastUpdated = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.LastUpdated)
                            End If

                        Case "StatusDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.StatusDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.StatusDate)
                            End If

                        Case "ResponseDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.ResponseDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.ResponseDate)
                            End If

                        Case "FollowupDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.FollowupDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.FollowupDate)
                            End If

                        Case "FollowupNumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.FollowupNumber = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.FollowupNumber)
                            End If

                        Case "DateOfOrigination"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.DateOfOrigination = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.DateOfOrigination)
                            End If

                        Case "DateOfOriginalImport"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.DateOfOriginalImport = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.DateOfOriginalImport)
                            End If

                        Case "DateOfLastImport"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.DateOfLastImport = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.DateOfLastImport)
                            End If

                        Case "Id"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Id = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Id)
                            End If

                        Case "ExpectedCompletionDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.ExpectedCompletionDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.ExpectedCompletionDate)
                            End If

                        Case "EzyUserID"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.EzyUserID = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.EzyUserID)
                            End If

                        Case "SyncId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.SyncId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.SyncId)
                            End If

                        Case "MgmtRespDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.MgmtRespDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.MgmtRespDate)
                            End If

                        Case "CommentsID"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.CommentsID = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.CommentsID)
                            End If

                        Case "Exported"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.Exported = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Exported)
                            End If

                        Case "Kfts"

                            If value Is Nothing Or value.GetType().ToString() = "System.Byte()" Then
                                Me.Kfts = CType(value, System.Byte())
                                OnPropertyChanged(FindingsMetadata.PropertyNames.Kfts)
                            End If

                        Case "ReorderNumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.ReorderNumber = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.ReorderNumber)
                            End If

                        Case "ThirdLevelRespDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.ThirdLevelRespDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(FindingsMetadata.PropertyNames.ThirdLevelRespDate)
                            End If


                        Case Else

                    End Select
                End If

            ElseIf Me.ContainsColumn(name) Then
                Me.SetColumn(name, value)
            Else
                Throw New Exception("SetProperty Error: '" + name + "' not found")
            End If

        End Sub

        Public Function str() As esStrings

            If _esstrings Is Nothing Then
                _esstrings = New esStrings(Me)
            End If
            Return _esstrings

        End Function

        Public NotInheritable Class esStrings

            Public Sub New(ByVal entity As esFindings)
                Me.entity = entity
            End Sub


            Public Property FileNo As System.String
                Get
                    Dim data_ As System.String = entity.FileNo

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.FileNo = Nothing
                    Else
                        entity.FileNo = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property RecMonth As System.String
                Get
                    Dim data_ As System.String = entity.RecMonth

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecMonth = Nothing
                    Else
                        entity.RecMonth = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property RecNumber As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.RecNumber

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecNumber = Nothing
                    Else
                        entity.RecNumber = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property RecYear As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.RecYear

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecYear = Nothing
                    Else
                        entity.RecYear = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property fldArc As System.String
                Get
                    Dim data_ As System.String = entity.fldArc

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.fldArc = Nothing
                    Else
                        entity.fldArc = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Reportid As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Reportid

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Reportid = Nothing
                    Else
                        entity.Reportid = Convert.ToInt32(Value)
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

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Findingno = Nothing
                    Else
                        entity.Findingno = Convert.ToDouble(Value)
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

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Itemno = Nothing
                    Else
                        entity.Itemno = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Severityrating As System.String
                Get
                    Dim data_ As System.String = entity.Severityrating

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Severityrating = Nothing
                    Else
                        entity.Severityrating = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ProbableCause As System.String
                Get
                    Dim data_ As System.String = entity.ProbableCause

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ProbableCause = Nothing
                    Else
                        entity.ProbableCause = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ProbableCauseID As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.ProbableCauseID

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ProbableCauseID = Nothing
                    Else
                        entity.ProbableCauseID = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Recommendation As System.String
                Get
                    Dim data_ As System.String = entity.Recommendation

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Recommendation = Nothing
                    Else
                        entity.Recommendation = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property RecommendationID As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.RecommendationID

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecommendationID = Nothing
                    Else
                        entity.RecommendationID = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property SpecItem As System.String
                Get
                    Dim data_ As System.String = entity.SpecItem

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SpecItem = Nothing
                    Else
                        entity.SpecItem = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property SpecItemID As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.SpecItemID

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SpecItemID = Nothing
                    Else
                        entity.SpecItemID = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property SpecItemDetail As System.String
                Get
                    Dim data_ As System.String = entity.SpecItemDetail

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SpecItemDetail = Nothing
                    Else
                        entity.SpecItemDetail = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property SpecItemDetailID As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.SpecItemDetailID

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SpecItemDetailID = Nothing
                    Else
                        entity.SpecItemDetailID = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property FindEquip As System.String
                Get
                    Dim data_ As System.String = entity.FindEquip

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.FindEquip = Nothing
                    Else
                        entity.FindEquip = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property fldLoad As System.String
                Get
                    Dim data_ As System.String = entity.fldLoad

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.fldLoad = Nothing
                    Else
                        entity.fldLoad = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property PlantAreaAffected As System.String
                Get
                    Dim data_ As System.String = entity.PlantAreaAffected

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PlantAreaAffected = Nothing
                    Else
                        entity.PlantAreaAffected = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property FaultType As System.String
                Get
                    Dim data_ As System.String = entity.FaultType

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.FaultType = Nothing
                    Else
                        entity.FaultType = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ProbableEquipmentDamageCost As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.ProbableEquipmentDamageCost

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ProbableEquipmentDamageCost = Nothing
                    Else
                        entity.ProbableEquipmentDamageCost = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property LengthOfBusinessInterruption As System.String
                Get
                    Dim data_ As System.String = entity.LengthOfBusinessInterruption

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.LengthOfBusinessInterruption = Nothing
                    Else
                        entity.LengthOfBusinessInterruption = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property CostOfBusinessInterruption As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.CostOfBusinessInterruption

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.CostOfBusinessInterruption = Nothing
                    Else
                        entity.CostOfBusinessInterruption = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property DetectedWith As System.String
                Get
                    Dim data_ As System.String = entity.DetectedWith

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.DetectedWith = Nothing
                    Else
                        entity.DetectedWith = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Impact As System.String
                Get
                    Dim data_ As System.String = entity.Impact

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Impact = Nothing
                    Else
                        entity.Impact = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Comments2 As System.String
                Get
                    Dim data_ As System.String = entity.Comments2

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Comments2 = Nothing
                    Else
                        entity.Comments2 = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property MaxTemp As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.MaxTemp

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.MaxTemp = Nothing
                    Else
                        entity.MaxTemp = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property RefTemp As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.RefTemp

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RefTemp = Nothing
                    Else
                        entity.RefTemp = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property RiseTemp As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.RiseTemp

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RiseTemp = Nothing
                    Else
                        entity.RiseTemp = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property PreventativeMaintenance As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.PreventativeMaintenance

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PreventativeMaintenance = Nothing
                    Else
                        entity.PreventativeMaintenance = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property Engineering As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.Engineering

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Engineering = Nothing
                    Else
                        entity.Engineering = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property Construction As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.Construction

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Construction = Nothing
                    Else
                        entity.Construction = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property Age As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.Age

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Age = Nothing
                    Else
                        entity.Age = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property PoorCondition As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.PoorCondition

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PoorCondition = Nothing
                    Else
                        entity.PoorCondition = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property NoTimeForMaintenance As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.NoTimeForMaintenance

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NoTimeForMaintenance = Nothing
                    Else
                        entity.NoTimeForMaintenance = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property PoorMaintenance As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.PoorMaintenance

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PoorMaintenance = Nothing
                    Else
                        entity.PoorMaintenance = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property Heat As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.Heat

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Heat = Nothing
                    Else
                        entity.Heat = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property Water As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.Water

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Water = Nothing
                    Else
                        entity.Water = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property Vibration As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.Vibration

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Vibration = Nothing
                    Else
                        entity.Vibration = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property Contamination As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.Contamination

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Contamination = Nothing
                    Else
                        entity.Contamination = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property NoRiskIQ As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.NoRiskIQ

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NoRiskIQ = Nothing
                    Else
                        entity.NoRiskIQ = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property LastUpdated As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.LastUpdated

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.LastUpdated = Nothing
                    Else
                        entity.LastUpdated = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property RecStatus As System.String
                Get
                    Dim data_ As System.String = entity.RecStatus

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecStatus = Nothing
                    Else
                        entity.RecStatus = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property StatusDate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.StatusDate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.StatusDate = Nothing
                    Else
                        entity.StatusDate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property ResponseFrom As System.String
                Get
                    Dim data_ As System.String = entity.ResponseFrom

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ResponseFrom = Nothing
                    Else
                        entity.ResponseFrom = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ResponseDate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.ResponseDate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ResponseDate = Nothing
                    Else
                        entity.ResponseDate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property ResponseComment As System.String
                Get
                    Dim data_ As System.String = entity.ResponseComment

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ResponseComment = Nothing
                    Else
                        entity.ResponseComment = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ResponseStatus As System.String
                Get
                    Dim data_ As System.String = entity.ResponseStatus

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ResponseStatus = Nothing
                    Else
                        entity.ResponseStatus = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property FollowupDate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.FollowupDate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.FollowupDate = Nothing
                    Else
                        entity.FollowupDate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property FollowupNumber As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.FollowupNumber

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.FollowupNumber = Nothing
                    Else
                        entity.FollowupNumber = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property RedundancySpare As System.String
                Get
                    Dim data_ As System.String = entity.RedundancySpare

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RedundancySpare = Nothing
                    Else
                        entity.RedundancySpare = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property RecPrimary As System.String
                Get
                    Dim data_ As System.String = entity.RecPrimary

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecPrimary = Nothing
                    Else
                        entity.RecPrimary = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property RecSecondary As System.String
                Get
                    Dim data_ As System.String = entity.RecSecondary

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecSecondary = Nothing
                    Else
                        entity.RecSecondary = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property IntendedAction As System.String
                Get
                    Dim data_ As System.String = entity.IntendedAction

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.IntendedAction = Nothing
                    Else
                        entity.IntendedAction = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property PlantComment As System.String
                Get
                    Dim data_ As System.String = entity.PlantComment

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PlantComment = Nothing
                    Else
                        entity.PlantComment = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property DateOfOrigination As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.DateOfOrigination

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.DateOfOrigination = Nothing
                    Else
                        entity.DateOfOrigination = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property DateOfOriginalImport As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.DateOfOriginalImport

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.DateOfOriginalImport = Nothing
                    Else
                        entity.DateOfOriginalImport = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property DateOfLastImport As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.DateOfLastImport

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.DateOfLastImport = Nothing
                    Else
                        entity.DateOfLastImport = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property Id As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.Id

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Id = Nothing
                    Else
                        entity.Id = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property fldObject As System.String
                Get
                    Dim data_ As System.String = entity.fldObject

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.fldObject = Nothing
                    Else
                        entity.fldObject = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property History As System.String
                Get
                    Dim data_ As System.String = entity.History

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.History = Nothing
                    Else
                        entity.History = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Comments As System.String
                Get
                    Dim data_ As System.String = entity.Comments

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Comments = Nothing
                    Else
                        entity.Comments = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ExpectedCompletionDate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.ExpectedCompletionDate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ExpectedCompletionDate = Nothing
                    Else
                        entity.ExpectedCompletionDate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property EzyUserID As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.EzyUserID

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.EzyUserID = Nothing
                    Else
                        entity.EzyUserID = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property SyncId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.SyncId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SyncId = Nothing
                    Else
                        entity.SyncId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property MgmtRespDate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.MgmtRespDate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.MgmtRespDate = Nothing
                    Else
                        entity.MgmtRespDate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property MgmtRespFrom As System.String
                Get
                    Dim data_ As System.String = entity.MgmtRespFrom

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.MgmtRespFrom = Nothing
                    Else
                        entity.MgmtRespFrom = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property MgmtRespAction As System.String
                Get
                    Dim data_ As System.String = entity.MgmtRespAction

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.MgmtRespAction = Nothing
                    Else
                        entity.MgmtRespAction = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property MgmtRespComment As System.String
                Get
                    Dim data_ As System.String = entity.MgmtRespComment

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.MgmtRespComment = Nothing
                    Else
                        entity.MgmtRespComment = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property CommentsID As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.CommentsID

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.CommentsID = Nothing
                    Else
                        entity.CommentsID = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property Exported As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.Exported

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Exported = Nothing
                    Else
                        entity.Exported = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property ReorderNumber As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.ReorderNumber

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ReorderNumber = Nothing
                    Else
                        entity.ReorderNumber = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property TimeData As System.String
                Get
                    Dim data_ As System.String = entity.TimeData

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.TimeData = Nothing
                    Else
                        entity.TimeData = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ThirdLevelRespDate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.ThirdLevelRespDate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ThirdLevelRespDate = Nothing
                    Else
                        entity.ThirdLevelRespDate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property ThirdLevelRespFrom As System.String
                Get
                    Dim data_ As System.String = entity.ThirdLevelRespFrom

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ThirdLevelRespFrom = Nothing
                    Else
                        entity.ThirdLevelRespFrom = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ThirdLevelRespAction As System.String
                Get
                    Dim data_ As System.String = entity.ThirdLevelRespAction

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ThirdLevelRespAction = Nothing
                    Else
                        entity.ThirdLevelRespAction = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ThirdLevelRespComment As System.String
                Get
                    Dim data_ As System.String = entity.ThirdLevelRespComment

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ThirdLevelRespComment = Nothing
                    Else
                        entity.ThirdLevelRespComment = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property UpdateBy As System.String
                Get
                    Dim data_ As System.String = entity.UpdateBy

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.UpdateBy = Nothing
                    Else
                        entity.UpdateBy = Convert.ToString(Value)
                    End If
                End Set
            End Property


            Private entity As esFindings
        End Class


        <NonSerialized> _
        <IgnoreDataMember> _
              Private _esstrings As esStrings

#End Region

#Region "Housekeeping methods"

        Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return FindingsMetadata.Meta()
            End Get
        End Property

#End Region

#Region "Query Logic"

        Public ReadOnly Property Query() As FindingsQuery
            Get
                If Me.m_query Is Nothing Then
                    Me.m_query = New FindingsQuery()
                    InitQuery(Me.m_query)
                End If

                Return Me.m_query
            End Get
        End Property

        Public Overloads Function Load(ByVal query As FindingsQuery) As Boolean
            Me.m_query = query
            InitQuery(Me.m_query)
            Return Me.Query.Load()
        End Function

        Protected Sub InitQuery(ByVal query As FindingsQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded

            If Not query.es2.HasConnection Then
                query.es2.Connection = DirectCast(Me, IEntity).Connection
            End If
        End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As FindingsQuery

    End Class



    <Serializable()> _
    Partial Public MustInherit Class esFindingsCollection
        Inherits esEntityCollection(Of Findings)

#Region "Housekeeping methods"
        Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return FindingsMetadata.Meta()
            End Get
        End Property

        Protected Overloads Overrides Function GetCollectionName() As String
            Return "FindingsCollection"
        End Function

#End Region

#Region "Query Logic"


        <BrowsableAttribute(False)> _
        Public ReadOnly Property Query() As FindingsQuery
            Get
                If Me.m_query Is Nothing Then
                    Me.m_query = New FindingsQuery()
                    InitQuery(Me.m_query)
                End If

                Return Me.m_query
            End Get
        End Property

        Public Overloads Function Load(ByVal query As FindingsQuery) As Boolean
            Me.m_query = query
            InitQuery(Me.m_query)
            Return Query.Load()
        End Function

        Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
            If Me.m_query Is Nothing Then
                Me.m_query = New FindingsQuery()
                Me.InitQuery(m_query)
            End If
            Return Me.m_query
        End Function

        Protected Sub InitQuery(ByVal query As FindingsQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded

            If Not query.es2.HasConnection Then
                query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
            End If
        End Sub

        Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
            Me.InitQuery(DirectCast(query, FindingsQuery))
        End Sub

#End Region

        Private m_query As FindingsQuery
    End Class



    <Serializable> _
    Partial Public MustInherit Class esFindingsQuery
        Inherits esDynamicQuery

        Protected Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return FindingsMetadata.Meta()
            End Get
        End Property

#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
                Case "FileNo"
                    Return Me.FileNo
                Case "RecMonth"
                    Return Me.RecMonth
                Case "RecNumber"
                    Return Me.RecNumber
                Case "RecYear"
                    Return Me.RecYear
                Case "fldArc"
                    Return Me.fldArc
                Case "Reportid"
                    Return Me.Reportid
                Case "Findingno"
                    Return Me.Findingno
                Case "Itemno"
                    Return Me.Itemno
                Case "Severityrating"
                    Return Me.Severityrating
                Case "ProbableCause"
                    Return Me.ProbableCause
                Case "ProbableCauseID"
                    Return Me.ProbableCauseID
                Case "Recommendation"
                    Return Me.Recommendation
                Case "RecommendationID"
                    Return Me.RecommendationID
                Case "SpecItem"
                    Return Me.SpecItem
                Case "SpecItemID"
                    Return Me.SpecItemID
                Case "SpecItemDetail"
                    Return Me.SpecItemDetail
                Case "SpecItemDetailID"
                    Return Me.SpecItemDetailID
                Case "FindEquip"
                    Return Me.FindEquip
                Case "fldLoad"
                    Return Me.fldLoad
                Case "PlantAreaAffected"
                    Return Me.PlantAreaAffected
                Case "FaultType"
                    Return Me.FaultType
                Case "ProbableEquipmentDamageCost"
                    Return Me.ProbableEquipmentDamageCost
                Case "LengthOfBusinessInterruption"
                    Return Me.LengthOfBusinessInterruption
                Case "CostOfBusinessInterruption"
                    Return Me.CostOfBusinessInterruption
                Case "DetectedWith"
                    Return Me.DetectedWith
                Case "Impact"
                    Return Me.Impact
                Case "Comments2"
                    Return Me.Comments2
                Case "MaxTemp"
                    Return Me.MaxTemp
                Case "RefTemp"
                    Return Me.RefTemp
                Case "RiseTemp"
                    Return Me.RiseTemp
                Case "PreventativeMaintenance"
                    Return Me.PreventativeMaintenance
                Case "Engineering"
                    Return Me.Engineering
                Case "Construction"
                    Return Me.Construction
                Case "Age"
                    Return Me.Age
                Case "PoorCondition"
                    Return Me.PoorCondition
                Case "NoTimeForMaintenance"
                    Return Me.NoTimeForMaintenance
                Case "PoorMaintenance"
                    Return Me.PoorMaintenance
                Case "Heat"
                    Return Me.Heat
                Case "Water"
                    Return Me.Water
                Case "Vibration"
                    Return Me.Vibration
                Case "Contamination"
                    Return Me.Contamination
                Case "NoRiskIQ"
                    Return Me.NoRiskIQ
                Case "LastUpdated"
                    Return Me.LastUpdated
                Case "RecStatus"
                    Return Me.RecStatus
                Case "StatusDate"
                    Return Me.StatusDate
                Case "ResponseFrom"
                    Return Me.ResponseFrom
                Case "ResponseDate"
                    Return Me.ResponseDate
                Case "ResponseComment"
                    Return Me.ResponseComment
                Case "ResponseStatus"
                    Return Me.ResponseStatus
                Case "FollowupDate"
                    Return Me.FollowupDate
                Case "FollowupNumber"
                    Return Me.FollowupNumber
                Case "RedundancySpare"
                    Return Me.RedundancySpare
                Case "RecPrimary"
                    Return Me.RecPrimary
                Case "RecSecondary"
                    Return Me.RecSecondary
                Case "IntendedAction"
                    Return Me.IntendedAction
                Case "PlantComment"
                    Return Me.PlantComment
                Case "DateOfOrigination"
                    Return Me.DateOfOrigination
                Case "DateOfOriginalImport"
                    Return Me.DateOfOriginalImport
                Case "DateOfLastImport"
                    Return Me.DateOfLastImport
                Case "Id"
                    Return Me.Id
                Case "fldObject"
                    Return Me.fldObject
                Case "History"
                    Return Me.History
                Case "Comments"
                    Return Me.Comments
                Case "ExpectedCompletionDate"
                    Return Me.ExpectedCompletionDate
                Case "EzyUserID"
                    Return Me.EzyUserID
                Case "SyncId"
                    Return Me.SyncId
                Case "MgmtRespDate"
                    Return Me.MgmtRespDate
                Case "MgmtRespFrom"
                    Return Me.MgmtRespFrom
                Case "MgmtRespAction"
                    Return Me.MgmtRespAction
                Case "MgmtRespComment"
                    Return Me.MgmtRespComment
                Case "CommentsID"
                    Return Me.CommentsID
                Case "Exported"
                    Return Me.Exported
                Case "Kfts"
                    Return Me.Kfts
                Case "ReorderNumber"
                    Return Me.ReorderNumber
                Case "TimeData"
                    Return Me.TimeData
                Case "ThirdLevelRespDate"
                    Return Me.ThirdLevelRespDate
                Case "ThirdLevelRespFrom"
                    Return Me.ThirdLevelRespFrom
                Case "ThirdLevelRespAction"
                    Return Me.ThirdLevelRespAction
                Case "ThirdLevelRespComment"
                    Return Me.ThirdLevelRespComment
                Case "UpdateBy"
                    Return Me.UpdateBy
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region

#Region "esQueryItems"


        Public ReadOnly Property FileNo As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.FileNo, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecMonth As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RecMonth, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecNumber As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RecNumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property RecYear As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RecYear, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property fldArc As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.fldArc, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Reportid As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Reportid, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Findingno As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Findingno, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property Itemno As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Itemno, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Severityrating As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Severityrating, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ProbableCause As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ProbableCause, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ProbableCauseID As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ProbableCauseID, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Recommendation As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Recommendation, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecommendationID As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RecommendationID, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property SpecItem As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.SpecItem, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property SpecItemID As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.SpecItemID, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property SpecItemDetail As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.SpecItemDetail, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property SpecItemDetailID As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.SpecItemDetailID, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property FindEquip As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.FindEquip, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property fldLoad As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.fldLoad, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property PlantAreaAffected As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.PlantAreaAffected, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property FaultType As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.FaultType, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ProbableEquipmentDamageCost As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ProbableEquipmentDamageCost, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property LengthOfBusinessInterruption As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.LengthOfBusinessInterruption, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property CostOfBusinessInterruption As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.CostOfBusinessInterruption, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property DetectedWith As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.DetectedWith, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Impact As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Impact, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Comments2 As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Comments2, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property MaxTemp As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.MaxTemp, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property RefTemp As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RefTemp, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property RiseTemp As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RiseTemp, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property PreventativeMaintenance As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.PreventativeMaintenance, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property Engineering As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Engineering, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property Construction As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Construction, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property Age As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Age, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property PoorCondition As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.PoorCondition, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property NoTimeForMaintenance As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.NoTimeForMaintenance, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property PoorMaintenance As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.PoorMaintenance, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property Heat As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Heat, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property Water As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Water, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property Vibration As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Vibration, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property Contamination As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Contamination, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property NoRiskIQ As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.NoRiskIQ, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property LastUpdated As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.LastUpdated, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property RecStatus As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RecStatus, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property StatusDate As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property ResponseFrom As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ResponseFrom, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ResponseDate As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ResponseDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property ResponseComment As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ResponseComment, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ResponseStatus As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ResponseStatus, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property FollowupDate As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.FollowupDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property FollowupNumber As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.FollowupNumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property RedundancySpare As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RedundancySpare, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecPrimary As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RecPrimary, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecSecondary As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.RecSecondary, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property IntendedAction As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.IntendedAction, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property PlantComment As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.PlantComment, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property DateOfOrigination As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.DateOfOrigination, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property DateOfOriginalImport As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.DateOfOriginalImport, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property DateOfLastImport As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.DateOfLastImport, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property Id As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Id, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property fldObject As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.fldObject, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property History As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.History, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Comments As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Comments, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ExpectedCompletionDate As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ExpectedCompletionDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property EzyUserID As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.EzyUserID, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property SyncId As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.SyncId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property MgmtRespDate As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.MgmtRespDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property MgmtRespFrom As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.MgmtRespFrom, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property MgmtRespAction As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.MgmtRespAction, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property MgmtRespComment As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.MgmtRespComment, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property CommentsID As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.CommentsID, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property Exported As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Exported, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property Kfts As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.Kfts, esSystemType.ByteArray)
            End Get
        End Property

        Public ReadOnly Property ReorderNumber As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ReorderNumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property TimeData As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.TimeData, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ThirdLevelRespDate As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ThirdLevelRespDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property ThirdLevelRespFrom As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ThirdLevelRespFrom, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ThirdLevelRespAction As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ThirdLevelRespAction, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ThirdLevelRespComment As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.ThirdLevelRespComment, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property UpdateBy As esQueryItem
            Get
                Return New esQueryItem(Me, FindingsMetadata.ColumnNames.UpdateBy, esSystemType.String)
            End Get
        End Property

#End Region

    End Class



    <Serializable> _
    Partial Public Class FindingsMetadata
        Inherits esMetadata
        Implements IMetadata

#Region "Protected Constructor"
        Protected Sub New()
            m_columns = New esColumnMetadataCollection()
            Dim c As esColumnMetadata

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.FileNo
            c.IsInPrimaryKey = True
            c.CharacterMaxLength = 50
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RecMonth, 1, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.RecMonth
            c.IsInPrimaryKey = True
            c.CharacterMaxLength = 50
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RecNumber, 2, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.RecNumber
            c.IsInPrimaryKey = True
            c.NumericPrecision = 10
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RecYear, 3, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.RecYear
            c.IsInPrimaryKey = True
            c.NumericPrecision = 10
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.fldArc, 4, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.fldArc
            c.CharacterMaxLength = 50
            c.IsNullable = True
            c.Alias = "fldArc"
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Reportid, 5, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.Reportid
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Findingno, 6, GetType(System.Double), esSystemType.Double)
            c.PropertyName = FindingsMetadata.PropertyNames.Findingno
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Itemno, 7, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.Itemno
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Severityrating, 8, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.Severityrating
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ProbableCause, 9, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.ProbableCause
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ProbableCauseID, 10, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.ProbableCauseID
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Recommendation, 11, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.Recommendation
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RecommendationID, 12, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.RecommendationID
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.SpecItem, 13, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.SpecItem
            c.CharacterMaxLength = 120
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.SpecItemID, 14, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.SpecItemID
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.SpecItemDetail, 15, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.SpecItemDetail
            c.CharacterMaxLength = 65
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.SpecItemDetailID, 16, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.SpecItemDetailID
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.FindEquip, 17, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.FindEquip
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.fldLoad, 18, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.fldLoad
            c.CharacterMaxLength = 255
            c.IsNullable = True
            c.Alias = "fldLoad"
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.PlantAreaAffected, 19, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.PlantAreaAffected
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.FaultType, 20, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.FaultType
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ProbableEquipmentDamageCost, 21, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.ProbableEquipmentDamageCost
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.LengthOfBusinessInterruption, 22, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.LengthOfBusinessInterruption
            c.CharacterMaxLength = 50
            c.IsNullable = True
            c.Alias = "LengthOfBusinessInterruption"
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.CostOfBusinessInterruption, 23, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.CostOfBusinessInterruption
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.DetectedWith, 24, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.DetectedWith
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Impact, 25, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.Impact
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Comments2, 26, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.Comments2
            c.CharacterMaxLength = 150
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.MaxTemp, 27, GetType(System.Double), esSystemType.Double)
            c.PropertyName = FindingsMetadata.PropertyNames.MaxTemp
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RefTemp, 28, GetType(System.Double), esSystemType.Double)
            c.PropertyName = FindingsMetadata.PropertyNames.RefTemp
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RiseTemp, 29, GetType(System.Double), esSystemType.Double)
            c.PropertyName = FindingsMetadata.PropertyNames.RiseTemp
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.PreventativeMaintenance, 30, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.PreventativeMaintenance
            c.IsNullable = True
            c.Alias = "PreventativeMaintenance"
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Engineering, 31, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.Engineering
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Construction, 32, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.Construction
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Age, 33, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.Age
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.PoorCondition, 34, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.PoorCondition
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.NoTimeForMaintenance, 35, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.NoTimeForMaintenance
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.PoorMaintenance, 36, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.PoorMaintenance
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Heat, 37, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.Heat
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Water, 38, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.Water
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Vibration, 39, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.Vibration
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Contamination, 40, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.Contamination
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.NoRiskIQ, 41, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.NoRiskIQ
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.LastUpdated, 42, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.LastUpdated
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RecStatus, 43, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.RecStatus
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.StatusDate, 44, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.StatusDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ResponseFrom, 45, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.ResponseFrom
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ResponseDate, 46, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.ResponseDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ResponseComment, 47, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.ResponseComment
            c.CharacterMaxLength = 250
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ResponseStatus, 48, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.ResponseStatus
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.FollowupDate, 49, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.FollowupDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.FollowupNumber, 50, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.FollowupNumber
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RedundancySpare, 51, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.RedundancySpare
            c.CharacterMaxLength = 30
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RecPrimary, 52, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.RecPrimary
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.RecSecondary, 53, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.RecSecondary
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.IntendedAction, 54, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.IntendedAction
            c.CharacterMaxLength = 30
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.PlantComment, 55, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.PlantComment
            c.CharacterMaxLength = 8000
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.DateOfOrigination, 56, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.DateOfOrigination
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.DateOfOriginalImport, 57, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.DateOfOriginalImport
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.DateOfLastImport, 58, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.DateOfLastImport
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Id, 59, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.Id
            c.IsAutoIncrement = True
            c.NumericPrecision = 10
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.fldObject, 60, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.fldObject
            c.CharacterMaxLength = 75
            c.IsNullable = True
            c.Alias = "fldObject"
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.History, 61, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.History
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Comments, 62, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.Comments
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ExpectedCompletionDate, 63, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.ExpectedCompletionDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.EzyUserID, 64, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.EzyUserID
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.SyncId, 65, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.SyncId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.MgmtRespDate, 66, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.MgmtRespDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.MgmtRespFrom, 67, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.MgmtRespFrom
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.MgmtRespAction, 68, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.MgmtRespAction
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.MgmtRespComment, 69, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.MgmtRespComment
            c.CharacterMaxLength = 2147483647
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.CommentsID, 70, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.CommentsID
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Exported, 71, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = FindingsMetadata.PropertyNames.Exported
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.Kfts, 72, GetType(System.Byte()), esSystemType.ByteArray)
            c.PropertyName = FindingsMetadata.PropertyNames.Kfts
            c.CharacterMaxLength = 8
            c.IsNullable = True
            c.IsComputed = True
            c.IsConcurrency = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ReorderNumber, 73, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = FindingsMetadata.PropertyNames.ReorderNumber
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.TimeData, 74, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.TimeData
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ThirdLevelRespDate, 75, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = FindingsMetadata.PropertyNames.ThirdLevelRespDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ThirdLevelRespFrom, 76, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.ThirdLevelRespFrom
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ThirdLevelRespAction, 77, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.ThirdLevelRespAction
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.ThirdLevelRespComment, 78, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.ThirdLevelRespComment
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(FindingsMetadata.ColumnNames.UpdateBy, 79, GetType(System.String), esSystemType.String)
            c.PropertyName = FindingsMetadata.PropertyNames.UpdateBy
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

        End Sub
#End Region

        Public Shared Function Meta() As FindingsMetadata
            Return _meta
        End Function

        Public ReadOnly Property DataID() As System.Guid Implements IMetadata.DataID
            Get
                Return MyBase.m_dataID
            End Get
        End Property

        Public ReadOnly Property MultiProviderMode() As Boolean Implements IMetadata.MultiProviderMode
            Get
                Return False
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
            Public Const RecMonth As String = "RecMonth"
            Public Const RecNumber As String = "RecNumber"
            Public Const RecYear As String = "RecYear"
            Public Const fldArc As String = "Arc#"
            Public Const Reportid As String = "reportid"
            Public Const Findingno As String = "findingno"
            Public Const Itemno As String = "itemno"
            Public Const Severityrating As String = "severityrating"
            Public Const ProbableCause As String = "ProbableCause"
            Public Const ProbableCauseID As String = "ProbableCauseID"
            Public Const Recommendation As String = "Recommendation"
            Public Const RecommendationID As String = "RecommendationID"
            Public Const SpecItem As String = "SpecItem"
            Public Const SpecItemID As String = "SpecItemID"
            Public Const SpecItemDetail As String = "SpecItemDetail"
            Public Const SpecItemDetailID As String = "SpecItemDetailID"
            Public Const FindEquip As String = "FindEquip"
            Public Const fldLoad As String = "Load"
            Public Const PlantAreaAffected As String = "PlantAreaAffected"
            Public Const FaultType As String = "FaultType"
            Public Const ProbableEquipmentDamageCost As String = "ProbableEquipmentDamageCost"
            Public Const LengthOfBusinessInterruption As String = "LenghtOfBusinessInterruption"
            Public Const CostOfBusinessInterruption As String = "CostOfBusinessInterruption"
            Public Const DetectedWith As String = "DetectedWith"
            Public Const Impact As String = "Impact"
            Public Const Comments2 As String = "Comments2"
            Public Const MaxTemp As String = "MaxTemp"
            Public Const RefTemp As String = "RefTemp"
            Public Const RiseTemp As String = "RiseTemp"
            Public Const PreventativeMaintenance As String = "PrevenativeMaintenance"
            Public Const Engineering As String = "Engineering"
            Public Const Construction As String = "Construction"
            Public Const Age As String = "Age"
            Public Const PoorCondition As String = "PoorCondition"
            Public Const NoTimeForMaintenance As String = "NoTimeForMaintenance"
            Public Const PoorMaintenance As String = "PoorMaintenance"
            Public Const Heat As String = "Heat"
            Public Const Water As String = "Water"
            Public Const Vibration As String = "Vibration"
            Public Const Contamination As String = "Contamination"
            Public Const NoRiskIQ As String = "NoRiskIQ"
            Public Const LastUpdated As String = "LastUpdated"
            Public Const RecStatus As String = "RecStatus"
            Public Const StatusDate As String = "StatusDate"
            Public Const ResponseFrom As String = "ResponseFrom"
            Public Const ResponseDate As String = "ResponseDate"
            Public Const ResponseComment As String = "ResponseComment"
            Public Const ResponseStatus As String = "ResponseStatus"
            Public Const FollowupDate As String = "FollowupDate"
            Public Const FollowupNumber As String = "FollowupNumber"
            Public Const RedundancySpare As String = "RedundancySpare"
            Public Const RecPrimary As String = "RecPrimary"
            Public Const RecSecondary As String = "RecSecondary"
            Public Const IntendedAction As String = "IntendedAction"
            Public Const PlantComment As String = "PlantComment"
            Public Const DateOfOrigination As String = "DateOfOrigination"
            Public Const DateOfOriginalImport As String = "DateOfOriginalImport"
            Public Const DateOfLastImport As String = "DateOfLastImport"
            Public Const Id As String = "ID"
            Public Const fldObject As String = "Object"
            Public Const History As String = "History"
            Public Const Comments As String = "Comments"
            Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
            Public Const EzyUserID As String = "EzyUserID"
            Public Const SyncId As String = "SyncId"
            Public Const MgmtRespDate As String = "MgmtRespDate"
            Public Const MgmtRespFrom As String = "MgmtRespFrom"
            Public Const MgmtRespAction As String = "MgmtRespAction"
            Public Const MgmtRespComment As String = "MgmtRespComment"
            Public Const CommentsID As String = "CommentsID"
            Public Const Exported As String = "Exported"
            Public Const Kfts As String = "KFTS"
            Public Const ReorderNumber As String = "ReorderNumber"
            Public Const TimeData As String = "TimeData"
            Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
            Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
            Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
            Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
            Public Const UpdateBy As String = "UpdateBy"
        End Class
#End Region

#Region "PropertyNames"
        Public Class PropertyNames
            Public Const FileNo As String = "FileNo"
            Public Const RecMonth As String = "RecMonth"
            Public Const RecNumber As String = "RecNumber"
            Public Const RecYear As String = "RecYear"
            Public Const fldArc As String = "fldArc"
            Public Const Reportid As String = "Reportid"
            Public Const Findingno As String = "Findingno"
            Public Const Itemno As String = "Itemno"
            Public Const Severityrating As String = "Severityrating"
            Public Const ProbableCause As String = "ProbableCause"
            Public Const ProbableCauseID As String = "ProbableCauseID"
            Public Const Recommendation As String = "Recommendation"
            Public Const RecommendationID As String = "RecommendationID"
            Public Const SpecItem As String = "SpecItem"
            Public Const SpecItemID As String = "SpecItemID"
            Public Const SpecItemDetail As String = "SpecItemDetail"
            Public Const SpecItemDetailID As String = "SpecItemDetailID"
            Public Const FindEquip As String = "FindEquip"
            Public Const fldLoad As String = "fldLoad"
            Public Const PlantAreaAffected As String = "PlantAreaAffected"
            Public Const FaultType As String = "FaultType"
            Public Const ProbableEquipmentDamageCost As String = "ProbableEquipmentDamageCost"
            Public Const LengthOfBusinessInterruption As String = "LengthOfBusinessInterruption"
            Public Const CostOfBusinessInterruption As String = "CostOfBusinessInterruption"
            Public Const DetectedWith As String = "DetectedWith"
            Public Const Impact As String = "Impact"
            Public Const Comments2 As String = "Comments2"
            Public Const MaxTemp As String = "MaxTemp"
            Public Const RefTemp As String = "RefTemp"
            Public Const RiseTemp As String = "RiseTemp"
            Public Const PreventativeMaintenance As String = "PreventativeMaintenance"
            Public Const Engineering As String = "Engineering"
            Public Const Construction As String = "Construction"
            Public Const Age As String = "Age"
            Public Const PoorCondition As String = "PoorCondition"
            Public Const NoTimeForMaintenance As String = "NoTimeForMaintenance"
            Public Const PoorMaintenance As String = "PoorMaintenance"
            Public Const Heat As String = "Heat"
            Public Const Water As String = "Water"
            Public Const Vibration As String = "Vibration"
            Public Const Contamination As String = "Contamination"
            Public Const NoRiskIQ As String = "NoRiskIQ"
            Public Const LastUpdated As String = "LastUpdated"
            Public Const RecStatus As String = "RecStatus"
            Public Const StatusDate As String = "StatusDate"
            Public Const ResponseFrom As String = "ResponseFrom"
            Public Const ResponseDate As String = "ResponseDate"
            Public Const ResponseComment As String = "ResponseComment"
            Public Const ResponseStatus As String = "ResponseStatus"
            Public Const FollowupDate As String = "FollowupDate"
            Public Const FollowupNumber As String = "FollowupNumber"
            Public Const RedundancySpare As String = "RedundancySpare"
            Public Const RecPrimary As String = "RecPrimary"
            Public Const RecSecondary As String = "RecSecondary"
            Public Const IntendedAction As String = "IntendedAction"
            Public Const PlantComment As String = "PlantComment"
            Public Const DateOfOrigination As String = "DateOfOrigination"
            Public Const DateOfOriginalImport As String = "DateOfOriginalImport"
            Public Const DateOfLastImport As String = "DateOfLastImport"
            Public Const Id As String = "Id"
            Public Const fldObject As String = "fldObject"
            Public Const History As String = "History"
            Public Const Comments As String = "Comments"
            Public Const ExpectedCompletionDate As String = "ExpectedCompletionDate"
            Public Const EzyUserID As String = "EzyUserID"
            Public Const SyncId As String = "SyncId"
            Public Const MgmtRespDate As String = "MgmtRespDate"
            Public Const MgmtRespFrom As String = "MgmtRespFrom"
            Public Const MgmtRespAction As String = "MgmtRespAction"
            Public Const MgmtRespComment As String = "MgmtRespComment"
            Public Const CommentsID As String = "CommentsID"
            Public Const Exported As String = "Exported"
            Public Const Kfts As String = "Kfts"
            Public Const ReorderNumber As String = "ReorderNumber"
            Public Const TimeData As String = "TimeData"
            Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
            Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
            Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
            Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
            Public Const UpdateBy As String = "UpdateBy"
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
            SyncLock GetType(FindingsMetadata)

                If FindingsMetadata.mapDelegates Is Nothing Then
                    FindingsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
                End If

                If FindingsMetadata._meta Is Nothing Then
                    FindingsMetadata._meta = New FindingsMetadata()
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



                meta.AddTypeMap("FileNo", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("RecMonth", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecNumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("RecYear", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("fldArc", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("Reportid", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Findingno", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("Itemno", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Severityrating", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("ProbableCause", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("ProbableCauseID", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Recommendation", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecommendationID", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("SpecItem", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("SpecItemID", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("SpecItemDetail", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("SpecItemDetailID", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("FindEquip", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("fldLoad", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("PlantAreaAffected", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("FaultType", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("ProbableEquipmentDamageCost", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("LengthOfBusinessInterruption", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("CostOfBusinessInterruption", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("DetectedWith", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("Impact", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("Comments2", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("MaxTemp", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("RefTemp", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("RiseTemp", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("PreventativeMaintenance", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("Engineering", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("Construction", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("Age", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("PoorCondition", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("NoTimeForMaintenance", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("PoorMaintenance", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("Heat", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("Water", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("Vibration", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("Contamination", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("NoRiskIQ", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("LastUpdated", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("RecStatus", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("StatusDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("ResponseFrom", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("ResponseDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("ResponseComment", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("ResponseStatus", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("FollowupDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("FollowupNumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("RedundancySpare", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecPrimary", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecSecondary", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("IntendedAction", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("PlantComment", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("DateOfOrigination", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("DateOfOriginalImport", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("DateOfLastImport", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("Id", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("fldObject", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("History", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("Comments", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("ExpectedCompletionDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("EzyUserID", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("SyncId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("MgmtRespDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("MgmtRespFrom", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("MgmtRespAction", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("MgmtRespComment", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("CommentsID", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("Exported", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("Kfts", New esTypeMap("timestamp", "System.Byte()"))
                meta.AddTypeMap("ReorderNumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("TimeData", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("ThirdLevelRespDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("ThirdLevelRespFrom", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("ThirdLevelRespAction", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("ThirdLevelRespComment", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("UpdateBy", New esTypeMap("nvarchar", "System.String"))

                meta.Schema = "dbo"

                meta.Source = "Findings"
                meta.Destination = "Findings"

                meta.spInsert = "proc_FindingsInsert"
                meta.spUpdate = "proc_FindingsUpdate"
                meta.spDelete = "proc_FindingsDelete"
                meta.spLoadAll = "proc_FindingsLoadAll"
                meta.spLoadByPrimaryKey = "proc_FindingsLoadByPrimaryKey"

                Me.m_providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me.m_providerMetadataMaps("esDefault")

        End Function

#End Region

        Private Shared _meta As FindingsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
        Private Shared _esDefault As Integer = RegisterDelegateesDefault()

    End Class

End Namespace
