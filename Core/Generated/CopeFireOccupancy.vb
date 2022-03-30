
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/29/2020 10:01:40 AM
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
    ' Encapsulates the 'Cope-FireOccupancy' table
    ' </summary>

    <System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _
    <Serializable> _
    <DataContract> _
    <KnownType(GetType(CopeFireOccupancy))> _
    <XmlType("CopeFireOccupancy")> _
    Partial Public Class CopeFireOccupancy
        Inherits esCopeFireOccupancy

        <DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _
        Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
            Get
                Return MyBase.Debug
            End Get
        End Property

        Public Overrides Function CreateInstance() As esEntity
            Return New CopeFireOccupancy()
        End Function

#Region "Static Quick Access Methods"
        Public Shared Sub Delete(ByVal id As System.Int32)
            Dim obj As New CopeFireOccupancy()
            obj.Id = id
            obj.AcceptChanges()
            obj.MarkAsDeleted()
            obj.Save()
        End Sub

        Public Shared Sub Delete(ByVal id As System.Int32, ByVal sqlAccessType As esSqlAccessType)
            Dim obj As New CopeFireOccupancy()
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
    <XmlType("CopeFireOccupancyCollection")> _
    Partial Public Class CopeFireOccupancyCollection
        Inherits esCopeFireOccupancyCollection
        Implements IEnumerable(Of CopeFireOccupancy)

        Public Function FindByPrimaryKey(ByVal id As System.Int32) As CopeFireOccupancy
            Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
        End Function



#Region "WCF Service Class"

        <DataContract> _
        <KnownType(GetType(CopeFireOccupancy))> _
        Public Class CopeFireOccupancyCollectionWCFPacket
            Inherits esCollectionWCFPacket(Of CopeFireOccupancyCollection)

            Public Shared Widening Operator CType(packet As CopeFireOccupancyCollectionWCFPacket) As CopeFireOccupancyCollection
                Return packet.Collection
            End Operator

            Public Shared Widening Operator CType(collection As CopeFireOccupancyCollection) As CopeFireOccupancyCollectionWCFPacket
                Return New CopeFireOccupancyCollectionWCFPacket() With {.Collection = collection}
            End Operator

        End Class

#End Region



    End Class




    <DebuggerDisplay("Query = {Parse()}")> _
    <Serializable> _
    Partial Public Class CopeFireOccupancyQuery
        Inherits esCopeFireOccupancyQuery

        Public Sub New(ByVal joinAlias As String)
            Me.es.JoinAlias = joinAlias
        End Sub

        Protected Overrides Function GetQueryName() As String
            Return "CopeFireOccupancyQuery"
        End Function

#Region "Explicit Casts"

        Public Shared Narrowing Operator CType(ByVal query As CopeFireOccupancyQuery) As String
            Return CopeFireOccupancyQuery.SerializeHelper.ToXml(query)
        End Operator

        Public Shared Narrowing Operator CType(ByVal query As String) As CopeFireOccupancyQuery
            Return DirectCast(CopeFireOccupancyQuery.SerializeHelper.FromXml(query, GetType(CopeFireOccupancyQuery)), CopeFireOccupancyQuery)
        End Operator

#End Region

    End Class


    <DataContract> _
    <Serializable()> _
    Partial Public MustInherit Class esCopeFireOccupancy
        Inherits esEntity
        Implements INotifyPropertyChanged

        Public Sub New()

        End Sub

#Region "LoadByPrimaryKey"
        Public Overridable Function LoadByPrimaryKey(ByVal id As System.Int32) As Boolean

            If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic(id)
            Else
                Return LoadByPrimaryKeyStoredProcedure(id)
            End If

        End Function

        Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Int32) As Boolean

            If sqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic(id)
            Else
                Return LoadByPrimaryKeyStoredProcedure(id)
            End If

        End Function

        Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Int32) As Boolean

            Dim query As New CopeFireOccupancyQuery()
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
        ' Maps to Cope-FireOccupancy.ID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Id As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(CopeFireOccupancyMetadata.ColumnNames.Id)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(CopeFireOccupancyMetadata.ColumnNames.Id, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.Id)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.FileNo
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FileNo As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.FileNo)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.FileNo, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.FileNo)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.IndustryGroup
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property IndustryGroup As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.IndustryGroup)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.IndustryGroup, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.IndustryGroup)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.MajorGroup
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MajorGroup As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.MajorGroup)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.MajorGroup, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.MajorGroup)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.SpecificGroup
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SpecificGroup As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.SpecificGroup)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.SpecificGroup, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.SpecificGroup)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.SICCode
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SICCode As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.SICCode)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.SICCode, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.SICCode)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.HoursDay
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property HoursDay As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.HoursDay)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.HoursDay, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.HoursDay)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.DaysWeek
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property DaysWeek As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.DaysWeek)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.DaysWeek, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.DaysWeek)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.NumberOfEmployees
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NumberOfEmployees As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(CopeFireOccupancyMetadata.ColumnNames.NumberOfEmployees)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(CopeFireOccupancyMetadata.ColumnNames.NumberOfEmployees, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.NumberOfEmployees)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.PercentManufacturing
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PercentManufacturing As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentManufacturing)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentManufacturing, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentManufacturing)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.PercentWholesaleDistStge
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PercentWholesaleDistStge As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentWholesaleDistStge)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentWholesaleDistStge, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentWholesaleDistStge)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.PercentOffice
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PercentOffice As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentOffice)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentOffice, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentOffice)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.PercentRetail
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PercentRetail As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentRetail)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentRetail, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentRetail)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.PercentOther
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PercentOther As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentOther)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.PercentOther, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentOther)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.BriefDescriptionOfOperationsAndProductsManufactured
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property BriefDescriptionOfOperationsAndProductsManufactured As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.BriefDescriptionOfOperationsAndProductsManufactured)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.BriefDescriptionOfOperationsAndProductsManufactured, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.BriefDescriptionOfOperationsAndProductsManufactured)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.OccupancyHazardClassification
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property OccupancyHazardClassification As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyHazardClassification)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyHazardClassification, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.OccupancyHazardClassification)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.PredominantIndoorStorageType
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PredominantIndoorStorageType As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.PredominantIndoorStorageType)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.PredominantIndoorStorageType, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PredominantIndoorStorageType)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.CommodityType
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property CommodityType As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.CommodityType)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.CommodityType, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.CommodityType)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.MaxStgeHeight
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MaxStgeHeight As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.MaxStgeHeight)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(CopeFireOccupancyMetadata.ColumnNames.MaxStgeHeight, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.MaxStgeHeight)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.CommodityDescription
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property CommodityDescription As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.CommodityDescription)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.CommodityDescription, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.CommodityDescription)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.SpecialHazardsDesription
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SpecialHazardsDesription As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.SpecialHazardsDesription)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.SpecialHazardsDesription, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.SpecialHazardsDesription)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.OccupancyUser1
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property OccupancyUser1 As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser1)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser1, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.OccupancyUser1)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.OccupancyUser2
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property OccupancyUser2 As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser2)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser2, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.OccupancyUser2)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.OccupancyUser3
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property OccupancyUser3 As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser3)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser3, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.OccupancyUser3)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to Cope-FireOccupancy.OccupancyUser4
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property OccupancyUser4 As System.String
            Get
                Return MyBase.GetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser4)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser4, value) Then
                    OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.OccupancyUser4)
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

                        Case "Id"
                            Me.str().Id = CType(value, String)

                        Case "FileNo"
                            Me.str().FileNo = CType(value, String)

                        Case "IndustryGroup"
                            Me.str().IndustryGroup = CType(value, String)

                        Case "MajorGroup"
                            Me.str().MajorGroup = CType(value, String)

                        Case "SpecificGroup"
                            Me.str().SpecificGroup = CType(value, String)

                        Case "SICCode"
                            Me.str().SICCode = CType(value, String)

                        Case "HoursDay"
                            Me.str().HoursDay = CType(value, String)

                        Case "DaysWeek"
                            Me.str().DaysWeek = CType(value, String)

                        Case "NumberOfEmployees"
                            Me.str().NumberOfEmployees = CType(value, String)

                        Case "PercentManufacturing"
                            Me.str().PercentManufacturing = CType(value, String)

                        Case "PercentWholesaleDistStge"
                            Me.str().PercentWholesaleDistStge = CType(value, String)

                        Case "PercentOffice"
                            Me.str().PercentOffice = CType(value, String)

                        Case "PercentRetail"
                            Me.str().PercentRetail = CType(value, String)

                        Case "PercentOther"
                            Me.str().PercentOther = CType(value, String)

                        Case "BriefDescriptionOfOperationsAndProductsManufactured"
                            Me.str().BriefDescriptionOfOperationsAndProductsManufactured = CType(value, String)

                        Case "OccupancyHazardClassification"
                            Me.str().OccupancyHazardClassification = CType(value, String)

                        Case "PredominantIndoorStorageType"
                            Me.str().PredominantIndoorStorageType = CType(value, String)

                        Case "CommodityType"
                            Me.str().CommodityType = CType(value, String)

                        Case "MaxStgeHeight"
                            Me.str().MaxStgeHeight = CType(value, String)

                        Case "CommodityDescription"
                            Me.str().CommodityDescription = CType(value, String)

                        Case "SpecialHazardsDesription"
                            Me.str().SpecialHazardsDesription = CType(value, String)

                        Case "OccupancyUser1"
                            Me.str().OccupancyUser1 = CType(value, String)

                        Case "OccupancyUser2"
                            Me.str().OccupancyUser2 = CType(value, String)

                        Case "OccupancyUser3"
                            Me.str().OccupancyUser3 = CType(value, String)

                        Case "OccupancyUser4"
                            Me.str().OccupancyUser4 = CType(value, String)

                    End Select

                Else

                    Select Case name

                        Case "Id"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.Id = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.Id)
                            End If

                        Case "HoursDay"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.HoursDay = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.HoursDay)
                            End If

                        Case "DaysWeek"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.DaysWeek = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.DaysWeek)
                            End If

                        Case "NumberOfEmployees"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NumberOfEmployees = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.NumberOfEmployees)
                            End If

                        Case "PercentManufacturing"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.PercentManufacturing = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentManufacturing)
                            End If

                        Case "PercentWholesaleDistStge"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.PercentWholesaleDistStge = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentWholesaleDistStge)
                            End If

                        Case "PercentOffice"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.PercentOffice = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentOffice)
                            End If

                        Case "PercentRetail"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.PercentRetail = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentRetail)
                            End If

                        Case "PercentOther"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.PercentOther = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.PercentOther)
                            End If

                        Case "MaxStgeHeight"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.MaxStgeHeight = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(CopeFireOccupancyMetadata.PropertyNames.MaxStgeHeight)
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

            Public Sub New(ByVal entity As esCopeFireOccupancy)
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

                Set(ByVal Value As System.String)
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

            Public Property IndustryGroup As System.String
                Get
                    Dim data_ As System.String = entity.IndustryGroup

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
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

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
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

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SpecificGroup = Nothing
                    Else
                        entity.SpecificGroup = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property SICCode As System.String
                Get
                    Dim data_ As System.String = entity.SICCode

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SICCode = Nothing
                    Else
                        entity.SICCode = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property HoursDay As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.HoursDay

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.HoursDay = Nothing
                    Else
                        entity.HoursDay = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property DaysWeek As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.DaysWeek

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.DaysWeek = Nothing
                    Else
                        entity.DaysWeek = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property NumberOfEmployees As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NumberOfEmployees

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NumberOfEmployees = Nothing
                    Else
                        entity.NumberOfEmployees = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property PercentManufacturing As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.PercentManufacturing

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PercentManufacturing = Nothing
                    Else
                        entity.PercentManufacturing = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property PercentWholesaleDistStge As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.PercentWholesaleDistStge

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PercentWholesaleDistStge = Nothing
                    Else
                        entity.PercentWholesaleDistStge = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property PercentOffice As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.PercentOffice

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PercentOffice = Nothing
                    Else
                        entity.PercentOffice = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property PercentRetail As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.PercentRetail

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PercentRetail = Nothing
                    Else
                        entity.PercentRetail = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property PercentOther As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.PercentOther

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PercentOther = Nothing
                    Else
                        entity.PercentOther = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property BriefDescriptionOfOperationsAndProductsManufactured As System.String
                Get
                    Dim data_ As System.String = entity.BriefDescriptionOfOperationsAndProductsManufactured

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.BriefDescriptionOfOperationsAndProductsManufactured = Nothing
                    Else
                        entity.BriefDescriptionOfOperationsAndProductsManufactured = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property OccupancyHazardClassification As System.String
                Get
                    Dim data_ As System.String = entity.OccupancyHazardClassification

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.OccupancyHazardClassification = Nothing
                    Else
                        entity.OccupancyHazardClassification = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property PredominantIndoorStorageType As System.String
                Get
                    Dim data_ As System.String = entity.PredominantIndoorStorageType

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PredominantIndoorStorageType = Nothing
                    Else
                        entity.PredominantIndoorStorageType = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property CommodityType As System.String
                Get
                    Dim data_ As System.String = entity.CommodityType

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.CommodityType = Nothing
                    Else
                        entity.CommodityType = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property MaxStgeHeight As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.MaxStgeHeight

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.MaxStgeHeight = Nothing
                    Else
                        entity.MaxStgeHeight = Convert.ToDouble(Value)
                    End If
                End Set
            End Property

            Public Property CommodityDescription As System.String
                Get
                    Dim data_ As System.String = entity.CommodityDescription

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.CommodityDescription = Nothing
                    Else
                        entity.CommodityDescription = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property SpecialHazardsDesription As System.String
                Get
                    Dim data_ As System.String = entity.SpecialHazardsDesription

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SpecialHazardsDesription = Nothing
                    Else
                        entity.SpecialHazardsDesription = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property OccupancyUser1 As System.String
                Get
                    Dim data_ As System.String = entity.OccupancyUser1

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.OccupancyUser1 = Nothing
                    Else
                        entity.OccupancyUser1 = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property OccupancyUser2 As System.String
                Get
                    Dim data_ As System.String = entity.OccupancyUser2

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.OccupancyUser2 = Nothing
                    Else
                        entity.OccupancyUser2 = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property OccupancyUser3 As System.String
                Get
                    Dim data_ As System.String = entity.OccupancyUser3

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.OccupancyUser3 = Nothing
                    Else
                        entity.OccupancyUser3 = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property OccupancyUser4 As System.String
                Get
                    Dim data_ As System.String = entity.OccupancyUser4

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.OccupancyUser4 = Nothing
                    Else
                        entity.OccupancyUser4 = Convert.ToString(Value)
                    End If
                End Set
            End Property


            Private entity As esCopeFireOccupancy
        End Class


        <NonSerialized> _
        <IgnoreDataMember> _
              Private _esstrings As esStrings

#End Region

#Region "Housekeeping methods"

        Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return CopeFireOccupancyMetadata.Meta()
            End Get
        End Property

#End Region

#Region "Query Logic"

        Public ReadOnly Property Query() As CopeFireOccupancyQuery
            Get
                If Me.m_query Is Nothing Then
                    Me.m_query = New CopeFireOccupancyQuery()
                    InitQuery(Me.m_query)
                End If

                Return Me.m_query
            End Get
        End Property

        Public Overloads Function Load(ByVal query As CopeFireOccupancyQuery) As Boolean
            Me.m_query = query
            InitQuery(Me.m_query)
            Return Me.Query.Load()
        End Function

        Protected Sub InitQuery(ByVal query As CopeFireOccupancyQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded

            If Not query.es2.HasConnection Then
                query.es2.Connection = DirectCast(Me, IEntity).Connection
            End If
        End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CopeFireOccupancyQuery

    End Class



    <Serializable()> _
    Partial Public MustInherit Class esCopeFireOccupancyCollection
        Inherits esEntityCollection(Of CopeFireOccupancy)

#Region "Housekeeping methods"
        Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return CopeFireOccupancyMetadata.Meta()
            End Get
        End Property

        Protected Overloads Overrides Function GetCollectionName() As String
            Return "CopeFireOccupancyCollection"
        End Function

#End Region

#Region "Query Logic"


        <BrowsableAttribute(False)> _
        Public ReadOnly Property Query() As CopeFireOccupancyQuery
            Get
                If Me.m_query Is Nothing Then
                    Me.m_query = New CopeFireOccupancyQuery()
                    InitQuery(Me.m_query)
                End If

                Return Me.m_query
            End Get
        End Property

        Public Overloads Function Load(ByVal query As CopeFireOccupancyQuery) As Boolean
            Me.m_query = query
            InitQuery(Me.m_query)
            Return Query.Load()
        End Function

        Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
            If Me.m_query Is Nothing Then
                Me.m_query = New CopeFireOccupancyQuery()
                Me.InitQuery(m_query)
            End If
            Return Me.m_query
        End Function

        Protected Sub InitQuery(ByVal query As CopeFireOccupancyQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded

            If Not query.es2.HasConnection Then
                query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
            End If
        End Sub

        Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
            Me.InitQuery(DirectCast(query, CopeFireOccupancyQuery))
        End Sub

#End Region

        Private m_query As CopeFireOccupancyQuery
    End Class



    <Serializable> _
    Partial Public MustInherit Class esCopeFireOccupancyQuery
        Inherits esDynamicQuery

        Protected Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return CopeFireOccupancyMetadata.Meta()
            End Get
        End Property

#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
                Case "Id"
                    Return Me.Id
                Case "FileNo"
                    Return Me.FileNo
                Case "IndustryGroup"
                    Return Me.IndustryGroup
                Case "MajorGroup"
                    Return Me.MajorGroup
                Case "SpecificGroup"
                    Return Me.SpecificGroup
                Case "SICCode"
                    Return Me.SICCode
                Case "HoursDay"
                    Return Me.HoursDay
                Case "DaysWeek"
                    Return Me.DaysWeek
                Case "NumberOfEmployees"
                    Return Me.NumberOfEmployees
                Case "PercentManufacturing"
                    Return Me.PercentManufacturing
                Case "PercentWholesaleDistStge"
                    Return Me.PercentWholesaleDistStge
                Case "PercentOffice"
                    Return Me.PercentOffice
                Case "PercentRetail"
                    Return Me.PercentRetail
                Case "PercentOther"
                    Return Me.PercentOther
                Case "BriefDescriptionOfOperationsAndProductsManufactured"
                    Return Me.BriefDescriptionOfOperationsAndProductsManufactured
                Case "OccupancyHazardClassification"
                    Return Me.OccupancyHazardClassification
                Case "PredominantIndoorStorageType"
                    Return Me.PredominantIndoorStorageType
                Case "CommodityType"
                    Return Me.CommodityType
                Case "MaxStgeHeight"
                    Return Me.MaxStgeHeight
                Case "CommodityDescription"
                    Return Me.CommodityDescription
                Case "SpecialHazardsDesription"
                    Return Me.SpecialHazardsDesription
                Case "OccupancyUser1"
                    Return Me.OccupancyUser1
                Case "OccupancyUser2"
                    Return Me.OccupancyUser2
                Case "OccupancyUser3"
                    Return Me.OccupancyUser3
                Case "OccupancyUser4"
                    Return Me.OccupancyUser4
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region

#Region "esQueryItems"


        Public ReadOnly Property Id As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.Id, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property FileNo As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.FileNo, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property IndustryGroup As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.IndustryGroup, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property MajorGroup As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.MajorGroup, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property SpecificGroup As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.SpecificGroup, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property SICCode As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.SICCode, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property HoursDay As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.HoursDay, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property DaysWeek As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.DaysWeek, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property NumberOfEmployees As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.NumberOfEmployees, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property PercentManufacturing As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.PercentManufacturing, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property PercentWholesaleDistStge As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.PercentWholesaleDistStge, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property PercentOffice As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.PercentOffice, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property PercentRetail As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.PercentRetail, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property PercentOther As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.PercentOther, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property BriefDescriptionOfOperationsAndProductsManufactured As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.BriefDescriptionOfOperationsAndProductsManufactured, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property OccupancyHazardClassification As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.OccupancyHazardClassification, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property PredominantIndoorStorageType As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.PredominantIndoorStorageType, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property CommodityType As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.CommodityType, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property MaxStgeHeight As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.MaxStgeHeight, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property CommodityDescription As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.CommodityDescription, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property SpecialHazardsDesription As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.SpecialHazardsDesription, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property OccupancyUser1 As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.OccupancyUser1, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property OccupancyUser2 As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.OccupancyUser2, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property OccupancyUser3 As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.OccupancyUser3, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property OccupancyUser4 As esQueryItem
            Get
                Return New esQueryItem(Me, CopeFireOccupancyMetadata.ColumnNames.OccupancyUser4, esSystemType.String)
            End Get
        End Property

#End Region

    End Class



    Partial Public Class CopeFireOccupancy
        Inherits esCopeFireOccupancy




    End Class




    <Serializable> _
    Partial Public Class CopeFireOccupancyMetadata
        Inherits esMetadata
        Implements IMetadata

#Region "Protected Constructor"
        Protected Sub New()
            m_columns = New esColumnMetadataCollection()
            Dim c As esColumnMetadata

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.Id
            c.IsInPrimaryKey = True
            c.IsAutoIncrement = True
            c.NumericPrecision = 10
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.FileNo, 1, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.FileNo
            c.CharacterMaxLength = 9
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.IndustryGroup, 2, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.IndustryGroup
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.MajorGroup, 3, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.MajorGroup
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.SpecificGroup, 4, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.SpecificGroup
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.SICCode, 5, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.SICCode
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.HoursDay, 6, GetType(System.Double), esSystemType.Double)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.HoursDay
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.DaysWeek, 7, GetType(System.Double), esSystemType.Double)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.DaysWeek
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.NumberOfEmployees, 8, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.NumberOfEmployees
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.PercentManufacturing, 9, GetType(System.Double), esSystemType.Double)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.PercentManufacturing
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.PercentWholesaleDistStge, 10, GetType(System.Double), esSystemType.Double)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.PercentWholesaleDistStge
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.PercentOffice, 11, GetType(System.Double), esSystemType.Double)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.PercentOffice
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.PercentRetail, 12, GetType(System.Double), esSystemType.Double)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.PercentRetail
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.PercentOther, 13, GetType(System.Double), esSystemType.Double)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.PercentOther
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.BriefDescriptionOfOperationsAndProductsManufactured, 14, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.BriefDescriptionOfOperationsAndProductsManufactured
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.OccupancyHazardClassification, 15, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.OccupancyHazardClassification
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.PredominantIndoorStorageType, 16, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.PredominantIndoorStorageType
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.CommodityType, 17, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.CommodityType
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.MaxStgeHeight, 18, GetType(System.Double), esSystemType.Double)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.MaxStgeHeight
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.CommodityDescription, 19, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.CommodityDescription
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.SpecialHazardsDesription, 20, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.SpecialHazardsDesription
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser1, 21, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.OccupancyUser1
            c.CharacterMaxLength = 4000
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser2, 22, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.OccupancyUser2
            c.CharacterMaxLength = 4000
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser3, 23, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.OccupancyUser3
            c.CharacterMaxLength = 4000
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(CopeFireOccupancyMetadata.ColumnNames.OccupancyUser4, 24, GetType(System.String), esSystemType.String)
            c.PropertyName = CopeFireOccupancyMetadata.PropertyNames.OccupancyUser4
            c.CharacterMaxLength = 4000
            c.IsNullable = True
            m_columns.Add(c)

        End Sub
#End Region

        Public Shared Function Meta() As CopeFireOccupancyMetadata
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
            Public Const Id As String = "ID"
            Public Const FileNo As String = "FileNo"
            Public Const IndustryGroup As String = "IndustryGroup"
            Public Const MajorGroup As String = "MajorGroup"
            Public Const SpecificGroup As String = "SpecificGroup"
            Public Const SICCode As String = "SICCode"
            Public Const HoursDay As String = "HoursDay"
            Public Const DaysWeek As String = "DaysWeek"
            Public Const NumberOfEmployees As String = "NumberOfEmployees"
            Public Const PercentManufacturing As String = "PercentManufacturing"
            Public Const PercentWholesaleDistStge As String = "PercentWholesaleDistStge"
            Public Const PercentOffice As String = "PercentOffice"
            Public Const PercentRetail As String = "PercentRetail"
            Public Const PercentOther As String = "PercentOther"
            Public Const BriefDescriptionOfOperationsAndProductsManufactured As String = "BriefDescriptionOfOperationsAndProductsManufactured"
            Public Const OccupancyHazardClassification As String = "OccupancyHazardClassification"
            Public Const PredominantIndoorStorageType As String = "PredominantIndoorStorageType"
            Public Const CommodityType As String = "CommodityType"
            Public Const MaxStgeHeight As String = "MaxStgeHeight"
            Public Const CommodityDescription As String = "CommodityDescription"
            Public Const SpecialHazardsDesription As String = "SpecialHazardsDesription"
            Public Const OccupancyUser1 As String = "OccupancyUser1"
            Public Const OccupancyUser2 As String = "OccupancyUser2"
            Public Const OccupancyUser3 As String = "OccupancyUser3"
            Public Const OccupancyUser4 As String = "OccupancyUser4"
        End Class
#End Region

#Region "PropertyNames"
        Public Class PropertyNames
            Public Const Id As String = "Id"
            Public Const FileNo As String = "FileNo"
            Public Const IndustryGroup As String = "IndustryGroup"
            Public Const MajorGroup As String = "MajorGroup"
            Public Const SpecificGroup As String = "SpecificGroup"
            Public Const SICCode As String = "SICCode"
            Public Const HoursDay As String = "HoursDay"
            Public Const DaysWeek As String = "DaysWeek"
            Public Const NumberOfEmployees As String = "NumberOfEmployees"
            Public Const PercentManufacturing As String = "PercentManufacturing"
            Public Const PercentWholesaleDistStge As String = "PercentWholesaleDistStge"
            Public Const PercentOffice As String = "PercentOffice"
            Public Const PercentRetail As String = "PercentRetail"
            Public Const PercentOther As String = "PercentOther"
            Public Const BriefDescriptionOfOperationsAndProductsManufactured As String = "BriefDescriptionOfOperationsAndProductsManufactured"
            Public Const OccupancyHazardClassification As String = "OccupancyHazardClassification"
            Public Const PredominantIndoorStorageType As String = "PredominantIndoorStorageType"
            Public Const CommodityType As String = "CommodityType"
            Public Const MaxStgeHeight As String = "MaxStgeHeight"
            Public Const CommodityDescription As String = "CommodityDescription"
            Public Const SpecialHazardsDesription As String = "SpecialHazardsDesription"
            Public Const OccupancyUser1 As String = "OccupancyUser1"
            Public Const OccupancyUser2 As String = "OccupancyUser2"
            Public Const OccupancyUser3 As String = "OccupancyUser3"
            Public Const OccupancyUser4 As String = "OccupancyUser4"
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
            SyncLock GetType(CopeFireOccupancyMetadata)

                If CopeFireOccupancyMetadata.mapDelegates Is Nothing Then
                    CopeFireOccupancyMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
                End If

                If CopeFireOccupancyMetadata._meta Is Nothing Then
                    CopeFireOccupancyMetadata._meta = New CopeFireOccupancyMetadata()
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



                meta.AddTypeMap("Id", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("FileNo", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("IndustryGroup", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("MajorGroup", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("SpecificGroup", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("SICCode", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("HoursDay", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("DaysWeek", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("NumberOfEmployees", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("PercentManufacturing", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("PercentWholesaleDistStge", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("PercentOffice", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("PercentRetail", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("PercentOther", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("BriefDescriptionOfOperationsAndProductsManufactured", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("OccupancyHazardClassification", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("PredominantIndoorStorageType", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("CommodityType", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("MaxStgeHeight", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("CommodityDescription", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("SpecialHazardsDesription", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("OccupancyUser1", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("OccupancyUser2", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("OccupancyUser3", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("OccupancyUser4", New esTypeMap("nvarchar", "System.String"))



                meta.Source = "Cope-FireOccupancy"
                meta.Destination = "Cope-FireOccupancy"

                meta.spInsert = "proc_Cope-FireOccupancyInsert"
                meta.spUpdate = "proc_Cope-FireOccupancyUpdate"
                meta.spDelete = "proc_Cope-FireOccupancyDelete"
                meta.spLoadAll = "proc_Cope-FireOccupancyLoadAll"
                meta.spLoadByPrimaryKey = "proc_Cope-FireOccupancyLoadByPrimaryKey"

                Me.m_providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me.m_providerMetadataMaps("esDefault")

        End Function

#End Region

        Private Shared _meta As CopeFireOccupancyMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
        Private Shared _esDefault As Integer = RegisterDelegateesDefault()

    End Class

End Namespace
